Public Class Form1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(2)
        WebBrowser1.Navigate("https://www.youtube.com/v/yAXnYcUjn5k&cc_load_policy=1&autohide=1&autoplay=1&fs=1&iv_load_policy=3&rel=0& showinfo=0& hd=1")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectTab(2)
        WebBrowser1.Navigate("https://www.youtube.com/v/BmFEoCFDi-w#t=13&cc_load_policy=1&autohide=1&autoplay=1&fs=1&iv_load_policy=3&rel=0& showinfo=0& hd=1")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(3)
        WebBrowser1.Navigate("https://www.youtube.com/v/9mcuIc5O-DE#t=146&cc_load_policy=1&autohide=1&autoplay=1&fs=1&iv_load_policy=3&rel=0& showinfo=0& hd=1")
    End Sub
End Class
