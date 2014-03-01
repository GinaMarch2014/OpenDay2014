Public Class Form1
    Dim urls = New String() {"https://www.youtube.com/v/yAXnYcUjn5k&cc_load_policy=1&autohide=1&autoplay=1&fs=1&iv_load_policy=3&rel=0& showinfo=0& hd=1",
                          "https://www.youtube.com/v/BmFEoCFDi-w#t=13&cc_load_policy=1&autohide=1&autoplay=1&fs=1&iv_load_policy=3&rel=0& showinfo=0& hd=1",
                          "https://www.youtube.com/v/9mcuIc5O-DE#t=146&cc_load_policy=1&autohide=1&autoplay=1&fs=1&iv_load_policy=3&rel=0& showinfo=0& hd=1"}

    Private Sub play(url As String)
        TabControl1.SelectTab(2)
        WebBrowser1.Navigate(url)
    End Sub

    Sub toSecondTab()
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        toSecondTab()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        play(urls(0))
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        play(urls(1))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        play(urls(2))
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                toSecondTab()
            Case Keys.A
                play(urls(0))
            Case Keys.S
                play(urls(1))
            Case Keys.D
                play(urls(2))
        End Select
    End Sub
End Class
