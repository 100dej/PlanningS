
CREATE function ExecuteDay(@m nvarchar(2),@y nvarchar(4)) 
returns table
	return
		with cte 
		as (
			select distinct 'Success' as xType, uname, cast(xdate as DATE) as xDate,count(xdate) over (partition by cast(xdate as DATE),uname) as CountExcute
			from plannings.dbo.tbl_101userExecMyProg			
			union
			select distinct 'Error' as xType, uname, cast(xdate as DATE) as xDate,count(xdate) over (partition by cast(xdate as DATE),uname) as CountExcute
			from plannings.dbo.tbl_102userExecMyprogTimeout
		)
		select Uname, 
		sum(case when xtype = 'Success' then 1 else 0 end) as SuccessDate,
		sum(case when xtype = 'Error' then 0 else 0 end) as ErrorDate,
		COUNT(Uname) as TotalDate,
		sum(case when xtype = 'Success' then CountExcute  else 0 end) as CountExecSuccess,
		sum(case when xtype = 'Error' then CountExcute  else 0 end) as CountExecError		
		from cte
		group by Uname