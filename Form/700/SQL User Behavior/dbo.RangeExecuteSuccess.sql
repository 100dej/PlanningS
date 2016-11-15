CREATE function RangeExecuteSuccess (@Uname nvarchar(20))
returns table
as
	return
		select 
			case 
				when ExecUsedTime < 6 then ExecUsedTime
				when	 cast(ExecUsedTime/10 as int)*10 > 50 then 9999 
				else (cast(ExecUsedTime/10 as int)*10)+10 
				end as xRange, 
			1 as SuccessCount, 0 as ErrorCount
		from plannings.dbo.tbl_101userExecMyProg
		where Uname like  @Uname + '%'