'#######################################
'#######################################
'##/////INFORMATION FOR THIS FORM\\\\\##
'#######################################
'#######################################
'/ key combinations \
'/ shift key not working \
'/ # key not working \
'/ detect case-sensitive \
'/ < key not working \
'/ ^ key not working \
'/ escape key not working \
'/ ´ key not working \
'/ ALT key not working \
'/ STRG key not working \
'/ some more keys needs to be tested \
'/ revise form style \
'/ add insert name \
'/ last mouse click has to been removed \
'/ key hook locks the key \

Option Explicit On
'Option Strict On
Imports System.Windows.Forms
Imports System.Diagnostics.Process
Public Class Form1
    Private Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer
    Private Declare Sub UnregisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer)
    Private Const Key_NONE As Integer = &H0
    Private Const WM_HOTKEY As Integer = &H312

    Dim xintervall As Integer = 0
    Dim oldintervall As Integer = 0
    Dim xtime As Integer = 0
    Dim xevent As Integer = 0
    Dim ini As New INIDatei
    Dim checkwert As Integer = 0
    Dim active As Boolean = False
    Dim nummer As Integer
    Dim startit As Boolean = False
    Private Declare Function GetAsyncKeyState Lib "user32" ( _
  ByVal vKey As Long) As Integer

    Private Const VK_LBUTTON = &H1
    Private Const VK_RBUTTON = &H2
    Private Const VK_MBUTTON = &H4
