﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtPantalla = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPantalla
        '
        Me.txtPantalla.Enabled = False
        Me.txtPantalla.Location = New System.Drawing.Point(12, 12)
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.Size = New System.Drawing.Size(585, 20)
        Me.txtPantalla.TabIndex = 0
        Me.txtPantalla.Text = "Proyector"
        Me.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 272)
        Me.Controls.Add(Me.txtPantalla)
        Me.Name = "Form1"
        Me.Text = "Butacas Cine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPantalla As TextBox
End Class