CREATE TABLE [dbo].[Atomiser]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[MinWatt] INT NOT NULL, 
	[MaxWatt] INT NOT NULL,
	[Brand] VARCHAR(50),
	[Ml] int NOT NULL,
	[Resistance] FLOAT NOT NULL
)
