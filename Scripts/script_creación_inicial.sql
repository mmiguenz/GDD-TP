--begin tran
use [GD1C2015]

GO
create Schema datiados   authorization [gd]
GO



/*Países*/

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
	localidad varchar(100),
	habilitado bit  
)

/*Estados de cuenta*/

CREATE TABLE datiados.CuentaEstados(
	id_estado int IDENTITY(1,1) PRIMARY KEY,
	descripcion varchar(50)NOT NULL,
)

/*Categorías de Cuenta*/

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
	cod_moneda int FOREIGN KEY REFERENCES datiados.Monedas,
	diasRestantes int
)

/* EmisoresTarjeta*/

create table datiados.emisoresTarjetas
( codEmisor int identity primary key,
  descripcion varchar(100)
)


/* Tarjetas*/

CREATE TABLE datiados.Tarjetas(
	id_tarjeta int identity(1,1) primary key,
	numero varchar(16) not null ,
	fecha_emision date NOT NULL,
	fecha_venc date NOT NULL,
	cod_seg varchar(3) NOT NULL,
	codEmisor int NOT NULL foreign key references datiados.emisoresTarjetas,
)

/* Tarjetas por Cliente*/

CREATE TABLE datiados.Tarjetas_Cliente(
	
	id_tarjeta int FOREIGN KEY REFERENCES datiados.Tarjetas,
	id_cliente int FOREIGN KEY REFERENCES datiados.Clientes
	CONSTRAINT pK_Tarjetas_Cliente PRIMARY KEY (id_tarjeta,id_cliente)
)


/*Depósitos*/

CREATE TABLE datiados.Depositos(
	codigo numeric(18,0) PRIMARY KEY,
	nro_cuenta numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
	fecha datetime NOT NULL,
	importe decimal(18,4) NOT NULL,
	moneda int FOREIGN KEY REFERENCES datiados.Monedas,
	id_tarjeta int foreign key references datiados.tarjetas
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
	tipo_mov numeric(2,0) PRIMARY KEY,
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
	
)
	



--- CtaCte


CREATE TABLE datiados.CtaCte(
							 CtaCteId int IDENTITY (1,1) Primary key,
							 ClienteID int ,
							 importe numeric(18,2) NOT NULL,
							 fecha datetime,
							 tipoConcepto int foreign key references datiados.ItemConceptoTipos,
							 NroCta numeric(18,0) foreign key references datiados.cuentas,
							 Saldada bit,
							 id_transf int foreign key references datiados.transferencias
							 
							 
								)



/*Facturas*/

CREATE TABLE datiados.Facturas(
	numero numeric(18,0) PRIMARY KEY,
	fecha datetime NOT NULL,
	id_cliente int FOREIGN KEY REFERENCES datiados.Clientes,
	TOTAL DECIMAL(18,2) 
	
	
)



/*Items Facturas*/

CREATE TABLE datiados.Items_Facturas(
	id_item int ,
	nro_factura numeric(18,0) FOREIGN KEY REFERENCES datiados.Facturas,
	tipo_concepto int FOREIGN KEY REFERENCES datiados.ItemConceptoTipos,
	importe numeric(18,2) NOT NULL,
	nro_cuenta numeric(18,0) FOREIGN KEY REFERENCES datiados.Cuentas,
	id_transf int foreign key references datiados.transferencias
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
	descripcion varchar(255) NOT NULL UNIQUE,
)

/*Usuarios_Roles*/

CREATE TABLE datiados.Usuarios_Roles(
	id int IDENTITY(1,1) PRIMARY KEY,
	usr varchar(255) FOREIGN KEY REFERENCES datiados.Usuarios,
	id_rol int FOREIGN KEY REFERENCES datiados.Roles
)

/*Funcionalidades*/

CREATE TABLE datiados.Roles_Funcionalidades(
	
	id_rol int  FOREIGN KEY REFERENCES datiados.Roles,
	id_func int FOREIGN KEY REFERENCES datiados.Funcionalidades
)


