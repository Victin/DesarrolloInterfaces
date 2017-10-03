Public Class Form1
    Dim altura As Integer = 160
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 3
            Dim txtForm As New TextBox
            txtForm.Name = "txtForm" & i
            txtForm.Tag = i
            txtForm.Size = New Size(150, 30)
            txtForm.Location = New Point(200 * (i + 0.1), altura)
            Me.Controls.Add(txtForm)
        Next
        altura = altura + 30
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
