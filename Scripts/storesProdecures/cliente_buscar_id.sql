USE [GD1C2015]
GO
/****** Object:  StoredProcedure [datiados].[cliente_buscar_ID]    Script Date: 06/26/2015 18:27:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [datiados].[cliente_buscar_ID]
@clienteID int

as


select nombre,apellido,cod_tipo_doc codtipodoc,cod_pais codpais, nro_doc nrodoc,
		mail,dir_altura altura, dir_calle calle, dir_dpto dto, dir_piso piso,fecha_nac fechanacimiento
		
from Clientes 
where id = @clienteID





