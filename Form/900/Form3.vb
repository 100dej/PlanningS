Public Class Form3
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private x As String
    Private Table_schema As String
    Private Table_name As String
    Private DT As DataTable
    Private distinctDT As DataTable
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        x = String.Format("Exec plannings.dbo.View_all ''")
        DT = cx.GetdataTable(x)
        distinctDT = DT.DefaultView.ToTable(True, "Table_schema")
        distinctDT.Rows.Add("")
        distinctDT.DefaultView.Sort = "Table_schema ASC"
        cboShcema.DisplayMember = "Table_schema"
        cboShcema.ValueMember = "Table_schema"
        cboShcema.DataSource = distinctDT

        Table_schema = cboShcema.SelectedValue

        AddHandler cboShcema.SelectedIndexChanged, AddressOf cboschema_SelectedIndexChanged

    End Sub
    Private Sub cboschema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Table_name = cboName.SelectedValue
        Select Case Table_name
            Case ""
                cboName.DataSource = Nothing
                Table_name = ""
            Case Else
                Dim DV As DataView = DT.DefaultView
                x = String.Format("Table_schema = '{0}'", Table_schema)
                DV.RowFilter = x
                distinctDT = DV.Table
                distinctDT = distinctDT.DefaultView.ToTable(True, x)
                distinctDT.Rows.Add("")
                distinctDT.DefaultView.Sort = "Table_name ASC"
                cboShcema.DisplayMember = "Table_name"
                cboShcema.ValueMember = "Table_name"
                cboShcema.DataSource = distinctDT
        End Select

    End Sub
End Class