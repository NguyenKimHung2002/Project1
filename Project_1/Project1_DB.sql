USE [master]
GO
/****** Object:  Database [Project1_DB]    Script Date: 2/18/2023 6:00:42 PM ******/
CREATE DATABASE [Project1_DB]
GO
ALTER DATABASE [Project1_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project1_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project1_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project1_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project1_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project1_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project1_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project1_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project1_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project1_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project1_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project1_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project1_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project1_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project1_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project1_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project1_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project1_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project1_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project1_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project1_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project1_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project1_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Project1_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Project1_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project1_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project1_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project1_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project1_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project1_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project1_DB', N'ON'
GO
ALTER DATABASE [Project1_DB] SET QUERY_STORE = OFF
GO
USE [Project1_DB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[CategoryDescription] [nvarchar](max) NULL,
 CONSTRAINT [Category_pk] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryByProduct]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryByProduct](
	[ProductId] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CategoryValue] [nvarchar](50) NULL,
	[CategoryUnit] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(220001,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerPhone] [varchar](11) NOT NULL,
 CONSTRAINT [Customer_pk] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feature]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feature](
	[FeatureId] [int] IDENTITY(1,1) NOT NULL,
	[FeatureName] [nvarchar](50) NULL,
	[FeatureDescription] [nvarchar](max) NULL,
 CONSTRAINT [Feature_pk] PRIMARY KEY CLUSTERED 
(
	[FeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeatureByCategory]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeatureByCategory](
	[CategoryId] [int] NOT NULL,
	[FeatureId] [int] NOT NULL,
 CONSTRAINT [FeatureByCategory_pk] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC,
	[FeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeatureByProduct]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeatureByProduct](
	[ProductId] [nvarchar](50) NOT NULL,
	[FeatureId] [int] NOT NULL,
	[FeatureValue] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceId] [int] IDENTITY(20220001,1) NOT NULL,
	[InvoiceDateTime] [datetime] NULL,
	[PaymentMethod] [nvarchar](max) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[StaffId] [int] NOT NULL,
 CONSTRAINT [Invoice_pk] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[InvoiceDetailId] [int] IDENTITY(20230001,1) NOT NULL,
	[ProductId] [nvarchar](50) NOT NULL,
	[InvoiceId] [int] NOT NULL,
	[QuantityNo] [float] NULL,
	[UnitPrice] [float] NULL,
	[Discount] [float] NULL,
 CONSTRAINT [InvoiceDetail_pk] PRIMARY KEY CLUSTERED 
(
	[InvoiceDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductQuantity] [int] NULL,
	[ProductUnit] [nvarchar](50) NULL,
	[ImportPrice] [nvarchar](50) NULL,
	[ExportPrice] [nvarchar](50) NULL,
	[ProductDescription] [nvarchar](max) NULL,
 CONSTRAINT [Product_pk] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2/18/2023 6:00:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[StaffAccount] [nvarchar](50) NULL,
	[StaffPassword] [nvarchar](50) NULL,
	[StaffIDPer] [nvarchar](50) NULL,
	[StaffName] [nvarchar](50) NOT NULL,
	[StaffGender] [nvarchar](50) NULL,
	[StaffAdress] [nvarchar](max) NULL,
	[StaffPhone] [varchar](11) NOT NULL,
	[StaffBirthday] [datetime] NULL,
 CONSTRAINT [Staff_pk] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CategoryByProduct]  WITH CHECK ADD  CONSTRAINT [CategoryByProduct_fk1] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[CategoryByProduct] CHECK CONSTRAINT [CategoryByProduct_fk1]
GO
ALTER TABLE [dbo].[CategoryByProduct]  WITH CHECK ADD  CONSTRAINT [CategoryByProduct_fk2] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[CategoryByProduct] CHECK CONSTRAINT [CategoryByProduct_fk2]
GO
ALTER TABLE [dbo].[FeatureByCategory]  WITH CHECK ADD  CONSTRAINT [FeatureByCategory_fk1] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[FeatureByCategory] CHECK CONSTRAINT [FeatureByCategory_fk1]
GO
ALTER TABLE [dbo].[FeatureByCategory]  WITH CHECK ADD  CONSTRAINT [FeatureByCategory_fk2] FOREIGN KEY([FeatureId])
REFERENCES [dbo].[Feature] ([FeatureId])
GO
ALTER TABLE [dbo].[FeatureByCategory] CHECK CONSTRAINT [FeatureByCategory_fk2]
GO
ALTER TABLE [dbo].[FeatureByProduct]  WITH CHECK ADD  CONSTRAINT [FeatureByProduct_fk1] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[FeatureByProduct] CHECK CONSTRAINT [FeatureByProduct_fk1]
GO
ALTER TABLE [dbo].[FeatureByProduct]  WITH CHECK ADD  CONSTRAINT [FeatureByProduct_fk2] FOREIGN KEY([FeatureId])
REFERENCES [dbo].[Feature] ([FeatureId])
GO
ALTER TABLE [dbo].[FeatureByProduct] CHECK CONSTRAINT [FeatureByProduct_fk2]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [Invoice_fk1] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [Invoice_fk1]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [Invoice_fk2] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staff] ([StaffId])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [Invoice_fk2]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [InvoiceDetail_fk1] FOREIGN KEY([InvoiceId])
REFERENCES [dbo].[Invoice] ([InvoiceId])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [InvoiceDetail_fk1]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [InvoiceDetail_fk2] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [InvoiceDetail_fk2]
GO
/****** Object:  StoredProcedure [dbo].[AuthoLogin]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AuthoLogin]
@Username nvarchar(50),
@Password nvarchar(50)
as
begin
    if exists (select * from Staff where StaffAccount = @Username and StaffPassword = @Password and StaffIDPer = 1)
        select 1 as code
    else if exists (select * from Staff where StaffAccount = @Username and StaffPassword = @Password and StaffIDPer = 0)
        select 0 as code
    else if exists(select * from Staff where StaffAccount = @Username and StaffPassword != @Password) 
        select 2 as code
    else select 3 as code
end;
GO
/****** Object:  StoredProcedure [dbo].[CreateInvoice]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CreateInvoice]
@InvoiceDatetime datetime,
@CustomerId int,
@StaffId int,
@PaymentMethod nvarchar(max)
as
begin
	insert into Invoice(InvoiceDateTime, CustomerId, StaffId, PaymentMethod)
	values (@InvoiceDatetime, @CustomerId, @StaffId, @PaymentMethod)
end;
GO
/****** Object:  StoredProcedure [dbo].[CreateInvoiceDetail]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CreateInvoiceDetail]
@InvoiceId int,
@ProductId nvarchar(50),
@UnitPrice float,
@ProductNumber float
as
begin
	insert into InvoiceDetail(InvoiceId, ProductId, UnitPrice, QuantityNo)
	values (@InvoiceId, @ProductId, @UnitPrice, @ProductNumber)
end;
GO
/****** Object:  StoredProcedure [dbo].[Get_InvoiceId]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Get_InvoiceId]
as
begin
	select Invoice.InvoiceId
	from Invoice
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_AddCategory]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_AddCategory]
@CategoryName nvarchar(max),
@CategoryDescription nvarchar(max)
as
begin
	insert into Category(Category.CategoryName, Category.CategoryDescription)
	values (@CategoryName, @CategoryDescription)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_AddCustomer]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddCustomer]
@CustomerName nvarchar(50),
@CustomerPhone nvarchar(50)
as
begin
	Insert into Customer
	values (@CustomerName, @CustomerPhone)
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_AddFeature]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddFeature]
@FeatureName nvarchar(max),
@FeatureDescription nvarchar(max)
as
begin
	insert into Feature (Feature.FeatureName, FeatureDescription)
	values (@FeatureName, @FeatureDescription)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_AddFeatureByCategory]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddFeatureByCategory]
@FeatureId int,
@CategoryId int
as
begin
	insert into FeatureByCategory(FeatureId, CategoryId)
	values (@FeatureId, @CategoryId)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_AddFeatureByProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_AddFeatureByProduct]
@ProductId nvarchar(50),
@FeatureId int,
@FeatureValue nvarchar(max)
as
begin
	insert into FeatureByProduct(ProductId, FeatureId, FeatureValue)
	values (@ProductId, @FeatureId, @FeatureValue)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_AddProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_AddProduct]
@ProductId nvarchar(50),
@ProductName nvarchar(50),
@ProductQuantity int,
@ProductUnit nvarchar(50),
@ImportPrice nvarchar(50),
@ExportPrice nvarchar(50),
@ProductDescription nvarchar(max)
as
begin
	insert into Product
	values(@ProductId, @ProductName, @ProductQuantity, @ProductUnit, @ImportPrice, @ExportPrice, @ProductDescription)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_AddSticker]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_AddSticker]
@ProductId nvarchar(50),
@FeatureId int,
@FeatureValue nvarchar(max)
as
begin
	insert into FeatureByProduct
	values(@ProductId, @FeatureId, @FeatureValue);
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteCustomer]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*create proc CreateInvoiceDetail
@InvoiceId int,
@ProductId nvarchar(50),
@UnitPrice int,
@ProductNumber int
as
begin
	insert into InvoiceDetail(InvoiceId, ProductId, UnitPrice, ProductNumber)
	values (@InvoiceId, @ProductId, @UnitPrice, @ProductNumber)
end;
go*/
create proc [dbo].[proc_DeleteCustomer]
@CustomerId int
as
begin
	delete Customer where CustomerId = @CustomerId;
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteFeature]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteFeature]
@FeatureId int
as
begin
	delete Feature where FeatureId = @FeatureId
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_DeleteProduct]
@ProductId nvarchar(50)
as
begin
	delete Product where ProductId = @ProductId;
	delete FeatureByProduct where ProductId = @ProductId;
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteSticker]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_DeleteSticker]
@ProductId nvarchar(50),
@FeatureId int
as
begin
	delete FeatureByProduct where ProductId = @ProductId and FeatureId = @FeatureId
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetCategoryName]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetCategoryName]
as
begin
	select distinct Category.CategoryName as N'Tên Loại SP'
	from Category
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetCustomerId]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetCustomerId]
@CustomerPhone nvarchar(11)
as
begin
	select Customer.CustomerId
	from Customer
	where Customer.CustomerPhone = @CustomerPhone
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetCustomerName]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetCustomerName]
@CustomerPhone nvarchar(50)
as
begin
	select CustomerName from Customer where Customer.CustomerPhone = @CustomerPhone;
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetDataCategory]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetDataCategory]
as
begin
	select Category.CategoryId as N'Mã danh mục', Category.CategoryName as N'Tên danh mục', Category.CategoryDescription as N'Mô tả'
	from Category;
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetDataCustomer]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetDataCustomer]
as
select Customer.CustomerId as N'Mã khách hàng', Customer.CustomerName as N'Tên khách hàng', Customer.CustomerPhone as N'SĐT khách hàng'
from Customer;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetDataFeature]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetDataFeature]
as
begin
	select Feature.FeatureId as 'Mã đặc tính', Feature.FeatureName as 'Tên đặc tính', Feature.FeatureDescription as 'Mô tả'
	from Feature;
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetDataPayment]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetDataPayment]
@PageSize int,
@PageIndex int
as
begin
	select *
	from(
			select ROW_NUMBER() over(order by Product.ProductID) as STT, Product.ProductId as N'Mã sản phẩm', Product.ProductName as N'Tên sản phẩm', Product.ExportPrice as N'Đơn giá',
			Product.ProductQuantity as N'Định lượng', Product.ProductUnit as N'Đơn vị đo'
			from Product
		) a
	where STT between (@PageIndex-1)*@PageSize+1 and @PageIndex*@PageSize
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetDataProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetDataProduct]
as
(
	select Product.ProductId as N'Mã sản phẩm', Product.ProductName as N'Tên sản phẩm', Product.ProductQuantity as N'Định lượng', Product.ProductUnit as N'Đơn vị đo', 
	Product.ImportPrice as N'Giá nhập', Product.ExportPrice as N'Giá xuất', Product.ProductDescription as N'Mô tả'
	from Product
)
GO
/****** Object:  StoredProcedure [dbo].[proc_GetDataSticker]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetDataSticker]
@ProductId nvarchar(50)
as
begin
	select Feature.FeatureName as N'Tên đặc tính', FeatureByProduct.FeatureValue as N'Giá trị tương đối'
	from Feature join FeatureByProduct on Feature.FeatureId = FeatureByProduct.FeatureId
	where FeatureByProduct.ProductId = @ProductId
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetFeatureIdByFeatureName]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetFeatureIdByFeatureName]
@FeatureName nvarchar(max)
as
begin
	select Feature.FeatureId
	from Feature
	where Feature.FeatureName = @FeatureName
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetFeatureName]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetFeatureName]
as
begin
	select Feature.FeatureId as N'Mã đặc tính', Feature.FeatureName as N'Đặc tính'
	from Feature
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetLastestCategoryId]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetLastestCategoryId]
as
begin
	select Category.CategoryId
	from Category
	where Category.CategoryId = (select MAX(Category.CategoryId)
								from Category)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetProductInformationForInvoice]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetProductInformationForInvoice]
@ProductId nvarchar(50)
as
begin
	select Product.ProductName, Product.ExportPrice
	from Product
	where Product.ProductId = @ProductId
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetSortedDataPayment]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetSortedDataPayment]
@CustomerPhone varchar(11),
@PageSize int,
@PageIndex int
as
begin
	WITH customer_history AS (
		SELECT Product.ProductId, COUNT(Product.ProductId) as frequence
		from Customer join Invoice on Customer.CustomerId = Invoice.CustomerId
                  join InvoiceDetail on Invoice.InvoiceId = InvoiceDetail.InvoiceId
                  join Product on InvoiceDetail.ProductId = Product.ProductId
		where Customer.CustomerPhone = @CustomerPhone
		group by Product.ProductId
		),
	all_products AS (
		SELECT Product.ProductId, Product.ProductName, Product.ExportPrice ,
			Product.ProductQuantity, Product.ProductUnit
		FROM Product
		)

	select STT, a.ProductId as N'Mã sản phẩm', a.ProductName as N'Tên sản phẩm', a.ExportPrice as N'Đơn giá',
			a.ProductQuantity as N'Định lượng', a.ProductUnit as N'Đơn vị đo'
	from(
			select ROW_NUMBER() over(order by all_products.ProductID) as STT, all_products.*, customer_history.frequence
			FROM all_products LEFT JOIN customer_history ON all_products.ProductId = customer_history.ProductId
		) a
	where STT between (@PageIndex-1)*@PageSize+1 and @PageIndex*@PageSize
	ORDER BY a.frequence DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetStaffId]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetStaffId]
@Username nvarchar(50),
@Password nvarchar(50)
as
begin
	select Staff.StaffId
	from Staff
	where Staff.StaffAccount = @Username and Staff.StaffPassword = @Password
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetStaffName]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetStaffName]
@Username nvarchar(50),
@Password nvarchar(50)
as
begin
	select Staff.StaffName
	from Staff
	where Staff.StaffAccount = @Username and Staff.StaffPassword = @Password
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetSuggestions]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetSuggestions]
@ProductId nvarchar(50)
as
begin
	select distinct ROW_NUMBER() over(order by Product.ProductID) as STT, Product.ProductId as N'Mã sản phẩm', Product.ProductName as N'Tên sản phẩm', Product.ExportPrice as N'Đơn giá',
			Product.ProductQuantity as N'Định lượng', Product.ProductUnit as N'Đơn vị đo'
	from Product join FeatureByProduct on Product.ProductId = FeatureByProduct.ProductId
	where FeatureByProduct.FeatureId in (select FeatureByProduct.FeatureId
											from FeatureByProduct
											where FeatureByProduct.ProductId = @ProductId)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetTotalProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetTotalProduct]
as
begin
	select COUNT(*)
	from Product
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetTotalSearchProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_GetTotalSearchProduct]
@SearchDataPayment nvarchar(max)
as
begin
	select count(*)
	from Product
	where UPPER(Product.ProductId) like UPPER('%'+@SearchDataPayment+'%') or UPPER(Product.ProductName) like ('%'+@SearchDataPayment+'%')
end
GO
/****** Object:  StoredProcedure [dbo].[proc_RecommendTrendingProducts]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_RecommendTrendingProducts]
as
begin
	select distinct top 10 ROW_NUMBER() over(order by Product.ProductID) as STT, Product.ProductId as N'Mã sản phẩm', Product.ProductName as N'Tên sản phẩm', Product.ExportPrice as N'Đơn giá',
			Product.ProductQuantity as N'Định lượng', Product.ProductUnit as N'Đơn vị đo', SUM(InvoiceDetail.QuantityNo) as [Số lượng bán ra]
	from Product join InvoiceDetail on Product.ProductId = InvoiceDetail.ProductId
	group by Product.ProductId, Product.ProductName, Product.ExportPrice,
			Product.ProductQuantity, Product.ProductUnit
	order by [Số lượng bán ra] DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchDataCustomer]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*create proc proc_AddFeature
@FeatureName nvarchar(max),
@FeatureDescription nvarchar(max)
as
begin
	insert into Feature (Feature.FeatureName, FeatureDescription)
	values (@FeatureName, @FeatureDescription)
end
go
create proc proc_UpdateFeature
@FeatureId int,
@FeatureName nvarchar(max),
@FeatureDescription nvarchar(max)
as
begin
	update Feature
	set FeatureName = @FeatureName, FeatureDescription = @FeatureDescription
	where FeatureId = @FeatureId
end
go
create proc proc_DeleteFeature
@FeatureId int
as
begin
	delete Feature where FeatureId = @FeatureId
end*/
CREATE proc [dbo].[proc_SearchDataCustomer]
@SearchFollowCustomerName nvarchar(max)
as
begin
	select Customer.CustomerId as N'Mã khách hàng', Customer.CustomerName as N'Tên khách hàng', Customer.CustomerPhone as N'SĐT khách hàng'
	from Customer
	where upper(Customer.CustomerName) like upper('%'+@SearchFollowCustomerName+'%');
