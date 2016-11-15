
CREATE proc Table_SalesAvg15D (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
as	
	begin try
		drop table ##tmpSalesAvg15D
	end try
	begin catch
	end catch
	declare @sql nvarchar(max)
	set @sql = dbo.SQL_SalesAvg15D (@xcase ,@mat ,@NEng)
	exec (@sql)