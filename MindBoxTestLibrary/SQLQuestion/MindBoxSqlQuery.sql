CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](255) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
([ID] ASC ) ) ON [PRIMARY]

CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](255) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
([ID] ASC) ) ON [PRIMARY]

CREATE TABLE [dbo].[ProductCategories] (
	[ProductID] [int] FOREIGN KEY REFERENCES Product(ID),
	[CategoryID] [int] FOREIGN KEY REFERENCES Category(ID),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO [dbo].[Product]
           ([ProductName])
     VALUES
           ('Coca Cola'),
           ('Chicken'),
           ('Tuna'),
           ('Rainbow trout'),
           ('Soap')

INSERT INTO [dbo].[Category]
           ([CategoryName])
     VALUES
           ('Meat'),
           ('Seafood'),
           ('Drink')

INSERT INTO ProductCategories
VALUES
	(1, 3),
	(2, 1),
	(3, 2),
    (3, 1),
    (4, 2),
    (4, 1)

SELECT ProductName, CategoryName 
FROM Product p
LEFT JOIN ProductCategories pc ON pc.ProductID = p.ID
LEFT JOIN Category c ON pc.CategoryID = c.ID
ORDER BY p.ProductName, c.CategoryName
