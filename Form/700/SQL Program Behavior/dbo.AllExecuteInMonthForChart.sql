create proc AllExecuteInMonthForChart(@m nvarchar(2),@y nvarchar(4)) as
	select a.MY,sum(success) as Success ,sum(error) as Error ,count(a.MY) as CUser,AVG(SuccessInSecond) as AVGSuccessTime, AVG(ErrorInSecond) as AVGErrorTime,
		sum(SuccessInSecond) as SuccessInSecond,sum(ErrorInSecond) as ErrorInSecond,SUM(CountUser) as CountUser,isnull(b.ActiveDay,0) as ActiveDay
	from PlanningS.dbo.ExecuteInMonth(@m,@y) a
	left join  PlanningS.dbo.UserUsedDayInMonth () b
		on a.my = b.my	
	group by a.MY,b.ActiveDay
	order by a.MY