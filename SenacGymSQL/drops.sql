---- DROPAR AS TABELAS NA ORDEM CORRETA

---- 1. Excluir as tabelas que t�m depend�ncias em outras, come�ando pelas que n�o t�m depend�ncia
--DROP TABLE IF EXISTS tblAtividadeTreino;
--DROP TABLE IF EXISTS tblFicha;
--DROP TABLE IF EXISTS tblPagamento;
--DROP TABLE IF EXISTS tblImc;
--DROP TABLE IF EXISTS tblAtividade;

---- 2. Excluir tabelas sem depend�ncias
----DROP TABLE IF EXISTS tblAparelho;
----DROP TABLE IF EXISTS tblModo;
--DROP TABLE IF EXISTS tblStatus;
--DROP TABLE IF EXISTS tblMusculo;
--DROP TABLE IF EXISTS tblExercicio;
--DROP TABLE IF EXISTS tblPlano;
--DROP TABLE IF EXISTS tblAluno;
--drop table if exists tblUsuario;
--GO
-- Dropar tabelas de relacionamento que possuem depend�ncias de chave estrangeira
DROP TABLE IF EXISTS tblAtividade;
DROP TABLE IF EXISTS tblExercicio;
DROP TABLE IF EXISTS tblMusculo;
DROP TABLE IF EXISTS tblPagamento;
--DROP TABLE IF EXISTS tblStatus;
DROP TABLE IF EXISTS tblPlano;
DROP TABLE IF EXISTS tblImc;
--DROP TABLE IF EXISTS tblFicha;
DROP TABLE IF EXISTS tblAluno;
DROP TABLE IF EXISTS tblUsuario;
