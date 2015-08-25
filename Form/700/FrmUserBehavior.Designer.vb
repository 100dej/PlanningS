<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserBehavior
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CUser = New System.Windows.Forms.Label
        Me.rbThisMonth = New System.Windows.Forms.RadioButton
        Me.rbThisWeek = New System.Windows.Forms.RadioButton
        Me.rbToday = New System.Windows.Forms.RadioButton
        Me.rbStatProgram = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbUser = New System.Windows.Forms.ListBox
        Me.pnBegin = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnToday = New System.Windows.Forms.Panel
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnTodayLeft = New System.Windows.Forms.Panel
        Me.pnError = New System.Windows.Forms.Panel
        Me.dtgError = New System.Windows.Forms.DataGridView
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnExecute = New System.Windows.Forms.Panel
        Me.dtgExcute = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnBegin.SuspendLayout()
        Me.pnToday.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTodayLeft.SuspendLayout()
        Me.pnError.SuspendLayout()
        CType(Me.dtgError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnExecute.SuspendLayout()
        CType(Me.dtgExcute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CUser)
        Me.Panel2.Controls.Add(Me.rbThisMonth)
        Me.Panel2.Controls.Add(Me.rbThisWeek)
        Me.Panel2.Controls.Add(Me.rbToday)
        Me.Panel2.Controls.Add(Me.rbStatProgram)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1170, 33)
        Me.Panel2.TabIndex = 6
        '
        'CUser
        '
        Me.CUser.AutoSize = True
        Me.CUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CUser.Location = New System.Drawing.Point(421, 2)
        Me.CUser.Name = "CUser"
        Me.CUser.Size = New System.Drawing.Size(72, 24)
        Me.CUser.TabIndex = 4
        Me.CUser.Text = "Label4"
        '
        'rbThisMonth
        '
        Me.rbThisMonth.AutoSize = True
        Me.rbThisMonth.Location = New System.Drawing.Point(234, 8)
        Me.rbThisMonth.Name = "rbThisMonth"
        Me.rbThisMonth.Size = New System.Drawing.Size(78, 17)
        Me.rbThisMonth.TabIndex = 3
        Me.rbThisMonth.TabStop = True
        Me.rbThisMonth.Tag = "4"
        Me.rbThisMonth.Text = "This Month"
        Me.rbThisMonth.UseVisualStyleBackColor = True
        '
        'rbThisWeek
        '
        Me.rbThisWeek.AutoSize = True
        Me.rbThisWeek.Location = New System.Drawing.Point(148, 8)
        Me.rbThisWeek.Name = "rbThisWeek"
        Me.rbThisWeek.Size = New System.Drawing.Size(77, 17)
        Me.rbThisWeek.TabIndex = 2
        Me.rbThisWeek.TabStop = True
        Me.rbThisWeek.Tag = "3"
        Me.rbThisWeek.Text = "This Week"
        Me.rbThisWeek.UseVisualStyleBackColor = True
        '
        'rbToday
        '
        Me.rbToday.AutoSize = True
        Me.rbToday.Location = New System.Drawing.Point(86, 8)
        Me.rbToday.Name = "rbToday"
        Me.rbToday.Size = New System.Drawing.Size(55, 17)
        Me.rbToday.TabIndex = 1
        Me.rbToday.TabStop = True
        Me.rbToday.Tag = "2"
        Me.rbToday.Text = "Today"
        Me.rbToday.UseVisualStyleBackColor = True
        '
        'rbStatProgram
        '
        Me.rbStatProgram.AutoSize = True
        Me.rbStatProgram.Location = New System.Drawing.Point(5, 8)
        Me.rbStatProgram.Name = "rbStatProgram"
        Me.rbStatProgram.Size = New System.Drawing.Size(78, 17)
        Me.rbStatProgram.TabIndex = 0
        Me.rbStatProgram.TabStop = True
        Me.rbStatProgram.Tag = "1"
        Me.rbStatProgram.Text = "From Begin"
        Me.rbStatProgram.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 582)
        Me.Panel1.TabIndex = 7
        '
        'lbUser
        '
        Me.lbUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbUser.FormattingEnabled = True
        Me.lbUser.Location = New System.Drawing.Point(0, 0)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(151, 576)
        Me.lbUser.TabIndex = 6
        '
        'pnBegin
        '
        Me.pnBegin.Controls.Add(Me.Label1)
        Me.pnBegin.Location = New System.Drawing.Point(884, 44)
        Me.pnBegin.Name = "pnBegin"
        Me.pnBegin.Size = New System.Drawing.Size(286, 124)
        Me.pnBegin.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'pnToday
        '
        Me.pnToday.Controls.Add(Me.Chart2)
        Me.pnToday.Controls.Add(Me.Chart1)
        Me.pnToday.Controls.Add(Me.Splitter1)
        Me.pnToday.Controls.Add(Me.pnTodayLeft)
        Me.pnToday.Controls.Add(Me.Panel3)
        Me.pnToday.Location = New System.Drawing.Point(157, 55)
        Me.pnToday.Name = "pnToday"
        Me.pnToday.Size = New System.Drawing.Size(976, 519)
        Me.pnToday.TabIndex = 9
        '
        'Chart2
        '
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart2.Location = New System.Drawing.Point(513, 516)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Size = New System.Drawing.Size(463, 3)
        Me.Chart2.TabIndex = 16
        Me.Chart2.Text = "Chart2"
        '
        'Chart1
        '
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Chart1.Location = New System.Drawing.Point(513, 30)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(463, 486)
        Me.Chart1.TabIndex = 15
        Me.Chart1.Text = "Chart1"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(510, 30)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 489)
        Me.Splitter1.TabIndex = 14
        Me.Splitter1.TabStop = False
        '
        'pnTodayLeft
        '
        Me.pnTodayLeft.Controls.Add(Me.pnError)
        Me.pnTodayLeft.Controls.Add(Me.pnExecute)
        Me.pnTodayLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnTodayLeft.Location = New System.Drawing.Point(0, 30)
        Me.pnTodayLeft.Name = "pnTodayLeft"
        Me.pnTodayLeft.Size = New System.Drawing.Size(510, 489)
        Me.pnTodayLeft.TabIndex = 13
        '
        'pnError
        '
        Me.pnError.Controls.Add(Me.dtgError)
        Me.pnError.Controls.Add(Me.Panel4)
        Me.pnError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnError.Location = New System.Drawing.Point(0, 496)
        Me.pnError.Name = "pnError"
        Me.pnError.Size = New System.Drawing.Size(510, 0)
        Me.pnError.TabIndex = 10
        '
        'dtgError
        '
        Me.dtgError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgError.Location = New System.Drawing.Point(0, 27)
        Me.dtgError.Name = "dtgError"
        Me.dtgError.Size = New System.Drawing.Size(510, 0)
        Me.dtgError.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(510, 27)
        Me.Panel4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(7, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Error"
        '
        'pnExecute
        '
        Me.pnExecute.Controls.Add(Me.dtgExcute)
        Me.pnExecute.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnExecute.Location = New System.Drawing.Point(0, 0)
        Me.pnExecute.Name = "pnExecute"
        Me.pnExecute.Size = New System.Drawing.Size(510, 496)
        Me.pnExecute.TabIndex = 8
        '
        'dtgExcute
        '
        Me.dtgExcute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgExcute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgExcute.Location = New System.Drawing.Point(0, 0)
        Me.dtgExcute.Name = "dtgExcute"
        Me.dtgExcute.Size = New System.Drawing.Size(510, 496)
        Me.dtgExcute.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(976, 30)
        Me.Panel3.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Execute"
        '
        'FrmUserBehavior
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 615)
        Me.Controls.Add(Me.pnToday)
        Me.Controls.Add(Me.pnBegin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmUserBehavior"
        Me.TabText = "Who used program?"
        Me.Text = "Who used program?"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnBegin.ResumeLayout(False)
        Me.pnBegin.PerformLayout()
        Me.pnToday.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTodayLeft.ResumeLayout(False)
        Me.pnError.ResumeLayout(False)
        CType(Me.dtgError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnExecute.ResumeLayout(False)
        CType(Me.dtgExcute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbToday As System.Windows.Forms.RadioButton
    Friend WithEvents rbStatProgram As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbUser As System.Windows.Forms.ListBox
    Friend WithEvents pnBegin As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnToday As System.Windows.Forms.Panel
    Friend WithEvents rbThisMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rbThisWeek As System.Windows.Forms.RadioButton
    Friend WithEvents CUser As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnTodayLeft As System.Windows.Forms.Panel
    Friend WithEvents pnError As System.Windows.Forms.Panel
    Friend WithEvents dtgError As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnExecute As System.Windows.Forms.Panel
    Friend WithEvents dtgExcute As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
