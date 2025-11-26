create database CoffeeABC;

use CoffeeABC;

create table tAccount(
	AccountName nvarchar(100) primary key,
	DisplayName nvarchar(100),
	AccountPassword nvarchar(20),
	Phone char(10) null,
	Gender nvarchar(20) null, 
	ImagePath nvarchar(255) null, 
	DateOfBirth datetime null,
	RoleID int -- 0: nhân viên, 1: quản lý
);

create table tFood(
	FoodID int IDENTITY(1,1) primary key,
	FoodName nvarchar(50),
	Price decimal,
	Category nvarchar(50)
);

create table tTable(
	TableID int primary key,
	TableName nvarchar(20),
	TableStatus int --0: trống, 1: có người
);

create table tOrder(
	OrderID int IDENTITY(1,1) primary key,
	TableID int foreign key references tTable(TableID) on delete cascade,
	Staff nvarchar(100) foreign key references tAccount(AccountName) on delete cascade,
	OrderDate datetime,
	OrderStatus int, -- 0: đã thanh toán, 1: chưa thanh toán
	Discount int default 0,
	Total decimal
);

create table tOrderDetail(
	OrderID int foreign key references tOrder(OrderID)  on delete cascade,
	FoodID int foreign key references tFood(FoodID) on delete cascade,
	Quantity int,
	primary key (OrderID, FoodID)
);

create table tCheckIn(
	AccountName nvarchar(100) foreign key references tAccount(AccountName) on delete cascade,
	CheckInDate date,
	primary key (AccountName, CheckInDate)
);

INSERT INTO tAccount (AccountName, DisplayName, AccountPassword, Phone, Gender, DateOfBirth, RoleID) VALUES 
('datphung', N'Phùng Tuấn Đạt', 'hongngoc2308', '0812394245', N'Nam', '2005-07-30', 0),
('admin', N'Admin', 'admin123', '0123456789', N'Nam', '2000-01-01', 1),
('hngoc', N'Vũ Hồng Ngọc', 'hongngoc2308', '0987654321', N'Nữ', '2005-08-23', 0),
('trang', N'Nguyễn Thu Trang', 'thutrang123', '0123456789', N'Nữ', '2000-01-01', 0),
('tdung', N'Tiên Dung', 'tdung123', '0123456789', N'Nữ', '2000-01-01', 0),
('khoa', N'Khoa', '1', '0123456789', N'Nam', '2000-01-01', 0);

INSERT INTO tFood (FoodName, Category, Price) VALUES
(N'Nước ép cam', N'Nước trái cây', 30000),
(N'Nước ép thơm',  N'Nước trái cây', 32000),
(N'Nước ép cà rốt',  N'Nước trái cây', 28000),
(N'Nước ép táo',  N'Nước trái cây', 34000),
(N'Sinh tố bơ',  N'Nước trái cây', 45000),

(N'Cà phê đen', N'Cà phê', 25000),
(N'Cà phê sữa', N'Cà phê', 28000),
(N'Bạc xỉu', N'Cà phê', 30000),
(N'Cà phê muối', N'Cà phê', 35000),
(N'Latte', N'Cà phê', 40000),

(N'Trà sữa trân châu', N'Trà sữa', 35000),
(N'Trà sữa đường đen', N'Trà sữa', 38000),
(N'Trà sữa matcha', N'Trà sữa', 39000),
(N'Hồng trà sữa', N'Trà sữa', 33000),
(N'Trà sữa socola', N'Trà sữa', 36000),

(N'Khoai tây chiên', N'Đồ ăn vặt', 25000),
(N'Xúc xích chiên', N'Đồ ăn vặt', 20000),
(N'Cá viên chiên', N'Đồ ăn vặt', 22000),
(N'Bánh tráng trộn', N'Đồ ăn vặt', 30000),
(N'Khô gà lá chanh', N'Đồ ăn vặt', 35000),

