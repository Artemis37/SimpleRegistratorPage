USE [master]
GO
/****** Object:  Database [SimpleRegistrationPage]    Script Date: 10/19/2021 6:13:51 PM ******/
CREATE DATABASE [SimpleRegistrationPage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SimpleRegistrationPage', FILENAME = N'D:\Sql Server 2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\SimpleRegistrationPage.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SimpleRegistrationPage_log', FILENAME = N'D:\Sql Server 2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\SimpleRegistrationPage_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SimpleRegistrationPage] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SimpleRegistrationPage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SimpleRegistrationPage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET ARITHABORT OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SimpleRegistrationPage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SimpleRegistrationPage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SimpleRegistrationPage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SimpleRegistrationPage] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SimpleRegistrationPage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET RECOVERY FULL 
GO
ALTER DATABASE [SimpleRegistrationPage] SET  MULTI_USER 
GO
ALTER DATABASE [SimpleRegistrationPage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SimpleRegistrationPage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SimpleRegistrationPage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SimpleRegistrationPage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SimpleRegistrationPage] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SimpleRegistrationPage] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SimpleRegistrationPage', N'ON'
GO
ALTER DATABASE [SimpleRegistrationPage] SET QUERY_STORE = OFF
GO
USE [SimpleRegistrationPage]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/19/2021 6:13:51 PM ******/
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
/****** Object:  Table [dbo].[Accounts]    Script Date: 10/19/2021 6:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[username] [varchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[email] [varchar](1000) NULL,
	[address] [nvarchar](1000) NULL,
	[phone] [int] NULL,
	[gender] [bit] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SimpleRegistrationPage] SET  READ_WRITE 
GO
