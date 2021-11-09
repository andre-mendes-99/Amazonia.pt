CREATE PROCEDURE [dbo].[usp_CoverterNomeParaMaiusculo]
	@param01 varchar(50)	
AS
	SELECT UPPER(@param01)
RETURN 0
