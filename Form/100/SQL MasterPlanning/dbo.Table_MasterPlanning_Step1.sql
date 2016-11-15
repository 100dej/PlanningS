
CREATE proc Table_MasterPlanning_Step1 (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
as	
	begin try
		drop table ##tmpMasterPlanning_Step1
	end try
	begin catch
	end catch
	declare @sql nvarchar(max)
	set @sql = dbo.SQL_MasterPlanning_Step1 (@xcase ,@mat ,@NEng)
	exec (@sql)