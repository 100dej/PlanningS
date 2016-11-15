create function ProgExecuteTime ()
returns table
as
	return
	with cte 
	as(
			select convert(nvarchar(2),cast(xdate as time))  as xTime,execusedtime as SuccessTime,0 as ErrorTime,1 as sType,0 as eType
			from plannings.dbo.tbl_101userExecMyProg
			union all
			select convert(nvarchar(2),cast(xdate as time))  as xTime,0 as SuccessTime,execusedtime as Errortime,0 as sType,1 as eType
			from plannings.dbo.tbl_102userExecMyprogTimeout
		)
	select xTime,sum(sType) as CountSuccessTime,sum(eType) as CountErrorTime,sum(sType + eType) as CountTotalTime,
		sum(successtime) as SuccessTime,sum(Errortime) AS ErrorTime,sum(successtime+Errortime) as TotalTime
	from cte
	group by  xTime