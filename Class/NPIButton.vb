Public Class NPIButton
    Inherits Button 'ถ่ายทอด object จาก Button
    Public Sub New()
        Me.ForeColor = Color.Blue
        Me.BackColor = SystemColors.Control
        Me.Font = New Font("Arial", 8, FontStyle.Bold)
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub BEnter() Handles Me.MouseClick, Me.KeyPress
        If Me.Enabled = False Then
        Else
            Me.BackColor = Color.DarkGreen
            Me.ForeColor = Color.Yellow
        End If
    End Sub
    Private Sub BFocus() Handles Me.MouseEnter, Me.GotFocus
        If Me.BackColor = Color.DarkGreen Then
        Else
            Me.BackColor = Color.Red
            Me.ForeColor = Color.White
        End If
    End Sub
    Private Sub BLostFocus() Handles Me.MouseLeave, Me.LostFocus
        If Me.BackColor = Color.DarkGreen Then
        Else
            Me.BackColor = SystemColors.Control
            Me.ForeColor = Color.Blue
        End If
    End Sub
End Class


