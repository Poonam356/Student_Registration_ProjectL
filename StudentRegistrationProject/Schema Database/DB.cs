//USE [DB_Student_Crud]
//GO
///****** Object:  Table [dbo].[tbl_Student]    Script Date: 02-07-2024 21:22:02 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tbl_Student](
//	[Id] [int] IDENTITY(1,1) NOT NULL,
//	[Name] [varchar](50) NULL,
//	[Father] [varchar](50) NULL,
//	[DOB] [varchar](50) NULL,
//	[Mobile] [varchar](10) NULL,
//	[Email] [varchar](50) NULL,
//	[State] [varchar](50) NULL,
//	[District] [varchar](50) NULL,
//	[Address] [varchar](50) NULL,
//	[Class] [varchar](50) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
//SET IDENTITY_INSERT [dbo].[tbl_Student] ON 
//GO
//INSERT [dbo].[tbl_Student] ([Id], [Name], [Father], [DOB], [Mobile], [Email], [State], [District], [Address], [Class]) VALUES (1, N'Poonam', N'Shiv', N'2024-07-04', N'6789543676', N'admin@gmail.com', N' UttarPradesh', N'Lucknow', N'lucknow', N'2nd')
//GO
//INSERT [dbo].[tbl_Student] ([Id], [Name], [Father], [DOB], [Mobile], [Email], [State], [District], [Address], [Class]) VALUES (2, N'test', N'test2', N'2024-07-12', N'6789543678', N'User@gmail.com', N' UttarPradesh', N'Basti', N'lucknow', N'4th')
//GO
//INSERT [dbo].[tbl_Student] ([Id], [Name], [Father], [DOB], [Mobile], [Email], [State], [District], [Address], [Class]) VALUES (3, N'Test2', N'Test3', N'2024-07-04', N'6789543678', N'userTest@gmail.com', N'MadhyaPradesh', N'Balrampur', N'Lucknow', N'3rd')
//GO
//SET IDENTITY_INSERT [dbo].[tbl_Student] OFF
//GO
//USE [DB_Student_Crud]
//GO
///****** Object:  Table [dbo].[tbl_Student]    Script Date: 02-07-2024 21:22:02 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tbl_Student](
//	[Id] [int] IDENTITY(1,1) NOT NULL,
//	[Name] [varchar](50) NULL,
//	[Father] [varchar](50) NULL,
//	[DOB] [varchar](50) NULL,
//	[Mobile] [varchar](10) NULL,
//	[Email] [varchar](50) NULL,
//	[State] [varchar](50) NULL,
//	[District] [varchar](50) NULL,
//	[Address] [varchar](50) NULL,
//	[Class] [varchar](50) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Id] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
//SET IDENTITY_INSERT [dbo].[tbl_Student] ON 
//GO
//INSERT [dbo].[tbl_Student] ([Id], [Name], [Father], [DOB], [Mobile], [Email], [State], [District], [Address], [Class]) VALUES (1, N'Poonam', N'Shiv', N'2024-07-04', N'6789543676', N'admin@gmail.com', N' UttarPradesh', N'Lucknow', N'lucknow', N'2nd')
//GO
//INSERT [dbo].[tbl_Student] ([Id], [Name], [Father], [DOB], [Mobile], [Email], [State], [District], [Address], [Class]) VALUES (2, N'test', N'test2', N'2024-07-12', N'6789543678', N'User@gmail.com', N' UttarPradesh', N'Basti', N'lucknow', N'4th')
//GO
//INSERT [dbo].[tbl_Student] ([Id], [Name], [Father], [DOB], [Mobile], [Email], [State], [District], [Address], [Class]) VALUES (3, N'Test2', N'Test3', N'2024-07-04', N'6789543678', N'userTest@gmail.com', N'MadhyaPradesh', N'Balrampur', N'Lucknow', N'3rd')
//GO
//SET IDENTITY_INSERT [dbo].[tbl_Student] OFF
//GO
