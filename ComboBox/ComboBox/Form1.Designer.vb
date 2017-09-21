<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cboApellido1 = New System.Windows.Forms.ComboBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.cboApellido2 = New System.Windows.Forms.ComboBox()
        Me.cboEdad = New System.Windows.Forms.ComboBox()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lstNombre = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cboApellido1
        '
        Me.cboApellido1.FormattingEnabled = True
        Me.cboApellido1.Location = New System.Drawing.Point(402, 14)
        Me.cboApellido1.Name = "cboApellido1"
        Me.cboApellido1.Size = New System.Drawing.Size(121, 21)
        Me.cboApellido1.TabIndex = 0
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(602, 107)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(172, 23)
        Me.btnCargar.TabIndex = 2
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'cboApellido2
        '
        Me.cboApellido2.FormattingEnabled = True
        Me.cboApellido2.Location = New System.Drawing.Point(402, 109)
        Me.cboApellido2.Name = "cboApellido2"
        Me.cboApellido2.Size = New System.Drawing.Size(121, 21)
        Me.cboApellido2.TabIndex = 4
        '
        'cboEdad
        '
        Me.cboEdad.FormattingEnabled = True
        Me.cboEdad.Location = New System.Drawing.Point(402, 203)
        Me.cboEdad.Name = "cboEdad"
        Me.cboEdad.Size = New System.Drawing.Size(121, 21)
        Me.cboEdad.TabIndex = 5
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(303, 17)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(53, 13)
        Me.lblApellido1.TabIndex = 6
        Me.lblApellido1.Text = "Apellido 1"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(303, 112)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(53, 13)
        Me.lblApellido2.TabIndex = 7
        Me.lblApellido2.Text = "Apellido 2"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(303, 206)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 8
        Me.lblEdad.Text = "Edad"
        '
        'lstNombre
        '
        Me.lstNombre.FormattingEnabled = True
        Me.lstNombre.Location = New System.Drawing.Point(13, 13)
        Me.lstNombre.Name = "lstNombre"
        Me.lstNombre.Size = New System.Drawing.Size(120, 212)
        Me.lstNombre.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 274)
        Me.Controls.Add(Me.lstNombre)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.cboEdad)
        Me.Controls.Add(Me.cboApellido2)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.cboApellido1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboApellido1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents cboApellido2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboEdad As System.Windows.Forms.ComboBox
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lstNombre As ListBox
End Class
