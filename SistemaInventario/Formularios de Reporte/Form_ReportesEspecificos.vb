Imports System.Data.SqlClient
Public Class Form_ReportesEspecificos

    Dim tabladatos As DataTable
   
    Private Sub Form_ReportesESpecificos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection
        'conexion.ConnectionString = cnn
    End Sub
    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        ' codigo original SQL en el archivo original
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cbobusqueda1.Text = Nothing
        tValor.Text = ""
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
    Private Sub Cbocriterio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbocriterio.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Cbobusqueda1.Focus()
        End If
    End Sub
    Private Sub Cbocriterio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbocriterio.SelectedIndexChanged
        For x = 0 To Cbobusqueda1.Items.Count - 1
            Cbobusqueda1.Items.RemoveAt(0)
        Next
        Select Case Cbocriterio.SelectedIndex
            Case 0
                Cbobusqueda1.Items.Add("usuario")
                Cbobusqueda1.Items.Add("clave")
                Cbobusqueda1.Items.Add("nombre")
                Cbobusqueda1.Items.Add("nivel")
            Case 1
                Cbobusqueda1.Items.Add("codigo")
                Cbobusqueda1.Items.Add("identidad")
                Cbobusqueda1.Items.Add("cliente")
                Cbobusqueda1.Items.Add("direccion")
                Cbobusqueda1.Items.Add("telefono")
            Case 2
                Cbobusqueda1.Items.Add("codigo")
                Cbobusqueda1.Items.Add("descripcion")
                Cbobusqueda1.Items.Add("existencia")
                Cbobusqueda1.Items.Add("valorc")
                Cbobusqueda1.Items.Add("valorv")
                Cbobusqueda1.Items.Add("categoria")
                Cbobusqueda1.Items.Add("fechaven")
            Case 3
                Cbobusqueda1.Items.Add("nfactura")
                Cbobusqueda1.Items.Add("fecha")
                Cbobusqueda1.Items.Add("codigo")
                Cbobusqueda1.Items.Add("descripcion")
                Cbobusqueda1.Items.Add("cantidad")
                Cbobusqueda1.Items.Add("subtotal1")
                Cbobusqueda1.Items.Add("subtotal2")
                Cbobusqueda1.Items.Add("impuesto")
                Cbobusqueda1.Items.Add("descuento")
                Cbobusqueda1.Items.Add("total")
        End Select
    End Sub

    Private Sub Form_ReportesEspecificos_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class