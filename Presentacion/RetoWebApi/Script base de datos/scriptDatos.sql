USE [ViajesTerrestres]
GO
/****** Object:  Table [dbo].[Bus]    Script Date: 4/09/2020 7:52:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bus](
	[BusId] [int] IDENTITY(1,1) NOT NULL,
	[Capacidad] [int] NULL,
	[CapacidadActual] [int] NULL,
 CONSTRAINT [PK_Bus] PRIMARY KEY CLUSTERED 
(
	[BusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipio]    Script Date: 4/09/2020 7:52:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipio](
	[MunicipioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Departamento] [varchar](50) NULL,
 CONSTRAINT [PK_Municipio] PRIMARY KEY CLUSTERED 
(
	[MunicipioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 4/09/2020 7:52:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajero](
	[PasajeroId] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [varchar](max) NULL,
	[Tapabocas] [bit] NOT NULL,
	[RutaBusId] [int] NULL,
	[SillaAsignada] [int] NULL,
 CONSTRAINT [PK_Pasajero] PRIMARY KEY CLUSTERED 
(
	[PasajeroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ruta]    Script Date: 4/09/2020 7:52:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ruta](
	[RutaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[OrigenId] [int] NULL,
	[DestinoId] [int] NOT NULL,
	[Trasbordo] [bit] NULL,
	[TrasbordoMunicipioId] [int] NULL,
 CONSTRAINT [PK_Ruta] PRIMARY KEY CLUSTERED 
(
	[RutaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RutaBus]    Script Date: 4/09/2020 7:52:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RutaBus](
	[RutaBusId] [int] IDENTITY(1,1) NOT NULL,
	[RutaId] [int] NULL,
	[BusId] [int] NULL,
 CONSTRAINT [PK_RutaBus] PRIMARY KEY CLUSTERED 
(
	[RutaBusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bus] ON 

INSERT [dbo].[Bus] ([BusId], [Capacidad], [CapacidadActual]) VALUES (1, 40, 0)
INSERT [dbo].[Bus] ([BusId], [Capacidad], [CapacidadActual]) VALUES (2, 40, 0)
INSERT [dbo].[Bus] ([BusId], [Capacidad], [CapacidadActual]) VALUES (3, 40, 0)
INSERT [dbo].[Bus] ([BusId], [Capacidad], [CapacidadActual]) VALUES (4, 40, 0)
SET IDENTITY_INSERT [dbo].[Bus] OFF
GO
SET IDENTITY_INSERT [dbo].[Municipio] ON 

INSERT [dbo].[Municipio] ([MunicipioId], [Nombre], [Departamento]) VALUES (1, N'Medellin', N'Antioquia')
INSERT [dbo].[Municipio] ([MunicipioId], [Nombre], [Departamento]) VALUES (2, N'Santa Rosa de Osos', N'Antioquia')
INSERT [dbo].[Municipio] ([MunicipioId], [Nombre], [Departamento]) VALUES (3, N'San José de la Montaña', N'Antioquia')
SET IDENTITY_INSERT [dbo].[Municipio] OFF
GO
SET IDENTITY_INSERT [dbo].[Pasajero] ON 

INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (1, N'Julian Jerez', 1, 7, 1)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (2, N'Marco Jimenez', 1, 8, 1)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (3, N'Stephany Rivera', 1, 7, 3)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (4, N'Pepita Perez', 1, 7, 5)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (5, N'Julianito Marin', 1, 7, 7)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (6, N'Malena Rojas', 1, 7, 9)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (7, N'Camila Zapote', 1, 7, 11)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (8, N'Alejandro Paloma', 1, 7, 13)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (9, N'Raúl chicalo', 1, 7, 15)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (10, N'James Rodriguez', 1, 7, 17)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (11, N'David Ospina', 1, 7, 19)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (12, N'Bob Esponja', 1, 7, 21)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (13, N'Nemo Rios', 1, 7, 23)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (14, N'Niña Niño', 1, 7, 25)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (15, N'Laura Señora', 1, 7, 27)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (16, N'Juliana Rojas', 1, 7, 29)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (17, N'Eduardo Pinto', 1, 7, 31)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (18, N'Maria Pinta', 1, 7, 33)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (19, N'Cristiano Ronaldo', 1, 7, 35)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (20, N'Elias Lopez', 1, 7, 37)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (21, N'Macho Arias', 1, 7, 39)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (22, N'Caballito Grande', 1, 8, 3)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (23, N'Caballito Pequeño', 1, 8, 5)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (24, N'Lento Lento', 1, 8, 7)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (25, N'Alex Morgan', 1, 8, 9)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (26, N'Jesus de la Cruz', 1, 8, 11)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (27, N'Maria de los Cielos', 1, 8, 13)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (28, N'Diablo de las Tinieblas', 1, 8, 15)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (29, N'Calamardo Pulpo', 1, 8, 17)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (30, N'Epson Ruiz', 1, 8, 19)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (31, N'Samsung Bejarano', 1, 8, 21)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (32, N'Bill Gates', 1, 8, 23)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (33, N'Bill Clinton', 1, 8, 25)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (34, N'Donald Trump', 1, 8, 27)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (35, N'Donald el pato', 1, 8, 29)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (36, N'Mickey Mouse', 1, 8, 31)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (37, N'Minnie Mouse ', 1, 8, 33)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (38, N'Will Smith', 1, 8, 35)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (39, N'Elon Musk', 1, 8, 37)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (40, N'Mark Zuckerber', 1, 8, 39)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (41, N'Balon Azul ', 1, 9, 1)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (42, N'El chapo Guzman', 1, 9, 3)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (43, N'Pedro Pablo Leon', 1, 9, 5)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (44, N'Anne Mar', 1, 9, 7)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (45, N'Linda Estrella ', 1, 9, 9)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (46, N'Matilda kira', 1, 9, 11)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (47, N'Belinda Corazon', 1, 9, 13)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (48, N'Manzana Verde', 1, 9, 15)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (49, N'Brad Pitt ', 1, 9, 17)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (50, N'Megan Fox', 1, 9, 19)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (51, N'Jennifer Lopez ', 1, 9, 21)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (52, N'Shakira', 1, 9, 23)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (53, N'Gerard Pique ', 1, 9, 25)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (54, N'Adele ', 1, 9, 27)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (55, N'Ed Sheeran', 1, 9, 29)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (56, N'Adam Levine ', 1, 9, 31)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (57, N'Ricardo Arjona', 1, 9, 33)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (58, N'Juanes', 1, 9, 35)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (59, N'Justion Kimberly', 1, 9, 37)
INSERT [dbo].[Pasajero] ([PasajeroId], [NombreCompleto], [Tapabocas], [RutaBusId], [SillaAsignada]) VALUES (60, N'Kimberly Papel', 1, 9, 39)
SET IDENTITY_INSERT [dbo].[Pasajero] OFF
GO
SET IDENTITY_INSERT [dbo].[Ruta] ON 

INSERT [dbo].[Ruta] ([RutaId], [Nombre], [OrigenId], [DestinoId], [Trasbordo], [TrasbordoMunicipioId]) VALUES (3, N'Ruta Santa Rosa de Osos VIP', 1, 2, 0, 2)
INSERT [dbo].[Ruta] ([RutaId], [Nombre], [OrigenId], [DestinoId], [Trasbordo], [TrasbordoMunicipioId]) VALUES (4, N'Ruta Santa Rosa de Osos', 1, 2, 1, 3)
SET IDENTITY_INSERT [dbo].[Ruta] OFF
GO
SET IDENTITY_INSERT [dbo].[RutaBus] ON 

INSERT [dbo].[RutaBus] ([RutaBusId], [RutaId], [BusId]) VALUES (7, 3, 1)
INSERT [dbo].[RutaBus] ([RutaBusId], [RutaId], [BusId]) VALUES (8, 4, 2)
INSERT [dbo].[RutaBus] ([RutaBusId], [RutaId], [BusId]) VALUES (9, 3, 3)
INSERT [dbo].[RutaBus] ([RutaBusId], [RutaId], [BusId]) VALUES (10, 4, 4)
SET IDENTITY_INSERT [dbo].[RutaBus] OFF
GO
ALTER TABLE [dbo].[Pasajero] ADD  CONSTRAINT [DF_Pasajero_Tapabocas]  DEFAULT ((1)) FOR [Tapabocas]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_Pasajero_RutaBus] FOREIGN KEY([RutaBusId])
REFERENCES [dbo].[RutaBus] ([RutaBusId])
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_Pasajero_RutaBus]
GO
ALTER TABLE [dbo].[Ruta]  WITH CHECK ADD  CONSTRAINT [FK_Destino] FOREIGN KEY([DestinoId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Ruta] CHECK CONSTRAINT [FK_Destino]
GO
ALTER TABLE [dbo].[Ruta]  WITH CHECK ADD  CONSTRAINT [FK_Ruta_Municipio] FOREIGN KEY([TrasbordoMunicipioId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Ruta] CHECK CONSTRAINT [FK_Ruta_Municipio]
GO
ALTER TABLE [dbo].[Ruta]  WITH CHECK ADD  CONSTRAINT [FK_Ruta_Municipio1] FOREIGN KEY([OrigenId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Ruta] CHECK CONSTRAINT [FK_Ruta_Municipio1]
GO
ALTER TABLE [dbo].[RutaBus]  WITH CHECK ADD  CONSTRAINT [FK_RutaBus_Bus] FOREIGN KEY([BusId])
REFERENCES [dbo].[Bus] ([BusId])
GO
ALTER TABLE [dbo].[RutaBus] CHECK CONSTRAINT [FK_RutaBus_Bus]
GO
ALTER TABLE [dbo].[RutaBus]  WITH CHECK ADD  CONSTRAINT [FK_RutaBus_Ruta] FOREIGN KEY([RutaId])
REFERENCES [dbo].[Ruta] ([RutaId])
GO
ALTER TABLE [dbo].[RutaBus] CHECK CONSTRAINT [FK_RutaBus_Ruta]
GO
