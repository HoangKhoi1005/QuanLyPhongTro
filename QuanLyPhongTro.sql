CREATE DATABASE QL_NhaTro
GO
USE QL_NhaTro
GO

CREATE TABLE KHACHTRO (
    MAKT NVARCHAR(10) NOT NULL,
    HOTEN NVARCHAR(50),
    DIACHI NVARCHAR(100),
    SODT NVARCHAR(20),
    CCCD NVARCHAR(12),
    NGAYSINH DATE,
    GIOITINH NVARCHAR(10),
    NGAYVAO DATE,
	SOXE NVARCHAR(20),
	ANH NVARCHAR(MAX),
	GHICHU NVARCHAR(255),  
    CONSTRAINT PK_KHACHTRO PRIMARY KEY (MAKT)
);

CREATE TABLE PHANQUYEN (
    MAQUYEN NVARCHAR(10) NOT NULL,   -- Mã quyền (khóa chính)
    TENQUYEN NVARCHAR(50) NOT NULL,  -- Tên quyền (ví dụ: Admin, User)
    GHICHU NVARCHAR(255),            -- Ghi chú
    CONSTRAINT PK_PHANQUYEN PRIMARY KEY (MAQUYEN)
);

CREATE TABLE NHANVIEN (
    MANV NVARCHAR(10) NOT NULL,                  -- Mã nhân viên (khóa chính)
    HOTENNV NVARCHAR(50),                        -- Họ tên nhân viên
    DIACHINV NVARCHAR(100),                      -- Địa chỉ nhân viên
    SODT NVARCHAR(20),                           -- Số điện thoại
    EMAILNV NVARCHAR(30),                        -- Email nhân viên
    NGAYSINH DATE,                               -- Ngày sinh của nhân viên
    NGAYVAO DATE,                                -- Ngày vào làm việc
    CHUCVU NVARCHAR(30),                         -- Chức vụ
    MAQUYEN NVARCHAR(10) NOT NULL,               -- Mã quyền (khóa ngoại từ bảng PHANQUYEN)
    CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV),   -- Thiết lập khóa chính cho MANV
    CONSTRAINT FK_NHANVIEN_PHANQUYEN FOREIGN KEY (MAQUYEN) REFERENCES PHANQUYEN(MAQUYEN) -- Khóa ngoại tới bảng PHANQUYEN
);

CREATE TABLE CHUNHATRO (
    MACHU NVARCHAR(10) NOT NULL,          -- Mã chủ nhà trọ
    TENCHU NVARCHAR(50),                  -- Tên chủ nhà trọ
    DIACHICHU NVARCHAR(100),              -- Địa chỉ chủ nhà trọ
    SODT NVARCHAR(20),                    -- Số điện thoại
    EMAIL NVARCHAR(50),                   -- Email liên hệ
    CONSTRAINT PK_CHUNHATRO PRIMARY KEY (MACHU) -- Khóa chính
);

CREATE TABLE NHATRO (
    MANT NVARCHAR(10) NOT NULL,           -- Mã nhà trọ
    TENNT NVARCHAR(50),                   -- Tên nhà trọ
    DIACHINT NVARCHAR(100),               -- Địa chỉ nhà trọ
    SODT NVARCHAR(20),                    -- Số điện thoại nhà trọ
    MACHU NVARCHAR(10),                   -- Mã chủ nhà trọ (Khóa ngoại)
    CONSTRAINT PK_NHATRO PRIMARY KEY (MANT),
    CONSTRAINT FK_NHATRO_CHUNHATRO FOREIGN KEY (MACHU) REFERENCES CHUNHATRO(MACHU) -- Khóa ngoại
);


