<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasEspecificasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesEspecificosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.InfoUsuarioBox = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.userID = New System.Windows.Forms.Label()
        Me.userCargo = New System.Windows.Forms.Label()
        Me.lbCargo = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.UserNombre = New System.Windows.Forms.Label()
        Me.OperacionesBox = New System.Windows.Forms.GroupBox()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.InfoUsuarioBox.SuspendLayout()
        Me.OperacionesBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(361, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.FacturaToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ClienteToolStripMenuItem.Text = "Clientes"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.FacturaToolStripMenuItem.Text = "Ventas"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasGeneralesToolStripMenuItem, Me.ConsultasEspecificasToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultasGeneralesToolStripMenuItem
        '
        Me.ConsultasGeneralesToolStripMenuItem.Name = "ConsultasGeneralesToolStripMenuItem"
        Me.ConsultasGeneralesToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ConsultasGeneralesToolStripMenuItem.Text = "Consultas Generales"
        '
        'ConsultasEspecificasToolStripMenuItem
        '
        Me.ConsultasEspecificasToolStripMenuItem.Name = "ConsultasEspecificasToolStripMenuItem"
        Me.ConsultasEspecificasToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ConsultasEspecificasToolStripMenuItem.Text = "Consultas Especificas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem1, Me.ReportesEspecificosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'ReportesEspecificosToolStripMenuItem
        '
        Me.ReportesEspecificosToolStripMenuItem.Name = "ReportesEspecificosToolStripMenuItem"
        Me.ReportesEspecificosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ReportesEspecificosToolStripMenuItem.Text = "Reportes Especificos"
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'InfoUsuarioBox
        '
        Me.InfoUsuarioBox.Controls.Add(Me.lblNombre)
        Me.InfoUsuarioBox.Controls.Add(Me.userID)
        Me.InfoUsuarioBox.Controls.Add(Me.userCargo)
        Me.InfoUsuarioBox.Controls.Add(Me.lbCargo)
        Me.InfoUsuarioBox.Controls.Add(Me.lbID)
        Me.InfoUsuarioBox.Controls.Add(Me.UserNombre)
        Me.InfoUsuarioBox.Location = New System.Drawing.Point(12, 42)
        Me.InfoUsuarioBox.Name = "InfoUsuarioBox"
        Me.InfoUsuarioBox.Size = New System.Drawing.Size(334, 123)
        Me.InfoUsuarioBox.TabIndex = 2
        Me.InfoUsuarioBox.TabStop = False
        Me.InfoUsuarioBox.Text = "Información de Acceso: "
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(77, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 13)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre Apellido"
        '
        'userID
        '
        Me.userID.AutoSize = True
        Me.userID.Location = New System.Drawing.Point(113, 59)
        Me.userID.Name = "userID"
        Me.userID.Size = New System.Drawing.Size(23, 13)
        Me.userID.TabIndex = 7
        Me.userID.Text = "C.I."
        '
        'userCargo
        '
        Me.userCargo.AutoSize = True
        Me.userCargo.Location = New System.Drawing.Point(67, 89)
        Me.userCargo.Name = "userCargo"
        Me.userCargo.Size = New System.Drawing.Size(35, 13)
        Me.userCargo.TabIndex = 6
        Me.userCargo.Text = "Cargo"
        '
        'lbCargo
        '
        Me.lbCargo.AutoSize = True
        Me.lbCargo.Location = New System.Drawing.Point(15, 89)
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(51, 13)
        Me.lbCargo.TabIndex = 5
        Me.lbCargo.Text = "CARGO: "
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(15, 59)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(98, 13)
        Me.lbID.TabIndex = 4
        Me.lbID.Text = "IDENTIFICACIÓN: "
        '
        'UserNombre
        '
        Me.UserNombre.AutoSize = True
        Me.UserNombre.Location = New System.Drawing.Point(15, 28)
        Me.UserNombre.Name = "UserNombre"
        Me.UserNombre.Size = New System.Drawing.Size(60, 13)
        Me.UserNombre.TabIndex = 3
        Me.UserNombre.Text = "NOMBRE: "
        '
        'OperacionesBox
        '
        Me.OperacionesBox.Controls.Add(Me.btnCompra)
        Me.OperacionesBox.Controls.Add(Me.btnVenta)
        Me.OperacionesBox.Location = New System.Drawing.Point(43, 202)
        Me.OperacionesBox.Name = "OperacionesBox"
        Me.OperacionesBox.Size = New System.Drawing.Size(258, 75)
        Me.OperacionesBox.TabIndex = 9
        Me.OperacionesBox.TabStop = False
        Me.OperacionesBox.Text = "Registrar"
        '
        'btnCompra
        '
        Me.btnCompra.Location = New System.Drawing.Point(139, 24)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(91, 32)
        Me.btnCompra.TabIndex = 1
        Me.btnCompra.Text = "Compra"
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(15, 24)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(95, 32)
        Me.btnVenta.TabIndex = 0
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 380)
        Me.Controls.Add(Me.OperacionesBox)
        Me.Controls.Add(Me.InfoUsuarioBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.InfoUsuarioBox.ResumeLayout(False)
        Me.InfoUsuarioBox.PerformLayout()
        Me.OperacionesBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasEspecificasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesEspecificosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents InfoUsuarioBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents userID As System.Windows.Forms.Label
    Friend WithEvents userCargo As System.Windows.Forms.Label
    Friend WithEvents lbCargo As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents UserNombre As System.Windows.Forms.Label
    Friend WithEvents OperacionesBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnCompra As System.Windows.Forms.Button
    Friend WithEvents btnVenta As System.Windows.Forms.Button
End Class
