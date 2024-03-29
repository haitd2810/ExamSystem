USE [master]
GO
/****** Object:  Database [WinAppTracNghiem]    Script Date: 3/18/2024 2:03:22 PM ******/
CREATE DATABASE [WinAppTracNghiem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WinAppTracNghiem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\WinAppTracNghiem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WinAppTracNghiem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\WinAppTracNghiem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [WinAppTracNghiem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WinAppTracNghiem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WinAppTracNghiem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET ARITHABORT OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WinAppTracNghiem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WinAppTracNghiem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WinAppTracNghiem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WinAppTracNghiem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WinAppTracNghiem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WinAppTracNghiem] SET  MULTI_USER 
GO
ALTER DATABASE [WinAppTracNghiem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WinAppTracNghiem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WinAppTracNghiem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WinAppTracNghiem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WinAppTracNghiem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WinAppTracNghiem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WinAppTracNghiem] SET QUERY_STORE = ON
GO
ALTER DATABASE [WinAppTracNghiem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [WinAppTracNghiem]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[username] [varchar](15) NOT NULL,
	[password] [varchar](15) NULL,
	[Role] [int] NULL,
	[Status] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnswersOfQuestion]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnswersOfQuestion](
	[Question] [int] NOT NULL,
	[Answer] [int] NOT NULL,
	[IsTrue] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Question] ASC,
	[Answer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Code] [varchar](10) NOT NULL,
	[Title] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enroll]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enroll](
	[Username] [varchar](15) NOT NULL,
	[Semester] [varchar](10) NOT NULL,
	[Course] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC,
	[Semester] ASC,
	[Course] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamCode]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamCode](
	[Code] [varchar](50) NOT NULL,
	[Semester] [varchar](10) NULL,
	[Course] [varchar](10) NULL,
	[DateBegin] [date] NULL,
	[TimeBegin] [float] NULL,
	[Long] [int] NULL,
	[Status] [varchar](10) NULL,
	[NumberOfQuestion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Practice]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Practice](
	[username] [varchar](15) NOT NULL,
	[ExamCode] [varchar](50) NOT NULL,
	[TimeBegin] [datetime] NULL,
	[Long] [int] NULL,
	[Mark] [decimal](4, 2) NULL,
	[Status] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC,
	[ExamCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionOfCode]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionOfCode](
	[ExamCode] [varchar](50) NOT NULL,
	[Question] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ExamCode] ASC,
	[Question] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](300) NULL,
	[NumberOfAnswers] [int] NULL,
	[Type] [int] NULL,
	[Course] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semesters]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semesters](
	[Code] [varchar](10) NOT NULL,
	[Year] [int] NULL,
	[beginDate] [date] NULL,
	[endDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfQuestion]    Script Date: 3/18/2024 2:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfQuestion](
	[ID] [int] NOT NULL,
	[Name] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accounts] ([username], [password], [Role], [Status]) VALUES (N'admin', N'Admin123', 1, N'active')
