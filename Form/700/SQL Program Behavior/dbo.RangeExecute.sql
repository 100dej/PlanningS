CREATE function RangeExecute (@Uname nvarchar(20))
returns table
as
	return
		with cte 
		as (
			select * from plannings.dbo.RangeExecuteSuccess(@Uname)
			union all
			select * from plannings.dbo.RangeExecuteError(@Uname)
			)
		select xRange ,sum(SuccessCount) as SuccessCount,sum(ErrorCount) as ErrorCount
		from cte
		group by xRange