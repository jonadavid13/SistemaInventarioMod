Imports System.Data.SqlClient
Public Class Inventario

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Inventario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection
        'conexion.ConnectionString = cnn
    End Sub

    Private Sub limpiar()
        tdescripcion.Text = ""
        nexistencia.Text = ""
        tvalorc.Text = ""
        tvalorv.Text = ""
        categoria.Text = Nothing
        fechaven.Text = ""
        tpropietario.Text = ""
        tcodigo.Text = ""
        tcodigo.Focus()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblfecha.Text = Format(Now(), "d")
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        MenuPrincipal.Show()
        Me.Hide()
        limpiar()
    End Sub
    Private Sub tdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdescripcion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nexistencia.Focus()
        End If
    End Sub
    Private Sub nexistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nexistencia.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tvalorc.Focus()
        End If
    End Sub
    Private Sub tvalorc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tvalorc.KeyPress
        If AscW(e.KeyChar) >= 48 And AscW(e.KeyChar) <= 57 Or AscW(e.KeyChar) = 13 Or AscW(e.KeyChar) = 8 Or AscW(e.KeyChar) = 32 Then
            If AscW(e.KeyChar) = 13 Then
                btnaceptar.Focus()
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub
    Private Sub tvalorv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tvalorv.KeyPress
        If AscW(e.KeyChar) >= 48 And AscW(e.KeyChar) <= 57 Or AscW(e.KeyChar) = 13 Or AscW(e.KeyChar) = 8 Or AscW(e.KeyChar) = 32 Then
            If AscW(e.KeyChar) = 13 Then
                btnaceptar.Focus()
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub
    Private Sub categoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles categoria.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            fechaven.Focus()
        End If
    End Sub
    Private Sub fechaven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fechaven.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tpropietario.Focus()
        End If
    End Sub
    Private Sub tpropietario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpropietario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnaceptar.Focus()
        End If
    End Sub
    Private Sub tcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcodigo.KeyPress
        If AscW(e.KeyChar) >= 48 And AscW(e.KeyChar) <= 57 Or AscW(e.KeyChar) = 13 Or AscW(e.KeyChar) = 8 Or AscW(e.KeyChar) = 32 Then
            If AscW(e.KeyChar) = 13 Then
                btnaceptar.Focus()
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub
    Private Sub tcodigo_Validated(sender As Object, e As EventArgs) Handles tcodigo.Validated
        'Validación del codigo
    End Sub
End Class