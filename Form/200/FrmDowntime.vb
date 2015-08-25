Public Class FrmDowntime
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private DV As DataView
    Private DT As DataTable
    Private X As String
    Private DvColumnfilter As String
    Private DVColumnValFilter As String
    Const maxtextboxpanel1 As Integer = 999
    Private CkBox(maxtextboxpanel1) As CheckBox
    Private Listcontrol As New List(Of Control)
    Private CaseCalendarList As New List(Of RadioButton)
    Private CaseCalendar As Integer
    Private CaseColumnList As New List(Of CheckBox)
    Private CaseColumnText As New System.Text.StringBuilder("")
    Private CaseUnitList As New List(Of CheckBox)
    Private CaseUnitText As New System.Text.StringBuilder("")
    Private CaseDataReport As New List(Of RadioButton)
    Private datareport As Integer
    Private Product As String
    Private DTGroup As String
    Private MCno As String
    Private DateS As String '@Sdate
    Private DateE As String '@Edate
    Private XCheck As String
    Private Sub FrmDowntime_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.ChangeCulture("en-US")
        AddHandler dtgMaster.DoubleClick, AddressOf dtMaster_DoubleClick
        AddHandler CopyGrid.Click, AddressOf CopyGrid_Click
        AddHandler CopylblSQL.Click, AddressOf CopylblSQL_Click
        AddHandler lblStatus.Click, AddressOf lblStatus_Click
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler cmdSQL.Click, AddressOf cmdSQL_Click

        For Each ctrl As RadioButton In Me.pnYcaseHeader.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf CaseCalendar_CheckedChanged
            CaseCalendarList.Add(ctrl)
        Next

        For Each ctrl As CheckBox In Me.pnColumn.Controls.OfType(Of CheckBox)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf CaseColumn_CheckedChanged
            CaseColumnList.Add(ctrl)
        Next

        For Each ctrl As CheckBox In Me.pnUnit.Controls.OfType(Of CheckBox)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf CaseUnit_CheckedChanged
            CaseUnitList.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnDataReport.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf CaseDataReport_CheckedChanged
            CaseDataReport.Add(ctrl)
        Next


        Dim DT1 As DataTable = cx.GetdataTable("select distinct dgroup_oee from pdbft.dbo.MS_DowntimeCode1 where dgroup_oee is not null order by dgroup_oee")
        DT1.Rows.Add("")
        DT1.DefaultView.Sort = "dgroup_oee ASC"
        cboDTgroup.DisplayMember = "dgroup_oee"
        cboDTgroup.ValueMember = "dgroup_oee"
        cboDTgroup.DataSource = DT1
        DTGroup = ""

        Dim DT2 As DataTable = cx.GetdataTable("select distinct product  from plannings.dbo.fact_downtime_table")
        DT2.Rows.Add("")
        DT2.DefaultView.Sort = "Product ASC"
        cboProduct.DisplayMember = "Product"
        cboProduct.ValueMember = "Product"
        cboProduct.DataSource = DT2
        Product = ""

        MCno = ""

        AddHandler cboProduct.SelectedIndexChanged, AddressOf cboProduct_SelectedIndexChanged
        AddHandler cboDTgroup.SelectedIndexChanged, AddressOf cboDTgroup_SelectedIndexChanged
        AddHandler cboMCno.SelectedIndexChanged, AddressOf cboMCno_SelectedIndexChanged

        rb31.Checked = True
        cb204.Checked = True
        cb208.Checked = True
        rb12.Checked = True
        txtSM.Text = 1
        txtEM.Text = 12

        txtSY.Text = Now.Year
        txtEY.Text = Now.Year

        pnGrid.BackgroundImageLayout = ImageLayout.Zoom

        Select Case Now.Day
            Case 1
                dtPickS.Value = DateSerial(Now.Year, Now.Month - 1, 1)
            Case Else
                dtPickS.Value = DateSerial(Now.Year, Now.Month, 1)
        End Select
        dtPickE.Value = DateSerial(Now.Year, Now.Month, Now.Day - 1)

        Call ClearData()

        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)

    End Sub
    Private Sub CaseUnit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim R1 As CheckBox = sender
        If R1.Checked = True Then CaseUnitText.Append(R1.Tag) Else CaseUnitText.Replace(R1.Tag, "")
        If cb303.Checked = True Then
            cboDTgroup.SelectedValue = ""
            cboDTgroup.Enabled = False
            DTGroup = ""
        Else
            cboDTgroup.Enabled = True
        End If
    End Sub
    Private Sub CopyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject(dtgMaster.GetClipboardContent, False)
    End Sub
    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DV.RowFilter = Nothing
        DvColumnfilter = Nothing
        DVColumnValFilter = Nothing
        lblFilter.Text = "Filter By ==> "
        lblStatus.Visible = False
        lblFilter.Visible = False
    End Sub
    Private Sub dtMaster_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim x As DataGridView = sender
        Dim y As String = x.Columns.Item(x.CurrentCell.ColumnIndex).Name.ToString
        DVColumnValFilter = x.CurrentCell.Value.ToString
        If DvColumnfilter IsNot Nothing Then DvColumnfilter += " and "
        DvColumnfilter += String.Format("[{0}] like '{1}'", y, DVColumnValFilter)
        Try
            DV.RowFilter = DvColumnfilter
        Catch ex As Exception
            lblStatus_Click(sender:=Nothing, e:=Nothing)
            Exit Sub
        End Try

        lblStatus.Visible = True
        lblFilter.Visible = True
        lblFilter.Text += String.Format("{0} : {1} / ", y, DVColumnValFilter)
    End Sub
    Private Sub ListChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnCmd)
        Call ClearData()
        Call RandomPicture()
        cmdExport.Enabled = False
        For Each ctrl In CaseUnitList
            ErrorProvider1.SetError(ctrl, "")
        Next
    End Sub
    Sub ClearData()
        cx.ClearButton(pnCmd)
        dtgMaster.DataSource = Nothing
        dtgMaster.Dock = DockStyle.None
        dtgMaster.Visible = False
        CopyGrid.Enabled = False
        lblFilter.Text = "Filter By ==> "
        lblStatus.Visible = False
        lblFilter.Visible = False
        lblSQL.Text = Nothing
        lblSQL.Dock = DockStyle.None
        lblSQL.Visible = False
        CopylblSQL.Enabled = False
    End Sub
    Sub RandomPicture()
        Dim intPic As Integer
        Dim rand As New Random
        intPic = rand.Next(0, frmMain.ImageList1.Images.Count)
        pnGrid.BackgroundImage = frmMain.ImageList1.Images(intPic)
    End Sub
    Private Sub CaseDataReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            datareport = R1.Tag
            Select Case datareport
                Case 1
                    For Each ctrl In CaseUnitList
                        ctrl.Checked = False
                        ctrl.Enabled = False
                    Next
                Case 2
                    For Each ctrl In CaseUnitList
                        ctrl.Enabled = True
                    Next
            End Select
        End If
    End Sub
    Private Sub CaseCalendar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            CaseCalendar = R1.Tag
            Select Case R1.Tag
                Case 1
                    dtPickS.Enabled = True
                    dtPickE.Enabled = True
                    txtSM.Enabled = False
                    txtEM.Enabled = False
                    txtSY.Enabled = False
                    txtEY.Enabled = False
                    pnYcaseDate.Visible = True
                    pnYcaseMonthYear.Visible = False
                Case 2
                    dtPickS.Enabled = False
                    dtPickE.Enabled = False
                    txtSM.Enabled = True
                    txtEM.Enabled = True
                    txtSY.Enabled = True
                    txtEY.Enabled = True
                    pnYcaseDate.Visible = False
                    pnYcaseMonthYear.Visible = True
                Case 3
                    dtPickS.Enabled = False
                    dtPickE.Enabled = False
                    txtSM.Enabled = False
                    txtEM.Enabled = False
                    txtSY.Enabled = True
                    txtEY.Enabled = True
                    pnYcaseDate.Visible = False
                    pnYcaseMonthYear.Visible = True
                Case 4
                    dtPickS.Enabled = False
                    dtPickE.Enabled = False
                    txtSM.Enabled = True
                    txtEM.Enabled = False
                    txtSY.Enabled = True
                    txtEY.Enabled = True
                    pnYcaseDate.Visible = False
                    pnYcaseMonthYear.Visible = True
            End Select
        End If
    End Sub
    Sub CreateX1()
        Select Case datareport
            Case 2
                Dim CountCheck As Integer = 0
                For Each ctrl In CaseUnitList
                    If ctrl.Checked = True Then
                        CountCheck += 1
                    End If
                Next

                If CountCheck = 0 Then
                    XCheck = "Y"
                    MsgBox("Please choose your Report")
                    For Each ctrl In CaseUnitList
                        ErrorProvider1.SetError(ctrl, "Please choose me")
                        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Next
                    Exit Sub
                End If
        End Select

        XCheck = ""


        Select Case CaseCalendar
            Case 1
                DateS = dtPickS.Value.Date.ToString("yyyy/MM/dd")
                DateE = dtPickE.Value.Date.ToString("yyyy/MM/dd")
            Case 2
                DateS = String.Format("{0}/{1}/1", txtSY.Text, txtSM.Text)
                Select Case txtEM.Text
                    Case 1, 3, 5, 7, 8, 10, 12
                        DateE = String.Format("{0}/{1}/31", txtEY.Text, txtEM.Text)
                    Case 4, 6, 9, 11
                        DateE = String.Format("{0}/{1}/30", txtEY.Text, txtEM.Text)
                    Case 2
                        Select Case txtEY.Text Mod 4
                            Case 0
                                DateE = String.Format("{0}/{1}/29", txtEY.Text, txtEM.Text)
                            Case 1, 2, 3
                                DateE = String.Format("{0}/{1}/28", txtEY.Text, txtEM.Text)
                        End Select
                End Select
            Case 3
                DateS = String.Format("{0}/1/1", txtSY.Text)
                DateE = String.Format("{0}/12/31", txtEY.Text)
            Case 4
                DateS = String.Format("{0}/{1}/1", txtSY.Text, txtSM.Text)
                Select Case txtSM.Text
                    Case 1, 3, 5, 7, 8, 10, 12
                        DateE = String.Format("{0}/{1}/31", txtEY.Text, txtSM.Text)
                    Case 4, 6, 9, 11
                        DateE = String.Format("{0}/{1}/30", txtEY.Text, txtSM.Text)
                    Case 2
                        Select Case txtEY.Text Mod 4
                            Case 0
                                DateE = String.Format("{0}/{1}/29", txtEY.Text, txtSM.Text)
                            Case 1, 2, 3
                                DateE = String.Format("{0}/{1}/28", txtEY.Text, txtSM.Text)
                        End Select
                End Select
        End Select

    End Sub
    Private Sub CopylblSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject(lblSQL.Text, False)
    End Sub
    Private Sub cmdSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call ClearData()
        Call CreateX1()
        If XCheck = "Y" Then Exit Sub

        lblSQL.Visible = True
        lblSQL.Dock = DockStyle.Fill

        Select Case datareport
            Case 1
                X = String.Format("Exec plannings.dbo.Select_Downtime_Table_for_text '{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}'" _
                        , DateS, DateE, CaseColumnText.ToString, CaseUnitText.ToString, CaseCalendar, Product, DTGroup, MCno)
            Case 2
                X = String.Format("Exec plannings.dbo.Select_Downtime_for_Text '{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}'" _
                        , DateS, DateE, CaseColumnText.ToString, CaseUnitText.ToString, CaseCalendar, Product, DTGroup, MCno)
        End Select
        Dim XSql As New System.Text.StringBuilder("")
        XSql.Append(cx.ExecuteScalar(X))
        lblSQL.Text = XSql.ToString
        cmdExport.Enabled = False
        CopylblSQL.Enabled = True
    End Sub
    Private Sub CaseColumn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim R1 As CheckBox = sender
        If R1.Checked = True Then CaseColumnText.Append(R1.Tag) Else CaseColumnText.Replace(R1.Tag, "")
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo GetError

        Dim T1 As Date = Now()
        Call ClearData()
        Call RandomPicture()
        Call CreateX1()
        If XCheck = "Y" Then Exit Sub
       
        Me.Cursor = Cursors.WaitCursor

        Select Case datareport
            Case 1
                X = String.Format("Exec plannings.dbo.Select_Downtime_Table_for_program '{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}'" _
                                 , DateS, DateE, CaseColumnText.ToString, CaseUnitText.ToString, CaseCalendar, Product, DTGroup, MCno)
            Case 2
                X = String.Format("Exec plannings.dbo.Select_Downtime_for_program '{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}'" _
                                , DateS, DateE, CaseColumnText.ToString, CaseUnitText.ToString, CaseCalendar, Product, DTGroup, MCno)
        End Select
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView
        dtgMaster.DataSource = DV
        dtgMaster.Visible = True
        dtgMaster.Dock = DockStyle.Fill
        cx.GridToList(dtgMaster)
        dtgMaster.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

        cmdExport.Enabled = True
        cx.GetUserExecProg(My.Application.ToString, Me.Name.ToString, X, DateDiff(DateInterval.Second, T1, Now()))

        lblStatus_Click(sender:=Nothing, e:=Nothing)

        Me.Cursor = Cursors.Default
        CopyGrid.Enabled = True
        Exit Sub

