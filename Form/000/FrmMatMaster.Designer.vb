<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatMaster
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
        Me.components = New System.ComponentModel.Container
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblFilter = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.dtGridMatMaster = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyGrid = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExport = New PlanningS.NPIButton
        Me.cmdExec = New PlanningS.NPIButton
        Me.txtEng = New PlanningS.NPIText
        Me.txtMat = New PlanningS.NPIText
        Me.pnHeader.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dtGridMatMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnHeader.Controls.Add(Me.cmdExport)
        Me.pnHeader.Controls.Add(Me.cmdExec)
        Me.pnHeader.Controls.Add(Me.Label2)
        Me.pnHeader.Controls.Add(Me.Label1)
        Me.pnHeader.Controls.Add(Me.txtEng)
        Me.pnHeader.Controls.Add(Me.txtMat)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1121, 100)
        Me.pnHeader.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name ENGLISH :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Material number :"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 100)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1121, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFilter, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1121, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblFilter
        '
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(55, 17)
        Me.lblFilter.Text = "Filter By :"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.IsLink = True
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(53, 17)
        Me.lblStatus.Text = "Show &All"
        '
        'dtGridMatMaster
        '
        Me.dtGridMatMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridMatMaster.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtGridMatMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridMatMaster.Location = New System.Drawing.Point(0, 103)
        Me.dtGridMatMaster.Name = "dtGridMatMaster"
        Me.dtGridMatMaster.Size = New System.Drawing.Size(1121, 397)
        Me.dtGridMatMaster.TabIndex = 16
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyGrid})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 26)
        '
        'CopyGrid
        '
        Me.CopyGrid.Name = "CopyGrid"
        Me.CopyGrid.Size = New System.Drawing.Size(127, 22)
        Me.CopyGrid.Text = "Copy Grid"
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(426, 62)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 23)
        Me.cmdExport.TabIndex = 4
        Me.cmdExport.Text = "Export Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(336, 62)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 3
        Me.cmdExec.Text = "Excute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'txtEng
        '
        Me.txtEng.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtEng.Location = New System.Drawing.Point(479, 16)
        Me.txtEng.MaxLength = 40
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Size = New System.Drawing.Size(178, 22)
        Me.txtEng.TabIndex = 1
        '
        'txtMat
        '
        Me.txtMat.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMat.Location = New System.Drawing.Point(160, 19)
        Me.txtMat.MaxLength = 18
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(149, 22)
        Me.txtMat.TabIndex = 0
        '
        'FrmMatMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 522)
        Me.Controls.Add(Me.dtGridMatMaster)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "FrmMatMaster"
        Me.TabText = "รายละเอียดสินค้า"
        Me.Text = "รายละเอียดสินค้า"
        Me.pnHeader.ResumeLayout(False)
        Me.pnHeader.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dtGridMatMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtEng As PlanningS.NPIText
    Friend WithEvents txtMat As PlanningS.NPIText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdExport As PlanningS.NPIButton
    Friend WithEvents cmdExec As PlanningS.NPIButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblFilter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dtGridMatMaster As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyGrid As System.Windows.Forms.ToolStripMenuItem
End Class
