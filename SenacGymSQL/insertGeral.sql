-- Inserindo os m�sculos
INSERT INTO tblMusculo (nome)
VALUES 
    ('Peito'),
    ('Ombro'),
    ('Pernas'),
    ('B�ceps'),
    ('Tr�ceps'),
    ('Costas'),
	('Abdomen'),
	('C�rdio');

-- Inserir os nomes �nicos dos exerc�cios
INSERT INTO tblExercicio (nome)
VALUES
   ('Supino'),
   ('Crucifixo'),
   ('Crossover'),
   ('Peck Deck'),
   ('Chest Press'),
   ('Pullover'),
   ('Flex�es'),
   ('Desenvolvimento'),
   ('Eleva��o Lateral'),
   ('Eleva��o Frontal'),
   ('Remada Alta'),
   ('Arnold Press'),
   ('Face Pull'),
   ('Encolhimento de Ombros'),
   ('Agachamento'),
   ('Leg Press'),
   ('Cadeira Extensora'),
   ('Passada'),
   ('Hack Squat'),
   ('Stiff'),
   ('Mesa Flexora'),
   ('Cadeira Flexora'),
   ('Rosca Direta'),
   ('Rosca Alternada'),
   ('Rosca Martelo'),
   ('Rosca Concentrada'),
   ('Rosca no Banco Scott'),
   ('Rosca Inversa'),
   ('Rosca na Polia'),
   ('Supino Fechado'),
   ('Tr�ceps Franc�s'),
   ('Tr�ceps Testa'),
   ('Tr�ceps Corda'),
   ('Tr�ceps Pulley'),
   ('Mergulho no Banco'),
   ('Kickback'),
   ('Tr�ceps M�quina'),
   ('Barra Fixa'),
   ('Puxada na Polia'),
   ('Remada Curvada'),
   ('Remada na Polia'),
   ('Remada Unilateral'),
   ('Pull-over na Polia'),
   ('Levantamento Terra'),
   ('Remada Cavalinho'),
   ('Abdominal'),
   ('Abdominal Lateral'),
   ('Prancha'),
   ('Eleva��o de Pernas'),
   ('Giro de Tronco'),
   ('Abdominal com Peso'),
   ('Crunch'),
   ('Abdominal no Banco Inclin�vel'),
   ('Flex�o de Tronco'),
   ('Abdominal com Bola'),
   ('Prancha Lateral'),
   ('Esteira'),
   ('Bicicleta'),
   ('El�ptico'),
   ('Escada'),
   ('Remo'),
   ('Air Bike'),
   ('Ski Erg'),
   ('Bicicleta Vertical'),
   ('Caminhada com Inclina��o'),
   ('Corrida com Inclina��o');


insert into tblUsuario
values 
  ('fernanda', 'Fernanda Oliveira', '4c29f94d61f96dde64a65202a6de6700', 1),
  ('ricardo', 'Ricardo Santos', '4c29f94d61f96dde64a65202a6de6700', 1),
  ('juliana', 'Juliana Pereira', '4c29f94d61f96dde64a65202a6de6700', 1),
  ('eduardo', 'Eduardo', '4c29f94d61f96dde64a65202a6de6700', 1),
  ('a', 'Testador', '0cc175b9c0f1b6a831c399e269772661', 1);

/* INSERT PLANOS */
INSERT INTO tblPlano (nome, descricao, valor, duracao)
VALUES 
    ('Di�rio', 'Plano com acesso di�rio � academia.', 10.00, 1),         -- 1 dia
    ('Mensal', 'Plano com acesso durante 30 dias.', 50.00, 30),          -- 30 dias
    ('Trimestral', 'Plano com acesso durante 3 meses.', 140.00, 90),     -- 90 dias
    ('Anual', 'Plano com acesso durante 12 meses.', 500.00, 365);        -- 365 dias
GO

