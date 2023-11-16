CREATE TABLE [dbo].[Desarrollador](
 [Id_Desarrollador] [int] IDENTITY(1,1) NOT NULL,
 [Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Desarrollador] Primary Key ([Id_Desarrollador])
)
GO

CREATE TABLE [dbo].[Videojuego](
 [Id_Videojuego] [int] IDENTITY(1,1) NOT NULL,
 [Titulo] [nvarchar](100) NOT NULL,
 [Valoracion] [int] NOT NULL,
 [Id_Desarrollador] [int] FOREIGN KEY REFERENCES Desarrollador([Id_Desarrollador]) NOT NULL,
 CONSTRAINT [PK_Videojuego] Primary Key ([Id_Videojuego])
)
GO