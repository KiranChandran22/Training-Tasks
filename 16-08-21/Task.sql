create table Customer(
CustomerID int primary key,
Name varchar(30),
City varchar(30),
Email varchar(50),
Phone int
)

create table Product (
	ProductCode int primary key,
	Name varchar(10),
	Price int
)

create table Orders 
(
	OrderId int, 
	CustomerId int,
	OrderDate Date,
	constraint PK_Oid primary key (OrderId),
	constraint FK_Cid Foreign key (CustomerId) references Customer(CustomerId)
)

create table OderItems(
		Tno int,
		Orderid int,
		ProductCode int,
		Quantity int
		constraint PK_tno primary key (Tno),
		constraint FK_oid Foreign key (Orderid) references Orders(OrderId),
		constraint FK_poid Foreign key (ProductCode) references Product(ProductCode)
)

insert into Customer values(1,'Kiran','Chennai','abc.com',893)
insert into Customer values(2,'Messi','Buenues','def.com',956)
insert into Customer values(3,'Ronaldo','Lisbon','ghi.com',116)
insert into Customer values(4,'Xavi','Barcelona','jkl.com',984)
insert into Customer values(5,'Mane','Senegal','mno.com',192)

insert into Product values(123,'Camp nou',9600)
insert into Product values(456,'allienz',7668)
insert into Product values(789,'Santiago',4624)
insert into Product values(1011,'Turin',9889)

insert into Orders values (1001,1,GETDATE());
insert into Orders values (1002,2,GETDATE());
insert into Orders values (1003,4,GETDATE());
insert into Orders values (1004,1,GETDATE());

insert into OderItems values(10,1004,1011,3)
insert into OderItems values(33,1004,123,11)
insert into OderItems values(44,1001,1011,18)

select * from Customer
select * from Product
select * from Orders
select * from OderItems

update Orders
set CustomerId=1
where OrderId=1003

select OrderID, CustomerId, cast (GetDate() as Date) as OrderDate 
from Orders

select cus.Name,cus.City,ord.OrderDate,cus.CustomerId from Orders ord
join Customers cus
on ord.CustomerId=cus.CustomerId

create view viers as
select oi.ProductCode,oi.Quantity,cust.Name from OderItems oi
join Orders os
on oi.Orderid=os.OrderId
join Customers cust
on cust.CustomerId=os.CustomerId

select * from viers

create view viewrs as
select oi.TNo, oi.OrderID, oi.Productcode, oi.Quantity, cus.CustomerId, pro.Price, od.OrderDate
from OderItems oi
join Orders od
on oi.OrderID = od.OrderId
join Customers cus
on cus.CustomerId =od.CustomerId
join Product pro
on pro.ProductCode = oi.Productcode

se