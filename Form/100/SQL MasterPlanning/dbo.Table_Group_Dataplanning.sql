
CREATE proc Table_Group_Dataplanning (@xcase int,@mat nvarchar(18),@NEng nvarchar(40),@mproduct nvarchar(30),@mtype nvarchar(30))
as	
	begin try
		drop table ##tmpGroup_Dataplanning
	end try
	begin catch
	end catch
	declare @sql nvarchar(max)
	set @sql = dbo.SQL_Group_Dataplanning (@xcase ,@mat ,@NEng ,@mproduct,@mtype)
	exec (@sql)