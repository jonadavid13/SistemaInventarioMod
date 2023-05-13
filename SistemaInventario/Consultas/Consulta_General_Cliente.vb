Imports MySql.Data.MySqlClient
Public Class Consulta_General
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim consulta As String
    Dim indiceFila As Integer
    Dim celdaID As Integer

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        TablaConsulta.ReadOnly = True

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
                conexion.Open()
                'MsgBox("Conexión exitosa")
            End If
        Catch ex As Exception
            MsgBox("Fallo al conectar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim opcion As Integer
        Dim lista As Byte
        opcion = OpcionesBox.SelectedIndex

        Try
            Select Case opcion
                Case 0
                    txtOpcion.Text = "Compras"
                    consulta = "SELECT productos.idProducto,compras.idCompras,fechaCompra,nombreProducto,marca,compras.cantidad,compras.precio,nombreEmpresa FROM compras INNER JOIN proveedores ON compras.RIF = proveedores.RIF INNER JOIN relacion_compras_productos ON compras.idCompras = relacion_compras_productos.idCompras INNER JOIN productos ON relacion_compras_productos.idProducto = productos.idProducto"
                    adaptador = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "compras")
                    lista = datos.Tables("compras").Rows.Count

                    If lista <> 0 Then
                        TablaConsulta.DataSource = Nothing
                        TablaConsulta.DataSource = datos
                        TablaConsulta.DataMember = "compras"
                        TablaConsulta.Columns(0).Visible = False
                    Else
                        MsgBox("No se encontraron registros")
                        OpcionesBox.SelectedIndex = -1
                    End If
                Case 1
                    txtOpcion.Text = "Ventas"
                    consulta = "SELECT * FROM ventas"
                    adaptador = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "ventas")
                    lista = datos.Tables("ventas").Rows.Count

                    If lista <> 0 Then
                        TablaConsulta.DataSource = Nothing
                        TablaConsulta.DataSource = datos
                        TablaConsulta.DataMember = "ventas"
                    Else
                        MsgBox("No se encontraron registros")
                    End If
                Case 2
                    txtOpcion.Text = "Proveedores"
                    consulta = "SELECT * FROM proveedores"
                    adaptador = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "proveedores")
                    lista = datos.Tables("proveedores").Rows.Count

                    If lista <> 0 Then
                        TablaConsulta.DataSource = Nothing
                        TablaConsulta.DataSource = datos
                        TablaConsulta.DataMember = "proveedores"
                    Else
                        MsgBox("No se encontraron registros")
                    End If
                Case 3
                    txtOpcion.Text = "Clientes"
                    consulta = "SELECT * FROM clientes"
                    adaptador = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "clientes")
                    lista = datos.Tables("clientes").Rows.Count

                    If lista <> 0 Then
                        TablaConsulta.DataSource = Nothing
                        TablaConsulta.DataSource = datos
                        TablaConsulta.DataMember = "clientes"
                    Else
                        MsgBox("No se encontraron registros")
                    End If
                Case 4
                    txtOpcion.Text = "Productos"
                    consulta = "SELECT * FROM productos"
                    adaptador = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "productos")
                    lista = datos.Tables("productos").Rows.Count

                    If lista <> 0 Then
                        TablaConsulta.DataSource = Nothing
                        TablaConsulta.DataSource = datos
                        TablaConsulta.DataMember = "productos"
                    Else
                        MsgBox("No se encontraron registros")
                    End If
                Case 5
                    txtOpcion.Text = "Trabajadores"
                    consulta = "SELECT idTrabajadores,nombre,telefono,cargo FROM trabajadores INNER JOIN cargos ON trabajadores.idCargo = cargos.idCargo"
                    adaptador = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "trabajadores")
                    lista = datos.Tables("trabajadores").Rows.Count

                    If lista > 0 Then
                        TablaConsulta.DataSource = Nothing
                        TablaConsulta.DataSource = datos
                        TablaConsulta.DataMember = "trabajadores"
                    Else
                        MsgBox("No se encontraron registros")
                    End If
                Case Else
                    MsgBox("No se ha seleccionado una opción válida.")
            End Select
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        TablaConsulta.DataSource = Nothing

        MenuPrincipal.Show()
        conexion.Close()
        Me.Close()
        OpcionesBox.SelectedIndex = -1
        txtOpcion.Clear()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim comandos As New MySqlCommand
        Dim opciones As New Integer
        opciones = OpcionesBox.SelectedIndex

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
                conexion.Open()
                'MsgBox("Conexión exitosa")
            Else
                conexion.Close()
                conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
                conexion.Open()
            End If
        Catch ex As Exception
            MsgBox("Fallo al conectar: " & ex.Message)
        End Try

        Select Case opciones
            Case 0
                Try
                    comandos = New MySqlCommand("DELETE FROM relacion_compras_productos WHERE idCompras = " & indiceFila & " AND idProducto = " & celdaID, conexion)
                    comandos.ExecuteNonQuery()

                    comandos = New MySqlCommand("DELETE FROM compras WHERE idCompras = " & indiceFila, conexion)
                    comandos.ExecuteNonQuery()
                    MsgBox("Registro eliminado")
                    btnCargar.PerformClick()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 4

            Case Else
        End Select
        

        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TablaConsulta_Click(sender As Object, e As EventArgs) Handles TablaConsulta.Click

    End Sub

    Private Sub TablaConsulta_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TablaConsulta.RowHeaderMouseClick
        Dim opcion As Integer
        Dim NumeroDeFilaSeleccionada As Integer
        opcion = OpcionesBox.SelectedIndex

        Select Case opcion
            Case 0
                If TablaConsulta.Rows.Count > 0 Then
                    btnEliminar.Enabled = True
                    NumeroDeFilaSeleccionada = TablaConsulta.CurrentRow.Index

                    indiceFila = TablaConsulta.Item(1, NumeroDeFilaSeleccionada).Value
                    Try
                        consulta = "SELECT idProducto FROM relacion_compras_productos WHERE idCompras = " & indiceFila
                        adaptador = New MySqlDataAdapter(consulta, conexion)
                        datos = New DataSet
                        adaptador.Fill(datos, "relacion_compras_productos")
                        celdaID = datos.Tables("relacion_compras_productos").Rows(0).Item("idProducto")
                    Catch ex As Exception
                        MsgBox("Falla en la búsqueda: " & ex.Message)
                    End Try
                    'MsgBox("FILA: " & NumeroDeFilaSeleccionada & " COLUMNA: " & indiceFila)
                End If
            Case 1

            Case 2

            Case 3

            Case 4
            Case Else
                btnEliminar.Enabled = False

        End Select
    End Sub

    Private Sub TablaConsulta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaConsulta.CellContentClick

    End Sub

    Private Sub OpcionesBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OpcionesBox.SelectedIndexChanged

    End Sub
End Class