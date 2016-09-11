Public Class Frm9040
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private DT As DataTable
    Private DV As DataView
    Private X As String

    Private Sub Frm9040_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTimePicker1.Value = Now()
    End Sub

    Private Sub NpiButton1_Click(sender As Object, e As EventArgs) Handles NpiButton1.Click
        X = String.Format("select * from asset_retirement")
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView

        Dim S1 As New System.Text.StringBuilder("")
        Dim S2 As New System.Text.StringBuilder("")
        Me.Cursor = Cursors.WaitCursor

        Dim Header1 As New ArrayList
        Header1.Add("SAPMF05A0100X")
        Header1.Add("             BKPF-BLDAT                         " & DateTimePicker1.Value.ToString("dd.MM.yyyy"))
        Header1.Add("             BKPF-BLART                         AR")
        Header1.Add("             BKPF-BUKRS                         0870")
        Header1.Add("             BKPF-BUDAT                         " & DateTimePicker1.Value.ToString("dd.MM.yyyy"))
        Header1.Add("             BKPF-MONAT                         6")
        Header1.Add("             BKPF-WAERS                         THB")
        Header1.Add("             BKPF-BRNCH                         0021")
        Header1.Add("             FS006-DOCID                        *")
        Header1.Add("             RF05A-NEWBS                        01")
        Header1.Add("             RF05A-NEWKO                        999999")
        Header1.Add("             BDC_OKCODE                         /00")
        Header1.Add("SAPLFCPD0100X")
        Header1.Add("             BSEC-NAME1                         ห้างหุ้นส่วนจำกัดภูผาหยกรุ่งเรือง")
        Header1.Add("             BSEC-STRAS                         6/3 หมู่ 7 ต.พลูตาหลวง อ.สัตหีบ")
        Header1.Add("             BSEC-ORT01                         จ.ชลบุรี")
        Header1.Add("             BSEC-PSTLZ                         20180")
        Header1.Add("             BSEC-LAND1                         TH")
        Header1.Add("             BSEC-STCD1                         0203551005344")
        Header1.Add("             BSEC-STCD2                         00000")
        Header1.Add("             BDC_OKCODE                         /00")
        Header1.Add("SAPMF05A0301X")
        Header1.Add("             BSEG-WRBTR                         " & DT.Compute("sum(Price)*1.07", ""))
        Header1.Add("             BKPF-XMWST                         X")
        Header1.Add("             BSEG-MWSKZ                         o7")
        Header1.Add("             BSEG-ZTERM                         nt00")
        Header1.Add("             BSEG-ZBD1T                         60")
        Header1.Add("             BSEG-SGTXT                         คัดขาย Asset ชำรุด")
        Header1.Add("             RF05A-NEWBS                        50")
        Header1.Add("             RF05A-NEWKO                        456000")
        Header1.Add("             BDC_OKCODE                         /00")

        Dim Item1 As New ArrayList
        Item1.Add("SAPMF05A0300X")
        Item1.Add("             BSEG-MWSKZ                         O7")
        Item1.Add("             BSEG-BUPLA                         0021")
        Item1.Add("             RF05A-XAABG                        X")
        Item1.Add("             RF05A-NEWBS                        50")
        Item1.Add("             RF05A-NEWKO                        456000")
        Item1.Add("             DKACB-FMORE                        X")

        Dim Item2 As New ArrayList
        Item2.Add("             BDC_OKCODE                         /00")
        Item2.Add("SAPLKACB0002X")

        Dim Item3 As New ArrayList
        Item3.Add("             BDC_OKCODE                         =ENTE")
        Item3.Add("SAPLAINT0210X")
        Item3.Add("             ANBZ-BWASL                         210")
        Item3.Add("             ANBZ-BZDAT                         " & DateTimePicker1.Value.ToString("dd.MM.yyyy"))
        Item3.Add("             ANBZ-XVABG                         X")

        Dim Item4 As New ArrayList
        Item4.Add("             BDC_OKCODE                         =GOON")

        Dim Ending As New ArrayList
        Ending.Add("TCDEF-92")
        Ending.Add("ENDTCDE")

        For i As Integer = 0 To Header1.Count - 1
            S1.Append(Header1(i))
            S1.AppendLine()
        Next

        For Each Drv As DataRowView In DV
            For i As Integer = 0 To Item1.Count - 1
                S2.Append(Item1(i))
                S2.AppendLine()
            Next
            S2.Append("             BSEG-WRBTR                          " & (Drv!price))
            S2.AppendLine()
            S2.Append("             BSEG-SGTXT                         ขาย Asset number " & (Drv!Asset_no))
            S2.AppendLine()
            For i As Integer = 0 To Item2.Count - 1
                S2.Append(Item2(i))
                S2.AppendLine()
            Next
            S2.Append("             COBL-KOSTL                         " & Drv!cctr)
            S2.AppendLine()
            For i As Integer = 0 To Item3.Count - 1
                S2.Append(Item3(i))
                S2.AppendLine()
            Next
            S2.Append("             RA01B-ANLN1                        " & Drv!asset_no)
            S2.AppendLine()
            S2.Append("             RA01B-ANLN2                        " & Drv!asset_sub_no)
            S2.AppendLine()
            For i As Integer = 0 To Item4.Count - 1
                S2.Append(Item4(i))
                S2.AppendLine()
            Next
        Next
        For i As Integer = 0 To Ending.Count - 1
            S2.Append(Ending(i))
            S2.AppendLine()
        Next

        S1.Append(S2.ToString())

        Me.Cursor = Cursors.Default

        Dim cdl As New SaveFileDialog
        cdl.Filter = "TXT File|*.txt"

        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim S3 As New IO.StreamWriter(cdl.FileName, False, System.Text.Encoding.GetEncoding(874))
            S3.Write(S1.ToString)
            S3.Close()
            MsgBox("Save file to :  " & cdl.FileName & "   Success")
        End If
    End Sub

    Private Sub NpiButton2_Click(sender As Object, e As EventArgs) Handles NpiButton2.Click
        Dim cdl As New OpenFileDialog
        cdl.Filter = "File (*.xlsx)|*.xlsx"

        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim ds As DataSet
            ds = cx.GetdataExcelXlxs(cdl.FileName)
            DV = ds.Tables(0).DefaultView

            Dim cmd As OleDbCommand
            cmd = cx.CommandCreate("truncate table plannings.dbo.asset_retirement")
            cx.Execute(cmd)


            For Each drv As DataRowView In DV
                cmd = cx.CommandCreate("insert into plannings.dbo.asset_retirement (doc_no,item,Asset_no,Asset_sub_no,price,cctr) values (?,?,?,?,?,?)", "TITTYT")
                Dim P0 As String = drv!doc_no
                Dim P1 As Integer = drv!item
                Dim P2 As String = drv!Asset_no
                Dim P3 As String = drv!Asset_sub_no
                Dim P4 As Double = drv!price
                Dim P5 As String = drv!cctr

                cmd.Parameters(0).Value = P0
                cmd.Parameters(1).Value = P1
                cmd.Parameters(2).Value = P2
                cmd.Parameters(3).Value = P3
                cmd.Parameters(4).Value = P4
                cmd.Parameters(5).Value = P5
                cx.Execute(cmd)
            Next
        End If
        MsgBox("นำข้อมูลเข้าเรียบร้อย มั้ง")

    End Sub
End Class