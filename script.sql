USE [QLNV]
GO
/****** Object:  Table [dbo].[BangCongChiTiet]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCongChiTiet](
	[ID] [int] NOT NULL,
	[MaKC] [char](10) NULL,
	[MaNV] [char](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[ngay] [datetime] NULL,
	[thu] [nvarchar](50) NULL,
	[giovao] [nvarchar](50) NULL,
	[ngaycong] [int] NULL,
	[ngayphep] [int] NULL,
	[kyhieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangCongChiTiet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [char](10) NOT NULL,
	[TenCV] [nvarchar](30) NULL,
	[MaQuyen] [char](10) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[MaKT] [char](10) NOT NULL,
	[NgayKhenThuong] [date] NULL,
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NoiDungKT] [nvarchar](50) NULL,
	[HinhThuc] [nvarchar](50) NULL,
	[TienThuong] [int] NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Table_1_1] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyCong]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyCong](
	[MaKC] [char](10) NOT NULL,
	[thang] [int] NOT NULL,
	[nam] [int] NOT NULL,
	[ngaytinhcong] [datetime] NOT NULL,
	[ngaycongtrongthang] [int] NULL,
	[trangthai] [bit] NULL,
 CONSTRAINT [PK_KyCong] PRIMARY KEY CLUSTERED 
(
	[MaKC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyCongChiTiet]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyCongChiTiet](
	[MaKC] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[D1] [nvarchar](10) NULL,
	[D2] [nvarchar](10) NULL,
	[D3] [nvarchar](10) NULL,
	[D4] [nvarchar](10) NULL,
	[D5] [nvarchar](10) NULL,
	[D6] [nvarchar](10) NULL,
	[D7] [nvarchar](10) NULL,
	[D8] [nvarchar](10) NULL,
	[D9] [nvarchar](10) NULL,
	[D10] [nvarchar](10) NULL,
	[D11] [nvarchar](10) NULL,
	[D12] [nvarchar](10) NULL,
	[D13] [nvarchar](10) NULL,
	[D14] [nvarchar](10) NULL,
	[D15] [nvarchar](10) NULL,
	[D16] [nvarchar](10) NULL,
	[D17] [nvarchar](10) NULL,
	[D18] [nvarchar](10) NULL,
	[D19] [nvarchar](10) NULL,
	[D20] [nvarchar](10) NULL,
	[D21] [nvarchar](10) NULL,
	[D22] [nvarchar](10) NULL,
	[D23] [nvarchar](10) NULL,
	[D24] [nvarchar](10) NULL,
	[D25] [nvarchar](10) NULL,
	[D26] [nvarchar](10) NULL,
	[D27] [nvarchar](10) NULL,
	[D28] [nvarchar](10) NULL,
	[D29] [nvarchar](10) NULL,
	[D30] [nvarchar](10) NULL,
	[D31] [nvarchar](10) NULL,
	[ngaycong] [int] NOT NULL,
	[ngayphep] [int] NOT NULL,
	[tongngaycong] [int] NOT NULL,
 CONSTRAINT [PK_KyCongChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaKC] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyLuat](
	[MaKL] [char](10) NOT NULL,
	[NgayKyLuat] [date] NULL,
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NoiDungKL] [nvarchar](50) NULL,
	[HinhThuc] [nvarchar](50) NULL,
	[TienKL] [int] NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[MaKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[MaNV] [char](10) NOT NULL,
	[LuongCoBan] [int] NULL,
	[NgayLanh] [date] NULL,
	[MaKT] [char](10) NULL,
	[MaKL] [char](10) NULL,
	[MaCV] [char](10) NULL,
	[MaLuong] [float] NULL,
	[TongLuong] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [char](15) NULL,
	[CCCD] [char](15) NULL,
	[MaPB] [char](10) NOT NULL,
	[MaCV] [char](10) NOT NULL,
	[MaLuong] [float] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [char](10) NOT NULL,
	[TenQuyen] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [char](10) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[Matrphong] [char](10) NOT NULL,
	[NgayNhamChuc] [date] NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 29/05/2022 6:41:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[MaNV] [char](10) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[PhanQuyen] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [MaQuyen]) VALUES (N'CV01      ', N'Nhân viên', N'MQ04      ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [MaQuyen]) VALUES (N'CV02      ', N'Phó phòng', N'MQ03      ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [MaQuyen]) VALUES (N'CV03      ', N'Trưởng phòng', N'MQ02      ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [MaQuyen]) VALUES (N'CV05      ', N'Giám đốc', N'MQ01      ')
GO
INSERT [dbo].[KhenThuong] ([MaKT], [NgayKhenThuong], [MaNV], [TenNV], [NoiDungKT], [HinhThuc], [TienThuong], [TrangThai]) VALUES (N'KT01      ', CAST(N'2022-04-10' AS Date), N'210089    ', N'Trần Hoàng Thanh Thy', N'Hoàn thành KPI', N'Thưởng Tiền', 9000000, N'Chưa Khen Thưởng')
INSERT [dbo].[KhenThuong] ([MaKT], [NgayKhenThuong], [MaNV], [TenNV], [NoiDungKT], [HinhThuc], [TienThuong], [TrangThai]) VALUES (N'KT02      ', CAST(N'2022-05-04' AS Date), N'210089    ', N'Trần Hoàng Thanh Thy', N'Vượt KPI', N'Voucher ', 0, N'1')
INSERT [dbo].[KhenThuong] ([MaKT], [NgayKhenThuong], [MaNV], [TenNV], [NoiDungKT], [HinhThuc], [TienThuong], [TrangThai]) VALUES (N'KT03      ', CAST(N'2022-05-17' AS Date), N'210086    ', N'Lê Bá Học', N'Hoàn thành KPI', N'Thưởng tiền', 698, N'1')
INSERT [dbo].[KhenThuong] ([MaKT], [NgayKhenThuong], [MaNV], [TenNV], [NoiDungKT], [HinhThuc], [TienThuong], [TrangThai]) VALUES (N'KT04      ', CAST(N'2022-05-10' AS Date), N'210082    ', N'210077    ', N'giỏi', N'tiền', 55, N'1')
GO
INSERT [dbo].[KyCong] ([MaKC], [thang], [nam], [ngaytinhcong], [ngaycongtrongthang], [trangthai]) VALUES (N'202201    ', 1, 2022, CAST(N'2022-05-27T00:00:00.000' AS DateTime), 26, 1)
GO
INSERT [dbo].[KyLuat] ([MaKL], [NgayKyLuat], [MaNV], [TenNV], [NoiDungKL], [HinhThuc], [TienKL], [TrangThai]) VALUES (N'KL01      ', CAST(N'2022-05-17' AS Date), N'NV01      ', N'Yến Dương', N'Ngủ trễ', N'Viết kiểm điểm', 0, N'Đã Kỷ Luật')
INSERT [dbo].[KyLuat] ([MaKL], [NgayKyLuat], [MaNV], [TenNV], [NoiDungKL], [HinhThuc], [TienKL], [TrangThai]) VALUES (N'KL02      ', CAST(N'2022-05-15' AS Date), N'210089    ', N'Trần Hoàng Thanh Thy', N'Đi làm trễ ', N'Phạt tiền', 500000, N'Đã Kỷ Luật')
INSERT [dbo].[KyLuat] ([MaKL], [NgayKyLuat], [MaNV], [TenNV], [NoiDungKL], [HinhThuc], [TienKL], [TrangThai]) VALUES (N'KL03      ', CAST(N'2022-05-10' AS Date), N'210082    ', N'Nguyễn La Huệ Uyên', N'Sai sót báo cáo', N'Đình chỉ 1 tuần', 0, N'Đã Kỷ Luật')
INSERT [dbo].[KyLuat] ([MaKL], [NgayKyLuat], [MaNV], [TenNV], [NoiDungKL], [HinhThuc], [TienKL], [TrangThai]) VALUES (N'KL04      ', CAST(N'2022-05-04' AS Date), N'210086    ', N'Nguyễn Ngọc Ánh Tuyết', N'Sai sót báo cáo', N'Đình chỉ tuần', 0, N'Đã Kỷ Luật')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [CCCD], [MaPB], [MaCV], [MaLuong], [TrangThai]) VALUES (N'210077    ', N'Nguyễn Ngọc Ánh Tuyết', CAST(N'1994-10-13' AS Date), N'Nữ', N'260 Phan Đăng Lưu', N'065599623649   ', N'09873216542    ', N'MR01      ', N'CV01      ', 0, N'Danghiviec')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [CCCD], [MaPB], [MaCV], [MaLuong], [TrangThai]) VALUES (N'210082    ', N'Nguyễn La Huệ Uyên', CAST(N'2002-06-10' AS Date), N'Nam', N'20 Nguyễn Thị NHỏ', N'09956544466    ', N'0123456789     ', N'MR01      ', N'CV03      ', 0, N'Danglamviec')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [CCCD], [MaPB], [MaCV], [MaLuong], [TrangThai]) VALUES (N'210086    ', N'Lê Bá Học', CAST(N'2001-04-16' AS Date), N'1', N'Bien Hòa, Đồng Nai', N'0564643131556  ', N'0654321987     ', N'MR01      ', N'CV03      ', 0, N'Danglamviec')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [CCCD], [MaPB], [MaCV], [MaLuong], [TrangThai]) VALUES (N'210089    ', N'Trần Hoàng Thanh Thy', CAST(N'2002-02-06' AS Date), N'Nam', N'111CT Tam Đảo', N'0819964156     ', N'079302014785   ', N'IT01      ', N'CV03      ', 0, N'Danglamviec')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [CCCD], [MaPB], [MaCV], [MaLuong], [TrangThai]) VALUES (N'NV01      ', N'Yến Dương', CAST(N'2002-04-15' AS Date), N'0', N'Xóm Củi', N'096468768444   ', N'0789456123     ', N'IT01      ', N'CV01      ', 0, N'Danglamviec')
GO
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (N'MQ01      ', N'Quản Trị')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (N'MQ02      ', N'Super Admin')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (N'MQ03      ', N'Admin')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (N'MQ04      ', N'User')
GO
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [Matrphong], [NgayNhamChuc], [TrangThai]) VALUES (N'IT01      ', N'Technology Information', N'MIT01     ', CAST(N'2021-05-22' AS Date), N'Đang hoạt động')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [Matrphong], [NgayNhamChuc], [TrangThai]) VALUES (N'MR01      ', N'Chăm sóc khách hàng', N'MMR01     ', CAST(N'2020-02-20' AS Date), N'Dừng hoạt động')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [Matrphong], [NgayNhamChuc], [TrangThai]) VALUES (N'PB05      ', N'HR01', N'MHR11     ', CAST(N'2022-05-10' AS Date), N'Đang hoạt động')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [Matrphong], [NgayNhamChuc], [TrangThai]) VALUES (N'PB07      ', N'Chăm sóc khách hàng', N'MCSKH     ', CAST(N'2022-07-22' AS Date), N'Ngưng hoạt động')
GO
INSERT [dbo].[Taikhoan] ([MaNV], [TenDangNhap], [MatKhau], [PhanQuyen]) VALUES (N'NV01      ', N'duong123', N'admin', N'Nhân Viên')
INSERT [dbo].[Taikhoan] ([MaNV], [TenDangNhap], [MatKhau], [PhanQuyen]) VALUES (N'210089    ', N'thy123', N'admin', N'Trưởng Phòng')
GO
ALTER TABLE [dbo].[BangCongChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_BangCongChiTiet_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BangCongChiTiet] CHECK CONSTRAINT [FK_BangCongChiTiet_NhanVien]
GO
ALTER TABLE [dbo].[ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_ChucVu_PhanQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[ChucVu] CHECK CONSTRAINT [FK_ChucVu_PhanQuyen]
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_KhenThuong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK_KhenThuong_NhanVien]
GO
ALTER TABLE [dbo].[KyCongChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_KyCongChiTiet_KyCong] FOREIGN KEY([MaKC])
REFERENCES [dbo].[KyCong] ([MaKC])
GO
ALTER TABLE [dbo].[KyCongChiTiet] CHECK CONSTRAINT [FK_KyCongChiTiet_KyCong]
GO
ALTER TABLE [dbo].[KyCongChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_KyCongChiTiet_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KyCongChiTiet] CHECK CONSTRAINT [FK_KyCongChiTiet_NhanVien]
GO
ALTER TABLE [dbo].[KyLuat]  WITH CHECK ADD  CONSTRAINT [FK_KyLuat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KyLuat] CHECK CONSTRAINT [FK_KyLuat_NhanVien]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[Taikhoan]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
