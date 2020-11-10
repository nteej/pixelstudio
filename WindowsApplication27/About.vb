Public Class About

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/dushan.pramod")

    End Sub
End Class