CREATE TABLE PHONGTRO (
    MAPT NVARCHAR(10) NOT NULL,                -- Mã phòng trọ (khóa chính)
    MANT NVARCHAR(10) NOT NULL,                -- Mã nhà trọ (khóa ngoại)
    TENPHONG NVARCHAR(30),                     -- Tên phòng trọ
    DONGIA MONEY,                             -- Đơn giá cho thuê (VNĐ)
    CHIEUDAI FLOAT,                            -- Chiều dài phòng (m)
    CHIEURONG FLOAT,                           -- Chiều rộng phòng (m)
    SOLUONGNGUOITD INT,                     -- Số lượng người tối đa
    GIOITINH_NAM BIT,                          -- Cho thuê Nam (0 = không, 1 = có)
    GIOITINH_NU BIT,                           -- Cho thuê Nữ (0 = không, 1 = có)
    MOTA NVARCHAR(255),                        -- Mô tả thêm
    ANH NVARCHAR(MAX),                     -- Hình ảnh (lưu trữ đường dẫn hoặc dữ liệu nhị phân)
    THUTU INT DEFAULT 0,                     -- Thứ tự sắp xếp
    TRANGTHAI NVARCHAR(20) DEFAULT 'Trống',    -- Trạng thái phòng (Có người, Trống, v.v.)
    CONSTRAINT PK_PHONGTRO PRIMARY KEY (MAPT),
    CONSTRAINT FK_PHONGTRO_NHATRO FOREIGN KEY (MANT) REFERENCES NHATRO(MANT)
);

CREATE TABLE HOPDONG (
    MAHDON NVARCHAR(10) NOT NULL,                 -- Mã hợp đồng (khóa chính)
    MAPT NVARCHAR(10) NOT NULL,                 -- Mã phòng trọ (khóa ngoại từ bảng PHONGTRO)
    NGAYLAP DATE,                               -- Ngày lập hợp đồng
    NGAYHETHAN DATE,                            -- Ngày hết hạn hợp đồng
    TIENCOC MONEY,                              -- Tiền cọc
    CONSTRAINT PK_HOPDONG PRIMARY KEY (MAHDON),   -- Thiết lập khóa chính cho MAHD
    CONSTRAINT FK_HOPDONG_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),   -- Khóa ngoại tới bảng PHONGTRO
);

CREATE TABLE KHACHTRO_HOPDONG (
    MAHDON NVARCHAR(10) NOT NULL,   -- Mã hợp đồng (khóa ngoại từ bảng HOPDONG)
    MAKT NVARCHAR(10) NOT NULL,     -- Mã khách trọ (khóa ngoại từ bảng KHACHTRO)
    NGUOIDAIDIEN BIT DEFAULT 0, -- 1 nếu khách trọ là người đại diện đứng tên, 0 nếu không
    CONSTRAINT FK_KHACHTRO_HOPDONG_HOPDONG FOREIGN KEY (MAHDON) REFERENCES HOPDONG(MAHDON),
    CONSTRAINT FK_KHACHTRO_HOPDONG_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT),
    CONSTRAINT PK_KHACHTRO_HOPDONG PRIMARY KEY (MAHDON, MAKT)
);

CREATE TABLE DICHVU (
    MADV NVARCHAR(10) NOT NULL,
    TENDV NVARCHAR(50),
    GIATIEN MONEY,
	MOTA NVARCHAR(255),
    CONSTRAINT PK_DICHVU PRIMARY KEY (MADV)
);

-- Bảng Sử Dụng Dịch Vụ
CREATE TABLE SUDUNGDV (
    MASUDUNGDV INT IDENTITY(1,1) NOT NULL,
    MAKT NVARCHAR(10) NOT NULL,
    MADV NVARCHAR(10) NOT NULL,
    SOLUONG INT,
    TONGTIEN MONEY,
    CONSTRAINT PK_SUDUNGDV PRIMARY KEY (MASUDUNGDV),
    CONSTRAINT FK_SUDUNGDV_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT),
    CONSTRAINT FK_SUDUNGDV_DICHVU FOREIGN KEY (MADV) REFERENCES DICHVU(MADV)
);

