USE [QUANLIDOANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[GetAccountByUserName]    Script Date: 5/9/2021 2:38:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAccountByUserName]
@userName nvarchar(20)
as 
begin
	select * from dbo.Account where userName = @userName
end

GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 5/9/2021 2:38:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login]
@userName nvarchar(20), @passWord nvarchar(50)
as
begin
select * from dbo.Account where userName = @userName and passWord = @passWord
end

GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/9/2021 2:38:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NULL,
	[passWord] [nvarchar](50) NULL,
	[type] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiDoan]    Script Date: 5/9/2021 2:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiDoan](
	[macd] [nchar](30) NOT NULL,
	[tencd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChiDoan] PRIMARY KEY CLUSTERED 
(
	[macd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DiemDanh]    Script Date: 5/9/2021 2:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemDanh](
	[Id] [int] NOT NULL,
	[madv] [nchar](30) NOT NULL,
	[mahd] [int] NOT NULL,
	[ghichu] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoanVien]    Script Date: 5/9/2021 2:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanVien](
	[madv] [nchar](30) NOT NULL,
	[tendv] [nvarchar](50) NOT NULL,
	[ns] [datetime] NOT NULL,
	[que] [nvarchar](max) NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[ngayvd] [datetime] NOT NULL,
	[dt] [nvarchar](30) NOT NULL,
	[macd] [nchar](30) NULL,
 CONSTRAINT [PK_DoanVien] PRIMARY KEY CLUSTERED 
(
	[madv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoatDong]    Script Date: 5/9/2021 2:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoatDong](
	[mahd] [int] NOT NULL,
	[tenhd] [nvarchar](max) NOT NULL,
	[thoigiantc] [date] NOT NULL,
	[ghichu] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_HoatDong] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 5/9/2021 2:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[makt] [int] NOT NULL,
	[madv] [nchar](30) NOT NULL,
	[tenkt] [nvarchar](30) NOT NULL,
	[thanhtich] [nvarchar](50) NOT NULL,
	[namhoc] [int] NOT NULL,
 CONSTRAINT [PK_KhenThuong] PRIMARY KEY CLUSTERED 
(
	[makt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XepLoai]    Script Date: 5/9/2021 2:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XepLoai](
	[ID] [int] NOT NULL,
	[madv] [nchar](30) NOT NULL,
	[namhoc] [int] NOT NULL,
	[nhanxet] [nvarchar](max) NOT NULL,
	[xeploai] [nvarchar](10) NOT NULL,
	[mahd] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[DiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_DoanVien] FOREIGN KEY([madv])
REFERENCES [dbo].[DoanVien] ([madv])
GO
ALTER TABLE [dbo].[DiemDanh] CHECK CONSTRAINT [FK_DiemDanh_DoanVien]
GO
ALTER TABLE [dbo].[DiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_HoatDong] FOREIGN KEY([mahd])
REFERENCES [dbo].[HoatDong] ([mahd])
GO
ALTER TABLE [dbo].[DiemDanh] CHECK CONSTRAINT [FK_DiemDanh_HoatDong]
GO
ALTER TABLE [dbo].[DoanVien]  WITH CHECK ADD  CONSTRAINT [FK_DoanVien_ChiDoan] FOREIGN KEY([macd])
REFERENCES [dbo].[ChiDoan] ([macd])
GO
ALTER TABLE [dbo].[DoanVien] CHECK CONSTRAINT [FK_DoanVien_ChiDoan]
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_KhenThuong_DoanVien] FOREIGN KEY([madv])
REFERENCES [dbo].[DoanVien] ([madv])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK_KhenThuong_DoanVien]
GO
ALTER TABLE [dbo].[XepLoai]  WITH CHECK ADD  CONSTRAINT [FK_XepLoai_DoanVien] FOREIGN KEY([madv])
REFERENCES [dbo].[DoanVien] ([madv])
GO
ALTER TABLE [dbo].[XepLoai] CHECK CONSTRAINT [FK_XepLoai_DoanVien]
GO
ALTER TABLE [dbo].[XepLoai]  WITH CHECK ADD  CONSTRAINT [FK_XepLoai_HoatDong] FOREIGN KEY([mahd])
REFERENCES [dbo].[HoatDong] ([mahd])
GO
ALTER TABLE [dbo].[XepLoai] CHECK CONSTRAINT [FK_XepLoai_HoatDong]
GO
