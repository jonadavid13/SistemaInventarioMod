Imports System.Data.SqlClient
Public Class Cliente

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection
        'conexion.ConnectionString = cnn
    End Sub

    Private Sub limpiar()
        tcliente.Text = ""
        tdireccion.Text = ""
        ttelefono.Text = ""
        tidentidad.Text = ""
        tidentidad.Focus()
    End Sub

    Private Sub tidentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tidentidad.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcliente.Focus()
        End If
    End Sub

    Private Sub tidentidad_Validated(sender As Object, e As EventArgs) Handles tidentidad.Validated
        

    End Sub
    Private Sub tcodigo_Validated(sender As Object, e As EventArgs) Handles tcodigo.Validated
        'contador = contador + 1
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()

    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        
    End Sub
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        MenuPrincipal.Show()
        Me.Hide()
        limpiar()
    End Sub
    Private Sub tcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcliente.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdireccion.Focus()
        End If
    End Sub
    Private Sub tdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdireccion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            ttelefono.Focus()
        End If
    End Sub


End Class