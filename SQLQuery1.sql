﻿USE [p2625596]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblTrip_SelectAll]

SELECT	@return_value as 'Return Value'

GO
