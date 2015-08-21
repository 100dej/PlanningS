Imports System.ComponentModel
Public Class NPILabel
    Inherits Label
    Dim m_Check As Boolean = False
    Public Sub New()
        'Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Me.Font = New Font("Tahoma", 8, FontStyle.Bold)
        Me.TextAlign = ContentAlignment.MiddleLeft
        Me.Cursor = Cursors.Hand
        Me.ImageAlign = ContentAlignment.MiddleRight
    End Sub
    Private Sub NPILabel_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Me.Layout
        Me.AutoSize = False
    End Sub
    <DefaultValue(False)> _
    Public Property Check() As Boolean
        Get
            Return m_Check
        End Get
        Set(ByVal value As Boolean)
            m_Check = value
            If m_Check Then
                Me.Image = My.Resources.OK
                Me.BackColor = Color.Cyan
            Else
                Me.Image = Nothing
                Me.BackColor = SystemColors.Control
            End If
        End Set
    End Property
End Class
