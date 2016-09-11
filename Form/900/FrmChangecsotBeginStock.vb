Imports DateTimeExtensions
Public Class FrmChangecsotBeginStock
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private DT As DataTable
    Private DV As DataView
    Private X As String
    Private postdate As String
    Private Sub Form5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler cmdExecute583.Click, AddressOf cmdExecute_Click
        AddHandler cmd581000.Click, AddressOf cmd581_Click
        AddHandler cmd582000.Click, AddressOf cmd582_Click
        AddHandler dtpPostdate.ValueChanged, AddressOf dtpPostdate_ValueChanged
        AddHandler cmdExeccost.Click, AddressOf cmdExeccost_Click
        AddHandler cmdCostxx.Click, AddressOf cmdCostxx_Click
        dtpPostdate.Value = Now
        postdate = dtpPostdate.Value.ToString("ddMMyyyy")
    End Sub
    Private Sub cmdExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        X = String.Format("Exec plannings.dbo.changecost '',''")
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView
        dtgMaster.DataSource = DV
        cx.GridToList(dtgMaster)

    End Sub
    Private Sub cmd581_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Header3.Add("             ACGL_HEAD-BKTXT                    Chang cost adj.")
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
            Select Case Drv!diffvc
                Case Is <> 0
                    For i As Integer = 0 To Item1.Count - 1
                        S2.Append(Item1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_ITEM-HKONT(01)                121110")
                    S2.AppendLine()
                    Select Case Drv!diffvc
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!diffvc))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MWSKZ(01)                nv")
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-ZUONR(01)                " & Drv!mplant)
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-SGTXT(01)                " & Drv!mprodh)
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
                    Select Case Drv!diffvc
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!diffvc))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-KOSTL(01)                0871-d0001")
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WERKS(01)                " & Drv!mplant)
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
    Private Sub dtpPostdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        postdate = dtpPostdate.Value.ToString("ddMMyyyy")
    End Sub
    Private Sub cmd582_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Header3.Add("             ACGL_HEAD-BKTXT                    Chang cost adj.")
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
            Select Case Drv!difffc
                Case Is <> 0
                    For i As Integer = 0 To Item1.Count - 1
                        S2.Append(Item1(i))
                        S2.AppendLine()
                    Next
                    S2.Append("             ACGL_ITEM-HKONT(01)                121110")
                    S2.AppendLine()
                    Select Case Drv!difffc
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                            'Case 0
                            '    S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!diffFC))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-MWSKZ(01)                nv")
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-ZUONR(01)                " & Drv!mplant)
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-SGTXT(01)                " & Drv!mprodh)
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
                    Select Case Drv!diffFC
                        Case Is > 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                S")
                        Case Is < 0
                            S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                            'Case 0
                            '    S2.Append("             ACGL_ITEM-SHKZG(01)                H")
                    End Select
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!diffFC))
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-KOSTL(01)                0871-d0001")
                    S2.AppendLine()
                    S2.Append("             ACGL_ITEM-WERKS(01)                " & Drv!mplant)
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
    Private Sub cmdExeccost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        X = String.Format("Exec plannings.dbo.Adjustcost '',''")
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView
        dtgMaster.DataSource = DV
        cx.GridToList(dtgMaster)
    End Sub

    Private Sub cmdCostxx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim S1 As New System.Text.StringBuilder("")
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
        Header3.Add("             ACGL_HEAD-BKTXT                    Chang cost adj.")
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

        For i As Integer = 0 To Item1.Count - 1
            S1.Append(Item1(i))
            S1.AppendLine()
        Next
        S1.Append("             ACGL_ITEM-HKONT(01)                121110")
        S1.AppendLine()

        Dim sum121110 As Double = DT.Compute("Sum (diffchangecost)", "")

        Select Case sum121110
            Case Is > 0
                S1.Append("             ACGL_ITEM-SHKZG(01)                H")
            Case Is < 0
                S1.Append("             ACGL_ITEM-SHKZG(01)                S")
            Case 0
                S1.Append("             ACGL_ITEM-SHKZG(01)                S")
        End Select
        S1.AppendLine()
        S1.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(sum121110))
        S1.AppendLine()
        S1.Append("             ACGL_ITEM-MWSKZ(01)                nv")
        S1.AppendLine()
        For i As Integer = 0 To Item2.Count - 1
            S1.Append(Item2(i))
            S1.AppendLine()
        Next

        For Each Drv As DataRowView In DV

            For i As Integer = 0 To Item1.Count - 1
                S1.Append(Item1(i))
                S1.AppendLine()
            Next
            S1.Append("             ACGL_ITEM-HKONT(01)                " & Drv!maccount)
            S1.AppendLine()
            Select Case Drv!diffchangecost
                Case Is > 0
                    S1.Append("             ACGL_ITEM-SHKZG(01)                S")
                Case Is < 0
                    S1.Append("             ACGL_ITEM-SHKZG(01)                H")
                Case 0
                    S1.Append("             ACGL_ITEM-SHKZG(01)                H")
            End Select
            S1.AppendLine()
            S1.Append("             ACGL_ITEM-WRBTR(01)                " & Math.Abs(Drv!diffchangecost))
            S1.AppendLine()
            S1.Append("             ACGL_ITEM-MWSKZ(01)                nv")
            S1.AppendLine()
            S1.Append("             ACGL_ITEM-KOSTL(01)                " & Drv!mcostcenter)
            S1.AppendLine()
            S1.Append("             ACGL_ITEM-MATNR(01)                " & Drv!mmatno)
            S1.AppendLine()
            For i As Integer = 0 To Item2.Count - 1
                S1.Append(Item2(i))
                S1.AppendLine()
            Next

            Select Case currentrow Mod 900
                Case 0
                    For i As Integer = 0 To Ending.Count - 1
                        S1.Append(Ending(i))
                        S1.AppendLine()
                    Next
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
            End Select
            currentrow += 1
        Next
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