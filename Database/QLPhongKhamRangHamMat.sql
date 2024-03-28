create database QuanLyPhongKham
go
    use QuanLyPhongKham
go
    create table Position(
        ID int identity,
        positionName nchar(50),
        primary key (ID)
    )
go
    create table Specialty (
        ID int identity,
        specialtyName nchar(50),
        primary key (ID)
    )
go
    create table Branch(
        ID int identity,
        branchName nchar(50),
        branchAddress nchar(256),
        phoneNumber char(10),
        primary key (ID)
    )
go
    create table Employee(
        ID int identity,
        positionID int,
        branchID int,
        employeeName nchar(50),
        birthday date,
        sex int check(
            sex = 0
            or sex = 1
        ),
        phoneNumber char(10),
        employeeAddress nchar(256),
        accountPassword char(20),
        primary key (ID),
        foreign key (positionID) references Position(ID),
        foreign key (branchID) references Branch(ID)
    )
go
    create table Detist(
        ID int,
        specialtyID int,
        foreign key (specialtyID) references Specialty(ID),
        foreign key (ID) references Employee(ID),
        primary key (ID)
    )
go
    create table Patient(
        ID int identity,
        branchID int,
        patientName nchar(50),
        birthday date,
        sex int check(
            sex = 0
            or sex = 1
        ),
        phoneNumber char(10),
        patientAddress nchar(256),
        primary key (ID),
        foreign key (branchID) references Branch(ID)
    )
go
    create table Schedule(
        ID int identity,
        patentID int,
        detistID int,
        meetTime datetime,
        status nchar(50),
        exportDate date,
        primary key (ID),
        foreign key (patentID) references Patient(ID),
        foreign key (detistID) references Detist(ID)
    )
go
    create table ServiceLevel1(
        ID int identity,
        level1Name nchar(50),
        primary key (ID)
    )
go
    create table ServiceLevel2(
        ID int identity,
        level1ID int,
        level1Name nchar(50),
        primary key (ID),
        foreign key (level1ID) references ServiceLevel1(ID)
    )
go
    create table Service(
        ID int identity,
        serviceName nchar(50),
        price float,
        primary key(ID)
    )
go
    create table ServiceLevel3(
        ID int,
        level2ID int,
        foreign key (level2ID) references ServiceLevel2(ID),
        foreign key (ID) references Service(ID),
        primary key(ID),
    )
go
    create table Medicine(
        ID int,
        available int,
        foreign key (ID) references Service(ID),
        primary key(ID),
    )
go
    create table BillInfor(
        serviceID int,
        scheduleID int,
        quantity int,
        foreign key (serviceID) references Service(ID),
        foreign key (scheduleID) references Schedule(ID),
        primary key(serviceID, scheduleID)
    )
go