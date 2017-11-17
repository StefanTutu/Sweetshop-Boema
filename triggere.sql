
DROP VIEW detalii_produs;

CREATE VIEW detalii_produs AS
SELECT produse.idProdus, DenProdus, DenMatPrima, CantMP_UnitProd, PretUnitMatPrima,procentTVA,max(dataModifTVA)
FROM materii_prime INNER JOIN reteta_produs ON materii_prime.idMatPrima=reteta_produs.idMatPrima
		   INNER JOIN produse ON reteta_produs.idProdus=produse.idProdus
		   INNER JOIN tva ON produse.idProdus=tva.idProdus
GROUP BY produse.idProdus,DenMatPrima,CantMP_UnitProd,PretUnitMatPrima,procentTVA
ORDER BY idProdus;


--INSERAREA in tabela produse atributele: costProductie,adoasComercial,valoareTVA

ALTER TABLE produse ADD costProductie NUMERIC (10,2);
ALTER TABLE produse ADD adaosComercial NUMERIC (10,2);
ALTER TABLE produse ADD valoareTVA NUMERIC(10,2);


UPDATE produse
	SET costProductie = (SELECT COALESCE(SUM(CantMP_UnitProd * PretUnitMatPrima),0)
			     FROM detalii_produs
			     WHERE idProdus=detalii_produs.idProdus),
	    valoareTVA = (SELECT COALESCE (SUM(CantMP_UnitProd * PretUnitMatPrima * ProcentTVA),0)
			  FROM detalii_produs
			  WHERE idProdus=detalii_produs.idProdus),
	    adaosComercial = (SELECT COALESCE (SUM((CantMP_UnitProd * PretUnitMatPrima)-(CantMP_UnitProd * PretUnitMatPrima * ProcentTVA)),0)
			       FROM detalii_produs
			       WHERE idProdus=detalii_produs.idProdus)

-- declansatorul de inserare in produse
 
DROP FUNCTION trg_produse_ins() CASCADE ;

CREATE OR REPLACE FUNCTION trg_produse_ins()
	RETURNS TRIGGER AS $trg_produse_ins$
BEGIN
	NEW.cosProductie := 0;
	NEW.valoareTVA := 0;
	NEW.adaosComercial :=0;

	RETURN NEW ;
END ;
$trg_produse_ins$ LANGUAGE plpgsql ;

CREATE TRIGGER trg_produse_ins BEFORE INSERT ON produse
	FOR EACH ROW EXECUTE PROCEDURE trg_produse_ins() ;


---
-- INSERARE in tabela angajati atributele: tipActDeIdentitate,serie,numar

ALTER TABLE angajati ADD tipActDeIdentitate CHAR (15);
ALTER TABLE angajati ADD Serie CHAR(10);
ALTER TABLE angajati ADD Numar CHAR(11);

DROP FUNCTION trg_angajati_ins() CASCADE;

CREATE OR REPLACE FUNCTION trg_angajati_ins()
	RETURNS TRIGGER AS $trg_angajati_ins$
BEGIN
	NEW.tipAtDeIdentitate :=0;
	NEW.Serie :=0;
	NEW.Numar :=0;

	RETURN NEW ;
END ;
$trg_angajati_ins$ LANGUAGE plpgsql ;

CREATE TRIGGER trg_angajati_ins BEFORE INSERT ON angajati
	FOR EACH ROW EXECUTE PROCEDURE trg_angajati_ins();


---
-- INSERARE in tabela bonuri_fiscale_vanzari

ALTER TABLE bonuri_fiscale_vanzari ADD valoareFaraTVA NUMERIC (10,2);
ALTER TABLE bonuri_fiscale_vanzari ADD valoareTVA NUMERIC(10,2);
ALTER TABLE bonuri_fiscale_vanzari ADD valoareTotala NUMERIC(10,2);

-----------
-----------
---------
-------------
--------------
-----------
---------
UPDATE bonuri_fiscale_vanzari
	SET valoareFaraTVA = (SELECT COALESCE(SUM((CantitateVanduta * PretVanzare)/(1+ProcentTVA)),2)
			      FROM bonuri_fiscale_vanzari INNER JOIN TVA ON bonuri_fiscale_vanzari.idProdus=TVA.idProdus
			      WHERE bonuri_fiscale_vanzari.idProdus=bonuri_fiscale_vanzari.idProdus),
	    valoareTVA = (SELECT COALESCE(SUM((CantitateVanduta * PretVanzare)-((CantitateVanduta * PretVanzare)/(1+ProcentTVA))),2)
			  FROM bonuri_fiscale_vanzari INNER JOIN TVA ON bonuri_fiscale_vanzari.idProdus=TVA.idProdus
			  WHERE bonuri_fiscale_vanzari.idProdus=bonuri_fiscale_vanzari.idProdus),
	    valoareTotala = (SELECT COALESCE(SUM(CantitateVanduta * PretVanzare),2)
			     FROM bonuri_fiscale_vanzari
			     WHERE bonuri_fiscale_vanzari.idProdus=bonuri_fiscale_vanzari.idProdus)


