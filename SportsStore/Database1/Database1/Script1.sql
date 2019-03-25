USE [SportsStore]
GO

/****** Object: Table [dbo].[Products] Script Date: 3/25/2019 8:19:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products] (
    [ProductID]   INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100)  NOT NULL,
    [Description] NVARCHAR (500)  NOT NULL,
    [Category]    NVARCHAR (50)   NOT NULL,
    [Price]       DECIMAL (16, 2) NOT NULL
);