create table datiados.loguinAuditoria
(id int identity primary key  ,
 usuario varchar(150),
 fechayHora datetime,
 descripcion varchar(100)
)




create table datiados.trimestre 
(
Trimestre varchar(100),
MDeste int,
Mhasta int

)


insert into datiados.trimestre values ('Enero-Marzo',1,3)
insert into datiados.trimestre values ('Abril-Junio',4,6)
insert into datiados.trimestre values  ('Julio-Septiembre',7,9)
insert into datiados.trimestre  values ('Octubre-Diciembre',10,12)






-- Miigracion =============================================================== 

/*Migración Tabla Bancos*/
INSERT INTO datiados.Bancos
SELECT DISTINCT Banco_Cogido,Banco_Nombre,Banco_Direccion
FROM gd_esquema.maestra
WHERE Banco_Cogido is not NULL
ORDER BY Banco_Cogido

/*Migración Tabla Cheques*/
INSERT INTO datiados.Cheques
SELECT DISTINCT Cheque_Numero,Banco_Cogido,Cheque_Importe,Cheque_Fecha
FROM gd_esquema.maestra
WHERE Cheque_Numero is not NULL

/* Migración Tabla Países*/
INSERT INTO datiados.Paises
SELECT DISTINCT  Cuenta_Pais_Codigo,Cuenta_Pais_Desc
FROM gd_esquema.maestra
UNION 
SELECT DISTINCT Cli_Pais_Codigo,Cli_Pais_Desc
FROM gd_esquema.maestra
ORDER BY 1

/*Migración Tabla Tipo Doc*/
INSERT INTO datiados.TipoDoc
SELECT DISTINCT Cli_Tipo_Doc_Cod,Cli_Tipo_Doc_Desc
FROM gd_esquema.maestra
ORDER BY Cli_Tipo_Doc_Cod

/*Migración Tabla Clientes*/
INSERT INTO datiados.clientes
SELECT DISTINCT Cli_Nro_Doc,Cli_Tipo_Doc_Cod,cli_pais_codigo,Cli_Nombre,Cli_Apellido,Cli_Dom_Calle,Cli_Dom_Nro,Cli_Dom_Piso,Cli_Dom_Depto,Cli_Mail,Cli_Fecha_Nac,'',1
FROM gd_esquema.maestra


/*Carga CuentaEstados*/
INSERT INTO datiados.CuentaEstados (descripcion) values('Habilitada')
INSERT INTO datiados.CuentaEstados (descripcion) values('Inhabilitada')
INSERT INTO datiados.CuentaEstados (descripcion) values('Pendiente de activación')
INSERT INTO datiados.CuentaEstados (descripcion) values('Cerrada')

/*Carga CuentaCategorías*/
INSERT INTO datiados.CuentaCategorias (descripcion,costo) values('Gratuita',0)
INSERT INTO datiados.CuentaCategorias (descripcion,costo) values('Bronce',10) 
INSERT INTO datiados.CuentaCategorias (descripcion,costo) values('Plata',50) 
INSERT INTO datiados.CuentaCategorias (descripcion,costo) values('Oro',100) 

/*Carga Tabla Monedas*/
INSERT INTO datiados.Monedas values ('Dolar',1)

/*Migración Tabla emisoresTarjetas*/

insert into datiados.emisoresTarjetas
select distinct Tarjeta_Emisor_Descripcion from gd_esquema.maestra
where Tarjeta_Numero is not null



/*Migración Tabla Tarjetas*/
INSERT INTO datiados.Tarjetas
SELECT DISTINCT Tarjeta_Numero,Tarjeta_Fecha_Emision,Tarjeta_Fecha_Vencimiento,Tarjeta_Codigo_Seg,emi.codEmisor
FROM gd_esquema.maestra m
inner join  datiados.emisoresTarjetas emi on emi.descripcion = m.Tarjeta_Emisor_Descripcion
WHERE Tarjeta_Numero is NOT NULL
ORDER BY Tarjeta_Numero




