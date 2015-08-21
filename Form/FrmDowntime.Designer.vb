<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDowntime
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
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.pnCmd = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboDTgroup = New System.Windows.Forms.ComboBox
        Me.cboMCno = New System.Windows.Forms.ComboBox
        Me.cboProduct = New System.Windows.Forms.ComboBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblFilter = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.pnGrid = New System.Windows.Forms.Panel
        Me.lblSQL = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopylblSQL = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyGrid = New System.Windows.Forms.ToolStripMenuItem
        Me.dtgMaster = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnDataReport = New System.Windows.Forms.Panel
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.pnUnit = New System.Windows.Forms.FlowLayoutPanel
        Me.cb301 = New System.Windows.Forms.CheckBox
        Me.cb302 = New System.Windows.Forms.CheckBox
        Me.cb303 = New System.Windows.Forms.CheckBox
        Me.cb304 = New System.Windows.Forms.CheckBox
        Me.Splitter4 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnYcaseMonthYear = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnYcaseDate = New System.Windows.Forms.Panel
        Me.dtPickE = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtPickS = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnYcaseHeader = New System.Windows.Forms.Panel
        Me.cbCrossYear = New System.Windows.Forms.CheckBox
        Me.rb34 = New System.Windows.Forms.RadioButton
        Me.rb33 = New System.Windows.Forms.RadioButton
        Me.rb32 = New System.Windows.Forms.RadioButton
        Me.rb31 = New System.Windows.Forms.RadioButton
        Me.Splitter5 = New System.Windows.Forms.Splitter
        Me.pnColumn = New System.Windows.Forms.FlowLayoutPanel
        Me.cb201 = New System.Windows.Forms.CheckBox
        Me.cb202 = New System.Windows.Forms.CheckBox
        Me.cb203 = New System.Windows.Forms.CheckBox
        Me.cb204 = New System.Windows.Forms.CheckBox
        Me.cb205 = New System.Windows.Forms.CheckBox
        Me.cb206 = New System.Windows.Forms.CheckBox
        Me.cb207 = New System.Windows.Forms.CheckBox
        Me.cb208 = New System.Windows.Forms.CheckBox
        Me.rb11 = New System.Windows.Forms.RadioButton
        Me.rb12 = New System.Windows.Forms.RadioButton
        Me.txtEY = New PlanningS.NPIText
        Me.txtSY = New PlanningS.NPIText
        Me.txtEM = New PlanningS.NPIText
        Me.txtSM = New PlanningS.NPIText
        Me.cmdSQL = New PlanningS.NPIButton
        Me.cmdExport = New PlanningS.NPIButton
        Me.cmdExec = New PlanningS.NPIButton
        Me.pnHeader.SuspendLayout()
        Me.pnCmd.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnGrid.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDataReport.SuspendLayout()
        Me.pnUnit.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnYcaseMonthYear.SuspendLayout()
        Me.pnYcaseDate.SuspendLayout()
        Me.pnYcaseHeader.SuspendLayout()
        Me.pnColumn.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.Controls.Add(Me.pnColumn)
        Me.pnHeader.Controls.Add(Me.Splitter5)
        Me.pnHeader.Controls.Add(Me.Panel2)
        Me.pnHeader.Controls.Add(Me.Splitter4)
        Me.pnHeader.Controls.Add(Me.pnUnit)
        Me.pnHeader.Controls.Add(Me.Splitter3)
        Me.pnHeader.Controls.Add(Me.pnDataReport)
        Me.pnHeader.Controls.Add(Me.Splitter2)
        Me.pnHeader.Controls.Add(Me.pnCmd)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1229, 170)
        Me.pnHeader.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(324, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 170)
        Me.Splitter2.TabIndex = 10
        Me.Splitter2.TabStop = False
        '
        'pnCmd
        '
        Me.pnCmd.Controls.Add(Me.Label9)
        Me.pnCmd.Controls.Add(Me.Label2)
        Me.pnCmd.Controls.Add(Me.Label1)
        Me.pnCmd.Controls.Add(Me.cboDTgroup)
        Me.pnCmd.Controls.Add(Me.cboMCno)
        Me.pnCmd.Controls.Add(Me.cboProduct)
        Me.pnCmd.Controls.Add(Me.cmdSQL)
        Me.pnCmd.Controls.Add(Me.cmdExport)
        Me.pnCmd.Controls.Add(Me.cmdExec)
        Me.pnCmd.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnCmd.Location = New System.Drawing.Point(0, 0)
        Me.pnCmd.Name = "pnCmd"
        Me.pnCmd.Size = New System.Drawing.Size(324, 170)
        Me.pnCmd.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(18, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "MC no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(18, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Downtime group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product"
        '
        'cboDTgroup
        '
        Me.cboDTgroup.FormattingEnabled = True
        Me.cboDTgroup.Location = New System.Drawing.Point(168, 90)
        Me.cboDTgroup.Name = "cboDTgroup"
        Me.cboDTgroup.Size = New System.Drawing.Size(146, 21)
        Me.cboDTgroup.TabIndex = 9
        '
        'cboMCno
        '
        Me.cboMCno.FormattingEnabled = True
        Me.cboMCno.Location = New System.Drawing.Point(112, 49)
        Me.cboMCno.Name = "cboMCno"
        Me.cboMCno.Size = New System.Drawing.Size(121, 21)
        Me.cboMCno.TabIndex = 8
        '
        'cboProduct
        '
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(112, 12)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(121, 21)
        Me.cboProduct.TabIndex = 7
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 170)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1229, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 500000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 10
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Pongdej's Says :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFilter, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 322)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1229, 22)
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
        'pnGrid
        '
        Me.pnGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnGrid.Controls.Add(Me.lblSQL)
        Me.pnGrid.Controls.Add(Me.dtgMaster)
        Me.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnGrid.Location = New System.Drawing.Point(0, 173)
        Me.pnGrid.Name = "pnGrid"
        Me.pnGrid.Size = New System.Drawing.Size(1229, 149)
        Me.pnGrid.TabIndex = 18
        '
        'lblSQL
        '
        Me.lblSQL.AutoSize = True
        Me.lblSQL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSQL.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSQL.ForeColor = System.Drawing.Color.Yellow
        Me.lblSQL.Location = New System.Drawing.Point(592, 91)
        Me.lblSQL.Name = "lblSQL"
        Me.lblSQL.Size = New System.Drawing.Size(45, 13)
        Me.lblSQL.TabIndex = 19
        Me.lblSQL.Text = "Label19"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopylblSQL, Me.CopyGrid})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 48)
        '
        'CopylblSQL
        '
        Me.CopylblSQL.Name = "CopylblSQL"
        Me.CopylblSQL.Size = New System.Drawing.Size(127, 22)
        Me.CopylblSQL.Text = "Copy SQL"
        '
        'CopyGrid
        '
        Me.CopyGrid.Name = "CopyGrid"
        Me.CopyGrid.Size = New System.Drawing.Size(127, 22)
        Me.CopyGrid.Text = "Copy Grid"
        '
        'dtgMaster
        '
        Me.dtgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMaster.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtgMaster.Location = New System.Drawing.Point(138, 19)
        Me.dtgMaster.Name = "dtgMaster"
        Me.dtgMaster.Size = New System.Drawing.Size(303, 204)
        Me.dtgMaster.TabIndex = 18
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnDataReport
        '
        Me.pnDataReport.Controls.Add(Me.rb11)
        Me.pnDataReport.Controls.Add(Me.rb12)
        Me.pnDataReport.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnDataReport.Location = New System.Drawing.Point(327, 0)
        Me.pnDataReport.Name = "pnDataReport"
        Me.pnDataReport.Size = New System.Drawing.Size(136, 170)
        Me.pnDataReport.TabIndex = 18
        '
        'Splitter3
        '
        Me.Splitter3.Location = New System.Drawing.Point(463, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(3, 170)
        Me.Splitter3.TabIndex = 19
        Me.Splitter3.TabStop = False
        '
        'pnUnit
        '
        Me.pnUnit.Controls.Add(Me.cb301)
        Me.pnUnit.Controls.Add(Me.cb302)
        Me.pnUnit.Controls.Add(Me.cb303)
        Me.pnUnit.Controls.Add(Me.cb304)
        Me.pnUnit.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnUnit.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnUnit.Location = New System.Drawing.Point(466, 0)
        Me.pnUnit.Name = "pnUnit"
        Me.pnUnit.Size = New System.Drawing.Size(144, 170)
        Me.pnUnit.TabIndex = 20
        '
        'cb301
        '
        Me.cb301.AutoSize = True
        Me.cb301.Location = New System.Drawing.Point(3, 3)
        Me.cb301.Name = "cb301"
        Me.cb301.Size = New System.Drawing.Size(69, 17)
        Me.cb301.TabIndex = 0
        Me.cb301.Tag = "1"
        Me.cb301.Text = "Minute(s)"
        Me.cb301.UseVisualStyleBackColor = True
        '
        'cb302
        '
        Me.cb302.AutoSize = True
        Me.cb302.Location = New System.Drawing.Point(3, 26)
        Me.cb302.Name = "cb302"
        Me.cb302.Size = New System.Drawing.Size(60, 17)
        Me.cb302.TabIndex = 1
        Me.cb302.Tag = "2"
        Me.cb302.Text = "Hour(s)"
        Me.cb302.UseVisualStyleBackColor = True
        '
        'cb303
        '
        Me.cb303.AutoSize = True
        Me.cb303.Location = New System.Drawing.Point(3, 49)
        Me.cb303.Name = "cb303"
        Me.cb303.Size = New System.Drawing.Size(77, 17)
        Me.cb303.TabIndex = 2
        Me.cb303.Tag = "3"
        Me.cb303.Text = "Percent(%)"
        Me.cb303.UseVisualStyleBackColor = True
        '
        'cb304
        '
        Me.cb304.AutoSize = True
        Me.cb304.Location = New System.Drawing.Point(3, 72)
        Me.cb304.Name = "cb304"
        Me.cb304.Size = New System.Drawing.Size(104, 17)
        Me.cb304.TabIndex = 3
        Me.cb304.Tag = "4"
        Me.cb304.Text = "Count Downtime"
        Me.cb304.UseVisualStyleBackColor = True
        '
        'Splitter4
        '
        Me.Splitter4.Location = New System.Drawing.Point(610, 0)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(3, 170)
        Me.Splitter4.TabIndex = 21
        Me.Splitter4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pnYcaseMonthYear)
        Me.Panel2.Controls.Add(Me.pnYcaseDate)
        Me.Panel2.Controls.Add(Me.pnYcaseHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(613, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 170)
        Me.Panel2.TabIndex = 22
        '
        'pnYcaseMonthYear
        '
        Me.pnYcaseMonthYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnYcaseMonthYear.Controls.Add(Me.txtEY)
        Me.pnYcaseMonthYear.Controls.Add(Me.Label7)
        Me.pnYcaseMonthYear.Controls.Add(Me.txtSY)
        Me.pnYcaseMonthYear.Controls.Add(Me.Label8)
        Me.pnYcaseMonthYear.Controls.Add(Me.txtEM)
        Me.pnYcaseMonthYear.Controls.Add(Me.Label6)
        Me.pnYcaseMonthYear.Controls.Add(Me.txtSM)
        Me.pnYcaseMonthYear.Controls.Add(Me.Label5)
        Me.pnYcaseMonthYear.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnYcaseMonthYear.Location = New System.Drawing.Point(0, 66)
        Me.pnYcaseMonthYear.Name = "pnYcaseMonthYear"
        Me.pnYcaseMonthYear.Size = New System.Drawing.Size(344, 60)
        Me.pnYcaseMonthYear.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(166, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "To :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "From Year :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "To :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "From Month :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnYcaseDate
        '
        Me.pnYcaseDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnYcaseDate.Controls.Add(Me.dtPickE)
        Me.pnYcaseDate.Controls.Add(Me.Label4)
        Me.pnYcaseDate.Controls.Add(Me.dtPickS)
        Me.pnYcaseDate.Controls.Add(Me.Label3)
        Me.pnYcaseDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnYcaseDate.Location = New System.Drawing.Point(0, 33)
        Me.pnYcaseDate.Name = "pnYcaseDate"
        Me.pnYcaseDate.Size = New System.Drawing.Size(344, 33)
        Me.pnYcaseDate.TabIndex = 59
        '
        'dtPickE
        '
        Me.dtPickE.CustomFormat = "dd.MM.yyyy"
        Me.dtPickE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickE.Location = New System.Drawing.Point(218, 6)
        Me.dtPickE.Name = "dtPickE"
        Me.dtPickE.Size = New System.Drawing.Size(100, 20)
        Me.dtPickE.TabIndex = 36
        Me.dtPickE.Value = New Date(2010, 10, 7, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "To :"
        '
        'dtPickS
        '
        Me.dtPickS.CustomFormat = "dd.MM.yyyy"
        Me.dtPickS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickS.Location = New System.Drawing.Point(84, 6)
        Me.dtPickS.Name = "dtPickS"
        Me.dtPickS.Size = New System.Drawing.Size(100, 20)
        Me.dtPickS.TabIndex = 35
        Me.dtPickS.Value = New Date(2010, 9, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "From Date :"
        '
        'pnYcaseHeader
        '
        Me.pnYcaseHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnYcaseHeader.Controls.Add(Me.cbCrossYear)
        Me.pnYcaseHeader.Controls.Add(Me.rb34)
        Me.pnYcaseHeader.Controls.Add(Me.rb33)
        Me.pnYcaseHeader.Controls.Add(Me.rb32)
        Me.pnYcaseHeader.Controls.Add(Me.rb31)
        Me.pnYcaseHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnYcaseHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnYcaseHeader.Name = "pnYcaseHeader"
        Me.pnYcaseHeader.Size = New System.Drawing.Size(344, 33)
        Me.pnYcaseHeader.TabIndex = 58
        '
        'cbCrossYear
        '
        Me.cbCrossYear.AutoSize = True
        Me.cbCrossYear.Location = New System.Drawing.Point(250, 10)
        Me.cbCrossYear.Name = "cbCrossYear"
        Me.cbCrossYear.Size = New System.Drawing.Size(52, 17)
        Me.cbCrossYear.TabIndex = 46
        Me.cbCrossYear.Text = "Cross"
        Me.cbCrossYear.UseVisualStyleBackColor = True
        '
        'rb34
        '
        Me.rb34.AutoSize = True
        Me.rb34.Location = New System.Drawing.Point(171, 10)
        Me.rb34.Name = "rb34"
        Me.rb34.Size = New System.Drawing.Size(73, 17)
        Me.rb34.TabIndex = 43
        Me.rb34.TabStop = True
        Me.rb34.Tag = "4"
        Me.rb34.Text = "Es. Month"
        Me.rb34.UseVisualStyleBackColor = True
        '
        'rb33
        '
        Me.rb33.AutoSize = True
        Me.rb33.Location = New System.Drawing.Point(119, 10)
        Me.rb33.Name = "rb33"
        Me.rb33.Size = New System.Drawing.Size(47, 17)
        Me.rb33.TabIndex = 6
        Me.rb33.TabStop = True
        Me.rb33.Tag = "3"
        Me.rb33.Text = "Year"
        Me.rb33.UseVisualStyleBackColor = True
        '
        'rb32
        '
        Me.rb32.AutoSize = True
        Me.rb32.Location = New System.Drawing.Point(64, 11)
        Me.rb32.Name = "rb32"
        Me.rb32.Size = New System.Drawing.Size(55, 17)
        Me.rb32.TabIndex = 3
        Me.rb32.TabStop = True
        Me.rb32.Tag = "2"
        Me.rb32.Text = "Month"
        Me.rb32.UseVisualStyleBackColor = True
        '
        'rb31
        '
        Me.rb31.AutoSize = True
        Me.rb31.Location = New System.Drawing.Point(15, 11)
        Me.rb31.Name = "rb31"
        Me.rb31.Size = New System.Drawing.Size(48, 17)
        Me.rb31.TabIndex = 0
        Me.rb31.TabStop = True
        Me.rb31.Tag = "1"
        Me.rb31.Text = "Date"
        Me.rb31.UseVisualStyleBackColor = True
        '
        'Splitter5
        '
        Me.Splitter5.Location = New System.Drawing.Point(957, 0)
        Me.Splitter5.Name = "Splitter5"
        Me.Splitter5.Size = New System.Drawing.Size(3, 170)
        Me.Splitter5.TabIndex = 23
        Me.Splitter5.TabStop = False
        '
        'pnColumn
        '
        Me.pnColumn.Controls.Add(Me.cb201)
        Me.pnColumn.Controls.Add(Me.cb202)
        Me.pnColumn.Controls.Add(Me.cb203)
        Me.pnColumn.Controls.Add(Me.cb204)
        Me.pnColumn.Controls.Add(Me.cb205)
        Me.pnColumn.Controls.Add(Me.cb206)
        Me.pnColumn.Controls.Add(Me.cb207)
        Me.pnColumn.Controls.Add(Me.cb208)
        Me.pnColumn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnColumn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnColumn.Location = New System.Drawing.Point(960, 0)
        Me.pnColumn.Name = "pnColumn"
        Me.pnColumn.Size = New System.Drawing.Size(269, 170)
        Me.pnColumn.TabIndex = 24
        '
        'cb201
        '
        Me.cb201.AutoSize = True
        Me.cb201.Location = New System.Drawing.Point(3, 3)
        Me.cb201.Name = "cb201"
        Me.cb201.Size = New System.Drawing.Size(74, 17)
        Me.cb201.TabIndex = 0
        Me.cb201.Tag = "1"
        Me.cb201.Text = "Group MC"
        Me.cb201.UseVisualStyleBackColor = True
        '
        'cb202
        '
        Me.cb202.AutoSize = True
        Me.cb202.Location = New System.Drawing.Point(3, 26)
        Me.cb202.Name = "cb202"
        Me.cb202.Size = New System.Drawing.Size(57, 17)
        Me.cb202.TabIndex = 1
        Me.cb202.Tag = "2"
        Me.cb202.Text = "MC no"
        Me.cb202.UseVisualStyleBackColor = True
        '
        'cb203
        '
        Me.cb203.AutoSize = True
        Me.cb203.Location = New System.Drawing.Point(3, 49)
        Me.cb203.Name = "cb203"
        Me.cb203.Size = New System.Drawing.Size(72, 17)
        Me.cb203.TabIndex = 2
        Me.cb203.Tag = "3"
        Me.cb203.Text = "MC brand"
        Me.cb203.UseVisualStyleBackColor = True
        '
        'cb204
        '
        Me.cb204.AutoSize = True
        Me.cb204.Location = New System.Drawing.Point(3, 72)
        Me.cb204.Name = "cb204"
        Me.cb204.Size = New System.Drawing.Size(103, 17)
        Me.cb204.TabIndex = 3
        Me.cb204.Tag = "4"
        Me.cb204.Text = "Downtime group"
        Me.cb204.UseVisualStyleBackColor = True
        '
        'cb205
        '
        Me.cb205.AutoSize = True
        Me.cb205.Location = New System.Drawing.Point(3, 95)
        Me.cb205.Name = "cb205"
        Me.cb205.Size = New System.Drawing.Size(100, 17)
        Me.cb205.TabIndex = 4
        Me.cb205.Tag = "5"
        Me.cb205.Text = "Downtime code"
        Me.cb205.UseVisualStyleBackColor = True
        '
        'cb206
        '
        Me.cb206.AutoSize = True
        Me.cb206.Location = New System.Drawing.Point(3, 118)
        Me.cb206.Name = "cb206"
        Me.cb206.Size = New System.Drawing.Size(106, 17)
        Me.cb206.TabIndex = 5
        Me.cb206.Tag = "6"
        Me.cb206.Text = "Downtime details"
        Me.cb206.UseVisualStyleBackColor = True
        '
        'cb207
        '
        Me.cb207.AutoSize = True
        Me.cb207.Location = New System.Drawing.Point(3, 141)
        Me.cb207.Name = "cb207"
        Me.cb207.Size = New System.Drawing.Size(47, 17)
        Me.cb207.TabIndex = 6
        Me.cb207.Tag = "7"
        Me.cb207.Text = "Shift"
        Me.cb207.UseVisualStyleBackColor = True
        '
        'cb208
        '
        Me.cb208.AutoSize = True
        Me.cb208.Location = New System.Drawing.Point(115, 3)
        Me.cb208.Name = "cb208"
        Me.cb208.Size = New System.Drawing.Size(63, 17)
        Me.cb208.TabIndex = 6
        Me.cb208.Tag = "8"
        Me.cb208.Text = "Product"
        Me.cb208.UseVisualStyleBackColor = True
        '
        'rb11
        '
        Me.rb11.AutoSize = True
        Me.rb11.Location = New System.Drawing.Point(11, 13)
        Me.rb11.Name = "rb11"
        Me.rb11.Size = New System.Drawing.Size(103, 17)
        Me.rb11.TabIndex = 2
        Me.rb11.TabStop = True
        Me.rb11.Tag = "1"
        Me.rb11.Text = "Table (For Pivot)"
        Me.rb11.UseVisualStyleBackColor = True
        '
        'rb12
        '
        Me.rb12.AutoSize = True
        Me.rb12.Location = New System.Drawing.Point(11, 43)
        Me.rb12.Name = "rb12"
        Me.rb12.Size = New System.Drawing.Size(73, 17)
        Me.rb12.TabIndex = 3
        Me.rb12.TabStop = True
        Me.rb12.Tag = "2"
        Me.rb12.Text = "Cross Tab"
        Me.rb12.UseVisualStyleBackColor = True
        '
        'txtEY
        '
        Me.txtEY.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtEY.Location = New System.Drawing.Point(208, 33)
        Me.txtEY.MaxLength = 4
        Me.txtEY.Name = "txtEY"
        Me.txtEY.NumberOnly = True
        Me.txtEY.Showcomma = False
        Me.txtEY.Size = New System.Drawing.Size(45, 22)
        Me.txtEY.TabIndex = 46
        Me.txtEY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSY
        '
        Me.txtSY.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSY.Location = New System.Drawing.Point(104, 33)
        Me.txtSY.MaxLength = 4
        Me.txtSY.Name = "txtSY"
        Me.txtSY.NumberOnly = True
        Me.txtSY.Showcomma = False
        Me.txtSY.Size = New System.Drawing.Size(45, 22)
        Me.txtSY.TabIndex = 45
        Me.txtSY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtSY, "มีข้อมูลย้อนหลังถึงปี 2008 ครับ")
        '
        'txtEM
        '
        Me.txtEM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtEM.Location = New System.Drawing.Point(208, 5)
        Me.txtEM.MaxLength = 2
        Me.txtEM.Name = "txtEM"
        Me.txtEM.NumberOnly = True
        Me.txtEM.Showcomma = False
        Me.txtEM.Size = New System.Drawing.Size(45, 22)
        Me.txtEM.TabIndex = 44
        Me.txtEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSM
        '
        Me.txtSM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtSM.Location = New System.Drawing.Point(104, 5)
        Me.txtSM.MaxLength = 2
        Me.txtSM.Name = "txtSM"
        Me.txtSM.NumberOnly = True
        Me.txtSM.Showcomma = False
        Me.txtSM.Size = New System.Drawing.Size(45, 22)
        Me.txtSM.TabIndex = 43
        Me.txtSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdSQL
        '
        Me.cmdSQL.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSQL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSQL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSQL.ForeColor = System.Drawing.Color.Blue
        Me.cmdSQL.Location = New System.Drawing.Point(61, 138)
        Me.cmdSQL.Name = "cmdSQL"
        Me.cmdSQL.Size = New System.Drawing.Size(75, 23)
        Me.cmdSQL.TabIndex = 6
        Me.cmdSQL.Text = "&SQL"
        Me.cmdSQL.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(142, 138)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 23)
        Me.cmdExport.TabIndex = 5
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
        Me.cmdExec.Location = New System.Drawing.Point(239, 138)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 4
        Me.cmdExec.Text = "&Execute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'FrmDowntime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 344)
        Me.Controls.Add(Me.pnGrid)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "FrmDowntime"
        Me.TabText = "FrmDowntime"
        Me.Text = "OEE-A"
        Me.pnHeader.ResumeLayout(False)
        Me.pnCmd.ResumeLayout(False)
        Me.pnCmd.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnGrid.ResumeLayout(False)
        Me.pnGrid.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dtgMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDataReport.ResumeLayout(False)
        Me.pnDataReport.PerformLayout()
        Me.pnUnit.ResumeLayout(False)
        Me.pnUnit.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnYcaseMonthYear.ResumeLayout(False)
        Me.pnYcaseMonthYear.PerformLayout()
        Me.pnYcaseDate.ResumeLayout(False)
        Me.pnYcaseDate.PerformLayout()
        Me.pnYcaseHeader.ResumeLayout(False)
        Me.pnYcaseHeader.PerformLayout()
        Me.pnColumn.ResumeLayout(False)
        Me.pnColumn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblFilter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdExport As PlanningS.NPIButton
    Friend WithEvents cmdExec As PlanningS.NPIButton
    Friend WithEvents pnGrid As System.Windows.Forms.Panel
    Friend WithEvents dtgMaster As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblSQL As System.Windows.Forms.Label
    Friend WithEvents cmdSQL As PlanningS.NPIButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopylblSQL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyGrid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnCmd As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDTgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboMCno As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents pnColumn As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cb201 As System.Windows.Forms.CheckBox
    Friend WithEvents cb202 As System.Windows.Forms.CheckBox
    Friend WithEvents cb203 As System.Windows.Forms.CheckBox
    Friend WithEvents cb204 As System.Windows.Forms.CheckBox
    Friend WithEvents cb205 As System.Windows.Forms.CheckBox
    Friend WithEvents cb206 As System.Windows.Forms.CheckBox
    Friend WithEvents cb207 As System.Windows.Forms.CheckBox
    Friend WithEvents cb208 As System.Windows.Forms.CheckBox
    Friend WithEvents Splitter5 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnYcaseMonthYear As System.Windows.Forms.Panel
    Friend WithEvents txtEY As PlanningS.NPIText
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSY As PlanningS.NPIText
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEM As PlanningS.NPIText
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSM As PlanningS.NPIText
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnYcaseDate As System.Windows.Forms.Panel
    Friend WithEvents dtPickE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtPickS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnYcaseHeader As System.Windows.Forms.Panel
    Friend WithEvents cbCrossYear As System.Windows.Forms.CheckBox
    Friend WithEvents rb34 As System.Windows.Forms.RadioButton
    Friend WithEvents rb33 As System.Windows.Forms.RadioButton
    Friend WithEvents rb32 As System.Windows.Forms.RadioButton
    Friend WithEvents rb31 As System.Windows.Forms.RadioButton
    Friend WithEvents Splitter4 As System.Windows.Forms.Splitter
    Friend WithEvents pnUnit As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cb301 As System.Windows.Forms.CheckBox
    Friend WithEvents cb302 As System.Windows.Forms.CheckBox
    Friend WithEvents cb303 As System.Windows.Forms.CheckBox
    Friend WithEvents cb304 As System.Windows.Forms.CheckBox
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents pnDataReport As System.Windows.Forms.Panel
    Friend WithEvents rb11 As System.Windows.Forms.RadioButton
    Friend WithEvents rb12 As System.Windows.Forms.RadioButton
End Class
