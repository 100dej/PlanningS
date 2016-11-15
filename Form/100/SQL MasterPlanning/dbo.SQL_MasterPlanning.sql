
CREATE function SQL_MasterPlanning (@Scase int,@VUname nvarchar(20),@Vname nvarchar(30))
returns nvarchar(Max)
as
begin
	declare @sql nvarchar(max)			set @sql = 'with cte as ( '  + char(13)			set @sql += ' select *, '+ char(13)			set @sql += '    Step1.[S/Day] * RFG.[Days Sale Min] as MinStock, '+ char(13)			set @sql += '    Step1.[S/Day] * RFG.[Days Sale Max] as MaxStock ' + char(13)			set @sql += ' from ##tmpMasterPlanning_Step1 Step1,tbm_170RangeFG RFG ' + char(13)			set @sql += ' where Step1.Utilize >= RFG.[Percent Min] and Step1.Utilize < RFG.[Percent Max] '+ char(13)			set @sql += ' ) ' + char(13)			set @sql += 'Select cte.*, ' + char(13)			set @sql += 'Request = case when cte.ATP < cte.MaxStock then cte.MaxStock - cte.ATP else 0 end, ' + char(13)			set @sql += 'OverMax = case when cte.ATP > cte.MaxStock then cte.ATP - cte.MaxStock  else 0 end, ' + char(13)			set @sql += '[Days Product] = case ' + char(13)			set @sql += 'when '+ char(13)			set @sql += 'convert(decimal(18,0), ' + char(13)			set @sql += 'case when cte.ATP < cte.MaxStock then cte.MaxStock - cte.ATP else 0 end ' + char(13)			set @sql += '/ ' + char(13)			set @sql += '(case when cte.StdCap-cte.[S/Day] = 0 then 1 else cte.StdCap-cte.[S/Day] end )) ' + char(13)			set @sql += '<0 ' + char(13)			set @sql += 'then 99999 ' + char(13)			set @sql += 'else ' + char(13)			set @sql += 'convert(decimal(18,0), ' + char(13)			set @sql += 'case when cte.ATP < cte.MaxStock then cte.MaxStock - cte.ATP else 0 end ' + char(13)			set @sql += '/ ' + char(13)			set @sql += '(case when cte.StdCap-cte.[S/Day] = 0 then 1 else cte.StdCap-cte.[S/Day] end )) ' + char(13)			set @sql += 'end ' + char(13)			set @sql += 'from cte ' + char(13)	
		set @sql +=
			case @Scase
				when 1 then ''
				when 2 then  'where cte.mmatno in (select distinct mmatno from Plannings.dbo.Select_User_Variant('''+ @VUname + ''' , ''' + @Vname + ''')) '																	
			end
return @sql
end