USE tempdb
GO

CREATE DATABASE DBICMA
GO

USE DBICMA
GO



--Creamos la tabla de inventario
CREATE TABLE Inventario
(
	CodigoProducto INT IDENTITY(1,1) NOT NULL,
	NombreProducto NVARCHAR(50),
	Precio INT,
	Proveedor INT,
	Caracteristicas NVARCHAR(200),
	TipoProducto BIT

	CONSTRAINT PK_Inventario_CodigoProducto PRIMARY KEY CLUSTERED(CodigoProducto)
)

-- Creamos la tabla de Proveedores
CREATE TABLE Proveedor
(
	CodigoProveedor INT IDENTITY(1,1) NOT NULL,
	NombreProveedor NVARCHAR(75) NOT NULL,
	Direccion NVARCHAR(125) NOT NULL,
	Telefono VARCHAR(9) NOT NULL,
	TelefonoSecundario VARCHAR(9)

	CONSTRAINT PK_Proveedor_CodigoProveedor PRIMARY KEY CLUSTERED(CodigoProveedor),
	CONSTRAINT PK_Proveedor_NombreProveedor UNIQUE NONCLUSTERED(NombreProveedor)
)

-- Creamos la tabla de clientes
CREATE TABLE Cliente
(
	CodigoCliente INT IDENTITY(1,1) NOT NULL,
	NombreCliente NVARCHAR(125) NOT NULL,
	TelefonoCliente VARCHAR(9) NOT NULL,
	TelefonoSecundarioCliente VARCHAR(9)

	CONSTRAINT PK_Cliente_CodigoCliente PRIMARY KEY CLUSTERED(CodigoCliente),
	CONSTRAINT PK_Cliente_NombreCliente UNIQUE NONCLUSTERED(NombreCliente)
)

-- Creamos la tabla de cotizaciones
CREATE TABLE Cotizacion
(
	CodigoCotizacion VARCHAR(7) NOT NULL,
	DireccionDeAlmacenaje NVARCHAR(150)NOT NULL,
	FechaDeCreacion DATE NOT NULL,
	Cliente INT NOT NULL

	CONSTRAINT PK_Cotizacion_CodigoCotizacion PRIMARY KEY CLUSTERED(CodigoCotizacion),
	CONSTRAINT PK_Cotizacion_DireccionDeAlmacenaje UNIQUE NONCLUSTERED(DireccionDeAlmacenaje)
)

-- Creamos la tabla de tipos de producto
CREATE TABLE TipoDeProducto
(
	CodigoTipoProducto BIT NOT NULL,
	TipoDeProducto NVARCHAR(75) NOT NULL

	CONSTRAINT PK_TipoDeProducto_CodigoTipoProducto PRIMARY KEY CLUSTERED(CodigoTipoProducto),
	CONSTRAINT PK_TipoDeProducto_TipoDeProducto UNIQUE NONCLUSTERED(TipoDeProducto)
)


--- Creamos las llaves foraneas para las relaciones de cada tabla
-----------------------------------------------------------------------------------
ALTER TABLE Inventario

	ADD CONSTRAINT FK_Inventario_TipoProducto FOREIGN KEY (TipoProducto) REFERENCES TipoDeProducto(CodigoTipoProducto)
	ON UPDATE CASCADE
	ON DELETE NO ACTION,

	CONSTRAINT FK_Inventario_Proveedor FOREIGN KEY (Proveedor) REFERENCES Proveedor(CodigoProveedor)
	ON UPDATE CASCADE
	ON DELETE NO ACTION
GO


ALTER TABLE Cotizacion

	ADD CONSTRAINT FK_Cotizacion_Cliente FOREIGN KEY (Cliente) REFERENCES Cliente(CodigoCliente)
	ON UPDATE CASCADE
	ON DELETE NO ACTION
GO
