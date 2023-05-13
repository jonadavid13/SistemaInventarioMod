Imports MySql.Data.MySqlClient
Public Class Compra
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim consulta As String
    Dim comandos As New MySqlCommand
    Dim cantidadProductos As Byte
    Dim cantidadProveedores As Byte
    Dim sumaProducto As Decimal
    Dim actualID As Integer
    Dim arregloID(100) As Integer



    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRegistroProducto.Visible = False
        btnRegistroProveedor.Visible = False

        btnCancelarProd.Visible = False
        btnCancelarProv.Visible = False

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
                conexion.Open()
            End If
        Catch ex As Exception
            MsgBox("Fallo al conectar: " & ex.Message)
        End Try

        'Bloquear edición en los controles de vista de datos
        txtEmpresa.ReadOnly = True
        txtRIF.ReadOnly = True
        txtDireccion.ReadOnly = True
        txtTelefono.ReadOnly = True

        txtProducto.ReadOnly = True
        txtDescripcion.ReadOnly = True
        txtMarca.ReadOnly = True

        actualizarListas()
        btnRegistrar.Enabled = True
    End Sub
    Private Sub actualizarListas()
        Dim producto As String
        Dim proveedor As String

        'Agregar los productos a la lista para su seleccion
        Try
            consulta = "SELECT idProducto,nombreProducto,marca,cantidad FROM productos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "productos")
            cantidadProductos = datos.Tables("productos").Rows.Count

                productoBox.DataSource = datos.Tables("productos")
                productoBox.DisplayMember = "nombreProducto"
                productoBox.ValueMember = "idProducto"
        Catch ex As Exception
            MsgBox("Error en seleccion: " & ex.Message)
        End Try

        'Agregar los proveedores a la lista para su seleccion
        Try
            consulta = "SELECT RIF,nombreEmpresa FROM proveedores"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            'datos = New DataSet
            adaptador.Fill(datos, "proveedores")
            cantidadProveedores = datos.Tables("proveedores").Rows.Count

            proveedorBox.DataSource = datos.Tables("proveedores")
            proveedorBox.DisplayMember = "nombreEmpresa"
            proveedorBox.ValueMember = "RIF"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Private Sub btnAddProducto_Click(sender As Object, e As EventArgs) Handles btnAddProducto.Click
        productoBox.SelectedIndex = -1
        txtProducto.Clear()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        txtMarca.Clear()
        txtID.Clear()

        txtProducto.ReadOnly = False
        txtMarca.ReadOnly = False
        txtDescripcion.ReadOnly = False
        txtCantidad.ReadOnly = True

        btnRegistroProducto.Visible = True
        btnCancelarProd.Visible = True

        txtProducto.Focus()
    End Sub

    Private Sub btnRegistroProducto_Click(sender As Object, e As EventArgs) Handles btnRegistroProducto.Click
        'Registrar nuevos productos
        Try
            comandos = New MySqlCommand("INSERT INTO productos (nombreProducto,marca,descripcion)" & "VALUES (@nombreProducto, @marca, @descripcion)", conexion)
            comandos.Parameters.AddWithValue("@nombreProducto", txtProducto.Text)
            comandos.Parameters.AddWithValue("@marca", txtMarca.Text)
            'comandos.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(txtCantidad.Text))
            comandos.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Producto registrado")



            'Limpiar ventanas y controles
            txtProducto.Clear()
            txtCantidad.Clear()
            txtMarca.Clear()
            txtDescripcion.Clear()
            txtID.Clear()

            txtProducto.ReadOnly = True
            txtMarca.ReadOnly = True
            txtDescripcion.ReadOnly = True

            btnRegistroProducto.Visible = False
            btnCancelarProd.Visible = False
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        'productoBox.Items.Clear()
        actualizarListas()

    End Sub

    Private Sub btnCancelarProd_Click(sender As Object, e As EventArgs) Handles btnCancelarProd.Click
        txtProducto.Clear()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        txtMarca.Clear()
        txtID.Clear()

        txtProducto.ReadOnly = True
        txtMarca.ReadOnly = True
        txtDescripcion.ReadOnly = True
        txtCantidad.ReadOnly = False

        btnRegistroProducto.Visible = False
        btnCancelarProd.Visible = False
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBoxResult.Yes Then
            MenuPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim lista As Byte
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
                conexion.Open()
            End If
        Catch ex As Exception
            MsgBox("Fallo al conectar: " & ex.Message)
        End Try
        Try
            'lista = datos.Tables("productos").Rows(0).Item("idCompras")

            comandos = New MySqlCommand("INSERT INTO compras (fechaCompra,cantidad,precio,RIF) VALUES (@fecha,@cantidad,@precio,@rif)", conexion)
            comandos.Parameters.AddWithValue("@fecha", Convert.ToDateTime(txtFecha.Text))
            comandos.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(txtCantidad.Text))
            comandos.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtMonto.Text))
            comandos.Parameters.AddWithValue("@rif", txtRIF.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Compra registrada")

            consulta = "SELECT MAX(idCompras) FROM compras"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "compras")
            Dim idCompra As Integer = datos.Tables("compras").Rows(0).Item(0)

            sumaProducto = sumaProducto + Convert.ToDecimal(txtCantidad.Text)

            comandos = New MySqlCommand("INSERT INTO relacion_compras_productos (idCompras,idProducto) VALUES (@idCompras,@idProducto)", conexion)
            comandos.Parameters.AddWithValue("@idCompras", idCompra)
            comandos.Parameters.AddWithValue("@idProducto", Val(txtID.Text))
            comandos.ExecuteNonQuery()

            comandos = New MySqlCommand("UPDATE productos SET cantidad = " & Replace(Str(sumaProducto), ",", ".") & " WHERE idProducto = " & txtID.Text, conexion)
            comandos.ExecuteNonQuery()

            Me.Close()
            MenuPrincipal.Show()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub productoBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles productoBox.SelectedValueChanged
        Dim codigoProducto As Integer
        cantidadProductos = 0
        If productoBox.SelectedIndex >= 0 Then
            codigoProducto = Val(productoBox.SelectedValue.ToString)
            Try
                consulta = "SELECT * FROM productos WHERE idProducto = " & codigoProducto
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "productos")
                cantidadProductos = datos.Tables("productos").Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        'Llenar campos
        If cantidadProductos > 0 Then
            txtID.Text = datos.Tables("productos").Rows(0).Item("idProducto")
            txtProducto.Text = datos.Tables("productos").Rows(0).Item("nombreProducto")
            txtMarca.Text = datos.Tables("productos").Rows(0).Item("marca")
            txtDescripcion.Text = datos.Tables("productos").Rows(0).Item("descripcion")
            If IsDBNull(datos.Tables("productos").Rows(0).Item("cantidad")) Then
                sumaProducto = 0
            Else
                sumaProducto = datos.Tables("productos").Rows(0).Item("cantidad")
            End If

            'If datos.Tables("productos").Rows(0).Item("descripcion").Equals(DBNull.Value) Then
            'txtDescripcion.Clear()
            'Else

            'End If
            txtCantidad.ReadOnly = False
            txtCantidad.Clear()
            txtCantidad.Focus()
        End If

    End Sub
    Private Sub proveedorBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles proveedorBox.SelectedIndexChanged
        'Mostrar proovedores registrados
        cantidadProveedores = 0

        If proveedorBox.SelectedIndex >= 0 Then
            Try
                consulta = "SELECT * FROM proveedores WHERE nombreEmpresa = '" & proveedorBox.Text & "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "proveedores")
                cantidadProveedores = datos.Tables("proveedores").Rows.Count

                If cantidadProveedores > 0 Then
                    'Llenar campos
                    txtRIF.Text = datos.Tables("proveedores").Rows(0).Item("RIF")
                    txtEmpresa.Text = datos.Tables("proveedores").Rows(0).Item("nombreEmpresa")
                    txtDireccion.Text = datos.Tables("proveedores").Rows(0).Item("ubicacion")
                    txtTelefono.Text = datos.Tables("proveedores").Rows(0).Item("telefono")
                End If
                

            Catch ex As Exception
                MsgBox("Error en selección: " & ex.Message)
            End Try
        End If
    End Sub
End Class