CREATE TABLE CHISODIEN (
    MCSD INT IDENTITY(1,1) PRIMARY KEY,
    MAPT NVARCHAR(10) NOT NULL,  -- Liên kết với PHONGTRO
    THANG DATE NOT NULL,
    CHISOCU INT NOT NULL,
    CHISOMOI INT NOT NULL,
    CONSTRAINT FK_CHISODIEN_PHONG FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
);



CREATE TABLE CHISONUOC (
    MACSN INT IDENTITY(1,1) PRIMARY KEY,
    MAPT NVARCHAR(10) NOT NULL,  -- Liên kết với PHONGTRO
    THANG DATE NOT NULL,
    CHISOCU INT NOT NULL,
    CHISOMOI INT NOT NULL,
    CONSTRAINT FK_CHISONUOC_PHONG FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
);


CREATE TABLE PHATSINH (
    MAPHATSINH INT IDENTITY(1,1) PRIMARY KEY,          -- Mã định danh duy nhất cho bản ghi
    MAPT NVARCHAR(10) NOT NULL,                -- Mã phòng trọ (khóa ngoại)
    THANG DATE NOT NULL,                       -- Tháng phát sinh
    SOTIEN MONEY,                            -- Số tiền phát sinh (VNĐ)
    NOIDUNG NVARCHAR(255),                    -- Nội dung phát sinh
    CONSTRAINT FK_PHATSINH_PHONG FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT)
);

CREATE TABLE HOADON (
    MAHD NVARCHAR(10) NOT NULL,
    MAPT NVARCHAR(10) NOT NULL,
    MANV NVARCHAR(10) NOT NULL,  -- Liên kết với NHANVIEN
    NGAYLAP DATE,
    TIENPHONG MONEY,
    TIENDIEN MONEY,
    TIENUOC MONEY,
	TIENDICHVU MONEY,
	TONGPHATSINH MONEY,
    TONGTIEN MONEY,
    TRANGTHAI NVARCHAR(20),
    CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
    CONSTRAINT FK_HOADON_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
    CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)  -- Liên kết với NHANVIEN
);

-- Bảng Kỷ Luật
CREATE TABLE KYLUAT (
    MAKL NVARCHAR(10) NOT NULL,
    MAKT NVARCHAR(10) NOT NULL,
    NOIDUNG NVARCHAR(255),
    HINHPHAT NVARCHAR(100),
    NGAYKL DATE,
    CONSTRAINT PK_KYLUAT PRIMARY KEY (MAKL),
    CONSTRAINT FK_KYLUAT_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT)
);


-- Bảng Tạm Trú Tạm Vắng
CREATE TABLE TAMTRUTAMVANG (
    MATV NVARCHAR(10) NOT NULL,
    MAKT NVARCHAR(10) NOT NULL,
    LOAITTV NVARCHAR(20), -- 'Tạm trú' hoặc 'Tạm vắng'
    NGAYBATDAU DATE,
    NGAYKETTHUC DATE,
    NOIDUNG NVARCHAR(255),
    CONSTRAINT PK_TAMTRUTAMVANG PRIMARY KEY (MATV),
    CONSTRAINT FK_TAMTRUTAMVANG_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT)
);

CREATE TABLE THANHTOAN (
    ID INT IDENTITY(1,1) PRIMARY KEY,   -- Mã định danh duy nhất cho bản ghi
    MAPT NVARCHAR(10) NOT NULL,         -- Mã phòng trọ (khóa ngoại)
    MANV NVARCHAR(10) NOT NULL,         -- Mã nhân viên (khóa ngoại)
    THANG DATE NOT NULL,                -- Tháng thanh toán
    MAKT NVARCHAR(10) NOT NULL,         -- Mã khách trọ (khóa ngoại)
    SOTIEN MONEY,                       -- Số tiền thanh toán
    DATRA MONEY DEFAULT 0,              -- Số tiền đã trả
    CONGNO MONEY DEFAULT 0,             -- Công nợ
    NGAYTHANHTOAN DATE,                 -- Ngày thanh toán
    CONSTRAINT FK_THANHTOAN_PHONG FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
    CONSTRAINT FK_THANHTOAN_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT),
    CONSTRAINT FK_THANHTOAN_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV) -- Khóa ngoại tới bảng NHANVIEN
);