#Region "API Functions And Structures"
    Dim TotalString As String
    Dim GlobalFileName As String
    Dim objStreamWriter As IO.StreamWriter
    ' Keylogger Declarations
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    ' End of Declarations
#End Region
    Protected Overrides Sub WndProc(ByRef m As Message)
        'die messages auswerten
        If m.Msg = WM_HOTKEY Then
            'hier wird entschieden welcher hotkey es war
            'einfach die übergebene id auswerten
            If startit = False Then

            Else
                Select Case m.WParam
                    Case 1
                        '^^
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "^")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 2
                        ' ß
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "ß")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 3
                        ' ´´
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "´")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 4
                        ' #
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "#")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 5
                        ' <
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "<")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 6
                        ' ü
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "ü")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 7
                        ' ä
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "ä")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 8
                        ' ö
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "ö")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    Case 9
                        ' escape
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "escape")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                End Select
            End If

        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        Dim Temp As Char
        Dim SpChar As String

        Try
            ' Iterate through all possible ascii values looking for a keydown event.
            For i = 8 To 190
                Dim result As Integer = 0
                ' Gets the keystate of the current key.
                result = GetAsyncKeyState(i)

                ' When a keydown event is detected (result = -32767)
                If result = -32767 Then
                    Temp = Chr(i)

                    If i = 8 Then

                        Temp = Nothing
                    ElseIf i = 13 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{ENTER}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '    MsgBox("Enter " & Temp & " " & i)
                    ElseIf i = 16 Then
                        '### buggy ###
                        '  xtime = xintervall - oldintervall
                        '    oldintervall = xintervall
                        '    ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{Enter}")
                        '    ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '    MsgBox("Shift gedrückt! " & Temp & " " & i)
                    ElseIf i = 18 Then
                        ' ### buggy ###
                        '  xtime = xintervall - oldintervall
                        '  oldintervall = xintervall
                        '    ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{ENTER}")
                        '    ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '  MsgBox("Alt gedrückt! " & Temp & " " & i)
                    ElseIf i = 19 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{BREAK}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    ElseIf i = 38 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{UP}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    ElseIf i = 40 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{DOWN}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                    ElseIf i = 107 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{ADD}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '    MsgBox("+ (num) " & Temp & " " & i)
                    ElseIf i = 106 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{MULTIPLY}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '    MsgBox("* (num) " & Temp & " " & i)
                    ElseIf i = 111 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{DIVIDE}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '   MsgBox("/ (num) " & Temp & " " & i)
                    ElseIf i = 109 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{SUBTRACT}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '  MsgBox("- (num) " & Temp & " " & i)
                    ElseIf i = 110 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, ",")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '  MsgBox(", (num) " & Temp & " " & i)
                    ElseIf i = 144 Then

                        ' 2 x , ????
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "numlock")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '   MsgBox(", (numtwit) " & Temp & " " & i)
                    ElseIf i = 187 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "+")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '   MsgBox("+ gedrückt " & Temp & " " & i)
                    ElseIf i > 95 And i < 106 Then ' Test to see if i is an Asii Number
                        ' ### needs to be tested ###
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        Temp = Chr(i - 48)
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, Temp)
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        ' MsgBox(Temp & " " & i)


                    ElseIf Chr(i) = "" Then ' remove strange character

                        Temp = Nothing

                    ElseIf i = 189 AndAlso My.Computer.Keyboard.ShiftKeyDown Then ' Tests for "_" character
                        ' ### needs to be tested ###
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "_")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        'MsgBox("_ " & i)
                    ElseIf Chr(i) = Chr(189) Then
                        ' ### needs to be tested ###
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "-")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '   MsgBox("- " & i)
                    ElseIf i > 128 Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        Temp = CType(ConvertPunc(i), Char) ' Converts punctuation from Ascii code
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, Temp)
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '     MsgBox(Temp & " " & i)
                    ElseIf My.Computer.Keyboard.CapsLock Then
                        ' ### needs to be tested ###
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{CAPSLOCK}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '   MsgBox(Temp & " " & i)
                    ElseIf Chr(i) = Chr(16) Then

                        Temp = Nothing
                    ElseIf My.Computer.Keyboard.ShiftKeyDown Then ' Converts keyboard event
                        ' ### buggy ###
                        '    xtime = xintervall - oldintervall
                        '     oldintervall = xintervall
                        '   Temp = ConvertChar(Temp)
                        '    MsgBox(Temp & " " & i)
                    ElseIf Chr(i) = Chr(9) Then
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        SpChar = "[Tab]"
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, "{TAB}")
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        'MsgBox(SpChar & " " & i)
                    ElseIf Not Char.IsUpper(Temp) AndAlso Not Temp = " " AndAlso Not Char.IsNumber(Temp) Then
                        SpChar = SpecialKeyConvert(Temp)
                        If Not SpChar = Nothing Then
                            'TxtBTest.Text = TxtBTest.Text
                            xevent = xevent + 1
                            xtime = xintervall - oldintervall
                            oldintervall = xintervall
                            ini.WertSchreiben("nonamed", "key" & xevent.ToString, SpChar)
                            ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                            '   MsgBox(SpChar & " " & i)
                        End If
                        ' ### no need? ###
                        '      ElseIf Chr(i) = Chr(13) Then ' Adds return carriage
                        '        xtime = xintervall - oldintervall
                        '     oldintervall = xintervall
                        '       MsgBox("neue zeile " & Temp & " " & i)
                    Else
                        xevent = xevent + 1
                        xtime = xintervall - oldintervall
                        oldintervall = xintervall
                        Temp = Char.ToLower(Temp)
                        DoReplaceNum(Temp)
                        ini.WertSchreiben("nonamed", "key" & xevent.ToString, Temp)
                        ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                        '  MsgBox(Temp & " " & i)
                    End If

                    ' you can set your own password to show the interface currently is you type
                    ' showinterce337 into any application while the app is running, the interface will show up.

                Else
                    If active = False Then
                        If CBool(GetAsyncKeyState(VK_LBUTTON)) Then
                            xevent = xevent + 1
                            checkwert = 0
                            active = True
                            ini.WertSchreiben("nonamed", "key" & xevent.ToString, "leftmouse")
                            ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                            ini.WertSchreiben("nonamed", "location" & xevent.ToString, MousePosition.ToString)
                            '   MsgBox("linke Maustaste")
                        ElseIf CBool(GetAsyncKeyState(VK_RBUTTON)) Then
                            xevent = xevent + 1
                            checkwert = 0
                            active = True
                            ini.WertSchreiben("nonamed", "key" & xevent.ToString, "rightmouse")
                            ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                            ini.WertSchreiben("nonamed", "location" & xevent.ToString, MousePosition.ToString)
                            '   MsgBox("rechte Maustaste")
                        ElseIf CBool(GetAsyncKeyState(VK_MBUTTON)) Then
                            xevent = xevent + 1
                            checkwert = 0
                            active = True
                            ini.WertSchreiben("nonamed", "key" & xevent.ToString, "middlemouse")
                            ini.WertSchreiben("nonamed", "time" & xevent.ToString, xtime.ToString)
                            ini.WertSchreiben("nonamed", "location" & xevent.ToString, MousePosition.ToString)
                            '  MsgBox("mittlere Maustaste")
                        Else

                        End If
                    Else
                        checkwert = checkwert + 1
                        If checkwert > 4000 Then
                            active = False
                        End If
                    End If




                End If
            Next

        Catch 'ex As Exception

        End Try
    End Sub

    Function ConvertPunc(ByVal Value As Integer) As String
        If Value = 190 Then
            Return "."
        ElseIf Value = 188 Then
            Return ","
        ElseIf Value = 162 Then
            Return "[Ctrl]"
        Else
            Return Nothing
        End If
    End Function
    Private Function GetActiveWindowText() As String
        Dim MyStr As String
        MyStr = New String(Chr(0), 100)
        MyStr = MyStr.Substring(0, InStr(MyStr, Chr(0)) - 1)
        Return MyStr
    End Function

    Public Function ConvertChar(ByVal CharMe As Char) As Char
        If CharMe = CType("1", Char) Then
            Return CType("!", Char)
        ElseIf CharMe = CType("2", Char) Then
            Return CType("@", Char)
        ElseIf CharMe = CType("3", Char) Then
            Return CType("#", Char)
        ElseIf CharMe = CType("4", Char) Then
            Return CType("$", Char)
        ElseIf CharMe = CType("5", Char) Then
            Return CType("%", Char)
        ElseIf CharMe = CType("6", Char) Then
            Return CType("^", Char)
        ElseIf CharMe = CType("7", Char) Then
            Return CType("&", Char)
        ElseIf CharMe = CType("8", Char) Then
            Return CType("*", Char)
        ElseIf CharMe = CType("9", Char) Then
            Return CType("(", Char)
        ElseIf CharMe = CType("0", Char) Then
            Return CType(")", Char)
        ElseIf CharMe = Chr(189) Then
            Return CType("_", Char)
        End If
        Return CharMe
    End Function

    Public Function SpecialKeyConvert(ByVal CharMe As Char) As String
        If CharMe = "p" Then
            Return "{F1}"
        ElseIf CharMe = "q" Then
            Return "{F2}"
        ElseIf CharMe = "r" Then
            Return "{F3}"
        ElseIf CharMe = "s" Then
            Return "{F4}"
        ElseIf CharMe = "t" Then
            Return "{F5}"
        ElseIf CharMe = "u" Then
            Return "{F6}"
        ElseIf CharMe = "v" Then
            Return "{F7}"
        ElseIf CharMe = "w" Then
            Return "{F8}"
        ElseIf CharMe = "x" Then
            Return "{F9}"
        ElseIf CharMe = "y" Then
            Return "{F10}"
        ElseIf CharMe = "z" Then
            Return "{F11}"
        ElseIf CharMe = "{" Then
            Return "{F12}"
            ' ### buggy ###
            '    ElseIf CharMe = "&" Then
            '       Return "[^]"
            '   ElseIf CharMe = "(" Then
            '    Return "[v]"
        ElseIf CharMe = "%" Then
            Return "{LEFT}"
        ElseIf CharMe = "'" Then
            Return "{RIGHT}"
        ElseIf CharMe = Chr(34) Then
            Return "{PGDN}"
        ElseIf CharMe = "!" Then
            Return "{PGUP}"
        ElseIf CharMe = "#" Then
            Return "{END}"
        ElseIf CharMe = "$" Then
            Return "{HOME}"
        ElseIf CharMe = "." Then
            Return "{DELETE}"
            ' ### buggy ###
            ' ElseIf CharMe = "[" Then
            '    Return "[WINDOWS KEY]"
            ' ElseIf CharMe = "]" Then
            '    Return "[MENU KEY]"
        Else
            Return Nothing
        End If
        Return CharMe

    End Function
    Public Function ReplaceValues(ByVal Value As String) As String
        With Value
            Value = .Replace("a", "1")
            Value = .Replace("b", "2")
            Value = .Replace("c", "3")
            Value = .Replace("d", "4")
            Value = .Replace("e", "5")
            Value = .Replace("f", "6")
            Value = .Replace("g", "7")
            Value = .Replace("h", "8")
            Value = .Replace("i", "9")
            Value = .Replace("`", "0")
        End With

        Return Value

    End Function
    Private Sub DoReplaceNum(ByVal Character As Char)
        Dim Temp(2) As String
        TotalString = TotalString + Character
        ' After String is equal to line width, write line
        ' to file, clear string
        If TotalString.Length > 16 Then
            TotalString = TotalString.Remove(0, 1)
        End If
        TotalString = ReplaceValues(TotalString)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UnregisterHotKey(Me.Handle, 1)
        UnregisterHotKey(Me.Handle, 2)
        UnregisterHotKey(Me.Handle, 3)
        UnregisterHotKey(Me.Handle, 4)
        UnregisterHotKey(Me.Handle, 5)
        UnregisterHotKey(Me.Handle, 6)
        UnregisterHotKey(Me.Handle, 7)
        UnregisterHotKey(Me.Handle, 8)
        UnregisterHotKey(Me.Handle, 9)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RegisterHotKey(Me.Handle, 1, Key_NONE, Keys.Oem5)
        RegisterHotKey(Me.Handle, 2, Key_NONE, Keys.OemOpenBrackets)
        RegisterHotKey(Me.Handle, 3, Key_NONE, Keys.Oem6)
        RegisterHotKey(Me.Handle, 4, Key_NONE, Keys.OemQuestion)
        RegisterHotKey(Me.Handle, 5, Key_NONE, Keys.OemBackslash)
        RegisterHotKey(Me.Handle, 6, Key_NONE, Keys.Oem1)
        RegisterHotKey(Me.Handle, 7, Key_NONE, Keys.Oem7)
        RegisterHotKey(Me.Handle, 8, Key_NONE, Keys.Oemtilde)
        RegisterHotKey(Me.Handle, 9, Key_NONE, Keys.Escape)

        Call GetAsyncKeyState(VK_LBUTTON)
        ini.Pfad = Application.StartupPath & "\Data\events.ini"
        ini.WertSchreiben("nonamed", "active", "ontest")

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        xintervall = xintervall + 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xyname As String = InputBox("Gebe bitte einen Namen für das Event ein!", "Achtung")
        Dim xgoon As Boolean = False
        Do
            If xyname = Nothing Then
                MsgBox("Der Name ist ungültig!", MsgBoxStyle.Critical, "Fehler")
                xgoon = False
            Else
                Dim TextDateiInhalte As String
                Dim rnd As New System.Random()
                Dim zvalue = GetRandom(1, 9999)
                Using myReader As New System.IO.StreamReader(Application.StartupPath & "\Data\Events.ini")
                    TextDateiInhalte = myReader.ReadToEnd
                End Using

                TextDateiInhalte = TextDateiInhalte.Replace("nonamed", xyname & "#x#" & zvalue.ToString & "#y#")

                Using myWriter As New System.IO.StreamWriter("c:\TextDateiName.txt", False)
                    myWriter.Write(TextDateiInhalte)
                End Using
                xgoon = True
            End If

        Loop Until xgoon = True
        Try
            ini.Pfad = Application.StartupPath & "\Data\events.ini"
            nummer = CInt(Val(ini.WertLesen("Global", "number")))
            ini.WertSchreiben("Global", "number", (nummer + 1).ToString)
            ini.WertSchreiben(My.Settings.savename, "number", (nummer + 1).ToString)
            ini.WertSchreiben("event" & nummer + 1, "deleted", "no")
            ini.WertSchreiben("event" & nummer + 1, "eventtyp", "AutoDo")
        Catch ex As Exception
            Try
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Data\Errorlog.txt", vbCrLf & Date.Today & " " & TimeOfDay & " : " & ex.ToString, True)
            Catch
            End Try
            ini.Pfad = Application.StartupPath & "\Data\events.ini"
            ini.WertSchreiben(My.Settings.savename, "number", "1")
            ini.WertSchreiben("Global", "number", "1")
            ini.WertSchreiben("event" & nummer + 1, "deleted", "no")
            ini.WertSchreiben("event" & nummer + 1, "eventtyp", "AutoDo")
            nummer = 0
        End Try

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("start in 3 sekunden")
        Timer3.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ini.SektionLöschen("nonamed")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Stop()
        Timer2.Stop()
        ini.SchlüsselLöschen("nonamed", "key" & xevent.ToString)
        ini.SchlüsselLöschen("nonamed", "location" & xevent.ToString)
        ini.SchlüsselLöschen("nonamed", "time" & xevent.ToString)
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        startit = True
        Timer1.Start()
        Timer2.Start()
    End Sub
End Class