INSERT [dbo].[Accounts] ([username], [password], [Role], [Status]) VALUES (N'haitdhe170242', N'123456', 2, N'active')
INSERT [dbo].[Accounts] ([username], [password], [Role], [Status]) VALUES (N'quanpahe170260', N'123456', 2, N'active')
INSERT [dbo].[Accounts] ([username], [password], [Role], [Status]) VALUES (N'hoangnvhe170385', N'123456', 2, N'active')
GO
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([ID], [Content]) VALUES (1, N'Search operation takes O ( n ) time in the best case.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (2, N'There is no immediate access to the predecessor of any node in list.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (3, N'Deleting last node of the list always takes O ( lgn ) time.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (4, N'Deleting a node at the beginning of the list takes constant time O ( 1 ).')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (5, N'On the average, delete operation executes O ( n ) steps.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (6, N'Inserting a new node at the end of the list requires O ( n ) steps.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (7, N'Methods for processing doubly linked list are simpler than those of singly linked list.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (8, N'Deleting a node at the end of the list takes constant time O ( 1 ).')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (9, N'The node which is deleted from the list will be claimed by the garbage collector.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (10, N'It needs more memory spaces for linking elements.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (11, N'All of the others.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (12, N'Deleting an element from it is efficiently.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (13, N'Inserting a new element to it is efficiently.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (14, N'(temp.info == null)')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (15, N'(temp.next == null)')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (16, N'(temp.next != null)')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (17, N'(temp == null)')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (18, N'An array')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (19, N'A singly linked list')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (20, N'A circular linked list')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (21, N'A double linked list')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (22, N'O ( lgn )')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (23, N'O ( 1 )')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (24, N'None of the others')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (25, N'O ( n )')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (26, N'O ( n2 )')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (27, N'Deleting')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (28, N'Searching')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (29, N'Inserting')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (30, N'All of the others')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (31, N'Inserting and Searching')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (32, N'Searching and Deleting')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (33, N'11')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (34, N'6')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (35, N'9')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (36, N'7')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (37, N'15')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (38, N'41')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (39, N'25')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (40, N'True')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (41, N'False')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (42, N'A and b are true')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (43, N'A and b are false')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (44, N'A is fale and b is true')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (45, N'A is true and b is false.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (46, N'Many copies of the function code are created.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (47, N'It requires large data values.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (48, N'Recursive functions tend to declare many local variables.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (49, N'Previous function calls are still open when the function calls itself and the activation records of these previous calls still occupy space on the call stack.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (50, N'Both odd and even may loop indefinitely')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (51, N'Both odd and even always stops')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (52, N'Odd always stops, but even may loop indefinitely')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (53, N'. even always stops, but odd may loop indefinitely')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (54, N'Insertion of the tail node')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (55, N'Deletion of any node')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (56, N'Insertion of a node to any position.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (57, N'Deletion of the tail node')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (58, N'A is false and b is true.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (59, N'A and b are true.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (60, N'Void push(Object x){ Node p = new Node(x);p.next = head;head=p.next;}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (61, N'Void push(Object x){ Node p = new Node(x);p.next = head;}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (62, N'Void push(Object x){ Node p = new Node(x);p.next = null;head=p;}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (63, N'Void push(Object x){ Node p = new Node(x);p.next = head;head=p;}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (64, N'Void dequeue(Object x){ if (isEmpty()) return(null);pool.remove(pool.size()-1);}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (65, N'Object dequeue(){ if (isEmpty()) return(null);return(pool.removeFirst();}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (66, N'Object dequeue(){ if (isEmpty()) return(null);return(pool.removeLast());}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (67, N'Object dequeue(){if (isEmpty()) return;return(pool.remove(pool.size()-1));}')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (68, N'Deleting one node from the begin of doubly linked list')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (69, N'Inserting one node to the end of the singly linked list that has no tail.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (70, N'Searching one node in singly linked list without tail in the best case.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (71, N'Deleting one any node in a doubly linked list.')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (72, N'Leibnitz')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (73, N'Von Neumann')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (74, N'Pascal')
INSERT [dbo].[Answers] ([ID], [Content]) VALUES (75, N'Charles Babbage')
SET IDENTITY_INSERT [dbo].[Answers] OFF
GO
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (1, 1, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (1, 2, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (1, 3, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (1, 4, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (1, 5, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (2, 6, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (2, 7, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (2, 8, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (2, 9, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (3, 10, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (3, 11, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (3, 12, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (3, 13, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (4, 14, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (4, 15, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (4, 16, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (4, 17, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (5, 11, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (5, 18, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (5, 19, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (5, 20, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (5, 21, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (6, 22, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (6, 23, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (6, 24, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (6, 25, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (6, 26, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (7, 27, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (7, 28, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (7, 29, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (7, 30, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (8, 27, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (8, 28, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (8, 31, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (8, 32, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (9, 22, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (9, 23, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (9, 25, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (9, 26, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (10, 33, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (10, 34, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (10, 35, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (10, 36, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (11, 35, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (11, 37, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (11, 38, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (11, 39, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (12, 40, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (12, 41, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (13, 42, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (13, 43, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (13, 44, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (13, 45, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (14, 46, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (14, 47, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (14, 48, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (14, 49, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (15, 50, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (15, 51, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (15, 52, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (15, 53, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (16, 54, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (16, 55, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (16, 56, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (16, 57, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (17, 43, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (17, 45, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (17, 58, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (17, 59, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (18, 60, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (18, 61, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (18, 62, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (18, 63, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (19, 64, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (19, 65, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (19, 66, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (19, 67, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (20, 68, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (20, 69, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (20, 70, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (20, 71, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (21, 72, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (21, 73, 1)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (21, 74, 0)
INSERT [dbo].[AnswersOfQuestion] ([Question], [Answer], [IsTrue]) VALUES (21, 75, 0)
GO
INSERT [dbo].[Courses] ([Code], [Title]) VALUES (N'CSD201', N'Data Structures and Algorithms')
INSERT [dbo].[Courses] ([Code], [Title]) VALUES (N'CSD203', N'Data Structures and Algorithm with Python')
INSERT [dbo].[Courses] ([Code], [Title]) VALUES (N'CSI104', N'Introduction to Computer Science')
INSERT [dbo].[Courses] ([Code], [Title]) VALUES (N'DBI202', N'Introduction to Databases')
INSERT [dbo].[Courses] ([Code], [Title]) VALUES (N'ITA203c', N'Management information systems')
INSERT [dbo].[Courses] ([Code], [Title]) VALUES (N'NWC203c', N'Computer Networking')
INSERT [dbo].[Courses] ([Code], [Title]) VALUES (N'PMG202c', N'Project management')
GO
INSERT [dbo].[Enroll] ([Username], [Semester], [Course]) VALUES (N'hoangnvhe170385', N'Fa2023', N'DBI202')
INSERT [dbo].[Enroll] ([Username], [Semester], [Course]) VALUES (N'hoangnvhe170385', N'Sp2024', N'CSD201')
INSERT [dbo].[Enroll] ([Username], [Semester], [Course]) VALUES (N'haitdhe170242', N'Fa2023', N'DBI202')
INSERT [dbo].[Enroll] ([Username], [Semester], [Course]) VALUES (N'haitdhe170242', N'Sp2024', N'CSD201')
INSERT [dbo].[Enroll] ([Username], [Semester], [Course]) VALUES (N'quanpahe170260', N'Fa2023', N'DBI202')
INSERT [dbo].[Enroll] ([Username], [Semester], [Course]) VALUES (N'quanpahe170260', N'Sp2024', N'CSD201')
GO
INSERT [dbo].[ExamCode] ([Code], [Semester], [Course], [DateBegin], [TimeBegin], [Long], [Status], [NumberOfQuestion]) VALUES (N'CSD201_TEST', N'Sp2024', N'CSD201', CAST(N'2024-03-18' AS Date), 1, 30, N'Active', 20)
GO
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 1)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 2)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 3)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 4)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 5)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 6)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 7)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 8)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 9)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 10)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 11)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 12)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 13)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 14)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 15)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 16)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 17)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 18)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 19)
INSERT [dbo].[QuestionOfCode] ([ExamCode], [Question]) VALUES (N'CSD201_TEST', 20)
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (1, N'Which of sentences about singly linked list are true:

Select one or more:', 5, 3, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (2, N'Select correct statement(s) about Doubly Linked List:
Select one or more:', 4, 3, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (3, N'Select the best choice about a linked structure.
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (4, N'Suppose temp refers to a node in a linked list (using the SLLNode class with instance variables called info and next). What boolean expression will be true when temp refers to the tail node of the list?', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (5, N'Select the best choice.
A stack can be implemented using .....
Select one:', 5, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (6, N'Assume that in an array list implementation of a stack, pushing an element onto a full stack requires allocating more memory. What is the complexity of pushing operation in this case?
Select one:', 5, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (7, N'Priority queues can be implemented by using unordered linked list. In this case, which of the following operations of the linked list is (are) used to enqueue an element?
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (8, N'Priority queues can be implemented by using unordered linkedlist. Which of the following operations is (are) used to dequeue?
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (9, N'What is the complexity of reversing the order of the elements on a stack using two additional stacks?
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (10, N'If the values of A, B, C and D are 2, 3, 4 and 5, respectively. Using stack, manually calculate the value of the following postfix expressions: A B C + * D -
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (11, N'How many activation records are allocated when calculating Fibonacci(5) by calling recursion method?
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (12, N'Linked lists allow easy insertion and deletion of information because such operations have a local impact on the list.', 2, 1, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (13, N'Consider the following statements:
a. In the circular list, deletion of the tail node takes O ( n ) time.
b. The first node of the circular list has next field reference to the last node.
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (14, N'Recursion requires much memory because:
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (15, N'Precondition for both methods: n >= 0public boolean even(int n) {if (n==0) return true;return odd(n-1);}public boolean odd(int n) {if (n==0) return false;return even(n-1);}Which assertions are correct?
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (16, N'Which of the following operation in the doubly linked circular list can be done in O(1) time?
Select one or more:', 4, 3, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (17, N'Consider the statements related to deleteFromTail operation in the Singly Linked List:
a. There is only one special cases to consider: the list is empty.
b. Most time-consuming part of the operation is finding the next to last node.
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (18, N'Suppose we are implementing a stack using a singly linked list where the head of the list is treated as the top of the stack.
Specify the correct implementation of push() method of the stack. (Choose the most suitable one)
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (19, N'Specify the correct implementation of dequeue() method of a queue. This queue uses java.util.LinkedList, here is pool, for storing data and the head of the list is treated as the head of the queue. (Choose the most suitable one)
Select one:', 4, 2, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (20, N'Which of the following operations always take O( 1)time:
Select one or more:', 4, 3, N'CSD201')
INSERT [dbo].[Questions] ([ID], [Title], [NumberOfAnswers], [Type], [Course]) VALUES (21, N'The _______ model is the basis for today''s computers.', 4, 2, N'CSI104')
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
INSERT [dbo].[Semesters] ([Code], [Year], [beginDate], [endDate]) VALUES (N'Fa2023', 2023, CAST(N'2023-08-01' AS Date), CAST(N'2023-11-21' AS Date))
INSERT [dbo].[Semesters] ([Code], [Year], [beginDate], [endDate]) VALUES (N'Sp2024', 2024, CAST(N'2024-01-02' AS Date), CAST(N'2024-03-21' AS Date))
GO
INSERT [dbo].[TypeOfQuestion] ([ID], [Name]) VALUES (1, N'True/False')
INSERT [dbo].[TypeOfQuestion] ([ID], [Name]) VALUES (2, N'One Answer')
INSERT [dbo].[TypeOfQuestion] ([ID], [Name]) VALUES (3, N'Multi answer')
GO
ALTER TABLE [dbo].[AnswersOfQuestion]  WITH CHECK ADD FOREIGN KEY([Answer])
REFERENCES [dbo].[Answers] ([ID])
GO
ALTER TABLE [dbo].[AnswersOfQuestion]  WITH CHECK ADD FOREIGN KEY([Question])
REFERENCES [dbo].[Questions] ([ID])
GO
ALTER TABLE [dbo].[Enroll]  WITH CHECK ADD FOREIGN KEY([Course])
REFERENCES [dbo].[Courses] ([Code])
GO
ALTER TABLE [dbo].[Enroll]  WITH CHECK ADD FOREIGN KEY([Semester])
REFERENCES [dbo].[Semesters] ([Code])
GO
ALTER TABLE [dbo].[Enroll]  WITH CHECK ADD FOREIGN KEY([Username])
REFERENCES [dbo].[Accounts] ([username])
GO
ALTER TABLE [dbo].[ExamCode]  WITH CHECK ADD FOREIGN KEY([Course])
REFERENCES [dbo].[Courses] ([Code])
GO
ALTER TABLE [dbo].[ExamCode]  WITH CHECK ADD FOREIGN KEY([Semester])
REFERENCES [dbo].[Semesters] ([Code])
GO
ALTER TABLE [dbo].[Practice]  WITH CHECK ADD FOREIGN KEY([ExamCode])
REFERENCES [dbo].[ExamCode] ([Code])
GO
ALTER TABLE [dbo].[Practice]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[Accounts] ([username])
GO
ALTER TABLE [dbo].[QuestionOfCode]  WITH CHECK ADD FOREIGN KEY([ExamCode])
REFERENCES [dbo].[ExamCode] ([Code])
GO
ALTER TABLE [dbo].[QuestionOfCode]  WITH CHECK ADD FOREIGN KEY([Question])
REFERENCES [dbo].[Questions] ([ID])
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD FOREIGN KEY([Course])
REFERENCES [dbo].[Courses] ([Code])
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD FOREIGN KEY([Type])
REFERENCES [dbo].[TypeOfQuestion] ([ID])
GO
USE [master]
GO
ALTER DATABASE [WinAppTracNghiem] SET  READ_WRITE 
GO
