CREATE DATABASE QL_NhaTro
GO
USE QL_NhaTro
GO

CREATE TABLE KHACHTRO (
    MAKT NVARCHAR(10) NOT NULL,
    HOTEN NVARCHAR(50),
    DIACHI NVARCHAR(100),
    SODT NVARCHAR(20),
    CMND NVARCHAR(12),
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

CREATE TABLE NHATRO (
    MANT NVARCHAR(10) NOT NULL,
    TENNT NVARCHAR(50),
    DIACHINT NVARCHAR(100),
    SODT NVARCHAR(20),
    CHUNHATRO NVARCHAR(50), -- Tên chủ nhà trọ
    CONSTRAINT PK_NHATRO PRIMARY KEY (MANT)
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
    MAHD NVARCHAR(10) NOT NULL,                 -- Mã hợp đồng (khóa chính)
    MAKT NVARCHAR(10) NOT NULL,                 -- Mã khách trọ (khóa ngoại từ bảng KHACHTRO)
    MAPT NVARCHAR(10) NOT NULL,                 -- Mã phòng trọ (khóa ngoại từ bảng PHONGTRO)
    MANV NVARCHAR(10) NOT NULL,                 -- Mã nhân viên (khóa ngoại từ bảng NHANVIEN)
    NGAYLAP DATE,                               -- Ngày lập hợp đồng
    NGAYHETHAN DATE,                            -- Ngày hết hạn hợp đồng
    TIENCOC MONEY,                              -- Tiền cọc
    CONSTRAINT PK_HOPDONG PRIMARY KEY (MAHD),   -- Thiết lập khóa chính cho MAHD
    CONSTRAINT FK_HOPDONG_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT),   -- Khóa ngoại tới bảng KHACHTRO
    CONSTRAINT FK_HOPDONG_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),   -- Khóa ngoại tới bảng PHONGTRO
    CONSTRAINT FK_HOPDONG_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)    -- Khóa ngoại tới bảng NHANVIEN
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
    ID INT NOT NULL,
    MAKT NVARCHAR(10) NOT NULL,
    MADV NVARCHAR(10) NOT NULL,
    SOLUONG INT,
    TONGTIEN MONEY,
    CONSTRAINT PK_SUDUNGDV PRIMARY KEY (ID),
    CONSTRAINT FK_SUDUNGDV_KHACHTRO FOREIGN KEY (MAKT) REFERENCES KHACHTRO(MAKT),
    CONSTRAINT FK_SUDUNGDV_DICHVU FOREIGN KEY (MADV) REFERENCES DICHVU(MADV)
);

CREATE TABLE CHISODIEN (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MAPT NVARCHAR(10) NOT NULL,  -- Liên kết với PHONGTRO
    MANV NVARCHAR(10) NOT NULL,  -- Liên kết với NHANVIEN
    THANG DATE NOT NULL,
    CHISOCU INT NOT NULL,
    CHISOMOI INT NOT NULL,
    CONSTRAINT FK_CHISODIEN_PHONG FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
    CONSTRAINT FK_CHISODIEN_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)  -- Liên kết với NHANVIEN
);



CREATE TABLE CHISONUOC (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MAPT NVARCHAR(10) NOT NULL,  -- Liên kết với PHONGTRO
    MANV NVARCHAR(10) NOT NULL,  -- Liên kết với NHANVIEN
    THANG DATE NOT NULL,
    CHISOCU INT NOT NULL,
    CHISOMOI INT NOT NULL,
    CONSTRAINT FK_CHISONUOC_PHONG FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
    CONSTRAINT FK_CHISONUOC_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)  -- Liên kết với NHANVIEN
);


CREATE TABLE PHATSINH (
    ID INT IDENTITY(1,1) PRIMARY KEY,          -- Mã định danh duy nhất cho bản ghi
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
    MANT NVARCHAR(10) NOT NULL,
    MAPT NVARCHAR(10) NOT NULL,
    MANV NVARCHAR(10) NOT NULL,  -- Liên kết với NHANVIEN
    DONGIA MONEY NOT NULL,
    SOLUONG INT NOT NULL,
    NGAYMUA DATE,
    NGAYSUDUNG DATE,
    DATHANHLY BIT DEFAULT 0,
    NGAYTHANHLY DATE,
    GHICHU NVARCHAR(255),
    CONSTRAINT PK_TAISAN PRIMARY KEY (MATS),
    CONSTRAINT FK_TAISAN_NHATRO FOREIGN KEY (MANT) REFERENCES NHATRO(MANT),
    CONSTRAINT FK_TAISAN_PHONGTRO FOREIGN KEY (MAPT) REFERENCES PHONGTRO(MAPT),
    CONSTRAINT FK_TAISAN_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)  -- Liên kết với NHANVIEN
);


CREATE TABLE COCGIUPHONG (
    MACG NVARCHAR(10) NOT NULL,                -- Mã cọc giữ phòng (khóa chính)
    MANT NVARCHAR(10) NOT NULL,                -- Mã nhà trọ (khóa ngoại)
    MAPT NVARCHAR(10) NOT NULL,                -- Mã phòng trọ (khóa ngoại)
    MAKT NVARCHAR(10) NOT NULL,                -- Mã khách trọ (khóa ngoại)
    NGAYDAT DATE NOT NULL,                    -- Ngày đặt cọc
    SODT NVARCHAR(20),                        -- Số điện thoại của khách
    TIENCOC MONEY NOT NULL,                   -- Số tiền cọc (VNĐ)
    NGAYDUKIEN_NHANPHONG DATE,                -- Ngày dự kiến nhận phòng
    GHICHU NVARCHAR(255),                     -- Ghi chú
    CONSTRAINT PK_COC_GIUPHONG PRIMARY KEY (MACG),
    CONSTRAINT FK_COC_GIUPHONG_NHATRO FOREIGN KEY (MANT) REFERENCES NHATRO(MANT),
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
    MATK NVARCHAR(10) NOT NULL,      -- Mã tài khoản (khóa chính)
    MANV NVARCHAR(10) NOT NULL,      -- Mã nhân viên (khóa ngoại từ bảng NHANVIEN)
    USERNAME NVARCHAR(50) NOT NULL,  -- Tên đăng nhập
    PASSWORD NVARCHAR(255) NOT NULL, -- Mật khẩu (nên mã hóa trước khi lưu trữ)
    TRANGTHAI BIT DEFAULT 1,         -- Trạng thái (1 = hoạt động, 0 = không hoạt động)
    CONSTRAINT PK_TAIKHOAN PRIMARY KEY (MATK),                -- Khóa chính
    CONSTRAINT FK_TAIKHOAN_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV) -- Khóa ngoại
);
