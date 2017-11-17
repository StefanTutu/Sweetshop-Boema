
-- Returneaza Procent Tva pentru un anumit produs

CREATE OR REPLACE FUNCTION f_ProcentTVA (NUMERIC)
		RETURNS NUMERIC AS
$$
SELECT ProcentTVA FROM TVA WHERE idProdus=$1
$$ LANGUAGE SQL ;

SELECT f_ProcentTVA(2) ;

-- Returneaza Nume Angajat

CREATE OR REPLACE FUNCTION f_numeAngajat (idAngajat_ angajati.idAngajat%TYPE)
		RETURNS angajati.NumePrenAngajat% TYPE AS
$$
SELECT NumePrenAngajat FROM angajati WHERE idAngajat=$1
$$ LANGUAGE SQL ;

SELECT f_numeAngajat (1) ;

-- Returneaza detalii pentru un produs

CREATE OR REPLACE FUNCTION f_detaliiProdus (idProdus_ produse.idProdus%TYPE)
		RETURNS SETOF produse AS
$$
SELECT * FROM produse WHERE idProdus=$1
$$ LANGUAGE SQL ;

SELECT * FROM f_detaliiProdus (3) ;

-- Returneaza comenzile dintr-un interval calendaristic

CREATE OR REPLACE FUNCTION f_comenzi_filtrate 
		(data_initiala DATE, data_finala DATE)
		RETURNS SETOF comenzi AS 
$$
SELECT * FROM comenzi WHERE DataComanda BETWEEN $1 AND $2
$$ LANGUAGE SQL ;

SELECT * FROM f_comenzi_filtrate (DATE'2013/08/20', DATE'2014/10/10') ;

-- Returneaza comenzile pentru un anumit client

CREATE OR REPLACE FUNCTION f_comenzile_unui_client (CodCl_ clienti.CodCl%TYPE)
		RETURNS Table (NumeCl varchar,AdresaLivrare varchar,DataComanda Date , StatusComanda Varchar , idLivrare Numeric , IdBonFiscal Numeric) AS 
$$
SELECT NumeCl, AdresaLivrare, DataComanda, StatusComanda, idLivrare, idBonFiscal 
FROM comenzi INNER JOIN adrese_livrare ON comenzi.NrComanda=adrese_livrare.NrComanda
	     INNER JOIN clienti ON adrese_livrare.CodCl=clienti.CodCl
WHERE clienti.CodCl = $1;
$$ LANGUAGE SQL ;

SELECT * FROM f_comenzile_unui_client (1003) ;

-- Returneaza transporturile realizate de un anumit sofer

CREATE OR REPLACE FUNCTION f_transporturi_filtrate_cronologic_sofer (idSofer_ soferi.idSofer%TYPE, data_initiala DATE, data_finala DATE)
		RETURNS SETOF transporturi AS
$$
SELECT * FROM transporturi WHERE idSofer=$1 AND DataPlecare BETWEEN $2 AND $3
$$ LANGUAGE SQL ;

SELECT * FROM f_transporturi_filtrate_cronologic_sofer (3, DATE'2014/04/14', CURRENT_DATE) ;

-- Returneaza cea mai frecventa localitate de livrare

DROP FUNCTION f_vi_localitati()cascade ;

CREATE OR REPLACE FUNCTION f_vi_localitati() 
	RETURNS livrari.LocLivrare%TYPE
AS
$$
DECLARE
	v_LocLivrare livrari.LocLivrare%TYPE ;
BEGIN
	SELECT LocLivrare INTO v_LocLivrare FROM livrari GROUP BY LocLivrare
	ORDER BY COUNT(*) DESC LIMIT 1 ;

	IF v_LocLivrare IS NULL THEN
		SELECT MIN(LocLivrare) INTO v_LocLivrare FROM livrari ;
	END IF ;
	RETURN v_LocLivrare ; 
END ;
$$ LANGUAGE plpgsql ;

ALTER TABLE livrari ALTER COLUMN LocLivrare SET DEFAULT f_vi_localitati() ;

SELECT f_vi_localitati() ;

-- Update Observatii din tabela angajati

CREATE OR REPLACE FUNCTION f_update_angajati_fara_telefon() RETURNS VOID AS 
$$
	UPDATE angajati SET Observatii = COALESCE(Observatii,' ') || 'Angajatul nu are telefon !'
	WHERE Telefon NOT IN (SELECT DISTINCT Telefon FROM angajati)
		AND COALESCE(Observatii,' ') NOT LIKE '%Angajatul nu are telefon !%'
$$ LANGUAGE SQL ;

-- Stergerea unei materii prime

CREATE OR REPLACE FUNCTION f_on_delete_cascade_materie_prima (idMatPrima_ materii_prime.idMatPrima%TYPE)
		RETURNS VOID AS 
$$
	DELETE FROM reteta_produs WHERE idMatPrima = $1 ;	
	DELETE FROM materii_prime WHERE idMatPrima = $1 ;
$$ LANGUAGE SQL ;

SELECT f_on_delete_cascade_materie_prima (15) ;

-- Costuri de productie

DROP VIEW cost_productie;

CREATE VIEW cost_productie AS
SELECT produse.idProdus, DenProdus, DenMatPrima, CantMP_UnitProd, PretUnitMatPrima
FROM materii_prime INNER JOIN reteta_produs ON materii_prime.idMatPrima=reteta_produs.idMatPrima
		   INNER JOIN produse ON reteta_produs.idProdus=produse.idProdus;

CREATE OR REPLACE FUNCTION f_cost_productie (idProdus_ cost_productie.idProdus%TYPE)
		RETURNS NUMERIC AS
$$
SELECT SUM(CantMP_UnitProd*PretUnitMatPrima) AS CostProd FROM cost_productie
WHERE idProdus=$1 GROUP BY DenProdus 
$$ LANGUAGE SQL;

SELECT * FROM f_cost_productie (1);