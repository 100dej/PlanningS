
CREATE proc  ExecuteDayForChart(@m nvarchar(2),@y nvarchar(4))
as
	select top 15 *
	from plannings.dbo.ExecuteDay(@m,@y)
	order by SuccessDate desc