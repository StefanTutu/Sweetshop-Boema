DROP TABLE IF EXISTS cantitati_produse;
DROP TABLE IF EXISTS comenzi_productie;
DROP TABLE IF EXISTS cantitati_returnate;
DROP TABLE IF EXISTS retururi;
DROP TABLE IF EXISTS incasari;
DROP TABLE IF EXISTS adrese_livrare;
DROP TABLE IF EXISTS cantitati_comandate;
DROP TABLE IF EXISTS comenzi;
DROP TABLE IF EXISTS livrari;
DROP TABLE IF EXISTS transporturi;
DROP TABLE IF EXISTS soferi;
DROP TABLE IF EXISTS bonuri_fiscale_vanzari;
DROP TABLE IF EXISTS bonuri_fiscale_comenzi;
DROP TABLE IF EXISTS bonuri_fiscale;
DROP TABLE IF EXISTS discount;
DROP TABLE IF EXISTS clienti;
DROP TABLE IF EXISTS salarii;
DROP TABLE IF EXISTS angajati;
DROP TABLE IF EXISTS scoatere_din_gestiune;
DROP TABLE IF EXISTS TVA;
DROP TABLE IF EXISTS reteta_produs;
DROP TABLE IF EXISTS produse;
DROP TABLE IF EXISTS materii_prime;

CREATE TABLE materii_prime (
idMatPrima NUMERIC (5)
	CONSTRAINT pk_materii_prime PRIMARY KEY
	CONSTRAINT nn_idMatPrima NOT NULL,
DenMatPrima VARCHAR (40)
	CONSTRAINT ck_DenMatPrima CHECK(SUBSTR(DenMatPrima,1,1)=UPPER(SUBSTR(DenMatPrima,1,1)))
	CONSTRAINT nn_DenMatPrima NOT NULL,
UM_MatPrima VARCHAR (5)
	CONSTRAINT nn_UM_MatPrima NOT NULL,
PretUnitMatPrima NUMERIC (5,2)
	CONSTRAINT nn_PretUnitMatPrima NOT NULL
	);

CREATE TABLE produse (
idProdus NUMERIC (5)
	CONSTRAINT pk_produse PRIMARY KEY
	CONSTRAINT nn_idProdus NOT NULL,
DenProdus VARCHAR (20)
	CONSTRAINT ck_DenProdus CHECK(SUBSTR(DenProdus,1,1)=UPPER(SUBSTR(DenProdus,1,1)))
	CONSTRAINT nn_DenProdus NOT NULL,
UM_Produs VARCHAR (5)
	CONSTRAINT nn_UM_Produs NOT NULL,
PretCatalog NUMERIC (5,2)
	CONSTRAINT nn_Pret NOT NULL
	);

CREATE TABLE reteta_produs (
idMatPrima NUMERIC (5)
	CONSTRAINT fk_Reteta_Produs_materii_prime REFERENCES materii_prime(idMatPrima)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idMatPrima NOT NULL,
idProdus NUMERIC (5)
	CONSTRAINT fk_Reteta_Produs_produse REFERENCES produse(idProdus)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
CantMP_UnitProd NUMERIC (5,2)
	CONSTRAINT nn_CantMP_UnitProd NOT NULL,
	CONSTRAINT pk_Reteta_Produs PRIMARY KEY (idMatPrima, idProdus)
	);
	
CREATE TABLE TVA (
idProdus NUMERIC (5)
	CONSTRAINT fk_TVA_produse REFERENCES produse(idProdus)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
DataModifTVA DATE
	CONSTRAINT nn_DataModifTVE NOT NULL,
ProcentTVA NUMERIC (5,2)
	CONSTRAINT nn_ProcentTVA NOT NULL,
	CONSTRAINT pk_TVA PRIMARY KEY (idProdus, DataModifTVA)
	);
	
CREATE TABLE scoatere_din_gestiune (
idProdus NUMERIC (5)
	CONSTRAINT fk_scoatere_din_gestiune_produse REFERENCES produse(idProdus)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
DataExpirareProd DATE
	CONSTRAINT nn_DataExpirareProd NOT NULL,
CantitateScoasaDinGestiune NUMERIC (5)
	CONSTRAINT nn_CantitateScoasaDinGestiune NOT NULL,
	CONSTRAINT pk_scoatere_gestiune PRIMARY KEY (idProdus, DataExpirareProd)
	);
	
CREATE TABLE angajati (
idAngajat NUMERIC (5)
	CONSTRAINT pk_angajati PRIMARY KEY
	CONSTRAINT nn_idAngajat NOT NULL,
NumePrenAngajat VARCHAR(40)
	CONSTRAINT ck_NumePrenAngajat CHECK (NumePrenAngajat=LTRIM(INITCAP(NumePrenAngajat)))
	CONSTRAINT nn_NumePrenAngajat NOT NULL,
AdresaAngajat VARCHAR (50)
	CONSTRAINT ck_AdresaAngajat CHECK (AdresaAngajat=LTRIM(INITCAP(AdresaAngajat)))
	CONSTRAINT nn_AdresaAngajat NOT NULL,
Telefon Numeric (10),
Functie VARCHAR (20)
	CONSTRAINT nn_Functie NOT NULL,
DataAngajare DATE
	CONSTRAINT nn_DataAngajare NOT NULL,
DataNastere DATE
	CONSTRAINT ck_angajare CHECK (DataNastere < COALESCE(DataAngajare, CURRENT_Date))
	CONSTRAINT nn_DataNastere NOT NULL, 
CNP NUMERIC (13)
	CONSTRAINT nn_CNP NOT NULL,
ActIdentitate VARCHAR (8)
	CONSTRAINT ck_ActIdentitate CHECK (SUBSTR(ActIdentitate,1,2)=UPPER(SUBSTR(ActIdentitate,1,2)))
	CONSTRAINT nn_ActIdentitate NOT NULL,
Observatii VARCHAR (50)
	);
	
CREATE TABLE salarii (
idAngajat NUMERIC (5)
	CONSTRAINT fk_salarii_angajati REFERENCES angajati(idAngajat)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idAngajat NOT NULL,
DataModifSalariu DATE
	CONSTRAINT nn_DataModifSalariu NOT NULL,
Salariu NUMERIC (6,2)
	CONSTRAINT nn_Salariu NOT NULL,
	CONSTRAINT pk_salarii PRIMARY KEY (idAngajat, DataModifSalariu)
	);
	
CREATE TABLE clienti (
CodCl NUMERIC (5)
	CONSTRAINT pk_clienti PRIMARY KEY
	CONSTRAINT nn_CodCl NOT NULL,
NumeCl VARCHAR (30)
	CONSTRAINT ck_NumeCl CHECK (NumeCl=LTRIM(INITCAP(NumeCl)))
	CONSTRAINT nn_NumeCl NOT NULL,
AdresaCl VARCHAR (50)
	CONSTRAINT ck_AdresaCl CHECK (AdresaCl=LTRIM(INITCAP(AdresaCl)))
	CONSTRAINT nn_AdresaCl NOT NULL,
LocCl VARCHAR (30)
	CONSTRAINT ck_LocCl CHECK (LocCl=LTRIM(INITCAP(LocCl)))
	CONSTRAINT nn_LocCl NOT NULL,
JudCl VARCHAR (30)
	CONSTRAINT ck_JudCl CHECK (JudCl=LTRIM(INITCAP(JudCl)))
	CONSTRAINT nn_JudCl NOT NULL,
SoldCurent NUMERIC (7,2)
	CONSTRAINT nn_SoldCurent NOT NULL
	);

CREATE TABLE discount (
idDiscount NUMERIC (5)
	CONSTRAINT pk_discount PRIMARY KEY
	CONSTRAINT nn_idDiscount NOT NULL,
TipDiscount VARCHAR (20)
	CONSTRAINT ck_TipDiscount CHECK (TipDiscount  IN ('Rabat', 'Remiza', 'Risturn', 'Scont') AND TipDiscount=LTRIM(INITCAP(TipDiscount)))
	CONSTRAINT nn_TipDiscount NOT NULL,
ProcentDiscount NUMERIC (5,2)
	CONSTRAINT nn_ProcentDiscount NOT NULL
	);
	
CREATE TABLE bonuri_fiscale (
idBonFiscal NUMERIC (5)
	CONSTRAINT pk_bonuri_fiscale PRIMARY KEY
	CONSTRAINT nn_idBonFiscal NOT NULL,
DataVanzare DATE
	CONSTRAINT nn_DataVanzare NOT NULL
	);

CREATE TABLE bonuri_fiscale_comenzi (
idBF_Comanda NUMERIC (5)
	CONSTRAINT fk_bonuri_fiscale_comenzi_bonuri_fiscale REFERENCES bonuri_fiscale(idBonFiscal)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idBF_Comanda NOT NULL,
NrLinieBF_Comanda NUMERIC (5)
	CONSTRAINT nn_NrLinieBF_Comanda NOT NULL,
idProdus NUMERIC (5)
	CONSTRAINT fk_bonuri_fiscale_comezi_produse REFERENCES produse(idProdus)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
idDiscount NUMERIC (5)
	CONSTRAINT fk_bonuri_fiscale_comenzi_discount REFERENCES discount(idDiscount)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idDiscount NOT NULL,
PretCuDiscount NUMERIC (7,2)
	CONSTRAINT nn_PretCuDiscount NOT NULL,
	CONSTRAINT pk_bonuri_fiscale_comezi PRIMARY KEY (idBF_Comanda, NrLinieBF_Comanda, idDiscount)
	);

