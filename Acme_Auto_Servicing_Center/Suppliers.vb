Imports MySql.Data.MySqlClient
Public Class Suppliers
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter
    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSupplierID.Enabled = False

        Try
            connection.Open()
            query = "SELECT * FROM suppliers"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "suppliers")
            dtgSuppliers.DataSource = dataset
            dtgSuppliers.DataMember = "suppliers"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click, BtnClear.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Save Records", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "INSERT INTO suppliers(name, email, phone) VALUES ('" & txtSupplierName.Text & "','" & txtEmail.Text & "','" & txtPhone.Text & "')"
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record saved")
                Else
                    MsgBox("Record not save")
                End If
            Catch ex As MySqlException
                MsgBox("Error inserting data to database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim ans = MessageBox.Show("Do you want to save changes?", "Save Record", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "UPDATE suppliers SET name = '" & txtSupplierName.Text & "', email = '" & txtEmail.Text & "', phone = '" &
                        txtPhone.Text & "' WHERE supplier_id = " & txtSupplierID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Updated successfully")
                Else
                    MsgBox("Failed to update")
                End If
            Catch ex As MySqlException
                MsgBox("Error updating data from database. Error is :" & ex.Message)
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ans = MessageBox.Show("Are you sure that do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "DELETE FROM suppliers WHERE supplier_id = " & txtSupplierID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Deleted")
                Else
                    MsgBox("Record  Not Deleted")
                End If
            Catch ex As MySqlException
                MsgBox("Error in deleting data from database. Error is :" & ex.Message)
            End Try
        End If
        sql = "ALTER TABLE suppliers Auto_Increment = 0"
        cmd = New MySqlCommand(sql, connection)
        cmd.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            connection.Open()
            query = "SELECT * FROM suppliers WHERE name LIKE '%" & txtSearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "suppliers")
            dtgSuppliers.DataSource = dataset
            dtgSuppliers.DataMember = "suppliers"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub
    Private Sub dtgSuppliers_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgSuppliers.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtSupplierID.Text = (dtgSuppliers(0, row).Value)
        txtSupplierName.Text = Convert.ToString(dtgSuppliers(1, row).Value)
        txtEmail.Text = Convert.ToString(dtgSuppliers(2, row).Value)
        txtPhone.Text = Convert.ToString(dtgSuppliers(3, row).Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub
End Class