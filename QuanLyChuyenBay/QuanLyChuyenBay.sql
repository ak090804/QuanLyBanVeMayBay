CREATE DATABASE QuanLyBanVeMayBay
go
USE QuanLyBanVeMayBay

-------------------
USE master;
GO
ALTER DATABASE QuanLyBanVeMayBay SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

DROP DATABASE QuanLyBanVeMayBay
-------------------
----bang tai khoan
CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50) UNIQUE, -- Đảm bảo tên tài khoản là duy nhất
    MatKhau NVARCHAR(100)
)

CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
    Email NVARCHAR(100),
    NgaySinh DATE CHECK (NgaySinh <= GETDATE()), -- Kiểm tra ngày sinh nhỏ hơn hoặc bằng ngày hiện tại
    SoDienThoai NVARCHAR(20),	
    MaTaiKhoan INT,
    CONSTRAINT FK_KHACHHANG_TAIKHOAN FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
)





CREATE TABLE HanhKhach (
    MaHanhKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    QuocTich NVARCHAR(50),
    NgaySinh DATE CHECK (NgaySinh <= GETDATE()), -- Kiểm tra ngày sinh nhỏ hơn hoặc bằng ngày hiện tại
    SoDienThoai NVARCHAR(20) UNIQUE, -- Đảm bảo số điện thoại là duy nhất
    Email NVARCHAR(100),
    CCCD_Passport NVARCHAR(20) UNIQUE, -- Đảm bảo CCCD/Passport là duy nhất
	MaKhachHang INT,
	CONSTRAINT FK_HANHKHACH_KHACHHANG foreign key (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE SanBay (
    MaSanBay INT IDENTITY(1,1) PRIMARY KEY,
    TenSanBay NVARCHAR(100) UNIQUE, -- Đảm bảo tên sân bay là duy nhất
    TenThanhPho NVARCHAR(100),
    VietTatSanBay NVARCHAR(10) UNIQUE -- Đảm bảo viết tắt sân bay là duy nhất
);

CREATE TABLE LoTrinh (
    MaLoTrinh INT IDENTITY(1,1) PRIMARY KEY,
	TenLoTrinh NVARCHAR(100),
    MaSB_Di INT,
    MaSB_Den INT,
	CONSTRAINT FK_MASBDI_SB FOREIGN KEY (MaSB_Di) REFERENCES SANBAY(MaSanBay),
	CONSTRAINT FK_MASBDEN_SB FOREIGN KEY (MaSB_Den) REFERENCES SANBAY(MaSanBay),
);	

CREATE TABLE HangHangKhong (
    MaHangHangKhong INT IDENTITY(1,1) PRIMARY KEY,
    TenHangHangKhong NVARCHAR(100) NOT NULL -- Tên hãng hàng không không được null
);


CREATE TABLE TrangThaiChuyenBay (
    MaTrangThaiChuyenBay INT IDENTITY(1,1) PRIMARY KEY,
    TenTrangThaiChuyenBay NVARCHAR(40) 
);
CREATE TABLE MayBay (
    MaMayBay INT IDENTITY(1,1) PRIMARY KEY,
    TenMayBay NVARCHAR(100) NOT NULL,
    SucChuaToiDa INT CHECK (SucChuaToiDa > 0) -- Sức chứa phải lớn hơn 0
);

CREATE TABLE ChuyenBay (
    MaChuyenBay INT IDENTITY(1,1) PRIMARY KEY,
    MaHangHangKhong INT,
    MaTrangThaiChuyenBay INT,
    MaLoTrinh INT,
	MaMayBay INT,
	GiaBay MONEY,
	NgayGioDi DATETIME NOT NULL,
    NgayGioDen DATETIME NOT NULL,
    CONSTRAINT FK_CHUYENBAY_SANBAY FOREIGN KEY (MaLoTrinh) REFERENCES LoTrinh(MaLoTrinh),
    CONSTRAINT FK_CHUYENBAY_HHK FOREIGN KEY (MaHangHangKhong) REFERENCES HangHangKhong(MaHangHangKhong),
    CONSTRAINT FK_CHUYENBAY_TRANGTHAI FOREIGN KEY (MaTrangThaiChuyenBay) REFERENCES TrangThaiChuyenBay(MaTrangThaiChuyenBay),
    CONSTRAINT FK_CHUYENBAY_MAYBAY FOREIGN KEY (MaMayBay) REFERENCES MayBay(MaMayBay)

);

CREATE TABLE HangGhe (
    MaHangGhe INT IDENTITY(1,1) PRIMARY KEY,
    TenHangGhe NVARCHAR(50),
);


CREATE TABLE MayBay_HangGhe (
	MaMBHG INT IDENTITY(1,1) PRIMARY KEY, 
    MaMayBay INT,
    MaHangGhe INT,
    SoGhe INT CHECK (SoGhe > 0), -- Số ghế phải lớn hơn 0
    CONSTRAINT FK_MayBay_HangGhe_MayBay FOREIGN KEY (MaMayBay) REFERENCES MayBay(MaMayBay),
    CONSTRAINT FK_MayBay_HangGhe_HangGhe FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe)
);

CREATE TABLE GiaHangGhe (
    MaHangGhe INT,
	MaHHK INT,
    Gia DECIMAL(18, 2) CHECK (Gia > 0), -- Giá phải lớn hơn 0
	CONSTRAINT PK_GiaHangGhe Primary Key (MaHangGhe, MaHHK),
    CONSTRAINT FK_HANGGHE_GIA FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe),
	CONSTRAINT FK_HANGGHE_HHK FOREIGN KEY (MaHHK) REFERENCES HangHangKhong(MaHangHangKhong)
);


CREATE TABLE TrangThaiVe (
   MaTTV INT IDENTITY(1,1),
   TenTTV nvarchar(20),
   CONSTRAINT PK_TTV PRIMARY KEY (MATTV)
);

CREATE TABLE Ve (

    MaVe INT IDENTITY(1,1) PRIMARY KEY,
	MaHanhKhach INT  NULL,
	MaTTV INT NOT NULL,
	CONSTRAINT FK_VEMAYBAY_TRANGTHAIVE FOREIGN KEY (MaTTV) REFERENCES TrangThaiVe(MaTTV),
	CONSTRAINT FK_VEMAYBAY_HANHKHACH FOREIGN KEY (MaHanhKhach) REFERENCES HanhKhach(MaHanhKhach)
);

CREATE TABLE ChiTietVe (
    MaVe INT PRIMARY KEY,
    MaChuyenBay INT NOT NULL,
	MaHangGhe int,
    CONSTRAINT FK_CTV_VE FOREIGN KEY (MaVe) REFERENCES Ve(MaVe),
	CONSTRAINT FK_CTV_CHUYENBAY FOREIGN KEY (MaChuyenBay) REFERENCES ChuyenBay(MaChuyenBay),
	CONSTRAINT FK_CTV_HANGGHE FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe)
);

CREATE TABLE PhieuDat (
    MaPhieuDat INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT not null,
    NgayDat DATE,
    SoLuongHanhKhach INT , 
    CONSTRAINT FK_PHIEUDAT_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE ChiTietPhieuDat (
    MaPhieuDat INT,
    MaVe INT,
    CONSTRAINT PK_CHITIETDATVE PRIMARY KEY (MaPhieuDat, MaVe),
    CONSTRAINT FK_CHITIETDATVE_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDat(MaPhieuDat),
    CONSTRAINT FK_CHITIETDATVE_VEMAYBAY FOREIGN KEY (MaVe) REFERENCES Ve(MaVe),
);

CREATE TABLE TrangThaiHoaDon(
	MaTTHD int identity(1,1) Primary key,
	TenTTHD nvarchar(100)
)

insert into TrangThaiHoaDon(TenTTHD) values
(N'Chưa thanh toán'),
(N'Đã thanh toán');

CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuDat INT,
    TongTien DECIMAL(18, 2) CHECK (TongTien >= 0), -- Tổng tiền không được nhỏ hơn 0
	MaTTHD INT DEFAULT 1,
    CONSTRAINT FK_HOADON_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDat(MaPhieuDat),
	CONSTRAINT FK_HOADON_TTHD FOREIGN KEY (MaTTHD) REFERENCES TrangThaiHoaDon(MaTTHD)
);




CREATE TABLE GiamGia (
    MaGiamGia INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(20),
    MucGiamGia DECIMAL(18, 2) CHECK (MucGiamGia > 0) -- Mức giảm giá phải lớn hơn 0
);

CREATE TABLE GiamGiaHoaDon (
	MaGiamGiaHoaDon int IDENTITY(1,1),
    MaHoaDon INT,
    MaGiamGia INT,
    CONSTRAINT PK_HD_GG PRIMARY KEY (MaGiamGiaHoaDon),
    CONSTRAINT FK_HD_GG_HOADON FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT FK_HD_GG_GIAMGIA FOREIGN KEY (MaGiamGia) REFERENCES GiamGia(MaGiamGia)
);

CREATE TABLE LoaiTienIch
(
MaLoaiTienIch INT IDENTITY(1,1) PRIMARY KEY,
TenLoaiTienIch NVARCHAR(50)
)
CREATE TABLE TienIch (
    MaTienIch INT IDENTITY(1,1) PRIMARY KEY,
    TenTienIch NVARCHAR(100),
    GiaTienIch DECIMAL(18, 2) CHECK (GiaTienIch > 0),
	MaLoaiTienIch INT,
	CONSTRAINT FK_TIENICH_LOAI FOREIGN KEY (MaLoaiTienIch) REFERENCES LoaiTienIch(MaLoaiTienIch)

);



CREATE TABLE DatTienIch (
    MaDatTienIch INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuDat INT,
    MaTienIch INT,
    CONSTRAINT FK_PD_TI_TIENICH FOREIGN KEY (MaTienIch) REFERENCES TienIch(MaTienIch),
    CONSTRAINT FK_PD_TI_PhieuDat FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDat(MaPhieuDat)
);
-- Bảng TaiKhoan
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau) VALUES 
(N'Admin', N'Admin@123'), 
(N'minh123', N'0123456789'), 
(N'khoa345', N'963852741'),
(N'duy678', N'147258369'),
(N'luan901', N'987654321'),
(N'dang666', N'123456789')

-- Bảng KhachHang
INSERT INTO KhachHang (HoTen, DiaChi, Email, NgaySinh, SoDienThoai, MaTaiKhoan) VALUES 
(N'Nguyễn Minh Luân', N'Hà Nội', N'nguyenminhluan@gmail.com', '2004-01-01', N'0123456789', 1),
(N'Trần Thị Oanh', N'TP Hồ Chí Minh', N'tranthioanh@gmail.com', '2004-05-15', N'0987654321', 2),
(N'Lê Văn Thịnh', N'Đà Nẵng', N'levanthinh@gmail.com', '2002-09-20', N'0123456780', 3), 
(N'Phạm Thị Dung', N'Huế', N'phamthidung@gmail.com', '2005-12-25', N'0987654320', 4),
(N'Nguyễn Văn Duy', N'Cần Thơ', N'nguyenvanduy@gmail.com', '2001-03-30', N'0123456791', 5)

-- Bảng SanBay
INSERT INTO SanBay (TenSanBay, TenThanhPho, VietTatSanBay) VALUES 
(N'Noi Bai International Airport', N'Hà Nội', N'HAN'),
(N'Tan Son Nhat International Airport', N'Hồ Chí Minh', N'SGN'),
(N'Da Nang International Airport', N'Đà Nẵng', N'DAD'), 
(N'Cam Ranh International Airport', N'Nha Trang', N'CXR'),
(N'Phu Quoc International Airport', N'Phú Quốc', N'PQC')

-- Bảng HangHangKhong
INSERT INTO HangHangKhong (TenHangHangKhong) VALUES 
(N'Vietnam Airlines'),
(N'Vietjet Air'),
(N'Bamboo Airways'),
(N'Pacific Airlines'),
(N'VASCO')

-- Bảng HanhKhach
INSERT INTO HanhKhach (HoTen, DiaChi, GioiTinh, QuocTich, NgaySinh, SoDienThoai, Email, CCCD_Passport, MaKhachHang) VALUES 
(N'Nguyễn Thị Xuân', N'Hà Nội', N'Nữ', N'Việt Nam', '1993-02-14', N'0126456790', N'nguyenthixuan@gmail.com', N'123456789',1),
(N'Trần Văn Yên', N'TP Hồ Chí Minh', N'Nam', N'Việt Nam', '1989-10-01', N'0987654322', N'tranvanyen@gmail.com', N'234567890',2),
(N'Lê Văn Thọ', N'Đà Nẵng', N'Nam', N'Việt Nam', '1990-07-07', N'0123456788', N'levantho@gmail.com', N'345678901',3),
(N'Nguyễn Văn Mạnh', N'Huế', N'Nam', N'Việt Nam', '1986-12-12', N'0987654319', N'nguyenvanmanh@gmail.com', N'456789012',3),
(N'Phạm Thị Quỳnh Như', N'Cần Thơ', N'Nữ', N'Việt Nam', '1995-04-05', N'0123456792', N'phamthiquynhnhu@gmail.com', N'567890123',4),
(N'Lê Thị Hồng', N'Hải Phòng', N'Nữ', N'Việt Nam', '1992-03-18', N'0123654789', N'lethihong@gmail.com', N'678901234',5),
(N'Phạm Văn Tuấn', N'Quảng Nam', N'Nam', N'Việt Nam', '1985-11-25', N'0987543211', N'phamvantuan@gmail.com', N'789012345',5),
(N'Bùi Thị Thu Hà', N'Bình Dương', N'Nữ', N'Việt Nam', '1994-09-09', N'0123789456', N'buithithuha@gmail.com', N'890123456',1),
(N'Trần Quang Huy', N'Nha Trang', N'Nam', N'Việt Nam', '1987-06-30', N'0978543210', N'tranquanghuy@gmail.com', N'901234567',2);

