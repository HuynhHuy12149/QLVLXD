
CREATE DATABASE Quanlyvatlieuxaydung
use Quanlyvatlieuxaydung

select * from chitiethdban

select * from NHANVIEN



CREATE TABLE CHUCVU(
	MaChucVu nvarchar(50) NOT NULL,
	ChucVu nvarchar(50) NOT NULL,
	primary key (MaChucVu)
)
select * from CHUCVU where Ma

INSERT into CHUCVU  VALUES (N'NV', N'NHÂN VIÊN')
INSERT into CHUCVU  VALUES (N'AD', N'QUAN LÝ')

select * from CHUCVU WHERE macv = AD

CREATE TABLE NHANVIEN(
	MaNV nvarchar(50) NOT NULL ,
	TenNV nvarchar(50) NULL,
	MaChucVu nvarchar(50) NULL,
	DiaChiNV nvarchar(50) NULL,
	SDT varchar(13) NULL,
	GioiTinh nvarchar(50) NULL,
	NgaySinh smalldatetime NULL,
	TenDN nvarchar(50) NULL,
	PassDN nvarchar(50) NULL,
    primary key (MaNV)
)
select TenNV from NHANVIEN where MaNV = N'nv01'
select * from nhanvien
INSERT into NhanVien  VALUES (N'NV004', N'Huỳnh Văn Huy',N'NV', N'Kiên Giang', N'0933436721',N'NAM',N'1/23/2001',N'HUY',N'123456')
INSERT into NhanVien  VALUES (N'NV007', N'Huỳnh Văn Huy',N'NV', N'Kiên Giang', N'0933436721',N'Nữ', N'1/1/2001',N'HUY1',N'123456')
INSERT into NhanVien  VALUES (N'NV0008', N'Huỳnh Văn Huy',N'NV', N'Kiên Giang', N'0933436721',N'Nữ', N'1/1/2001',N'HUY1',N'123456')
SELECT *  from NHANVIEN
WHERE TenDN = N'HUY' and PassDN = N'123456'

delete from NHANVIEN where MaNV = N'NV000'
 select * from nhanvien
 
select TenNV from NHANVIEN as nv , HOADONBAN as hd  where nv.MaNV = hd.MaNV and hd.MaHD = N'HD01' 

CREATE TABLE SANPHAM(
	MaSP nvarchar(50) NOT NULL,
	MaNhom nvarchar(50) NULL,
	TenSP nvarchar(50) NULL,
	DonViTinh nvarchar(50) NULL,
	SLTon int NULL,
	GiaBan int NULL,
	GiaNhap int NULL,
	MaNCC nvarchar(50) NULL,
	primary key (MaSP)
)

select MaSP from SANPHAM
INSERT into SANPHAM VALUES (N'SP001', N'VL001', N'XI MĂNG', N'KHỐI', 50, 7000000, 5000000, N'NCC0001')
INSERT into SANPHAM  VALUES (N'SP002', N'VL001', N'CÁT ', N'KHỐI', 20, 400000, 200000 ,  N'NCC0001')
INSERT into SANPHAM VALUES (N'SP003', N'VL002', N'HỆ THỐNG CỬA', N'CÁI', 40 , 6000000 , 5000000 , N'NCC0001')
INSERT into SANPHAM  VALUES (N'SP004', N'VL001', N'GẠCH THẺ ', N'THÙNG', 80, 600000, 370000, N'NCC0002')
INSERT into SANPHAM  VALUES (N'SP005', N'VL001', N'GẠCH MEN', N'THÙNG', 90, 7000000, 5800000, N'NCC0002')
INSERT into SANPHAM VALUES (N'SP006', N'VL002', N'NƯỚC SƠN', N'THÙNG', 70, 6000000, 3500000, N'NCC0002')
INSERT into SANPHAM VALUES (N'SP007', N'VL001', N'SĂT', N'KG', 120, 30000000, 27000000, N'NCC0002')
INSERT into SANPHAM VALUES (N'SP008', N'VL001', N'ĐÁ ', N'KHỐI', 160, 180000, 100000, N'NCC0001')
INSERT into SANPHAM VALUES (N'SP009', N'VL001', N'NGÓI ', N'THÙNG', 80, 110000, 100000, N'NCC0002')
INSERT into SANPHAM VALUES (N'SP010', N'VL002', N'BỒN CẦU', N'CÁI', 200, 20500000, 20000000,N'NCC0001')
INSERT into SANPHAM VALUES (N'SP012', N'VL002', N'VÒI SỊT', N'Cái', 20, 6000000, 5500000, N'NCC0002')



