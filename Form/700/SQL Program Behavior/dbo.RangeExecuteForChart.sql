CREATE proc RangeExecuteForChart (@Uname nvarchar(20))
as
	select * from PlanningS.dbo.RangeExecute (@Uname) order by xRange