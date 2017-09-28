Public Class Form1

    Dim i As Integer = 0
    Dim dato As String

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        For Each Controles In Controls
            If TypeOf (Controles) Is TextBox Then
                If Controles.Text = "" Then
                    MsgBox("Falta uno o varios campos por introducir")
                    Controles.focus()
                End If
            End If
        Next
        'Redimensionar el Array e introducir datos
        ReDim Preserve agenda(i)
        agenda(i).dni = txtDNI.Text
        agenda(i).nombre = txtNom.Text
        agenda(i).app1 = txtApp1.Text
        agenda(i).app2 = txtApp2.Text
        agenda(i).dir = txtDir.Text
        agenda(i).tlf = txtTlf.Text
        'Mas funciones al hacer click en el boton
        cbxDNI.Items.Add(agenda(i).dni)
        i += 1
        blanco()
    End Sub

    Private Sub cbxDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDNI.SelectedIndexChanged
        mostrarDato()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        For j = cbxDNI.SelectedIndex To UBound(agenda) - 1
            agenda(j) = agenda(j + 1)
        Next
        cbxDNI.Items.Remove(cbxDNI.SelectedIndex)
        ReDim Preserve agenda(cbxDNI.Items.Count - 1)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub blanco()
        For Each Controles In Controls
            If TypeOf (Controles) Is TextBox Then
                Controles.Text = ""
            End If
        Next
    End Sub

    Private Sub mostrarDato()
        dato = cbxDNI.SelectedIndex
        txtDNI.Text = agenda(dato).dni
        txtNom.Text = agenda(dato).nombre
        txtApp1.Text = agenda(dato).app1
        txtApp2.Text = agenda(dato).app2
        txtDir.Text = agenda(dato).dir
        txtTlf.Text = agenda(dato).tlf
    End Sub

End Class
