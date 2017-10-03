Public Class Form1

    Dim altura As Integer = 80

    Private Sub btnSala1_Click(sender As Object, e As EventArgs) Handles btnSala1.Click
        For j = 0 To 3 'Tiene que hacer esto 4 veces (Se crean 4 filas de butacas)
            For i = 0 To 13 'Crea una fila con 14 butacas
                Dim variable As Integer
                variable += 1 'Cada vez que haga 1 recorrido el bucle se seuma al valor 1

                Dim hor As New Button
                hor.Name = variable
                hor.Tag = i
                hor.BackColor = Color.Aqua
                hor.Size = New Size(40, 40)
                hor.Location = New Point(40 * (i + 1 / 2), altura)
                hor.Text = hor.Name
                Me.Controls.Add(hor)
                AddHandler hor.Click, AddressOf accionClick
            Next
            altura = altura + 40
        Next
    End Sub

    Private Sub accionClick(ByVal Boton As Object, ByVal e As System.EventArgs)
        Boton.BackColor = Color.Red
    End Sub

End Class
