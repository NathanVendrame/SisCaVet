create database SisCaVet
go

use SisCaVet
go

create table pessoas                                              --<-----mod
(
  id              int           not null primary key identity,    
  nome            varchar(50)   not null,
  cpf             varchar(15)   not null unique,
  rg              varchar(13)   not null,
  dataNascimento  date          not null,
  telefone        varchar(20)   not null,
  rua             varchar(100)  not null,
  bairro          varchar(100)  not null,
  cep             varchar(10)   not null,
  cidade          varchar(100)  not null,
  estado          varchar(2)    not null,   
  status          int           check(status in (0,1))
)
go



create table clientes								--<-----mod
(
	pessoaId	                  int	    not null primary key references pessoas,
    quantidadeConsultasAberto	  int       null     
)
go


create table veterinarios
(	
	pessoaId	        int			  not null primary key references pessoas,
	email				varchar(50)		not null,
	senha				varchar(10)		not null,
	salario				decimal(10,2) not null,
	especialidade       varchar(100)  not null,
	crmv                int           not null unique	
)
go


create table animais
(	
    id              int            not null primary key identity,
	nome            varchar(100)   not null,
	idade           int            not null,
	peso            decimal(10,2)  not null,  
	raca            varchar(50)    not null,
	descricao       varchar(500)   null,
	clienteId	    int		       not null references clientes,
	especie         varchar(100)   not null,
	status          int           check(status in (0,1))
)
go

create table consultas
(	
    id              int            not null primary key identity,
	data            date           not null,	
	descricao       varchar(100)   null,
	clienteId	    int		       not null references clientes,
	veterinarioId	int	           not null references veterinarios,
	animalId	    int	           not null references animais,	
	valorTotal		decimal(10,2)  not null,
	status          int           check(status in (0,1))         
)
go

create table procedimentos
(
    id        int			not null primary key identity,
	descricao varchar(100)	not null,
	valor     decimal(10,2)	not null,
	status          int           check(status in (0,1)) 
)
go


create table consultas_procedimentos
(	
	procedimentoId	    int		        not null references procedimentos,
	consultaId	        int		        not null references consultas,  
	resultado           varchar(50)	null,
	primary key(procedimentoId, consultaId)
)
go

insert into pessoas values ('Alvaro de Campos', '3030', '0303', '1980-02-17', '3434','Rua Lim�es', 'Bairro Violeta', '15043333', 'Rio Preto', 'SP', 1)	--<-----mod
insert into pessoas values ('Alberto Carreiro', '4040', '0404', '1980-02-18' , '35335','Rua Laranja', 'Bairro Girassol', '15044444', 'Rio Preto', 'SP', 1)
insert into pessoas values ('Ricardo Reis', '5050', '0505', '1980-02-19', '3636','Rua ', 'Bairro Violeta', '15043333', 'Rio Preto', 'SP', 1)
Select * from pessoas
go

insert into pessoas values ('Clark Kent', '1111', '2222', '1980-02-17', '3434', 'rua almeida','bairro cabare','15010600','mirassol', 'SP', 1)
insert into pessoas values ('Superman', '2222', '3333', '1980-02-18' , '35335', 'rua aparecida', 'bairro messias', '15048123','Rio Preto', 'SP', 1)
insert into pessoas values ('Homem de A�o', '3333', '1111', '1980-02-19', '3636','rua espinole de franca', 'bairro Sam Francisco','15063666', 'Rio Preto', 'SP', 1)
Select * from pessoas
go

insert into procedimentos values ('Hemograma', 30,0)						
insert into procedimentos values ('Adenograma', 30,0)
insert into procedimentos values ('Retirada de Pontos', 10,0)
Select * from procedimentos
go


insert into clientes values (1,0)								--<-----mod
insert into clientes values (2,0)
insert into clientes values (3,1)
SELECT * FROM clientes
go

insert into animais values ('tobias', 10, 10, 'SRD', 'preto', 1, 'pug',1)
insert into animais values ('reginaldo', 10, 10, 'SRD', 'branco', 1, 'buldogue',1)
insert into animais values ('zebra', 10, 10, 'SRD', 'preto', 1, 'beagle',1)
select * from animais
go

