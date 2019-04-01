
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/31/2019 14:19:49
-- Generated from EDMX file: C:\Xamarin\Projects\h2controdemo\h2controdemo\CapaDatos\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbh2control];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ENCARGADOSROLES]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ENCARGADOSSet] DROP CONSTRAINT [FK_ENCARGADOSROLES];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOSPAGOS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAGOS] DROP CONSTRAINT [FK_USUARIOSPAGOS];
GO
IF OBJECT_ID(N'[dbo].[FK_PAGOSENCARGADOS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAGOS] DROP CONSTRAINT [FK_PAGOSENCARGADOS];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ENCARGADOSSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ENCARGADOSSet];
GO
IF OBJECT_ID(N'[dbo].[ROLESSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ROLESSet];
GO
IF OBJECT_ID(N'[dbo].[USUARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOS];
GO
IF OBJECT_ID(N'[dbo].[PAGOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PAGOS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ENCARGADOSSet'
CREATE TABLE [dbo].[ENCARGADOSSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NOMBRES] nvarchar(35)  NOT NULL,
    [APELLIDOS] nvarchar(70)  NOT NULL,
    [USUARIO] nchar(3)  NOT NULL,
    [PASSWORD] nvarchar(8)  NOT NULL,
    [FECHAALTA] datetime  NOT NULL,
    [FECHAMODIFICACION] datetime  NOT NULL,
    [ROLESId] int  NOT NULL,
    [DIRECCION] nvarchar(125)  NULL,
    [TELEFONO] nvarchar(10)  NOT NULL,
    [CORREO] nvarchar(125)  NOT NULL
);
GO

-- Creating table 'ROLESSet'
CREATE TABLE [dbo].[ROLESSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NOMBRE] nvarchar(35)  NOT NULL
);
GO

-- Creating table 'USUARIOS'
CREATE TABLE [dbo].[USUARIOS] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FOLIO] nchar(9)  NOT NULL,
    [NOMBRES] nvarchar(35)  NOT NULL,
    [APELLIDOS] nvarchar(70)  NOT NULL,
    [DOMICILIO] nvarchar(125)  NOT NULL,
    [TELEFONO] nchar(10)  NOT NULL,
    [EMAIL] nvarchar(75)  NULL,
    [NOTOMAS] int  NOT NULL,
    [FECHAALTA] datetime  NOT NULL,
    [FECHAMODIFICACION] datetime  NOT NULL,
    [ENCARGADOSId] int  NOT NULL
);
GO

-- Creating table 'PAGOS'
CREATE TABLE [dbo].[PAGOS] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FOLIO] nchar(13)  NOT NULL,
    [TARIFA] decimal(10,2)  NOT NULL,
    [FECHAPAGO] datetime  NOT NULL,
    [IMPORTE] decimal(10,2)  NOT NULL,
    [USUARIOSId] int  NOT NULL,
    [ENCARGADOSId] int  NOT NULL,
    [PERIODO] nvarchar(35)  NOT NULL,
    [RETARDO] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ENCARGADOSSet'
ALTER TABLE [dbo].[ENCARGADOSSet]
ADD CONSTRAINT [PK_ENCARGADOSSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ROLESSet'
ALTER TABLE [dbo].[ROLESSet]
ADD CONSTRAINT [PK_ROLESSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'USUARIOS'
ALTER TABLE [dbo].[USUARIOS]
ADD CONSTRAINT [PK_USUARIOS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PAGOS'
ALTER TABLE [dbo].[PAGOS]
ADD CONSTRAINT [PK_PAGOS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ROLESId] in table 'ENCARGADOSSet'
ALTER TABLE [dbo].[ENCARGADOSSet]
ADD CONSTRAINT [FK_ENCARGADOSROLES]
    FOREIGN KEY ([ROLESId])
    REFERENCES [dbo].[ROLESSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ENCARGADOSROLES'
CREATE INDEX [IX_FK_ENCARGADOSROLES]
ON [dbo].[ENCARGADOSSet]
    ([ROLESId]);
GO

-- Creating foreign key on [USUARIOSId] in table 'PAGOS'
ALTER TABLE [dbo].[PAGOS]
ADD CONSTRAINT [FK_USUARIOSPAGOS]
    FOREIGN KEY ([USUARIOSId])
    REFERENCES [dbo].[USUARIOS]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOSPAGOS'
CREATE INDEX [IX_FK_USUARIOSPAGOS]
ON [dbo].[PAGOS]
    ([USUARIOSId]);
GO

-- Creating foreign key on [ENCARGADOSId] in table 'PAGOS'
ALTER TABLE [dbo].[PAGOS]
ADD CONSTRAINT [FK_PAGOSENCARGADOS]
    FOREIGN KEY ([ENCARGADOSId])
    REFERENCES [dbo].[ENCARGADOSSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PAGOSENCARGADOS'
CREATE INDEX [IX_FK_PAGOSENCARGADOS]
ON [dbo].[PAGOS]
    ([ENCARGADOSId]);
GO

-- Creating foreign key on [ENCARGADOSId] in table 'USUARIOS'
ALTER TABLE [dbo].[USUARIOS]
ADD CONSTRAINT [FK_ENCARGADOSUSUARIOS]
    FOREIGN KEY ([ENCARGADOSId])
    REFERENCES [dbo].[ENCARGADOSSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ENCARGADOSUSUARIOS'
CREATE INDEX [IX_FK_ENCARGADOSUSUARIOS]
ON [dbo].[USUARIOS]
    ([ENCARGADOSId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------