--Constraint NOT NULL(Valor não pode ser nulo)

--Constraints UNIQUE(valor unico sem repeticao na tabela)
ALTER TABLE Produtos ADD UNIQUE(Nome);


--Constraints Ckeck(verifica uma Determinada condição na tabela)
ALTER TABLE Produtos 
ADD CONSTRAINT Chk_ColunaGenero CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F');


--Constraint Default(define um valor padrão para o campo na tabela)
ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro;


--Apagando constraint
ALTER TABLE Produtos 
DROP CONSTRAINT DF__Produtos__DataCa__300424B4;