CREATE TABLE TAISAN (
    MATS NVARCHAR(10) NOT NULL,
    TENTAISAN NVARCHAR(100) NOT NULL,
    MAPT NVARCHAR(10) NOT NULL,
    DONGIA MONEY NOT NULL,
    SOLUONG INT NOT NULL,
    NGAYMUA DATE,
    NGAYSUDUNG DATE,
    DATHANHLY BIT DEFAULT 0,
    NGAYTHANHLY DATE,
    GHICHU NVARCHAR(255),
    CONSTRAINT PK_TAISAN PRIMARY KEY (MATS),
    CONSTRAINT FK_TAISAN_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
);


CREATE TABLE COCGIUPHONG (
    MACGP NVARCHAR(10) NOT NULL,                -- Mã cọc giữ phòng (khóa chính)
    MAPT NVARCHAR(10) NOT NULL,                -- Mã phòng trọ (khóa ngoại)
    MAKT NVARCHAR(10) NOT NULL,                -- Mã khách trọ (khóa ngoại)
    NGAYDAT DATE NOT NULL,                    -- Ngày đặt cọc
    SODT NVARCHAR(20),                        -- Số điện thoại của khách
    TIENCOC MONEY NOT NULL,                   -- Số tiền cọc (VNĐ)
    NGAYDUKIEN_NHANPHONG DATE,                -- Ngày dự kiến nhận phòng
    GHICHU NVARCHAR(255),                     -- Ghi chú
    CONSTRAINT PK_COC_GIUPHONG PRIMARY KEY (MACGP),
    CONSTRAINT FK_COC_GIUPHONG_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
    CONSTRAINT FK_COC_GIUPHONG_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT)
);

CREATE TABLE MANHINH (
    MAMH NVARCHAR(10) NOT NULL,     -- Mã màn hình (khóa chính)
    TENMH NVARCHAR(50) NOT NULL,    -- Tên màn hình
    GHICHU NVARCHAR(255),           -- Ghi chú
    CONSTRAINT PK_MANHINH PRIMARY KEY (MAMH)
);

CREATE TABLE PHANQUYEN_MANHINH (
    MAQUYEN NVARCHAR(10) NOT NULL,  -- Mã quyền (khóa ngoại từ bảng PhanQuyen)
    MAMH NVARCHAR(10) NOT NULL,     -- Mã màn hình (khóa ngoại từ bảng ManHinh)
    COQUYEN BIT DEFAULT 0,          -- Quyền truy cập (1 = có quyền, 0 = không có quyền)
    CONSTRAINT PK_PHANQUYEN_MANHINH PRIMARY KEY (MAQUYEN, MAMH),
    CONSTRAINT FK_PHANQUYENMH_PHANQUYEN FOREIGN KEY (MAQUYEN) REFERENCES PhanQuyen(MAQUYEN),
    CONSTRAINT FK_PHANQUYENMH_MANHINH FOREIGN KEY (MAMH) REFERENCES ManHinh(MAMH)
);

CREATE TABLE TAIKHOAN (
    MATK NVARCHAR(10) NOT NULL,					-- Mã tài khoản (khóa chính)
    MANV NVARCHAR(10) NOT NULL,					-- Mã nhân viên (khóa ngoại từ bảng NHANVIEN)
    TENDANGNHAP NVARCHAR(50) NOT NULL,			-- Tên đăng nhập
    MATKHAU NVARCHAR(512) NOT NULL,				-- Mật khẩu (nên mã hóa trước khi lưu trữ)
    TRANGTHAI BIT DEFAULT 1,					-- Trạng thái (1 = hoạt động, 0 = không hoạt động)
    CONSTRAINT PK_TAIKHOAN PRIMARY KEY (MATK),  -- Khóa chính
    CONSTRAINT FK_TAIKHOAN_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV) -- Khóa ngoại
);

