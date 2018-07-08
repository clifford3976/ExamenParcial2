
CREATE DATABASE ParcialesDb
GO
USE ParcialesDb
drop table Vehiculos
GO
CREATE TABLE Vehiculos
(
    VehiculosId int primary key identity(1,1),
	Descripcion varchar(max),
	TotalMantenimiento money
);
Go
drop table Talleres
GO
CREATE TABLE Talleres
(

    TallerId int primary key identity(1,1),
	Nombre varchar(30),

);
GO
drop table Articulos
GO
CREATE TABLE Articulos
(
 ArticuloId int primary key identity(1,1),
 Descripcion varchar(max),
 costo money,
 Ganancia money,
 precio money,
 Inventario money
);
GO
drop table Mantenimiento
GO
CREATE TABLE Mantenimientos
(
			MantenimientoId int primary key identity(1,1),
			VehiculoId int,
            Fecha date,
			Subtotal money,
			ITBIS money,
			Total money
);
GO
drop table MantenimientosDetalles
GO
CREATE TABLE MantenimientosDetalles
(
			Id int primary key identity(1,1),
			MantenimientoId int,
            TallerId int,
            ArticulosId int,
            Articulo varchar(30),
            Cantidad int,
            Precio money,
            Importe int
      
);
GO
drop table EntradaArticulos
GO
CREATE TABLE EntradaArticulos
(
			EntradaId int primary key identity(1,1),
            Fecha date,
            Articulos Varchar(30),          
            Cantidad int
           
      
);
GO

select *from Articulos
select * from EntradaArticulos
select * from Talleres
select * from Vehiculos
select* from MantenimientosDetalles
select* from Mantenimientos





