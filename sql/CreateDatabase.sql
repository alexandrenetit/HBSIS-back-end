IF DB_ID(N'HBSIS') IS NULL
BEGIN
	CREATE DATABASE [HBSIS];	
END
GO

USE [HBSIS];

IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
	CREATE TABLE [__EFMigrationsHistory] (
		[MigrationId] nvarchar(150) NOT NULL,
		[ProductVersion] nvarchar(32) NOT NULL,
		CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
	);
END;

IF OBJECT_ID(N'Clientes') IS NULL
BEGIN

	CREATE TABLE [Clientes] (
		[Id] uniqueidentifier NOT NULL,
		[CpfCnpj] nvarchar(14) NOT NULL,
		[Nome] nvarchar(150) NOT NULL,
		[Telefone] nvarchar(14) NOT NULL,
		CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id]),
		CONSTRAINT [AK_Clientes_CpfCnpj] UNIQUE ([CpfCnpj])
	);

	INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
	VALUES (N'' + CONVERT(VARCHAR(20), GETDATE(), 126) + '_Initial', N'1.1.1');

	
END;
GO
