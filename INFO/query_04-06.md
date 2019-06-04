# Query 04/06/2019

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
