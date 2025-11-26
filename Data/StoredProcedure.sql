---stored procedured
--ACCOUNT
create or alter proc USP_GetAllAccount
as 
	select 
		AccountName, DisplayName, AccountPassword,
		Phone, Gender, ImagePath, DateOfBirth, 
		case
			when RoleID = 0 then N'Nhân viên'
			when RoleID = 1 then N'Quản lý'
			else N'Chưa xác định'
		end as AccountRole
	from tAccount
go

create or alter proc USP_GetAccountByAccountName
@AccountName nvarchar(100)
as begin
	select
		AccountName, DisplayName, AccountPassword,
		Phone, Gender, ImagePath, DateOfBirth, 
		case
			when RoleID = 0 then N'Nhân viên'
			when RoleID = 1 then N'Quản lý'
			else N'Chưa xác định'
		end as AccountRole
	from tAccount	
	where AccountName = @AccountName
end
go

create or alter proc USP_SearchByDisplayName
@DisplayName nvarchar(100)
as begin
	select 
		AccountName, DisplayName, AccountPassword,
		Phone, Gender, ImagePath, DateOfBirth, 
		case
			when RoleID = 0 then N'Nhân viên'
			when RoleID = 1 then N'Quản lý'
			else N'Chưa xác định'
		end as AccountRole
	from tAccount	
	where DisplayName COLLATE Vietnamese_CI_AI like N'%' + @DisplayName + N'%'
end
go

create or alter proc USP_SearchByAccountName
@AccountName nvarchar(100)
as begin
	select 
		AccountName, DisplayName, AccountPassword,
		Phone, Gender, ImagePath, DateOfBirth, 
		case
			when RoleID = 0 then N'Nhân viên'
			when RoleID = 1 then N'Quản lý'
			else N'Chưa xác định'
		end as AccountRole
	from tAccount	
	where AccountName COLLATE Vietnamese_CI_AI like N'%' + @AccountName + N'%'
end
go

create or alter proc USP_SearchByPhone
@Phone nvarchar(10)
as begin
	select 
		AccountName, DisplayName, AccountPassword,
		Phone, Gender, ImagePath, DateOfBirth, 
		case
			when RoleID = 0 then N'Nhân viên'
			when RoleID = 1 then N'Quản lý'
			else N'Chưa xác định'
		end as AccountRole
	from tAccount	
	where Phone COLLATE Vietnamese_CI_AI like N'%' + @Phone + N'%'
end
go

create or alter proc USP_InsertAccount
@AccountName nvarchar(100),
@DisplayName nvarchar(100),
@Password nvarchar(20),
@Phone nvarchar(10),
@Gender nvarchar(10),
@DateOfBirth nvarchar(30),
@RoleID int
as begin 
	insert into tAccount (AccountName, DisplayName, AccountPassword, Phone, Gender, DateOfBirth, RoleID) 
	values (@AccountName, @DisplayName, @Password, @Phone, @Gender, @DateOfBirth, @RoleID)
end
go

create or alter proc USP_DeleteAccount
@AccountName nvarchar(100)
as begin 
	delete from tAccount where AccountName = @AccountName
end 
go

create or alter proc USP_UpdateAccount
@AccountName nvarchar(100),
@DisplayName nvarchar(100),
@Password nvarchar(20),
@RoleID int,
@Phone char(10),
@DateOfBirth datetime,
@Gender nvarchar(20),
@ImagePath nvarchar(255)
as begin
	if @ImagePath = '' or @ImagePath is null
		select @ImagePath = ImagePath from tAccount where AccountName = @AccountName
	update tAccount
	set DisplayName = @DisplayName, AccountPassword = @Password, RoleID = @RoleID,
		Phone = @Phone, DateOfBirth = @DateOfBirth, Gender = @Gender, ImagePath = @ImagePath
	where AccountName = @AccountName
end
go

--TABLE
create or alter proc USP_GetAllTable
as begin 
	select * from tTable
end
go

create or alter proc USP_InsertTable
as 
begin 
	declare @tableID int
	select @tableID = max(TableID) + 1
	from tTable

	insert into tTable (TableID, TableName, TableStatus) 
	values (@tableID,'Bàn ' + Cast(@tableID as nvarchar(10)), 0)
end 
go

create or alter proc USP_DeleteTable
@tableID int
as
	delete from tTable where TableID = @tableID
go

create or alter proc USP_GetTableByID
@tableID int
as 
	select * from tTable where TableID = @tableID
go

