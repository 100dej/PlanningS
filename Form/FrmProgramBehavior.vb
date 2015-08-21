Public Class FrmProgramBehavior
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private x As String
    Private titleFont As New Font("Arial", 15)
    Private titleFont1 As New Font("Arial", 10)
    Private labelFont As New Font("Tahoma", 8)
    Private Sub FrmProgramBehavior_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
        Call Chart1Data()
        Call Chart2Data()
        Call Chart3Data()
        Call Chart4Data()
        Call Chart5Data()
        Call Chart6Data()
        Call Chart7Data()
        Call Chart9Data()
        Call Chart10Data()

        Dim xUser As Integer
        Dim xCount As Integer
        Dim xTime As Integer
        Dim xTimeReduce As Integer

        x = "select count(Uname) from tbl_101userExecMyprog where Pname ='PlanningS.My.MyApplication' group by Uname"
        xUser = cx.ExecuteScalar(x)
        x = "select count(Uname) from tbl_101userExecMyprog where Pname ='PlanningS.My.MyApplication'"
        xCount = cx.ExecuteScalar(x)
        x = "select sum(ExecUsedTime) from tbl_101userExecMyprog where Pname ='PlanningS.My.MyApplication'"
        xTime = cx.ExecuteScalar(x)
        xTimeReduce = (xCount * 180)
        x = String.Format("มี User ใช้งานทั้งหมด {0} คน เรียกใช้งานมาแล้ว {1:N0} ครั้ง ใช้เวลากับ program ทั้งหมด {2:N0} วินาที จากที่ต้องใช้เวลาประมาณ {3:N0} วินาที", xUser, xCount, xTime, xTimeReduce)
        Label1.Text = x


    End Sub
    Sub Chart4Data()

        Chart4.BackColor = Color.Aquamarine


        x = String.Format("exec plannings.dbo.ExcuteResultDayInMonth_ForChart ''")
        DT = cx.GetdataTable(x)
        Chart4.DataSource = DT

        Dim LandingCount_Title As Title = New Title(String.Format("สถิติการ Excute รายวัน (ย้อนหลัง {0} วัน)", DT.Rows.Count))
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont
        LandingCount_Title.ForeColor = Color.Blue
        Chart4.Titles.Add(LandingCount_Title)

        Dim legend As New Legend
        legend.Docking = Docking.Bottom
        legend.Alignment = StringAlignment.Center
        Chart4.Legends.Add(legend)

        Dim series4 As New Series("AVGErrorTime(Sec)")
        series4.ChartType = SeriesChartType.Area
        series4.Color = Color.BlueViolet
        series4.BorderWidth = 2
        series4.YAxisType = AxisType.Secondary
        Chart4.Series.Add(series4)
        Chart4.Series("AVGErrorTime(Sec)").XValueMember = "xDate"
        Chart4.Series("AVGErrorTime(Sec)").YValueMembers = "ErrorInSecond"

        Dim series3 As New Series("AVGSuccessTime(Sec)")
        series3.ChartType = SeriesChartType.Area
        series3.Color = Color.GreenYellow
        series3.BorderWidth = 2
        series3.YAxisType = AxisType.Secondary
        Chart4.Series.Add(series3)
        Chart4.Series("AVGSuccessTime(Sec)").XValueMember = "xDate"
        Chart4.Series("AVGSuccessTime(Sec)").YValueMembers = "SuccessInSecond"

        Dim series As New Series("Success(Count)")
        series.ChartType = SeriesChartType.StackedColumn
        series.Font = labelFont
        series.Label = "#VALY"
        series.LabelForeColor = Color.DarkBlue
        series.Palette = ChartColorPalette.None
        series.Color = Color.Green
        Chart4.Series.Add(series)
        Chart4.Series("Success(Count)").XValueMember = "xDate"
        Chart4.Series("Success(Count)").YValueMembers = "Success"

        Dim series1 As New Series("Error(Count)")
        series1.ChartType = SeriesChartType.StackedColumn
        series1.Font = labelFont
        series1.Label = "#VALY"
        series1.LabelForeColor = Color.Yellow
        series1.Palette = ChartColorPalette.None
        series1.Color = Color.Red
        Chart4.Series.Add(series1)
        Chart4.Series("Error(Count)").XValueMember = "xDate"
        Chart4.Series("Error(Count)").YValueMembers = "Error"


        Dim series2 As New Series("Active User(Man)")
        series2.ChartType = SeriesChartType.Spline
        series2.Font = labelFont
        series2.Label = "#VALY"
        series2.YAxisType = AxisType.Secondary
        series2.LabelForeColor = Color.Red
        series2.Color = Color.DarkMagenta
        series2.BorderWidth = 2
        Chart4.Series.Add(series2)
        Chart4.Series("Active User(Man)").XValueMember = "xDate"
        Chart4.Series("Active User(Man)").YValueMembers = "Cuser"



        Chart4.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        Chart4.ChartAreas(0).AxisX.LabelStyle.Angle = 30
        Chart4.ChartAreas(0).AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        Chart4.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Aqua
        Chart4.ChartAreas(0).AxisX.MajorGrid.Enabled = False


        Chart4.DataBind()


    End Sub

    Sub Chart10Data()
        Chart10.ChartAreas.Clear()
        Dim chartArea1 As New ChartArea("Chart10")
        chartArea1.BackColor = Drawing.Color.Azure
        chartArea1.BackGradientStyle = GradientStyle.TopBottom
        chartArea1.BackHatchStyle = ChartHatchStyle.DashedHorizontal
        chartArea1.Area3DStyle.Enable3D = True
        Chart10.ChartAreas.Add(chartArea1)

        'Chart
        Chart10.BackColor = Color.Brown
        Chart10.BackSecondaryColor = Color.Gray
        Chart10.BackGradientStyle = GradientStyle.TopBottom


        'Title
        Dim LandingCount_Title As Title = New Title("สถิติ Execute สำเร็จ : วินาที(ครั้ง)")
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont1
        LandingCount_Title.ForeColor = Color.White
        Chart10.Titles.Add(LandingCount_Title)

        x = String.Format("exec plannings.dbo.RangeExecuteForChart ''")
        DT = cx.GetdataTable(x)
        Chart10.DataSource = DT


        Dim series As New Series("SERIES")
        series.ChartType = SeriesChartType.Pie
        series.Font = labelFont
        series.Label = "#VALX(#VALY)"
        series("PieLabelStyle") = "Outside"
        series.LabelForeColor = Color.Blue
        series.Palette = ChartColorPalette.EarthTones
        Chart10.Series.Add(series)
        Chart10.Series("SERIES").XValueMember = "xRange"
        Chart10.Series("SERIES").YValueMembers = "SuccessCount"

        Chart10.DataBind()
    End Sub
    Sub Chart9Data()
        Chart9.ChartAreas.Clear()
        Dim chartArea As New ChartArea("chart9")
        chartArea.BackColor = Drawing.Color.Azure
        chartArea.BackGradientStyle = GradientStyle.TopBottom
        chartArea.BackHatchStyle = ChartHatchStyle.DashedHorizontal
        chartArea.Area3DStyle.Enable3D = True
        Chart9.ChartAreas.Add(chartArea)

        'Chart
        Chart9.BackColor = Color.GreenYellow
        Chart9.BackSecondaryColor = Color.Gray
        Chart9.BackGradientStyle = GradientStyle.TopBottom


        'Title
        Dim LandingCount_Title As Title = New Title("สถิติ Execute สำเร็จ : ช่วงเวลา(ครั้ง)")
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont1
        LandingCount_Title.ForeColor = Color.Teal
        Chart9.Titles.Add(LandingCount_Title)

        x = String.Format("exec plannings.dbo.ProgExecuteTimeForChart ''")
        DT = cx.GetdataTable(x)
        Chart9.DataSource = DT

        Dim series As New Series("SERIES")
        series.ChartType = SeriesChartType.Pie
        series.Font = labelFont
        series.Label = "#AXISLABEL (#VALY)"
        series("PieLabelStyle") = "Outside"
        series.LabelForeColor = Color.Blue
        series.Palette = ChartColorPalette.EarthTones
        Chart9.Series.Add(series)
        Chart9.Series("SERIES").XValueMember = "xTime"
        Chart9.Series("SERIES").YValueMembers = "CountSuccessTime"

        Chart9.DataBind()
    End Sub
    Sub Chart6Data()
        Chart6.ChartAreas.Clear()
        Dim chartArea As New ChartArea("chart6")
        chartArea.BackColor = Drawing.Color.Azure
        chartArea.BackGradientStyle = GradientStyle.TopBottom
        chartArea.BackHatchStyle = ChartHatchStyle.DashedHorizontal
        chartArea.Area3DStyle.Enable3D = True
        Chart6.ChartAreas.Add(chartArea)

        'Chart
        Chart6.BackColor = Color.Brown
        Chart6.BackSecondaryColor = Color.Gray
        Chart6.BackGradientStyle = GradientStyle.TopBottom

        'Title
        Dim LandingCount_Title As Title = New Title("ผลการ Execute ข้อมูลแต่ละเวลา (%)")
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont1
        LandingCount_Title.ForeColor = Color.White
        Chart6.Titles.Add(LandingCount_Title)

        x = String.Format("exec ProgExecuteTimeForChart ''")
        DT = cx.GetdataTable(x)
        Chart6.DataSource = DT

        Dim series As New Series("Success")
        series.ChartType = SeriesChartType.StackedBar100
        Chart6.Series.Add(series)
        Chart6.Series("Success").XValueMember = "xTime"
        Chart6.Series("Success").YValueMembers = "CountSuccessTime"

        Dim series1 As New Series("Error")
        series1.ChartType = SeriesChartType.StackedBar100
        Chart6.Series.Add(series1)
        Chart6.Series("Error").XValueMember = "xTime"
        Chart6.Series("Error").YValueMembers = "CountErrorTime"

        Chart6.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        Chart6.ChartAreas(0).AxisX.LabelStyle.Angle = 0

        Chart6.DataBind()
    End Sub
    Sub Chart5Data()
        Chart5.ChartAreas.Clear()
        Dim chartArea As New ChartArea("Chart5")
        chartArea.BackColor = Drawing.Color.Azure
        chartArea.BackGradientStyle = GradientStyle.TopBottom
        chartArea.BackHatchStyle = ChartHatchStyle.DashedHorizontal
        Chart5.ChartAreas.Add(chartArea)

        'Chart
        Chart5.BackColor = Color.GreenYellow
        Chart5.BackSecondaryColor = Color.Gray
        Chart5.BackGradientStyle = GradientStyle.TopBottom

        'Title
        Dim LandingCount_Title As Title = New Title("สถิติ Excute รายวัน (เช้า/บ่าย)")
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont1
        LandingCount_Title.ForeColor = Color.Teal
        Chart5.Titles.Add(LandingCount_Title)

        x = String.Format("exec ExecuteWeekDayForChart '','',''")
        DT = cx.GetdataTable(x)
        Chart5.DataSource = DT

        Dim series1 As New Series("AM")
        series1.ChartType = SeriesChartType.Bubble
        series1.Label = "#VALY"
        series1.Font = labelFont
        series1.LabelForeColor = Color.DarkBlue
        series1.Color = Color.LightGreen
        series1.ChartArea = "Chart5"
        Chart5.Series.Add(series1)
        Chart5.Series("AM").XValueMember = "XDateName"
        Chart5.Series("AM").YValueMembers = "AM"

        Dim series2 As New Series("PM")
        series2.ChartType = SeriesChartType.Bubble
        series2.Label = "#VALY"
        series1.Font = labelFont
        series2.LabelForeColor = Color.DarkBlue
        series2.Color = Color.MediumSlateBlue
        series2.ChartArea = "Chart5"
        Chart5.Series.Add(series2)
        Chart5.Series("PM").XValueMember = "XDateName"
        Chart5.Series("PM").YValueMembers = "PM"

        Chart5.ChartAreas("Chart5").AxisX.LabelStyle.Interval = 1
        Chart5.ChartAreas("Chart5").AxisX.LabelStyle.Angle = 30
        Chart5.ChartAreas("Chart5").AxisX.MajorGrid.Enabled = False

    End Sub
    Sub Chart1Data()
        Chart1.ChartAreas.Clear()
        Dim chartArea1 As New ChartArea("chart1")
        chartArea1.BackColor = Drawing.Color.Azure
        chartArea1.BackGradientStyle = GradientStyle.TopBottom
        chartArea1.BackHatchStyle = ChartHatchStyle.DashedHorizontal
        chartArea1.Area3DStyle.Enable3D = True
        Chart1.ChartAreas.Add(chartArea1)

        'Chart
        Chart1.BackColor = Color.GreenYellow
        Chart1.BackSecondaryColor = Color.Gray
        Chart1.BackGradientStyle = GradientStyle.TopBottom

        'Title
        Dim LandingCount_Title As Title = New Title("สถิติ Execute ไม่สำเร็จ : วินาที(ครั้ง)")
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont1
        LandingCount_Title.ForeColor = Color.Teal
        Chart1.Titles.Add(LandingCount_Title)

        x = String.Format("exec plannings.dbo.RangeExecuteForChart ''")
        DT = cx.GetdataTable(x)
        Chart1.DataSource = DT

        Dim series As New Series("SERIES")
        series.ChartType = SeriesChartType.Pie
        series.Font = labelFont
        series.Label = "#VALX(#VALY)"
        series("PieLabelStyle") = "Outside"
        series.LabelForeColor = Color.Red
        series.Palette = ChartColorPalette.Fire
        Chart1.Series.Add(series)
        Chart1.Series("SERIES").XValueMember = "xRange"
        Chart1.Series("SERIES").YValueMembers = "ErrorCount"

    End Sub
    Sub Chart2Data()
        Chart2.ChartAreas.Clear()
        Dim chartArea1 As New ChartArea("Chart2")
        chartArea1.BackColor = Drawing.Color.Azure
        chartArea1.BackGradientStyle = GradientStyle.TopBottom
        chartArea1.BackHatchStyle = ChartHatchStyle.DashedHorizontal
        chartArea1.Area3DStyle.Enable3D = True
        Chart2.ChartAreas.Add(chartArea1)

        'Chart
        Chart2.BackColor = Color.Brown
        Chart2.BackSecondaryColor = Color.Gray
        Chart2.BackGradientStyle = GradientStyle.TopBottom

        'Title
        Dim LandingCount_Title As Title = New Title("สถิติ Execute ไม่สำเร็จ : ช่วงเวลา(ครั้ง)")
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont1
        LandingCount_Title.ForeColor = Color.White
        Chart2.Titles.Add(LandingCount_Title)

        x = String.Format("exec ProgExecuteTimeForChart ''")
        DT = cx.GetdataTable(x)
        Chart2.DataSource = DT

        Dim series As New Series("SERIES")
        series.ChartType = SeriesChartType.Pie
        series.Font = labelFont
        series.Label = "#AXISLABEL (#VALY)"
        series("PieLabelStyle") = "Outside"
        series.LabelForeColor = Color.Red
        series.Palette = ChartColorPalette.Fire
        Chart2.Series.Add(series)
        Chart2.Series("SERIES").XValueMember = "xTime"
        Chart2.Series("SERIES").YValueMembers = "CountErrorTime"
        Chart2.DataBind()
    End Sub
    Sub Chart3Data()

        Chart3.BackColor = Color.Aquamarine
        Chart3.BackSecondaryColor = Color.Gray
        Chart3.BackGradientStyle = GradientStyle.TopBottom

        Dim LandingCount_Title As Title = New Title("ข้อมูลการ Execute รายเดือน")
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont
        LandingCount_Title.ForeColor = Color.Blue
        Chart3.Titles.Add(LandingCount_Title)

        x = String.Format("exec plannings.dbo.AllExecuteInMonthForChart '{0}','{1}'", "", "")
        DT = cx.GetdataTable(x)
        Chart3.DataSource = DT

        Dim legend As New Legend
        legend.Docking = Docking.Bottom
        legend.Alignment = StringAlignment.Center
        Chart3.Legends.Add(legend)

        Dim series4 As New Series("AVGErrorTime(Sec)")
        series4.ChartType = SeriesChartType.Area
        series4.Color = Color.BlueViolet
        series4.BorderWidth = 2
        Chart3.Series.Add(series4)
        Chart3.Series("AVGErrorTime(Sec)").XValueMember = "MY"
        Chart3.Series("AVGErrorTime(Sec)").YValueMembers = "AVGErrorTime"

        Dim series3 As New Series("AVGSuccessTime(Sec)")
        series3.ChartType = SeriesChartType.Area
        series3.Color = Color.GreenYellow
        series3.BorderWidth = 2
        Chart3.Series.Add(series3)
        Chart3.Series("AVGSuccessTime(Sec)").XValueMember = "MY"
        Chart3.Series("AVGSuccessTime(Sec)").YValueMembers = "AVGSuccessTime"

        Dim series As New Series("Success(Count)")
        series.ChartType = SeriesChartType.StackedColumn
        series.Font = labelFont
        series.Label = "#VALY"
        series.LabelForeColor = Color.DarkBlue
        series.Palette = ChartColorPalette.None
        series.Color = Color.Green
        Chart3.Series.Add(series)
        Chart3.Series("Success(Count)").XValueMember = "MY"
        Chart3.Series("Success(Count)").YValueMembers = "Success"

        Dim series1 As New Series("Error(Count)")
        series1.ChartType = SeriesChartType.StackedColumn
        series1.Font = labelFont
        series1.Label = "#VALY"
        series1.LabelForeColor = Color.Yellow
        series1.Palette = ChartColorPalette.None
        series1.Color = Color.Red
        Chart3.Series.Add(series1)
        Chart3.Series("Error(Count)").XValueMember = "MY"
        Chart3.Series("Error(Count)").YValueMembers = "Error"

        Dim series2 As New Series("Active User(Man)")
        series2.ChartType = SeriesChartType.Spline
        series2.Font = labelFont
        series2.Label = "#VALY"
        series2.YAxisType = AxisType.Secondary
        series2.LabelForeColor = Color.Red
        series2.Color = Color.DarkMagenta
        series2.BorderWidth = 2
        Chart3.Series.Add(series2)
        Chart3.Series("Active User(Man)").XValueMember = "MY"
        Chart3.Series("Active User(Man)").YValueMembers = "Cuser"

        Dim series5 As New Series("New User(Man)")
        series5.ChartType = SeriesChartType.BoxPlot
        series5.YAxisType = AxisType.Secondary
        series5.Color = Color.Goldenrod
        series5.BorderWidth = 2
        Chart3.Series.Add(series5)
        Chart3.Series("New User(Man)").XValueMember = "MY"
        Chart3.Series("New User(Man)").YValueMembers = "CountUser"

        Dim series6 As New Series("Active User(Day)")
        series6.ChartType = SeriesChartType.StackedColumn
        series6.Font = labelFont
        series6.Label = "#VALY"
        series6.YAxisType = AxisType.Secondary
        series6.LabelForeColor = Color.Gold
        series6.Palette = ChartColorPalette.None
        series6.Color = Color.Gray
        Chart3.Series.Add(series6)
        Chart3.Series("Active User(Day)").XValueMember = "MY"
        Chart3.Series("Active User(Day)").YValueMembers = "ActiveDay"

        Chart3.ChartAreas(0).AxisX.LabelStyle.Angle = 45
        Chart3.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        Dim i As Integer
        i = DT.Compute("Max(Success) + Max(Error)", "")
        i = Math.Floor(i / 500)
        i = (i + 1) * 500
        Chart3.ChartAreas(0).AxisY.Maximum = i
        Chart3.ChartAreas(0).AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        Chart3.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Aqua
        Chart3.ChartAreas(0).AxisX.MajorGrid.Enabled = False

        Chart3.DataBind()

    End Sub
    Sub Chart7Data()

        Chart7.BackColor = Color.Aquamarine

        x = String.Format("exec ExecuteDayForChart '{0}','{1}'", "", "")
        DT = cx.GetdataTable(x)
        Chart7.DataSource = DT

        Dim LandingCount_Title As Title = New Title(String.Format("จำนวน Execute ของ User (Top {0})", DT.Rows.Count))
        LandingCount_Title.Alignment = ContentAlignment.TopLeft
        LandingCount_Title.Font = titleFont
        LandingCount_Title.ForeColor = Color.Blue
        Chart7.Titles.Add(LandingCount_Title)

        Dim legend As New Legend
        legend.Docking = Docking.Bottom
        legend.Alignment = StringAlignment.Center
        Chart7.Legends.Add(legend)

        Dim series2 As New Series("Success (Count)")
        series2.ChartType = SeriesChartType.Area
        series2.Palette = ChartColorPalette.None
        series2.YAxisType = AxisType.Secondary
        series2.Color = Color.Green
        Chart7.Series.Add(series2)
        Chart7.Series("Success (Count)").XValueMember = "Uname"
        Chart7.Series("Success (Count)").YValueMembers = "CountExecSuccess"

        Dim series3 As New Series("Error (Count)")
        series3.ChartType = SeriesChartType.Area
        series3.Palette = ChartColorPalette.None
        series3.YAxisType = AxisType.Secondary
        series3.Color = Color.Red
        Chart7.Series.Add(series3)
        Chart7.Series("Error (Count)").XValueMember = "Uname"
        Chart7.Series("Error (Count)").YValueMembers = "CountExecError"

        Dim series As New Series("Active (Day)")
        series.ChartType = SeriesChartType.StackedColumn
        series.Font = labelFont
        series.IsXValueIndexed = True
        series.Label = "#VALY"
        series.LabelForeColor = Color.Gold
        series.Palette = ChartColorPalette.None
        series.Color = Color.Gray
        Chart7.Series.Add(series)
        Chart7.Series("Active (Day)").XValueMember = "Uname"
        Chart7.Series("Active (Day)").YValueMembers = "SuccessDate"


        Chart7.ChartAreas(0).AxisX.LabelStyle.Angle = 30
        Chart7.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        Chart7.ChartAreas(0).AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        Chart7.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Aqua
        Chart7.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        Chart7.DataBind()
    End Sub
End Class