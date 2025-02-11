---- DROPAR AS TABELAS NA ORDEM CORRETA

---- 1. Excluir as tabelas que têm dependências em outras, começando pelas que não têm dependência
--DROP TABLE IF EXISTS tblAtividadeTreino;
--DROP TABLE IF EXISTS tblFicha;
--DROP TABLE IF EXISTS tblPagamento;
--DROP TABLE IF EXISTS tblImc;
--DROP TABLE IF EXISTS tblAtividade;

---- 2. Excluir tabelas sem dependências
----DROP TABLE IF EXISTS tblAparelho;
----DROP TABLE IF EXISTS tblModo;
--DROP TABLE IF EXISTS tblStatus;
--DROP TABLE IF EXISTS tblMusculo;
--DROP TABLE IF EXISTS tblExercicio;
--DROP TABLE IF EXISTS tblPlano;
--DROP TABLE IF EXISTS tblAluno;
--drop table if exists tblUsuario;
--GO
-- Dropar tabelas de relacionamento que possuem dependências de chave estrangeira
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
