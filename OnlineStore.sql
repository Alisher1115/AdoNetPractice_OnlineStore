create table Customer (
	Id int Primary key identity(1,1),
	FullName nvarchar(2550),
	Age int,
	Address nvarchar(2550),
	Phone nvarchar(2550),
)
go
create table Employee (
	Id int Primary Key identity(1,1),
	FullName nvarchar(2550),
	Age int,
	Address nvarchar(2550),
	Phone nvarchar(2550)
)
go
create table Cart (
	Id int Primary Key identity(1,1),
	CustomerId int,
	TotalSum int
)
go
create table OrderStatus (
	Id int Primary Key identity(1,1),
	OrderStatusName nvarchar(2550)
)
go
create table Orders (
	Id int Primary Key identity(1,1),
	CustomerId int,
	EmployeeId int,
	TotalSum int,
	OrderDate DateTime,
	OrderStatusId int
)
go 
create table DeliveryStatus(
	Id int Primary Key identity(1,1),
	deliveryStatusName nvarchar(2550)
)
go 
create table Delivery (
	Id int Primary key identity(1,1),
	OrderId int, 
	DeliveryStatusId int
)
go 
create table Manufacturer (
	Id int Primary key identity(1,1),
	Name nvarchar(2550)
)
go 
create table Category (
	Id int Primary key identity(1,1),
	Name nvarchar(2550)
)
go 
create table Good (
	Id int Primary key identity(1,1),
	Name nvarchar(2550),
	ManufacturerId int,
	CategoryId int,
	Description nvarchar(2550),
	Price int
)
go 
create table CartGood (
	Id int Primary key identity(1,1),
	CartId int,
	GoodId int,
	GoodCount int
)
go 
create table OrderGood (
	Id int Primary key identity(1,1),
	OrderId int,
	GoodId int,
	GoodCount int
)
go 
create table TransactionStatus (
	Id int Primary key identity(1,1),
	transactionStatusName nvarchar(2550)
)
go 
create table Transactions (
	Id int Primary key identity(1,1),
	OrderId int,
	TransactionStatusId int
)