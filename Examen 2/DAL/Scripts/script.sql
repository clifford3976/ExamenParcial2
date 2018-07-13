
CREATE DATABASE ParcialesDb
GO
USE ParcialesDb

GO

create TABLE Vehiculos
(
    VehiculosId int primary key identity(1,1),
	Descripcion varchar(max),
	TotalMantenimiento money
);
GO
create TABLE Talleres
(

    TallerId int primary key identity(1,1),
	Nombre varchar(30),

);
GO
create TABLE Articulos
(
 ArticulosId int primary key identity(1,1),
 Descripcion varchar(max),
 costo int,
 Ganancia int,
 precio decimal,
 Inventario decimal
);
GO

GO
create TABLE Mantenimiento
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
create TABLE MantenimientoDetalle
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
create TABLE EntradaArticulos
(
			EntradaId int primary key identity(1,1),
            Fecha date,
           ArticuloId int,         
            Cantidad int
           
      
);
GO
