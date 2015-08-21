Public Class FrmMenu
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.ExpandAll()
        AddHandler TreeView1.DoubleClick, AddressOf TreeView1_OpenForm
        AddHandler TreeView1.KeyPress, AddressOf TreeView1_KeyPress
    End Sub
    Private Sub TreeView1_OpenForm(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DockState = WeifenLuo.WinFormsUI.DockState.DockLeftAutoHide
        Dim Y As String = TreeView1.SelectedNode.Name
        Select Case Y
            Case "nd001MatMaster"
                Dim cf As New FrmMatMaster
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd101MasterPlanning"
                Dim cf As New FrmMasterPlanning
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd102AlarmReport"
                Dim cf As New FrmPSO
                cf.Show(DockPanel)
            Case "nd103DashBoard"
                Dim cf As New FrmDashBoard
                cf.Show(DockPanel)
            Case "nd201"
                Dim cf As New FrmDowntime
                cf.Show(DockPanel)
            Case "nd701UserBehavior"
                Dim cf As New FrmUserBehavior
                cf.Show(DockPanel)
            Case "nd702ProgramBehavior"
                Dim cf As New FrmProgramBehavior
                cf.Show(DockPanel)
            Case "nd811UpdateAccount"
                Dim frm As Form
                For Each frm In frmMain.MdiChildren
                    If (TypeOf frm Is FrmGIAccount) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New FrmGIAccount
                cf.Show(DockPanel)
            Case "nd8121PreGI"
                Dim frm As Form
                For Each frm In frmMain.MdiChildren
                    If (TypeOf frm Is FrmPreGI) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New FrmPreGI
                cf.Show(DockPanel)
            Case "nd8122PreGIExtra"
                Dim frm As Form
                For Each frm In frmMain.MdiChildren
                    If (TypeOf frm Is FrmPreGIExtra) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New FrmPreGIExtra
                cf.Show(DockPanel)
            Case "nd8123PreGICctr"
                Dim frm As Form
                For Each frm In frmMain.MdiChildren
                    If (TypeOf frm Is frmpregivercctr) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New frmpregivercctr
                cf.Show(DockPanel)
            Case "nd813GiToConsoh"
                Dim frm As Form
                For Each frm In frmMain.MdiChildren
                    If (TypeOf frm Is FrmGiToConsoh) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New FrmGiToConsoh
                cf.Show(DockPanel)
            Case "nd820ChangeMatConsoh"
                Dim frm As Form
                For Each frm In frmMain.MdiChildren
                    If (TypeOf frm Is FrmGiToConsoh) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New FrmChangeMatConsoh
                cf.Show(DockPanel)
            Case "nd901"
                Dim cf As New Form1
                cf.Show(DockPanel)
            Case "nd902"
                Dim cf As New Form2
                cf.Show(DockPanel)
            Case "nd903"
                Dim cf As New Form3
                cf.Show(DockPanel)
            Case "nd904"
                Dim cf As New Form4
                cf.Show(DockPanel)
            Case "nd90401"
                Dim cf As New Form6
                cf.Show(DockPanel)
            Case "nd911"
                Dim cf As New FrmChangecsotBeginStock
                cf.Show(DockPanel)
            Case "nd912"
                Dim cf As New FrmRevalue
                cf.Show(DockPanel)
            Case Else
                MsgBox("อยู่ระหว่างการจัดทำ")
                Me.DockState = WeifenLuo.WinFormsUI.DockState.DockLeft
        End Select
    End Sub
    Private Sub TreeView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            TreeView1_OpenForm(sender:=TreeView1.SelectedNode.Name, e:=Nothing)
        Else : Exit Sub
        End If
    End Sub
End Class