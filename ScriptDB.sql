IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Articulos] (
    [Iddt] nvarchar(17) NOT NULL,
    [Nart] int NOT NULL,
    [Carttyp] nvarchar(1) NOT NULL,
    [Codbenef] nvarchar(15) NOT NULL,
    [Cartetamrc] nvarchar(2) NULL,
    [Iespnce] nvarchar(17) NOT NULL,
    [Cartdesc] nvarchar(500) NOT NULL,
    [Cartpayori] nvarchar(2) NULL,
    [Cartpayacq] nvarchar(2) NULL,
    [Cartpayprc] nvarchar(2) NULL,
    [Iddtapu] nvarchar(17) NULL,
    [Nartapu] int NULL,
    [Qartbul] decimal(18,2) NULL,
    [Martunitar] decimal(18,4) NULL,
    [Cartuntdcl] nvarchar(2) NULL,
    [Qartuntdcl] decimal(18,2) NULL,
    [Cartuntest] nvarchar(2) NULL,
    [Qartuntest] decimal(18,2) NULL,
    [Qartkgrbrt] decimal(18,3) NULL,
    [Qartkgrnet] decimal(18,3) NULL,
    [Martfob] decimal(18,2) NOT NULL,
    [Martfobdol] decimal(18,2) NOT NULL,
    [Martfle] decimal(18,2) NULL,
    [Martass] decimal(18,2) NULL,
    [Martemma] decimal(18,2) NULL,
    [Martfrai] decimal(18,2) NULL,
    [Martajuinc] decimal(18,2) NULL,
    [Martajuded] decimal(18,2) NULL,
    [Martbasimp] decimal(18,2) NULL,
    [Martbasimp2] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Articulos] PRIMARY KEY ([Iddt], [Nart])
);
GO

CREATE TABLE [Declaraciones] (
    [Iddt] nvarchar(17) NOT NULL,
    [Iddtextr] nvarchar(17) NOT NULL,
    [Cddtver] int NOT NULL,
    [Iddtext] nvarchar(17) NOT NULL,
    [Iext] nvarchar(40) NULL,
    [Cddteta] nvarchar(4) NOT NULL,
    [Dddtoficia] datetime2 NOT NULL,
    [Dddtrectifa] datetime2 NULL,
    [Cddtcirvis] nvarchar(1) NULL,
    [Qddttaxchg] decimal(18,2) NOT NULL,
    [Ista] nvarchar(4) NOT NULL,
    [Cddtbur] nvarchar(4) NOT NULL,
    [Cddtburdst] nvarchar(4) NULL,
    [Cddtdep] nvarchar(4) NULL,
    [Cddtentrep] nvarchar(4) NULL,
    [Cddtage] nvarchar(5) NOT NULL,
    [Cddtagr] nvarchar(14) NULL,
    [Lddtagr] nvarchar(100) NULL,
    [Nddtimmioe] nvarchar(14) NOT NULL,
    [Lddtnomioe] nvarchar(100) NOT NULL,
    [Cddtpayori] nvarchar(2) NULL,
    [Cddtpaidst] nvarchar(2) NULL,
    [Lddtnomfod] nvarchar(150) NULL,
    [Cddtincote] nvarchar(3) NULL,
    [Cddtdevfob] nvarchar(3) NOT NULL,
    [Cddtdevfle] nvarchar(3) NULL,
    [Cddtdevass] nvarchar(3) NULL,
    [Cddttransp] nvarchar(5) NULL,
    [Cddtmdetrn] nvarchar(1) NULL,
    [Cddtpaytrn] nvarchar(2) NULL,
    [Nddtart] int NOT NULL,
    [Nddtdelai] int NULL,
    [Dddtbae] datetime2 NULL,
    [Dddtsalida] datetime2 NULL,
    [Dddtcancel] datetime2 NULL,
    [Dddtechean] datetime2 NULL,
    [Cddtobs] nvarchar(500) NULL,
    CONSTRAINT [PK_Declaraciones] PRIMARY KEY ([Iddt])
);
GO

CREATE TABLE [LiquidacionesArticulo] (
    [Iliq] nvarchar(17) NOT NULL,
    [Nart] int NOT NULL,
    [Clqatax] nvarchar(3) NOT NULL,
    [Clqatyp] nvarchar(1) NOT NULL,
    [Mlqabas] decimal(18,4) NOT NULL,
    [Qlqacoefic] decimal(18,6) NOT NULL,
    [Mlqa] decimal(18,4) NOT NULL,
    CONSTRAINT [PK_LiquidacionesArticulo] PRIMARY KEY ([Iliq], [Nart], [Clqatax], [Clqatyp])
);
GO

CREATE TABLE [Liquidaciones] (
    [Iliq] nvarchar(17) NOT NULL,
    [Cliqdop] nvarchar(17) NOT NULL,
    [Cliqeta] nvarchar(3) NOT NULL,
    [Mliq] decimal(18,2) NULL,
    [Mliqgar] decimal(18,2) NULL,
    [Dlippay] datetime2 NULL,
    [Clipnomope] nvarchar(20) NULL,
    [Iddt] nvarchar(17) NULL,
    CONSTRAINT [PK_Liquidaciones] PRIMARY KEY ([Iliq]),
    CONSTRAINT [FK_Liquidaciones_Declaraciones_Iddt] FOREIGN KEY ([Iddt]) REFERENCES [Declaraciones] ([Iddt])
);
GO

CREATE INDEX [IX_Liquidaciones_Iddt] ON [Liquidaciones] ([Iddt]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240805215925_Inicial', N'8.0.7');
GO

COMMIT;
GO

