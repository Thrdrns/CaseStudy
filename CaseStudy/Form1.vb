Imports MySql.Data.MySqlClient
Public Class Form1

    Dim connStr As String = "server=localhost;port=3306;user id=root;password=;database=hotelbayview;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Using conn As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter("SELECT * FROM guest", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInput() Then Exit Sub
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim sql As String =
                    "INSERT INTO guest (GuestID, FirstName, LastName, Email, Phone, Preferences) " &
                    "VALUES (@qn, @fn, @ln, @em, @ph, @pr)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@qn", txtGuestID.Text.Trim())
                    cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@pr", txtPreferences.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Guest added.")
            ClearFields()
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error adding guest: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtGuestID.Text = "" Then
            MessageBox.Show("Select a guest from the table first.")
            Exit Sub
        End If
        If Not ValidateInput() Then Exit Sub
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim sql As String =
                    "UPDATE guest SET FirstName=@fn, LastName=@ln, Email=@em, " &
                    "Phone=@ph, Preferences=@pr WHERE GuestID=@id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@pr", txtPreferences.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", txtGuestID.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Guest updated.")
            ClearFields()
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error updating guest: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtGuestID.Text = "" Then
            MessageBox.Show("Select a guest from the table first.")
            Exit Sub
        End If
        If MessageBox.Show("Delete this guest?", "Confirm",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM guest WHERE GuestID=@id", conn)
                    cmd.Parameters.AddWithValue("@id", txtGuestID.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Guest deleted.")
            ClearFields()
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error deleting guest: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
    Private Function ValidateInput() As Boolean
        If txtFirstName.Text.Trim() = "" OrElse txtLastName.Text.Trim() = "" Then
            MessageBox.Show("First name and last name are required.")
            Return False
        End If
        Return True
    End Function

    Private Sub ClearFields()
        txtGuestID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtPreferences.Clear()
        txtFirstName.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim f2 As New Form2()
        Me.Hide()
        f2.Show()
    End Sub
End Class
