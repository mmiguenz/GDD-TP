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