INSERT INTO tblAluno (nome, telefone, dataNascimento, email, ativoAte)
VALUES 
('Ana Souza', '987654321', '2005-03-14', 'ana.souza@email.com', '2025-12-31'),
('Carlos Silva', '912345678', '2004-07-22', 'carlos.silva@email.com', '2025-12-31'),
('Fernanda Costa', '923456789', '2003-11-05', 'fernanda.costa@email.com', '2025-12-31'),
('Jo�o Oliveira', '934567890', '2004-02-17', 'joao.oliveira@email.com', '2025-12-31'),
('Mariana Lima', '945678901', '2003-06-10', 'mariana.lima@email.com', '2025-12-31'),
('Lucas Pereira', '956789012', '2004-09-23', 'lucas.pereira@email.com', '2025-12-31'),
('Julia Almeida', '967890123', '2005-01-30', 'julia.almeida@email.com', '2025-12-31'),
('Pedro Santos', '978901234', '2003-10-11', 'pedro.santos@email.com', '2025-12-31'),
('Larissa Martins', '989012345', '2004-12-12', 'larissa.martins@email.com', '2025-12-31'),
('Ricardo Gomes', '990123456', '2003-08-25', 'ricardo.gomes@email.com', '2025-12-31'),
('Sofia Rocha', '901234567', '2005-04-16', 'sofia.rocha@email.com', '2025-12-31'),
('Rafael Costa', '912345678', '2004-10-30', 'rafael.costa@email.com', '2025-12-31'),
('Camila Ferreira', '923456789', '2005-02-09', 'camila.ferreira@email.com', '2025-12-31'),
('Gustavo Ribeiro', '934567890', '2003-12-20', 'gustavo.ribeiro@email.com', '2025-12-31'),
('Beatriz Alves', '945678901', '2004-05-14', 'beatriz.alves@email.com', '2025-12-31'),
('Felipe Martins', '956789012', '2004-08-01', 'felipe.martins@email.com', '2025-12-31'),
('Viviane Pereira', '967890123', '2005-01-04', 'viviane.pereira@email.com', '2025-12-31'),
('Eduardo Silva', '978901234', '2003-09-15', 'eduardo.silva@email.com', '2025-12-31'),
('Paula Costa', '989012345', '2004-03-28', 'paula.costa@email.com', '2025-12-31'),
('Marcos Souza', '990123456', '2004-11-18', 'marcos.souza@email.com', '2025-12-31'),
('Isabela Lima', '901234567', '2005-02-20', 'isabela.lima@email.com', '2025-12-31'),
('Thiago Almeida', '912345678', '2003-04-09', 'thiago.almeida@email.com', '2025-12-31'),
('Tatiane Rocha', '923456789', '2004-01-02', 'tatiane.rocha@email.com', '2025-12-31'),
('Daniel Costa', '934567890', '2005-07-05', 'daniel.costa@email.com', '2025-12-31'),
('Renata Pereira', '945678901', '2004-12-25', 'renata.pereira@email.com', '2025-12-31'),
('Bruna Ribeiro', '956789012', '2003-05-17', 'bruna.ribeiro@email.com', '2025-12-31'),
('Marcelo Santos', '967890123', '2004-10-07', 'marcelo.santos@email.com', '2025-12-31'),
('C�ntia Lima', '978901234', '2005-06-19', 'cintia.lima@email.com', '2025-12-31'),
('Gustavo Ferreira', '989012345', '2003-01-14', 'gustavo.ferreira@email.com', '2025-12-31'),
('Elaine Souza', '990123456', '2004-04-29', 'elaine.souza@email.com', '2025-12-31'),
('M�rio Silva', '901234567', '2004-10-22', 'mario.silva@email.com', '2025-12-31'),
('Roberta Costa', '912345678', '2005-08-12', 'roberta.costa@email.com', '2025-12-31'),
('Gabriel Oliveira', '923456789', '2004-11-09', 'gabriel.oliveira@email.com', '2025-12-31'),
('Cristina Pereira', '934567890', '2003-02-23', 'cristina.pereira@email.com', '2025-12-31'),
('M�rcia Almeida', '945678901', '2005-09-18', 'marcia.almeida@email.com', '2025-12-31'),
('Vin�cius Costa', '956789012', '2004-07-14', 'vinicius.costa@email.com', '2025-12-31'),
('Juliana Rocha', '967890123', '2005-11-29', 'juliana.rocha@email.com', '2025-12-31'),
('William Souza', '978901234', '2003-03-19', 'william.souza@email.com', '2025-12-31'),
('Rog�rio Silva', '989012345', '2004-06-02', 'rogerio.silva@email.com', '2025-12-31'),
('Patr�cia Lima', '990123456', '2004-08-24', 'patricia.lima@email.com', '2025-12-31'),
('Renato Santos', '901234567', '2003-05-11', 'renato.santos@email.com', '2025-12-31'),
('Simone Pereira', '912345678', '2005-10-30', 'simone.pereira@email.com', '2025-12-31'),
('Amanda Costa', '923456789', '2004-02-05', 'amanda.costa@email.com', '2025-12-31'),
('Lucas Gomes', '934567890', '2003-12-03', 'lucas.gomes@email.com', '2025-12-31'),
('Robson Almeida', '945678901', '2004-11-13', 'robson.almeida@email.com', '2025-12-31'),
('Gabriela Souza', '956789012', '2005-09-09', 'gabriela.souza@email.com', '2025-12-31'),
('Andr� Lima', '967890123', '2004-06-15', 'andre.lima@email.com', '2025-12-31'),
('Luana Pereira', '978901234', '2003-07-28', 'luana.pereira@email.com', '2025-12-31'),
('Ricardo Almeida', '989012345', '2004-05-09', 'ricardo.almeida@email.com', '2025-12-31'),
('Larissa Gomes', '990123456', '2005-12-04', 'larissa.gomes@email.com', '2025-12-31'),
('Tiago Rocha', '901234567', '2004-01-19', 'tiago.rocha@email.com', '2025-12-31'),
('Marcela Souza', '912345678', '2003-10-21', 'marcela.souza@email.com', '2025-12-31'),
('Rodrigo Lima', '923456789', '2005-05-16', 'rodrigo.lima@email.com', '2025-12-31'),
('Carla Pereira', '934567890', '2003-06-04', 'carla.pereira@email.com', '2025-12-31'),
('Sandro Silva', '945678901', '2004-04-18', 'sandro.silva@email.com', '2025-12-31'),
('Felipe Almeida', '956789012', '2005-08-28', 'felipe.almeida@email.com', '2025-12-31'),
('Leandra Costa', '967890123', '2003-05-06', 'leandra.costa@email.com', '2025-12-31'),
('Pedro Rocha', '978901234', '2004-09-25', 'pedro.rocha@email.com', '2025-12-31'),
('Paulo Souza', '989012345', '2004-07-30', 'paulo.souza@email.com', '2025-12-31');

