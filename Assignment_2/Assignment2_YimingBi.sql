use AdventureWorks2019

-- Question 1
Select country.name 'Country', province.Name 'Province'
From Person.CountryRegion country Join Person.StateProvince province
On country.CountryRegionCode = province.CountryRegionCode
Order By 'Country' Asc, 'Province' Asc

-- Question 2
Select country.name 'Country', province.Name 'Province'
From Person.CountryRegion country Join Person.StateProvince province
On country.CountryRegionCode = province.CountryRegionCode And country.Name In ('Germany', 'Canada')
Order By 'Country' Asc, 'Province' Asc

use Northwind

-- Question 3
Select Distinct id.ProductID, products.ProductName
From 
	-- This subquery selects all productId from orders happened in last 25 years
	(Select details.ProductID ProductID, orders.OrderDate OrderDate
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID And orders.OrderDate > DATEADD(YEAR, -25, GETDATE())
	) Id 
Join Products products 
On Id.ProductID = products.ProductID
Order By id.ProductID

-- Question 4
Select Top 5 orders.ShipPostalCode PostalCode, Count(orders.ShipPostalCode) [PostalCode Count]
From Orders orders Join [Order Details] details 
On orders.OrderID = details.OrderID And orders.OrderDate > DATEADD(YEAR, -25, GETDATE())
Group By orders.ShipPostalCode
Order By Count(orders.ShipPostalCode) Desc

-- Question 5
Select City, Count(City) MunOfCustomers
From Customers
Group By City

-- Question 6
Select City, Count(City) MunOfCustomers
From Customers
Group By City
Having Count(City) > 2

-- Question 7
Select Customers.CompanyName [Customer Name], customercount.ProductCount
From (
	-- This subquery computes total amount of items ordered by each customerId
	Select orders.CustomerID, Sum(details.Quantity) ProductCount
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	Group By orders.CustomerID
	) customercount
Join Customers
On customercount.CustomerID = Customers.CustomerID
Order By Customers.CompanyName

-- Question 8

Select Customers.CompanyName [Customer Name], customercount.ProductCount
From (
	-- This subquery computes total amount of items ordered by each customerId
	-- And filters the relatively rich group (ordered over 100 items)
	Select orders.CustomerID, Sum(details.Quantity) ProductCount
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	Group By orders.CustomerID
	Having Sum(details.Quantity) > 100
	) customercount
Join Customers
On customercount.CustomerID = Customers.CustomerID
Order By Customers.CompanyName

-- Question 9
Select distinct productIswithSupplierId.SupplierID, productIdwithShipperId.ShipVia ShipperID
From (
	Select details.ProductID ProductID, orders.ShipVia
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	) productIdwithShipperId 
Join (
	Select products.ProductID, suppliers.SupplierID
	From Suppliers suppliers Join Products products
	On suppliers.SupplierID = products.SupplierID
	) productIswithSupplierId
On productIdwithShipperId.ProductID = productIswithSupplierId.ProductID
Order By productIswithSupplierId.SupplierID, ShipperID

-- Question 10
Select productIDwithdate.OrderDate, Products.ProductName
From (
	Select details.ProductID ProductID, orders.OrderDate OrderDate
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	) productIDwithdate
Join Products
On productIDwithdate.ProductID = Products.ProductID

-- Question 11
Select a.FirstName + ' ' + a.LastName [Name], a.Title, b.FirstName + ' ' + b.LastName [Name]
From Employees a Full Join Employees b
On a.Title = b.Title
-- I found this comparing between strings on a website, so COOL
Where a.FirstName + ' ' + a.LastName < b.FirstName + ' ' + b.LastName
Order By a.FirstName + ' ' + a.LastName Asc

-- Question 12
Select emp.FirstName + ' ' + emp.LastName [Manager Name], managerIdwithCount.[Employee Count]
From (
	Select ReportsTo [ManagerID], Count(ReportsTo) [Employee Count]
	From Employees
	Group By ReportsTo
	Having Count(ReportsTo) > 2
	) managerIdwithCount
Join Employees emp On managerIdwithCount.ManagerID = emp.EmployeeID

-- Question 13
-- I should have used subquery to order the results by city, but I am lucky to follow the given order of columns,
-- so Union operator sort the results by city for me
Select City, CompanyName [Name], ContactName [Contant Name], 'Customer' [type]
From Customers
Union
Select City, CompanyName [Name], ContactName [Contant Name], 'Supplier' [type]
From Suppliers

-- Question 14
Select Distinct customers.City
From Customers customers join Employees employees
On customers.City = employees.City And customers.Country = employees.Country

