CREATE TABLE [dbo].[Bag] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Brand]       NVARCHAR (MAX)  NOT NULL,
    [Model]       NVARCHAR (MAX)  NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Description] NVARCHAR (MAX)  NOT NULL,
    CONSTRAINT [PK_Bag] PRIMARY KEY CLUSTERED ([Id] ASC)
);

