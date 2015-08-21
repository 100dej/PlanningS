Public Class FrmGIAccount
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private Sub FrmGIAccount_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
        cmdSave.Enabled = False
        cmdExport.Enabled = False
    End Sub

    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        cx.ClearButton(pnHeader)
        cmdExport.Enabled = False
        DV = Nothing
        dtgItem.DataSource = Nothing
        Try
            dtgItem.Columns.Remove("Check")
        Catch ex As Exception

        End Try

        Dim cdl As New OpenFileDialog
        cdl.Filter = "File (*.xls)|*.xls"

        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim ds As DataSet
                ds = cx.GetdataExcel(cdl.FileName)
                DV = ds.Tables(0).DefaultView
                dtgItem.DataSource = DV
                cx.GridToList(dtgItem)
                Try
                    Do Until dtgItem.Columns.Count - 1 = 2
                        dtgItem.Columns.RemoveAt(dtgItem.Columns.Count - 1)
                    Loop
                Catch ex As Exception

                End Try
                cmdSave.Enabled = True
            Catch ex As Exception
                dtgItem.DataSource = Nothing
                cmdSave.Enabled = False
            End Try
        End If
        
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        cx.ClearButton(pnHeader)
        Try
            dtgItem.Columns.Remove("Check")
        Catch ex As Exception

        End Try

        dtgItem.Columns.Add("Check", "Check")

        For r As Integer = 0 To dtgItem.Rows.Count - 1
            Try
                Dim cmd As OleDbCommand = cx.CommandCreate("delete from tbm_600GiConsohAccount where Productcode = ? ", "T")
                cmd.Parameters(0).Value = dtgItem.Item(0, r).Value
                cx.Execute(cmd)
            Catch ex As Exception

            End Try
            
        Next

        For r As Integer = 0 To dtgItem.Rows.Count - 1
            Try
                Dim cmd As OleDbCommand = cx.CommandCreate("insert into tbm_600GiConsohAccount (Productcode,CostCenter,GLAccount,Uname) values (?,?,?,?)", "TTTT")
                cmd.Parameters(0).Value = dtgItem.Item(0, r).Value
                cmd.Parameters(1).Value = dtgItem.Item(1, r).Value
                cmd.Parameters(2).Value = dtgItem.Item(2, r).Value
                cmd.Parameters(3).Value = Uname
                Dim Z As Integer = cx.Execute(cmd)
                If Z = -99 Then
                    dtgItem.Item(3, r).Value = "Fail"
                Else
                    dtgItem.Item(3, r).Value = "OK"
                End If
            Catch ex As Exception
                MsgBox("ไม่สามารถนำข้อมูลเข้าระบบได้ โปรดลองอีกครั้ง และสังเกตุ Column Check ด้วย")
                cmdSave.Enabled = False
                Exit Sub
            End Try
        Next
        MsgBox("นำข้อมูล  เข้าระบบเรียบร้อย โปรดตรวจสอบ Column Check ว่า OK หรือไม่")
        cmdSave.Enabled = False
    End Sub

    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        cx.ClearButton(pnHeader)
        Try
            dtgItem.Columns.Remove("Check")
        Catch ex As Exception

        End Try
        cmdExport.Enabled = False
        cmdSave.Enabled = False
        DT = cx.GetdataTable("select * from tbm_600GiConsohAccount")
        dtgItem.DataSource = DT
        cx.GridToList(dtgItem)
        cmdExport.Enabled = True
    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        cx.ClearButton(pnHeader)
        Dim cdl As New SaveFileDialog
        cdl.FileName = "Account For GI"
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgItem, cdl.FileName, Chr(9))
        End If
    End Sub
End Class