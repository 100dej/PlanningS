Public Class FrmDaysSale
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExec.Click
        Dim T1 As Date = Now()
        cx.ClearButton(pnHeader)
        Dim X1 As String = String.Format("exec ShowDaysSale '{0}','{1}'", txtMat.Text, txtEng.Text)
        DT = cx.GetdataTable(X1)
        dtgGridAllMat.DataSource = DT
        cx.GridToList(dtgGridAllMat)

        cx.GetUserExecProg(My.Application.ToString, Me.Name.ToString, X1, DateDiff(DateInterval.Second, T1, Now()))


        cmdExport.Enabled = True

    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        cx.ClearButton(pnHeader)
        Dim cdl As New SaveFileDialog
        cdl.FileName = "DaysSale"
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgGridAllMat, cdl.FileName, Chr(9))
        End If
    End Sub

    Private Sub FrmAllMat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdExport.Enabled = False
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
    End Sub
End Class