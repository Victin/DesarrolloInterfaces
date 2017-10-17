Public Class Form2

    Dim altura As Integer = 50
    Dim libres As Integer
    Dim variable As Integer = 0


    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For j = 0 To filas 'Tiene que hacer esto 4 veces (Se crean 4 filas de butacas)
            For i = 0 To numero 'Crea una fila con 14 butacas

                Dim hor As New Button
                hor.Name = variable
                hor.Tag = variable
                If hor.Tag = 0 Then
                    hor.BackColor = Color.Aqua
                Else
                    hor.BackColor = Color.Aqua
                End If
                hor.Size = New Size(40, 40)
                hor.Location = New Point(40 * (i + 1 / 2), altura)
                hor.Text = hor.Name
                Me.Controls.Add(hor)
                AddHandler hor.Click, AddressOf accionClick

                variable += 1 'Cada vez que haga 1 recorrido el bucle se seuma al valor 1
            Next
            altura = altura + 40
        Next
    End Sub

    Private Sub accionClick(ByVal Boton As Object, ByVal e As System.EventArgs)
        If Boton.BackColor = Color.Aqua Then
            Boton.BackColor = Color.Crimson
        Else
            Boton.BackColor = Color.Aqua
        End If
        For i = 0 To UBound(salaAux)
            If Boton.BackColor = Color.Aqua Then
                salaAux(Boton.Tag) = 1
            Else
                salaAux(Boton.Tag) = 0
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class