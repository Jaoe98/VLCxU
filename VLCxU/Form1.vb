Imports LibVLCSharp.Shared

Public Class Form1
    Dim FullScreen As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

        Core.Initialize()
        Dim LibVLC As New LibVLC()

        VideoView1.MediaPlayer = New MediaPlayer(New Media(LibVLC, "C:\Users\Julian\Desktop\Univalle\2020-08-20 07-07-00.mp4"))
        VideoView1.MediaPlayer.Play()
        VideoView1.MediaPlayer.Time = 10000
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "1" Then
            VideoView1.MediaPlayer.SetRate(1)
        End If
        If e.KeyChar = "2" Then
            VideoView1.MediaPlayer.SetRate(2)
        End If
        If e.KeyChar = "3" Then
            VideoView1.MediaPlayer.SetRate(3)
        End If
    End Sub

    Private Sub VideoView1_Click(sender As Object, e As EventArgs) Handles VideoView1.Click

    End Sub

    Private Sub VideoView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VideoView1.KeyPress
        If e.KeyChar = "1" Then
            VideoView1.MediaPlayer.SetRate(1)
        End If
        If e.KeyChar = "2" Then
            VideoView1.MediaPlayer.SetRate(2)
        End If
        If e.KeyChar = "3" Then
            VideoView1.MediaPlayer.SetRate(3)
        End If
        If e.KeyChar = "4" Then
            VideoView1.MediaPlayer.SetRate(4)
        End If
        If e.KeyChar = "5" Then
            VideoView1.MediaPlayer.SetRate(5)
        End If
        If e.KeyChar = "6" Then
            VideoView1.MediaPlayer.SetRate(3.5)
        End If


        If e.KeyChar = "7" Then
            If Not FullScreen Then
                Me.FormBorderStyle = FormBorderStyle.None
                Me.WindowState = FormWindowState.Maximized
                VideoView1.Size = New Size(1920, 1080)
                FullScreen = True
            Else
                Me.FormBorderStyle = FormBorderStyle.Sizable
                Me.WindowState = FormWindowState.Normal
                VideoView1.Size = New Size(1033, 613)
                FullScreen = False
            End If
        End If
    End Sub

    Private Sub VideoView1_KeyDown(sender As Object, e As KeyEventArgs) Handles VideoView1.KeyDown
        If e.KeyCode = Keys.Space Then
            If VideoView1.MediaPlayer.IsPlaying Then
                VideoView1.MediaPlayer.Pause()
            Else
                VideoView1.MediaPlayer.Play()
            End If
        End If

        If e.KeyCode = Keys.D Then
            VideoView1.MediaPlayer.Time += 5000
        End If
        If e.KeyCode = Keys.A Then
            VideoView1.MediaPlayer.Time -= 5000
        End If

    End Sub
End Class
