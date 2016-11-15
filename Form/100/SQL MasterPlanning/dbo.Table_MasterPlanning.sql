
CREATE proc Table_MasterPlanning (@Scase int,@xcase int,@mat nvarchar(18),@NEng nvarchar(40),@VUname nvarchar(20),@Vname nvarchar(30),@mproduct nvarchar(30),@mtype nvarchar(30))
as
	exec Table_Group_Dataplanning @xcase, @mat, @NEng, @mproduct,@mtype
	exec Table_SalesAvgPerDay @xcase, @mat, @NEng
	exec Table_SalesAvg15D @xcase, @mat, @NEng
	exec Table_SalesAvgLastM @xcase, @mat, @NEng
	exec Table_ConSohGIT @xcase, @mat, @NEng
	exec Table_MasterPlanning_Step1 @xcase, @mat, @NEng
	declare @sql nvarchar(max)
		set @sql = dbo.SQL_MasterPlanning(@Scase,@VUname,@Vname)
	exec (@sql)