CREATE TABLE NGUOIQUEN (
    MANQ INT IDENTITY(1,1) PRIMARY KEY, 
    MAKT NVARCHAR(10) NOT NULL,         -- Liên kết với khách thuê
    HOTEN NVARCHAR(50),                 -- Họ tên người quen
	CCCD NVARCHAR(12),					-- Số căn cước công dân
    NGAYO DATE,                         -- Ngày đến ở
	NGAYDI DATE,                        -- Ngày đi
    SODT NVARCHAR(20),                  -- Số điện thoại người quen
    PHITHU MONEY DEFAULT 20000,                       -- Phí thu (mặc định là 20k)
    CONSTRAINT FK_NGUOIQUEN_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT)
);

CREATE TABLE BAOTRAPHONG (
    MABAOTP INT IDENTITY(1,1) PRIMARY KEY, 
    MAKT NVARCHAR(10) NOT NULL,         -- Mã khách trọ
    MAPT NVARCHAR(10) NOT NULL,         -- Mã phòng trọ
    NGAYBAO DATE,                       -- Ngày khách báo trả phòng
    NGAYTRAPHONG DATE,                  -- Ngày khách trả phòng chính thức
	NOIDUNG NVARCHAR(255),
    CONSTRAINT FK_BAOTRAPHONG_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT),
    CONSTRAINT FK_BAOTRAPHONG_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT)
);

CREATE TABLE THONGBAO (
    MATHONGBAO INT IDENTITY(1,1) PRIMARY KEY,
    MAKT NVARCHAR(10) NOT NULL,         -- Mã khách trọ
    NOIDUNG NVARCHAR(512),              -- Nội dung thông báo
    LOAITHONGBAO NVARCHAR(50),          -- Loại thông báo (Kỷ luật, Tạm trú, Trả phòng, v.v.)
    NGAYTB DATE,                        -- Ngày thông báo
    CONSTRAINT FK_THONGBAO_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT)
);


INSERT INTO NHATRO (MANT, TENNT, DIACHINT, SODT, CHUNHATRO) VALUES
('NT001', 'Nha Tro A', '123 Le Lai, HCMC', '0123456789', 'Nguyen Van A'),
('NT002', 'Nha Tro B', '456 Nguyen Hue, HCMC', '0987654321', 'Tran Thi B'),
('NT003', 'Nha Tro C', '789 Le Duan, HCMC', '0123456789', 'Le Van C'),
('NT004', 'Nha Tro D', '321 Vo Van Tan, HCMC', '0987654321', 'Pham Thi D'),
('NT005', 'Nha Tro E', '654 Nguyen Trai, HCMC', '0123456789', 'Vu Thi E'),
('NT006', 'Nha Tro F', '987 Le Hong Phong, HCMC', '0987654321', 'Nguyen Thi F'),
('NT007', 'Nha Tro G', '123 Nguyen Van Cu, HCMC', '0123456789', 'Nguyen Van G'),
('NT008', 'Nha Tro H', '456 Dong Khoi, HCMC', '0987654321', 'Le Thi H'),
('NT009', 'Nha Tro I', '789 Cong Hoa, HCMC', '0123456789', 'Pham Van I'),
('NT010', 'Nha Tro J', '321 Tan Phu, HCMC', '0987654321', 'Vu Thi J');


