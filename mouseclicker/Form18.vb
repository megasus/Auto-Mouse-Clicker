'#######################################
'#######################################
'##/////INFORMATION FOR THIS FORM\\\\\##
'#######################################
'#######################################
'/ done \


Imports System.Windows.Forms
Imports System.Drawing

Public Class Form18
    Dim nStartPos As Point
    Dim nDragPos As Point
    Dim value As Integer = 0
    Dim xvalue As Integer = 0
    Dim zvalue As Integer = 0
    Dim picclicked As Integer
    '  Dim xauto2 As New mouseclicker.autoclick2


    'Dim xform20 As New mouseclicker.Form20
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

    Dim taste1 As String = 1
    Dim taste2 As String = 1
    Dim taste3 As String = 1
    Dim taste4 As String = 1
    Dim taste5 As String = 1
    Dim taste6 As String = 1
    Dim taste7 As String = 1
    Dim taste8 As String = 1
    Dim taste9 As String = 1
    Dim taste10 As String = 1
    
    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        CheckBox1.Checked = True
        Timer2.Start()
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        my.settings.bo1 = False
        my.settings.bo2 = False
        my.settings.bo3 = False
        my.settings.bo4 = False
        my.settings.bo5 = False
        my.settings.bo6 = False
        my.settings.bo7 = False
        my.settings.bo8 = False
        my.settings.bo9 = False
        my.settings.bo10 = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()
        Me.Close()
    End Sub
    Declare Function GetAsyncKeyState Lib _
