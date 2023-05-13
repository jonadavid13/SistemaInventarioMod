Imports MySql.Data.MySqlClient
Public Class Acceso
    Dim comandos As New MySqlCommand
    Dim conexion As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim consulta As String
    Dim continuar As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'Dim database As New conexionDB <-- prueba de conexión de base de datos --
        'database.conectar()

        Try
            conexion.ConnectionString = "server=localhost ; database=inventario ; user id=root ; port=3306"
            conexion.Open()
            'MsgBox("Conexión exitosa")
        Catch ex As Exception
            MsgBox("Fallo al conectar: " & ex.Message)
        End Try

        If txtClave.Text = "" Then
            btnIngresar.Enabled = False
        End If
        If txtUsuario.Text = "" Then
            btnIngresar.Enabled = False
        End If

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim dato As Integer
        Dim lista As Byte
        Dim count As String = "SELECT count(*) FROM trabajadores"
        Dim clave As String
        adaptador = New MySqlDataAdapter(count, conexion)
        datos = New DataSet
        datos.Reset()
        adaptador.Fill(datos, "trabajadores")
        dato = datos.Tables("trabajadores").Rows(0).Item("count(*)")

        Try
            consulta = "SELECT claveAcceso FROM trabajadores WHERE idTrabajadores ='" & txtUsuario.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Reset()
            adaptador.Fill(datos, "trabajadores")
            lista = datos.Tables("trabajadores").Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If lista <> 0 Then
            clave = datos.Tables("trabajadores").Rows(0).Item("claveAcceso")

            If txtClave.Text = clave Then
                ProgressBar1.Show()
                Timer1.Start()
                continuar = True
                conexion.Close()
            Else
                MsgBox("Clave incorrecta, intente nuevamente. ")
                txtClave.Clear()
                txtClave.Focus()
            End If
        Else
            MsgBox("Usuario no encontrado")
            txtClave.Clear()
            txtUsuario.Focus()
        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Desea salir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            conexion.Close()
            End
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        If continuar = True Then
            ProgressBar1.Increment(40)

            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
                MsgBox("Bienvenido al Sistema")
                MenuPrincipal.Show()
                MenuPrincipal.mostrarUsuario()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub txtClave_Validated(sender As Object, e As EventArgs)
        If txtUsuario.Text = "" Or txtClave.Text = "" Then
            mensaje.Text = "No pueden quedar valores vacios"
            btnSalir.Focus()
            Exit Sub
        End If
        'sql = "select = * from Acceso where usuario *" 'revisar 12:08
        'sql += "'" & txtUsuario.Text & "' and clave*"
        'sql += "'" & txtClave.Text & "'"
        'conexion.Open()
        'adaptar = New SqlDataAdapter(sql, conexion)
        'almacen = New DataSet
        'conexion.Close()
        'adaptar.Fill(almacen, "Acceso")
        'resultado = almacen.Tables("Acceso").Rows.Count
        'If resultado > 0 Then
        ' registro = almacen.Tables("Acceso").Rows(0)
        ' vnivel = registro("nivel")
        ' btnIngresar.Visible = True
        ' btnIngresar.Focus()
        ' ElseIf resultado = 0 Then
        ' btnIngresar.Visible = False
        ' MsgBox("No se pudo Ingresar")
        ' btnSalir.Focus()
        ' End If
    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.BackColor = Color.Aquamarine
        txtClave.BackColor = Color.White
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtClave.Focus()
        End If

        Select Case Asc(e.KeyChar)
            Case Is = 8
            Case Is = 27
                'Escape

            Case Else
                If InStr("1234567890'", e.KeyChar) = 0 Then
                    Beep()
                    e.Handled = True
                End If
        End Select
    End Sub

    Private Sub txtClave_GotFocus(sender As Object, e As EventArgs) Handles txtClave.GotFocus
        txtClave.BackColor = Color.Aquamarine
        txtUsuario.BackColor = Color.White
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtClave_Validated(sender, e)
        End If
        
        Select Case Asc(e.KeyChar)
            Case Is = 13
                btnIngresar.PerformClick()
        End Select
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.Text = "" Then
            btnIngresar.Enabled = False
        ElseIf txtClave.Text <> "" Then
            btnIngresar.Enabled = True
        End If
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        If txtClave.Text = "" Then
            btnIngresar.Enabled = False
        ElseIf txtUsuario.Text <> "" Then
            btnIngresar.Enabled = True
        End If

    End Sub

    Private Sub shortchut_Click(sender As Object, e As EventArgs)
        txtUsuario.Text = 27091183
        txtClave.Text = "start"
        btnIngresar.PerformClick()

    End Sub
End Class