--Bảng TrangThaiChuyenBay
INSERT INTO TrangThaiChuyenBay (TenTrangThaiChuyenBay) VALUES
(N'Có sẵn'),
(N'Không có sẵn')

---Bảng máy bay
INSERT INTO MayBay (TenMayBay, SucChuaToiDa)
VALUES 
    (N'Boeing 737',200 ),
    (N'Airbus A320',180),
    (N'Boeing 747',190),
    (N'Airbus A380',170),
    (N'Cessna 172',250);

--Bảng TrangThaiVe
INSERT INTO TrangThaiVe (TenTTV) VALUES
(N'Có sẵn'),
(N'Đã đặt'),
(N'Đã sử dụng')

--Bảng LoTrinh
INSERT INTO LoTrinh (TenLoTrinh, MaSB_Di, MaSB_Den) VALUES 
	(N'Hà Nội - TP Hồ Chí Minh',1, 2), -- Từ Hà Nội đến TP Hồ Chí Minh
	(N'TP Hồ Chí Minh - Đà Nẵng', 2, 3), -- Từ TP Hồ Chí Minh đến Đà Nẵng
	(N'Hà Nội - Đà Nẵng', 1, 3), -- Từ Hà Nội đến Đà Nẵng
	(N'Đà Nẵng - Nha Trang', 3, 4), -- Từ Đà Nẵng đến Nha Trang
	(N'Nha Trang - Phú Quốc', 4, 5) -- Từ Nha Trang đến Phú Quốc


--Bảng ChuyenBay
INSERT INTO ChuyenBay (MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh,MaMayBay,GiaBay,NgayGioDi,NgayGioDen) VALUES 
(1, 1, 1,1,1500000,'2024-11-25 08:00:00','2024-11-25 10:30:00'), -- Vietnam Airlines, Có sẵn, Hà Nội - TP Hồ Chí Minh
(2, 2, 2,2,1200000,'2024-11-25 09:00:00','2024-11-25 10:45:00'), -- VietJet Air, Không có sẵn, TP Hồ Chí Minh - Đà Nẵng
(1, 1, 3,2,1300000,'2024-11-25 15:00:00','2024-11-25 16:30:00'), -- Vietnam Airlines, Có sẵn, Hà Nội - Đà Nẵng
(3, 1, 4,4,1100000,'2024-11-25 08:00:00','2024-11-25 08:45:00'), -- Bamboo Airways, Có sẵn, Đà Nẵng - Nha Trang
(2, 1, 5,5,2000000,'2024-11-25 08:00:00','2024-11-25 09:30:00') -- VietJet Air, Có sẵn, Nha Trang - Phú Quốc

--Bảng HangGhe
INSERT INTO HangGhe (TenHangGhe) VALUES
(N'Phổ thông'),
(N'Thương gia'),
(N'Hạng nhất'),
(N'Tiết kiệm')

INSERT INTO MayBay_HangGhe (MaMayBay, MaHangGhe, SoGhe)
VALUES 
    (1, 1, 20),  -- Máy bay 1 có 20 ghế Hạng Nhất
    (1, 2, 30),  -- Máy bay 1 có 30 ghế Hạng Thương Gia
    (1, 3, 150), -- Máy bay 1 có 100 ghế Hạng Phổ Thông

    (2, 1, 10),  -- Máy bay 2 có 10 ghế Hạng Nhất
    (2, 2, 20),  -- Máy bay 2 có 20 ghế Hạng Thương Gia
    (2, 3, 150), -- Máy bay 2 có 150 ghế Hạng Phổ Thông

    (3, 1, 30),  -- Máy bay 3 có 15 ghế Hạng Nhất
    (3, 2, 40),  -- Máy bay 3 có 25 ghế Hạng Thương Gia
    (3, 3, 120), -- Máy bay 3 có 200 ghế Hạng Phổ Thông

    (4, 1, 30),  -- Máy bay 4 có 30 ghế Hạng Nhất
    (4, 2, 40),  -- Máy bay 4 có 40 ghế Hạng Thương Gia
    (4, 3, 100), -- Máy bay 4 có 300 ghế Hạng Phổ Thông

    (5, 1, 50),
    (5, 2, 80),
    (5, 3, 120);   

--Bảng GiaHangGhe
INSERT INTO GiaHangGhe (MaHangGhe, MaHHK,Gia) VALUES 
-- VN Airlines
(1, 1,700000), -- Phổ thông
(2, 1, 1200000), -- Thương gia
(3, 1, 3000000), -- Hạng nhất
(4, 1,300000), -- Tiết kiệm
-- Vietjet Air
(1, 2, 450000), -- Phổ thông
(2, 2, 1000000), -- Thương gia
(4, 2,275000), -- Tiết kiệm
-- Bamboo Airways
(1, 3, 450000), -- Phổ thông
(2, 3, 1100000), -- Thương gia
(4, 3,299000), -- Tiết kiệm
-- Pacific Airlines
(1, 4, 420000), -- Phổ thông
(2, 4, 900000), -- Thương gia
(4, 4, 280000), -- Tiết kiệm
-- VASCO
(1, 5, 380000), -- Phổ thông
(4, 5, 250000) -- Tiết kiệm


--Bảng Ve
INSERT INTO Ve (MaHanhKhach, MaTTV) VALUES 
(1, 1), -- Hành khách 1, Trạng thái vé: Có sẵn
(2, 2), -- Hành khách 2, Trạng thái vé: Đã đặt
(3, 1), -- Hành khách 3, Trạng thái vé: Có sẵn
(4, 3), -- Hành khách 4, Trạng thái vé: Đã sử dụng
(5, 1), -- Hành khách 5, Trạng thái vé: Có sẵn
(6, 1), -- Hành khách 6, Trạng thái vé: Có sẵn
(7, 2), -- Hành khách 7, Trạng thái vé: Đã đặt
(8, 1), -- Hành khách 8, Trạng thái vé: Có sẵn
(9, 3); -- Hành khách 9, Trạng thái vé: Đã sử dụng


--Bảng ChiTietVe
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, MaHangGhe) Values
(1, 1, 1), -- Vé 1, Chuyến bay 1, Hạng ghế: Phổ thông
(2, 2, 1), -- Vé 2, Chuyến bay 2, Hạng ghế: Phổ thông
(3, 3, 2), -- Vé 3, Chuyến bay 3, Hạng ghế: Thương gia
(4, 4, 3), -- Vé 4, Chuyến bay 4, Hạng ghế: Hạng nhất
(5, 5, 4), -- Vé 5, Chuyến bay 5, Hạng ghế: Tiết kiệm
(6, 2, 2), -- Vé 6, Chuyến bay 2, Hạng ghế: Thương gia
(7, 3, 1), -- Vé 7, Chuyến bay 3, Hạng ghế: Phổ thông
(8, 4, 3), -- Vé 8, Chuyến bay 4, Hạng ghế: Hạng nhất
(9, 5, 4); -- Vé 9, Chuyến bay 5, Hạng ghế: Tiết kiệm

--Bổ sung:
-- Bảng Ve
INSERT INTO Ve ( MaTTV) VALUES 
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1), 
(1);

-- Bảng ChiTietVe
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, MaHangGhe) VALUES
(21, 1, 1), -- Vé 10, Chuyến bay 1, Hạng ghế: Phổ thông
(11, 2, 2), -- Vé 11, Chuyến bay 2, Hạng ghế: Thương gia
(12, 3, 3), -- Vé 12, Chuyến bay 3, Hạng ghế: Hạng nhất
(13, 4, 4), -- Vé 13, Chuyến bay 4, Hạng ghế: Tiết kiệm
(14, 5, 1), -- Vé 14, Chuyến bay 5, Hạng ghế: Phổ thông
(15, 1, 2), -- Vé 15, Chuyến bay 1, Hạng ghế: Thương gia
(16, 2, 3), -- Vé 16, Chuyến bay 2, Hạng ghế: Hạng nhất
(17, 3, 4), -- Vé 17, Chuyến bay 3, Hạng ghế: Tiết kiệm
(18, 4, 1), -- Vé 18, Chuyến bay 4, Hạng ghế: Phổ thông
(19, 5, 2), -- Vé 19, Chuyến bay 5, Hạng ghế: Thương gia
(20, 1, 3); -- Vé 20, Chuyến bay 1, Hạng ghế: Hạng nhất

--Bảng PhieuDat
INSERT INTO PhieuDat (MaKhachHang, NgayDat, SoLuongHanhKhach) Values
(1, '2024-11-01', 2), -- Khách hàng 1, đặt vé cho 2 hành khách
(2, '2024-11-02', 1), -- Khách hàng 2, đặt vé cho 1 hành khách
(3, '2024-11-03', 3), -- Khách hàng 3, đặt vé cho 3 hành khách
(4, '2024-11-04', 1), -- Khách hàng 4, đặt vé cho 1 hành khách
(5, '2024-11-05', 2) -- Khách hàng 5, đặt vé cho 2 hành khách



--Bảng ChiTietPhieuDat
INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaVe) VALUES 
(1, 1), -- Phiếu đặt 1, Vé 1
(1, 2), -- Phiếu đặt 1, Vé 2
(2, 3), -- Phiếu đặt 2, Vé 3
(3, 4), -- Phiếu đặt 3, Vé 4
(3, 5), -- Phiếu đặt 3, Vé 5
(3, 6), -- Phiếu đặt 3, Vé 6
(4, 7), -- Phiếu đặt 4, Vé 7
(5, 8), -- Phiếu đặt 5, Vé 8
(5, 9); -- Phiếu đặt 5, Vé 9

--Bảng HoaDon
INSERT INTO HoaDon (MaPhieuDat, TongTien) VALUES 
(1, 3825000), -- Phiếu đặt 1, Tổng tiền: 3,825,000 VND
(2, 2160000), -- Phiếu đặt 2, Tổng tiền: 2,160,000 VND
(3, 2287500), -- Phiếu đặt 3, Tổng tiền: 2,287,500 VND
(4, 1742500), -- Phiếu đặt 4, Tổng tiền: 1,742,500 VND
(5, 1706250) -- Phiếu đặt 5, Tổng tiền: 1,706,250 VND

--Bảng GiamGia
INSERT INTO GiamGia (Code, MucGiamGia) VALUES 
('GIAM10', 10.00), -- Mã giảm giá 10%
('GIAM20', 20.00), -- Mã giảm giá 20%
('GIAM50', 50.00), -- Mã giảm giá 50%
('NEWUSER', 15.00), -- Mã giảm giá cho người dùng mới 15%
('VIPMEMBER', 25.00) -- Mã giảm giá cho thành viên VIP 25%

--Bảng GiamGiaHoaDon
INSERT INTO GiamGiaHoaDon (MaHoaDon, MaGiamGia) VALUES 
(1, 1), -- Áp dụng mã GIAM10 cho hóa đơn 1
(2, 2), -- Áp dụng mã GIAM20 cho hóa đơn 2
(3, 3), -- Áp dụng mã GIAM50 cho hóa đơn 3
(4, 4), -- Áp dụng mã NEWUSER cho hóa đơn 4
(5, 5) -- Áp dụng mã VIPMEMBER cho hóa đơn 5


INSERT INTO LoaiTienIch(TenLoaiTienIch) VALUES 
(N'Dịch vụ'), 
(N'Hành lý'), 
(N'Chổ ngồi') 


--Bảng TienIch
INSERT INTO TienIch (TenTienIch, GiaTienIch, MaLoaiTienIch) VALUES 
(N'Bữa ăn trên máy bay', 150000,1), -- Bữa ăn trên máy bay, giá: 150,000 VND
(N'Gửi thêm hành lý', 250000,2), -- Gửi thêm hành lý, giá: 250,000 VND
(N'Ưu tiên lên máy bay', 200000,1), -- Ưu tiên lên máy bay, giá: 200,000 VND
(N'Chọn chỗ ngồi', 100000,3), -- Chọn chỗ ngồi, giá: 100,000 VND
(N'Truy cập Wi-Fi', 50000,1), -- Truy cập Wi-Fi, giá: 50,000 VND
(N'Truy cập phòng chờ hạng sang', 300000,1), -- Phòng chờ hạng sang, giá: 300,000 VND
(N'Bảo hiểm chuyến bay', 200000,1), -- Bảo hiểm chuyến bay, giá: 200,000 VND
(N'Trợ lý cá nhân', 500000,1), -- Trợ lý cá nhân, giá: 500,000 VND
(N'Dịch vụ spa', 400000,1), -- Dịch vụ spa, giá: 400,000 VND
(N'Nâng cấp ghế ngồi', 600000,3) -- Nâng cấp ghế ngồi, giá: 600,000 VND

--Bảng DatTienIch
INSERT INTO DatTienIch (MaPhieuDat, MaTienIch) VALUES 
(1, 1), -- Phiếu đặt 1, Tiện ích: Bữa ăn trên máy bay
(1, 2), -- Phiếu đặt 1, Tiện ích: Gửi thêm hành lý
(2, 3), -- Phiếu đặt 2, Tiện ích: Ưu tiên lên máy bay
(3, 4), -- Phiếu đặt 3, Tiện ích: Chọn chỗ ngồi
(4, 5) -- Phiếu đặt 4, Tiện ích: Truy cập Wi-Fi

--//--
-- Trigger
-- Xóa tài khoản khi có thao tác xóa khách hàng

-- Tạo KhachHang mới khi có TaiKhoan mới được tạo
CREATE TRIGGER trg_TaoKhachHangMoiKhiCoTaiKhoanMoi
ON TaiKhoan
AFTER INSERT
AS
BEGIN
    DECLARE @MaTaiKhoan INT;
    DECLARE @TenTaiKhoan NVARCHAR(50);

    
    SELECT @MaTaiKhoan = MaTaiKhoan, @TenTaiKhoan = TenTaiKhoan FROM inserted;

    INSERT INTO KhachHang (MaTaiKhoan, HoTen, DiaChi, Email, NgaySinh, SoDienThoai)
    VALUES (@MaTaiKhoan, @TenTaiKhoan, NULL, NULL, NULL, NULL);
