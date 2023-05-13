<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.tvalorv = New System.Windows.Forms.TextBox()
        Me.tvalorc = New System.Windows.Forms.TextBox()
        Me.tcodigo = New System.Windows.Forms.TextBox()
        Me.tdescripcion = New System.Windows.Forms.TextBox()
        Me.nexistencia = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.categoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tpropietario = New System.Windows.Forms.TextBox()
        Me.fechaven = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblfecha = New System.Windows.Forms.Label()
        CType(Me.nexistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Valor Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Existencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Codigo"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(393, 417)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(97, 92)
        Me.btnsalir.TabIndex = 36
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(266, 417)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 92)
        Me.btncancelar.TabIndex = 35
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(143, 417)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(97, 92)
        Me.btneliminar.TabIndex = 34
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(21, 417)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(97, 92)
        Me.btnaceptar.TabIndex = 33
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'tvalorv
        '
        Me.tvalorv.Location = New System.Drawing.Point(119, 221)
        Me.tvalorv.Name = "tvalorv"
        Me.tvalorv.Size = New System.Drawing.Size(100, 22)
        Me.tvalorv.TabIndex = 32
        '
        'tvalorc
        '
        Me.tvalorc.Location = New System.Drawing.Point(119, 179)
        Me.tvalorc.Name = "tvalorc"
        Me.tvalorc.Size = New System.Drawing.Size(100, 22)
        Me.tvalorc.TabIndex = 31
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(119, 29)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(100, 22)
        Me.tcodigo.TabIndex = 28
        '
        'tdescripcion
        '
        Me.tdescripcion.Location = New System.Drawing.Point(119, 73)
        Me.tdescripcion.Multiline = True
        Me.tdescripcion.Name = "tdescripcion"
        Me.tdescripcion.Size = New System.Drawing.Size(225, 41)
        Me.tdescripcion.TabIndex = 29
        '
        'nexistencia
        '
        Me.nexistencia.Location = New System.Drawing.Point(119, 137)
        Me.nexistencia.Name = "nexistencia"
        Me.nexistencia.Size = New System.Drawing.Size(49, 22)
        Me.nexistencia.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Valor Compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Categoria"
        '
        'categoria
        '
        Me.categoria.FormattingEnabled = True
        Me.categoria.Location = New System.Drawing.Point(119, 264)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(121, 24)
        Me.categoria.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Fecha Vencimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Propietario"
        '
        'tpropietario
        '
        Me.tpropietario.Location = New System.Drawing.Point(119, 349)
        Me.tpropietario.Name = "tpropietario"
        Me.tpropietario.Size = New System.Drawing.Size(100, 22)
        Me.tpropietario.TabIndex = 48
        '
        'fechaven
        '
        Me.fechaven.Location = New System.Drawing.Point(163, 307)
        Me.fechaven.Name = "fechaven"
        Me.fechaven.Size = New System.Drawing.Size(233, 22)
        Me.fechaven.TabIndex = 0
        '
        'Timer1
        '
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(390, 18)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(85, 17)
        Me.lblfecha.TabIndex = 49
        Me.lblfecha.Text = "fecha actual"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 532)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.fechaven)
        Me.Controls.Add(Me.tpropietario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.categoria)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nexistencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.tvalorv)
        Me.Controls.Add(Me.tvalorc)
        Me.Controls.Add(Me.tdescripcion)
        Me.Controls.Add(Me.tcodigo)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.nexistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents tvalorv As System.Windows.Forms.TextBox
    Friend WithEvents tvalorc As System.Windows.Forms.TextBox
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents tdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents nexistencia As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tpropietario As System.Windows.Forms.TextBox
    Friend WithEvents fechaven As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblfecha As System.Windows.Forms.Label
End Class
