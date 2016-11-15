create function ExecuteInMonth(@m nvarchar(2),@y nvarchar(4))
returns table
as
	return
	with cte 
	as (
		select  Uname,COUNT(xdate) as Success,0 as Error,SUM(execUsedTime) As SuccessInSecond,0 as ErrorInSecond,0 as CountUser,
			xdate
			from plannings.dbo.tbl_101userExecMyProg
			group by Uname,xdate
		union	
		select  Uname,0 as Success,COUNT(xdate) as Error,0 As SuccessInSecond,SUM(execUsedTime) as ErrorInSecond,0 as CountUser,
			xdate
			from plannings.dbo.tbl_102userExecMyprogTimeout 
			group by Uname,xdate
		union
		select distinct uname ,0 as Success,0 as Error,0 As SuccessInSecond,0 as ErrorInSecond,1 as CountUser,
			min(cast(xdate as date)) over (partition by uname) as xDate
			from plannings.dbo.tbl_101userExecMyProg						
	)
	select Uname,convert(nvarchar(4),year(xdate)) + '-' +  REPLICATE('0',2-len(month(xdate))) +  convert(nvarchar(2),month(xdate))  as MY,
		sum(Success) as Success, sum(error) as Error ,SUM(SuccessInSecond) as SuccessInSecond, 
		SUM(ErrorInSecond) as ErrorInSecond,SUM(CountUser) as CountUser
	from cte
	where month(xdate) like '%' + @m and YEAR(xdate) like '%' + @y
	group by uname,convert(nvarchar(4),year(xdate)) + '-' +  REPLICATE('0',2-len(month(xdate))) +  convert(nvarchar(2),month(xdate))