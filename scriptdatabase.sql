/*create database CASTGROUP;*/

create table CATEGORIA
(Codigo int AUTO_INCREMENT PRIMARY KEY,
Descricao varchar(100)
);

create table CURSO
(
    CodigoCurso int not null AUTO_INCREMENT PRIMARY KEY,
	DecricaoAssunto varchar(200) not null ,
    DataInicio date not null,
    DataTermino date not null,
    QuantidadeTurma int null,
    CodigoCategoria int not null,
    FOREIGN KEY (CodigoCategoria)
        REFERENCES CATEGORIA (Codigo)
        ON UPDATE RESTRICT ON DELETE CASCADE
);

alter table `curso` add constraint `fk_categoria` foreign key (`CodigoCategoria`) references `categoria` (`Codigo`);