END;

--//--

Select * from TaiKhoan
Select * from KhachHang
Select * from HanhKhach
Select * from Ve
Select * from PhieuDat
Select * from ChiTietPhieuDat
Select * from ChiTietVe
Select * from TrangThaiVe
Select * from TrangThaiChuyenBay
Select * from ChuyenBay
Select * from HangGhe
Select * from HangHangKhong
Select * from GiaHangGhe
Select * from SanBay
Select * from LoTrinh
Select * from TienIch
Select * from DatTienIch
Select * from GiamGia
Select * from HoaDon
Select * from GiamGiaHoaDon

-- Stored Proc
-- Hàm mã hóa mật khẩu
--CREATE FUNCTION func_MaHoaMatKhau(@MatKhau varchar(100))
--Returns varchar(256)
--as
--	begin
--		return convert(varchar(256),hashbytes('SHA_256',@MatKhau),1)
--	end;
CREATE FUNCTION func_MaHoaMatKhau(@MatKhau VARCHAR(100))
RETURNS VARCHAR(64)
AS
BEGIN
    RETURN CASE 
        WHEN @MatKhau IS NOT NULL THEN 
            SUBSTRING(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @MatKhau), 1), 3, 64)
        ELSE 
            NULL
    END;
END;
GO

	
--//--
-- Tạo login + user cho tài khoản:

