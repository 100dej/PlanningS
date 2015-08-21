Imports VS2005Extender
Public Class frmMain
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        ImageList1 = cx.fillImlWithFilesFromDir("\\172.31.195.13\plannings\install\installpc\PictureLoop")
        VS2005Style.Extender.SetSchema(DockPanel, VS2005Style.Extender.Schema.FromBase)
        FrmMenu.Show(DockPanel, WeifenLuo.WinFormsUI.DockState.DockLeft)
        FrmMenu.CloseButton = False

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Me.Text = "Pongdej's Projects : PlanningS : V." & System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Else
            Dim MeVersion As System.Version = System.Reflection.Assembly.GetExecutingAssembly.GetName.Version()
            Me.Text = String.Format("Pongdej's Projects : PlanningS : V.{0}.{1}.{2}.{3}", MeVersion.Major, MeVersion.Minor _
            , MeVersion.Build, MeVersion.Revision)
        End If

        Dim A As String = cx.ExecuteScalar(String.Format("exec WelcomeMyProg '{0}'", Uname))
        If Len(A) > 1 Then MsgBox(A)
    End Sub
End Class
