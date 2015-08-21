<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterPlanning
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
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblPFNext = New System.Windows.Forms.Label
        Me.lblFittingNext = New System.Windows.Forms.Label
        Me.lblPF = New System.Windows.Forms.Label
        Me.lblFitting = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.rb24 = New System.Windows.Forms.RadioButton
        Me.rb28 = New System.Windows.Forms.RadioButton
        Me.rb27 = New System.Windows.Forms.RadioButton
        Me.rb25 = New System.Windows.Forms.RadioButton
        Me.rb23 = New System.Windows.Forms.RadioButton
        Me.rb26 = New System.Windows.Forms.RadioButton
        Me.rb22 = New System.Windows.Forms.RadioButton
        Me.rb21 = New System.Windows.Forms.RadioButton
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.pnCmd = New System.Windows.Forms.Panel
        Me.cmdExport = New PlanningS.NPIButton
        Me.cmdExec = New PlanningS.NPIButton
        Me.pnScase = New System.Windows.Forms.Panel
        Me.pnScase0 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.rb72 = New System.Windows.Forms.RadioButton
        Me.rb71 = New System.Windows.Forms.RadioButton
        Me.pnScase1 = New System.Windows.Forms.Panel
        Me.cboMtype = New System.Windows.Forms.ComboBox
        Me.cboProduct = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEng = New PlanningS.NPIText
        Me.txtMat = New PlanningS.NPIText
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnScase2 = New System.Windows.Forms.Panel
        Me.cmdSetVariant = New PlanningS.NPIButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboVname = New System.Windows.Forms.ComboBox
        Me.cboUname = New System.Windows.Forms.ComboBox
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblFilter = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.dtGridMatMaster = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyGrid = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cbFunctionCopyGrid = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnHeader.SuspendLayout()
        Me.pnCmd.SuspendLayout()
        Me.pnScase.SuspendLayout()
        Me.pnScase0.SuspendLayout()
        Me.pnScase1.SuspendLayout()
        Me.pnScase2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dtGridMatMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.pnHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1269, 240)
        Me.Panel1.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.rb24)
        Me.Panel4.Controls.Add(Me.rb28)
        Me.Panel4.Controls.Add(Me.rb27)
        Me.Panel4.Controls.Add(Me.rb25)
        Me.Panel4.Controls.Add(Me.rb23)
        Me.Panel4.Controls.Add(Me.rb26)
        Me.Panel4.Controls.Add(Me.rb22)
        Me.Panel4.Controls.Add(Me.rb21)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(362, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(907, 240)
        Me.Panel4.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblPFNext)
        Me.Panel2.Controls.Add(Me.lblFittingNext)
        Me.Panel2.Controls.Add(Me.lblPF)
        Me.Panel2.Controls.Add(Me.lblFitting)
        Me.Panel2.Location = New System.Drawing.Point(338, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 131)
        Me.Panel2.TabIndex = 21
        '
        'lblPFNext
        '
        Me.lblPFNext.AutoSize = True
        Me.lblPFNext.ForeColor = System.Drawing.Color.Gray
        Me.lblPFNext.Location = New System.Drawing.Point(50, 101)
        Me.lblPFNext.Name = "lblPFNext"
        Me.lblPFNext.Size = New System.Drawing.Size(52, 13)
        Me.lblPFNext.TabIndex = 24
        Me.lblPFNext.Text = "lblPFNext"
        '
        'lblFittingNext
        '
        Me.lblFittingNext.AutoSize = True
        Me.lblFittingNext.ForeColor = System.Drawing.Color.Gray
        Me.lblFittingNext.Location = New System.Drawing.Point(50, 48)
        Me.lblFittingNext.Name = "lblFittingNext"
        Me.lblFittingNext.Size = New System.Drawing.Size(67, 13)
        Me.lblFittingNext.TabIndex = 23
        Me.lblFittingNext.Text = "lblFittingNext"
        '
        'lblPF
        '
        Me.lblPF.AutoSize = True
        Me.lblPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPF.ForeColor = System.Drawing.Color.Blue
        Me.lblPF.Location = New System.Drawing.Point(3, 71)
        Me.lblPF.Name = "lblPF"
        Me.lblPF.Size = New System.Drawing.Size(53, 24)
        Me.lblPF.TabIndex = 22
        Me.lblPF.Text = "lblPF"
        '
        'lblFitting
        '
        Me.lblFitting.AutoSize = True
        Me.lblFitting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFitting.ForeColor = System.Drawing.Color.Blue
        Me.lblFitting.Location = New System.Drawing.Point(3, 13)
        Me.lblFitting.Name = "lblFitting"
        Me.lblFitting.Size = New System.Drawing.Size(79, 24)
        Me.lblFitting.TabIndex = 21
        Me.lblFitting.Text = "lblFitting"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(869, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 27)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "3"
        '
        'rb24
        '
        Me.rb24.AutoSize = True
        Me.rb24.Location = New System.Drawing.Point(229, 49)
        Me.rb24.Name = "rb24"
        Me.rb24.Size = New System.Drawing.Size(88, 17)
        Me.rb24.TabIndex = 3
        Me.rb24.TabStop = True
        Me.rb24.Tag = "4"
        Me.rb24.Text = "By Com Plant"
        Me.rb24.UseVisualStyleBackColor = True
        '
        'rb28
        '
        Me.rb28.AutoSize = True
        Me.rb28.Location = New System.Drawing.Point(16, 104)
        Me.rb28.Name = "rb28"
        Me.rb28.Size = New System.Drawing.Size(98, 17)
        Me.rb28.TabIndex = 7
        Me.rb28.TabStop = True
        Me.rb28.Tag = "8"
        Me.rb28.Text = "Group Location"
        Me.rb28.UseVisualStyleBackColor = True
        '
        'rb27
        '
        Me.rb27.AutoSize = True
        Me.rb27.Location = New System.Drawing.Point(229, 76)
        Me.rb27.Name = "rb27"
        Me.rb27.Size = New System.Drawing.Size(65, 17)
        Me.rb27.TabIndex = 6
        Me.rb27.TabStop = True
        Me.rb27.Tag = "7"
        Me.rb27.Text = "By Zone"
        Me.rb27.UseVisualStyleBackColor = True
        '
        'rb25
        '
        Me.rb25.AutoSize = True
        Me.rb25.Location = New System.Drawing.Point(16, 76)
        Me.rb25.Name = "rb25"
        Me.rb25.Size = New System.Drawing.Size(61, 17)
        Me.rb25.TabIndex = 4
        Me.rb25.TabStop = True
        Me.rb25.Tag = "5"
        Me.rb25.Text = "By Com"
        Me.rb25.UseVisualStyleBackColor = True
        '
        'rb23
        '
        Me.rb23.AutoSize = True
        Me.rb23.Location = New System.Drawing.Point(124, 49)
        Me.rb23.Name = "rb23"
        Me.rb23.Size = New System.Drawing.Size(89, 17)
        Me.rb23.TabIndex = 2
        Me.rb23.TabStop = True
        Me.rb23.Tag = "3"
        Me.rb23.Text = "By Com Zone"
        Me.rb23.UseVisualStyleBackColor = True
        '
        'rb26
        '
        Me.rb26.AutoSize = True
        Me.rb26.Location = New System.Drawing.Point(124, 76)
        Me.rb26.Name = "rb26"
        Me.rb26.Size = New System.Drawing.Size(81, 17)
        Me.rb26.TabIndex = 5
        Me.rb26.TabStop = True
        Me.rb26.Tag = "6"
        Me.rb26.Text = "By Location"
        Me.rb26.UseVisualStyleBackColor = True
        '
        'rb22
        '
        Me.rb22.AutoSize = True
        Me.rb22.Location = New System.Drawing.Point(16, 49)
        Me.rb22.Name = "rb22"
        Me.rb22.Size = New System.Drawing.Size(92, 17)
        Me.rb22.TabIndex = 1
        Me.rb22.TabStop = True
        Me.rb22.Tag = "2"
        Me.rb22.Text = "By Plant Zone"
        Me.rb22.UseVisualStyleBackColor = True
        '
        'rb21
        '
        Me.rb21.AutoSize = True
        Me.rb21.Location = New System.Drawing.Point(16, 21)
        Me.rb21.Name = "rb21"
        Me.rb21.Size = New System.Drawing.Size(116, 17)
        Me.rb21.TabIndex = 0
        Me.rb21.TabStop = True
        Me.rb21.Tag = "1"
        Me.rb21.Text = "By Com Plant Zone"
        Me.rb21.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(359, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 240)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnHeader.Controls.Add(Me.pnCmd)
        Me.pnHeader.Controls.Add(Me.pnScase)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(359, 240)
        Me.pnHeader.TabIndex = 3
        '
        'pnCmd
        '
        Me.pnCmd.Controls.Add(Me.cbFunctionCopyGrid)
        Me.pnCmd.Controls.Add(Me.cmdExport)
        Me.pnCmd.Controls.Add(Me.cmdExec)
        Me.pnCmd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCmd.Location = New System.Drawing.Point(0, 180)
        Me.pnCmd.Name = "pnCmd"
        Me.pnCmd.Size = New System.Drawing.Size(359, 60)
        Me.pnCmd.TabIndex = 2
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(254, 9)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 23)
        Me.cmdExport.TabIndex = 2
        Me.cmdExport.Text = "E&xport Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(164, 9)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 1
        Me.cmdExec.Text = "&Excute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'pnScase
        '
        Me.pnScase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnScase.Controls.Add(Me.pnScase0)
        Me.pnScase.Controls.Add(Me.pnScase1)
        Me.pnScase.Controls.Add(Me.pnScase2)
        Me.pnScase.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnScase.Location = New System.Drawing.Point(0, 0)
        Me.pnScase.Name = "pnScase"
        Me.pnScase.Size = New System.Drawing.Size(359, 180)
        Me.pnScase.TabIndex = 0
        '
        'pnScase0
        '
        Me.pnScase0.Controls.Add(Me.Label15)
        Me.pnScase0.Controls.Add(Me.rb72)
        Me.pnScase0.Controls.Add(Me.rb71)
        Me.pnScase0.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnScase0.Location = New System.Drawing.Point(0, 0)
        Me.pnScase0.Name = "pnScase0"
        Me.pnScase0.Size = New System.Drawing.Size(359, 44)
        Me.pnScase0.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(320, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 27)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "7"
        '
        'rb72
        '
        Me.rb72.AutoSize = True
        Me.rb72.Location = New System.Drawing.Point(131, 10)
        Me.rb72.Name = "rb72"
        Me.rb72.Size = New System.Drawing.Size(105, 17)
        Me.rb72.TabIndex = 1
        Me.rb72.TabStop = True
        Me.rb72.Tag = "2"
        Me.rb72.Text = "Variant Condition"
        Me.rb72.UseVisualStyleBackColor = True
        '
        'rb71
        '
        Me.rb71.AutoSize = True
        Me.rb71.Location = New System.Drawing.Point(24, 10)
        Me.rb71.Name = "rb71"
        Me.rb71.Size = New System.Drawing.Size(101, 17)
        Me.rb71.TabIndex = 0
        Me.rb71.TabStop = True
        Me.rb71.Tag = "1"
        Me.rb71.Text = "Single Condition"
        Me.rb71.UseVisualStyleBackColor = True
        '
        'pnScase1
        '
        Me.pnScase1.Controls.Add(Me.cboMtype)
        Me.pnScase1.Controls.Add(Me.cboProduct)
        Me.pnScase1.Controls.Add(Me.Label19)
        Me.pnScase1.Controls.Add(Me.Label18)
        Me.pnScase1.Controls.Add(Me.Label2)
        Me.pnScase1.Controls.Add(Me.txtEng)
        Me.pnScase1.Controls.Add(Me.txtMat)
        Me.pnScase1.Controls.Add(Me.Label1)
        Me.pnScase1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnScase1.Location = New System.Drawing.Point(0, 0)
        Me.pnScase1.Name = "pnScase1"
        Me.pnScase1.Size = New System.Drawing.Size(359, 180)
        Me.pnScase1.TabIndex = 0
        '
        'cboMtype
        '
        Me.cboMtype.FormattingEnabled = True
        Me.cboMtype.Location = New System.Drawing.Point(161, 145)
        Me.cboMtype.Name = "cboMtype"
        Me.cboMtype.Size = New System.Drawing.Size(178, 21)
        Me.cboMtype.TabIndex = 3
        '
        'cboProduct
        '
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(161, 117)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(178, 21)
        Me.cboProduct.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(91, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 20)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Mtype :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(79, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Product :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name ENGLISH :"
        '
        'txtEng
        '
        Me.txtEng.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtEng.Location = New System.Drawing.Point(161, 88)
        Me.txtEng.MaxLength = 40
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Size = New System.Drawing.Size(178, 22)
        Me.txtEng.TabIndex = 1
        '
        'txtMat
        '
        Me.txtMat.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMat.Location = New System.Drawing.Point(161, 59)
        Me.txtMat.MaxLength = 18
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(149, 22)
        Me.txtMat.TabIndex = 0
        Me.txtMat.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Material number :"
        '
        'pnScase2
        '
        Me.pnScase2.Controls.Add(Me.cmdSetVariant)
        Me.pnScase2.Controls.Add(Me.Label17)
        Me.pnScase2.Controls.Add(Me.Label16)
        Me.pnScase2.Controls.Add(Me.cboVname)
        Me.pnScase2.Controls.Add(Me.cboUname)
        Me.pnScase2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnScase2.Location = New System.Drawing.Point(0, 0)
        Me.pnScase2.Name = "pnScase2"
        Me.pnScase2.Size = New System.Drawing.Size(359, 180)
        Me.pnScase2.TabIndex = 23
        '
        'cmdSetVariant
        '
        Me.cmdSetVariant.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetVariant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSetVariant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSetVariant.ForeColor = System.Drawing.Color.Blue
        Me.cmdSetVariant.Location = New System.Drawing.Point(164, 135)
        Me.cmdSetVariant.Name = "cmdSetVariant"
        Me.cmdSetVariant.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetVariant.TabIndex = 4
        Me.cmdSetVariant.Text = "&Setting"
        Me.cmdSetVariant.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Variant :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(30, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "User :"
        '
        'cboVname
        '
        Me.cboVname.FormattingEnabled = True
        Me.cboVname.Location = New System.Drawing.Point(88, 94)
        Me.cboVname.Name = "cboVname"
        Me.cboVname.Size = New System.Drawing.Size(251, 21)
        Me.cboVname.TabIndex = 1
        '
        'cboUname
        '
        Me.cboUname.FormattingEnabled = True
        Me.cboUname.Location = New System.Drawing.Point(87, 64)
        Me.cboUname.Name = "cboUname"
        Me.cboUname.Size = New System.Drawing.Size(121, 21)
        Me.cboUname.TabIndex = 0
        '
        'Splitter3
        '
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter3.Location = New System.Drawing.Point(0, 240)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(1269, 3)
        Me.Splitter3.TabIndex = 8
        Me.Splitter3.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFilter, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 455)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1269, 22)
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
        Me.dtGridMatMaster.Location = New System.Drawing.Point(48, 17)
        Me.dtGridMatMaster.Name = "dtGridMatMaster"
        Me.dtGridMatMaster.Size = New System.Drawing.Size(356, 259)
        Me.dtGridMatMaster.TabIndex = 17
        Me.dtGridMatMaster.TabStop = False
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.dtGridMatMaster)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 243)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1269, 212)
        Me.Panel3.TabIndex = 17
        '
        'cbFunctionCopyGrid
        '
        Me.cbFunctionCopyGrid.AutoSize = True
        Me.cbFunctionCopyGrid.Location = New System.Drawing.Point(83, 12)
        Me.cbFunctionCopyGrid.Name = "cbFunctionCopyGrid"
        Me.cbFunctionCopyGrid.Size = New System.Drawing.Size(61, 17)
        Me.cbFunctionCopyGrid.TabIndex = 0
        Me.cbFunctionCopyGrid.Text = "Header"
        Me.cbFunctionCopyGrid.UseVisualStyleBackColor = True
        '
        'FrmMasterPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 477)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Splitter3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMasterPlanning"
        Me.TabText = "ดูข้อมูลสำหรับวางแผน"
        Me.Text = "ดูข้อมูลสำหรับวางแผน"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnHeader.ResumeLayout(False)
        Me.pnCmd.ResumeLayout(False)
        Me.pnCmd.PerformLayout()
        Me.pnScase.ResumeLayout(False)
        Me.pnScase0.ResumeLayout(False)
        Me.pnScase0.PerformLayout()
        Me.pnScase1.ResumeLayout(False)
        Me.pnScase1.PerformLayout()
        Me.pnScase2.ResumeLayout(False)
        Me.pnScase2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dtGridMatMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblFilter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dtGridMatMaster As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblPFNext As System.Windows.Forms.Label
    Friend WithEvents lblFittingNext As System.Windows.Forms.Label
    Friend WithEvents lblPF As System.Windows.Forms.Label
    Friend WithEvents lblFitting As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rb24 As System.Windows.Forms.RadioButton
    Friend WithEvents rb28 As System.Windows.Forms.RadioButton
    Friend WithEvents rb27 As System.Windows.Forms.RadioButton
    Friend WithEvents rb25 As System.Windows.Forms.RadioButton
    Friend WithEvents rb23 As System.Windows.Forms.RadioButton
    Friend WithEvents rb26 As System.Windows.Forms.RadioButton
    Friend WithEvents rb22 As System.Windows.Forms.RadioButton
    Friend WithEvents rb21 As System.Windows.Forms.RadioButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents pnCmd As System.Windows.Forms.Panel
    Friend WithEvents cmdExport As PlanningS.NPIButton
    Friend WithEvents cmdExec As PlanningS.NPIButton
    Friend WithEvents pnScase As System.Windows.Forms.Panel
    Friend WithEvents pnScase0 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents rb72 As System.Windows.Forms.RadioButton
    Friend WithEvents rb71 As System.Windows.Forms.RadioButton
    Friend WithEvents pnScase1 As System.Windows.Forms.Panel
    Friend WithEvents cboMtype As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEng As PlanningS.NPIText
    Friend WithEvents txtMat As PlanningS.NPIText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnScase2 As System.Windows.Forms.Panel
    Friend WithEvents cmdSetVariant As PlanningS.NPIButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboVname As System.Windows.Forms.ComboBox
    Friend WithEvents cboUname As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyGrid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbFunctionCopyGrid As System.Windows.Forms.CheckBox
End Class
