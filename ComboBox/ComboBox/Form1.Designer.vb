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
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboNombre
        '
        Me.cboNombre.FormattingEnabled = True
        Me.cboNombre.Location = New System.Drawing.Point(62, 104)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(121, 21)
        Me.cboNombre.TabIndex = 0
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
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(12, 107)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido1.TabIndex = 6
        Me.lblApellido1.Text = "Nombre"
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(217, 6)
        Me.txtApellido1.Multiline = True
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(100, 256)
        Me.txtApellido1.TabIndex = 7
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(339, 6)
        Me.txtApellido2.Multiline = True
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(100, 256)
        Me.txtApellido2.TabIndex = 8
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(464, 6)
        Me.txtEdad.Multiline = True
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 256)
        Me.txtEdad.TabIndex = 9
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(602, 136)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(172, 23)
        Me.btnVer.TabIndex = 10
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 274)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.cboNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboNombre As System.Windows.Forms.ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnVer As Button
End Class
