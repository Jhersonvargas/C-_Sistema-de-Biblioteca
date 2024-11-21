
create procedure insertar_libros

@idlibro varchar(20),
@titulolibro varchar(150),
@editorial varchar(50),
@pais varchar(20),
@año int,
@nPag int,
@existencia int
as

insert into LIBROS(idlibro,titulolibro,editorial,pais,año,nPag,existencia)
values (@idlibro,@titulolibro,@editorial,@pais,@año,@nPag,@existencia)
set @idlibro=@@IDENTITY
go

EXECUTE insertar_libros 'A006','Planetas','Navarrate','Peru','2023','5','1'
select * from LIBROS
go


--------------------------------------------------------------------------------------------------------
create procedure Actualizar_libros

@idlibro varchar(20),
@titulolibro varchar(150),
@editorial varchar(50),
@pais varchar(20),
@año int,
@nPag int,
@existencia int
as

update libros
set
titulolibro=@titulolibro,
editorial=@editorial,
pais=@pais,
año=@año,
nPag=@nPag,
existencia=@existencia
where idlibro=@idlibro
go

EXECUTE Actualizar_libros 'A005','Planetas','Navarrate','Peru','2023','40','7'
select * from LIBROS
go




----------------------------------------------------------------------------------------------------
create procedure Elimina_Libros
@idlibro varchar(20)
as
delete from libros where idlibro=@idlibro
go

EXECUTE Elimina_Libros 'A006'
select * from LIBROS
go
----------------------------------------------------------------------------------------------------


create procedure listar_libros
as
select * from ConsultarLibrosAutor
go

EXECUTE listar_libros 
go
--------------------------------------------------------------------------------------------------------


create procedure Consultar_Libros_Idlibros
@idlibro varchar(20)
as
select * from libros where idlibro=@idlibro
go

EXECUTE Consultar_Libros_Idlibros 'A005'
go
----------------------------------------------------------------------------------------





create procedure IsentarLibro_Autor

@idlibro varchar(20),
@idAutor char(4)
as

insert into LIBROS_AUTOR(idlibro,idAutor)
values(@idlibro,@idAutor)
set @idlibro=@@IDENTITY
go
execute IsentarLibro_Autor 'A006','B006'
select * from LIBROS_AUTOR
go
------------------------------------------------------------------------------------------------------

create procedure ActualizarLibros_Autor

@idlibro varchar(20),
@idAutor char(4)
as

update LIBROS_AUTOR
set
idAutor=@idAutor

where idlibro=@idlibro

EXECUTE ActualizarLibros_Autor 'A001','B001'
select * from LIBROS_AUTOR
go

--------------------------------------------------------------------------------------------------------

create procedure VConsultar_Libros_Autor
@idlibro varchar(20)
as
select * from Vista_Libros_Autor where idlibro=@idlibro
go

execute VConsultar_Libros_Autor 'A001 '
go
------------------------------------------------------------------------------------------------------------




create procedure Llenar_Autor
as
select * from AUTOR
go

EXECUTE Llenar_Autor 
go



create procedure Agregar_Autor
@idAutor char(4),
@nomAutor varchar(50)
as
insert into AUTOR(idAutor,nomAutor)
values(@idAutor,@nomAutor)
go

execute Agregar_Autor 'B006','Peru 21'
select * from AUTOR
go
---------------------------------------------------------------------------------


create procedure Actualizar_Autor

@idAutor char(4),
@nomAutor varchar(50)
as

update AUTOR
set
nomAutor=@nomAutor
where idAutor=@idAutor
go

EXECUTE Actualizar_Autor 'B006','Planetas'
select * from AUTOR
go


--------------------------------------------------------------------------------------


create procedure Consultar_autores_Idautores
@idAutor char(4)
as
select * from AUTOR where idAutor=@idAutor
go

EXECUTE Consultar_autores_Idautores 'B005'
go
----------------------------------------------------------------------------------------

--SECCIOM DE TABLA DE ACCESO

