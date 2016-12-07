
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/07/2016 09:49:53
-- Generated from EDMX file: C:\Users\itfak\Documents\Visual Studio 2015\Projects\Notes\Database\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [notedb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_NotebookNote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Notes] DROP CONSTRAINT [FK_NotebookNote];
GO
IF OBJECT_ID(N'[dbo].[FK_UserNotebook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Notebooks] DROP CONSTRAINT [FK_UserNotebook];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Notebooks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Notebooks];
GO
IF OBJECT_ID(N'[dbo].[Notes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Notes];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Notebooks'
CREATE TABLE [dbo].[Notebooks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [BackgroundImagePath] nvarchar(max)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Notes'
CREATE TABLE [dbo].[Notes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Remainder] datetime  NULL,
    [Priority] nvarchar(max)  NOT NULL,
    [Color] nvarchar(max)  NULL,
    [NotebookId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Notebooks'
ALTER TABLE [dbo].[Notebooks]
ADD CONSTRAINT [PK_Notebooks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Notes'
ALTER TABLE [dbo].[Notes]
ADD CONSTRAINT [PK_Notes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [NotebookId] in table 'Notes'
ALTER TABLE [dbo].[Notes]
ADD CONSTRAINT [FK_NotebookNote]
    FOREIGN KEY ([NotebookId])
    REFERENCES [dbo].[Notebooks]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NotebookNote'
CREATE INDEX [IX_FK_NotebookNote]
ON [dbo].[Notes]
    ([NotebookId]);
GO

-- Creating foreign key on [UserId] in table 'Notebooks'
ALTER TABLE [dbo].[Notebooks]
ADD CONSTRAINT [FK_UserNotebook]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserNotebook'
CREATE INDEX [IX_FK_UserNotebook]
ON [dbo].[Notebooks]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------