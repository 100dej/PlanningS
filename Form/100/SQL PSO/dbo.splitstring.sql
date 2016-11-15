/* รวม Store ผลิต,ขาย,ตั๋ว ให้เป็น Store เดียว

@Scase รูปแบบการเลือก Filter ข้อมูล Mat + Name   1 ปกติ , 2 ดึงจาก Variant
@Tcase รูปแบบการเลือกรายงาน ตาม Check Box
@Vcase รูปแบบการเลือก Stock & Back order เมื่อ @Ycase <> 1  1 Begin Month, 2 Ending Month
@Xcase  รูปแบบการ Group ข้อมูล  ตาม Check Box
@Ycase  รูปแบบการ Group ข้อมูล  1 วัน, 2 เดือน, 3 ปี , 4 เฉพาะเดือน
@Zcase  รูปแบบข้อมูล 2 Qty, 3 We, 4 Utilize, 5 Box
*/
--Function
CREATE FUNCTION splitstring ( @stringToSplit VARCHAR(MAX) )
RETURNS
 @returnList TABLE (xid int identity(1,1) ,[Name] [nvarchar] (500))
AS
BEGIN

 DECLARE @name NVARCHAR(255)
 DECLARE @pos INT

 WHILE CHARINDEX(',', @stringToSplit) > 0
 BEGIN
  SELECT @pos  = CHARINDEX(',', @stringToSplit)  
  SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)

  INSERT INTO @returnList 
  SELECT @name

  SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
 END

 INSERT INTO @returnList
 SELECT @stringToSplit

 RETURN
END