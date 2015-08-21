<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDaysSale
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
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEng = New PlanningS.NPIText
        Me.cmdExport = New PlanningS.NPIButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMat = New PlanningS.NPIText
        Me.cmdExec = New PlanningS.NPIButton
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgGridAllMat = New System.Windows.Forms.DataGridView
        Me.pnHeader.SuspendLayout()
        CType(Me.dtgGridAllMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnHeader.Controls.Add(Me.Label2)
        Me.pnHeader.Controls.Add(Me.txtEng)
        Me.pnHeader.Controls.Add(Me.cmdExport)
        Me.pnHeader.Controls.Add(Me.Label1)
        Me.pnHeader.Controls.Add(Me.txtMat)
        Me.pnHeader.Controls.Add(Me.cmdExec)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1196, 95)
        Me.pnHeader.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name ENGLISH :"
        '
        'txtEng
        '
        Me.txtEng.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtEng.Location = New System.Drawing.Point(475, 12)
        Me.txtEng.MaxLength = 40
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Size = New System.Drawing.Size(178, 22)
        Me.txtEng.TabIndex = 1
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(422, 52)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 23)
        Me.cmdExport.TabIndex = 4
        Me.cmdExport.Text = "Export Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Material number :"
        '
        'txtMat
        '
        Me.txtMat.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMat.Location = New System.Drawing.Point(157, 12)
        Me.txtMat.MaxLength = 18
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(149, 22)
        Me.txtMat.TabIndex = 0
        Me.txtMat.Text = "ZZ11"
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(332, 52)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 3
        Me.cmdExec.Text = "Excute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 95)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1196, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dtgGridAllMat
        '
        Me.dtgGridAllMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGridAllMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgGridAllMat.Location = New System.Drawing.Point(0, 98)
        Me.dtgGridAllMat.Name = "dtgGridAllMat"
        Me.dtgGridAllMat.Size = New System.Drawing.Size(1196, 350)
        Me.dtgGridAllMat.TabIndex = 2
        '
        'FrmDaysSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 448)
        Me.Controls.Add(Me.dtgGridAllMat)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "FrmDaysSale"
        Me.TabText = "ดูวันขาย"
        Me.Text = "ดูวันขาย"
        Me.pnHeader.ResumeLayout(False)
        Me.pnHeader.PerformLayout()
        CType(Me.dtgGridAllMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents cmdExport As PlanningS.NPIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMat As PlanningS.NPIText
    Friend WithEvents cmdExec As PlanningS.NPIButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dtgGridAllMat As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEng As PlanningS.NPIText
End Class
