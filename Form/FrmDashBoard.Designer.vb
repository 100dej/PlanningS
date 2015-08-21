<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashBoard
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cboUname = New System.Windows.Forms.ComboBox
        Me.cboVname = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnChartOF = New System.Windows.Forms.Panel
        Me.rbSirichai = New System.Windows.Forms.RadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.cmdExec = New PlanningS.NPIButton
        Me.cmdSetVariant = New PlanningS.NPIButton
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnChartOF.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.cmdExec)
        Me.Panel1.Controls.Add(Me.cmdSetVariant)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.cboUname)
        Me.Panel1.Controls.Add(Me.cboVname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1190, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(285, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Variant :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboUname
        '
        Me.cboUname.FormattingEnabled = True
        Me.cboUname.Location = New System.Drawing.Point(159, 12)
        Me.cboUname.Name = "cboUname"
        Me.cboUname.Size = New System.Drawing.Size(121, 21)
        Me.cboUname.TabIndex = 3
        '
        'cboVname
        '
        Me.cboVname.FormattingEnabled = True
        Me.cboVname.Location = New System.Drawing.Point(353, 12)
        Me.cboVname.Name = "cboVname"
        Me.cboVname.Size = New System.Drawing.Size(251, 21)
        Me.cboVname.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(189, 565)
        Me.Panel2.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(189, 565)
        Me.TreeView1.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(189, 41)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 565)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'pnChartOF
        '
        Me.pnChartOF.Controls.Add(Me.rbSirichai)
        Me.pnChartOF.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnChartOF.Location = New System.Drawing.Point(192, 41)
        Me.pnChartOF.Name = "pnChartOF"
        Me.pnChartOF.Size = New System.Drawing.Size(998, 30)
        Me.pnChartOF.TabIndex = 4
        '
        'rbSirichai
        '
        Me.rbSirichai.AutoSize = True
        Me.rbSirichai.Location = New System.Drawing.Point(15, 6)
        Me.rbSirichai.Name = "rbSirichai"
        Me.rbSirichai.Size = New System.Drawing.Size(72, 17)
        Me.rbSirichai.TabIndex = 0
        Me.rbSirichai.TabStop = True
        Me.rbSirichai.Tag = "0"
        Me.rbSirichai.Text = "Sirichai B."
        Me.rbSirichai.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Chart1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(192, 71)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(998, 535)
        Me.Panel4.TabIndex = 5
        '
        'Chart1
        '
        Me.Chart1.Location = New System.Drawing.Point(10, 10)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(430, 334)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(622, 12)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 5
        Me.cmdExec.Text = "&Excute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'cmdSetVariant
        '
        Me.cmdSetVariant.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetVariant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSetVariant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSetVariant.ForeColor = System.Drawing.Color.Blue
        Me.cmdSetVariant.Location = New System.Drawing.Point(12, 12)
        Me.cmdSetVariant.Name = "cmdSetVariant"
        Me.cmdSetVariant.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetVariant.TabIndex = 4
        Me.cmdSetVariant.Text = "&Setting"
        Me.cmdSetVariant.UseVisualStyleBackColor = True
        '
        'FrmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 606)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.pnChartOF)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDashBoard"
        Me.TabText = "FrmDashBoard"
        Me.Text = "FrmDashBoard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnChartOF.ResumeLayout(False)
        Me.pnChartOF.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents cmdSetVariant As PlanningS.NPIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboUname As System.Windows.Forms.ComboBox
    Friend WithEvents cboVname As System.Windows.Forms.ComboBox
    Friend WithEvents cmdExec As PlanningS.NPIButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnChartOF As System.Windows.Forms.Panel
    Friend WithEvents rbSirichai As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
