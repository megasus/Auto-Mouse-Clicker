
'#######################################
'#######################################
'##/////INFORMATION FOR THIS FORM\\\\\##
'#######################################
'#######################################
'/ done \



Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form19
    Dim ini As New INIDatei
    Dim xbumm As Boolean = False
    Dim nummer As Integer
    Dim zvalue
    Dim goon As Boolean
    '  Dim xxform18 As New Form18


    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CheckBox1.Checked = True
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        If my.settings.bo1 = True Then
            Label2.Visible = True
            Label3.Visible = True
            TextBox1.Visible = True
        End If
        If my.settings.bo2 = True Then
            Label4.Visible = True
            Label5.Visible = True
            TextBox2.Visible = True
        End If
        If my.settings.bo3 = True Then
            Label6.Visible = True
            Label7.Visible = True
            TextBox3.Visible = True
        End If
        If my.settings.bo4 = True Then
            Label8.Visible = True
            Label9.Visible = True
            TextBox4.Visible = True
        End If
        If my.settings.bo5 = True Then
            Label10.Visible = True
            Label11.Visible = True
            TextBox5.Visible = True
        End If
        If my.settings.bo6 = True Then
            Label12.Visible = True
            Label13.Visible = True
            TextBox6.Visible = True
        End If
        If my.settings.bo7 = True Then
            Label14.Visible = True
            Label15.Visible = True
            TextBox7.Visible = True
        End If
        If my.settings.bo8 = True Then
            Label16.Visible = True
            Label17.Visible = True
            TextBox8.Visible = True
        End If
        If my.settings.bo9 = True Then
            Label18.Visible = True
            Label19.Visible = True
            TextBox9.Visible = True
        End If
        If my.settings.bo10 = True Then
            Label20.Visible = True
            Label21.Visible = True
            TextBox10.Visible = True
        End If

    End Sub
    Private Sub Form19_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

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
    Private Sub Abbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abbrechen.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            TextBox1.Text = 1
        End If
        If TextBox2.Text = Nothing Then
            TextBox2.Text = 1
        End If
        If TextBox3.Text = Nothing Then
            TextBox3.Text = 1
        End If
        If TextBox4.Text = Nothing Then
            TextBox4.Text = 1
        End If
        If TextBox5.Text = Nothing Then
            TextBox5.Text = 1
        End If
        If TextBox6.Text = Nothing Then
            TextBox6.Text = 1
        End If
        If TextBox7.Text = Nothing Then
            TextBox7.Text = 1
        End If
        If TextBox8.Text = Nothing Then
            TextBox8.Text = 1
        End If
        If TextBox9.Text = Nothing Then
            TextBox9.Text = 1
        End If
        If TextBox10.Text = Nothing Then
            TextBox10.Text = 1
        End If
        Try
            my.settings.time1 = TextBox1.Text
            my.settings.time2 = TextBox2.Text
            my.settings.time3 = TextBox3.Text
            my.settings.time4 = TextBox4.Text
            my.settings.time5 = TextBox5.Text
            my.settings.time6 = TextBox6.Text
            my.settings.time7 = TextBox7.Text
            my.settings.time8 = TextBox8.Text
            my.settings.time9 = TextBox9.Text
            my.settings.time10 = TextBox10.Text
        Catch ex As Exception
            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Data\Errorlog.txt", vbCrLf & Date.Today & " " & TimeOfDay & " : " & ex.ToString, True)
            Catch
            End Try
        End Try

        If CheckBox1.Checked = True Then
            my.settings.wiederholen = True
        Else
            my.settings.wiederholen = False
        End If
        Dim rnd As New System.Random()
        zvalue = GetRandom(1, 9999)
        Dim savename As String = InputBox("Bitte gib einen Namen für das Event ein: ", "Speichern")
        Do
            If savename = "" Then
                MsgBox("Ungültger Name! Der Name muss mindestens 1 Zeichen besitzen.", MsgBoxStyle.Critical, "Fehler")
                goon = False
                savename = InputBox("Bitte gib einen Namen für das Event ein: ", "Speichern")
            Else
                my.settings.savename = savename & "#x#" & zvalue.ToString & "#y#"
                goon = True
            End If
        Loop Until goon = True
        ini.Pfad = Application.StartupPath & "\Data\events.ini"
        Try
            ini.Pfad = Application.StartupPath & "\Data\events.ini"
            nummer = CInt(Val(ini.WertLesen("Global", "number")))
            ini.WertSchreiben("Global", "number", (nummer + 1).ToString)
            ini.WertSchreiben(my.settings.savename, "number", (nummer + 1).ToString)
            ini.WertSchreiben("event" & nummer + 1, "deleted", "no")
            ini.WertSchreiben("event" & nummer + 1, "eventtyp", "AutoKlicker")
        Catch ex As Exception
            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Data\Errorlog.txt", vbCrLf & Date.Today & " " & TimeOfDay & " : " & ex.ToString, True)
            Catch
            End Try
            ini.Pfad = Application.StartupPath & "\Data\events.ini"
            ini.WertSchreiben(my.settings.savename, "number", "1")
            ini.WertSchreiben("Global", "number", "1")
            ini.WertSchreiben("event" & nummer + 1, "deleted", "no")
            ini.WertSchreiben("event" & nummer + 1, "eventtyp", "AutoKlicker")
            nummer = 0
        End Try
        ini.WertSchreiben("event" & nummer + 1, "name", my.settings.savename)
        If my.settings.wiederholen = True Then
            ini.WertSchreiben("event" & nummer + 1, "wiederholen", "Ja")
        Else
            ini.WertSchreiben("event" & nummer + 1, "wiederholen", "Nein")
        End If
        If my.settings.bo10 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "10")
        ElseIf my.settings.bo9 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "9")
        ElseIf my.settings.bo8 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "8")
        ElseIf my.settings.bo7 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "7")
        ElseIf my.settings.bo6 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "6")
        ElseIf my.settings.bo5 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "5")
        ElseIf my.settings.bo4 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "4")
        ElseIf my.settings.bo3 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "3")
        ElseIf my.settings.bo2 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "2")
        ElseIf my.settings.bo1 = True Then
            ini.WertSchreiben("event" & nummer + 1, "klicks", "1")
        Else

        End If

        Do
            If my.settings.bo1 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location1", my.settings.pos1.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time1", My.Settings.time1.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key1", My.Settings.taste1)
                my.settings.bo1 = False
            ElseIf my.settings.bo2 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location2", my.settings.pos2.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time2", My.Settings.time2.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key2", My.Settings.taste2)
                my.settings.bo2 = False
            ElseIf my.settings.bo3 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location3", my.settings.pos3.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time3", My.Settings.time3.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key3", My.Settings.taste3)
                my.settings.bo3 = False
            ElseIf my.settings.bo4 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location4", my.settings.pos4.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time4", My.Settings.time4.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key4", My.Settings.taste4)
                my.settings.bo4 = False
            ElseIf my.settings.bo5 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location5", my.settings.pos5.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time5", My.Settings.time5.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key5", My.Settings.taste5)
                my.settings.bo5 = False
            ElseIf my.settings.bo6 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location6", my.settings.pos6.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time6", My.Settings.time6.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key6", My.Settings.taste6)
                my.settings.bo6 = False
            ElseIf my.settings.bo7 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location7", my.settings.pos7.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time7", My.Settings.time7.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key7", My.Settings.taste7)
                my.settings.bo7 = False
            ElseIf my.settings.bo8 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location8", my.settings.pos8.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time8", My.Settings.time8.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key8", My.Settings.taste8)
                my.settings.bo8 = False
            ElseIf my.settings.bo9 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location9", my.settings.pos9.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time9", My.Settings.time9.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key9", My.Settings.taste9)
                my.settings.bo9 = False
            ElseIf my.settings.bo10 = True Then
                ini.WertSchreiben("event" & nummer + 1, "location10", my.settings.pos10.ToString)
                ini.WertSchreiben("event" & nummer + 1, "time10", My.Settings.time10.ToString)
                ini.WertSchreiben("event" & nummer + 1, "key10", My.Settings.taste10)
                my.settings.bo10 = False
            Else
                xbumm = True
            End If
        Loop Until xbumm = True
        Dim xform20 As New mouseclicker.Form20
        xform20.Show()
        Me.Close()
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
    Public Function GetRandom(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Try
            Dim nRandom As Integer

            Randomize()
            nRandom = CInt(minimum + (maximum - minimum + 1) * Rnd())

            While nRandom < minimum OrElse nRandom > maximum
                Randomize()
                nRandom = CInt(minimum + (maximum - minimum + 1) * Rnd())
            End While

            Return nRandom
        Catch ex As Exception
            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Data\Errorlog.txt", vbCrLf & Date.Today & " " & TimeOfDay & " : " & ex.ToString, True)
            Catch
            End Try
            Return minimum
        End Try

    End Function
End Class