GetError:
        cx.GetUserExecProgTimeout(My.Application.ToString, Me.Name.ToString, X, DateDiff(DateInterval.Second, T1, Now()))
        MsgBox("ข้อมูลที่คุณเลือกมีจำนวนมาก / Network อาจจะมีปัญหา" & Chr(13) & "ลองกด Excute ดูอีกสักครั้ง" & Chr(13) & "หรือ ลองเลือกรายงานให้น้อยลง")
        Me.Cursor = Cursors.Default


    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnCmd)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Downtime")
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgMaster, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub cboProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Product = cboProduct.SelectedValue
        Select Case Product
            Case ""
                cboMCno.DataSource = Nothing
                MCno = ""
            Case Else
                Dim x As String = String.Format("select distinct [mc no] as MCno from plannings.dbo.fact_downtime_table where [mc no]  is not null  and product = '{0}' order by [mc no] ", Product.ToString)
                Dim DT1 As DataTable = cx.GetdataTable(x)
                DT1.Rows.Add("")
                DT1.DefaultView.Sort = "MCno ASC"
                cboMCno.DisplayMember = "MCno"
                cboMCno.ValueMember = "MCno"
                cboMCno.DataSource = DT1
                MCno = ""
        End Select
    End Sub
    Private Sub cboDTgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DTGroup = cboDTgroup.SelectedValue
    End Sub
    Private Sub cboMCno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MCno = cboMCno.SelectedValue
    End Sub
End Class