USE curso_sql;

INSERT INTO funcionarios (id, nome, salario, departamento) VALUES (1, 'Henrique', 2500, 'TI');
INSERT INTO funcionarios (id, nome, salario, departamento) VALUES (2, 'Guilherme', 2500, 'Juridico');
INSERT INTO funcionarios (nome, salario, departamento) VALUES ('Fábio', 5000, 'TI');
INSERT INTO funcionarios (nome, salario, departamento) VALUES ('José', 5000, 'Marketing');
INSERT INTO funcionarios (nome, salario, departamento) VALUES ('Isabela', 5000, 'Juridico');

SELECT * FROM funcionarios;

SELECT * FROM funcionarios WHERE salario > 2000;
SELECT * FROM funcionarios WHERE nome = 'Henrique';
SELECT * FROM funcionarios WHERE id = 3;

UPDATE funcionarios SET salario = salario * 1.1 WHERE id = 1;

SET SQL_SAFE_UPDATES = 0;
UPDATE funcionarios SET salario = salario * 1.1;

UPDATE funcionarios SET salario = ROUND(salario * 1.1, 2);

DELETE FROM funcionarios WHERE id = 4;

INSERT INTO veiculos (funcionario_id, veiculo, placa) VALUES (1, 'Carro', 'QIF-4469');
INSERT INTO veiculos (funcionario_id, veiculo, placa) VALUES (2, 'Carro', 'QIF-4470');

UPDATE veiculos SET funcionario_id = 5 WHERE id = 2;

SELECT * FROM veiculos;

INSERT INTO salarios (faixa, inicio, fim) VALUES ('Programador Junior', 1500, 3000);	
INSERT INTO salarios (faixa, inicio, fim) VALUES ('Programador Sênior', 5000, 8000);	

SELECT * FROM salarios;

SELECT * FROM funcionarios f WHERE f.salario > 2000; 
SELECT nome AS 'funcionario', salario FROM funcionarios f WHERE f.salario > 2000;

SELECT * FROM funcionarios WHERE  nome =  'Henrique'
UNION ALL
SELECT * FROM funcionarios WHERE id = 5;



