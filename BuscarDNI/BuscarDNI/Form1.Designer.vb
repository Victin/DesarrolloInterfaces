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
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblApp1 = New System.Windows.Forms.Label()
        Me.lblTlf = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblApp2 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtApp2 = New System.Windows.Forms.TextBox()
        Me.txtApp1 = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cbxDNI = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(439, 43)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(136, 23)
        Me.btnAñadir.TabIndex = 0
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(439, 148)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(136, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(439, 94)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(136, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(40, 31)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(29, 13)
        Me.lblDNI.TabIndex = 3
        Me.lblDNI.Text = "DNI"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(40, 64)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(50, 13)
        Me.lblNom.TabIndex = 4
        Me.lblNom.Text = "Nombre"
        '
        'lblApp1
        '
        Me.lblApp1.AutoSize = True
        Me.lblApp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp1.Location = New System.Drawing.Point(40, 99)
        Me.lblApp1.Name = "lblApp1"
        Me.lblApp1.Size = New System.Drawing.Size(91, 13)
        Me.lblApp1.TabIndex = 5
        Me.lblApp1.Text = "Primer Apellido"
        '
        'lblTlf
        '
        Me.lblTlf.AutoSize = True
        Me.lblTlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTlf.Location = New System.Drawing.Point(40, 204)
        Me.lblTlf.Name = "lblTlf"
        Me.lblTlf.Size = New System.Drawing.Size(57, 13)
        Me.lblTlf.TabIndex = 6
        Me.lblTlf.Text = "Telefono"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDir.Location = New System.Drawing.Point(40, 169)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(61, 13)
        Me.lblDir.TabIndex = 7
        Me.lblDir.Text = "Direccion"
        '
        'lblApp2
        '
        Me.lblApp2.AutoSize = True
        Me.lblApp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp2.Location = New System.Drawing.Point(40, 133)
        Me.lblApp2.Name = "lblApp2"
        Me.lblApp2.Size = New System.Drawing.Size(106, 13)
        Me.lblApp2.TabIndex = 8
        Me.lblApp2.Text = "Segundo Apellido"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(207, 28)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(153, 20)
        Me.txtDNI.TabIndex = 9
        '
        'txtTlf
        '
        Me.txtTlf.Location = New System.Drawing.Point(207, 201)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(153, 20)
        Me.txtTlf.TabIndex = 11
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(207, 166)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(153, 20)
        Me.txtDir.TabIndex = 12
        '
        'txtApp2
        '
        Me.txtApp2.Location = New System.Drawing.Point(207, 130)
        Me.txtApp2.Name = "txtApp2"
        Me.txtApp2.Size = New System.Drawing.Size(153, 20)
        Me.txtApp2.TabIndex = 13
        '
        'txtApp1
        '
        Me.txtApp1.Location = New System.Drawing.Point(207, 96)
        Me.txtApp1.Name = "txtApp1"
        Me.txtApp1.Size = New System.Drawing.Size(153, 20)
        Me.txtApp1.TabIndex = 14
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(207, 61)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(153, 20)
        Me.txtNom.TabIndex = 15
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(134, 278)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(94, 13)
        Me.lblBuscar.TabIndex = 16
        Me.lblBuscar.Text = "Buscar por DNI"
        '
        'cbxDNI
        '
        Me.cbxDNI.FormattingEnabled = True
        Me.cbxDNI.Location = New System.Drawing.Point(230, 275)
        Me.cbxDNI.Name = "cbxDNI"
        Me.cbxDNI.Size = New System.Drawing.Size(168, 21)
        Me.cbxDNI.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 337)
        Me.Controls.Add(Me.cbxDNI)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtApp1)
        Me.Controls.Add(Me.txtApp2)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblApp2)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblTlf)
        Me.Controls.Add(Me.lblApp1)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAñadir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblApp1 As Label
    Friend WithEvents lblTlf As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblApp2 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtApp2 As TextBox
    Friend WithEvents txtApp1 As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents cbxDNI As ComboBox
End Class
