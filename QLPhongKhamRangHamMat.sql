CREATE TABLE PHONG_KHAM (
  MaPhongKham varchar(10) primary key,
  TenPhongKham varchar(50),
  Diachi varchar(50),
  Sodienthoai varchar(10)
) CREATE TABLE CHUYEN_KHOA (
  MaChuyenKhoa varchar(10) primary key,
  TenChuyenKhoa varchar(50),
) CREATE TABLE BAC_SI (
  MaBS varchar(10) primary key,
  MaPhongKham varchar(10),
  MaChuyenKhoa varchar(10),
  FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
  FOREIGN KEY (MaChuyenKhoa) REFERENCES CHUYEN_KHOA (MaChuyenKhoa),
  SoDienThoaiBS varchar(10),
  HoTen varchar(50),
  DiaChiBS varchar(60)
) CREATE TABLE Benh_Nhan (
  MaBN varchar(10) primary key,
  MaPhongKham varchar(10),
  FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
  HoTen varchar(50),
  NgaySinh smalldatetime,
  GioiTinh bit,
  SoDienThoaiBN varchar(10) default 'kh�ng c�',
  DiaChiBN varchar(60)
) CREATE TABLE QUAN_lY (
  MaQL varchar(10),
  MaPhongKham varchar(10),
  FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
  HoTen varchar(50),
  SoDienThoaiQuanLi varchar(10),
  DiaChiQuanLi varchar(60),
) CREATE TABLE LE_TAN (
  MaLT varchar(10) primary key,
  MaPhongKham varchar(10),
  FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
  HoTen varchar(50),
  SoDienThoaiLT varchar(10),
  DiaChiLT varchar(60)
) CREATE TABLE LICH_HEN (
  MaLichHen varchar(10) primary key,
  MaBN varchar(10),
  MaBS varchar(10),
  MaPhongKham varchar(10),
  MaChuyenKhoa varchar(10),
  FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
  FOREIGN KEY (MaChuyenKhoa) REFERENCES CHUYEN_KHOA (MaChuyenKhoa),
  FOREIGN KEY (MaBN) REFERENCES BENH_NHAN (MaBN),
  FOREIGN KEY (MaBS) REFERENCES BAC_SI (MaBS)
) CREATE TABLE DON_THUOC (
  MaLichHen varchar(10),
  MaBN varchar(10),
  MaBS varchar(10),
  MaPhongKham varchar(10),
  MaChuyenKhoa varchar(10),
  FOREIGN KEY (MaLichHen) REFERENCES LICH_HEN (MaLichHen),
  FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
  FOREIGN KEY (MaChuyenKhoa) REFERENCES CHUYEN_KHOA (MaChuyenKhoa),
  FOREIGN KEY (MaBN) REFERENCES BENH_NHAN (MaBN),
  FOREIGN KEY (MaBS) REFERENCES BAC_SI (MaBS),
  MaThuoc char(10),
  SoLuong int
) CREATE TABLE THUOC(
  MaThuoc varchar(10),
  TenThuoc varchar(50),
  TonKho int
) CREATE procedure insert_thuoc @ tenThuoc varchar(50),
@ soLuong int as begin
declare @ count int;
if (
  select count(*)
  from THUOC
) = 0 begin
set @ count = 1;
end;
else begin
set @ count = cast(
    trim(
      (
        select top(1) MaThuoc
        from THUOC
        order by MaThuoc desc
      )
    ) as int
  ) + 1;
end;
declare @ maThuoc char(10);
set @ maThuoc = cast(@ count as char(10));
insert into THUOC
values (@ maThuoc, @ tenThuoc, @ soLuong);
end;
-- exec insert_thuoc 'Panadol',12;
-- select * from THUOC;
-- select * from THUOC order by MaThuoc desc
create trigger trg_DonThuoc ON DON_THUOC FOR
insert as begin
update THUOC
SET TonKho = TonKho - (
    select SoLuong
    from inserted
    where inserted.MaThuoc = THUOC.MaThuoc
  )
FROM THUOC
  JOIN inserted ON THUOC.MaThuoc = inserted.MaThuoc;
end;