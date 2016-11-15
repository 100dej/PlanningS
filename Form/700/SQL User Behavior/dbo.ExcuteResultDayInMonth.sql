CREATE function [dbo].[ExcuteResultDayInMonth] (@Uname nvarchar(20))
returns table
as
	return
		with cte as (
		select  Uname,COUNT(xdate) as Success,0 as Error,sum(execUsedTime) As SuccessInSecond,0 as ErrorInSecond,0 as CountUser,
			cast(xdate as date) as xDate
		from plannings.dbo.tbl_101userExecMyProg
		where xdate between getdate() - 15 and getdate() 
		group by Uname,cast(xdate as date) 		
		union	 all
		select  Uname,0 as Success,COUNT(xdate) as Error,0 As SuccessInSecond,sum(execUsedTime) as ErrorInSecond,0 as CountUser,
			cast(xdate as date) as xDate
		from plannings.dbo.tbl_102userExecMyprogTimeout 
		where xdate between getdate() - 15 and getdate()
		group by Uname,cast(xdate as date) 		
		union all
		select distinct uname ,0 as Success,0 as Error,0 As SuccessInSecond,0 as ErrorInSecond,1 as CountUser,
			min(cast(xdate as date)) over (partition by uname) as xDate
		from plannings.dbo.tbl_101userExecMyProg		
		where xdate between getdate() - 15 and getdate()
		)
		
	select xDate,
		sum(success) as  Success, 
		sum(Error) as Error, 
		cast (sum(SuccessInSecond)/case when sum(success) = 0 then 1 else sum(success) end as int) as SuccessInSecond , 
		cast (sum(ErrorInSecond)/case when sum(error) = 0 then 1 else sum(error) end as int) as ErrorInSecond,
		count(cast(xdate as date)) as CUser
		from cte
		where  uname like @Uname + '%'
		group by xdate