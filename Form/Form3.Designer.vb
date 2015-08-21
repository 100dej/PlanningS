<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.cboShcema = New System.Windows.Forms.ComboBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgMaster = New System.Windows.Forms.DataGridView
        Me.NpiButton1 = New PlanningS.NPIButton
        Me.cboName = New System.Windows.Forms.ComboBox
        Me.pnHeader.SuspendLayout()
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.Controls.Add(Me.cboName)
        Me.pnHeader.Controls.Add(Me.cboShcema)
        Me.pnHeader.Controls.Add(Me.NpiButton1)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1130, 100)
        Me.pnHeader.TabIndex = 0
        '
        'cboShcema
        '
        Me.cboShcema.FormattingEnabled = True
        Me.cboShcema.Location = New System.Drawing.Point(199, 32)
        Me.cboShcema.Name = "cboShcema"
        Me.cboShcema.Size = New System.Drawing.Size(199, 21)
        Me.cboShcema.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 100)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1130, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dtgMaster
        '
        Me.dtgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMaster.Location = New System.Drawing.Point(0, 103)
        Me.dtgMaster.Name = "dtgMaster"
        Me.dtgMaster.Size = New System.Drawing.Size(1130, 389)
        Me.dtgMaster.TabIndex = 2
        '
        'NpiButton1
        '
        Me.NpiButton1.BackColor = System.Drawing.SystemColors.Control
        Me.NpiButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiButton1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiButton1.ForeColor = System.Drawing.Color.Blue
        Me.NpiButton1.Location = New System.Drawing.Point(779, 30)
        Me.NpiButton1.Name = "NpiButton1"
        Me.NpiButton1.Size = New System.Drawing.Size(75, 23)
        Me.NpiButton1.TabIndex = 0
        Me.NpiButton1.Text = "NpiButton1"
        Me.NpiButton1.UseVisualStyleBackColor = True
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(440, 32)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(207, 21)
        Me.cboName.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 492)
        Me.Controls.Add(Me.dtgMaster)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "Form3"
        Me.TabText = "Form3"
        Me.Text = "Form3"
        Me.pnHeader.ResumeLayout(False)
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dtgMaster As System.Windows.Forms.DataGridView
    Friend WithEvents NpiButton1 As PlanningS.NPIButton
    Friend WithEvents cboShcema As System.Windows.Forms.ComboBox
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
End Class
