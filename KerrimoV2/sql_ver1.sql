CREATE DATABASE KERRIMOproj
use KERRIMOproj
CREATE TABLE tblLoginData
(
USERNAME varchar(32) NOT NULL,
[PASSWORD] varchar(32) NOT NULL,
[EMPLOYEE ID] varchar(50) NOT NULL,
[PRIVILEDGE LEVEL] [int] NOT NULL,
constraint PK_tblLoginData primary key ([EMPLOYEE ID]))

INSERT INTO tblLoginData VALUES('admin','admin','E-Admin',1)
select * from tblLoginData
--drop table tblLoginData
--drop table tblUserData
delete from tblUserData where usertype = 'Admin1'
select tblLoginData, tblUserData FROM tblLoginData INNER JOIN tblUserData on tblUserData.[EMPLOYEE ID]=tblLoginData.[EMPLOYEE ID] where tblLoginData.USERNAME = 'admin2'
SELECT usertype,name,contact,email,branch,tblLoginData.[PASSWORD] FROM tblUserData INNER JOIN tblLoginData on tblUserData.[EMPLOYEE ID]=tblLoginData.[EMPLOYEE ID] WHERE username = 'admin2'
select * from tblLoginData
CREATE TABLE [dbo].[tblUserData](
	[EMPLOYEE ID] varchar(50) NOT NULL,
	USERNAME varchar(32) NOT NULL,
	[PASSWORD] varchar(32) NOT NULL,
	[NAME] [varchar](50) NOT NULL,
	USERTYPE varchar(32) Not null,
	[BRANCH] [varchar](50) NOT NULL,
	[CONTACT] [varchar](50) NOT NULL,
	[Email] [varchar](250) NULL,
	[PRIVILEDGE LEVEL] [int] NOT NULL,
	[JoiningDate] [nchar](50) NULL,
	constraint PK_tblUserData primary key ([EMPLOYEE ID]))
ALTER TABLE tblUserData
ALTER COLUMN [PASSWORD] varchar(MAX)
select * from tblUserData
SELECT FNAME AS [First Name] FROM tblUserData 
INSERT INTO tblUserData VALUES('E-Admin','admin','admin','Joshua Tamargo','Admin1','Taguig','+639193422228','joshua_tamargo12@yahoo.com',1,null)
INSERT INTO tblUserData VALUES(2,'Joshua Tamargo1','Admin2','Taguig','+639193422228','joshua_tamargo12@yahoo.com',null)
INSERT INTO tblUserData VALUES(3,'Joshua Tamargo2','Admin3','Taguig','+639193422228','joshua_tamargo12@yahoo.com',null)

CREATE TABLE [dbo].[Product](
	[ProductID] [nchar](10) NOT NULL,
	[ProductName] [varchar](max) NOT NULL,
	[Price] [float] NOT NULL,
	[Image] [image] NULL,	
	[SuppliesID] nchar(10)
	
)
ALTER TABLE Product
ADD PRIMARY KEY (ProductID)

ALTER TABLE Product
DROP Constraint [ProductID]
ALTER TABLE Product
DROP Foreign Key SuppliesID

ADD FOREIGN KEY ([SuppliesID])
REFERENCES Supplies_List([SuppliesID])
update Product set SuppliesID = 'SL-134498' where ProductID ='P-178454' SL-888367 SL-226285 
update product set SuppliesID = 'SL-888367 ' where ProductID ='P-791434  '
update product set SuppliesID = 'SL-226285  ' where ProductID ='P-447321    '	
select * from Product
INSERT INTO Product values ('P-244142', 'Kerrimo Premium Fries', 40, NULL)
INSERT INTO Product values ('P-541622', 'Kerrimo European Fries', 50, NULL)
INSERT INTO Product values ('P-982911', 'Kerrimo Belgium Fries', 60, NULL)
INSERT INTO Product	values ('P-982911', 'Kerrimo Asian Fries', 70, NULL)
INSERT INTO Product	values ('P-982911', 'Kerrimo Regular Fries', 70, NULL)
drop table product

CREATE TABLE Size
(
[id] nchar(10) NOT NULL,
SizeName varchar(max) NOT NULL,
SizePrice float NOT NULL,
)
ALTER TABLE SIZE
ADD [id] nchar(10)


select * from Size
--Update Size set SizeName='Dyanne',SizePrice=" + txtPriceSize.Text + " Where SizeName='" + txtSizeName.Text + "'
INSERT INTO Size Values ('P-982911','Budget',10)
INSERT INTO Size Values ('P-982912','Regular',20)
INSERT INTO Size Values ('P-982913','Jumbo',30)

Create table tblFlavorCat(
flavorCatId nchar(10) NOT NULL,
flavorName varchar (50) NULL
)
ALTER TABLE tblFlavorCat
ADD FlavorPrice float 

select * from tblFlavorCat

Create table tblDrinkCat
(
drinkCatId nchar(10) NOT NULL,
drinkName varchar(50) NULL
)
ALTER TABLE tblDrinkCat
ADD		 float 

