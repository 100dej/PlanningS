
CREATE function Table_DataPlanning (@mat nvarchar(18),@NEng nvarchar(40),@mproduct nvarchar(30),@mtype nvarchar(30))
returns table
as
	return
		select  SbNF.mcomp,SbNF.mplant_location,SbNF.mplant_salezone,SbNF.mmatno,Pb.mmateng,Pb.mnetwgt, SbNF.UR, SbNF.ATP,	SbNF.mrundate
		from StockBalancePipeNow SbNF				
			inner join DBWMS.dbo.vmsa140_product_basic Pb
				on SbNF.mmatno = pb.mmatno
			left join PlanningS.dbo.tbm_190OtherProductDetails OPD
				on SbNF.mmatno = OPD.mmatno		
		where  SbNF.mmatno like @mat + '%' and Pb.mmateng like '%' + @NEng + '%' and pb.mflagdel <> 'x'  
		and case when isnull(OPD.mtype,'') = '' then  '00NonGroup' else OPD.mtype end like  + @mtype + '%' 
		and case when isnull(OPD.mproduct,'') = '' then  '00NonGroup' else OPD.mproduct end like  + @mproduct + '%' 
		union all
		select  SbNP.mcomp,SbNP.mplant_location,SbNP.mplant_salezone,SbNP.mmatno,Pb.mmateng ,Pb.mnetwgt,SbNP.UR, SbNP.ATP,SbNP.mrundate
		from StockBalanceProfileNow SbNP				
			inner join DBWMS.dbo.vmsa140_product_basic Pb
				on SbNP.mmatno = pb.mmatno
			left join PlanningS.dbo.tbm_190OtherProductDetails OPD
				on SbNP.mmatno = OPD.mmatno
		where   SbNP.mmatno like @mat + '%' and Pb.mmateng like '%' + @NEng + '%' and pb.mflagdel <> 'x' 
		and case when isnull(OPD.mtype,'') = '' then  '00NonGroup' else OPD.mtype end like  + @mtype + '%' 
		and case when isnull(OPD.mproduct,'') = '' then  '00NonGroup' else OPD.mproduct end like  + @mproduct + '%'