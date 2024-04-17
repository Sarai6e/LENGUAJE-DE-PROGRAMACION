-- Creación de la base de datos
CREATE DATABASE virt;
GO

-- Uso de la base de datos shop
USE virt;
GO

-- Creación de la tabla Productos
CREATE TABLE Productos (
    IdProducto int primary key,
    Nombre varchar(100),
    Descripcion varchar(255),
    SKU varchar(50),
    Categoria varchar(100),
    Precio decimal(18, 2),
    CantidadStock int,
    UnidadMedida varchar(50),
    FechaVencimiento date
);
GO

-- Ejemplos de inserción en la tabla Productos
INSERT INTO Productos (IdProducto, Nombre, Descripcion, SKU, Categoria, Precio, CantidadStock, UnidadMedida, FechaVencimiento)
VALUES 
    (1, 'Camiseta', 'Camiseta de algodón de color blanco', 'CMST001', 'Ropa', 15.99, 50, 'Unidad', NULL),
    (2, 'Pantalón', 'Pantalón vaquero azul oscuro', 'PNLN002', 'Ropa', 29.99, 30, 'Unidad', NULL),
    (3, 'Leche', 'Leche desnatada en envase de un litro', 'LECH001', 'Lácteos', 1.99, 100, 'Litro', '2024-05-15');
GO

-- Creación de la tabla Proveedores
CREATE TABLE Proveedores (
    IdProveedor int primary key,
    NombreEmpresa varchar(100),
    NombreContacto varchar(100),
    Direccion varchar(255),
    Telefono varchar(20),
    CorreoElectronico varchar(100),
    TerminosPago varchar(100)
);
GO

-- Ejemplos de inserción en la tabla Proveedores
INSERT INTO Proveedores (IdProveedor, NombreEmpresa, NombreContacto, Direccion, Telefono, CorreoElectronico, TerminosPago)
VALUES 
    (1, 'Proveedor A', 'Juan Pérez', 'Calle Principal 123', '123456789', 'juan@example.com', 'Pago a 30 días'),
    (2, 'Proveedor B', 'María López', 'Avenida Secundaria 456', '987654321', 'maria@example.com', 'Pago a 60 días'),
    (3, 'Proveedor C', 'Pedro Ramírez', 'Plaza Central 789', '456123789', 'pedro@example.com', 'Pago a 45 días');
GO

-- Creación de la tabla Entradas de inventario
CREATE TABLE Entradas (
    IdEntrada int primary key,
    IdProducto int,
    CantidadRecibida int,
    FechaHoraEntrada datetime,
    IdProveedor int,
    NumeroFactura varchar(50),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto),
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor)
);
GO

-- Ejemplos de inserción en la tabla Entradas
INSERT INTO Entradas (IdEntrada, IdProducto, CantidadRecibida, FechaHoraEntrada, IdProveedor, NumeroFactura)
VALUES 
    (1, 1, 100, '2024-04-01 09:00:00', 1, 'FACT-001'),
    (2, 2, 50, '2024-04-02 10:30:00', 2, 'FACT-002'),
    (3, 3, 75, '2024-04-03 12:15:00', 3, 'FACT-003');
GO

-- Creación de la tabla Salidas de inventario
CREATE TABLE Salidas (
    IdSalida int primary key,
    IdProducto int,
    CantidadRetirada int,
    FechaHoraSalida datetime,
    MotivoSalida varchar(255),
    IdCliente int,
    NumeroFactura varchar(50),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);
GO

-- Ejemplos de inserción en la tabla Salidas
INSERT INTO Salidas (IdSalida, IdProducto, CantidadRetirada, FechaHoraSalida, MotivoSalida, IdCliente, NumeroFactura)
VALUES 
    (1, 1, 20, '2024-04-01 15:00:00', 'Venta al por menor', NULL, NULL),
    (2, 2, 10, '2024-04-02 11:45:00', 'Reemplazo de producto defectuoso', 1, 'FACT-003'),
    (3, 3, 5, '2024-04-03 14:30:00', 'Devolución de cliente', 2, NULL);
GO

-- Creación de la tabla Movimientos de inventario
CREATE TABLE Movimientos (
    IdMovimiento int primary key,
    TipoMovimiento varchar(50),
    IdProducto int,
    CantidadMovida int,
    FechaHoraMovimiento datetime,
    IdOrigen int,
    IdDestino int,
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto),
    FOREIGN KEY (IdOrigen) REFERENCES Proveedores(IdProveedor), -- Si el origen es un proveedor
    FOREIGN KEY (IdDestino) REFERENCES Proveedores(IdProveedor) -- Si el destino es un proveedor
);
GO

-- Ejemplos de inserción en la tabla Movimientos
INSERT INTO Movimientos (IdMovimiento, TipoMovimiento, IdProducto, CantidadMovida, FechaHoraMovimiento, IdOrigen, IdDestino)
VALUES 
    (1, 'Entrada', 1, 100, '2024-04-01 09:00:00', 1, NULL),
    (2, 'Salida', 2, 50, '2024-04-02 10:30:00', NULL, 1),
    (3, 'Entrada', 3, 75, '2024-04-03 12:15:00', 2, NULL);
GO
