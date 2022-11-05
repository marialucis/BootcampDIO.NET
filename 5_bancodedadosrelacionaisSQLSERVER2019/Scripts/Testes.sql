SELECT * FROM Clientes;

--inserindo registro na tabela
INSERT INTO Clientes VALUES ('Luciclene', 'Santos', 'email@email.com', 1, GETDATE());


--consultando nome
SELECT * FROM Clientes 
WHERE Nome LIKE 'Luci%';


--atualizando registro na tabela
UPDATE Clientes 
SET Email = 'lux@email.com', 
	AceitaComunicados = 0
WHERE Id = 289;

--deletando registro

DELETE FROM Clientes 
WHERE Id = 205;

--desfazendo coomits
BEGIN TRAN -- antes de executar o update sem WHERE, execta o BEGIN TRAN
ROLLBACK --Após o update para desfazer o commit errado, executa o ROLLBACK
