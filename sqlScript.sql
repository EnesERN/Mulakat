USE [Mulakat]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19.03.2021 16:55:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 19.03.2021 16:55:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[ID] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Year] [nvarchar](max) NULL,
	[Poster] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 19.03.2021 16:55:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [uniqueidentifier] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210319085928_Initial', N'5.0.4')
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'a8e0937a-b77c-43c2-8e43-35c944d291ca', N'The Lego Batman Movie', N'2018', N'https://m.media-amazon.com/images/M/MV5BOTY4YjI2N2MtYmFlMC00ZjcyLTg3YjEtMDQyM2ZjYzQ5YWFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3562656' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T16:44:48.3232973' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'4f886738-f6ec-43a4-9879-491ce28284b0', N'Batman v Superman: Dawn of Justice', N'2016', N'https://m.media-amazon.com/images/M/MV5BYThjYzcyYzItNTVjNy00NDk0LTgwMWQtYjMwNmNlNWJhMzMyXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3561263' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3561289' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'b334a170-3323-42b9-9091-5d9a96a66650', N'Batman: Under the Red Hood', N'2010', N'https://m.media-amazon.com/images/M/MV5BNmY4ZDZjY2UtOWFiYy00MjhjLThmMjctOTQ2NjYxZGRjYmNlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3562783' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3562784' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'f774677b-9f72-4de5-8857-5e969259b5ec', N'Batman: The Dark Knight Returns, Part 1', N'2012', N'https://m.media-amazon.com/images/M/MV5BMzIxMDkxNDM2M15BMl5BanBnXkFtZTcwMDA5ODY1OQ@@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3564063' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3564069' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'280073c1-b23f-4fd4-9cb4-7833407df3f6', N'Batman', N'1989', N'https://m.media-amazon.com/images/M/MV5BMTYwNjAyODIyMF5BMl5BanBnXkFtZTYwNDMwMDk2._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3561598' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3561601' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'e8940858-8af4-4139-86cd-dde9a1aab0c7', N'Batman: The Animated Series', N'1992–1995', N'https://m.media-amazon.com/images/M/MV5BOTM3MTRkZjQtYjBkMy00YWE1LTkxOTQtNDQyNGY0YjYzNzAzXkEyXkFqcGdeQXVyOTgwMzk1MTA@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3562741' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3562742' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'43155072-0b94-4c98-a718-e05e01095d17', N'Batman Begins', N'2005', N'https://m.media-amazon.com/images/M/MV5BOTY4YjI2N2MtYmFlMC00ZjcyLTg3YjEtMDQyM2ZjYzQ5YWFkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3389119' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3389150' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'5ee056a4-a047-4a2f-b29f-f2cd27305d7e', N'Batman Forever', N'1995', N'https://m.media-amazon.com/images/M/MV5BNDdjYmFiYWEtYzBhZS00YTZkLWFlODgtY2I5MDE0NzZmMDljXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3562604' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3562610' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[Movie] ([ID], [Title], [Year], [Poster], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'09958524-27dd-44e3-b792-fd1d9e8b148a', N'Batman & Robin', N'1997', N'https://m.media-amazon.com/images/M/MV5BMGQ5YTM1NmMtYmIxYy00N2VmLWJhZTYtN2EwYTY3MWFhOTczXkEyXkFqcGdeQXVyNTA2NTI0MTY@._V1_SX300.jpg', CAST(N'2021-03-19T11:59:28.3561693' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T11:59:28.3561695' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
INSERT [dbo].[User] ([ID], [Email], [Password], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (N'6b16af6b-ac88-eb11-8f8e-acd564c5c768', N'deneme@mail.com', N'77144181801671221493621411721821012450118171875229232', CAST(N'2021-03-19T15:12:48.3851545' AS DateTime2), N'00000000-0000-0000-0000-000000000000', CAST(N'2021-03-19T15:12:48.3867587' AS DateTime2), N'00000000-0000-0000-0000-000000000000', 1, 0)
ALTER TABLE [dbo].[Movie] ADD  DEFAULT (newsequentialid()) FOR [ID]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT (newsequentialid()) FOR [ID]
GO
