
CREATE proc Table_ConSohGIT (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
as	
	begin try
		drop table ##tmpConSohGIT
	end try
	begin catch
	end catch
	declare @sql nvarchar(max)
	set @sql = dbo.SQL_ConSohGIT(@xcase ,@mat ,@NEng)
	exec (@sql)