/*
insert into veterinarios values (6,7000, 'castra��o', 10010)
insert into veterinarios values (7,8000,'castra��o', 10011)
insert into veterinarios values (8,10000,'medica��o', 10100)
SELECT * FROM veterinarios
go


insert into consultas values ('2019-10-03', 'rotina', 1, 6, 1, 20.20, 1)
insert into consultas values ('31/05/2019', 'rotina', 2, 6, 2, 10.10, 1)
insert into consultas values ('31/05/2019', 'rotina', 3, 6, 3, 10.30, 1)
select * from consultas
go

insert into consultas_procedimentos values(1, 1, 'pronto')
insert into consultas_procedimentos values(2, 2, 'em espera')
insert into consultas_procedimentos values(3, 3, 'em espera')
select * from consultas_procedimentos
go

insert into usuarios values (4, 'teste@teste.com', '123')
insert into usuarios values (6, 'teste2@teste.com', '456')
insert into usuarios values (8, 'teste3@teste.com', '789')
go

insert into medicamentos values ('ciprofaxilico','13/03/1999', '12/03/2005',1)
insert into medicamentos values ('cov�lico','13/03/1999', '12/03/2005', 2)
insert into medicamentos values ('doxilina','13/03/1999', '12/03/2005',3)
select * from medicamentos

insert into pagamentos values (1, 4, 4, 200)
insert into pagamentos values (1, 5, 4, 300)
insert into pagamentos values (1, 6, 4, 400)
select * from pagamentos

insert into medicamentos_procedimentos values(1, 1, 10)
insert into medicamentos_procedimentos values(2, 2, 10)
insert into medicamentos_procedimentos values(3, 3, 10)
select * from medicamentos_procedimentos


insert into funcionarios values (4, 2500)
insert into funcionarios values (5, 2500)
insert into funcionarios values (6, 2500)
SELECT * FROM funcionarios

insert into categorias values ('Antibi�tico');
insert into categorias values ('Antiviral');
insert into categorias values ('Antif�ngico');
Select * from categorias

*/
---------------------------------------------------------------------------------------------------------------
----------------- procedures ----------------------------------------------
-------------------------------------------------------------------------------

    


-- ----- cadastro procedimentos ------------------------------------------------------
create procedure cadProc
(
    @descricao varchar(100),
	@valor decimal(10,2) ,
	@status int  
)
as
begin
     insert into procedimentos values (@descricao, @valor, @status)
end
go

exec cadProc 'vacinação', 50, 0
go

select * from procedimentos
go

create procedure altProc
(
    @id int,
    @descricao varchar(100), 
    @valor decimal(10,2),
	@status int
)
as
begin
     update procedimentos set 
            descricao = @descricao,  
            valor = @valor,
			status = @status
      where id = @id
end
go

exec altProc 1,'tigre', 30, 1
go

select * from procedimentos
go

----- cadastro cliente ----------------------------------------------------------------//////////mod

create procedure cadCli
(
	@nome						varchar(100),
	@cpf						varchar(12),
	@rg							varchar(10),
	@dataNascimento				date,
	@telefone					varchar(20),
	@rua						varchar(100),
	@bairro						varchar(100),
	@cep						varchar(10),
	@cidade						varchar(100),
	@estado						varchar(2),
	@quantidadeConsultasAberto  int,
	@status				        int
)
as
begin
	declare @codigo int
    select @codigo = id from pessoas where cpf  = @cpf	
	if @@ROWCOUNT = 0
	begin
			insert into pessoas values (@nome, @cpf, @rg, @dataNascimento, @telefone,@rua, @bairro, @cep, @cidade, @estado, @status)
			insert into clientes values (@@IDENTITY, @quantidadeConsultasAberto)
	end
end
go

exec cadCli 'carlos', '99999', '00001','1998-03-25','22333', 'Rua Lim�es', 'Bairro Violeta', '15043333', 'Rio Preto', 'SP', 1, 1
go

select * from pessoas
select * from clientes
go

