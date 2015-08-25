Public Class frmpregivercctr
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Dim HeaderText As String
    Private Sub FrmPreGI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
        cmdSave.Enabled = False
    End Sub
    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        cx.ClearButton(pnHeader)
        DV = Nothing
        dtgItem.DataSource = Nothing
        Try
            dtgItem.Columns.Remove("Check")
        Catch ex As Exception

        End Try
        Try
            dtgItem.Columns.Remove("ItemNo")
        Catch ex As Exception

        End Try

        If txtOrder.Enabled = False Or txtVersion.Enabled = False Then txtOrder.Enabled = True : txtVersion.Enabled = True : Exit Sub

        HeaderText = String.Format("{0}-{1}", UCase(txtOrder.Text), UCase(txtVersion.Text))
        If txtOrder.Text.Count <> 7 Then MsgBox("ใส่ Order ไม่ครบ 7 หลัก") : txtOrder.Focus() : Exit Sub
        If String.IsNullOrEmpty(txtVersion.Text) Then MsgBox("กรุณาใส่ Version") : txtVersion.Focus() : Exit Sub


        Dim Date1 As Date = cx.ExecuteScalar("select xDate from plannings.dbo.tbt_600GiToConsoh where Headertext = '" & HeaderText & "'")
        If Date1 = Nothing Then
            Dim cdl As New OpenFileDialog
            cdl.Filter = "File (*.xls)|*.xls"

            If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Dim ds As DataSet
                    ds = cx.GetdataExcel(cdl.FileName)
                    DV = ds.Tables(0).DefaultView
                    dtgItem.Columns.Add("ItemNo", "ItemNo")
                    dtgItem.DataSource = DV
                    cx.GridToList(dtgItem)

                    For r As Integer = 0 To dtgItem.Rows.Count - 1
                        dtgItem.Item(0, r).Value = r + 1
                    Next

                    If dtgItem.Columns.Count - 1 < 3 Then
                        MsgBox("File ที่นำเข้าไม่ถูกต้อง")
                        dtgItem.DataSource = Nothing
                        cmdSave.Enabled = False
                        Exit Sub
                    Else
                        Try
                            Do Until dtgItem.Columns.Count - 1 = 3
                                dtgItem.Columns.RemoveAt(dtgItem.Columns.Count - 1)
                            Loop
                        Catch ex As Exception

                        End Try
                    End If

                    Dim cmd As OleDbCommand
                    cmd = cx.CommandCreate("truncate table plannings.dbo.tbt_600preGiToConsoh")
                    cx.Execute(cmd)

                    For r As Integer = 0 To dtgItem.Rows.Count - 1
                        Try
                            cmd = cx.CommandCreate("insert into plannings.dbo.tbt_600preGiToConsoh (HeaderText,itemNo,Productcode,OrderQty,Costcenter) values (?,?,?,?,?)", "TITIT")
                            Dim P0 As Integer = dtgItem.Item("itemNo", r).Value
                            Dim P1 As String = dtgItem.Item(1, r).Value
                            Dim P2 As Integer = dtgItem.Item(2, r).Value
                            Dim P3 As String = dtgItem.Item(3, r).Value
                            cmd.Parameters(0).Value = HeaderText
                            cmd.Parameters(1).Value = P0
                            cmd.Parameters(2).Value = P1
                            cmd.Parameters(3).Value = P2
                            cmd.Parameters(4).Value = P3
                            cx.Execute(cmd)
                        Catch ex As Exception
                            MsgBox("ต้องใส่ Cost center ใน file excel ด้วยครับ")
                            Exit Sub
                        End Try
                    Next

                    Try
                        dtgItem.Columns.Remove("ItemNo")
                    Catch ex As Exception

                    End Try
                    DV = Nothing
                    dtgItem.DataSource = Nothing
                    DT = cx.GetdataTable("select a.*,c.baseunit, b.GlAccount  from plannings.dbo.tbt_600preGiToConsoh A " & _
                     "left join plannings.dbo.tbm_600GiConsohAccount B on a.productcode = B.productcode " & _
                     "left join [172.18.8.188].npiconsohpd.dbo.tbm_product C on a.productcode = c.productcode ")
                    dtgItem.DataSource = DT
                    cx.GridToList(dtgItem)

                    For r As Integer = 0 To dtgItem.Rows.Count - 1
                        If IsDBNull(dtgItem.Item("GlAccount", r).Value) Or IsDBNull(dtgItem.Item("CostCenter", r).Value) Then
                            MsgBox("แจ้งบัญชีให้ update Account ก่อนครับ")
                            dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                            cmdSave.Enabled = False
                            Exit Sub
                        ElseIf IsDBNull(dtgItem.Item("OrderQty", r).Value) Then
                            MsgBox("ใส่จำนวนเบิกไม่ถูกต้อง")
                            dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                            cmdSave.Enabled = False
                            Exit Sub
                        ElseIf IsDBNull(dtgItem.Item("CostCenter", r).Value) Then
                            MsgBox("ต้องใส่ costcenter ใน Excel ด้วย")
                            dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                            cmdSave.Enabled = False
                            Exit Sub
                        ElseIf dtgItem.Item("CostCenter", r).Value.ToString.Count < 10 Then
                            MsgBox("Costcenter ใส่ไม่ถูกต้อง")
                            dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                            cmdSave.Enabled = False
                            Exit Sub
                        ElseIf Microsoft.VisualBasic.Left(dtgItem.Item("CostCenter", r).Value, 6).ToString <> "0871-6" Then
                            MsgBox("Costcenter ใส่ไม่ถูกต้อง xx")
                            dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                            cmdSave.Enabled = False
                            Exit Sub
                        ElseIf dtgItem.Item("OrderQty", r).Value = 0 Then
                            MsgBox("ใส่จำนวนเบิกไม่ถูกต้อง")
                            dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                            cmdSave.Enabled = False
                            Exit Sub
                        ElseIf IsDBNull(dtgItem.Item("baseunit", r).Value) Then
                            MsgBox("ระบบมีปัญหา โปรดลองอีกครั้งนึง หรือติดต่อ พงศ์เดช เบอร์ 216")
                            dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                            cmdSave.Enabled = False
                            Exit Sub
                        Else
                            cmdSave.Enabled = True
                        End If
                    Next

                    txtOrder.Enabled = False
                    txtVersion.Enabled = False
                Catch ex As Exception
                    dtgItem.DataSource = Nothing
                    cmdSave.Enabled = False
                    txtOrder.Enabled = True
                    txtVersion.Enabled = True
                End Try
            End If
        Else
            MsgBox("Order " & HeaderText & " เคยมีการเบิกไปแล้วเมื่อ  " & Date1)
            cmdSave.Enabled = False
            txtOrder.Enabled = True
            txtVersion.Enabled = True
            Exit Sub

        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        cx.ClearButton(pnHeader)
        Try
            dtgItem.Columns.Remove("Check")
        Catch ex As Exception

        End Try

        Me.Cursor = Cursors.WaitCursor

        dtgItem.Columns.Add("Check", "Check")
        For r As Integer = 0 To dtgItem.Rows.Count - 1
            Try
                Dim cmd As OleDbCommand = cx.CommandCreate("insert into tbt_600GiToConsoh " & _
                    "(Uname,HeaderText,itemNo,Productcode,OrderQty,unit,GLaccount,Costcenter) " & _
                    " values (?,?,?,?,?,?,?,?)", "TTITITTT")
                cmd.Parameters(0).Value = Uname
                cmd.Parameters(1).Value = dtgItem.Item("HeaderText", r).Value
                cmd.Parameters(2).Value = dtgItem.Item("itemNo", r).Value
                cmd.Parameters(3).Value = dtgItem.Item("Productcode", r).Value
                cmd.Parameters(4).Value = dtgItem.Item("OrderQty", r).Value
                cmd.Parameters(5).Value = dtgItem.Item("baseunit", r).Value
                cmd.Parameters(6).Value = dtgItem.Item("GLaccount", r).Value
                cmd.Parameters(7).Value = dtgItem.Item("Costcenter", r).Value
                Dim Z As Integer = cx.Execute(cmd)
                If Z = -99 Then
                    dtgItem.Item("Check", r).Value = "Fail"
                    dtgItem.Rows(r).DefaultCellStyle.BackColor = Color.Red
                Else
                    dtgItem.Item("Check", r).Value = "OK"
                End If
            Catch ex As Exception
                MsgBox("ไม่สามารถนำข้อมูลเข้าระบบได้ โปรดลองอีกครั้ง และสังเกตุ Column Check ด้วย")
                cmdSave.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
        Next
        MsgBox("นำข้อมูล Order " & HeaderText & " เข้าระบบเรียบร้อย โปรดตรวจสอบ Column Check ว่า OK หรือไม่")
        cmdSave.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub
End Class