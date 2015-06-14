--Migro Tabla Paises
insert into paises 
select distinct  cuenta_pais_codigo,cuenta_pais_desc
from migracion
union 
select  distinct cli_pais_codigo,cli_pais_desc
from migracion
order by Cuenta_Pais_Codigo

-- Migro Tipo Doc
insert into TipoDoc
select distinct cli_tipo_doc_cod,cli_tipo_doc_desc
from migracion
order by 1


--Migro Clientes

insert into clientes
select distinct Cli_Nro_Doc,Cli_Tipo_Doc_Cod,cli_pais_codigo,
 Cli_Nombre,
 Cli_Apellido,
Cli_Dom_Calle,
Cli_Dom_Nro,
Cli_Dom_Piso,
Cli_Dom_Depto,
Cli_Fecha_Nac,
Cli_Mail
from migracion


-- Migro bancos
insert into bancos
select distinct banco_cogido,banco_nombre,banco_direccion
from migracion
where banco_cogido is not null
order by 1 

-- Migro Tabla Tarjetas
insert into tarjetas
select distinct tarjeta_numero,tarjeta_fecha_emision,tarjeta_fecha_vencimiento,tarjeta_codigo_seg,tarjeta_emisor_descripcion
from migracion
where tarjeta_numero is not null
order by 1 



-- Migro Cheques 

insert into cheques
select distinct cheque_numero,banco_cogido,cheque_importe,cheque_fecha
from migracion
where Cheque_Numero is not null


insert into monedas values (1,'Dolar',1)


-- Migro cuentas 

insert into cuentas 
select distinct cuenta_numero,cuenta_estado,cuenta_pais_codigo,cuenta_fecha_creacion,cuenta_fecha_cierre,1,cli_nro_doc,cli_tipo_doc_cod,null
from migracion
order by 1


-- Migro Depositos

insert into depositos
select  deposito_codigo,deposito_fecha,cuenta_numero,deposito_importe,1,tarjeta_numero
from migracion
where deposito_codigo is not null
order by 1 



-- Migro Retiros 
insert into retiros 
select  retiro_codigo,retiro_importe,Cheque_numero,banco_cogido,cli_nro_doc,cli_tipo_doc_cod,Cuenta_Numero
from migracion
where retiro_codigo is not null
order by  1 


--Migro Tabla Transferencias

insert into Transferencias (NroCtaOrigen,NroCtaDestino,Importe,Fecha)
select cuenta_numero,cuenta_dest_numero,trans_importe,transf_fecha
from migracion
where transf_fecha is not null
order by 1


-- Cargo tabla Tarjetas Por Cliente
 insert into tarjetasXCliente
select distinct tarjeta_numero,cli_nro_doc,cli_tipo_doc_cod
from migracion
where tarjeta_numero is not null


--Lleno Table TipoMovCtas

insert into TipoMovCtas values(1,'IngXDeposito','+')
insert into TipoMovCtas values(2,'IngXTransf','+')
insert into TipoMovCtas values(3,'EgrXTransf','-')
insert into TipoMovCtas values(4,'EgrXRetiro','-')




--Lleno tabla Movimientos de cuentas

insert into MovCtas (NroCuenta,CodTipoMovCta,Importe,Fecha)
select nroCuenta,1,importe,fechaDeposito
from depositos

union 

select nroCuenta,4,r.importe,Fecha
from retiros r 
inner join cheques c on c.nrocheque = r.nrocheque

union

select NroCtaOrigen,3,importe,fecha from transferencias

union 

select NroCtaDestino,2,importe,fecha from transferencias 





