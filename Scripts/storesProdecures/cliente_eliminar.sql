USE [GD1C2015]
GO
/****** Object:  StoredProcedure [datiados].[cliente_eliminar]    Script Date: 06/26/2015 18:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [datiados].[cliente_eliminar]
@clienteID int 

as

delete from datiados.Clientes where id = @clienteID