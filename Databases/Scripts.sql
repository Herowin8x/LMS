USE [LMS]
GO
/****** Object:  Table [dbo].[Holiday]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holiday](
	[holidayID] [nvarchar](6) NOT NULL,
	[holidayName] [text] NOT NULL,
	[holidayDate] [date] NOT NULL,
	[actualDate] [date] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Leave_Allowance]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leave_Allowance](
	[userID] [nvarchar](6) NOT NULL,
	[leaveTypeID] [nvarchar](2) NOT NULL,
	[leaveRemaining] [int] NOT NULL,
	[startedDate] [datetime] NULL,
	[expiredDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Leave_Request]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leave_Request](
	[leaveRequestID] [nvarchar](10) NOT NULL,
	[userID] [nvarchar](6) NOT NULL,
	[leaveTypeID] [nvarchar](2) NOT NULL,
	[fromDate] [datetime] NOT NULL,
	[toDate] [datetime] NOT NULL,
	[isHaftDay] [bit] NULL,
	[isFirstHaft] [bit] NULL,
	[isSecondHaft] [bit] NULL,
	[attachment] [image] NULL,
	[requestStatus] [smallint] NOT NULL,
	[leaveDescription] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permission]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[permissionID] [nvarchar](4) NOT NULL,
	[permissionName] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleID] [int] NOT NULL,
	[roleName] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoleAndPermission]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAndPermission](
	[rolePermissionID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[roleID] [int] NOT NULL,
	[permissionID] [nvarchar](4) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Timming]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timming](
	[timeID] [nvarchar](6) NOT NULL,
	[userID] [nvarchar](6) NOT NULL,
	[day] [datetime] NOT NULL,
	[timeIn] [datetime] NOT NULL,
	[timeOut] [datetime] NOT NULL,
	[manualIn] [datetime] NULL,
	[manualOut] [datetime] NULL,
	[comments] [text] NULL,
	[submit] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Type_Of_Leave]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Of_Leave](
	[leaveTypeID] [nvarchar](2) NOT NULL,
	[name] [text] NOT NULL,
	[description] [text] NOT NULL,
	[allowanceLeave] [int] NOT NULL,
	[isPaid] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 07/05/2016 4:26:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[userID] [nvarchar](6) NOT NULL,
	[holidayID] [nvarchar](6) NOT NULL,
	[firstName] [text] NOT NULL,
	[lastName] [text] NOT NULL,
	[dayOfBirth] [date] NOT NULL,
	[joinDate] [date] NOT NULL,
	[contactPhone] [nvarchar](11) NULL,
	[address] [text] NULL,
	[possition] [text] NOT NULL,
	[level] [nvarchar](3) NOT NULL,
	[emailAddr] [varchar](50) NOT NULL,
	[passWord] [nvarchar](16) NOT NULL,
	[roleId] [int] NULL,
	[approverId] [nvarchar](6) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Holiday] ([holidayID], [holidayName], [holidayDate], [actualDate]) VALUES (N'h1    ', N'Hung Kings Commemoration', CAST(N'2016-04-16' AS Date), CAST(N'2016-03-10' AS Date))
INSERT [dbo].[Holiday] ([holidayID], [holidayName], [holidayDate], [actualDate]) VALUES (N'h2    ', N'Reunification Day ', CAST(N'2016-04-30' AS Date), CAST(N'2016-04-30' AS Date))
INSERT [dbo].[Holiday] ([holidayID], [holidayName], [holidayDate], [actualDate]) VALUES (N'h3    ', N'International Labor Day', CAST(N'2016-05-01' AS Date), CAST(N'2016-05-01' AS Date))
INSERT [dbo].[Leave_Request] ([leaveRequestID], [userID], [leaveTypeID], [fromDate], [toDate], [isHaftDay], [isFirstHaft], [isSecondHaft], [attachment], [requestStatus], [leaveDescription]) VALUES (N'1', N'u2', N'1', CAST(N'2016-05-05 00:00:00.000' AS DateTime), CAST(N'2016-05-06 00:00:00.000' AS DateTime), 0, 0, 0, NULL, 0, N'Des')
INSERT [dbo].[Permission] ([permissionID], [permissionName]) VALUES (N'1', N'RaiseRequest')
INSERT [dbo].[Permission] ([permissionID], [permissionName]) VALUES (N'2', N'ApproveRequest')
INSERT [dbo].[Permission] ([permissionID], [permissionName]) VALUES (N'3', N'ReceiveCCLeaveRequest')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (1, N'Employee')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (2, N'Manager')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (4, N'HR Leave Management')
SET IDENTITY_INSERT [dbo].[RoleAndPermission] ON 

INSERT [dbo].[RoleAndPermission] ([rolePermissionID], [roleID], [permissionID]) VALUES (CAST(1 AS Numeric(18, 0)), 1, N'1')
INSERT [dbo].[RoleAndPermission] ([rolePermissionID], [roleID], [permissionID]) VALUES (CAST(2 AS Numeric(18, 0)), 2, N'2')
INSERT [dbo].[RoleAndPermission] ([rolePermissionID], [roleID], [permissionID]) VALUES (CAST(5 AS Numeric(18, 0)), 2, N'1')
INSERT [dbo].[RoleAndPermission] ([rolePermissionID], [roleID], [permissionID]) VALUES (CAST(4 AS Numeric(18, 0)), 4, N'3')
INSERT [dbo].[RoleAndPermission] ([rolePermissionID], [roleID], [permissionID]) VALUES (CAST(6 AS Numeric(18, 0)), 4, N'1')
INSERT [dbo].[RoleAndPermission] ([rolePermissionID], [roleID], [permissionID]) VALUES (CAST(7 AS Numeric(18, 0)), 4, N'2')
SET IDENTITY_INSERT [dbo].[RoleAndPermission] OFF
INSERT [dbo].[Timming] ([timeID], [userID], [day], [timeIn], [timeOut], [manualIn], [manualOut], [comments], [submit]) VALUES (N't1', N'u1', CAST(N'2016-02-12 00:00:00.000' AS DateTime), CAST(N'2016-02-12 08:00:00.000' AS DateTime), CAST(N'2016-02-12 17:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Timming] ([timeID], [userID], [day], [timeIn], [timeOut], [manualIn], [manualOut], [comments], [submit]) VALUES (N't2', N'u1', CAST(N'2016-02-13 00:00:00.000' AS DateTime), CAST(N'2016-02-13 09:00:00.000' AS DateTime), CAST(N'2016-02-13 17:00:00.000' AS DateTime), NULL, NULL, N'Take Child', NULL)
INSERT [dbo].[Type_Of_Leave] ([leaveTypeID], [name], [description], [allowanceLeave], [isPaid]) VALUES (N'1', N'Annual Leave', N'Annual Leave Desp', 12, 1)
INSERT [dbo].[User] ([userID], [holidayID], [firstName], [lastName], [dayOfBirth], [joinDate], [contactPhone], [address], [possition], [level], [emailAddr], [passWord], [roleId], [approverId]) VALUES (N'u1', N'h1', N'Tuan123', N'Nguyen Dang Hoang', CAST(N'1988-09-24' AS Date), CAST(N'2015-05-11' AS Date), N'0974498893', N'58 Ngo Thoi Nhiem, P17, Q.PN, HCM', N'Developer', N'3', N'hoangtuan24091988@gmail.com', N'123456', 1, N'u2')
INSERT [dbo].[User] ([userID], [holidayID], [firstName], [lastName], [dayOfBirth], [joinDate], [contactPhone], [address], [possition], [level], [emailAddr], [passWord], [roleId], [approverId]) VALUES (N'u2', N'h1', N'An', N'Lam Truong', CAST(N'1992-02-05' AS Date), CAST(N'2013-06-21' AS Date), N'01234567891', N'Can Tho', N'Developer', N'4', N'1570733@hcmut.edu.vn', N'123456', 1, N'u2')
INSERT [dbo].[User] ([userID], [holidayID], [firstName], [lastName], [dayOfBirth], [joinDate], [contactPhone], [address], [possition], [level], [emailAddr], [passWord], [roleId], [approverId]) VALUES (N'u3', N'h1', N'Tien', N'Nguyen Van', CAST(N'1986-07-12' AS Date), CAST(N'2009-03-09' AS Date), N'0974123456', N'Go Vap', N'Manager', N'8', N'1570712@hcmut.edu.vn', N'123456', 2, NULL)
INSERT [dbo].[User] ([userID], [holidayID], [firstName], [lastName], [dayOfBirth], [joinDate], [contactPhone], [address], [possition], [level], [emailAddr], [passWord], [roleId], [approverId]) VALUES (N'u4', N'h1', N'Thuy', N'Tran', CAST(N'1990-05-12' AS Date), CAST(N'2009-03-09' AS Date), N'0974299443', N'Quan 1', N'Senior HR', N'5', N'tienspkt@gmail.com', N'123456', 4, NULL)
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_HOLIDAY]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[Holiday] ADD  CONSTRAINT [PK_HOLIDAY] PRIMARY KEY NONCLUSTERED 
(
	[holidayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_LEAVE_REQUEST]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[Leave_Request] ADD  CONSTRAINT [PK_LEAVE_REQUEST] PRIMARY KEY NONCLUSTERED 
(
	[leaveRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_PERMISSION]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[Permission] ADD  CONSTRAINT [PK_PERMISSION] PRIMARY KEY NONCLUSTERED 
(
	[permissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ROLE]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [PK_ROLE] PRIMARY KEY NONCLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ROLEANDPERMISSION]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[RoleAndPermission] ADD  CONSTRAINT [PK_ROLEANDPERMISSION] PRIMARY KEY NONCLUSTERED 
(
	[rolePermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_TIMMING]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[Timming] ADD  CONSTRAINT [PK_TIMMING] PRIMARY KEY NONCLUSTERED 
(
	[timeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_TYPE_OF_LEAVE]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[Type_Of_Leave] ADD  CONSTRAINT [PK_TYPE_OF_LEAVE] PRIMARY KEY NONCLUSTERED 
(
	[leaveTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_USER]    Script Date: 07/05/2016 4:26:17 CH ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [PK_USER] PRIMARY KEY NONCLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Leave_Allowance]  WITH CHECK ADD  CONSTRAINT [FK_LEAVE_AL_TYPE AND _TYPE_OF_] FOREIGN KEY([leaveTypeID])
REFERENCES [dbo].[Type_Of_Leave] ([leaveTypeID])
GO
ALTER TABLE [dbo].[Leave_Allowance] CHECK CONSTRAINT [FK_LEAVE_AL_TYPE AND _TYPE_OF_]
GO
ALTER TABLE [dbo].[Leave_Allowance]  WITH CHECK ADD  CONSTRAINT [FK_Leave_Allowance_User] FOREIGN KEY([userID])
REFERENCES [dbo].[User] ([userID])
GO
ALTER TABLE [dbo].[Leave_Allowance] CHECK CONSTRAINT [FK_Leave_Allowance_User]
GO
ALTER TABLE [dbo].[Leave_Request]  WITH CHECK ADD  CONSTRAINT [FK_LEAVE_RE_RAISE LEA_USER] FOREIGN KEY([userID])
REFERENCES [dbo].[User] ([userID])
GO
ALTER TABLE [dbo].[Leave_Request] CHECK CONSTRAINT [FK_LEAVE_RE_RAISE LEA_USER]
GO
ALTER TABLE [dbo].[Leave_Request]  WITH CHECK ADD  CONSTRAINT [FK_LEAVE_RE_TYPE OF L_TYPE_OF_] FOREIGN KEY([leaveTypeID])
REFERENCES [dbo].[Type_Of_Leave] ([leaveTypeID])
GO
ALTER TABLE [dbo].[Leave_Request] CHECK CONSTRAINT [FK_LEAVE_RE_TYPE OF L_TYPE_OF_]
GO
ALTER TABLE [dbo].[RoleAndPermission]  WITH CHECK ADD  CONSTRAINT [FK_ROLEANDP_HAVE IN R_PERMISSI] FOREIGN KEY([permissionID])
REFERENCES [dbo].[Permission] ([permissionID])
GO
ALTER TABLE [dbo].[RoleAndPermission] CHECK CONSTRAINT [FK_ROLEANDP_HAVE IN R_PERMISSI]
GO
ALTER TABLE [dbo].[RoleAndPermission]  WITH CHECK ADD  CONSTRAINT [FK_ROLEANDP_PERMISSIO_ROLE] FOREIGN KEY([roleID])
REFERENCES [dbo].[Role] ([roleID])
GO
ALTER TABLE [dbo].[RoleAndPermission] CHECK CONSTRAINT [FK_ROLEANDP_PERMISSIO_ROLE]
GO
ALTER TABLE [dbo].[Timming]  WITH CHECK ADD  CONSTRAINT [FK_TIMMING_TIMING_USER] FOREIGN KEY([userID])
REFERENCES [dbo].[User] ([userID])
GO
ALTER TABLE [dbo].[Timming] CHECK CONSTRAINT [FK_TIMMING_TIMING_USER]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_USER_MODIFY PU_HOLIDAY] FOREIGN KEY([holidayID])
REFERENCES [dbo].[Holiday] ([holidayID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_USER_MODIFY PU_HOLIDAY]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[Role] ([roleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
