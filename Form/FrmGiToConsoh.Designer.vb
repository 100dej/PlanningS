<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGiToConsoh
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
        Me.dtgItem = New System.Windows.Forms.DataGridView
        Me.NpiLabel2 = New PlanningS.NPILabel
        Me.txtWhCode = New PlanningS.NPIText
        Me.lblWarning = New PlanningS.NPILabel
        Me.NpiLabel1 = New PlanningS.NPILabel
        Me.txtOrder = New PlanningS.NPIText
        Me.cmdExec = New PlanningS.NPIButton
        Me.cmdSave = New PlanningS.NPIButton
        Me.Panel1.SuspendLayout()
        CType(Me.dtgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.NpiLabel2)
        Me.Panel1.Controls.Add(Me.txtWhCode)
        Me.Panel1.Controls.Add(Me.lblWarning)
        Me.Panel1.Controls.Add(Me.NpiLabel1)
        Me.Panel1.Controls.Add(Me.txtOrder)
        Me.Panel1.Controls.Add(Me.cmdExec)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 77)
        Me.Panel1.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 77)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1094, 3)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'dtgItem
        '
        Me.dtgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgItem.Location = New System.Drawing.Point(0, 80)
        Me.dtgItem.Name = "dtgItem"
        Me.dtgItem.Size = New System.Drawing.Size(1094, 353)
        Me.dtgItem.TabIndex = 3
        '
        'NpiLabel2
        '
        Me.NpiLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NpiLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel2.Location = New System.Drawing.Point(29, 9)
        Me.NpiLabel2.Name = "NpiLabel2"
        Me.NpiLabel2.Size = New System.Drawing.Size(100, 23)
        Me.NpiLabel2.TabIndex = 6
        Me.NpiLabel2.Text = "WH Code : "
        Me.NpiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWhCode
        '
        Me.txtWhCode.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtWhCode.Location = New System.Drawing.Point(135, 9)
        Me.txtWhCode.MaxLength = 3
        Me.txtWhCode.Name = "txtWhCode"
        Me.txtWhCode.Size = New System.Drawing.Size(62, 22)
        Me.txtWhCode.TabIndex = 0
        '
        'lblWarning
        '
        Me.lblWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWarning.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWarning.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarning.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblWarning.Location = New System.Drawing.Point(531, 41)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(495, 26)
        Me.lblWarning.TabIndex = 4
        Me.lblWarning.Text = "NpiLabel2"
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NpiLabel1
        '
        Me.NpiLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NpiLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel1.Location = New System.Drawing.Point(29, 45)
        Me.NpiLabel1.Name = "NpiLabel1"
        Me.NpiLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NpiLabel1.TabIndex = 3
        Me.NpiLabel1.Text = "Order No : "
        Me.NpiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrder
        '
        Me.txtOrder.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtOrder.Location = New System.Drawing.Point(135, 45)
        Me.txtOrder.MaxLength = 10
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(134, 22)
        Me.txtOrder.TabIndex = 1
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(288, 44)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 2
        Me.cmdExec.Text = "Execute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(380, 44)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'FrmGiToConsoh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 433)
        Me.Controls.Add(Me.dtgItem)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmGiToConsoh"
        Me.TabText = "เอาเข้า Consoh"
        Me.Text = "เอาเข้า Consoh"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdSave As PlanningS.NPIButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtOrder As PlanningS.NPIText
    Friend WithEvents cmdExec As PlanningS.NPIButton
    Friend WithEvents NpiLabel1 As PlanningS.NPILabel
    Friend WithEvents dtgItem As System.Windows.Forms.DataGridView
    Friend WithEvents lblWarning As PlanningS.NPILabel
    Friend WithEvents NpiLabel2 As PlanningS.NPILabel
    Friend WithEvents txtWhCode As PlanningS.NPIText
End Class
