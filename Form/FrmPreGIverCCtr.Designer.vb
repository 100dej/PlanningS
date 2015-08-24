<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpregivercctr
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
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.cmdSave = New PlanningS.NPIButton
        Me.cmdImport = New PlanningS.NPIButton
        Me.NpiLabel2 = New PlanningS.NPILabel
        Me.NpiLabel1 = New PlanningS.NPILabel
        Me.txtVersion = New PlanningS.NPIText
        Me.txtOrder = New PlanningS.NPIText
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgItem = New System.Windows.Forms.DataGridView
        Me.pnHeader.SuspendLayout()
        CType(Me.dtgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnHeader.Controls.Add(Me.cmdSave)
        Me.pnHeader.Controls.Add(Me.cmdImport)
        Me.pnHeader.Controls.Add(Me.NpiLabel2)
        Me.pnHeader.Controls.Add(Me.NpiLabel1)
        Me.pnHeader.Controls.Add(Me.txtVersion)
        Me.pnHeader.Controls.Add(Me.txtOrder)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(888, 60)
        Me.pnHeader.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(524, 18)
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
        Me.cmdImport.Location = New System.Drawing.Point(404, 18)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(104, 23)
        Me.cmdImport.TabIndex = 4
        Me.cmdImport.Text = "Import Excel"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'NpiLabel2
        '
        Me.NpiLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NpiLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel2.Location = New System.Drawing.Point(244, 18)
        Me.NpiLabel2.Name = "NpiLabel2"
        Me.NpiLabel2.Size = New System.Drawing.Size(89, 23)
        Me.NpiLabel2.TabIndex = 3
        Me.NpiLabel2.Text = "Version :"
        Me.NpiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NpiLabel1
        '
        Me.NpiLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NpiLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel1.Location = New System.Drawing.Point(28, 18)
        Me.NpiLabel1.Name = "NpiLabel1"
        Me.NpiLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NpiLabel1.TabIndex = 2
        Me.NpiLabel1.Text = "Order No: "
        Me.NpiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVersion
        '
        Me.txtVersion.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtVersion.Location = New System.Drawing.Point(336, 18)
        Me.txtVersion.MaxLength = 2
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Showcomma = False
        Me.txtVersion.Size = New System.Drawing.Size(33, 22)
        Me.txtVersion.TabIndex = 1
        '
        'txtOrder
        '
        Me.txtOrder.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtOrder.Location = New System.Drawing.Point(134, 18)
        Me.txtOrder.MaxLength = 7
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(90, 22)
        Me.txtOrder.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 60)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(888, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dtgItem
        '
        Me.dtgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgItem.Location = New System.Drawing.Point(0, 63)
        Me.dtgItem.Name = "dtgItem"
        Me.dtgItem.Size = New System.Drawing.Size(888, 416)
        Me.dtgItem.TabIndex = 2
        Me.dtgItem.TabStop = False
        '
        'FrmPreGI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 479)
        Me.Controls.Add(Me.dtgItem)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "FrmPreGI"
        Me.TabText = "เตรียมใบเบิก"
        Me.Text = "เตรียมใบเบิก"
        Me.pnHeader.ResumeLayout(False)
        Me.pnHeader.PerformLayout()
        CType(Me.dtgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents NpiLabel2 As PlanningS.NPILabel
    Friend WithEvents NpiLabel1 As PlanningS.NPILabel
    Friend WithEvents txtVersion As PlanningS.NPIText
    Friend WithEvents txtOrder As PlanningS.NPIText
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents cmdSave As PlanningS.NPIButton
    Friend WithEvents cmdImport As PlanningS.NPIButton
    Friend WithEvents dtgItem As System.Windows.Forms.DataGridView
End Class
