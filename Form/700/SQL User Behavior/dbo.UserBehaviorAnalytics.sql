
-----------------------------------------------------------------------------
CREATE function UserBehaviorAnalytics (@xUser nvarchar(20)) 
returns table
	return
		select uname, xdate,
			datepart(day, xdate) AS xDay,
			datename(weekday,xdate) as xDateName,
			datepart(weekday, xdate) as xWeekDay,
			datename(MONTH,xdate) as xMonthName,
			DATEPART(MONTH,xdate) as xMonth,
			case when convert(nvarchar(2),cast(xdate as time)) < 12 then 1 else 0 end as AM,		
			case when convert(nvarchar(2),cast(xdate as time)) >=12 then 1 else 0 end as PM,
			1 as 	Total
		from plannings.dbo.tbl_101userExecMyProg
		where Uname like  @xUser + '%'