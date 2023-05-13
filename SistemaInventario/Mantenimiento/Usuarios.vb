Imports System.Data.SqlClient
Public Class Usuarios
    Private Sub limpiar()
        tusuario.Text = ""
        tclave.Text = ""
        tconfirmar.Text = ""
        tnombre.Text = ""
        tnivel.Text = Nothing
        tusuario.Focus()
    End Sub
    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection
        'conexion.ConnectionString = cnn
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        MenuPrincipal.Show()
        Me.Hide()
        limpiar()
    End Sub
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub tusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tusuario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tclave.Focus()
        End If
    End Sub

    Private Sub tusuario_Validated(sender As Object, e As EventArgs) Handles tusuario.Validated
        'Codigo original SQL en archivo original
    End Sub

    Private Sub tconfirmar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tconfirmar.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnombre.Focus()
        End If
    End Sub
    Private Sub tconfirmar_Validated(sender As Object, e As EventArgs) Handles tconfirmar.Validated
        If tclave.Text <> tconfirmar.Text Then
            MsgBox("Las claves no coinciden")
            tclave.Focus()
            Exit Sub
        Else
            MsgBox("Las claves coinciden")
            tnombre.Focus() ' podria ser el nivel o el boton de aceptar
        End If
    End Sub
    Private Sub tclave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tclave.KeyPress
        If AscW(e.KeyChar) + Keys.Enter Then
            tconfirmar.Focus()
        End If
    End Sub
    Private Sub tnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnombre.KeyPress
        If AscW(e.KeyChar) >= 65 And AscW(e.KeyChar) <= 90 Or AscW(e.KeyChar) = 97 Or AscW(e.KeyChar) = 122 Or AscW(e.KeyChar) = 9 Then
            If AscW(e.KeyChar) = 13 Then
                tnivel.Focus()
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub
    Private Sub tnivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnivel.KeyPress
        If AscW(e.KeyChar) >= 48 And AscW(e.KeyChar) <= 57 Or AscW(e.KeyChar) = 13 Or AscW(e.KeyChar) = 8 Or AscW(e.KeyChar) = 32 Then
            If AscW(e.KeyChar) = 13 Then
                btnaceptar.Focus()
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub
End Class

