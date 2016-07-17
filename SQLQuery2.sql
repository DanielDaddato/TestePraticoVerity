USE [TestePratico]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Produtos];


GO
CREATE TABLE [dbo].[Produtos] (
    [Id]          INT        PRIMARY KEY     IDENTITY (1, 1) NOT NULL,
    [Nome]        NVARCHAR (100)  NOT NULL,
    [Descricao]   NVARCHAR (150)  NULL,
    [Preco]       DECIMAL (18, 2) NOT NULL,
    [Quantidade]  INT             NOT NULL,
    [CategoriaId] INT             NULL
);

ALTER TABLE [dbo].[Produtos]
    ADD CONSTRAINT [FK_Produtos_Categoria] FOREIGN KEY ([CategoriaId]) REFERENCES [dbo].[Categoria] ([Id]);