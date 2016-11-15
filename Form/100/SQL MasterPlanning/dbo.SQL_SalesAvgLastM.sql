
CREATE function SQL_SalesAvgLastM (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
returns nvarchar(Max)
as
begin
	declare @sql nvarchar(max),@sql1 nvarchar(max)
	set @sql1 =
		case @xcase
			when 1 then ',mcomp, mplant_location,mplant_salezone '
			when 2 then ',mplant_location,mplant_salezone '
			when 3 then ',mcomp, mplant_salezone '
			when 4 then ',mcomp, mplant_location '
			when 5 then ',mcomp '
			when 6 then ',mplant_location '
			when 7 then ',mplant_salezone '	
			when 8 then ''
		end
	set @sql = ''
	set @sql += 'select mmatno '
	set @sql += @sql1
	set @sql += ',sum(LMavgQty) as AvgPast ' + Char(13)
	set @sql += ' into ##tmpSalesAvgLastM '  + Char(13)
	set @sql += 'from SalesAvgLastM ' + Char(13)
	set @sql += 'group by mmatno'
	set @sql += @sql1
return @sql
end