-- Question 15a
Select Distinct City
From Customers
Where City Not In(
	-- This subquery gives the cities have employees
	Select Distinct City
	From Employees
	)

-- Question 15b
Select Distinct City
From Customers
Except
Select Distinct City
From Employees

-- Question 16
Select productIdwithOrder.ProductID ProductID, products.ProductName, productIdwithOrder.Quantity Quantity
From (
	-- This subquery gives orderId and productId from each order
	Select details.ProductID ProductID, Sum(details.Quantity) Quantity
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	Group By details.ProductID
	) productIdwithOrder
Join Products products
On productIdwithOrder.ProductID = products.ProductID
Order By productIdwithOrder.ProductID

-- Question 17a
Select City
From Customers
Except (
Select distinct City
From Customers
Group By City
Having Count(City) = 0
Union
Select distinct City
From Customers
Group By City
Having Count(City) = 1
)

-- Question 17b
Select City
From Customers
Except (
Select distinct City
From Customers
Group By City
Having Count(City) < 2
)

-- Question 18
Select citywithproductId.City
From (
	Select Distinct orders.ShipCity City, details.ProductID ProductID
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	) citywithproductId
Group By citywithproductId.City
Having Count(citywithproductId.City) > 1

-- Question 19
With popular5ProductId (ProductID, Quantity, [Rank]) As (
	Select Top 5 popularProductId.ProductID, popularProductId.Quantity, Rank() Over(Order By popularProductId.Quantity Desc) [Rank]
	From (
		Select details.ProductID ProductID, Sum(details.Quantity) Quantity
		From Orders orders Join [Order Details] details
		On orders.OrderID = details.OrderID
		Group By details.ProductID
		) popularProductId
	),
productAveragePrice (ProductID, [Average Price]) As (
	Select details.ProductID ProductID, Avg(details.UnitPrice * (1 - details.Discount)) [Average Price]
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	Group By details.ProductID
	),
citywithItemCount (City, ProductID, [Item Count]) As (
	Select Distinct orders.ShipCity City, details.ProductID ProductID, Sum(details.Quantity) [Item Count]
	From Orders orders Join [Order Details] details
	On orders.OrderID = details.OrderID
	Group By details.ProductID, orders.ShipCity
	)

Select allInfo.ProductID, allInfo.Quantity [Ordered Quantity], allInfo.[Average Price], allInfo.City [Most Ordered City],
		allInfo.[Item Count] [Ordered Number From The City]
From (
	Select productInfo.ProductID, productInfo.Quantity, productInfo.[Average Price], citywithItemCount.City, citywithItemCount.[Item Count], 
			Rank() Over(Partition By productInfo.ProductID Order By citywithItemCount.[Item Count] Desc) [Rank]
	From (
		Select popular5ProductId.ProductID, popular5ProductId.Quantity, productAveragePrice.[Average Price]
		From popular5ProductId Join productAveragePrice
		On popular5ProductId.ProductID = productAveragePrice.ProductID
		) productInfo 
	Join citywithItemCount
	On productInfo.ProductID = citywithItemCount.ProductID
	-- Order By productInfo.ProductID
	) allInfo
Where allInfo.Rank = 1




-- Question 20
Select emp.City, emp.[Order Count], item.[Item Count]
From (
	-- This subquery finds how many orders associated with each city has employee
	Select citywithOrderCount.City, Sum(citywithOrderCount.[Order Count]) [Order Count]
	From (
		-- This subquery finds how many orders associated with each employee
		Select employeeIdwithOrderCount.EmployeeID, employeeIdwithOrderCount.City, Count(employeeIdwithOrderCount.EmployeeID) [Order Count]
		From (
			-- This subquery finds employeeId foreach order
			Select orders.OrderID, orders.EmployeeID, employees.City
			From Orders orders Join Employees employees
			On orders.EmployeeID = employees.EmployeeID
			) employeeIdwithOrderCount
		Group By employeeIdwithOrderCount.EmployeeID, employeeIdwithOrderCount.City
		) citywithOrderCount
	Group By citywithOrderCount.City
	-- Order By [Order Count] Desc
) emp

Join (
-- This subquery finds how many items were ordered to each city
Select orders.ShipCity City, Sum(details.Quantity) [Item Count]
From Orders orders Join [Order Details] details
On orders.OrderID = details.OrderID
Group By orders.ShipCity
-- Order By Sum(details.Quantity) Desc
) item

On emp.City = item.City
Order By emp.[Order Count] Desc, item.[Item Count] Desc

-- Question 21
-- 1. By distinct
-- 2. Set conditions in Where operator, like: In/Not In a set
-- 3. Union the table with itself
-- 4. Using Group By
-- 5. Using Partition By
-- 6. Join with a table with no duplicates 
