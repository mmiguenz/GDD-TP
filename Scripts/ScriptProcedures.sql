USE [GD1C2015]
GO
/****** Object:  StoredProcedure [datiados].[auditarLoguin]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[auditarLoguin]  
@usuario varchar(255),  
@descripcion varchar(100)  
  
as  

declare @fecha datetime

set @fecha = GETDATE()
  
  
insert into datiados.loguinAuditoria values (@usuario,@fecha,@descripcion)
GO
/****** Object:  StoredProcedure [datiados].[cliente_modificar]    Script Date: 07/01/2015 20:25:56 ******/
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
/****** Object:  StoredProcedure [datiados].[cliente_eliminar]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [datiados].[cliente_eliminar]
@clienteID int 

as

update  datiados.Clientes set habilitado=0 where id = @clienteID
GO
/****** Object:  StoredProcedure [datiados].[cliente_buscar_ID]    Script Date: 07/01/2015 20:25:56 ******/
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
/****** Object:  StoredProcedure [datiados].[cliente_buscar]    Script Date: 07/01/2015 20:25:56 ******/
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
/****** Object:  StoredProcedure [datiados].[cliente_agregar]    Script Date: 07/01/2015 20:25:56 ******/
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
/****** Object:  StoredProcedure [datiados].[FuncionalidadesDelRol_buscar]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [datiados].[FuncionalidadesDelRol_buscar]
@RolID int 
as


select descripcion funcionalidad from datiados.funcionalidades  f
inner join datiados.Roles_Funcionalidades rf on rf.id_func=f.id_func
inner join datiados.roles r on r.id_rol=rf.id_rol
where rf.id_rol = @RolID
GO
/****** Object:  StoredProcedure [datiados].[funcionalidades_buscar]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[funcionalidades_buscar]
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
/****** Object:  StoredProcedure [datiados].[Usuario_modif]    Script Date: 07/01/2015 20:25:56 ******/
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
/****** Object:  StoredProcedure [datiados].[Usuario_baja]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[Usuario_baja]
@username varchar(255)


as 

update datiados.Usuarios set estado = 0 where username = @username
GO
/****** Object:  StoredProcedure [datiados].[Usuario_agregar]    Script Date: 07/01/2015 20:25:56 ******/
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
/****** Object:  StoredProcedure [datiados].[incrementarIntentosFallidos]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[incrementarIntentosFallidos]
@usuario varchar(100)
as

declare @intentos int

select @intentos = cant_intentos_fallidos from datiados.Usuarios where username=@usuario

if @intentos = 2
	update datiados.Usuarios  set cant_intentos_fallidos+=1,estado=0 where username = @usuario
else
	update datiados.Usuarios  set cant_intentos_fallidos+=1 where username = @usuario
GO
/****** Object:  StoredProcedure [datiados].[RolesBuscar]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [datiados].[RolesBuscar]
@username varchar(255)

as 



select id_rol,nombre
 from datiados.Roles
 where estado = 1 
 
 
 
select id_rol 
from datiados.Usuarios_Roles
where usr = @username
GO
/****** Object:  StoredProcedure [datiados].[loguear]    Script Date: 07/01/2015 20:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [datiados].[loguear] 
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
