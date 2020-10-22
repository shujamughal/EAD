CREATE TABLE [dbo].[Users] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [UserName] NCHAR (10) NULL,
    [Password] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UC_UserName] UNIQUE NONCLUSTERED ([UserName] ASC)
);