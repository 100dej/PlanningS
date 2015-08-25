Public Class FrmMasterPlanning
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private DV As DataView ' สำหรับส่งค่า Dataview จาก Datable Form ต่าง ๆ ไปทำ chart
    Private DT As DataTable
    Private DateS As String '@Sdate
    Private DateE As String '@Edate
    Private mmatno As String '@mat
    Private mnameEng As String '@NEng
    Private mproduct As String
    Private mtype As String
    Private VUname As String ' @VUname
    Private Vname As String ' @Vname
    Private Xcase As Integer '@xcase => เลือกการ group Location    
    Private Scase As Integer
    Private ScaseT As String
    Private XcaseT As String
    Private DvColumnfilter As String
    Private DVColumnValFilter As String
    Private Xcase1RB As New List(Of RadioButton)
    Private Scase7RB As New List(Of RadioButton)
    Private ListOfControl As New List(Of Control)
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo ErrorTimeout
        Dim T1 As Date = Now()
        Call ClearData()
        Call RandomPicture()

        Me.Cursor = Cursors.WaitCursor

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


        Dim X1 As String
        X1 = String.Format("exec plannings.dbo.Table_MasterPlanning {0},{1},'{2}','{3}','{4}','{5}','{6}','{7}'", _
                           Scase, Xcase, mmatno, mnameEng, VUname, Vname, mproduct, mtype)

        Dim DS As DataSet = cx.GetdataSet(X1)
        DT = DS.Tables(0)

        DV = DT.DefaultView

        dtGridMatMaster.DataSource = DV
        cx.GridToList(dtGridMatMaster)
        dtGridMatMaster.Columns(4).Frozen = True
        cmdExport.Enabled = True

        Call DataTime()

        dtGridMatMaster.Visible = True
        dtGridMatMaster.Dock = DockStyle.Fill

        cx.GetUserExecProg(My.Application.ToString, Me.Name.ToString, X1, DateDiff(DateInterval.Second, T1, Now()))
        cx.Get_User_Function_CopyGrid(Uname, cbFunctionCopyGrid.Checked)

        lblStatus_Click(sender:=Nothing, e:=Nothing)

        Me.Cursor = Cursors.Default
        Exit Sub

