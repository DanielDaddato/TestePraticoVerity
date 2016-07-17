USE [TestePratico]
GO

/****** Object: Table [dbo].[Categoria] Script Date: 17/07/2016 16:50:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categoria] (
    [Id]        INT        Primary key    IDENTITY (1, 1) NOT NULL,
    [Nome]      NVARCHAR (100) NOT NULL,
    [Descricao] NVARCHAR (150) NULL
);

ALTER TABLE [dbo].[Produtos]
    ADD CONSTRAINT [FK_Produtos_Categoria] FOREIGN KEY ([CategoriaId]) REFERENCES [dbo].[Categoria] ([Id]);


