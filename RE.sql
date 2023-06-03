create database DBTT
go

use DBTT
go

create table alum
(
	cod varchar(5),
	nombre varchar(50),
	direcc varchar(50),
    fecha int
);
go

create proc sp_lisalum
as
select * from alum order by cod 
go

create proc sp_busalum
@nombre varchar (50)
as
select cod,nombre,direcc,fecha from alum where nombre like @nombre + '%'
go

create proc sp_manalum
@cod varchar(5),
@nombre varchar(50),
@direcc varchar (50),
@fecha int,
@acc varchar (70) output
as
if (@acc= '1')
begin
	declare @codnu varchar(5), @codmx varchar(5)
	set @codmx =(select max(cod)from alum)
	set @codmx = isnull(@codmx, 'A0000')
	set @codnu ='A' +RIGHT(RIGHT(@codmx, 4)+10001, 4)
	insert into alum (cod,nombre,direcc,fecha)
	values (@codnu,@nombre,@direcc,@fecha)
	set @acc = 'se genero el codigo: '+@codnu
end
else if (@acc = '2')
begin
	update alum set nombre=@nombre, direcc=@direcc, fecha=@fecha where cod=@cod 
	set @acc ='se modifico el codigo: ' +@cod
end
else if (@acc = '3')
begin
	delete from alum where cod=@cod
	set @acc='se borro el codigo: ' +@cod
end
go


