
CREATE proc Table_SalesAvgLastM (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
as	
	begin try
		drop table ##tmpSalesAvgLastM
	end try
	begin catch
	end catch
	declare @sql nvarchar(max)
	set @sql = dbo.SQL_SalesAvgLastM (@xcase ,@mat ,@NEng)
	exec (@sql)