CREATE TABLE KHACHHANG(
	MaKH nvarchar(50) NOT NULL,
	TenKH nvarchar(50) NULL,
	DiaChiKH nvarchar(50) NULL,
	SDTKH varchar(12) NULL,
	primary key(MaKH)
)
select * from KHACHHANG


CREATE TABLE NHOMSANPHAM(
	MaNhom nvarchar(50) NOT NULL,
	TenNhom nvarchar(50) NULL,
	primary key(MaNhom)
)

INSERT into NHOMSANPHAM  VALUES (N'VL001', N'Vật liệu xây dựng thô')
INSERT into NHOMSANPHAM  VALUES (N'VL002', N'Vật liệu xây dựng hoàn thiện')

select * from NHOMSANPHAM



CREATE TABLE NHACUNGCAP(
	MaNCC nvarchar(50) NOT NULL,
	TenNCC nvarchar(50) NULL,
	SDTNCC varchar(13) NULL,
	DiaChiNCC nvarchar(50) NULL,
	primary key(MaNCC)
)
 select * from NHACUNGCAP
INSERT NHACUNGCAP VALUES (N'NCC0001', N'CƠ SỞ SẢN XUẤT CÔNG NGHIỆP HÀ TIÊN', N'0756373658', N'HÀ TIÊN')
INSERT NHACUNGCAP VALUES (N'NCC0002', N'NHÀ MÁY CÔNG NGHIỆP HẢI PHÒNG', N'0744849176', N'TP.HẢI PHÒNG')
INSERT NHACUNGCAP VALUES (N'NCC0003', N'NHÀ MÁY CUNG CẤP NGUYÊN LIỆU XÂY DỰNG MỸ', N'0733123764', N'HÀ NỘI')



CREATE TABLE HOADONBAN(
	MaHD nvarchar(50) NOT NULL,
	MaNV nvarchar(50) NULL,
	MaKH nvarchar(50) NULL,
	NgayBan smalldatetime NULL,
	TongTienBan int NULL,
	primary key(MaHD)
)
select * from HOADONBAN

CREATE TABLE CHITIETHDBAN(
	MaHD nvarchar(50) NOT NULL,
	MaSP nvarchar(50) NOT NULL,
	SLBan int NULL,
	DonGiaBan int NULL,
	ThanhTienBan int NULL,
	primary key(MaHD, MASP)
)
select * from CHITIETHDBAN



create trigger Buy_Product on CHITiethdban for insert
as
update SANPHAM set SanPham.SLTon = SANPHAM.SLTon - inserted.SLBan from inserted
where SANPHAM.MaSP = inserted.MaSP


create trigger Return_Product on CHITiethdban for delete
as
update SANPHAM set SanPham.SLTon = SANPHAM.SLTon + deleted.SLBan from deleted
where SANPHAM.MaSP = deleted.MaSP


create trigger update_Product on Chitiethdban for update
as
begin
	update SANPHAM set SanPham.SLTon = SANPHAM.SLTon - inserted.SLBan from inserted
	where SANPHAM.MaSP = inserted.MaSP 
	update SANPHAM set SanPham.SLTon = SANPHAM.SLTon + deleted.SLBan from deleted
	where SANPHAM.MaSP = deleted.MaSP
end


select TenNV from NHANVIEN where MaNV = N'nv01'

select * from SANPHAM where MaSP = N'SP001'

select * from nhanvien

BACKUP DATABASE Quanlyvatlieuxaydung
TO DISK = 'D:\Quanlyvatlieuxaydung.bak'
select * from NHANVIEN

restore DATABASE Quanlyvatlieuxaydung
from DISK = 'D:\database1.bak' with NoRecovery

restore database Quanlyvatlieuxaydung from disk = 'D:\Quanlyvatlieuxaydung.bak' With NoRecovery

select * from SANPHAM

update SANPHAM set MaNhom = N'VL001' , TenSP = N'CÁT', DonViTinh = 20,SLTon=20, GiaBan = 400000, GiaNhap = 200000, MaNCC='NCC0001' where MaSP='SP002'
select * from SANPHAM