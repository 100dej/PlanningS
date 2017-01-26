<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReclass
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMonth = New PlanningS.NPIText()
        Me.txtYear = New PlanningS.NPIText()
        Me.cmdAct = New PlanningS.NPIButton()
        Me.cmdStd = New PlanningS.NPIButton()
        Me.SuspendLayout()
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMonth.Location = New System.Drawing.Point(187, 57)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(38, 22)
        Me.txtMonth.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtYear.Location = New System.Drawing.Point(257, 57)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(61, 22)
        Me.txtYear.TabIndex = 1
        '
        'cmdAct
        '
        Me.cmdAct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAct.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAct.ForeColor = System.Drawing.Color.Blue
        Me.cmdAct.Location = New System.Drawing.Point(393, 55)
        Me.cmdAct.Name = "cmdAct"
        Me.cmdAct.Size = New System.Drawing.Size(75, 23)
        Me.cmdAct.TabIndex = 2
        Me.cmdAct.Text = "Act7xx"
        Me.cmdAct.UseVisualStyleBackColor = False
        '
        'cmdStd
        '
        Me.cmdStd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdStd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdStd.ForeColor = System.Drawing.Color.Blue
        Me.cmdStd.Location = New System.Drawing.Point(519, 55)
        Me.cmdStd.Name = "cmdStd"
        Me.cmdStd.Size = New System.Drawing.Size(75, 23)
        Me.cmdStd.TabIndex = 3
        Me.cmdStd.Text = "Std"
        Me.cmdStd.UseVisualStyleBackColor = False
        '
        'FrmReclass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 361)
        Me.Controls.Add(Me.cmdStd)
        Me.Controls.Add(Me.cmdAct)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmReclass"
        Me.Text = "FrmReclass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMonth As NPIText
    Friend WithEvents txtYear As NPIText
    Friend WithEvents cmdAct As NPIButton
    Friend WithEvents cmdStd As NPIButton
End Class