create procedure altCli
(
    @cliente_id							int,
	@nome						varchar(100),
	@cpf						varchar(12),
	@rg							varchar(10),
	@dataNascimento				date,
	@telefone					varchar(20),
	@rua						varchar(100),
	@bairro						varchar(100),
	@cep						varchar(10),
	@cidade						varchar(100),
	@estado						varchar(2),
	@quantidadeConsultasAberto  int,
	@status				        int   
)
as
begin
	select * from pessoas where id = @cliente_id 
	if @@ROWCOUNT= 1
	begin 
	update pessoas set nome = @nome, cpf = @cpf, rg = @rg, dataNascimento = @dataNascimento, telefone = @telefone,
					   rua = @rua, bairro = @bairro, cep = @cep, cidade = @cidade, estado = @estado, status = @status
	where id = @cliente_id
	update clientes set quantidadeConsultasAberto = @quantidadeConsultasAberto
	where @cliente_id = @cliente_id
	return 1 
	end 
	else	
		return 0
end
go

exec altCli 7, 'Carla', '99999', '00001','1998-03-25','22333', 'Rua Limões', 'Bairro Violeta', '15043333', 'Rio Preto', 'SP', 1, 1
go

-- ------ cadastrar veterinarios ----------------------------------------------------////////////////////mod

create procedure cadVet
(
    @nome						varchar(100),
	@cpf						varchar(12),
	@rg							varchar(10),
	@dataNascimento				date,
	@telefone					varchar(20),							--<-----------------------mod
	@rua						varchar(100),
	@bairro						varchar(100),
	@cep						varchar(10),
	@cidade						varchar(100),
	@estado						varchar(2),
	@status						int,
	@email						varchar(50),
	@senha						varchar(10),
	@salario					decimal(10,2),  
	@especialidade				varchar(100),
	@crmv						int
)
as
begin
    declare @codigo int

    select @codigo = id from pessoas where cpf  = @cpf
	
	if @@ROWCOUNT = 0
	begin
		insert into pessoas values (@nome, @cpf, @rg, @dataNascimento, @telefone,@rua,@bairro,@cep,@cidade,@estado, @status) --<-----mod
		set @codigo = @@IDENTITY
		insert into veterinarios values (@codigo, @email, @senha, @salario, @especialidade, @crmv)
	end

	return @codigo
end
go

declare @r int
exec @r = cadVet 'zz', 'zz', '00001', '1998-03-25', '222333', 'rua joaquim', 'bairro Sam Pedro', '15048666', 'Rio Preto', 'SP', 1, 'camila@gmail.com', '123456', 200000, 'treinar', 55667    --<-----mod
print @r

go
exec cadVet 'João', '22222222', '111111111', '2999-03-25', '33333333', 'rua joaquim', 'bairro Sam Pedro', '15048666', 'Rio Preto', 'SP', 1, 'joao@gmail.com', '123456', 200000, 'vendedora', 123456   --<-----mod
go


create procedure altVet
(
    @id							int,
	@nome						varchar(100),
	@cpf						varchar(12),
	@rg							varchar(10),
	@dataNascimento				date,
	@telefone					varchar(20),							--<-----------------------mod
	@rua						varchar(100),
	@bairro						varchar(100),
	@cep						varchar(10),
	@cidade						varchar(100),
	@estado						varchar(2),
	@status						int,
	@especialidade				varchar(100),
	@salario					decimal(10,2),  
	@crmv						int,
	@email						varchar(50),
	@senha						varchar(10)                                    --<-----------------------------------------------adicionei o crmv para alterar tbm
)
as
begin
	begin try 
		begin tran
			select * from pessoas where id = @id 
			if @@ROWCOUNT= 1
			begin 
			 update pessoas set 
					nome = @nome,
					cpf = @cpf,
					rg = @rg, 
					dataNascimento = @dataNascimento,
					telefone = @telefone, 
					rua = @rua,
					bairro = @bairro,
					cidade = @cidade,
					estado = @estado,
					status = @status
			  where id = @id
			  update veterinarios set 
					especialidade = @especialidade, 	--<------------------------------ adicionei o campo especialidade para altera tbm, alem do crmv embaixo		
					salario       = @salario,
					crmv          = @crmv,
					email         = @email,
					senha         = @senha
			  where pessoaId = @id
			 end
		commit
		return 0
	end try
	begin catch
		rollback
		return 1
	end catch
end
go

select * from veterinarios
go

exec altVet 2, 'Camila Ramos', '9999999', '00001', '1998-03-25', '22333', 'rua joaquim', 'bairro Sam Pedro', '15048999', 'Rio Preto', 'SP', 1, 'camila@hotmail.com', '654321', 250000, 'atender', 112233
go

