CREATE proc UserBehavior (@X1 nvarchar(10),@X2 nvarchar(50)) as
declare @S1 nvarchar(max), @S2 nvarchar(max), @D1 datetime, @I1 int	
set @S1 = Char(13) + Char(13) +  '     เริ่มเก็บข้อมูล' + Char(13)
	select @D1 =  min(xdate) from tbl_100userLoginMyProg where Pname = @X2
set @S1 += '          ตั้งแต่วันที่ ' + convert(nvarchar(20),@D1)
set @S1 += ' (ผ่านมาแล้ว ' + convert(nvarchar(20),datediff(D,@D1,GETDATE())) + ' วัน)' + Char(13) + Char(13)
set @S1 += '     เรียกใช้ Program ครั้งแรก' + Char(13)
	select @D1 =  min(xdate) from tbl_100userLoginMyProg where Pname = @X2 and Uname = @X1
set @S1 += '          เมื่อวันที่ ' + convert(nvarchar(20),@D1)
set @S1 += ' (ผ่านมาแล้ว ' + convert(nvarchar(20),datediff(D,@D1,GETDATE())) + ' วัน)' + Char(13) + Char(13)
set @S1 += '     เรียกใช้ Program ล่าสุด' + Char(13)
	select @D1 =  max(xdate) from tbl_100userLoginMyProg where Pname = @X2 and Uname = @X1
set @S1 += '          เมื่อวันที่ ' +  convert(nvarchar(20),@D1) + ' (ผ่านมาแล้ว ' + convert(nvarchar(20),datediff(D,@D1,GETDATE())) + ' วัน)' + Char(13) + Char(13)
set @S1 += '     เรียกใช้ Program' + Char(13)
	select @I1 = count(Uname) from tbl_100userLoginMyProg where Pname = @X2 and Uname = @X1
set @S1 += '          รวมทั้งสิ้น ' + convert(nvarchar(20),@I1) + ' ครั้ง' + CHAR(13)
	select @I1 = max(A.CUname) from
		(Select count(Uname) as CUname,convert(date,xdate,105) as xDate from tbl_100userLoginMyProg where Pname = @X2 and Uname = @X1 group by convert(date,xdate,105)) A
	select @D1 = A.Xdate from
		(Select count(Uname) as CUname,convert(date,xdate,105) as xDate from tbl_100userLoginMyProg where Pname = @X2 and Uname = @X1 group by convert(date,xdate,105)) A
		inner join
		(select max(B.CUname) as MUname from
			(Select count(Uname) as CUname,convert(date,xdate,105) as xDate from tbl_100userLoginMyProg where Pname = @X2 and Uname = @X1 group by convert(date,xdate,105)) B) C			
		on A.CUname  = C.MUname			
set @S1 += '          มากที่สุด ' + convert(nvarchar(20),@I1) + ' ครั้ง/วัน เมื่อวันที่ ' +  convert(nvarchar(20),@D1,105) + CHAR(13) + Char(13)
set @S1 += '     หน้าจอที่ใช้งานมากที่สุดคือ ' + Char(13)
	select @S2 =  C.Fname from 
		(select  Max(A.CFname) As MFname from (select Fname,COUNT(Fname) as CFname from tbl_100userLoginMyProg where Pname = @X2 and Uname = @X1 group by Fname) A ) B
		inner join
		(select Fname,COUNT(Fname) as CFname from tbl_100userLoginMyProg where Pname = @X2 and Uname =  @x1 group by Fname) C
			on B.MFname = C.CFname
set @S1 += '          ' + @S2 + ' รวมทั้งสิ้น '
	select @I1 =  COUNT(Fname)  from tbl_100userLoginMyProg where Pname = @X2 and Uname =  @x1 and Fname = @S2
set @S1 += convert(nvarchar(20),@I1) + '  ครั้ง ' + char(13)	+ Char(13)
set @S1 += '     เรียกข้อมูล' + Char(13)
	select @I1 = count(Uname) from tbl_101userExecMyprog where Pname = @X2 and Uname = @X1
set @S1 += '          รวมทั้งสิ้น ' + convert(nvarchar(20),@I1) + ' ครั้ง รวมเวลาทั้งหมด ' 		
	select @I1 =  isnull(sum(ExecUsedTime),0) from tbl_101userExecMyprog where Pname = @X2 and Uname = @X1	
set @S1 += convert(nvarchar(20),@I1) + '  วินาที (เริ่มเก็บข้อมูลเมื่อ '
	select @D1 =  min(xdate) from tbl_101userExecMyprog where Pname = @X2
set @S1 += convert(nvarchar(20),@D1) + ')' + char(13)	
	select @I1 = max(A.CUname) from
		(Select count(Uname) as CUname,convert(date,xdate,105) as xDate from tbl_101userExecMyprog where Pname = @X2 and Uname = @X1 group by convert(date,xdate,105)) A
	select @D1 = A.Xdate from
		(Select count(Uname) as CUname,convert(date,xdate,105) as xDate from tbl_101userExecMyprog where Pname = @X2 and Uname = @X1 group by convert(date,xdate,105)) A
		inner join
		(select max(B.CUname) as MUname from
			(Select count(Uname) as CUname,convert(date,xdate,105) as xDate from tbl_101userExecMyprog where Pname = @X2 and Uname = @X1 group by convert(date,xdate,105)) B) C			
		on A.CUname  = C.MUname			
set @S1 += '          มากที่สุด ' + convert(nvarchar(20),@I1) + ' ครั้ง/วัน เมื่อวันที่ ' +  convert(nvarchar(20),@D1,105) + CHAR(13) + Char(13)
set @S1 += '     เงื่อนไขที่เรียกใช้งานมากที่สุด ' + Char(13)
	select @S2 =  C.ExecCondition from 
		(select  Max(A.CExecCondition) As MExecCondition from (select ExecCondition,COUNT(ExecCondition) as CExecCondition from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1 group by ExecCondition) A ) B
		inner join
		(select ExecCondition,COUNT(ExecCondition) as CExecCondition from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1 group by ExecCondition) C
			on B.MExecCondition = C.CExecCondition
set @S1 += '          ' + @S2  + Char(13)
	select @I1 =  isnull(count(ExecCondition),0)  from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1 and ExecCondition = @S2
set @S1 += '          รวม ' + convert(nvarchar(20),@I1) + '  ครั้ง ใช้เวลารวมทั้งสิ้น '
	select @I1 =  isnull(sum(ExecUsedTime),0)  from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1 and ExecCondition = @S2
set @S1 += convert(nvarchar(20),@I1) + '  วินาที ' + char(13) + Char(13)
set @S1 += '     เงื่อนไขที่เรียกข้อมูลนานที่สุด ' + Char(13)
	select @S2 =  A.ExecCondition from
		(select ExecCondition,ExecUsedTime from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1) A 
		inner join 
		(select Max(ExecUsedTime) as MExecUsedTime from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1) C
		on A.ExecUsedTime = C.MExecUsedTime
set @S1 += '          ' + @S2  + Char(13)
	select @I1 =  isnull(ExecUsedTime,0)  from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1 and ExecCondition = @S2 order by ExecUsedTime 
	select @D1 =  xdate from tbl_101userExecMyprog where Pname = @X2 and Uname =  @x1 and ExecCondition = @S2 order by ExecUsedTime 
set @S1 += '          ใช้เวลา ' + convert(nvarchar(20),@I1) + '  วินาที เมื่อวันที่ ' + convert(nvarchar(20),@D1) + char(13) + Char(13)
select (@S1)