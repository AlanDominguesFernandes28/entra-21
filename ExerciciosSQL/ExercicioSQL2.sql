CREATE TABLE enderecos(
estado VARCHAR(2),
cidade VARCHAR(140),
bairro VARCHAR(120),
cep VARCHAR(10),
logradouro VARCHAR(250),
numero INTEGER,
complemento TEXT
);

SELECT estado,cidade,bairro,cep,logradouro,numero,complemento FROM enderecos;

INSERT INTO enderecos
	(estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES ('AC','Rio Branco','Ayrton Senna','69.911-866','Estrada Deputado José Rui da Silveira Lino','282','Casa');

INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES ('SC','Biguaçu','Fundos','88.161-400','Rua Julio Teodoro Martins','995','');

INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES ('MG','Santa Luzia','Padre Miguel','33.082-050','Rua Buenos Aires','371','Apartamento');

INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('BA','','São Tomé de Paripe','40.800-361','Travessa Luís Hage','685','');

INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('MG','Ipatinga','Vila Celeste','','Rua Antônio Boaventura Batista','645','');

INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('RS','Passo Fundo','Nenê Graeff','99.030-250','','154','');

INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('AM','Manaus','Petrópolis','69.079-300','Rua Coronel Ferreira Sobrinho','264','Fundos');

INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('TO','Gurupi','Gurupi','77.402-130','Rua Adelmo Aires Negri','794','');

	INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('AC','','Preventório','','Preventório','212','Bloco B');

	INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('AP','Santana','Comercial','68.925-073','Rua Calçoene','648','');

	INSERT INTO enderecos
    (estado,cidade,bairro,cep,logradouro,numero,complemento)
	VALUES('PB','Cabedelo','Camalaú','58.103-052','Rua Siqueira Campos','249','');

--atualizar a lista--
UPDATE enderecos SET cep = '69.911-866', logradouro ='Estrada Deputado José Rui da Silveira Lino' WHERE numero = '282';

UPDATE enderecos SET complemento = 'Apartamento' WHERE cep='88.161-400';

UPDATE enderecos SET cidade = 'Salvador' ,complemento = 'Casa' WHERE cep='40.800-361';

UPDATE enderecos SET cep = '35.162-484' , complemento = 'Casa' WHERE bairro = 'Vila Celeste';

UPDATE enderecos SET logradouro ='Rua Itu', complemento = 'Casa' WHERE estado = 'RS';

UPDATE enderecos SET  complemento ='Casa', bairro= 'Muniz Santana' WHERE estado = 'TO';

UPDATE enderecos SET cidade ='Rio Branco', cep ='69900-162' WHERE numero = '212';

UPDATE enderecos SET complemento = 'Comercio' WHERE estado='AP';	

UPDATE enderecos SET complemento = 'Casa' WHERE estado='PB';
