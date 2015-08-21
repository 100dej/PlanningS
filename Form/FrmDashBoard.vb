Public Class FrmDashBoard
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private VUname As String
    Private Vname As String
    Private x As String
    Private ListOfControl As New List(Of Control)
    Private ChartOf As New List(Of RadioButton)
    Private Sub FrmDashBoard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.ChangeCulture("en-US")

        AddHandler cboUname.SelectedValueChanged, AddressOf cboUname_SelectedValueChanged
        AddHandler cboVname.SelectedValueChanged, AddressOf cboVname_SelectedValueChanged
        AddHandler cmdSetVariant.Click, AddressOf cmdSetVariant_Click
        AddHandler cboVname.Click, AddressOf cboVname_Click
        AddHandler cboUname.Click, AddressOf cboUname_Click
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler TreeView1.BeforeExpand, AddressOf TreeView1_BeforeExpand
        AddHandler TreeView1.AfterCollapse, AddressOf TreeView1_AfterCollapse

        Dim DT1 As DataTable = cx.GetdataTable("select Uname from tbl_103userFilterVariant group by Uname order by Uname")
        cboUname.DisplayMember = "Uname"
        cboUname.ValueMember = "Uname"
        cboUname.DataSource = DT1

        Try
            cboUname.SelectedValue = Uname
        Catch ex As Exception

        End Try

        For Each ctrl As RadioButton In Me.pnChartOF.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ChartOF_CheckChanged
            ChartOf.Add(ctrl)
            ListOfControl.Add(ctrl)
        Next

        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
    End Sub
    Private Sub ChartOF_CheckChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        Select Case R1.Tag
            Case 0
                x = String.Format("select * from plannings.dbo.DashboardVariant('{0}','{1}','{2}')", VUname, Vname, Now.Year)
                DT = cx.GetdataTable(x)
                Chart1.DataSource = DT

        End Select
    End Sub
    Sub clear()
        cx.ClearButton(Panel1)
        TreeView1.Nodes.Clear()
    End Sub
    Private Sub cmdExec_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Call clear()

        Me.Cursor = Cursors.WaitCursor

        If cboVname.SelectedValue = Nothing Then MsgBox("Please choose your variant!!") : cboVname.Focus() : Exit Sub

        Dim n1 As New TreeNode(Vname)
        TreeView1.Nodes.Add(n1)
        Dim n2 As New TreeNode
        n2.Text = "xxx"
        n2.Tag = "xxx"
        n1.Nodes.Add(n2)

        TreeView1.ExpandAll()

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub TreeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        Dim n1 As TreeNode = e.Node
        n1.Nodes().Clear()
        Dim n2 As New TreeNode
        n2.Text = "xxx"
        n2.Tag = "xxx"
        n1.Nodes.Add(n2)
    End Sub
    Private Sub TreeView1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)
        Dim n1 As TreeNode = e.Node
        Select Case n1.Level
            Case 0
                If n1.Nodes(0).Text = "xxx" And n1.Nodes(0).Tag = "xxx" Then
                    n1.Nodes.Clear()
                End If
                x = String.Format("select distinct mbusiness from Select_User_Variant_For_Treenode('{0}','{1}')", VUname, Vname)
                Dim DT3 As DataTable = cx.GetdataTable(x)

                x = String.Format("select distinct mbusiness,mproduct from Select_User_Variant_For_Treenode('{0}','{1}')", VUname, Vname)
                Dim DT4 As DataTable = cx.GetdataTable(x)
                Dim DV4 As DataView = DT4.DefaultView
                For Each dr As DataRow In DT3.Rows
                    DV4.RowFilter = String.Format("mbusiness = '{0}'", dr("mbusiness"))
                    Dim n2 As New TreeNode
                    n2.Text = dr!mbusiness & " [" & DV4.Count & "]"
                    n2.Tag = dr!mbusiness
                    n1.Nodes.Add(n2)
                    Dim n3 As New TreeNode
                    n3.Text = "xxx"
                    n3.Tag = "xxx"
                    n2.Nodes.Add(n3)
                Next
            Case 1
                If n1.Nodes(0).Text = "xxx" And n1.Nodes(0).Tag = "xxx" Then
                    n1.Nodes.Clear()
                End If
                x = String.Format("select distinct mproduct from Select_User_Variant_For_Treenode('{0}','{1}') where mbusiness = '{2}'" _
                                  , VUname, Vname, n1.Tag)
                Dim DT3 As DataTable = cx.GetdataTable(x)

                x = String.Format("select distinct mproduct,mtype from Select_User_Variant_For_Treenode('{0}','{1}') where mbusiness = '{2}'" _
                    , VUname, Vname, n1.Tag)
                Dim DT4 As DataTable = cx.GetdataTable(x)
                Dim DV4 As DataView = DT4.DefaultView

                For Each Dr3 As DataRow In DT3.Rows
                    DV4.RowFilter = String.Format("mproduct = '{0}' ", Dr3!mproduct)
                    Dim n3 As New TreeNode
                    n3.Text = Dr3!mproduct & " [" & DV4.Count & "]"
                    n3.Tag = Dr3!mproduct
                    n1.Nodes.Add(n3)
                    Dim n4 As New TreeNode
                    n4.Text = "xxx"
                    n4.Tag = "xxx"
                    n3.Nodes.Add(n4)
                Next
            Case 2
                If n1.Nodes(0).Text = "xxx" And n1.Nodes(0).Tag = "xxx" Then
                    n1.Nodes.Clear()
                End If
                x = String.Format("select distinct mtype from Select_User_Variant_For_Treenode('{0}','{1}') where mproduct = '{2}'" _
                                  , VUname, Vname, n1.Tag)
                Dim DT3 As DataTable = cx.GetdataTable(x)

                x = String.Format("select distinct mtype,mmateng from Select_User_Variant_For_Treenode('{0}','{1}') where mproduct = '{2}'" _
                    , VUname, Vname, n1.Tag)
                Dim DT4 As DataTable = cx.GetdataTable(x)
                Dim DV4 As DataView = DT4.DefaultView
                For Each Dr3 As DataRow In DT3.Rows
                    DV4.RowFilter = String.Format("mtype = '{0}' ", Dr3!mtype)
                    Dim n3 As New TreeNode
                    n3.Text = Dr3!mtype & " [" & DV4.Count & "]"
                    n3.Tag = Dr3!mtype
                    n1.Nodes.Add(n3)
                    Dim n4 As New TreeNode
                    n4.Text = "xxx"
                    n4.Tag = "xxx"
                    n3.Nodes.Add(n4)
                Next
            Case 3
                If n1.Nodes(0).Text = "xxx" And n1.Nodes(0).Tag = "xxx" Then
                    n1.Nodes.Clear()
                End If
                x = String.Format("select distinct mmateng from Select_User_Variant_For_Treenode('{0}','{1}') where mtype = '{2}'" _
                                  , VUname, Vname, n1.Tag)
                Dim DT3 As DataTable = cx.GetdataTable(x)
                For Each Dr3 As DataRow In DT3.Rows
                    Dim n3 As New TreeNode
                    n3.Text = Dr3!mmateng
                    n3.Tag = Dr3!mmateng
                    n1.Nodes.Add(n3)
                Next
        End Select
    End Sub
    Private Sub cboUname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If cboUname.SelectedValue = Nothing Then cboVname.DataSource = Nothing : VUname = Nothing : Exit Sub
        VUname = cboUname.SelectedValue
    End Sub
    Private Sub cboVname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Vname = cboVname.SelectedValue
    End Sub
    Private Sub cmdSetVariant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call clear()
        Dim frm As Form
        For Each frm In frmMain.MdiChildren
            If (TypeOf frm Is FrmUserVariant) Then
                frm.Activate()
                Exit Sub
            End If
        Next
        Dim cf As New FrmUserVariant
        cf.Show(DockPanel)
    End Sub
    Private Sub cboUname_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Call clear()
        cboUname.DataSource = Nothing
        Dim DT1 As DataTable = cx.GetdataTable("select Uname from tbl_103userFilterVariant group by Uname order by Uname")
        cboUname.DisplayMember = "Uname"
        cboUname.ValueMember = "Uname"
        cboUname.DataSource = DT1
    End Sub
    Private Sub cboVname_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Call clear()
        cboVname.DataSource = Nothing
        Dim SSql As String = String.Format("select Vname from tbl_103userFilterVariant where Uname = '{0}' group by Vname order by Vname", _
           cboUname.SelectedValue)
        Dim DT1 As DataTable = cx.GetdataTable(SSql)
        cboVname.DisplayMember = "Vname"
        cboVname.ValueMember = "Vname"
        cboVname.DataSource = DT1
    End Sub
End Class