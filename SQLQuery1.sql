CREATE DATABASE Shop
GO

USE Shop;

CREATE TABLE Product
(
	ProductId int primary key,
	ProductName nvarchar(128) not null,
)

insert into Product(ProductId, ProductName) values (1, 'Apple')
insert into Product(ProductId, ProductName) values (2, 'Banan')
insert into Product(ProductId, ProductName) values (3, 'Strawberry')
insert into Product(ProductId, ProductName) values (4, 'Meat')

CREATE TABLE Category
(
	CategoryId int primary key,
	CategoryName nvarchar(64) not null
)

insert into Category(CategoryId, CategoryName) values(1, 'Fresh')
insert into Category(CategoryId, CategoryName) values(2, 'Expensive')
insert into Category(CategoryId, CategoryName) values(3, 'Popular')

CREATE TABLE ProductsCategories
(
	CategoryId int foreign key references Category(CategoryId),
	ProductId int foreign key references Product(ProductId),
	primary key(CategoryId, ProductId)
)

insert into ProductsCategories(ProductId, CategoryId) values (1, 1)
insert into ProductsCategories(ProductId, CategoryId) values (1, 2)
insert into ProductsCategories(ProductId, CategoryId) values (2, 3)
insert into ProductsCategories(ProductId, CategoryId) values (3, 3)

SELECT P.ProductName, (SELECT CategoryName FROM Category AS C WHERE PC.CategoryId = C.CategoryId)
FROM Product AS P
LEFT JOIN ProductsCategories AS PC ON P.ProductId = PC.ProductId