INSERT INTO tblImc (idAluno, peso, altura)
VALUES 
(1, 55.60, 1.62),
(2, 70.50, 1.75),
(3, 63.20, 1.68),
(4, 80.00, 1.80),
(5, 58.40, 1.65),
(6, 90.10, 1.85),
(7, 72.80, 1.74),
(8, 68.90, 1.77),
(9, 65.00, 1.70),
(10, 85.60, 1.82),
(11, 78.30, 1.79),
(12, 62.50, 1.67),
(13, 74.10, 1.73),
(14, 66.40, 1.72),
(15, 82.20, 1.80),
(16, 79.00, 1.78),
(17, 59.30, 1.69),
(18, 86.50, 1.81),
(19, 70.10, 1.76),
(20, 66.90, 1.75),
(21, 73.60, 1.74),
(22, 88.70, 1.83),
(23, 69.30, 1.71),
(24, 72.40, 1.77),
(25, 61.60, 1.68),
(26, 79.90, 1.80),
(27, 74.80, 1.75),
(28, 77.50, 1.79),
(29, 80.30, 1.82),
(30, 75.90, 1.76),
(31, 83.40, 1.81),
(32, 69.80, 1.74),
(33, 68.60, 1.73),
(34, 76.10, 1.78),
(35, 79.20, 1.80),
(36, 70.90, 1.75),
(37, 81.00, 1.80),
(38, 84.40, 1.82),
(39, 71.50, 1.76),
(40, 78.60, 1.79),
(41, 82.80, 1.81),
(42, 85.20, 1.83),
(43, 69.00, 1.70),
(44, 72.00, 1.75),
(45, 64.30, 1.68),
(46, 74.00, 1.74),
(47, 76.90, 1.79),
(48, 78.40, 1.80),
(49, 70.20, 1.75),
(50, 66.50, 1.72),
(51, 87.30, 1.83),
(52, 79.40, 1.81),
(53, 72.10, 1.74),
(54, 80.50, 1.80),
(55, 75.20, 1.76),
(56, 82.00, 1.79),
(57, 68.20, 1.73),
(58, 71.80, 1.75),
(59, 76.30, 1.78);


