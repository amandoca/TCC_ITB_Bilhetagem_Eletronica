use master
Drop DATABASE funcionario
CREATE DATABASE funcionario
go
USE funcionario
go
CREATE TABLE Cadastro_Empresa(idFuncionario int identity(1,1)primary key,
	Empresa     varchar(64),
	CNPJ		char(18),
	Telefone	char(13),
	Email		varchar(64),
	Endereco	varchar(64),
	Bairro		varchar(64),
	Numero		char(6),
	CEP			char(10),
	Cidade		varchar(64),
	Senha		varchar(20))
INSERT INTO Cadastro_Empresa VALUES ('Boticario','00.776.574/0001-56',
							'(11)3099-1682','rh@oboticario.com','HENRY FORD','Gabriela',
							'643','06210-108','Barueri','123456');
INSERT INTO Cadastro_Empresa VALUES ('Sanremo','89.738.173/0001-15',
							'(11)2135-5105', 'recrutamento@inbetta.com', 'Av. Nova São Paulo,','Itaqui',
							'467','06696-100','Itapevi', 'iQwHqYd');
INSERT INTO Cadastro_Empresa VALUES ('CSU','01.896.779/0001-38',
							'(11)2627-8500', 'ri@csu.com.br','R. Piaui', 'Nova Aldeinha',
							'136', '74638-823', 'Barueri','ECrgNHj');
INSERT INTO Cadastro_Empresa VALUES ('Maquiplast', '65.751.216/0001-34',
							'(11)4619-9696','rh@Maquiplast.com','R Marcelino Da Silva', 'Nucleo Micro Industrial Pres.',
							'145','06602-030', 'Jandira','rBX63gz');
INSERT INTO Cadastro_Empresa VALUES ('Atlas Copco', '57029431000106',
							'(11)3478-8700','servicos.compressores@br.atlascopco.com',
							'Alameda Araguaia', 'Alphaville', '2700', '06455-000', 'Barueri','ZXezTJB');
INSERT INTO Cadastro_Empresa VALUES ('E2R Transportadora', '13.930.405/0001-70',
							'(11)4142-3669', 'rh@e2rexpress.com.br',
							'Avenida Presidente Vargas','Cidade Saúde','650','06693-150','Itapevi','iOjHgWP');

/*
create table Usuario_App
(	ID_Usuario_APP	int identity (1,1),
	CPF				decimal(11) not null,
	login_email		varchar(64) not null,
	login_senha		varchar(10) not null,
	Constraint PK_Usuario_App_ID_usuario	Primary key (ID_Usuario_APP),
	Constraint UN_Usuario_App_CPF			Unique (CPF)
);	*/

CREATE TABLE Login_Empresa(idFuncionario int identity(1,1)primary key,
	Empresa	varchar(64),
	Senha	varchar(10));
								 
CREATE TABLE Estudante(idFuncionario int identity(1,1)primary key,
	Nome_Instituicao	varchar(64),
	CPF			char(15),
	Bairro		varchar(64),
	Endereco	varchar(64),
	Cidade		varchar(64),
	CEP			char(9),
	Nome_Aluno	varchar(64),
	Data_Nascimento	char(10),
	Email		varchar(64))
INSERT INTO Estudante VALUES ('ITB Paulista', '477.492.737-20', 'Maria Helena', 'Rua Ipanema', 'Barueri', '06397-848', 'Aline','21/02/2003', 'maria@gmail.com');
INSERT INTO Estudante VALUES ('ITB Mutinga', '688.213.488-06', 'Jardim São Carlos','Rua Lambari', 'Itapevi','06694-360','Sueli', '05/03/2001','sueli@yahoo.com');
INSERT INTO Estudante VALUES ('ITB Belval','738.020.548-06', 'Jardim Ruth','Rua Mário Albertinelli','Itapevi','06683-040','Cauê', '13/06/2003','caue@outlook.com');
INSERT INTO Estudante VALUES ('ITB Viana', '976.087.726-20', 'Vale do Sol', 'Rua Dom Pedro', 'Barueri', '86376-555','Antonio', '25/09/2002', 'antonio@gmail.com');
INSERT INTO Estudante VALUES ('Chalupe Colegio','832.374.098-47','Jardim Marina','Rua Tabira','Itapevi','06660-810','Yasmin', '08/03/1999','yasmin@bol.com')
INSERT INTO Estudante VALUES ('Suzete da Costa','650.589.388-12','Jardim Briquet','Rua Ceará Mirim','Jandira','06655-490','Melissa','09/11/2001','melissa2001@outlook.com')
INSERT INTO Estudante VALUES ('Escola Ohanna','318.162.678-30','Jardim da Rainha','Rua Osório','Barueri','06656-440','Caio','14/08/2002','caio14@hotmail.com')
INSERT INTO Estudante VALUES ('Amador Aguiar','173.402.848-34','Rua Diego Dias','Nova Itapevi','Itapevi','06690-340','Milena','03/02/2000','milena21@net.com')
INSERT INTO Estudante VALUES ('Cristão Asas','932.032.568-51','Rua Simonides','Parque Mira','Jandira,','06683-300','Julio','26/05/1999','julio@bol.com.br');




CREATE TABLE Cadastro_Cidadao(idFuncionario int identity(1,1)primary key,
	CPF			char(14),
	Nome		varchar(64),
	RG			char(12),
	Email		varchar(64),
	Bairro		varchar(64),
	Cidade		varchar(64),
	Data_Nascimento	char(10))
