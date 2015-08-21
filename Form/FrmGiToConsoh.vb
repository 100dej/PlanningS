Imports System.Data.SqlClient
Public Class FrmGiToConsoh
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private dgvColumnHeader As DGVColumnHeader
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        cx.ClearButton(Panel1)
        Try
            dtgItem.Columns.Remove("Check")
        Catch ex As Exception

        End Try

        Me.Cursor = Cursors.WaitCursor

        dtgItem.Columns.Add("Check", "Check")

        Dim r1 As Integer = 0
        For r As Integer = 0 To dtgItem.Rows.Count - 1
            If Me.dtgItem.Rows(r).Cells(0).Value = "true" Then
                r1 += 1
            End If
        Next

        If r1 = 0 Then MsgBox("คุณไม่ได้เลือกรายการเลย", , "เลือกอย่างน้อย 1 รายการ") : Me.Cursor = Cursors.Default : Exit Sub

        Dim tmpID As Integer
        Dim Result As String
        Dim movementtype As String
        Dim x As String = cx.ExecuteScalar("select MAX (orderno) from [172.18.8.188].NPIconsohPD.dbo.tbt_giinusedheader")
        tmpID = Convert.ToInt32(x.ToString().Substring(4, 4))
        Result = (x.ToString().Substring(0, 4) & (tmpID + 1).ToString("0000"))

        Dim c = cx.ExecuteScalar("Select Giinusedorderno from tbt_600GiToConsoh where headertext = '" & txtOrder.Text & "'")
        If String.IsNullOrEmpty(c.ToString) Then
            movementtype = "201"
        Else
            movementtype = "261"
        End If

        Dim cmd As OleDbCommand
        cmd = cx.CommandCreate("insert into [172.18.8.188].NPIconsohPD.dbo.tbt_giinusedheader (OrderNo,OrderStatus,WHCode,MovementType,DocumentDate, " & _
                               "RequestByWHCode,RequestByWHName,CreateBy,HeaderText) values (?,?,?,?,?,?,?,?,?)", "TTTTDTTIT")
        cmd.Parameters(0).Value = Result
        cmd.Parameters(1).Value = "New"
        cmd.Parameters(2).Value = txtWhCode.Text
        cmd.Parameters(3).Value = movementtype
        cmd.Parameters(4).Value = Now()
        cmd.Parameters(5).Value = "106"
        cmd.Parameters(6).Value = "RY - ประกอบสินค้า"
        cmd.Parameters(7).Value = 195
        cmd.Parameters(8).Value = txtOrder.Text
        cx.Execute(cmd)

        For r As Integer = 0 To dtgItem.Rows.Count - 1
            Me.dtgItem.EndEdit()
            'Dim re_value As String = Me.dtgItem.Rows(r).Cells(0).EditedFormattedValue.ToString()
            Try
                If Me.dtgItem.Rows(r).Cells(0).Value = "true" Then
                    cmd = cx.CommandCreate("insert into [172.18.8.188].NPIconsohPD.dbo.tbt_giinusedDetail (OrderNo,ItemNo,ProductCode,OrderQty,Unit, " & _
                    "GLAccount,GIInUsedOrderNo,CostCenter) values (?,?,?,?,?,?,?,?) ", "TITITTTT")
                    cmd.Parameters(0).Value = Result
                    cmd.Parameters(1).Value = dtgItem.Item("itemNo", r).Value
                    cmd.Parameters(2).Value = dtgItem.Item("Productcode", r).Value
                    cmd.Parameters(3).Value = dtgItem.Item("OrderQty", r).Value
                    cmd.Parameters(4).Value = dtgItem.Item("Unit", r).Value
                    cmd.Parameters(5).Value = dtgItem.Item("GLAccount", r).Value
                    cmd.Parameters(6).Value = dtgItem.Item("Giinusedorderno", r).Value
                    cmd.Parameters(7).Value = dtgItem.Item("CostCenter", r).Value

                    Dim Z As Integer = cx.Execute(cmd)
                    If Z = -99 Then
                        dtgItem.Item("Check", r).Value = "Fail"
                        dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                    Else
                        dtgItem.Item("Check", r).Value = "OK"
                    End If
                End If
            Catch ex As Exception
                MsgBox("ไม่สามารถนำข้อมูลเข้าระบบได้ โปรดลองอีกครั้ง และสังเกตุ Column Check ด้วย")
                cmdSave.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
        Next

        cmd = cx.CommandCreate("Update tbt_600GiToConsoh set Orderno = ? , UnameConfirm = ? , ConfirmDate  = ? where HeaderText = ?", "TTDT")
        cmd.Parameters(0).Value = Result
        cmd.Parameters(1).Value = Uname
        cmd.Parameters(2).Value = Now()
        cmd.Parameters(3).Value = txtOrder.Text
        cx.Execute(cmd)

        MsgBox("นำข้อมูล Order " & txtOrder.Text & " เข้า ConSoh เรียบร้อย ได้เลข " & Result.ToString & " โปรดตรวจสอบ Column Check ว่า OK หรือไม่")
        cmdSave.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExec.Click
        cx.ClearButton(Panel1)

        dtgItem.DataSource = Nothing
        lblWarning.Text = ""

        Try
            dtgItem.Columns.RemoveAt(0)
        Catch ex As Exception

        End Try

        Try
            dtgItem.Columns.Remove("Check")
        Catch ex As Exception

        End Try

        If txtOrder.Enabled = False Then txtOrder.Enabled = True : txtWhCode.Enabled = True : Exit Sub

        Dim A As String = txtWhCode.Text
        If A = String.Empty Then MsgBox("ยังไม่ใส่รหัส Wh Code") : txtWhCode.Focus() : Exit Sub
        If A <> "113" And A <> "117" Then MsgBox("Wh code ใส่เฉพาะ 113 หรือ 117") : txtWhCode.Focus() : Exit Sub

        A = txtOrder.Text
        If A = String.Empty Then MsgBox("ยังไม่ใส่เลข Order") : txtOrder.Focus() : Exit Sub

        Dim B As String = cx.ExecuteScalar("Select headertext from tbt_600GiToConsoh where headertext = '" & A & "'")
        If String.IsNullOrEmpty(B) Then MsgBox("ไม่มีเลข Order นี้ในระบบ") : txtOrder.Focus() : Exit Sub

        Dim C = cx.ExecuteScalar("Select Orderno from tbt_600GiToConsoh where headertext = '" & A & "'")
        If Not IsDBNull(C) Then lblWarning.Text = "โปรดระวัง Order " & A & " เคยนำเข้า Consoh แล้ว ได้เลข " & C : MsgBox(lblWarning.Text)

        Me.Cursor = Cursors.WaitCursor

        dgvColumnHeader = New DGVColumnHeader()
        dtgItem.Columns.Insert(0, New DataGridViewCheckBoxColumn())
        dtgItem.Columns(0).HeaderCell = dgvColumnHeader

        Dim DT As DataTable = cx.GetdataTable("select A.Headertext,A.itemNo,A.Productcode,B.mmateng,A.OrderQty,A.Unit,A.GLAccount,A.CostCenter,A.Giinusedorderno " & _
                " from tbt_600GiToConsoh A left join DBWMS.dbo.vmsa140_product_basic B on a.productcode = B.mmatno where A.Headertext ='" & A & "'" & _
                " order by itemno ")
        dtgItem.DataSource = DT
        cx.GridToList(dtgItem)

        For r As Integer = 0 To dtgItem.Rows.Count - 1
            If IsDBNull(dtgItem.Item("GLAccount", r).Value) Or IsDBNull(dtgItem.Item("CostCenter", r).Value) Then
                MsgBox("ข้อมูลบัญชีไม่สมบูรณ์ ไม่สามารถ Interface ConSoh ได้")
                dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                cmdSave.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            ElseIf IsDBNull(dtgItem.Item("OrderQty", r).Value) Then
                MsgBox("ข้อมูลจำนวนเบิกไม่ถูกต้อง ไม่สามารถ Interface Consoh ได้")
                dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                cmdSave.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            ElseIf dtgItem.Item("OrderQty", r).Value = 0 Then
                MsgBox("ข้อมูลจำนวนเบิกไม่ถูกต้อง ไม่สามารถ Interface Consoh ได้")
                dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                cmdSave.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                txtWhCode.Enabled = False
                txtOrder.Enabled = False
                cmdSave.Enabled = True
            End If
        Next
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub FrmGiToConsoh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
        cmdSave.Enabled = False
        lblWarning.BorderStyle = BorderStyle.None
        lblWarning.Text = ""
        lblWarning.ForeColor = Color.Red
    End Sub
    Private Sub dtgItem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgItem.CellClick
        If e.ColumnIndex = 0 Then
            If e.RowIndex >= 0 Then
                Me.dtgItem.EndEdit()
                Dim re_value As String = Me.dtgItem.Rows(e.RowIndex).Cells(0).EditedFormattedValue.ToString()
                If Me.dtgItem.Rows(e.RowIndex).Cells(0).Value = "true" Then Me.dtgItem.Rows(e.RowIndex).Cells(0).Value = "False" Else Me.dtgItem.Rows(e.RowIndex).Cells(0).Value = "true"
            End If
        End If
    End Sub
    Private Sub dtgItem_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgItem.ColumnHeaderMouseClick
        If e.ColumnIndex = 0 Then
            For i As Integer = 0 To dtgItem.Rows.Count - 1
                Me.dtgItem.EndEdit()
                Dim re_value As String = Me.dtgItem.Rows(i).Cells(0).EditedFormattedValue.ToString()
                dtgItem.Rows(i).Cells(0).Value = dgvColumnHeader.CheckAll
            Next
        End If
    End Sub
End Class