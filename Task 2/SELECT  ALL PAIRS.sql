USE MindBoxTask2BD;
SELECT [dbo].[Products].[Name] AS ProductName, [dbo].[Categories].[Name] AS CategorieName
FROM [dbo].[Products]
LEFT JOIN [dbo].[ProductCategories]
ON [dbo].[Products].[Id] = [dbo].[ProductCategories].[ProductId]
LEFT JOIN [dbo].[Categories]
ON [dbo].[ProductCategories].[CategorieId] = [dbo].[Categories].[Id];