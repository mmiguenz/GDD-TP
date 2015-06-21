USE [Migracion]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paises](
	[codigo] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bancos]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bancos](
	[Codigo] [numeric](18, 0) NOT NULL,
	[Nombre] [varchar](250) NULL,
	[Direccion] [varchar](250) NULL,
 CONSTRAINT [PK_Bancos] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tarjetas](
	[NroTarjeta] [varchar](16) NOT NULL,
	[FechaEmision] [datetime] NULL,
	[FechaVencimiento] [datetime] NULL,
	[CodSeg] [varchar](3) NULL,
	[Emisor] [varchar](250) NULL,
 CONSTRAINT [PK_Tarjetas_1] PRIMARY KEY CLUSTERED 
(
	[NroTarjeta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoMovCtas]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoMovCtas](
	[CodMov] [numeric](2, 0) NOT NULL,
	[Descripcion] [varchar](150) NULL,
	[Signo] [char](1) NULL,
 CONSTRAINT [PK_TipoMovCtas] PRIMARY KEY CLUSTERED 
(
	[CodMov] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDoc](
	[codigo] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_TipoDoc] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoCuenta]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoCuenta](
	[codigo] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[costo] [decimal](18, 4) NULL,
 CONSTRAINT [PK_TipoCuenta] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Monedas]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Monedas](
	[codigo] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[cotizacion] [decimal](18, 4) NULL,
 CONSTRAINT [PK_Monedas] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentaEstados]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuentaEstados](
	[Codigo] [numeric](18, 0) NOT NULL,
	[Descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_CuentaEstados] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[NroDoc] [numeric](18, 0) NOT NULL,
	[CodTipoDoc] [numeric](18, 0) NOT NULL,
	[CodPais] [numeric](18, 0) NULL,
	[Nombre] [varchar](255) NULL,
	[Apellido] [varchar](255) NULL,
	[calle] [varchar](255) NULL,
	[NumeroDomicilio] [numeric](18, 0) NULL,
	[Piso] [numeric](18, 0) NULL,
	[Dpto] [varchar](10) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Mail] [varchar](255) NULL,
 CONSTRAINT [PK_Clientes_1] PRIMARY KEY CLUSTERED 
(
	[NroDoc] ASC,
	[CodTipoDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cheques]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cheques](
	[NroCheque] [numeric](18, 0) NOT NULL,
	[CodBanco] [numeric](18, 0) NOT NULL,
	[Importe] [decimal](18, 4) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_Cheques] PRIMARY KEY CLUSTERED 
(
	[NroCheque] ASC,
	[CodBanco] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[NroCuenta] [numeric](18, 0) NOT NULL,
	[CodEstado] [numeric](18, 0) NULL,
	[CodPais] [numeric](18, 0) NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaCierre] [datetime] NULL,
	[CodMoneda] [numeric](18, 0) NULL,
	[NroDocCliente] [numeric](18, 0) NULL,
	[CodTipoDocCli] [numeric](18, 0) NULL,
	[CodTipoCuenta] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED 
(
	[NroCuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TarjetasXCliente]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TarjetasXCliente](
	[NroTarjeta] [varchar](16) NOT NULL,
	[NroDoc] [numeric](18, 0) NOT NULL,
	[TipoDoc] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_TarjetasXCliente_1] PRIMARY KEY CLUSTERED 
(
	[NroTarjeta] ASC,
	[NroDoc] ASC,
	[TipoDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transferencias]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transferencias](
	[Codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NroCtaOrigen] [numeric](18, 0) NULL,
	[NroCtaDestino] [numeric](18, 0) NULL,
	[Importe] [decimal](18, 4) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Retiros]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Retiros](
	[Codigo] [numeric](18, 0) NOT NULL,
	[Importe] [decimal](18, 4) NULL,
	[NroCheque] [numeric](18, 0) NULL,
	[CodBanco] [numeric](18, 0) NULL,
	[NroDocCli] [numeric](18, 0) NULL,
	[TipoDocCli] [numeric](18, 0) NULL,
	[NroCuenta] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Retiros] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovCtas]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovCtas](
	[CodigoMov] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NroCuenta] [numeric](18, 0) NOT NULL,
	[CodTipoMovCta] [numeric](2, 0) NULL,
	[Importe] [decimal](18, 4) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_MovCtas] PRIMARY KEY CLUSTERED 
(
	[CodigoMov] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Depositos]    Script Date: 05/26/2015 01:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Depositos](
	[Codigo] [numeric](18, 0) NOT NULL,
	[FechaDeposito] [datetime] NULL,
	[NroCuenta] [numeric](18, 0) NULL,
	[Importe] [decimal](18, 4) NULL,
	[CodMoneda] [numeric](18, 0) NULL,
	[NroTarjeta] [varchar](16) NULL,
 CONSTRAINT [PK_Depositos] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Bancos_1Cheques__N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Cheques]  WITH CHECK ADD  CONSTRAINT [FK_Bancos_1Cheques__N] FOREIGN KEY([CodBanco])
