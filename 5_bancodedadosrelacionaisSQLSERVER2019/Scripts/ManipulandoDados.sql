SELECT * FROM TesteProd;

SELECT * FROM Produtos;


--inserindo registro a partir de outra tabela
INSERT INTO TesteProd
SELECT  Nome, Cor, Preco, Tamanho,Genero FROM Produtos;




--Usando o COUNT para contabilizar a quantidade de registro
SELECT COUNT(Id) AS 'QTD PESSOAS' FROM Clientes;

SELECT COUNT(*) AS 'QTD PESSOAS' FROM Clientes;

SELECT COUNT(Genero) AS 'UNISSEX' FROM TesteProd
WHERE Genero = 'U';




--Usando o SUM
SELECT SUM(Preco) AS 'PrecoTotal'FROM TesteProd;

SELECT SUM(Preco) AS 'PrecoTotalTamanhoM'FROM TesteProd
WHERE Tamanho = 'M';


--Usando o MAX
SELECT MAX(Preco) AS 'ProdMaisCaroM' FROM Produtos
WHERE Tamanho = 'P';

--Usando MIN
SELECT MIN(Preco) AS 'ProdMaisBaratoM' FROM Produtos;

--Usando AVG para media
SELECT AVG(Preco) AS 'ProdMedia' FROM Produtos;




--Concatenando colunas
SELECT
	Nome + ', Cor: ' + Cor + ', Genero: ' + Genero AS 'Descricao Produtos'
FROM Produtos


--Deixando Texto Maiusculo com UPPER e Minusculo com LOWER
SELECT
	Nome + ', Cor: ' + Cor + ', Genero: ' + Genero AS 'Descricao Produtos',
	UPPER(Nome) AS 'Nome',
	LOWER(Cor) AS 'Cor'
FROM Produtos;



--Adicionando uma nova coluna
ALTER TABLE Produtos ADD
DataCadastro DATETIME2;

--Atualizando o campo data 
UPDATE Produtos
SET DataCadastro = GETDATE();

--Remnovendo coluna
ALTER TABLE Produtos
DROP COLUMN DataCadastro;



--Formatando data
SELECT
	Nome + ', Cor: ' + Cor + ', Genero: ' + Genero AS 'Descricao Produtos',
	UPPER(Nome) AS 'Nome',
	LOWER(Cor) AS 'Cor',
	FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') AS 'Data'
FROM Produtos;



--Usando o Group By
SELECT 
	Tamanho,
	COUNT(*) AS 'QTD'
	FROM Produtos
	WHERE Tamanho <> ''
	GROUP BY Tamanho
	ORDER BY QTD DESC;