INSERT INTO Cadastro_Cidadao VALUES ('499.409.558-20', 'Livia','39.888.030-2','livia@hotmail.com', 'Parque Viana', 'Barueri', '05/02/1990')
INSERT INTO Cadastro_Cidadao VALUES ('734.874.834-74', 'Joana','38.948.239-3','joana@bol.com'    ,  'Vila Guimarães',  'Jandira','20/03/1983')
INSERT INTO Cadastro_Cidadao VALUES ('893.783.748-38', 'Igor', '93.983.983-8','igor@outlook.com',  'Pq Camargos',   'Barueri','09/12/1982')
INSERT INTO Cadastro_Cidadao VALUES ('961.494.548-60','Rafaela', '34.069.378-2', 'rafaela@hotmail.com','Jardim Sorocabana', 'Itapevi','25/08/2002')
INSERT INTO Cadastro_Cidadao VALUES ('738.845.343-20', 'Willian', '76.668.839-2', 'willian@bing.com', 'Vila Diogo Balhesteiro','Jandira','21/03/1997')
INSERT INTO Cadastro_Cidadao VALUES ('226.795.138-00','Miguel', '49.239.057-5', 'miguel12@gmail.com', 'Vila Tupinambás', 'Itapevi','27/06/1990')
INSERT INTO Cadastro_Cidadao VALUES ('543.464.308-99','Murilo', '30.282.253-7', 'murilo@net.com', 'Viela São Jorge', 'Barueri', '17/02/1955')
INSERT INTO Cadastro_Cidadao VALUES ('466.173.168-94','Ayumi', '33.551.072-3', 'ayumi@hotmail.com', 'Rua Azaléia', 'Jandira', '21/09/1978');




CREATE TABLE Funcionario_Empresa(idFuncionario int identity(1,1)primary key,
	Empresa	varchar(64),
	CPF		char(14),
	Nome	varchar(64),
	Data_Nascimento	char(10),
	RG		char(12))
INSERT INTO Funcionario_Empresa VALUES ('Atlas Copco', '764.957.072-30', 'João', '18/09/1989','98.755.026-2')
INSERT INTO Funcionario_Empresa VALUES ('Boticario', '644.497.227-20', 'Milena', '28/07/1986','39.908.065-4')
INSERT INTO Funcionario_Empresa VALUES ('Atlas Copco','037.857.863-22', 'Ricardo','27/12/1992','87.988.733-8')
INSERT INTO Funcionario_Empresa VALUES ('Calebe Eletrônica','473.336.928-09','Brenda','11/11/1982','35.884.081-8')
INSERT INTO Funcionario_Empresa VALUES ('Hadassa Automóveis','282.968.118-55','Marcela','26/12/2001','40.681.091-6')
INSERT INTO Funcionario_Empresa VALUES ('McDonalds','996.220.328-77','Bruno', '13/04/2000', '12.991.749-7')
INSERT INTO Funcionario_Empresa VALUES ('Caedu Modas','209.862.308-98','Armando','10/07/1996','16.965.412-6')
INSERT INTO Funcionario_Empresa VALUES ('Mercado Japão','608.017.698-09','Solange', '27/09/1976','41.118.519-6')
INSERT INTO Funcionario_Empresa VALUES ('Drogasil','763.389.068-14','Théo','12/12/1969','65.354.365.8')
INSERT INTO Funcionario_Empresa VALUES ('Doceria Smile','417.609.728-00','Regina','19/10/1992','31.657.313-9')
INSERT INTO Funcionario_Empresa VALUES ('Paula Acessoria Jurídica','608.478.818-14','Nathan','02/09/1989','35.655.131-3')
INSERT INTO Funcionario_Empresa VALUES ('Fast Lavanderia','525.388.128-01','Osvaldo','02/06/1963','28.236.703-2') ;



CREATE TABLE Contato(idFuncionario int identity(1,1)primary key,
	CPF		char(14),
	Nome	varchar(64),
	Email	varchar(64),
	Mensagem varchar(400))
INSERT INTO Contato VALUES ('499.409.558-20', 'Bruno', 'bruno@hotmail.com', 'Os ônibus da linha a215 estão demorando muito, ajeitem os horários')
INSERT INTO Contato VALUES ('766.452.974-30', 'Miguel', 'miguel@bol.com', 'Gostaria que fizessem atualização no app de vocês, enfreto problema de login');

CREATE TABLE Login_Adm(idFuncionario int identity(1,1)primary key,
	Nome	varchar(10),
	Senha	varchar(10))

CREATE TABLE Cadastro_Adm(idFuncionario int identity(1,1)primary key,
	Nome	varchar(10),
	Viacao	varchar(10),
	Senha	varchar(10))
INSERT INTO Cadastro_Adm VALUES ('Fernando','Ralip','9HshWSp');
INSERT INTO Cadastro_Adm VALUES ('Bianca','Benfica','3399');
INSERT INTO Cadastro_Adm VALUES ('Thiago','Ralip','MtsRwby');
INSERT INTO Cadastro_Adm VALUES ('Rafael','Ralip','AiYrkuo');
INSERT INTO Cadastro_Adm VALUES ('Bruna','Benfica','dRd3o7r');