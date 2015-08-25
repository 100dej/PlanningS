<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRevalue
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
        Me.pnCondition = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.dtgMaster = New System.Windows.Forms.DataGridView()
        Me.txtMonth = New PlanningS.NPIText()
        Me.txtYear = New PlanningS.NPIText()
        Me.cmdExecFC = New PlanningS.NPIButton()
        Me.cmdExpTemp = New PlanningS.NPIButton()
        Me.cmdExecVC = New PlanningS.NPIButton()
        Me.pnCondition.SuspendLayout()
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnCondition
        '
        Me.pnCondition.Controls.Add(Me.txtMonth)
        Me.pnCondition.Controls.Add(Me.txtYear)
        Me.pnCondition.Controls.Add(Me.Label2)
        Me.pnCondition.Controls.Add(Me.Label1)
        Me.pnCondition.Controls.Add(Me.cmdExecFC)
        Me.pnCondition.Controls.Add(Me.cmdExpTemp)
        Me.pnCondition.Controls.Add(Me.cmdExecVC)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(1257, 92)
        Me.pnCondition.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Year :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Month :"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 92)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1257, 3)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'dtgMaster
        '
        Me.dtgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMaster.Location = New System.Drawing.Point(0, 95)
        Me.dtgMaster.Name = "dtgMaster"
        Me.dtgMaster.Size = New System.Drawing.Size(1257, 367)
        Me.dtgMaster.TabIndex = 3
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMonth.Location = New System.Drawing.Point(89, 20)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(43, 22)
        Me.txtMonth.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtYear.Location = New System.Drawing.Point(196, 19)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(81, 22)
        Me.txtYear.TabIndex = 1
        '
        'cmdExecFC
        '
        Me.cmdExecFC.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExecFC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExecFC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExecFC.ForeColor = System.Drawing.Color.Blue
        Me.cmdExecFC.Location = New System.Drawing.Point(603, 12)
        Me.cmdExecFC.Name = "cmdExecFC"
        Me.cmdExecFC.Size = New System.Drawing.Size(93, 23)
        Me.cmdExecFC.TabIndex = 3
        Me.cmdExecFC.Text = "ExecuteFC"
        Me.cmdExecFC.UseVisualStyleBackColor = True
        '
        'cmdExpTemp
        '
        Me.cmdExpTemp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExpTemp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExpTemp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExpTemp.ForeColor = System.Drawing.Color.Blue
        Me.cmdExpTemp.Location = New System.Drawing.Point(486, 55)
        Me.cmdExpTemp.Name = "cmdExpTemp"
        Me.cmdExpTemp.Size = New System.Drawing.Size(93, 23)
        Me.cmdExpTemp.TabIndex = 4
        Me.cmdExpTemp.Text = "Template"
        Me.cmdExpTemp.UseVisualStyleBackColor = True
        '
        'cmdExecVC
        '
        Me.cmdExecVC.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExecVC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExecVC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExecVC.ForeColor = System.Drawing.Color.Blue
        Me.cmdExecVC.Location = New System.Drawing.Point(486, 13)
        Me.cmdExecVC.Name = "cmdExecVC"
        Me.cmdExecVC.Size = New System.Drawing.Size(93, 23)
        Me.cmdExecVC.TabIndex = 2
        Me.cmdExecVC.Text = "&ExecuteVC"
        Me.cmdExecVC.UseVisualStyleBackColor = True
        '
        'FrmRevalue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 462)
        Me.Controls.Add(Me.dtgMaster)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnCondition)
        Me.Name = "FrmRevalue"
        Me.TabText = "FrmRevalue"
        Me.Text = "FrmRevalue"
        Me.pnCondition.ResumeLayout(False)
        Me.pnCondition.PerformLayout()
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnCondition As System.Windows.Forms.Panel
    Friend WithEvents cmdExecFC As PlanningS.NPIButton
    Friend WithEvents cmdExpTemp As PlanningS.NPIButton
    Friend WithEvents cmdExecVC As PlanningS.NPIButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dtgMaster As System.Windows.Forms.DataGridView
    Friend WithEvents txtMonth As PlanningS.NPIText
    Friend WithEvents txtYear As PlanningS.NPIText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