CREATE TABLE bonuri_fiscale_vanzari (
idBF_Vanzare NUMERIC (5)
	CONSTRAINT fk_bonuri_fiscale_vanzari_bonuri_fiscale REFERENCES bonuri_fiscale(idBonFiscal)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idBF_Vanzare NOT NULL,
NrLinieBF_Vanzare NUMERIC (5)
	CONSTRAINT nn_NrLinieBF_Vanzare NOT NULL,
idProdus NUMERIC (5)
	CONSTRAINT fk_bonuri_fiscale_vanzari_produse REFERENCES produse(idProdus)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
CantitateVanduta NUMERIC (5,2)
	CONSTRAINT nn_CantitateVanduta NOT NULL,
PretVanzare NUMERIC (5,2)
	CONSTRAINT nn_PretVanzare NOT NULL,
	CONSTRAINT pk_bonuri_fiscale_vanzari PRIMARY KEY (idBF_Vanzare, NrLinieBF_Vanzare)
	);

CREATE TABLE soferi (
idSofer NUMERIC (5)
	CONSTRAINT pk_soferi PRIMARY KEY
	CONSTRAINT fk_soferi_idSofer REFERENCES angajati(idAngajat)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idSofer NOT NULL,
NumePrenSofer VARCHAR(40)
	CONSTRAINT ck_NumePrenSofer CHECK (NumePrenSofer=LTRIM(INITCAP(NumePrenSofer)))
	CONSTRAINT nn_NumePrenSofer NOT NULL,
CategPermis VARCHAR (3)
	CONSTRAINT nn_CategPermis NOT NULL
	);

CREATE TABLE transporturi (
idTransport NUMERIC (5)
	CONSTRAINT pk_transporturi PRIMARY KEY
	CONSTRAINT nn_idTransport NOT NULL,
DataPlecare DATE
	CONSTRAINT nn_DataOraPlecare NOT NULL,
NrInmatr VARCHAR (7)
	CONSTRAINT ck_NrInmatr CHECK ((SUBSTR(NrInmatr,1,2)=UPPER(SUBSTR(NrInmatr,1,2))) AND (SUBSTR(NrInmatr,5,3)=UPPER(SUBSTR(NrInmatr,5,3))))
	CONSTRAINT nn_NrInmatr NOT NULL,
DataSosire DATE
	--CONSTRAINT ck_data CHECK (DataOraPlecare < COALESCE(DataOraSosire, CURRENT_Date))
	CONSTRAINT nn_DataOraSosire NOT NULL,
idSofer NUMERIC (5)
	CONSTRAINT fk_transporturi_soferi REFERENCES soferi(idSofer)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idSofer NOT NULL
	);

CREATE TABLE livrari (
idLivrare NUMERIC (5)
	CONSTRAINT pk_livrari PRIMARY KEY
	CONSTRAINT nn_idLivrare NOT NULL,
LocLivrare VARCHAR (40)
	CONSTRAINT ck_LocLivrare CHECK (LocLivrare=LTRIM(INITCAP(LocLivrare)))
	CONSTRAINT nn_LocLivrare NOT NULL,
JudLivrare VARCHAR (40)
	CONSTRAINT ck_JudLivrare CHECK (JudLivrare=LTRIM(INITCAP(JudLivrare)))
	CONSTRAINT nn_JudLivrare NOT NULL,
DataLivrare DATE
	CONSTRAINT nn_DataOraLivrare NOT NULL,
idTransport NUMERIC (5)
	CONSTRAINT fk_livrari_transporturi REFERENCES transporturi(idTransport)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idTransport NOT NULL
	);

CREATE TABLE comenzi (
NrComanda NUMERIC (5)
	CONSTRAINT pk_comenzi PRIMARY KEY
	CONSTRAINT nn_NrComanda NOT NULL,
DataComanda DATE
	CONSTRAINT nn_DataComanda NOT NULL,
StatusComanda VARCHAR (20)
	CONSTRAINT nn_StatusComanda NOT NULL,
idLivrare NUMERIC (5)
	CONSTRAINT fk_comenzi_livrari REFERENCES livrari(idLivrare)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idLivrare NOT NULL,
idBonFiscal NUMERIC (5)
	--Aici nu mergea cu idBF_Comanda (cu legătură la clauza UNIQUE) !!
	CONSTRAINT fk_comenzi_bonuri_fiscale REFERENCES bonuri_fiscale(idBonFiscal)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idBonFiscal NOT NULL
	);

CREATE TABLE cantitati_comandate (
NrComanda NUMERIC (5)
	CONSTRAINT fk_cantitati_comandate_comenzi REFERENCES comenzi(NrComanda)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_NrComanda NOT NULL,
idProdus NUMERIC (5)
	CONSTRAINT fk_comenzi_produse REFERENCES produse(idProdus)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
CantProdusComandata NUMERIC (5)
	CONSTRAINT nn_CantProdudComandata NOT NULL,
	CONSTRAINT pk_cantitati_comandate PRIMARY KEY (NrComanda, idProdus)
	);

CREATE TABLE adrese_livrare (
NrComanda NUMERIC (5)
	CONSTRAINT fk_adrese_livrare_comenzi REFERENCES comenzi(NrComanda)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_NrComanda NOT NULL,
CodCl NUMERIC (5)
	CONSTRAINT fk_adrese_livrare_clienti REFERENCES clienti(CodCl)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_CodCl NOT NULL,
AdresaLivrare VARCHAR (50)
	CONSTRAINT ck_AdresaLivrare CHECK (AdresaLivrare=LTRIM(INITCAP(AdresaLivrare)))
	CONSTRAINT nn_AdresaLivrare NOT NULL,
	CONSTRAINT pk_adrese_livrare PRIMARY KEY (NrComanda, CodCl)
	);
	
CREATE TABLE incasari (
idIncasare NUMERIC (5)
	CONSTRAINT pk_incasari PRIMARY KEY
	CONSTRAINT nn_idIncasare NOT NULL,
idBonFiscal NUMERIC (5)
	--Se încasează câte un singur bon fiscal o dată !!
	CONSTRAINT fk_incasari_bonuri_fiscale REFERENCES bonuri_fiscale(idBonFiscal)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idBonFiscal NOT NULL,
DataIncasare DATE
	CONSTRAINT nn_DataIncasare NOT NULL,
ModPlata VARCHAR (20)
	CONSTRAINT ck_ModPlata CHECK (ModPlata IN ('Numerar', 'Card', 'Cec'))
	CONSTRAINT nn_ModPlata NOT NULL,
SumaIncasata NUMERIC (5,2)
	CONSTRAINT nn_SumaIncasata NOT NULL
	);
	
CREATE TABLE retururi (
idRetur NUMERIC (5)
	CONSTRAINT pk_retururi PRIMARY KEY
	CONSTRAINT nn_idRetur NOT NULL,
DataRetur DATE
	CONSTRAINT nn_DataOraRetur NOT NULL,
MotivRetur VARCHAR (60)
	CONSTRAINT nn_MotivRetur NOT NULL,
idTransport NUMERIC (5)
	CONSTRAINT fk_retururi_transporturi REFERENCES transporturi(idTransport)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idTransport NOT NULL
	);

CREATE TABLE cantitati_returnate (
idRetur NUMERIC (5)
	CONSTRAINT fk_cantitati_returnate_retururi REFERENCES retururi(idRetur)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idRetur NOT NULL,
NrComanda NUMERIC (5)
	CONSTRAINT fk_cantitati_returnate_comenzi REFERENCES comenzi(NrComanda)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_NrComanda NOT NULL,
idProdus NUMERIC (5)
	CONSTRAINT fk_cantitati_returnate_produse REFERENCES produse(idProdus)
		ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
CantitateReturnata NUMERIC (5,2)
	CONSTRAINT nn_CantitateReturnata NOT NULL,
	CONSTRAINT pk_cantitati_returnate PRIMARY KEY (idRetur, NrComanda, idProdus)
	);

CREATE TABLE comenzi_productie (
idComandaProductie NUMERIC (5)
	CONSTRAINT pk_comenzi_productie PRIMARY KEY
	CONSTRAINT nn_idComandaProductie NOT NULL,
DataComanda DATE
	CONSTRAINT nn_DataComanda NOT NULL,
StatusProductie VARCHAR (20)
	CONSTRAINT nn_StatusComanda NOT NULL
	);

CREATE TABLE cantitati_produse (
idComandaProductie NUMERIC (5)
	CONSTRAINT fk_cantitati_produse_comenzi_productie REFERENCES comenzi_productie(idComandaProductie)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idComandaProductie NOT NULL,
idProdus NUMERIC (5)
	CONSTRAINT fk_cantitati_produse_produse REFERENCES produse(idProdus)
			ON DELETE RESTRICT ON UPDATE CASCADE
	CONSTRAINT nn_idProdus NOT NULL,
CantitateProdusa NUMERIC (5)
	CONSTRAINT nn_CantitateProdusa NOT NULL,
	CONSTRAINT pk_cantitati_produse PRIMARY KEY (idComandaProductie, idProdus)
	);



