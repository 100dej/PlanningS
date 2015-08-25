Public Class Form4
    Private cx As New NPIData(NPIConnect.AccountBS)
    Private DT As DataTable
    Private X As String
    Private Compcode As String
    Private AssetID As String
    Private AssetNo As String
    Private AssetSubNo As String
    Private AssetName As String
    Private RespCctr As String
    Private Sub Form4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler cmdExecute.Click, AddressOf cmdExecute_Click
        AddHandler dtgMaster.DoubleClick, AddressOf dtgMaster_DoubleClick
        AddHandler cmdPicAdd.Click, AddressOf cmdPicAdd_Click
        AddHandler cmdSavepic.Click, AddressOf cmdPicSave_Click
        cmdPicAdd.Enabled = False
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

        X = String.Format("Exec Accdb.dbo.Asset_master '{0}','{1}','{2}'", AssetID, AssetName, RespCctr)
        DT = cx.GetdataTable(X)
        dtgMaster.DataSource = DT.DefaultView
        cx.GridToList(dtgMaster)

        cmdPicAdd.Enabled = False
        cmdSavepic.Enabled = False

    End Sub
    Private Sub dtgMaster_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dx As DataGridView = sender
        Dim y As Integer = dx.CurrentCell.RowIndex
        lblAssetNo.Text = dx.Item("massetid", y).Value

        X = String.Format("Exec accdb.dbo.asset_picture_show '{0}'", lblAssetNo.Text)

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
        cmdPicAdd.Enabled = True
        cmdSavepic.Enabled = True
    End Sub
    Private Sub cmdPicAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cdl As New OpenFileDialog
        Dim bmp As Bitmap
        Dim bmppixel As Double
        Dim pixcelctrl As Integer = 300000
        cdl.Filter = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            bmp = Image.FromFile(cdl.FileName)
            bmppixel = bmp.Height * bmp.Width
            bmppixel = (bmppixel Mod pixcelctrl) / bmppixel
            If bmppixel < 1 Then
                bmppixel = 1 - bmppixel
            Else
                bmppixel = 1
            End If
            Dim newbmp As New Bitmap(CInt(bmp.Width * bmppixel), CInt(bmp.Height * bmppixel))
            Dim gr_dest As Graphics = Graphics.FromImage(newbmp)
            gr_dest.DrawImage(bmp, 0, 0, newbmp.Width + 1, newbmp.Height + 1)
            picAsset.Image = newbmp
            Dim cmd As OleDbCommand = cx.CommandCreate("Exec accdb.dbo.asset_picture_insert ?,?,?,?", "TPTD")
            cmd.Parameters(0).Value = lblAssetNo.Text
            cmd.Parameters(1).Value = cx.ImageToBytesJPG(picAsset.Image)
            cmd.Parameters(2).Value = Uname
            cmd.Parameters(3).Value = Now()
            cx.Execute(cmd)
            MsgBox("Finish")
            cmdPicAdd.Enabled = False
        End If
    End Sub
    Private Sub cmdPicSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Get the two images
        Dim img1 As Image = picAsset.Image

        Using sfd As SaveFileDialog = New SaveFileDialog
            'Set the dialog's properties
            With sfd
                .FileName = String.Empty
                .Filter = "Jpeg|*.jpeg"
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                .Title = "Save Dual Images"
            End With

            'If the user decides to save...
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Declare a new bitmap with the width being both image's widths added together
                'And the height being the larger of the two images
                Using b As Bitmap = New Bitmap(img1.Width, img1.Height)
                    'Declare a new instance of graphics from our bitmap
                    Using g As Graphics = Graphics.FromImage(b)
                        'Draw the first image on the left
                        g.DrawImage(img1, New Point(0, 0))

                        'Save the graphics
                        g.Save()
                    End Using

                    'Save the bitmap
                    b.Save(sfd.FileName, Imaging.ImageFormat.Jpeg)
                End Using
            End If
        End Using
        MsgBox("เสร็จแล้ว อยู่ใน D:\image")
    End Sub
End Class