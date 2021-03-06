USE [Class student]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 10/25/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[name] [nvarchar](50) NULL,
	[password] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 10/25/2020 11:02:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[studentid] [int] NULL,
	[Data] [date] NULL,
	[attendanceid] [int] IDENTITY(1,1) NOT NULL,
	[Attendance] [nvarchar](50) NULL,
	[student name] [nvarchar](50) NULL,
	[data Attendance] [nvarchar](max) NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[attendanceid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[class]    Script Date: 10/25/2020 11:02:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class](
	[class name] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[seat] [int] NOT NULL,
	[level id] [int] NOT NULL,
 CONSTRAINT [PK_class] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Level]    Script Date: 10/25/2020 11:02:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Level](
	[leval name] [nvarchar](max) NULL,
	[level id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED 
(
	[level id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 10/25/2020 11:02:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[student name] [nvarchar](max) NULL,
	[studentid] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[mobile] [int] NULL,
	[age] [int] NULL,
	[address] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[username] [nvarchar](max) NULL,
	[password] [int] NULL,
	[comfirm password] [int] NULL,
	[photo] [image] NULL,
	[level id] [int] NULL,
	[id] [int] NULL,
	[data] [date] NULL,
	[idi] [int] NULL,
	[student data] [nvarchar](max) NULL,
	[attendanceid] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[studentid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 10/25/2020 11:02:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[teacher name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[mobile] [int] NULL,
	[addres] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[cender] [nvarchar](max) NULL,
	[photo] [image] NULL,
	[user name] [nvarchar](max) NULL,
	[password] [int] NULL,
	[comfer password] [int] NULL,
	[leval id] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([name], [password], [id]) VALUES (N'omar', 12345, 1)
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Attendance] ON 

INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (2, CAST(N'2020-05-19' AS Date), 1, N'2', NULL, N'2020-05-21')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (4, CAST(N'2020-05-12' AS Date), 2, N'1', N'omar', NULL)
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (5, CAST(N'2020-06-03' AS Date), 3, N'1', N'undefined', N'2020-05-14')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (6, CAST(N'2020-05-20' AS Date), 4, N'1', N'undefined', NULL)
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (7, CAST(N'2020-05-19' AS Date), 5, N'1', NULL, NULL)
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (10, CAST(N'2020-05-28' AS Date), 6, N'1', NULL, NULL)
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (16, CAST(N'2020-05-13' AS Date), 7, N'2', NULL, N'2020-04-6')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (8, CAST(N'2020-05-18' AS Date), 8, N'2', NULL, N'06/04/2020
')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (10, CAST(N'2020-05-18' AS Date), 9, N'1', NULL, N'06/04/2020
')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (5, CAST(N'2020-05-20' AS Date), 10, N'2', NULL, N'2020-06-04')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (16, CAST(N'2020-05-25' AS Date), 11, N'1', NULL, N'2020-06-04')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (5, CAST(N'2020-06-11' AS Date), 12, N'1', NULL, N'2020-06-04')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (16, NULL, 13, N'2', NULL, N'2020-06-04')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (9, NULL, 14, N'1', NULL, N'2020-06-04')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (20, NULL, 15, NULL, NULL, NULL)
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (9, NULL, 16, N'1', NULL, N'2020-10-17')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (22, NULL, 17, N'2', NULL, N'2020-10-17')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (23, NULL, 18, N'1', NULL, N'2020-10-17')
INSERT [dbo].[Attendance] ([studentid], [Data], [attendanceid], [Attendance], [student name], [data Attendance]) VALUES (32, NULL, 19, N'1', NULL, N'2020-10-28')
SET IDENTITY_INSERT [dbo].[Attendance] OFF
SET IDENTITY_INSERT [dbo].[class] ON 

INSERT [dbo].[class] ([class name], [id], [seat], [level id]) VALUES (N'lab1', 7, 3, 17)
INSERT [dbo].[class] ([class name], [id], [seat], [level id]) VALUES (N'lab 4', 23, 14, 24)
INSERT [dbo].[class] ([class name], [id], [seat], [level id]) VALUES (N'lab2', 24, 16, 22)
SET IDENTITY_INSERT [dbo].[class] OFF
SET IDENTITY_INSERT [dbo].[Level] ON 

INSERT [dbo].[Level] ([leval name], [level id]) VALUES (N'level_2', 17)
INSERT [dbo].[Level] ([leval name], [level id]) VALUES (N'level_3', 22)
INSERT [dbo].[Level] ([leval name], [level id]) VALUES (N'level_4', 24)
INSERT [dbo].[Level] ([leval name], [level id]) VALUES (N'level_5', 26)
SET IDENTITY_INSERT [dbo].[Level] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'omar mahmoud', 2, N'www.@.gmail.com', NULL, NULL, NULL, NULL, N'omar2', 1234, 1234, NULL, NULL, NULL, NULL, 5, N'2020-05-21', 1)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'omar mahmoud', 4, N'omahhdd', 222222, NULL, N'dndijd', N'jndi', N'omar1', 1234, 1234, NULL, NULL, 7, NULL, 7, NULL, 1)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'omar mahmoud', 5, N'NULLwww.@.gmail.com', 23445, NULL, N'dndijd', N'jndi', N'1', 1111, 1111, NULL, 22, 7, NULL, 8, NULL, 1)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'omar mahmoud', 6, N'mahmoud@gamil.com', NULL, 13, NULL, NULL, N'omar3', 1234, 1234, NULL, 22, 7, NULL, 9, N'2020-05-14', 2)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'omar mahmoud', 7, N'www.@.gmail.comww', NULL, 13, NULL, NULL, N'omar4', 1234, 1234, NULL, 22, 7, NULL, 10, NULL, 2)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N' mahmoud', 8, NULL, NULL, 13, NULL, NULL, N'omar5', 1234, 1234, NULL, 13, 16, NULL, 5, NULL, 2)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N' mahmoud1', 9, NULL, NULL, 18, NULL, NULL, N'omar6', 1234, 1234, NULL, 17, 22, NULL, 7, NULL, 2)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'MO', 10, N'mahmoud@gamil.com', NULL, 18, NULL, NULL, N'omar7', 123, 123, NULL, 24, 22, NULL, 8, N'2020-05-21', 2)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N' mahmd1', 11, N'mahmoud@gamil.com', NULL, 18, NULL, NULL, N'omar8', 123, 123, NULL, 26, 22, NULL, 9, NULL, 2)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'AMR', 12, N'omar mahmoud@gamil.com', 1053854597, NULL, N'alix', N'cairo', N'omar0', 12345, 12345, NULL, NULL, NULL, CAST(N'2020-05-21' AS Date), 10, N'2020-05-14', 3)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'Ahmed', 13, N'ahmed.@gamil.com', 1553854597, NULL, N'cairo', N'cairo', N'omar98', 12345, 12345, NULL, NULL, NULL, CAST(N'2020-05-14' AS Date), 11, NULL, 4)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'MWE', 14, N'ahmed.@gamil.com', 1553854597, NULL, N'cairo', N'cairo', N'omar88', 12345, 12345, NULL, NULL, NULL, CAST(N'2020-05-14' AS Date), 11, N'2020-05-15', 5)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'MAHAMED', 15, N'ahmed.@gamil.com', 1553854597, NULL, N'cairo', N'cairo', N'n', 12345, 12345, NULL, 24, 22, CAST(N'2020-05-14' AS Date), 12, NULL, 5)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'SABER', 16, N'mahmoud@gamil.com', 102373456, NULL, N'cairo', N'cairo', N'nnn', 12345, 12345, NULL, 22, 16, CAST(N'2020-05-21' AS Date), 12, N'2020-06-04', 4)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'Salma', 17, N'omar.@gamil.com', 1553854597, NULL, N'cairo', N'cairo', N'nnnn', 12345, 12345, NULL, 24, 22, CAST(N'2020-05-15' AS Date), 12, N'2020-05-15', 5)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'Ramize', 18, N'Ramize.@gamil.com', 13894845, NULL, N'alex', N'cairo', N'Ramnize', 12345, 12345, NULL, 13, 22, CAST(N'2020-05-15' AS Date), 12, NULL, 4)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'ahmed', 19, N'www.@.gmail.com', 102373456, NULL, N'cairo', N'cairo', N'ahmed', 12344, 12344, NULL, 13, 16, CAST(N'2020-05-28' AS Date), 24, N'2020-06-04', 5)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'menna', 20, N'werf.@gamil.com', 4444, NULL, N'cairo4', N'cairo', N'omar', 111, 111, NULL, 13, 22, CAST(N'2020-05-15' AS Date), 24, N'2020-06-04', 6)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (NULL, 21, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 24, N'2020-06-04', 7)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'monna', 22, N'omar.mahmoudnn@gamil.com', 1553854597, NULL, N'cairo', N'cairo', N'omar', 12333, 12333, NULL, 17, 22, NULL, 12, NULL, 8)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'rageb', 23, N'rageb.@gamil.com', 8785754, NULL, N'cairo', N'cairo', N'rageb', 11111, 11111, NULL, 17, 22, NULL, 12, N'2020-06-04', 9)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'adfgsdfghj', 24, N'zxcvbnm,', NULL, NULL, N'm', N'xdddd', N'ddd', 12345, 12345, NULL, 22, 16, NULL, 25, N'0005-12-31', 10)
INSERT [dbo].[Student] ([student name], [studentid], [Email], [mobile], [age], [address], [city], [username], [password], [comfirm password], [photo], [level id], [id], [data], [idi], [student data], [attendanceid]) VALUES (N'sdfghj', 32, N'sdfhj', 1234, NULL, N'sd', N'shjk', N'qwert', 123456, 123456, NULL, 13, 7, NULL, 12, N'2020-07-22', 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N'mahmoud ahmed', N'mahmoud.nm@gamil.com', 102373456, N'liverpool', N'cairo', N'1', NULL, N'omar', 123, 123, 17, 5)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N' ahmedmahmoud', N'mahmoud@gamil.com', 1553854597, N'alex3', N'cairo', N'2', NULL, N'omar', 1234, 1234, 17, 7)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N' mona', N'omar.@gamil.com', 1553854597, N'cs', N'cairo', N'2', NULL, N'omar', 12345, 12345, 24, 8)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N' menna', N'ahmed.@gamil.com', 1553854597, N'cairo', N'cairo', N'1', NULL, N'omar', 12345, 12345, 17, 9)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N'saad', N'mahmoud@gamil.com', 1553854597, N'cairo', N'cairo', N'2', NULL, N'omar', 12345, 12345, 17, 10)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N'saber', N'omar.@gamil.com', 1553854597, N'cairo', N'cairo', N'2', NULL, N'omar', 12345, 12345, 17, 11)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N'mahmoud', N'omar.@gamil.com', 1553854597, N'caaos', N'cairo', N'2', NULL, N'omar', 1234, 1234, NULL, 12)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N'fatma', N'omar.@gamil.com', 102373456, N'ff', N'cairo', N'2', NULL, N'omar', 12345, 12345, 24, 24)
INSERT [dbo].[Teacher] ([teacher name], [Email], [mobile], [addres], [city], [cender], [photo], [user name], [password], [comfer password], [leval id], [id]) VALUES (N'soad', N'mahmoud@gamil.com', 102373456, N'Almunawafia', N'cairo', N'2', NULL, N'omar', 12345, 12345, 22, 25)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Student] FOREIGN KEY([studentid])
REFERENCES [dbo].[Student] ([studentid])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Student]
GO
ALTER TABLE [dbo].[class]  WITH CHECK ADD  CONSTRAINT [FK_class_Level] FOREIGN KEY([level id])
REFERENCES [dbo].[Level] ([level id])
GO
ALTER TABLE [dbo].[class] CHECK CONSTRAINT [FK_class_Level]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Attendance] FOREIGN KEY([attendanceid])
REFERENCES [dbo].[Attendance] ([attendanceid])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Attendance]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Teacher] FOREIGN KEY([idi])
REFERENCES [dbo].[Teacher] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Teacher]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Level] FOREIGN KEY([leval id])
REFERENCES [dbo].[Level] ([level id])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Level]
GO
