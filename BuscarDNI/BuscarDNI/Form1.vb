Public Class Form1
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        For Each Controles In Controls
            If TypeOf (Controles) Is TextBox Then
                If Controles.Text = "" Then
                    If txtDNI.Text = "" Then
                        MsgBox("Rellena el DNI")
                    End If
                    If txtNom.Text = "" Then
                        MsgBox("Rellena el nombre")
                    End If
                    If txtApp1.Text = "" Then
                        MsgBox("Rellena el primer apellido")
                    End If
                    If txtApp2.Text = "" Then
                        MsgBox("Rellena el segundo apellido")
                    End If
                    If txtDNI.Text = "" Then
                        MsgBox("Rellena el nombre")
                    End If

                End If
            End If
        Next
    End Sub

    Private Sub blanco()
        For Each Controles In Controls
            If TypeOf (Controles) Is TextBox Then
                Controles.Text = ""
            End If
        Next
    End Sub
End Class
