USE [GD1C2015]
GO
/****** Object:  StoredProcedure [datiados].[cliente_buscar]    Script Date: 06/26/2015 18:27:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [datiados].[cliente_buscar]
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



--exec datiados.cliente_buscar @nombre=N'',@apellido=N'',@mail=N'',@codTipoDoc=NULL,@nroDoc=2723120