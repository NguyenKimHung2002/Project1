USE [master]
GO
/****** Object:  Database [Project1_DB]    Script Date: 2/19/2023 1:16:06 PM ******/
CREATE DATABASE [Project1_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project1_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.KIMHUNG\MSSQL\DATA\Project1_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project1_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.KIMHUNG\MSSQL\DATA\Project1_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Project1_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project1_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
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
/****** Object:  Table [dbo].[Category]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[CategoryByProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[Customer]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[Feature]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[FeatureByCategory]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[FeatureByProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[Invoice]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  Table [dbo].[Staff]    Script Date: 2/19/2023 1:16:06 PM ******/
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
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription]) VALUES (1, N'Tâm lý mua hàng', N'Hành vi mua hàng tác động do yếu tố tâm lý')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220001, N'Nguyễn Minh Hào', N'0828432432')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220002, N'Phan Tuấn Thành', N'0999888777')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220003, N'Lê Minh Cương', N'0987987987')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220004, N'Phạm Thị Bích Hằng', N'0789888987')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220005, N'Nguyễn Quang Thịnh', N'0988877766')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220006, N'Phạm Hồng Phong', N'0987666789')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220007, N'Lê Hồng Vân', N'0432874837')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220008, N'Nguyễn Hồng Hạnh', N'0947328467')
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerPhone]) VALUES (220009, N'Nguyễn Hữu Đức', N'0274347389')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Feature] ON 

INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (1, N'Thịt gia súc gia cầm', N'Các mặt hàng tươi sống là thịt và các sản phẩm từ thịt (Bò, dê, gà, heo, ...)')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (2, N'Thủy hải sản', N'Các mặt hàng tươi sống là thủy hải sản và các sản phẩm từ thủy hải sản (Tôm, cá, mực, ...)')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (3, N'Thực phẩm rau', N'Là các loại thực phẩm chứa nhiều vitamin và khoáng chất, bao gồm cả rau củ và rau cải.')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (4, N'Thực phẩm củ quả', N'Các loại thực phẩm củ quả như cà rốt, bí ngô, gấc, ...')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (5, N'Trái cây', N'Trái cây tươi các loại')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (6, N'Trứng', N'Gồm trứng và các sản phẩm từ trứng')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (7, N'Thực phẩm đóng gói', N'Thực phẩm đóng gói, đóng hộp sẵn như bánh, kẹo, gia vị, dầu ăn, mỳ gói, sữa các loại,')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (8, N'Nước uống đóng chai', N'Nước uống đóng chai/ lon/ thùng các loại')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (9, N'Lương thực', N'Gồm các loại thực phẩm như gạo, ngô, khoai, sắn, ...')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (10, N'Thực phẩm hạt', N'Gồm các thực phẩm dạng hạt như đậu, đỗ, vừng, lạc, ...')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (11, N'Tâm lý tặng kèm', N'Các sản phẩm được tặng cho khách hàng nhằm hướng tới tâm lý "có đi có lại", củng cố mối quan hệ chân thành với khách hàng')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (12, N'Tâm lý đầu tư', N'Các sản phẩm thuộc dạng nếu khách hàng cam kết mua hàng trong một thời gian dài sẽ có những ưu đãi với giá trị hấp dẫn')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (13, N'Tâm lý tin cậy', N'Các sản phẩm được giới thiệu bởi những nguồn có thẩm quyền như đài truyền hình quốc gia hoặc được giới thiệu trong những talkshow của các diễn giả có ảnh hưởng')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (14, N'Tâm lý xu hướng', N'Các sản phẩm có hiệu ứng tâm lý theo đám đông, phổ biến nhờ mạng xã hội hay blog, dù mang tính thời điểm nhưng tạo ra trend lan tỏa không ngờ, thu hút khách mua hàng')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (15, N'Tâm lý tín nhiệm với thương hiệu', N'Các sản phẩm lấy được thiện cảm tích cực nhờ thương hiệu hay dịch vụ dù cho các thương hiệu đối thủ có chất lượng sản phẩm hay các chiến lược marketing tốt hơn.')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (16, N'Đang giảm giá', N'Các sản phầm được nhà cung cấp lên chiến lược giảm giá nhằm tăng số lượng sản phẩm bán ra')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (17, N'Ưu đãi tặng kèm và trúng thưởng', N'Gồm các ưu đãi tặng kèm quà vào sản phẩm được mua hoặc hình thức trúng thưởng vào các sự kiện đặc biệt ')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (18, N'Đổi trả', N'Gồm các sản phẩm có chính sách đổi trả trong một khoảng thời gian tính từ thời điểm đơn hàng được thanh toán nếu bị lỗi như héo, khô hay sản phẩm đóng gói có bao bì bị rách hở')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (19, N'Tuổi tác', N'Các sản phẩm có phụ thuộc vào tuổi tác người dùng như sữa trẻ em chẳng hạn tuy nhiên các sản phẩm loại này nhiều khi là mua hộ')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (20, N'Nghề nghiệp', N'Các sản phẩm có xu hướng phục vụ nghề nghiệp và công việc riêng của khách hàng ví dụ đầu bếp thường mua gia vị loại độc đáo cho dù đắt tiền')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (21, N'Cao cấp', N'Các sản phẩm mang giá trị cao, thường là những người có nhiều của cái hoặc thu nhập cao mới có khả năng chi trả')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (22, N'Thực phẩm gia vị', N'Gồm các loại gia vị nấu nướng như dầu ăn, nước mắm, dầu hào, muối, mì chính, ...')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (23, N'Thực phẩm đông lạnh', N'Thực phẩm đông lạnh là các sản phẩm được chế biến sẵn, sau đó được bảo quản ở nhiệt độ thấp trong thời gian dài.')
INSERT [dbo].[Feature] ([FeatureId], [FeatureName], [FeatureDescription]) VALUES (24, N'Thực phẩm ăn nhanh', N'Thức ăn nhanh là loại thức ăn được chế biến nhanh, phục vụ nhanh và thưởng thức chỉ trong khoảng thời gian ngắn.')
SET IDENTITY_INSERT [dbo].[Feature] OFF
GO
INSERT [dbo].[FeatureByCategory] ([CategoryId], [FeatureId]) VALUES (1, 11)
GO
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_01', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_02', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_05', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_06', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_03', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_06', 2, N'3')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_08', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_09', 22, N'3')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_09', 22, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_10', 22, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_13', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_14', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_15', 22, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_16', 22, N'1')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_17', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_18', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'HE.P_01', 6, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'HE.P_01', 21, N'Trừng đẻ từ gà thảo dược')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'KF.P_03', 6, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'KF.P_04', 3, N'3')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'MMF.P_01', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_01', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_02', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_03', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_03', 24, N'3 Miền')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_04', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_05', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_06', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_06', 24, N'Đệ Nhất')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NT.P_01', 2, N'5')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NT.P_02', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'SGF.P_01', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'SGF.P_02', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'SGF.P_02', 23, N'-5 độ C')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'TD.P_01', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'TT.P_01', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'TT.P_01', 21, N'Nhập khẩu Mỹ')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_04', 3, N'9')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_09', 4, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_11', 4, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_12', 4, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_01', 13, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_03', 13, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_04', 13, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_03', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_04', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'C.P_07', 1, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_01', 2, N'1')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_02', 2, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_04', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_05', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_11', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_12', 7, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_15', 22, N'3')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_16', 22, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'KF.P_01', 6, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'KF.P_02', 6, N'Có')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'KF.P_02', 21, N'Nhập khẩu')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'MMF.P_01', 23, N'0 độ C')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_01', 24, N'Hảo Hảo')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_02', 24, N'Kokomi')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'NP_04', 24, N'Omachi')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'SGF.P_03', 2, N'3')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_01', 3, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_02', 3, N'5')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_03', 3, N'4')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_05', 3, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_07', 3, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_10', 3, N'9')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'EP_07', 2, N'2')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_06', 3, N'3')
INSERT [dbo].[FeatureByProduct] ([ProductId], [FeatureId], [FeatureValue]) VALUES (N'VE.P_08', 4, N'Có')
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220002, CAST(N'2023-01-12T09:44:08.500' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220003, CAST(N'2023-01-12T09:49:13.137' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220004, CAST(N'2023-01-12T10:06:15.973' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220005, CAST(N'2023-01-12T13:41:35.197' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220006, CAST(N'2023-01-12T13:46:41.947' AS DateTime), N'Tiền mặt', 220006, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220007, CAST(N'2023-01-12T13:51:23.627' AS DateTime), N'Tiền mặt', 220006, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220008, CAST(N'2023-01-12T13:52:24.687' AS DateTime), N'Tiền mặt', 220004, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220009, CAST(N'2023-01-12T13:52:48.093' AS DateTime), N'Tiền mặt', 220004, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220010, CAST(N'2023-01-12T13:54:13.623' AS DateTime), N'Tiền mặt', 220005, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220011, CAST(N'2023-01-12T13:54:33.453' AS DateTime), N'Tiền mặt', 220005, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220012, CAST(N'2023-01-12T13:55:39.093' AS DateTime), N'Tiền mặt', 220002, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220013, CAST(N'2023-01-12T14:27:54.057' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220014, CAST(N'2023-01-12T14:28:40.367' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220015, CAST(N'2023-01-12T14:31:06.270' AS DateTime), N'Tiền mặt', 220006, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220016, CAST(N'2023-01-12T14:32:54.783' AS DateTime), N'Tiền mặt', 220004, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220017, CAST(N'2023-01-12T14:33:28.737' AS DateTime), N'Tiền mặt', 220003, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220018, CAST(N'2023-01-12T14:33:30.937' AS DateTime), N'Tiền mặt', 220003, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220019, CAST(N'2023-01-12T14:33:33.077' AS DateTime), N'Tiền mặt', 220003, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220020, CAST(N'2023-01-12T14:34:52.200' AS DateTime), N'Tiền mặt', 220009, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220021, CAST(N'2023-01-12T14:34:59.910' AS DateTime), N'Tiền mặt', 220009, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220022, CAST(N'2023-01-12T14:35:01.743' AS DateTime), N'Tiền mặt', 220009, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220023, CAST(N'2023-01-12T14:35:03.470' AS DateTime), N'Tiền mặt', 220009, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220024, CAST(N'2023-01-12T14:35:28.737' AS DateTime), N'Tiền mặt', 220009, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220025, CAST(N'2023-01-12T14:35:30.887' AS DateTime), N'Tiền mặt', 220009, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220026, CAST(N'2023-01-12T15:42:45.050' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220027, CAST(N'2023-01-15T21:54:37.990' AS DateTime), N'Tiền mặt', 220002, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220028, CAST(N'2023-01-18T09:09:12.490' AS DateTime), N'Tiền mặt', 220006, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220029, CAST(N'2023-01-21T08:34:40.863' AS DateTime), N'Tiền mặt', 220006, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220030, CAST(N'2023-01-27T17:31:27.907' AS DateTime), N'Tiền mặt', 220006, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220031, CAST(N'2023-01-28T15:22:58.280' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220032, CAST(N'2023-02-06T16:28:45.267' AS DateTime), N'Tiền mặt', 220006, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220033, CAST(N'2023-02-08T21:45:37.807' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220034, CAST(N'2023-02-09T16:01:48.303' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20220035, CAST(N'2023-02-12T21:34:50.647' AS DateTime), N'Tiền mặt', 220006, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20221035, CAST(N'2023-02-16T20:24:36.570' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20221036, CAST(N'2023-02-16T20:45:13.163' AS DateTime), N'Tiền mặt', 220006, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20221037, CAST(N'2023-02-16T20:49:40.497' AS DateTime), N'Tiền mặt', 220006, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20221038, CAST(N'2023-02-16T22:10:45.070' AS DateTime), N'Tiền mặt', 220002, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceDateTime], [PaymentMethod], [CustomerId], [StaffId]) VALUES (20221039, CAST(N'2023-02-18T11:37:07.073' AS DateTime), N'Tiền mặt', 220002, 2)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[InvoiceDetail] ON 

INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230001, N'C.P_01', 20220004, 1, 89300, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230002, N'C.P_02', 20220004, 4, 76500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230003, N'C.P_05', 20220005, 1, 125000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230004, N'C.P_04', 20220005, 1, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230005, N'EP_02', 20220005, 1, 96000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230006, N'C.P_06', 20220005, 1, 67900, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230007, N'C.P_02', 20220006, 1, 76500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230008, N'C.P_04', 20220006, 2, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230009, N'C.P_02', 20220007, 1, 76500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230010, N'C.P_04', 20220007, 3, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230011, N'EP_15', 20220008, 1, 49000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230012, N'EP_17', 20220008, 1, 26000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230013, N'EP_15', 20220009, 1, 49000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230014, N'EP_17', 20220009, 1, 26000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230015, N'HE.P_01', 20220009, 1, 29400, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230016, N'TD.P_01', 20220010, 1, 84000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230017, N'TD.P_01', 20220011, 1, 84000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230018, N'VE.P_07', 20220011, 1, 13700, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230019, N'NP_01', 20220012, 10, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230020, N'NP_01', 20220013, 4, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230021, N'NP_01', 20220014, 4, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230022, N'NP_02', 20220014, 1, 3500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230023, N'VE.P_03', 20220015, 1, 6400, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230024, N'VE.P_03', 20220015, 1, 6400, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230025, N'VE.P_22', 20220016, 1, 19000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230026, N'EP_02', 20220017, 1, 96000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230027, N'EP_02', 20220018, 1, 96000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230028, N'EP_02', 20220019, 1, 96000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230029, N'NP_01', 20220020, 2, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230030, N'NP_01', 20220021, 2, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230031, N'NP_01', 20220022, 2, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230032, N'NP_01', 20220023, 2, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230033, N'NP_01', 20220024, 2, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230034, N'NP_04', 20220024, 7, 6500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230035, N'NP_01', 20220025, 2, 4500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230036, N'NP_04', 20220025, 7, 6500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230037, N'VE.P_05', 20220026, 1, 27500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230038, N'VE.P_06', 20220026, 2, 5200, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230039, N'C.P_03', 20220027, 1, 81200, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230040, N'C.P_04', 20220027, 3, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230041, N'C.P_02', 20220028, 1, 76500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230042, N'C.P_04', 20220028, 1, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230043, N'C.P_03', 20220029, 1, 81200, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230044, N'EP_12', 20220029, 1, 34400, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230045, N'C.P_04', 20220030, 1, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230046, N'C.P_06', 20220030, 12, 67900, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230047, N'VE.P_27', 20220031, 1, 58900, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230048, N'C.P_03', 20220032, 1, 81200, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230049, N'C.P_04', 20220032, 2, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230050, N'C.P_04', 20220033, 2, 59000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230051, N'C.P_02', 20220033, 1, 76500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230052, N'C.P_03', 20220034, 1, 81200, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230053, N'C.P_05', 20220034, 2, 125000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230054, N'C.P_02', 20220035, 2, 76500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230055, N'C.P_06', 20220035, 1, 67900, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20230056, N'EP_01', 20220035, 1, 47500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231054, N'C.P_05', 20221035, 5, 125000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231055, N'C.P_07', 20221035, 1, 47500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231056, N'C.P_06', 20221036, 4, 67900, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231057, N'C.P_03', 20221037, 1, 81200, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231058, N'C.P_02', 20221038, 1, 76500, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231059, N'C.P_03', 20221038, 4, 81200, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231060, N'C.P_01', 20221038, 2, 89300, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231061, N'VE.P_02', 20221039, 1, 6100, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231062, N'VE.P_03', 20221039, 1, 6400, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231063, N'SGF.P_03', 20221039, 1, 99000, NULL)
INSERT [dbo].[InvoiceDetail] ([InvoiceDetailId], [ProductId], [InvoiceId], [QuantityNo], [UnitPrice], [Discount]) VALUES (20231064, N'SGF.P_02', 20221039, 2, 35000, NULL)
SET IDENTITY_INSERT [dbo].[InvoiceDetail] OFF
GO
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'C.P_01', N'Ba rọi heo C.P', 500, N'gram', N'49800', N'89300', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'C.P_02', N'Sườn già C.P', 500, N'gram', N'39200', N'76500', N'Sườn già 9-11 miếng')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'C.P_03', N'Đuôi heo C.P', 500, N'gram', N'50000', N'81200', N'Đuôi heo 7-9 miếng')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'C.P_04', N'Thịt đùi C.P', 500, N'gram', N'32400', N'59000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'C.P_05', N'Ba rọi rút sườn C.P', 500, N'gram', N'62000', N'125000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'C.P_06', N'Thịt xay sẵn C.P', 500, N'gram', N'38000', N'67900', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'C.P_07', N'Nạc dăm C.P 300', 300, N'gram', N'27000', N'47500', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_01', N'Tôm thẻ nguyên con khay 250', 250, N'gram', N'30500', N'47500', N'10-13 con')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_02', N'Tôm càng xanh khay 500', 500, N'gram', N'54000', N'96000', N'10-15 con')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_03', N'Cá cam đông lạnh', 2, N'con', N'45000', N'119000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_04', N'Cá chim trắng biển', 400, N'gram', N'55000', N'91000', N'Cá biển ngonn')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_05', N'Cá Thu cắt khúc', 300, N'gram', N'48000', N'94800', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_06', N'Mực ống khay 500', 500, N'gram', N'56000', N'96000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_07', N'Cá hồi nhập khẩu túi 500', 500, N'gram', N'58000', N'98000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_08', N'Xúc xích Đức Việt gói 10', 10, N'Cái', N'22000', N'40000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_09', N'Dầu thực vật Nakydaco 1 lít', 1, N'lít', N'24000', N'43000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_10', N'Dầu thực vật Trường An 5 lít', 5, N'lít', N'150000', N'270000', N'')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_11', N'Đường mía trắng', 1, N'Kg', N'13000', N'28600', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_12', N'Bột ngọt hạt lớn Ajinomoto 454g', 454, N'gram', N'14600', N'34400', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_13', N'Hạt nêm Knorr 400g tặng tương ớt', 400, N'gram', N'18000', N'38500', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_14', N'Muối I-ot Vifon 450g', 450, N'gram', N'3000', N'6200', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_15', N'Nước mắm Nam Ngư 900ml', 900, N'ml', N'23000', N'49000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_16', N'Nước chấm cá cơm 3 Miền 800ml', 800, N'ml', N'12000', N'17000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_17', N'Sữa tươi ít đương TH true Milk 180ml', 4, N'hộp', N'14000', N'26000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'EP_18', N'Sữa lúa mạch ngũ cốc 180ml', 4, N'hộp', N'14000', N'27000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'HE.P_01', N'Hộp 6 trứng gà Happy Egg', 6, N'quả', N'32000', N'48000', N'')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'KF.P_01', N'Hộp 10 trứng gà tươi 4KFarm', 10, N'quả', N'15000', N'28000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'KF.P_02', N'Hộp 4 trứng vịt bắc thảo KFarm', 4, N'quả', N'21000', N'31000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'KF.P_03', N'Hộp 4 trứng vịt muối', 4, N'quả', N'16000', N'26000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'KF.P_04', N'Cài thìa 4KFarm', 500, N'gram', N'4400', N'13400', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'MMF.P_01', N'Cá bống đông lạnh', 200, N'gram', N'12000', N'26000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NP_01', N'Mỳ Hảo Hảo tôm chua cay 75g', 1, N'gói', N'2500', N'4500', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NP_02', N'Mỳ Kokomi tôm chua cay 90g', 1, N'gói', N'1800', N'3500', N'')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NP_03', N'Mỳ 3 Miền tôm chua cay 65g', 1, N'gói', N'1700', N'3500', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NP_04', N'Mỳ Omachi sốt Spaghetti 91g', 1, N'gói', N'2200', N'6500', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NP_05', N'Mỳ Siukay hải sản 85g', 1, N'gói', N'6300', N'11000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NP_06', N'Phở bò Đệ Nhất 65g', 1, N'gói', N'4000', N'7000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NT.P_01', N'Sứa cắt sợi Nhất Tâm', 350, N'gram', N'19000', N'32000', N'')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'NT.P_02', N'Chả ba sa Nhất Tâm', 200, N'gram', N'9000', N'19000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'SGF.P_01', N'Cá hồi phi lê đông lạnh', 200, N'gram', N'62000', N'110000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'SGF.P_02', N'Cá trứng đông lạnh SG Food', 200, N'gram', N'13000', N'35000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'SGF.P_03', N'Chả mực hương vị truyền thống', 250, N'gram', N'44000', N'99000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'TD.P_01', N'Lạp xưởng tươi tiêu, tỏi', 250, N'gram', N'52000', N'84000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'TT.P_01', N'Thịt ba rọi bò Mỹ đông lạnh', 300, N'gram', N'56000', N'97000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_01', N'Xà lách lô lô xanh', 500, N'gram', N'8000', N'18900', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_02', N'Rau húng quế gói 100 gram', 100, N'gram', N'1500', N'6100', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_03', N'Rau diếp cá gói 100 gram', 100, N'gram', N'1200', N'6400', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_04', N'Giá đậu xanh gói 200 gram', 200, N'gram', N'1300', N'5700', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_05', N'Xà lách búp mỡ', 500, N'gram', N'11000', N'27500', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_06', N'Rau răm gói 100g', 100, N'gram', N'1200', N'5200', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_07', N'Cải bẹ xanh', 300, N'gram', N'3600', N'13700', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_08', N'Khoai tây túi 500g', 500, N'gram', N'6100', N'14100', N'3-7 củ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_09', N'Bí đỏ tròn túi 500g', 500, N'gram', N'5500', N'11500', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_10', N'Đậu bắp khay 250g', 250, N'gram', N'3500', N'10500', N'12-18 trái')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_11', N'Khoai lang Nhật túi 1 Kg', 1000, N'gram', N'13200', N'31100', N'4-10 củ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_12', N'Bắp ngô Mỹ', 2, N'bắp', N'9400', N'17100', N'600gram trở lên')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_13', N'Bắp ngô nếp', 2, N'bắp', N'6400', N'18600', N'500 gram trở lên')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_14', N'Ớt chuông xanh', 230, N'gram', N'4000', N'16000', N'1-2 quả')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_15', N'Ớt chuông đỏ', 230, N'gram', N'4500', N'18000', N'1-2 quả')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_16', N'Cà pháo vỉ', 200, N'gram', N'1200', N'8000', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_17', N'Cà chua Beef khay 500g', 500, N'gram', N'13000', N'22000', N'2-4 quả')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_18', N'Cà chua túi 1Kg', 1, N'Kg', N'13200', N'32200', N'10-12 quả')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_19', N'Bông cải xanh', 1, N'Bông', N'7400', N'16100', N'300g trở lên')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_20', N'Tỏi cô đơn túi 300g', 300, N'gram', N'18000', N'38000', N'')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_21', N'Bưởi Diễn tiến vua', 1, N'trái', N'68000', N'142500', N'800g trở lên')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_22', N'Táo Gia Lâm hộp 500g', 500, N'gram', N'5000', N'19000', N'6-10 trái')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_23', N'Táo Gia Lâm hộp 1Kg', 1, N'Kg', N'14000', N'27600', N'20-30 trái')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_24', N'Táo Gala mini Mỹ', 1, N'Kg', N'26000', N'47900', NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_25', N'Cam sành Bắc Giang', 1, N'Kg', N'10000', N'21600', N'5-7 trái')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_26', N'Cam vàng Úc', 1, N'Kg', N'34000', N'62000', N'3-5 trái')
INSERT [dbo].[Product] ([ProductId], [ProductName], [ProductQuantity], [ProductUnit], [ImportPrice], [ExportPrice], [ProductDescription]) VALUES (N'VE.P_27', N'Dưa hấu không hạt', 1, N'Trái', N'32000', N'58900', N'2.8 Kg trở lên')
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffId], [StaffAccount], [StaffPassword], [StaffIDPer], [StaffName], [StaffGender], [StaffAdress], [StaffPhone], [StaffBirthday]) VALUES (1, N'manager', N'manager', N'1', N'Nguyễn Kim Hùng', N'Nam', N'--', N'0487473749', CAST(N'2002-04-29T00:00:00.000' AS DateTime))
INSERT [dbo].[Staff] ([StaffId], [StaffAccount], [StaffPassword], [StaffIDPer], [StaffName], [StaffGender], [StaffAdress], [StaffPhone], [StaffBirthday]) VALUES (2, N'admin1', N'admin1', N'0', N'Trần Văn Dũng', N'Nam', N'--', N'0678543976', CAST(N'2002-03-29T00:00:00.000' AS DateTime))
INSERT [dbo].[Staff] ([StaffId], [StaffAccount], [StaffPassword], [StaffIDPer], [StaffName], [StaffGender], [StaffAdress], [StaffPhone], [StaffBirthday]) VALUES (3, N'admin2', N'admin2', N'0', N'Lê Anh Vũ', N'Nam', N'--', N'0423868024', CAST(N'2002-06-24T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Staff] OFF
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
/****** Object:  StoredProcedure [dbo].[AuthoLogin]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[CreateInvoice]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[CreateInvoiceDetail]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Get_InvoiceId]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddCategory]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddCustomer]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddFeature]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddFeatureByCategory]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddFeatureByProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddSticker]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteCustomer]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteFeature]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteSticker]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetCategoryName]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetCustomerId]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetCustomerName]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetDataCategory]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetDataCustomer]    Script Date: 2/19/2023 1:16:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_GetDataCustomer]
as
select Customer.CustomerId as N'Mã khách hàng', Customer.CustomerName as N'Tên khách hàng', Customer.CustomerPhone as N'SĐT khách hàng'
from Customer;
GO
/****** Object:  StoredProcedure [dbo].[proc_GetDataFeature]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetDataPayment]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetDataProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetDataSticker]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetFeatureIdByFeatureName]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetFeatureName]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetLastestCategoryId]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetProductInformationForInvoice]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetSortedDataPayment]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetStaffId]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetStaffName]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetSuggestions]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetTotalProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_GetTotalSearchProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_RecommendTrendingProducts]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_SearchDataCustomer]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_SearchDataFeature]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_SearchDataPayment]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_SearchDataProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateCustomer]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateFeature]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateProduct]    Script Date: 2/19/2023 1:16:06 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateSticker]    Script Date: 2/19/2023 1:16:06 PM ******/
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
