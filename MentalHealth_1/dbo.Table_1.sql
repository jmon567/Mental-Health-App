CREATE TABLE [dbo].[Mood]
(
	[Date] SMALLDATETIME NOT NULL PRIMARY KEY, 
    [Happiness] INT NULL, 
    [Motivation] INT NULL, 
    [Depression] INT NULL, 
    [Anxiety] INT NULL, 
    [Contentment] INT NULL
)
