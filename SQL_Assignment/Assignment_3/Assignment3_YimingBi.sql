use Northwind

-- Question 1
Create View view_product_order_Bi as
(
Select [Order Details].ProductID, Sum([Order Details].Quantity) [Total Ordered Quantity]
From Orders Join [Order Details]
On Orders.OrderID = [Order Details].OrderID
Group By [Order Details].ProductID
)
-- Test queries
Select * From view_product_order_Bi Order By view_product_order_Bi.ProductID
Drop view view_product_order_Bi

-- Question 2
Create Proc sp_product_order_quantity_Bi
@productID int,
@total_ordered_quantity int Out
As
Begin
	Select @total_ordered_quantity = [Total Ordered Quantity]
	From view_product_order_Bi
	Where view_product_order_Bi.ProductID = @productID
End
-- Test queries
Declare @quantity int
Exec sp_product_order_quantity_Bi 1, @quantity out
Print @quantity

-- Question 3
Create Proc sp_product_order_city_Bi
@product_name varchar(40)
As
Begin
	Select Top 5 Orders.ShipCity, Sum(orderID_and_quantity.Quantity)
From (
	-- This subquery select orderID and ordered quantity according to product name
	Select Products.ProductID, [Order Details].OrderID, [Order Details].Quantity
	From Products Join [Order Details]
	On Products.ProductID = [Order Details].ProductID
	Where ProductName = @product_name
	) orderID_and_quantity
Join Orders
On orderID_and_quantity.OrderID = Orders.OrderID
Group By Orders.ShipCity
Order By Sum(orderID_and_quantity.Quantity) Desc
End

-- Test queries
Exec sp_product_order_city_Bi 'Ikura'
-- Base queries
Select Top 5 Orders.ShipCity, Sum(orderID_and_quantity.Quantity)
From (
	-- This subquery select orderID and ordered quantity according to product name
	Select Products.ProductID, [Order Details].OrderID, [Order Details].Quantity
	From Products Join [Order Details]
	On Products.ProductID = [Order Details].ProductID
	Where ProductName = 'Ikura'
	) orderID_and_quantity
Join Orders
On orderID_and_quantity.OrderID = Orders.OrderID
Group By Orders.ShipCity
Order By Sum(orderID_and_quantity.Quantity) Desc

-- Question 4
Create Table city_Bi(
Id int Primary Key,
City varchar(30)
)

Insert city_Bi values
(1, 'Seattle'), 
(2, 'Green Bay')

Create Table people_Bi(
Id int Primary Key,
FullName varchar(30),
City int
)

Insert people_Bi values
(1, 'Aaron Rodgers', 2), 
(2, 'Russell Wilson', 1), 
(3, 'Jody Nelson', 2)

Insert city_Bi values
(3, 'Madison')

Update people_Bi Set people_Bi.City = 3
From people_Bi Join city_Bi
On people_Bi.City = city_Bi.Id
Where city_Bi.City = 'Seattle'

Delete city_Bi
Where city_Bi.City = 'Seattle'

Create View Packers_YimingBi As(
Select people_Bi.FullName
From people_Bi Join city_Bi
On city_Bi.City = 'Green Bay'
)

-- Test and check
Select * From city_Bi
Select * From people_Bi
Select * From Packers_YimingBi

-- Delete
Drop table people_Bi
Drop table city_Bi
Drop view Packers_YimingBi

-- Question 5
Create Proc sp_birthday_employees_Bi
As
Begin
	Create table birthday_employees_Bi (
	EmpployeeName nvarchar(30),
	BirthDate datetime
	)
	
	Insert birthday_employees_Bi
	Select Employees.FirstName + ' ' + Employees.LastName [empName], Employees.BirthDate
	From Employees
	Where  MONTH(Employees.BirthDate)='2'
End

Exec sp_birthday_employees_Bi

-- Question 6
-- 1. Use statement
-- Select * From TableA Where Not In TableB and 
-- Select * From TableB Where Not In TableA,
-- After running two selects, if both results are NULL, the two tables are the same.
-- 2. Union two tables together, if the result has the same length as both tables, the two tables are the same.