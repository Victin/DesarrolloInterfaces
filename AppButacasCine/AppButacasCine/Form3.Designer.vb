<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPantalla = New System.Windows.Forms.TextBox()
        Me.lblLibres2 = New System.Windows.Forms.Label()
        Me.txtLibres2 = New System.Windows.Forms.TextBox()
        Me.btnSalir2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPantalla
        '
        Me.txtPantalla.Enabled = False
        Me.txtPantalla.Location = New System.Drawing.Point(12, 12)
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.Size = New System.Drawing.Size(573, 20)
        Me.txtPantalla.TabIndex = 2
        Me.txtPantalla.Text = "Proyector"
        Me.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLibres2
        '
        Me.lblLibres2.AutoSize = True
        Me.lblLibres2.Location = New System.Drawing.Point(434, 377)
        Me.lblLibres2.Name = "lblLibres2"
        Me.lblLibres2.Size = New System.Drawing.Size(73, 13)
        Me.lblLibres2.TabIndex = 7
        Me.lblLibres2.Text = "Butacas libres"
        '
        'txtLibres2
        '
        Me.txtLibres2.Enabled = False
        Me.txtLibres2.Location = New System.Drawing.Point(513, 374)
        Me.txtLibres2.Name = "txtLibres2"
        Me.txtLibres2.Size = New System.Drawing.Size(72, 20)
        Me.txtLibres2.TabIndex = 8
        '
        'btnSalir2
        '
        Me.btnSalir2.Location = New System.Drawing.Point(12, 367)
        Me.btnSalir2.Name = "btnSalir2"
        Me.btnSalir2.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir2.TabIndex = 13
        Me.btnSalir2.Text = "Salir"
        Me.btnSalir2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 406)
        Me.Controls.Add(Me.btnSalir2)
        Me.Controls.Add(Me.txtLibres2)
        Me.Controls.Add(Me.lblLibres2)
        Me.Controls.Add(Me.txtPantalla)
        Me.Name = "Form3"
        Me.Text = "Sala 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPantalla As TextBox
    Friend WithEvents lblLibres2 As Label
    Friend WithEvents txtLibres2 As TextBox
    Friend WithEvents btnSalir2 As Button
End Class