INSERT INTO materii_prime VALUES (1, 'Zahar', 'kg', 3.5);
INSERT INTO materii_prime VALUES (2, 'Oua', 'buc', 0.6);
INSERT INTO materii_prime VALUES (3, 'Faina', 'kg', 3);
INSERT INTO materii_prime VALUES (4, 'Esenta', 'ml', 0.02);
INSERT INTO materii_prime VALUES (5, 'Lapte', 'l', 4);
INSERT INTO materii_prime VALUES (6, 'Unt', 'g', 0.06);
INSERT INTO materii_prime VALUES (7, 'Cacao', 'g', 0.02);
INSERT INTO materii_prime VALUES (8, 'Zahar pudra', 'g', 0.04);
INSERT INTO materii_prime VALUES (9, 'Ciocolata', 'g', 0.08);
INSERT INTO materii_prime VALUES (10, 'Frisca lichida', 'l', 4);
INSERT INTO materii_prime VALUES (11, 'Fructe', 'buc', 2);
INSERT INTO materii_prime VALUES (12, 'Smantana', 'kg', 18);
INSERT INTO materii_prime VALUES (13, 'Praf de copt', 'plic', 1);
INSERT INTO materii_prime VALUES (14, 'Ulei', 'l', 3);
INSERT INTO materii_prime VALUES (15, 'Inghetata', 'kg', 15);

INSERT INTO produse VALUES (1, 'Ecler', 'buc', 5);
INSERT INTO produse VALUES (2, 'Amandina', 'buc', 8);
INSERT INTO produse VALUES (3, 'Diplomat', 'kg', 25);
INSERT INTO produse VALUES (4, 'Profiterol', 'buc', 10);
INSERT INTO produse VALUES (5, 'Savarina', 'buc', 9);
INSERT INTO produse VALUES (6, 'Tarta cu ciocolata', 'kg', 35);
INSERT INTO produse VALUES (7, 'Tarta cu fructe', 'kg', 30);
INSERT INTO produse VALUES (8, 'Briosa cu ciocolata', 'buc', 5);
INSERT INTO produse VALUES (9, 'Lemon', 'kg', 38);
INSERT INTO produse VALUES (10, 'Fursecuri', 'kg', 25);
INSERT INTO produse VALUES (11, 'Bezele', 'kg', 18);
INSERT INTO produse VALUES (12, 'Afrodita', 'buc', 5);
INSERT INTO produse VALUES (13, 'Boema', 'buc', 6);
INSERT INTO produse VALUES (14, 'Tiramisu', 'kg', 38);
INSERT INTO produse VALUES (15, 'Cremsnit', 'buc', 8);

INSERT INTO reteta_produs VALUES (1, 1, 0.50);
INSERT INTO reteta_produs VALUES (2, 1, 4);
INSERT INTO reteta_produs VALUES (3, 1, 0.30);
INSERT INTO reteta_produs VALUES (4, 1, 0.15);
INSERT INTO reteta_produs VALUES (5, 1, 1);
INSERT INTO reteta_produs VALUES (6, 1, 100);
INSERT INTO reteta_produs VALUES (9, 1, 250);
INSERT INTO reteta_produs VALUES (1, 2, 0.70);
INSERT INTO reteta_produs VALUES (2, 2, 2);
INSERT INTO reteta_produs VALUES (3, 2, 1.20);
INSERT INTO reteta_produs VALUES (4, 2, 0.30);
INSERT INTO reteta_produs VALUES (5, 2, 1.3);
INSERT INTO reteta_produs VALUES (7, 2, 400);
INSERT INTO reteta_produs VALUES (13, 2, 2);
INSERT INTO reteta_produs VALUES (1, 3, 0.60);
INSERT INTO reteta_produs VALUES (2, 3, 7);
INSERT INTO reteta_produs VALUES (4, 3, 0.20);
INSERT INTO reteta_produs VALUES (5, 3, 1);
INSERT INTO reteta_produs VALUES (10, 3, 0.50);
INSERT INTO reteta_produs VALUES (11, 3, 3);
INSERT INTO reteta_produs VALUES (1, 4, 0.90);
INSERT INTO reteta_produs VALUES (2, 4, 3);
INSERT INTO reteta_produs VALUES (3, 4, 0.50);
INSERT INTO reteta_produs VALUES (4, 4, 0.20);
INSERT INTO reteta_produs VALUES (5, 4, 0.15);
INSERT INTO reteta_produs VALUES (6, 4, 80);
INSERT INTO reteta_produs VALUES (15, 4, 0.30);
INSERT INTO reteta_produs VALUES (1, 5, 0.40);
INSERT INTO reteta_produs VALUES (2, 5, 2);
INSERT INTO reteta_produs VALUES (3, 5, 0.50);
INSERT INTO reteta_produs VALUES (4, 5, 0.20);
INSERT INTO reteta_produs VALUES (5, 5, 1);
INSERT INTO reteta_produs VALUES (6, 5, 30);
INSERT INTO reteta_produs VALUES (8, 5, 25);
INSERT INTO reteta_produs VALUES (12, 5, 0.50);
INSERT INTO reteta_produs VALUES (1, 6, 0.70);
INSERT INTO reteta_produs VALUES (3, 6, 0.75);
INSERT INTO reteta_produs VALUES (5, 6, 0.30);
INSERT INTO reteta_produs VALUES (7, 6, 20);
INSERT INTO reteta_produs VALUES (9, 6, 200);
INSERT INTO reteta_produs VALUES (1, 7, 0.30);
INSERT INTO reteta_produs VALUES (2, 7, 3);
INSERT INTO reteta_produs VALUES (5, 7, 1);
INSERT INTO reteta_produs VALUES (11, 7, 3);
INSERT INTO reteta_produs VALUES (14, 7, 0.15);
INSERT INTO reteta_produs VALUES (1, 8, 0.40);
INSERT INTO reteta_produs VALUES (2, 8, 3);
INSERT INTO reteta_produs VALUES (3, 8, 1.20);
INSERT INTO reteta_produs VALUES (5, 8, 1);
INSERT INTO reteta_produs VALUES (7, 8, 30);
INSERT INTO reteta_produs VALUES (9, 8, 250);
INSERT INTO reteta_produs VALUES (1, 9, 0.25);
INSERT INTO reteta_produs VALUES (3, 9, 1);
INSERT INTO reteta_produs VALUES (5, 9, 0.80);
INSERT INTO reteta_produs VALUES (11, 9, 2);
INSERT INTO reteta_produs VALUES (1, 10, 0.30);
INSERT INTO reteta_produs VALUES (3, 10, 2);
INSERT INTO reteta_produs VALUES (5, 10, 1);
INSERT INTO reteta_produs VALUES (6, 10, 250);
INSERT INTO reteta_produs VALUES (8, 10, 20);
INSERT INTO reteta_produs VALUES (1, 11, 0.80);
INSERT INTO reteta_produs VALUES (2, 11, 5);
INSERT INTO reteta_produs VALUES (4, 11, 15);
INSERT INTO reteta_produs VALUES (1, 12, 0.30);
INSERT INTO reteta_produs VALUES (3, 12, 1);
INSERT INTO reteta_produs VALUES (5, 12, 0.80);
INSERT INTO reteta_produs VALUES (10, 12, 0.50);
INSERT INTO reteta_produs VALUES (14, 12, 0.10);
INSERT INTO reteta_produs VALUES (1, 13, 0.45);
INSERT INTO reteta_produs VALUES (2, 13, 3);
INSERT INTO reteta_produs VALUES (3, 13, 0.70);
INSERT INTO reteta_produs VALUES (4, 13, 20);
INSERT INTO reteta_produs VALUES (5, 13, 0.60);
INSERT INTO reteta_produs VALUES (6, 13, 250);
INSERT INTO reteta_produs VALUES (7, 13, 25);
INSERT INTO reteta_produs VALUES (13, 13, 1);
INSERT INTO reteta_produs VALUES (1, 14, 0.50);
INSERT INTO reteta_produs VALUES (4, 14, 35);
INSERT INTO reteta_produs VALUES (5, 14, 1);
INSERT INTO reteta_produs VALUES (7, 14, 35);
INSERT INTO reteta_produs VALUES (10, 14, 0.70);
INSERT INTO reteta_produs VALUES (1, 15, 0.35);
INSERT INTO reteta_produs VALUES (3, 15, 0.50);
INSERT INTO reteta_produs VALUES (4, 15, 10);
INSERT INTO reteta_produs VALUES (6, 15, 230);
INSERT INTO reteta_produs VALUES (10, 15, 1);

