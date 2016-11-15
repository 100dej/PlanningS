CREATE proc UserBehaviorAnalyticsForChart (@Uname nvarchar(20))
as
	select xdatename, sum(AM) as AM, sum (PM) as PM  from PlanningS.dbo.UserBehaviorAnalytics (@Uname) group by xdatename,xWeekDay order by xWeekDay

	select xMonthName,sum(Total) as Total   from PlanningS.dbo.UserBehaviorAnalytics (@Uname) group by xMonthName,xMonth order by xMonth	
	
	select * from plannings.dbo.ExcuteResultDayInMonth (@Uname)
		
	select xDay, sum(Total) as Total  from PlanningS.dbo.UserBehaviorAnalytics (@Uname) group by xDay order by xday