-- Inserir atividades
INSERT INTO tblAtividade (idMusculo, idExercicio, idAluno, comentario, serie, repeticao, treino)
VALUES
(3, 12, 1, 'Treino de pernas', 4, 12, 'Treino A'),
(5, 27, 1, 'Foco em bra�os', 3, 10, 'Treino B'),
(2, 15, 1, 'Treino de costas', 4, 8, 'Treino C'),
(4, 33, 2, 'Treino intenso', 5, 10, 'Treino D'),
(6, 45, 2, 'Treino de ombro', 4, 12, 'Treino E'),
(3, 20, 2, 'Treino de pernas', 3, 15, 'Treino F'),
(7, 12, 3, 'Treino para gl�teos', 4, 12, 'Treino G'),
(5, 28, 3, 'Foco em bra�os', 3, 8, 'Treino A'),
(4, 30, 3, 'Treino de peito', 4, 10, 'Treino B'),
(2, 50, 4, 'Foco em costas', 5, 8, 'Treino C'),
(8, 64, 4, 'Treino de peito e costas', 3, 10, 'Treino D'),
(6, 21, 5, 'Treino de ombro', 4, 12, 'Treino E'),
(1, 40, 5, 'Treino de pernas', 4, 10, 'Treino F'),
(5, 22, 6, 'Foco em b�ceps', 3, 12, 'Treino G'),
(3, 10, 6, 'Treino de pernas', 4, 8, 'Treino A'),
(2, 15, 6, 'Treino de costas', 5, 10, 'Treino B'),
(4, 36, 7, 'Treino de peito', 4, 10, 'Treino C'),
(7, 28, 7, 'Treino de gl�teos', 4, 15, 'Treino D'),
(6, 33, 7, 'Treino de ombro', 3, 12, 'Treino E'),
(3, 18, 8, 'Treino de pernas', 4, 10, 'Treino F'),
(5, 41, 8, 'Foco em bra�os', 4, 10, 'Treino G'),
(8, 22, 8, 'Treino de peito', 5, 10, 'Treino A'),
(1, 43, 9, 'Treino de pernas', 4, 12, 'Treino B'),
(3, 27, 9, 'Treino de costas', 4, 10, 'Treino C'),
(6, 34, 9, 'Treino de ombro', 3, 10, 'Treino D'),
(7, 18, 10, 'Treino de gl�teos', 4, 15, 'Treino E'),
(5, 55, 10, 'Foco em b�ceps', 3, 12, 'Treino F'),
(4, 41, 10, 'Treino de peito', 4, 10, 'Treino G'),
(1, 50, 11, 'Treino de pernas', 4, 8, 'Treino A'),
(8, 64, 11, 'Treino de peito', 3, 10, 'Treino B'),
(6, 35, 11, 'Treino de ombro', 5, 12, 'Treino C'),
(3, 21, 12, 'Treino de costas', 4, 10, 'Treino D'),
(7, 22, 12, 'Treino de gl�teos', 3, 15, 'Treino E'),
(4, 34, 12, 'Treino de peito', 4, 10, 'Treino F'),
(5, 12, 13, 'Treino de b�ceps', 4, 12, 'Treino G'),
(6, 27, 13, 'Treino de ombro', 3, 10, 'Treino A'),
(3, 20, 13, 'Treino de pernas', 5, 12, 'Treino B'),
(1, 41, 14, 'Treino de gl�teos', 4, 10, 'Treino C'),
(2, 45, 14, 'Treino de costas', 4, 10, 'Treino D'),
(7, 60, 14, 'Treino de peito', 3, 12, 'Treino E'),
(8, 42, 15, 'Treino de gl�teos', 4, 8, 'Treino F'),
(6, 37, 15, 'Treino de ombro', 4, 12, 'Treino G'),
(4, 34, 15, 'Treino de peito', 5, 10, 'Treino A'),
(3, 12, 16, 'Treino de pernas', 4, 15, 'Treino B'),
(1, 40, 16, 'Treino de gl�teos', 3, 10, 'Treino C'),
(2, 27, 16, 'Treino de costas', 4, 12, 'Treino D'),
(5, 56, 17, 'Treino de b�ceps', 3, 10, 'Treino E'),
(8, 60, 17, 'Treino de peito', 4, 12, 'Treino F'),
(7, 30, 17, 'Treino de gl�teos', 4, 10, 'Treino G'),
(6, 21, 18, 'Treino de ombro', 3, 12, 'Treino A'),
(4, 31, 18, 'Treino de peito', 5, 8, 'Treino B'),
(5, 45, 18, 'Treino de b�ceps', 4, 12, 'Treino C'),
(3, 22, 19, 'Treino de costas', 4, 10, 'Treino D'),
(7, 14, 19, 'Treino de gl�teos', 3, 15, 'Treino E'),
(6, 35, 19, 'Treino de ombro', 5, 12, 'Treino F'),
(2, 28, 20, 'Treino de pernas', 4, 12, 'Treino G'),
(5, 24, 20, 'Foco em bra�os', 4, 10, 'Treino A'),
(8, 50, 20, 'Treino de peito', 3, 10, 'Treino B'),
(4, 17, 21, 'Treino de peito', 3, 8, 'Treino C'),
(7, 31, 21, 'Treino de gl�teos', 4, 15, 'Treino D'),
(5, 19, 21, 'Foco em bra�os', 3, 12, 'Treino E'),
(2, 45, 22, 'Treino de costas', 5, 8, 'Treino F'),
(1, 60, 22, 'Treino de pernas', 4, 10, 'Treino G'),
(6, 31, 22, 'Treino de ombro', 4, 10, 'Treino A'),
(3, 11, 23, 'Treino de pernas', 3, 12, 'Treino B'),
(8, 37, 23, 'Treino de peito', 5, 10, 'Treino C'),
(7, 25, 23, 'Treino de gl�teos', 4, 15, 'Treino D'),
(5, 48, 24, 'Foco em b�ceps', 4, 12, 'Treino E'),
(2, 33, 24, 'Treino de costas', 3, 10, 'Treino F'),
(4, 30, 24, 'Treino de peito', 4, 8, 'Treino G'),
(6, 41, 25, 'Treino de ombro', 4, 12, 'Treino A'),
(8, 34, 25, 'Treino de peito', 3, 10, 'Treino B'),
(7, 23, 25, 'Treino de gl�teos', 4, 10, 'Treino C'),
(1, 50, 26, 'Treino de pernas', 4, 12, 'Treino D'),
(5, 12, 26, 'Foco em bra�os', 3, 10, 'Treino E'),
(3, 35, 26, 'Treino de costas', 5, 8, 'Treino F'),
(4, 30, 27, 'Treino de peito', 3, 8, 'Treino G'),
(6, 33, 27, 'Treino de ombro', 4, 12, 'Treino A'),
(7, 48, 28, 'Treino de gl�teos', 4, 12, 'Treino B'),
(3, 21, 28, 'Treino de costas', 3, 15, 'Treino C'),
(8, 40, 28, 'Treino de peito', 4, 10, 'Treino D'),
(4, 39, 29, 'Treino de peito', 3, 8, 'Treino E'),
(2, 46, 29, 'Treino de costas', 4, 12, 'Treino F'),
(7, 50, 29, 'Treino de gl�teos', 5, 10, 'Treino G'),
(5, 24, 30, 'Foco em b�ceps', 3, 8, 'Treino A'),
(6, 28, 30, 'Treino de ombro', 5, 10, 'Treino B'),
(1, 33, 31, 'Treino de pernas', 3, 12, 'Treino C'),
(7, 44, 31, 'Treino de gl�teos', 4, 12, 'Treino D'),
(5, 39, 32, 'Foco em b�ceps', 4, 15, 'Treino E'),
(6, 29, 32, 'Treino de ombro', 3, 10, 'Treino F'),
(8, 37, 33, 'Treino de peito', 5, 10, 'Treino G'),
(1, 29, 34, 'Treino de pernas', 4, 8, 'Treino A'),
(2, 41, 34, 'Treino de costas', 5, 12, 'Treino B'),
(3, 45, 34, 'Treino de costas', 4, 10, 'Treino C'),
(5, 27, 35, 'Foco em b�ceps', 4, 12, 'Treino D'),
(7, 40, 35, 'Treino de gl�teos', 5, 15, 'Treino E'),
(4, 21, 36, 'Treino de peito', 3, 8, 'Treino F'),
(2, 22, 36, 'Treino de costas', 4, 10, 'Treino G'),
(1, 36, 37, 'Treino de pernas', 4, 12, 'Treino A'),
(5, 48, 37, 'Foco em b�ceps', 4, 15, 'Treino B'),
(3, 22, 38, 'Treino de costas', 5, 12, 'Treino C'),
(7, 23, 39, 'Treino de gl�teos', 3, 10, 'Treino D'),
(2, 47, 39, 'Treino de costas', 5, 8, 'Treino E'),
(8, 43, 39, 'Treino de peito', 4, 12, 'Treino F'),
(6, 26, 40, 'Treino de ombro', 3, 8, 'Treino G'),
(5, 50, 41, 'Foco em b�ceps', 3, 10, 'Treino A'),
(3, 28, 42, 'Treino de costas', 4, 10, 'Treino B'),
(4, 44, 43, 'Treino de peito', 4, 12, 'Treino C'),
(6, 25, 44, 'Treino de ombro', 5, 8, 'Treino D'),
(8, 41, 45, 'Treino de peito', 3, 10, 'Treino E'),
(7, 36, 46, 'Treino de gl�teos', 5, 12, 'Treino F'),
(1, 37, 47, 'Treino de pernas', 4, 15, 'Treino G'),
(6, 22, 48, 'Treino de ombro', 4, 10, 'Treino A'),
(4, 33, 49, 'Treino de peito', 5, 12, 'Treino B'),
(2, 42, 50, 'Treino de costas', 4, 12, 'Treino C'),
(7, 29, 51, 'Treino de gl�teos', 4, 8, 'Treino D'),
(6, 28, 52, 'Treino de ombro', 3, 15, 'Treino E'),
(3, 31, 53, 'Treino de costas', 4, 12, 'Treino F'),
(5, 43, 54, 'Foco em b�ceps', 3, 10, 'Treino G'),
(8, 47, 55, 'Treino de peito', 4, 12, 'Treino A'),
(1, 42, 56, 'Treino de pernas', 5, 8, 'Treino B'),
(3, 21, 57, 'Treino de costas', 4, 10, 'Treino C'),
(6, 33, 58, 'Treino de ombro', 3, 10, 'Treino D'),
(7, 44, 59, 'Treino de gl�teos', 4, 12, 'Treino E');

