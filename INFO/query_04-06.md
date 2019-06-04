# Query 04/06/2019

SCHEMA LOGICO gestione magazzino

fornitori (idFornitore, nome, indirizzo, citta, email, telefono)
clienti (idCliente, nome, indirizzo, citta, email, telefono)
categorie (idCategoria, categoria, iva)
articoli (idArticolo, descrizione, prezzo, quantita, scortaMinima, idCategoria, idFornitore)
fatture (idFattura, pagata, data, idCliente)
righeFattura (idFattura, idArticolo,  prezzo, quantita)

QUERY:
1.	per ogni categoria visualizzare i prodotti, riportando anche le categorie senza prodotti
2.	elenco fornitore per ogni prodotto compresi i fornitori che non forniscono prodotti
3.	i due prodotti più venduti
4.	prodotti mai venduti nell’anno in corso
5.	cliente con totale importo  maggiore (importo comprensivo di IVA)
6.	fatture ancora da pagare 
7.	fatture ancora da pagare in ritardo (passati i 30 giorni)
8.	importo delle fatture suddiviso per mese e anno

---

1)
SELECT DISTINCT c.Categoria, a.descrizione
FROM Categorie as c LEFT JOIN Articoli as a OS c.IdCategoria = a.IdCategoria

2)
SELECT DISTINCT f.Nome, a.descrizione
FROM Fornitori as c LEFT JOIN Articoli as a OS c.IdFornitore = a.IdFornitore

3)
SELECT TOP 2 WITH TIES a.Dscrizione
FROM Articoli as a, RigheFattura rf
WHERE rf.IdArticolo = a.IdArticolo
GROUP BY a.Dscrizione
ORDER BY SUM(rf.Quantita) desc

4)
SELECT a.Descrizione
FROM Articoli as a, Fatture as f, RigheFattura as rf
WHERE rf.IdArticolo != a.IdArticolo AND f.IdFattura = rf.IdFattura AND YEAR(f.Data) = YEAR(GETDATE())

4)
SELECT idArticolo 
FROM Articoli, 
(
  SELECT a.IdArticolo
  FROM Articoli as a, Fatture as f, RigheFattura as rf
  WHERE rf.IdArticolo = a.IdArticolo AND f.IdFattura = rf.IdFattura AND YEAR(f.Data) = YEAR(GETDATE())
) as t
WHERE idArticolo NOT IN t.IdArticolo

4)
SELECT idArticolo 
FROM Articoli
WHERE idArticolo NOT IN (
  SELECT a.IdArticolo
  FROM Articoli as a, Fatture as f, RigheFattura as rf
  WHERE rf.IdArticolo = a.IdArticolo AND f.IdFattura = rf.IdFattura AND YEAR(f.Data) = YEAR(GETDATE())
)

5)
SELECT cl.Nome, SUM(rf.Prezzo + (a.Prezzo * c.Iva / 100) * rf.Quantita) as [Totale import (con iva)]
FROM Clienti as cl, Fatture as f, RigheFattura as rf, Articoli as a, Categorie as c
WHERE cl.IdCliente = f.IdCliente AND
f.IdFattura = rf.IdFattura AND
rf.IdArticolo = a.IdArticolo AND
c.IdCategoria = a.IdCategoria
GROUP BY cl.Nome

6)
SELECT IdFattura
FROM Fatture
WHERE Pagata = false

7)
SELECT IdFattura
FROM Fatture
WHERE Pagata = false AND Data <= DATEADD(DAY, -30, GETDATE())

8)
SELECT
