Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Public Class autoclick



    Dim pos1 As System.Drawing.Point
    Dim pos2 As System.Drawing.Point
    Dim pos3 As System.Drawing.Point
    Dim pos4 As System.Drawing.Point
    Dim pos5 As System.Drawing.Point
    Dim pos6 As System.Drawing.Point
    Dim pos7 As System.Drawing.Point
    Dim pos8 As System.Drawing.Point
    Dim pos9 As System.Drawing.Point
    Dim pos10 As System.Drawing.Point
    Dim time1 As Integer
    Dim time2 As Integer
    Dim time3 As Integer
    Dim time4 As Integer
    Dim time5 As Integer
    Dim time6 As Integer
    Dim time7 As Integer
    Dim time8 As Integer
    Dim time9 As Integer
    Dim time10 As Integer
    Dim taste1 As String
    Dim taste2 As String
    Dim taste3 As String
    Dim taste4 As String
    Dim taste5 As String
    Dim taste6 As String
    Dim taste7 As String
    Dim taste8 As String
    Dim taste9 As String
    Dim taste10 As String
    Dim xname As String
    Dim red As String
    Dim red2 As String
    Dim ini As New INIDatei
    Dim part() As String
    Dim wiederholen As Boolean = True
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



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.ControlKey) = -32767 Then
            Timer2.Start()
            click1.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If GetAsyncKeyState(Keys.ControlKey) = -32767 Then

            click1.Stop()
            click2.Stop()
            click3.Stop()
            click4.Stop()
            click5.Stop()
            click6.Stop()
            click7.Stop()
            click8.Stop()
            click9.Stop()
            click10.Stop()

            Me.Close()
            Timer2.Stop()
        End If
    End Sub

    Private Sub autoclick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pos1 = Nothing
        pos2 = Nothing
        pos3 = Nothing
        pos4 = Nothing
        pos5 = Nothing
        pos6 = Nothing
        pos7 = Nothing
        pos8 = Nothing
        pos9 = Nothing
        pos10 = Nothing
        time1 = Nothing
        time2 = Nothing
        time3 = Nothing
        time4 = Nothing
        time5 = Nothing
        time6 = Nothing
        time7 = Nothing
        time8 = Nothing
        time9 = Nothing
        time10 = Nothing
        taste1 = Nothing
        taste2 = Nothing
        taste3 = Nothing
        taste4 = Nothing
        taste5 = Nothing
        taste6 = Nothing
        taste7 = Nothing
        taste8 = Nothing
        taste9 = Nothing
        taste10 = Nothing
        Try
            ini.Pfad = Application.StartupPath & "\Data\events.ini"
            ' Dim xnummer As String = ini.WertLesen("event" & my.settings.eventid, "klicks")
            Dim xnummer As Integer = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "klicks")))
            If ini.WertLesen("event" & My.Settings.eventid, "wiederholen") = "Ja" Then
                wiederholen = True
            Else
                wiederholen = False
            End If
            Do
                Select Case xnummer
                    Case 1
                        red = ini.WertLesen("event" & My.Settings.eventid, "location1")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos1 = New System.Drawing.Point(part(3), part(6))
                        time1 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time1")))
                        taste1 = ini.WertLesen("event" & My.Settings.eventid, "key1")
                        xnummer = xnummer - 1
                        click1.Interval = time1
                    Case 2
                        red = ini.WertLesen("event" & My.Settings.eventid, "location2")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos2 = New System.Drawing.Point(part(3), part(6))
                        time2 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time2")))
                        taste2 = ini.WertLesen("event" & My.Settings.eventid, "key2")
                        xnummer = xnummer - 1
                        click2.Interval = time2
                    Case 3
                        red = ini.WertLesen("event" & My.Settings.eventid, "location3")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos3 = New System.Drawing.Point(part(3), part(6))
                        time3 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time3")))
                        taste3 = ini.WertLesen("event" & My.Settings.eventid, "key3")
                        xnummer = xnummer - 1
                        click3.Interval = time3
                    Case 4
                        red = ini.WertLesen("event" & My.Settings.eventid, "location4")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos4 = New System.Drawing.Point(part(3), part(6))
                        time4 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time4")))
                        taste4 = ini.WertLesen("event" & My.Settings.eventid, "key4")
                        xnummer = xnummer - 1
                        click4.Interval = time4
                    Case 5
                        red = ini.WertLesen("event" & My.Settings.eventid, "location5")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos5 = New System.Drawing.Point(part(3), part(6))
                        time5 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time5")))
                        taste5 = ini.WertLesen("event" & My.Settings.eventid, "key5")
                        xnummer = xnummer - 1
                        click5.Interval = time5
                    Case 6
                        red = ini.WertLesen("event" & My.Settings.eventid, "location6")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos6 = New System.Drawing.Point(part(3), part(6))
                        time6 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time6")))
                        taste6 = ini.WertLesen("event" & My.Settings.eventid, "key6")
                        xnummer = xnummer - 1
                        click6.Interval = time6
                    Case 7
                        red = ini.WertLesen("event" & My.Settings.eventid, "location7")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos7 = New System.Drawing.Point(part(3), part(6))
                        time7 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time7")))
                        taste7 = ini.WertLesen("event" & My.Settings.eventid, "key7")
                        xnummer = xnummer - 1
                        click7.Interval = time7
                    Case 8
                        red = ini.WertLesen("event" & My.Settings.eventid, "location8")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos8 = New System.Drawing.Point(part(3), part(6))
                        time8 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time8")))
                        taste8 = ini.WertLesen("event" & My.Settings.eventid, "key8")
                        xnummer = xnummer - 1
                        click8.Interval = time8
                    Case 9
                        red = ini.WertLesen("event" & My.Settings.eventid, "location9")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos9 = New System.Drawing.Point(part(3), part(6))
                        time9 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time9")))
                        taste9 = ini.WertLesen("event" & My.Settings.eventid, "key9")
                        xnummer = xnummer - 1
                        click9.Interval = time9
                    Case 10
                        red = ini.WertLesen("event" & My.Settings.eventid, "location10")
                        part = red.Split(New Char() {"{"c, "}"c, "="c, "X"c, "Y"c, ","c})
                        pos10 = New System.Drawing.Point(part(3), part(6))
                        time10 = CInt(Val(ini.WertLesen("event" & My.Settings.eventid, "time10")))
                        taste10 = ini.WertLesen("event" & My.Settings.eventid, "key10")
                        xnummer = xnummer - 1
                        click10.Interval = time10
                    Case Else
                        xnummer = 0
                End Select

            Loop Until xnummer = 0

            Timer1.Start()
        Catch ex As Exception
            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Data\Errorlog.txt", vbCrLf & Date.Today & " " & TimeOfDay & " : " & ex.ToString, True)
            Catch
            End Try
        End Try

    End Sub


    Private Sub click1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click1.Tick
        Cursor.Position = pos1
        Select Case taste1
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select

        If pos2 = Nothing Then
            If wiederholen = True Then

            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click1.Stop()
            End If
        Else

            click2.Start()
            click1.Stop()
        End If
    End Sub

    Private Sub click2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click2.Tick
        Cursor.Position = pos2
        Select Case taste2
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos3 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click2.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click2.Stop()
            End If
        Else
            click3.Start()
            click2.Stop()
        End If
    End Sub

    Private Sub click3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click3.Tick
        Cursor.Position = pos3
        Select Case taste3
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos4 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click3.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click3.Stop()
            End If
        Else
            click4.Start()
            click3.Stop()
        End If
    End Sub

    Private Sub click4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click4.Tick
        Cursor.Position = pos4
        Select Case taste4
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos5 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click4.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click4.Stop()
            End If
        Else
            click5.Start()
            click4.Stop()
        End If
    End Sub

    Private Sub click5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click5.Tick
        Cursor.Position = pos5
        Select Case taste5
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos6 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click5.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click5.Stop()
            End If
        Else
            click6.Start()
            click5.Stop()
        End If
    End Sub

    Private Sub click6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click6.Tick
        Cursor.Position = pos6
        Select Case taste6
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos7 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click6.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click6.Stop()
            End If
        Else
            click7.Start()
            click6.Stop()
        End If
    End Sub

    Private Sub click7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click7.Tick
        Cursor.Position = pos7
        Select Case taste7
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos8 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click7.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click7.Stop()
            End If
        Else
            click8.Start()
            click7.Stop()
        End If
    End Sub

    Private Sub click8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click8.Tick
        Cursor.Position = pos8
        Select Case taste8
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos9 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click8.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click8.Stop()
            End If
        Else
            click9.Start()
            click8.Stop()
        End If
    End Sub

    Private Sub click9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click9.Tick
        Cursor.Position = pos9
        Select Case taste9
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select
        If pos10 = Nothing Then
            If wiederholen = True Then
                click1.Start()
                click9.Stop()
            Else
                MsgBox("Event beendet!")
                Timer2.Stop()
                Me.Close()
                click9.Stop()
            End If
        Else
            click10.Start()
            click9.Stop()
        End If
    End Sub

    Private Sub click10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles click10.Tick
        Cursor.Position = pos10
        Select Case taste10
            Case "1"
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Case "2"
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0)
            Case "3"
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
            Case Else
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        End Select

        If wiederholen = True Then
            click1.Start()
            click10.Stop()
        Else
            MsgBox("Event beendet!")
            Timer2.Stop()
            Me.Close()
            click10.Stop()
        End If

    End Sub
End Class