USE [master]
GO
/****** Object:  Database [DigiDoor]    Script Date: 12-May-16 10:41:08 PM ******/
CREATE DATABASE [DigiDoor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DigiDoor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DigiDoor.mdf' , SIZE = 20480KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DigiDoor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DigiDoor_log.ldf' , SIZE = 5696KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DigiDoor] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DigiDoor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DigiDoor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DigiDoor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DigiDoor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DigiDoor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DigiDoor] SET ARITHABORT OFF 
GO
ALTER DATABASE [DigiDoor] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DigiDoor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DigiDoor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DigiDoor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DigiDoor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DigiDoor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DigiDoor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DigiDoor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DigiDoor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DigiDoor] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DigiDoor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DigiDoor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DigiDoor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DigiDoor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DigiDoor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DigiDoor] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DigiDoor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DigiDoor] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DigiDoor] SET  MULTI_USER 
GO
ALTER DATABASE [DigiDoor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DigiDoor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DigiDoor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DigiDoor] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DigiDoor] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DigiDoor]
GO
/****** Object:  Table [dbo].[AdminLoginRecord]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdminLoginRecord](
	[LoginNumber] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[LoginTime] [time](7) NOT NULL,
	[LoginDate] [date] NULL,
 CONSTRAINT [PK_AdminLoginRecord] PRIMARY KEY CLUSTERED 
(
	[LoginNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[category_table]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[category_table](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [varchar](25) NOT NULL,
 CONSTRAINT [PK_category_table] PRIMARY KEY CLUSTERED 
(
	[category_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[log_table]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[log_table](
	[entry_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[checkInTime] [time](7) NOT NULL,
	[CapturedImage] [varbinary](max) NULL,
	[checkInDate] [date] NULL,
	[CheckOutTime] [time](7) NULL,
	[CheckOutDate] [date] NULL,
	[CheckOutStatus] [varchar](50) NULL,
 CONSTRAINT [PK_log_table] PRIMARY KEY CLUSTERED 
(
	[entry_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[system_status_table]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[system_status_table](
	[Serial_Number] [int] IDENTITY(1,1) NOT NULL,
	[system_status] [varchar](50) NOT NULL,
	[act_time] [time](7) NOT NULL,
	[act_date] [date] NOT NULL,
 CONSTRAINT [PK_system_status_table] PRIMARY KEY CLUSTERED 
(
	[Serial_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user_table]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user_table](
	[user_number] [int] IDENTITY(1,1) NOT NULL,
	[NameOfUser] [varchar](50) NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[passcode] [varchar](8) NOT NULL,
	[category] [varchar](25) NOT NULL,
	[begin_time] [time](7) NOT NULL,
	[end_time] [time](7) NOT NULL,
	[user_image] [varbinary](max) NULL,
	[status] [varchar](50) NOT NULL CONSTRAINT [DF_user_table_status]  DEFAULT ('ACTIVE'),
 CONSTRAINT [PK_user_table] PRIMARY KEY CLUSTERED 
(
	[user_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[AdminLoginRecord]  WITH CHECK ADD  CONSTRAINT [FK_AdminLoginRecord_user_table] FOREIGN KEY([username])
REFERENCES [dbo].[user_table] ([user_name])
GO
ALTER TABLE [dbo].[AdminLoginRecord] CHECK CONSTRAINT [FK_AdminLoginRecord_user_table]
GO
ALTER TABLE [dbo].[log_table]  WITH CHECK ADD  CONSTRAINT [FK_log_table_user_table] FOREIGN KEY([username])
REFERENCES [dbo].[user_table] ([user_name])
GO
ALTER TABLE [dbo].[log_table] CHECK CONSTRAINT [FK_log_table_user_table]
GO
ALTER TABLE [dbo].[user_table]  WITH CHECK ADD  CONSTRAINT [FK_user_table_category_table1] FOREIGN KEY([category])
REFERENCES [dbo].[category_table] ([category_name])
GO
ALTER TABLE [dbo].[user_table] CHECK CONSTRAINT [FK_user_table_category_table1]
GO
/****** Object:  StoredProcedure [dbo].[AdminLoginInfo_SelectByName]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[AdminLoginInfo_SelectByName]
(
	@name varchar(50)
)

AS

BEGIN

SELECT * from AdminLoginRecord
where username = @name

END

GO
/****** Object:  StoredProcedure [dbo].[AdminLoginTable_AddEntry]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AdminLoginTable_AddEntry]
(
	@user_name varchar(50),
	@login_time time,
	@login_date date
)

AS

BEGIN

insert into AdminLoginRecord
(
username,
LoginTime,
LoginDate

)

VALUES
(
@user_name,
@login_time,
@login_date
)

END

GO
/****** Object:  StoredProcedure [dbo].[InsertCheckOut]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertCheckOut]
(
	@user_name varchar(50),
	@checkOutTime time,
	@checkOutDate date
)

AS

BEGIN 

UPDATE log_table

SET
CheckOutTime =@checkOutTime,
CheckOutDate = @checkOutDate,
CheckOutStatus = 'true'

WHERE

entry_id =(SELECT MAX(entry_id) from log_table) AND
username = @user_name AND
CheckOutStatus='false'



END


GO
/****** Object:  StoredProcedure [dbo].[log_tableAddEntry]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[log_tableAddEntry]
(
	@user_name nvarchar(50),
	@check_In_Time time,
	@captured_Image image,
	@currentDate date
)

as

begin

insert into log_table
(
username,
checkInTime,
CapturedImage,
checkInDate,
CheckOutStatus
)

VALUES
(
@user_name,
@check_In_Time,
@captured_Image,
@currentDate,
'false'
)

end


GO
/****** Object:  StoredProcedure [dbo].[log_tableClearEntries]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[log_tableClearEntries]


AS

BEGIN

DELETE from log_table

END
GO
/****** Object:  StoredProcedure [dbo].[LogInfo_SelectByName]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LogInfo_SelectByName]
(
	@name varchar(50)
)

AS

BEGIN

SELECT * from log_table
where username = @name

END

GO
/****** Object:  StoredProcedure [dbo].[LogTable_SelectRecords]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[LogTable_SelectRecords]

AS

BEGIN

SELECT * from log_table

END




GO
/****** Object:  StoredProcedure [dbo].[UpdateSystemStatus]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[UpdateSystemStatus]
(
@system_status varchar(50),
@act_time time,
@act_date date
)

AS

BEGIN

INSERT INTO system_status_table
(
system_status,
act_time,
act_date
)

VALUES
(
@system_status,
@act_time,
@act_date
)

END
GO
/****** Object:  StoredProcedure [dbo].[User_TableAddRecord]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[User_TableAddRecord]
(
@NameOfUser nvarchar(50),
@UserName nvarchar(50),
@Pin	nvarchar(8),
@Category nvarchar(25),
@beginTime time,
@endTime time,
@img image
)

as


begin

insert into dbo.user_table
(
NameOfUser,
user_name,
passcode,
category,
begin_time,
end_time,
user_image,
[status]
)

values
(
@NameOfUser,
@UserName,
@Pin,
@Category,
@beginTime,
@endTime,
@img,
'ACTIVE'
)


end
GO
/****** Object:  StoredProcedure [dbo].[user_tableDeleteRecord]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[user_tableDeleteRecord]
(
@UserName nvarchar(50),
@Pin nvarchar(8)
)

as

begin

update user_table

set

passcode = @Pin,
[status] = 'INACTIVE'

where

user_name = @UserName

end

GO
/****** Object:  StoredProcedure [dbo].[user_tableUpdateRecord]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[user_tableUpdateRecord]
(
@NameOfUser nvarchar(50),
@UserName nvarchar(50),
@Pin	nvarchar(8),
@Category nvarchar(25),
@beginTime time,
@endTime time,
@img image
)

as

begin

update dbo.user_table

SET

NameOfUser = @NameOfUser,
passcode = @Pin,
category = @Category,
begin_time = @beginTime,
end_time = @endTime,
user_image = @img,
[status] ='ACTIVE'
where

user_name = @UserName ;



end

GO
/****** Object:  StoredProcedure [dbo].[UserTable_SelectRecords]    Script Date: 12-May-16 10:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UserTable_SelectRecords]
(
@UserName nvarchar(50)
)


as




begin

select * from user_table where user_name=@UserName



end
GO
USE [master]
GO
ALTER DATABASE [DigiDoor] SET  READ_WRITE 
GO
