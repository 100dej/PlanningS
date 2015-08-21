<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits WeifenLuo.WinFormsUI.DockContent

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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnFG = New System.Windows.Forms.FlowLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dTpicker1 = New System.Windows.Forms.DateTimePicker
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdShow = New PlanningS.NPIButton
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnFG)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(817, 74)
        Me.Panel2.TabIndex = 5
        '
        'pnFG
        '
        Me.pnFG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnFG.Location = New System.Drawing.Point(0, 0)
        Me.pnFG.Name = "pnFG"
        Me.pnFG.Size = New System.Drawing.Size(617, 74)
        Me.pnFG.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdShow)
        Me.Panel3.Controls.Add(Me.dTpicker1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(617, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 74)
        Me.Panel3.TabIndex = 9
        '
        'dTpicker1
        '
        Me.dTpicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dTpicker1.CustomFormat = ""
        Me.dTpicker1.Location = New System.Drawing.Point(24, 3)
        Me.dTpicker1.Name = "dTpicker1"
        Me.dTpicker1.Size = New System.Drawing.Size(105, 20)
        Me.dTpicker1.TabIndex = 4
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 74)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(817, 3)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 299)
        Me.Panel1.TabIndex = 7
        '
        'cmdShow
        '
        Me.cmdShow.BackColor = System.Drawing.SystemColors.Control
        Me.cmdShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdShow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdShow.ForeColor = System.Drawing.Color.Blue
        Me.cmdShow.Location = New System.Drawing.Point(24, 30)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(75, 23)
        Me.cmdShow.TabIndex = 5
        Me.cmdShow.Text = "Show All"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 376)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form2"
        Me.TabText = "Form2"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnFG As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dTpicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdShow As PlanningS.NPIButton
End Class
