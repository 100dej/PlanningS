
CREATE function SQL_MasterPlanning_Step1 (@xcase int,@mat nvarchar(18),@NEng nvarchar(40))
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
	set @sql += 'select '
	set @sql += 
		case @xcase
			when 1 then  'DP.mcomp, DP.mplant_location, DP.mplant_salezone, '
			when 2 then  'DP.mplant_location, DP.mplant_salezone, '
			when 3 then  'DP.mcomp, DP.mplant_salezone, '
			when 4 then  'DP.mcomp, DP.mplant_location, '
			when 5 then  'DP.mcomp, '
			when 6 then  'DP.mplant_location, '
			when 7 then  'DP.mplant_salezone, '	
			when 8 then  ''	
		end
	set @sql += 'DP.mmatno, DP.mmateng,OPD.mshortname,OPD.mtype,OPD.mMCFix,DP.mnetwgt, DP.UR, DP.ATP, '   + char(13)
	set @sql += 'isnull(CGIT.QtyGIT,0) as QtyGIT,isnull(SALM.AvgPast,0) as AvgPast '   + char(13)
	set @sql += ',isnull(SA15D.AvgRolling,0) as AvgRolling,isnull(SAPD.[S/Day],0) as [S/Day] '   + char(13)
	set @sql += ',[Days Sale] = convert(decimal(18,0),DP.ATP/ case when isnull(SAPD.[S/Day],0)=0  then 1 else SAPD.[S/Day] end) '   + char(13)
	set @sql += ',isnull(OPD.mstandardCap,999999) as StdCap '   + char(13)
	set @sql += ',Utilize = convert(decimal(18,2),case when isnull(SAPD.[S/Day],0)<=0 then 0 else SAPD.[S/Day] end /isnull(OPD.mstandardCap,999999)) '  + char(13)
	set @sql += 'into ##tmpMasterPlanning_Step1 '  + Char(13)
	set @sql += 'from ##tmpGroup_Dataplanning DP '  + char(13)
	set @sql += 'left join plannings.dbo.tbm_190OtherProductDetails OPD'  + char(13) + '  on ' + char(13) + '  DP.mmatno=OPD.mmatno '  + char(13)
	set @sql += 'left join ##tmpConSohGIT CGIT '  + char(13) +  '  on '  + char(13)	
	set @sql += 
		case @xcase
				when 1 then '  DP.mcomp = CGIT.mcomp and DP.mplant_location= CGIT.mplant_location and DP.mplant_salezone=CGIT.mplant_salezone and '
				when 2 then '  DP.mplant_location= CGIT.mplant_location and DP.mplant_salezone=CGIT.mplant_salezone and '
				when 3 then '  DP.mcomp = CGIT.mcomp and DP.mplant_salezone=CGIT.mplant_salezone and '
				when 4 then '  DP.mcomp = CGIT.mcomp and DP.mplant_location= CGIT.mplant_location and '
				when 5 then '  DP.mcomp = CGIT.mcomp and '
				when 6 then '  DP.mplant_location= CGIT.mplant_location and '
				when 7 then '  DP.mplant_salezone=CGIT.mplant_salezone and '
				when 8 then ''
			end
	set @sql += 'DP.mmatno=CGIT.mmatno '  + char(13)
	set @sql += 'Left Join ##tmpSalesAvgLastM SALM ' + char(13) + '  on '  + char(13)
	set @sql += '  DP.mmatno = SALM.mmatno '
	set @sql +=
		case @xcase
			when 1 then 'and DP.mcomp=SALM.mcomp and DP.mplant_location=SALM.mplant_location and DP.mplant_salezone=SALM.mplant_salezone '
			when 2 then 'and DP.mplant_location=SALM.mplant_location and DP.mplant_salezone=SALM.mplant_salezone '
			when 3 then 'and DP.mcomp=SALM.mcomp and DP.mplant_salezone=SALM.mplant_salezone '
			when 4 then 'and DP.mcomp=SALM.mcomp and DP.mplant_location=SALM.mplant_location '
			when 5 then 'and DP.mcomp=SALM.mcomp '
			when 6 then 'and DP.mplant_location=SALM.mplant_location '
			when 7 then 'and DP.mplant_salezone=SALM.mplant_salezone '
			when 8 then ''
		end	
	set @sql += char(13) + 'Left Join ##tmpSalesAvg15D SA15D '  + char(13) +  '  on ' + char(13)
	set @sql += '  DP.mmatno = SA15D.mmatno '
	set @sql +=
		case @xcase
			when 1 then 'and DP.mcomp=SA15D.mcomp and DP.mplant_location=SA15D.mplant_location and DP.mplant_salezone=SA15D.mplant_salezone '
			when 2 then 'and DP.mplant_location=SA15D.mplant_location and DP.mplant_salezone=SA15D.mplant_salezone '
			when 3 then 'and DP.mcomp=SA15D.mcomp and DP.mplant_salezone=SA15D.mplant_salezone '
			when 4 then 'and DP.mcomp=SA15D.mcomp and DP.mplant_location=SA15D.mplant_location '
			when 5 then 'and DP.mcomp=SA15D.mcomp '
			when 6 then 'and DP.mplant_location=SA15D.mplant_location '
			when 7 then 'and DP.mplant_salezone=SA15D.mplant_salezone '
			when 8 then ''
		end
	set @sql +=  + char(13) + 'Left Join ##tmpSalesAvgPerDay SAPD '  + char(13) + '  on ' + char(13)
	set @sql += '  DP.mmatno = SAPD.mmatno '
	set @sql +=
		case @xcase
			when 1 then 'and DP.mcomp=SAPD.mcomp and DP.mplant_location=SAPD.mplant_location and DP.mplant_salezone=SAPD.mplant_salezone '
			when 2 then 'and DP.mplant_location=SAPD.mplant_location and DP.mplant_salezone=SAPD.mplant_salezone '
			when 3 then 'and DP.mcomp=SAPD.mcomp and DP.mplant_salezone=SAPD.mplant_salezone '
			when 4 then 'and DP.mcomp=SAPD.mcomp and DP.mplant_location=SAPD.mplant_location '
			when 5 then 'and DP.mcomp=SAPD.mcomp '
			when 6 then 'and DP.mplant_location=SAPD.mplant_location '
			when 7 then 'and DP.mplant_salezone=SAPD.mplant_salezone '
			when 8 then ''
		end		
return @sql
end