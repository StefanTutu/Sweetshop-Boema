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
	--Aici nu mergea cu idBF_Comanda (cu legatura la clauza UNIQUE) !!
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
	--Se încaseaza câte un singur bon fiscal o data !!
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