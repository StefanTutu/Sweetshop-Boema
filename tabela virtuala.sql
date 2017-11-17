-- Tabela virtuala pentru salariile angajatilor

Create view salarii_angajati as (
SELECT DISTINCT ON (numeprenangajat)
       numeprenangajat,functie,salariu,datamodifsalariu
FROM   angajati a inner join salarii s on a.idAngajat=s.idAngajat
ORDER  BY numeprenangajat, datamodifsalariu DESC);

select * from salarii_angajati

----------------------------------------------------------------------------------------------

     select numeprenangajat , functie , salariu , datamodifsalariu
from salarii_angajati

select * from produse


CREATE VIEW cost_total_productie AS
(SELECT denProdus, denMatPrima, cantMP_UnitProd, PretUnitMatPrima FROM  produse p 
INNER JOIN reteta_produs r ON p.idProdus=r.idProdus 
INNER JOIN materii_prime m ON r.idMatPrima=m.idMatPrima)
--------------------------------------------------------------------------------------------------
Drop view clientiincasari;

CREATE OR REPLACE VIEW clientiincasari AS 
 SELECT clienti.codcl,numeCl,
    incasari.idincasare,
    incasari.idbonfiscal,
    incasari.dataincasare,
    incasari.modplata,
    incasari.sumaincasata
   FROM clienti
     JOIN adrese_livrare ON clienti.codcl = adrese_livrare.codcl
     JOIN comenzi ON adrese_livrare.nrcomanda = comenzi.nrcomanda
     JOIN incasari ON comenzi.idbonfiscal = incasari.idbonfiscal;

--------------------------------------------------------------------------------------------------

CREATE OR REPLACE VIEW clienti_livrari AS 
 SELECT clienti.codcl,
    comenzi.nrcomanda,
    comenzi.datacomanda,
    comenzi.statuscomanda,
    comenzi.idlivrare,
    comenzi.idbonfiscal
   FROM clienti
     JOIN adrese_livrare ON clienti.codcl = adrese_livrare.codcl
     JOIN comenzi ON adrese_livrare.nrcomanda = comenzi.nrcomanda;
     
----------------------------------------------------------------------------------------------------
Select produse.idProdus , denProdus,idComandaProductie,CantitateProdusa from produse inner join cantitati_produse on produse.idprodus=cantitati_produse.idprodus

-----------------------------------------------------------------------------------------------------------------
SELECT discount.idDiscount , tipdiscount , idbf_comanda , nrliniebf_comanda, pretcudiscount from discount inner join bonuri_fiscale_comenzi on discount.iddiscount=bonuri_fiscale_comenzi.iddiscount order by iddiscount

-----------------------------------------------------------------------------------------------------------------------------
CREATE VIEW localitateLivrare as(
select loclivrare , count(idLivrare) as totalLivrari
from livrari
group by locLivrare);
---------------------------------------------------------------------------------------------------------------