INSERT INTO TVA VALUES (1, '2014/03/20', 19.00);
INSERT INTO TVA VALUES (1, '2014/07/18', 24.00);
INSERT INTO TVA VALUES (2, '2014/05/15', 24.00);
INSERT INTO TVA VALUES (2, '2014/07/20', 19.00);
INSERT INTO TVA VALUES (2, '2015/01/04', 9.00);
INSERT INTO TVA VALUES (3, '2014/05/18', 9.00);
INSERT INTO TVA VALUES (4, '2014/06/02', 19.00);
INSERT INTO TVA VALUES (4, '2014/09/27', 25.00);
INSERT INTO TVA VALUES (4, '2015/03/08', 24.00);
INSERT INTO TVA VALUES (5, '2014/07/30', 25.00);
INSERT INTO TVA VALUES (6, '2014/09/24', 18.00);
INSERT INTO TVA VALUES (7, '2014/11/17', 24.00);
INSERT INTO TVA VALUES (7, '2015/01/19', 25.00);
INSERT INTO TVA VALUES (7, '2015/03/04', 9.00);
INSERT INTO TVA VALUES (7, '2015/05/16', 19.00);
INSERT INTO TVA VALUES (8, '2014/12/02', 19.00);
INSERT INTO TVA VALUES (9, '2015/01/19', 19.00);
INSERT INTO TVA VALUES (10, '2015/01/28', 24.00);
INSERT INTO TVA VALUES (10, '2015/04/09', 9.00);
INSERT INTO TVA VALUES (11, '2015/02/13', 25.00);
INSERT INTO TVA VALUES (12, '2015/02/28', 24.00);
INSERT INTO TVA VALUES (12, '2014/05/30', 19.00);
INSERT INTO TVA VALUES (13, '2015/03/29', 19.00);
INSERT INTO TVA VALUES (14, '2014/04/08', 9.00);
INSERT INTO TVA VALUES (14, '2014/09/30', 24.00);
INSERT INTO TVA VALUES (15, '2015/05/15', 19.00);

INSERT INTO scoatere_din_gestiune VALUES (1, '2014/04/23', 5);
INSERT INTO scoatere_din_gestiune VALUES (1, '2014/05/05', 2);
INSERT INTO scoatere_din_gestiune VALUES (2, '2014/03/16', 4);
INSERT INTO scoatere_din_gestiune VALUES (3, '2014/05/20', 2);
INSERT INTO scoatere_din_gestiune VALUES (4, '2014/04/18', 7);
INSERT INTO scoatere_din_gestiune VALUES (5, '2014/06/09', 3);
INSERT INTO scoatere_din_gestiune VALUES (5, '2015/04/20', 5);
INSERT INTO scoatere_din_gestiune VALUES (6, '2014/07/03', 2);
INSERT INTO scoatere_din_gestiune VALUES (7, '2015/02/09', 1);
INSERT INTO scoatere_din_gestiune VALUES (8, '2015/04/22', 15);
INSERT INTO scoatere_din_gestiune VALUES (8, '2015/05/12', 13);
INSERT INTO scoatere_din_gestiune VALUES (9, '2014/06/04', 3);
INSERT INTO scoatere_din_gestiune VALUES (9, '2014/09/10', 2);
INSERT INTO scoatere_din_gestiune VALUES (9, '2015/04/30', 5);
INSERT INTO scoatere_din_gestiune VALUES (10, '2014/07/29', 4);
INSERT INTO scoatere_din_gestiune VALUES (11, '2015/03/21', 1);
INSERT INTO scoatere_din_gestiune VALUES (12, '2014/09/18', 14);
INSERT INTO scoatere_din_gestiune VALUES (12, '2015/02/11', 6);
INSERT INTO scoatere_din_gestiune VALUES (13, '2015/01/20', 9);
INSERT INTO scoatere_din_gestiune VALUES (14, '2014/12/19', 2);
INSERT INTO scoatere_din_gestiune VALUES (14, '2015/06/14', 3);
INSERT INTO scoatere_din_gestiune VALUES (15, '2015/04/17', 5);

INSERT INTO angajati VALUES (1, 'Popescu Vasilica', 'Str. Ion Barbu, Nr. 8, Iasi', 0746903214, 'Cofetar', '2012/03/26', '1985/09/18', 2850918245683, 'IS374839',Null);
INSERT INTO angajati VALUES (2, 'Ionel Adriana', 'Bvd. Carol I, Nr. 18, Pascani', 0232209278, 'Manager', '2011/03/18', '1969/04/30', 2690430940357, 'IS584733',Null);
INSERT INTO angajati VALUES (3, 'Aanei Marian', 'Str. Gheorghe Asachi, Nr. 7, Iasi', 0763023856, 'Sofer', '2012/01/10', '1978/07/20', 1780720256305, 'IS748594',Null);
INSERT INTO angajati VALUES (4, 'Bootez Elena', 'Str. Mihai Eminescu, Nr. 20, Pascani',0232217904, 'Contabil', '2013/02/13', '1990/12/28', 2901228045280, 'IS637294',Null);
INSERT INTO angajati VALUES (5, 'Ionescu Cristian', 'Str. Marin Sava, Nr. 10, Iasi', 0232309451, 'Sofer', '2012/08/25', '1988/05/04', 1880504456302, 'IS124475',Null);
INSERT INTO angajati VALUES (6, 'Gafita Aurel', 'Str. Florilor, Nr. 80, Targu Frumos', 0232384893, 'Sofer', '2013/03/09', '1969/07/20', 1690720245367, 'IS465398',Null);
INSERT INTO angajati VALUES (7, 'Preda Marin', 'Bvd. Eminescu, Nr. 46, Letcani', 0735674895, 'Cofetar', '2012/04/07', '1990/05/30', 1900530465378, 'IS115896',Null);
INSERT INTO angajati VALUES (8, 'Anechitei Andreea', 'Str. Horia, Nr. 123, Podu Iloaei', 0232758478, 'Vanzator', '2013/09/24', '1987/03/31', 2870331847634, 'IS003659',Null);
INSERT INTO angajati VALUES (9, 'Ursache Laurentiu', 'Str. Elena, Nr. 45, Sarca', 0764563898, 'Sofer', '2014/07/25', '1978/03/17', 1780317589641, 'IS212698',Null);
INSERT INTO angajati VALUES (10, 'Amariei Geanina', 'Bvd. Ferdinand, Nr. 45, Pascani', 0232098564, 'Cofetar', '2011/12/09', '1977/05/14', 2770514658962, 'IS012658',Null);
INSERT INTO angajati VALUES (11, 'Gabor Madalina', 'Str. Republicii, Nr. 75, Letcani', 0734856490, 'Cofetar', '2011/10/06', '1968/09/13', 2680913569745, 'IS036987',Null);
INSERT INTO angajati VALUES (12, 'Vasiliu Diana', 'Bvd. Bucium, Nr. 78, Iasi', 0375046783, 'Manager', '2013/04/22', '1983/03/09', 2830309563248, 'IS103458',Null);
INSERT INTO angajati VALUES (13, 'Serban Ionut', 'Str. Carolina, Nr. 109, Sarca', 0789456372, 'Sofer', '2013/07/05', '1986/06/23', 1860623569874, 'IS125698',Null);
INSERT INTO angajati VALUES (14, 'Popescu Ionela', 'Bvd. Sperantei, Nr. 34, Targu Frumos', 0722564789, 'Paznic', '2012/02/16', '1977/01/29', 2770129620136, 'IS758469',Null);
INSERT INTO angajati VALUES (15, 'Mocanu Alexandra', 'Str. Eleonora Roman, Nr. 69, Pascani',0233756890, 'Cofetar', '2014/07/19', '1974/04/22', 2740422102598, 'IS125987',Null);
INSERT INTO angajati VALUES (16, 'Cojocariu Claudiu', 'Str. Crisului, Nr. 9, Iasi', 0779034126, 'Sofer', '2013/07/30', '1982/12/12', 1821212526589, 'IS102365',Null);
INSERT INTO angajati VALUES (17, 'Aionesei Mariana', 'Str. Elena Doamna, Nr. 24, Targu Frumos', 0345892453, 'Cofetar', '2013/06/29', '1981/05/14', 2810514623002, 'IS126987',Null);
INSERT INTO angajati VALUES (18, 'Bucataru Frorina', 'Bvd. Matei Popovici, Nr. 117, Iasi', 0231746589, 'Sofer', '2014/05/23', '1991/11/04', 2911104521116, 'IS524698',Null);
INSERT INTO angajati VALUES (19, 'Mitrea Bogdan', 'Str. Gheorghe Asachi, Nr. 245, Letcani', 0744397265, 'Cofetar', '2014/03/31', '1975/03/18', 1750318523669, 'IS125698',Null);
INSERT INTO angajati VALUES (20, 'Nistor Andrei', 'Str. Petre Andrei, Nr. 76, Targu Frumos', 0783452678, 'Sofer', '2015/03/23', '1979/11/28', 1791128563447, 'IS256486',Null);

