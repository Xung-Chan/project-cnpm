-- Drop database QuanLyPhongKham;
go
    create database QuanLyPhongKham;

go
    use QuanLyPhongKham;

go
    create table Position(
        positionID char(1),
        positionName nchar(50),
        primary key (positionID)
    );

go
    create table Account(
        phoneNumber char(10),
        userID char(10),
        positionID char(10),
        accountPassword char(20),
        primary key (phoneNumber),
        foreign key(positionID) references Position(positionID)
    );

go
    create table Specialty (
        specialtyID char(10),
        specialtyName nchar(50),
        primary key (specialtyID)
    );

go
    create table Branch(
        branchID char(10),
        branchName nchar(50),
        branchAddress nchar(256),
        branchPhoneNumber char(10),
        primary key (branchID)
    );

go
    create table UserInformation (
        userID char(10),
        userName nchar(50),
        branchID char(10),
        phoneNumber char(10),
        userAddress nchar(100),
        primary key (userID),
        foreign key (branchID) references Branch (branchID),
        foreign key (phoneNumber) references Account (phoneNumber)
    );

go
alter table
    Account
add
    constraint fk_account_userInformation foreign key (userID) references UserInformation (userID);

go
    create table Dentist(
        userID char(10),
        specialtyID char(10),
        userName nchar(50),
        branchID char(10),
        phoneNumber char(10),
        userAddress nchar(100),
        primary key (userID),
        foreign key (specialtyID) references Specialty (specialtyID),
        foreign key (branchID) references Branch (branchID),
        foreign key (phoneNumber) references Account (phoneNumber)
    );