ErrorTimeout:
        cx.GetUserExecProgTimeout(My.Application.ToString, Me.Name.ToString, X1, DateDiff(DateInterval.Second, T1, Now()))
        MsgBox("ข้อมูลที่คุณเลือกมีจำนวนมาก / Network อาจจะมีปัญหา" & Chr(13) & "ลองกด Excute ดูอีกสักครั้ง" & Chr(13) & "หรือ ลองเลือกรายงานให้น้อยลง")
        Me.Cursor = Cursors.Default
        Exit Sub


    End Sub
    Sub DataTime()
        Dim BalanceTime As Date
        BalanceTime = cx.ExecuteScalar("select top 1 mrundate from StockBalancePipeNow")
        lblFitting.Text = String.Format("Stock Pipe / Fitting at : {0}", BalanceTime)

        Select Case BalanceTime.Hour
            Case 5
                BalanceTime = BalanceTime.AddHours(3)
            Case 8
                BalanceTime = BalanceTime.AddHours(2)
            Case 10
                BalanceTime = BalanceTime.AddHours(3)
            Case 13
                BalanceTime = BalanceTime.AddHours(2).AddMinutes(30)
            Case 15
                BalanceTime = BalanceTime.AddDays(1).AddHours(-10)
        End Select
        lblFittingNext.Text = String.Format("Next Time : {0}", BalanceTime)
        If BalanceTime < Now Then
            lblFitting.ForeColor = Color.Gray
            lblFittingNext.ForeColor = Color.Red
        Else
            lblFitting.ForeColor = Color.Blue
            lblFittingNext.ForeColor = Color.Gray
        End If

        BalanceTime = cx.ExecuteScalar("select top 1 mrundate from StockBalanceProfileNow")
        lblPF.Text = String.Format("Stock Profiles at : {0}", BalanceTime)

        Select Case BalanceTime.Hour
            Case 6
                BalanceTime = BalanceTime.AddHours(3)
            Case 5
                BalanceTime = BalanceTime.AddHours(4)
            Case 9
                BalanceTime = BalanceTime.AddHours(1)
            Case 10
                BalanceTime = BalanceTime.AddHours(1)
            Case 11
                BalanceTime = BalanceTime.AddHours(1)
            Case 12
                BalanceTime = BalanceTime.AddHours(2)
            Case 14
                BalanceTime = BalanceTime.AddHours(1)
            Case 15
                BalanceTime = BalanceTime.AddDays(1).AddHours(-10)
        End Select
        lblPFNext.Text = String.Format("Next Time : {0}", BalanceTime)
        If BalanceTime < Now Then
            lblPF.ForeColor = Color.Gray
            lblPFNext.ForeColor = Color.Red
        Else
            lblPF.ForeColor = Color.Blue
            lblPFNext.ForeColor = Color.Gray
        End If

    End Sub
    Sub ClearData()
        cx.ClearButton(pnCmd)
        cx.ClearButton(pnScase2)
        dtGridMatMaster.DataSource = Nothing
        dtGridMatMaster.Dock = DockStyle.None
        dtGridMatMaster.Visible = False
    End Sub
    Sub RandomPicture()
        Dim intPic As Integer
        Dim rand As New Random
        intPic = rand.Next(0, frmMain.ImageList1.Images.Count)
        Panel3.BackgroundImage = frmMain.ImageList1.Images(intPic)
    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnCmd)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Master Planning by {0} ", XcaseT)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtGridMatMaster, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub FrmMatMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.ChangeCulture("en-US")
        cmdExport.Enabled = False
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)

        For Each ctrl As RadioButton In Me.Panel4.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf Xcase_CheckedChanged
            Xcase1RB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnScase0.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf Scase_CheckedChanged
            Scase7RB.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        AddHandler cboUname.SelectedValueChanged, AddressOf cboUname_SelectedValueChanged
        AddHandler cboVname.SelectedValueChanged, AddressOf cboVname_SelectedValueChanged
        AddHandler cboProduct.SelectedIndexChanged, AddressOf cboProduct_SelectedIndexChanged
        AddHandler cboMtype.SelectedIndexChanged, AddressOf cboMtype_SelectedIndexChanged
        AddHandler cboVname.Click, AddressOf cboVname_Click
        AddHandler cboUname.Click, AddressOf cboUname_Click
        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler dtGridMatMaster.DoubleClick, AddressOf dtGridMatMaster_DoubleClick
        AddHandler lblStatus.Click, AddressOf lblStatus_Click
        AddHandler cmdSetVariant.Click, AddressOf cmdSetVariant_Click
        AddHandler CopyGrid.Click, AddressOf CopyGrid_Click
        AddHandler cbFunctionCopyGrid.CheckedChanged, AddressOf cbFunctionCopyGrid_CheckedChanged

        Dim DT1 As DataTable = cx.GetdataTable("select Uname from tbl_103userFilterVariant group by Uname order by Uname")
        cboUname.DisplayMember = "Uname"
        cboUname.ValueMember = "Uname"
        cboUname.DataSource = DT1

        Try
            cboUname.SelectedValue = Uname
        Catch ex As Exception

        End Try

        Dim SSql As String = String.Format("select distinct mproduct from tbm_190Otherproductdetails  order by mproduct")
        Dim DT2 As DataTable = cx.GetdataTable(SSql)
        cboProduct.DisplayMember = "mproduct"
        cboProduct.ValueMember = "mproduct"
        cboProduct.DataSource = DT2

        cbFunctionCopyGrid.Checked = cx.Get_Function_CopyGrid(Uname)

        rb26.Checked = True

        lblFilter.Text = "Filter By ==> "
        lblStatus.Visible = False
        lblFilter.Visible = False

        dtGridMatMaster.Visible = False
        Call RandomPicture()
        Panel3.BackgroundImageLayout = ImageLayout.Zoom

        Call DataTime()

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
    Private Sub Xcase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        Call ClearData()
        Call RandomPicture()
        If R1.Checked = True Then
            Xcase = R1.Tag
            XcaseT = R1.Text
        End If
        cmdExport.Enabled = False
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
    Private Sub cboUname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If cboUname.SelectedValue = Nothing Then cboVname.DataSource = Nothing : VUname = Nothing : Exit Sub
        VUname = cboUname.SelectedValue
    End Sub
    Private Sub cboVname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Vname = cboVname.SelectedValue
    End Sub
    Private Sub cmdSetVariant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call ClearData()
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
                Dim SSql As String = String.Format("select distinct mtype from tbm_190Otherproductdetails  order by mtype")
                Dim DT1 As DataTable = cx.GetdataTable(SSql)
                cboMtype.DisplayMember = "mtype"
                cboMtype.ValueMember = "mtype"
                cboMtype.DataSource = DT1
            Case Else
                Dim SSql As String = String.Format("select distinct mtype from tbm_190Otherproductdetails where mproduct = '{0}' order by mtype", mproduct)
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
        Dim DT1 As DataTable = cx.GetdataTable("select Uname from tbl_103userFilterVariant group by Uname order by Uname")
        cboUname.DisplayMember = "Uname"
        cboUname.ValueMember = "Uname"
        cboUname.DataSource = DT1
    End Sub
    Private Sub cboVname_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        cboVname.DataSource = Nothing
        Dim SSql As String = String.Format("select Vname from tbl_103userFilterVariant where Uname = '{0}' group by Vname order by Vname", _
           cboUname.SelectedValue)
        Dim DT1 As DataTable = cx.GetdataTable(SSql)
        cboVname.DisplayMember = "Vname"
        cboVname.ValueMember = "Vname"
        cboVname.DataSource = DT1
    End Sub

    Private Sub CopyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject(dtGridMatMaster.GetClipboardContent, False)
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