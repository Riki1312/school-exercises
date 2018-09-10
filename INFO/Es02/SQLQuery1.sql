SELECT Citta.stringa, COUNT(*) AS numAbbonamenti FROM  Abbonato, Citta
WHERE Abbonato.citta = Citta.id_citta AND Abbonato.id_abbonato IN (SELECT DISTINCT id_abbonato FROM Abbonamento)
GROUP BY Citta.stringa 
HAVING COUNT(*)>1

SELECT DISTINCT id_abbonato FROM Abbonamento