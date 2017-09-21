Public Class Form1
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim max As String
        Dim i As Integer

        While max <> "NO"
            ReDim Preserve datos(i)
            datos(i).nombre = InputBox("Nombre")
            datos(i).apellido1 = InputBox("Apellido 1")
            datos(i).apellido2 = InputBox("Apellido 2")
            datos(i).edad = InputBox("Edad")
            max = InputBox("Quieres seguir SI/NO")
        End While
        lstNombre.Items.Add(datos(i).nombre)
        cboApellido1.Items.Add(lstNombre.SelectedIndex.)
    End Sub
End Class
