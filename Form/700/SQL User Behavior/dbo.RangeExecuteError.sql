
CREATE function RangeExecuteError (@Uname nvarchar(20))
returns table
as
	return
		select 
			case 
				when ExecUsedTime < 6 then ExecUsedTime
				when cast(ExecUsedTime/10 as int)*10 > 50 then 9999 
				else (cast(ExecUsedTime/10 as int)*10)+10 
				end as xRange, 
			0 as SuccessCount, 1 as ErrorCount
		from plannings.dbo.tbl_102userExecMyprogTimeout
		where Uname like @Uname + '%'