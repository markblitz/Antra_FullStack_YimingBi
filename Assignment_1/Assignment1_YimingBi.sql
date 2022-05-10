Use AdventureWorks2019

-- Question 1
Select ProductID, Name, Color, ListPrice
From Production.Product

-- Question 2
Select ProductID, Name, Color, ListPrice
From Production.Product
Where ListPrice != 0

-- Question 3
Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color Is Not Null

-- Question 4
Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color Is Not Null And ListPrice > 0

-- Question 5
Select Name + ' ' + Color
From Production.Product
Where Color Is Not Null

-- Question 6
Select *
From Production.Product
Where (Name = 'LL Crankarm' And Color = 'Black')
Or (Name = 'ML Crankarm' And Color = 'Black')
Or (Name = 'HL Crankarm' And Color = 'Black')
Or (Name = 'Chainring Bolts' And Color = 'Silver')
Or (Name = 'Chainring Nut' And Color = 'Silver')
Or (Name = 'Chainring' And Color = 'Black')

-- Question 7
Select ProductID, Name
From Production.Product
Where ProductID Between 400 and 500

-- Question 8
Select ProductID, Name, Color
From Production.Product
Where Color In ('black','blue')

-- Question 9
Select *
From Production.Product
Where Name Like 'S%'

-- Question 10
Select Name, ListPrice
From Production.Product
Where Name Like '[AS]%'
Order By Name

-- Question 11
Select *
From Production.Product
Where Name Like '[SPO][^K]%'
Order By Name

-- Question 12
Select Distinct IsNULL(ProductSubcategoryID, 0) 'ProductSubcategoryID', IsNULL(Color, 'N/A') 'Color'
From Production.Product