DROP FUNCTION trg_bonuri_vanzare_ins() CASCADE;

CREATE OR REPLACE FUNCTION trg_bonuri_vanzare_ins()
	RETURNS TRIGGER AS $trg_bonuri_vanzare_ins$
BEGIN
	NEW.valoareFaraTVA :=0;
	NEW.valoareTVA :=0;
	NEW.valoareTotala :=0;

	RETURN NEW ;
END ;
$trg_bonuri_vanzare_ins$ LANGUAGE plpgsql ;

CREATE TRIGGER trg_bonuri_vanzare_ins BEFORE INSERT ON bonuri_fiscale_vanzari
	FOR EACH ROW EXECUTE PROCEDURE trg_bonuri_vanzare_ins() ;



-------------------
---
-- DELETE

-- stergerea oricarui angajat



CREATE table var_pub_angajati(
	utilizator VARCHAR(40),
	tabela VARCHAR(20),
	idAngajat NUMERIC(5),
	PRIMARY KEY (utilizator,tabela,idAngajat)
);

DROP FUNCTION trg_angajati_del() CASCADE;

CREATE OR REPLACE FUNCTION trg_angajati_del()
	RETURNS TRIGGER AS $trg_angajati_del$
BEGIN
	INSERT INTO var_pub_angajati VALUES (user, 'angajati',old.idAngajat);
	
	RETURN OLD;
END;
$trg_angajati_del$ LANGUAGE plpgsql;

CREATE TRIGGER trg_angajati_del BEFORE DELETE ON angajati
	FOR EACH ROW EXECUTE PROCEDURE trg_angajati_del() ;

delete from angajati where idAngajat=5;
----------------------------------------------------------------------------------------------------------------------------------
-- stergerea oricarui transport

DROP FUNCTION trg_transporturi_del() CASCADE ;

CREATE OR REPLACE FUNCTION trg_transporturi_del()
	RETURNS TRIGGER AS $trg_transporturi_del$
BEGIN 
	DELETE FROM retururi WHERE retururi.idTransport=OLD.idTransport;
	DELETE FROM livrari WHERE livrari.idTransport=OLD.idTransport;
	DELETE FROM transporturi WHERE transporturi.idTransport=OLD.idTransport;

	RETURN OLD;
END;
$trg_transporturi_del$ LANGUAGE plpgsql;

CREATE TRIGGER trg_transporturi_del BEFORE DELETE ON transporturi
	FOR EACH ROW EXECUTE PROCEDURE trg_transporturi_del() ;

----------------------------------------------------------------------------------------------------------------------------------
-- stergerea oricarei comenzi 

DROP FUNCTION trg_comenzi_del() CASCADE ;

CREATE OR REPLACE FUNCTION trg_comenzi_del()
	RETURNS TRIGGER AS $trg_comenzi_del$
BEGIN

	IF statusComanda <> 'Anulata' THEN NULL;
	ELSE 
		UPDATE comenzi SET nrComanda=nrComanda-1 WHERE nrComanda>OLD.nrComanda;
	END IF;

	RETURN OLD;
END;
$trg_comenzi_del$ LANGUAGE plpgsql;

CREATE TRIGGER trg_comenzi_del BEFORE DELETE ON comenzi
	FOR EACH ROW EXECUTE PROCEDURE trg_comenzi_del();
----------------------------------------------------------------------------------------------------------------------------------
--------
---
-- UPDATE
DROP VIEW cantitati_productie;

CREATE VIEW cantitati_productie AS (
SELECT cantitati_comandate.idProdus,cantitati_comandate.nrComanda,cantProdusComandata,cantitati_produse.idComandaProductie,cantitateProdusa,StatusProductie
FROM cantitati_produse inner join cantitati_comandate on cantitati_produse.idProdus=cantitati_comandate.idProdus
			inner join comenzi_productie on cantitati_produse.idComandaProductie=comenzi_productie.idComandaProductie
);

----------------------------------------------------------------------------------------------------------------------------------
CREATE OR REPLACE FUNCTION f_status_productie(comenzi_productie.idComandaProductie% TYPE) 
	RETURNS comenzi_productie.statusProductie% TYPE AS 
$$
	SELECT statusProductie FROM comenzi_productie WHERE idComandaProductie=$1
$$ LANGUAGE SQL;
----------------------------------------------------------------------------------------------------------------------------------
DROP FUNCTION trg_cantitatiProductie_upd() CASCADE ;

CREATE OR REPLACE FUNCTION trg_cantitatiProductie_upd() 
	RETURNS TRIGGER AS $trg_cantitatiProductie_upd$
