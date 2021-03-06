USE [master]
GO
/****** Object:  Database [FPdatabase]    Script Date: 7/13/2022 2:26:08 PM ******/
CREATE DATABASE [FPdatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FPdatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FPdatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FPdatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FPdatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FPdatabase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FPdatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FPdatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FPdatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FPdatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FPdatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FPdatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [FPdatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FPdatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FPdatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FPdatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FPdatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FPdatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FPdatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FPdatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FPdatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FPdatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FPdatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FPdatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FPdatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FPdatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FPdatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FPdatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FPdatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FPdatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FPdatabase] SET  MULTI_USER 
GO
ALTER DATABASE [FPdatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FPdatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FPdatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FPdatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FPdatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FPdatabase] SET QUERY_STORE = OFF
GO
USE [FPdatabase]
GO
/****** Object:  Table [dbo].[Aircrafts]    Script Date: 7/13/2022 2:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aircrafts](
	[icao] [varchar](10) NOT NULL,
	[model] [varchar](50) NOT NULL,
	[engine_type] [varchar](50) NOT NULL,
	[plane_age] [int] NOT NULL,
	[delivery_date] [datetimeoffset](7) NOT NULL,
	[seat_count] [int] NOT NULL,
	[image_url] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Aircrafts] PRIMARY KEY CLUSTERED 
(
	[icao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Flights]    Script Date: 7/13/2022 2:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flights](
	[flight_number] [int] NOT NULL,
	[seat] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[duration] [varchar](50) NOT NULL,
	[delay] [varchar](50) NOT NULL,
	[airline_name] [varchar](255) NOT NULL,
	[departure_airport_name] [varchar](255) NOT NULL,
	[departure_date] [datetimeoffset](7) NOT NULL,
	[departure_gate] [varchar](50) NOT NULL,
	[arrival_airport_name] [varchar](255) NOT NULL,
	[arrival_date] [datetimeoffset](7) NOT NULL,
	[arrival_gate] [varchar](50) NOT NULL,
	[aircraft_id] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Flights] PRIMARY KEY CLUSTERED 
(
	[flight_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/13/2022 2:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[password] [varchar](250) NOT NULL,
	[miles] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_miles]  DEFAULT ((0)) FOR [miles]
GO
USE [master]
GO
ALTER DATABASE [FPdatabase] SET  READ_WRITE 
GO
