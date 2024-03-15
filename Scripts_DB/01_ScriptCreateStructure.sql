USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'PruebaSD')
BEGIN
    CREATE DATABASE PruebaSD;
END
GO

USE [PruebaSD]
GO

CREATE TABLE [dbo].[Usuarios](
	[UsuId] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	CONSTRAINT [PK_Usuarios] PRIMARY KEY ([UsuId])
)
GO