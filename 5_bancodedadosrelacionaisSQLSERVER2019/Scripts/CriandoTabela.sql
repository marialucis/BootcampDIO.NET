CREATE TABLE TesteProd(
	Id int IDENTITY(1,1) NOT NULL,
	Nome varchar(255)  NOT NULL,
	Cor varchar(50)  NULL,
	Preco decimal (13,2) NOT NULL,
	Tamanho varchar(5) NULL,
	Genero char(1) NULL

)

--IDENTITY É UM AUTOINCREMENT
