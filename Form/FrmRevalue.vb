Public Class FrmRevalue
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private DT As DataTable
    Private DV As DataView
    Private X As String
    Private postdate As String
    Private txtM As String
    Private txtY As String
    Private Sub Clear_List()
        cx.ClearButton(pnCondition)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub FrmRevalue_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler cmdExecVC.Click, AddressOf cmdExecVC_Click
        AddHandler txtMonth.TextChanged, AddressOf Clear_List
        AddHandler txtYear.TextChanged, AddressOf Clear_List
        AddHandler cmdExpTemp.Click, AddressOf cmdExpTemp_Click
        cmdExpTemp.Enabled = False
    End Sub
    Private Sub cmdExecVC_Click(sender As Object, e As EventArgs)
        Call Clear_List()
        Me.Cursor = Cursors.WaitCursor
        txtY = txtYear.Text
        txtM = String.Format("{0:N0}", txtMonth.Text).ToString().PadLeft(2, "0")
        postdate = cx.xPostdate(txtMonth.Text, txtYear.Text)

        X = String.Format("select * from plannings.dbo.Acc_revalue_VC('{0}','{1}') where [revalue group] is not null", txtM, txtY)
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView
        dtgMaster.DataSource = DV
        cx.GridToList(dtgMaster)
        Me.Cursor = Cursors.Default
        cmdExpTemp.Enabled = True
    End Sub
    Private Sub cmdExpTemp_Click(sender As Object, e As EventArgs)
        Call Clear_List()
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
        Header3.Add("             ACGL_HEAD-BKTXT                    Revalue month " & txtMonth.Text & "/" & txtYear.Text)
        Header3.Add("             ACGL_HEAD-BLART                    SV")
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
            Select Case Drv!Revalue
                Case Is <> 0
                    For i As Integer = 0 To Item1.Count - 1
                        S2.Append(Item1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_ITEM-HKONT(01)                121110")
                    S2.AppendLine()
                    Select Case Drv!Revalue
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!Revalue))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MWSKZ(01)                nv")
                    S2.AppendLine()
                    'S2.Append("             ACGL_ITEM-ZUONR(01)                " & Drv!mplant)
                    'S2.AppendLine()
                    S2.Append("             ACGL_ITEM-SGTXT(01)                " & Drv!mprodhl5)
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
                    Select Case Drv!Revalue
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!Revalue))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-KOSTL(01)                0871-d0003")
                    S2.AppendLine()
                    'S2.Append("             ACGL_ITEM-WERKS(01)                " & Drv!mplant)
                    'S2.AppendLine()
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