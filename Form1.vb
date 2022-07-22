Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports QRCoder
Imports QRCoder.QRCodeGenerator

Public Class Form1
    Dim PicW, PicH As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        P1.Visible = False
        P3.Image = GetQR(TQR.Text, 1, ECCLevel.H, TxtQB.Value, TxtZ.Value)
        P4.Image = Magnifier(P3.Image, TxtZ.Value)
        P4.Left = 9 : P4.Top = 156
        P4.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        P1.Visible = False
        PicW = Val(TxtW.Text)
        PicH = Val(TxtH.Text)
        'P1:原图缩放至W*H
        Dim B1 As New Bitmap(P1.Image)
        Dim B2 As New Bitmap(PicW, PicH)
        Dim G As Graphics = Graphics.FromImage(B2)
        G.DrawImage(P1.Image, 0, 0, PicW, PicH)
        P2.Image = B2
        'P2.1:转换为Byte
        Dim B3(PicW + 1, PicH + 1) As Color
        Dim I, J As Integer
        For I = 1 To PicW
            For J = 1 To PicH
                B3(I, J) = B2.GetPixel(I - 1, J - 1)
            Next
        Next
        'P2.2:匹配颜色
        Dim B4(PicW + 1, PicH + 1) As Color
        Dim B5 As New Bitmap(PicW, PicH)
        Select Case ComboBox1.SelectedIndex
            Case 0 '抖动模式
                For I = 1 To PicW
                    For J = 1 To PicH
                        B4(I, J) = GetBDColor(B3(I, J), BayerDithering(I - 1, J - 1))
                        B5.SetPixel(I - 1, J - 1, B4(I, J))
                    Next
                Next
            Case 1 '灰度M模式
                For I = 1 To PicW
                    For J = 1 To PicH
                        B4(I, J) = GetGradMColor(B3(I, J))
                        B5.SetPixel(I - 1, J - 1, B4(I, J))
                    Next
                Next
            Case 2 '灰度V模式 参数未调整
                For I = 1 To PicW
                    For J = 1 To PicH
                        B4(I, J) = GetGradVColor(B3(I, J))
                        B5.SetPixel(I - 1, J - 1, B4(I, J))
                    Next
                Next
            Case 3 '灰度G模式 参数未调整
                For I = 1 To PicW
                    For J = 1 To PicH
                        B4(I, J) = GetGradGColor(B3(I, J))
                        B5.SetPixel(I - 1, J - 1, B4(I, J))
                    Next
                Next
            Case 4 '距离近似模式
                For I = 1 To PicW
                    For J = 1 To PicH
                        B4(I, J) = GetSimColor(B3(I, J))
                        B5.SetPixel(I - 1, J - 1, B4(I, J))
                    Next
                Next
            Case 5 'LAB近似
                For I = 1 To PicW
                    For J = 1 To PicH
                        B4(I, J) = GetLabColor(B3(I, J))
                        B5.SetPixel(I - 1, J - 1, B4(I, J))
                    Next
                Next
        End Select
        P3.Image = B5
        'P3:绘制结果
        P4.Image = Magnifier(B5, TxtZ.Value)
        P4.Left = 9 : P4.Top = 156
        P4.Visible = True
    End Sub
    Function BayerDithering(X As Integer, Y As Integer) As Single
        Return CSng((DMap((X And 7) + (Y And 7) * 8) / 64 - 0.5) * 510 / 5)
    End Function
    Function GetBDColor(C As Color, FC As Single) As Color '距离近似
        Dim i As Integer, D As Single, T As Single
        Dim DR, DG, DB As Single
        Dim GC As Integer
        D = 7000000
        For i = 0 To 5
            DR = CSng(C.R) + FC
            DG = CSng(C.G) + FC
            DB = CSng(C.B) + FC
            DR -= CSng(CubeColor(i).R)
            DG -= CSng(CubeColor(i).G)
            DB -= CSng(CubeColor(i).B)
            T = DR * DR + DG * DG + DB * DB
            If T < D Then
                D = T
                GC = i
            End If
        Next
        Return CubeColor(GC)
    End Function

    Function GetGradGColor(C As Color) As Color '灰度
        Select Case C.G
            Case Is < 80
                Return Color.Blue
            Case Is < 120
                Return Color.Red
            Case Is < 150
                Return Color.Orange
            Case Is < 180
                Return Color.Yellow
            Case Else
                Return Color.White
        End Select
    End Function
    Function GetGradMColor(C As Color) As Color '灰度
        Dim G As Single
        G = CSng(C.R) * 0.299 + CSng(C.G) * 0.587 + CSng(C.B) * 0.144
        Select Case G
            Case Is < 80
                Return Color.Blue
            Case Is < 120
                Return Color.Red
            Case Is < 150
                Return Color.Orange
            Case Is < 180
                Return Color.Yellow
            Case Else
                Return Color.White
        End Select
    End Function
    Function GetGradVColor(C As Color) As Color '灰度
        Dim G As Single
        G = (CSng(C.R) + CSng(C.G) + CSng(C.B)) / 3
        Select Case G
            Case Is > 180
                Return Color.White
            Case Is > 150
                Return Color.Yellow
            Case Is > 120
                Return Color.Orange
            Case Is > 90
                Return Color.Red
            Case Else
                Return Color.Blue
        End Select
    End Function
    Function GetLabColor(C As Color) As Color 'LAB近似
        Dim i As Integer, D As Single, T As Single
        Dim DR, DG, DB, CR As Single
        Dim GC As Integer
        D = 800000
        For i = 0 To 5
            DR = CSng(C.R) - CSng(CubeColor(i).R)
            DG = CSng(C.G) - CSng(CubeColor(i).G)
            DB = CSng(C.B) - CSng(CubeColor(i).B)
            CR = (CSng(C.R) + CSng(CubeColor(i).R)) / 2
            T = (2 + CR / 256) * DR * DR + 4 * DG * DG + (2 + (255 - CR) / 256) * DB * DB
            If T < D Then
                D = T
                GC = i
            End If
        Next
        Return CubeColor(GC)
    End Function
    Function GetSimColor(C As Color) As Color '距离近似
        Dim i As Integer, D As Single, T As Single
        Dim DR, DG, DB As Single
        Dim GC As Integer
        D = 200000
        For i = 0 To 5
            DR = CSng(C.R) - CSng(CubeColor(i).R)
            DG = CSng(C.G) - CSng(CubeColor(i).G)
            DB = CSng(C.B) - CSng(CubeColor(i).B)
            T = DR * DR + DG * DG + DB * DB
            If T < D Then
                D = T
                GC = i
            End If
        Next
        Return CubeColor(GC)
    End Function
    Function GetQR(A As String, Optional P As Integer = 1, Optional EL As Integer = ECCLevel.H, Optional B As Integer = 0, Optional Z As Integer = 1) As Bitmap
        Dim Q As New QRCoder.QRCodeGenerator
        Dim QD As QRCoder.QRCodeData = Q.CreateQrCode(A, EL)
        Dim QC As New QRCode(QD)
        Dim QI As Bitmap = QC.GetGraphic(P, CubeColor(ComboBox2.SelectedIndex), CubeColor(ComboBox3.SelectedIndex), False)
        Dim PI As New Bitmap(QI.Width + B * 2, QI.Width + B * 2)
        Dim G As Graphics = Graphics.FromImage(PI)
        G.FillRectangle(New SolidBrush(CubeColor(ComboBox3.SelectedIndex)), 0, 0, PI.Width, PI.Height)
        G.DrawImage(QI, B, B, QI.Width, QI.Width)
        Return PI
    End Function

    Public Function Byte2Img(ByVal bytes As Byte()) As Bitmap
        Return CType(Bitmap.FromStream(New IO.MemoryStream(bytes)), Bitmap)
    End Function
    Dim CubeColor(5) As Color, CubePen(5) As Pen
    Dim DMap() As Single
    Dim IsOnload As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 4
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 4
        CubeColor = {Color.White, Color.FromArgb(&HFF, 0, &HFF, 0), Color.Red, Color.FromArgb(&HFF, &HFF, &H80, 0), Color.Blue, Color.Yellow}
        For i As Integer = 0 To 5
            CubePen(i) = New Pen(CubeColor(i))
        Next
        DMap = {0, 48, 12, 60, 3, 51, 15, 63, 32, 16, 44, 28, 35, 19, 47, 31,
                8, 56, 4, 52, 11, 59, 7, 55, 40, 24, 36, 20, 43, 27, 39, 23,
                2, 50, 14, 62, 1, 49, 13, 61, 34, 18, 46, 30, 33, 17, 45, 29,
                10, 58, 6, 54, 9, 57, 5, 53, 42, 26, 38, 22, 41, 25, 37, 21}
        IsOnload = True
    End Sub


    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim S() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        If S.Length = 1 Then
            P4.Visible = False
            sender.TEXT = S(0)
            P1.Image = Image.FromFile(S(0))
            TxtW.Text = P1.Width.ToString
            TxtH.Text = P1.Height.ToString
            P1.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim F As New FontDialog
        F.Font = Button4.Font
        F.ShowDialog()
        Button4.Font = F.Font
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        P1.Visible = False
        Dim B As Bitmap, G As Graphics = P1.CreateGraphics
        Dim S() As String = TTX.Text.Split(vbCrLf)
        Dim TxtSize As Size = G.MeasureString(TTX.Text, Button4.Font).ToSize
        B = New Bitmap(TxtSize.Width, TxtSize.Height)
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        G = Graphics.FromImage(B)
        G.FillRectangle(New SolidBrush(Color.White), 0, 0, B.Width, B.Height)
        G.DrawString(TTX.Text, Button4.Font, New SolidBrush(Color.Black), 0, 0)
        P3.Image = ImgThr(B, CubeColor(ComboBox5.SelectedIndex), CubeColor(ComboBox4.SelectedIndex))
        P4.Image = Magnifier(P3.Image, TxtZ.Value)
        P4.Left = 9 : P4.Top = 156
        P4.Visible = True
    End Sub
    Private Function ImgThr(srcB As Bitmap, FColor As Color, BColor As Color) As Bitmap
        Dim B As Bitmap = New Bitmap(srcB.Size.Width, srcB.Size.Height)
        Dim srcData As BitmapData = srcB.LockBits(New Rectangle(New Point(0, 0), srcB.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb)
        Dim BData As BitmapData = B.LockBits(New Rectangle(New Point(0, 0), B.Size), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)
        Dim srcPtr As IntPtr = srcData.Scan0
        Dim BPtr As IntPtr = BData.Scan0
        Dim C As Color
        For y As Integer = 0 To srcData.Height - 1
            For x As Integer = 0 To srcData.Width - 1
                C = Color.FromArgb(Marshal.ReadInt32(srcPtr, (x + y * srcData.Width) * 4))
                Marshal.WriteInt32(BPtr, (x + y * srcData.Width) * 4, If(C.G < CByte(TThr.Text), FColor.ToArgb, BColor.ToArgb))
            Next
        Next
        srcB.UnlockBits(srcData)
        B.UnlockBits(BData)
        Return B
    End Function

    Private Sub TThr_ValueChanged(sender As Object, e As EventArgs) Handles TThr.ValueChanged
        If Not IsOnload Then Exit Sub
        Dim B As Bitmap, G As Graphics = P1.CreateGraphics
        Dim S() As String = TTX.Text.Split(vbCrLf)
        Dim TxtSize As Size = G.MeasureString(TTX.Text, Button4.Font).ToSize
        B = New Bitmap(TxtSize.Width, TxtSize.Height)
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        G = Graphics.FromImage(B)
        G.FillRectangle(New SolidBrush(Color.White), 0, 0, B.Width, B.Height)
        G.DrawString(TTX.Text, Button4.Font, New SolidBrush(Color.Black), 0, 0)
        P1.Image = ImgThr(B, CubeColor(ComboBox5.SelectedIndex), CubeColor(ComboBox4.SelectedIndex))
        P4.Image = Magnifier(P1.Image, TxtZ.Value)
        P4.Visible = True
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim FName As String = "魔方拼图" & DateTime.Now.ToString("yyyyMMdd-HHmmss")
        MkDir(Application.StartupPath & "\" & FName)
        Dim SpW, BoW As Integer, Zoom As Integer = TxtZ.Value
        BoW = If(CheckBox1.Checked, 1, 0)
        SpW = If(CheckBox2.Checked, 1, 0)
        '宽度=P宽*缩放+(P宽+1)*边框+(P宽\3+1)*分隔线
        Dim PW, PH As Integer
        PW = P3.Width * Zoom + (P3.Width + 1) * BoW + (P3.Width \ 3 + 1) * SpW
        PH = P3.Height * Zoom + (P3.Height + 1) * BoW + (P3.Height \ 3 + 1) * SpW
        Dim B As Bitmap = New Bitmap(PW, PH), SrcB As Bitmap = P3.Image
        Dim G As Graphics = Graphics.FromImage(B)
        G.FillRectangle(Brushes.Black, 0, 0, PW, PH)
        Dim srcData As BitmapData = SrcB.LockBits(New Rectangle(New Point(0, 0), SrcB.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb)
        Dim BData As BitmapData = B.LockBits(New Rectangle(New Point(0, 0), B.Size), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)
        Dim srcPtr As IntPtr = srcData.Scan0
        Dim BPtr As IntPtr = BData.Scan0
        Dim x, y, i, j As Integer
        For y = 0 To srcData.Height - 1
            For x = 0 To srcData.Width - 1
                For i = 0 To Zoom - 1
                    For j = 0 To Zoom - 1
                        Marshal.WriteInt32(BPtr,
                                           (x * Zoom + (x + 1) * BoW + (x \ 3 + 1) * SpW + i + (y * Zoom + (y + 1) * BoW + (y \ 3 + 1) * SpW + j) * BData.Width) * 4,
                                           Marshal.ReadInt32(srcPtr, (x + y * srcData.Width) * 4))
                    Next
                Next
            Next
        Next
        SrcB.UnlockBits(srcData)
        B.UnlockBits(BData)
        P4.Image = B
        B.Save(Application.StartupPath & "\" & FName & ".png")
        If CheckBox3.Checked Then
            '拆分拼图
            PW = Tsp1.Value * 3 * Zoom + Tsp1.Value * 3 * BoW + Tsp1.Value * SpW
            PH = Tsp2.Value * 3 * Zoom + Tsp2.Value * 3 * BoW + Tsp2.Value * SpW
            i = 0 : j = 0
            For x = 0 To P4.Width - BoW * 3 - SpW Step PW
                For y = 0 To P4.Height - BoW * 3 - SpW Step PH
                    B = New Bitmap(PW + BoW + SpW, PH + BoW + SpW)
                    G = Graphics.FromImage(B)
                    G.DrawImage(P4.Image, -x, -y)
                    B.Save(Application.StartupPath & "\" & FName & "\" & i.ToString & "-" & j.ToString & ".PNG")
                    j += 1
                Next
                i += 1
                j = 0
            Next
        End If
        MsgBox("已保存拼图：" & vbCrLf & Application.StartupPath & "\" & FName)
    End Sub
    Dim IsMove As Boolean, MovX, MovY As Integer
    Private Sub P4_MouseDown(sender As Object, e As MouseEventArgs) Handles P4.MouseDown
        MovX = e.X
        MovY = e.Y
        IsMove = True
    End Sub

    Public Function Img2Byte(ByVal img As Bitmap) As Byte()
        Dim ms As New System.IO.MemoryStream
        img.Save(ms, Imaging.ImageFormat.Bmp)
        Dim outBytes(CInt(ms.Length - 1)) As Byte
        ms.Seek(0, System.IO.SeekOrigin.Begin)
        ms.Read(outBytes, 0, CInt(ms.Length))
        Return outBytes
    End Function

    Public Function Magnifier(srcB As Bitmap, multiple As Integer) As Bitmap
        If multiple <= 0 Then
            Return srcB
        End If
        Dim B As Bitmap = New Bitmap(srcB.Size.Width * multiple, srcB.Size.Height * multiple)
        Dim srcData As BitmapData = srcB.LockBits(New Rectangle(New Point(0, 0), srcB.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb)
        Dim BData As BitmapData = B.LockBits(New Rectangle(New Point(0, 0), B.Size), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)
        Dim srcPtr As IntPtr = srcData.Scan0
        Dim BPtr As IntPtr = BData.Scan0
        For y As Integer = 0 To srcData.Height - 1
            For x As Integer = 0 To srcData.Width - 1
                For i As Integer = 0 To multiple - 1
                    For j As Integer = 0 To multiple - 1
                        Marshal.WriteInt32(BPtr, (x * multiple + i + (y * multiple + j) * BData.Width) * 4, Marshal.ReadInt32(srcPtr, (x + y * srcData.Width) * 4))
                    Next
                Next
            Next
        Next
        srcB.UnlockBits(srcData)
        B.UnlockBits(BData)
        Return B
    End Function

    Private Sub P4_MouseUp(sender As Object, e As MouseEventArgs) Handles P4.MouseUp
        IsMove = False
    End Sub

    Private Sub P4_MouseMove(sender As Object, e As MouseEventArgs) Handles P4.MouseMove
        If IsMove Then
            P4.Left += e.X - MovX
            P4.Top += e.Y - MovY
        End If
    End Sub
End Class
