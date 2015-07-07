--begin tran t1 
--rollback tran t1 
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




create table datiados.tiposListados
(
	id int ,
	descripcion varchar(max)
)


 insert into datiados.tiposListados values  (1,'Clientes que alguna de sus cuentas fueron inhabilitadas por no pagar los costos de transacción')
 insert into datiados.tiposListados values  (2,'Cliente con mayor cantidad de comisiones facturadas en todas sus cuentas')
 insert into datiados.tiposListados values  (3,'Clientes con mayor cantidad de transacciones realizadas entre cuentas propias')
 insert into datiados.tiposListados values  (4,'Países con mayor cantidad de movimientos tanto ingresos como egresos')
 insert into datiados.tiposListados values  (5,'Total facturado para los distintos tipos de cuentas')



create table datiados.historialDeudores
(
nroCta numeric(18,0),
clienteID int ,
fecha datetime

)


create table datiados.gestionCuentas
(
	fechaUltimaGestion datetime primary key
)


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
SELECT DISTINCT Cuenta_Numero,c.id,1,Cuenta_Pais_Codigo,Cuenta_Fecha_Creacion,Cuenta_Fecha_Cierre,1,1,null
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
insert into datiados.Funcionalidades values('retiros')
insert into datiados.Funcionalidades values('depositos')
insert into datiados.Funcionalidades values('transferencias')
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







-------------Set de datos usuarios --------------- 



update datiados.Usuarios set pwd = 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'
where username in('Agata_Duarte_aga','Aien_Rodríguez_aie','Alejandro_Figueroa_ale','Alejo_Córdoba_ale','Alenka_Gallardo_ale','Amarena_Molina_ama','Ambrosio_Vidal_amb')


