USE [AngularLogging]

CREATE TABLE [dbo].[ApiLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ErrorMessage] [nvarchar](200) NULL,
 CONSTRAINT [PK_ApiLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


