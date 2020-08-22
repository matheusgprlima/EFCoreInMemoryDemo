IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [BoardGames] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(200) NOT NULL,
    [PublishingCompany] varchar(200) NOT NULL,
    [MinPlayers] int NOT NULL,
    [MaxPlayers] int NOT NULL,
    [Price] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_BoardGames] PRIMARY KEY ([Id])
);

GO

CREATE UNIQUE INDEX [IX_BoardGames_Title] ON [BoardGames] ([Title]) WHERE [Title] IS NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200822210424_Initial', N'3.1.7');

GO