REFERENCES [dbo].[Bancos] ([Codigo])
GO
ALTER TABLE [dbo].[Cheques] CHECK CONSTRAINT [FK_Bancos_1Cheques__N]
GO
/****** Object:  ForeignKey [FK_Clientes_N_Paises_1]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_N_Paises_1] FOREIGN KEY([CodPais])
REFERENCES [dbo].[Paises] ([codigo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_N_Paises_1]
GO
/****** Object:  ForeignKey [FK_Clientes_N_TipoDoc_1]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_N_TipoDoc_1] FOREIGN KEY([CodTipoDoc])
REFERENCES [dbo].[TipoDoc] ([codigo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_N_TipoDoc_1]
GO
/****** Object:  ForeignKey [FK_Clientes_1_Cuentas_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_1_Cuentas_N] FOREIGN KEY([NroDocCliente], [CodTipoDocCli])
REFERENCES [dbo].[Clientes] ([NroDoc], [CodTipoDoc])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Clientes_1_Cuentas_N]
GO
/****** Object:  ForeignKey [FK_CuentaEstados_1_Cuentas_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_CuentaEstados_1_Cuentas_N] FOREIGN KEY([CodEstado])
REFERENCES [dbo].[CuentaEstados] ([Codigo])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_CuentaEstados_1_Cuentas_N]
GO
/****** Object:  ForeignKey [FK_Monedas_1_Cuentas_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Monedas_1_Cuentas_N] FOREIGN KEY([CodMoneda])
REFERENCES [dbo].[Monedas] ([codigo])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Monedas_1_Cuentas_N]
GO
/****** Object:  ForeignKey [FK_Paises_1_Cuentas_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Paises_1_Cuentas_N] FOREIGN KEY([CodPais])
REFERENCES [dbo].[Paises] ([codigo])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Paises_1_Cuentas_N]
GO
/****** Object:  ForeignKey [FK_TipoCuenta_1_Cuentas_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_TipoCuenta_1_Cuentas_N] FOREIGN KEY([CodTipoCuenta])
REFERENCES [dbo].[TipoCuenta] ([codigo])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_TipoCuenta_1_Cuentas_N]
GO
/****** Object:  ForeignKey [FK_Cuentas_1_Depositos_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Depositos]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_1_Depositos_N] FOREIGN KEY([NroCuenta])
REFERENCES [dbo].[Cuentas] ([NroCuenta])
GO
ALTER TABLE [dbo].[Depositos] CHECK CONSTRAINT [FK_Cuentas_1_Depositos_N]
GO
/****** Object:  ForeignKey [FK_Monedas_1_Cuentas_1]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Depositos]  WITH CHECK ADD  CONSTRAINT [FK_Monedas_1_Cuentas_1] FOREIGN KEY([CodMoneda])
REFERENCES [dbo].[Monedas] ([codigo])
GO
ALTER TABLE [dbo].[Depositos] CHECK CONSTRAINT [FK_Monedas_1_Cuentas_1]
GO
/****** Object:  ForeignKey [FK_MovCtas_2_Cuentas]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[MovCtas]  WITH CHECK ADD  CONSTRAINT [FK_MovCtas_2_Cuentas] FOREIGN KEY([NroCuenta])
REFERENCES [dbo].[Cuentas] ([NroCuenta])
GO
ALTER TABLE [dbo].[MovCtas] CHECK CONSTRAINT [FK_MovCtas_2_Cuentas]
GO
/****** Object:  ForeignKey [FK_TipoMovCtas_2_MovCTas_2]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[MovCtas]  WITH CHECK ADD  CONSTRAINT [FK_TipoMovCtas_2_MovCTas_2] FOREIGN KEY([CodTipoMovCta])
REFERENCES [dbo].[TipoMovCtas] ([CodMov])
GO
ALTER TABLE [dbo].[MovCtas] CHECK CONSTRAINT [FK_TipoMovCtas_2_MovCTas_2]
GO
/****** Object:  ForeignKey [FK_Cheques_1_Retiros_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Retiros]  WITH CHECK ADD  CONSTRAINT [FK_Cheques_1_Retiros_N] FOREIGN KEY([NroCheque], [CodBanco])
REFERENCES [dbo].[Cheques] ([NroCheque], [CodBanco])
GO
ALTER TABLE [dbo].[Retiros] CHECK CONSTRAINT [FK_Cheques_1_Retiros_N]
GO
/****** Object:  ForeignKey [FK_Clientes_1_Retiros_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Retiros]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_1_Retiros_N] FOREIGN KEY([NroDocCli], [TipoDocCli])
REFERENCES [dbo].[Clientes] ([NroDoc], [CodTipoDoc])
GO
ALTER TABLE [dbo].[Retiros] CHECK CONSTRAINT [FK_Clientes_1_Retiros_N]
GO
/****** Object:  ForeignKey [FK_Retiros_Cuentas]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Retiros]  WITH CHECK ADD  CONSTRAINT [FK_Retiros_Cuentas] FOREIGN KEY([NroCuenta])
REFERENCES [dbo].[Cuentas] ([NroCuenta])
GO
ALTER TABLE [dbo].[Retiros] CHECK CONSTRAINT [FK_Retiros_Cuentas]
GO
/****** Object:  ForeignKey [FK_Clientes_2_TarjXCli_2]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[TarjetasXCliente]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_2_TarjXCli_2] FOREIGN KEY([NroDoc], [TipoDoc])
REFERENCES [dbo].[Clientes] ([NroDoc], [CodTipoDoc])
GO
ALTER TABLE [dbo].[TarjetasXCliente] CHECK CONSTRAINT [FK_Clientes_2_TarjXCli_2]
GO
/****** Object:  ForeignKey [FK_Cuentas_1_Tranferencias_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_1_Tranferencias_N] FOREIGN KEY([NroCtaOrigen])
REFERENCES [dbo].[Cuentas] ([NroCuenta])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Cuentas_1_Tranferencias_N]
GO
/****** Object:  ForeignKey [FK_Cuentas_1_Transf_N]    Script Date: 05/26/2015 01:16:24 ******/
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_1_Transf_N] FOREIGN KEY([NroCtaDestino])
REFERENCES [dbo].[Cuentas] ([NroCuenta])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Cuentas_1_Transf_N]
GO
