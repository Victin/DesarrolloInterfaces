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
        Me.btnSala2 = New System.Windows.Forms.Button()
        Me.btnSala1 = New System.Windows.Forms.Button()
        Me.btnSala3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSala2
        '
        Me.btnSala2.Location = New System.Drawing.Point(223, 125)
        Me.btnSala2.Name = "btnSala2"
        Me.btnSala2.Size = New System.Drawing.Size(124, 46)
        Me.btnSala2.TabIndex = 2
        Me.btnSala2.Text = "Sala 2"
        Me.btnSala2.UseVisualStyleBackColor = True
        '
        'btnSala1
        '
        Me.btnSala1.Location = New System.Drawing.Point(94, 125)
        Me.btnSala1.Name = "btnSala1"
        Me.btnSala1.Size = New System.Drawing.Size(124, 46)
        Me.btnSala1.TabIndex = 1
        Me.btnSala1.Text = "Sala 1"
        Me.btnSala1.UseVisualStyleBackColor = True
        '
        'btnSala3
        '
        Me.btnSala3.Location = New System.Drawing.Point(353, 125)
        Me.btnSala3.Name = "btnSala3"
        Me.btnSala3.Size = New System.Drawing.Size(124, 46)
        Me.btnSala3.TabIndex = 3
        Me.btnSala3.Text = "Sala 3"
        Me.btnSala3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ELIGE LA SALA DE CINE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 285)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSala3)
        Me.Controls.Add(Me.btnSala2)
        Me.Controls.Add(Me.btnSala1)
        Me.Name = "Form1"
        Me.Text = "Butacas Cine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSala2 As Button
    Friend WithEvents btnSala1 As Button
    Friend WithEvents btnSala3 As Button
    Friend WithEvents Label1 As Label
End Class
