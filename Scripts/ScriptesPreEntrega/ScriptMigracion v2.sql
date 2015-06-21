/*Migración Tabla Bancos*/
INSERT INTO datiados.Bancos
SELECT DISTINCT Banco_Cogido,Banco_Nombre,Banco_Direccion
FROM gd_esquema.Maestra
WHERE Banco_Cogido is not NULL
ORDER BY Banco_Cogido

/*Migración Tabla Cheques*/
INSERT INTO datiados.Cheques
SELECT DISTINCT Cheque_Numero,Banco_Cogido,Cheque_Importe,Cheque_Fecha
FROM gd_esquema.Maestra
WHERE Cheque_Numero is not NULL

/* Migración Tabla Países*/
INSERT INTO datiados.Paises
SELECT DISTINCT  Cuenta_Pais_Codigo,Cuenta_Pais_Desc
FROM gd_esquema.Maestra
UNION 
SELECT DISTINCT Cli_Pais_Codigo,Cli_Pais_Desc
FROM gd_esquema.Maestra
ORDER BY 1

/*Migración Tabla Tipo Doc*/
INSERT INTO datiados.TipoDoc
SELECT DISTINCT Cli_Tipo_Doc_Cod,Cli_Tipo_Doc_Desc
FROM gd_esquema.Maestra
ORDER BY Cli_Tipo_Doc_Cod

/*Migración Tabla Clientes*/
INSERT INTO datiados.Clientes (nro_doc,cod_tipo_doc,cod_pais,nombre,apellido,dir_calle,dir_altura,dir_piso,dir_dpto,mail,fecha_nac)
SELECT DISTINCT Cli_Nro_Doc,Cli_Tipo_Doc_Cod,cli_pais_codigo,Cli_Nombre,Cli_Apellido,Cli_Dom_Calle,Cli_Dom_Nro,Cli_Dom_Piso,Cli_Dom_Depto,Cli_Fecha_Nac,Cli_Mail
FROM gd_esquema.Maestra

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
INSERT INTO datiados.Monedas values (1,'Dolar',1)

/*Migración Tabla Tarjetas*/
INSERT INTO datiados.Tarjetas
SELECT DISTINCT Tarjeta_Numero,Tarjeta_Fecha_Emision,Tarjeta_Fecha_Vencimiento,Tarjeta_Codigo_Seg,Tarjeta_Emisor_Descripcion
FROM gd_esquema.Maestra
WHERE Tarjeta_Numero is NOT NULL
ORDER BY Tarjeta_Numero

/*Migración Tabla Facturas*/
INSERT INTO datiados.Facturas (numero,fecha,id_cliente)
SELECT m.Factura_Numero,m.Factura_Fecha,c.id
FROM gd_esquema.Maestra m inner join datiados.Clientes c
ON (m.Cli_Nro_Doc = c.nro_doc) AND (m.Cli_Tipo_Doc_Cod = c.cod_tipo_doc)
WHERE m.Factura_Numero is NOT NULL

INSERT INTO datiados.Facturas(abonada) values(0)

/*Cargo Tabla TipoMovCuentas*/
INSERT INTO datiados.TipoMovCuentas values(1,'IngXDeposito','+')
INSERT INTO datiados.TipoMovCuentas values(2,'IngXTransf','+')
INSERT INTO datiados.TipoMovCuentas values(3,'EgrXTransf','-')
INSERT INTO datiados.TipoMovCuentas values(4,'EgrXRetiro','-')

/*Migración Tabla Cuentas*/
INSERT INTO datiados.Cuentas (nro_cuenta,fecha_creacion,fecha_cierre,cod_pais)
SELECT DISTINCT Cuenta_Numero,Cuenta_Fecha_Creacion,Cuenta_Fecha_Cierre,Cuenta_Pais_Codigo
FROM gd_esquema.Maestra
INSERT INTO datiados.Cuentas(cod_estado,categoria,cod_moneda) values('Habilitada','Gratuita',1)

/*Migración Tabla Depósitos*/
INSERT INTO datiados.Depositos
SELECT  Deposito_Codigo,Cuenta_Numero,Deposito_fecha,Deposito_Importe,1,tarjeta_numero
from gd_esquema.Maestra
where deposito_codigo is NOT NULL
order by Deposito_Codigo

/*Migración Tabla Retiros*/
INSERT INTO datiados.Retiros 
SELECT  m.Retiro_Codigo,Cuenta_Numero,Retiro_Fecha,Retiro_Importe,Cheque_Numero,Banco_Cogido
from gd_esquema.Maestra
where Retiro_Codigo is NOT NULL
order by  Retiro_Codigo 

/*Migración Tabla Transferencias*/
INSERT INTO datiados.Transferencias (cta_origen,cta_destino,importe,fecha,costo)
SELECT Cuenta_Numero,Cuenta_Dest_Numero,Trans_Importe,Transf_Fecha,Trans_Costo_Trans
FROM gd_esquema.Maestra
WHERE Transf_Fecha is NOT NULL

/*Migración Tabla Tarjetas_Cliente*/

INSERT INTO datiados.Tarjetas_Cliente(nro_tarjeta,id_cliente)
SELECT DISTINCT m.Tarjeta_Numero,c.id
FROM gd_esquema.Maestra m inner join datiados.Clientes c
ON (m.Cli_Nro_Doc = c.nro_doc) AND (m.Cli_Tipo_Doc_Cod = c.cod_tipo_doc)
WHERE m.Tarjeta_Numero is NOT NULL

/*Migración Tabla ItemConceptoTipos*/
INSERT INTO datiados.ItemConceptoTipos(descripcion,costo) values ('Apertura de Cuenta',5.00)
INSERT INTO datiados.ItemConceptoTipos(descripcion,porc_import_transf) values ('Comision por Transferencia',0.10)
INSERT INTO datiados.ItemConceptoTipos(descripcion,costo) values ('Modificacion Tipo de Cuenta',2.00)

/*Migración Tabla Items_Facturas*/
INSERT INTO datiados.Items_Facturas(nro_factura,descripcion,importe,nro_cuenta)
SELECT Factura_Numero,Item_Factura_Descr,Item_Factura_Importe,Cuenta_Numero
FROM gd_esquema.Maestra
WHERE Factura_Numero is NOT NULL

INSERT INTO datiados.Items_Facturas(tipo_concepto)
SELECT id_tipo
FROM datiados.ItemConceptoTipos
WHERE descripcion = 'Comision por Transferencia'

/*Migración Tabla Movimientos de cuentas*/

