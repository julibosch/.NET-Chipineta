USE [master]
GO

/****** Object:  Database [db_club]    Script Date: 7/8/2023 3:53:08 p. m. ******/
CREATE DATABASE [db_club]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_club', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_club.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_club_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_club_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_club].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [db_club] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [db_club] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [db_club] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [db_club] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [db_club] SET ARITHABORT OFF 
GO

ALTER DATABASE [db_club] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [db_club] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [db_club] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [db_club] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [db_club] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [db_club] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [db_club] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [db_club] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [db_club] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [db_club] SET  DISABLE_BROKER 
GO

ALTER DATABASE [db_club] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [db_club] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [db_club] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [db_club] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [db_club] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [db_club] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [db_club] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [db_club] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [db_club] SET  MULTI_USER 
GO

ALTER DATABASE [db_club] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [db_club] SET DB_CHAINING OFF 
GO

ALTER DATABASE [db_club] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [db_club] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [db_club] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [db_club] SET QUERY_STORE = OFF
GO

ALTER DATABASE [db_club] SET  READ_WRITE 
GO


