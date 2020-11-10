Public Class Modulator
    Dim TBox As TextBox

    Dim TBoxList As New List(Of TextBox)
    Private Sub Modulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 460
        Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))

        Dim x As Integer = 20
        Dim y As Integer = 45

        For i = 1 To 100
            TBox = New TextBox
            With TBox
                .Name = "TextBox" & i.ToString
                .Multiline = False
                .Font = New Font("Book Antiqua", 11)
                .Width = CInt(Me.ClientRectangle.Width / 10) - 24
                .Height = 26
                .BorderStyle = BorderStyle.Fixed3D
                .Location = New Point(x, y)
            End With
            x += CInt(Me.ClientRectangle.Width / 10) - 4
            If Me.ClientRectangle.Width - x < CInt(Me.ClientRectangle.Width / 10) - 4 Then x = 20 : y += 36
            TBoxList.Add(TBox)
            Me.Controls.Add(TBox)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To TBoxList.Count - 1
            TBoxList(i).Clear()
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To TBoxList.Count - 1
            TBoxList(i).Text = (i + 1).ToString
        Next
    End Sub
End Class