CREATE TABLE [dbo].[Montage]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[BoxId] INT NULL REFERENCES Box(Id),
	[AtomiserId] INT NULL REFERENCES Atomiser(Id),
	[Nickname] VARCHAR(50) NULL
)
