USE [PIT]
GO
/****** Object:  Table [dbo].[user_details]    Script Date: 30/09/2020 7:53:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_details](
	[title] [int] NULL,
	[name] [varchar](100) NOT NULL,
	[surname] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[age] [int] NULL,
	[dob] [varchar](10) NULL,
	[addr_1] [varchar](100) NULL,
	[addr_2] [varchar](100) NULL,
	[town] [varchar](100) NULL,
	[province] [int] NULL,
	[p_code] [varchar](5) NULL,
	[tel_no] [varchar](12) NULL,
	[cel_no] [varchar](12) NOT NULL,
 CONSTRAINT [PK_user_details] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_province]    Script Date: 30/09/2020 7:53:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_province](
	[id] [int] NULL,
	[province] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_title]    Script Date: 30/09/2020 7:53:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_title](
	[id] [int] NULL,
	[title] [varchar](5) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[user_details] ([title], [name], [surname], [email], [age], [dob], [addr_1], [addr_2], [town], [province], [p_code], [tel_no], [cel_no]) VALUES (0, N'Jane', N'Dory', N'jane.dory@hotmail.com', 25, N'1995-01-01', N'12 Keningston Str', N'Queenston', N'Durban', 4, N'6600', N'0319001200', N'0651357980')
GO
INSERT [dbo].[user_details] ([title], [name], [surname], [email], [age], [dob], [addr_1], [addr_2], [town], [province], [p_code], [tel_no], [cel_no]) VALUES (1, N'John', N'Doe', N'johnd@yahoo.com', 30, N'1990-01-01', N'Unit 30 Block A', N'100 Church street', N'Durbanville', 0, N'7500', N'+27219109750', N'+27842835719')
GO
INSERT [dbo].[user_details] ([title], [name], [surname], [email], [age], [dob], [addr_1], [addr_2], [town], [province], [p_code], [tel_no], [cel_no]) VALUES (3, N'Mielie', N'Pieter', N'werewr@yahoo.com', 51, N'1970-01-01', N'Unit test 2', N'15 mielie street', N'Mielieville', 1, N'7500', N'+27834534571', N'+27845634571')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (0, N'Western Cape')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (1, N'Northern Cape')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (2, N'Eastern Cape')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (3, N'Free State')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (4, N'Kwazulu-Natal')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (5, N'North West')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (6, N'Gauteng')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (7, N'Mpumalanga')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (8, N'Limpopo')
GO
INSERT [dbo].[user_province] ([id], [province]) VALUES (9, N'mielie')
GO
INSERT [dbo].[user_title] ([id], [title]) VALUES (0, N'Ms')
GO
INSERT [dbo].[user_title] ([id], [title]) VALUES (1, N'Mr')
GO
INSERT [dbo].[user_title] ([id], [title]) VALUES (2, N'Mrs')
GO
INSERT [dbo].[user_title] ([id], [title]) VALUES (3, N'Dr')
GO
INSERT [dbo].[user_title] ([id], [title]) VALUES (4, N'Prof')
GO
INSERT [dbo].[user_title] ([id], [title]) VALUES (5, N'x')
GO
