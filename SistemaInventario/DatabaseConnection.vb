Imports MySql.Data.MySqlClient
Module DatabaseConnection
    Public Class conexionDB
        Private comando As New MySqlCommand
        Dim cadena As String = "server=localhost ; database=inventario ; user id=root ; port=3306"
        Public conexion As MySqlConnection = New MySqlConnection(cadena)

        Public Sub conectar()
            Try
                conexion.Open()
                MsgBox("Conexión exitosa")
                'conexion.Close()
                'MsgBox("Conexión finalizada")
            Catch ex As Exception
                MsgBox("La conexión no fue exitosa")
            End Try
        End Sub

        Public Sub apagar()
            Try
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End Sub
    End Class
End Module
