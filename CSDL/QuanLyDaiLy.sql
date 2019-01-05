--database QuanLyDaiLy
IF DB_ID (N'QuanLyDaiLy') IS NOT NULL
DROP DATABASE QuanLyDaiLy
GO
create database QuanLyDaiLy
go
use QuanLyDaiLy
go

--tạo bảng
create table DAILY 
(
	MaDaiLy char(10)NOT NULL PRIMARY KEY,
	TenDaiLy nvarchar(50),
	DienThoai char(15),	
	DiaChi nvarchar(231),
	NgayTiepNhan datetime,
	Email char(30),
	TienNo int,
	--thuộc tính khóa phụ
	MaLoaiDaiLy int,
	MaQuan char(10)
);
go
create table BAOCAODOANHSO 
(
	MaBaoCaoDoanhSo char(10) NOT NULL PRIMARY KEY,
	Thang int	
);
go
create table DOANHSO_DAILY 
(
	MaBaoCaoDoanhSo char(10), 
	MaDaiLy char(10),
	SoPhieuXuat int,
	TongTriGia int,
	TyLe int,
	
	PRIMARY KEY(MaBaoCaoDoanhSo,MaDaiLy)
);
go
create table BAOCAOCONGNO
(
	MaBaoCaoCongNo char(10) NOT NULL PRIMARY KEY,
	Thang int
);
go
create table CONGNO_DAILY
(
	MaBaoCaoCongNo char(10),
	MaDaiLy char(10),
	NoDau int,
	PhatSinh int,
	NoCuoi int,
	--khóa ngoại
	PRIMARY KEY(MaBaoCaoCongNo,MaDaiLy)
);
go
create table QUAN
(
	MaQuan char(10) NOT NULL PRIMARY KEY,
	TenQuan nvarchar(50),
);
go
create table THAMSO 
(
	ID int NOT NULL Primary key,
	SoDaiLyToiDaQuan int,
	SoMatHang int,
	SoDonViTinh int
);
go
------------------------------------------
create table MATHANG
(
	MaMatHang char(10)NOT NULL PRIMARY KEY,
	TenMatHang nvarchar(100),
	DonGia int,
	SoLuongTon int
)
go
create table PHIEUXUATHANG
(
	MaPhieuXuat char(10)NOT NULL PRIMARY KEY,
	NgayLapPhieu Datetime,
	TongTien int,
	--khóa ngoại 
	MaDaiLy char(10)
)
go
create table PHIEUTHUTIEN
(
	MaPhieuThu char(10)NOT NULL PRIMARY KEY,
	NgayThuTien Datetime,
	SoTienThu int,
	--khóa ngoại
	MaDaiLy char(10)
)
go
create table LOAIDAILY
(
	MaLoaiDaiLy  int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TenLoaiDaiLy nvarchar(100),
	TienNoToiDa int
)
go
create table DONVITINH
(
	MaDonViTinh int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TenDonViTinh nvarchar(50)
)
go
create table PHIEUXUAT_MATHANG
(
	MaPhieuXuat char(10),
	MaMatHang char(10),
	SoLuong int,
	ThanhTien int,
	--khoangoai
	MaDonViTinh int,
	PRIMARY KEY(MaPhieuXuat,MaMatHang)
	
)
------------------------------------------
go
-----------------------------khoa ngoai
--k1 --DAILY
ALTER TABLE [dbo].[DAILY]  WITH CHECK
ADD  CONSTRAINT [FK_DAILY_LOAIDAILY] FOREIGN KEY([MaLoaiDaiLy])
REFERENCES [dbo].[LOAIDAILY] ([MaLoaiDaiLy])
GO
--k2 --DAILY
ALTER TABLE [dbo].[DAILY]  WITH CHECK 
ADD  CONSTRAINT [FK_DAILY_QUAN] FOREIGN KEY([MaQuan])
REFERENCES [dbo].[QUAN] ([MaQuan])
GO
--k3 --DOANHSO_DAILY DAILY
ALTER TABLE [dbo].[DOANHSO_DAILY]  WITH CHECK 
ADD  CONSTRAINT [FK_DOANHSO_DAILY_DAILY] FOREIGN KEY([MaDaiLy])
REFERENCES [dbo].[DAILY] ([MaDaiLy])
GO
--k33 --DOANHSO_DAILY BAOCAODOANHSO
ALTER TABLE [dbo].[DOANHSO_DAILY]  WITH CHECK 
ADD  CONSTRAINT [FK_DOANHSO_DAILY_DOANHSO] FOREIGN KEY([MaBaoCaoDoanhSo])
REFERENCES [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo])
GO
--k4 --CONGNO_DAILY DAILY
ALTER TABLE [dbo].[CONGNO_DAILY]  WITH CHECK 
ADD  CONSTRAINT [FK_CONGNO_DAILY_DAILY] FOREIGN KEY([MaDaiLy])
REFERENCES [dbo].[DAILY] ([MaDaiLy])
GO
--k44 --CONGNO_DAILY BAOCAOCONGNO
ALTER TABLE [dbo].[CONGNO_DAILY]  WITH CHECK 
ADD  CONSTRAINT [FK_CONGNO_DAILY_CONGNO] FOREIGN KEY([MaBaoCaoCongNo])
REFERENCES [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo])
GO
-----------------------
--k5 --PHIEUXUAT_MATHANG
ALTER TABLE [dbo].[PHIEUXUAT_MATHANG]  WITH CHECK
ADD  CONSTRAINT [FK_PHIEUXUATMATHANG_MATHANG] FOREIGN KEY([MaMatHang])
REFERENCES [dbo].[MATHANG] ([MaMatHang])
GO
--k6 --PHIEUXUAT_MATHANG
ALTER TABLE [dbo].[PHIEUXUAT_MATHANG]  WITH CHECK
ADD  CONSTRAINT [FK_PHIEUXUATMATHANG_DONVITINH] FOREIGN KEY([MaDonViTinh])
REFERENCES [dbo].[DONVITINH] ([MaDonViTinh])
GO
--k7 --PHIEUXUAT_MATHANG
ALTER TABLE [dbo].[PHIEUXUAT_MATHANG]  WITH CHECK
ADD  CONSTRAINT [FK_PHIEUXUATMATHANG_PHIEUXUATHANG] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUATHANG] ([MaPhieuXuat])
GO
--k8 --PHIEUXUATHANG
ALTER TABLE [dbo].[PHIEUXUATHANG]  WITH CHECK
ADD  CONSTRAINT [FK_PHIEUXUATHANG_DAILY] FOREIGN KEY([MaDaiLy])
REFERENCES [dbo].[DAILY] ([MaDaiLy])
GO
--k9 --PHIEUTHUTIEN
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK
ADD  CONSTRAINT [FK_PHIEUTHUTIEN_DAILY] FOREIGN KEY([MaDaiLy])
REFERENCES [dbo].[DAILY] ([MaDaiLy])
GO


