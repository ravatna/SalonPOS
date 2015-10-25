USE [POS_DB_Salon]
GO


CREATE TABLE [dbo].[Level](
	[Code] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Status] [nvarchar](50) NULL,
	[InsertDate] [datetime] NULL,
	[InsertUser] [nvarchar](50) NULL,
	[InsertIP] [nvarchar](50) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdateUser] [nvarchar](50) NULL,
	[LastUpdateIP] [nvarchar](50) NULL,
)




