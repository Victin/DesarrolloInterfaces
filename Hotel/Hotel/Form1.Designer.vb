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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImporte = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxCena = New System.Windows.Forms.CheckBox()
        Me.cbxComida = New System.Windows.Forms.CheckBox()
        Me.cbxAlojamiento = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTemporada = New System.Windows.Forms.ComboBox()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 67)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(145, 67)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DNI:"
        '
        'btnImporte
        '
        Me.btnImporte.Location = New System.Drawing.Point(12, 123)
        Me.btnImporte.Name = "btnImporte"
        Me.btnImporte.Size = New System.Drawing.Size(75, 23)
        Me.btnImporte.TabIndex = 4
        Me.btnImporte.Text = "Importe"
        Me.btnImporte.UseVisualStyleBackColor = True
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(114, 125)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxAlojamiento)
        Me.GroupBox1.Controls.Add(Me.cbxComida)
        Me.GroupBox1.Controls.Add(Me.cbxCena)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(277, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 194)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servicios Solicitados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precios en temporada baja"
        '
        'cbxCena
        '
        Me.cbxCena.AutoSize = True
        Me.cbxCena.Location = New System.Drawing.Point(19, 46)
        Me.cbxCena.Name = "cbxCena"
        Me.cbxCena.Size = New System.Drawing.Size(95, 17)
        Me.cbxCena.TabIndex = 8
        Me.cbxCena.Text = "Cena: 1000pts"
        Me.cbxCena.UseVisualStyleBackColor = True
        '
        'cbxComida
        '
        Me.cbxComida.AutoSize = True
        Me.cbxComida.Location = New System.Drawing.Point(19, 69)
        Me.cbxComida.Name = "cbxComida"
        Me.cbxComida.Size = New System.Drawing.Size(105, 17)
        Me.cbxComida.TabIndex = 9
        Me.cbxComida.Text = "Comida: 1500pts"
        Me.cbxComida.UseVisualStyleBackColor = True
        '
        'cbxAlojamiento
        '
        Me.cbxAlojamiento.AutoSize = True
        Me.cbxAlojamiento.Location = New System.Drawing.Point(19, 92)
        Me.cbxAlojamiento.Name = "cbxAlojamiento"
        Me.cbxAlojamiento.Size = New System.Drawing.Size(181, 17)
        Me.cbxAlojamiento.TabIndex = 10
        Me.cbxAlojamiento.Text = "Alojamiento y desayuno: 4000pts"
        Me.cbxAlojamiento.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Temporada media: 15% más"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Temporada alta: 25% más"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(537, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Temporada"
        '
        'cmbTemporada
        '
        Me.cmbTemporada.FormattingEnabled = True
        Me.cmbTemporada.Items.AddRange(New Object() {"ALTA", "MEDIA", "BAJA"})
        Me.cmbTemporada.Location = New System.Drawing.Point(540, 67)
        Me.cmbTemporada.Name = "cmbTemporada"
        Me.cmbTemporada.Size = New System.Drawing.Size(121, 21)
        Me.cmbTemporada.TabIndex = 13
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(12, 274)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnVisualizar.TabIndex = 14
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 303)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 360)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.cmbTemporada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.btnImporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Form1"
        Me.Text = "Hotel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImporte As Button
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxAlojamiento As CheckBox
    Friend WithEvents cbxComida As CheckBox
    Friend WithEvents cbxCena As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbTemporada As ComboBox
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnSalir As Button
End Class
