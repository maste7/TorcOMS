CREATE PROCEDURE CreateOrder  
@CustomerId BIGINT, 
@ProductId BIGINT,
@ProductQty INT
AS
BEGIN

DECLARE @TotalCost DECIMAL(18,2)

IF(@ProductQty < 1)
BEGIN
RETURN -2;
END

IF((SELECT COUNT(1) FROM Products WHERE Id = @ProductId) = 0)
BEGIN
RETURN -1;
END

SELECT @TotalCost = @ProductQty * Price 
FROM Products (NOLOCK) 
WHERE Id = @ProductId

INSERT INTO Orders
VALUES (@CustomerId, @ProductId, @ProductQty, @TotalCost)

END;