
CREATE function Select_User_Variant (@VUname nvarchar(20),@Vname nvarchar(30))
returns table
as
	return
		select a.mmatno,a.mmateng
		from DBWMS.dbo.vmsa140_product_basic A
		inner join (select * from tbl_103userFilterVariant where Uname = @VUname and Vname = @Vname )  B
		on A.mmatno Like B.mmatno + '%' and  A.mmateng  like '%'+B.mmateng+ '%'  
		and A.mmattype like '%' + B.mmattype and A.mprodh like B.mprodh + '%'