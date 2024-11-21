create database Biblioteca 
go
use Biblioteca
go

CREATE TABLE LIBROS
(
idlibro varchar(20) NOT NULL,
titulolibro varchar(150) NOT NULL,
editorial varchar(50) NULL,
pais varchar (20) NULL,
a�o int NULL,
nPag int NULL,
existencia int NOT NULL,
CONSTRAINT PK_LIBROS_idlibro PRIMARY KEY (idlibro),
)
go

CREATE TABLE PRESTAMO
(
codPrestamo int IDENTITY(1,1),
idlibro varchar (20) NOT NUll,
fechaP date NOT NULL,
fechaD date NOT NULL,

CONSTRAINT PK_PRESTAMO_codPrestamo PRIMARY KEY (codPrestamo),
CONSTRAINT FK_PRESTAMO_idlibro FOREIGN KEY (idlibro) REFERENCES LIBROS(idlibro)
)
go

CREATE TABLE AUTOR
(
idAutor char(4) NOT NULL,
nomAutor varchar(50)NOT NULL,
CONSTRAINT PK_AUTOR_idAutor PRIMARY KEY (idAutor)
)
go
--select * from AUTOR 
--delete from AUTOR where idAutor='A007'


CREATE TABLE LIBROS_AUTOR
(
idlibro varchar(20) NOT NULL,
idAutor char(4)NOT NULL,
CONSTRAINT PK_MB_AUTOR_idlibro_idAutor PRIMARY KEY(idlibro,idAutor),
CONSTRAINT FK_AUTOR_idlibro FOREIGN KEY (idlibro) REFERENCES LIBROS(idlibro),
CONSTRAINT FK_AUTOR_idAutor FOREIGN KEY (idAutor) REFERENCES AUTOR(idAutor)
)
GO
--select * from LIBROS_AUTOR



CREATE TABLE ACCESO
(
idusuario int identity(1,1) primary key not null,
clave varchar(100) not null
)
go
--select * from ACCESO

insert into ACCESO(clave) values ('Clave1')
insert into ACCESO(clave) values ('Clave2')
insert into ACCESO(clave) values ('Clave3')
insert into ACCESO(clave) values ('Clave4')
insert into ACCESO(clave) values ('Clave5')
insert into ACCESO(clave) values ('Clave6')
go



--insert into LIBROS_AUTOR(idlibro,idAutor) values ('A001', 'B001')



insert into LIBROS(idlibro,titulolibro,editorial,pais,a�o,nPag,existencia) values ('A001', 'La Nacion', 'Comercio', 'Bolivia', '1996', '22', '5')
insert into LIBROS(idlibro,titulolibro,editorial,pais,a�o,nPag,existencia) values ('A002', 'Liderasgo', 'USP', 'Peru', '2010', '50', '10')
insert into LIBROS(idlibro,titulolibro,editorial,pais,a�o,nPag,existencia) values ('A003', 'Ciudad de los Perros', 'Navarrete', 'Peru', '1980', '101', '6')
insert into LIBROS(idlibro,titulolibro,editorial,pais,a�o,nPag,existencia) values ('A004', 'Macroeconomia', 'UNT', 'Argentina', '2010', '101', '5')
insert into LIBROS(idlibro,titulolibro,editorial,pais,a�o,nPag,existencia) values ('A005', 'Matematica I', 'La Republica', 'Chile', '1996', '50', '5')
go

--select * from LIBROS

insert into AUTOR(idAutor,nomAutor) values ('B001', 'El comercio')
insert into AUTOR(idAutor,nomAutor) values ('B002', 'Hermano Soto')
insert into AUTOR(idAutor,nomAutor) values ('B003', 'Vargas Llosa')
insert into AUTOR(idAutor,nomAutor) values ('B004', 'Peru 21')
insert into AUTOR(idAutor,nomAutor) values ('B005', 'Felipe Calderon')
go

--select * from AUTOR
--delete from AUTOR where idAutor='B013'


insert into PRESTAMO(idlibro,fechaP,fechaD) values ('A003','2014/05/12','2014/05/31')
insert into PRESTAMO(idlibro,fechaP,fechaD) values ('A001','2015-02-12','2015-03-28')
insert into PRESTAMO(idlibro,fechaP,fechaD) values ('A004','2016-01-20','2016-02-10')
insert into PRESTAMO(idlibro,fechaP,fechaD) values ('A003','2016-02-10','2016-02-20')
insert into PRESTAMO(idlibro,fechaP,fechaD) values ('A005','2016-03-01','2016-03-30')
go

--select * from PRESTAMO





