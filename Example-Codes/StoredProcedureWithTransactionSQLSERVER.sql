SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE dbo.spTestTrans
	@ProductName nvarchar(100)
AS
BEGIN

	SET NOCOUNT ON;

	BEGIN TRY
		BEGIN Transaction
		/* this line will not be inserted untill commit transaction, but next line will throw error and in catch blog we rollback transaction */
		insert into dbo.Products (ProductName,Amount,Properties,GroupId,Price) Values (@ProductName,1,'no properties',1,100) 
		/* this line throws error, cannot set ProductId to 1 */																																													
		insert into dbo.Products (ProductId,ProductName,Amount,Properties,GroupId,Price) Values (1,@ProductName,1,'no properties',1,100) 
		Commit Transaction
	END TRY
	BEGIN CATCH
		Rollback Transaction
	END CATCH

END