-------- cadastro animais -----------------------------------------------------------------
create procedure cadAni
(
    @nome		varchar(100),
	@idade		int,
	@peso		decimal(10,2),
	@raca		varchar(50),
	@descricao	varchar(100),
	@clienteId	int,
	@especie	varchar(100),
	@status     int
)
as
begin
     insert into animais values (@nome, @idade, @peso, @raca, @descricao, @clienteId, @especie, @status)
end
go

exec cadAni 'nini', 10, 10, 'SRD', 'branco', 1, 'gato siames',0 --<------------------trocado
go

create procedure altAni
(
	@id			int,
    @nome		varchar(100),
	@idade		int,
	@peso		decimal(10,2),
	@raca		varchar(50),
	@descricao	varchar(100) = null,
	@clienteId	int,
	@especie	varchar(100),
	@status     int

)
as
begin

		 update animais set 
			 nome = @nome,
			 idade = @idade,
			 peso = @peso,
			 raca = @raca,
			 descricao = @descricao,
			 clienteId = @clienteId,
			 especie = @especie,
			 status = @status
		  where id = @id  
end
go

exec altAni 1,'bibi', 10, 10.10, 'SRD', 'branco', 1, 'gato siames', 0
go

select * from veterinarios
go
----- cadastro consultas ----------------------------------------------------------------------------------

create procedure cadConsul
(
    @data			date,	
	@descricao		varchar(100),
	@clienteId		int,
	@veterinarioId int,
	@animalId		int,
	@valorTotal     decimal(10,2),
	@status			int
)
as
begin
	insert into consultas values (@data, @descricao, @clienteId, @veterinarioId, @animalId, @valorTotal, @status)
end
go 

exec cadConsul '2019-05-20', 'vacinacao cinomose', 1, 8, 1, 10.2, 1
go

create procedure altConsul
(
	@id int,
    @data			date,	
	@descricao		varchar(100),
	@clienteId		int,
	@veterinarioId int,
	@animalId		int,
	@valorTotal     decimal(10,2),
	@status			int
)
as
begin
     update consultas set 
        data = @data,	
		descricao = @descricao,
		clienteId = @clienteId,
		veterinarioId = @veterinarioId,
		animalId = @animalId,
		valorTotal = @valorTotal,
		status = @status
      where id = @id      
end
go
exec altConsul 5,'2019-05-31', 'vacinacao cinomose', 1, 8, 1,10.2, 1
go

--------- consultas procedimentos ----------------------------------------------

create procedure cadConsulProc
(
	@procedimentoId    int,
	@consultaId		int,    
	@resultado			Varchar(100)
)
as
begin	
	insert into consultas_procedimentos values (@procedimentoId, @consultaId, @resultado)
end
go 

exec cadConsulProc 1, 1, 'teste'      --<----------------------------------------------------------------------------Deixei sem nd, pode ser nulo
go

create procedure altConsulProc
(
	@procedimentoId		int,
	@consultaId			int,    
	@resultado			Varchar(100)
)
as
begin

	update consultas_procedimentos set resultado = @resultado
	where  procedimentoId = @procedimentoId and consultaId = @consultaId
end
go


------------- cliente join ---------------------------------------------------------------------------------------

create view v_clientes
as
	select p.id, p.nome, p.cpf, p.rg, p.dataNascimento, p.telefone, p.rua, p.bairro, p.cep, p.cidade, p.estado, p.status, c.quantidadeConsultasAberto    --<-------mod
	from clientes c, pessoas p
	where p.id = c.pessoaId and p.status = 0 -- Isso é caso vc queira filtrar numa lista de ativo e desativo, recoemdo fazer outras views
go
select * from v_clientes
go

update pessoas set status = 0

------------- veterinarios join ------------------------------------------------------------------------------------//////////////?

create view v_veterinarios
as
	select p.id, p.nome, p.cpf, p.rg, p.dataNascimento, p.telefone, p.rua, p.bairro, p.cep, p.cidade, p.estado,  p.status, v.especialidade, v.salario, 
	v.crmv, v.email, v.senha
	from veterinarios v, pessoas p
	where p.id = v.pessoaId and p.status = 0 -- msm coisa de clientes
go
select * from v_veterinarios
go

update animais set status = 0
go
------------- animais join ------------------------------------------------------------------------------------

