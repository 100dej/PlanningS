create proc ProgExecuteTimeForChart (@Uname nvarchar(8)) as
	select * from PlanningS.dbo.ProgExecuteTime() order by xtime