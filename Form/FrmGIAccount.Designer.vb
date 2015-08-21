<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGIAccount
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
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgItem = New System.Windows.Forms.DataGridView
        Me.cmdSave = New PlanningS.NPIButton
        Me.cmdImport = New PlanningS.NPIButton
        Me.cmdDisplay = New PlanningS.NPIButton
        Me.cmdExport = New PlanningS.NPIButton
        Me.pnHeader.SuspendLayout()
        CType(Me.dtgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnHeader.Controls.Add(Me.cmdExport)
        Me.pnHeader.Controls.Add(Me.cmdDisplay)
        Me.pnHeader.Controls.Add(Me.cmdSave)
        Me.pnHeader.Controls.Add(Me.cmdImport)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(750, 60)
        Me.pnHeader.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 60)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(750, 3)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'dtgItem
        '
        Me.dtgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgItem.Location = New System.Drawing.Point(0, 63)
        Me.dtgItem.Name = "dtgItem"
        Me.dtgItem.Size = New System.Drawing.Size(750, 426)
        Me.dtgItem.TabIndex = 3
        Me.dtgItem.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(153, 12)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdImport
        '
        Me.cmdImport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdImport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdImport.ForeColor = System.Drawing.Color.Blue
        Me.cmdImport.Location = New System.Drawing.Point(33, 12)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(104, 23)
        Me.cmdImport.TabIndex = 4
        Me.cmdImport.Text = "Import Excel"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'cmdDisplay
        '
        Me.cmdDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDisplay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdDisplay.ForeColor = System.Drawing.Color.Blue
        Me.cmdDisplay.Location = New System.Drawing.Point(284, 12)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Size = New System.Drawing.Size(91, 23)
        Me.cmdDisplay.TabIndex = 6
        Me.cmdDisplay.Text = "ดูข้อมูลทั้งหมด"
        Me.cmdDisplay.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(392, 12)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(109, 23)
        Me.cmdExport.TabIndex = 7
        Me.cmdExport.Text = "Export Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'FrmGIAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 489)
        Me.Controls.Add(Me.dtgItem)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "FrmGIAccount"
        Me.TabText = "Update Account"
        Me.Text = "Update Account"
        Me.pnHeader.ResumeLayout(False)
        CType(Me.dtgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents cmdSave As PlanningS.NPIButton
    Friend WithEvents cmdImport As PlanningS.NPIButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dtgItem As System.Windows.Forms.DataGridView
    Friend WithEvents cmdExport As PlanningS.NPIButton
    Friend WithEvents cmdDisplay As PlanningS.NPIButton
End Class
