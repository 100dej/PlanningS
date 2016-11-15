
CREATE function SQL_ConSohGIT (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
returns nvarchar(Max)
as
begin
	declare @sql nvarchar(max),@sql1 nvarchar(max)
	set @sql = ''
	set @sql += 'select '
	set @sql +=
		case @xcase
			when 1 then 'mcomp = 87,PlantName as mplant_location,mplant_salezone = ''DOM'', '
			when 2 then 'PlantName as mplant_location,mplant_salezone = ''DOM'', '
			when 3 then 'mcomp = 87, mplant_salezone = ''DOM'', '
			when 4 then 'mcomp = 87, PlantName as mplant_location, '
			when 5 then 'mcomp = 87, '
			when 6 then 'PlantName as mplant_location, '
			when 7 then 'mplant_salezone = ''DOM'', '
			when 8 then ''	
		end
	set @sql += 'mmatno, SUM(SumOfQty) as QtyGIT '  + char(13)
	set @sql += 'into ##tmpConSohGIT '  + char(13)
	set @sql += 'from [172.18.8.188].npiconsohpd.dbo.vmsu101_consohgit '  + char(13)
	set @sql += 'group by mmatno '
	set @sql += 
	case when @xcase in (1,2,4,6) then ',PlantName '
			when @xcase in (3,5,7,8) then ''
	end
return @sql
end