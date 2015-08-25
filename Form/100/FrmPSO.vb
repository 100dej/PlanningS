Public Class FrmPSO
    'Private cx As New NPIData(NPIConnect.NPIRYSqlConnection)
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private DV As DataView
    Private DT As DataTable
    Private DateS As String '@Sdate
    Private DateE As String '@Edate
    Private mmatno As String '@mat
    Private mnameEng As String '@NEng
    Private mproduct As String
    Private mtype As String
    Private Comp As String  '@comp
    Private Plant As String  '@Plant
    Private Zone As String  '@Zone 
    Private Mattype As String '@mattype
    Private VUname As String ' @VUname
    Private Vname As String ' @Vname
    Private Vcase As Integer '@Vcase => เลือกข้อมูลต้น/ปลาย เดือน    
    Private Ycase As Integer '@Ycase => เลือกการ group วันที่
    Private Zcase As Integer '@Zcase => เลือกหน่วยของสินค้า
    Private Scase As Integer '@Scase => เลือกการ Filter mat
    Private xCrossYear As Integer
    Private VcaseT As String
    Private CaseCalendarText As String
    Private ZcaseT As String
    Private ScaseT As String
    Private X1 As String
    Private Xcheck As String
    Private DvColumnfilter As String
    Private DVColumnValFilter As String
    Private Zcase1RB As New List(Of RadioButton)
    Private Xcase2CB As New List(Of CheckBox)
    Private Vcase3RB As New List(Of RadioButton)
    Private CaseCalendar As New List(Of RadioButton)
    Private Wcase5RB As New List(Of RadioButton)
    Private Tcase6CB As New List(Of CheckBox)
    Private Scase7RB As New List(Of RadioButton)
    Private XButton As New List(Of Button)
    Private ListOfControl As New List(Of Control)
    Private ControlForm As New Dictionary(Of Integer, Control)
    Private CountCheck As Integer
    Private CaseReportText As New System.Text.StringBuilder("")
    Private ReportText As String = ""
    Private CaseColumnText As New System.Text.StringBuilder("")
    Private ColumnText As String = ""
    Private Sub FrmMatMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.ChangeCulture("en-US")

        For Each ctrl As Control In Me.pnCmd.Controls.OfType(Of Button)()
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnZcase.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Zcase_CheckedChanged
            Zcase1RB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As CheckBox In Me.pnXcase.Controls.OfType(Of CheckBox)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Xcase2CB_CheckedChanged
            Xcase2CB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnVcase.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Vcase_CheckedChanged
            Vcase3RB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnYcaseHeader.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Ycase_CheckedChanged
            CaseCalendar.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnWcase.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Wcase_CheckedChanged
            Wcase5RB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As CheckBox In Me.pnTcase.Controls.OfType(Of CheckBox)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Tcase6CB_CheckedChanged
            Tcase6CB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnScase0.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Scase_CheckedChanged
            Scase7RB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        AddHandler Splitter3.DoubleClick, AddressOf Splitter3_DoubleClick
        AddHandler dtGridMatMaster.DoubleClick, AddressOf dtGridMatMaster_DoubleClick
        AddHandler lblStatus.Click, AddressOf lblStatus_Click
        AddHandler cboUname.SelectedValueChanged, AddressOf cboUname_SelectedValueChanged
        AddHandler cboVname.SelectedValueChanged, AddressOf cboVname_SelectedValueChanged
        AddHandler cmdSetVariant.Click, AddressOf cmdSetVariant_Click
        AddHandler cmdChkField.Click, AddressOf cmdChkField_Click
        AddHandler cmdChkReport.Click, AddressOf cmdChkReport_Click
        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler cmdSQL.Click, AddressOf cmdSQL_Click
        AddHandler dtPickS.ValueChanged, AddressOf ListChanged
        AddHandler dtPickE.ValueChanged, AddressOf ListChanged
        AddHandler cboProduct.SelectedIndexChanged, AddressOf cboProduct_SelectedIndexChanged
        AddHandler cboMtype.SelectedIndexChanged, AddressOf cboMtype_SelectedIndexChanged
        AddHandler cboVname.Click, AddressOf cboVname_Click
        AddHandler cboUname.Click, AddressOf cboUname_Click
        AddHandler CopylblSQL.Click, AddressOf CopylblSQL_Click
        AddHandler CopyGrid.Click, AddressOf CopyGrid_Click
        AddHandler cbFunctionCopyGrid.CheckedChanged, AddressOf cbFunctionCopyGrid_CheckedChanged

        Select Case Now.Day
            Case 1
                dtPickS.Value = DateSerial(Now.Year, Now.Month - 1, 1)
            Case Else
                dtPickS.Value = DateSerial(Now.Year, Now.Month, 1)
        End Select
        dtPickE.Value = DateSerial(Now.Year, Now.Month, Now.Day - 1)

        Dim DT1 As DataTable = cx.GetdataTable("select Uname from plannings.dbo.tbl_103userFilterVariant group by Uname order by Uname")
        cboUname.DisplayMember = "Uname"
        cboUname.ValueMember = "Uname"
        cboUname.DataSource = DT1

        Try
            cboUname.SelectedValue = Uname
        Catch ex As Exception

        End Try

        Dim SSql As String = String.Format("select distinct mproduct from plannings.dbo.tbm_190Otherproductdetails  order by mproduct")
        Dim DT2 As DataTable = cx.GetdataTable(SSql)
        cboProduct.DisplayMember = "mproduct"
        cboProduct.ValueMember = "mproduct"
        cboProduct.DataSource = DT2

        rb13.Checked = True
        rb31.Checked = True
        rb42.Checked = True
        rb51.Checked = True
        rb71.Checked = True

        pnGrand.Height = 230

        Dim Dcontrol As DataTable = cx.GetdataTable(String.Format("Exec plannings.dbo.List_ControlForm'{0}'", Me.Name.ToString))
        For Each dr As DataRow In Dcontrol.Rows
            For Each ctrl As Control In ListOfControl
                If dr!ccontrol.ToString = ctrl.Name Then
                    ControlForm.Add(dr!rowid, ctrl)
                End If
            Next
        Next

        For i As Integer = 1 To ControlForm.Count
            ControlForm(i).Enabled = False
        Next


        cbFunctionCopyGrid.Checked = cx.Get_Function_CopyGrid(Uname)


        cmdChkReport.Text = "&All"

        txtSM.Text = 1
        txtEM.Text = 12

        txtSY.Text = Now.Year
        txtEY.Text = Now.Year

        lblFilter.Text = "Filter By ==> "
        lblStatus.Visible = False
        lblFilter.Visible = False

        Panel8.BackgroundImageLayout = ImageLayout.Zoom

        Call ClearData()
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)

        txtMat.Focus()

    End Sub
    Sub RandomPicture()
        Dim intPic As Integer
        Dim rand As New Random
        intPic = rand.Next(0, frmMain.ImageList1.Images.Count)
        Panel8.BackgroundImage = frmMain.ImageList1.Images(intPic)
    End Sub
    Sub CreateX1()
        If rb72.Checked = True And VUname = Nothing Then MsgBox("Please choose your varaint") : cboUname.Focus() : Exit Sub

        'Dim cmd As OleDbCommand = cx.CommandCreate("truncate table tmpCheckReport; truncate table tmpCheckField")
        'cx.Execute(cmd)

        CountCheck = 0
        'TCheck = ""
        For Each ctrl In Tcase6CB
            If ctrl.Checked = True Then
                'cmd = cx.CommandCreate("insert tmpCheckReport (Report) values (?)", "T")
                'cmd.Parameters(0).Value = ctrl.Tag
                'cx.Execute(cmd)
                'TCheck = String.Format("{0},{1}", ctrl.Tag, TCheck)
                CountCheck += 1
            End If
        Next

        If CountCheck = 0 Then
            MsgBox("Please choose your Report")
            Xcheck = "Y"
            For Each ctrl In Tcase6CB
                ErrorProvider1.SetError(ctrl, "Please choose me")
                ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Next
            Exit Sub
        End If

        CountCheck = 0
        Xcheck = ""
        For Each ctrl In Xcase2CB
            If ctrl.Checked = True Then
                'cmd = cx.CommandCreate("insert tmpCheckField (CField) values (?)", "T")
                'cmd.Parameters(0).Value = ctrl.Tag
                'cx.Execute(cmd)
                'XCheck = String.Format("{0},{1}", ctrl.Tag, XCheck)
                CountCheck += 1
            End If
        Next

        Select Case Scase
            Case 1
                mmatno = txtMat.Text
                mnameEng = txtEng.Text
            Case 2
                mmatno = ""
                mnameEng = ""
                mproduct = ""
                mtype = ""
        End Select

        If cbCrossYear.Checked Then
            xCrossYear = 1
        Else
            xCrossYear = 0
        End If

        Select Case Ycase
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
    Sub ClearData()
        cx.ClearButton(pnCmd)
        dtGridMatMaster.DataSource = Nothing
        dtGridMatMaster.Dock = DockStyle.None
        dtGridMatMaster.Visible = False
        lblSQL.Text = Nothing
        lblSQL.Dock = DockStyle.None
        lblSQL.Visible = False
        CopyGrid.Enabled = False
        CopylblSQL.Enabled = False
    End Sub
    Private Sub cmdSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call ClearData()
        Call CreateX1()
        If XCheck = "Y" Then Exit Sub

        lblSQL.Visible = True
        lblSQL.Dock = DockStyle.Fill

        X1 = String.Format("exec Select_Crosstab_PSO_X1 {0},{1},{2},{3},'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',{16},'{17}','{18}'", _
                           Scase, Vcase, Ycase, Zcase, DateS, DateE, mmatno, mnameEng, mproduct, mtype, Comp, Plant, Zone, Mattype, VUname, Vname, xCrossYear, _
                           ReportText, ColumnText)

        Dim XSql As New System.Text.StringBuilder("")
        XSql.Append(cx.ExecuteScalar(X1))
        lblSQL.Text = XSql.ToString
        cmdExport.Enabled = False
        CopylblSQL.Enabled = True
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo GetError

        Dim T1 As Date = Now()
        Call ClearData()
        Call CreateX1()
        Call RandomPicture()
        If XCheck = "Y" Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        X1 = String.Format("exec Exec_Crosstab_PSO_X1 {0},{1},{2},{3},'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',{16},'{17}','{18}'", _
                Scase, Vcase, Ycase, Zcase, DateS, DateE, mmatno, mnameEng, mproduct, mtype, Comp, Plant, Zone, Mattype, VUname, Vname, xCrossYear, _
                 ReportText, ColumnText)
        Dim DS As DataSet
        DS = cx.GetdataSet(X1)
        DT = DS.Tables(0)
        DV = DT.DefaultView()
        dtGridMatMaster.Visible = True
        dtGridMatMaster.Dock = DockStyle.Fill
        dtGridMatMaster.DataSource = DV
        cx.GridToList(dtGridMatMaster)
        Dim X2 As String = ""
        For i As Integer = 0 To CountCheck
            X2 += "T"
        Next
        If cbCrossYear.Checked = True Then X2 += "T"
        If cb210.Checked = True Then X2 += "TT" : CountCheck += 2
        X2 += "TG"
        If Len(X2) - 2 >= 6 Then dtGridMatMaster.Columns(6).Frozen = True Else dtGridMatMaster.Columns(CInt(Len(X2)) - 2).Frozen = True
        cx.GridFormatNew(dtGridMatMaster, X2.ToString)

        cmdExport.Enabled = True
        cx.GetUserExecProg(My.Application.ToString, Me.Name.ToString, X1, DateDiff(DateInterval.Second, T1, Now()))
        cx.Get_User_Function_CopyGrid(Uname, cbFunctionCopyGrid.Checked)

        lblStatus_Click(sender:=Nothing, e:=Nothing)

        Me.Cursor = Cursors.Default
        CopyGrid.Enabled = True
        Exit Sub

