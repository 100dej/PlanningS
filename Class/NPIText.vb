'<ToolboxBitmap(ชื่อ file) สำหรับทำ ICON
Imports System.ComponentModel
Public Class NPIText
    Inherits TextBox
    Dim m_numberOnly As Boolean = False
    Dim m_DecimalPlaces As Integer = 0
    Dim m_ShowComma As Boolean = True
    <DefaultValue(0), Description("จำนวนจุดทศนิยม"), Category("Data")> _
    Public Property DecimalPlaces() As Integer
        Get
            Return m_DecimalPlaces
        End Get
        Set(ByVal value As Integer)
            m_DecimalPlaces = value
        End Set
    End Property
    <DefaultValue(True), Description("ใส่ comma"), Category("Data")> _
    Public Property Showcomma() As Boolean
        Get
            Return m_ShowComma
        End Get
        Set(ByVal value As Boolean)
            m_ShowComma = value
        End Set
    End Property
    'ใส่คำอธิบาย Property
    <Description("Input Number Only in the Textbox"), DefaultValue(False), Category("Data")> _
    Public Property NumberOnly() As Boolean
        Get
            Return m_numberOnly ' ขั้นต้นต้องใส่
        End Get
        Set(ByVal value As Boolean)
            m_numberOnly = value ' ขั้นต้นต้องใส่
            If value Then
                Me.TextAlign = HorizontalAlignment.Right
            Else
                Me.TextAlign = HorizontalAlignment.Left
            End If
        End Set
    End Property
    Public Sub New()
        Me.Font = New Font("Tahoma", 9)
    End Sub
    Private Sub NPIText_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled = False Then
            Me.BackColor = SystemColors.Control()
        Else
            Me.BackColor = Color.White
        End If
    End Sub
    Private Sub NPIText_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.LightCyan
        Me.ForeColor = Color.Red
        If m_NumberOnly Then
            MyBase.Text = Replace(Me.Text, ",", "")
            Me.SelectAll()
        End If
    End Sub
    Private Sub NPIText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Down
                e.Handled = True
                SendKeys.Send("{TAB}")
            Case Keys.Up
                e.Handled = True
                SendKeys.Send("+{TAB}")
            Case Keys.Escape
                Me.Text = ""
                Me.SelectAll()
        End Select
    End Sub
    Private Sub NPIText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then ' ในกรณีที่ยังมีเสียงอยู่  ต้องมาดักที่ Key press
            e.Handled = True
            Exit Sub
        End If
        If m_numberOnly Then
            e.Handled = False
            Select Case e.KeyChar
                Case "0" To "9", Chr(8), Chr(27)
                Case "."
                    If m_DecimalPlaces = 0 Then
                        e.Handled = True
                    Else
                        If InStr(Me.Text, ".") > 0 Then
                            e.Handled = True
                        End If
                    End If
                Case Else
                    e.Handled = True
                    MsgBox("ใส่ตัวเลขครับ")
            End Select
        End If
    End Sub
    Private Sub NPIText_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
        Me.ForeColor = Color.Black
        FormatData()
    End Sub
    Private Sub FormatData()
        If m_NumberOnly Then
            If Me.Text = "" Then
                MyBase.Text = "0"
            End If
            Try
                If m_ShowComma Then
                    MyBase.Text = CDbl(Me.Text).ToString("n" & m_DecimalPlaces)
                Else
                    If m_DecimalPlaces = 0 Then
                        MyBase.Text = CDbl(Me.Text).ToString("0")
                    Else
                        MyBase.Text = CDbl(Me.Text).ToString("0." & New String("0", m_DecimalPlaces))
                    End If
                End If
            Catch ex As Exception
                MyBase.Text = "0"
                Me.SelectAll()
            End Try
        End If
    End Sub
    Public Function Value() As Object
        If m_NumberOnly Then
            Dim x As String = Me.Text
            If x = "" Then x = "0"
            Dim Y As Object
            If m_DecimalPlaces = 0 Then
                Try
                    Y = CInt(x)
                Catch ex As Exception
                    Y = Me.Name.ToString & " ==> " & ex.Message.ToString
                End Try
                Return Y
            Else
                Try
                    Y = CDbl(x)
                Catch ex As Exception
                    Y = Me.Name.ToString & " ==> " & ex.Message.ToString
                End Try
                Return Y
            End If
        Else
            Return Me.Text
        End If
    End Function
    Public Overrides Property Text() As String 'สำหรับ replace formant
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            FormatData()
        End Set
    End Property
End Class
