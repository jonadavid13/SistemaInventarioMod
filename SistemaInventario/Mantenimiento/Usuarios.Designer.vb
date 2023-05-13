<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tusuario = New System.Windows.Forms.TextBox()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.tconfirmar = New System.Windows.Forms.TextBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tnivel = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nivel"
        '
        'tusuario
        '
        Me.tusuario.Location = New System.Drawing.Point(108, 62)
        Me.tusuario.Name = "tusuario"
        Me.tusuario.Size = New System.Drawing.Size(181, 22)
        Me.tusuario.TabIndex = 5
        '
        'tclave
        '
        Me.tclave.Location = New System.Drawing.Point(108, 113)
        Me.tclave.Name = "tclave"
        Me.tclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tclave.Size = New System.Drawing.Size(130, 22)
        Me.tclave.TabIndex = 6
        '
        'tconfirmar
        '
        Me.tconfirmar.Location = New System.Drawing.Point(108, 171)
        Me.tconfirmar.Name = "tconfirmar"
        Me.tconfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tconfirmar.Size = New System.Drawing.Size(130, 22)
        Me.tconfirmar.TabIndex = 7
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(108, 228)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(181, 22)
        Me.tnombre.TabIndex = 8
        '
        'tnivel
        '
        Me.tnivel.Location = New System.Drawing.Point(108, 289)
        Me.tnivel.Name = "tnivel"
        Me.tnivel.Size = New System.Drawing.Size(75, 22)
        Me.tnivel.TabIndex = 9
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(382, 382)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(97, 92)
        Me.btnsalir.TabIndex = 40
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(255, 382)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 92)
        Me.btncancelar.TabIndex = 39
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(132, 382)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(97, 92)
        Me.btneliminar.TabIndex = 38
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(10, 382)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(97, 92)
        Me.btnaceptar.TabIndex = 37
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 486)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.tnivel)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.tconfirmar)
        Me.Controls.Add(Me.tclave)
        Me.Controls.Add(Me.tusuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tusuario As System.Windows.Forms.TextBox
    Friend WithEvents tclave As System.Windows.Forms.TextBox
    Friend WithEvents tconfirmar As System.Windows.Forms.TextBox
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents tnivel As System.Windows.Forms.TextBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
End Class
