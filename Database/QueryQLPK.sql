CREATE TABLE CHUYEN_KHOA (
    MaChuyenKhoa char(10) primary key,
    TenChuyenKhoa char(50),
);

CREATE TABLE TAI_KHOAN(
    Username char(10) primary key,
    Password char(10),
    Role char(10),
    MaUser char(10),
);

CREATE TABLE PHONG_KHAM (
    MaPhongKham char(10) primary key,
    TenPhongKham char(50),
    Diachi char(50),
    Sodienthoai char(10)
);

CREATE TABLE INFORMATION_USER(
    MaUser char(10) primary key,
    MaPhongKham char(10),
    Sdt char(10),
    HoTen char(50),
    DiaChi char(60),
    Username char(10),
    FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
    FOREIGN KEY (Username) REFERENCES TAI_KHOAN(Username)
);

ALTER TABLE
    TAI_KHOAN
ADD
    CONSTRAINT FK_TaiKhoan_InformationUser FOREIGN KEY (MaUser) REFERENCES INFORMATION_USER(MaUser);

CREATE TABLE BAC_SI (
    MaBS char(10) primary key,
    MaChuyenKhoa char(10),
    FOREIGN KEY (MaBS) REFERENCES INFORMATION_USER(MaUser),
    FOREIGN KEY (MaChuyenKhoa) REFERENCES CHUYEN_KHOA (MaChuyenKhoa),
);

CREATE TABLE Benh_Nhan (
    MaBN char(10) primary key,
    MaPhongKham char(10),
    HoTen char(50),
    NgaySinh smalldatetime,
    GioiTinh bit,
    SoDienThoaiBN char(10) default 'kh�ng c�',
    DiaChiBN char(60),
    FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
);

CREATE TABLE LICH_HEN (
    MaLichHen char(10) primary key,
    MaBN char(10),
    MaBS char(10),
    ThoiGian datetime,
    TrangThai char(10),
    FOREIGN KEY (MaBN) REFERENCES BENH_NHAN (MaBN),
    FOREIGN KEY (MaBS) REFERENCES BAC_SI (MaBS)
);

CREATE TABLE THUOC(
    MaThuoc char(10) primary key,
    TenThuoc char(50),
    TonKho int,
    NgayNhap date
);

CREATE TABLE DON_THUOC (
    MaLichHen char(10),
    MaThuoc char(10),
    SoLuong int,
    FOREIGN KEY (MaLichHen) REFERENCES LICH_HEN(MaLichHen),
    FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc),
    PRIMARY KEY (MaLichHen, MaThuoc)
);