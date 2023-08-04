Imports MySql.Data.MySqlClient
Public Class Parts
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter
    Private Sub Parts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPartID.Enabled = False
        txtStock.Enabled = False
        Try
            connection.Open()
            sql = "SELECT p.part_id, p.name, p.costprice, p.sellprice, s.quantity 
                    FROM parts p INNER JOIN stock s ON (p.part_id = s.part_id)"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "parts_stock")
            dtgParts.DataSource = dataset
            dtgParts.DataMember = "parts_stock"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Save record?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "INSERT INTO parts(name, costprice, sellprice) VALUES('" & txtName.Text & "','" & txtCostPrice.Text & "','" & txtSellPrice.Text & "')"
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfuly inserted!")
                Else
                    MsgBox("Failed to insert :(")
                End If
                sql = "insert into stock(part_id, quantity) values((SELECT max(part_id) FROM parts), 0);"
                cmd = New MySqlCommand(sql, connection)
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MsgBox(" Error :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
            connection.Close()
            Parts_Load(sender, e)
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim ans = MessageBox.Show("Do you want to save changes?", "Save Record", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "UPDATE parts SET name = '" & txtName.Text & "', costprice = '" & txtCostPrice.Text &
                    "', sellprice = '" & txtSellPrice.Text & "' WHERE part_id = " & txtPartID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Changed")
                Else
                    MsgBox("Record Not Save")
                End If
            Catch ex As MySqlException
                MsgBox("Error updating data from database. Error is :" & ex.Message)
            End Try
            connection.Close()
            Parts_Load(sender, e)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ans = MessageBox.Show("Are you sure that do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "DELETE FROM parts WHERE part_id = " & txtPartID.Text
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
            sql = "ALTER TABLE parts Auto_Increment = 0"
            cmd = New MySqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
            Parts_Load(sender, e)
        End If
    End Sub

    Private Sub txtSupplierSearch_TextChanged(sender As Object, e As EventArgs) Handles txtpartsSearch.TextChanged
        Try
            connection.Open()
            sql = "SELECT p.part_id, p.name, p.costprice, p.sellprice, s.quantity 
                    FROM parts p INNER JOIN stock s ON (p.part_id = s.part_id) WHERE p.name LIKE '%" & txtpartsSearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "parts_stock")
            dtgParts.DataSource = dataset
            dtgParts.DataMember = "parts_stock"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub
    Private Sub dtgParts_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgParts.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtPartID.Text = (dtgParts(0, row).Value)
        txtName.Text = Convert.ToString(dtgParts(1, row).Value)
        txtCostPrice.Text = Convert.ToString(dtgParts(2, row).Value)
        txtSellPrice.Text = Convert.ToString(dtgParts(3, row).Value)
        txtStock.Text = Convert.ToString(dtgParts(4, row).Value)
    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        Me.Hide()
        OrdersParts.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCostPrice.Clear()
        txtName.Clear()
        txtpartsSearch.Clear()
        txtSellPrice.Clear()
        txtStock.Clear()
        txtCostPrice.Clear()
        txtPartID.Clear()
    End Sub
End Class