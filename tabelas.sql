CREATE TABLE usuarios (id INT UNSIGNED ZEROFILL NOT NULL PRIMARY KEY AUTO_INCREMENT,
                       login VARCHAR(30),
                       senha VARCHAR(40),
                       situacao VARCHAR(1) NOT NULL DEFAULT 'A',
                       dt_cadastro INT(8),
                       INDEX(login)
                       ) ENGINE = MyISAM;


CREATE TABLE agenda (id INT PRIMARY KEY AUTO_INCREMENT,
                     nome VARCHAR(50),
                     email VARCHAR(50),
                     telefone INT(11),
                     cep INT(8),
                     end VARCHAR(130),
                     end_num INT(5),
                     end_bairro VARCHAR(20),
                     dt_cadastro INT(8),
                     INDEX(nome)
                     ) ENGINE = MyISAM;