INSERT INTO PHONGTRO (MAPT, MANT, TENPHONG, DONGIA, CHIEUDAI, CHIEURONG, SOLUONGNGUOITD, GIOITINH_NAM, GIOITINH_NU, MOTA, ANH, THUTU, TRANGTHAI) VALUES
('PT001', 'NT001', 'Phong A1', 1500000, 5.0, 4.0, 2, 1, 1, 'Phong rộng rãi', NULL, 1, 'Trống'),
('PT002', 'NT001', 'Phong A2', 1200000, 4.5, 3.5, 2, 1, 1, 'Phong thoáng mát', NULL, 2, 'Có người'),
('PT003', 'NT002', 'Phong B1', 1000000, 4.0, 3.0, 1, 1, 0, 'Phong nhỏ, tiện nghi', NULL, 3, 'Trống'),
('PT004', 'NT002', 'Phong B2', 1100000, 4.5, 3.5, 1, 0, 1, 'Phong rộng, sạch sẽ', NULL, 4, 'Có người'),
('PT005', 'NT003', 'Phong C1', 1300000, 5.0, 4.0, 2, 1, 0, 'Phong đẹp, hiện đại', NULL, 5, 'Trống'),
('PT006', 'NT003', 'Phong C2', 1400000, 5.0, 4.5, 2, 0, 1, 'Phong mới, sạch', NULL, 6, 'Có người'),
('PT007', 'NT004', 'Phong D1', 1500000, 5.5, 4.5, 2, 1, 1, 'Phong có cửa sổ lớn', NULL, 7, 'Trống'),
('PT008', 'NT004', 'Phong D2', 1600000, 6.0, 5.0, 3, 1, 1, 'Phong sang trọng', NULL, 8, 'Có người'),
('PT009', 'NT005', 'Phong E1', 1700000, 6.0, 5.0, 3, 1, 1, 'Phong có ban công', NULL, 9, 'Trống'),
('PT010', 'NT005', 'Phong E2', 1800000, 6.5, 5.5, 3, 0, 1, 'Phong cao cấp', NULL, 10, 'Có người');


INSERT INTO KHACHTRO (MAKT, HOTEN, DIACHI, SODT, CMND, NGAYSINH, GIOITINH, NGAYVAO, SOXE, ANH, GHICHU) VALUES
('K001', 'Nguyen Van A', '123 Le Lai, HCMC', '0123456789', '123456789', '1985-01-01', 'Nam', '2022-05-01', 'Xe001', NULL, 'Khách cũ'),
('K002', 'Tran Thi B', '456 Nguyen Hue, HCMC', '0987654321', '234567890', '1990-02-02', 'Nu', '2023-06-01', 'Xe002', NULL, 'Khách mới'),
('K003', 'Le Van C', '789 Le Duan, HCMC', '0123456789', '345678901', '1988-03-03', 'Nam', '2021-07-01', 'Xe003', NULL, 'Khách cũ'),
('K004', 'Pham Thi D', '321 Vo Van Tan, HCMC', '0987654321', '456789012', '1992-04-04', 'Nu', '2020-08-01', 'Xe004', NULL, 'Khách mới'),
('K005', 'Vu Thi E', '654 Nguyen Trai, HCMC', '0123456789', '567890123', '1987-05-05', 'Nu', '2019-09-01', 'Xe005', NULL, 'Khách cũ'),
('K006', 'Nguyen Thi F', '987 Le Hong Phong, HCMC', '0987654321', '678901234', '1985-06-06', 'Nu', '2022-10-01', 'Xe006', NULL, 'Khách mới'),
('K007', 'Nguyen Van G', '123 Nguyen Van Cu, HCMC', '0123456789', '789012345', '1990-07-07', 'Nam', '2021-11-01', 'Xe007', NULL, 'Khách cũ'),
('K008', 'Le Thi H', '456 Dong Khoi, HCMC', '0987654321', '890123456', '1995-08-08', 'Nu', '2020-12-01', 'Xe008', NULL, 'Khách mới'),
('K009', 'Pham Van I', '789 Cong Hoa, HCMC', '0123456789', '901234567', '1988-09-09', 'Nam', '2019-01-01', 'Xe009', NULL, 'Khách cũ'),
('K010', 'Vu Thi J', '321 Tan Phu, HCMC', '0987654321', '012345678', '1992-10-10', 'Nu', '2022-02-01', 'Xe010', NULL, 'Khách mới');

