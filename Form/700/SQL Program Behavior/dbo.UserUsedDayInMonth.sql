

CREATE function UserUsedDayInMonth()
returns table
as
	return
	with cte as (
		select  distinct
			convert(nvarchar(4),year(xdate)) + '-' +  REPLICATE('0',2-len(month(xdate))) +  convert(nvarchar(2),month(xdate))  as MY , 
			cast(xdate as DATE) as Xdate
		from plannings.dbo.tbl_101userExecMyProg
		)
	select my, count(xdate) AS ActiveDay
	from cte
	group by MY