BEGIN
	if NEW.nrcomanda=OLD.nrComanda or NEW.cantProdusComandata = OLD.cantProdusComandata OR NEW.cantitateProdusa = OLD.cantitateProdusa THEN null;
	else
	if f_status_productie <> 'Inchisa' THEN 
	UPDATE cantitati_produse set NEW.cantitateProdusa=cantitateProdusa+cantProdusComandata ;
	end if;
	end if;
	
	RETURN NEW;
END ;
$trg_cantitatiProductie_upd$ LANGUAGE plpgsql;

CREATE TRIGGER trg_cantitatiProductie_upd AFTER INSERT ON cantitati_comandate
	FOR EACH ROW EXECUTE PROCEDURE trg_cantitatiProductie_upd();

----------------------------------------------------------------------------------------------------------------------------------
-- actualizare tabela produse

CREATE OR REPLACE FUNCTION p_variabile_publice () RETURNS VOID AS $$
BEGIN
	IF NOT EXISTS (SELECT 1 FROM pg_tables
		WHERE tablename='variabile_publice') THEN
	EXECUTE 'CREATE LOCAL TEMPORARY TABLE variabile_publice(
		variabila VARCHAR(50),
		valoare VARCHAR(50))';
	INSERT INTO variabile_publice VALUES ('v_trg_produse','false');
	INSERT INTO variabile_publice VALUES ('v_trg_bonuri,false');
	END IF;
END;
$$ LANGUAGE plpgsql;

SELECT p_variabile_publice();
----------------------------------------------------------------------------------------------------------------------------------

DROP FUNCTION trg_produse_upd() CASCADE;

CREATE OR REPLACE FUNCTION trg_produse_upd() RETURNS TRIGGER AS $trg_produse_upd$
BEGIN
	IF NEW.idProdus = OLD.idProdus THEN
		IF NEW.costProductie <> OLD.costProductie OR NEW.valoareTVA <> OLD.valoareTVA OR NEW.adaosComercial <> OLD.adaosComercial THEN
			NEW.valoareTVA := NEW.costProductie * NEW.procentTVA;
			PERFORM p_variabile_publice();
			UPDATE variabile_publice SET valoare = 'true' WHERE variabila = 'v_trg_produse';
			UPDATE produse SET valoareTVA = valoareTVA - OLD.valoareTVA + NEW.valoareTVA,
				   adaosComercial = adaosComercial - (OLD.costProductie - (OLD.costProductie * OLD.procentTVA)) + (NEW.costProductie - (NEW.costProductie * NEW.procentTVA))
			WHERE idProdus = NEW.idProdus ;
		END IF ; 
	ELSE
		PERFORM p_variabile_publice () ;
		UPDATE variabile_publice SET valoare = 'true' WHERE variabila = 'v_trg_produse' ;
		UPDATE produse SET valoareTVA = valoareTVA - OLD.valoareTVA,
				adaosComercial = adaosComercial - (OLD.costProductie - (OLD.costProductie * OLD.procentTVA))
		WHERE idProdus = OLD.idProdus;

		NEW.valoareTVA := NEW.costProductie * NEW.procentTVA;
		UPDATE produse SET valoareTVA = valoareTVA + NEW.valoareTVA,
				adaosComercial = adaosComercial + (NEW.costProductie - (NEW.costProductie * NEW.procentTVA))
		WHERE idProdus = NEW.idProdus ;
	UPDATE variabile_publice SET valoare = 'false' WHERE variabila = 'v_trg_produse';
	END IF;
	RETURN NEW ;
END ;
$trg_produse_upd$ LANGUAGE plpgsql ;

CREATE TRIGGER trg_produse_upd BEFORE INSERT ON produse
	FOR EACH ROW EXECUTE PROCEDURE trg_produse_upd () ;
----------------------------------------------------------------------------------------------------------------------------------
---actuaizare tabela bonuri fiscale comenzi


CREATE OR REPLACE FUNCTION f_var_publica (variabila_ variabile_publice.variabila%TYPE)
	RETURNS BOOLEAN AS $$
DECLARE
	v_sir VARCHAR(6) ;
BEGIN
	SELECT valoare INTO v_sir FROM variabile_publice WHERE variabila = variabila_ ;
	IF v_sir = 'true' THEN
		RETURN TRUE ;
	ELSE
		RETURN FALSE ;
	END IF;
END ;
$$LANGUAGE plpgsql ;
-----------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION trg_bonuri_upd()
	RETURNS TRIGGER AS $trg_bonuri_upd$
BEGIN
	IF NEW.idbf_comanda<>OLD.idbf_comanda OR NEW.nrliniebf_comanda<>OLD.nrliniebf_comanda THEN
		PERFORM p_variabile_publice();
		IF f_var_publica('v_trg_bonuri')  = FALSE THEN
			RAISE EXCEPTION 
				'Nu puteti modifica interactic bonul fiscal!';
		END IF;
	END IF;
	RETURN NEW;
END;
$trg_bonuri_upd$ LANGUAGE plpgsql;