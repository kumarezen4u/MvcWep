USE [Practice]
GO
/****** Object:  ForeignKey [FK__Employee__DeptId__7F2BE32F]    Script Date: 07/19/2023 10:31:04 ******/
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK__Employee__DeptId__7F2BE32F]
GO
/****** Object:  ForeignKey [fk_Menu]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tbl_UserDashboardConfig] DROP CONSTRAINT [fk_Menu]
GO
/****** Object:  ForeignKey [fkRoleId]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tblLogin] DROP CONSTRAINT [fkRoleId]
GO
/****** Object:  ForeignKey [FK__DailyExpe__Expen__2F9A1060]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[DailyExpenses] DROP CONSTRAINT [FK__DailyExpe__Expen__2F9A1060]
GO
/****** Object:  ForeignKey [FK__DailyExpe__Expen__308E3499]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[DailyExpenses] DROP CONSTRAINT [FK__DailyExpe__Expen__308E3499]
GO
/****** Object:  ForeignKey [FK__ExpSubCat__Expen__318258D2]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[ExpSubCategory] DROP CONSTRAINT [FK__ExpSubCat__Expen__318258D2]
GO
/****** Object:  ForeignKey [FK__ExpSubCat__Expen__32767D0B]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[ExpSubCategory] DROP CONSTRAINT [FK__ExpSubCat__Expen__32767D0B]
GO
/****** Object:  Table [Expense].[DailyExpenses]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[DailyExpenses] DROP CONSTRAINT [FK__DailyExpe__Expen__2F9A1060]
GO
ALTER TABLE [Expense].[DailyExpenses] DROP CONSTRAINT [FK__DailyExpe__Expen__308E3499]
GO
DROP TABLE [Expense].[DailyExpenses]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateEmpDeleteDeptId]    Script Date: 07/19/2023 10:31:06 ******/
DROP PROCEDURE [dbo].[usp_UpdateEmpDeleteDeptId]
GO
/****** Object:  Table [dbo].[tbl_UserDashboardConfig]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tbl_UserDashboardConfig] DROP CONSTRAINT [fk_Menu]
GO
DROP TABLE [dbo].[tbl_UserDashboardConfig]
GO
/****** Object:  StoredProcedure [dbo].[sp_customer]    Script Date: 07/19/2023 10:31:06 ******/
DROP PROCEDURE [dbo].[sp_customer]
GO
/****** Object:  StoredProcedure [dbo].[SPR_GETMultipleResultSP]    Script Date: 07/19/2023 10:31:06 ******/
DROP PROCEDURE [dbo].[SPR_GETMultipleResultSP]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tblLogin] DROP CONSTRAINT [fkRoleId]
GO
DROP TABLE [dbo].[tblLogin]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 07/19/2023 10:31:04 ******/
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK__Employee__DeptId__7F2BE32F]
GO
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [Expense].[ExpSubCategory]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[ExpSubCategory] DROP CONSTRAINT [FK__ExpSubCat__Expen__318258D2]
GO
ALTER TABLE [Expense].[ExpSubCategory] DROP CONSTRAINT [FK__ExpSubCat__Expen__32767D0B]
GO
DROP TABLE [Expense].[ExpSubCategory]
GO
/****** Object:  UserDefinedFunction [dbo].[fnSplitString]    Script Date: 07/19/2023 10:31:06 ******/
DROP FUNCTION [dbo].[fnSplitString]
GO
/****** Object:  Table [dbo].[PrimaryInformation]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[PrimaryInformation]
GO
/****** Object:  Table [Expense].[PrimaryInformation]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [Expense].[PrimaryInformation]
GO
/****** Object:  Table [Custom].[Product]    Script Date: 07/19/2023 10:31:04 ******/
DROP TABLE [Custom].[Product]
GO
/****** Object:  Table [Data].[ProfitCenterToSAPXref]    Script Date: 07/19/2023 10:31:04 ******/
DROP TABLE [Data].[ProfitCenterToSAPXref]
GO
/****** Object:  Table [dbo].[RoutineExpenses]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[RoutineExpenses]
GO
/****** Object:  Table [Services].[SerilogError]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [Services].[SerilogError]
GO
/****** Object:  Table [Data].[SourceSystemToBatchNumberXref]    Script Date: 07/19/2023 10:31:04 ******/
DROP TABLE [Data].[SourceSystemToBatchNumberXref]
GO
/****** Object:  Table [dbo].[EnrollmentStatusLookup]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[EnrollmentStatusLookup] DROP CONSTRAINT [DF_EnrollmentStatusLookup_CreatedOn]
GO
ALTER TABLE [dbo].[EnrollmentStatusLookup] DROP CONSTRAINT [DF_EnrollmentStatusLookup_ModifiedOn]
GO
DROP TABLE [dbo].[EnrollmentStatusLookup]
GO
/****** Object:  Table [dbo].[EnrollmentTypeLookup]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[EnrollmentTypeLookup] DROP CONSTRAINT [DF_EnrollmentTypeLookup_CreatedOn]
GO
ALTER TABLE [dbo].[EnrollmentTypeLookup] DROP CONSTRAINT [DF_EnrollmentTypeLookup_ModifiedOn]
GO
DROP TABLE [dbo].[EnrollmentTypeLookup]
GO
/****** Object:  Table [dbo].[ExpCategory]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[ExpCategory]
GO
/****** Object:  Table [Expense].[ExpCategory]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [Expense].[ExpCategory]
GO
/****** Object:  Table [dbo].[ExpSubCategory]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[ExpSubCategory]
GO
/****** Object:  Table [dbo].[tblRole]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tblRole] DROP CONSTRAINT [DF__tblRole__Archive__208CD6FA]
GO
DROP TABLE [dbo].[tblRole]
GO
/****** Object:  Table [dbo].[Technology]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[Technology]
GO
/****** Object:  UserDefinedFunction [dbo].[TestfnSplitString]    Script Date: 07/19/2023 10:31:06 ******/
DROP FUNCTION [dbo].[TestfnSplitString]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetProdDetails]    Script Date: 07/19/2023 10:31:06 ******/
DROP PROCEDURE [dbo].[usp_GetProdDetails]
GO
/****** Object:  StoredProcedure [dbo].[usp_Numeric]    Script Date: 07/19/2023 10:31:06 ******/
DROP PROCEDURE [dbo].[usp_Numeric]
GO
/****** Object:  Table [Custom].[Supplier]    Script Date: 07/19/2023 10:31:04 ******/
DROP TABLE [Custom].[Supplier]
GO
/****** Object:  Table [dbo].[tbl_Menu]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[tbl_Menu]
GO
/****** Object:  Table [dbo].[tbl_MessagesType]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[tbl_MessagesType]
GO
/****** Object:  Table [dbo].[tbl_Registration]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tbl_Registration] DROP CONSTRAINT [DF__tbl_Regis__Archi__151B244E]
GO
DROP TABLE [dbo].[tbl_Registration]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 07/19/2023 10:31:04 ******/
DROP TABLE [dbo].[Department]
GO
/****** Object:  Table [dbo].[tblCities]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[tblCities]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 07/19/2023 10:31:05 ******/
DROP TABLE [dbo].[tblEmployee]
GO
/****** Object:  Table [dbo].[CUSTOMER2]    Script Date: 07/19/2023 10:31:04 ******/
DROP TABLE [dbo].[CUSTOMER2]
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 07/19/2023 10:31:04 ******/
DROP TABLE [dbo].[CUSTOMERS]
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[ID] [int] NOT NULL,
	[NAME] [varchar](20) NOT NULL,
	[AGE] [int] NOT NULL,
	[ADDRESS] [char](25) NULL,
	[SALARY] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[NAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMER2]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMER2](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](20) NOT NULL,
	[AGE] [int] NOT NULL,
	[ADDRESS] [char](25) NULL,
	[SALARY] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[NAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[Department] [varchar](20) NOT NULL,
	[Gender] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCities]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCities](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Registration]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Registration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](25) NOT NULL,
	[UserName] [varchar](25) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[Archive] [bit] NULL DEFAULT ((1)),
 CONSTRAINT [regis_pkId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_MessagesType]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_MessagesType](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Archive] [bit] NULL,
 CONSTRAINT [pk_TypeId] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Menu]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Menu](
	[MenuId] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [varchar](50) NULL,
	[DispName] [varchar](50) NULL,
	[Archive] [bit] NULL,
 CONSTRAINT [pk_MenuId] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Custom].[Supplier]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Custom].[Supplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_Numeric]    Script Date: 07/19/2023 10:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Numeric]
    @NUM1 INT,  
    @NUM2 INT , 
    @NUM3 INT OUT  
 AS  
 BEGIN 
 
 BEGIN TRY  
 BEGIN TRANSACTION  
