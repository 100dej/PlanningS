Public Class FrmMatMaster
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Dim DV As DataView
    Dim DT As DataTable
    Dim DvColumnfilter As String
    Dim DVColumnValFilter As String
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim T1 As Date = Now()
        cx.ClearButton(pnHeader)
        Me.Cursor = Cursors.WaitCursor
        Dim X1 As String = String.Format("exec ProductMaster '{0}','{1}'", txtMat.Text, txtEng.Text)
        DT = cx.GetdataTable(X1)
        DV = DT.DefaultView
        dtGridMatMaster.DataSource = DV
        'dtGridMatMaster.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        cx.GridToList(dtGridMatMaster)

        cmdExport.Enabled = True

        cx.GetUserExecProg(My.Application.ToString, Me.Name.ToString, X1, DateDiff(DateInterval.Second, T1, Now()))

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnHeader)
        Dim cdl As New SaveFileDialog
        cdl.FileName = "Material Master"
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtGridMatMaster, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub FrmMatMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmdExport.Enabled = False
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)

        AddHandler CopyGrid.Click, AddressOf CopyGrid_Click
        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler dtGridMatMaster.DoubleClick, AddressOf dtGridMatMaster_DoubleClick
        AddHandler lblStatus.Click, AddressOf lblStatus_Click

        lblFilter.Text = "Filter By ==> "
        lblStatus.Visible = False
        lblFilter.Visible = False
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

    Private Sub CopyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject(dtGridMatMaster.GetClipboardContent, False)
    End Sub
End Class