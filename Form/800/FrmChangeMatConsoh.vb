Public Class FrmChangeMatConsoh
    Dim cx As New NPIData(NPIConnect.Consoh)
    Dim x As String = ""
    Dim cmd As OleDbCommand
    Private Sub FrmChangeMatConsoh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler cmdImportData.Click, AddressOf NpiButton1_Click
        AddHandler cmdExportBin.Click, AddressOf NpiButton2_Click
        AddHandler cmdExportStock.Click, AddressOf NpiButton3_Click
        AddHandler cmdSave.Click, AddressOf cmdSave_Click

        cmdExportBin.Enabled = False
        cmdExportStock.Enabled = False
        cmdSave.Enabled = False

    End Sub
    Private Sub NpiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(Panel1)
        cx.ClearButton(Panel3)
        cx.ClearButton(Panel4)
        dtgMaster.DataSource = Nothing
        dtgChangeStock.DataSource = Nothing
        dtgChangeBin.DataSource = Nothing
        cmdExportBin.Enabled = False
        cmdExportStock.Enabled = False
        cmdSave.Enabled = False

        Dim cdl As New OpenFileDialog
        cdl.Filter = "File (*.xls)|*.xls"

        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim ds As DataSet
                ds = cx.GetdataExcel(cdl.FileName)
                DV = ds.Tables(0).DefaultView
                dtgMaster.DataSource = DV
                cx.GridToList(dtgMaster)
                Try
                    Do Until dtgMaster.Columns.Count - 1 = 2
                        dtgMaster.Columns.RemoveAt(dtgMaster.Columns.Count - 1)
                    Loop
                Catch ex As Exception

                End Try
            Catch ex As Exception
                dtgMaster.DataSource = Nothing
            End Try
        End If

        For i As Integer = 0 To dtgMaster.Columns.Count - 1
            Select Case i
                Case 0
                    If dtgMaster.Columns.Item(i).Name.ToString <> "WHCode" Then
                        MsgBox("ชื่อ Column แรกต้อง = WHCode")
                        cmdExportBin.Enabled = False
                        cmdExportStock.Enabled = False
                        cmdSave.Enabled = False
                        Exit Sub
                    End If
                Case 1
                    If dtgMaster.Columns.Item(i).Name.ToString <> "MatOld" Then
                        MsgBox("ชื่อ Column ที่สองต้อง = MatOld")
                        cmdExportBin.Enabled = False
                        cmdExportStock.Enabled = False
                        cmdSave.Enabled = False
                        Exit Sub
                    End If
                Case 2
                    If dtgMaster.Columns.Item(i).Name.ToString <> "MatNew" Then
                        MsgBox("ชื่อ Column ที่สามต้อง = MatNew")
                        cmdExportBin.Enabled = False
                        cmdExportStock.Enabled = False
                        cmdSave.Enabled = False
                        Exit Sub
                    End If
            End Select
        Next

        x = String.Format("Exec Truncate_Change_mat_Stock ''")
        cmd = cx.CommandCreate(x)
        cx.Execute(cmd)

        For r As Integer = 0 To dtgMaster.Rows.Count - 1
            Try
                x = String.Format("Exec Change_mat_Stock '{0}','{1}','{2}','{3}','{4}','{5}' ", _
                                  dtgMaster.Item("WHCode", r).Value, dtgMaster.Item("MatOld", r).Value, dtgMaster.Item("MatNew", r).Value, _
                                  Uname, hostname, ipaddress)
                cmd = cx.CommandCreate(x)
                cx.Execute(cmd)
            Catch ex As Exception
                MsgBox("เอาข้อมูลเข้าระบบไม่ได้ ลองใหม่อีกที")
                cmdExportBin.Enabled = False
                cmdExportStock.Enabled = False
                cmdSave.Enabled = False
                Exit Sub
            End Try
        Next

        x = String.Format("exec Select_Bin_mat_Change ''")
        Dim dt1 As DataTable = cx.GetdataTable(x)
        dtgChangeBin.DataSource = dt1
        cx.GridToList(dtgChangeBin)

        x = String.Format("exec Select_Stock_mat_Change ''")
        Dim dt As DataTable = cx.GetdataTable(x)
        dtgChangeStock.DataSource = dt
        cx.GridToList(dtgChangeStock)

        cmdExportBin.Enabled = True
        cmdExportStock.Enabled = True
        cmdSave.Enabled = True


    End Sub

    Private Sub NpiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(Panel1)
        cx.ClearButton(Panel3)
        cx.ClearButton(Panel4)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Change mat in bin by {0} {1}", Uname, Now.ToString("yyyy-MM-dd"))

        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgChangeBin, cdl.FileName, Chr(9))
        End If
    End Sub

    Private Sub NpiButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(Panel1)
        cx.ClearButton(Panel3)
        cx.ClearButton(Panel4)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Change mat in stock by {0} {1}", Uname, Now.ToString("yyyy-MM-dd"))

        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgChangeStock, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(Panel1)
        cx.ClearButton(Panel3)
        cx.ClearButton(Panel4)

        Dim xKeyConfirm As String = "แมนยูอ่อน!!!"
        Dim xUserKey As String = InputBox("จำไม่ได้ ก็ช่วยไม่ได้", "ใส่ Password")
        If xKeyConfirm <> xUserKey Then
            MsgBox("อ่อนก็ยอมรับมา", MsgBoxStyle.Critical, "ชัวร์")
            Exit Sub
        Else
            x = String.Format("Exec Update_Change_mat ''")
            cmd = cx.CommandCreate(x)
            Dim y As Integer = cx.Execute(cmd)
            If y = -99 Then
                MsgBox("น่าจะมีปัญหา")
            Else
                MsgBox("ข้อมูลแก้ไขเรียบร้อย")
                cmdSave.Enabled = False
            End If
        End If
    End Sub
End Class