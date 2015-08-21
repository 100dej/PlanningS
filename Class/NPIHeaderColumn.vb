Public Class DGVColumnHeader
    Inherits DataGridViewColumnHeaderCell
    Private CheckBoxRegion As Rectangle
    Private m_checkAll As Boolean = False

    Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal dataGridViewElementState As DataGridViewElementStates, ByVal value As Object, _
     ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)

        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, _
         formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        graphics.FillRectangle(New SolidBrush(cellStyle.BackColor), cellBounds)

        CheckBoxRegion = New Rectangle(cellBounds.Location.X + 1, cellBounds.Location.Y + 2, 25, cellBounds.Size.Height - 4)

        If Me.m_checkAll Then
            ControlPaint.DrawCheckBox(graphics, CheckBoxRegion, ButtonState.Checked)
        Else
            ControlPaint.DrawCheckBox(graphics, CheckBoxRegion, ButtonState.Normal)
        End If

        Dim normalRegion As New Rectangle(cellBounds.Location.X + 1 + 25, cellBounds.Location.Y, cellBounds.Size.Width - 26, cellBounds.Size.Height)

        graphics.DrawString(value.ToString(), cellStyle.Font, New SolidBrush(cellStyle.ForeColor), normalRegion)
    End Sub

    Protected Overrides Sub OnMouseClick(ByVal e As DataGridViewCellMouseEventArgs)
        'Convert the CheckBoxRegion 
        Dim rec As New Rectangle(New Point(0, 0), Me.CheckBoxRegion.Size)
        Me.m_checkAll = Not Me.m_checkAll
        If rec.Contains(e.Location) Then
            Me.DataGridView.Invalidate()
        End If
        MyBase.OnMouseClick(e)
    End Sub

    Public Property CheckAll() As Boolean
        Get
            Return Me.m_checkAll
        End Get
        Set(ByVal value As Boolean)
            Me.m_checkAll = value
        End Set
    End Property
End Class
