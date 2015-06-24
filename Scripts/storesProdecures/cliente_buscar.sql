
alter procedure datiados.cliente_buscar
@nombre varchar(255),
@apellido varchar(255),
@mail varchar(255),
@codtipodoc numeric(18,0),
@nrodoc numeric(18,0)

as


select c.ID,nombre,c.apellido,c.mail,td.descripcion,c.nro_doc
from datiados.clientes c
inner join datiados.tipodoc td on c.cod_tipo_doc=td.cod_doc
where nombre  like '%'+@nombre or @nombre is null
and ( apellido like '%'+@apellido or @apellido is null)
and (mail like  '%'+@mail+'%' or @mail is null)
and (c.cod_tipo_doc = @codtipodoc or @codtipodoc is null)
and (c.nro_doc = @nrodoc or @nrodoc is null)