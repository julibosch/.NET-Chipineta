USE [db_club]
GO

/****** Object:  Table [dbo].[personas]    Script Date: 7/8/2023 3:53:34 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[personas](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


