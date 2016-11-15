
CREATE function Function_Crosstab_PSO_X1
	(@Scase int,@Vcase int,@Ycase int,@Zcase int,@Sdate datetime , @Edate datetime,@mat nvarchar(18),@NEng nvarchar(40),@mproduct nvarchar(30),@mtype nvarchar(30),
	@comp nvarchar(2),@plant nvarchar(2),@zone nvarchar(3),@Mattype nvarchar(2),@VUname nvarchar(20),@Vname nvarchar(30),@CrossYear int,@CheckReport nvarchar(max),@CheckColumn nvarchar(max)) 
returns nvarchar(max)
as
begin
	declare @fldname nvarchar(10),@sql nvarchar(max), @Sql1 nvarchar(max),@Sql3 nvarchar(max),@Sql4 nvarchar(max)
	declare @Tcase int,@EReport int,@SReport int,@Cdate datetime,@d int,@m int , @y int
	declare @Xcase int,@EField int, @SField int	

	select @EField = count(*) from plannings.dbo.splitstring(@CheckColumn) where name != ''
	set @SField = 1
	set @Sql1 = ''
	set @Sql3 = ''
	set @Sql4 = ''
	while @SField <= @EField
	begin
		select @Xcase = Name  from plannings.dbo.splitstring(@CheckColumn) where xid = @SField and name != ''
		set @sql1 +=
			case @Xcase
				when 1 then ''			
				when 3 then ',pb.mprodhl1 '
				when 4 then ',pb.mprodhl2 '
				when 5 then ',pb.mprodhl3 '
				when 6 then ',pb.mprodhl4 '
				when 7 then ',pb.mprodhl5 '
				when 8 then ',pb.mprodh '
				when 9 then ', case when pd.mtype = '''' then  ''00NonGroup'' else pd.mtype end as mtype '
				when 10 then ',sh.mmatno, pb.mmateng,pd.mShortName '
				when 11 then ',pd.mboxType '
				when 12 then ',pd.mboxSize '
				when 13 then ',Sh.mcomp '
				when 14 then ',sh.mplant_location '
				when 15 then ',sh.mplant_salezone '
				when 16 then ',pb.mmattype '
				when 17 then ',pd.mMCFix '
				when 18 then ',pd.mBusiness '
				when 19 then ',pd.mProduct '
				when 20 then ',pd.mProductType '
				when 21 then ',pd.mColor '
				when 22 then ',pd.mSpec '
				when 23 then ',pb.mnetwgt '
			end			
		set @sql3 +=
			case @Xcase
				when 1 then ''			
				when 3 then ',Cte.mprodhl1 '
				when 4 then ',Cte.mprodhl2 '
				when 5 then ',Cte.mprodhl3 '
				when 6 then ',Cte.mprodhl4 '
				when 7 then ',Cte.mprodhl5 '
				when 8 then ',Cte.mprodh '
				when 9 then ',Cte.mtype '
				when 10 then ',Cte.mmatno, Cte.mmateng,Cte.mShortName '
				when 11 then ',Cte.mboxType '
				when 12 then ',Cte.mboxSize '
				when 13 then ',Cte.mcomp '
				when 14 then ',Cte.mplant_location '
				when 15 then ',Cte.mplant_salezone '
				when 16 then ',Cte.mmattype '
				when 17 then ',Cte.mMCFix '
				when 18 then ',Cte.mBusiness '
				when 19 then ',Cte.mProduct '
				when 20 then ',Cte.mProductType '
				when 21 then ',Cte.mColor '
				when 22 then ',Cte.mSpec '
				when 23 then ',Cte.mnetwgt '
			end
		set @sql4 +=
			case @Xcase
				when 1 then ''			
				when 3 then ',pb.mprodhl1 '
				when 4 then ',pb.mprodhl2 '
				when 5 then ',pb.mprodhl3 '
				when 6 then ',pb.mprodhl4 '
				when 7 then ',pb.mprodhl5 '
				when 8 then ',pb.mprodh '
				when 9 then ',pd.mtype '
				when 10 then ',sh.mmatno, pb.mmateng,pd.mShortName '
				when 11 then ',pd.mboxType '
				when 12 then ',pd.mboxSize '
				when 13 then ',Sh.mcomp '
				when 14 then ',sh.mplant_location '
				when 15 then ',sh.mplant_salezone '
				when 16 then ',pb.mmattype '
				when 17 then ',pd.mMCFix '
				when 18 then ',pd.mBusiness '
				when 19 then ',pd.mProduct '
				when 20 then ',pd.mProductType '
				when 21 then ',pd.mColor '
				when 22 then ',pd.mSpec '
				when 23 then ',pb.mnetwgt '
			end
		set @SField += 1
	end

	select @EReport = count(*) from plannings.dbo.splitstring(@CheckReport) where name != ''
	set @SReport = 1

	set @sql = 'SET LOCK_TIMEOUT 60000' + char(13) + ';with cte as (' + char(13)
	while @SReport <= @EReport
	begin
		select @Tcase = Name  from plannings.dbo.splitstring(@CheckReport) where xid = @SReport	 and name != ''
		set @sql += 			
			case when @Ycase = 1 then 'select sh.caldate,'
					when @Ycase in (2,4) then 'select sh.M, sh.Y,'
					when @Ycase = 3 then 'select sh.Y,'
			end			
		set @sql += '''' + @mat + ''' as GrpMat, '
		set @sql +=
			case @Tcase
				when 1 then '''01.Actual Sale'''
				when 2 then '''02.Sale Orders'''
				when 3 then '''03.Production'''
				when 4 then '''04.Inhouse Used'''
				when 5 then '''05.Orders In Hand'''
				when 6 then '''06.Back Order'''
				when 7 then '''07.Stock UR'''
				when 8 then '''08.Stock ATP'''
				when 9 then '''09.Goods Issue'''
				when 10 then '''10.Stock ATP ex BO'''
				when 11 then '''11.AvgSLastM'''
				when 12 then '''12.AvgSRolling15Days'''
				when 13 then '''13.AvgSales'''
				when 14 then '''14.Sales Orders Expired'''
				when 15 then '''15.DaysSale'''
			end
		set @sql += ' as Report '
		set @sql += 
			case @CrossYear
				when 0 then ''
				when 1 then 
					case when @ycase =1 then ',year(sh.caldate) as xYear '
						else ',sh.y as xYear '
					end
			end 
		set @sql += @sql1 + char(13)
		set @sql +=
			case when @Tcase = 15 then ', '
					when @Zcase = 1 then ','
					else  ',sum('
			end
		set @sql +=
			case when @Zcase in (2,4,5) then
						case when @Tcase in (1,2,3,4,14)	then 'isnull(Sh.Qty,0)'
								when @Tcase = 5				then '(isnull(Sh.UR,0)-isnull(Sh.ATP,0))'
								when @Tcase in (6,8,10)	then 'isnull(Sh.ATP,0)'								
								when @Tcase = 7				then 'isnull(Sh.UR,0)'
								when @Tcase = 11			then 'isnull(Sh.AVGSalesLastMonth,0)'
								when @Tcase = 12			then 'isnull(Sh.AVGSalesRolling,0)'
								when @Tcase = 13			then 'isnull(Sh.AVGSales,0)'
								when @Tcase = 15			then 'cast(sum(isnull(Sh.ATP,0))/case when sum(isnull(Sh.AVGSales,1)) = 0 then 1 else sum(isnull(Sh.AVGSales,1)) end as int) '
						end
					when @Zcase = 3 then
						case when @Tcase in (1,2,3,4,14)	then 'isnull(Sh.We,0)/1000'
								when @Tcase = 5				then '(isnull(Sh.UR_We,0)-isnull(Sh.ATP_We,0))/1000'
								when @Tcase in (6,8,10)	then 'isnull(Sh.ATP_We,0)/1000'								
								when @Tcase = 7				then 'isnull(Sh.UR_We,0)/1000'
								when @Tcase = 11			then 'isnull(Sh.AVGSalesLastMonth_we,0)/1000'
								when @Tcase = 12			then 'isnull(Sh.AVGSalesRolling_we,0)/1000'
								when @Tcase = 13			then 'isnull(Sh.AVGSales_we,0)/1000'
								when @Tcase = 15			then 'cast(sum(isnull(Sh.ATP,0))/case when sum(isnull(Sh.AVGSales,1)) = 0 then 1 else sum(isnull(Sh.AVGSales,1)) end as int) '
						end
					when @Zcase = 1 then
						case when @Tcase in (1,2,3,4,14)	then 'sum(isnull(Sh.Qty,0)) as Pcs,sum(isnull(Sh.We,0))/1000 as Tons,0 as DaysSale
											,cast(sum(isnull(Sh.Qty/CUOM.BaseUnitQty,0)) as int) as Box,cast(sum(isnull(Sh.Qty*pb.mvolume,0)) as int) as CCM
											,sum(isnull(Sh.Qty,0)/pd.mStandardCap)'
								when @Tcase = 5				then 'sum((isnull(Sh.UR,0)-isnull(Sh.ATP,0))) as Pcs ,sum((isnull(Sh.UR_We,0)-isnull(Sh.ATP_We,0)))/1000 as Tons,0 as DaysSale
											,cast(sum((isnull(Sh.UR,0)-isnull(Sh.ATP,0))/CUOM.BaseUnitQty) as int) as Box,cast(sum((isnull(Sh.UR,0)-isnull(Sh.ATP,0))*pb.mvolume) as int) as CCM
											,sum((isnull(Sh.UR,0)-isnull(Sh.ATP,0))/pd.mStandardCap)'
								when @Tcase in (6,8,10)	then 'sum(isnull(Sh.ATP,0)) as Pcs,sum(isnull(Sh.ATP_We,0))/1000 as Tons,0 as DaysSale
											,cast(sum(isnull(Sh.ATP/CUOM.BaseUnitQty,0)) as int) as Box,cast(sum(isnull(Sh.ATP*pb.mvolume,0)) as int) as CCM
											,sum(isnull(Sh.ATP/pd.mStandardCap,0))'
								when @Tcase = 7				then 'sum(isnull(Sh.UR,0)) as Pcs,sum(isnull(Sh.UR_We,0))/1000 as Tons,0 as DaysSale
											,cast(sum(isnull(Sh.UR/CUOM.BaseUnitQty,0)) as int) as Box,cast(sum(isnull(Sh.UR*pb.mvolume,0)) as int) as CCM
											,sum(isnull(Sh.UR/pd.mStandardCap,0))'
								when @Tcase = 11			then 'sum(isnull(Sh.AVGSalesLastMonth,0)) as Pcs,sum(isnull(Sh.AVGSalesLastMonth_We,0))/1000 as Tons,0 as DaysSale
											,cast(sum(isnull(Sh.AVGSalesLastMonth/CUOM.BaseUnitQty,0)) as int) as Box,cast(sum(isnull(Sh.AVGSalesLastMonth*pb.mvolume,0)) as int) as CCM
											,sum(isnull(Sh.AVGSalesLastMonth/pd.mStandardCap,0))'
								when @Tcase = 12			then 'sum(isnull(Sh.AVGSalesRolling,0)) as Pcs,sum(isnull(Sh.AVGSalesRolling_We,0))/1000 as Tons,0 as DaysSale
											,cast(sum(isnull(Sh.AVGSalesRolling/CUOM.BaseUnitQty,0)) as int) as Box,cast(sum(isnull(Sh.AVGSalesRolling*pb.mvolume,0)) as int) as CCM
											,sum(isnull(Sh.AVGSalesRolling/pd.mStandardCap,0))'
								when @Tcase = 13			then 'sum(isnull(Sh.AVGSales,0)) as Pcs,sum(isnull(Sh.AVGSales_We,0))/1000 as Tons,0 as DaysSale
											,cast(sum(isnull(Sh.AVGSales/CUOM.BaseUnitQty,0)) as int) as Box,cast(sum(isnull(Sh.AVGSales*pb.mvolume,0)) as int) as CCM
											,sum(isnull(Sh.AVGSales/pd.mStandardCap,0))'
								when @Tcase = 15			then '0 as Pcs,0 as Tons
											,cast(sum(isnull(Sh.ATP,0))/case when sum(isnull(Sh.AVGSales,1)) = 0 then 1 else sum(isnull(Sh.AVGSales,1)) end as int) as DaysSale,0 as Box,0 as CCM,0'
						end
						+	case @Ycase
								when 1 then ''
								when 2 then '/case when sh.m = month(getdate()) and sh.y = year(getdate()) 
											then day(getdate())-1 
											else plannings.dbo.EOM(datepart(dy,convert(nvarchar(4),sh.y)+''/''+convert(nvarchar(2),sh.m)+''/1'')) end'
								when 3 then '/case when sh.y = year(getdate()) 
											then datepart(dy,getdate()-1) 
											else datepart(dy,convert(nvarchar(4),cte.y)+''/12/31'') end'
								when 4 then '/case when sh.m = month(getdate()) and sh.y = year(getdate()) 
											then day(getdate())-1 
											else plannings.dbo.EOM(datepart(dy,convert(nvarchar(4),sh.y)+''/''+convert(nvarchar(2),sh.m)+''/1'')) end'
							end
						+ ' as Utilize '
			end
		set @sql +=
			case when @Zcase in (1,2,3) then '' 
					when @Zcase = 4		then '/pd.mStandardCap'
					when @Zcase = 5		then '/CUOM.BaseUnitQty'
			end
		set @sql += 
			case when @Tcase = 15 and @Zcase !=1 then ' As Qty ' + Char(13)
					when @Zcase = 1 then '' + Char(13)
					else  ') As Qty ' + Char(13)
			end
		set @sql +=
			case when @Tcase = 1 then 'from plannings.dbo.SalesHistory Sh '
				when @Tcase = 2 then 'from plannings.dbo.SalesOrderHistory Sh '
				when @Tcase = 3 then 'from plannings.dbo.ProductHistory Sh '
				when @Tcase = 4 then 'from plannings.dbo.InhouseUsed Sh '
				when @Tcase in (5,7,8,11,12,13,15) then 'from plannings.dbo.StockBalanceHistory Sh '
				when @Tcase = 6 then 'from plannings.dbo.stockbackorderhistory Sh '	
				when @Tcase = 10 then 'from plannings.dbo.StockATPHistory Sh '
				when @Tcase = 14 then 'from plannings.dbo.SalesOrderDeleteHistory Sh '
			end
		set @sql += char (13) + 'inner join dbwms.dbo.vmsa140_product_basic 	 pb ' + char(13) 
		set @sql += 'on sh.mmatno = pb.mmatno'
		set @sql += char(13) + 'left join  plannings.dbo.tbm_190OtherProductDetails Pd'+ char(13) + 'on sh.mmatno = pd.mmatno' + char(13)
		set @sql +=
			case 	when @zcase In (1,5) then 'left join (select  * from [172.18.8.188].npiconsohpd.dbo.tbi_UOM 
									where UOM not in (''PC'',''PAC'',''KG'') and ' + 
									case @Scase
											when 1 then ' productcode like ''' + @mat + '%'''														
											when 2 then ' productcode in (select distinct  mmatno from Plannings.dbo.Select_User_Variant('''+ @VUname + ''' , ''' + @Vname + ''')) '
										end	
									+ ') CUOM ' + char(13) + 'on sh.mmatno = CUOM.productcode' + char(13)
					else ''
			end
		set @sql +=
			case when @Tcase in (1,2,3,4,14) then 'where sh.caldate between ''' + CONVERT(nvarchar(15),@Sdate,101) + ''' 	and ''' +  CONVERT(nvarchar(15),@Edate,101) + ''' and '
					when @Tcase in (5,6,7,8,10,11,12,13,15) then
						case when @Ycase = 1		then 'where sh.caldate between ''' + CONVERT(nvarchar(15),@Sdate,101) + ''' 	and ''' +  CONVERT(nvarchar(15),@Edate,101) + ''' and '
								when @Ycase in (2,4)	then 'inner join (select caldate from plannings.dbo.Calendar where ' +
									case @Vcase
										when 1 then 'isbom '
										when 2 then 'iseom '
									end
									+ '=''x'' and 
											caldate between ''' + CONVERT(nvarchar(15),@Sdate,101) + ''' 	and ''' +  CONVERT(nvarchar(15),@Edate,101) + '''
											 or  caldate = case when year(''' + CONVERT(nvarchar(15),@Edate,101)  + ''') != year(getdate()) then convert(date,GETDATE())  else  convert(date,GETDATE()-1) end
											  ) Cl on Sh.caldate=Cl.caldate where ' + char(13)
								when @Ycase = 3	then
									case @Vcase
										when 1 then 'where day(sh.caldate) = 1 and sh.m = 1 and ' + char(13)
										when 2 then 'where day(sh.caldate) = case when sh.y = year(getdate()) then day(getdate())-1 else 31 end 
															 and sh.m = case when sh.y = year(getdate()) then month(getdate()) else 12 end and ' + char(13)				
									end
						end
			end
		set @sql +=
			case @Scase
				when 1 then ' sh.mmatno like ''' + @mat + '%'' 
							and pb.mmateng like ''%' + @NEng + '%'' and case when pd.mtype = '''' then  ''00NonGroup'' else pd.mtype end like ''' + @mtype + '%''
							 and pd.mproduct like ''' + @mproduct + '%'' and pb.mmattype like ''' + @Mattype + '%'' ' + char(13)
				when 2 then 'sh.mmatno in (select distinct  mmatno from Plannings.dbo.Select_User_Variant('''+ @VUname + ''' , ''' + @Vname + ''')) '
			end		
		set @sql +=
			case 	when @Tcase in (2,5,6,10,14,11,12,13,15)		then ' and pb.mflagdel <> ''X'' ' + char(13)
					else ''
			end
		set @sql +=  char(13)
		set @sql +=  'group by '
		set @sql +=			
			case when @Ycase = 1 then 'sh.caldate '
					when @Ycase in (2,4) then 'sh.M, sh.Y '
					when @Ycase = 3 then 'sh.Y '
			end
		set @sql +=
			case when @Tcase = 6	then   ', sh.mmatno '
					else	''
			end
		set @sql += @Sql4
		set @sql += char(13)
		set @sql +=
			case when @Tcase = 6 then 'Having sum(isnull(Sh.ATP,0))<0 ' + Char(13)						
					else ''
			end
		set @sql +=
			case when @EReport <= @SReport then ''
					when @EReport >= @SReport then 'Union all ' + char(13)
			end		
		set @SReport += 1
	end
	set @sql += ')' + char(13)		
	set @sql += 
		case when @Zcase = 1 then 'select * ' 
			else 'select  Cte.Report,Cte.GrpMat  '
		end
	set @sql +=
		case when @Zcase = 1 then 'from cte '
			else
				case @CrossYear 
					when 0 then ''
					when 1 then ',Cte.xYear '
				end
		end
	set @sql += 
		case when @Zcase = 1 then ''
			else @Sql3
		end
	if @Crossyear = 0
	begin
		set @Cdate= @Sdate
		while @Cdate <= @Edate
		begin
			select @d=DAY(@Cdate), @m = MONTH(@Cdate) ,@y = YEAR(@Cdate)
			set @fldname =				
					case @ycase
						when 1 then	 convert(nvarchar(2),@d) +'/'+ left(datename(mm,@cdate),3) + '/' + right(convert(nvarchar(4),@y),2)
						when 2 then	 left(datename(mm,@cdate),3) + '/' + right(convert(nvarchar(4),@y),4)
						when 3 then	 right(convert(nvarchar(4),@y),4)
						when 4 then	 left(datename(mm,@cdate),3) + '/' + right(convert(nvarchar(4),@y),4)
					end
			set @sql += char(13)
			set @sql +=
				case when @Zcase = 1 then ''
					else
						case @ycase
							when 1 then ',Sum(case when day(Cte.caldate) = ' + CONVERT(nvarchar(2),@d) + ' and month(Cte.caldate) = ' + convert(nvarchar(2),@m) + ' and year(Cte.caldate) = ' + convert(nvarchar(4),@y)
							when 2 then ',Sum(case when cte.m = ' + convert(nvarchar(2),@m) + ' and cte.y = ' + convert(nvarchar(4),@y)
							when 3 then ',Sum(case when cte.y = ' + convert(nvarchar(4),@y)
							when 4 then ',Sum(case when cte.m = ' + convert(nvarchar(2),@m) + ' and cte.y = ' + convert(nvarchar(4),@y)
						end
				end
			set @sql +=
				case when @Zcase = 1 then ''
					else ' then convert(decimal (18,3),Cte.Qty '
				end
			set @sql +=
				case 	when @Zcase = 4 then
							case @Ycase
								when 1 then ''
								when 2 then '/case when cte.m = month(getdate()) and cte.y = year(getdate()) then day(getdate())-1 else plannings.dbo.EOM(datepart(dy,convert(nvarchar(4),cte.y)+''/''+convert(nvarchar(2),cte.m)+''/1'')) end'
								when 3 then '/case when cte.y  = year(getdate()) then datepart(dy,getdate()-1) else datepart(dy,convert(nvarchar(4),year(Cte.y))+''/12/31'') end'
								when 4 then '/case when cte.m = month(getdate()) and cte.y = year(getdate()) then day(getdate())-1 else plannings.dbo.EOM(datepart(dy,convert(nvarchar(4),cte.y)+''/''+convert(nvarchar(2),cte.m)+''/1'')) end'
							end
						else ''
				end
			set @sql +=
				case when @Zcase = 1 then ''
					else ') else 0 end) as [' + @fldname + '] '			
				end
			select @Cdate =
				case @ycase
					when 1 then 	DATEADD(DD,1,@Cdate)
					when 2 then 	DATEADD(MM,1,@Cdate)
					when 3 then 	DATEADD(YY,1,@Cdate)
					when 4 then 	DATEADD(YY,1,@Cdate)
				end
		end
	end		
	else
	begin
		set @Cdate= @Sdate
		while @Cdate <= @Edate
		begin
			select @d=DAY(@Cdate), @m = MONTH(@Cdate) ,@y = YEAR(@Cdate)
			set @fldname =				
				case @ycase
					when 1 then	 convert(nvarchar(2),@d) +'/'+ left(datename(mm,@cdate),3) 
					when 2 then	 left(datename(mm,@cdate),3) 
					when 3 then	 'Year'
					when 4 then	 left(datename(mm,@cdate),3)
				end
			set @sql += char(13)
			set @sql +=
				case when @Zcase = 1 then ''
					else			
						case @ycase
							when 1 then ',Sum(case when day(Cte.caldate) = ' + CONVERT(nvarchar(2),@d) + ' and month(Cte.caldate) = ' + convert(nvarchar(2),@m) + ' then convert(decimal (18,3),Cte.Qty '
							when 2 then ',Sum(case when cte.m = ' + convert(nvarchar(2),@m) + ' then convert(decimal (18,3),Cte.Qty '
							when 3 then ',Sum(convert(decimal (18,3),Cte.Qty '
							when 4 then ',Sum(case when cte.m = ' + convert(nvarchar(2),@m) + ' then convert(decimal (18,3),Cte.Qty '
						end
				end						
			set @sql +=
			case when @Zcase in (1,2,3,5) then ''
					when @Zcase = 4 then
						case @Ycase
							when 1 then ''
							when 2 then '/case when cte.m = month(getdate()) and cte.y = year(getdate()) then day(getdate())-1 else plannings.dbo.EOM(datepart(dy,convert(nvarchar(4),cte.y)+''/''+convert(nvarchar(2),cte.m)+''/1'')) end'
							when 3 then '/case when cte.y = year(getdate()) then datepart(dy,getdate()-1) else datepart(dy,convert(nvarchar(4),cte.y)+''/12/31'') end'
							when 4 then '/case when cte.m = month(getdate()) and cte.y = year(getdate()) then day(getdate())-1 else plannings.dbo.EOM(datepart(dy,convert(nvarchar(4),cte.y)+''/''+convert(nvarchar(2),cte.m)+''/1'')) end'
						end
			end
			set @sql +=
				case when @Zcase = 1 then ''
					else
						case when @ycase in (1,2,4) then ') else 0 end) as [' + @fldname + '] '
							else '))  as [' + @fldname + '] '
						end
				end
			select @Cdate =
				case @ycase
					when 1 then 	DATEADD(DD,1,@Cdate)
					when 2 then 	DATEADD(MM,1,@Cdate)
					when 3 then 	DATEADD(YY,1,@Cdate)
					when 4 then 	DATEADD(YY,1,@Cdate)
				end
			if (@ycase = 4 or @ycase = 3)  and year(@Cdate) > year(@Sdate)
				break
			else if (@ycase = 1 or @ycase = 2) and (month(@Cdate) >month(@Edate) or year(@Cdate) > year(@Sdate))
				break
			else
				continue
		end	
	end
	set @sql +=
		case when @Zcase in (2,3,5)	then  char(13) + ',case 
				when cte.report in (''01.Actual Sale'',''02.Sale Orders'',''03.Production'',''04.Inhouse Used'',''09.Goods Issue'',''14.Sales Orders Expired'')  
					then Sum(convert(decimal(18,3),isnull(Cte.Qty,0)))
				when cte.report in (''06.Back Order'')  
					then count(convert(decimal(18,3),isnull(Cte.Qty,0))) end as Total '			 
			else  ''
				end	
	set @sql += char(13)	
	set @sql += 
		case when @Zcase = 1 then ''
			else 'from Cte' + char(13) +  'group by Cte.Report,Cte.GrpMat ' 	
		end
	set @sql +=
		case @CrossYear 
			when 0 then ''
			when 1 then ',Cte.xYear '
		end
	set @sql += 
		case when @Zcase = 1 then ''
			else @Sql3	  + char(13) + 'order by Cte.Report'	
		end
return @sql
end