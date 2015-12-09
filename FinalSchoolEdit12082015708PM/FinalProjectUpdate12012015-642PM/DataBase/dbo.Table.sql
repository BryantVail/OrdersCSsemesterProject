CREATE TABLE [dbo].[VendorT]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ItemType] NVARCHAR(50) NOT NULL, 
    [UnitPrice] DECIMAL NOT NULL, 
    [NameOfItem] NVARCHAR(50) NOT NULL, 
    [VendorName] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [AddStreetNum] NCHAR(10) NOT NULL, 
    [AddStreetName] NVARCHAR(50) NOT NULL, 
    [AddStreetType] NCHAR(10) NOT NULL, 
    [AddCity] NVARCHAR(50) NOT NULL, 
    [AddState] NVARCHAR(50) NOT NULL, 
    [AddZipCode] NCHAR(10) NOT NULL
)