SET @NUM3 = @NUM1 / @NUM2;
   COMMIT TRANSACTION 
  END TRY  
 BEGIN CATCH  
    IF @@TRANCOUNT > 0  
    ROLLBACK TRANSACTION  
    DECLARE  @ErrorMessage  NVARCHAR(4000),  
             @ErrorSeverity INT,    
             @ErrorState    INT;    
  
    SELECT     
        @ErrorMessage  = ERROR_MESSAGE(),    
        @ErrorSeverity = ERROR_SEVERITY(),   
        @ErrorState    = ERROR_STATE();   
           
    SET @ErrorMessage=@ErrorMessage   
  
    RAISERROR (@ErrorMessage, -- Message text.    
                 @ErrorSeverity, -- Severity.    
                 @ErrorState -- State.    
               );    
               PRINT 'Error Message';
               PRINT @ErrorMessage;
 END CATCH  
 RETURN @NUM3;
 
 END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetProdDetails]    Script Date: 07/19/2023 10:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetProdDetails]      
@pageno int,
@pagesize int,
@sortcolumn varchar(100),
@sortorder varchar(10),
@filter varchar(max),
@count int  OUTPUT

AS
BEGIN


    declare @Start int=(@pageno)*@pagesize;
    declare @End int=@Start+@pagesize;
   -- SET NOCOUNT ON;
    
   DECLARE  @tblProducts AS TABLE
        (ProductId int,ProductName nvarchar(50),UnitPrice money, UnitsInStock smallint,RN int)   

    declare @sql varchar(max)= 'select ProductId,ProductName,UnitPrice,UnitsInStock,
    ROW_NUMBER() OVER (ORDER BY '+@sortcolumn + ' '+@sortorder+' ) AS RN from Custom.Product  WHERE 1=1 '-- +@filter;    
    --print @sql;
    INSERT INTO @tblProducts exec (@sql)
    select  @count=COUNT(*) from @tblProducts
    select * from @tblProducts where RN>@Start and RN<=@End order by RN 