INSERT INTO tblDrinkCat values ('Iced Tea')
INSERT INTO tblDrinkCat values ('Orange')
INSERT INTO tblDrinkCat values ('Strawberry')

 

CREATE TABLE [dbo].[ProductSold](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [nchar](15) NOT NULL,
	[ProductName] [varchar](250) NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL
)

CREATE TABLE [dbo].[Invoice_Info](
	[InvoiceNo] [nchar](15) NOT NULL,
	[InvoiceDate] [nchar](30) NOT NULL,
	
	[Total] [float] NOT NULL,
	[TotalPayment] [float] NOT NULL,
	[Change] [float] NOT NULL,
	)
select * from Invoice_Info

select * from ProductSold
delete from ProductSold
CREATE TABLE [dbo].[Supplier](
	[SupplierId] [nchar](10) NOT NULL,
	[SupplierName] [varchar](250) NOT NULL,
	[Address] [varchar](250) NOT NULL,
	[City] [varchar](250) NOT NULL,
	[ContactNo] [nchar](15) NOT NULL,
	[ContactNo1] [nchar](15) NULL,
	[Email] [varchar](250) NULL,
	[Notes] [varchar](max) NULL,
	)
	INSERT INTO Supplier VALUES ('ST-XAMPLE','Supplier Name','Batangas','Lipa',09193422228,4561220,'dismalar12@gmail.com',NULL)
	CREATE TABLE [dbo].[Temp_Stock](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [nchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,)
	select * from product
	insert into Temp_Stock values ('P-832116',5)
	insert into Temp_Stock values ('Jumbo',500)
	CREATE TABLE [dbo].[Stock](
	[StockID] [nchar](10) NOT NULL,
	[StockDate] [nchar](30) NOT NULL,
	[ProductID] [nchar](10) NOT NULL,
	[SupplierID] [nchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,)
	insert into Stock values ('ST-SAMP','01/Jun/2016','P-832116','ST-XAMPLE',10)                   
	SELECT RTRIM(StockID),RTRIM(StockDate),RTRIM(ProductID),RTRIM(ProductName),RTRIM(Supplier.SupplierID),RTRIM(SupplierName),RTRIM(Quantity) from Stock,Product,Supplier where Stock.ProductID=Product.ProductID and Stock.SupplierID=Supplier.SupplierID order by ProductName

	CREATE TABLE Supplies_List
	(
	SuppliesID nchar(10) NOT NULL,
	SuppliesName varchar(max) NOT NULL,
	Unit varchar(10) NoT NULL,
	Price decimal(10,2) NOT NULL,
	)
	ALTER TABLE Supplies_List
	ALTER COLUMN ProductID varchar(max)
	REFERENCES Product(ProductID)
	ADD PRIMARY KEY (SuppliesID)
	
	ALTER TABLE Supplies_List
	DROP COLUMN PRODUCTID
	ALTER Column ProductID varchar(max)
   Update Supplies_List
   SET ProductID='P-952451'
   WHERE SuppliesID = 'SL-917914 '
	select * from Supplies_List
	select * from tblUserData
	select* from Stock
	select * from Size
	select * from product
	select * from ProductSold
	select * from tblFlavorCat
	select * from tblDrinkCat
	select * from invoice_info
	select * from Temp_Stock
	select * from Temp_Stock where ProductID is Null
	Update Temp_Stock
	Set ProductID = Null
	where ID = 32
	select * from Supplies_List where SuppliesName like 'reg%' order by SuppliesID
	SELECT * from Supplies_List, STOCK
	SELECT RTRIM(SuppliesID),RTRIM(SuppliesName),RTRIM(Unit),RTRIM(Price),RTRIM(ProductID) from Supplies_List where SuppliesName like '&bel' order by SuppliesName
	SELECT RTRIM(ProductID),RTRIM(ProductName),RTRIM(Price),Image from Product where ProductName like '%' order by Productname
	SELECT Supplies_List.SuppliesID,SuppliesName,Unit,Price,sum(Quantity),sum(Price*Quantity) from Temp_Stock,Supplies_List where Temp_Stock.SuppliesID=Supplies_List.SuppliesID and SuppliesName like 'che' group by Supplies_List.SuppliesID,suppliesname,Price,unit,Quantity having(Quantity>0)  order by SuppliesName
	select * from Supplies_List where ProductID IS NULL
	update temp_stock set Quantity = Quantity - " + ListView1.Items[i].SubItems[4].Text + " where ProductID IS NULL
	ALTER TABLE Temp_Stock
	ADD ProductID varchar(max)
	SELECT * from invoice_info,productsold where invoice_info.invoiceno=productsold.invoiceno and Invoice_info.invoiceNo='OD-99828482    '
	update temp_stock set Quantity = Quantity - 1 where ProductID= 'SL-592498'
	update temp_stock set Quantity = Quantity - 1 where ProductID= 'SL-117565 '
	SELECT * from invoice_info,productsold where invoice_info.invoiceno=productsold.invoiceno and ProductSold.ProductID=Product.ProductID and Invoice_info.invoiceNo='OD-99828482'    
		SELECT RTRIM(StockID),RTRIM(StockDate),RTRIM(Supplies_List.SuppliesID),RTRIM(SuppliesName),RTRIM(Supplier.SupplierID),RTRIM(SupplierName),RTRIM(Quantity) from Stock,Supplies_List,Supplier where Stock.ProductID=Supplies_List.SuppliesID and Stock.SupplierID=Supplier.SupplierID and StockDate between '05/Jun/2016' and '17/Jun/2016'order by SuppliesName
		SELECT Supplies_List.SuppliesID,SuppliesName,Unit,Price,sum(Quantity),sum(Price*Quantity) from Temp_Stock,Supplies_List where Temp_Stock.ProductID=Supplies_List.SuppliesID group by Supplies_List.SuppliesID,suppliesname,Price,unit,Quantity having(Quantity>0)  order by SuppliesName
update temp_stock set Quantity = Quantity - 1 where ProductID= 'SL-296768'
SELECT * from product,invoice_info,productsold where invoice_info.invoiceno=productsold.invoiceno and ProductSold.ProductID=Product.ProductID and Invoice_info.invoiceNo='OD-42624246'    

UPDATE Temp_Stock
   SET ProductID = CASE SuppliesID
                      WHEN 'SL-888367' THEN 'P-244142' 
                      WHEN 'SL-676368' THEN 'P-244142' 
                      ELSE SuppliesID
                      END
 WHERE SuppliesID IN('SL-888367', 'SL-676368');

CREATE TABLE PO (
	[OrderNo] [nchar](15) NOT NULL,
	[OrderDate] [nchar](30) NOT NULL,
	[EMPLOYEE ID] [nchar](15),
	[SubTotal] [float] NOT NULL,
	[VATPer] [float] NOT NULL,
	[VATAmount] [float] NOT NULL,
	[DiscountPer] [float] NOT NULL,
	[DiscountAmount] [float] NOT NULL,
	[GrandTotal] [float] NOT NULL,
	[TotalPayment] [float] NOT NULL,
	PaymentDue [float] NOT NULL,
	[Status] varchar(max),
	Remarks varchar(max))

	ALTER TABLE PO
	ADD Remarks varchar(max)
 select * from tblUserData
 select * from PO
 SELECT RTRIM(OrderNo) as [Order No],RTRIM(OrderDate) as [Order Date],RTRIM(PO.[EMPLOYEE ID]) as [Employee ID],RTRIM(Name) as [Customer Name],RTRIM(SubTotal) as [SubTotal],RTRIM(VATPer) as [Vat+ST %],RTRIM(VATAmount) as [VAT+ST Amount],RTRIM(DiscountPer) as [Discount %],RTRIM(DiscountAmount) as [Discount Amount],RTRIM(GrandTotal) as [Grand Total],RTRIM(TotalPayment) as [Total Payment],RTRIM(PaymentDue) as [Payment Due],RTRIM(Status) as [Status],Remarks from PO,tblUserData where PO.[EMPLOYEE ID]=tblUserData.[EMPLOYEE ID] and tblUserData.[EMPLOYEE ID]=
SELECT RTRIM(Supplies_List.SuppliesID),RTRIM(SuppliesName),RTRIM(Unit),RTRIM(Price),RTRIM(Supplies_List.ProductID),RTRIM(Quantity) from Supplies_List,Temp_Stock where Supplies_List.SuppliesID=Temp_Stock.SuppliesID order by SuppliesName

CREATE TABLE SO
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNo] [nchar](15) NOT NULL,
	[SuppliesID] [varchar](50) NOT NULL,
	[SuppliesName] [varchar](250) NOT NULL,
	[Unit] varchar(50),
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL
	
)
SELECT * from Supplies_List,PO,SO,tblUserData where PO.OrderNo=SO.OrderNo and PO.[EMPLOYEE ID]=tblUserData.[EMPLOYEE ID] and SO.SuppliesID=Supplies_List.SuppliesID and PO.OrderNo='ON-21516782    '
SELECT distinct Name FROM PO,tblUserData where PO.[Employee Id]=tblUserData.[Employee Id]
SELECT RTRIM([EMPLOYEE ID])as [Customer ID],RTRIM(Name) as [Customer Name],RTRIM([BRANCH]) as [Address],RTRIM(Contact) as [Contact No.], (email) as [Email] from tblUserData where [Priviledge Level] = 2 order by Name
SELECT * from Supplies_List,PO,SO,tblUserData where PO.OrderNo=SO.OrderNo and PO.[EMPLOYEE ID]=tblUserData.[EMPLOYEE ID] and SO.SuppliesID=Supplies_List.SuppliesID and PO.OrderNo='ON-59628668'      
select * from SO
	USE GoFitV5
CREATE TABLE SliderConfiguration
(
	imageUrl	varchar(max),
	isActive	varchar(1),
	company		varchar(max)
)

insert into SliderConfiguration VALUES ('diet.jpg',1,'1')
DELETE FROM SliderConfiguration
insert into SliderConfiguration VALUES ('article.jpg',1,'1')
insert into SliderConfiguration VALUES ('boxing.jpg',1,'1')