go
    create table Patient() -- go
    --     CREATE TABLE CHUYEN_KHOA (
    --         MaChuyenKhoa char(10) primary key,
    --         TenChuyenKhoa char(50),
    --     );
    -- CREATE TABLE TAI_KHOAN(
    --     Username char(10) primary key,
    --     Password char(10),
    --     Role char(10),
    --     MaUser char(10),
    -- );
    -- CREATE TABLE PHONG_KHAM (
    --     MaPhongKham char(10) primary key,
    --     TenPhongKham char(50),
    --     Diachi char(50),
    --     Sodienthoai char(10)
    -- );
    -- CREATE TABLE INFORMATION_USER(
    --     MaUser char(10) primary key,
    --     MaPhongKham char(10),
    --     Sdt char(10),
    --     HoTen char(50),
    --     DiaChi char(60),
    --     Username char(10),
    --     FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
    --     FOREIGN KEY (Username) REFERENCES TAI_KHOAN(Username)
    -- );
    -- ALTER TABLE
    --     TAI_KHOAN
    -- ADD
    --     CONSTRAINT FK_TaiKhoan_InformationUser FOREIGN KEY (MaUser) REFERENCES INFORMATION_USER(MaUser);
    -- CREATE TABLE BAC_SI (
    --     MaBS char(10) primary key,
    --     MaChuyenKhoa char(10),
    --     FOREIGN KEY (MaBS) REFERENCES INFORMATION_USER(MaUser),
    --     FOREIGN KEY (MaChuyenKhoa) REFERENCES CHUYEN_KHOA (MaChuyenKhoa),
    -- );
    -- CREATE TABLE Benh_Nhan (
    --     MaBN char(10) primary key,
    --     MaPhongKham char(10),
    --     HoTen char(50),
    --     NgaySinh smalldatetime,
    --     GioiTinh bit,
    --     SoDienThoaiBN char(10) default 'kh�ng c�',
    --     DiaChiBN char(60),
    --     FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
    -- );
    -- CREATE TABLE LICH_HEN (
    --     MaLichHen char(10) primary key,
    --     MaBN char(10),
    --     MaBS char(10),
    --     ThoiGian datetime,
    --     TrangThai char(10),
    --     FOREIGN KEY (MaBN) REFERENCES BENH_NHAN (MaBN),
    --     FOREIGN KEY (MaBS) REFERENCES BAC_SI (MaBS)
    -- );
    -- CREATE TABLE THUOC(
    --     MaThuoc char(10) primary key,
    --     TenThuoc char(50),
    --     TonKho int,
    --     DonGia float,
    --     NgayNhap date
    -- );
    -- CREATE TABLE DON_THUOC (
    --     MaLichHen char(10),
    --     MaThuoc char(10),
    --     SoLuong int,
    --     FOREIGN KEY (MaLichHen) REFERENCES LICH_HEN(MaLichHen),
    --     FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc),
    --     PRIMARY KEY (MaLichHen, MaThuoc)
    -- );
    -- go
    --     CREATE procedure insert_thuoc @tenThuoc char(50),
    --     @soLuong int as begin declare @count int;
    -- if (
    --     select
    --         count(*)
    --     from
    --         THUOC
    -- ) = 0 begin
    -- set
    --     @count = 1;
    -- end;
    -- else begin
    -- set
    --     @count = cast(
    --         trim(
    --             (
    --                 select
    --                     top(1) MaThuoc
    --                 from
    --                     THUOC
    --                 order by
    --                     MaThuoc desc
    --             )
    --         ) as int
    --     ) + 1;
    -- end;
    -- declare @maThuoc char(10);
    -- set
    --     @maThuoc = cast(@ count as char(10));
    -- insert into
    --     THUOC
    -- values
    --     (@maThuoc, @ tenThuoc, @ soLuong);
    -- end;
    -- go
    --     CREATE procedure insert_lichHen @maBS char(10),
    --     @maBN char(10),
    --     @thoiGian datetime,
    --     @trangThai char(50),
    --     @ketQuaXetNghiem char(256) as begin declare @ count int;
    -- if (
    --     select
    --         count(*)
    --     from
    --         LICH_HEN
    -- ) = 0 begin
    -- set
    --     @ count = 1;
    -- end;
    -- else begin
    -- set
    --     @ count = cast(
    --         trim(
    --             (
    --                 select
    --                     top(1) MaLichHen
    --                 from
    --                     LICH_HEN
    --                 order by
    --                     MaLichHen desc
    --             )
    --         ) as int
    --     ) + 1;
    -- end;
    -- declare @ maLichHen char(10);
    -- set
    --     @ maLichHen = cast(@ count as char(10));
    -- insert into
    --     LICH_HEN
    -- values
    --     (
    --         @maLichHen,
    --         @maBN,
    --         @maBS,
    --         @thoiGian,
    --         @trangThai,
    --         @ketQuaXetNghiem
    --     );
    -- end;
    -- -- exec insert_thuoc 'Panadol',
    -- -- 12;
    -- -- select
    -- --     *
    -- -- from
    -- --     THUOC;
    -- -- select
    -- --     *
    -- -- from
    -- --     THUOC
    -- -- order by
    -- --     MaThuoc desc;
    -- create trigger trg_insertDonThuoc ON DON_THUOC FOR
    -- insert
    --     as begin
    -- update
    --     THUOC
    -- SET
    --     TonKho = TonKho - (
    --         select
    --             SoLuong
    --         from
    --             inserted
    --         where
    --             inserted.MaThuoc = THUOC.MaThuoc
    --     )
    -- FROM
    --     THUOC
    --     JOIN inserted ON THUOC.MaThuoc = inserted.MaThuoc;
    -- end;
    -- CREATE TRIGGER trg_updateDonThuoc on DON_THUOC FOR
    -- update
    --     as begin
    -- update
    --     THUOC
    -- SET
    --     TonKho = TonKho - (
    --         select
    --             SoLuong
    --         from
    --             inserted
    --         where
    --             inserted.MaThuoc = THUOC.MaThuoc
    --     ) + (
    --         select
    --             SoLuong
    --         from
    --             deleted
    --         where
    --             inserted.MaThuoc = THUOC.MaThuoc
    --     )
    -- FROM
    --     THUOC
    --     JOIN inserted ON THUOC.MaThuoc = inserted.MaThuoc;
    -- end;
    -- insert into
    --     TAI_KHOAN
    -- values
    --     ('0396371201', '1', 'BS');
    -- select
    --     @ @SERVERNAME