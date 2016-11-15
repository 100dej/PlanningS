create proc ProgExecuteAllTimeForChart (@Uname nvarchar(8)) as
	select 
		case 
			when  xTime <= 12 then 'AM'
			else 'PM'
		end as xTime,
		sum(CountSuccessTime) as CountSuccessTime,
		sum(CountErrorTime) as CountErrorTime,
		sum(CountTotalTime) as CountTotalTime,
		sum(SuccessTime) as SuccessTime,
		sum(ErrorTime) as ErrorTime,
		sum(TotalTime) as TotalTime
	 from PlanningS.dbo.ProgExecuteTime() 
	 group by 
		case 
			when  xTime <= 12 then 'AM'
			else 'PM'
		end
	 order by xtime