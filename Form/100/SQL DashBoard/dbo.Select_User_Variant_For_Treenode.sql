
CREATE function Select_User_Variant_For_Treenode (@VUname nvarchar(20),@Vname nvarchar(30))
returns table
as
	return
		select b.mBusiness,b.mproduct,b.mtype,a.mmateng
		from PlanningS.dbo.Select_User_Variant (@VUname,@Vname) A
		inner join plannings.dbo.tbm_190OtherProductDetails B
		on a.mmatno = b.mmatno