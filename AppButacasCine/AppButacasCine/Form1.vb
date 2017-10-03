Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 13
            Dim hor As New Button
            hor.Name = i + 1
            hor.Tag = i
            hor.BackColor = Color.Aqua
            hor.Size = New Size(40, 40)
            hor.Location = New Point(40 * (i + 1 / 2), 80)
            hor.Text = hor.Name
            Me.Controls.Add(hor)
            AddHandler hor.Click, AddressOf accionClick
        Next

        For i = 0 To 13
            Dim hor As New Button
            hor.Name = i + 1 + 14
            hor.Tag = i
            hor.BackColor = Color.Aqua
            hor.Size = New Size(40, 40)
            hor.Location = New Point(40 * (i + 1 / 2), 120)
            hor.Text = hor.Name
            Me.Controls.Add(hor)
            AddHandler hor.Click, AddressOf accionClick
        Next

        For i = 0 To 13
            Dim hor As New Button
            hor.Name = i + 1 + 28
            hor.Tag = i
            hor.BackColor = Color.Aqua
            hor.Size = New Size(40, 40)
            hor.Location = New Point(40 * (i + 1 / 2), 160)
            hor.Text = hor.Name
            Me.Controls.Add(hor)
            AddHandler hor.Click, AddressOf accionClick
        Next

        For i = 0 To 13
            Dim hor As New Button
            hor.Name = i + 1 + 42
            hor.Tag = i
            hor.BackColor = Color.Aqua
            hor.Size = New Size(40, 40)
            hor.Location = New Point(40 * (i + 1 / 2), 200)
            hor.Text = hor.Name
            Me.Controls.Add(hor)
            AddHandler hor.Click, AddressOf accionClick
        Next
    End Sub

    Private Sub accionClick(ByVal Boton As Object, ByVal e As System.EventArgs)
        Boton.BackColor = Color.Red
    End Sub
End Class
