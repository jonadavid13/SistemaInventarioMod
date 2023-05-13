Imports MySql.Data.MySqlClient
Public Class MenuPrincipal
    Dim consulta As String
    Dim conexion As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub mostrarUsuario()
        Dim lista As Byte
        Dim idUsuario As Integer = Acceso.txtUsuario.Text
        Dim idCargo As Integer

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
                conexion.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try

        Try
            consulta = "SELECT nombre,idCargo FROM trabajadores WHERE idTrabajadores ='" & idUsuario & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "trabajadores")
            lista = datos.Tables("trabajadores").Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If lista > 0 Then
            lblNombre.Text = datos.Tables("trabajadores").Rows(0).Item("nombre")
            userID.Text = idUsuario 'Ya que conocemos el ID del trabajador a partir de la encuesta anterior
            idCargo = datos.Tables("trabajadores").Rows(0).Item("idCargo")

            consulta = "SELECT cargo FROM cargos WHERE idCargo ='" & idCargo & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "cargos")
            userCargo.Text = datos.Tables("cargos").Rows(0).Item("cargo")

        End If

        'Validacion de permisos de Trabajadores segun su ID
        If idCargo = 3 Then
            btnCompra.Visible = False
        ElseIf idCargo = 1 Or 2 Then
            btnCompra.Visible = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dispose()
    End Sub

    Private Sub FacturaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Facturacion.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioToolStripMenuItem.Click
        Inventario.Show()
        Me.Hide()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        ' Facturacion.Show()
        Me.Hide()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        'Consulta_Genreral_Cliente.show()
        Me.Hide()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        'Consulta_Especifica_Cliente.show()
        Me.Hide()
    End Sub

    Private Sub InventarioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioToolStripMenuItem.Click
        '  Consulta_General_Inventario.show()
        Me.Hide()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        'Try
        'If registro("nivel") = "00" Then
        ' Usuarios.Show()
        'Me.Hide()
        ' Else
        ' MsgBox("No tiene acceso a este formulario")
        ' End If
        ' Catch ex As Exception
        'MsgBox("Intente de nuevo mas tarde")
        ' End Try
    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        'Try
        'If registro("nivel") = "00" Then
        ''Consulta_General_Usuario.Show()
        'Me.Hide()
        ' Else
        'MsgBox("No tiene acceso a este formulario")
        '  End If
        '  Catch ex As Exception
        'MsgBox("Intente de nuevo mas tarde")
        '   End Try
    End Sub

    Private Sub UsuarioToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        'Try
        'If registro("nivel") = "00" Then
        ''Consulta_Especifica_Usuario.Show()
        '    Me.Hide()
        '    Else
        '     MsgBox("No tiene acceso a este formulario")
        '     End If
        '     Catch ex As Exception
        'MsgBox("Intente de nuevo mas tarde")
        '     End Try

    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Acceso.txtUsuario.Clear()
        Acceso.txtClave.Clear()
        lblNombre.ResetText()
        userID.ResetText()
        userCargo.ResetText()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        Acceso.ProgressBar1.Value = 0

        Acceso.Show()
        Acceso.txtUsuario.Focus()
        Me.Hide()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        ' Form_Reportes.show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static IM
        IM = IM + 1
        '  PictureBox1.image = ImageList.Images(IM)  'Quejesta verga
        If IM = 5 Then
            IM = 0
        End If
    End Sub

    Private Sub ReportesEspecificosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesEspecificosToolStripMenuItem.Click
        '  Form_ReportesEspecificos.show()
        Me.Hide()
    End Sub

    Private Sub ConsultasGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasGeneralesToolStripMenuItem.Click
        Consulta_General.Show()
        conexion.Close()
        Me.Hide()
    End Sub

    Private Sub ConsultasEspecificasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasEspecificasToolStripMenuItem.Click
        Consulta_Especifica.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVenta.Click

    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        Compra.Show()
        conexion.Close()
        Me.Hide()
    End Sub

    Private Sub prueba_Click(sender As Object, e As EventArgs)
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
                conexion.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try

        Try
            consulta = "SELECT t.*, @rownum := @rownum + 1 as rank FROM productos t, (SELECT @rownum := 0) r"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "productos")
            MsgBox("EXITO")
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub
End Class
