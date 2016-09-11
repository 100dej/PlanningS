<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangecsotBeginStock
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCostxx = New PlanningS.NPIButton()
        Me.cmdExeccost = New PlanningS.NPIButton()
        Me.cmd582000 = New PlanningS.NPIButton()
        Me.dtpPostdate = New System.Windows.Forms.DateTimePicker()
        Me.cmd581000 = New PlanningS.NPIButton()
        Me.cmdExecute583 = New PlanningS.NPIButton()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgMaster = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCostxx)
        Me.Panel1.Controls.Add(Me.cmdExeccost)
        Me.Panel1.Controls.Add(Me.cmd582000)
        Me.Panel1.Controls.Add(Me.dtpPostdate)
        Me.Panel1.Controls.Add(Me.cmd581000)
        Me.Panel1.Controls.Add(Me.cmdExecute583)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1193, 92)
        Me.Panel1.TabIndex = 0
        '
        'cmdCostxx
        '
        Me.cmdCostxx.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCostxx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCostxx.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCostxx.ForeColor = System.Drawing.Color.Blue
        Me.cmdCostxx.Location = New System.Drawing.Point(621, 55)
        Me.cmdCostxx.Name = "cmdCostxx"
        Me.cmdCostxx.Size = New System.Drawing.Size(75, 23)
        Me.cmdCostxx.TabIndex = 6
        Me.cmdCostxx.Text = "costxx"
        Me.cmdCostxx.UseVisualStyleBackColor = True
        '
        'cmdExeccost
        '
        Me.cmdExeccost.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExeccost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExeccost.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExeccost.ForeColor = System.Drawing.Color.Blue
        Me.cmdExeccost.Location = New System.Drawing.Point(486, 55)
        Me.cmdExeccost.Name = "cmdExeccost"
        Me.cmdExeccost.Size = New System.Drawing.Size(93, 23)
        Me.cmdExeccost.TabIndex = 5
        Me.cmdExeccost.Text = "ExecuteCost"
        Me.cmdExeccost.UseVisualStyleBackColor = True
        '
        'cmd582000
        '
        Me.cmd582000.BackColor = System.Drawing.SystemColors.Control
        Me.cmd582000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd582000.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd582000.ForeColor = System.Drawing.Color.Blue
        Me.cmd582000.Location = New System.Drawing.Point(746, 12)
        Me.cmd582000.Name = "cmd582000"
        Me.cmd582000.Size = New System.Drawing.Size(75, 23)
        Me.cmd582000.TabIndex = 4
        Me.cmd582000.Text = "582000"
        Me.cmd582000.UseVisualStyleBackColor = True
        '
        'dtpPostdate
        '
        Me.dtpPostdate.CustomFormat = "dd.MM.yyyy"
        Me.dtpPostdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPostdate.Location = New System.Drawing.Point(323, 41)
        Me.dtpPostdate.Name = "dtpPostdate"
        Me.dtpPostdate.Size = New System.Drawing.Size(105, 20)
        Me.dtpPostdate.TabIndex = 3
        '
        'cmd581000
        '
        Me.cmd581000.BackColor = System.Drawing.SystemColors.Control
        Me.cmd581000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd581000.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd581000.ForeColor = System.Drawing.Color.Blue
        Me.cmd581000.Location = New System.Drawing.Point(621, 12)
        Me.cmd581000.Name = "cmd581000"
        Me.cmd581000.Size = New System.Drawing.Size(75, 23)
        Me.cmd581000.TabIndex = 1
        Me.cmd581000.Text = "581000"
        Me.cmd581000.UseVisualStyleBackColor = True
        '
        'cmdExecute583
        '
        Me.cmdExecute583.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExecute583.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExecute583.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExecute583.ForeColor = System.Drawing.Color.Blue
        Me.cmdExecute583.Location = New System.Drawing.Point(486, 13)
        Me.cmdExecute583.Name = "cmdExecute583"
        Me.cmdExecute583.Size = New System.Drawing.Size(93, 23)
        Me.cmdExecute583.TabIndex = 0
        Me.cmdExecute583.Text = "&Execute583"
        Me.cmdExecute583.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 92)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1193, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgMaster)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1193, 388)
        Me.Panel2.TabIndex = 2
        '
        'dtgMaster
        '
        Me.dtgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMaster.Location = New System.Drawing.Point(0, 0)
        Me.dtgMaster.Name = "dtgMaster"
        Me.dtgMaster.Size = New System.Drawing.Size(1193, 388)
        Me.dtgMaster.TabIndex = 0
        '
        'FrmChangecsotBeginStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 483)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmChangecsotBeginStock"
        Me.TabText = "Begin Stock"
        Me.Text = "BeginStock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdExecute583 As PlanningS.NPIButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtgMaster As System.Windows.Forms.DataGridView
    Friend WithEvents cmd581000 As PlanningS.NPIButton
    Friend WithEvents dtpPostdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd582000 As PlanningS.NPIButton
    Friend WithEvents cmdExeccost As PlanningS.NPIButton
    Friend WithEvents cmdCostxx As PlanningS.NPIButton
End Class
