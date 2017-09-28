Public Class Form1

    Dim i As Integer = 0

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        For Each Controles In Controls
            If TypeOf (Controles) Is TextBox Then
                If Controles.Text = "" Then
                    MsgBox("Falta uno o varios campos por introducir")
                    Controles.focus()
                End If
            End If
        Next
        ReDim Preserve agenda(i)
        agenda(i).dni = txtDNI.Text
        agenda(i).nombre = txtNom.Text
        agenda(i).app1 = txtApp1.Text
        agenda(i).app2 = txtApp2.Text
        agenda(i).dir = txtDir.Text
        agenda(i).tlf = txtTlf.Text

        i += 1
        blanco()
    End Sub

    Private Sub blanco()
        For Each Controles In Controls
            If TypeOf (Controles) Is TextBox Then
                Controles.Text = ""
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
