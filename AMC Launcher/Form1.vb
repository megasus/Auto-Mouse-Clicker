Imports System.Net

Public Class Form1
    Private xform As mouseclicker.Form17
    Dim version = "120"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Try
            Dim client100 As New WebClient
            Dim quellcode100 As String = client100.DownloadString("http://wowgeslauncher.bplaced.net/filemanager/Auto Clicker/version.html")
            Dim anfang100 As String = "<version>"
            Dim ende100 As String = "</version>"
            Dim quellcodeSplit100 As String
            quellcodeSplit100 = Split(quellcode100, anfang100, 5)(1)
            quellcodeSplit100 = Split(quellcodeSplit100, ende100, 6)(0)
            If version = quellcodeSplit100 Then
                xform = New mouseclicker.Form17
                xform.Show()
                ' Me.Close()
            Else
                Me.WindowState = FormWindowState.Normal
                Me.MaximumSize = Me.Size
                Me.MinimumSize = Me.Size
                Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            End If
        Catch ex As Exception
            xform = New mouseclicker.Form17
            xform.Show()
            '  Me.Close()
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        xform = New mouseclicker.Form17
        xform.Show()
        '  Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim client100 As New WebClient
            Dim quellcode100 As String = client100.DownloadString("http://wowgeslauncher.bplaced.net/filemanager/Auto Clicker/version.html")
            Dim anfang100 As String = "<link>"
            Dim ende100 As String = "</link>"
            Dim quellcodeSplit100 As String
            quellcodeSplit100 = Split(quellcode100, anfang100, 5)(1)
            quellcodeSplit100 = Split(quellcodeSplit100, ende100, 6)(0)
            Process.Start(quellcodeSplit100)
            Me.Close()
        Catch ex As Exception
            xform = New mouseclicker.Form17
            xform.Show()
            ' Me.Close()
        End Try
    End Sub
End Class
