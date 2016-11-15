		
CREATE proc ExecuteWeekDayForChart (@m nvarchar(2),@y nvarchar(4),@Uname nvarchar(20)) 
as
	select xdatename,xdate,sum(am) as AM,sum(pm) as PM, sum(AM + PM) as Total
	from plannings.dbo.ExecuteWeekDay (@m,@y) 		
	where Uname like '%' + @Uname 
	group by xdatename,xdate
	order by xDate