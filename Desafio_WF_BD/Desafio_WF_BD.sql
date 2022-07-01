create database GestaoVendas_db

use GestaoVendas_db

create table clientes(

idCliente integer primary key not null identity,
nome varchar(50),
cpf varchar(20),
telefone varchar(20),
endereco varchar(100),
cidade varchar(100),
email varchar(50),
)

create table produtos(
idProduto integer primary key not null identity,
codEAN varchar(13),
nomeProduto varchar(50),
estoque int,
valorProduto real
)

create table vendas(
idVendas integer primary key not null identity,
codigoCliente int,
valorTotal real,
)

create table itemVenda(
idVenda integer primary key not null identity,
idProduto int,
valorUnidade real,
quantidade int,
valorTotal real
)

select *
from clientes


select *
from produtos



select *
from vendas

select *
from itemVenda

insert into clientes values('Jéssica', '39594519894', '11965114340', 'Acesso Garça Branca, 496, Balneário São José', 'São Paulo', 'jessica.gc@gmail.com');

drop table clientes

delete clientes