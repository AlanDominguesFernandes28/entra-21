CREATE TABLE champions(
nome VARCHAR(100),
descricao VARCHAR(100),
habilidade1 VARCHAR(100),
habilidade2 VARCHAR(100),
habilidade3 VARCHAR(100),
habilidade4 VARCHAR(100),
habilidade5 VARCHAR(100)
);



INSERT INTO champions
       (nome,descricao,habilidade1,habilidade2,habilidade3,habilidade4,habilidade5)
       VALUES('Katarina','a Lâmina Sinistra ','Voracidade ','Lâmina Saltitante ','Preparação ','Shunpo','Lótus da Morte');
      
INSERT INTO champions
       (nome,habilidade1,habilidade2,habilidade3,habilidade4,habilidade5)
       VALUES('Yasuo ','Estilo do Errante','Tempestade de Aço','Parede de Vento','Espada Ágil','Último Suspiro');

INSERT INTO champions
       (nome,descricao,habilidade1)
       VALUES('Master Yi ','o Espadachim Wuju ','Ataque Duplo');

INSERT INTO champions
       (nome,descricao,habilidade1,habilidade2,habilidade3,habilidade4,habilidade5)
       VALUES('Vayne ','a Caçadora Noturna ','Caçadora Noturna ','Rolamento','Dardos de Prata ','a Condenar','Hora Final');

INSERT INTO champions
       (nome,descricao,habilidade1,habilidade2,habilidade3,habilidade4)
       VALUES('Lee Sin ','o Monge Cego ','Agitação ','Onda Sônica /Ataque Ressonante','Proteger /Vontade de Ferro','Tempestade /Mutilar');

INSERT INTO champions
       (nome,descricao,habilidade1,habilidade3,habilidade4,habilidade5)
       VALUES('Vi ','a Defensora de Piltover','Blindagem','Pancada Certeira','Força Excessiva','Saque e Enterrada');

INSERT INTO champions
       (nome,descricao,habilidade1,habilidade2,habilidade3,habilidade4,habilidade5)
       VALUES('Diana ','o Escárnio da Lua ','Espada de Prata Lunar','Golpe Crescente','Cascata Lívida ','Colapso Minguante','Zênite Lunar');

INSERT INTO champions
       (nome,descricao,habilidade1,habilidade2,habilidade3,habilidade4,habilidade5)
       VALUES('Annie ','a Criança Sombria','Piromania ','Desintegrar ','Incinerar ','Escudo Fundido','Invocar:Tibbers');

INSERT INTO champions
       (nome,habilidade1,habilidade2,habilidade3,habilidade4,habilidade5)
       VALUES('Aatrox','Poço de Sangue','Voo Sombrio','Sede de Sangue / Preço em Sangue','Lâminas da Aflição','Massacre');


       UPDATE champions SET descricao = 'O Imperdoavel' WHERE nome= 'Yasuo';
       UPDATE champions SET habilidade2='Ataque Alpha',habilidade3='Meditar',habilidade4='Estilo Wuju',habilidade5='HighLander' WHERE nome= 'Master Yi';
       UPDATE champions SET habilidade5='Furia do Dragão'  WHERE nome= 'Lee Sin';
       UPDATE champions SET habilidade2='Quebra Cofres' WHERE nome= 'Vi';
       UPDATE champions SET descricao ='A Espada Darkin'WHERE nome= 'Aatrox ';

SELECT nome AS 'Nome',
        descricao AS 'Descrição',
        habilidade1 AS 'Habilidade 1',
        habilidade2 AS 'Habilidade 2',
        habilidade3 AS 'Habilidade 3',
        habilidade4 AS 'Habilidade 4',
        habilidade5 AS 'Habilidade 5'
FROM champions;