Public Class FrmReclass
    Private cx As New NPIData(NPIConnect.Prefsuit)
    Private DT As DataTable
    Private DV As DataView
    Private X As String
    Private postdate As String
    Private Sub FrmReclass_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler cmdAct.Click, AddressOf cmdAct_Click
        AddHandler cmdStd.Click, AddressOf cmdStd_Click

        Select Case Today.Month
            Case 1
                txtMonth.Text = 12
                txtYear.Text = Today.Year - 1
            Case Else
                txtMonth.Text = Today.Month - 1
                txtYear.Text = Today.Year
        End Select

    End Sub

    Private Sub cmdAct_Click(sender As Object, e As EventArgs)
        X = String.Format("select * from [co_npi].[process].[Act_VC_RM_split_cost]('" & txtMonth.Text.ToString().PadLeft(2, "0") & "'," & txtYear.Text & ")")
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView
        postdate = cx.xPostdate(txtMonth.Text, txtYear.Text)


        Dim S1 As New System.Text.StringBuilder("")
        Dim S2 As New System.Text.StringBuilder("")
        Me.Cursor = Cursors.WaitCursor

        Dim currentrow As Integer = 1

        Dim Header1 As New ArrayList
        Header1.Add("SAPMF05A1001x")

        Dim Header2 As New ArrayList
        Header2.Add("             BDC_OKCODE                         /ECCDE")
        Header2.Add("SAPLACHD1000x")
        Header2.Add("             BKPF-BUKRS                         0870")
        Header2.Add("             BDC_OKCODE                         =ENTR")
        Header2.Add("SAPMF05A1001x")
        Header2.Add("             ACGL_HEAD-WAERS                    THB")

        Dim Header3 As New ArrayList
        Header3.Add("             ACGL_HEAD-BKTXT                    Reclass RM Used")
        Header3.Add("             ACGL_HEAD-BLART                    YB")
        Header3.Add("             BDC_OKCODE                         /00")

        Dim Item1 As New ArrayList
        Item1.Add("SAPMF05A1001x")

        Dim Item2 As New ArrayList
        Item2.Add("             ACGL_ITEM-MARKSP(01)               X")
        Item2.Add("             BDC_OKCODE                         =0005")

        Dim Ending As New ArrayList
        Ending.Add("SAPMF05A1001x")
        Ending.Add("             BDC_OKCODE                         =BU")
        Ending.Add("TCDEFB50")
        Ending.Add("ENDTCDE")

        For i As Integer = 0 To Header1.Count - 1
            S1.Append(Header1(i))
            S1.AppendLine()
        Next
        S1.Append("             ACGL_HEAD-BLDAT                    " & postdate)
        S1.AppendLine()
        For i As Integer = 0 To Header2.Count - 1
            S1.Append(Header2(i))
            S1.AppendLine()
        Next
        S1.Append("             ACGL_HEAD-BUDAT                    " & postdate)
        S1.AppendLine()
        S1.Append("             ACGL_HEAD-BLDAT                    " & postdate)
        S1.AppendLine()
        For i As Integer = 0 To Header3.Count - 1
            S1.Append(Header3(i))
            S1.AppendLine()
        Next

        For Each Drv As DataRowView In DV
            Select Case Drv!fc
                Case Is <> 0
                    For i As Integer = 0 To Item1.Count - 1
                        S2.Append(Item1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_ITEM-HKONT(01)                " & Drv!mcostelement)
                    S2.AppendLine()
                    Select Case Drv!FC
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!FC))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-KOSTL(01)                " & Drv!mcostcenter)
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MWSKZ(01)                nv")
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MATNR(01)                " & Drv!mmatno)
                    S2.AppendLine()
                    For i As Integer = 0 To Item2.Count - 1
                        S2.Append(Item2(i))
                        S2.AppendLine()
                    Next

                    For i As Integer = 0 To Item1.Count - 1
                        S2.Append(Item1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_ITEM-HKONT(01)                582000")
                    S2.AppendLine()
                    Select Case Drv!FC
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!FC))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-KOSTL(01)                0871-60000")
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MATNR(01)                " & Drv!mmatno)
                    S2.AppendLine()
                    For i As Integer = 0 To Item2.Count - 1
                        S2.Append(Item2(i))
                        S2.AppendLine()
                    Next
                    currentrow += 1
            End Select

            Select Case currentrow Mod 400
                Case 0
                    For i As Integer = 0 To Ending.Count - 1
                        S2.Append(Ending(i))
                        S2.AppendLine()
                    Next
                    For i As Integer = 0 To Header1.Count - 1
                        S2.Append(Header1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_HEAD-BLDAT                    " & postdate)
                    S2.AppendLine()
                    For i As Integer = 0 To Header2.Count - 1
                        S2.Append(Header2(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_HEAD-BUDAT                    " & postdate)
                    S2.AppendLine()
                    S2.Append("             ACGL_HEAD-BLDAT                    " & postdate)
                    S2.AppendLine()
                    For i As Integer = 0 To Header3.Count - 1
                        S2.Append(Header3(i))
                        S2.AppendLine()
                    Next
            End Select
        Next
        S1.Append(S2.ToString())
        For i As Integer = 0 To Ending.Count - 1
            S1.Append(Ending(i))
            S1.AppendLine()
        Next

        Me.Cursor = Cursors.Default

        Dim cdl As New SaveFileDialog
        cdl.Filter = "TXT File|*.txt"

        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim S3 As New IO.StreamWriter(cdl.FileName, False, System.Text.Encoding.GetEncoding(874))
            S3.Write(S1.ToString)
            S3.Close()
            MsgBox("Save file to : " & cdl.FileName & "   Success")
        End If
    End Sub
    Private Sub cmdStd_Click(sender As Object, e As EventArgs)
        X = String.Format("exec forvs.[Std_VC_FG_View_w_group_x_insect] '" & txtMonth.Text.ToString().PadLeft(2, "0") & "'," & txtYear.Text)
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView
        postdate = cx.xPostdate(txtMonth.Text, txtYear.Text)


        Dim S1 As New System.Text.StringBuilder("")
        Dim S2 As New System.Text.StringBuilder("")
        Me.Cursor = Cursors.WaitCursor

        Dim currentrow As Integer = 1

        Dim Header1 As New ArrayList
        Header1.Add("SAPMF05A1001x")

        Dim Header2 As New ArrayList
        Header2.Add("             BDC_OKCODE                         /ECCDE")
        Header2.Add("SAPLACHD1000x")
        Header2.Add("             BKPF-BUKRS                         0870")
        Header2.Add("             BDC_OKCODE                         =ENTR")
        Header2.Add("SAPMF05A1001x")
        Header2.Add("             ACGL_HEAD-WAERS                    THB")

        Dim Header3 As New ArrayList
        Header3.Add("             ACGL_HEAD-BKTXT                    Reclass Std FG")
        Header3.Add("             ACGL_HEAD-BLART                    YB")
        Header3.Add("             BDC_OKCODE                         /00")

        Dim Item1 As New ArrayList
        Item1.Add("SAPMF05A1001x")

        Dim Item2 As New ArrayList
        Item2.Add("             ACGL_ITEM-MARKSP(01)               X")
        Item2.Add("             BDC_OKCODE                         =0005")

        Dim Ending As New ArrayList
        Ending.Add("SAPMF05A1001x")
        Ending.Add("             BDC_OKCODE                         =BU")
        Ending.Add("TCDEFB50")
        Ending.Add("ENDTCDE")

        For i As Integer = 0 To Header1.Count - 1
            S1.Append(Header1(i))
            S1.AppendLine()
        Next
        S1.Append("             ACGL_HEAD-BLDAT                    " & postdate)
        S1.AppendLine()
        For i As Integer = 0 To Header2.Count - 1
            S1.Append(Header2(i))
            S1.AppendLine()
        Next
        S1.Append("             ACGL_HEAD-BUDAT                    " & postdate)
        S1.AppendLine()
        S1.Append("             ACGL_HEAD-BLDAT                    " & postdate)
        S1.AppendLine()
        For i As Integer = 0 To Header3.Count - 1
            S1.Append(Header3(i))
            S1.AppendLine()
        Next

        For Each Drv As DataRowView In DV
            Select Case Drv!diff_after_Restate
                Case Is <> 0
                    For i As Integer = 0 To Item1.Count - 1
                        S2.Append(Item1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_ITEM-HKONT(01)                582000")
                    S2.AppendLine()
                    Select Case Drv!diff_after_Restate
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!diff_after_Restate))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-KOSTL(01)                " & Drv!mcostcenter)
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MATNR(01)                " & Drv!mmatno)
                    S2.AppendLine()
                    For i As Integer = 0 To Item2.Count - 1
                        S2.Append(Item2(i))
                        S2.AppendLine()
                    Next

                    For i As Integer = 0 To Item1.Count - 1
                        S2.Append(Item1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_ITEM-HKONT(01)                581000")
                    S2.AppendLine()
                    Select Case Drv!diff_after_Restate
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!diff_after_Restate))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-KOSTL(01)                0871-60000")
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MATNR(01)                " & Drv!mmatno)
                    S2.AppendLine()
                    For i As Integer = 0 To Item2.Count - 1
                        S2.Append(Item2(i))
                        S2.AppendLine()
                    Next
                    currentrow += 1
            End Select

            Select Case currentrow Mod 400
                Case 0
                    For i As Integer = 0 To Ending.Count - 1
                        S2.Append(Ending(i))
                        S2.AppendLine()
                    Next
                    For i As Integer = 0 To Header1.Count - 1
                        S2.Append(Header1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_HEAD-BLDAT                    " & postdate)
                    S2.AppendLine()
                    For i As Integer = 0 To Header2.Count - 1
                        S2.Append(Header2(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_HEAD-BUDAT                    " & postdate)
                    S2.AppendLine()
                    S2.Append("             ACGL_HEAD-BLDAT                    " & postdate)
                    S2.AppendLine()
                    For i As Integer = 0 To Header3.Count - 1
                        S2.Append(Header3(i))
                        S2.AppendLine()
                    Next
            End Select
        Next
        S1.Append(S2.ToString())
        For i As Integer = 0 To Ending.Count - 1
            S1.Append(Ending(i))
            S1.AppendLine()
        Next

        Me.Cursor = Cursors.Default

        Dim cdl As New SaveFileDialog
        cdl.Filter = "TXT File|*.txt"

        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim S3 As New IO.StreamWriter(cdl.FileName, False, System.Text.Encoding.GetEncoding(874))
            S3.Write(S1.ToString)
            S3.Close()
            MsgBox("Save file to : " & cdl.FileName & "   Success")
        End If
    End Sub
End Class