--------------- procedures -------------------
USE [GD1C2015]
GO
/****** Object:  StoredProcedure [datiados].[listado1]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[listado1]
@anio int,
@trimestre varchar(150)

as



declare @MesDesde int 
declare @MesHasta int 

select @MesDesde = MDeste , @MesHasta = MHasta
from datiados.Trimestre
where trimestre = @trimestre



select top 5 * 
from datiados.historialDeudores
where YEAR(fecha) = @anio
and MONTH(fecha) between @MesDesde and @MesHasta
GO
/****** Object:  StoredProcedure [datiados].[auditarLoguin]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[auditarLoguin]  
@usuario varchar(255),  
@descripcion varchar(100)  
  
as  

declare @fecha datetime

set @fecha = GETDATE()
  
  
insert into datiados.loguinAuditoria values (@usuario,@fecha,@descripcion)
GO
/****** Object:  StoredProcedure [datiados].[cliente_modificar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[cliente_modificar]
@ClienteID int ,
@nombre		varchar(255),
@apellido	varchar(255),
@mail		varchar(255),
@localidad	varchar(255),
@calle		varchar(255),
@altura		varchar(255),
@dto		varchar(10),
@piso		numeric(3,0),
@fechaNac	datetime,
@codTipoDoc numeric(18,0),
@codPais	numeric(18,0),
@nroDoc		numeric(18,0),
@habilitado bit 

as


update datiados.Clientes set nombre = @nombre,apellido=@apellido,
						 mail=@mail,dir_calle=@calle,dir_altura=@altura,
						 dir_dpto=@dto,dir_piso=@piso,fecha_nac=@fechaNac,
						 cod_tipo_doc=@codTipoDoc,cod_pais=@codPais,nro_doc=@nroDoc,localidad=@localidad,habilitado = @habilitado
where id=@ClienteID
GO
/****** Object:  StoredProcedure [datiados].[cliente_eliminar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[cliente_eliminar]
@clienteID int 

as

update  datiados.Clientes set habilitado=0 where id = @clienteID
GO
/****** Object:  StoredProcedure [datiados].[cliente_buscar_ID]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[cliente_buscar_ID]
@clienteID int

as


select nombre,apellido,cod_tipo_doc codtipodoc,cod_pais codpais, nro_doc nrodoc,
		mail,dir_altura altura, dir_calle calle, dir_dpto dto, dir_piso piso,fecha_nac fechanacimiento,localidad,habilitado
		
from Clientes 
where id = @clienteID
GO
/****** Object:  StoredProcedure [datiados].[cliente_buscar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[cliente_buscar]
@nombre varchar(255),
@apellido varchar(255),
@mail varchar(255),
@codtipodoc numeric(18,0),
@nrodoc numeric(18,0)

as


select c.ID,nombre,c.apellido,c.mail,td.descripcion,c.nro_doc
from datiados.clientes c
inner join datiados.tipodoc td on c.cod_tipo_doc=td.cod_doc
where (c.nro_doc = @nrodoc or @nrodoc is null)
and (nombre  like  @nombre+'%' or @nombre ='')
and ( apellido like @apellido+'%' or @apellido='' )
and (mail like '%'+@mail+'%' or @mail ='')
and (c.cod_tipo_doc = @codtipodoc or @codtipodoc is null)
GO
/****** Object:  StoredProcedure [datiados].[cliente_agregar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[cliente_agregar]
@nombre		varchar(255),
@apellido	varchar(255),
@mail		varchar(255),
@localidad	varchar(255),
@calle		varchar(255),
@altura		varchar(255),
@dto		varchar(10),
@piso		numeric(3,0),
@fechaNac	datetime,
@codTipoDoc numeric(18,0),
@codPais	numeric(18,0),
@nroDoc		numeric(18,0)

as


insert into datiados.Clientes	values (@nroDoc,
										@codTipoDoc,
										@codPais,
										@nombre,
										@apellido,
										@calle,
										@altura,
										@piso,
										@dto,
										@mail,
										@fechaNac,
										@localidad,
										1									
																				
										)
GO
/****** Object:  StoredProcedure [datiados].[FuncionalidadesDelRol_buscar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[FuncionalidadesDelRol_buscar]
@RolID int 
as


select descripcion funcionalidad from datiados.funcionalidades  f
inner join datiados.Roles_Funcionalidades rf on rf.id_func=f.id_func
inner join datiados.roles r on r.id_rol=rf.id_rol
where rf.id_rol = @RolID
GO
/****** Object:  StoredProcedure [datiados].[funcionalidades_buscar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[funcionalidades_buscar]
@id_rol int

as


select f.id_func,f.descripcion
from  datiados.Funcionalidades f
inner join datiados.Roles_Funcionalidades rf on f.id_func = rf.id_func
where id_rol = @id_rol


select f.id_func,f.descripcion
from datiados.Funcionalidades f
where f.id_func not in (select fu.id_func  from datiados.Funcionalidades fu
							inner join datiados.Roles_Funcionalidades rf on fu.id_func = rf.id_func
							where id_rol = @id_rol)
GO
/****** Object:  StoredProcedure [datiados].[Tarjetas_buscar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[Tarjetas_buscar]
@clienteID int

as 



select t.id_tarjeta ID ,right(replicate('*',16) + right(t.numero,4),16) Numero, et.descripcion Emisor, t.fecha_venc FechaVencimiento
from datiados.tarjetas  t 
inner join datiados.tarjetas_cliente tc on tc.id_tarjeta = t.id_tarjeta
inner join datiados.emisoresTarjetas et  on et.codemisor = t.codemisor
where tc.id_cliente = @clienteID
GO
/****** Object:  StoredProcedure [datiados].[Usuario_modif]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[Usuario_modif]
@username varchar(255),
@pass varchar(255),
@pregunta varchar(255),
@resp varchar(255),
@clienteID int,
@fechaModif datetime,
@estado bit
as 




update datiados.Usuarios set username = @username,pwd = @pass,estado = @estado,fecha_ult_modif=@fechaModif,preg_secr= @pregunta, rta_secr=@resp,clienteID = @clienteID
where username = @username
GO
/****** Object:  StoredProcedure [datiados].[Usuario_baja]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[Usuario_baja]
@username varchar(255)


as 

update datiados.Usuarios set estado = 0 where username = @username
GO
/****** Object:  StoredProcedure [datiados].[Usuario_agregar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[Usuario_agregar]
@username varchar(255),
@pass varchar(255),
@pregunta varchar(255),
@resp varchar(255),
@clienteID int,
@fechaCreacion datetime,
@fechaModif datetime
as 




insert into datiados.Usuarios 
values (@username,@pass,1,@fechaCreacion,@fechaModif,@pregunta,@resp,0,@clienteID);
GO
/****** Object:  StoredProcedure [datiados].[proximoNroCta]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[proximoNroCta]
as


declare @proximoNro numeric(16,0)

select  @proximoNro = cast(max(nro_cuenta)as numeric(16,0))
from datiados.cuentas 


set @proximoNro+=1

select ProximoNro = convert(varchar(16),@proximoNro)
GO
/****** Object:  StoredProcedure [datiados].[incrementarIntentosFallidos]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[incrementarIntentosFallidos]
@usuario varchar(100)
as

declare @intentos int

select @intentos = cant_intentos_fallidos from datiados.Usuarios where username=@usuario

if @intentos = 2
	update datiados.Usuarios  set cant_intentos_fallidos+=1,estado=0 where username = @usuario
else
	update datiados.Usuarios  set cant_intentos_fallidos+=1 where username = @usuario
GO
/****** Object:  StoredProcedure [datiados].[tarjeta_desAsociar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[tarjeta_desAsociar]
@numeroTarj varchar(16),
@emisor int ,
@clienteID int

as 

declare @tarjetaID int
 
 
 select @tarjetaID = t.id_tarjeta 
		 	from datiados.Tarjetas t 
		 	inner join datiados.Tarjetas_Cliente tc on t.id_tarjeta = tc.id_tarjeta
		     where t.numero = @numeroTarj and t.codEmisor=@emisor and tc.id_cliente = @clienteID
 

if @tarjetaID is not null
begin

	delete from datiados.Tarjetas_Cliente where id_cliente = @clienteID and id_tarjeta = @tarjetaID
end
GO
/****** Object:  StoredProcedure [datiados].[tarjeta_asociar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[tarjeta_asociar]
@numeroTarj varchar(16),
@emisor int ,
@codSeg varchar(3),
@fechaEmi datetime,
@fechaVenc datetime,
@clienteID int

as

declare @id_tarjeta int

if not exists (select numero from datiados.Tarjetas where numero = @numeroTarj and codEmisor =@emisor)
begin
	insert into datiados.Tarjetas
	values (@numeroTarj,@fechaEmi,@fechaVenc,@codSeg,@emisor)
	
	select  @id_tarjeta = id_tarjeta from datiados.Tarjetas where numero = @numeroTarj and codemisor = @emisor
	
	
	select * from datiados.Tarjetas_Cliente where id_tarjeta = @id_tarjeta and id_cliente  = @clienteID
		 
	insert into datiados.Tarjetas_Cliente 
	values (@id_tarjeta,@clienteID)			
		
	

end
else 
begin 

	select  @id_tarjeta = id_tarjeta from datiados.Tarjetas where numero = @numeroTarj and codemisor = @emisor
	update datiados.Tarjetas set numero = @numeroTarj,fecha_emision= @fechaEmi,fecha_venc=@fechaVenc,cod_seg=@codSeg,codemisor=@emisor
	where id_tarjeta = @id_tarjeta
		
	if not exists (select * from datiados.Tarjetas_Cliente where id_tarjeta = @id_tarjeta and id_cliente  = @clienteID)
	begin 
	
		insert into datiados.Tarjetas_Cliente
		values (@id_tarjeta,@clienteID)
	end
end
GO
/****** Object:  StoredProcedure [datiados].[buscarCuentas]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[buscarCuentas]
@nombre varchar(max),
@apellido varchar(max)

as


select cc.nro_cuenta,c.nombre,c.apellido from datiados.Cuentas cc
inner join datiados.Clientes c  on c.id = cc.cliente_id
where (c.nombre like @nombre+'%' or @nombre ='')
and  (c.apellido like @apellido+'%' or @apellido='')
GO
/****** Object:  StoredProcedure [datiados].[consultaSaldo]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec datiados.consultaSaldo '1111111111111125', '20160606'

CREATE procedure [datiados].[consultaSaldo]
@nroCta varchar(16),
@fechaTope datetime


as


-------------- Saldo ------------
select isnull(SUM(cm.importe * (case when tp.signo = '+' then 1 else -1 end)),0) Saldo
from datiados.cuentaMovimientos  cm 
inner join datiados.tipomovcuentas tp on tp.tipo_mov = cm.tipo_mov 
where cm.nro_cuenta = @nroCta 
and fecha <= @fechaTope



--------------Depositos---------------------------


select top 5 d.codigo CodigoDeposito, d.Fecha, d.Importe,m.descripcion Moneda, t.numero Tarjeta, et.Descripcion Emisor
from datiados.depositos d
inner join datiados.monedas m on m.moneda_id =d.moneda
inner join datiados.tarjetas t on  t.id_tarjeta = d.id_tarjeta
inner join datiados.emisoresTarjetas et on et.codemisor=t.codemisor
where d.Nro_cuenta = @nroCta
and d.fecha <= @fechaTope
order by d.fecha desc




---------------- Retiros----------------------------
select top 5 r.codigo codigoRetiro, r.nro_cuenta Cuenta, r.fecha,r.importe,r.nro_Cheque, b.nombre
 from datiados.retiros r 
inner join datiados.bancos b  on b.codigo = r.cod_banco
where r.nro_cuenta = @nroCta 
and fecha <= @fechaTope
order by fecha desc


----------------Transferencias-----------------
select top 10 id_transf CodigoTransferencia, cta_origen CuentaOrigen, cta_destino CuentaDestino,Importe, Fecha
from datiados.transferencias
where cta_origen = @nroCta
and fecha <= @fechaTope
order by fecha desc
GO
/****** Object:  StoredProcedure [datiados].[Deposito_agregar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[Deposito_agregar]
@nroCta varchar(16),
@importe decimal(18,4),
@moneda int ,
@tarjetaID int,
@Fecha datetime

as


if exists (select * from datiados.cuentas where nro_cuenta = @nroCta and cod_estado <>1)
begin
	raiserror('La Cuenta Debe esta Habilitada Para relizar la transaccion',16,1)
	return
end

declare @proximoCodigo numeric (18,0)

select   @proximoCodigo = max(codigo)+ 1
from datiados.depositos



insert into datiados.depositos
values  (@proximoCodigo,@nroCta,@Fecha,@importe,@moneda,@tarjetaID)


insert into datiados.cuentaMovimientos
values(@nroCta,1,@importe,@Fecha)
GO
/****** Object:  StoredProcedure [datiados].[RolesBuscar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[RolesBuscar]
@username varchar(255)

as 



select id_rol,nombre
 from datiados.Roles
 where estado = 1 
 
 
 
select id_rol 
from datiados.Usuarios_Roles
where usr = @username
GO
/****** Object:  StoredProcedure [datiados].[Retiro_agregar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[Retiro_agregar]
@nroCta varchar(16),
@importe decimal(18,4),
@moneda int ,
@Fecha datetime

as



if exists (select * from datiados.cuentas where nro_cuenta = @nroCta and cod_Estado <>1 )
begin
	declare @strError  varchar(150)
	set  @strError =' Imposible realizar la transaccion. La cuenta no se encuentra habilitada'
	
	raiserror(@strError,16,1)	
	return
end


declare @proxCheque numeric(18,0)
declare @proximoRetiro numeric(18,0)


select @proxCheque =  MAX(numero_cheque) + 1  from datiados.cheques
select @proximoRetiro = MAX(codigo) + 1  from datiados.retiros

insert into datiados.cheques
values (@proxCheque,10002,@importe,@Fecha)

insert into datiados.retiros
values(@proximoRetiro,@nroCta,@Fecha,@importe,@proxCheque,10002)

insert into datiados.cuentaMovimientos
values(@nroCta,4,@importe,@Fecha)
GO
/****** Object:  StoredProcedure [datiados].[loguear]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[loguear] 
@Usuario varchar(100),
@Contraseña Varchar(max)

As


select * from datiados.Usuarios 
IF NOT EXISTS (SELECT * FROM Datiados.USUARIOS u WHERE u.username = @Usuario and u.estado=1)
BEGIN

	
	RAISERROR('USUARIO INEXISTENTE',16,1)
	
	RETURN 
END


IF  NOT EXISTS (SELECT * FROM Datiados.USUARIOS u WHERE u.username = @Usuario AND u.pwd=@Contraseña and u.estado=1)
BEGIN 
	Declare @INTENTOS int
	Declare @MsgError Varchar(100)
	
	select @INTENTOS = cant_intentos_fallidos
	from datiados.Usuarios 
	where username=@Usuario
	
	
	  
	
	exec datiados.auditarLoguin @Usuario,'Acceso Denegado'		
	
	
	set @MsgError = 'CONTRASEÑA INCORRECTA. '
	set  @MsgError = @MsgError +  ltrim(rtrim(str(isnull( 3 - (@INTENTOS + 1 ),-1))))
	set  @MsgError = @MsgError + ' INTENTOS RESTANTES'	
	
	exec datiados.incrementarIntentosFallidos @usuario
	
	RAISERROR( @MsgError ,16,1)
		
	RETURN 
	
END


-- Si no sale por el raiseError limpio los intentos Fallidos 

exec datiados.auditarLoguin @usuario,'Acceso correcto'		

update datiados.usuarios set cant_intentos_fallidos= 0 where username = @Usuario 

if not exists (select * from datiados.Usuarios u inner join datiados.Clientes c on c.id = u.clienteID where c.habilitado = 1 and u.username=@Usuario)
begin 

 RAISERROR( 'No existe Cliente Asociado a su  Usuario. Contactese con su administrador ' ,16,1)

end
GO
/****** Object:  StoredProcedure [datiados].[listado4]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[listado4]
@anio int,
@trimestre varchar(150)

as



declare @MesDesde int 
declare @MesHasta int 

select @MesDesde = MDeste , @MesHasta = MHasta
from datiados.Trimestre
where trimestre = @trimestre




select  top 5 p.descripcion Pais, COUNT(*) Movimientos
from datiados.CuentaMovimientos cm
inner join datiados.Cuentas c on c.nro_cuenta = cm.nro_cuenta
inner join datiados.Paises p on p.codigo = c.cod_pais
where year(cm.fecha)  = @anio
and MONTH(cm.fecha) between @MesDesde and @MesHasta
group by  p.descripcion
order by 2 desc
GO
/****** Object:  StoredProcedure [datiados].[listado3]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[listado3]
@anio int,
@trimestre varchar(150)

as



declare @MesDesde int 
declare @MesHasta int 

select @MesDesde = MDeste , @MesHasta = MHasta
from datiados.Trimestre
where trimestre = @trimestre



select top 5  cli.nombre + ' '+cli.apellido Cliente,COUNT(*)  Cantidad_De_Transferencias
from datiados.Transferencias t 
inner join datiados.Cuentas c on c.nro_cuenta = t.cta_origen
inner join datiados.Cuentas cc on cc.nro_cuenta = t.cta_destino
inner join datiados.Clientes cli on cli.id = c.cliente_id
where c.cliente_id = cc.cliente_id
and YEAR(t.fecha)= @anio
and MONTH(t.fecha) between @MesDesde and @MesHasta
group by cli.nombre + ' '+cli.apellido 
order by 2 desc
GO
/****** Object:  StoredProcedure [datiados].[listado2]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[listado2]
@anio int,
@trimestre varchar(150)

as



declare @MesDesde int 
declare @MesHasta int 

select @MesDesde = MDeste , @MesHasta = MHasta
from datiados.Trimestre
where trimestre = @trimestre


select top 5 c.nombre +' ' +c.apellido Cliente , COUNT(*) Cantidad_De_Comisiones_Cobradas from datiados.Facturas f 
inner join datiados.Items_Facturas i on i.nro_factura = f.numero
inner join datiados.Clientes c on c.id  = f.id_cliente
where i.tipo_concepto = 1 
and YEAR(f.fecha)= @anio 
and MONTH(f.fecha) between @MesDesde and @MesHasta 
group by c.nombre +' ' +c.apellido
order by 2 desc
GO
/****** Object:  StoredProcedure [datiados].[transferencia_agregar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[transferencia_agregar]
@nroCtaO varchar(16),
@nroCtaD varchar(16),
@importe decimal(18,4),
@moneda int ,
@Fecha datetime

as 


if exists (	select 1
			from datiados.cuentas
			where  nro_cuenta = @nroCtaD
			and cod_estado not in (1,2) 
			)
begin 
	raiserror('LA CUENTA DESTINO DEBE ENCONTRARSE HABILITADA O INHABILITADA',16,1)
	return
end 



insert into datiados.Transferencias
values (@nroCtaO,@nroCtaD,@importe,@Fecha)



declare @clienteIDCtaOrigen int 

select @clienteIDCtaOrigen=  cliente_id from datiados.Cuentas 
where nro_cuenta = @nroCtaO


if not exists (select 1 from datiados.Cuentas where @nroCtaD = nro_cuenta and  cliente_id  = @clienteIDCtaOrigen)

begin
-- Prepararo para facturar --


declare @id_transf int
set  @id_transf = (select top 1 id_transf from datiados.Transferencias order by id_transf desc )


insert into datiados.CtaCte
select c.cliente_id,cc.costo,@Fecha,1,c.nro_cuenta,0,@id_transf
from datiados.cuentas c 
inner join datiados.CuentaCategorias cc on cc.id_categoria = c.categoria
where  c.nro_cuenta = @nroCtaO
and cc.costo >0

end 

--- Actualizo movimientos de cuentas ---


insert into datiados.CuentaMovimientos
values (@nroCtaO,3,@importe,@Fecha)

insert into datiados.CuentaMovimientos
values (@nroCtaD,2,@importe,@Fecha)
GO
/****** Object:  StoredProcedure [datiados].[listado5]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[listado5]
@anio int,
@trimestre varchar(150)

as



declare @MesDesde int 
declare @MesHasta int 

select @MesDesde = MDeste , @MesHasta = MHasta
from datiados.Trimestre
where trimestre = @trimestre



select cc.descripcion  TipoCuenta,sum(i.importe) TotalFacturado from datiados.Facturas f 
inner join datiados.Items_Facturas i on i.nro_factura = f.numero
inner join datiados.Cuentas c on c.nro_cuenta = i.nro_cuenta
inner join datiados.CuentaCategorias cc on cc.id_categoria = c.categoria
where YEAR(f.fecha) = @anio
and MONTH(f.fecha) between @MesDesde and @MesHasta
group by cc.descripcion
GO
/****** Object:  StoredProcedure [datiados].[gestionarCuentas]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[gestionarCuentas]
@fecha datetime
as



if  not exists (select * from datiados.gestionCuentas where left(convert(varchar,fechaUltimaGestion,121),10) = left(convert(varchar,@fecha,121),10) )
begin 

begin tran t1

-- grabo en ctaCorriente



insert into datiados.ctacte
select c.cliente_id,cc.costo,@fecha,2,c.nro_cuenta,0,null
 from datiados.cuentas c
 inner join datiados.cuentaCategorias cc on cc.id_categoria= c.categoria
 where ISNULL(diasRestantes,0) <>0
 

--- resto 1 dia a todas las cuentas con dias vigentes

update datiados.cuentas set diasRestantes -=1 where isnull(diasRestantes,0)<>0

-- las cuentas que se quedan sin dias las cambio a pendiente de activacion

update  datiados.cuentas set cod_estado = 3 where DiasRestantes = 0


---- registro deudores que se les inhabilita la cuenta

insert into datiados.historialDeudores
select NroCta,ClienteID,@fecha
from datiados.CtaCte 
where Saldada = 0 
group by NroCta,ClienteID
having COUNT(*) > =5



-- inabilito las cuentas de los deudores

update c set cod_estado = 2
from datiados.Cuentas c 
inner join (select NroCta
			from datiados.CtaCte 
			where Saldada = 0 
			group by NroCta
			having COUNT(*) > =5) X on X.NroCta = c.nro_cuenta




insert into gestionCuentas
values (@fecha)



if @@ERROR <> 0
begin 
	rollback tran t1
end
else 
begin
commit tran t1
end 



end
GO
/****** Object:  StoredProcedure [datiados].[facturar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[facturar]
@clienteID int,
@fecha datetime
as 


if not exists (select 1
			from datiados.CtaCte
			where ClienteID = @clienteID
			and Saldada = 0 )
begin 

	raiserror('No hay cargos por facturar',16,1)
	return
end 

declare @proxNumeroFact numeric(18,0)
select @proxNumeroFact = MAX(numero) + 1 from datiados.Facturas


create table #tempItems
(
id_item int identity (1,1),
nro_factura numeric(18,0) ,
tipo_concepto int,
importe decimal(18,2),
nro_cuenta varchar(16),
id_transf int 
)


insert into #tempItems
select @proxNumeroFact,tipoConcepto,importe,NroCta,id_transf
from datiados.CtaCte
where ClienteID = @clienteID
and Saldada = 0 


declare @totalFact numeric(18,2)
select @totalFact = SUM(importe) from #tempItems

insert into datiados.Facturas 
values (@proxNumeroFact,@fecha,@clienteID,@totalFact)

insert into datiados.Items_Facturas
select * from #tempItems order by id_item


update datiados.CtaCte  set Saldada = 1 
where ClienteID = @clienteID


update c set c.cod_estado  = case when c.cod_estado  in (2,3) then 1 else c.cod_estado end
from datiados.Cuentas c
inner join datiados.CtaCte cc on cc.nrocta = c.nro_cuenta
where  cc.clienteID = @clienteID
and  cc.Saldada = 1 




drop table #tempItems
GO
/****** Object:  StoredProcedure [datiados].[cuenta_modif]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[cuenta_modif]
@NroCta varchar(16),
@Categoria int ,
@EstadoCuenta int ,
@pais int,
@moneda int,
@fecha datetime 


as

declare @cateAnterior int
declare @diasRestantes int



select @cateAnterior = categoria,@diasRestantes = diasRestantes
from datiados.cuentas
where nro_cuenta=@NroCta





set @diasRestantes = case when @cateAnterior <> @Categoria  and @Categoria = 1 then null		
						  when 	@cateAnterior<>@Categoria and @Categoria <> 1 then 30
						  else @diasRestantes end


---si modifico la categoria agrego el cargo a la ctacte

if ISNULL(@diasRestantes,0) = 30 
begin
declare @clienteID int
set @clienteID = (select cliente_id  from datiados.Cuentas where nro_cuenta = @NroCta)


insert into datiados.CtaCte
select @clienteID,costo,@fecha,2,@NroCta,0,null
from datiados.CuentaCategorias
where id_categoria =@Categoria

update datiados.cuentas set cod_estado =3,cod_pais = @pais,categoria = @categoria,cod_moneda = @moneda,diasRestantes = @diasRestantes where nro_cuenta  = @NroCta
return

end 

update datiados.cuentas set cod_estado =@estadoCuenta,cod_pais = @pais,categoria = @categoria,cod_moneda = @moneda,diasRestantes = @diasRestantes where nro_cuenta  = @NroCta
GO
/****** Object:  StoredProcedure [datiados].[Cuenta_agregar]    Script Date: 07/06/2015 22:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[Cuenta_agregar]
@NroCta varchar(16),
@Categoria int ,
@pais int,
@moneda int,
@fechaCreac Datetime ,
@ClienteID int


as



insert into datiados.cuentas 
values (@NroCta,@clienteID,3,@pais,@fechaCreac,null,@categoria,@moneda,null)


if @Categoria <>1
begin
insert into datiados.CtaCte 
select @ClienteID,c.costo,@fechaCreac,2,@NroCta,0,null
from datiados.CuentaCategorias c
end
GO
