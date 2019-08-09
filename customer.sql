USE [EZPass]
GO

/****** Object:  Table [dbo].[customers]    Script Date: 8/9/2019 12:04:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[customers](
	[Id] [int] NULL,
	[FName] [nvarchar](50) NULL,
	[LName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Telephone] [nvarchar](50) NULL
) ON [PRIMARY]
GO


