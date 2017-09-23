IF OBJECT_ID('Item') IS NULL
    EXEC(
		'CREATE TABLE [dbo].[Item](
			[Title] [nvarchar](50) NULL,
			[Content] [nvarchar](max) NULL,
			[Id] [int] IDENTITY(1,1) NOT NULL,
		CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
		(
			[Id] ASC
		)
		)'
	)