-- CRIANDO TABELAS REFERENTES A ALUNO E PLANO

/* CRIANDO TABELAS REFERENTES A ALUNO E PLANO */

CREATE TABLE tblUsuario (
id int identity primary key,
login varchar(100),
nome varchar(100),
password varchar(32),
ativo bit
)

insert into tblUsuario
values (
'a','Testador','0cc175b9c0f1b6a831c399e269772661',1)

CREATE TABLE tblAluno (
    id                    INT IDENTITY(1,1) PRIMARY KEY,             -- ID único para cada aluno
    nome                  VARCHAR(100) NOT NULL,					 -- Nome do aluno
    telefone			  VARCHAR(15),                               -- Telefone
    dataNascimento        DATE,                                      -- Data de nascimento do aluno
    email				  VARCHAR(100) UNIQUE,                       -- Email do aluno
	ativoAte			  DATE										 -- Até quando o aluno estará ativo
);
GO


CREATE TABLE tblImc (
    id                     INT IDENTITY(1,1) PRIMARY KEY,            -- ID único para cada IMC
    idAluno                INT NOT NULL,                             -- Chave estrangeira para o aluno
    peso                   DECIMAL(5,2) NOT NULL,                    -- Peso em kg, com precisão de 2 casas decimais
    altura                 DECIMAL(5,2) NOT NULL,                    -- Altura em metros, com precisão de 2 casas decimais
    data                   DATE DEFAULT GETDATE(),                   -- Data do IMC
    FOREIGN KEY (idAluno) REFERENCES tblAluno(id)                    -- Relacionamento com Aluno
);
GO



CREATE TABLE tblPlano (
    id                      INT IDENTITY(1,1) PRIMARY KEY,             -- Chave primária 'id'
    nome                    VARCHAR(50) NOT NULL,                      -- Nome do plano (ex: Diário, Mensal, etc.)
    descricao				VARCHAR(255),                              -- Descrição do plano
    valor					DECIMAL(10, 2) NOT NULL,                   -- Valor do plano
    duracao				    INT NOT NULL                               -- Duração do plano em dias
);
GO

/* INSERT PLANOS */
INSERT INTO tblPlano (nome, descricao, valor, duracao)
VALUES 
    ('Diário', 'Plano com acesso diário à academia.', 10.00, 1),         -- 1 dia
    ('Mensal', 'Plano com acesso durante 30 dias.', 50.00, 30),          -- 30 dias
    ('Trimestral', 'Plano com acesso durante 3 meses.', 140.00, 90),     -- 90 dias
    ('Anual', 'Plano com acesso durante 12 meses.', 500.00, 365);        -- 365 dias
GO

--create table tblStatus (
--	id               INT IDENTITY(1,1) PRIMARY KEY,  
--	status			varchar(50)
--)

CREATE TABLE tblPagamento (
    id               INT IDENTITY(1,1) PRIMARY KEY,             -- ID único para cada pagamento
    idAluno          INT NOT NULL,                               -- Chave estrangeira para o aluno
    idPlano          INT NOT NULL,                               -- Chave estrangeira para o plano
    valorPagamento   DECIMAL(10, 2) NOT NULL,                   -- Valor do pagamento
	--idStatus		 int not null,
    dataPagamento    DATETIME DEFAULT GETDATE(),                -- Data do pagamento
    FOREIGN KEY (idAluno) REFERENCES tblAluno(id),             -- Relacionamento com Aluno
    FOREIGN KEY (idPlano) REFERENCES tblPlano(id),              -- Relacionamento com Plano
--	foreign key (idStatus) references tblStatus(id)

);
GO



/* CRIANDO TABELAS DE MÚSCULOS, TIPOS E APARELHOS */

CREATE TABLE tblMusculo (
    id                   INT IDENTITY(1,1) PRIMARY KEY,             -- Chave primária 'id'
    nome                 VARCHAR(100) NOT NULL
);
GO

/*
CREATE TABLE tblModo (
    id                   INT IDENTITY(1,1) PRIMARY KEY,             -- Chave primária 'id'
    nome                 VARCHAR(50) NOT NULL
);
GO
*/

/*
CREATE TABLE tblAparelho (
    id                   INT IDENTITY(1,1) PRIMARY KEY,             -- Chave primária 'id'
    nome                 VARCHAR(100) NOT NULL
);
GO


*/
-- Criar tabela para exercícios


CREATE TABLE tblExercicio (
    id                   INT IDENTITY(1,1) PRIMARY KEY,
    nome                 VARCHAR(100) NOT NULL
);
GO


CREATE TABLE tblAtividade (
    id                   INT IDENTITY(1,1) PRIMARY KEY,             -- Chave primária 'id'
    idMusculo            INT NOT NULL,
	idExercicio          INT NOT NULL,
	idAluno				 INT NOT NULL,
	comentario           VARCHAR(100),
	serie				 int,
	repeticao            int,
	treino			 	 varchar(100),
	FOREIGN KEY (idExercicio) REFERENCES tblExercicio(id),
	FOREIGN KEY (idMusculo)		  REFERENCES tblMusculo(id),
	FOREIGN KEY (idAluno) REFERENCES tblAluno(id),
	--idModo               INT NOT NULL,                              -- Relacionamento com a tabela Modo
	--idAparelho           INT NOT NULL,                              -- Relacionamento com a tabela Aparelho
	--FOREIGN KEY (idModo)	   	  REFERENCES tblModo(id),
    --FOREIGN KEY (idAparelho)	  REFERENCES tblAparelho(id),
);
GO



--CREATE TABLE tblFicha (
--    id                     INT IDENTITY(1,1) PRIMARY KEY,             -- ID único para cada ficha
--    idAluno                INT NOT NULL,                              -- Relacionamento com a tabela Aluno

--    FOREIGN KEY (idAluno)  REFERENCES tblAluno(id),

--);
--GO
