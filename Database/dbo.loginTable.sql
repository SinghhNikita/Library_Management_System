USE [library]
GO

/****** Object:  Table [dbo].[loginTable]    Script Date: 5/29/2022 6:57:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[loginTable](
	[id] [int] NOT NULL,
	[username] [varchar](150) NOT NULL,
	[pass] [varchar](150) NOT NULL
) ON [PRIMARY]
GO


