<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtLibres3 = New System.Windows.Forms.TextBox()
        Me.lblLibres2 = New System.Windows.Forms.Label()
        Me.btnSalir3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPantalla
        '
        Me.txtPantalla.Enabled = False
        Me.txtPantalla.Location = New System.Drawing.Point(12, 12)
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.Size = New System.Drawing.Size(573, 20)
        Me.txtPantalla.TabIndex = 3
        Me.txtPantalla.Text = "Proyector"
        Me.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLibres3
        '
        Me.txtLibres3.Enabled = False
        Me.txtLibres3.Location = New System.Drawing.Point(505, 374)
        Me.txtLibres3.Name = "txtLibres3"
        Me.txtLibres3.Size = New System.Drawing.Size(80, 20)
        Me.txtLibres3.TabIndex = 10
        '
        'lblLibres2
        '
        Me.lblLibres2.AutoSize = True
        Me.lblLibres2.Location = New System.Drawing.Point(426, 377)
        Me.lblLibres2.Name = "lblLibres2"
        Me.lblLibres2.Size = New System.Drawing.Size(73, 13)
        Me.lblLibres2.TabIndex = 9
        Me.lblLibres2.Text = "Butacas libres"
        '
        'btnSalir3
        '
        Me.btnSalir3.Location = New System.Drawing.Point(7, 371)
        Me.btnSalir3.Name = "btnSalir3"
        Me.btnSalir3.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir3.TabIndex = 12
        Me.btnSalir3.Text = "Salir"
        Me.btnSalir3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 406)
        Me.Controls.Add(Me.btnSalir3)
        Me.Controls.Add(Me.txtLibres3)
        Me.Controls.Add(Me.lblLibres2)
        Me.Controls.Add(Me.txtPantalla)
        Me.Name = "Form4"
        Me.Text = "Sala 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPantalla As TextBox
    Friend WithEvents txtLibres3 As TextBox
    Friend WithEvents lblLibres2 As Label
    Friend WithEvents btnSalir3 As Button
End Class
