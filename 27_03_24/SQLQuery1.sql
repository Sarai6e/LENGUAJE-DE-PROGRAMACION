

create database cliente

GO


USE cliente

GO

CREATE TABLE empleado(
    Idempleado int primary key identity,
    Nombre varchar(100),
    Apellido varchar(100),
    DNI varchar(20), -- Cambiado a varchar para permitir caracteres no numéricos
    Cargo varchar(100),
    Numero_celular varchar(10),
    Fecha_nacimiento date,
    Domicilio varchar(255) -- Ajustado la longitud y eliminado getdate()
);


go


-- Ejemplo 1
INSERT INTO empleado (Nombre, Apellido, DNI, Cargo, Numero_celular, Fecha_nacimiento, Domicilio)
VALUES ('Juan', 'Pérez', '12345678A', 'Gerente', '123456789', '1990-05-15', 'Calle Principal 123');

-- Ejemplo 2
INSERT INTO empleado (Nombre, Apellido, DNI, Cargo, Numero_celular, Fecha_nacimiento, Domicilio)
VALUES ('María', 'González', '98765432Z', 'Asistente', '987654321', '1985-08-20', 'Avenida Central 456');

-- Ejemplo 3
INSERT INTO empleado (Nombre, Apellido, DNI, Cargo, Numero_celular, Fecha_nacimiento, Domicilio)
VALUES ('Carlos', 'López', '56789012B', 'Analista', '567890123', '1993-11-10', 'Plaza Mayor 789');

-- Ejemplo 4
INSERT INTO empleado (Nombre, Apellido, DNI, Cargo, Numero_celular, Fecha_nacimiento, Domicilio)
VALUES ('Ana', 'Martínez', '34567890C', 'Recepcionista', '345678901', '1988-03-25', 'Calle Secundaria 234');

-- Ejemplo 5
INSERT INTO empleado (Nombre, Apellido, DNI, Cargo, Numero_celular, Fecha_nacimiento, Domicilio)
VALUES ('Pedro', 'Rodríguez', '90123456D', 'Contador', '901234567', '1979-07-12', 'Avenida Principal 789');
