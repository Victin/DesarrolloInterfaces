Public Class Form1
    Private Sub btnSala1_Click(sender As Object, e As EventArgs) Handles btnSala1.Click
        filas = 3
        numero = 13
        salaAux = sala1
        'Me.Close()
        Form2.Show()
    End Sub

    Private Sub btnSala2_Click(sender As Object, e As EventArgs) Handles btnSala2.Click
        filas = 5
        numero = 13
        'Me.Close()
        Form3.Show()
    End Sub

    Private Sub btnSala3_Click(sender As Object, e As EventArgs) Handles btnSala3.Click
        filas = 1
        numero = 13
        'Me.Close()
        Form4.Show()
    End Sub
End Class
