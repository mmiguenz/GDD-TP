USE [GD1C2015]
GO
/****** Object:  StoredProcedure [datiados].[loguear]    Script Date: 06/20/2015 22:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER Procedure [datiados].[loguear] 
@Usuario varchar(100),
@Contraseña Varchar(max)

As



IF NOT EXISTS (SELECT * FROM Datiados.USUARIOS u WHERE u.username = @Usuario)
BEGIN
	
	RAISERROR('USUARIO INEXISTENTE',16,1)
	
	RETURN 
END


IF  NOT EXISTS (SELECT * FROM Datiados.USUARIOS u WHERE u.username = @Usuario AND u.pwd=@Contraseña)
BEGIN 
	Declare @INTENTOS int
	Declare @MsgError Varchar(100)
	select @INTENTOS = cant_intentos_fallidos
	from datiados.Usuarios
	
	select @INTENTOS = cant_intentos_fallidos
	from datiados.Usuarios
	
	
	  
	
	
	set @MsgError = 'CONTRASEÑA INCORRECTA. '
	set  @MsgError = @MsgError +  ltrim(rtrim(str(isnull( 3 - (@INTENTOS + 1 ),-1))))
	set  @MsgError = @MsgError + ' INTENTOS RESTANTES'	
	
	
	
	RAISERROR( @MsgError ,16,1)
		
	RETURN 
	
END


-- Si no sale por el raiseError limpio los intentos Fallidos 
update datiados.usuarios set cant_intentos_fallidos= 0 where username = @Usuario 





