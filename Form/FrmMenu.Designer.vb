<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("001 รายละเอียดสินค้า")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("000 ข้อมูลระบบ", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("101 Analysis stock (real time)")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("102 Alarm Report (history)")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("103 Dash board")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("100 Data for planning", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("201 A")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("200 Data OEE", New System.Windows.Forms.TreeNode() {TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("701 User behavior")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("702 Static of program")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("700 Report for Admin", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("811 Update Account - สำหรับบัญชี")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8121 เตรียมใบเบิก - สำหรับผลิต (ไม่มี Extra Job)")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8122 เตรียมใบเบิก - สำหรับผลิต (มี Extra Job)")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8123 เตรียมใบเบิก - สำหรับผลิต (ใส่ cost center)")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("813 เอาใบเบิกเข้า Consoh  - สำหรับคลัง")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("810 Interface ใบเบิก", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("820 Change mat in stock")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("800 ConSoh", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("901 Form")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("902 Test Planning")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("903 DB prefsuit")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("90401 Asset report")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("904 Asset master", New System.Windows.Forms.TreeNode() {TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("911 Change cost adjust")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("912 Standard to actual adjust")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("910 Account CO", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("900 Test program", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode24, TreeNode27})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "nd001MatMaster"
        TreeNode1.Text = "001 รายละเอียดสินค้า"
        TreeNode2.Name = "Node000"
        TreeNode2.Text = "000 ข้อมูลระบบ"
        TreeNode3.Name = "nd101MasterPlanning"
        TreeNode3.Text = "101 Analysis stock (real time)"
        TreeNode4.Name = "nd102AlarmReport"
        TreeNode4.Text = "102 Alarm Report (history)"
        TreeNode5.Name = "nd103DashBoard"
        TreeNode5.Text = "103 Dash board"
        TreeNode6.Name = "Node100"
        TreeNode6.Text = "100 Data for planning"
        TreeNode7.Name = "nd201"
        TreeNode7.Text = "201 A"
        TreeNode8.Name = "nd200"
        TreeNode8.Text = "200 Data OEE"
        TreeNode9.Name = "nd701UserBehavior"
        TreeNode9.Text = "701 User behavior"
        TreeNode10.Name = "nd702ProgramBehavior"
        TreeNode10.Text = "702 Static of program"
        TreeNode11.Name = "Node700"
        TreeNode11.Text = "700 Report for Admin"
        TreeNode12.Name = "nd811UpdateAccount"
        TreeNode12.Text = "811 Update Account - สำหรับบัญชี"
        TreeNode13.BackColor = System.Drawing.Color.White
        TreeNode13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        TreeNode13.Name = "nd8121PreGIxx"
        TreeNode13.Text = "8121 เตรียมใบเบิก - สำหรับผลิต (ไม่มี Extra Job)"
        TreeNode14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        TreeNode14.Name = "nd8122PreGIExtraxx"
        TreeNode14.Text = "8122 เตรียมใบเบิก - สำหรับผลิต (มี Extra Job)"
        TreeNode15.Name = "nd8123PreGICctr"
        TreeNode15.Text = "8123 เตรียมใบเบิก - สำหรับผลิต (ใส่ cost center)"
        TreeNode16.Name = "nd813GiToConsoh"
        TreeNode16.Text = "813 เอาใบเบิกเข้า Consoh  - สำหรับคลัง"
        TreeNode17.Name = "Node810"
        TreeNode17.Text = "810 Interface ใบเบิก"
        TreeNode18.Name = "nd820ChangeMatConsoh"
        TreeNode18.Text = "820 Change mat in stock"
        TreeNode19.Name = "Node800"
        TreeNode19.Text = "800 ConSoh"
        TreeNode20.Name = "nd901"
        TreeNode20.Text = "901 Form"
        TreeNode21.Name = "nd902"
        TreeNode21.Text = "902 Test Planning"
        TreeNode22.Name = "nd903"
        TreeNode22.Text = "903 DB prefsuit"
        TreeNode23.Name = "nd90401"
        TreeNode23.Text = "90401 Asset report"
        TreeNode24.Name = "nd904"
        TreeNode24.Text = "904 Asset master"
        TreeNode25.Name = "nd911"
        TreeNode25.Text = "911 Change cost adjust"
        TreeNode26.Name = "nd912"
        TreeNode26.Text = "912 Standard to actual adjust"
        TreeNode27.Name = "Nd910"
        TreeNode27.Text = "910 Account CO"
        TreeNode28.Name = "nd900"
        TreeNode28.Text = "900 Test program"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode6, TreeNode8, TreeNode11, TreeNode19, TreeNode28})
        Me.TreeView1.Size = New System.Drawing.Size(292, 266)
        Me.TreeView1.TabIndex = 0
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "FrmMenu"
        Me.TabText = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