INSERT INTO PHANQUYEN (MAQUYEN, TENQUYEN, GHICHU) VALUES
('Q001', 'Admin', 'Quản trị viên hệ thống'),
('Q002', 'User', 'Người dùng thông thường'),
('Q003', 'Manager', 'Quản lý'),
('Q004', 'Staff', 'Nhân viên'),
('Q005', 'Receptionist', 'Nhân viên tiếp tân'),
('Q006', 'Cleaner', 'Nhân viên dọn dẹp'),
('Q007', 'Security', 'Nhân viên bảo vệ'),
('Q008', 'Maintenance', 'Nhân viên bảo trì'),
('Q009', 'IT', 'Nhân viên IT'),
('Q010', 'Accountant', 'Kế toán');


INSERT INTO NHANVIEN (MANV, HOTENNV, DIACHINV, SODT, EMAILNV, NGAYSINH, NGAYVAO, CHUCVU, MAQUYEN) VALUES
('NV001', 'Nguyen Van A', '123 Le Lai, HCMC', '0123456789', 'a@example.com', '1985-01-01', '2020-01-01', 'Admin', 'Q001'),
('NV002', 'Tran Thi B', '456 Nguyen Hue, HCMC', '0987654321', 'b@example.com', '1990-02-02', '2021-02-01', 'User', 'Q002'),
('NV003', 'Le Van C', '789 Le Duan, HCMC', '0123456789', 'c@example.com', '1988-03-03', '2019-03-01', 'Manager', 'Q003'),
('NV004', 'Pham Thi D', '321 Vo Van Tan, HCMC', '0987654321', 'd@example.com', '1992-04-04', '2018-04-01', 'Staff', 'Q004'),
('NV005', 'Vu Thi E', '654 Nguyen Trai, HCMC', '0123456789', 'e@example.com', '1987-05-05', '2022-05-01', 'Receptionist', 'Q005'),
('NV006', 'Nguyen Thi F', '987 Le Hong Phong, HCMC', '0987654321', 'f@example.com', '1985-06-06', '2023-06-01', 'Cleaner', 'Q006'),
('NV007', 'Nguyen Van G', '123 Nguyen Van Cu, HCMC', '0123456789', 'g@example.com', '1990-07-07', '2021-07-01', 'Security', 'Q007'),
('NV008', 'Le Thi H', '456 Dong Khoi, HCMC', '0987654321', 'h@example.com', '1995-08-08', '2022-08-01', 'Maintenance', 'Q008'),
('NV009', 'Pham Van I', '789 Cong Hoa, HCMC', '0123456789', 'i@example.com', '1988-09-09', '2020-09-01', 'IT', 'Q009'),
('NV010', 'Vu Thi J', '321 Tan Phu, HCMC', '0987654321', 'j@example.com', '1992-10-10', '2023-10-01', 'Accountant', 'Q010');


INSERT INTO HOPDONG (MAHD, MAKT, MAPT, MANV, NGAYLAP, NGAYHETHAN, TIENCOC) VALUES
('HD001', 'K001', 'PT001', 'NV001', '2024-01-01', '2025-01-01', 500000),
('HD002', 'K002', 'PT002', 'NV002', '2024-02-01', '2025-02-01', 600000),
('HD003', 'K003', 'PT003', 'NV003', '2024-03-01', '2025-03-01', 700000),
('HD004', 'K004', 'PT004', 'NV004', '2024-04-01', '2025-04-01', 800000),
('HD005', 'K005', 'PT005', 'NV005', '2024-05-01', '2025-05-01', 900000),
('HD006', 'K006', 'PT006', 'NV006', '2024-06-01', '2025-06-01', 1000000),
('HD007', 'K007', 'PT007', 'NV007', '2024-07-01', '2025-07-01', 1100000),
('HD008', 'K008', 'PT008', 'NV008', '2024-08-01', '2025-08-01', 1200000),
('HD009', 'K009', 'PT009', 'NV009', '2024-09-01', '2025-09-01', 1300000),
('HD010', 'K010', 'PT010', 'NV010', '2024-10-01', '2025-10-01', 1400000);


SELECT * FROM HOPDONG WHERE MAPT = 'PT001'
SELECT * FROM PHONGTRO WHERE MANT = 'NT001'