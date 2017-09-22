Public Class Form1
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim max As String
        Dim i As Integer

        While max <> "NO"
            ReDim Preserve datos(i)
            datos(i).nombre = InputBox("Nombre")
            cboNombre.Items.Add(datos(i).nombre)
            datos(i).apellido1 = InputBox("Apellido 1")
            datos(i).apellido2 = InputBox("Apellido 2")
            datos(i).edad = InputBox("Edad")
            max = InputBox("Quieres seguir SI/NO")
        End While
        cboNombre.SelectedIndex = 0
    End Sub
    Sub mostrarDatos()
        txtApellido1.Text = datos(cboNombre.SelectedIndex).apellido1
        txtApellido2.Text = datos(cboNombre.SelectedIndex).apellido2
        txtEdad.Text = datos(cboNombre.SelectedIndex).edad
    End Sub
End Class
