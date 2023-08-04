Imports MySql.Data.MySqlClient
Public Class Mechanics
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter
    Private Sub Mechanics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMechanicID.Enabled = False
        txtDateHired.Enabled = False
        Try
            connection.Open()
            sql = "SELECT mechanic_id AS ID, fname AS Name, datehired AS Date_Hired FROM mechanics"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "mechanics")
            dtgMechanics.DataSource = dataset
            dtgMechanics.DataMember = "mechanics"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub txtSearchMechanic_TextChanged(sender As Object, e As EventArgs) Handles txtSearchMechanic.TextChanged
        Try
            connection.Open()
            sql = "SELECT mechanic_id AS ID, fname AS Name, datehired AS Date_Hired FROM mechanics WHERE fname LIKE '%" & txtSearchMechanic.Text & "%'"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "mechanics")
            dtgMechanics.DataSource = dataset
            dtgMechanics.DataMember = "mechanics"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub dtgMechanics_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgMechanics.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtMechanicID.Text = dtgMechanics(0, row).Value
        txtMechanicName.Text = dtgMechanics(1, row).Value
        txtDateHired.Text = dtgMechanics(2, row).Value
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Save record?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "INSERT INTO mechanics(fname, datehired) VALUES('" & txtMechanicName.Text & "','" & dateHire.Value.ToString("yyyy-MM-dd") & "')"
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfuly inserted!")
                Else
                    MsgBox("Failed to insert :(")
                End If
            Catch ex As MySqlException
                MsgBox(" Error :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
            connection.Close()
            Mechanics_Load(sender, e)
        End If
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim ans = MessageBox.Show("Do you want to save changes?", "Save Record", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "UPDATE mechanics SET fname = '" & txtMechanicName.Text & "' WHERE mechanic_id = " & txtMechanicID.Text
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
            Mechanics_Load(sender, e)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ans = MessageBox.Show("Are you sure that do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "DELETE FROM mechanics WHERE mechanic_id = " & txtMechanicID.Text
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
            sql = "ALTER TABLE mechanics Auto_Increment = 0"
            cmd = New MySqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
            Mechanics_Load(sender, e)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub
End Class