Public Class Form_Reportes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If Rbcliente.Checked = True Then
        'CCliente.Show()
        'ElseIf Rbinventario.Checked = True Then
        'CInvetario.show()
        'ElseIf Rbusuario.Checked = True Then
        'CUsuario.Show()
        'ElseIf Rbfactura.Checked = True Then
        'CFactura.Show()
        'End If
        'Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Form_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class