<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangeMatConsoh
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
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgMaster = New System.Windows.Forms.DataGridView
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dtgChangeBin = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.dtgChangeStock = New System.Windows.Forms.DataGridView
        Me.cmdExportStock = New PlanningS.NPIButton
        Me.cmdExportBin = New PlanningS.NPIButton
        Me.cmdImportData = New PlanningS.NPIButton
        Me.cmdSave = New PlanningS.NPIButton
        Me.Panel1.SuspendLayout()
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgChangeBin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dtgChangeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.cmdImportData)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 50)
        Me.Panel1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 50)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1164, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dtgMaster
        '
        Me.dtgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMaster.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtgMaster.Location = New System.Drawing.Point(0, 53)
        Me.dtgMaster.Name = "dtgMaster"
        Me.dtgMaster.Size = New System.Drawing.Size(240, 433)
        Me.dtgMaster.TabIndex = 2
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(240, 53)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 433)
        Me.Splitter2.TabIndex = 3
        Me.Splitter2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgChangeBin)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(243, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 433)
        Me.Panel2.TabIndex = 4
        '
        'dtgChangeBin
        '
        Me.dtgChangeBin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgChangeBin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgChangeBin.Location = New System.Drawing.Point(0, 44)
        Me.dtgChangeBin.Name = "dtgChangeBin"
        Me.dtgChangeBin.Size = New System.Drawing.Size(278, 389)
        Me.dtgChangeBin.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdExportBin)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 44)
        Me.Panel3.TabIndex = 0
        '
        'Splitter3
        '
        Me.Splitter3.Location = New System.Drawing.Point(521, 53)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(3, 433)
        Me.Splitter3.TabIndex = 5
        Me.Splitter3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmdExportStock)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(524, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(640, 44)
        Me.Panel4.TabIndex = 6
        '
        'dtgChangeStock
        '
        Me.dtgChangeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgChangeStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgChangeStock.Location = New System.Drawing.Point(524, 97)
        Me.dtgChangeStock.Name = "dtgChangeStock"
        Me.dtgChangeStock.Size = New System.Drawing.Size(640, 389)
        Me.dtgChangeStock.TabIndex = 7
        '
        'cmdExportStock
        '
        Me.cmdExportStock.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExportStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExportStock.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExportStock.ForeColor = System.Drawing.Color.Blue
        Me.cmdExportStock.Location = New System.Drawing.Point(117, 7)
        Me.cmdExportStock.Name = "cmdExportStock"
        Me.cmdExportStock.Size = New System.Drawing.Size(104, 23)
        Me.cmdExportStock.TabIndex = 0
        Me.cmdExportStock.Text = "Export stock"
        Me.cmdExportStock.UseVisualStyleBackColor = True
        '
        'cmdExportBin
        '
        Me.cmdExportBin.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExportBin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExportBin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExportBin.ForeColor = System.Drawing.Color.Blue
        Me.cmdExportBin.Location = New System.Drawing.Point(95, 7)
        Me.cmdExportBin.Name = "cmdExportBin"
        Me.cmdExportBin.Size = New System.Drawing.Size(75, 23)
        Me.cmdExportBin.TabIndex = 0
        Me.cmdExportBin.Text = "Export bin"
        Me.cmdExportBin.UseVisualStyleBackColor = True
        '
        'cmdImportData
        '
        Me.cmdImportData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdImportData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdImportData.ForeColor = System.Drawing.Color.Blue
        Me.cmdImportData.Location = New System.Drawing.Point(67, 12)
        Me.cmdImportData.Name = "cmdImportData"
        Me.cmdImportData.Size = New System.Drawing.Size(75, 23)
        Me.cmdImportData.TabIndex = 0
        Me.cmdImportData.Text = "Import Data"
        Me.cmdImportData.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(982, 12)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'FrmChangeMatConsoh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 486)
        Me.Controls.Add(Me.dtgChangeStock)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Splitter3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.dtgMaster)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmChangeMatConsoh"
        Me.TabText = "Change mat in stock consoh"
        Me.Text = "Change mat in stock consoh"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgChangeBin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dtgChangeStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dtgMaster As System.Windows.Forms.DataGridView
    Friend WithEvents cmdImportData As PlanningS.NPIButton
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtgChangeBin As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtgChangeStock As System.Windows.Forms.DataGridView
    Friend WithEvents cmdExportBin As PlanningS.NPIButton
    Friend WithEvents cmdExportStock As PlanningS.NPIButton
    Friend WithEvents cmdSave As PlanningS.NPIButton
End Class
