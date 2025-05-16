create database BancoTop;
use BancoTop;
create table Usuário(
id int primary key auto_increment,
nome varchar(80),
email varchar(100),
Senha varchar(50)
);
create table Produto(
id int primary key auto_increment,
nome varchar(80),
descricao varchar(100),
preco decimal(10,2),
quantidade int

);