-----------------------
--INSERT
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q1        ', N'Quận 1')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q10       ', N'Quận 10')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q11       ', N'Quận 11')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q12       ', N'Quận 12')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q13       ', N'Quận Âu Cơ')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q14       ', N'Quận Đại Việt')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q15       ', N'Quận Đại Nam')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q16       ', N'Quận Cầu Giấy')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q17       ', N'Quận Lạc Hồng')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q18       ', N'Quận Hùng Vương')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q19       ', N'Quận Bà Triệu')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q2        ', N'Quận 2')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q20       ', N'Quận Sang')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q3        ', N'Quận 3')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q4        ', N'Quận 4')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q5        ', N'Quận 5')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q6        ', N'Quận 6')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q7        ', N'Quận 7')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q8        ', N'Quận 8')
INSERT [dbo].[QUAN] ([MaQuan], [TenQuan]) VALUES (N'Q9        ', N'Quận 9')
--
SET IDENTITY_INSERT [dbo].[LOAIDAILY] ON 
INSERT [dbo].[LOAIDAILY] ([MaLoaiDaiLy], [TenLoaiDaiLy], [TienNoToiDa]) VALUES (1, N'VIP', 20000)
INSERT [dbo].[LOAIDAILY] ([MaLoaiDaiLy], [TenLoaiDaiLy], [TienNoToiDa]) VALUES (2, N'Thường', 50)
SET IDENTITY_INSERT [dbo].[LOAIDAILY] OFF
--
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL1       ', N'Hiếu Đẹp Trai', N'012345678      ', N'Trần Hưng Đạo', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'hieudona8@gmail.com           ', 0, 1, N'Q1        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL10      ', N'libra', N'07368394       ', N'Nguyễn Trãi', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'libra@gmail.com               ', 10000, 1, N'Q5        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL2       ', N'Sally', N'03028382       ', N'An Dương Vương', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'sally@gmail.com               ', 12000, 1, N'Q3        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL3       ', N'Campus', N'034882939      ', N'Nguyễn Văn Cừ', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'campus@gmail.com              ', 0, 2, N'Q5        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL4       ', N'Aries', N'03028382       ', N'An Dương Vương', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'aries@gmail.com               ', 50, 2, N'Q3        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL5       ', N'Taurus', N'012388959      ', N'Tông Đức Thắng', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'taurus@gmail.com              ', 20000, 1, N'Q3        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL6       ', N'Gemini', N'04538384       ', N'Hai Bà Trưng', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'gemini@gmail.com              ', 12000, 1, N'Q3        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL7       ', N'Cancer', N'034838489      ', N'Nguyễn Thiện Thuật', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'cancer@gamil.com              ', 50, 2, N'Q1        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL8       ', N'Leo', N'0848434343     ', N'Trần Bình Trọng', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'leo@gmail.com                 ', 20000, 1, N'Q1        ')
INSERT [dbo].[DAILY] ([MaDaiLy], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [TienNo], [MaLoaiDaiLy], [MaQuan]) VALUES (N'DL9       ', N'Virgo', N'04493939       ', N'Nguyễn Huệ', CAST(N'2008-12-21T00:00:00.000' AS DateTime), N'virgo@gmail.com               ', 50, 2, N'Q1        ')

