DROP TABLE Categoria
CREATE TABLE Categoria(
Id Int IDENTITY PRIMARY KEY
, Nome VARCHAR(30) NOT NULL
, Descricao VARCHAR(100) NULL
, DataCadastro DATETIME DEFAULT(GETDATE())
);

DROP TABLE Pizza
CREATE TABLE Pizza(
Id Int IDENTITY PRIMARY KEY
, Nome VARCHAR(30) NOT NULL
, Descricao VARCHAR(200) NULL
, FotoBase64 VARCHAR(MAX) NULL
, DataCadastro DATETIME DEFAULT(GETDATE())
, CategoriaId Int NOT NULL
, Valor DECIMAL(8,2) NOT NULL
, CONSTRAINT fk_pizza_idcategoria FOREIGN KEY(CategoriaId) REFERENCES Categoria(Id)
)

INSERT INTO CATEGORIA VALUES ('DOCE', 'PIZZA DOCE', 1);
INSERT INTO CATEGORIA VALUES ('SALGADA', 'PIZZA SALGADA', 2);
INSERT INTO CATEGORIA VALUES ('BROTINHO', 'PIZZA BROTINHO', 3);

select * from Categoria

INSERT INTO Pizza
(Nome, Descricao, CategoriaId, Valor)
VALUES
('Pizza de Mussarela', 'Pizza com mussarela, massa de tomate e azeitona', 1, 10.20)

select * from pizza

CREATE TABLE UsuarioLogin(
	Id Int IDENTITY PRIMARY KEY
	,Nome VARCHAR(150) NOT NULL
	,Email VARCHAR(150) NOT NULL
	,Senha VARCHAR(500) NOT NULL
) 

INSERT INTO UsuarioLogin
(Nome, Email, Senha)
VALUES
('Vera', 'veluccg@gmail.com', '')

SELECT * FROM UsuarioLogin


