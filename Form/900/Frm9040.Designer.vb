<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm9040
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NpiButton1 = New PlanningS.NPIButton()
        Me.NpiButton2 = New PlanningS.NPIButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'NpiButton1
        '
        Me.NpiButton1.BackColor = System.Drawing.SystemColors.Control
        Me.NpiButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiButton1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiButton1.ForeColor = System.Drawing.Color.Blue
        Me.NpiButton1.Location = New System.Drawing.Point(275, 44)
        Me.NpiButton1.Name = "NpiButton1"
        Me.NpiButton1.Size = New System.Drawing.Size(75, 23)
        Me.NpiButton1.TabIndex = 0
        Me.NpiButton1.Text = "Export"
        Me.NpiButton1.UseVisualStyleBackColor = False
        '
        'NpiButton2
        '
        Me.NpiButton2.BackColor = System.Drawing.SystemColors.Control
        Me.NpiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiButton2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiButton2.ForeColor = System.Drawing.Color.Blue
        Me.NpiButton2.Location = New System.Drawing.Point(135, 44)
        Me.NpiButton2.Name = "NpiButton2"
        Me.NpiButton2.Size = New System.Drawing.Size(75, 23)
        Me.NpiButton2.TabIndex = 1
        Me.NpiButton2.Text = "Import"
        Me.NpiButton2.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(135, 127)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Frm9040
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 288)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.NpiButton2)
        Me.Controls.Add(Me.NpiButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm9040"
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NpiButton1 As NPIButton
    Friend WithEvents NpiButton2 As NPIButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
