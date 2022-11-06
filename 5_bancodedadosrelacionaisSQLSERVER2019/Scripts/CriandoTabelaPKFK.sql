CREATE TABLE Enderecos(
	Id int PRIMARY KEY IDENTITY (1,1)NOT NULL, --chave primaria
	IdCliente  int NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL

	CONSTRAINT FK_Enderevos_Clientes FOREIGN KEY(IdCliente)  --criando a chave estrangeira referenciando a tabela 
	REFERENCES Clientes(Id)
);


SELECT * FROM Enderecos;


INSERT INTO Enderecos VALUES(1,'RUA TESTE','TESTEBAIRRO','CIDADETESTE','PB');

SELECT * FROM Clientes
WHERE Id = 1;

SELECT * FROM Enderecos
WHERE IdCliente = 1;