INSERT INTO salarii VALUES (1, '2013/03/28', 900.00);
INSERT INTO salarii VALUES (2, '2014/08/19', 1050.90);
INSERT INTO salarii VALUES (3, '2013/05/20', 980.30);
INSERT INTO salarii VALUES (3, '2015/02/13', 1200.00);
INSERT INTO salarii VALUES (4, '2014/10/22', 1100.70);
INSERT INTO salarii VALUES (5, '2014/04/20', 1200.30);
INSERT INTO salarii VALUES (6, '2014/09/06', 1340.00);
INSERT INTO salarii VALUES (7, '2013/07/24', 950.30);
INSERT INTO salarii VALUES (7, '2014/04/18', 1307.00);
INSERT INTO salarii VALUES (8, '2014/05/13', 1104.70);
INSERT INTO salarii VALUES (9, '2014/10/09', 1302.00);
INSERT INTO salarii VALUES (9, '2014/01/24', 945.00);
INSERT INTO salarii VALUES (9, '2015/05/30', 1206.90);
INSERT INTO salarii VALUES (10, '2014/05/12', 845.00);
INSERT INTO salarii VALUES (11, '2013/02/04', 734.00);
INSERT INTO salarii VALUES (12, '2013/05/23', 956.00);
INSERT INTO salarii VALUES (12, '2014/04/17', 990.40);
INSERT INTO salarii VALUES (12, '2015/02/19', 1230.00);
INSERT INTO salarii VALUES (12, '2015/05/22', 1100.50);
INSERT INTO salarii VALUES (13, '2014/03/07', 1090.35);
INSERT INTO salarii VALUES (14, '2013/05/09', 1305.00);
INSERT INTO salarii VALUES (14, '2014/04/25', 940.00);
INSERT INTO salarii VALUES (15, '2014/10/14', 1005.80);
INSERT INTO salarii VALUES (16, '2014/12/04', 1250.55);
INSERT INTO salarii VALUES (16, '2015/01/04', 1100.20);
INSERT INTO salarii VALUES (17, '2013/11/17', 834.00);
INSERT INTO salarii VALUES (17, '2014/09/29', 960.70);
INSERT INTO salarii VALUES (18, '2014/08/12', 950.20);
INSERT INTO salarii VALUES (19, '2014/06/20', 1389.00);
INSERT INTO salarii VALUES (19, '2014/10/19', 1050.60);
INSERT INTO salarii VALUES (19, '2015/01/23', 1120.50);
INSERT INTO salarii VALUES (20, '2015/04/20', 1075.00);

INSERT INTO clienti VALUES (1001, 'Amaretto', 'Str. Ion Creanga, Nr. 34', 'Iasi', 'Iasi', 1905.00);
INSERT INTO clienti VALUES (1002, 'Amariei Alexandra', 'Str. Vasile Popescu, Nr. 8', 'Targu Frumos', 'Iasi', 840.00);
INSERT INTO clienti VALUES (1003, 'Sava Irina', 'Str. Lazar, Nr. 121', 'Iasi', 'Iasi', 1020.80);
INSERT INTO clienti VALUES (1004, 'Cojocariu Viorel', 'Bvd. Carol I, Nr 1', 'Iasi', 'Iasi', 1560.50);
INSERT INTO clienti VALUES (1005, 'Aliona', 'Str. Gheorghe Voda, Nr. 56', 'Iasi', 'Iasi', 2035.00);
INSERT INTO clienti VALUES (1006, 'Trofin Simona', 'Str. Regina Maria, Nr. 67', 'Pascani', 'Iasi', 845.00);
INSERT INTO clienti VALUES (1007, 'Anegroaei Marius', 'Bvd. Stefan Musat, Nr. 78', 'Targu Frumos', 'Iasi', 345.00);
INSERT INTO clienti VALUES (1008, 'Dumitru Bogdan', 'Str. Ioan Cuza, Nr. 56', 'Iasi', 'Iasi', 465.00);
INSERT INTO clienti VALUES (1009, 'Doretto', 'Bvd. Carol I, Nr. 80', 'Pascani', 'Iasi', 2059.00);
INSERT INTO clienti VALUES (1010, 'Caramela', 'Str. Viorilor, Nr. 23', 'Iasi', 'Iasi', 1980.50);
INSERT INTO clienti VALUES (1011, 'Iftime Eliza', 'Str. Vanatorilor, Nr. 56', 'Targu Frumos', 'Iasi', 1040.00);
INSERT INTO clienti VALUES (1012, 'Marian Elena', 'Bvd. Mihai Albu, Nr. 58', 'Letcani', 'Iasi', 243.00);
INSERT INTO clienti VALUES (1013, 'Areallo', 'Str. Mihnea Gheorghe, Nr. 23', 'Pascani', 'Iasi', 2040.00);
INSERT INTO clienti VALUES (1014, 'Josan Paula', 'Bvd. Ferdinand, Nr. 134', 'Iasi', 'Iasi', 960.00);
INSERT INTO clienti VALUES (1015, 'Bucuria', 'Str. Angela Robu, Nr. 209', 'Letcani', 'Iasi', 2409.00);
INSERT INTO clienti VALUES (1016, 'Arsene Larisa', 'Bvd. Elisabeta I, Nr. 20', 'Iasi', 'Iasi', 560.40);
INSERT INTO clienti VALUES (1017, 'Airinei Radu', 'Str. Florilor, Nr. 157', 'Pascani', 'Iasi', 650.30);
INSERT INTO clienti VALUES (1018, 'Elita', 'Str. Atanasie Fatu, Nr. 189', 'Iasi', 'Iasi', 1968.00);
INSERT INTO clienti VALUES (1019, 'Ilie Andreea', 'Str. Sararie, Nr. 26', 'Pascani', 'Iasi', 497.00);
INSERT INTO clienti VALUES (1020, 'Cassanova', 'Str. Ciric, Nr. 95', 'Targu Frumos', 'Iasi', 2040.00);

INSERT INTO discount VALUES (1, 'Rabat', 6.00);
INSERT INTO discount VALUES (2, 'Remiza', 8.00);
INSERT INTO discount VALUES (3, 'Risturn', 3.00);
INSERT INTO discount VALUES (4, 'Scont', 7.00);

INSERT INTO bonuri_fiscale VALUES (1, '2014/01/12');
INSERT INTO bonuri_fiscale VALUES (2, '2014/02/14');
INSERT INTO bonuri_fiscale VALUES (3, '2014/03/16');
INSERT INTO bonuri_fiscale VALUES (4, '2014/03/18');
INSERT INTO bonuri_fiscale VALUES (5, '2014/04/22');
INSERT INTO bonuri_fiscale VALUES (6, '2014/05/26');
INSERT INTO bonuri_fiscale VALUES (7, '2014/06/04');
INSERT INTO bonuri_fiscale VALUES (8, '2014/05/07');
INSERT INTO bonuri_fiscale VALUES (9, '2014/06/19');
INSERT INTO bonuri_fiscale VALUES (10, '2014/07/23');
INSERT INTO bonuri_fiscale VALUES (11, '2014/08/27');
INSERT INTO bonuri_fiscale VALUES (12, '2014/09/06');
INSERT INTO bonuri_fiscale VALUES (13, '2014/10/09');
INSERT INTO bonuri_fiscale VALUES (14, '2014/10/23');
INSERT INTO bonuri_fiscale VALUES (15, '2014/11/25');
INSERT INTO bonuri_fiscale VALUES (16, '2014/12/13');
INSERT INTO bonuri_fiscale VALUES (17, '2014/12/16');
INSERT INTO bonuri_fiscale VALUES (18, '2015/02/22');
INSERT INTO bonuri_fiscale VALUES (19, '2015/03/28');
INSERT INTO bonuri_fiscale VALUES (20, '2015/04/30');
INSERT INTO bonuri_fiscale VALUES (21, '2013/02/11');
INSERT INTO bonuri_fiscale VALUES (22, '2013/05/25');
INSERT INTO bonuri_fiscale VALUES (23, '2013/08/19');
INSERT INTO bonuri_fiscale VALUES (24, '2013/09/12');
INSERT INTO bonuri_fiscale VALUES (25, '2013/11/08');
INSERT INTO bonuri_fiscale VALUES (26, '2013/12/05');
INSERT INTO bonuri_fiscale VALUES (27, '2014/03/23');
INSERT INTO bonuri_fiscale VALUES (28, '2014/07/30');
INSERT INTO bonuri_fiscale VALUES (29, '2015/02/15');
INSERT INTO bonuri_fiscale VALUES (30, '2015/04/18');
INSERT INTO bonuri_fiscale VALUES (31, '2015/03/14');
INSERT INTO bonuri_fiscale VALUES (32, '2014/05/06');
INSERT INTO bonuri_fiscale VALUES (33, '2013/07/22');
INSERT INTO bonuri_fiscale VALUES (34, '2014/11/28');
INSERT INTO bonuri_fiscale VALUES (35, '2013/12/15');
INSERT INTO bonuri_fiscale VALUES (36, '2015/08/10');
INSERT INTO bonuri_fiscale VALUES (37, '2014/04/23');
INSERT INTO bonuri_fiscale VALUES (38, '2015/10/07');
INSERT INTO bonuri_fiscale VALUES (39, '2014/01/12');
INSERT INTO bonuri_fiscale VALUES (40, '2013/09/01');

