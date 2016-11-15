
CREATE function SQL_Group_Dataplanning (@xcase int,@mat nvarchar(18),@NEng nvarchar(40),@mproduct nvarchar(30),@mtype nvarchar(30))
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
	set @sql += 'select mmatno'
	set @sql += @sql1	
	set @sql += ',mmateng,mnetwgt ,sum(UR) as UR, sum(ATP) as ATP ' + char(13)
	set @sql += 'into ##tmpGroup_Dataplanning ' + char(13)
	set @sql += 'from  plannings.dbo.Table_DataPlanning(''' + @mat + ''',''' + @NEng + ''',''' + @mproduct + ''',''' + @mtype + ''')'  + char(13)
	--set @sql += 
	--	case when @xcase in (1,2,3,7) then ''		
	--			when @xcase in (4,5,6,8) then ' where mplant_salezone = ''DOM'''	 + char(13)
	--	end
	set @sql += 'group by mmatno,mmateng,mnetwgt '
	set @sql += @sql1
return @sql
end