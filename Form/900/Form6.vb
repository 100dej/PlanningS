Public Class Form6
    Private cx As New NPIData(NPIConnect.AccountBS)
    Private DT As DataTable
    Private DV As DataView
    Private X As String
    Private Compcode As String
    Private AssetID As String
    Private AssetNo As String
    Private AssetSubNo As String
    Private AssetName As String
    Private RespCctr As String
    Private Sub Form6_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler cmdExecute.Click, AddressOf cmdExecute_Click
        AddHandler cmdSavepic.Click, AddressOf cmdPicSave_Click
        cmdSavepic.Enabled = False
    End Sub
    Private Sub cmdExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim A As New System.Text.StringBuilder("")

        If txtCompcode.Text = "" Then A.Append("%") Else A.Append(String.Format("{0:N0}", txtCompcode.Text).ToString().PadLeft(4, "0"))
        A.Append("-")
        If txtAssetno.Text = "" Then A.Append("%") Else A.Append(String.Format("{0:N0}", txtAssetno.Text).ToString().PadLeft(12, "0"))
        A.Append("-")
        If txtSubno.Text = "" Then A.Append("%") Else A.Append(String.Format("{0:N0}", txtSubno.Text).ToString().PadLeft(4, "0"))
        AssetID = A.ToString
        A.Remove(0, A.ToString.Count)

        A.Append("%")
        A.Append(txtAssetname.Text)
        A.Append("%")
        AssetName = A.ToString
        A.Remove(0, A.ToString.Count)

        A.Append("%")
        A.Append(txtRespcctr.Text)
        A.Append("%")
        RespCctr = A.ToString
        A.Remove(0, A.ToString.Count)

        X = String.Format("Exec Accdb.dbo.Asset_master_w_pic '{0}','{1}','{2}'", AssetID, AssetName, RespCctr)
        DT = cx.GetdataTable(X)
        DV = DT.DefaultView
        dtgMaster.DataSource = DV
        cx.GridToList(dtgMaster)

        cmdSavepic.Enabled = True

    End Sub
    Private Sub cmdPicSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Get the two images
        Me.Cursor = Cursors.WaitCursor
        Dim img1 As Image
        Using sfd As SaveFileDialog = New SaveFileDialog


            For Each Drv As DataRowView In DV
                X = String.Format("Exec accdb.dbo.asset_picture_show '{0}'", Drv!massetid.ToString)
                Dim dt1 As DataTable = cx.GetdataTable(X)
                Try
                    Dim dr As DataRow = dt1.Rows(0)
                    If IsDBNull(dr!massetpiclarge) Then
                        picAsset.Image = Nothing
                    Else
                        picAsset.Image = cx.BytesToImage(dr!massetpiclarge)
                    End If
                Catch ex As Exception
                    picAsset.Image = Nothing
                End Try
                'Set the dialog's properties
                img1 = picAsset.Image
                With sfd
                    .FileName = Drv!massetid.ToString + ".jpeg"
                    .InitialDirectory = "D:\image\"
                End With
                'Declare a new instance of graphics from our bitmap
                Using b As Bitmap = New Bitmap(img1.Width, img1.Height)
                    Using g As Graphics = Graphics.FromImage(b)
                        'Draw the first image on the left
                        g.DrawImage(img1, New Point(0, 0))
                        'Save the graphics
                        g.Save()
                    End Using
                    'Save the bitmap
                    b.Save(sfd.InitialDirectory + sfd.FileName, Imaging.ImageFormat.Jpeg)

                    'End If
                End Using
            Next
        End Using
        MsgBox("เสร็จแล้ว ไชโย  อยู่ใน D:\image")
        Me.Cursor = Cursors.Default

    End Sub
End Class