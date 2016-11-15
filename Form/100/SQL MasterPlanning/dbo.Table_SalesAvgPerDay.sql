
CREATE proc Table_SalesAvgPerDay (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
as	
	begin try
		drop table ##tmpSalesAvgPerDay
	end try
	begin catch
	end catch
	declare @sql nvarchar(max)
	set @sql = dbo.SQL_SalesAvgPerDay (@xcase ,@mat ,@NEng )
	exec (@sql)