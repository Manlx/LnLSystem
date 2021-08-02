USE [master]
GO
if exists(select * from sysdatabases where name='LLDB') 
	DROP DATABASE [LLDB]
GO
/****** Object:  Database [LLDB]    Script Date: 21/08/02 11:05:57 ******/
CREATE DATABASE [LLDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LLDB', FILENAME = N'E:\Programming_And_Stuff\Programing\LnLSystem\LLDB.mdf' , SIZE = 10240KB , MAXSIZE = 10485760KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LLDB_log', FILENAME = N'E:\Programming_And_Stuff\Programing\LnLSystem\LLDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LLDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LLDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LLDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LLDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LLDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LLDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LLDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LLDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LLDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LLDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LLDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LLDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LLDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LLDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LLDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LLDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LLDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LLDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LLDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LLDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LLDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LLDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LLDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LLDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LLDB] SET RECOVERY FULL 
GO
ALTER DATABASE [LLDB] SET  MULTI_USER 
GO
ALTER DATABASE [LLDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LLDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LLDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LLDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LLDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LLDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LLDB', N'ON'
GO
ALTER DATABASE [LLDB] SET QUERY_STORE = OFF
GO
USE [LLDB]
GO
/****** Object:  Table [dbo].[tblBanks]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBanks](
	[BankID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClient]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClient](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NULL,
	[Surname] [varchar](35) NULL,
	[CellNumber] [varchar](10) NULL,
	[EmailAddress] [varchar](50) NULL,
	[IsBlacklisted] [bit] NULL,
	[HasTab] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCreditSale]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCreditSale](
	[TabID] [int] NOT NULL,
	[StockID] [int] NOT NULL,
	[SoldCount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TabID] ASC,
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEvent]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEvent](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[LocationID] [int] NULL,
	[ClientID] [int] NULL,
	[EventType] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLocation]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLocation](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[LocationDiscription] [varchar](75) NULL,
	[IsOutDoors] [bit] NULL,
	[HasBarAccess] [bit] NULL,
	[HasWifiAccess] [bit] NULL,
	[HasKitcherAccess] [bit] NULL,
	[HasLakeAccess] [bit] NULL,
	[HasSwimmingPoolAccess] [bit] NULL,
	[HasEntertainmentAccess] [bit] NULL,
	[HasStage] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrder]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrder](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NULL,
	[SupplierID] [int] NULL,
	[StockID] [int] NULL,
	[Freightcharges] [decimal](18, 0) NULL,
	[TransactionID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPayMentMethods]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPayMentMethods](
	[MethodID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStaff]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NULL,
	[Surname] [varchar](35) NULL,
	[CellNumber] [varchar](10) NULL,
	[HasLicense] [bit] NULL,
	[IsFulltimeMember] [bit] NULL,
	[RankID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStaffBank]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaffBank](
	[StaffID] [int] NOT NULL,
	[BankID] [int] NOT NULL,
	[Branch] [varchar](25) NULL,
	[AccountNumber] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC,
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStaffPermission]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaffPermission](
	[RankID] [int] IDENTITY(1,1) NOT NULL,
	[RankDescription] [varchar](40) NULL,
	[Salary] [decimal](18, 0) NULL,
	[IsSenior] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[RankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStock]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStock](
	[StockID] [int] IDENTITY(1,1) NOT NULL,
	[StockDescription] [varchar](40) NULL,
	[CostPrice] [decimal](18, 0) NULL,
	[ProfitMargin] [decimal](18, 0) NULL,
	[Count] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](50) NULL,
	[Balance] [decimal](18, 0) NULL,
	[ContactNumber] [varchar](20) NULL,
	[BankBranch] [varchar](30) NULL,
	[AccountNumber] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSupplierBank]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplierBank](
	[SupplierID] [int] NOT NULL,
	[BankID] [int] NOT NULL,
	[BankBranch] [varchar](25) NULL,
	[AccountNumber] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC,
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTab]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTab](
	[TabID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NULL,
	[Balance] [decimal](18, 0) NULL,
	[CutOfValue] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[TabID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTransaction]    Script Date: 21/08/02 11:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTransaction](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 0) NULL,
	[Reason] [varchar](45) NULL,
	[DATE] [datetime] NULL,
	[METHODID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblCreditSale]  WITH CHECK ADD FOREIGN KEY([StockID])
REFERENCES [dbo].[tblStock] ([StockID])
GO
ALTER TABLE [dbo].[tblCreditSale]  WITH CHECK ADD FOREIGN KEY([TabID])
REFERENCES [dbo].[tblTab] ([TabID])
GO
ALTER TABLE [dbo].[tblEvent]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ClientID])
GO
ALTER TABLE [dbo].[tblEvent]  WITH CHECK ADD FOREIGN KEY([LocationID])
REFERENCES [dbo].[tblLocation] ([LocationID])
GO
ALTER TABLE [dbo].[tblOrder]  WITH CHECK ADD FOREIGN KEY([StockID])
REFERENCES [dbo].[tblStock] ([StockID])
GO
ALTER TABLE [dbo].[tblOrder]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[tblSupplier] ([SupplierID])
GO
ALTER TABLE [dbo].[tblOrder]  WITH CHECK ADD FOREIGN KEY([TransactionID])
REFERENCES [dbo].[tblTransaction] ([TransactionID])
GO
ALTER TABLE [dbo].[tblStaff]  WITH CHECK ADD FOREIGN KEY([RankID])
REFERENCES [dbo].[tblStaffPermission] ([RankID])
GO
ALTER TABLE [dbo].[tblStaffBank]  WITH CHECK ADD FOREIGN KEY([BankID])
REFERENCES [dbo].[tblBanks] ([BankID])
GO
ALTER TABLE [dbo].[tblStaffBank]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[tblStaff] ([StaffID])
GO
ALTER TABLE [dbo].[tblSupplierBank]  WITH CHECK ADD FOREIGN KEY([BankID])
REFERENCES [dbo].[tblBanks] ([BankID])
GO
ALTER TABLE [dbo].[tblSupplierBank]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[tblSupplier] ([SupplierID])
GO
ALTER TABLE [dbo].[tblTab]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ClientID])
GO
ALTER TABLE [dbo].[tblTransaction]  WITH CHECK ADD FOREIGN KEY([METHODID])
REFERENCES [dbo].[tblPayMentMethods] ([MethodID])
GO
USE [master]
GO
ALTER DATABASE [LLDB] SET  READ_WRITE 
GO
