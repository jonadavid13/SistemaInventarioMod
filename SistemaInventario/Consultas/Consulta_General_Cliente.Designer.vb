<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_General
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
        Me.TablaConsulta = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.OpcionesBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TablaConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaConsulta
        '
        Me.TablaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaConsulta.Location = New System.Drawing.Point(19, 142)
        Me.TablaConsulta.Margin = New System.Windows.Forms.Padding(2)
        Me.TablaConsulta.Name = "TablaConsulta"
        Me.TablaConsulta.RowTemplate.Height = 24
        Me.TablaConsulta.Size = New System.Drawing.Size(609, 269)
        Me.TablaConsulta.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(195, 443)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(222, 39)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver al Menú Principal"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'OpcionesBox
        '
        Me.OpcionesBox.FormattingEnabled = True
        Me.OpcionesBox.Items.AddRange(New Object() {"Compras", "Ventas", "Proveedores", "Clientes", "Productos", "Trabajadores"})
        Me.OpcionesBox.Location = New System.Drawing.Point(19, 69)
        Me.OpcionesBox.Name = "OpcionesBox"
        Me.OpcionesBox.Size = New System.Drawing.Size(269, 21)
        Me.OpcionesBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione el campo a visualizar: "
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(294, 61)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(87, 34)
        Me.btnCargar.TabIndex = 4
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(19, 117)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.ReadOnly = True
        Me.txtOpcion.Size = New System.Drawing.Size(179, 20)
        Me.txtOpcion.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(519, 108)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 29)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Consulta_General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 511)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpcionesBox)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.TablaConsulta)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Consulta_General"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Generales"
        CType(Me.TablaConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TablaConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents OpcionesBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