GetError:
        cx.GetUserExecProgTimeout(My.Application.ToString, Me.Name.ToString, X1, DateDiff(DateInterval.Second, T1, Now()))
        MsgBox("ข้อมูลที่คุณเลือกมีจำนวนมาก / Network อาจจะมีปัญหา" & Chr(13) & "ลองกด Excute ดูอีกสักครั้ง" & Chr(13) & "หรือ ลองเลือกรายงานให้น้อยลง")
        Me.Cursor = Cursors.Default
        Exit Sub

    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnCmd)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("{0} {1} {2} {3}", mmatno, ZcaseT, VcaseT, CaseCalendarText)

        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtGridMatMaster, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub ListChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnCmd)
        Call ClearData()
        Call RandomPicture()
        For Each ctrl In Tcase6CB
            ErrorProvider1.SetError(ctrl, "")
        Next
        cmdExport.Enabled = False
    End Sub
    Private Sub Zcase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            Zcase = R1.Tag
            ZcaseT = R1.Text
            Select Case R1.Tag
                Case 1
                    Select Case rb34.Checked
                        Case True
                            rb31.Checked = True
                    End Select
                    rb34.Enabled = False
                    cbCrossYear.Enabled = False
                    cbCrossYear.Checked = False
                Case Else
                    rb34.Enabled = True
                    cbCrossYear.Enabled = True
            End Select
        End If
    End Sub
    Private Sub Scase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            Scase = R1.Tag
            ScaseT = R1.Text
            Select Case R1.Tag
                Case 1
                    pnScase1.Visible = True
                    pnScase1.Dock = DockStyle.Fill
                    pnScase2.Visible = False
                    txtMat.Focus()
                Case 2
                    pnScase2.Visible = True
                    pnScase2.Dock = DockStyle.Fill
                    pnScase1.Visible = False
                    cboUname.Focus()
            End Select
        End If
    End Sub
    Private Sub Tcase6CB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As CheckBox = sender
        If R1.Checked = True Then CaseReportText.Append(R1.Tag & ",") Else CaseReportText.Replace(R1.Tag & ",", "")

        ReportText = CaseReportText.ToString
        If Microsoft.VisualBasic.Len(ReportText) > 0 Then
            ReportText = Microsoft.VisualBasic.Left(ReportText, Microsoft.VisualBasic.Len(ReportText) - 1)
        End If
    End Sub
    Private Sub Xcase2CB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As CheckBox = sender
        If R1.Checked = True Then CaseColumnText.Append(R1.Tag & ",") Else CaseColumnText.Replace(R1.Tag & ",", "")

        ColumnText = CaseColumnText.ToString
        If Microsoft.VisualBasic.Len(ColumnText) > 0 Then
            ColumnText = Microsoft.VisualBasic.Left(ColumnText, Microsoft.VisualBasic.Len(ColumnText) - 1)
        End If
    End Sub
    Private Sub Ycase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            Ycase = R1.Tag
            CaseCalendarText = R1.Text
            Select Case R1.Tag
                Case 1
                    dtPickS.Enabled = True
                    dtPickE.Enabled = True
                    txtSM.Enabled = False
                    txtEM.Enabled = False
                    txtSY.Enabled = False
                    txtEY.Enabled = False
                    pnVcase.Visible = False
                    pnYcaseDate.Visible = True
                    pnYcaseMonthYear.Visible = False
                Case 2
                    dtPickS.Enabled = False
                    dtPickE.Enabled = False
                    txtSM.Enabled = True
                    txtEM.Enabled = True
                    txtSY.Enabled = True
                    txtEY.Enabled = True
                    pnVcase.Visible = True
                    pnYcaseDate.Visible = False
                    pnYcaseMonthYear.Visible = True
                Case 3
                    dtPickS.Enabled = False
                    dtPickE.Enabled = False
                    txtSM.Enabled = False
                    txtEM.Enabled = False
                    txtSY.Enabled = True
                    txtEY.Enabled = True
                    pnVcase.Visible = True
                    pnYcaseDate.Visible = False
                    pnYcaseMonthYear.Visible = True
                Case 4
                    dtPickS.Enabled = False
                    dtPickE.Enabled = False
                    txtSM.Enabled = True
                    txtEM.Enabled = False
                    txtSY.Enabled = True
                    txtEY.Enabled = True
                    pnVcase.Visible = True
                    pnYcaseDate.Visible = False
                    pnYcaseMonthYear.Visible = True
            End Select
        End If
    End Sub
    Private Sub Vcase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            Vcase = R1.Tag
            VcaseT = R1.Text
        End If
    End Sub
    Private Sub Wcase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            Mattype = R1.Tag
        End If
    End Sub
    Private Sub Splitter3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If pnGrand.Height = pnZcase.Height Then pnGrand.Height = 230 Else pnGrand.Height = pnZcase.Height
    End Sub
    Private Sub dtGridMatMaster_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
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
    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DV.RowFilter = Nothing
        DvColumnfilter = Nothing
        DVColumnValFilter = Nothing
        lblFilter.Text = "Filter By ==> "
        lblStatus.Visible = False
        lblFilter.Visible = False
    End Sub
    Private Sub cmdChkReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each n In Tcase6CB
            If cmdChkReport.Text = "&All" And n.Enabled = True Then n.Checked = True Else n.Checked = False
        Next
        If cmdChkReport.Text = "&All" Then cmdChkReport.Text = "&Un" Else cmdChkReport.Text = "&All"
    End Sub
    Private Sub cmdChkField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each n In Xcase2CB
            If cmdChkField.Text = "A&ll" And n.Enabled = True Then n.Checked = True Else n.Checked = False
        Next
        If cmdChkField.Text = "A&ll" Then cmdChkField.Text = "U&n" Else cmdChkField.Text = "A&ll"
    End Sub
    Private Sub cboUname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If cboUname.SelectedValue = Nothing Then cboVname.DataSource = Nothing : VUname = Nothing : Exit Sub
        VUname = cboUname.SelectedValue
    End Sub
    Private Sub cboVname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Vname = cboVname.SelectedValue
    End Sub
    Private Sub cmdSetVariant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As Form
        For Each frm In frmMain.MdiChildren
            If (TypeOf frm Is FrmUserVariant) Then
                frm.Activate()
                Exit Sub
            End If
        Next
        Dim cf As New FrmUserVariant
        cf.Show(DockPanel)
    End Sub
    Private Sub cboProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mproduct = cboProduct.SelectedValue
        Select Case mproduct
            Case ""
                Dim SSql As String = String.Format("select distinct mtype from plannings.dbo.tbm_190Otherproductdetails  order by mtype")
                Dim DT1 As DataTable = cx.GetdataTable(SSql)
                cboMtype.DisplayMember = "mtype"
                cboMtype.ValueMember = "mtype"
                cboMtype.DataSource = DT1
            Case Else
                Dim SSql As String = String.Format("select distinct mtype from plannings.dbo.tbm_190Otherproductdetails where mproduct = '{0}' order by mtype", mproduct)
                Dim DT1 As DataTable = cx.GetdataTable(SSql)
                DT1.Rows.Add("")
                DT1.DefaultView.Sort = "mtype ASC"
                cboMtype.DisplayMember = "mtype"
                cboMtype.ValueMember = "mtype"
                cboMtype.DataSource = DT1
        End Select
    End Sub
    Private Sub cboMtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mtype = cboMtype.SelectedValue
    End Sub
    Private Sub cboUname_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        cboUname.DataSource = Nothing
        Dim DT1 As DataTable = cx.GetdataTable("select Uname from plannings.dbo.tbl_103userFilterVariant group by Uname order by Uname")
        cboUname.DisplayMember = "Uname"
        cboUname.ValueMember = "Uname"
        cboUname.DataSource = DT1
    End Sub
    Private Sub cboVname_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        cboVname.DataSource = Nothing
        Dim SSql As String = String.Format("select Vname from plannings.dbo.tbl_103userFilterVariant where Uname = '{0}' group by Vname order by Vname", _
           cboUname.SelectedValue)
        Dim DT1 As DataTable = cx.GetdataTable(SSql)
        cboVname.DisplayMember = "Vname"
        cboVname.ValueMember = "Vname"
        cboVname.DataSource = DT1
    End Sub
    Private Sub CopyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject(dtGridMatMaster.GetClipboardContent, False)
    End Sub
    Private Sub CopylblSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject(lblSQL.Text, False)
    End Sub
    Private Sub cbFunctionCopyGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cb As CheckBox = sender
        Clipboard.Clear()
        Select Case cb.Checked
            Case True
                dtGridMatMaster.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Case False
                dtGridMatMaster.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        End Select
    End Sub
End Class