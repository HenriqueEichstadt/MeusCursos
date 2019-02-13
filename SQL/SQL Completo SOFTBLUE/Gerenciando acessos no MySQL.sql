
/*
	// Acessa apenas por determinado ip
CREATE USER 'henrique'@'200.200.190.190' IDENTIFIED BY 'henrique123';
	// Acessa apenas na própria máquina
CREATE USER 'henrique'@'localhost' IDENTIFIED BY 'henrique123';

	// Acessa de qualquer lugar
CREATE USER 'henrique'@'%' IDENTIFIED BY 'henrique123';
*/

CREATE USER 'henrique'@'localhost' IDENTIFIED BY 'henrique123';
GRANT ALL ON curso_sql.* TO 'henrique'@'localhost';

CREATE USER 'henrique'@'%' IDENTIFIED BY 'andreviagem';
GRANT SELECT ON curso_sql.* TO 'henrique'@'%';

GRANT INSERT ON curso_sql.funcionarios TO 'henrique'@'%';


REVOKE INSERT ON curso_sql.funcionarios FROM 'henrique'@'%';

REVOKE SELECT ON curso_sql.* FROM 'henrique'@'%';

GRANT SELECT ON curso_sql.funcionarios TO 'henrique'@'%';
GRANT SELECT ON curso_sql.veiculos TO 'henrique'@'%';

REVOKE SELECT ON curso_sql.funcionarios FROM 'henrique'@'%';
REVOKE SELECT ON curso_sql.veiculos FROM 'henrique'@'%';

DROP USER 'henrique'@'%';
DROP USER 'henrique'@'localhost';

SELECT USER FROM mysql.user;
SHOW GRANTS FOR 'henrique'@'%';




