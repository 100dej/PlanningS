
--Select
CREATE Proc Select_Crosstab_PSO_X1
	(@Scase int,@Vcase int,@Ycase int,@Zcase int,@Sdate datetime , @Edate datetime,@mat nvarchar(18),@NEng nvarchar(40),@mproduct nvarchar(30),
	@mtype nvarchar(30),@comp nvarchar(2),@plant nvarchar(2),@zone nvarchar(3),@Mattype nvarchar(2),@VUname nvarchar(20),	@Vname nvarchar(30),@CrossYear int,
	@CheckReport nvarchar(max),@CheckColumn nvarchar(max)) 
as
	declare @sql nvarchar(max)
	set @sql = dbo.function_Crosstab_PSO_X1(@Scase,@Vcase,@Ycase,@Zcase,@Sdate,@Edate,@mat,@NEng,@mproduct,@mtype,@comp,@plant,@zone,@Mattype,@VUname,@Vname,@CrossYear,@CheckReport,@CheckColumn)
	select(@sql)