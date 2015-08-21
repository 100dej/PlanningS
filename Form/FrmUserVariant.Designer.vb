<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserVariant
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
        Me.dtgMasterVariant = New System.Windows.Forms.DataGridView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.dtgVariantDetails = New System.Windows.Forms.DataGridView
        Me.cmdCancel = New PlanningS.NPIButton
        Me.cmdSave = New PlanningS.NPIButton
        Me.cmdImport = New PlanningS.NPIButton
        Me.cmdNew = New PlanningS.NPIButton
        Me.cmdDelete = New PlanningS.NPIButton
        Me.cmdChange = New PlanningS.NPIButton
        Me.cmdCopy = New PlanningS.NPIButton
        Me.txtVname = New PlanningS.NPIText
        Me.NpiLabel1 = New PlanningS.NPILabel
        Me.lblVarUser = New PlanningS.NPILabel
        CType(Me.dtgMasterVariant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnHeader.SuspendLayout()
        CType(Me.dtgVariantDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgMasterVariant
        '
        Me.dtgMasterVariant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMasterVariant.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtgMasterVariant.Location = New System.Drawing.Point(0, 0)
        Me.dtgMasterVariant.Name = "dtgMasterVariant"
        Me.dtgMasterVariant.Size = New System.Drawing.Size(240, 498)
        Me.dtgMasterVariant.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Splitter1.Location = New System.Drawing.Point(240, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 498)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'pnHeader
        '
        Me.pnHeader.Controls.Add(Me.cmdCancel)
        Me.pnHeader.Controls.Add(Me.cmdSave)
        Me.pnHeader.Controls.Add(Me.cmdImport)
        Me.pnHeader.Controls.Add(Me.cmdNew)
        Me.pnHeader.Controls.Add(Me.cmdDelete)
        Me.pnHeader.Controls.Add(Me.cmdChange)
        Me.pnHeader.Controls.Add(Me.cmdCopy)
        Me.pnHeader.Controls.Add(Me.txtVname)
        Me.pnHeader.Controls.Add(Me.NpiLabel1)
        Me.pnHeader.Controls.Add(Me.lblVarUser)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(243, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1010, 100)
        Me.pnHeader.TabIndex = 2
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(243, 100)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(1010, 3)
        Me.Splitter2.TabIndex = 3
        Me.Splitter2.TabStop = False
        '
        'dtgVariantDetails
        '
        Me.dtgVariantDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVariantDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgVariantDetails.Location = New System.Drawing.Point(243, 103)
        Me.dtgVariantDetails.Name = "dtgVariantDetails"
        Me.dtgVariantDetails.Size = New System.Drawing.Size(1010, 395)
        Me.dtgVariantDetails.TabIndex = 4
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCancel.ForeColor = System.Drawing.Color.Blue
        Me.cmdCancel.Location = New System.Drawing.Point(830, 50)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "C&ancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(911, 50)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdImport
        '
        Me.cmdImport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdImport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdImport.ForeColor = System.Drawing.Color.Blue
        Me.cmdImport.Location = New System.Drawing.Point(502, 50)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(75, 23)
        Me.cmdImport.TabIndex = 2
        Me.cmdImport.Text = "&Import"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNew.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdNew.ForeColor = System.Drawing.Color.Blue
        Me.cmdNew.Location = New System.Drawing.Point(421, 50)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdNew.TabIndex = 1
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdDelete.ForeColor = System.Drawing.Color.Blue
        Me.cmdDelete.Location = New System.Drawing.Point(749, 50)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdChange
        '
        Me.cmdChange.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdChange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdChange.ForeColor = System.Drawing.Color.Blue
        Me.cmdChange.Location = New System.Drawing.Point(668, 50)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdChange.TabIndex = 4
        Me.cmdChange.Text = "C&hange"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdCopy
        '
        Me.cmdCopy.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCopy.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCopy.ForeColor = System.Drawing.Color.Blue
        Me.cmdCopy.Location = New System.Drawing.Point(587, 50)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopy.TabIndex = 3
        Me.cmdCopy.Text = "&Copy"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'txtVname
        '
        Me.txtVname.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtVname.Location = New System.Drawing.Point(104, 53)
        Me.txtVname.MaxLength = 30
        Me.txtVname.Name = "txtVname"
        Me.txtVname.Size = New System.Drawing.Size(299, 22)
        Me.txtVname.TabIndex = 0
        '
        'NpiLabel1
        '
        Me.NpiLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel1.Location = New System.Drawing.Point(16, 51)
        Me.NpiLabel1.Name = "NpiLabel1"
        Me.NpiLabel1.Size = New System.Drawing.Size(82, 29)
        Me.NpiLabel1.TabIndex = 1
        Me.NpiLabel1.Text = "Variant :"
        Me.NpiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVarUser
        '
        Me.lblVarUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblVarUser.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblVarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblVarUser.Location = New System.Drawing.Point(16, 9)
        Me.lblVarUser.Name = "lblVarUser"
        Me.lblVarUser.Size = New System.Drawing.Size(158, 29)
        Me.lblVarUser.TabIndex = 0
        Me.lblVarUser.Text = "User :"
        Me.lblVarUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmUserVariant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 498)
        Me.Controls.Add(Me.dtgVariantDetails)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.pnHeader)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.dtgMasterVariant)
        Me.Name = "FrmUserVariant"
        Me.TabText = "UserVariant"
        Me.Text = "UserVariant"
        CType(Me.dtgMasterVariant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnHeader.ResumeLayout(False)
        Me.pnHeader.PerformLayout()
        CType(Me.dtgVariantDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgMasterVariant As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents dtgVariantDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblVarUser As PlanningS.NPILabel
    Friend WithEvents txtVname As PlanningS.NPIText
    Friend WithEvents NpiLabel1 As PlanningS.NPILabel
    Friend WithEvents cmdNew As PlanningS.NPIButton
    Friend WithEvents cmdDelete As PlanningS.NPIButton
    Friend WithEvents cmdChange As PlanningS.NPIButton
    Friend WithEvents cmdCopy As PlanningS.NPIButton
    Friend WithEvents cmdSave As PlanningS.NPIButton
    Friend WithEvents cmdImport As PlanningS.NPIButton
    Friend WithEvents cmdCancel As PlanningS.NPIButton
End Class
