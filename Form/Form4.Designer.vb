<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgMaster = New System.Windows.Forms.DataGridView()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.picAsset = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmdSavepic = New PlanningS.NPIButton()
        Me.lblAssetNo = New PlanningS.NPILabel()
        Me.cmdPicAdd = New PlanningS.NPIButton()
        Me.NpiLabel4 = New PlanningS.NPILabel()
        Me.txtRespcctr = New PlanningS.NPIText()
        Me.NpiLabel8 = New PlanningS.NPILabel()
        Me.txtAssetname = New PlanningS.NPIText()
        Me.cmdExecute = New PlanningS.NPIButton()
        Me.NpiLabel3 = New PlanningS.NPILabel()
        Me.txtSubno = New PlanningS.NPIText()
        Me.NpiLabel2 = New PlanningS.NPILabel()
        Me.txtAssetno = New PlanningS.NPIText()
        Me.NpiLabel1 = New PlanningS.NPILabel()
        Me.txtCompcode = New PlanningS.NPIText()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.NpiLabel4)
        Me.Panel1.Controls.Add(Me.txtRespcctr)
        Me.Panel1.Controls.Add(Me.NpiLabel8)
        Me.Panel1.Controls.Add(Me.txtAssetname)
        Me.Panel1.Controls.Add(Me.cmdExecute)
        Me.Panel1.Controls.Add(Me.NpiLabel3)
        Me.Panel1.Controls.Add(Me.txtSubno)
        Me.Panel1.Controls.Add(Me.NpiLabel2)
        Me.Panel1.Controls.Add(Me.txtAssetno)
        Me.Panel1.Controls.Add(Me.NpiLabel1)
        Me.Panel1.Controls.Add(Me.txtCompcode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1270, 123)
        Me.Panel1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 123)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1270, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgMaster)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 392)
        Me.Panel2.TabIndex = 2
        '
        'dtgMaster
        '
        Me.dtgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMaster.Location = New System.Drawing.Point(0, 0)
        Me.dtgMaster.Name = "dtgMaster"
        Me.dtgMaster.Size = New System.Drawing.Size(864, 392)
        Me.dtgMaster.TabIndex = 3
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(864, 126)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 392)
        Me.Splitter2.TabIndex = 3
        Me.Splitter2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(867, 126)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 392)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.picAsset)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 97)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(403, 295)
        Me.Panel4.TabIndex = 2
        '
        'picAsset
        '
        Me.picAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picAsset.Location = New System.Drawing.Point(0, 0)
        Me.picAsset.Name = "picAsset"
        Me.picAsset.Size = New System.Drawing.Size(403, 295)
        Me.picAsset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsset.TabIndex = 0
        Me.picAsset.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cmdSavepic)
        Me.Panel5.Controls.Add(Me.lblAssetNo)
        Me.Panel5.Controls.Add(Me.cmdPicAdd)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(403, 97)
        Me.Panel5.TabIndex = 1
        '
        'cmdSavepic
        '
        Me.cmdSavepic.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSavepic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSavepic.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSavepic.ForeColor = System.Drawing.Color.Blue
        Me.cmdSavepic.Location = New System.Drawing.Point(110, 71)
        Me.cmdSavepic.Name = "cmdSavepic"
        Me.cmdSavepic.Size = New System.Drawing.Size(75, 23)
        Me.cmdSavepic.TabIndex = 22
        Me.cmdSavepic.Text = "E&xport"
        Me.cmdSavepic.UseVisualStyleBackColor = False
        '
        'lblAssetNo
        '
        Me.lblAssetNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAssetNo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAssetNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAssetNo.Location = New System.Drawing.Point(7, 7)
        Me.lblAssetNo.Name = "lblAssetNo"
        Me.lblAssetNo.Size = New System.Drawing.Size(295, 40)
        Me.lblAssetNo.TabIndex = 21
        Me.lblAssetNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdPicAdd
        '
        Me.cmdPicAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPicAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPicAdd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdPicAdd.ForeColor = System.Drawing.Color.Blue
        Me.cmdPicAdd.Location = New System.Drawing.Point(17, 71)
        Me.cmdPicAdd.Name = "cmdPicAdd"
        Me.cmdPicAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdPicAdd.TabIndex = 0
        Me.cmdPicAdd.Text = "&Add"
        Me.cmdPicAdd.UseVisualStyleBackColor = True
        '
        'NpiLabel4
        '
        Me.NpiLabel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel4.Location = New System.Drawing.Point(12, 43)
        Me.NpiLabel4.Name = "NpiLabel4"
        Me.NpiLabel4.Size = New System.Drawing.Size(141, 22)
        Me.NpiLabel4.TabIndex = 14
        Me.NpiLabel4.Text = "Response costcenter :"
        Me.NpiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRespcctr
        '
        Me.txtRespcctr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRespcctr.Location = New System.Drawing.Point(149, 43)
        Me.txtRespcctr.Name = "txtRespcctr"
        Me.txtRespcctr.Size = New System.Drawing.Size(100, 22)
        Me.txtRespcctr.TabIndex = 4
        '
        'NpiLabel8
        '
        Me.NpiLabel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel8.Location = New System.Drawing.Point(587, 15)
        Me.NpiLabel8.Name = "NpiLabel8"
        Me.NpiLabel8.Size = New System.Drawing.Size(83, 22)
        Me.NpiLabel8.TabIndex = 12
        Me.NpiLabel8.Text = "Asset name :"
        Me.NpiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAssetname
        '
        Me.txtAssetname.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtAssetname.Location = New System.Drawing.Point(676, 16)
        Me.txtAssetname.Name = "txtAssetname"
        Me.txtAssetname.Size = New System.Drawing.Size(334, 22)
        Me.txtAssetname.TabIndex = 3
        '
        'cmdExecute
        '
        Me.cmdExecute.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExecute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExecute.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExecute.ForeColor = System.Drawing.Color.Blue
        Me.cmdExecute.Location = New System.Drawing.Point(191, 83)
        Me.cmdExecute.Name = "cmdExecute"
        Me.cmdExecute.Size = New System.Drawing.Size(75, 23)
        Me.cmdExecute.TabIndex = 5
        Me.cmdExecute.Text = "&Execute"
        Me.cmdExecute.UseVisualStyleBackColor = True
        '
        'NpiLabel3
        '
        Me.NpiLabel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NpiLabel3.Location = New System.Drawing.Point(392, 13)
        Me.NpiLabel3.Name = "NpiLabel3"
        Me.NpiLabel3.Size = New System.Drawing.Size(83, 22)
        Me.NpiLabel3.TabIndex = 5
        Me.NpiLabel3.Text = "Sub number :"
        Me.NpiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubno
        '
        Me.txtSubno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSubno.Location = New System.Drawing.Point(481, 14)
        Me.txtSubno.Name = "txtSubno"
        Me.txtSubno.Size = New System.Drawing.Size(100, 22)
        Me.txtSubno.TabIndex = 2
        '
        'NpiLabel2
        '
        Me.NpiLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NpiLabel2.Location = New System.Drawing.Point(188, 13)
        Me.NpiLabel2.Name = "NpiLabel2"
        Me.NpiLabel2.Size = New System.Drawing.Size(92, 22)
        Me.NpiLabel2.TabIndex = 3
        Me.NpiLabel2.Text = "Asset number :"
        Me.NpiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAssetno
        '
        Me.txtAssetno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtAssetno.Location = New System.Drawing.Point(286, 13)
        Me.txtAssetno.Name = "txtAssetno"
        Me.txtAssetno.Size = New System.Drawing.Size(100, 22)
        Me.txtAssetno.TabIndex = 1
        '
        'NpiLabel1
        '
        Me.NpiLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NpiLabel1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NpiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NpiLabel1.Location = New System.Drawing.Point(10, 12)
        Me.NpiLabel1.Name = "NpiLabel1"
        Me.NpiLabel1.Size = New System.Drawing.Size(72, 22)
        Me.NpiLabel1.TabIndex = 1
        Me.NpiLabel1.Text = "Company :"
        Me.NpiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCompcode
        '
        Me.txtCompcode.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCompcode.Location = New System.Drawing.Point(82, 12)
        Me.txtCompcode.Name = "txtCompcode"
        Me.txtCompcode.Size = New System.Drawing.Size(100, 22)
        Me.txtCompcode.TabIndex = 0
        Me.txtCompcode.Text = "0870"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 518)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.TabText = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.picAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents NpiLabel3 As PlanningS.NPILabel
    Friend WithEvents txtSubno As PlanningS.NPIText
    Friend WithEvents NpiLabel2 As PlanningS.NPILabel
    Friend WithEvents txtAssetno As PlanningS.NPIText
    Friend WithEvents NpiLabel1 As PlanningS.NPILabel
    Friend WithEvents txtCompcode As PlanningS.NPIText
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdExecute As PlanningS.NPIButton
    Friend WithEvents NpiLabel8 As PlanningS.NPILabel
    Friend WithEvents txtAssetname As PlanningS.NPIText
    Friend WithEvents NpiLabel4 As PlanningS.NPILabel
    Friend WithEvents txtRespcctr As PlanningS.NPIText
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents picAsset As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdPicAdd As PlanningS.NPIButton
    Friend WithEvents dtgMaster As System.Windows.Forms.DataGridView
    Friend WithEvents lblAssetNo As PlanningS.NPILabel
    Friend WithEvents cmdSavepic As PlanningS.NPIButton
End Class