END
GO
/****** Object:  Table [dbo].[Users]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [UsersId_pk] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[TestfnSplitString]    Script Date: 07/19/2023 10:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [dbo].[TestfnSplitString] 
( 
    @string NVARCHAR(MAX), 
    @delimiter CHAR(1) 
) 
--RETURNS @output TABLE(splitdata NVARCHAR(MAX) 
RETURNS @output TABLE(splitdata NVARCHAR(MAX) 
) 
BEGIN 
    DECLARE @start INT, @end INT 
    SELECT @start = 1, @end = CHARINDEX(@delimiter, @string) 
    WHILE @start < LEN(@string) + 1 BEGIN 
        IF @end = 0  
            SET @end = LEN(@string) + 1
       
        INSERT INTO @output (splitdata)  
        VALUES(SUBSTRING(@string, @start, @end - @start)) 
        SET @start = @end + 1 
        SET @end = CHARINDEX(@delimiter, @string, @start)
        
    END 
    RETURN 
END
GO
/****** Object:  Table [dbo].[Technology]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Technology](
	[TechId] [int] IDENTITY(1,1) NOT NULL,
	[TechName] [varchar](50) NULL,
 CONSTRAINT [pk_TechId] PRIMARY KEY CLUSTERED 
(
	[TechId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [uk_TechId] UNIQUE NONCLUSTERED 
(
	[TechName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblRole]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRole](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](30) NOT NULL,
	[Archive] [bit] NULL DEFAULT ((1)),
 CONSTRAINT [pkRoleId] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpSubCategory]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpSubCategory](
	[ExpenseSubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCategoryId] [int] NULL,
	[SubCategoryName] [nvarchar](50) NULL,
	[Archive] [bit] NULL,
 CONSTRAINT [PK_ExpSubCategory] PRIMARY KEY CLUSTERED 
(
	[ExpenseSubCategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Expense].[ExpCategory]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Expense].[ExpCategory](
	[ExpenseCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Archive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseCategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpCategory]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpCategory](
	[ExpenseCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Archive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseCategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnrollmentTypeLookup]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnrollmentTypeLookup](
	[EnrollmentTypeID] [smallint] NOT NULL,
	[EnrollmentTypeCode] [nvarchar](50) NOT NULL,
	[EnrollmentDescription] [nvarchar](255) NULL,
	[Timestamp] [timestamp] NULL,
	[CreatedOn] [datetime] NULL CONSTRAINT [DF_EnrollmentTypeLookup_CreatedOn]  DEFAULT (getutcdate()),
	[CreatedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL CONSTRAINT [DF_EnrollmentTypeLookup_ModifiedOn]  DEFAULT (getutcdate()),
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EnrollmentTypeLookup] PRIMARY KEY CLUSTERED 
(
	[EnrollmentTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnrollmentStatusLookup]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnrollmentStatusLookup](
	[EnrollmentStatusID] [smallint] NOT NULL,
	[EnrollmentStatusCode] [nvarchar](50) NULL,
	[EnrollmentStatusName] [nvarchar](255) NULL,
	[Timestamp] [timestamp] NULL,
	[CreatedOn] [datetime] NULL CONSTRAINT [DF_EnrollmentStatusLookup_CreatedOn]  DEFAULT (getutcdate()),
	[CreatedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL CONSTRAINT [DF_EnrollmentStatusLookup_ModifiedOn]  DEFAULT (getutcdate()),
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EnrollmentStatusLookup] PRIMARY KEY CLUSTERED 
(
	[EnrollmentStatusID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Data].[SourceSystemToBatchNumberXref]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data].[SourceSystemToBatchNumberXref](
	[SourceSystemToBatchNumberXrefId] [int] IDENTITY(1,1) NOT NULL,
	[SourceSystem] [nvarchar](250) NOT NULL,
	[BatchNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SourceSystemToBatchNumberXref] PRIMARY KEY CLUSTERED 
(
	[SourceSystemToBatchNumberXrefId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Services].[SerilogError]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Services].[SerilogError](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[MessageTemplate] [nvarchar](max) NULL,
	[Level] [nvarchar](128) NULL,
	[TimeStamp] [datetime] NOT NULL,
	[Exception] [nvarchar](max) NULL,
	[Properties] [xml] NULL,
 CONSTRAINT [PK_SerilogError] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoutineExpenses]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoutineExpenses](
	[RoutineExpensesId] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCategoryId] [int] NULL,
	[ExpenseSubCategoryId] [int] NULL,
	[PrimaryInformationId] [int] NULL,
	[PayAmount] [numeric](18, 2) NULL,
	[PaymentDate] [datetime] NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_RoutineExpenses] PRIMARY KEY CLUSTERED 
(
	[RoutineExpensesId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Data].[ProfitCenterToSAPXref]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data].[ProfitCenterToSAPXref](
	[ProfitCenterToSAPXrefID] [int] IDENTITY(1,1) NOT NULL,
	[ProfitCenter] [nvarchar](10) NOT NULL,
	[CType] [int] NOT NULL,
	[SAPInvoiceCompanyNumber] [nvarchar](10) NOT NULL,
	[SAPInvoiceProfitCenterNumber] [nvarchar](10) NOT NULL,
	[SAPAccountCompanyNumber] [nvarchar](10) NOT NULL,
	[SAPAccountGLAccountNumber] [nvarchar](10) NOT NULL,
	[SAPAccountProfitCenterNumber] [nvarchar](10) NOT NULL,
	[SAPAccountCostCenterNumber] [nvarchar](10) NOT NULL,
	[SAPPlant] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_ProfitCenterToSAPXref] PRIMARY KEY CLUSTERED 
(
	[ProfitCenterToSAPXrefID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Custom].[Product]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Custom].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](60) NULL,
	[Category] [varchar](50) NOT NULL,
	[UnitPrice] [decimal](18, 4) NULL,
	[UnitsInStock] [int] NOT NULL,
 CONSTRAINT [pk_ProductID] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Expense].[PrimaryInformation]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Expense].[PrimaryInformation](
	[PrimaryInformationId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ExpenseSubCategoryId] [int] NULL,
	[PrincipalAmount] [numeric](18, 2) NULL,
	[InterestRate] [numeric](18, 2) NULL,
	[OpeningDate] [datetime] NULL,
	[IsEMIType] [bit] NULL,
	[NumberOfTearms] [int] NULL,
	[RePaymentAmount] [numeric](18, 2) NULL,
	[ClosingDate] [datetime] NULL,
	[Archive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrimaryInformationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrimaryInformation]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrimaryInformation](
	[PrimaryInformationId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ExpenseSubCategoryId] [int] NULL,
	[PrincipalAmount] [numeric](18, 2) NULL,
	[InterestRate] [numeric](18, 2) NULL,
	[OpeningDate] [datetime] NULL,
	[IsEMIType] [bit] NULL,
	[NumberOfTearms] [int] NULL,
	[RePaymentAmount] [numeric](18, 2) NULL,
	[ClosingDate] [datetime] NULL,
	[Archive] [bit] NULL,
 CONSTRAINT [PK_PrimaryInformation] PRIMARY KEY CLUSTERED 
(
	[PrimaryInformationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fnSplitString]    Script Date: 07/19/2023 10:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [dbo].[fnSplitString] 
( 
    @string NVARCHAR(MAX), 
    @delimiter CHAR(1) 
) 
--RETURNS @output TABLE(splitdata NVARCHAR(MAX) 
RETURNS @output TABLE(splitdata NVARCHAR(MAX) 
) 
BEGIN 
    DECLARE @start INT, @end INT 
    SELECT @start = 1, @end = CHARINDEX(@delimiter, @string) 
    WHILE @start < LEN(@string) + 1 BEGIN 
        IF @end = 0  
            SET @end = LEN(@string) + 1
       
        INSERT INTO @output (splitdata)  
        VALUES(SUBSTRING(@string, @start, @end - @start)) 
        SET @start = @end + 1 
        SET @end = CHARINDEX(@delimiter, @string, @start)
        
    END 
    RETURN 
END
GO
/****** Object:  Table [Expense].[ExpSubCategory]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Expense].[ExpSubCategory](
	[ExpenseSubCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCategoryId] [int] NOT NULL,
	[SubCategoryName] [nvarchar](50) NULL,
	[Archive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseSubCategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 07/19/2023 10:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Email] [varchar](50) NULL,
	[DeptId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLogin](
	[LoginId] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[EmailId] [varchar](50) NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [pkLoginId] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SPR_GETMultipleResultSP]    Script Date: 07/19/2023 10:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPR_GETMultipleResultSP]  
  
AS  
BEGIN  
 SET NOCOUNT ON;  
   Select Top 3 * from dbo.ExpCategory;    
   Select Top 3 * from ExpSubCategory        
END
GO
/****** Object:  StoredProcedure [dbo].[sp_customer]    Script Date: 07/19/2023 10:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_customer] 
as
select ID,NAME,AGE from CUSTOMERS
GO
/****** Object:  Table [dbo].[tbl_UserDashboardConfig]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_UserDashboardConfig](
	[LoginId] [varchar](50) NOT NULL,
	[MenuId] [int] NOT NULL,
	[ServerName] [varchar](50) NULL,
	[SearchTest1] [varchar](50) NULL,
	[SearchTest2] [varchar](50) NULL,
	[Archive] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateEmpDeleteDeptId]    Script Date: 07/19/2023 10:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateEmpDeleteDeptId]   
 @Id INT,  
 @EmpName VARCHAR(50),  
 @Email VARCHAR(50)  
 AS    
 BEGIN TRY  
  BEGIN TRANSACTION  
      
    UPDATE Employee   
    SET Name=@EmpName  
    WHERE Id=@Id  
  
    DELETE FROM Department   WHERE Id=@Id  
        
        PRINT 'SUCCESSFULLY EXECUTIED';
        
   COMMIT TRANSACTION  
 END TRY  
 BEGIN CATCH  
    IF @@TRANCOUNT > 0  
    ROLLBACK TRANSACTION  
    DECLARE  @ErrorMessage  NVARCHAR(4000),  
             @ErrorSeverity INT,    
             @ErrorState    INT;    
  
    SELECT     
        @ErrorMessage  = ERROR_MESSAGE(),    
        @ErrorSeverity = ERROR_SEVERITY(),   
        @ErrorState    = ERROR_STATE();   
           
    SET @ErrorMessage=@ErrorMessage   
  
    RAISERROR (@ErrorMessage, -- Message text.    
                 @ErrorSeverity, -- Severity.    
                 @ErrorState -- State.    
               );    
               PRINT 'Failure';
 END CATCH
GO
/****** Object:  Table [Expense].[DailyExpenses]    Script Date: 07/19/2023 10:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Expense].[DailyExpenses](
	[DailyExpensesId] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCategoryId] [int] NULL,
	[ExpenseSubCategoryId] [int] NULL,
	[PrimaryInformationId] [int] NULL,
	[PayAmount] [numeric](18, 2) NULL,
	[PaymentDate] [datetime] NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[DailyExpensesId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK__Employee__DeptId__7F2BE32F]    Script Date: 07/19/2023 10:31:04 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DeptId])
REFERENCES [dbo].[Department] ([Id])
GO
/****** Object:  ForeignKey [fk_Menu]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tbl_UserDashboardConfig]  WITH CHECK ADD  CONSTRAINT [fk_Menu] FOREIGN KEY([MenuId])
REFERENCES [dbo].[tbl_Menu] ([MenuId])
GO
ALTER TABLE [dbo].[tbl_UserDashboardConfig] CHECK CONSTRAINT [fk_Menu]
GO
/****** Object:  ForeignKey [fkRoleId]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [dbo].[tblLogin]  WITH CHECK ADD  CONSTRAINT [fkRoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[tblRole] ([RoleId])
GO
ALTER TABLE [dbo].[tblLogin] CHECK CONSTRAINT [fkRoleId]
GO
/****** Object:  ForeignKey [FK__DailyExpe__Expen__2F9A1060]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[DailyExpenses]  WITH CHECK ADD FOREIGN KEY([ExpenseCategoryId])
REFERENCES [Expense].[ExpCategory] ([ExpenseCategoryId])
GO
/****** Object:  ForeignKey [FK__DailyExpe__Expen__308E3499]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[DailyExpenses]  WITH CHECK ADD FOREIGN KEY([ExpenseSubCategoryId])
REFERENCES [Expense].[ExpSubCategory] ([ExpenseSubCategoryId])
GO
/****** Object:  ForeignKey [FK__ExpSubCat__Expen__318258D2]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[ExpSubCategory]  WITH CHECK ADD FOREIGN KEY([ExpenseCategoryId])
REFERENCES [Expense].[ExpCategory] ([ExpenseCategoryId])
GO
/****** Object:  ForeignKey [FK__ExpSubCat__Expen__32767D0B]    Script Date: 07/19/2023 10:31:05 ******/
ALTER TABLE [Expense].[ExpSubCategory]  WITH CHECK ADD FOREIGN KEY([ExpenseCategoryId])
REFERENCES [Expense].[ExpCategory] ([ExpenseCategoryId])
GO
