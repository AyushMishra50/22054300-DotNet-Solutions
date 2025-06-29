-- Using ROW_NUMBER
SELECT *
FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowPosition
    FROM ProductCatalog
) AS RankedProducts
WHERE RowPosition <= 3;

-- Using RANK
SELECT *
FROM (
    SELECT *,
           RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank
    FROM ProductCatalog
) AS RankedProducts
WHERE PriceRank <= 3;

-- Using DENSE_RANK
SELECT *
FROM (
    SELECT *,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DensePriceRank
    FROM ProductCatalog
) AS RankedProducts
WHERE DensePriceRank <= 3;
