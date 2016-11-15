CREATE function [dbo].[EOMDate] (@xdate datetime) 
	returns date 
	as
	begin
		return DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,@xdate),0))
	end