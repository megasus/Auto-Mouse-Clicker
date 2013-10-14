'#######################################
'#######################################
'##/////INFORMATION FOR THIS FORM\\\\\##
'#######################################
'#######################################
'/ Add Feature: AutoDo \



Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form17
    Private xauto2 As mouseclicker.autoclick2
    Private xform18 As mouseclicker.Form18
    Private xform19 As mouseclicker.Form19
    Private xform20 As mouseclicker.Form20

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        xform18 = New mouseclicker.Form18
        xform18.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        xform20 = New mouseclicker.Form20
        xform20.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        xauto2 = New mouseclicker.autoclick2
        xauto2.Show()
    End Sub
    Private Sub Form17_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        ' Rechteck -Größe
        Dim r As Rectangle
        With Me.ClientRectangle
            r = New Rectangle(0, 0, .Width - 1, .Height - 1)
        End With

        ' Rundung in Pixel
        Dim radius As Single = 15

        'abgerundetes Rechteck mit Farbverlauf zeichnen
        DrawRoundedRectangle(e.Graphics, r, radius, Color.Black, New LinearGradientBrush(r, Color.Gray, Color.Gray, LinearGradientMode.Vertical)) ', Color.RoyalBlue, LinearGradientMode.Vertical))
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink

        PictureBox2.BackgroundImage = My.Resources.x2
        PictureBox3.BackgroundImage = My.Resources._2
    End Sub
    Sub abrunden(ByVal was As Object, _
  ByVal x As Integer, ByVal y As Integer, _
  ByVal width As Integer, ByVal height As Integer, _
  ByVal radius As Integer)


        Dim gp As System.Drawing.Drawing2D.GraphicsPath = _
          New System.Drawing.Drawing2D.GraphicsPath()

        gp.AddLine(x + radius, y, x + width - radius, y)
        gp.AddArc(x + width - radius, y, radius, radius, 270, 90)
        gp.AddLine(x + width, y + radius, x + width, y + height - radius)
        gp.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90)
        gp.AddLine(x + width - radius, y + height, x + radius, y + height)
        gp.AddArc(x, y + height - radius, radius, radius, 90, 90)
        gp.AddLine(x, y + height - radius, x, y + radius)
        gp.AddArc(x, y, radius, radius, 180, 90)
        gp.CloseFigure()

        was.region = New System.Drawing.Region(gp)
        gp.Dispose()
    End Sub

    Public Sub DrawRoundedRectangle(ByVal g As Graphics, _
   ByVal r As Rectangle, _
   ByVal radius As Single, _
   ByVal borderColor As Color)

        ' GraphicsPath erstellen
        Dim path As GraphicsPath = RectanglePath(r, radius)

        ' Rechteck mit angerundeten Ecken zeichnen
        g.DrawPath(New Pen(borderColor), path)

        ' Ressourcen freigeben
        path.Dispose()
    End Sub

    ''' <summary>
    ''' Abgerundetes Rechteck mit Füllung zeichnen
    ''' </summary>
    ''' <param name="g">Graphics-Obkjekt, auf das die Ausgabe erfolgen soll</param>
    ''' <param name="r">Rechteck-Struktur</param>
    ''' <param name="radius">Radius der abgerundeten Ecken</param>
    ''' <param name="borderColor">Rahmenfarbe des Rechtecks</param>
    ''' <param name="fillBrush">Brush-Objekt für die Füllung</param>
    Public Sub DrawRoundedRectangle(ByVal g As Graphics, _
      ByVal r As Rectangle, _
      ByVal radius As Single, _
      ByVal borderColor As Color, _
      ByVal fillBrush As Brush)

        ' GraphicsPath erstellen
        Dim path As GraphicsPath = RectanglePath(r, radius)

        ' Füllung zeichnen
        g.FillPath(fillBrush, path)

        ' Rechteck mit angerundeten Ecken zeichnen
        g.DrawPath(New Pen(borderColor), path)

        ' Ressourcen freigeben
        path.Dispose()
    End Sub

    ''' <summary>
    ''' Hilfsfunktion: Erstellt einen GraphicsPath aus der
    ''' Größe des Rechtecks und dem angegeben Radius
    ''' </summary>
    Private Function RectanglePath(ByVal r As RectangleF, _
      ByVal radius As Single) As GraphicsPath

        ' Neues GraphicsPath-Objekt erstellen
        Dim path As New GraphicsPath
        Dim d As Single = 2 * radius

        ' Zusammensetzen des GraphicsPath 
        With path
            If radius < 1 Then
                ' keine abgerundeten Ecken
                .AddRectangle(r)
            Else
                ' Linien und Bögen erstellen
                .AddLine(r.X + radius, r.Y, r.X + r.Width - d, r.Y)
                .AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90)
                .AddLine(r.X + r.Width, r.Y + radius, r.X + r.Width, r.Y + r.Height - d)
                .AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
                .AddLine(r.X + r.Width - d, r.Y + r.Height, r.X + radius, r.Y + r.Height)
                .AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90)
                .AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + radius)
                .AddArc(r.X, r.Y, d, d, 180, 90)
            End If
            .CloseFigure()
        End With

        Return (path)
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private ptMouseDownLocation As Point





    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ptMouseDownLocation = e.Location
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = e.Location - ptMouseDownLocation + Me.Location
        End If
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Application.Exit()
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.BackgroundImage = My.Resources.x
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage = My.Resources.x2
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.BackgroundImage = My.Resources.__
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackgroundImage = My.Resources._2
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.BackgroundImage = My.Resources.x
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.BackgroundImage = My.Resources.__
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class