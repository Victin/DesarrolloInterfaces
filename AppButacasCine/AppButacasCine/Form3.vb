Public Class Form3

    Dim altura As Integer = 80
    Dim libres As Integer
    Dim variable As Integer
    Dim numero As Integer = 13

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For j = 0 To filas 'Tiene que hacer esto 4 veces (Se crean 4 filas de butacas)
            For i = 0 To numero 'Crea una fila con 14 butacas
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
        If Boton.BackColor = Color.Aqua Then
            Boton.BackColor = Color.Crimson
        ElseIf Boton.BackColor = Color.Crimson Then
            Boton.BackColor = Color.Aqua
        End If
    End Sub

    Private Sub btnSalir2_Click(sender As Object, e As EventArgs) Handles btnSalir2.Click
        Me.Close()
    End Sub
End Class