"user32.dll" (ByVal nVirtKey As Keys) As Short

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.ControlKey) = -32767 Then
            xvalue = xvalue + 1
            If xvalue = 1 Then
                With PictureBox1
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo1 = True
                Label12.Text = "1/10 Mauspositionen hinzugefügt"


            ElseIf xvalue = 2 Then
                With PictureBox2
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo2 = True

                Label12.Text = "2/10 Mauspositionen hinzugefügt"
            ElseIf xvalue = 3 Then
                With PictureBox3
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo3 = True

                Label12.Text = "3/10 Mauspositionen hinzugefügt"
            ElseIf xvalue = 4 Then
                With PictureBox4
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                my.settings.bo4 = True
                zvalue = zvalue + 1

                Label12.Text = "4/10 Mauspositionen hinzugefügt"
                my.settings.bo1 = True
            ElseIf xvalue = 5 Then
                With PictureBox5
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo5 = True


                Label12.Text = "5/10 Mauspositionen hinzugefügt"
            ElseIf xvalue = 6 Then
                With PictureBox6
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo6 = True


                Label12.Text = "6/10 Mauspositionen hinzugefügt"
            ElseIf xvalue = 7 Then
                With PictureBox7
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo7 = True


                Label12.Text = "7/10 Mauspositionen hinzugefügt"
            ElseIf xvalue = 8 Then
                With PictureBox8
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo8 = True


                Label12.Text = "8/10 Mauspositionen hinzugefügt"
            ElseIf xvalue = 9 Then
                With PictureBox9
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo9 = True


                Label12.Text = "9/10 Mauspositionen hinzugefügt"
            ElseIf xvalue = 10 Then
                With PictureBox10
                    .Visible = True
                    .Location = New System.Drawing.Point(MousePosition.X - 12, MousePosition.Y - 12)
                End With
                zvalue = zvalue + 1
                my.settings.bo10 = True

                Label12.Text = "10/10 Mauspositionen hinzugefügt"

            Else
                MsgBox("Du kannst keine weiteren Positionen hinzufügen!")
                Timer1.Stop()
            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label12.Text = "0/10 Mauspositionen hinzugefügt" Then
            MsgBox("Du hast keine Mausposition hinzugefügt!")
            Me.Close()
        Else
            Timer1.Stop()
            If my.settings.bo1 = True Then
                My.Settings.pos1 = New System.Drawing.Point(PictureBox1.Location.X + 12, PictureBox1.Location.Y + 12)
                My.Settings.taste1 = taste1
            End If
            If my.settings.bo2 = True Then
                My.Settings.pos2 = New System.Drawing.Point(PictureBox2.Location.X + 12, PictureBox2.Location.Y + 12)
                My.Settings.taste2 = taste2
            End If
            If my.settings.bo3 = True Then
                My.Settings.pos3 = New System.Drawing.Point(PictureBox3.Location.X + 12, PictureBox3.Location.Y + 12)
                My.Settings.taste3 = taste3
            End If
            If my.settings.bo4 = True Then
                My.Settings.pos4 = New System.Drawing.Point(PictureBox4.Location.X + 12, PictureBox4.Location.Y + 12)
                My.Settings.taste4 = taste4
            End If
            If my.settings.bo5 = True Then
                My.Settings.pos5 = New System.Drawing.Point(PictureBox5.Location.X + 12, PictureBox5.Location.Y + 12)
                My.Settings.taste5 = taste5
            End If
            If my.settings.bo6 = True Then
                My.Settings.pos6 = New System.Drawing.Point(PictureBox6.Location.X + 12, PictureBox6.Location.Y + 12)
                My.Settings.taste6 = taste6
            End If
            If my.settings.bo7 = True Then
                My.Settings.pos7 = New System.Drawing.Point(PictureBox7.Location.X + 12, PictureBox7.Location.Y + 12)
                My.Settings.taste7 = taste7
            End If
            If my.settings.bo8 = True Then
                My.Settings.pos8 = New System.Drawing.Point(PictureBox8.Location.X + 12, PictureBox8.Location.Y + 12)
                My.Settings.taste8 = taste8
            End If
            If my.settings.bo9 = True Then
                My.Settings.pos9 = New System.Drawing.Point(PictureBox9.Location.X + 12, PictureBox9.Location.Y + 12)
                My.Settings.taste9 = taste9
            End If
            If my.settings.bo10 = True Then
                My.Settings.pos10 = New System.Drawing.Point(PictureBox10.Location.X + 12, PictureBox10.Location.Y + 12)
                My.Settings.taste10 = taste10
            End If


            Dim xform19 As New mouseclicker.Form19
            xform19.Show()
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox1.Location
            nDragPos = PictureBox1.PointToScreen(New Point(e.X, e.Y))
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 1
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox1.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox1.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If

    End Sub
    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox2.Location
            nDragPos = PictureBox2.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 2
            ContextMenuStrip1.Show(MousePosition)
        End If

    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox2.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox2.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox3.Location
            nDragPos = PictureBox3.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 3
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox3.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox3.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox4.Location
            nDragPos = PictureBox4.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 4
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox4.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox4.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox5.Location
            nDragPos = PictureBox5.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 5
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox5.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox5.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox6.Location
            nDragPos = PictureBox6.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 6
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox6.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox6.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox7.Location
            nDragPos = PictureBox7.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 7
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox7.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox7.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox8.Location
            nDragPos = PictureBox8.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 8
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox8.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox8.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox9.Location
            nDragPos = PictureBox9.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 9
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox9.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox9.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub
    Private Sub PictureBox10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = PictureBox10.Location
            nDragPos = PictureBox10.PointToScreen(New Point(e.X, e.Y))
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            picclicked = 10
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub PictureBox10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = PictureBox10.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            PictureBox10.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click

    End Sub
    Private Sub PictureBox11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox11.MouseDown
        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = Panel1.Location
            nDragPos = Panel1.PointToScreen(New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub PictureBox11_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox11.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = Panel1.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            Panel1.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If CheckBox1.Checked = True Then
            Select Case zvalue

                Case 1
                    PictureBox1.Visible = True
                    
                Case 2
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    
                Case 3
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    
                Case 4
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                   
                Case 5
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox5.Visible = True

                Case 6
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                Case 7
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                    PictureBox7.Visible = True
                Case 8
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                    PictureBox7.Visible = True
                    PictureBox8.Visible = True
                Case 9
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                    PictureBox7.Visible = True
                    PictureBox8.Visible = True
                    PictureBox9.Visible = True
                Case 10
                    PictureBox1.Visible = True
                    PictureBox2.Visible = True
                    PictureBox3.Visible = True
                    PictureBox4.Visible = True
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                    PictureBox7.Visible = True
                    PictureBox8.Visible = True
                    PictureBox9.Visible = True
                    PictureBox10.Visible = True
            End Select


        Else
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
        End If
    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'links
        Select Case picclicked

            Case 1
                taste1 = "1"
            Case 2
                taste2 = "1"
            Case 3
                taste3 = "1"
            Case 4
                taste4 = "1"
            Case 5
                taste5 = "1"
            Case 6
                taste6 = "1"
            Case 7
                taste7 = "1"
            Case 8
                taste8 = "1"
            Case 9
                taste9 = "1"
            Case 10
                taste10 = "1"
            Case Else

        End Select
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'mitte
        Select Case picclicked

            Case 1
                taste1 = "2"
            Case 2
                taste2 = "2"
            Case 3
                taste3 = "2"
            Case 4
                taste4 = "2"
            Case 5
                taste5 = "2"
            Case 6
                taste6 = "2"
            Case 7
                taste7 = "2"
            Case 8
                taste8 = "2"
            Case 9
                taste9 = "2"
            Case 10
                taste10 = "2"
            Case Else

        End Select
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        'rechts
        Select Case picclicked

            Case 1
                taste1 = "3"
            Case 2
                taste2 = "3"
            Case 3
                taste3 = "3"
            Case 4
                taste4 = "3"
            Case 5
                taste5 = "3"
            Case 6
                taste6 = "3"
            Case 7
                taste7 = "3"
            Case 8
                taste8 = "3"
            Case 9
                taste9 = "3"
            Case 10
                taste10 = "3"
            Case Else

        End Select
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class