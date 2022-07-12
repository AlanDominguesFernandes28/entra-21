CREATE TABLE pecas(
    id INTEGER PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(50),
    tipo INTEGER,
    preco_unitario DECIMAL(6,2));

CREATE TABLE clientes(
    id INTEGER PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(40),
    cpf VARCHAR(14));

SELECT * FROM pecas;
SELECT * FROM clientes;

CREATE TABLE enderecos(
    id INTEGER PRIMARY KEY IDENTITY(1,1),----FK
    id_cliente INTEGER NOT NULL, ------FK
    cep VARCHAR(9) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    bairro VARCHAR(30) NOT NULL,
    logradouro VARCHAR(40) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    descricao TEXT,

    --- FOREIGN KEY nome_coluna_tabela_atual 
    --- REFERENCES nome_tabela_pai(nome_tabela_pai_pk)
    FOREIGN KEY (id_cliente) REFERENCES clientes(id));

CREATE TABLE pedidos(
    id INTEGER PRIMARY KEY IDENTITY(1,1),
    id_cliente INTEGER NOT NULL,
    status TINYINT NOT NULL,---0..255
    data_criacao DATETIME2 NOT NULL,
    data_compra DATETIME2,
);

CREATE TABLE pedidos_pecas(
    id INTEGER PRIMARY KEY IDENTITY(1,1), ---PK
    id_peca INTEGER, --- FK tabela pecas
    id_pedido INTEGER, --- FK tabela pedido

    quantidade SMALLINT,

    FOREIGN KEY(id_pedido) REFERENCES pedidos(id),
    FOREIGN KEY(id_peca) REFERENCES pecas(id)
);

INSERT INTO pecas(nome,tipo,preco_unitario)VALUES
('SSD 240 GB' , 1, 200),
('SSD 240 M2' ,1, 420.39),
('RTX 3090 TI ', 2 , 9999.90),
('GTX 1060' , 2, 1500),
('16GB  DDR5 4800Ghz', 5 ,800),
('16GB DDR4 3200Ghz' , 5, 350);

INSERT INTO clientes(nome,cpf) VALUES
('Claudio', '070.355.489-73'),
('Cry', '027.599.384-76'),
('juliana', '127.599.584-76');


INSERT INTO enderecos(id_cliente,estado,cidade, BAIRRO, cep,logradouro,numero) VALUES
(1, 'SC', 'BLUMENAU' , ' VELHA' , '89070-301' , ' RUA DIVINOPOLIS' , 777),
(2, 'SC', 'BLUMENAU' , ' VELHA GRANDE' ,'89070-472', 'MORRO DA EDITH' , 36),
(3, 'SC', 'BLUMENAU' , ' JUDHIT' , ' SEM CEP' , ' RUA DA KELLEN', 23);


SELECT * FROM pecas;
SELECT * FROM clientes;
SELECT * FROM enderecos;
SELECT * FROM pedidos;
SELECT * FROM pedidos_pecas;

----consulta para çistar o nome,cpf e endereco completo do cliente
----consulta parte da tabela de clientes fazendo inner join com a atbela de endereco

SELECT
      c.nome,
      c.cpf,
      CONCAT(
             e.estado, ' - ',
             e.cidade, ' - ',
             e.bairro, ' - ',
             e.logradouro, ' - ',
             e.numero) AS 'Endereço Completo'
             FROM clientes AS c
      INNER JOIN enderecos AS e ON (e.id_cliente = c.id);

--- CONSULTAR OS ENDERECOS APRESENTANDO SEU CLIENTE FILTRANDO POR BAIRROS COM NOME VELHA

SELECT
     c.nome,
     e.bairro,
     e.logradouro
     FROM enderecos AS e
     INNER JOIN clientes AS c ON (c.id = e.id_cliente)
     WHERE e.bairro LIKE '%velha%';

-- status do pedido
--0 - Carrinho
--1 - aguardando pagamento
--2 - pagamento efetivado
--3 - entrega  realizada
INSERT INTO pedidos (id_cliente, status, data_criacao) VALUES
(1,0, GETDATE()), --- pedido para claudio
((SELECT id FROM clientes WHERE nome = 'Cry') , 0, GETDATE());---pedido para cry

SELECT * FROM pedidos;


--consultar pedidos listando, data da criacao formato PT-BR,status com texto e nome do cliente
--Consultar partindo da tabela de pedidos com JOIN em clientes
SELECT
     FORMAT (p.data_criacao, 'dd/MM/yyyy'),
     CASE
         WHEN [status] = 0 THEN 'Carrinho'
         WHEN [status] = 1 THEN 'Aguardando pagamento'
         WHEN [status] = 2 THEN 'Pagamento efetivado'
         ELSE 'Entrega realizada'
         END AS 'Status pedido',
         c.nome
         FROM pedidos AS p
         INNER JOIN clientes AS c ON(P.id_cliente = c.id);
UPDATE pedidos SET status = 1 WHERE id = 2;