---------------------------------------------------------------

--PROCEDIMIENTO ALMACENADO PARA EL ACCESO 
CREATE PROCEDURE validar_usuario
@idusuario INT,
@clave VARCHAR(100)
AS
BEGIN
    SELECT * FROM ACCESO
    WHERE ((idusuario = @idusuario) AND (clave= @clave));
END;
go

execute validar_usuario '1', 'Clave1'
go

---------------------------------------------------------------------------------

create procedure VConsultar_libros_Titulo
@titulolibro varchar(150)
as
select * from ConsultarLibrosAutor where titulolibro like '%\' + @titulolibro + '%' escape '\'
go 


execute VConsultar_libros_Titulo 'super'
go

--------------------------------------------------------------------------------------------------------------
create procedure VConsultar_libros_Pais 
@pais varchar(150)
as
select * from ConsultarLibrosAutor where pais like '%\' + @pais + '%' escape '\'
go


execute VConsultar_libros_Pais 'peru'
go


--------------------------------------------------------------------------------------------------------------------

create procedure VConsultar_libros_Editorial 
@editorial varchar(50)
as
select * from ConsultarLibrosAutor where editorial like '%\' + @editorial + '%' escape '\'
go


execute VConsultar_libros_Editorial 'vallejo'
go

--------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Consultar_Libros_PorAños
    @añodesde INT,
    @añohasta INT
AS
BEGIN
    SELECT * FROM ConsultarLibrosAutor
    WHERE año BETWEEN @añodesde AND @añohasta
END
go

execute Consultar_Libros_PorAños 2000, 2040
go

--------------------------------------------------------------------------------------------------------------------------

create procedure VConsultar_libros_Prestamos
@librosP varchar(150)
as
select * from ConsultarLibrosAutor where nomAutor like '%\' + @librosP + '%' escape '\' or titulolibro like '%\' + @librosP + '%' escape '\'

go

execute VConsultar_libros_Prestamos 'pe'
go

----------------------------------------------------------------------------------------------------------------------------------------------
create procedure Insertar_Prestamo
@idlibro varchar (20),
@fechaP date,
@fechaD date,
@Anulado char(10)
as
insert into PRESTAMO (idlibro,fechaP,fechaD,Anulado)
values (@idlibro,@fechaP,@fechaD,@Anulado)
set @idlibro=@@IDENTITY

go

exec Insertar_Prestamo 'A001','2015-02-12','2015-03-28','si'
go

-------------------------------------------------------------------------------------------------

go
create procedure Anular_Prestamo
@idlibro varchar(20),
@Anulado varchar(20)
as
update PRESTAMO
set
Anulado=@Anulado
where idlibro=@idlibro

go

exec Anular_Prestamo 'A006','no'
go

--------------------------------------------------------------------------------------------------

create procedure Actualizar_LibrosExis
@idlibro varchar(20),

@existencia int
as
update LIBROS
set
existencia=@existencia
where idlibro=@idlibro

go

exec Actualizar_LibrosExis 'A011','10'
go

---------------------------------------------------------------------------------------------------------

create procedure buscar_libroD
@fechaP date,
@fechaD date
as
select * from ConsultarLibrosActivos where ([Fecha de prestamo] >= @fechaP and [Fecha de prestamo] <=@fechaD) 
and ([Fecha de devolucion] >= @fechaP and [Fecha de devolucion] <=@fechaD);
go




-------------------------------------------------------------------------------------------------------------------
create procedure buscar_libroP
@fechaP date,
@fechaD date
as
select * from ConsultarLibrosInactivos where (fechaP >= @fechaP and fechaP <=@fechaD) and Anulado='no';
go


-----------------------------------------------------------------------------------------------------

create procedure ReporteAño
@año int,
@año2 int
as
select * from ConsultarLibrosAutor where año >= @año and año <= @año2
go


execute ReporteAño '2000' ,'2023'
go

----------------------------------------------------------------------------------------------------------------------