-- Inserindo dummy data na tabela tblPagamento

DECLARE @i INT = 1;

WHILE @i <= 100 -- Vamos inserir 100 registros, por exemplo
BEGIN
    -- Gerar valores aleat�rios para cada pagamento
    DECLARE @idAluno INT = FLOOR(RAND() * 59) + 1;  -- N�mero aleat�rio de 1 a 59 para idAluno
    DECLARE @idPlano INT = FLOOR(RAND() * 4) + 1;   -- N�mero aleat�rio de 1 a 4 para idPlano
    DECLARE @valorPagamento DECIMAL(10, 2);
    DECLARE @duracao INT = CASE WHEN RAND() < 0.25 THEN 1
                                WHEN RAND() < 0.5 THEN 30
                                WHEN RAND() < 0.75 THEN 90
                                ELSE 365 END; -- Dura��o aleat�ria entre 1, 30, 90, 365

    -- Definindo valor do pagamento com base em um intervalo de op��es
    IF RAND() < 0.25 SET @valorPagamento = 10.00;
    ELSE IF RAND() < 0.5 SET @valorPagamento = 50.00;
    ELSE IF RAND() < 0.75 SET @valorPagamento = 140.00;
    ELSE SET @valorPagamento = 500.00;

    -- Inserir o pagamento gerado
    INSERT INTO tblPagamento (idAluno, idPlano, valorPagamento, dataPagamento)
    VALUES (@idAluno, @idPlano, @valorPagamento, GETDATE());

    -- Incrementar o contador
    SET @i = @i + 1;
END;
GO



