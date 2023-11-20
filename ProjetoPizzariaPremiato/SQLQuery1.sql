CREATE TABLE Categoria(
Id Int IDENTITY PRIMARY KEY
, Nome VARCHAR(30) NOT NULL
, Descricao VARCHAR(100) NULL
, DataCadasto DATETIME DEFAULT(GETDATE())
);

CREATE TABLE Pizza(
Id Int IDENTITY PRIMARY KEY
, Nome VARCHAR(30) NOT NULL
, Descricao VARCHAR(200) NULL
, FotoBase64 VARCHAR(MAX) NULL
, DataCadasto DATETIME DEFAULT(GETDATE())
, IdCategoria Int NOT NULL
, CONSTRAINT fk_pizza_idcategoria FOREIGN KEY(IdCategoria) REFERENCES Categoria(Id)
)

INSERT INTO Categoria
(Nome, Descricao)
VALUES
('Salgada', '')

select * from Categoria

INSERT INTO Pizza
(Nome, Descricao, IdCategoria)
VALUES
('Pizza de Mussarela', 'Pizza com mussarela, massa de tomate e azeitona', 1)

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
('Gui', 'gui@mail.com', '123')

