Public Class NPIData
    Dim strcon As String
    Dim m_AutoClose As Boolean = True
    Dim cn As OleDbConnection
    Public Function ConnectionOpen() As Boolean
        Dim Y As Boolean = True
        If cn Is Nothing Then
            cn = New OleDbConnection(strcon)
        End If
        If cn.State = ConnectionState.Closed Then
            Try
                cn.Open()
            Catch ex As Exception
                MsgBox("Cannot open database connection")
                Y = False
            End Try
        End If
        Return Y
    End Function
    Public Sub ConnectionClose()
        If cn IsNot Nothing Then
            If cn.State <> ConnectionState.Closed Then
                Try
                    cn.Close()
                    cn.Dispose()
                Catch ex As Exception

                End Try
            End If
        End If
        cn = Nothing
    End Sub
    Public Property Autoclose()
        Get
            Return m_AutoClose
        End Get
        Set(ByVal value)
            m_AutoClose = value
        End Set
    End Property
    Public Sub New()
        strcon = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=PlanningS" 'default database ตอน run program
        'strcon = "Server=172.31.195.13;Database=PlanningS;User Id=sa;Password=sqlrayong"
    End Sub
    Public Sub New(ByVal stringconnect As String)
        strcon = stringconnect ' เปลี่ยน Server
    End Sub
    Public Function GetdataExcel(ByVal Fname As String) As DataSet
        Dim ds As New DataSet
        Dim strConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='" & Fname & " '; " &
                                                 "Extended Properties=Excel 8.0;")

        strConnection.Open()

        Dim myTableName = strConnection.GetSchema("Tables").Rows(0)("TABLE_NAME")
        Dim objAdapter As New OleDbDataAdapter(String.Format("SELECT * FROM [{0}]", myTableName), strConnection)
        Try
            objAdapter.Fill(ds)
            strConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 48, "NPI Project")
            strConnection.Close()
        End Try
        Return ds
    End Function
    Public Function GetdataExcelXlxs(ByVal Fname As String) As DataSet
        Dim conn As OleDbConnection
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Fname + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
        dts = New DataSet
        Try
            dta.Fill(dts, "[Sheet1$]")
        Catch ex As Exception
            MsgBox(ex.Message, 48, "NPI Project")
            conn.Close()
        End Try
        conn.Close()
        Return dts
    End Function
    Public Function fillImlWithFilesFromDir(ByRef dirPath As String) As ImageList
        Dim allowedExtensions() As String = {".gif", ".jpg", ".bmp", ".png"}
        Dim imlTemp As New ImageList
        Dim dirFiles() As String = IO.Directory.GetFiles(dirPath)
        imlTemp.ImageSize = New Size(256, 256)
        imlTemp.ColorDepth = ColorDepth.Depth32Bit

        For Each dirFile As String In dirFiles
            For Each extension As String In allowedExtensions 'allowedExtensions
                If extension = IO.Path.GetExtension(dirFile) Then
                    imlTemp.Images.Add(Image.FromFile(dirFile))
                End If
            Next
        Next

        Return imlTemp
    End Function
    Public Function GetdataTableReader(ByVal strsql As String) As DataTable 'ชุดคำสั่งแสดงข้อมูล
        Dim cn As New OleDbConnection
        Try
            cn.ConnectionString = strcon
            cn.Open()
            Dim myCmd As OleDbCommand = New OleDbCommand(strsql, cn)
            Dim dt As New DataTable
            Dim dr As OleDbDataReader = myCmd.ExecuteReader()

            If dr.HasRows Then
                dt.Load(dr)
                Return dt
            End If

        Catch ex As Exception
            MsgBox(ex.Message, 48, "NPI Project")
        Finally
            cn.Close()
        End Try
    End Function
    Public Function xPostdate(ByVal xM As String, ByVal xY As String) As String
        Dim postdate As String
        Select Case xM.ToString
            Case 1, 3, 5, 7, 8, 10, 12
                postdate = String.Format("31{0}{1}", String.Format("{0:N0}", xM).ToString().PadLeft(2, "0"), xY)
            Case 4, 6, 9, 11
                postdate = String.Format("30{0}{1}", String.Format("{0:N0}", xM).ToString().PadLeft(2, "0"), xY)
            Case 2
                Select Case xY.ToString Mod 4
                    Case 0
                        postdate = String.Format("29{0}{1}", String.Format("{0:N0}", xM).ToString().PadLeft(2, "0"), xY)
                    Case 1, 2, 3
                        postdate = String.Format("28{0}{1}", String.Format("{0:N0}", xM).ToString().PadLeft(2, "0"), xY)
                End Select
        End Select
        Return postdate
    End Function
    Public Function GetdataTable(ByVal strsql As String) As DataTable 'ชุดคำสั่งแสดงข้อมูล

        'Dim ds As New DataTable
        'Using connection As New SqlConnection(strcon)
        '    Dim dx As New SqlDataAdapter()
        '    dx.SelectCommand = New SqlCommand(strsql, connection)
        '    dx.Fill(ds)
        '    Return ds
        'End Using


        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(strsql, strcon)

        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, 48, "NPI Project")
            dt = Nothing
        End Try
        Return dt
    End Function
    Public Function GetdataSet(ByVal strsql As String) As DataSet 'ชุดคำสั่งแสดงข้อมูล
        'Dim ds As New DataSet
        'Using connection As New SqlConnection(strcon)
        '    Dim dx As New SqlDataAdapter()
        '    dx.SelectCommand = New SqlCommand(strsql, connection)
        '    dx.Fill(ds)
        '    Return ds
        'End Using
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(strsql, strcon)

        Try
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message, 48, "NPI Project")
            ds = Nothing
        End Try
        Return ds
    End Function
    Public Function ExecuteScalar(ByVal strsql As String) As Object
        Dim Y As Boolean = Me.ConnectionOpen
        If Y = False Then Return Nothing
        Dim cmd As New OleDbCommand(strsql, cn)
        Dim X As Object = Nothing
        Try
            X = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message, 48, "NPI Project")
        End Try
        If m_AutoClose = True Then
            Me.ConnectionClose()
        End If
        Return X
    End Function
    Public Function Execute(ByVal strsql As String) As Integer
        
        Dim cmd As New OleDbCommand(strsql, cn)
        Return Me.Execute(cmd)

    End Function
    Public Function Get_Function_CopyGrid(ByVal uname As String) As Integer
        Dim fbit As Integer = Me.ExecuteScalar(String.Format("Exec Get_Function_Config '{0}','{1}'", uname, "CopyGrid"))
        Return fbit
    End Function
    Public Sub Get_User_Function_CopyGrid(ByVal uname As String, ByVal fbit As Integer)
        Dim x As String = String.Format("select * from plannings.dbo.tba_ConfigFunction where uname ='{0}' and FuncName = '{1}' ", uname, "CopyGrid")
        Dim dt As DataTable = Me.GetdataTable(x)
        Select Case dt.Rows.Count
            Case 0
                x = String.Format("insert into plannings.dbo.tba_ConfigFunction values ('{0}','{1}',{2})", uname, "CopyGrid", fbit)
            Case Else
                x = String.Format("update plannings.dbo.tba_ConfigFunction set xConfig = {2} where uname ='{0}' and FuncName = '{1}'", uname, "CopyGrid", fbit)
        End Select
        Me.Execute(x)
    End Sub
    Public Function Execute(ByVal cmd As OleDbCommand) As Integer
        Dim Y As Boolean = Me.ConnectionOpen
        If Y = False Then Return Nothing
        cmd.Connection = cn
        Dim X As Integer = 0
        Try
            X = cmd.ExecuteNonQuery
        Catch ex As Exception
            X = -99
        End Try
        If m_AutoClose = True Then
            Me.ConnectionClose()
        End If
        Return X
    End Function
    Public Function ImageToBytesJPG(ByVal img As Image) As Byte()
        Dim B1() As Byte
        Dim M1 As New IO.MemoryStream
        img.Save(M1, Imaging.ImageFormat.Jpeg)
        B1 = M1.GetBuffer
        M1.Close()
        Return B1
    End Function
    Public Function ImageToBytesGIF(ByVal img As Image) As Byte()
        Dim B1() As Byte
        Dim M1 As New IO.MemoryStream
        img.Save(M1, Imaging.ImageFormat.Gif)
        B1 = M1.GetBuffer
        M1.Close()
        Return B1
    End Function
    Public Function ImageToBytesPNG(ByVal img As Image) As Byte()
        Dim B1() As Byte
        Dim M1 As New IO.MemoryStream
        img.Save(M1, Imaging.ImageFormat.Png)
        B1 = M1.GetBuffer
        M1.Close()
        Return B1
    End Function
    Public Function BytesToImage(ByVal B1() As Byte) As Image
        Dim img As Image
        Dim M1 As New IO.MemoryStream(B1)
        img = Image.FromStream(M1)
        M1.Close()
        Return img
    End Function
    Public Sub GetUserUsedProg(ByVal Pname As String, ByVal Fname As String)
        If Uname = "pongdejr" Then Exit Sub
        Dim cmd As OleDbCommand = CommandCreate("insert into tbl_100userLoginMyProg (Pname,Fname,Uname,Cname,IPname) values (?,?,?,?,?)", "TTTTT")
        cmd.Parameters(0).Value = Pname
        cmd.Parameters(1).Value = Fname
        cmd.Parameters(2).Value = Uname
        cmd.Parameters(3).Value = hostname
        cmd.Parameters(4).Value = ipaddress
        Execute(cmd)
    End Sub

    Public Sub GetUserExecProg(ByVal Pname As String, ByVal Fname As String, ByVal ExecCondition As String, ByVal ExecTime As Integer, Optional ByVal ExecReport As String = "", Optional ByVal ExecField As String = "")
        If Uname = "pongdejr" Then Exit Sub
        Dim cmd As OleDbCommand = CommandCreate("insert into tbl_101userExecMyProg (Pname,Fname,Uname,ExecCondition,ExecUsedTime,ExecReport,ExecField) values (?,?,?,?,?,?,?)", "TTTTITT")
        cmd.Parameters(0).Value = Pname
        cmd.Parameters(1).Value = Fname
        cmd.Parameters(2).Value = Uname
        cmd.Parameters(3).Value = ExecCondition
        cmd.Parameters(4).Value = ExecTime
        cmd.Parameters(5).Value = ExecReport
        cmd.Parameters(6).Value = ExecField
        Execute(cmd)
        MsgBox("Report READY!!!!")
    End Sub
    Public Sub GetUserExecProgTimeout(ByVal Pname As String, ByVal Fname As String, ByVal ExecCondition As String, ByVal ExecTime As Integer, Optional ByVal ExecReport As String = "", Optional ByVal ExecField As String = "")
        If Uname = "pongdejr" Then Exit Sub
        Dim cmd As OleDbCommand = CommandCreate("insert into tbl_102userExecMyprogTimeout (Pname,Fname,Uname,ExecCondition,ExecUsedTime,ExecReport,ExecField) values (?,?,?,?,?,?,?)", "TTTTITT")
        cmd.Parameters(0).Value = Pname
        cmd.Parameters(1).Value = Fname
        cmd.Parameters(2).Value = Uname
        cmd.Parameters(3).Value = ExecCondition
        cmd.Parameters(4).Value = ExecTime
        cmd.Parameters(5).Value = ExecReport
        cmd.Parameters(6).Value = ExecField
        Execute(cmd)
    End Sub
    Public Sub ExportToTextFileFormGrid(ByVal DG As DataGridView, ByVal FileName As String, Optional ByVal CharSep As String = "|")
        Dim S1 As New System.Text.StringBuilder("")

        For i As Integer = 0 To DG.Columns.Count - 1
            If i > 0 Then
                S1.Append(CharSep)
            End If
            S1.Append(DG.Columns(i).HeaderText)
        Next
        S1.Append(vbCrLf)

        For Each drv As DataGridViewRow In DG.Rows
            For i As Integer = 0 To DG.Columns.Count - 1
                If i > 0 Then
                    S1.Append(CharSep)
                End If
                If Not IsDBNull(DG.Item(i, drv.Index).Value) Then
                    Select Case DG.Item(i, drv.Index).ValueType.ToString
                        Case "System.DateTime"
                            If DG.Columns(i).DefaultCellStyle.Format.ToString = "HH:MM" Then
                                S1.Append(CDate(DG.Item(i, drv.Index).Value).ToString("HH:MM"))
                            Else
                                S1.Append(CDate(DG.Item(i, drv.Index).Value).ToString("dd/MM/yyyy"))
                            End If
                        Case Else
                            S1.Append(DG.Item(i, drv.Index).Value.ToString)
                    End Select
                End If
            Next
            S1.Append(vbCrLf)
        Next

        Dim S2 As New IO.StreamWriter(FileName, False, System.Text.Encoding.GetEncoding(874))
        S2.Write(S1.ToString)
        S2.Close()
        MsgBox("Save file to : " & FileName & "   Success")
    End Sub
    Public Sub ExportToTextFileFormTable(ByVal DG As DataGridView, ByVal DT As DataTable, ByVal FileName As String, Optional ByVal CharSep As String = "|")
        Dim S1 As New System.Text.StringBuilder("")

        For i As Integer = 0 To DG.Columns.Count - 1
            If i > 0 Then
                S1.Append(CharSep)
            End If
            S1.Append(DG.Columns(i).HeaderText)
        Next
        S1.Append(vbCrLf)

        For Each dr As DataRow In DT.Rows
            For i As Integer = 0 To DT.Columns.Count - 1
                If i > 0 Then
                    S1.Append(CharSep)
                End If
                If Not IsDBNull(dr(i)) Then
                    Select Case DT.Columns(i).DataType.ToString
                        Case "System.DateTime"
                            If DG.Columns(i).DefaultCellStyle.Format.ToString = "HH:MM" Then
                                S1.Append(CDate(dr(i)).ToString("HH:MM"))
                            Else
                                S1.Append(CDate(dr(i)).ToString("dd/MM/yyyy"))
                            End If
                        Case Else
                            S1.Append(dr(i).ToString)
                    End Select
                End If
            Next
            S1.Append(vbCrLf)
        Next

        Dim S2 As New IO.StreamWriter(FileName, False, System.Text.Encoding.GetEncoding(874))
        S2.Write(S1.ToString)
        S2.Close()
        MsgBox("Save file to : " & FileName & "   Success")
    End Sub
    Public Sub ExportPair(ByVal DT As DataTable, ByVal FileName As String, Optional ByVal CharSep As String = "=")
        Dim S1 As New System.Text.StringBuilder("")
        For Each dr As DataRow In DT.Rows
            For i As Integer = 0 To DT.Columns.Count - 1
                S1.Append(DT.Columns(i).ColumnName)
                S1.Append(CharSep)
                If Not IsDBNull(dr(i)) Then
                    S1.Append(dr(i).ToString)
                End If
                S1.Append(vbCrLf)
            Next
            S1.Append("-----------------------------------------------------")
            S1.Append(vbCrLf)
        Next
        Dim S2 As New IO.StreamWriter(FileName, False, System.Text.Encoding.GetEncoding(874))
        S2.Write(S1.ToString)
        S2.Close()
        MsgBox("Success")
    End Sub
    ''' <summary>
    ''' 
    ''' 
    ''' </summary>
    ''' <param name="strsql"></param>
    ''' <param name="Paramtype">T:Text, I:Integer, D:Date, Y:Money, F:Float, B:Boolean, P:Picture, M:Memo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CommandCreate(ByVal strsql As String, Optional ByVal Paramtype As String = "") As OleDbCommand 'Optional ไม่ใส่ค่ามาก็ได้
        Dim cmd As New OleDbCommand(strsql)
        If Paramtype <> "" Then
            For i As Integer = 1 To Len(Paramtype)
                Dim X As String = UCase(Mid(Paramtype, i, 1))
                Dim P1 As New OleDbParameter
                P1.ParameterName = "@p" & i
                Select Case X
                    Case "T"
                        P1.OleDbType = OleDbType.VarWChar
                    Case "I"
                        P1.OleDbType = OleDbType.Integer
                    Case "D"
                        P1.OleDbType = OleDbType.Date
                    Case "F"
                        P1.OleDbType = OleDbType.Double
                    Case "B"
                        P1.OleDbType = OleDbType.Boolean
                    Case "P"
                        P1.OleDbType = OleDbType.LongVarBinary 'Type Picture
                    Case "M"
                        P1.OleDbType = OleDbType.LongVarWChar ' Type Memo
                    Case "Y"
                        P1.OleDbType = OleDbType.Currency
                End Select
                cmd.Parameters.Add(P1)
            Next
        End If
        Return cmd
    End Function
    Public Function CheckTable(ByVal tablename As String) As Boolean
        Dim Y As Integer = Me.ExecuteScalar("select count(*) from sysobjects where type ='u' and name = '" & tablename & "'")
        Dim Z As Boolean = False
        If Y = 1 Then Z = True
        Return Z
    End Function
    Public Sub GridToList(ByVal G1 As DataGridView)
        With G1
            .AllowUserToAddRows = False
            .ReadOnly = True
            .AllowUserToDeleteRows = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro 'สลับสีบรรทัด
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells ' จัด column ให้ตามต้องการ
            .AllowUserToOrderColumns = True
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        End With
    End Sub
    Public Sub GridToListNew(ByVal G1 As DataGridView)
        With G1
            .AllowUserToAddRows = False
            .ReadOnly = True
            .AllowUserToDeleteRows = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro 'สลับสีบรรทัด
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells ' จัด column ให้ตามต้องการ
            .AllowUserToOrderColumns = True
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            For i As Integer = 0 To G1.Columns.Count - 1
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        End With
    End Sub
    Public Sub GridToKey(ByVal G1 As DataGridView)
        With G1
            .AllowUserToAddRows = True
            .ReadOnly = False
            .AllowUserToDeleteRows = True
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro 'สลับสีบรรทัด
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells ' จัด column ให้ตามต้องการ
            .AllowUserToOrderColumns = True
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        End With
    End Sub
    ''' <summary>
    ''' ทำให้เป็นรูปแบบ Hyperlink
    ''' </summary>
    ''' <param name="G1"></param>
    ''' <param name="C1"></param>
    ''' <remarks></remarks>
    Public Sub GridLink(ByVal G1 As DataGridView, ByVal C1 As Integer)
        With G1
            .Columns(C1).DefaultCellStyle.ForeColor = Color.Blue
            .Columns(C1).DefaultCellStyle.Font = New Font("Tahoma", 12, FontStyle.Underline, Nothing, Nothing)
        End With
    End Sub
    ''' <summary>
    ''' เปลี่ยนสีของ Button
    ''' </summary>
    ''' <param name="P1">ชื่อ Panel ที่ Button อยู่</param>
    ''' <remarks></remarks>
    Public Sub ClearButton(ByVal P1 As Panel)
        For Each ctl As Control In P1.Controls
            If TypeOf ctl Is Button Then
                ctl.BackColor = SystemColors.Control
                ctl.ForeColor = Color.Blue
            End If
        Next
    End Sub
    
    ''' <summary>
    ''' กำหนด Header text ให้ Grid
    ''' </summary>
    ''' <param name="G1">ชื่อ Grid เป็น Parameter</param>
    ''' <param name="strHeader">Header ของแต่ละ Column คั่นด้วย "|"</param>
    ''' <remarks></remarks>
    Public Sub GridHeaderText(ByVal G1 As DataGridView, ByVal strHeader As String) 'วนลูปเปลี่ยนชื่อ column ใน GridVeiw
        Dim a1() As String = Split(strHeader, "|")
        For i As Integer = 0 To UBound(a1)
            If i <= G1.Columns.Count - 1 Then
                If a1(i) <> "" Then
                    G1.Columns(i).HeaderText = a1(i)
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' กำหนด Format ใน Grid
    ''' </summary>
    ''' <param name="G1"></param>
    ''' <param name="Xformat">T:Text,P:Picture:,I :Ineger,D:Date,X:Time,F:Decimal(2),G:Decimal(3)</param>
    ''' <remarks></remarks>
    Public Sub GridFormat(ByVal G1 As DataGridView, ByVal Xformat As String)
        If Xformat <> "" Then
            For i As Integer = 1 To Len(Xformat)
                If i <= G1.Columns.Count Then
                    Dim X As String = UCase(Mid(Xformat, i, 1))
                    Dim col As DataGridViewColumn = G1.Columns(i - 1)
                    Select Case X
                        Case "T"
                        Case "P"
                        Case "X"
                            col.DefaultCellStyle.Format = "HH:MM"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Case "I"
                            col.DefaultCellStyle.Format = "n0"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        Case "D"
                            col.DefaultCellStyle.Format = "dd.MMM.yyyy"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Case "F"
                            col.DefaultCellStyle.Format = "n2"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        Case "G"
                            col.DefaultCellStyle.Format = "n3"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End Select
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' กำหนด Format ใน Grid ถ้า Xformat น้อยกว่า Datagrid ให้ใช้ Format ตัวสุดท้าย
    ''' </summary>
    ''' <param name="G1"></param>
    ''' <param name="Xformat">T:Text,P:Picture:,I :Ineger,D:Date,X:Time,F:Decimal(2),G:Decimal(3)</param>
    ''' <remarks></remarks>
    Public Sub GridFormatNew(ByVal G1 As DataGridView, ByVal Xformat As String)
        If Xformat <> "" Then
            For i As Integer = 1 To G1.Columns.Count
                If i <= G1.Columns.Count Then
                    Dim X As String
                    If i > Len(Xformat) Then X = UCase(Right(Xformat, 1)) Else X = UCase(Mid(Xformat, i, 1))
                    Dim col As DataGridViewColumn = G1.Columns(i - 1)
                    Select Case X
                        Case "T"
                        Case "P"
                        Case "X"
                            col.DefaultCellStyle.Format = "HH:MM"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Case "I"
                            col.DefaultCellStyle.Format = "n0"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        Case "D"
                            col.DefaultCellStyle.Format = "dd.MMM.yyyy"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Case "F"
                            col.DefaultCellStyle.Format = "n2"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        Case "G"
                            col.DefaultCellStyle.Format = "n3"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End Select
                End If
            Next
        End If
    End Sub
    Protected Overrides Sub Finalize()
        Me.ConnectionClose()
        MyBase.Finalize()
    End Sub
End Class
