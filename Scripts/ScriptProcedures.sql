USE []
GO
/****** Object:  Table [datiados].[Paises]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Paises](
	[codigo] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Monedas]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Monedas](
	[moneda_id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[cotizacion] [decimal](18, 4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[moneda_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[maestra]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[maestra](
	[Cli_Pais_Codigo] [numeric](18, 0) NULL,
	[Cli_Pais_Desc] [varchar](250) NULL,
	[Cli_Nombre] [varchar](255) NULL,
	[Cli_Apellido] [varchar](255) NULL,
	[Cli_Tipo_Doc_Cod] [numeric](18, 0) NULL,
	[Cli_Nro_Doc] [numeric](18, 0) NULL,
	[Cli_Tipo_Doc_Desc] [varchar](255) NULL,
	[Cli_Dom_Calle] [varchar](255) NULL,
	[Cli_Dom_Nro] [numeric](18, 0) NULL,
	[Cli_Dom_Piso] [numeric](18, 0) NULL,
	[Cli_Dom_Depto] [varchar](10) NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [varchar](255) NULL,
	[Cuenta_Numero] [numeric](18, 0) NULL,
	[Cuenta_Fecha_Creacion] [datetime] NULL,
	[Cuenta_Estado] [varchar](255) NULL,
	[Cuenta_Pais_Codigo] [numeric](18, 0) NULL,
	[Cuenta_Pais_Desc] [varchar](250) NULL,
	[Cuenta_Fecha_Cierre] [datetime] NULL,
	[Deposito_Codigo] [numeric](18, 0) NULL,
	[Deposito_Fecha] [datetime] NULL,
	[Deposito_Importe] [numeric](18, 2) NULL,
	[Tarjeta_Numero] [varchar](16) NULL,
	[Tarjeta_Fecha_Emision] [datetime] NULL,
	[Tarjeta_Fecha_Vencimiento] [datetime] NULL,
	[Tarjeta_Codigo_Seg] [varchar](3) NULL,
	[Tarjeta_Emisor_Descripcion] [varchar](255) NULL,
	[Cuenta_Dest_Numero] [numeric](18, 0) NULL,
	[Cuenta_Dest_Fecha_Creacion] [datetime] NULL,
	[Cuenta_Dest_Estado] [varchar](255) NULL,
	[Cuenta_Dest_Pais_Codigo] [numeric](18, 0) NULL,
	[Cuenta_Dest_Pais_Desc] [varchar](250) NULL,
	[Cuenta_Dest_Fecha_Cierre] [datetime] NULL,
	[Transf_Fecha] [datetime] NULL,
	[Trans_Importe] [numeric](18, 2) NULL,
	[Trans_Costo_Trans] [numeric](18, 2) NULL,
	[Retiro_Fecha] [datetime] NULL,
	[Retiro_Codigo] [numeric](18, 0) NULL,
	[Retiro_Importe] [numeric](18, 2) NULL,
	[Cheque_Numero] [numeric](18, 0) NULL,
	[Cheque_Fecha] [datetime] NULL,
	[Cheque_Importe] [numeric](18, 2) NULL,
	[Banco_Cogido] [numeric](18, 0) NULL,
	[Banco_Nombre] [varchar](255) NULL,
	[Banco_Direccion] [varchar](255) NULL,
	[Item_Factura_Descr] [varchar](255) NULL,
	[Item_Factura_Importe] [numeric](18, 2) NULL,
	[Factura_Numero] [numeric](18, 0) NULL,
	[Factura_Fecha] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[loguinAuditoria]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[loguinAuditoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](150) NULL,
	[fechayHora] [datetime] NULL,
	[descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Bancos]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Bancos](
	[codigo] [numeric](18, 0) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[direccion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[emisoresTarjetas]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[emisoresTarjetas](
	[codEmisor] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[codEmisor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[ItemConceptoTipos]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[ItemConceptoTipos](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Funcionalidades]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Funcionalidades](
	[id_func] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_func] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[CuentaEstados]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[CuentaEstados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[CuentaCategorias]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[CuentaCategorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[costo] [decimal](18, 4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[TipoMovCuentas]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[TipoMovCuentas](
	[tipo_mov] [numeric](2, 0) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[signo] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tipo_mov] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[TipoDoc]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[TipoDoc](
	[cod_doc] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_doc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Roles]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Tarjetas]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Tarjetas](
	[id_tarjeta] [int] IDENTITY(1,1) NOT NULL,
	[numero] [varchar](16) NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[fecha_venc] [date] NOT NULL,
	[cod_seg] [varchar](3) NOT NULL,
	[codEmisor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tarjeta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Roles_Funcionalidades]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Roles_Funcionalidades](
	[id_rol] [int] NULL,
	[id_func] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Clientes]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nro_doc] [numeric](18, 0) NULL,
	[cod_tipo_doc] [numeric](18, 0) NULL,
	[cod_pais] [numeric](18, 0) NULL,
	[nombre] [varchar](255) NOT NULL,
	[apellido] [varchar](255) NOT NULL,
	[dir_calle] [varchar](255) NOT NULL,
	[dir_altura] [numeric](18, 0) NOT NULL,
	[dir_piso] [numeric](3, 0) NULL,
	[dir_dpto] [varchar](10) NULL,
	[mail] [varchar](255) NOT NULL,
	[fecha_nac] [datetime] NOT NULL,
	[localidad] [varchar](100) NULL,
	[habilitado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[mail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nro_doc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Cheques]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Cheques](
	[numero_cheque] [numeric](18, 0) NOT NULL,
	[cod_banco] [numeric](18, 0) NOT NULL,
	[importe] [decimal](18, 4) NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [pk_Cheques] PRIMARY KEY CLUSTERED 
(
	[numero_cheque] ASC,
	[cod_banco] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Facturas]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Facturas](
	[numero] [numeric](18, 0) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_cliente] [int] NULL,
	[TOTAL] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Cuentas]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Cuentas](
	[nro_cuenta] [numeric](18, 0) NOT NULL,
	[cliente_id] [int] NULL,
	[cod_estado] [int] NULL,
	[cod_pais] [numeric](18, 0) NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_cierre] [datetime] NULL,
	[categoria] [int] NULL,
	[cod_moneda] [int] NULL,
	[DiasRestantes] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nro_cuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Tarjetas_Cliente]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Tarjetas_Cliente](
	[id_tarjeta] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [pK_Tarjetas_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_tarjeta] ASC,
	[id_cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Usuarios]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Usuarios](
	[username] [varchar](255) NOT NULL,
	[pwd] [varchar](255) NOT NULL,
	[estado] [bit] NULL,
	[fecha_creac] [datetime] NOT NULL,
	[fecha_ult_modif] [datetime] NOT NULL,
	[preg_secr] [varchar](255) NULL,
	[rta_secr] [varchar](255) NULL,
	[cant_intentos_fallidos] [int] NULL,
	[clienteID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Usuarios_Roles]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [datiados].[Usuarios_Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usr] [varchar](255) NULL,
	[id_rol] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [datiados].[Transferencias]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Transferencias](
	[id_transf] [int] IDENTITY(1,1) NOT NULL,
	[cta_origen] [numeric](18, 0) NULL,
	[cta_destino] [numeric](18, 0) NULL,
	[importe] [decimal](18, 4) NOT NULL,
	[fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_transf] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Retiros]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Retiros](
	[codigo] [numeric](18, 0) NOT NULL,
	[nro_cuenta] [numeric](18, 0) NULL,
	[fecha] [datetime] NOT NULL,
	[importe] [decimal](18, 4) NOT NULL,
	[nro_cheque] [numeric](18, 0) NOT NULL,
	[cod_banco] [numeric](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[CuentaMovimientos]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[CuentaMovimientos](
	[cod_mov] [int] IDENTITY(1,1) NOT NULL,
	[nro_cuenta] [numeric](18, 0) NOT NULL,
	[tipo_mov] [numeric](2, 0) NULL,
	[importe] [decimal](18, 4) NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [pk_CtaMovs] PRIMARY KEY CLUSTERED 
(
	[cod_mov] ASC,
	[nro_cuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Depositos]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Depositos](
	[codigo] [numeric](18, 0) NOT NULL,
	[nro_cuenta] [numeric](18, 0) NULL,
	[fecha] [datetime] NOT NULL,
	[importe] [decimal](18, 4) NOT NULL,
	[moneda] [int] NULL,
	[id_tarjeta] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[Items_Facturas]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[Items_Facturas](
	[id_item] [int] NOT NULL,
	[nro_factura] [numeric](18, 0) NOT NULL,
	[tipo_concepto] [int] NULL,
	[importe] [numeric](18, 2) NOT NULL,
	[nro_cuenta] [numeric](18, 0) NULL,
	[id_transf] [int] NULL,
 CONSTRAINT [pf_Item_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC,
	[nro_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [datiados].[CtaCte]    Script Date: 07/05/2015 21:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [datiados].[CtaCte](
	[CtaCteId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NULL,
	[importe] [numeric](18, 2) NOT NULL,
	[fecha] [datetime] NULL,
	[tipoConcepto] [int] NULL,
	[NroCta] [numeric](18, 0) NULL,
	[Saldada] [bit] NULL,
	[id_transf] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CtaCteId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__Roles__estado__6A30C649]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Roles] ADD  DEFAULT ((0)) FOR [estado]
GO
/****** Object:  Default [DF__Usuarios__estado__6EF57B66]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Usuarios] ADD  DEFAULT ((0)) FOR [estado]
GO
/****** Object:  Default [DF__Usuarios__cant_i__6FE99F9F]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Usuarios] ADD  DEFAULT ((0)) FOR [cant_intentos_fallidos]
GO
/****** Object:  ForeignKey [FK__Cheques__cod_ban__07F6335A]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Cheques]  WITH CHECK ADD FOREIGN KEY([cod_banco])
REFERENCES [datiados].[Bancos] ([codigo])
GO
/****** Object:  ForeignKey [FK__Clientes__cod_pa__173876EA]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Clientes]  WITH CHECK ADD FOREIGN KEY([cod_pais])
REFERENCES [datiados].[Paises] ([codigo])
GO
/****** Object:  ForeignKey [FK__Clientes__cod_ti__164452B1]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Clientes]  WITH CHECK ADD FOREIGN KEY([cod_tipo_doc])
REFERENCES [datiados].[TipoDoc] ([cod_doc])
GO
/****** Object:  ForeignKey [FK__CtaCte__NroCta__5AEE82B9]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[CtaCte]  WITH CHECK ADD FOREIGN KEY([NroCta])
REFERENCES [datiados].[Cuentas] ([nro_cuenta])
GO
/****** Object:  ForeignKey [FK__CtaCte__tipoConc__59FA5E80]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[CtaCte]  WITH CHECK ADD FOREIGN KEY([tipoConcepto])
REFERENCES [datiados].[ItemConceptoTipos] ([id_tipo])
GO
/****** Object:  ForeignKey [FK_CtaCte_transferencias]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[CtaCte]  WITH CHECK ADD  CONSTRAINT [FK_CtaCte_transferencias] FOREIGN KEY([id_transf])
REFERENCES [datiados].[Transferencias] ([id_transf])
GO
ALTER TABLE [datiados].[CtaCte] CHECK CONSTRAINT [FK_CtaCte_transferencias]
GO
/****** Object:  ForeignKey [FK__CuentaMov__nro_c__2B0A656D]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[CuentaMovimientos]  WITH CHECK ADD FOREIGN KEY([nro_cuenta])
REFERENCES [datiados].[Cuentas] ([nro_cuenta])
GO
/****** Object:  ForeignKey [FK__CuentaMov__tipo___2BFE89A6]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[CuentaMovimientos]  WITH CHECK ADD FOREIGN KEY([tipo_mov])
REFERENCES [datiados].[TipoMovCuentas] ([tipo_mov])
GO
/****** Object:  ForeignKey [FK__Cuentas__categor__2A4B4B5E]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Cuentas]  WITH CHECK ADD FOREIGN KEY([categoria])
REFERENCES [datiados].[CuentaCategorias] ([id_categoria])
GO
/****** Object:  ForeignKey [FK__Cuentas__cliente__276EDEB3]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Cuentas]  WITH CHECK ADD FOREIGN KEY([cliente_id])
REFERENCES [datiados].[Clientes] ([id])
GO
/****** Object:  ForeignKey [FK__Cuentas__cod_est__286302EC]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Cuentas]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [datiados].[CuentaEstados] ([id_estado])
GO
/****** Object:  ForeignKey [FK__Cuentas__cod_mon__2B3F6F97]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Cuentas]  WITH CHECK ADD FOREIGN KEY([cod_moneda])
REFERENCES [datiados].[Monedas] ([moneda_id])
GO
/****** Object:  ForeignKey [FK__Cuentas__cod_pai__29572725]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Cuentas]  WITH CHECK ADD FOREIGN KEY([cod_pais])
REFERENCES [datiados].[Paises] ([codigo])
GO
/****** Object:  ForeignKey [FK__Depositos__id_ta__3E52440B]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Depositos]  WITH CHECK ADD FOREIGN KEY([id_tarjeta])
REFERENCES [datiados].[Tarjetas] ([id_tarjeta])
GO
/****** Object:  ForeignKey [FK__Depositos__moned__3D5E1FD2]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Depositos]  WITH CHECK ADD FOREIGN KEY([moneda])
REFERENCES [datiados].[Monedas] ([moneda_id])
GO
/****** Object:  ForeignKey [FK__Depositos__nro_c__3C69FB99]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Depositos]  WITH CHECK ADD FOREIGN KEY([nro_cuenta])
REFERENCES [datiados].[Cuentas] ([nro_cuenta])
GO
/****** Object:  ForeignKey [FK__Facturas__id_cli__5FB337D6]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Facturas]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [datiados].[Clientes] ([id])
GO
/****** Object:  ForeignKey [FK__Items_Fac__id_tr__656C112C]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Items_Facturas]  WITH CHECK ADD FOREIGN KEY([id_transf])
REFERENCES [datiados].[Transferencias] ([id_transf])
GO
/****** Object:  ForeignKey [FK__Items_Fac__nro_c__6477ECF3]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Items_Facturas]  WITH CHECK ADD FOREIGN KEY([nro_cuenta])
REFERENCES [datiados].[Cuentas] ([nro_cuenta])
GO
/****** Object:  ForeignKey [FK__Items_Fac__nro_f__628FA481]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Items_Facturas]  WITH CHECK ADD FOREIGN KEY([nro_factura])
REFERENCES [datiados].[Facturas] ([numero])
GO
/****** Object:  ForeignKey [FK__Items_Fac__tipo___6383C8BA]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Items_Facturas]  WITH CHECK ADD FOREIGN KEY([tipo_concepto])
REFERENCES [datiados].[ItemConceptoTipos] ([id_tipo])
GO
/****** Object:  ForeignKey [FK__Retiros__nro_cue__4316F928]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Retiros]  WITH CHECK ADD FOREIGN KEY([nro_cuenta])
REFERENCES [datiados].[Cuentas] ([nro_cuenta])
GO
/****** Object:  ForeignKey [fk_cheques_retiros]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Retiros]  WITH CHECK ADD  CONSTRAINT [fk_cheques_retiros] FOREIGN KEY([nro_cheque], [cod_banco])
REFERENCES [datiados].[Cheques] ([numero_cheque], [cod_banco])
GO
ALTER TABLE [datiados].[Retiros] CHECK CONSTRAINT [fk_cheques_retiros]
GO
/****** Object:  ForeignKey [FK__Roles_Fun__id_fu__7D439ABD]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Roles_Funcionalidades]  WITH CHECK ADD FOREIGN KEY([id_func])
REFERENCES [datiados].[Funcionalidades] ([id_func])
GO
/****** Object:  ForeignKey [FK__Roles_Fun__id_ro__7C4F7684]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Roles_Funcionalidades]  WITH CHECK ADD FOREIGN KEY([id_rol])
REFERENCES [datiados].[Roles] ([id_rol])
GO
/****** Object:  ForeignKey [FK__Tarjetas__codEmi__33D4B598]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Tarjetas]  WITH CHECK ADD FOREIGN KEY([codEmisor])
REFERENCES [datiados].[emisoresTarjetas] ([codEmisor])
GO
/****** Object:  ForeignKey [FK__Tarjetas___id_cl__37A5467C]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Tarjetas_Cliente]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [datiados].[Clientes] ([id])
GO
/****** Object:  ForeignKey [FK__Tarjetas___id_ta__36B12243]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Tarjetas_Cliente]  WITH CHECK ADD FOREIGN KEY([id_tarjeta])
REFERENCES [datiados].[Tarjetas] ([id_tarjeta])
GO
/****** Object:  ForeignKey [FK__Transfere__cta_d__49C3F6B7]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Transferencias]  WITH CHECK ADD FOREIGN KEY([cta_destino])
REFERENCES [datiados].[Cuentas] ([nro_cuenta])
GO
/****** Object:  ForeignKey [FK__Transfere__cta_o__48CFD27E]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Transferencias]  WITH CHECK ADD FOREIGN KEY([cta_origen])
REFERENCES [datiados].[Cuentas] ([nro_cuenta])
GO
/****** Object:  ForeignKey [FK__Usuarios__client__70DDC3D8]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Usuarios]  WITH CHECK ADD FOREIGN KEY([clienteID])
REFERENCES [datiados].[Clientes] ([id])
GO
/****** Object:  ForeignKey [FK__Usuarios___id_ro__7A672E12]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Usuarios_Roles]  WITH CHECK ADD FOREIGN KEY([id_rol])
REFERENCES [datiados].[Roles] ([id_rol])
GO
/****** Object:  ForeignKey [FK__Usuarios_Ro__usr__797309D9]    Script Date: 07/05/2015 21:55:48 ******/
ALTER TABLE [datiados].[Usuarios_Roles]  WITH CHECK ADD FOREIGN KEY([usr])
REFERENCES [datiados].[Usuarios] ([username])
GO