create or alter proc USP_UpdateTableStatus
@TableID int,
@TableStatus nvarchar(20)
as begin
	update tTable 
	set TableStatus = 
	case 
		when @TableStatus = N'Trống' then 0
		else 1 
	end
	where TableID = @TableID
end
go

--FOOD
create or alter proc USP_GetAllFood
as 
	select * from tFood
go

create or alter proc USP_GetCategoryList
as begin
	select distinct(Category)
	from tFood
end
go

create or alter proc USP_GetFoodByCategory
@category nvarchar(50)
as begin 
	select * from tFood 
	where Category = @category
end 
go

create or alter proc USP_GetFoodIDByName 
@foodName nvarchar(50)
as begin 
	select FoodID from tFood where FoodName = @foodName
end
go


--ORDER
create or alter proc USP_GetAllOrder
as 
	select * from tOrder
go


create or alter proc USP_GetUnCheckedOrderByTableID
@tableID int
as begin
	select OrderID from tOrder
	where TableID = @tableID and OrderStatus = 1
end
go 

create or alter proc USP_InsertOrder
@tableID int, @staff nvarchar(100)
as begin 
	insert into tOrder(TableID, Staff, OrderDate, OrderStatus) values
	(@tableID, @staff, GETDATE(), 1)
end 
go

create or alter proc USP_CheckOut
@orderID int,
@discount int,
@total decimal
as begin 
	update tOrder
	Set Discount = @discount,
		Total = @total,
		OrderStatus = 0 -- đã thanh toán
	where OrderID = @orderID
end
go

--ORDER DETAIL
create or alter proc USP_GetOrderDetailByOrderID
@orderID int
as begin 
	select od.FoodID, f.FoodName, f.Price, od.Quantity
	from tOrderDetail od
	join tFood f on od.FoodID = f.FoodID
	where OrderID = @orderID
end
go

create or alter proc USP_InsertOrderDetail
@orderID int,
@foodID int,
@quantity int
as begin 
	declare @currentQuant int
	select @currentQuant = Quantity
	from tOrderDetail where OrderID = @orderID and FoodID = @foodID
	if @currentQuant + @quantity <= 0
		delete from tOrderDetail
		where OrderID = @orderID and FoodID = @foodID
	else if @currentQuant is null
		insert into tOrderDetail (OrderID, FoodID, Quantity) values
			(@orderID, @foodID, @quantity)
	else
		update tOrderDetail 
			set Quantity = ISNULL(Quantity, 0) + @quantity
			where OrderID = @orderID and FoodID = @foodID
end
go

--CHART
create or alter proc USP_IncomeChartByDate
@beginTime datetime,
@endTime datetime
as begin 
	SELECT
		FORMAT(orderDate, 'yyyy-MM-dd') AS SaleDate, 
		SUM(Total) AS Revenue           
	FROM
		tOrder
	Where
		orderDate between @beginTime and @endTime
	GROUP BY
		FORMAT(orderDate, 'yyyy-MM-dd')
	ORDER BY
		SaleDate;
end
go

create or alter proc USP_FoodSaleRatio
@beginTime datetime,
@endTime datetime
as begin
	SELECT
		  FoodName, Sum(Quantity) as SaleQuantity
	FROM tOrderDetail od
	join tFood f on od.FoodID = f.FoodID
	join tOrder o on o.OrderID = od.OrderID
	Where
		orderDate between @beginTime and @endTime
	GROUP BY
		FoodName
end
go

--CheckIn
create or alter proc USP_GetCheckInTable
@beginTime date,
@endTime date
as begin
	select DisplayName, CheckInDate
	from tCheckIn ci 
	join tAccount a on ci.AccountName = a.AccountName
	where CheckInDate between @beginTime and @endTime
	group by CheckInDate
end
go

create or alter proc USP_CheckIn 
@AccountName nvarchar(100)
as begin
	IF EXISTS (
		SELECT 1 
		FROM tCheckIn
		WHERE AccountName = @AccountName and CheckInDate = GETDATE()
	)
	insert into tCheckIn(AccountName, CheckInDate) values (@AccountName, GETDate());
end
go

select * from tAccount
select * from tOrderDetail

exec USP_GetAccountByAccountName @AccountName = 'admin'
select * from tOrder
select * from tOrderDetail

exec USP_UpdateTableStatus @TableID = 1, @TableStatus = N'Trống'

exec USP_FoodSaleRatio @beginTime = '10/1/2025', @endTime = '11/25/2025'
