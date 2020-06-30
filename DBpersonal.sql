USE [personal]
GO

/****** Object:  Table [dbo].[personal]    Script Date: 29/06/2020 20:27:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[personal](
	[Idpersonal] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApePaterno] [varchar](50) NOT NULL,
	[ApeMaterno] [varchar](50) NOT NULL,
	[CI] [varchar](50) NOT NULL,
	[FchaNacimiento] [datetime2](7) NOT NULL,
	[Sexo] [nchar](10) NOT NULL,
	[Nacionalidad] [varchar](50) NOT NULL,
	[EstadoCivil] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Codigo] [decimal](18, 0) NOT NULL,
	[Estado] [nvarchar](10) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[DiasVac] [int] NULL,
 CONSTRAINT [PK_personal] PRIMARY KEY CLUSTERED 
(
	[Idpersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


