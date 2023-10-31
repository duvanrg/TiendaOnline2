CREATE TABLE pais(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_idpais PRIMARY KEY(id)
);

CREATE TABLE departamento(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    idpaisFk int(11),
    CONSTRAINT Pk_iddepartamento PRIMARY KEY(id),
    CONSTRAINT Fk_idpais FOREIGN KEY (idpaisFk) REFERENCES pais(id)
);

CREATE TABLE ciudad(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    iddepartamentoFk int(11),
    CONSTRAINT Pk_idciudad PRIMARY KEY(id),
    CONSTRAINT Fk_iddepartamento FOREIGN KEY (iddepartamentoFk) REFERENCES departamento(id)
);

CREATE TABLE tipoPersona(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_idtipoPersona PRIMARY KEY (id)
);

CREATE TABLE presentacion(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_idpresentacion PRIMARY KEY (id)
);

CREATE TABLE rolPersona(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_idrolPersona PRIMARY KEY(id)
);

CREATE TABLE formaPago(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_idformaPago PRIMARY KEY(id)
);

CREATE TABLE tipoMovimientoInventario(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_tipoMovimientoInventario PRIMARY KEY(id)
);

CREATE TABLE tipoContacto(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_idtipoContacto PRIMARY KEY(id)
);

CREATE TABLE marca(
    id int AUTO_INCREMENT,
    nombre varchar(50),
    CONSTRAINT Pk_idmarca PRIMARY KEY(id)
);

CREATE TABLE producto(
    code VARCHAR(10),
    nombreprod VARCHAR(100),
    idmarca int(11),
    CONSTRAINT Pk_producto PRIMARY KEY(code),
    CONSTRAINT Fk_idmarca FOREIGN KEY (idmarca) REFERENCES marca(id)
);

CREATE TABLE tipoDocumento (
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_tipoDocumento PRIMARY KEY (id)
);

CREATE TABLE persona(
    id VARCHAR (20),
    nombre VARCHAR(50),
    fechaRegistro DATE,
    idDocumento int(11),
    idRolPersona int(11),
    idTipoPersona int(11),
    CONSTRAINT pk_persona PRIMARY KEY (id),
    CONSTRAINT Fk_idDocumento FOREIGN KEY (idDocumento) REFERENCES tipoDocumento(id),
    CONSTRAINT Fk_idRolPersona FOREIGN KEY (idRolPersona) REFERENCES rolPersona(id),
    CONSTRAINT Fk_idTipoPersona FOREIGN KEY (idTipoPersona) REFERENCES tipoPersona(id)
);

CREATE TABLE ubicacionPersona(
    idDireccion int AUTO_INCREMENT,
    tipoDeVia varchar(50),
    numeroPri smallint,
    letra CHAR(2),
    bis CHAR(10),
    letrasec CHAR(2),
    cardinal CHAR(10),
    numeroSec smallint,
    letrater CHAR(2),
    numeroTer smallint,
    cardinalSec CHAR(10),
    complemento VARCHAR(50),
    idPersona varchar(20),
    idCiudad int(11),
    CONSTRAINT Pk_direccion_fk PRIMARY KEY (idDireccion),
    CONSTRAINT Fk_idPersona FOREIGN KEY (idPersona) REFERENCES persona(id),
    CONSTRAINT Fk_idCiudad FOREIGN KEY (idCiudad) REFERENCES ciudad(id)
);

CREATE TABLE contactoPersona(
    id int AUTO_INCREMENT,
    idPersona varchar(20),
    idTipoContacto int(11),
    CONSTRAINT Pk_contacto PRIMARY KEY(id),
    CONSTRAINT Fk_idPersonaContacto FOREIGN KEY (idPersona) REFERENCES persona(id),
    CONSTRAINT Fk_idTipoContact FOREIGN KEY (idTipoContacto) REFERENCES tipoContacto(id)
);

CREATE TABLE inventario(
    id varchar(10),
    nombre varchar(50),
    codProducto varchar(10),
    precio DECIMAL(11, 2),
    stock smallint,
    stockMin smallint,
    stockMax smallint,
    idPresentacion int(11),
    CONSTRAINT Pk_idinventario PRIMARY Key(id),
    CONSTRAINT Fk_codProducto FOREIGN KEY (codProducto) REFERENCES producto(code),
    CONSTRAINT Fk_idPresentacion FOREIGN KEY (idPresentacion) REFERENCES presentacion(id)
);

CREATE TABLE factura(
    id int AUTO_INCREMENT,
    facturaInicial int,
    facturaActual int,
    nroResolucion varchar(10),
    CONSTRAINT Pk_idfactura PRIMARY KEY (id)
);

CREATE TABLE movimientoInventario(
    id varchar(10),
    idResponsable varchar(20),
    idReceptor varchar(20),
    fechaMovimiento DATE,
    fechaVencimiento DATE,
    idtipoMovimientoInventario int(11),
    CONSTRAINT Pk_idMovInv PRIMARY KEY (id),
    CONSTRAINT Fk_idResponsable FOREIGN KEY (idResponsable) REFERENCES persona (id),
    CONSTRAINT FK_idReceptor FOREIGN KEY (idReceptor) REFERENCES persona (id),
    CONSTRAINT Fk_idtipoMovimientoInventario FOREIGN KEY (idtipoMovimientoInventario) REFERENCES tipoMovimientoInventario(id)
);

CREATE TABLE detalleMovimientoInventario(
    idInventario varchar(10),
    idMovInv VARCHAR(10),
    cantidad TINYINT,
    precio DECIMAL(11, 2),
    CONSTRAINT Pk_idinventario_idMovInv PRIMARY KEY (idMovInv, idInventario),
    CONSTRAINT Fk_idInventario FOREIGN KEY (idInventario) REFERENCES inventario(id),
    CONSTRAINT Fk_idMovInv FOREIGN KEY (idMovInv) REFERENCES movimientoInventario(id)
); 