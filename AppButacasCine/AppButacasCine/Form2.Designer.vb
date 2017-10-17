<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtPantalla = New System.Windows.Forms.TextBox()
        Me.txtLibres = New System.Windows.Forms.TextBox()
        Me.lblLibres = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPantalla
        '
        Me.txtPantalla.Enabled = False
        Me.txtPantalla.Location = New System.Drawing.Point(12, 12)
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.Size = New System.Drawing.Size(573, 20)
        Me.txtPantalla.TabIndex = 1
        Me.txtPantalla.Text = "Proyector"
        Me.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLibres
        '
        Me.txtLibres.Enabled = False
        Me.txtLibres.Location = New System.Drawing.Point(485, 374)
        Me.txtLibres.Name = "txtLibres"
        Me.txtLibres.Size = New System.Drawing.Size(100, 20)
        Me.txtLibres.TabIndex = 5
        '
        'lblLibres
        '
        Me.lblLibres.AutoSize = True
        Me.lblLibres.Location = New System.Drawing.Point(404, 377)
        Me.lblLibres.Name = "lblLibres"
        Me.lblLibres.Size = New System.Drawing.Size(73, 13)
        Me.lblLibres.TabIndex = 6
        Me.lblLibres.Text = "Butacas libres"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 371)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 406)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblLibres)
        Me.Controls.Add(Me.txtLibres)
        Me.Controls.Add(Me.txtPantalla)
        Me.Name = "Form2"
        Me.Text = "Sala 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPantalla As TextBox
    Friend WithEvents txtLibres As TextBox
    Friend WithEvents lblLibres As Label
    Friend WithEvents btnSalir As Button
End Class
