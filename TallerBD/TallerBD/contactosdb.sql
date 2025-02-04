
USE [ContactosDB]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 30/10/2023 20:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](10) NULL,
	[Nombre] [nvarchar](30) NULL,
	[Telefono] [nvarchar](12) NULL,
	[FechaNacimiento] [datetime] NULL,
 CONSTRAINT [PK__Personas__3214EC07A40455E2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([Id], [Cedula], [Nombre], [Telefono], [FechaNacimiento]) VALUES (2, N'65489', N'carlos', N'87845', CAST(N'2023-10-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Personas] ([Id], [Cedula], [Nombre], [Telefono], [FechaNacimiento]) VALUES (6, N'65656', N'johnp', N'8989874', CAST(N'2000-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Personas] ([Id], [Cedula], [Nombre], [Telefono], [FechaNacimiento]) VALUES (7, N'6565656', N'pedro pablo perez', N'315487987', CAST(N'1980-01-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
USE [master]
GO
ALTER DATABASE [ContactosDB] SET  READ_WRITE 
GO
