Imports MySql.Data.MySqlClient
Public Class ManageCus
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub

    Private Sub ManageCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            query = "SELECT * FROM customers"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "customers")
            DataGridView1.DataSource = dataset
            DataGridView1.DataMember = "customers"
        Catch ex As MySqlException
            MsgBox("Error is: " & ex.Message)
        End Try
        connection.Close()
        txtCustomerID.Enabled = False
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim ans = MessageBox.Show("Do you want to save changes?", "Data", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "UPDATE customers SET name ='" & txtName.Text & "', phone = '" & txtPhone.Text & "', email ='" &
                     txtEmail.Text & "', address ='" & txtAddress.Text & "', postalcode ='" & txtPostal.Text & "' WHERE customer_id = " & txtCustomerID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Update Successfully")
                Else
                    MsgBox("Failed to Update")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            End Try
            connection.Close()
        End If
        ManageCus_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Data", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "INSERT INTO customers (name, phone, email, address, postalcode) 
                            VALUES ('" & txtName.Text & "','" & txtPhone.Text & "','" &
                                txtEmail.Text & "','" & txtAddress.Text & "','" & txtPostal.Text & "')"
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record inserted to database")
                Else
                    MsgBox("Failed to insert")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            End Try
            connection.Close()
        End If
        ManageCus_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ans = MessageBox.Show("Do you want to delete this record?", "Data", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "DELETE FROM customers WHERE customer_id = " & txtCustomerID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Deleted Successfully")
                Else
                    MsgBox("Failed to Delete")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            End Try
            sql = "ALTER TABLE customers auto_increment = 0"
            cmd = New MySqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
        End If
        ManageCus_Load(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAddress.Clear()
        txtCustomerID.Clear()
        txtEmail.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtPostal.Clear()
        txtSearch.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            connection.Open()
            query = "SELECT * FROM customers WHERE name LIKE '%" & txtSearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "customers")
            DataGridView1.DataSource = dataset
            DataGridView1.DataMember = "customers"
        Catch ex As MySqlException
            MsgBox("Error is: " & ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtCustomerID.Text = DataGridView1(0, row).Value.ToString
        txtName.Text = DataGridView1(1, row).Value.ToString
        txtPhone.Text = DataGridView1(2, row).Value.ToString
        txtEmail.Text = DataGridView1(3, row).Value.ToString
        txtAddress.Text = DataGridView1(4, row).Value.ToString
        txtPostal.Text = DataGridView1(5, row).Value.ToString
    End Sub
End Class