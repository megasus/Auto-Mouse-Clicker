Imports System.Drawing
Imports System.Windows.Forms
Public Class autoclick2
    Dim time As Integer
    Dim nStartPos As Point
    Dim nDragPos As Point
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Long
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Long
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Public Const MOUSEEVENTF_LEFTUP = &H4 ' left button up
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20 ' middle button down
    Public Const MOUSEEVENTF_MIDDLEUP = &H40 ' middle button up
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8 ' right button down
    Public Const MOUSEEVENTF_RIGHTUP = &H10 ' right button up
    Dim mausPosition As New Point(100, 100) 'in Pixeln, z.B. (550, 680)
    Declare Function GetAsyncKeyState Lib _
"user32.dll" (ByVal nVirtKey As Keys) As Short
    Private Sub autoclick2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.ControlKey) = -32767 Then
            Timer2.Start()
            Timer3.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If GetAsyncKeyState(Keys.ControlKey) = -32767 Then

            Timer3.Stop()
            MsgBox("Event beendet!")
            Me.Close()
            Timer2.Stop()
        End If
        If GetAsyncKeyState(Keys.Add) = -32767 Then
            If Timer3.Interval > 50 Then
                Timer3.Interval = Timer3.Interval - 50
            Else

            End If

        End If
        If GetAsyncKeyState(Keys.Subtract) = -32767 Then
            Timer3.Interval = Timer3.Interval + 50
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If RadioButton1.Checked = True Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        ElseIf RadioButton3.Checked = True Then
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
        Else
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            time = CInt(Val(TextBox1.Text))
            If time = Nothing Then
                time = 1

            Else
                Timer3.Interval = time
                MsgBox("Führe die Maus an die Stelle an der ""geklickt"" werden soll. Die ""Strg""-Taste startet und beendet das Event!" & vbCrLf & "Mit der ""+"" und ""-""-Taste kann man das Intervall regulieren!")
                Me.WindowState = FormWindowState.Minimized
                Timer4.Stop()
                Timer1.Start()
            End If
        Catch ex As Exception
            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Data\Errorlog.txt", vbCrLf & Date.Today & " " & TimeOfDay & " : " & ex.ToString, True)
            Catch
            End Try
            Me.Close()
        End Try
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            RadioButton3.Checked = False
        ElseIf RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            RadioButton3.Checked = False
        ElseIf RadioButton3.Checked = True Then
            RadioButton2.Checked = False
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub PictureBox11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox11.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = Me.Location
            nDragPos = Me.PointToScreen(New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub PictureBox11_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox11.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = Me.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            Me.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click

    End Sub
End Class