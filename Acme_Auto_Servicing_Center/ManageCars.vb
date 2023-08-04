Imports MySql.Data.MySqlClient
Public Class ManageCars
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter

    Public manuID As Integer
    Public typeID As Integer

    Public customerID As Integer
    Public modelID As Integer
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub

    Private Sub ManageCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtManufacturerID.Enabled = False
        txtModelID.Enabled = False
        txtTypeID.Enabled = False
        txtCarID.Enabled = False
        txtCarsManu.Enabled = False
        txtCarType.Enabled = False
        cmbMODtype.Items.Clear()
        cmbMODmanu.Items.Clear()
        cmbModel.Items.Clear()
        cmbCarowner.Items.Clear()
        Try
            connection.Open()
            sql = "SELECT * FROM manufacturers"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "manufacturers")
            dtgManufacturers.DataSource = dataset
            dtgManufacturers.DataMember = "manufacturers"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            sql = "SELECT * FROM types"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "types")
            dtgTypes.DataSource = dataset
            dtgTypes.DataMember = "types"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)

        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT mo.model_id, mo.name AS model, ma.name AS manufacturer, t.name AS type
                    FROM models mo INNER JOIN manufacturers ma ON
                    (ma.manufacturer_id = mo.manufacturer_id) 
                    INNER JOIN types t ON (t.type_id = mo.type_id)"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "models_manufacturers_types")
            dtgModels.DataSource = dataset
            dtgModels.DataMember = "models_manufacturers_types"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT name FROM manufacturers"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbMODmanu.Items.Add(reader("name"))
            End While
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT name FROM types"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbMODtype.Items.Add(reader("name"))
            End While
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT car_id, platenumber, mileage, cu.name AS owner, mo.name AS model, t.name AS type, ma.name AS manufacturer
                    FROM customers cu INNER JOIN cars ca ON (cu.customer_id = ca.customer_id)
                    INNER JOIN models mo ON (mo.model_id = ca.model_id) 
                    INNER JOIN manufacturers ma ON (ma.manufacturer_id = mo.manufacturer_id)
                    INNER JOIN types t ON (t.type_id = mo.type_id);"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "cars_customers_models_types_manufacturers")
            dtgCars.DataSource = dataset
            dtgCars.DataMember = "cars_customers_models_types_manufacturers"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT name FROM models"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbModel.Items.Add(reader("name"))
            End While
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT name FROM customers"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbCarowner.Items.Add(reader("name"))
            End While
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Save Records", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "INSERT INTO manufacturers(name) VALUES('" & txtmanuName.Text & "')"
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
                MsgBox("Error in code. Erro is :" & exs.Message)
            End Try
            connection.Close()
        End If
        ManageCars_Load(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ans = MessageBox.Show("Do you want to save changes?", "Save Record", MessageBoxButtons.YesNo)

        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "UPDATE manufacturers SET name='" & txtmanuName.Text & "'
                    WHERE manufacturer_id=" & txtManufacturerID.Text
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
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ans = MessageBox.Show("Are you sure that do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "DELETE FROM manufacturers WHERE manufacturer_id = " & txtManufacturerID.Text
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
        sql = "ALTER TABLE manufacturers Auto_Increment = 0"
        cmd = New MySqlCommand(sql, connection)
        cmd.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtManufacturerID.Clear()
        txtmanuName.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchManu.TextChanged
        Try
            connection.Open()
            sql = "SELECT * FROM manufacturers WHERE name LIKE '%" & txtSearchManu.Text & "%'"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "manufacturers")
            dtgManufacturers.DataSource = dataset
            dtgManufacturers.DataMember = "manufacturers"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub dtgManufacturers_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgManufacturers.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtManufacturerID.Text = (dtgManufacturers(0, row).Value)
        txtmanuName.Text = Convert.ToString(dtgManufacturers(1, row).Value)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Save record?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "INSERT INTO types(name) VALUES('" & txtTypeName.Text & "')"
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
        End If
        connection.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ans = MessageBox.Show("Do you want to update the records?", "Update records?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "UPDATE types SET name ='" & txtTypeName.Text & "' WHERE type_id = " & txtTypeID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfuly changed!")
                Else
                    MsgBox("Failed to change :(")
                End If
            Catch ex As MySqlException
                MsgBox("Error inserting data to database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ans = MessageBox.Show("Do you want to delete this records?", "Delete records?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "DELETE FROM types WHERE type_id = " & txtTypeID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfuly deleted!")
                Else
                    MsgBox("Failed to delete :(")
                End If
            Catch ex As MySqlException
                MsgBox("Error in deleting the data from database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
        End If
        sql = "ALTER TABLE types Auto_Increment = 0"
        cmd = New MySqlCommand(sql, connection)
        cmd.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub dtgTypes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgTypes.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtTypeID.Text = (dtgTypes(0, row).Value)
        txtTypeName.Text = Convert.ToString(dtgTypes(1, row).Value)
    End Sub

    Private Sub txtTypeSearch_TextChanged(sender As Object, e As EventArgs) Handles txtTypeSearch.TextChanged
        Try
            connection.Open()
            sql = "SELECT * FROM types WHERE name LIKE '%" & txtTypeSearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "types")
            dtgTypes.DataSource = dataset
            dtgTypes.DataMember = "types"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)

        End Try
        connection.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Save record?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                query = "SELECT manufacturer_id FROM manufacturers WHERE name = '" & cmbMODmanu.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    manuID = reader("manufacturer_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
            Try
                connection.Open()
                query = "SELECT type_id FROM types WHERE name = '" & cmbMODtype.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    typeID = reader("type_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)

            End Try
            connection.Close()
            Try
                connection.Open()
                sql = "INSERT INTO models(name, manufacturer_id, type_id) VALUES ('" & txtModelName.Text & "'," & manuID & "," & typeID & ")"
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfuly inserted!")
                Else
                    MsgBox("Failed to insert :(")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim ans = MessageBox.Show("Do you want to delete this records?", "Delete records?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then

            Try
                connection.Open()
                sql = "DELETE FROM models WHERE model_id =" & txtModelID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfuly deleted!")
                Else
                    MsgBox("Failed to delete :(")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            sql = "ALTER TABLE models Auto_Increment = 0"
            cmd = New MySqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim ans = MessageBox.Show("Do you want to update the records?", "Update records?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                query = "SELECT manufacturer_id FROM manufacturers WHERE name = '" & cmbMODmanu.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    manuID = reader("manufacturer_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
            Try
                connection.Open()
                query = "SELECT type_id FROM types WHERE name = '" & cmbMODtype.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    typeID = reader("type_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)

            End Try
            connection.Close()
            Try
                connection.Open()
                sql = "UPDATE models SET name = '" & txtModelName.Text & "', manufacturer_id = " & manuID & ", type_id = " & typeID & " WHERE model_id =" & txtModelID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfuly changed!")
                Else
                    MsgBox("Failed to change :(")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
        End If
    End Sub

    Private Sub dtgModels_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgModels.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtModelID.Text = (dtgModels(0, row).Value)
        txtModelName.Text = Convert.ToString(dtgModels(1, row).Value)
        cmbMODmanu.Text = Convert.ToString(dtgModels(2, row).Value)
        cmbMODtype.Text = Convert.ToString(dtgModels(3, row).Value)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtModelSearch.TextChanged
        Try
            connection.Open()
            query = "SELECT mo.model_id, mo.name AS model, ma.name AS manufacturer, t.name AS type
                    FROM models mo INNER JOIN manufacturers ma ON
                    (ma.manufacturer_id = mo.manufacturer_id) 
                    INNER JOIN types t ON (t.type_id = mo.type_id) WHERE mo.name LIKE '%" & txtModelSearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "models_manufacturers_types")
            dtgModels.DataSource = dataset
            dtgModels.DataMember = "models_manufacturers_types"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim ans = MessageBox.Show("Do you want to save this records?", "Save record?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                query = "SELECT customer_id FROM customers WHERE name = '" & cmbCarowner.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    customerID = reader("customer_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()

            Try
                connection.Open()
                query = "SELECT model_id FROM models WHERE name = '" & cmbModel.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    modelID = reader("model_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
            Try
                connection.Open()
                sql = "INSERT INTO cars(mileage, platenumber, customer_id, model_id) VALUES ('" & txtMileage.Text & "','" & txtPlateNumber.Text & "'," & customerID & "," & modelID & ")"
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record saved")
                Else
                    MsgBox("Record not save")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
        End If
        ManageCars_Load(sender, e)
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        Try
            connection.Open()
            query = "SELECT mo.name, ma.name AS manu, t.name AS type
                    FROM models mo INNER JOIN manufacturers ma ON
                    (ma.manufacturer_id = mo.manufacturer_id) 
                    INNER JOIN types t ON (t.type_id = mo.type_id) WHERE mo.name = '" & cmbModel.SelectedItem & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                txtCarsManu.Text = reader("manu")
                txtCarType.Text = reader("type")
            End While
        Catch ex As MySqlException
            MsgBox("Error is: " & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim ans = MessageBox.Show("Do you want to update the records?", "Update records?", MessageBoxButtons.YesNo)

        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                query = "SELECT customer_id FROM customers WHERE name = '" & cmbCarowner.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    customerID = reader("customer_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()

            Try
                connection.Open()
                query = "SELECT model_id FROM models WHERE name = '" & cmbModel.Text & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    modelID = reader("model_id")
                End While
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
            Try
                connection.Open()
                Try
                    sql = "UPDATE cars SET mileage = '" & txtMileage.Text & "', platenumber = '" & txtPlateNumber.Text & "', customer_id = " & customerID & ", model_id = " & modelID & " WHERE car_id = " & txtCarID.Text
                    cmd = New MySqlCommand(sql, connection)
                    Dim i As Integer = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Update saved")
                    Else
                        MsgBox("Failed to update")
                    End If
                Catch ex As MySqlException
                    MsgBox("Error is: " & ex.Message)
                Catch exs As Exception
                    MsgBox("Error in code. Error is : " & exs.Message)
                End Try
            Catch ex As Exception
            End Try
            connection.Close()
            ManageCars_Load(sender, e)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim ans = MessageBox.Show("Do you want to delete this records?", "Delete records?", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "DELETE FROM cars WHERE car_id = " & txtCarID.Text
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Successfully deleted!")
                Else
                    MsgBox("Failed to delete!")
                End If
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            sql = "ALTER TABLE cars Auto_Increment = 0"
            cmd = New MySqlCommand(sql, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
            ManageCars_Load(sender, e)
        End If
    End Sub

    Private Sub dtgCars_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgCars.RowHeaderMouseClick
        Dim row As Integer = e.RowIndex
        txtCarID.Text = (dtgCars(0, row).Value)
        cmbCarowner.Text = Convert.ToString(dtgCars(3, row).Value)
        txtMileage.Text = Convert.ToString(dtgCars(2, row).Value)
        txtPlateNumber.Text = Convert.ToString(dtgCars(1, row).Value)
        cmbModel.Text = Convert.ToString(dtgCars(4, row).Value)
        txtCarsManu.Text = Convert.ToString(dtgCars(6, row).Value)
        txtCarType.Text = Convert.ToString(dtgCars(5, row).Value)
    End Sub

    Private Sub txtCarsearch_TextChanged(sender As Object, e As EventArgs) Handles txtCarsearch.TextChanged
        Try
            connection.Open()
            query = "SELECT car_id, platenumber, mileage, cu.name AS owner, mo.name AS model, t.name AS type, ma.name AS manufacturer
                    FROM customers cu INNER JOIN cars ca ON (cu.customer_id = ca.customer_id)
                    INNER JOIN models mo ON (mo.model_id = ca.model_id) 
                    INNER JOIN manufacturers ma ON (ma.manufacturer_id = mo.manufacturer_id)
                    INNER JOIN types t ON (t.type_id = mo.type_id) WHERE platenumber LIKE '%" & txtCarsearch.Text &
                    "%' OR cu.name LIKE '%" & txtCarsearch.Text & "%' OR mo.name LIKE '%" & txtCarsearch.Text & "%' OR t.name LIKE '%" &
                    txtCarsearch.Text & "%' OR ma.name LIKE '%" & txtCarsearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "cars_customers_models_types_manufacturers")
            dtgCars.DataSource = dataset
            dtgCars.DataMember = "cars_customers_models_types_manufacturers"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Hide()
        ManageCus.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub
End Class