(N'Cà phê cappuccino', N'Cà phê', 42000),
(N'Sinh tố xoài', N'Nước trái cây', 40000),
(N'Trà sữa phô mai tươi', N'Trà sữa', 42000),
(N'Bánh mì chà bông', N'Đồ ăn vặt', 20000),
(N'Bánh mì chảo', N'Đồ ăn vặt', 25000);

INSERT INTO tTable (TableID, TableName) VALUES
(1, N'Bàn 1'),
(2, N'Bàn 2'),
(3, N'Bàn 3'),
(4, N'Bàn 4'),
(5, N'Bàn 5'),
(6, N'Bàn 6'),
(7, N'Bàn 7'),
(8, N'Bàn 8'),
(9, N'Bàn 9'),
(10, N'Bàn 10'),
(11, N'Bàn 11'),
(12, N'Bàn 12'),
(13, N'Bàn 13'),
(14, N'Bàn 14'),
(15, N'Bàn 15'),
(16, N'Bàn 16'),
(17, N'Bàn 17'),
(18, N'Bàn 18'),
(19, N'Bàn 19'),
(20, N'Bàn 20');
GO

INSERT INTO tOrder (TableID, Staff, OrderDate, OrderStatus, Total) VALUES 
(2, 'admin', '2025-11-10', 1, 100000),
(2, 'admin', '2025-11-12', 1, 120000),
(4, 'admin', '2025-10-02', 1, 923701),
(5, 'admin', '2025-10-05', 1, 123456),
(1, 'admin', '2025-11-01', 1, 85000),
(3, 'admin', '2025-11-02', 1, 95000),
(2, 'datphung', '2025-11-03', 1, 178000),
(4, 'datphung', '2025-11-04', 1, 220000),
(5, 'datphung', '2025-11-06', 1, 300000),
(1, 'hngoc', '2025-11-07', 1, 99000),
(2, 'hngoc', '2025-11-08', 1, 110000),
(3, 'hngoc', '2025-11-10', 1, 150000),
(4, 'admin', '2025-11-11', 1, 205000),
(5, 'admin', '2025-11-13', 1, 178500),
(2, 'admin', '2025-11-14', 1, 240000),
(3, 'datphung', '2025-11-15', 1, 95000),
(4, 'datphung', '2025-11-16', 1, 305000),
(5, 'datphung', '2025-11-17', 1, 500000),
(1, 'hngoc', '2025-11-18', 1, 87500),
(2, 'hngoc', '2025-11-19', 1, 99000),
(3, 'hngoc', '2025-11-20', 1, 120000);
go

INSERT INTO tOrderDetail (OrderID, FoodID, Quantity) VALUES
(15, 8, 4),
(5, 19, 1),
(20, 25, 2),
(7, 12, 5),
(5, 4, 3),
(12, 21, 1),
(18, 7, 2),
(5, 16, 6),
(10, 2, 4),
(16, 18, 1),
(9, 11, 3),
(5, 24, 5),
(19, 6, 2),
(5, 13, 7),
(13, 23, 1),
(6, 10, 4),
(17, 1, 3),
(8, 20, 2),
(11, 17, 5),
(14, 9, 1);
GO

INSERT INTO tCheckIn (AccountName, CheckInDate) VALUES
('admin',     '2025-11-26'),
('datphung',  '2025-10-26'),
('hngoc',     '2025-11-02'),
('admin',     '2025-10-25'),
('admin',     '2025-11-24'),
('admin',     '2025-11-23'),
('datphung',  '2025-11-26'),
('datphung',  '2025-10-25'),
('datphung',  '2025-11-23'),
('hngoc',     '2025-11-26'),
('hngoc',     '2025-11-24'),
('hngoc',     '2025-11-22'),
('tdung',     '2025-11-26'),
('tdung',     '2025-10-25'),
('tdung',     '2025-11-21'),
('khoa',      '2025-11-26'),
('khoa',      '2025-11-22'),
('trang',     '2025-10-25'),
('trang',     '2025-11-24'),
('trang',     '2025-11-23'),
('hngoc',     '2025-11-01'),
('admin',     '2025-11-01'),
('datphung',  '2025-11-01');