SELECT TypeProducts.ProductName, Products_Category_CategoryName_Like.CategoryName
FROM
(
	SELECT ProductID, ProductName
	FROM  Products
	GROUP BY ProductID, ProductName
) AS TypeProducts
LEFT JOIN
(
	SELECT ProductID, CategoryID
	FROM Products_Category_Like AS pc
	JOIN
	Category AS c
	ON pc.CategoryID = c.CategoryID
	GROUP BY ProductID, CategoriesID
) AS Products_Category_CategoryName_Like
GROUP BY TypeProducts.ProductName, Products_Category_CategoryName_Like.CategoryName