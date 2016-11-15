CREATE proc List_ControlForm (@Fname nvarchar(50)) as
	Select ROW_NUMBER() over (order by ccontrol) as RowID ,ccontrol from tba_200ControlCommand where Fname = @Fname and IsEnable = 'N'