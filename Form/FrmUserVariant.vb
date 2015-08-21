Public Class FrmUserVariant
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Dim DT As DataTable
    Dim DV As DataView
    Dim S As String
    Dim Vname As String
    Dim VUname As String
    Dim cmd As OleDbCommand
    Private Sub S_Event()
        cx.ClearButton(pnHeader)
        Select Case S
            Case "Display"
                cx.GridToList(dtgVariantDetails)
                txtVname.Enabled = False
                cmdNew.Enabled = True
                cmdImport.Enabled = True
                If VUname = Uname Then
                    cmdDelete.Enabled = True
                    cmdChange.Enabled = True
                Else
                    cmdChange.Enabled = False
                    cmdDelete.Enabled = False
                End If
                If IsNothing(dtgVariantDetails.DataSource) Then cmdCopy.Enabled = False Else cmdCopy.Enabled = True
                cmdCancel.Enabled = False
                cmdSave.Enabled = False
            Case "New"
                VUname = Uname
                lblVarUser.Text = String.Format("User : {0}", VUname)
                txtVname.Text = Nothing
                txtVname.Enabled = True
                txtVname.Focus()
                With dtgVariantDetails
                    .DataSource = Nothing
                    .Columns.Add("mprodh", "mprodh")
                    .Columns.Add("mmatno", "mmatno")
                    .Columns.Add("mmateng", "mmateng")
                    .Columns.Add("mmattype", "mmattype")
                End With
                cx.GridToKey(dtgVariantDetails)
                For Each ctrl As Button In Me.pnHeader.Controls.OfType(Of Button)()
                    ctrl.Enabled = False
                Next
                cmdCancel.Enabled = True
                cmdSave.Enabled = True
            Case "Import"
                VUname = Uname
                Dim cdl As New OpenFileDialog
                cdl.Filter = "File (*.xls)|*.xls"

                If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        Dim ds As DataSet
                        ds = cx.GetdataExcel(cdl.FileName)
                        DV = ds.Tables(0).DefaultView
                        dtgVariantDetails.DataSource = DV
                        cx.GridToList(dtgVariantDetails)
                        Try
                            Do Until dtgVariantDetails.Columns.Count - 1 = 3
                                dtgVariantDetails.Columns.RemoveAt(dtgVariantDetails.Columns.Count - 1)
                            Loop
                        Catch ex As Exception

                        End Try
                        For Each ctrl As Button In Me.pnHeader.Controls.OfType(Of Button)()
                            ctrl.Enabled = False
                        Next
                        lblVarUser.Text = String.Format("User : {0}", Uname)
                        txtVname.Text = Nothing
                        txtVname.Enabled = True
                        txtVname.Focus()
                        cmdCancel.Enabled = True
                        cmdSave.Enabled = True
                    Catch ex As Exception
                        dtgVariantDetails.DataSource = Nothing
                        For Each ctrl As Button In Me.pnHeader.Controls.OfType(Of Button)()
                            ctrl.Enabled = True
                        Next
                        cmdCancel.Enabled = False
                        cmdSave.Enabled = False
                    End Try
                End If
        End Select
    End Sub
    Private Sub FrmUserVariant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DT = cx.GetdataTable("Select Uname,Vname from tbl_103userFilterVariant group by Uname,Vname")
        DV = DT.DefaultView
        dtgMasterVariant.DataSource = DV
        cx.GridToList(dtgMasterVariant)

        S = "Display"
        S_Event()

    End Sub
    Private Sub dtgMasterVariant_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgMasterVariant.DoubleClick
        Try
            dtgVariantDetails.Columns.Clear()
        Catch ex As Exception

        End Try

        Dim x As DataGridView = sender
        VUname = x.Item(0, x.CurrentRow.Index).Value.ToString
        Vname = x.Item(1, x.CurrentRow.Index).Value.ToString

        DT = cx.GetdataTable(String.Format("Select mprodh,mmatno,mmateng,mmattype from tbl_103userFilterVariant where Vname = '{0}' and Uname = '{1}'", Vname, VUname))
        DV = DT.DefaultView
        dtgVariantDetails.DataSource = DV
        cx.GridToList(dtgVariantDetails)

        lblVarUser.Text = String.Format("User : {0}", VUname)
        txtVname.Text = Vname

        S = "Display"
        S_Event()

    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        S = "New"
        S_Event()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            dtgVariantDetails.Columns.Clear()
        Catch ex As Exception

        End Try
        txtVname.Text = Nothing
        S = "Display"
        S_Event()
    End Sub
    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        S = "Import"
        S_Event()
    End Sub
    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        S = "Copy"
        VUname = Uname
        lblVarUser.Text = String.Format("User : {0}", VUname)
        txtVname.Enabled = True
        For Each ctrl As Button In Me.pnHeader.Controls.OfType(Of Button)()
            ctrl.Enabled = False
        Next
        cx.GridToKey(dtgVariantDetails)
        cmdCancel.Enabled = True
        cmdSave.Enabled = True
    End Sub
    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        S = "Change"
        For Each ctrl As Button In Me.pnHeader.Controls.OfType(Of Button)()
            ctrl.Enabled = False
        Next
        cx.GridToKey(dtgVariantDetails)
        cmdCancel.Enabled = True
        cmdSave.Enabled = True
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim A As String = MsgBox(String.Format("ต้องการลบ Variant : {0} ใช่หรือไม่?", Vname), MsgBoxStyle.YesNo)
        Select Case A
            Case 6
                cmd = cx.CommandCreate(String.Format("Delete from tbl_103userFilterVariant where Vname = '{0}' and Uname = '{1}'", Vname, VUname))
                cx.Execute(cmd)
                MsgBox(String.Format("ลบ Variant : {0} แล้ว", Vname))
                FrmUserVariant_Load(sender:=Nothing, e:=Nothing)
                S = "New"
                S_Event()
        End Select
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case S
            Case "New", "Import", "Copy"
                If txtVname.Text = Nothing Then MsgBox("กรุณาใส่ชื่อ Variant") : txtVname.Focus() : Exit Sub
                Dim A As String = cx.ExecuteScalar(String.Format("select Vname from tbl_103userFilterVariant where Vname = '{0}' and Uname = '{1}'", txtVname.Text, VUname))
                If A = Nothing Then
                    For r As Integer = 0 To dtgVariantDetails.Rows.Count - 1
                        Try
                            cmd = cx.CommandCreate("insert into tbl_103userFilterVariant (Vname,Uname,mprodh,mmatno,mmateng,mmattype) values (?,?,?,?,?,?)", "TTTTTT")
                            cmd.Parameters(0).Value = txtVname.Text
                            cmd.Parameters(1).Value = VUname
                            cmd.Parameters(2).Value = dtgVariantDetails(0, r).Value
                            cmd.Parameters(3).Value = dtgVariantDetails(1, r).Value
                            cmd.Parameters(4).Value = dtgVariantDetails(2, r).Value
                            cmd.Parameters(5).Value = dtgVariantDetails(3, r).Value
                            cx.Execute(cmd)
                        Catch ex As Exception

                        End Try
                    Next
                    Try
                        dtgVariantDetails.Columns.Clear()
                    Catch ex As Exception

                    End Try
                    S = "New"
                    S_Event()
                Else
                    MsgBox(String.Format("Variant : {0} มีอยู่แล้ว กรุณาใส่ชื่อใหม่", txtVname.Text)) : txtVname.Focus() : Exit Sub
                End If
            Case "Change"
                cmd = cx.CommandCreate(String.Format("delete from tbl_103userFilterVariant where  Vname = '{0}' and Uname = '{1}'", txtVname.Text, VUname))
                cx.Execute(cmd)
                For r As Integer = 0 To dtgVariantDetails.Rows.Count - 1
                    Try
                        cmd = cx.CommandCreate("insert into tbl_103userFilterVariant (Vname,Uname,mprodh,mmatno,mmateng,mmattype) values (?,?,?,?,?,?)", "TTTTTT")
                        cmd.Parameters(0).Value = txtVname.Text
                        cmd.Parameters(1).Value = VUname
                        cmd.Parameters(2).Value = dtgVariantDetails(0, r).Value
                        cmd.Parameters(3).Value = dtgVariantDetails(1, r).Value
                        cmd.Parameters(4).Value = dtgVariantDetails(2, r).Value
                        cmd.Parameters(5).Value = dtgVariantDetails(3, r).Value
                        cx.Execute(cmd)
                    Catch ex As Exception

                    End Try
                Next
                S = "Display"
                S_Event()
        End Select
        cmd = cx.CommandCreate("delete from tbl_103userFilterVariant where mmatno is null and mprodh is null")
        cx.Execute(cmd)
        cmd = cx.CommandCreate("update tbl_103userFilterVariant set mmateng ='' where mmateng is null")
        cx.Execute(cmd)
        cmd = cx.CommandCreate("update tbl_103userFilterVariant set mmattype ='' where mmattype is null")
        cx.Execute(cmd)
        cmd = cx.CommandCreate("update tbl_103userFilterVariant set mprodh ='' where mprodh is null")
        cx.Execute(cmd)
        cmd = cx.CommandCreate("update tbl_103userFilterVariant set mmatno ='' where mmatno is null")
        cx.Execute(cmd)
        FrmUserVariant_Load(sender:=Nothing, e:=Nothing)
        MsgBox("Save Variant : " & txtVname.Text & " เรียบร้อยแล้ว")
    End Sub
End Class