/*Migración Tabla Cuentas*/
INSERT INTO datiados.Cuentas 
SELECT DISTINCT Cuenta_Numero,c.id,1,Cuenta_Pais_Codigo,Cuenta_Fecha_Creacion,Cuenta_Fecha_Cierre,1,1
FROM gd_esquema.maestra m
inner join datiados.clientes c on m.cli_nro_doc= c.nro_doc and m.cli_tipo_doc_cod= c.cod_tipo_doc

/*Migración Tabla Depósitos*/
INSERT INTO datiados.Depositos
SELECT  m.Deposito_Codigo,m.Cuenta_Numero,m.Deposito_fecha,m.Deposito_Importe,1,t.id_tarjeta
from gd_esquema.maestra m
inner join datiados.emisoresTarjetas et on et.descripcion = m.tarjeta_emisor_descripcion
inner join datiados.tarjetas t on  t.codemisor = et.codemisor and  t.numero = m.tarjeta_numero
where deposito_codigo is NOT NULL


/*Migración Tabla Retiros*/
INSERT INTO datiados.Retiros 
SELECT  Retiro_Codigo,Cuenta_Numero,Retiro_Fecha,Retiro_Importe,Cheque_Numero,Banco_Cogido
from gd_esquema.maestra
where Retiro_Codigo is NOT NULL
order by  Retiro_Codigo 

/*/*Migración Tabla Transferencias*/
INSERT INTO datiados.Transferencias
SELECT Cuenta_Numero,Cuenta_Dest_Numero,Trans_Importe,Transf_Fecha
FROM gd_esquema.maestra
WHERE Item_Factura_Descr is not null*/




/*Migración Tabla Tarjetas_Cliente*/

INSERT INTO datiados.Tarjetas_Cliente
SELECT DISTINCT t.id_tarjeta,c.id
FROM gd_esquema.maestra m
 inner join datiados.Clientes c ON (m.Cli_Nro_Doc = c.nro_doc) AND (m.Cli_Tipo_Doc_Cod = c.cod_tipo_doc)
 inner join datiados.emisoresTarjetas et on (et.descripcion = m.tarjeta_emisor_descripcion)
 inner join datiados.tarjetas t on (m.tarjeta_numero = t.numero and et.codemisor = t.codemisor)
WHERE m.Tarjeta_Numero is NOT NULL



/*Cargo Tabla TipoMovCuentas*/
INSERT INTO datiados.TipoMovCuentas values(1,'IngXDeposito','+')
INSERT INTO datiados.TipoMovCuentas values(2,'IngXTransf','+')
INSERT INTO datiados.TipoMovCuentas values(3,'EgrXTransf','-')
INSERT INTO datiados.TipoMovCuentas values(4,'EgrXRetiro','-')

INSERT INTO datiados.cuentaMovimientos (nro_cuenta,tipo_mov,Importe,Fecha)
SELECT nro_cuenta,1,importe,fecha
FROM datiados.depositos

UNION 

SELECT nro_cuenta,4,r.importe,r.Fecha
FROM datiados.retiros r 
INNER JOIN datiados.cheques c on c.numero_cheque = r.nro_cheque

UNION

SELECT cta_origen,3,importe,fecha from datiados.transferencias

UNION

SELECT cta_destino,2,importe,fecha from datiados.transferencias 