INSERT INTO bonuri_fiscale_comenzi VALUES (1, 1, 1, 1, 24.50);
INSERT INTO bonuri_fiscale_comenzi VALUES (3, 1, 2, 2, 35.60);
INSERT INTO bonuri_fiscale_comenzi VALUES (3, 2, 4, 2, 54.80);
INSERT INTO bonuri_fiscale_comenzi VALUES (3, 3, 8, 4, 110.20);
INSERT INTO bonuri_fiscale_comenzi VALUES (4, 1, 11, 2, 34.80);
INSERT INTO bonuri_fiscale_comenzi VALUES (4, 2, 14, 3, 43.20);
INSERT INTO bonuri_fiscale_comenzi VALUES (5, 1, 3, 1, 56.80);
INSERT INTO bonuri_fiscale_comenzi VALUES (5, 2, 5, 4, 41.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (6, 1, 6, 3, 23.60);
INSERT INTO bonuri_fiscale_comenzi VALUES (6, 2, 8, 2, 37.90);
INSERT INTO bonuri_fiscale_comenzi VALUES (6, 3, 10, 4, 62.30);
INSERT INTO bonuri_fiscale_comenzi VALUES (7, 1, 13, 1, 45.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (8, 1, 7, 1, 43.20);
INSERT INTO bonuri_fiscale_comenzi VALUES (9, 1, 9, 2, 73.40);
INSERT INTO bonuri_fiscale_comenzi VALUES (9, 2, 12, 3, 23.50);
INSERT INTO bonuri_fiscale_comenzi VALUES (9, 3, 15, 3, 38.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (11, 1, 9, 2, 41.70);
INSERT INTO bonuri_fiscale_comenzi VALUES (11, 2, 11, 4, 68.90);
INSERT INTO bonuri_fiscale_comenzi VALUES (14, 1, 4, 2, 30.70);
INSERT INTO bonuri_fiscale_comenzi VALUES (14, 2, 15, 3, 28.40);
INSERT INTO bonuri_fiscale_comenzi VALUES (21, 1, 1, 1, 46.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (21, 2, 5, 4, 19.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (22, 1, 2, 2, 25.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (22, 2, 6, 3, 46.50);
INSERT INTO bonuri_fiscale_comenzi VALUES (22, 3, 9, 1, 34.20);
INSERT INTO bonuri_fiscale_comenzi VALUES (23, 1, 11, 4, 73.40);
INSERT INTO bonuri_fiscale_comenzi VALUES (24, 1, 14, 2, 28.30);
INSERT INTO bonuri_fiscale_comenzi VALUES (24, 2, 15, 1, 35.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (25, 1, 12, 2, 42.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (26, 1, 7, 3, 35.90);
INSERT INTO bonuri_fiscale_comenzi VALUES (26, 2, 8, 2, 25.40);
INSERT INTO bonuri_fiscale_comenzi VALUES (27, 1, 1, 3, 37.80);
INSERT INTO bonuri_fiscale_comenzi VALUES (28, 1, 3, 1, 36.10);
INSERT INTO bonuri_fiscale_comenzi VALUES (28, 2, 4, 4, 21.00);
INSERT INTO bonuri_fiscale_comenzi VALUES (28, 3, 10, 1, 64.20);
INSERT INTO bonuri_fiscale_comenzi VALUES (29, 1, 13, 3, 19.90);
INSERT INTO bonuri_fiscale_comenzi VALUES (30, 1, 15, 2, 26.30);

INSERT INTO bonuri_fiscale_vanzari VALUES (2, 1, 1, 3, 15);
INSERT INTO bonuri_fiscale_vanzari VALUES (2, 2, 3, 0.20, 5);
INSERT INTO bonuri_fiscale_vanzari VALUES (10, 1, 6, 0.50, 17.5);
INSERT INTO bonuri_fiscale_vanzari VALUES (10, 2, 10, 1, 25);
INSERT INTO bonuri_fiscale_vanzari VALUES (12, 1, 11, 0.50, 9);
INSERT INTO bonuri_fiscale_vanzari VALUES (13, 1, 2, 5, 40);
INSERT INTO bonuri_fiscale_vanzari VALUES (15, 1, 4, 3, 30);
INSERT INTO bonuri_fiscale_vanzari VALUES (15, 2, 9, 0.80, 30.4);
INSERT INTO bonuri_fiscale_vanzari VALUES (15, 3, 14, 0.45, 17.1);
INSERT INTO bonuri_fiscale_vanzari VALUES (16, 1, 12, 6, 30);
INSERT INTO bonuri_fiscale_vanzari VALUES (17, 1, 7, 1.50, 45);
INSERT INTO bonuri_fiscale_vanzari VALUES (17, 2, 10, 1.20, 30);
INSERT INTO bonuri_fiscale_vanzari VALUES (17, 3, 15, 5, 40);
INSERT INTO bonuri_fiscale_vanzari VALUES (18, 1, 5, 2, 18);
INSERT INTO bonuri_fiscale_vanzari VALUES (18, 2, 12, 4, 20);
INSERT INTO bonuri_fiscale_vanzari VALUES (19, 1, 6, 0.60, 21);
INSERT INTO bonuri_fiscale_vanzari VALUES (19, 2, 7, 0.35, 10.5);
INSERT INTO bonuri_fiscale_vanzari VALUES (20, 1, 3, 0.50, 12.5);
INSERT INTO bonuri_fiscale_vanzari VALUES (20, 2, 8, 8, 40);
INSERT INTO bonuri_fiscale_vanzari VALUES (20, 3, 13, 4, 24);

INSERT INTO soferi VALUES (3, 'Aanei Marian', 'B');
INSERT INTO soferi VALUES (5, 'Ionescu Cristian', 'B');
INSERT INTO soferi VALUES (6, 'Gafita Aurel', 'B');
INSERT INTO soferi VALUES (9, 'Ursache Laureniu', 'B');
INSERT INTO soferi VALUES (13, 'Serban Ionut', 'B');
INSERT INTO soferi VALUES (16, 'Cojocariu Claudiu', 'B');
INSERT INTO soferi VALUES (18, 'Bucataru Elena', 'B');
INSERT INTO soferi VALUES (20, 'Nistor Andrei', 'B');

INSERT INTO transporturi VALUES (1, '2014/04/14', 'IS04VTH', '2014/04/14', 3);
INSERT INTO transporturi VALUES (2, '2014/07/05', 'IS34FTH', '2014/07/05', 9);
INSERT INTO transporturi VALUES (3, '2015/03/18', 'IS56VAW', '2015/03/18', 5);
INSERT INTO transporturi VALUES (4, '2014/06/25', 'IS28PFV', '2014/06/25', 6);
INSERT INTO transporturi VALUES (5, '2015/02/13', 'IS64LVS', '2015/02/13', 13);
INSERT INTO transporturi VALUES (6, '2013/06/03', 'IS64LVS', '2013/06/03', 20);
INSERT INTO transporturi VALUES (7, '2013/04/25', 'IS04VTH', '2013/04/25', 16);
INSERT INTO transporturi VALUES (8, '2014/05/04', 'IS34FTH', '2014/05/04', 3);
INSERT INTO transporturi VALUES (9, '2013/05/29', 'IS04VTH', '2013/05/29', 18);
INSERT INTO transporturi VALUES (10, '2014/01/30', 'IS34FTH', '2014/01/30', 13);
INSERT INTO transporturi VALUES (11, '2013/03/15', 'IS28PFV', '2013/03/15', 20);
INSERT INTO transporturi VALUES (12, '2013/09/23', 'IS56VAW', '2013/09/23', 5);
INSERT INTO transporturi VALUES (13, '2015/03/22', 'IS04VTH', '2015/03/22', 6);
INSERT INTO transporturi VALUES (14, '2014/11/14', 'IS56VAW', '2014/11/14', 9);
INSERT INTO transporturi VALUES (15, '2014/06/30', 'IS28PFV', '2014/06/30', 16);
INSERT INTO transporturi VALUES (16, '2014/04/01', 'IS64LVS', '2014/04/01', 18);
INSERT INTO transporturi VALUES (17, '2014/12/09', 'IS04VTH', '2014/12/09', 3);
INSERT INTO transporturi VALUES (18, '2013/04/12', 'IS56VAW', '2013/04/12', 6);
INSERT INTO transporturi VALUES (19, '2015/05/03', 'IS28PFV', '2015/05/03', 5);
INSERT INTO transporturi VALUES (20, '2014/10/06', 'IS04VTH', '2014/10/06', 13);
INSERT INTO transporturi VALUES (21, '2015/03/14', 'IS04VTH', '2015/03/14', 3);
INSERT INTO transporturi VALUES (22, '2014/05/06', 'IS34FTH', '2014/05/06', 18);
INSERT INTO transporturi VALUES (23, '2013/07/22', 'IS56VAW', '2013/07/22', 5);
INSERT INTO transporturi VALUES (24, '2014/11/28', 'IS04VTH', '2014/11/28', 16);
INSERT INTO transporturi VALUES (25, '2013/12/15', 'IS64LVS', '2013/12/15', 20);
INSERT INTO transporturi VALUES (26, '2015/08/10', 'IS56VAW', '2015/08/10', 6);
INSERT INTO transporturi VALUES (27, '2014/04/23', 'IS04VTH', '2014/04/23', 13);
INSERT INTO transporturi VALUES (28, '2015/10/07', 'IS34FTH', '2015/10/07', 5);
INSERT INTO transporturi VALUES (29, '2014/01/12', 'IS64LVS', '2014/01/12', 9);
INSERT INTO transporturi VALUES (30, '2013/09/01', 'IS56VAW', '2013/09/01', 18);

INSERT INTO livrari VALUES (1, 'Targu Frumos', 'Iasi', '2014/04/14', 1);
INSERT INTO livrari VALUES (2, 'Iasi', 'Iasi', '2014/07/05', 2);
INSERT INTO livrari VALUES (3, 'Targu Frumos', 'Iasi', '2015/03/18', 3);
INSERT INTO livrari VALUES (4, 'Iasi', 'Iasi', '2014/06/25', 4);
INSERT INTO livrari VALUES (5, 'Pascani', 'Iasi', '2015/02/13', 5);
INSERT INTO livrari VALUES (6, 'Iasi', 'Iasi', '2013/06/03', 6);
INSERT INTO livrari VALUES (7, 'Pascani', 'Iasi', '2013/04/25', 7);
INSERT INTO livrari VALUES (8, 'Targu Frumos', 'Iasi', '2014/05/04', 8);
INSERT INTO livrari VALUES (9, 'Targu Frumos', 'Iasi', '2013/05/29', 9);
INSERT INTO livrari VALUES (10, 'Pascani', 'Iasi', '2014/01/30', 10);
INSERT INTO livrari VALUES (11, 'Iasi', 'Iasi', '2013/03/15', 11);
INSERT INTO livrari VALUES (12, 'Targu Frumos', 'Iasi', '2013/09/23', 12);
INSERT INTO livrari VALUES (13, 'Pascani', 'Iasi', '2015/03/22', 13);
INSERT INTO livrari VALUES (14, 'Iasi', 'Iasi', '2014/11/14', 14);
INSERT INTO livrari VALUES (15, 'Letcani', 'Iasi', '2014/06/30', 15);
INSERT INTO livrari VALUES (16, 'Iasi', 'Iasi', '2014/04/01', 16);
INSERT INTO livrari VALUES (17, 'Podu Iloaei', 'Iasi', '2014/12/09', 17);
INSERT INTO livrari VALUES (18, 'Pascani', 'Iasi', '2013/04/12', 18);
INSERT INTO livrari VALUES (19, 'Iasi', 'Iasi', '2015/05/03', 19);
INSERT INTO livrari VALUES (20, 'Letcani', 'Iasi', '2014/10/06', 20);
INSERT INTO livrari VALUES (21, 'Targu Frumos', 'Iasi', '2015/03/14', 21);
INSERT INTO livrari VALUES (22, 'Iasi', 'Iasi', '2014/05/06', 22);
INSERT INTO livrari VALUES (23, 'Targu Frumos', 'Iasi', '2013/07/22', 23);
INSERT INTO livrari VALUES (24, 'Pascani', 'Iasi', '2014/11/28', 24);
INSERT INTO livrari VALUES (25, 'Iasi', 'Iasi', '2013/12/15', 25);
INSERT INTO livrari VALUES (26, 'Targu Frumos', 'Iasi', '2015/08/10', 26);
INSERT INTO livrari VALUES (27, 'Iasi', 'Iasi', '2014/04/23', 27);
INSERT INTO livrari VALUES (28, 'Letcani', 'Iasi', '2015/10/07', 28);
INSERT INTO livrari VALUES (29, 'Targu Frumos', 'Iasi', '2014/01/12', 29);
INSERT INTO livrari VALUES (30, 'Iasi', 'Iasi', '2013/09/01', 30);

INSERT INTO comenzi VALUES (101, '2014/04/14', 'In curs de livrare', 1, 1);
INSERT INTO comenzi VALUES (102, '2014/07/05', 'In curs de livrare', 2, 3);
INSERT INTO comenzi VALUES (103, '2015/03/18', 'In procesare', 3, 4);
INSERT INTO comenzi VALUES (104, '2014/06/25', 'In curs de livrare', 4, 5);
INSERT INTO comenzi VALUES (105, '2015/02/13', 'In procesare', 5, 6);
INSERT INTO comenzi VALUES (106, '2013/06/03', 'In curs de livrare', 6, 7);
INSERT INTO comenzi VALUES (107, '2013/04/25', 'In curs de livrare', 7, 8);
INSERT INTO comenzi VALUES (108, '2014/05/04', 'In procesare', 8, 9);
INSERT INTO comenzi VALUES (109, '2013/05/29', 'In procesare', 9, 11);
INSERT INTO comenzi VALUES (110, '2014/01/30', 'In curs de livrare', 10, 14);
INSERT INTO comenzi VALUES (111, '2013/03/15', 'In procesare', 11, 21);
INSERT INTO comenzi VALUES (112, '2013/09/23', 'In curs de livrare', 12, 22);
INSERT INTO comenzi VALUES (113, '2015/03/22', 'In curs de livrare', 13, 23);
INSERT INTO comenzi VALUES (114, '2014/11/14', 'In procesare', 14, 24);
INSERT INTO comenzi VALUES (115, '2014/06/30', 'In curs de livrare', 15, 25);
INSERT INTO comenzi VALUES (116, '2014/04/01', 'In procesare', 16, 26);
INSERT INTO comenzi VALUES (117, '2014/12/09', 'In procesare', 17, 27);
INSERT INTO comenzi VALUES (118, '2013/04/12', 'In curs de livrare', 18, 28);
INSERT INTO comenzi VALUES (119, '2015/05/03', 'In procesare', 19, 29);
INSERT INTO comenzi VALUES (120, '2014/10/06', 'In curs de livrare', 20, 30);
INSERT INTO comenzi VALUES (121, '2015/03/14', 'In curs de livrare', 21, 31);
INSERT INTO comenzi VALUES (122, '2014/05/06', 'In procesare', 22, 32);
INSERT INTO comenzi VALUES (123, '2013/07/22', 'In procesare', 23, 33);
INSERT INTO comenzi VALUES (124, '2014/11/28', 'In curs de livrare', 24, 34);
INSERT INTO comenzi VALUES (125, '2013/12/15', 'In curs de livrare', 25, 35);
INSERT INTO comenzi VALUES (126, '2015/08/10', 'In procesare', 26, 36);
INSERT INTO comenzi VALUES (127, '2014/04/23', 'In procesare', 27, 37);
INSERT INTO comenzi VALUES (128, '2015/10/07', 'In curs de livrare', 28, 38);
INSERT INTO comenzi VALUES (129, '2014/01/12', 'In procesare', 29, 39);
INSERT INTO comenzi VALUES (130, '2013/09/01', 'In curs de livrare', 30, 40);

INSERT INTO cantitati_comandate VALUES (101, 3, 2);
INSERT INTO cantitati_comandate VALUES (102, 1, 14);
INSERT INTO cantitati_comandate VALUES (103, 4, 20);
INSERT INTO cantitati_comandate VALUES (103, 5, 17);
INSERT INTO cantitati_comandate VALUES (104, 7, 3);
INSERT INTO cantitati_comandate VALUES (104, 10, 2);
INSERT INTO cantitati_comandate VALUES (105, 13, 8);
INSERT INTO cantitati_comandate VALUES (106, 12, 3);
INSERT INTO cantitati_comandate VALUES (106, 14, 4);
INSERT INTO cantitati_comandate VALUES (106, 15, 9);
INSERT INTO cantitati_comandate VALUES (107, 11, 1);
INSERT INTO cantitati_comandate VALUES (108, 2, 16);
INSERT INTO cantitati_comandate VALUES (109, 6, 2);
INSERT INTO cantitati_comandate VALUES (109, 9, 3);
INSERT INTO cantitati_comandate VALUES (110, 8, 25);
INSERT INTO cantitati_comandate VALUES (111, 1, 19);
INSERT INTO cantitati_comandate VALUES (111, 3, 2);
INSERT INTO cantitati_comandate VALUES (112, 6, 3);
INSERT INTO cantitati_comandate VALUES (113, 8, 23);
INSERT INTO cantitati_comandate VALUES (113, 11, 2);
INSERT INTO cantitati_comandate VALUES (114, 14, 4);
INSERT INTO cantitati_comandate VALUES (114, 15, 14);
INSERT INTO cantitati_comandate VALUES (115, 10, 2);
INSERT INTO cantitati_comandate VALUES (116, 7, 1);
INSERT INTO cantitati_comandate VALUES (116, 9, 2);
INSERT INTO cantitati_comandate VALUES (117, 4, 17);
INSERT INTO cantitati_comandate VALUES (118, 5, 6);
INSERT INTO cantitati_comandate VALUES (118, 8, 17);
INSERT INTO cantitati_comandate VALUES (119, 13, 7);
INSERT INTO cantitati_comandate VALUES (120, 12, 9);

INSERT INTO adrese_livrare VALUES (101, 1001, 'Str. Ion Ionescu, Nr. 9');
INSERT INTO adrese_livrare VALUES (102, 1002, 'Bvd. Carol I, Nr. 43');
INSERT INTO adrese_livrare VALUES (103, 1002, 'Str. Elena Maria, Nr. 100');
INSERT INTO adrese_livrare VALUES (104, 1003, 'Bvd. Mihai Eminescu, Nr. 10');
INSERT INTO adrese_livrare VALUES (105, 1004, 'Str. Alexandru Cel Mare, Nr. 67');
INSERT INTO adrese_livrare VALUES (106, 1005, 'Str. Vama Veche, Nr. 19');
INSERT INTO adrese_livrare VALUES (107, 1005, 'Bvd. Gheorghe Asachi, Nr. 23');
INSERT INTO adrese_livrare VALUES (108, 1005, 'Str. Mihail Kogalniceanu, Nr. 290');
INSERT INTO adrese_livrare VALUES (109, 1006, 'Str. Soarelui, Nr. 421');
INSERT INTO adrese_livrare VALUES (110, 1007, 'Bvd. Ion Creanga, Nr. 202');
INSERT INTO adrese_livrare VALUES (111, 1007, 'Bvd. Cuza Voda, Nr. 60');
INSERT INTO adrese_livrare VALUES (112, 1008, 'Str. Dimitrie Cantemir, Nr. 405');
INSERT INTO adrese_livrare VALUES (113, 1009, 'Str. Avram Iancu, Nr 56');
INSERT INTO adrese_livrare VALUES (114, 1010, 'Bvd. Mihai Bravu, Nr. 7');
INSERT INTO adrese_livrare VALUES (115, 1010, 'Str. Independentei, Nr. 20');
INSERT INTO adrese_livrare VALUES (116, 1011, 'Bvd. Voievozilor, Nr. 3');
INSERT INTO adrese_livrare VALUES (117, 1012, 'Str. Mihail Cioran, Nr. 960');
INSERT INTO adrese_livrare VALUES (118, 1013, 'Str. Ioan Cel Mare, Nr. 37');
INSERT INTO adrese_livrare VALUES (119, 1014, 'Str. Castanilor, Nr. 86');
INSERT INTO adrese_livrare VALUES (120, 1014, 'Str. Palat, Nr. 12');
INSERT INTO adrese_livrare VALUES (121, 1015, 'Bvd. Victoria, Nr. 30');
INSERT INTO adrese_livrare VALUES (122, 1015, 'Str. Bradului, Nr. 35');
INSERT INTO adrese_livrare VALUES (123, 1016, 'Str. Epavelor, Nr. 346');
INSERT INTO adrese_livrare VALUES (124, 1017, 'Bvd. Regina Alba, Nr. 149');
INSERT INTO adrese_livrare VALUES (125, 1017, 'Str. Fagului, Nr. 23');
INSERT INTO adrese_livrare VALUES (126, 1017, 'Str. Sf. Lazar, Nr. 564');
INSERT INTO adrese_livrare VALUES (127, 1018, 'Str. Pantelimon, Nr. 25');
INSERT INTO adrese_livrare VALUES (128, 1019, 'Bvd. Aurel Vlaicu, Nr. 12');
INSERT INTO adrese_livrare VALUES (129, 1019, 'Str. Emil Racovita, Nr. 6');
INSERT INTO adrese_livrare VALUES (130, 1020, 'Str. Toma Cozma, Nr. 8');

INSERT INTO incasari VALUES (1, 1, '2014/01/12', 'Numerar', 24.50);
INSERT INTO incasari VALUES (2, 2, '2014/02/14', 'Card', 20);
INSERT INTO incasari VALUES (3, 3, '2014/03/16', 'Cec', 200.60);
INSERT INTO incasari VALUES (4, 4, '2014/03/18', 'Cec', 78);
INSERT INTO incasari VALUES (5, 5, '2014/04/22', 'Numerar', 97.80);
INSERT INTO incasari VALUES (6, 6, '2014/05/26', 'Cec', 123.80);
INSERT INTO incasari VALUES (7, 7, '2014/06/04', 'Card', 45.00);
INSERT INTO incasari VALUES (8, 8, '2014/05/07', 'Numerar', 43.20);
INSERT INTO incasari VALUES (9, 9, '2014/06/19', 'Cec', 134.90);
INSERT INTO incasari VALUES (10, 10, '2014/07/23', 'Numerar', 42.50);
INSERT INTO incasari VALUES (11, 11, '2014/08/27', 'Card', 110.60);
INSERT INTO incasari VALUES (12, 12, '2014/09/06', 'Card', 9);
INSERT INTO incasari VALUES (13, 13, '2014/10/09', 'Numerar', 40);
INSERT INTO incasari VALUES (14, 14, '2014/10/23', 'Cec', 59.1);
INSERT INTO incasari VALUES (15, 15, '2014/11/25', 'Numerar', 77.5);
INSERT INTO incasari VALUES (16, 16, '2014/12/13', 'Cec', 30);
INSERT INTO incasari VALUES (17, 17, '2014/12/16', 'Card', 115);
INSERT INTO incasari VALUES (18, 18, '2015/02/22', 'Numerar', 38);
INSERT INTO incasari VALUES (19, 19, '2015/03/28', 'Card', 31.5);
INSERT INTO incasari VALUES (20, 20, '2015/04/30', 'Cec', 76.5);
INSERT INTO incasari VALUES (21, 21, '2013/02/11', 'Numerar', 65.00);
INSERT INTO incasari VALUES (22, 22, '2013/05/25', 'Cec', 105.70);
INSERT INTO incasari VALUES (23, 23, '2013/08/19', 'Card', 73.40);
INSERT INTO incasari VALUES (24, 24, '2013/09/12', 'Numerar', 63.30);
INSERT INTO incasari VALUES (25, 25, '2013/11/08', 'Cec', 42.00);
INSERT INTO incasari VALUES (26, 26, '2013/12/05', 'Numerar', 61.30);
INSERT INTO incasari VALUES (27, 27, '2014/03/23', 'Card', 37.80);
INSERT INTO incasari VALUES (28, 28, '2014/07/30', 'Cec', 121.3);
INSERT INTO incasari VALUES (29, 29, '2015/02/15', 'Card', 19.90);
INSERT INTO incasari VALUES (30, 30, '2015/04/18', 'Numerar', 26.30);

INSERT INTO retururi VALUES (1, '2014/04/14', 'Comanda gresita', 1);
INSERT INTO retururi VALUES (2, '2015/02/13', 'Comanda necorespunzatoare', 5);
INSERT INTO retururi VALUES (3, '2014/05/04', 'Comanda necorespunzatoare', 8);
INSERT INTO retururi VALUES (4, '2014/01/30', 'Comanda gresita', 10);
INSERT INTO retururi VALUES (5, '2013/03/15', 'Comanda necorespunzatoare', 11);
INSERT INTO retururi VALUES (6, '2015/03/22', 'Comanda gresita', 13);
INSERT INTO retururi VALUES (7, '2014/06/30', 'Comanda necorespunzatoare', 15);
INSERT INTO retururi VALUES (8, '2014/04/01', 'Comanda gresita', 16);
INSERT INTO retururi VALUES (9, '2013/04/12', 'Comanda gresita', 18);
INSERT INTO retururi VALUES (10, '2014/10/06', 'Comanda necorespunzatoare', 20);

INSERT INTO cantitati_returnate VALUES (1, 101, 1, 3);
INSERT INTO cantitati_returnate VALUES (2, 105, 11, 2);
INSERT INTO cantitati_returnate VALUES (3, 108, 4, 2);
INSERT INTO cantitati_returnate VALUES (4, 110, 2, 7);
INSERT INTO cantitati_returnate VALUES (5, 111, 3, 1);
INSERT INTO cantitati_returnate VALUES (6, 113, 12, 2);
INSERT INTO cantitati_returnate VALUES (7, 115, 5, 7);
INSERT INTO cantitati_returnate VALUES (8, 116, 2, 4);
INSERT INTO cantitati_returnate VALUES (9, 118, 11, 1);
INSERT INTO cantitati_returnate VALUES (10, 120, 15, 3);

INSERT INTO comenzi_productie VALUES (1, '2013/09/19', 'Deschisa');
INSERT INTO comenzi_productie VALUES (2, '2013/11/14', 'In procesare');
INSERT INTO comenzi_productie VALUES (3, '2014/02/18', 'Inchisa');
INSERT INTO comenzi_productie VALUES (4, '2014/03/15', 'Deschisa');
INSERT INTO comenzi_productie VALUES (5, '2014/03/31', 'In procesare');
INSERT INTO comenzi_productie VALUES (6, '2014/04/19', 'Deschisa');
INSERT INTO comenzi_productie VALUES (7, '2014/05/02', 'Inchisa');
INSERT INTO comenzi_productie VALUES (8, '2014/05/04', 'Deschisa');
INSERT INTO comenzi_productie VALUES (9, '2014/06/12', 'In procesare');
INSERT INTO comenzi_productie VALUES (10, '2014/07/17', 'In procesare');
INSERT INTO comenzi_productie VALUES (11, '2014/09/23', 'Inchisa');
INSERT INTO comenzi_productie VALUES (12, '2014/12/30', 'Deschisa');
INSERT INTO comenzi_productie VALUES (13, '2015/03/19', 'In procesare');
INSERT INTO comenzi_productie VALUES (14, '2015/04/16', 'Inchisa');
INSERT INTO comenzi_productie VALUES (15, '2015/04/23', 'In procesare');

INSERT INTO cantitati_produse VALUES (1, 1, 30);
INSERT INTO cantitati_produse VALUES (2, 6, 3);
INSERT INTO cantitati_produse VALUES (3, 9, 2);
INSERT INTO cantitati_produse VALUES (4, 2, 25);
INSERT INTO cantitati_produse VALUES (5, 3, 4);
INSERT INTO cantitati_produse VALUES (6, 4, 18);
INSERT INTO cantitati_produse VALUES (7, 5, 20);
INSERT INTO cantitati_produse VALUES (8, 13, 16);
INSERT INTO cantitati_produse VALUES (8, 15, 24);
INSERT INTO cantitati_produse VALUES (9, 7, 3);
INSERT INTO cantitati_produse VALUES (10, 8, 40);
INSERT INTO cantitati_produse VALUES (10, 9, 2);
INSERT INTO cantitati_produse VALUES (11, 2, 35);
INSERT INTO cantitati_produse VALUES (12, 6, 4);
INSERT INTO cantitati_produse VALUES (13, 10, 7);
INSERT INTO cantitati_produse VALUES (13, 12, 16);
INSERT INTO cantitati_produse VALUES (14, 11, 3);
INSERT INTO cantitati_produse VALUES (14, 1, 28);
INSERT INTO cantitati_produse VALUES (15, 14, 5);
INSERT INTO cantitati_produse VALUES (15, 7, 2);