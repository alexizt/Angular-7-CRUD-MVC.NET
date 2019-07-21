CREATE TABLE [dbo].[EmployeeDetails](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [varchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[EmailId] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[PinCode] [varchar](50) NULL,
 CONSTRAINT [PK_EmployeeDetails] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
