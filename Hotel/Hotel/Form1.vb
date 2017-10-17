Public Class Form1
    Dim dias As Object
    Dim total, comida, cena, alojamiento, porciento As Integer
    Private Sub btnImporte_Click(sender As Object, e As EventArgs) Handles btnImporte.Click
        If txtNombre.Text = "" Then
            MsgBox("Introduce un Nombre")
        ElseIf txtDni.Text = "" Then
            MsgBox("Introduce un DNI")
        Else
            dias = InputBox("Numero de dias que ha pasado en el hotel", "Dias en el hotel")


            If cbxCena.Checked Then
                cena = 1000
            End If
            If cbxComida.Checked Then
                comida = 1500
            End If
            If cbxAlojamiento.Checked Then
                alojamiento = 4000
            End If
            total = (cena + comida + alojamiento) * dias

            Select Case cmbTemporada.Text
                Case "ALTA"
                    porciento = total * 0.25
                    total = total + porciento
                Case "MEDIA"
                    porciento = total * 0.15
                    total = total + porciento
                Case "BAJA"
                    total = total
            End Select
            txtImporte.Text = total
        End If
    End Sub
End Class
