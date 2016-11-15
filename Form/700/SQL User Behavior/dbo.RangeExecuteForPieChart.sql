CREATE proc RangeExecuteForPieChart (@Uname nvarchar(20))
as
	select xRange ,SUM(Successcount) as Success from plannings.dbo.RangeExecuteSuccess(@Uname) group by xRange order by xRange
	
	select xRange ,SUM(ErrorCount) as Error from plannings.dbo.RangeExecuteError(@Uname) group by xRange order by xRange