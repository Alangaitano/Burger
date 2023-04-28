USE [hamburgueseria]
GO

/****** Object:  Table [dbo].[acompañamiento]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[acompañamiento](
	[id_acompañamiento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[recargo] [int] NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_acompañamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bebida]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bebida](
	[id_bebida] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[precio] [float] NULL,
	[recargo] [int] NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bebida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[combo]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[combo](
	[id_combo] [int] IDENTITY(1,1) NOT NULL,
	[detalle] [int] NOT NULL,
	[nombre] [varchar](20) NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_combo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_combo]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_combo](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[bebida] [int] NOT NULL,
	[acompañamiento] [int] NOT NULL,
	[hamburguesa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[id_venta] [int] NOT NULL,
	[id_combo] [int] NOT NULL,
	[cantidad] [int] NULL,
	[total] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[telefono] [int] NULL,
	[mail] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hamburguesa]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hamburguesa](
	[id_hamburguesa] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hamburguesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingrediente]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingrediente](
	[id_ingrediente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[precio] [float] NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingrediente_acompañamiento]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingrediente_acompañamiento](
	[id_acompañamiento] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_acompañamiento] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingrediente_hamburguesa]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingrediente_hamburguesa](
	[id_hamburguesa] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hamburguesa] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 5 abr. 2023 00:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[empleado] [int] NOT NULL,
	[fecha_venta] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[acompañamiento] ON 
GO
INSERT [dbo].[acompañamiento] ([id_acompañamiento], [nombre], [recargo], [activo]) VALUES (1, N'Papas fritas', 10, 1)
GO
INSERT [dbo].[acompañamiento] ([id_acompañamiento], [nombre], [recargo], [activo]) VALUES (2, N'Ensalada', 10, 1)
GO
INSERT [dbo].[acompañamiento] ([id_acompañamiento], [nombre], [recargo], [activo]) VALUES (1053, N'Salsa criolla', 10, 1)
GO
INSERT [dbo].[acompañamiento] ([id_acompañamiento], [nombre], [recargo], [activo]) VALUES (1054, N'Papas al horno', 10, 1)
GO
INSERT [dbo].[acompañamiento] ([id_acompañamiento], [nombre], [recargo], [activo]) VALUES (1055, N'Ensalada cesar', 10, 1)
GO
INSERT [dbo].[acompañamiento] ([id_acompañamiento], [nombre], [recargo], [activo]) VALUES (2043, N'Papas fritas', 10, 0)
GO
SET IDENTITY_INSERT [dbo].[acompañamiento] OFF
GO
SET IDENTITY_INSERT [dbo].[bebida] ON 
GO
INSERT [dbo].[bebida] ([id_bebida], [nombre], [precio], [recargo], [activo]) VALUES (1, N'Coca-Cola', 200, 10, 1)
GO
INSERT [dbo].[bebida] ([id_bebida], [nombre], [precio], [recargo], [activo]) VALUES (2, N'Fanta', 200, 10, 1)
GO
INSERT [dbo].[bebida] ([id_bebida], [nombre], [precio], [recargo], [activo]) VALUES (3, N'Sprite', 200, 10, 1)
GO
INSERT [dbo].[bebida] ([id_bebida], [nombre], [precio], [recargo], [activo]) VALUES (4, N'Jugo naranja', 250, 10, 1)
GO
INSERT [dbo].[bebida] ([id_bebida], [nombre], [precio], [recargo], [activo]) VALUES (5, N'Soda', 200, 10, 1)
GO
INSERT [dbo].[bebida] ([id_bebida], [nombre], [precio], [recargo], [activo]) VALUES (1006, N'Agua', 250, 10, 1)
GO
INSERT [dbo].[bebida] ([id_bebida], [nombre], [precio], [recargo], [activo]) VALUES (1007, N'Agua saborizada', 250, 10, 1)
GO
SET IDENTITY_INSERT [dbo].[bebida] OFF
GO
SET IDENTITY_INSERT [dbo].[combo] ON 
GO
INSERT [dbo].[combo] ([id_combo], [detalle], [nombre], [activo]) VALUES (18, 10, N'Simple', 1)
GO
INSERT [dbo].[combo] ([id_combo], [detalle], [nombre], [activo]) VALUES (19, 11, N'Simple Completo', 1)
GO
INSERT [dbo].[combo] ([id_combo], [detalle], [nombre], [activo]) VALUES (20, 12, N'Doble', 1)
GO
INSERT [dbo].[combo] ([id_combo], [detalle], [nombre], [activo]) VALUES (21, 13, N'Doble completo', 1)
GO
INSERT [dbo].[combo] ([id_combo], [detalle], [nombre], [activo]) VALUES (22, 15, N'Simple', 1)
GO
INSERT [dbo].[combo] ([id_combo], [detalle], [nombre], [activo]) VALUES (24, 36, N'Simple Completo', 1)
GO
SET IDENTITY_INSERT [dbo].[combo] OFF
GO
SET IDENTITY_INSERT [dbo].[detalle_combo] ON 
GO
INSERT [dbo].[detalle_combo] ([id_detalle], [bebida], [acompañamiento], [hamburguesa]) VALUES (10, 1, 1055, 1)
GO
INSERT [dbo].[detalle_combo] ([id_detalle], [bebida], [acompañamiento], [hamburguesa]) VALUES (11, 1, 1, 2)
GO
INSERT [dbo].[detalle_combo] ([id_detalle], [bebida], [acompañamiento], [hamburguesa]) VALUES (12, 4, 2, 3)
GO
INSERT [dbo].[detalle_combo] ([id_detalle], [bebida], [acompañamiento], [hamburguesa]) VALUES (13, 5, 1, 4)
GO
INSERT [dbo].[detalle_combo] ([id_detalle], [bebida], [acompañamiento], [hamburguesa]) VALUES (15, 1, 1, 2)
GO
INSERT [dbo].[detalle_combo] ([id_detalle], [bebida], [acompañamiento], [hamburguesa]) VALUES (36, 1, 1, 1010)
GO
SET IDENTITY_INSERT [dbo].[detalle_combo] OFF
GO
INSERT [dbo].[detalle_venta] ([id_venta], [id_combo], [cantidad], [total]) VALUES (1, 1, 2, NULL)
GO
INSERT [dbo].[detalle_venta] ([id_venta], [id_combo], [cantidad], [total]) VALUES (2, 1, 2, NULL)
GO
INSERT [dbo].[detalle_venta] ([id_venta], [id_combo], [cantidad], [total]) VALUES (3, 2, 3, NULL)
GO
INSERT [dbo].[detalle_venta] ([id_venta], [id_combo], [cantidad], [total]) VALUES (4, 4, 1, NULL)
GO
INSERT [dbo].[detalle_venta] ([id_venta], [id_combo], [cantidad], [total]) VALUES (5, 18, 2, 2000)
GO
SET IDENTITY_INSERT [dbo].[empleado] ON 
GO
INSERT [dbo].[empleado] ([id_empleado], [nombre], [apellido], [telefono], [mail]) VALUES (1, N'juan', N'gonzalez', 1154879865, N'juancito@outlook.com')
GO
INSERT [dbo].[empleado] ([id_empleado], [nombre], [apellido], [telefono], [mail]) VALUES (2, N'alan', N'gaitano', 1154456589, N'alan@hotmail.com')
GO
INSERT [dbo].[empleado] ([id_empleado], [nombre], [apellido], [telefono], [mail]) VALUES (3, N'sebastian', N'perez', 1154686344, N'seba@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[hamburguesa] ON 
GO
INSERT [dbo].[hamburguesa] ([id_hamburguesa], [nombre], [activo]) VALUES (1, N'Simple', 1)
GO
INSERT [dbo].[hamburguesa] ([id_hamburguesa], [nombre], [activo]) VALUES (2, N'Simple Completo', 1)
GO
INSERT [dbo].[hamburguesa] ([id_hamburguesa], [nombre], [activo]) VALUES (3, N'Doble', 1)
GO
INSERT [dbo].[hamburguesa] ([id_hamburguesa], [nombre], [activo]) VALUES (4, N'Doble Completo', 1)
GO
INSERT [dbo].[hamburguesa] ([id_hamburguesa], [nombre], [activo]) VALUES (9, N'Triple', 1)
GO
INSERT [dbo].[hamburguesa] ([id_hamburguesa], [nombre], [activo]) VALUES (1010, N'Triple Completo', 1)
GO
INSERT [dbo].[hamburguesa] ([id_hamburguesa], [nombre], [activo]) VALUES (1023, N'Cuadruple', 1)
GO
SET IDENTITY_INSERT [dbo].[hamburguesa] OFF
GO
SET IDENTITY_INSERT [dbo].[ingrediente] ON 
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (1, N'Carne', 250, 1)
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (2, N'Tomate', 100, 1)
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (3, N'Lechuga', 100, 1)
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (4, N'Pepino', 100, 1)
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (5, N'Queso', 100, 1)
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (6, N'Guacamole', 100, 1)
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (1007, N'Cebolla', 100, 1)
GO
INSERT [dbo].[ingrediente] ([id_ingrediente], [nombre], [precio], [activo]) VALUES (1008, N'Papa', 200, 1)
GO
SET IDENTITY_INSERT [dbo].[ingrediente] OFF
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (1, 1008, 1)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (2, 2, 1)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (2, 3, 1)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (1053, 2, 1)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (1053, 1007, 1)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (1054, 1008, 2)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (1055, 2, 3)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (1055, 3, 1)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (1055, 5, 1)
GO
INSERT [dbo].[ingrediente_acompañamiento] ([id_acompañamiento], [id_ingrediente], [cantidad]) VALUES (2043, 1008, 2)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1, 1, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1, 2, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1, 3, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1, 5, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (2, 1, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (2, 2, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (2, 3, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (2, 4, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (2, 5, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (2, 6, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (2, 1007, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (3, 1, 2)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (3, 2, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (3, 3, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (3, 5, 2)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (4, 1, 2)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (4, 2, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (4, 3, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (4, 4, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (4, 5, 2)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (4, 6, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (9, 1, 3)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (9, 2, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (9, 3, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (9, 5, 3)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (9, 1007, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1010, 1, 4)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1010, 2, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1010, 3, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1010, 4, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1010, 5, 3)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1010, 6, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1010, 1007, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1023, 1, 4)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1023, 2, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1023, 3, 1)
GO
INSERT [dbo].[ingrediente_hamburguesa] ([id_hamburguesa], [id_ingrediente], [cantidad]) VALUES (1023, 5, 4)
GO
SET IDENTITY_INSERT [dbo].[venta] ON 
GO
INSERT [dbo].[venta] ([id_venta], [empleado], [fecha_venta]) VALUES (2, 1, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[venta] ([id_venta], [empleado], [fecha_venta]) VALUES (3, 2, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[venta] ([id_venta], [empleado], [fecha_venta]) VALUES (4, 3, CAST(N'1900-01-01T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[venta] OFF
GO
ALTER TABLE [dbo].[acompañamiento] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[combo] ADD  DEFAULT ((0)) FOR [activo]
GO
ALTER TABLE [dbo].[hamburguesa] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[ingrediente] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[combo]  WITH CHECK ADD FOREIGN KEY([detalle])
REFERENCES [dbo].[detalle_combo] ([id_detalle])
GO
ALTER TABLE [dbo].[detalle_combo]  WITH CHECK ADD FOREIGN KEY([acompañamiento])
REFERENCES [dbo].[acompañamiento] ([id_acompañamiento])
GO
ALTER TABLE [dbo].[detalle_combo]  WITH CHECK ADD FOREIGN KEY([bebida])
REFERENCES [dbo].[bebida] ([id_bebida])
GO
ALTER TABLE [dbo].[detalle_combo]  WITH CHECK ADD FOREIGN KEY([hamburguesa])
REFERENCES [dbo].[hamburguesa] ([id_hamburguesa])
GO
ALTER TABLE [dbo].[ingrediente_acompañamiento]  WITH CHECK ADD FOREIGN KEY([id_acompañamiento])
REFERENCES [dbo].[acompañamiento] ([id_acompañamiento])
GO
ALTER TABLE [dbo].[ingrediente_acompañamiento]  WITH CHECK ADD FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[ingrediente] ([id_ingrediente])
GO
ALTER TABLE [dbo].[ingrediente_hamburguesa]  WITH CHECK ADD FOREIGN KEY([id_hamburguesa])
REFERENCES [dbo].[hamburguesa] ([id_hamburguesa])
GO
ALTER TABLE [dbo].[ingrediente_hamburguesa]  WITH CHECK ADD FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[ingrediente] ([id_ingrediente])
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD FOREIGN KEY([empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
