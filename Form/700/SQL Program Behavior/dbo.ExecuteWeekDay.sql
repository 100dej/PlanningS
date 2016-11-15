CREATE function ExecuteWeekDay (@m nvarchar(2),@y nvarchar(4)) 
returns table
	return
		with cte 
		as (
			select uname, 
				datename(weekday, cast(xdate as DATE)) as xDateName,
				datepart(weekday, cast(xdate as DATE)) as xDate,
				case when convert(nvarchar(2),cast(xdate as time)) < 12 then 1 else 0 end as AM,		
				case when convert(nvarchar(2),cast(xdate as time)) >=12 then 1 else 0 end as PM				
			from plannings.dbo.tbl_101userExecMyProg			
			)
		select uname,xDateName,xDate,sum(AM) as AM, sum(PM) as PM
		from cte
		group by uname,xDateName,xDate