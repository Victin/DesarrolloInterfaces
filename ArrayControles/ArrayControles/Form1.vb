Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 5
            Dim miTxt As New TextBox
            miTxt.Name = "txt" & i
            miTxt.Tag = i
            miTxt.Size = New Size(100, 20)
            miTxt.Location = New Point(30, 20 * (i + 1)) '+ Añadir la distancia al principio
            miTxt.Text = miTxt.Name
            Me.Controls.Add(miTxt)
        Next

        For i = 0 To 5
            Dim miBtn As New Button
            miBtn.Name = "btn" & i
            miBtn.Tag = i
            miBtn.Size = New Size(100, 20)
            miBtn.Location = New Point(150, 20 * (i + 1)) '+ Añadir la distancia al principio
            miBtn.Text = miBtn.Name
            Me.Controls.Add(miBtn)
            AddHandler miBtn.Click, AddressOf Prueba
        Next
    End Sub

    Private Sub Prueba(ByVal Variable As Object, ByVal e As System.EventArgs)
        MsgBox("Control " + CType(Variable, Button).Tag.ToString()) 'Recoge el indice de donde has pulsado
        'CType(Variable, Button).BackColor = Color.Aqua // Esto es igual
        Variable.BackColor = Color.Aqua
    End Sub
End Class