-- LLENO TABLA  FUNCIONALIDADES
insert into datiados.funcionalidades values ('ABMmenu')
insert into datiados.funcionalidades values('ClientesMenu')
insert into datiados.funcionalidades values ('ClientesAlta')
insert into datiados.funcionalidades values('ClientesBaja')
insert into datiados.funcionalidades values('ClientesModificacion')
insert into datiados.funcionalidades values('CuentasMenu')
insert into datiados.funcionalidades values('CuentasAlta')
insert into datiados.funcionalidades values('CuentasBaja')
insert into datiados.funcionalidades values('CuentasModificacion')
insert into datiados.funcionalidades values('UsuariosMenu')
insert into datiados.funcionalidades values('UsuariosAlta')
insert into datiados.funcionalidades values('UsuariosBaja')
insert into datiados.funcionalidades values('UsuariosModificacion')
insert into datiados.funcionalidades values('RolMenu')
insert into datiados.funcionalidades values('RolAlta')
insert into datiados.funcionalidades values('RolBaja')
insert into datiados.funcionalidades values('RolModificacion')
insert into datiados.Funcionalidades values('ListadosMenu')
insert into datiados.Funcionalidades values('MovimientosMenu')
insert into datiados.Funcionalidades values('ConsultasMenu')
insert into datiados.Funcionalidades values('FacturacionMenu')
insert into datiados.Funcionalidades values('CambiarRolMenu')




-- LLENO TABLA ROLES
insert into datiados.roles values('Administrador',1)
insert into datiados.roles values('Cliente',1)


-- LLENO TABLA USUARIOS
insert into datiados.usuarios
select c.nombre +'_'+ c.apellido+'_'+left(isnull(c.mail,''),3),'',1,GETDATE(),GETDATE(),'','',0,c.id
from datiados.clientes c


--LLENO TABLA USUARIOS_ROLES
insert into datiados.usuarios_roles 
select username,2 
from datiados.usuarios

insert into datiados.usuarios_roles
select top 10 username,1
from datiados.usuarios





-- LLENO TABLA ROLES - FUNCIONALIDADES
insert into datiados.roles_funcionalidades
select id_rol,id_func from datiados.funcionalidades,datiados.roles
where id_rol = 1 


  
  

-- LLENO CONCEPTOS FACTURAS

INSERT INTO DATIADOS.ITEMCONCEPTOTIPOS VALUES('comision por transferencia')
INSERT INTO DATIADOS.ITEMCONCEPTOTIPOS VALUES('Apertura de cuenta')


-- LLENO FACTURAS 
insert into datiados.facturas
SELECT  FACTURA_NUMERO, FACTURA_FECHA,C.ID,SUM(isnull(ITEM_FACTURA_IMPORTE,0)) FROM gd_esquema.maestra M 
INNER JOIN DATIADOS.CLIENTES C ON C.NRO_DOC = M.cLI_NRO_DOC AND C.COD_TIPO_DOC = M.CLI_TIPO_DOC_COD
 WHERE M.FACTURA_NUMERO IS NOT NULL
 GROUP BY FACTURA_NUMERO,C.ID,FACTURA_FECHA
ORDER BY M.FACTURA_NUMERO



/*/*Migración Tabla Transferencias*/
INSERT INTO datiados.Transferencias
SELECT Cuenta_Numero,Cuenta_Dest_Numero,Trans_Importe,Transf_Fecha
FROM gd_esquema.maestra
WHERE Item_Factura_Descr is not null*/



create table #temp
(id_transf int identity (1,1),
 cuenta_numero numeric(18,0),
 cuenta_dest_numero numeric(18,0),
 trans_importe numeric(18,2),
 transf_fecha datetime,
 factura_numero numeric(18,0),
 item_factura_importe numeric(18,2)
 
)


insert into #temp
SELECT Cuenta_Numero,Cuenta_Dest_Numero,Trans_Importe,Transf_Fecha,factura_numero,item_factura_importe
FROM gd_esquema.maestra
WHERE Item_Factura_Descr is not null

insert into datiados.transferencias
select Cuenta_Numero,Cuenta_Dest_Numero,Trans_Importe,Transf_Fecha
from #temp
order by id_transf

insert into datiados.items_facturas
select 1,factura_numero,1,item_factura_importe,cuenta_numero,id_transf
from #temp
order by id_transf

--commit tran
--rollback tran