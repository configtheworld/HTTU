CREATE TABLE [dbo].[tableSignAndLog] (
    [Username]  NVARCHAR (50)  NOT NULL,
    [Country]   NVARCHAR (50)  NULL,
    [Provience] NVARCHAR (255) NULL,
    [Password]  NVARCHAR (50)  NOT NULL,
    [Lat]       NVARCHAR(50)     NULL,
    [Long]      NVARCHAR(50)     NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);