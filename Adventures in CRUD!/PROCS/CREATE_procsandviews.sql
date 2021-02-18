USE [AdventureWorksLT2019]
GO
/****** Object:  View [dbo].[ProductView]    Script Date: 2/17/2021 5:57:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ProductView]
AS
SELECT        SalesLT.Product.ProductID, SalesLT.Product.Name, SalesLT.ProductCategory.ProductCategoryID, SalesLT.ProductCategory.Name AS CategoryName, SalesLT.ProductModelProductDescription.ProductModelID, 
                         SalesLT.ProductModelProductDescription.ProductDescriptionID, SalesLT.ProductModelProductDescription.Culture, SalesLT.ProductDescription.ProductDescriptionID AS DescriptionID, 
                         SalesLT.ProductModel.ProductModelID AS ModelID, SalesLT.ProductModel.Name AS ModelName, SalesLT.Product.ProductNumber, SalesLT.Product.Color, SalesLT.Product.StandardCost, SalesLT.Product.ListPrice, 
                         SalesLT.Product.Size, SalesLT.Product.Weight
FROM            SalesLT.Product INNER JOIN
                         SalesLT.ProductCategory ON SalesLT.Product.ProductCategoryID = SalesLT.ProductCategory.ProductCategoryID INNER JOIN
                         SalesLT.ProductModel ON SalesLT.Product.ProductModelID = SalesLT.ProductModel.ProductModelID INNER JOIN
                         SalesLT.ProductModelProductDescription ON SalesLT.ProductModel.ProductModelID = SalesLT.ProductModelProductDescription.ProductModelID INNER JOIN
                         SalesLT.ProductDescription ON SalesLT.ProductModelProductDescription.ProductDescriptionID = SalesLT.ProductDescription.ProductDescriptionID
GO
/****** Object:  StoredProcedure [dbo].[deleteCust]    Script Date: 2/17/2021 5:57:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[deleteCust]
@CustomerID int
AS
DELETE FROM [SalesLT].[Customer] WHERE [CustomerID]=@CustomerID
GO
/****** Object:  StoredProcedure [dbo].[InsertCust]    Script Date: 2/17/2021 5:57:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertCust]
(  
    @CustomerID INT,
	@Title NVARCHAR(8) = NULL,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @CompanyName NVARCHAR(128) = NULL,
	@EmailAddress NVARCHAR(50) = NULL,
	@AddressID int,
	@AddressT NVARCHAR(50),
	@AddL1 NVARCHAR(60),
	@AddL2 NVARCHAR(60) = Null,
	@City NVARCHAR(50),
	@State NVARCHAR(50),
	@PostalC NVARCHAR(50)
)
AS
    INSERT INTO [SalesLT].[Customer] ([CustomerID],[Title], [FirstName], [LastName],[CompanyName],[EmailAddress])  
    VALUES (@CustomerID,@Title,@FirstName,@LastName,@CompanyName,@EmailAddress)  
GO
/****** Object:  StoredProcedure [dbo].[showCust]    Script Date: 2/17/2021 5:57:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[showCust]
AS
BEGIN
    SELECT [SalesLT].[Customer].[CustomerID] AS [CustomerID],[FirstName],[MiddleName],[LastName],[CompanyName],[EmailAddress],[SalesLT].[CustomerAddress].[AddressType],
	[AddressLine1],[AddressLine2],[City],[StateProvince],[PostalCode] 
	FROM (([SalesLT].[Customer]
	left join [SalesLT].[CustomerAddress] on [SalesLT].[Customer].[CustomerID] = [SalesLT].[CustomerAddress].[CustomerID])
	left join [SalesLT].[Address] on [SalesLT].[CustomerAddress].[AddressID] = [SalesLT].[Address].[AddressID])
END
GO
/****** Object:  StoredProcedure [dbo].[showProd]    Script Date: 2/17/2021 5:57:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[showProd]
AS
BEGIN
    SELECT [ProductID],[Name],[ProductCategoryID],[CategoryName],[ProductModelID],[ProductDescriptionID],[Culture],
	[DescriptionID],[ModelID],[ModelName],[ProductNumber],[ProductNumber],[Color],[StandardCost],
	[ListPrice],[Size],[Weight]
	From [dbo].[ProductView]
	where [dbo].[ProductView].[Culture] = 'en'
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCust]    Script Date: 2/17/2021 5:57:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateCust]
(  
    @CustomerID INT,
    @FirstName NVARCHAR(50),
	@MiddleName NVARCHAR(50) = NULL,
    @LastName NVARCHAR(50),
    @CompanyName NVARCHAR(128) = NULL,
	@EmailAddress NVARCHAR(50) = NULL,
	@AddressID INT,
	@AddressT NVARCHAR(50),
	@AddL1 NVARCHAR(60),
	@AddL2 NVARCHAR(60) = Null,
	@City NVARCHAR(50),
	@State NVARCHAR(50),
	@PostalC NVARCHAR(50)
)
AS
BEGIN  
    UPDATE [SalesLT].[Customer] SET [FirstName]=@FirstName,[MiddleName]=@MiddleName,
    [LastName]=@LastName,[CompanyName]=@CompanyName,[EmailAddress]=@EmailAddress 
	WHERE [CustomerID]=@CustomerID
END
BEGIN
	UPDATE [SalesLT].[CustomerAddress] SET [AddressType]=@AddressT
	WHERE [CustomerID]=@CustomerID
END
BEGIN
	UPDATE [SalesLT].[Address] SET [AddressLine1]=@AddL1,[AddressLine2]=@AddL2,
	[City]=@City,[StateProvince]=@State,[PostalCode]=@PostalC
	WHERE [AddressID]=@AddressID
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[23] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Product (SalesLT)"
            Begin Extent = 
               Top = 47
               Left = 21
               Bottom = 177
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "ProductCategory (SalesLT)"
            Begin Extent = 
               Top = 7
               Left = 311
               Bottom = 137
               Right = 535
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ProductModel (SalesLT)"
            Begin Extent = 
               Top = 211
               Left = 296
               Bottom = 341
               Right = 486
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ProductModelProductDescription (SalesLT)"
            Begin Extent = 
               Top = 211
               Left = 579
               Bottom = 374
               Right = 781
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ProductDescription (SalesLT)"
            Begin Extent = 
               Top = 15
               Left = 826
               Bottom = 153
               Right = 1028
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
       ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'  GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductView'
GO
