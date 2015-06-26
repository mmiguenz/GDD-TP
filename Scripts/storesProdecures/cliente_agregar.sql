USE [GD1C2015]
GO
/****** Object:  StoredProcedure [datiados].[cliente_agregar]    Script Date: 06/26/2015 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [datiados].[cliente_agregar]
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
										@fechaNac									
																				
										)
		



