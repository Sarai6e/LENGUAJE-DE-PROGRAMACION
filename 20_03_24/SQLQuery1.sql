
use LOGIN

-- Crear la tabla login_01
CREATE TABLE login_01 (
    nombre_de_usuario VARCHAR(50) NOT NULL,
    contraseña VARCHAR(50) NOT NULL
);

-- Insertar algunos ejemplos de datos
INSERT INTO login_01

(nombre_de_usuario, contraseña) 

VALUES ('usuario1', 'contraseña1');
INSERT INTO login_01 (nombre_de_usuario, contraseña) VALUES ('usuario2', 'contraseña2');
INSERT INTO login_01 (nombre_de_usuario, contraseña) VALUES ('usuario3', 'contraseña3');
INSERT INTO login_01 (nombre_de_usuario, contraseña) VALUES ('usuario4', 'contraseña4');
INSERT INTO login_01 