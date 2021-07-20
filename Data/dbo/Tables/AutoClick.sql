CREATE TABLE [dbo].[AutoClick]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Quirk] NVARCHAR(50) NOT NULL, 
    [MinimumStrength] INT NOT NULL, 
    [MinimumDurability] INT NOT NULL, 
    [MinimumStamina] INT NOT NULL, 
    [Items] NVARCHAR(500) NOT NULL, 
    [Moves] NVARCHAR(MAX) NOT NULL, 
    [Timing] NVARCHAR(MAX) NOT NULL
)