create view v_animais
as
	select a.id, p.nome Cliente, a.nome Animal, a.idade, a.peso, a.raca, a.descricao, a.especie, a.status
	from clientes c, pessoas p, animais a
	where p.id = c.pessoaId and p.id = a.clienteId and a.status = 0 -- mesma coisa uma lista pra geral dps outra com filtro
go
select * from v_animais
go
------------- consultas join ------------------------------------------------------------------------------------ ///////? 

create view v_consultas
as
	select con.id, c.nome Cliente, vt.nome Veterinario, a.nome Animal, con.descricao,
	 con.valorTotal, con.data, con.status
	from v_clientes c, animais a, consultas con, v_veterinarios vt
	where  c.id = con.clienteId and vt.id = con.veterinarioId 
	and a.id = con.animalId 
	and a.id = con.animalId and con.status = 0--<-------------------------------� o procedimento id de consulta? da pra tirar sem bugar
go
select * from consultas
go

update consultas set status = 0

------------- procedimentos ------------------------------------------------------------------------------------
create view v_procedimentos
as
	select id, descricao, valor
	from procedimentos where status = 0
go
select * from v_procedimentos
go


------------- consultas procedimentos join ------------------------------------------------------------------------------------///////?

create view v_consultas_procedimentos
as
	select c.id, cli.nome Cliente, vet.nome Veterinario, ani.nome Animal, c.descricao Resultado, p.descricao Procedimento, c.valorTotal --<-----mudei
	from consultas c, consultas_procedimentos cp, procedimentos p, v_clientes cli, v_veterinarios vet, animais ani

	where  cp.consultaId = c.id and cp.procedimentoId = p.id 
	and c.clienteId = cli.id and c.veterinarioId = vet.id and c.animalId = ani.id
	and cli.id = ani.ClienteId
go

select * from v_consultas_procedimentos
go

------------- usuarios join ------------------------------------------------------------------------------------///////?

create view usuarios 
as 
select v.Pessoaid Id, p.nome Veterinario, p.dataNascimento, v.email, v.senha 
from veterinarios v, pessoas p
where v.pessoaId = p.id
go 

/*

------------- especialidades ------------------------------------------------------------------------------------

create view v_especialidades
as
	select id, descricao
	from Especialidades
go

select * from v_especialidades
------------- categorias ------------------------------------------------------------------------------------
create view v_categorias
as
	select id, descricao
	from categorias
go

select * from v_categorias
------------- especie ------------------------------------------------------------------------------------

create view v_especie
as
	select id, descricao
	from especies
go
select * from v_especie
------------- funcionarios join ------------------------------------------------------------------------------------

create view v_funcionarios
as
	select p.id, p.nome, p.cpf, p.rg, p.data_nascimento, p.telefone, f.salario
	from funcionarios f, pessoas p
	where p.id = f.pessoa_id
go
select * from v_funcionarios
------------- medicamentos join ------------------------------------------------------------------------------------

create view v_medicamentos
as
	select m.id, m.descricao, m.data_vencimento, m.data_fabricacao, m.categoria_medicamento_id, cm.descricao descricaoCategoria
	from medicamentos m, categorias cm
	where m.categoria_medicamento_id = cm.id
go
select * from v_medicamentos
------------- pagamentos join ------------------------------------------------------------------------------------
create view v_pagamentos
as
	select pag.id, p.nome, p.cpf, p.rg, pag.total, con.descricao, f.salario
	from clientes c, pessoas p, pagamentos pag, consultas con, funcionarios f
	where p.id = c.pessoa_id and pag.cliente_id = p.id 
	and pag.consulta_id = con.id and p.id = pag.funcionario_id
go

select * from v_pagamentos
------------- medicamentos procedimentos join ------------------------------------------------------------------------------------
create view v_medicamentos_procedimentos
as
	select m.descricao, m.data_vencimento, m.data_fabricacao, 
	cm.descricao CategoriaMedicamento, p.descricao Procedimento, p.valor,
	mp.quantidade 
	from medicamentos m, categorias cm, procedimentos p, 
	medicamentos_procedimentos mp
	where m.categoria_medicamento_id = cm.id and 
	p.id = mp.procedimento_id and m.id = mp.medicamento_id
go
select * from v_medicamentos_procedimentos
