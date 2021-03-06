USE [GDScriptTest]
GO

GO



/*Pa�ses*/

CREATE TABLE datiados.Paises(
	codigo numeric(18, 0) PRIMARY KEY,
	descripcion varchar(255) NOT NULL,
)

/*Bancos*/

CREATE TABLE datiados.Bancos(
	codigo numeric(18, 0) PRIMARY KEY,
	nombre varchar(255) NOT NULL,
	direccion varchar(255) NOT NULL,
)

/*Cheques*/

CREATE TABLE datiados.Cheques(
	numero_cheque numeric(18,0),
	cod_banco numeric(18,0) FOREIGN KEY  REFERENCES datiados.Bancos,
	importe decimal(18,4) NOT NULL,
	fecha datetime NOT NULL,
	CONSTRAINT pk_Cheques PRIMARY KEY (numero_cheque,cod_banco)
)

/* Tipo Documento*/

CREATE TABLE datiados.TipoDoc(
	cod_doc numeric(18,0) PRIMARY KEY,
	descripcion varchar(255) NOT NULL
)

/*Clientes*/

CREATE TABLE datiados.Clientes(
	id int IDENTITY(1,1) PRIMARY KEY,
	nro_doc numeric(18,0) UNIQUE,
	cod_tipo_doc numeric(18,0) FOREIGN KEY REFERENCES datiados.TipoDoc,
	cod_pais numeric(18,0) FOREIGN KEY REFERENCES datiados.Paises,
	nombre varchar(255) NOT NULL,
	apellido varchar(255) NOT NULL,
	dir_calle varchar(255) NOT NULL,
	dir_altura numeric(18,0) NOT NULL,
	dir_piso numeric(3,0),
	dir_dpto varchar(10),
	mail varchar(255) NOT NULL UNIQUE,
	fecha_nac datetime NOT NULL,
)

/*Estados de cuenta*/

CREATE TABLE datiados.CuentaEstados(
	id_estado int IDENTITY(1,1) PRIMARY KEY,
	descripcion varchar(50)NOT NULL,
)

/*Categor�as de Cuenta*/

CREATE TABLE datiados.CuentaCategorias(
	id_categoria int IDENTITY(1,1) PRIMARY KEY,
	descripcion varchar(150) NOT NULL,
	costo decimal(18,4) NOT NULL,
)

/*Monedas*/

CREATE TABLE datiados.Monedas(
	moneda_id int IDENTITY(1,1) PRIMARY KEY,
	descripcion varchar(100)NOT NULL,
	cotizacion decimal(18,4) NOT NULL,
)

/*Cuentas*/

CREATE TABLE datiados.Cuentas(
	nro_cuenta numeric(18,0) PRIMARY KEY,
	cliente_id int FOREIGN KEY REFERENCES datiados.Clientes,
	cod_estado int FOREIGN KEY REFERENCES datiados.CuentaEstados,
	cod_pais numeric(18,0) FOREIGN KEY REFERENCES datiados.Paises,
	fecha_creacion datetime NOT NULL,
	fecha_cierre datetime,
	categoria int FOREIGN KEY REFERENCES datiados.CuentaCategorias,
	cod_moneda int FOREIGN KEY REFERENCES datiados.Monedas
)

/* Tarjetas*/

CREATE TABLE datiados.Tarjetas(
	numero varchar(16) PRIMARY KEY,
	fecha_emision date NOT NULL,
	fecha_venc date NOT NULL,
	cod_seg varchar(3) NOT NULL,
	emisor varchar(250) NOT NULL,
)

/* Tarjetas por Cliente*/

CREATE TABLE datiados.Tarjetas_Cliente(
	id int IDENTITY(1,1) PRIMARY KEY,
	nro_tarjeta varchar(16) FOREIGN KEY REFERENCES datiados.Tarjetas,
	id_cliente int FOREIGN KEY REFERENCES datiados.Clientes
)


/*Dep�sitos*/

CREATE TABLE datiados.Depositos(
	codigo numeric(18,0) PRIMARY KEY,
	nro_cuenta numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
	fecha datetime NOT NULL,
	importe decimal(18,4) NOT NULL,
	moneda int FOREIGN KEY REFERENCES datiados.Monedas,
	nro_tarjeta varchar(16) FOREIGN KEY REFERENCES datiados.Tarjetas
)

/*Retiros*/

