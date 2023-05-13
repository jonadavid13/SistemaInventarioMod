<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.ttelefono = New System.Windows.Forms.TextBox()
        Me.tdireccion = New System.Windows.Forms.TextBox()
        Me.tcliente = New System.Windows.Forms.TextBox()
        Me.tidentidad = New System.Windows.Forms.TextBox()
        Me.tcodigo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Identidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Codigo"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(405, 407)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(97, 92)
        Me.btnsalir.TabIndex = 22
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(278, 407)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 92)
        Me.btncancelar.TabIndex = 21
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(155, 407)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(97, 92)
        Me.btneliminar.TabIndex = 20
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(33, 407)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(97, 92)
        Me.btnaceptar.TabIndex = 19
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'ttelefono
        '
        Me.ttelefono.Location = New System.Drawing.Point(116, 334)
        Me.ttelefono.Name = "ttelefono"
        Me.ttelefono.Size = New System.Drawing.Size(171, 22)
        Me.ttelefono.TabIndex = 18
        '
        'tdireccion
        '
        Me.tdireccion.Location = New System.Drawing.Point(116, 281)
        Me.tdireccion.Name = "tdireccion"
        Me.tdireccion.Size = New System.Drawing.Size(360, 22)
        Me.tdireccion.TabIndex = 17
        '
        'tcliente
        '
        Me.tcliente.Location = New System.Drawing.Point(116, 227)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(269, 22)
        Me.tcliente.TabIndex = 16
        '
        'tidentidad
        '
        Me.tidentidad.Location = New System.Drawing.Point(116, 171)
        Me.tidentidad.Name = "tidentidad"
        Me.tidentidad.Size = New System.Drawing.Size(225, 22)
        Me.tidentidad.TabIndex = 15
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(116, 115)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(100, 22)
        Me.tcodigo.TabIndex = 14
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 615)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.ttelefono)
        Me.Controls.Add(Me.tdireccion)
        Me.Controls.Add(Me.tcliente)
        Me.Controls.Add(Me.tidentidad)
        Me.Controls.Add(Me.tcodigo)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents ttelefono As System.Windows.Forms.TextBox
    Friend WithEvents tdireccion As System.Windows.Forms.TextBox
    Friend WithEvents tcliente As System.Windows.Forms.TextBox
    Friend WithEvents tidentidad As System.Windows.Forms.TextBox
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
End Class