CREATE PROC sp_TaoLoginUser 
    @TenTaiKhoan NVARCHAR(100), 
    @MatKhau NVARCHAR(256)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX); 

    BEGIN TRY
        
        IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = @TenTaiKhoan)
        BEGIN
            SET @SQL = 'CREATE LOGIN [' + @TenTaiKhoan + '] WITH PASSWORD = ''' + @MatKhau + ''';';
            EXEC sp_executesql @SQL;
        END
        ELSE
        BEGIN
            PRINT 'Login đã tồn tại: ' + @TenTaiKhoan;
        END

        IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = @TenTaiKhoan)
        BEGIN
            SET @SQL = 'USE QuanLyBanVeMayBay; CREATE USER [' + @TenTaiKhoan + '] FOR LOGIN [' + @TenTaiKhoan + '];';
            EXEC sp_executesql @SQL;
        END
        ELSE
        BEGIN
            PRINT 'User đã tồn tại: ' + @TenTaiKhoan;
        END
        
        PRINT 'Tạo Login và User thành công: ' + @TenTaiKhoan;
    END TRY
    BEGIN CATCH
        PRINT 'Đã xảy ra lỗi: ' + ERROR_MESSAGE();
    END CATCH
END;



--Cursor tạo login và user cho csdl
DECLARE @TenTaiKhoan NVARCHAR(100), 
        @MatKhau NVARCHAR(256);


DECLARE c_TaiKhoan CURSOR FOR
    SELECT TenTaiKhoan, MatKhau
    FROM TaiKhoan;  


OPEN c_TaiKhoan;


FETCH NEXT FROM c_TaiKhoan INTO @TenTaiKhoan, @MatKhau;


WHILE @@FETCH_STATUS = 0
BEGIN
    
    EXEC sp_TaoLoginUser @TenTaiKhoan, @MatKhau;

    
    FETCH NEXT FROM c_TaiKhoan INTO @TenTaiKhoan, @MatKhau;
END;


CLOSE c_TaiKhoan;
DEALLOCATE c_TaiKhoan;

PRINT 'Đã tạo tài khoản và user cho tất cả các tài khoản trong bảng.';

-- Phân quyền
-- Admin 
	ALTER ROLE db_accessadmin ADD MEMBER Admin;
	GRANT SELECT, DELETE, UPDATE, INSERT ON SCHEMA::dbo TO Admin;
	GRANT EXECUTE ON SCHEMA::dbo TO Admin;


-- User
-- Tạo nhóm quyền cho user:
	CREATE ROLE customer_role
	GRANT SELECT, INSERT, UPDATE ON dbo.HanhKhach TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.Ve TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.ChiTietVe TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.PhieuDat TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.ChiTietPhieuDat TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.HoaDon TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.DatTienIch TO customer_role;
	GRANT SELECT ON SCHEMA::dbo TO customer_role;
	GRANT EXECUTE ON SCHEMA::dbo TO customer_role;

	
	-- Add member
	ALTER ROLE customer_role Add member dang666
	ALTER ROLE customer_role Add member duy678
	ALTER ROLE customer_role Add member khoa345
	ALTER ROLE customer_role Add member luan901
	ALTER ROLE customer_role Add member minh123
	
	
	-- Proc Doi mat khau Login theo MatKhau moi 
	CREATE PROC sp_DoiMatKhauLogin
	 @LoginName NVARCHAR(100),   
    @NewPassword NVARCHAR(128)  
AS
BEGIN
    BEGIN TRY
        
        IF EXISTS (SELECT 1 
                   FROM sys.server_principals 
                   WHERE name = @LoginName AND type_desc = 'SQL_LOGIN')
        BEGIN
           
            DECLARE @Sql NVARCHAR(MAX);
            SET @Sql = N'ALTER LOGIN [' + @LoginName + '] WITH PASSWORD = ''' + @NewPassword + ''';';
            EXEC sp_executesql @Sql;
            
            PRINT 'Mật khẩu đã được đổi thành công cho Login: ' + @LoginName;
        END
        ELSE
        BEGIN
           
            PRINT 'Login của user này không tồn tại: ' + @LoginName;
        END
    END TRY
    BEGIN CATCH
        
        PRINT 'Đã xảy ra lỗi: ' + ERROR_MESSAGE();
    END CATCH
END;


	-- Thủ tục thêm vai trò cho khách
	CREATE PROC sp_AddRoleTaiKhoanMoi @TenTaiKhoan NVARCHAR(100)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);


    SET @sql = N'ALTER ROLE customer_role ADD MEMBER ' + QUOTENAME(@TenTaiKhoan);


    EXEC sp_executesql @sql;
END;


-- Gỡ quyền khách
CREATE PROCEDURE sp_GoQuyen
    @TenTaiKhoan NVARCHAR(100) 
AS
BEGIN

    DECLARE @sql NVARCHAR(MAX);
    
    SET @sql = N'ALTER ROLE customer_role DROP MEMBER ' + QUOTENAME(@TenTaiKhoan);

    EXEC sp_executesql @sql;
END;



exec sp_CreateTaiKhoan 'ssuser123','123'

drop proc sp_CreateTaiKhoan
-- Tạo tài khoản khách hàng
CREATE PROCEDURE sp_CreateTaiKhoan
    @TenTaiKhoan NVARCHAR(50),
    @MatKhau NVARCHAR(100),
    @SDT VARCHAR(20) = NULL -- Đảm bảo tham số có thể chấp nhận giá trị NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem tài khoản đã tồn tại trong bảng TaiKhoan hay chưa
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan)
    BEGIN
        RAISERROR('Tên tài khoản đã tồn tại.', 16, 1);
        RETURN;
    END

    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Bước 1: Thêm tài khoản vào bảng TaiKhoan
        INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau)
        VALUES (@TenTaiKhoan, @MatKhau);

        -- Bước 2: Gọi thủ tục sp_TaoLoginUser để tạo login và user
        EXEC sp_TaoLoginUser @TenTaiKhoan, @MatKhau;

        -- Bước 3: Thêm tài khoản vào vai trò customer_role
        EXEC sp_AddRoleTaiKhoanMoi @TenTaiKhoan;

        -- Bước 4: Tạo 1 thông tin khách hàng 
        IF @SDT IS NOT NULL
        BEGIN
            INSERT INTO KhachHang (MaTaiKhoan, SoDienThoai)
            VALUES ((SELECT MaTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan), @SDT);
        END

        COMMIT TRANSACTION;

        PRINT 'Tài khoản đã được tạo thành công và phân quyền: ' + @TenTaiKhoan;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Đã xảy ra lỗi: ' + ERROR_MESSAGE();
    END CATCH
END;



-- Xóa tài khoản
CREATE PROCEDURE sp_XoaTaiKhoan 
    @MaTaiKhoan INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra xem tài khoản có liên kết với khách hàng nào không
        -- Nếu có, xóa các bản ghi trong bảng KhachHang liên quan
        DELETE FROM KhachHang WHERE MaTaiKhoan = @MaTaiKhoan;

        -- Tiếp tục xóa tài khoản trong bảng TaiKhoan

		DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;

select * from TaiKhoan
update TaiKhoan set MatKhau = '123' where TenTaiKhoan = 'dang666'



-- Đổi mật khẩu tài khoản

CREATE PROCEDURE sp_DoiMatKhau
    @TenTaiKhoan NVARCHAR(255),
    @MatKhau NVARCHAR(255)
AS
BEGIN
    ---- Mã hóa mật khẩu
    --DECLARE @MatKhauMaHoa NVARCHAR(256);
    --SET @MatKhauMaHoa = dbo.func_MaHoaMatKhau(@MatKhau);

    -- Cập nhật thông tin tài khoản
    UPDATE TaiKhoan
    SET MatKhau = @MatKhau
    WHERE TenTaiKhoan = @TenTaiKhoan;
END;

EXEC sp_UpdateKhachHang 
    @TenTaiKhoan = 'aduy113',
    @HoTen = 'John Doe',
    @Email = 'john.doe@example.com',
    @SoDienThoai = '0987654321';
	@DiaChi = 'ABC;'

-- Tạo thủ tục cập nhật tài khoản khách hàng
CREATE PROCEDURE sp_UpdateKhachHang
    @TenTaiKhoan NVARCHAR(50),
    @HoTen NVARCHAR(100) = NULL,
    @DiaChi NVARCHAR(255) = NULL,
    @Email NVARCHAR(100) = NULL,
    @NgaySinh DATE = NULL,
    @SoDienThoai NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra xem khách hàng có tồn tại dựa trên tên tài khoản không
        IF NOT EXISTS (SELECT 1 FROM KhachHang kh
                      JOIN TaiKhoan tk ON kh.MaTaiKhoan = tk.MaTaiKhoan
                      WHERE tk.TenTaiKhoan = @TenTaiKhoan)
        BEGIN
            RAISERROR('Khách hàng không tồn tại.', 16, 1);
            RETURN;
        END

        -- Cập nhật thông tin khách hàng
        UPDATE KhachHang
        SET
            HoTen = COALESCE(@HoTen, HoTen),
            DiaChi = COALESCE(@DiaChi, DiaChi),
            Email = COALESCE(@Email, Email),
            NgaySinh = COALESCE(@NgaySinh, NgaySinh),
            SoDienThoai = COALESCE(@SoDienThoai, SoDienThoai)
        FROM KhachHang kh
        JOIN TaiKhoan tk ON kh.MaTaiKhoan = tk.MaTaiKhoan
        WHERE tk.TenTaiKhoan = @TenTaiKhoan;

        COMMIT TRANSACTION;

        PRINT 'Cập nhật thông tin khách hàng thành công.';
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Đã xảy ra lỗi: ' + ERROR_MESSAGE();
    END CATCH
END;

-- Cập nhật thông tin khách



--//--
-- Tra cứu thông tin khách hàng theo Tài khoản
CREATE FUNCTION func_ThongTinKhachHangTheoTaiKhoan(@TenTaiKhoan varchar(50))
RETURNS TABLE
AS
RETURN
(
	select kh.HoTen,kh.MaKhachHang, kh.DiaChi, kh.SoDienThoai, kh.NgaySinh, kh.Email
	From KhachHang kh
	Join TaiKhoan tk on tk.MaTaiKhoan = kh.MaTaiKhoan
	where tk.TenTaiKhoan = @TenTaiKhoan
);

select * from func_ThongTinKhachHangTheoTaiKhoan('Admin')





--Minh
--Stored Proc ThemHoaDon
CREATE PROCEDURE sp_ThemHoaDon 
    @MaPhieuDat INT,
    @TongTien DECIMAL(18, 2) OUTPUT,  
    @MaHoaDonMoi INT OUTPUT 
AS
BEGIN
    BEGIN TRY
       
        IF NOT EXISTS (SELECT 1 FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat)
        BEGIN
            RAISERROR(N'Mã phiếu đặt không tồn tại.', 16, 1);
            RETURN;
        END

        
        IF dbo.func_KiemTraMaPhieuDat(@MaPhieuDat) = 1
        BEGIN
            RAISERROR(N'Mã phiếu đặt đã được sử dụng cho một hóa đơn khác.', 16, 1);
            RETURN;
        END

        
        SET @TongTien = dbo.func_TinhTongTien(@MaPhieuDat);

       
        INSERT INTO HoaDon (MaPhieuDat, TongTien)
        VALUES (@MaPhieuDat, @TongTien);

        
        SET @MaHoaDonMoi = SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

       
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;


-------------------Test
-- Khai báo các biến để lưu giá trị đầu ra
DECLARE @TongTien DECIMAL(18, 2);
DECLARE @MaHoaDonMoi INT;

-- Giá trị đầu vào để kiểm tra
DECLARE @MaPhieuDat INT = 2; -- Thay đổi giá trị này để test các trường hợp khác nhau

-- Gọi stored procedure
BEGIN TRY
    EXEC sp_ThemHoaDon 
        @MaPhieuDat = @MaPhieuDat, 
        @TongTien = @TongTien OUTPUT, 
        @MaHoaDonMoi = @MaHoaDonMoi OUTPUT;

    -- In kết quả ra để kiểm tra
    PRINT N'Tổng tiền: ' + CAST(@TongTien AS NVARCHAR);
    PRINT N'Mã hóa đơn mới: ' + CAST(@MaHoaDonMoi AS NVARCHAR);
END TRY
BEGIN CATCH
    -- Bắt lỗi và in ra thông báo lỗi
    PRINT N'Lỗi: ' + ERROR_MESSAGE();
END CATCH;


-------Stored proc Sửa Hóa Đơn
CREATE PROCEDURE sp_SuaHoaDon
    @MaHoaDon INT,               
    @MaPhieuDat INT = NULL       
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
       
        IF @MaPhieuDat IS NOT NULL AND dbo.func_KiemTraMaPhieuDat(@MaPhieuDat) = 1
        BEGIN
            RAISERROR(N'Hóa đơn của mã phiếu đặt này đã tồn tại trong hệ thống! Không thể sửa.', 16, 1);
            RETURN;
        END

        
        IF @MaPhieuDat IS NOT NULL
        BEGIN
            UPDATE HoaDon
            SET MaPhieuDat = @MaPhieuDat
            WHERE MaHoaDon = @MaHoaDon;
        END

      
        DECLARE @CurrentMaPhieuDat INT;
        SELECT @CurrentMaPhieuDat = MaPhieuDat 
        FROM HoaDon 
        WHERE MaHoaDon = @MaHoaDon;

        
        DECLARE @NewTongTien DECIMAL(18, 2);
        SET @NewTongTien = dbo.func_TinhTongTien(@CurrentMaPhieuDat);

        
        UPDATE HoaDon
        SET TongTien = @NewTongTien
        WHERE MaHoaDon = @MaHoaDon;

        PRINT N'Cập nhật hóa đơn thành công.';
    END TRY
    BEGIN CATCH
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(N' %s', 16, 1, @ErrorMessage);
    END CATCH
END;



-----------Test
EXEC sp_SuaHoaDon 
    @MaHoaDon = 1,
    @MaPhieuDat = 1;

select * from hoadon




-----------------------Stored proc Xóa Hóa Đơn 
CREATE PROCEDURE sp_XoaHoaDon
    @MaHoaDon INT 
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        
        DELETE FROM GiamGiaHoaDon
        WHERE MaHoaDon = @MaHoaDon;

        DELETE FROM HoaDon
        WHERE MaHoaDon = @MaHoaDon;

        PRINT N'Xóa hóa đơn thành công.';
    END TRY
    BEGIN CATCH
       
        RAISERROR(N'Không thể xóa hóa đơn.', 16, 1);
    END CATCH
END;



EXEC sp_XoaHoaDon @MaHoaDon = 23;



CREATE PROCEDURE sp_ThemMaGiamGia
    @Code NVARCHAR(20),          
    @MucGiamGia DECIMAL(18, 2)  
AS
BEGIN
    BEGIN TRY
        
        IF dbo.func_KiemTraCodeGiamGia(@Code) = 1
        BEGIN
            RAISERROR(N'Code giảm giá này đã tồn tại.', 16, 1);
            RETURN;
        END

       
        INSERT INTO GiamGia (Code, MucGiamGia)
        VALUES (@Code, @MucGiamGia);

        PRINT N'Thêm mã giảm giá thành công.';
    END TRY
    BEGIN CATCH
        
        RAISERROR(N'Không thể thêm mã giảm giá vì code đã tồn tại.', 16, 1);
    END CATCH
END;



------------Test
DECLARE @Code NVARCHAR(20) = 'Friday';
DECLARE @MucGiamGia DECIMAL(18, 2) = 20.0; -- 20%

EXEC sp_ThemMaGiamGia
    @Code = @Code,
    @MucGiamGia = @MucGiamGia;




--Procedure Sửa Mã Giảm Giá
CREATE PROCEDURE sp_SuaMaGiamGia
(
    @MaGiamGia INT,              
    @Code NVARCHAR(20),          
    @MucGiamGia DECIMAL(18, 2)   
)
AS
BEGIN

    IF dbo.func_KiemTraCodeGiamGia(@Code) = 1 
    BEGIN
        PRINT N'Code giảm giá này đã tồn tại trong hệ thống! Không thể sửa';
        RETURN;  
    END


        UPDATE GiamGia
        SET Code = @Code,
            MucGiamGia = @MucGiamGia
        WHERE MaGiamGia = @MaGiamGia;

    PRINT N'Mã giảm giá đã được cập nhật thành công!';
END;




select * from GiamGia

-------Test
DECLARE @MaGiamGia INT = 7;  
DECLARE @Code NVARCHAR(20) = N'GIAM0';
DECLARE @MucGiamGia DECIMAL(18, 2) = 25.0; -- 15%

EXEC sp_SuaMaGiamGia
    @MaGiamGia = @MaGiamGia,
    @Code = @Code,
    @MucGiamGia = @MucGiamGia;



--------Stored procedure XoaMaGiamGia
CREATE PROCEDURE sp_XoaMaGiamGia
    @MaGiamGia INT 
AS
BEGIN

    DELETE FROM GiamGia
    WHERE MaGiamGia = @MaGiamGia;

    PRINT N'Mã giảm giá đã được xóa thành công.';
END;
drop proc sp_XoaMaGiamGia
---------------Test
DECLARE @MaGiamGia INT = 7; 

EXEC sp_XoaMaGiamGia @MaGiamGia = @MaGiamGia;



drop function func_TinhTongTien
--Function
CREATE FUNCTION func_TinhTongTien (@MaPhieuDat INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongTienVe DECIMAL(18, 2) = 0;
    DECLARE @TongTienTienIch DECIMAL(18, 2) = 0;
    DECLARE @PhanTramGiam DECIMAL(5, 2) = 0;
    DECLARE @TongTruocGiam DECIMAL(18, 2) = 0;
    DECLARE @TongTien DECIMAL(18, 2) = 0;

    SELECT @TongTienVe = COALESCE(SUM(ChuyenBay.GiaBay + GiaHangGhe.Gia), 0)
    FROM ChiTietPhieuDat
    JOIN Ve ON ChiTietPhieuDat.MaVe = Ve.MaVe
    JOIN ChiTietVe ON Ve.MaVe = ChiTietVe.MaVe
    JOIN ChuyenBay ON ChiTietVe.MaChuyenBay = ChuyenBay.MaChuyenBay
    JOIN GiaHangGhe ON ChiTietVe.MaHangGhe = GiaHangGhe.MaHangGhe
    WHERE ChiTietPhieuDat.MaPhieuDat = @MaPhieuDat
    AND ChuyenBay.MaHangHangKhong = GiaHangGhe.MaHHK;

    SELECT @TongTienTienIch = COALESCE(SUM(TienIch.GiaTienIch), 0)
    FROM DatTienIch
    JOIN TienIch ON DatTienIch.MaTienIch = TienIch.MaTienIch
    WHERE DatTienIch.MaPhieuDat = @MaPhieuDat;

    SET @TongTruocGiam = @TongTienVe + @TongTienTienIch;

    SELECT @PhanTramGiam = COALESCE(MAX(GiamGia.MucGiamGia), 0)
    FROM GiamGiaHoaDon
    JOIN GiamGia ON GiamGiaHoaDon.MaGiamGia = GiamGia.MaGiamGia
    JOIN HoaDon ON HoaDon.MaHoaDon = GiamGiaHoaDon.MaHoaDon
    WHERE HoaDon.MaPhieuDat = @MaPhieuDat;

    SET @TongTien = @TongTruocGiam * (1 - @PhanTramGiam / 100.0);

    RETURN @TongTien;
END;




------------------Test
SELECT dbo.func_TinhTongTien(5) AS TongTien;;


---------Function kiểm tra mã phiếu đặt
CREATE FUNCTION func_KiemTraMaPhieuDat (
    @MaPhieuDat NVARCHAR(20) 
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    IF EXISTS (SELECT 1 FROM HoaDon WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        SET @Exists = 1;  
    END
    ELSE
    BEGIN
        SET @Exists = 0; 
    END
    RETURN @Exists;
END;

---------Function kiểm tra code giảm giá
CREATE FUNCTION func_KiemTraCodeGiamGia (
    @Code NVARCHAR(20) 
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    IF EXISTS (SELECT 1 FROM GiamGia WHERE Code = @Code)
    BEGIN
        SET @Exists = 1;  
    END
    ELSE
    BEGIN
        SET @Exists = 0;  
    END
    RETURN @Exists;
END;





--Trigger Cập Nhật Tổng Tiền Hóa Đơn khi thêm hoặc xóa vé 
CREATE TRIGGER trg_CapNhatTongTienHoaDon
ON ChiTietPhieuDat
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    
    DECLARE @MaPhieuDat INT;

     IF EXISTS (SELECT 1 FROM INSERTED)
    BEGIN
        SELECT TOP 1 @MaPhieuDat = MaPhieuDat FROM INSERTED;
    END
    ELSE IF EXISTS (SELECT 1 FROM DELETED)
    BEGIN
        SELECT TOP 1 @MaPhieuDat = MaPhieuDat FROM DELETED;
    END

     IF @MaPhieuDat IS NOT NULL
    BEGIN
        DECLARE @TongTien DECIMAL(18, 2);

         SET @TongTien = dbo.func_TinhTongTien(@MaPhieuDat);

         UPDATE HoaDon
        SET TongTien = @TongTien
        WHERE MaPhieuDat = @MaPhieuDat;
    END
END;


-----Thêm dữ liệu để test
insert into Ve values (8,2)
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, NgayDi, NgayDen, MaHangGhe) Values
(11, 1, '2024-11-10', '2024-11-10', 1) -- Vé 11, Chuyến bay 1, Hạng ghế: Phổ thông
-----Test thêm vé
INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaVe) 
VALUES (2, 11); -- Thay giá trị 1 và 101 với dữ liệu phù hợp

-----Test xóa vé
DELETE FROM ChiTietPhieuDat
WHERE MaPhieuDat = 2 AND MaVe = 11;






------LUÂN
----===============================================================---------------------
----================================================================--------------------
----proc tao ve

CREATE PROCEDURE sp_TaoVe
    @MaHK INT = NULL,       
    @MaChuyenBay INT,      
    @MaHangGhe INT          
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Mã chuyến bay không tồn tại.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM HangGhe WHERE MaHangGhe = @MaHangGhe)
    BEGIN
        RAISERROR(N'Mã hạng ghế không tồn tại.', 16, 1);
        RETURN;
    END

    IF @MaHK IS NOT NULL AND NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHK)
    BEGIN
        RAISERROR(N'Hành khách không tồn tại.', 16, 1);
        RETURN;
    END

    DECLARE @MaVe INT;
    INSERT INTO Ve (MaHanhKhach, MaTTV)
    VALUES (@MaHK, 1); 

    SET @MaVe = SCOPE_IDENTITY();

    INSERT INTO ChiTietVe (MaVe, MaChuyenBay, MaHangGhe)
    VALUES (@MaVe, @MaChuyenBay, @MaHangGhe);

    PRINT N'Vé và chi tiết vé đã được tạo thành công.';
END;



EXEC sp_TaoVe 
    @MaHK = 1,            
    @MaChuyenBay = 2,     

    @MaHangGhe = 2; 

	EXEC sp_TaoVe 
    @MaHK = null,            
    @MaChuyenBay = 2,     

    @MaHangGhe = 2; 


	------proc xóa vé
CREATE PROCEDURE sp_XoaVe
    @MaVe INT
AS
BEGIN
    SET NOCOUNT ON;
    IF dbo.fn_KiemTraVeTrongPhieuDat(@MaVe) = 1
    BEGIN
        RAISERROR(N'Vé này đang được sử dụng trong phiếu đặt, không thể xóa.', 16, 1);
        RETURN;
    END

    DELETE FROM ChiTietVe
    WHERE MaVe = @MaVe;

    DELETE FROM Ve
    WHERE MaVe = @MaVe;

    PRINT N'Vé và chi tiết vé đã được xóa thành công.';
END;

---câu lệnh thực thi
EXEC sp_XoaVe @MaVe = 10;

EXEC sp_XoaVe @MaVe = 2;

----proc sua chi tiet ve
	CREATE PROCEDURE sp_SuaVeVaChiTiet
    @MaVe INT,            
    @MaHK INT,           
    @MaTTV INT,           
    @MaChuyenBay INT,     
          
    @MaHangGhe INT        
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM Ve WHERE MaVe = @MaVe)
    BEGIN
        RAISERROR(N'Vé không tồn tại.', 16, 1);
        RETURN;
    END
    IF NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHK)
    BEGIN
        RAISERROR(N'Hành khách không tồn tại.', 16, 1);
        RETURN;
    END
    IF @MaTTV NOT IN (1, 2, 3)
    BEGIN
        RAISERROR(N'Mã trạng thái vé không hợp lệ.', 16, 1);
        RETURN;
    END
    IF NOT EXISTS (SELECT 1 FROM ChiTietVe WHERE MaVe = @MaVe)
    BEGIN
        RAISERROR(N'Chi tiết vé không tồn tại.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Mã chuyến bay không tồn tại.', 16, 1);
        RETURN;
    END

   

    IF NOT EXISTS (SELECT 1 FROM HangGhe WHERE MaHangGhe = @MaHangGhe)
    BEGIN
        RAISERROR(N'Mã hạng ghế không tồn tại.', 16, 1);
        RETURN;
    END
   
    UPDATE Ve
    SET MaHanhKhach = @MaHK, MaTTV = @MaTTV
    WHERE MaVe = @MaVe;

    UPDATE ChiTietVe
    SET MaChuyenBay = @MaChuyenBay, MaHangGhe = @MaHangGhe
    WHERE MaVe = @MaVe;

    PRINT N'Vé và chi tiết vé đã được cập nhật thành công.';
END;
EXEC sp_SuaVeVaChiTiet
    @MaVe = 1, 
    @MaHK = 2, 
    @MaTTV = 2, 
    @MaChuyenBay = 3, 
    @MaHangGhe = 4;



	
CREATE PROCEDURE sp_TaoPhieuDat
    @MaKhachHang INT,           
    @NgayDat DATETIME,          
    @SoLuongHanhKhach INT = 1,  
    @MaPhieuDat INT OUTPUT      
AS
BEGIN
    
    IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang = @MaKhachHang)
    BEGIN
        PRINT 'Mã khách hàng không tồn tại';
        RETURN;
    END

     
    INSERT INTO PhieuDat (MaKhachHang, NgayDat, SoLuongHanhKhach)
    VALUES (@MaKhachHang, @NgayDat, @SoLuongHanhKhach);

     
    SET @MaPhieuDat = SCOPE_IDENTITY();

    
    PRINT 'Đặt vé thành công';
END;

---proc tạo chi tiết phiếu đặt
CREATE PROCEDURE sp_SuaHanhKhachVe
    @MaVe INT,            
    @MaHK INT           
      
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM Ve WHERE MaVe = @MaVe)
    BEGIN
        RAISERROR(N'Vé không tồn tại.', 16, 1);
        RETURN;
    END
    IF NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHK)
    BEGIN
        RAISERROR(N'Hành khách không tồn tại.', 16, 1);
        RETURN;
    END
	   
    UPDATE Ve
    SET MaHanhKhach = @MaHK
	Where MaVe = @MaVe
 END;


---proc tạo chi tiết phiếu đặt

CREATE PROCEDURE sp_TaoChiTietPhieuDat
    @MaPhieuDat INT,       -- Mã phiếu đặt
    @MaVe INT,              -- Mã vé
	@MaHK INT
AS
BEGIN
    -- Kiểm tra xem phiếu đặt có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        PRINT 'Mã phiếu đặt không tồn tại';
        RETURN;
    END

    -- Kiểm tra xem vé có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM Ve WHERE MaVe = @MaVe)
    BEGIN
        PRINT 'Mã vé không tồn tại';
        RETURN;
    END

    -- Chèn dữ liệu vào bảng ChiTietPhieuDat
    INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaVe)
    VALUES (@MaPhieuDat, @MaVe);

	exec sp_SuaHanhKhachVe @MaVe, @MaHK
    -- Trả về thông báo thành công
    PRINT 'Chi tiết phiếu đặt đã được thêm thành công';
END;
--proc xóa phiếu đặt
CREATE PROCEDURE sp_XoaPhieuDat
    @MaPhieuDat INT
AS
BEGIN
     
    IF dbo.fn_KiemTraPhiuDatCoHoaDon(@MaPhieuDat) = 1
    BEGIN
        
        DELETE FROM HoaDon WHERE MaPhieuDat = @MaPhieuDat;
    END
 
    IF dbo.fn_KiemTraPhiuDatCoTienIch(@MaPhieuDat) = 1
    BEGIN
         
        DELETE FROM DatTienIch WHERE MaPhieuDat = @MaPhieuDat;
    END

    
    DELETE FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat;

     
    DELETE FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat;
    
    PRINT 'Xóa phiếu đặt thành công';
END;

---sửa phiếu đặt(sửa tên khách hàng và ngày đặt)
CREATE PROCEDURE sp_SuaPhieuDat
    @MaPhieuDat INT,           
    @MaKhachHang INT,          
    @NgayDat DATETIME         
AS
BEGIN
    
    IF NOT EXISTS (SELECT 1 FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        PRINT 'Mã phiếu đặt không tồn tại';
        RETURN;
    END

     IF @NgayDat < GETDATE()
    BEGIN
        PRINT 'Ngày đặt phải lớn hơn hoặc bằng ngày hiện tại';
        RETURN;
    END

     IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang = @MaKhachHang)
    BEGIN
        PRINT 'Mã khách hàng không tồn tại';
        RETURN;
    END

     UPDATE PhieuDat
    SET MaKhachHang = @MaKhachHang, NgayDat = @NgayDat
    WHERE MaPhieuDat = @MaPhieuDat;

    PRINT 'Sửa phiếu đặt thành công';
END;

---proc xóa vé trong chi tiết phiếu đặt
CREATE PROCEDURE sp_XoaVeTrongPhieuDat
    @MaPhieuDat INT,    
	@MaVe INT
AS
BEGIN
    
    DELETE FROM ChiTietPhieuDat
    WHERE MaPhieuDat = @MaPhieuDat AND MaVe=@MaVe
    
    PRINT 'Xóa vé thành công.';
END;

EXEC sp_XoaVeTrongPhieuDat @MaPhieuDat = 5, @MaVe = 6;
select*from ChiTietPhieuDat




-----proc suachitietphieudat
CREATE PROCEDURE sp_SuaChiTietVeTrongPhieuDat
    @MaPhieuDat INT,  
	@MaVe INT
AS
BEGIN
    
        UPDATE ChiTietPhieuDat
        SET MaVe = @MaVe
        WHERE MaPhieuDat = @MaPhieuDat 

        PRINT 'Cập nhật mã vé thành công.';
    
    
    
END;
EXEC sp_SuaChiTietVeTrongPhieuDat @MaPhieuDat = 4, @MaVe = 7

--------FUNCTION--------------------
-----kiểm tra vé có được đặt hông
CREATE FUNCTION fn_KiemTraVeTrongPhieuDat
(
    @MaVe INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @KetQua BIT;

    IF EXISTS (SELECT 1 FROM ChiTietPhieuDat WHERE MaVe = @MaVe)
    BEGIN
        SET @KetQua = 1;  
    END

    ELSE
    BEGIN
        SET @KetQua = 0;  
    END

    RETURN @KetQua;
END;


--function kiểm tra phiếu đặt hóa đơn
CREATE FUNCTION fn_KiemTraPhiuDatCoHoaDon (@MaPhieuDat INT)
RETURNS BIT
AS
BEGIN
    DECLARE @result BIT;

     IF EXISTS (SELECT 1 FROM HoaDon WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        SET @result = 1; 
    END
    ELSE
    BEGIN
        SET @result = 0;  
    END

    RETURN @result;
END;

----function kiểm tra phiếu đăt tiện ích
CREATE FUNCTION fn_KiemTraPhiuDatCoTienIch (@MaPhieuDat INT)
RETURNS BIT
AS
BEGIN
    DECLARE @result BIT;

     IF EXISTS (SELECT 1 FROM DatTienIch WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        SET @result = 1; 
    END
    ELSE
    BEGIN
        SET @result = 0;  
    END

    RETURN @result;
END;


----------------TRIGGER---------------
--CẬP NHẬT TRẠNG THÁI PHIẾU ĐẶT 

CREATE TRIGGER trg_CapNhatTrangThaiVe
ON ChiTietPhieuDat
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

     IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
       
        UPDATE Ve
        SET MaTTV = 2
        WHERE MaVe IN (SELECT MaVe FROM inserted);
    END

     
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
         
        UPDATE Ve
        SET MaTTV = 1
        WHERE MaVe IN (SELECT MaVe FROM deleted);
    END

     IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
         
        UPDATE Ve
        SET MaTTV = 1
        WHERE MaVe IN (SELECT MaVe FROM deleted);

       
        UPDATE Ve
        SET MaTTV = 2
        WHERE MaVe IN (SELECT MaVe FROM inserted);
    END

    PRINT N'MaTTV đã được cập nhật thành công cho các vé được thêm, xóa hoặc sửa.';
END;


DROP TRIGGER trg_CapNhatTrangThaiVe



----trigger cập nhật số lượng hành khách khi mà có vé được thêm vào hoặc xóa trong phiếu đặt đó
CREATE TRIGGER trg_CapNhatSoLuongHanhKhach
ON ChiTietPhieuDat
AFTER INSERT, DELETE
AS
BEGIN
     
    DECLARE @MaPhieuDat INT;

     IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        SELECT @MaPhieuDat = MaPhieuDat FROM inserted;
    END

     IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        SELECT @MaPhieuDat = MaPhieuDat FROM deleted;
    END

     DECLARE @SoLuongVes INT;

     SELECT @SoLuongVes = COUNT(*) FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat;

     UPDATE PhieuDat
    SET SoLuongHanhKhach = @SoLuongVes
    WHERE MaPhieuDat = @MaPhieuDat;
    
END;



--============================================================================================================================================-----------------------
--============================================================================================================================================--------------------------

-- Khoa
-- Stored Proc

-- Tìm kiếm chuyến bay theo lộ trình và ngày đi 

CREATE PROCEDURE sp_TimKiemChuyenBay
    @MaHangHangKhong INT = NULL,
    @MaTrangThaiChuyenBay INT = NULL,
    @MaLoTrinh INT = NULL,
    @MaMayBay INT = NULL,
    @NgayDi DATE = NULL
AS
BEGIN
    SELECT 
        cb.MaChuyenBay,
        hhk.TenHangHangKhong,
        ttc.TenTrangThaiChuyenBay,
        lt.TenLoTrinh,
        mb.TenMayBay,
        cb.GiaBay,
        cb.NgayGioDi,
        cb.NgayGioDen
    FROM 
        ChuyenBay cb
    JOIN 
        HangHangKhong hhk ON cb.MaHangHangKhong = hhk.MaHangHangKhong
    JOIN 
        TrangThaiChuyenBay ttc ON cb.MaTrangThaiChuyenBay = ttc.MaTrangThaiChuyenBay
    JOIN 
        LoTrinh lt ON cb.MaLoTrinh = lt.MaLoTrinh
    JOIN 
        MayBay mb ON cb.MaMayBay = mb.MaMayBay
    WHERE 
        (@MaHangHangKhong IS NULL OR cb.MaHangHangKhong = @MaHangHangKhong) AND
        (@MaTrangThaiChuyenBay IS NULL OR cb.MaTrangThaiChuyenBay = @MaTrangThaiChuyenBay) AND
        (@MaLoTrinh IS NULL OR cb.MaLoTrinh = @MaLoTrinh) AND
        (@MaMayBay IS NULL OR cb.MaMayBay = @MaMayBay) AND
        (@NgayDi IS NULL OR CONVERT(DATE, cb.NgayGioDi) = @NgayDi)
END

-- Tìm kiếm theo hãng hàng không và lộ trình
EXEC sp_TimKiemChuyenBay @MaHangHangKhong = 5;



-- Tìm kiếm theo tất cả các tiêu chí
EXEC sp_TimKiemChuyenBay @MaHangHangKhong = 1, @MaTrangThaiChuyenBay = 1, @MaLoTrinh = 1, @MaMayBay = 1;

 -- Tìm Kiếm chuyến bay báo số lượng vé:
 
CREATE PROCEDURE sp_TimKiemChuyenBay2
    @MaHangHangKhong INT = NULL,
    @MaTrangThaiChuyenBay INT = NULL,
    @MaLoTrinh INT = NULL,
    @MaMayBay INT = NULL,
    @NgayDi DATE = NULL
AS
BEGIN
    SELECT 
        c.MaChuyenBay,
        h.TenHangHangKhong,
        CASE 
            WHEN UnusedTickets.Soluong > 0 THEN CAST(UnusedTickets.Soluong AS NVARCHAR)
            ELSE N'Hết vé'
        END AS SoLuongVe,
        l.TenLoTrinh,
        m.TenMayBay,
        c.GiaBay,
        c.NgayGioDi,
        c.NgayGioDen
    FROM ChuyenBay c
    JOIN HangHangKhong h ON c.MaHangHangKhong = h.MaHangHangKhong
    JOIN LoTrinh l ON c.MaLoTrinh = l.MaLoTrinh
    JOIN MayBay m ON c.MaMayBay = m.MaMayBay
    LEFT JOIN (
        SELECT 
            ctv.MaChuyenBay,
            COUNT(ctv.MaVe) AS Soluong
        FROM ChiTietVe ctv
        LEFT JOIN Ve v ON ctv.MaVe = v.MaVe
        WHERE v.MaHanhKhach IS NULL
        GROUP BY ctv.MaChuyenBay
    ) AS UnusedTickets ON UnusedTickets.MaChuyenBay = c.MaChuyenBay
    WHERE 
        (@MaHangHangKhong IS NULL OR c.MaHangHangKhong = @MaHangHangKhong) AND
        (@MaTrangThaiChuyenBay IS NULL OR c.MaTrangThaiChuyenBay = @MaTrangThaiChuyenBay) AND
        (@MaLoTrinh IS NULL OR c.MaLoTrinh = @MaLoTrinh) AND
        (@MaMayBay IS NULL OR c.MaMayBay = @MaMayBay) AND
        (@NgayDi IS NULL OR CONVERT(DATE, c.NgayGioDi) = @NgayDi);
END;


-- Cập nhật trạng thái chuyến bay 




-- Thêm mới chuyến bay

CREATE PROCEDURE sp_ThemMoiChuyenBay
(
    @MaHangHangKhong INT,
    @MaTrangThaiChuyenBay INT,
    @MaLoTrinh INT,
    @MaMayBay INT,
    @GiaBay MONEY,
	@NgayGioDi Datetime,
	@NgayGioDen Datetime

)
AS
BEGIN

    IF dbo.fn_KiemTraTonTaiChuyenBay(@MaHangHangKhong, @MaTrangThaiChuyenBay, @MaLoTrinh, @MaMayBay) = 1
    BEGIN
        PRINT N'Chuyến bay đã tồn tại!';
        RETURN;   
    END

    INSERT INTO ChuyenBay (MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh, MaMayBay, GiaBay, NgayGioDi, NgayGioDen)
    VALUES (@MaHangHangKhong, @MaTrangThaiChuyenBay, @MaLoTrinh, @MaMayBay, @GiaBay, @NgayGioDi, @NgayGioDen);

    PRINT N'Chuyến bay đã được thêm mới thành công!';
END;

--Thuc thi
EXEC sp_ThemMoiChuyenBay @MaHangHangKhong = 5, @MaTrangThaiChuyenBay = 2, @MaLoTrinh = 2, @MaMayBay = 4, @GiaBay = 1500000, @NgayGioDi = '2024-11-25 09:30:00', @NgayGioDen = '2024-11-25 11:30:00';


-- Xóa chuyến bay

CREATE PROCEDURE sp_XoaChuyenBay
(
    @MaChuyenBay INT
)
AS
BEGIN
   
    IF dbo.fn_KiemTraChuyenBayBanVeChua(@MaChuyenBay) = 1
    BEGIN
        PRINT N'Chuyến bay này đã bán vé, không thể xóa!';
        RETURN;   
    END

     DELETE FROM ChuyenBay
    WHERE MaChuyenBay = @MaChuyenBay;

    PRINT N'Chuyến bay đã được xóa thành công!';
END;


EXEC sp_XoaChuyenBay @MaChuyenBay = 6;


-- Sửa  chuyến bay

CREATE PROCEDURE sp_SuaTTChuyenBay
(
    @MaChuyenBay INT,            
    @MaHangHangKhong INT,      
    @MaTrangThaiChuyenBay INT,       
    @MaLoTrinh INT,                
    @MaMayBay INT,     
    @GiaBay MONEY,
	@NgayGioDi Datetime,
	@NgayGioDen Datetime
)
AS
BEGIN
     
    IF dbo.fn_KiemTraTonTaiChuyenBay(@MaHangHangKhong, @MaTrangThaiChuyenBay, @MaLoTrinh, @MaMayBay) = 1
    BEGIN
        PRINT N'Chuyến bay này đã tồn tại, không thể sửa!';
        RETURN;   
    END

     UPDATE ChuyenBay
    SET
        MaHangHangKhong = @MaHangHangKhong,
        MaTrangThaiChuyenBay = @MaTrangThaiChuyenBay,
        MaLoTrinh = @MaLoTrinh,
        MaMayBay = @MaMayBay,
        GiaBay = @GiaBay,
		NgayGioDi = @NgayGioDi,
		NgayGioDen = @NgayGioDen
    WHERE MaChuyenBay = @MaChuyenBay;

    PRINT N'Thông tin chuyến bay đã được sửa thành công!';
END;

--Thuc thi
EXEC sp_SuaTTChuyenBay @MaChuyenBay = 5, @MaHangHangKhong = 3, @MaTrangThaiChuyenBay = 2, @MaLoTrinh = 5, @MaMayBay = 4, @GiaBay = 5000000, @NgayGioDi = '2024-11-25 09:30:00', @NgayGioDen = '2024-11-25 11:30:00';      


-- Thêm máy bay

CREATE PROCEDURE sp_ThemMayBay
(
    @TenMayBay NVARCHAR(100),
    @SucChuaToiDa INT               
)
AS
BEGIN
     
    IF dbo.fn_KiemTraTonTaiMayBay(@TenMayBay) = 1
    BEGIN
        PRINT N'Máy bay này đã tồn tại!';
        RETURN;   
    END

     INSERT INTO MayBay (TenMayBay, SucChuaToiDa)
    VALUES (@TenMayBay, @SucChuaToiDa);

    PRINT N'Máy bay đã được thêm thành công!';
END;

--Thuc thi
EXEC sp_ThemMayBay @TenMayBay = 'Boeing 666', @SucChuaToiDa = 300; 


-- Xóa máy bay

CREATE PROCEDURE sp_XoaMayBay
(
    @MaMayBay INT           
)
AS
BEGIN
     
    IF dbo.fn_KiemTraMayBayDuocDung(@MaMayBay) = 1
    BEGIN
        PRINT N'Máy bay này đang được sử dụng trong chuyến bay, không thể xóa!';
        RETURN;   
    END

     DELETE FROM MayBay
    WHERE MaMayBay = @MaMayBay;

    PRINT N'Máy bay đã được xóa thành công!';
END;

--Thuc thi
EXEC sp_XoaMayBay @MaMayBay = 6; 


-- Sửa thông tin máy bay

CREATE PROCEDURE sp_SuaTTMayBay
(
    @MaMayBay INT,               
    @TenMayBay NVARCHAR(100),  
    @SucChuaToiDa INT       
)
AS
BEGIN
    
    IF dbo.fn_KiemTraTonTaiMayBay(@TenMayBay) = 1
    BEGIN
        PRINT N'Máy bay với tên này đã tồn tại, không thể sửa!';
        RETURN;   
    END

   
    UPDATE MayBay
    SET TenMayBay = @TenMayBay,     
        SucChuaToiDa = @SucChuaToiDa   
    WHERE MaMayBay = @MaMayBay;

    PRINT N'Thông tin máy bay đã được sửa thành công!';
END;

--Thuc thi
EXEC dbo.sp_SuaTTMayBay @MaMayBay = 1, @TenMayBay = 'Boeing 737 M', @SucChuaToiDa = 330; 


-- Thêm tiện ích


CREATE PROCEDURE sp_ThemTienIch
(
    @TenTienIch NVARCHAR(100),
    @GiaTienIch DECIMAL(18, 2),  
	@MaLoaiTienIch INT
)
AS
BEGIN
     
    IF dbo.fn_KiemTraTonTaiTienIch(@TenTienIch) = 1
    BEGIN
        PRINT N'Tiện ích này đã tồn tại trong hệ thống!';
        RETURN;   
    END

     INSERT INTO TienIch (TenTienIch, GiaTienIch, MaLoaiTienIch)
    VALUES (@TenTienIch, @GiaTienIch, @MaLoaiTienIch);

    PRINT N'Tiện ích đã được thêm thành công!';
END;

--Thuc thi
EXEC sp_ThemTienIch @TenTienIch = 'WiFi Premium', @GiaTienIch = 100000.00;





-- Xóa tiện ích

CREATE PROCEDURE sp_XoaTienIch
(
    @MaTienIch INT    
)
AS
BEGIN

     DELETE FROM TienIch
    WHERE MaTienIch = @MaTienIch;

    PRINT N'Tiện ích đã được xóa thành công!';
END;


EXEC sp_XoaTienIch @MaTienIch = 11;


-- Sửa tiện ích
drop proc sp_SuaTienIch

CREATE PROCEDURE sp_SuaTienIch
(
    @MaTienIch INT,            
    @TenTienIch NVARCHAR(100), 
    @GiaTienIch DECIMAL(18, 2),
	@MaLoaiTienIch INT

)
AS
BEGIN

     IF dbo.fn_KiemTraTonTaiTienIch(@TenTienIch) = 1 
    BEGIN
        PRINT N'Tên tiện ích này đã tồn tại trong hệ thống! Không thể sửa';
        RETURN;   
    END

     UPDATE TienIch
    SET TenTienIch = @TenTienIch,
        GiaTienIch = @GiaTienIch,
		MaLoaiTienIch = @MaLoaiTienIch
    WHERE MaTienIch = @MaTienIch;

    PRINT N'Thông tin tiện ích đã được cập nhật thành công!';
END;

--Thuc thi
EXEC sp_SuaTienIch @MaTienIch = 1, @TenTienIchMoi = 'Bữa ăn nhẹ', @GiaTienIchMoi = 150.00;


-- Function




-- Kiểm tra chuyến bay đã tồn tại chưa

CREATE FUNCTION fn_KiemTraTonTaiChuyenBay
(
    @MaHangHangKhong INT,
    @MaTrangThaiChuyenBay INT,
    @MaLoTrinh INT,
    @MaMayBay INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

     IF EXISTS (
        SELECT 1
        FROM ChuyenBay
        WHERE MaHangHangKhong = @MaHangHangKhong
          AND MaTrangThaiChuyenBay = @MaTrangThaiChuyenBay
          AND MaLoTrinh = @MaLoTrinh
          AND MaMayBay = @MaMayBay
    )
    BEGIN
        SET @Exists = 1;   
    END
    ELSE
    BEGIN
        SET @Exists = 0;   
    END

    RETURN @Exists;
END;


-- Kiểm tra chuyến bay đã bán vé chưa

CREATE FUNCTION fn_KiemTraChuyenBayBanVeChua
(
    @MaChuyenBay INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

     IF EXISTS (
        SELECT 1
        FROM ChiTietVe
        WHERE MaChuyenBay = @MaChuyenBay
    )
    BEGIN
        SET @Exists = 1;   
    END
    ELSE
    BEGIN
        SET @Exists = 0;  
    END

    RETURN @Exists;
END;


-- Kiểm tra tồn tại máy bay

CREATE FUNCTION fn_KiemTraTonTaiMayBay
(
    @TenMayBay NVARCHAR(100)        
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

     IF EXISTS (
        SELECT 1
        FROM MayBay
        WHERE TenMayBay = @TenMayBay
    )
    BEGIN
        SET @Exists = 1;   
    END
    ELSE
    BEGIN
        SET @Exists = 0;   
    END

    RETURN @Exists;
END;


-- Kiểm tra máy bay được dùng chưa 

CREATE FUNCTION fn_KiemTraMayBayDuocDung
(
    @MaMayBay INT       
)
RETURNS BIT
AS
BEGIN
    DECLARE @IsUsed BIT;

     IF EXISTS (
        SELECT 1
        FROM ChuyenBay
        WHERE MaMayBay = @MaMayBay
    )
    BEGIN
        SET @IsUsed = 1;   
    END
    ELSE
    BEGIN
        SET @IsUsed = 0;  
    END

    RETURN @IsUsed;
END;

-- Kiem tra tồn tại tiện ích

CREATE FUNCTION fn_KiemTraTonTaiTienIch
(
    @TenTienIch NVARCHAR(100)   
)
RETURNS BIT
AS
BEGIN
    DECLARE @IsExist BIT;

     IF EXISTS (
        SELECT 1
        FROM TienIch
        WHERE TenTienIch = @TenTienIch
    )
    BEGIN
        SET @IsExist = 1;   
    END
    ELSE
    BEGIN
        SET @IsExist = 0;   
    END

    RETURN @IsExist;
END;

--- ============================== ---
--			HANH KHACH			   ---
--- ============================== ---

-- Sửa thông tin hành khách
CREATE PROCEDURE sp_SuaThongTinHanhKhach
    @MaHanhKhach INT,
    @HoTen NVARCHAR(100) = NULL,
    @DiaChi NVARCHAR(255) = NULL,
    @GioiTinh NVARCHAR(10) = NULL,
    @QuocTich NVARCHAR(50) = NULL,
    @NgaySinh DATE = NULL,
    @SoDienThoai NVARCHAR(20) = NULL,
    @Email NVARCHAR(100) = NULL,
    @CCCD_Passport NVARCHAR(20) = NULL,
    @MaKhachHang INT = NULL
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
         UPDATE HanhKhach
        SET 
            HoTen = ISNULL(@HoTen, HoTen),
            DiaChi = ISNULL(@DiaChi, DiaChi),
            GioiTinh = ISNULL(@GioiTinh, GioiTinh),
            QuocTich = ISNULL(@QuocTich, QuocTich),
            NgaySinh = ISNULL(@NgaySinh, NgaySinh),
            SoDienThoai = ISNULL(@SoDienThoai, SoDienThoai),
            Email = ISNULL(@Email, Email),
            CCCD_Passport = ISNULL(@CCCD_Passport, CCCD_Passport),
            MaKhachHang = ISNULL(@MaKhachHang, MaKhachHang)
        WHERE MaHanhKhach = @MaHanhKhach;

         IF @@ROWCOUNT = 0
        BEGIN
            THROW 50001, N'Mã Hành Khách không tồn tại.', 1;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

         DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;


----------proc thêm hành khách
CREATE PROCEDURE sp_ThemHanhKhach
    @HoTen NVARCHAR(100),
    @DiaChi NVARCHAR(255),
    @GioiTinh NVARCHAR(10),
    @QuocTich NVARCHAR(50),
    @NgaySinh DATE,
    @SoDienThoai NVARCHAR(20) = NULL, 
    @Email NVARCHAR(100) = NULL,    
    @CCCD_Passport NVARCHAR(20),
    @MaKhachHang INT            
AS
BEGIN
    SET NOCOUNT ON;

     IF EXISTS (
        SELECT 1
        FROM HanhKhach
        WHERE CCCD_Passport = @CCCD_Passport
    )
    BEGIN
        RAISERROR('CCCD hoặc Passport này đã có người dùng.', 16, 1);
        RETURN;
    END;

     IF @MaKhachHang IS NOT NULL AND NOT EXISTS (
        SELECT 1
        FROM KhachHang
        WHERE MaKhachHang = @MaKhachHang
    )
    BEGIN
        RAISERROR('MaKhachHang không tồn tại trong bảng KhachHang.', 16, 1);
        RETURN;
    END;

     
    INSERT INTO HanhKhach (HoTen, DiaChi, GioiTinh, QuocTich, NgaySinh, SoDienThoai, Email, CCCD_Passport, MaKhachHang)
    VALUES (@HoTen, @DiaChi, @GioiTinh, @QuocTich, @NgaySinh, @SoDienThoai, @Email, @CCCD_Passport, @MaKhachHang);

    PRINT 'Thêm hành khách thành công.';
END;

EXEC sp_ThemHanhKhach
    @HoTen = N'Nguyễn Văn A',
    @DiaChi = N'123 Đường ABC, Quận 1, TP.HCM',
    @GioiTinh = N'Nam',
    @QuocTich = N'Việt Nam',
    @NgaySinh = '1995-10-15',
    @SoDienThoai = '0912345678',
    @Email = 'nguyenvana@gmail.com',
    @CCCD_Passport = '12345678',
    @MaKhachHang = 1;

---function kiểm tra hành khách có đặt vé hay không
CREATE FUNCTION dbo.fn_KiemTraHanhKhachCoDatVe (@maHanhKhach INT)
RETURNS BIT
AS
BEGIN
    DECLARE @isExist BIT

     IF EXISTS (SELECT 1 FROM Ve WHERE MaHanhKhach = @maHanhKhach)
    BEGIN
        SET @isExist = 1  
    END
    ELSE
    BEGIN
        SET @isExist = 0  
    END

    RETURN @isExist
END

    





---proc xóa hành khách
CREATE PROCEDURE dbo.sp_XoaHanhKhach (@maHanhKhach INT)
AS
BEGIN
    
    IF dbo.fn_KiemTraHanhKhachCoDatVe(@maHanhKhach) = 1
    BEGIN
        PRINT 'Không thể xóa hành khách. Hành khách này đã đặt vé.'
         RETURN
    END
    
     BEGIN
        DELETE FROM HanhKhach WHERE MaHanhKhach = @maHanhKhach
        PRINT 'Hành khách đã được xóa thành công.'
    END
END

drop proc SuaHanhKhach
--proc sửa hành khách
CREATE PROCEDURE sp_SuaHanhKhach
    @MaHanhKhach INT,
    @HoTen NVARCHAR(100),
    @DiaChi NVARCHAR(255),
    @GioiTinh NVARCHAR(10),
    @QuocTich NVARCHAR(50),
    @NgaySinh DATE,
    @SoDienThoai NVARCHAR(20),
    @Email NVARCHAR(100),
    @CCCD_Passport NVARCHAR(20),
    @MaKhachHang INT = NULL  
AS
BEGIN
    
    IF NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHanhKhach)
    BEGIN
        PRINT 'Hành khách không tồn tại!';
        RETURN;
    END

     IF @MaKhachHang IS NOT NULL AND NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang = @MaKhachHang)
    BEGIN
        PRINT 'Mã khách hàng không tồn tại!';
        RETURN;
    END

     UPDATE HanhKhach
    SET
        HoTen = @HoTen,
        DiaChi = @DiaChi,
        GioiTinh = @GioiTinh,
        QuocTich = @QuocTich,
        NgaySinh = @NgaySinh,
        SoDienThoai = @SoDienThoai,
        Email = @Email,
        CCCD_Passport = @CCCD_Passport,
        MaKhachHang = @MaKhachHang
    WHERE MaHanhKhach = @MaHanhKhach;

    PRINT 'Cập nhật hành khách thành công!';
END;


EXEC SuaHanhKhach
    @MaHanhKhach = 1,           
    @HoTen = N'Nguyễn Văn A',   
    @DiaChi = N'Quận 1, TP.HCM', 
    @GioiTinh = N'Nam',          
    @QuocTich = N'Việt Nam',     
    @NgaySinh = '1990-01-01',   
    @SoDienThoai = '0987654321', 
    @Email = N'nguyenvana@example.com',  
    @CCCD_Passport = '1555456789', 
    @MaKhachHang = 6;          
	
	create proc sp_xuatHoaDonUser @TenTaiKhoan varchar(100)
	as
	begin
	select hd.MaHoaDon, pd.MaPhieuDat, hd.TongTien, tk.TenTaiKhoan from HoaDon hd
	join PhieuDat pd on pd.MaPhieuDat = hd.MaPhieuDat
	join KhachHang kh on kh.MaKhachHang = pd.MaKhachHang
	join TaiKhoan tk on tk.MaTaiKhoan = kh.MaTaiKhoan
	where tk.TenTaiKhoan = @TenTaiKhoan;
	end

	exec sp_xuatHoaDonUser 'Admin'

	select * from PhieuDat
	select * from TaiKhoan
	select * from KhachHang



	---============cursorr
	---lộ trình được bay nhiều nhất

CREATE PROCEDURE sp_ThongKeLoTrinhBayNhieuNhat
AS
BEGIN
    DECLARE @MaLoTrinh INT;
    DECLARE @TenLoTrinh NVARCHAR(100);
    DECLARE @SoLanBay INT;
    DECLARE @MaxSoLanBay INT = 0;
    DECLARE @MaxMaLoTrinh INT;

     DECLARE LoTrinhCursor CURSOR FOR
    SELECT MaLoTrinh, TenLoTrinh
    FROM LoTrinh;

     OPEN LoTrinhCursor;

     FETCH NEXT FROM LoTrinhCursor INTO @MaLoTrinh, @TenLoTrinh

    WHILE @@FETCH_STATUS = 0
    BEGIN
        
        SELECT @SoLanBay = COUNT(*)
        FROM ChuyenBay
        WHERE MaLoTrinh = @MaLoTrinh;

         IF @SoLanBay > @MaxSoLanBay
        BEGIN
            SET @MaxSoLanBay = @SoLanBay;
            SET @MaxMaLoTrinh = @MaLoTrinh;
        END

         FETCH NEXT FROM LoTrinhCursor INTO @MaLoTrinh, @TenLoTrinh
    END;

     CLOSE LoTrinhCursor;
    DEALLOCATE LoTrinhCursor;

     SELECT 
        LT.MaLoTrinh as N'Mã lộ trình', 
        LT.TenLoTrinh as N'Tên lộ trình',  
        @MaxSoLanBay AS N'Số chuyến bay'
    FROM LoTrinh LT
    WHERE EXISTS (
        SELECT 1
        FROM ChuyenBay CB
        WHERE CB.MaLoTrinh = LT.MaLoTrinh
        GROUP BY CB.MaLoTrinh
        HAVING COUNT(*) = @MaxSoLanBay
    );
END;


-----chuyen bay được đặt nhiều nhất



CREATE PROCEDURE sp_ChuyenBayDatNhieuNhat
AS
BEGIN
     
    DECLARE @MaxSoLanDat INT = 0;
    DECLARE @MaChuyenBay INT;
    DECLARE @TenHangHangKhong NVARCHAR(100);
    DECLARE @TenLoTrinh NVARCHAR(100);
    DECLARE @TenMayBay NVARCHAR(100);
    DECLARE @GiaBay DECIMAL(18, 2);
    DECLARE @NgayGioDi DATETIME;
    DECLARE @NgayGioDen DATETIME;
    DECLARE @SoLanDat INT;
 
    DECLARE FlightCursor CURSOR FOR
    SELECT 
        CB.MaChuyenBay,
        HHK.TenHangHangKhong,
        LT.TenLoTrinh,
        MB.TenMayBay,
        CB.GiaBay,
        CB.NgayGioDi,
        CB.NgayGioDen
    FROM ChuyenBay CB
    INNER JOIN HangHangKhong HHK ON CB.MaHangHangKhong = HHK.MaHangHangKhong
    INNER JOIN LoTrinh LT ON CB.MaLoTrinh = LT.MaLoTrinh
    INNER JOIN MayBay MB ON CB.MaMayBay = MB.MaMayBay;

     OPEN FlightCursor;

     FETCH NEXT FROM FlightCursor INTO @MaChuyenBay, @TenHangHangKhong, @TenLoTrinh, @TenMayBay, @GiaBay, @NgayGioDi, @NgayGioDen;

     WHILE @@FETCH_STATUS = 0
    BEGIN
         
        SELECT @SoLanDat = COUNT(DV.MaVe)
        FROM ChiTietVe CTV
        LEFT JOIN Ve DV ON CTV.MaVe = DV.MaVe
        WHERE CTV.MaChuyenBay = @MaChuyenBay;

         IF @SoLanDat > @MaxSoLanDat
        BEGIN
            SET @MaxSoLanDat = @SoLanDat;
        END

         FETCH NEXT FROM FlightCursor INTO @MaChuyenBay, @TenHangHangKhong, @TenLoTrinh, @TenMayBay, @GiaBay, @NgayGioDi, @NgayGioDen;
    END;

     CLOSE FlightCursor;
    DEALLOCATE FlightCursor;

     SELECT 
        CB.MaChuyenBay AS N'Mã chuyến bay',
        HHK.TenHangHangKhong AS N'Tên hãng hàng không',
        LT.TenLoTrinh AS N'Tên lộ trình',
        MB.TenMayBay AS N'Tên máy bay',
        CB.GiaBay AS N'Giá bay',
        CB.NgayGioDi AS N'Ngày giờ đi',
        CB.NgayGioDen AS N'Ngày giờ đến',
        COUNT(DV.MaVe) AS N'Số lần đặt vé'
    FROM ChuyenBay CB
    INNER JOIN HangHangKhong HHK ON CB.MaHangHangKhong = HHK.MaHangHangKhong
    INNER JOIN LoTrinh LT ON CB.MaLoTrinh = LT.MaLoTrinh
    INNER JOIN MayBay MB ON CB.MaMayBay = MB.MaMayBay
    LEFT JOIN ChiTietVe CTV ON CTV.MaChuyenBay = CB.MaChuyenBay
    LEFT JOIN Ve DV ON CTV.MaVe = DV.MaVe
    GROUP BY 
        CB.MaChuyenBay,
        HHK.TenHangHangKhong,
        LT.TenLoTrinh,
        MB.TenMayBay,
        CB.GiaBay,
        CB.NgayGioDi,
        CB.NgayGioDen
    HAVING COUNT(DV.MaVe) = @MaxSoLanDat;
END;


----hãng hàng khog dược bay nhiều nhất
CREATE PROCEDURE sp_ThongKeHangHangKhongDatNhieuNhat
AS
BEGIN
     
    DECLARE @MaxSoLanBay INT = 0;
    DECLARE @MaHangHangKhong INT;
    DECLARE @TenHangHangKhong NVARCHAR(100);
    DECLARE @SoLanBay INT;

     DECLARE AirlineCursor CURSOR FOR
    SELECT MaHangHangKhong, TenHangHangKhong
    FROM HangHangKhong;

     OPEN AirlineCursor;

     FETCH NEXT FROM AirlineCursor INTO @MaHangHangKhong, @TenHangHangKhong;

     WHILE @@FETCH_STATUS = 0
    BEGIN
         SELECT @SoLanBay = COUNT(*)
        FROM ChuyenBay
        WHERE MaHangHangKhong = @MaHangHangKhong;

         IF @SoLanBay > @MaxSoLanBay
        BEGIN
            SET @MaxSoLanBay = @SoLanBay;
        END
         FETCH NEXT FROM AirlineCursor INTO @MaHangHangKhong, @TenHangHangKhong;
    END;

     CLOSE AirlineCursor;
    DEALLOCATE AirlineCursor;

     SELECT 
        HHK.MaHangHangKhong AS N'Mã hãng hàng không',
        HHK.TenHangHangKhong AS N'Tên hãng hàng không',
        @MaxSoLanBay AS N'Số chuyến bay'
    FROM HangHangKhong HHK
    WHERE EXISTS (
        SELECT 1
        FROM ChuyenBay CB
        WHERE CB.MaHangHangKhong = HHK.MaHangHangKhong
        GROUP BY CB.MaHangHangKhong
        HAVING COUNT(*) = @MaxSoLanBay
    );
END;


--máy bay được sử dụng nhièu nhất
CREATE PROCEDURE sp_ThongKeMayBayDuocSuDungNhieuNhat
AS
BEGIN
     DECLARE @MaxSoLanSuDung INT = 0;
    DECLARE @MaMayBay INT;
    DECLARE @TenMayBay NVARCHAR(100);
    DECLARE @SoLanSuDung INT;

     DECLARE AircraftCursor CURSOR FOR
    SELECT MaMayBay, TenMayBay
    FROM MayBay;

     OPEN AircraftCursor;

     FETCH NEXT FROM AircraftCursor INTO @MaMayBay, @TenMayBay;

     WHILE @@FETCH_STATUS = 0
    BEGIN
         SELECT @SoLanSuDung = COUNT(*)
        FROM ChuyenBay
        WHERE MaMayBay = @MaMayBay;

         IF @SoLanSuDung > @MaxSoLanSuDung
        BEGIN
            SET @MaxSoLanSuDung = @SoLanSuDung;
        END

         FETCH NEXT FROM AircraftCursor INTO @MaMayBay, @TenMayBay;
    END;

     CLOSE AircraftCursor;
    DEALLOCATE AircraftCursor;

     SELECT 
        MB.MaMayBay AS N'Mã máy bay',
        MB.TenMayBay AS N'Tên máy bay',
        @MaxSoLanSuDung AS N'Số lần sử dụng'
    FROM MayBay MB
    WHERE EXISTS (
        SELECT 1
        FROM ChuyenBay CB
        WHERE CB.MaMayBay = MB.MaMayBay
        GROUP BY CB.MaMayBay
        HAVING COUNT(*) = @MaxSoLanSuDung
    );
END;

select*from KhachHang

-----khách hàng đặt vé nhiều nhất
SELECT 
    KH.MaKhachHang AS N'Mã khách hàng',
    KH.HoTen AS N'Tên khách hàng',
    KH.DiaChi AS N'Địa chỉ',
    KH.Email AS N'Email',
    KH.NgaySinh AS N'Ngày sinh',
    KH.SoDienThoai AS N'Số điện thoại',
    TK.MaTaiKhoan AS N'Mã tài khoản',
    COUNT(PD.MaPhieuDat) AS N'Số lần đặt vé'
FROM 
    KhachHang KH
JOIN 
    TaiKhoan TK ON KH.MaTaiKhoan = TK.MaTaiKhoan
JOIN 
    PhieuDat PD ON KH.MaKhachHang = PD.MaKhachHang
GROUP BY 
    KH.MaKhachHang, KH.HoTen, KH.DiaChi, KH.Email, KH.NgaySinh, KH.SoDienThoai, TK.MaTaiKhoan
ORDER BY 
    COUNT(PD.MaPhieuDat) DESC;


	select*from PhieuDat



	CREATE PROCEDURE sp_KhachHangDatVeNhieuNhat
AS
BEGIN
     DECLARE @MaxSoLanDat INT = 0;
    DECLARE @MaKhachHang INT;
    DECLARE @HoTen NVARCHAR(100);
    DECLARE @DiaChi NVARCHAR(255);
    DECLARE @Email NVARCHAR(100);
    DECLARE @NgaySinh DATE;
    DECLARE @SoDienThoai NVARCHAR(20);
    DECLARE @TenTaiKhoan NVARCHAR(50);
    DECLARE @SoLanDat INT;

     DECLARE CustomerCursor CURSOR FOR
    SELECT 
        KH.MaKhachHang,
        KH.HoTen,
        KH.DiaChi,
        KH.Email,
        KH.NgaySinh,
        KH.SoDienThoai,
        TK.TenTaiKhoan
    FROM KhachHang KH
    INNER JOIN TaiKhoan TK ON KH.MaTaiKhoan = TK.MaTaiKhoan;

     OPEN CustomerCursor;

     FETCH NEXT FROM CustomerCursor INTO @MaKhachHang, @HoTen, @DiaChi, @Email, @NgaySinh, @SoDienThoai, @TenTaiKhoan;

     WHILE @@FETCH_STATUS = 0
    BEGIN
         SELECT @SoLanDat = COUNT(PD.MaPhieuDat)
        FROM PhieuDat PD
        WHERE PD.MaKhachHang = @MaKhachHang;

         IF @SoLanDat > @MaxSoLanDat
        BEGIN
            SET @MaxSoLanDat = @SoLanDat;
        END

         FETCH NEXT FROM CustomerCursor INTO @MaKhachHang, @HoTen, @DiaChi, @Email, @NgaySinh, @SoDienThoai, @TenTaiKhoan;
    END;

     CLOSE CustomerCursor;
    DEALLOCATE CustomerCursor;
	SELECT 
        @MaKhachHang AS MaKhachHang,
        @HoTen AS HoTen,
        @DiaChi AS DiaChi,
        @Email AS Email,
        @NgaySinh AS NgaySinh,
        @SoDienThoai AS SoDienThoai,
        @TenTaiKhoan AS TenTaiKhoan,
        @MaxSoLanDat AS SoLanDat;
END;

CREATE PROC sp_CapNhatThanhToan @MaHD int
AS
BEGIN
	Update HOADON
	Set MaTTHD = 2
	Where MaHoaDon = @MaHD
END;
    
	select * from KhachHang kh join TaiKhoan tk on tk.MaTaiKhoan = kh.MaTaiKhoan where kh.MaTaiKhoan = 1

	select * from taikhoan

	select p.MaPhieuDat ,k.HoTen ,p.NgayDat ,p.SoLuongHanhKhach from PhieuDat p,KhachHang k, TaiKhoan tk where p.MaKhachHang=k.MaKhachHang and tk.MaTaiKhoan = k.MaTaiKhoan and tk.TenTaiKhoan = ''

	CREATE FUNCTION dbo. BackupDatabase (@DatabaseName NVARCHAR (100))
RETURNS NVARCHAR (MAX)
AS
BEGIN
DECLARE @BackupPath NVARCHAR (MAX)
SET @BackupPath = 'D:\Backup\' + @DatabaseName + '.bak'
DECLARE @SQL NVARCHAR (MAX)
SET @SQL='BACKUP DATABASE [' + @DatabaseName + '] TO DISK =''' + @BackupPath +''' WITH INIT;'
RETURN @SQL
END

--BoSung
--Bổ sung:
-- Bảng Ve
INSERT INTO Ve ( MaTTV) VALUES 
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1), 
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1),
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1),
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1),
(1), 
(1), 
(1),
(1),
(1), 
(1);

-- Bảng ChiTietVe
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, MaHangGhe) VALUES

(22, 2, 1), -- Vé 22, Chuyến bay 1, Hạng ghế: Phổ thông
(23, 3, 2), -- Vé 23, Chuyến bay 2, Hạng ghế: Thương gia
(24, 4, 3), -- Vé 24, Chuyến bay 3, Hạng ghế: Hạng nhất
(25, 5, 4), -- Vé 25, Chuyến bay 4, Hạng ghế: Tiết kiệm
(26, 1, 1), -- Vé 26, Chuyến bay 5, Hạng ghế: Phổ thông
(27, 2, 2), -- Vé 27, Chuyến bay 1, Hạng ghế: Thương gia
(28, 3, 3), -- Vé 28, Chuyến bay 2, Hạng ghế: Hạng nhất
(29, 4, 4), -- Vé 29, Chuyến bay 3, Hạng ghế: Tiết kiệm
(30, 5, 1), -- Vé 30, Chuyến bay 4, Hạng ghế: Phổ thông
(31, 1, 2), -- Vé 31, Chuyến bay 5, Hạng ghế: Thương gia
(32, 2, 3), -- Vé 32, Chuyến bay 1, Hạng ghế: Hạng nhất
(33, 3, 1), -- Vé 33, Chuyến bay 1, Hạng ghế: Phổ thông
(34, 4, 2), -- Vé 34, Chuyến bay 2, Hạng ghế: Thương gia
(35, 5, 3), -- Vé 35, Chuyến bay 3, Hạng ghế: Hạng nhất
(36, 1, 4), -- Vé 36, Chuyến bay 4, Hạng ghế: Tiết kiệm
(37, 2, 1), -- Vé 37, Chuyến bay 5, Hạng ghế: Phổ thông
(38, 3, 2), -- Vé 38, Chuyến bay 1, Hạng ghế: Thương gia
(39, 4, 3), -- Vé 39, Chuyến bay 2, Hạng ghế: Hạng nhất
(40, 5, 4), -- Vé 40, Chuyến bay 3, Hạng ghế: Tiết kiệm
(41, 1, 1), -- Vé 41, Chuyến bay 4, Hạng ghế: Phổ thông
(42, 2, 2), -- Vé 42, Chuyến bay 5, Hạng ghế: Thương gia
(43, 3, 3), -- Vé 43, Chuyến bay 1, Hạng ghế: Hạng nhất
(44, 4, 1), -- Vé 44, Chuyến bay 1, Hạng ghế: Phổ thông
(45, 5, 2), -- Vé 45, Chuyến bay 2, Hạng ghế: Thương gia
(46, 1, 3), -- Vé 46, Chuyến bay 3, Hạng ghế: Hạng nhất
(47, 2, 4), -- Vé 47, Chuyến bay 4, Hạng ghế: Tiết kiệm
(48, 3, 1), -- Vé 48, Chuyến bay 5, Hạng ghế: Phổ thông
(49, 4, 2), -- Vé 49, Chuyến bay 1, Hạng ghế: Thương gia
(50, 5, 3), -- Vé 50, Chuyến bay 2, Hạng ghế: Hạng nhất
(51, 1, 4), -- Vé 51, Chuyến bay 3, Hạng ghế: Tiết kiệm
(52, 2, 1), -- Vé 52, Chuyến bay 4, Hạng ghế: Phổ thông
(53, 3, 2), -- Vé 53, Chuyến bay 5, Hạng ghế: Thương gia
(54, 4, 3), -- Vé 54, Chuyến bay 1, Hạng ghế: Hạng nhất
(55, 5, 1), -- Vé 55, Chuyến bay 1, Hạng ghế: Phổ thông
(56, 1, 2), -- Vé 56, Chuyến bay 2, Hạng ghế: Thương gia
(57, 2, 3), -- Vé 57, Chuyến bay 3, Hạng ghế: Hạng nhất
(58, 3, 4), -- Vé 58, Chuyến bay 4, Hạng ghế: Tiết kiệm
(59, 4, 1), -- Vé 59, Chuyến bay 5, Hạng ghế: Phổ thông
(60, 5, 2), -- Vé 60, Chuyến bay 1, Hạng ghế: Thương gia
(61, 2, 3), -- Vé 61, Chuyến bay 2, Hạng ghế: Hạng nhất
(62, 3, 4), -- Vé 62, Chuyến bay 3, Hạng ghế: Tiết kiệm
(63, 4, 1), -- Vé 63, Chuyến bay 4, Hạng ghế: Phổ thông
(64, 5, 2), -- Vé 64, Chuyến bay 5, Hạng ghế: Thương gia
(65, 1, 3), -- Vé 65, Chuyến bay 1, Hạng ghế: Hạng nhất
(66, 1, 1), -- Vé 66, Chuyến bay 1, Hạng ghế: Phổ thông
(67, 2, 2), -- Vé 67, Chuyến bay 2, Hạng ghế: Thương gia
(68, 3, 3), -- Vé 68, Chuyến bay 3, Hạng ghế: Hạng nhất
(69, 4, 4), -- Vé 69, Chuyến bay 4, Hạng ghế: Tiết kiệm
(70, 5, 1), -- Vé 70, Chuyến bay 5, Hạng ghế: Phổ thông
(71, 1, 2), -- Vé 71, Chuyến bay 1, Hạng ghế: Thương gia
(72, 2, 3), -- Vé 72, Chuyến bay 2, Hạng ghế: Hạng nhất
(73, 3, 4), -- Vé 73, Chuyến bay 3, Hạng ghế: Tiết kiệm
(74, 4, 1), -- Vé 74, Chuyến bay 4, Hạng ghế: Phổ thông
(75, 5, 2), -- Vé 75, Chuyến bay 5, Hạng ghế: Thương gia
(76, 1, 3), -- Vé 76, Chuyến bay 1, Hạng ghế: Hạng nhất
(77, 2, 1), -- Vé 77, Chuyến bay 1, Hạng ghế: Phổ thông
(78, 3, 2), -- Vé 78, Chuyến bay 2, Hạng ghế: Thương gia
(79, 4, 3), -- Vé 79, Chuyến bay 3, Hạng ghế: Hạng nhất
(80, 5, 4), -- Vé 80, Chuyến bay 4, Hạng ghế: Tiết kiệm
(81, 1, 1), -- Vé 81, Chuyến bay 5, Hạng ghế: Phổ thông
(82, 2, 2), -- Vé 82, Chuyến bay 1, Hạng ghế: Thương gia
(83, 3, 3), -- Vé 83, Chuyến bay 2, Hạng ghế: Hạng nhất
(84, 4, 4), -- Vé 84, Chuyến bay 3, Hạng ghế: Tiết kiệm
(85, 5, 1), -- Vé 85, Chuyến bay 4, Hạng ghế: Phổ thông
(86, 1, 2), -- Vé 86, Chuyến bay 5, Hạng ghế: Thương gia
(87, 2, 3), -- Vé 87, Chuyến bay 1, Hạng ghế: Hạng nhất
(88, 3, 1), -- Vé 88, Chuyến bay 1, Hạng ghế: Phổ thông
(89, 4, 2), -- Vé 89, Chuyến bay 2, Hạng ghế: Thương gia
(90, 5, 3), -- Vé 90, Chuyến bay 3, Hạng ghế: Hạng nhất
(91, 1, 4), -- Vé 91, Chuyến bay 4, Hạng ghế: Tiết kiệm
(92, 2, 1), -- Vé 92, Chuyến bay 5, Hạng ghế: Phổ thông
(93, 3, 2), -- Vé 15, Chuyến bay 1, Hạng ghế: Thương gia
(94, 4, 3), -- Vé 16, Chuyến bay 2, Hạng ghế: Hạng nhất
(95, 5, 4), -- Vé 17, Chuyến bay 3, Hạng ghế: Tiết kiệm
(96, 1, 1), -- Vé 18, Chuyến bay 4, Hạng ghế: Phổ thông
(97, 2, 2), -- Vé 19, Chuyến bay 5, Hạng ghế: Thương gia
(98, 3, 3), -- Vé 20, Chuyến bay 1, Hạng ghế: Hạng nhất
(99, 4, 1), -- Vé 10, Chuyến bay 1, Hạng ghế: Phổ thông
(100, 5, 2), -- Vé 11, Chuyến bay 2, Hạng ghế: Thương gia
(101, 3, 3), -- Vé 12, Chuyến bay 3, Hạng ghế: Hạng nhất
(102, 4, 4), -- Vé 13, Chuyến bay 4, Hạng ghế: Tiết kiệm
(103, 5, 1), -- Vé 14, Chuyến bay 5, Hạng ghế: Phổ thông
(104, 1, 2), -- Vé 15, Chuyến bay 1, Hạng ghế: Thương gia
(105, 2, 3), -- Vé 16, Chuyến bay 2, Hạng ghế: Hạng nhất
(106, 1, 4), -- Vé 17, Chuyến bay 3, Hạng ghế: Tiết kiệm
(107, 2, 1), -- Vé 18, Chuyến bay 4, Hạng ghế: Phổ thông
(108, 3, 2), -- Vé 19, Chuyến bay 5, Hạng ghế: Thương gia
(109, 4, 3), -- Vé 20, Chuyến bay 1, Hạng ghế: Hạng nhất
(110, 5, 1), -- Vé 10, Chuyến bay 1, Hạng ghế: Phổ thông
(111, 3, 3), -- Vé 12, Chuyến bay 3, Hạng ghế: Hạng nhất
(112, 4, 4), -- Vé 13, Chuyến bay 4, Hạng ghế: Tiết kiệm
(113, 5, 1), -- Vé 14, Chuyến bay 5, Hạng ghế: Phổ thông
(114, 1, 2), -- Vé 15, Chuyến bay 1, Hạng ghế: Thương gia
(115, 2, 3), -- Vé 16, Chuyến bay 2, Hạng ghế: Hạng nhất
(116, 3, 4), -- Vé 17, Chuyến bay 3, Hạng ghế: Tiết kiệm
(117, 4, 1), -- Vé 18, Chuyến bay 4, Hạng ghế: Phổ thông
(118, 5, 2), -- Vé 19, Chuyến bay 5, Hạng ghế: Thương gia
(119, 1, 3), -- Vé 20, Chuyến bay 1, Hạng ghế: Hạng nhất
(120, 2, 3); -- Vé 20, Chuyến bay 1, Hạng ghế: Hạng nhất