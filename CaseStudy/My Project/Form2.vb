Imports MySql.Data.MySqlClient
Public Class Form2

    Dim connStr As String = "server=localhost;port=3306;user id=root;password=;database=hotelbayview;"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Using conn As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter("SELECT * FROM guest", conn)
            Dim dt As New DataTable()
        End Using
    End Sub

End Class