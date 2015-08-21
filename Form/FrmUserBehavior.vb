Public Class FrmUserBehavior
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private RbCase As Integer
    Private x As String
    Private xUser As String
    Private Sub FrmReportProg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler lbUser.SelectedIndexChanged, AddressOf lbUser_SelectedIndexChanged
        AddHandler rbStatProgram.CheckedChanged, AddressOf rbStatProgram_CheckedChanged
        AddHandler rbToday.CheckedChanged, AddressOf rbStatProgram_CheckedChanged
        AddHandler rbThisWeek.CheckedChanged, AddressOf rbStatProgram_CheckedChanged
        AddHandler rbThisMonth.CheckedChanged, AddressOf rbStatProgram_CheckedChanged
        rbStatProgram.Checked = True
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
    End Sub
    Private Sub lbUser_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        xUser = lbUser.SelectedValue
        Dim xProg As String = My.Application.ToString
        Dim lblUserBehavior As String = ""
        Select Case RbCase
            Case 1
                pnToday.Dock = DockStyle.None
                pnToday.Visible = False
                pnBegin.Visible = True
                pnBegin.Dock = DockStyle.Fill
                Try
                    lblUserBehavior = cx.ExecuteScalar(String.Format("exec plannings.dbo.UserBehavior '{0}','{1}'", xUser, xProg))
                Catch ex As Exception

                End Try
                Label1.Text = xUser + lblUserBehavior
            Case Else
                pnBegin.Dock = DockStyle.None
                pnToday.Visible = True
                pnBegin.Visible = False
                pnToday.Dock = DockStyle.Fill

                Dim a, c, am, pm As Integer
                Dim b, d As Date
                d = Now
                x = String.Format("select *,datepart(ww,xdate) as W,datepart(mm,xdate) as M,datepart(yyyy,xdate) as Y from plannings.dbo.tbl_101userExecMyprog where Uname = '{0}' order by xid desc", xUser)
                Dim DT1 As DataTable = cx.GetdataTable(x)
                dtgExcute.DataSource = DT1.DefaultView
                cx.GridToList(dtgExcute)
                x = String.Format("select min(xdate) from plannings.dbo.tbl_100userLoginMyProg where Pname = '{0}' and Uname = '{1}'", xProg, xUser)
                b = cx.ExecuteScalar(x)
                x = String.Format("exec UserBehaviorTime '{0}','AM'", xUser)
                am = cx.ExecuteScalar(x)
                x = String.Format("exec UserBehaviorTime '{0}','PM'", xUser)
                pm = cx.ExecuteScalar(x)
                Select Case RbCase
                    Case 2
                        a = DT1.Compute("count(xdate)", String.Format("xdate > '{0}'", d.AddDays(-0.5)))
                        c = DateDiff(DateInterval.Day, b, d)
                        x = "วัน"
                    Case 3
                        a = DT1.Compute("count(xdate)", String.Format("W = {0} and Y = {1}", DatePart(DateInterval.WeekOfYear, d), DatePart(DateInterval.Year, d)))
                        c = DateDiff(DateInterval.WeekOfYear, b, d)
                        x = "สัปดาห์"
                    Case 4
                        a = DT1.Compute("count(xdate)", String.Format("M = {0} and Y = {1}", DatePart(DateInterval.Month, d), DatePart(DateInterval.Year, d)))
                        c = DateDiff(DateInterval.Month, b, d)
                        x = "เดือน"
                End Select
                If c = 0 Then c = 1
                Label2.Text = String.Format("Excute : {4}นี้ใช้มาแล้ว {0} ครั้ง จากทั้งหมด {1} ครั้ง ช่วงเช้า {5} ครั้ง ({7}%) ช่วงบ่าย {6} ครั้ง ({8}%) ใช้มาแล้ว {2} {4} เฉลี่ย {3} ครั้ง/{4}", _
                                        a, DT1.Rows.Count, c, CInt(DT1.Rows.Count / c), x, am, pm, CInt(am * 100 / DT1.Rows.Count), CInt(pm * 100 / DT1.Rows.Count))

                x = String.Format("select *,datepart(ww,xdate) as W,datepart(mm,xdate) as M,datepart(yyyy,xdate) as Y from plannings.dbo.tbl_102userExecMyprogTimeout where Uname = '{0}' order by xid desc", xUser)
                Dim DT2 As DataTable = cx.GetdataTable(x)
                dtgError.DataSource = DT2.DefaultView
                cx.GridToList(dtgError)
                Select Case RbCase
                    Case 2
                        a = DT2.Compute("count(xdate)", String.Format("xdate > '{0}'", d.AddDays(-0.5)))
                        x = "วัน"
                    Case 3
                        a = DT2.Compute("count(xdate)", String.Format("W = {0} and Y = {1}", DatePart(DateInterval.WeekOfYear, d), DatePart(DateInterval.Year, d)))
                        x = "สัปดาห์"
                    Case 4
                        a = DT2.Compute("count(xdate)", String.Format("M = {0} and Y = {1}", DatePart(DateInterval.Month, d), DatePart(DateInterval.Year, d)))
                        x = "เดือน"
                End Select
                Label3.Text = String.Format("Error : {0}นี้เกิด Error {1} ครั้ง จากทั้งหมด {2} ครั้ง", x, a, DT2.Rows.Count)

                Call Chart1_Object()
                Call Chart2_Object()
        End Select
    End Sub
    Private Sub Chart2_Object()

        Chart2.ChartAreas.Clear()
        Chart2.Series.Clear()

        x = String.Format("exec RangeExecuteForPieChart '{0}'", xUser)
        Dim ChartAreaList As New List(Of String)()
        ChartAreaList.Add("Success")
        ChartAreaList.Add("Error")
        Dim xTitle As [String] = ""
        Dim yTitle As [String] = ""

        Dim DS As DataSet = cx.GetdataSet(x)
        If DS.Tables.Count > 0 Then
            For i As Integer = 0 To DS.Tables.Count - 1
                If DS.Tables(i).Rows.Count > 0 Then
                    xTitle = ""
                    yTitle = ""
                    Chart2.ChartAreas.Add(ChartAreaList(i)).AlignmentOrientation = AreaAlignmentOrientations.Horizontal
                    Chart2.Series.Add(ChartAreaList(i))
                    If ChartAreaList(i) = "Success" Then
                        xTitle = "xRange"
                        yTitle = "Success"
                        Chart2.Series(ChartAreaList(i)).Palette = ChartColorPalette.Bright
                        Chart2.Series(ChartAreaList(i)).LabelForeColor = Color.Blue
                    End If
                    If ChartAreaList(i) = "Error" Then
                        xTitle = "xRange"
                        yTitle = "Error"
                        Chart2.Series(ChartAreaList(i)).Palette = ChartColorPalette.Fire
                        Chart2.Series(ChartAreaList(i)).LabelForeColor = Color.Red
                    End If
                    Chart2.Series(ChartAreaList(i)).ChartType = SeriesChartType.Pie
                    Chart2.ChartAreas(ChartAreaList(i)).Area3DStyle.Enable3D = True
                    Chart2.Series(ChartAreaList(i)).ChartArea = ChartAreaList(i)
                    Chart2.Series(ChartAreaList(i)).Label = "#VALX(#VALY)"
                    Chart2.Series(ChartAreaList(i))("PieLabelStyle") = "Outside"
                    Chart2.Series(ChartAreaList(i)).Points.DataBindXY(DS.Tables(i).DefaultView, xTitle, DS.Tables(i).DefaultView, yTitle)
                End If
            Next
        End If
    End Sub

    Private Sub Chart1_Object()
        Chart1.Legends.Clear()
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        x = String.Format("exec plannings.dbo.UserBehaviorAnalyticsForChart '{0}'", xUser)

        Dim DS As DataSet = cx.GetdataSet(x)
        If DS.Tables.Count > 0 Then
            Dim ChartAreaList As New List(Of String)()

            ChartAreaList.Add("WeekDay")
            ChartAreaList.Add("Month")
            ChartAreaList.Add("WeekDayTotal")
            ChartAreaList.Add("DayTotal")

            Dim i As Integer, f As Integer
            Dim xTitle As New ArrayList
            Dim yTitle As New ArrayList

            For i = 0 To DS.Tables.Count - 1
                If DS.Tables(i).Rows.Count > 0 Then
                    Chart1.ChartAreas.Add(ChartAreaList(i))
                    xTitle.Clear()
                    yTitle.Clear()
                    For f = 1 To DS.Tables(i).Columns.Count - 1
                        Chart1.Series.Add(ChartAreaList(i) + f.ToString)
                        Select Case i
                            Case 0
                                Chart1.Series(ChartAreaList(i) + f.ToString).ChartType = SeriesChartType.Bubble
                                xTitle.Add("xDatename")
                                Select Case f
                                    Case 1
                                        yTitle.Add("AM")
                                        Chart1.Series(ChartAreaList(i) + f.ToString).Color = Color.DarkSlateBlue
                                    Case 2
                                        yTitle.Add("PM")
                                        Chart1.Series(ChartAreaList(i) + f.ToString).Color = Color.LightGreen
                                End Select
                            Case 1
                                xTitle.Add("xMonthName")
                                yTitle.Add("Total")
                                Chart1.Series(ChartAreaList(i) + f.ToString).ChartType = SeriesChartType.Column
                                Chart1.Series(ChartAreaList(i) + f.ToString).Palette = ChartColorPalette.Bright
                            Case 2
                                xTitle.Add("xDate")
                                Select Case f
                                    Case 1
                                        yTitle.Add("ErrorInSecond")
                                        Chart1.Series(ChartAreaList(i) + f.ToString).ChartType = SeriesChartType.Area
                                        Chart1.Series(ChartAreaList(i) + f.ToString).Color = Color.BlueViolet
                                        Chart1.Series(ChartAreaList(i) + f.ToString).YAxisType = AxisType.Secondary
                                    Case 2
                                        yTitle.Add("SuccessInSecond")
                                        Chart1.Series(ChartAreaList(i) + f.ToString).ChartType = SeriesChartType.Area
                                        Chart1.Series(ChartAreaList(i) + f.ToString).Color = Color.GreenYellow
                                        Chart1.Series(ChartAreaList(i) + f.ToString).YAxisType = AxisType.Secondary
                                    Case 3
                                        yTitle.Add("Success")
                                        Chart1.Series(ChartAreaList(i) + f.ToString).ChartType = SeriesChartType.StackedColumn
                                        Chart1.Series(ChartAreaList(i) + f.ToString).Color = Color.Green
                                        Chart1.Series(ChartAreaList(i) + f.ToString).LabelForeColor = Color.DarkBlue
                                    Case 4
                                        yTitle.Add("Error")
                                        Chart1.Series(ChartAreaList(i) + f.ToString).ChartType = SeriesChartType.StackedColumn
                                        Chart1.Series(ChartAreaList(i) + f.ToString).Color = Color.Red
                                        Chart1.Series(ChartAreaList(i) + f.ToString).LabelForeColor = Color.Yellow
                                    Case 5
                                        yTitle.Add("")
                                End Select
                            Case 3
                                xTitle.Add("xDay")
                                yTitle.Add("Total")
                                Chart1.Series(ChartAreaList(i) + f.ToString).ChartType = SeriesChartType.Column
                                Chart1.Series(ChartAreaList(i) + f.ToString).Palette = ChartColorPalette.Bright
                        End Select
                        SetChartAreaFeatures(0, Chart1, ChartAreaList(i), xTitle(f - 1), yTitle(f - 1))
                        Chart1.ChartAreas(ChartAreaList(i)).AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.Dash
                        Chart1.ChartAreas(ChartAreaList(i)).AxisY2.MajorGrid.LineColor = Color.Aqua
                        Chart1.ChartAreas(ChartAreaList(i)).AxisX.MajorGrid.Enabled = False
                        Chart1.ChartAreas(ChartAreaList(i)).AlignWithChartArea = ChartAreaList(i)
                        Chart1.ChartAreas(ChartAreaList(i)).AxisX.LabelStyle.Interval = 1
                        Chart1.Series(ChartAreaList(i) + f.ToString).ChartArea = ChartAreaList(i)
                        Chart1.Series(ChartAreaList(i) + f.ToString)("DrawingStyle") = "Cylinder"
                        Chart1.Series(ChartAreaList(i) + f.ToString).Points.DataBindXY(DS.Tables(i).DefaultView, xTitle(f - 1), DS.Tables(i).DefaultView, yTitle(f - 1))
                    Next
                End If
            Next
        End If
    End Sub
    Private Sub SetChartAreaFeatures(ByVal a As Integer, ByVal tmpChart As Chart, ByVal tmpArea As [String], ByVal xTitle As [String], ByVal yTitle As [String])
        Select Case a
            Case 0
                tmpChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
                tmpChart.BorderlineColor = System.Drawing.Color.FromArgb(26, 59, 105)
                tmpChart.BorderlineWidth = 2
                tmpChart.BackColor = Color.Silver
                tmpChart.ChartAreas(tmpArea).AxisX.MajorGrid.Enabled = False
            Case 1
                tmpChart.ChartAreas(tmpArea).BorderDashStyle = ChartDashStyle.Solid
                tmpChart.ChartAreas(tmpArea).BorderWidth = 1
                tmpChart.ChartAreas(tmpArea).BackColor = Color.White
                tmpChart.ChartAreas(tmpArea).BorderColor = Color.Black
                tmpChart.ChartAreas(tmpArea).AxisX.Title = xTitle
                tmpChart.ChartAreas(tmpArea).AxisX.TitleFont = New System.Drawing.Font("Verdana", 10, System.Drawing.FontStyle.Bold)
                tmpChart.ChartAreas(tmpArea).AxisX.Minimum = 0
                tmpChart.ChartAreas(tmpArea).AxisX.Interval = 1
                tmpChart.ChartAreas(tmpArea).AxisX.MajorGrid.Enabled = False
                tmpChart.ChartAreas(tmpArea).AxisY.Title = yTitle
                tmpChart.ChartAreas(tmpArea).AxisY.TitleFont = New System.Drawing.Font("Verdana", 10, System.Drawing.FontStyle.Bold)
                tmpChart.ChartAreas(tmpArea).AxisY2.LineColor = Color.Black
                tmpChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
                tmpChart.ChartAreas(tmpArea).AxisX.LabelStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                tmpChart.ChartAreas(tmpArea).AxisY.LabelStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                tmpChart.ChartAreas(tmpArea).AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64)
                tmpChart.ChartAreas(tmpArea).AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64)
            Case 2
                tmpChart.ChartAreas(tmpArea).Area3DStyle.Enable3D = True
        End Select
    End Sub
    Private Sub rbStatProgram_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            RbCase = R1.Tag
        End If
        Select Case RbCase
            Case 1
                DT = cx.GetdataTable("select Uname from tbl_101userExecMyprog where Pname ='PlanningS.My.MyApplication' group by Uname order by Uname")
            Case 2
                DT = cx.GetdataTable("select Uname from tbl_101userExecMyprog where Pname ='PlanningS.My.MyApplication' and xdate > getdate()-0.5 group by Uname order by Uname")
            Case 3
                DT = cx.GetdataTable("select Uname from plannings.dbo.tbl_101userExecMyprog where Pname ='PlanningS.My.MyApplication' and datepart(wk,xdate) = datepart(wk,getdate()) and year(xdate) = year(getdate()) group by Uname order by Uname")
            Case 4
                DT = cx.GetdataTable("select Uname from plannings.dbo.tbl_101userExecMyprog where Pname ='PlanningS.My.MyApplication' and datepart(mm,xdate) = datepart(mm,getdate()) and year(xdate) = year(getdate()) group by Uname order by Uname")
        End Select
        lbUser.DisplayMember = "Uname"
        lbUser.ValueMember = "Uname"
        lbUser.DataSource = DT
        CUser.Text = String.Format("มี User ใช้งานแล้ว จำนวน {0} คน", DT.Rows.Count.ToString)
    End Sub
End Class