end
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchDataFeature]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_SearchDataFeature]
@SearchFollowFeatureName nvarchar(max)
as
begin
	select Feature.FeatureId as N'Mã đặc tính', Feature.FeatureName as N'Tên đặc tính', Feature.FeatureDescription as N'Mô tả'
	from Feature
	where upper(Feature.FeatureName) like upper('%'+@SearchFollowFeatureName+'%');
end
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchDataPayment]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_SearchDataPayment]
@PageSize int,
@PageIndex int,
@SearchDataPayment nvarchar(max)
as
begin
	select *
	from(
			select ROW_NUMBER() over(order by Product.ProductID) as STT, Product.ProductId as N'Mã sản phẩm', Product.ProductName as N'Tên sản phẩm', Product.ExportPrice as N'Đơn giá',
			Product.ProductQuantity as N'Định lượng', Product.ProductUnit as N'Đơn vị đo'
			from Product
			where UPPER(Product.ProductId) like UPPER('%'+@SearchDataPayment+'%') or UPPER(Product.ProductName) like ('%'+@SearchDataPayment+'%')
		) a
	where STT between (@PageIndex-1)*@PageSize+1 and @PageIndex*@PageSize
end
GO
/****** Object:  StoredProcedure [dbo].[proc_SearchDataProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_SearchDataProduct]
@SearchDataProduct nvarchar(max)
as
begin
	select Product.ProductId as N'Mã sản phẩm', Product.ProductName as N'Tên sản phẩm', Product.ProductQuantity as N'Định lượng', Product.ProductUnit as N'Đơn vị đo', 
	Product.ImportPrice as N'Giá nhập', Product.ExportPrice as N'Giá xuất', Product.ProductDescription as N'Mô tả'
	from Product
	where UPPER(Product.ProductId) like UPPER('%'+@SearchDataProduct+'%') or UPPER(Product.ProductName) like ('%'+@SearchDataProduct+'%')
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateCustomer]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*create proc Show_Product
as
begin
	select Product.ProductId, Product.ProductName, Product.QuantityNo, Product.ProductUnit, Category.CategoryName
	from Product join Category on Product.CategoryId = Category.CategoryId
				join Feature on Category.FeatureId = Feature.FeatureId
end;
go*/
create proc [dbo].[proc_UpdateCustomer]
@CustomerId int,
@CustomerName nvarchar(50),
@CustomerPhone nvarchar(50)
as
begin
	update Customer
	set CustomerName = @CustomerName, CustomerPhone = @CustomerPhone
	where CustomerId = @CustomerId
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateFeature]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateFeature]
@FeatureId int,
@FeatureName nvarchar(max),
@FeatureDescription nvarchar(max)
as
begin
	update Feature
	set FeatureName = @FeatureName, FeatureDescription = @FeatureDescription
	where FeatureId = @FeatureId
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateProduct]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateProduct]
@ProductId nvarchar(50),
@ProductName nvarchar(50),
@ProductQuantity int,
@ProductUnit nvarchar(50),
@ImportPrice nvarchar(50),
@ExportPrice nvarchar(50),
@ProductDescription nvarchar(max)
as
begin
	update Product
	set ProductName = @ProductName, ProductQuantity = @ProductQuantity, ProductUnit = @ProductUnit,
		ImportPrice = @ImportPrice, ExportPrice = @ExportPrice, ProductDescription = @ProductDescription
	Where ProductId = @ProductId
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateSticker]    Script Date: 2/18/2023 6:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_UpdateSticker]
@ProductId nvarchar(50),
@FeatureIdChange int,
@FeatureId int,
@FeatureValue nvarchar(max)
as
begin
	update FeatureByProduct
	set FeatureId = @FeatureId, FeatureValue = @FeatureValue
	where ProductId = @ProductId and FeatureId = @FeatureIdChange
end
GO
USE [master]
GO
ALTER DATABASE [Project1_DB] SET  READ_WRITE 
GO
