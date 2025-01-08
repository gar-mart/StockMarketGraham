CREATE FUNCTION fxGetIdByTicker(@symbol NVARCHAR(10))
RETURNS INT
AS
BEGIN
    DECLARE @id INT;

    SELECT @id = Id 
    FROM Entity.Stock 
    WHERE Symbol = @symbol

    RETURN @id
END

