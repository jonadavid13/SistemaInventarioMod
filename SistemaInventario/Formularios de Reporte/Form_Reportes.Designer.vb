<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Reportes
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Rbcliente = New System.Windows.Forms.CheckBox()
        Me.Rbinventario = New System.Windows.Forms.CheckBox()
        Me.Rbusuario = New System.Windows.Forms.CheckBox()
        Me.Rbfactura = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 83)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 111)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Rbcliente
        '
        Me.Rbcliente.AutoSize = True
        Me.Rbcliente.Location = New System.Drawing.Point(26, 58)
        Me.Rbcliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rbcliente.Name = "Rbcliente"
        Me.Rbcliente.Size = New System.Drawing.Size(58, 17)
        Me.Rbcliente.TabIndex = 1
        Me.Rbcliente.Text = "Cliente"
        Me.Rbcliente.UseVisualStyleBackColor = True
        '
        'Rbinventario
        '
        Me.Rbinventario.AutoSize = True
        Me.Rbinventario.Location = New System.Drawing.Point(26, 107)
        Me.Rbinventario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rbinventario.Name = "Rbinventario"
        Me.Rbinventario.Size = New System.Drawing.Size(73, 17)
        Me.Rbinventario.TabIndex = 2
        Me.Rbinventario.Text = "Inventario"
        Me.Rbinventario.UseVisualStyleBackColor = True
        '
        'Rbusuario
        '
        Me.Rbusuario.AutoSize = True
        Me.Rbusuario.Location = New System.Drawing.Point(26, 155)
        Me.Rbusuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rbusuario.Name = "Rbusuario"
        Me.Rbusuario.Size = New System.Drawing.Size(62, 17)
        Me.Rbusuario.TabIndex = 3
        Me.Rbusuario.Text = "Usuario"
        Me.Rbusuario.UseVisualStyleBackColor = True
        '
        'Rbfactura
        '
        Me.Rbfactura.AutoSize = True
        Me.Rbfactura.Location = New System.Drawing.Point(26, 202)
        Me.Rbfactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rbfactura.Name = "Rbfactura"
        Me.Rbfactura.Size = New System.Drawing.Size(62, 17)
        Me.Rbfactura.TabIndex = 4
        Me.Rbfactura.Text = "Factura"
        Me.Rbfactura.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 257)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 56)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Seleccione el Reporte que desea ver"
        '
        'Form_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Rbfactura)
        Me.Controls.Add(Me.Rbusuario)
        Me.Controls.Add(Me.Rbinventario)
        Me.Controls.Add(Me.Rbcliente)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_Reportes"
        Me.Text = "Form_Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Rbcliente As System.Windows.Forms.CheckBox
    Friend WithEvents Rbinventario As System.Windows.Forms.CheckBox
    Friend WithEvents Rbusuario As System.Windows.Forms.CheckBox
    Friend WithEvents Rbfactura As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
