<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRegistro = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.infoProducto = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnCancelarProd = New System.Windows.Forms.Button()
        Me.btnRegistroProducto = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.infoProveedor = New System.Windows.Forms.GroupBox()
        Me.btnCancelarProv = New System.Windows.Forms.Button()
        Me.btnRegistroProveedor = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRIF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.productoBox = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnAddProducto = New System.Windows.Forms.Button()
        Me.btnAddProveedor = New System.Windows.Forms.Button()
        Me.proveedorBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.infoProducto.SuspendLayout()
        Me.infoProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRegistro
        '
        Me.txtRegistro.AutoSize = True
        Me.txtRegistro.Location = New System.Drawing.Point(271, 18)
        Me.txtRegistro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(88, 13)
        Me.txtRegistro.TabIndex = 37
        Me.txtRegistro.Text = "Registrar Compra"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(203, 578)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 30)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(25, 578)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(150, 30)
        Me.btnRegistrar.TabIndex = 33
        Me.btnRegistrar.Text = "Registrar compra"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'infoProducto
        '
        Me.infoProducto.Controls.Add(Me.Label11)
        Me.infoProducto.Controls.Add(Me.txtID)
        Me.infoProducto.Controls.Add(Me.btnCancelarProd)
        Me.infoProducto.Controls.Add(Me.btnRegistroProducto)
        Me.infoProducto.Controls.Add(Me.txtCantidad)
        Me.infoProducto.Controls.Add(Me.txtDescripcion)
        Me.infoProducto.Controls.Add(Me.Label8)
        Me.infoProducto.Controls.Add(Me.Label3)
        Me.infoProducto.Controls.Add(Me.txtMarca)
        Me.infoProducto.Controls.Add(Me.Label2)
        Me.infoProducto.Controls.Add(Me.txtProducto)
        Me.infoProducto.Controls.Add(Me.lblProducto)
        Me.infoProducto.Location = New System.Drawing.Point(27, 156)
        Me.infoProducto.Name = "infoProducto"
        Me.infoProducto.Size = New System.Drawing.Size(253, 279)
        Me.infoProducto.TabIndex = 38
        Me.infoProducto.TabStop = False
        Me.infoProducto.Text = "Información del Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(147, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "ID: "
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(176, 18)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(53, 20)
        Me.txtID.TabIndex = 56
        Me.txtID.Text = "ID: "
        '
        'btnCancelarProd
        '
        Me.btnCancelarProd.Location = New System.Drawing.Point(157, 239)
        Me.btnCancelarProd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarProd.Name = "btnCancelarProd"
        Me.btnCancelarProd.Size = New System.Drawing.Size(73, 30)
        Me.btnCancelarProd.TabIndex = 56
        Me.btnCancelarProd.Text = "Cancelar"
        Me.btnCancelarProd.UseVisualStyleBackColor = True
        '
        'btnRegistroProducto
        '
        Me.btnRegistroProducto.Location = New System.Drawing.Point(18, 239)
        Me.btnRegistroProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistroProducto.Name = "btnRegistroProducto"
        Me.btnRegistroProducto.Size = New System.Drawing.Size(130, 30)
        Me.btnRegistroProducto.TabIndex = 56
        Me.btnRegistroProducto.Text = "Agregar producto"
        Me.btnRegistroProducto.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(18, 212)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(212, 20)
        Me.txtCantidad.TabIndex = 57
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(18, 159)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(212, 20)
        Me.txtDescripcion.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Cantidad a comprar: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Descripción:"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(18, 103)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(212, 20)
        Me.txtMarca.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Marca: "
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(18, 52)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(212, 20)
        Me.txtProducto.TabIndex = 40
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(15, 30)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(47, 13)
        Me.lblProducto.TabIndex = 41
        Me.lblProducto.Text = "Nombre:"
        '
        'infoProveedor
        '
        Me.infoProveedor.Controls.Add(Me.btnCancelarProv)
        Me.infoProveedor.Controls.Add(Me.btnRegistroProveedor)
        Me.infoProveedor.Controls.Add(Me.txtTelefono)
        Me.infoProveedor.Controls.Add(Me.Label7)
        Me.infoProveedor.Controls.Add(Me.txtDireccion)
        Me.infoProveedor.Controls.Add(Me.Label4)
        Me.infoProveedor.Controls.Add(Me.txtRIF)
        Me.infoProveedor.Controls.Add(Me.Label5)
        Me.infoProveedor.Controls.Add(Me.txtEmpresa)
        Me.infoProveedor.Controls.Add(Me.Label6)
        Me.infoProveedor.Location = New System.Drawing.Point(336, 156)
        Me.infoProveedor.Name = "infoProveedor"
        Me.infoProveedor.Size = New System.Drawing.Size(247, 279)
        Me.infoProveedor.TabIndex = 39
        Me.infoProveedor.TabStop = False
        Me.infoProveedor.Text = "Información del Proveedor"
        '
        'btnCancelarProv
        '
        Me.btnCancelarProv.Location = New System.Drawing.Point(165, 239)
        Me.btnCancelarProv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarProv.Name = "btnCancelarProv"
        Me.btnCancelarProv.Size = New System.Drawing.Size(67, 30)
        Me.btnCancelarProv.TabIndex = 59
        Me.btnCancelarProv.Text = "Cancelar"
        Me.btnCancelarProv.UseVisualStyleBackColor = True
        '
        'btnRegistroProveedor
        '
        Me.btnRegistroProveedor.Location = New System.Drawing.Point(21, 239)
        Me.btnRegistroProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistroProveedor.Name = "btnRegistroProveedor"
        Me.btnRegistroProveedor.Size = New System.Drawing.Size(135, 30)
        Me.btnRegistroProveedor.TabIndex = 59
        Me.btnRegistroProveedor.Text = "Registrar proveedor"
        Me.btnRegistroProveedor.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(20, 212)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(212, 20)
        Me.txtTelefono.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Número de teléfono: "
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(20, 160)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(212, 20)
        Me.txtDireccion.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Dirección:"
        '
        'txtRIF
        '
        Me.txtRIF.Location = New System.Drawing.Point(20, 103)
        Me.txtRIF.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRIF.Name = "txtRIF"
        Me.txtRIF.Size = New System.Drawing.Size(212, 20)
        Me.txtRIF.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "RIF:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(20, 49)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(212, 20)
        Me.txtEmpresa.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Empresa:"
        '
        'productoBox
        '
        Me.productoBox.FormattingEnabled = True
        Me.productoBox.Location = New System.Drawing.Point(27, 82)
        Me.productoBox.Name = "productoBox"
        Me.productoBox.Size = New System.Drawing.Size(253, 21)
        Me.productoBox.TabIndex = 40
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(42, 57)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(133, 13)
        Me.lbl1.TabIndex = 40
        Me.lbl1.Text = "Elegir producto registrado: "
        '
        'btnAddProducto
        '
        Me.btnAddProducto.Location = New System.Drawing.Point(67, 115)
        Me.btnAddProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProducto.Name = "btnAddProducto"
        Me.btnAddProducto.Size = New System.Drawing.Size(171, 26)
        Me.btnAddProducto.TabIndex = 42
        Me.btnAddProducto.Text = "Agregar nuevo producto"
        Me.btnAddProducto.UseVisualStyleBackColor = True
        '
        'btnAddProveedor
        '
        Me.btnAddProveedor.Location = New System.Drawing.Point(372, 115)
        Me.btnAddProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProveedor.Name = "btnAddProveedor"
        Me.btnAddProveedor.Size = New System.Drawing.Size(177, 26)
        Me.btnAddProveedor.TabIndex = 46
        Me.btnAddProveedor.Text = "Registrar nuevo proveedor"
        Me.btnAddProveedor.UseVisualStyleBackColor = True
        '
        'proveedorBox
        '
        Me.proveedorBox.FormattingEnabled = True
        Me.proveedorBox.Location = New System.Drawing.Point(336, 82)
        Me.proveedorBox.Name = "proveedorBox"
        Me.proveedorBox.Size = New System.Drawing.Size(247, 21)
        Me.proveedorBox.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Elegir proveedor registrado: "
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(33, 527)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(212, 20)
        Me.txtMonto.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 447)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Fecha de compra: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 505)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Monto de pago: "
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(33, 472)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(212, 20)
        Me.txtFecha.TabIndex = 55
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 653)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAddProveedor)
        Me.Controls.Add(Me.proveedorBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddProducto)
        Me.Controls.Add(Me.infoProveedor)
        Me.Controls.Add(Me.infoProducto)
        Me.Controls.Add(Me.productoBox)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtRegistro)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra"
        Me.infoProducto.ResumeLayout(False)
        Me.infoProducto.PerformLayout()
        Me.infoProveedor.ResumeLayout(False)
        Me.infoProveedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRegistro As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents infoProducto As System.Windows.Forms.GroupBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents productoBox As System.Windows.Forms.ComboBox
    Friend WithEvents infoProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents btnAddProducto As System.Windows.Forms.Button
    Friend WithEvents btnAddProveedor As System.Windows.Forms.Button
    Friend WithEvents proveedorBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRIF As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRegistroProducto As System.Windows.Forms.Button
    Friend WithEvents btnRegistroProveedor As System.Windows.Forms.Button
    Friend WithEvents btnCancelarProd As System.Windows.Forms.Button
    Friend WithEvents btnCancelarProv As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
