﻿
CREATE function SQL_MasterPlanning (@Scase int,@VUname nvarchar(20),@Vname nvarchar(30))
returns nvarchar(Max)
as
begin
	declare @sql nvarchar(max)	
		set @sql +=
			case @Scase
				when 1 then ''
				when 2 then  'where cte.mmatno in (select distinct mmatno from Plannings.dbo.Select_User_Variant('''+ @VUname + ''' , ''' + @Vname + ''')) '																	
			end
return @sql
end