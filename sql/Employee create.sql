USE [OfficeDB]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 30-May-18 10:34:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](50) NULL,
	[Office] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Salary] [int] NULL,
 CONSTRAINT [PK_EmployeeList] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