CREATE TABLE datiados.Retiros(
	codigo numeric(18,0) PRIMARY KEY,
	nro_cuenta numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
	fecha datetime NOT NULL,
	importe decimal(18,4) NOT NULL,
	nro_cheque numeric(18,0) NOT NULL,
	cod_banco numeric(18,0) NOT NULL,
	CONSTRAINT fk_cheques_retiros FOREIGN KEY (nro_cheque,cod_banco) REFERENCES datiados.Cheques
)

/*Transferencias*/

CREATE TABLE datiados.Transferencias(
		id_transf int IDENTITY(1,1) PRIMARY KEY,
		cta_origen numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
		cta_destino numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
		importe decimal(18,4) NOT NULL,
		fecha datetime NOT NULL,
		
)

/*Tipo de Movimientos en Cuentas*/

CREATE TABLE datiados.TipoMovCuentas(
	cod_mov numeric(2,0) PRIMARY KEY,
	descripcion varchar(150) NOT NULL,
	signo char(1) NOT NULL
)
	
/*Movimientos en Cuentas*/

CREATE TABLE datiados.CuentaMovimientos(
	cod_mov int IDENTITY(1,1),
	nro_cuenta numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
	tipo_mov numeric(2,0) FOREIGN KEY REFERENCES datiados.TipoMovCuentas,
	importe decimal(18,4) NOT NULL,
	fecha datetime NOT NULL,
	CONSTRAINT pk_CtaMovs PRIMARY KEY (cod_mov,nro_cuenta)
)

/* Tipos de Items de Facturas*/

CREATE TABLE datiados.ItemConceptoTipos(
	id_tipo int IDENTITY(1,1) PRIMARY KEY,
	descripcion varchar(255) NOT NULL,
	porc_import_transf decimal(18,4) DEFAULT 0,
	costo decimal(18,4) DEFAULT 0,
)
	



--- CtaCte


CREATE TABLE datiados.CtaCte(
							 CtaCteId int IDENTITY (1,1) Primary key,
							 ClienteID int foreign key references datiados.clientes,
							 importe numeric(18,2) NOT NULL,
							 fecha datetime,
							 tipoConcepto int foreign key references datiados.ItemConceptoTipos,
							 NroCta numeric(18,0) foreign key references datiados.cuentas,
							 Saldada bit 
							 
								)



/*Facturas*/

CREATE TABLE datiados.Facturas(
	numero numeric(18,0) PRIMARY KEY,
	fecha datetime NOT NULL,
	id_cliente int FOREIGN KEY REFERENCES datiados.Clientes,
	
	
)



/*Items Facturas*/

CREATE TABLE datiados.Items_Facturas(
	id_item int IDENTITY(1,1),
	tipo_concepto int FOREIGN KEY REFERENCES datiados.ItemConceptoTipos,
	nro_factura numeric(18,0) FOREIGN KEY REFERENCES datiados.Facturas,
	descripcion varchar(255) NOT NULL,
	importe numeric(18,2) NOT NULL,
	nro_cuenta numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
	CtaCteID int foreign key references datiados.CtaCte
	CONSTRAINT pf_Item_Facturas PRIMARY KEY (id_item,nro_factura)
)



/*Roles*/

CREATE TABLE datiados.Roles(
	id_rol int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(255) NOT NULL,
	estado bit NOT NULL DEFAULT 0
)	
/*Usuarios*/

CREATE TABLE datiados.Usuarios(
	username varchar(255)NOT NULL PRIMARY KEY,
	pwd varchar(255) NOT NULL,
	estado bit DEFAULT 0,
	rol_id int FOREIGN KEY REFERENCES datiados.Roles,
	fecha_creac datetime NOT NULL,
	fecha_ult_modif datetime NOT NULL,
	preg_secr varchar(255),
	rta_secr varchar(255),
	cant_intentos_fallidos int DEFAULT 0,
	clienteID int foreign key references datiados.clientes
)

/*Funcionalidades*/

CREATE TABLE datiados.Funcionalidades(
	id_func int IDENTITY(1,1) PRIMARY KEY,
	descripcion varchar(255) NOT NULL,
)

/*Usuarios_Roles*/

CREATE TABLE datiados.Usuarios_Roles(
	id int IDENTITY(1,1) PRIMARY KEY,
	id_usr varchar(255) FOREIGN KEY REFERENCES datiados.Usuarios,
	id_rol int FOREIGN KEY REFERENCES datiados.Roles
)

/*Roles_Funcionalidades*/

CREATE TABLE datiados.Roles_Funcionalidades(
	id int IDENTITY(1,1) PRIMARY KEY,
	id_rol int FOREIGN KEY REFERENCES datiados.Roles,
	id_func int FOREIGN KEY REFERENCES datiados.Funcionalidades
)