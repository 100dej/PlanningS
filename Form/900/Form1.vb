Public Class Form1
    Dim CX As New NPIData(NPIConnect.TBTest)

    Const maxtextboxpanel1 As Integer = 999
    Dim txtbox(maxtextboxpanel1) As NPIText
    Dim Labelx(maxtextboxpanel1) As Label
    Dim Combox(maxtextboxpanel1) As ComboBox
    Dim DateTpic(maxtextboxpanel1) As DateTimePicker
    Dim CkBox(maxtextboxpanel1) As CheckBox
    Dim LitBox(maxtextboxpanel1) As ListBox
    Dim OpG(maxtextboxpanel1) As GroupBox
    Dim DB As DataTable
    Dim Listcontrol As New List(Of Control)
    Private Sub GenFrom(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Panel1.Controls.Clear()
        Listcontrol.Clear()

        Dim X2 As String = String.Format("exec tbtest.dbo.Genform '{0}','{1}','{2}' ", Me.Name, "panel1", TxtDept.Text)
        DB = CX.GetdataTable(X2)

        For i = 1 To DB.Rows.Count

            OpG(i) = New GroupBox

            Select Case DB.Rows(i - 1).Item("ObjectType")
                Case "TextBox"
                    txtbox(i) = New NPIText
                    With txtbox(i)
                        .Font = New Font("Tahoma", 12)
                        .Width = DB.Rows(i - 1).Item("Objectwidth") * .Font.Size
                        .MaxLength = DB.Rows(i - 1).Item("Objectwidth")
                        .Name = DB.Rows(i - 1).Item("Objectname")
                        .Text = .Name
                        .Top = 20
                        .Left = 10
                    End With
                    OpG(i).Controls.Add(txtbox(i))
                    Listcontrol.Add(txtbox(i))
                Case "ComboBox"
                    Combox(i) = New ComboBox
                    With Combox(i)
                        .Font = New Font("Tahoma", 12)
                        .Width = DB.Rows(i - 1).Item("Objectwidth") * .Font.Size
                        .MaxLength = DB.Rows(i - 1).Item("Objectwidth")
                        .Name = DB.Rows(i - 1).Item("Objectname")
                        Dim DBC As DataTable = CX.GetdataTable(String.Format("select {0},{1} ,{0} + ' ' + {1} as DisCombo from {2} ", DB.Rows(i - 1).Item("ExpandValue"), DB.Rows(i - 1).Item("ExpandDisplay"), DB.Rows(i - 1).Item("ExpandTable")))
                        .DataSource = DBC
                        .DisplayMember = "DisCombo"
                        .ValueMember = DB.Rows(i - 1).Item("ExpandValue")
                        .Top = 20
                        .Left = 10
                    End With
                    OpG(i).Controls.Add(Combox(i))
                    Listcontrol.Add(Combox(i))
                Case "DateTimePicker"
                    DateTpic(i) = New DateTimePicker

                    With DateTpic(i)

                        .Font = New Font("Tahoma", 12)
                        .Width = DB.Rows(i - 1).Item("Objectwidth") * .Font.Size
                        .Name = DB.Rows(i - 1).Item("Objectname")
                        .Top = 20
                        .Left = 10

                    End With
                    OpG(i).Controls.Add(DateTpic(i))
                    Listcontrol.Add(DateTpic(i))

                Case "CheckBox"
                    CkBox(i) = New CheckBox
                    With CkBox(i)
                        .Font = New Font("Tahoma", 12)
                        .Width = Len(DB.Rows(i - 1).Item("ObjectLabeltext")) * .Font.Size
                        .Name = DB.Rows(i - 1).Item("Objectname")
                        .Text = DB.Rows(i - 1).Item("ObjectLabeltext")
                        .Top = 20
                        .Left = 10
                    End With
                    OpG(i).Controls.Add(CkBox(i))
                    Listcontrol.Add(CkBox(i))
                Case "ListBox"
                    LitBox(i) = New ListBox
                    With LitBox(i)
                        .Font = New Font("Tahoma", 10)
                        .Width = DB.Rows(i - 1).Item("Objectwidth") * .Font.Size
                        '.Height = 100
                        .Name = DB.Rows(i - 1).Item("Objectname")
                        .Items.Add(DB.Rows(i - 1).Item("ObjectLabeltext"))
                        .Top = 20
                        .Left = 10
                        .HorizontalScrollbar = True
                    End With
                    OpG(i).Controls.Add(LitBox(i))
                    Listcontrol.Add(LitBox(i))
            End Select

            OpG(i).Height = Listcontrol(i - 1).Bottom + 15
            OpG(i).Width = Listcontrol(i - 1).Right + 10
            OpG(i).Text = DB.Rows(i - 1).Item("ObjectLabeltext")
            Panel1.Controls.Add(OpG(i))

        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim S1 As New System.Text.StringBuilder("")
        Dim S2 As New System.Text.StringBuilder("")
        For i = 1 To DB.Rows.Count
            S1.Append(txtbox(i).Name)
            S2.Append("'" & txtbox(i).Text & "'")
            If i <> DB.Rows.Count Then S1.Append(",") : S2.Append(",")

        Next
        Dim x As String = String.Format("Insert into tbtest.dbo.Tdata ({0}) select {1} ", S1.ToString, S2.ToString)
        MsgBox(x)
        Dim y As Integer = CX.Execute(x)
        If y = 1 Then MsgBox("OK")

    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtDept.Text = "PipeInline"
    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Down
                e.Handled = True
                SendKeys.Send("{TAB}")
            Case Keys.Up
                e.Handled = True
                SendKeys.Send("+{TAB}")
            Case Keys.Escape
                Me.Text = ""
        End Select
    End Sub
End Class