--
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang]) VALUES (N'BCCN1     ', 1)
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang]) VALUES (N'BCCN2     ', 2)
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang]) VALUES (N'BCCN3     ', 3)
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang]) VALUES (N'BCCN4     ', 4)
--
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS1     ', 1)
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS2     ', 3)
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS3     ', 4)
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS4     ', 2)
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS5     ', 4)
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS6     ', 10)
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS7     ', 1)
INSERT [dbo].[BAOCAODOANHSO] ([MaBaoCaoDoanhSo], [Thang]) VALUES (N'BCDS8     ', 12)
--
--
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX1       ', CAST(N'2010-01-01T00:00:00.000' AS DateTime), 10000000, N'DL1       ')
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX2       ', CAST(N'2017-03-03T00:00:00.000' AS DateTime), 20000000, N'DL1       ')
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX3       ', CAST(N'2018-04-04T00:00:00.000' AS DateTime), 30000000, N'DL1       ')
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX4       ', CAST(N'2018-02-02T00:00:00.000' AS DateTime), 20000000, N'DL2       ')
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX5       ', CAST(N'2018-04-05T00:00:00.000' AS DateTime), 15000000, N'DL2       ')
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX6       ', CAST(N'2017-10-29T00:00:00.000' AS DateTime), 21000000, N'DL3       ')
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX7       ', CAST(N'2016-01-30T00:00:00.000' AS DateTime), 18000000, N'DL3       ')
INSERT [dbo].[PHIEUXUATHANG] ([MaPhieuXuat], [NgayLapPhieu], [TongTien], [MaDaiLy]) VALUES (N'PX8       ', CAST(N'2014-12-12T00:00:00.000' AS DateTime), 30000000, N'DL4       ')
--

INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT1       ', CAST(N'2010-01-02T00:00:00.000' AS DateTime), 10000000, N'DL1       ')
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT2       ', CAST(N'2017-03-04T00:00:00.000' AS DateTime), 20000000, N'DL1       ')
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT3       ', CAST(N'2018-04-05T00:00:00.000' AS DateTime), 30000000, N'DL1       ')
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT4       ', CAST(N'2018-02-03T00:00:00.000' AS DateTime), 20000000, N'DL2       ')
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT5       ', CAST(N'2018-04-06T00:00:00.000' AS DateTime), 15000000, N'DL2       ')
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT6       ', CAST(N'2017-10-30T00:00:00.000' AS DateTime), 21000000, N'DL3       ')
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT7       ', CAST(N'2016-01-31T00:00:00.000' AS DateTime), 18000000, N'DL3       ')
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [NgayThuTien], [SoTienThu], [MaDaiLy]) VALUES (N'PT8       ', CAST(N'2014-12-14T00:00:00.000' AS DateTime), 30000000, N'DL4       ')

--
SET IDENTITY_INSERT [dbo].[DONVITINH] ON 
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (1, N'VND')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (2, N'USD')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (3, N'ERO')
SET IDENTITY_INSERT [dbo].[DONVITINH] OFF
--
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH1       ', N'Tủ Lạnh', 5000000, 500)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH2       ', N'TiVi', 8000000, 100)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH3       ', N'Xe Máy', 50000000, 100)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH4       ', N'Lò vi sóng', 5000000, 200)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH5       ', N'Máy Tính', 20000000, 200)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH6       ', N'Chuột không dây', 500000, 300)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH7       ', N'Guitar', 8000000, 100)
INSERT [dbo].[MATHANG] ([MaMatHang], [TenMatHang], [DonGia], [SoLuongTon]) VALUES (N'MH8       ', N'Ổ cứng SSD', 2000000, 100)
--
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX1       ', N'MH1       ', 2, 10000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX2       ', N'MH1       ', 1, 5000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX2       ', N'MH4       ', 3, 5000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX3       ', N'MH4       ', 2, 10000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX3       ', N'MH5       ', 1, 2000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX4       ', N'MH5       ', 1, 20000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX5       ', N'MH4       ', 3, 15000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX6       ', N'MH5       ', 1, 20000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX7       ', N'MH4       ', 3, 15000000, 1)
INSERT [dbo].[PHIEUXUAT_MATHANG] ([MaPhieuXuat], [MaMatHang], [SoLuong], [ThanhTien], [MaDonViTinh]) VALUES (N'PX8       ', N'MH8       ', 15, 30000000, 1)

-------------------------------
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN1     ', N'DL1       ',150000,30000,180000)
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN2     ', N'DL2       ',190000,10000,200000)
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN3     ', N'DL2       ',543000,183500,726500)
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN1     ', N'DL5       ',150000,30000,180000)
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN3     ', N'DL6       ',151510,18501,170011)
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN4     ', N'DL3       ',190000,10000,200000)
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN2     ', N'DL4       ',125000,3600,128600)
INSERT [dbo].[CONGNO_DAILY] ([MaBaoCaoCongNo], [MaDaiLy], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'BCCN1     ', N'DL8       ',150000,30000,180000)
---
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS1     ', N'DL1       ',25,2358000,10)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS1     ', N'DL2       ',5,88000,5)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS2     ', N'DL5       ',8,11500,8)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS4     ', N'DL3       ',11,550000,20)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS3     ', N'DL4       ',10,52000,14)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS5     ', N'DL1       ',2,2358000,10)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS7     ', N'DL2       ',8,150000,15)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS8     ', N'DL5       ',6,50500,9)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS8     ', N'DL3       ',2,10000,1)
INSERT [dbo].[DOANHSO_DAILY] ([MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongTriGia], [TyLe]) VALUES (N'BCDS4     ', N'DL4       ',10,52000,14)

INSERT [dbo].[THAMSO] ([ID], [SoDaiLyToiDaQuan], [SoMatHang], [SoDonViTinh]) VALUES (1, 4, 5, 3)