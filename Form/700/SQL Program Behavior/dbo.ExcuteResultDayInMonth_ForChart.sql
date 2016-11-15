CREATE proc  ExcuteResultDayInMonth_ForChart (@Uname nvarchar(20)) as
	select * from plannings.dbo.ExcuteResultDayInMonth (@Uname) order by xdate