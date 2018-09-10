SELECT COUNT(*) FROM Rivista, Abbonamento
WHERE Abbonamento.periodo = 1 AND 
id_rivista = cod_rivista AND 
Rivista.titolo like 'La fedeltà'