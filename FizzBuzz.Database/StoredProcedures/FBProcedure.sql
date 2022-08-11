
CREATE PROCEDURE [dbo].[FBProcedure](
	@result NVARCHAR(MAX)
)
AS
	
BEGIN

	INSERT INTO [dbo].[FBTable] (Results) VALUES (result);

END
