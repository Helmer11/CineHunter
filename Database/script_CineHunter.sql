USE [HunterDB]
GO
/****** Object:  Table [dbo].[Actores]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actores](
	[Actor_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Completo] [varchar](100) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Foto] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Actor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[Genero_id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Genero_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[Pelicula_id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Anio] [date] NOT NULL,
	[Fecha_Estreno] [datetime] NOT NULL,
	[ImagenPelicula] [varchar](100) NULL,
	[ActorID] [int] NOT NULL,
	[GeneroID] [tinyint] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK__Pelicula__C5BC7D10C17C88B0] PRIMARY KEY CLUSTERED 
(
	[Pelicula_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actores] ON 

INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (2, N'Adam Brody', CAST(N'1979-12-15' AS Date), N'M', N'foto.jpg', 1)
INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (3, N'Alejandro Goic', CAST(N'2023-04-05' AS Date), N'M', N'C:\Users\hys-1\Downloads\alejadro.jpg', 1)
INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (4, N'Anna Lore', CAST(N'1985-07-11' AS Date), N'F', N'C:\Users\hys-1\Downloads\Anna.jpg', 1)
INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (5, N'taz de tzmania', CAST(N'2023-03-29' AS Date), N'M', N'C:\Users\hys-1\Downloads\taz.jpg', 1)
INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (6, N'Carabela carabela', CAST(N'2023-03-27' AS Date), N'F', N'C:\practicas_y\CineHunter_Test\CineHunter\images_Actores', 1)
INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (7, N'Natali', CAST(N'2023-04-04' AS Date), N'F', N'C:\practicas_y\CineHunter_Test\CineHunter\bin\Debug\images_Actores\', 1)
INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (8, N'Flan', CAST(N'2023-03-28' AS Date), N'F', N'C:\practicas_y\CineHunter_Test\CineHunter\bin\Debug\images_Peliculas\Flan.jpg', 1)
INSERT [dbo].[Actores] ([Actor_id], [Nombre_Completo], [Fecha_Nacimiento], [Sexo], [Foto], [Estado]) VALUES (9, N'Viejo Agrio', CAST(N'2023-03-28' AS Date), N'F', N'C:\practicas_y\CineHunter_Test\CineHunter\bin\Debug\images_Peliculas\Viejo Agrio.jpg', 1)
SET IDENTITY_INSERT [dbo].[Actores] OFF
SET IDENTITY_INSERT [dbo].[Generos] ON 

INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (1, N'Accion', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (2, N'Aventura', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (3, N'Ciencia Ficcion', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (4, N'Comedia', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (5, N'No-Ficcion', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (6, N'Drama', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (7, N'Fantasia', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (8, N'Musical', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (9, N'Suspenso', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (10, N'Terror', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (11, N'Cine Mudo', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (12, N'Cinema sonoro', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (13, N'Cine 2D', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (14, N'Cine 3D', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (15, N'Animacion', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (16, N'Religiosa', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (17, N'Futurista', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (18, N'Policiaca', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (19, N'Crime', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (20, N'Deportiva', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (21, N'Belica', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (22, N'Western', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (23, N'Erótico', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (24, N'Melodrama', 1)
INSERT [dbo].[Generos] ([Genero_id], [Descripcion], [Estado]) VALUES (25, N'Policíaco', 1)
SET IDENTITY_INSERT [dbo].[Generos] OFF
SET IDENTITY_INSERT [dbo].[Peliculas] ON 

INSERT [dbo].[Peliculas] ([Pelicula_id], [Titulo], [Descripcion], [Anio], [Fecha_Estreno], [ImagenPelicula], [ActorID], [GeneroID], [Estado]) VALUES (3, N'¡Shazam! La furia de los dioses', N'Billy Batson y sus hermanos adoptivos, que se transforman en superhéroes al decir “¡Shazam!”, se ven obligados a volver a la acción y luchar contra las Hijas de Atlas, a quienes deben evitar que use u', CAST(N'2023-03-26' AS Date), CAST(N'2023-04-12T23:55:14.000' AS DateTime), NULL, 2, 1, 1)
INSERT [dbo].[Peliculas] ([Pelicula_id], [Titulo], [Descripcion], [Anio], [Fecha_Estreno], [ImagenPelicula], [ActorID], [GeneroID], [Estado]) VALUES (4, N'Shazan2023', N'Billy Batson y sus hermanos adoptivos, que se transforman en superhéroes al decir “¡Shazam!”, se ven obligados a volver a la acción y luchar contra las Hijas de Atlas, a quienes deben evitar que use u', CAST(N'2023-04-11' AS Date), CAST(N'2023-04-11T03:28:11.990' AS DateTime), N'C:\practicas_y\CineHunter_Test\CineHunter\bin\Debug\images_Peliculas\Shazan2023.jpg', 2, 1, 1)
INSERT [dbo].[Peliculas] ([Pelicula_id], [Titulo], [Descripcion], [Anio], [Fecha_Estreno], [ImagenPelicula], [ActorID], [GeneroID], [Estado]) VALUES (5, N'Taz grita', N'Ejemplo de pelicula', CAST(N'2023-03-29' AS Date), CAST(N'2023-03-29T03:41:24.000' AS DateTime), N'C:\practicas_y\CineHunter_Test\CineHunter\bin\Debug\images_Peliculas\Taz grita.jpg', 6, 18, 1)
SET IDENTITY_INSERT [dbo].[Peliculas] OFF
ALTER TABLE [dbo].[Actores] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Generos] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Peliculas] ADD  CONSTRAINT [DF__Peliculas__Estad__4F7CD00D]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [FK__Peliculas__Actor__5165187F] FOREIGN KEY([ActorID])
REFERENCES [dbo].[Actores] ([Actor_id])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [FK__Peliculas__Actor__5165187F]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [FK__Peliculas__Gener__5070F446] FOREIGN KEY([GeneroID])
REFERENCES [dbo].[Generos] ([Genero_id])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [FK__Peliculas__Gener__5070F446]
GO
/****** Object:  StoredProcedure [dbo].[sp_Agregar_Actores]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[sp_Agregar_Actores]
(
@Nombre_Completo varchar(100),
@Fecha_Nacimiento date,
@Sexo char(1),
@Foto varchar(100)
)
As
Begin 

INSERT INTO [dbo].[Actores]
           ([Nombre_Completo]
           ,[Fecha_Nacimiento]
           ,[Sexo]
           ,[Foto]
           )
     VALUES
           (
		   @Nombre_Completo,   
			@Fecha_Nacimiento,
			@Sexo,
			@Foto
		   )

End
GO
/****** Object:  StoredProcedure [dbo].[sp_Agregar_Genero]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[sp_Agregar_Genero]
(

@Descripcion varchar(50)
)
As
begin 

INSERT INTO [dbo].[Generos]
           (
		   [Descripcion]
           )
     VALUES
           (
		   @Descripcion
           )
End


GO
/****** Object:  StoredProcedure [dbo].[sp_Agregar_Peliculas]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[sp_Agregar_Peliculas]
(
@Titulo varchar(50),
@Descripcion varchar(200),
@Anio date, 
@Fecha_Estreno datetime, 
@ImagenPelicula varchar(100),
@ActorID int, 
@GeneroID int 
)
As
begin 

INSERT INTO [dbo].[Peliculas]
           (
		   [Titulo]
           ,[Descripcion]
           ,[Anio]
           ,[Fecha_Estreno]
		   ,[ImagenPelicula]
           ,[ActorID]
           ,[GeneroID]
		   )
     VALUES
           (
			@Titulo ,
			@Descripcion,
			@Anio , 
			@Fecha_Estreno, 
			@ImagenPelicula,
			@ActorID , 
			@GeneroID  
)

End
GO
/****** Object:  StoredProcedure [dbo].[sp_Cargar_Actores]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[sp_Cargar_Actores]

As
Begin 

SELECT [Actor_id]
      ,[Nombre_Completo]
  FROM [dbo].[Actores]
	Where Estado = 1



End
GO
/****** Object:  StoredProcedure [dbo].[sp_Cargar_Genero]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[sp_Cargar_Genero]
As
Begin 

Select 
Genero_id,
Descripcion

From Generos
where Estado = 1

End
GO
/****** Object:  StoredProcedure [dbo].[sp_Cargar_Pelicula]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--sp_Cargar_Pelicula 
CREATE procedure [dbo].[sp_Cargar_Pelicula]
(
@Titulo varchar(5) = int
)
As 
Begin 

Select 
 p.Pelicula_id,
 p.Titulo,
 p.Descripcion as Sinopsis,
 p.Anio as 'Años',
 p.Fecha_Estreno,
 p.ImagenPelicula,
 a.Nombre_Completo,
 g.Descripcion As Genero
From Peliculas p with(Nolock)
inner join Actores a with(Nolock)
On p.ActorID = a.Actor_id
inner join Generos g
On p.GeneroID = g.Genero_id
Where p.Titulo like '%'+ @Titulo + '%' 
and p.Estado = 1
and a.Estado = 1
order by p.Pelicula_id 
End 
GO
/****** Object:  StoredProcedure [dbo].[sp_Detalle_Actor]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--[dbo].[sp_Detalle_Actor] 8
CREATE procedure [dbo].[sp_Detalle_Actor]
(
@Actor_id int
)
As
Begin 

select
Actor_id,
Nombre_Completo,
Fecha_Nacimiento,
Sexo,
Foto
From 
[dbo].[Actores]
Where Actor_id = @Actor_id
and Estado = 1
End
GO
/****** Object:  StoredProcedure [dbo].[sp_Detalle_Pelicula]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[sp_Detalle_Pelicula]
(
@Pelicula_id int
)
As
Begin 


Select 
p.Pelicula_id,
p.Titulo,
p.Descripcion as Sipnosis,
p.Anio,
p.Fecha_Estreno,
p.ImagenPelicula,
a.Nombre_Completo,
g.Descripcion as Genero
From Peliculas p with(Nolock)
inner join Actores a with(Nolock)
On p.ActorID = a.Actor_id
inner join Generos g 
on p.GeneroID = g.Genero_id
Where p.Pelicula_id = @Pelicula_id and p.Estado = 1 and a.Estado =1
order by p.Pelicula_id
End
GO
/****** Object:  StoredProcedure [dbo].[sp_Edita_Actores]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[sp_Edita_Actores]
(
@Actor_id int,
@Nombre_Completo varchar(100),
@Fecha_Nacimiento date,
@Sexo char(1),
@Foto varchar(100)
)
As 
Begin 

Update Actores
		Set Nombre_Completo = @Nombre_Completo,
			Fecha_Nacimiento = @Fecha_Nacimiento,
			Sexo = @Sexo,
			Foto = @Foto
			Where Actor_id = @Actor_id and Estado = 1

			End 
GO
/****** Object:  StoredProcedure [dbo].[sp_Edita_Peliculas]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




Create procedure [dbo].[sp_Edita_Peliculas]
(
@Pelicula_id int,
@Titulo varchar(50),
@Descripcion varchar(200),
@Anio date, 
@Fecha_Estreno datetime, 
@ActorID int, 
@GeneroID int 
)
As
Begin 

Update Peliculas 
		Set Titulo = @Titulo,
		    Descripcion = @Descripcion,
			Anio= @Anio,
			Fecha_Estreno = @Fecha_Estreno,
			ActorID = @ActorID,
			GeneroID = @GeneroID
			
			Where Pelicula_id = @Pelicula_id 


End
GO
/****** Object:  StoredProcedure [dbo].[sp_Inactivar_Actores]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[sp_Inactivar_Actores]
(
@Actor_id int
)
As 
Begin 

Update Actores
		Set Estado = 0
			Where Actor_id = @Actor_id 

			End 
GO
/****** Object:  StoredProcedure [dbo].[sp_Inactivar_Genero]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create procedure [dbo].[sp_Inactivar_Genero]
(
@Genero_id int
)
As 
Begin 

Update Generos
		Set Estado = 0
			Where Genero_id = @Genero_id 

			End 
GO
/****** Object:  StoredProcedure [dbo].[sp_Inactivar_Peliculas]    Script Date: 4/11/2023 7:47:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[sp_Inactivar_Peliculas]
(
@Pelicula_id int
)
As
Begin 

Update Peliculas 
		Set Estado = 0
			
			Where Pelicula_id = @Pelicula_id 


End
GO
