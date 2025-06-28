SELECT *
FROM (
    SELECT 
        *,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;
