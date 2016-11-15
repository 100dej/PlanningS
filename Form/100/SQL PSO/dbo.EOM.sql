create function EOM (@xdate datetime) 
	returns int 
	as
	begin
		return day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,@xdate)+1,0)))
	end