CREATE DATABASE ParcialesDb
GO
USE ParcialesDb
GO
CREATE TABLE Vehiculos
(
    VehiculosId int primary key identity(1,1),
	Descripcion varchar(max),
	TotalMantenimiento money
);
GO
CREATE TABLE Talleres
(

    TallerId int primary key identity(1,1),
	Nombre varchar(30),

);
GO
CREATE TABLE Articulos
(
 ArticuloId int primary key identity(1,1),
 Descripcion varchar(max),
 costo int,
 Ganancia int,
 precio decimal,
 Inventario decimal
);
GO

GO
CREATE TABLE Mantenimiento
(
			MantenimientoId int primary key identity(1,1),
			VehiculoId int,
            Fecha date,
			Subtotal money,
			ITBIS money,
			Total money
);
GO

GO
CREATE TABLE MantenimientoDetalle
(
			Id int primary key identity(1,1),
			MantenimientoId int,
            TallerId int,
            ArticulosId int,
            Articulo varchar(30),
            Cantidad int,
            Precio int,
            Importe int
      
);
GO

GO
CREATE TABLE EntradaArticulos
(
			EntradaId int primary key identity(1,1),
            Fecha date,
            Articulos Varchar(30),          
            Cantidad int
           
      
);
GO
