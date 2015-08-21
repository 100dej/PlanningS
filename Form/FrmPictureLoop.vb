Public Class FrmPictureLoop
    Private allowedExtensions() As String = {".gif", ".jpg", ".bmp", ".png"}
    Private Function GetThumbnail(ByVal imagePath As String) As Bitmap
        Const thumbSize As Integer = 256
        Try
            Dim originalImage = New Bitmap(imagePath)

            'if the image is small than a thumbnail, return it
            If originalImage.Width < thumbSize AndAlso originalImage.Height < thumbSize Then
                Return originalImage
            End If

            Dim format = originalImage.RawFormat

            Dim ratio As Decimal
            Dim newWidth As Integer
            Dim newHeight As Integer

            If originalImage.Width > originalImage.Height Then
                ratio = Convert.ToDecimal(thumbSize / originalImage.Width)
                newWidth = thumbSize
                newHeight = Convert.ToInt32(originalImage.Height * ratio)
            Else
                ratio = Convert.ToDecimal(thumbSize / originalImage.Height)
                newHeight = thumbSize
                newWidth = Convert.ToInt32(originalImage.Width * ratio)
            End If

            Dim thumbNail As New Bitmap(newWidth, newHeight)
            Dim g = Graphics.FromImage(thumbNail)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.FillRectangle(Brushes.White, 0, 0, newWidth, newHeight)
            g.DrawImage(originalImage, 0, 0, newWidth, newHeight)

            Return thumbNail

        Catch exArg As System.ArgumentException
            'not an image
            Return Nothing
        End Try

    End Function
    Function fillImlWithFilesFromDir(ByRef dirPath As String) As ImageList
        Dim imlTemp As New ImageList
        Dim dirFiles() As String = IO.Directory.GetFiles(dirPath)
        imlTemp.ImageSize = New Size(256, 256)
        imlTemp.ColorDepth = ColorDepth.Depth32Bit

        For Each dirFile As String In dirFiles
            For Each extension As String In allowedExtensions
                If extension = IO.Path.GetExtension(dirFile) Then
                    imlTemp.Images.Add(Image.FromFile(dirFile))
                End If
            Next
        Next

        Return imlTemp
    End Function
    Private Sub FrmPictureLoop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ImageList1 = fillImlWithFilesFromDir("...\PictureLoop")

        Dim intPic As Integer
        Dim rand As New Random
        intPic = rand.Next(0, ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(intPic)
    End Sub
End Class