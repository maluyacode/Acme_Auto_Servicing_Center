Imports MySql.Data.MySqlClient
Public Class Customer
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter

    Public customer_id As Integer = 0
    Public car_id As Integer = 0

    Public mod_id As Integer
    Public newcus As Integer

    Public manufacturer As Integer
    Public type As Integer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Enabled = False
        txtPhone.Enabled = False
        txtAddress.Enabled = False
        txtEmail.Enabled = False
        txtPostalCode.Enabled = False
        txtMileage.Enabled = False
        txtPlateNumber.Enabled = False
        txtModel.Enabled = False
        cmbModels.Enabled = False
        txtType.Enabled = False
        txtManufacturer.Enabled = False
        'Customer DataGrid
        Try
            connection.Open()
            query = "SELECT customer_id, name, phone, email, address, postalcode
                    FROM customers"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "customers_cars")
            DataGridView1.DataSource = dataset.Tables("customers_cars")

        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        End Try
        'Owners Car Datagrid
        Try

            query = "SELECT car_id, platenumber, mileage, mo.name AS car_model, t.name AS type_name, m.name AS manufacturer
                    FROM customers cu INNER JOIN cars ca ON (cu.customer_id = ca.customer_id) 
                    INNER JOIN models mo ON (mo.model_id = ca.model_id) INNER JOIN manufacturers m ON
                    (m.manufacturer_id = mo.manufacturer_id) INNER JOIN types t ON (t.type_id = mo.type_id)"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "customers_cars_models_manufacturers_types")
            DataGridView2.DataSource = dataset.Tables("customers_cars_models_manufacturers_types")

        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        txtname.Enabled = True
        txtPhone.Enabled = True
        txtAddress.Enabled = True
        txtEmail.Enabled = True
        txtPostalCode.Enabled = True
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        If txtAddress.Text = "" Or txtname.Text = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Or txtPostalCode.Text = "" Then
            MessageBox.Show("All fields are required!", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If customer_id = 0 Or car_id = 0 Then
            connection.Open()
            If customer_id = 0 Then
                Try

                    sql = "INSERT INTO customers (name, phone, email, address, postalcode) 
                            VALUES ('" & txtname.Text & "','" & txtPhone.Text & "','" & txtEmail.Text &
                            "','" & txtAddress.Text & "','" & txtPostalCode.Text & "')"
                    cmd = New MySqlCommand(sql, connection)
                    cmd.ExecuteNonQuery()
                    MsgBox("Customer Inserted")
                Catch ex As MySqlException
                    MsgBox("Error in collectig data from database. Error is :" & ex.Message)
                End Try
            End If
            If car_id = 0 Then
                If customer_id = 0 Then
                    query = "SELECT customer_id FROM customers WHERE customer_id = (SELECT MAX(customer_id) FROM customers)"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    reader.Read()
                    newcus = reader("customer_id")
                    reader.Close()


                    query = "SELECT * from models WHERE name = '" & txtModel.Text & "'"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    If reader.Read() Then
                        mod_id = reader("model_id")
                        reader.Close()
                    Else
                        reader.Close()
                        query = "SELECT * FROM manufacturers WHERE name = '" & txtManufacturer.Text & "'"
                        cmd = New MySqlCommand(query, connection)
                        reader = cmd.ExecuteReader
                        If reader.Read Then
                            manufacturer = reader("manufacturer_id")
                            reader.Close()
                        Else
                            reader.Close()
                            sql = "INSERT INTO manufacturers(name) VALUES('" & txtManufacturer.Text & "')"
                            cmd = New MySqlCommand(sql, connection)
                            cmd.ExecuteNonQuery()
                            query = "SELECT manufacturer_id FROM manufacturers WHERE manufacturer_id = (SELECT MAX(manufacturer_id) FROM manufacturers)"
                            cmd = New MySqlCommand(query, connection)
                            reader = cmd.ExecuteReader
                            reader.Read()
                            manufacturer = reader("manufacturer_id")
                            reader.Close()
                        End If

                        query = "SELECT * FROM types WHERE name = '" & txtType.Text & "'"
                        cmd = New MySqlCommand(query, connection)
                        reader = cmd.ExecuteReader
                        If reader.Read Then
                            type = reader("type_id")
                            reader.Close()
                        Else
                            reader.Close()
                            sql = "INSERT INTO type(name) VALUES('" & txtType.Text & "')"
                            cmd = New MySqlCommand(sql, connection)
                            cmd.ExecuteNonQuery()
                            query = "SELECT type_id FROM types WHERE type_id = (SELECT MAX(type_id) FROM types)"
                            cmd = New MySqlCommand(query, connection)
                            reader = cmd.ExecuteReader
                            reader.Read()
                            type = reader("type_id")
                            reader.Close()
                        End If
                        sql = "INSERT INTO models(name, manufacturer_id, type_id) VALUES('" & txtModel.Text & "'," & manufacturer & "," & type & ")"
                        cmd = New MySqlCommand(sql, connection)
                        cmd.ExecuteNonQuery()
                        query = "SELECT model_id FROM models WHERE model_id = (SELECT MAX(model_id) FROM models)"
                        cmd = New MySqlCommand(query, connection)
                        reader = cmd.ExecuteReader
                        reader.Read()
                        mod_id = reader("model_id")
                        reader.Close()
                    End If

                    Try
                        sql = "INSERT INTO cars(mileage, platenumber, customer_id, model_id) 
                           VALUES ('" & txtMileage.Text & "','" & txtPlateNumber.Text & "'," & newcus & "," & mod_id & ")"
                        cmd = New MySqlCommand(sql, connection)
                        cmd.ExecuteNonQuery()
                        MsgBox("Car Inserted")
                    Catch ex As MySqlException
                        MsgBox("Error in collectig data from database. Error is :" & ex.Message)
                    End Try
                Else

                    query = "SELECT * from models WHERE name = '" & txtModel.Text & "'"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    If reader.Read() Then
                        mod_id = reader("model_id")
                        reader.Close()
                    Else
                        reader.Close()
                        query = "SELECT * FROM manufacturers WHERE name = '" & txtManufacturer.Text & "'"
                        cmd = New MySqlCommand(query, connection)
                        reader = cmd.ExecuteReader
                        If reader.Read Then
                            manufacturer = reader("manufacturer_id")
                            reader.Close()
                        Else
                            reader.Close()
                            sql = "INSERT INTO manufacturers(name) VALUES('" & txtManufacturer.Text & "')"
                            cmd = New MySqlCommand(sql, connection)
                            cmd.ExecuteNonQuery()
                            query = "SELECT manufacturer_id FROM manufacturers WHERE manufacturer_id = (SELECT MAX(manufacturer_id) FROM manufacturers)"
                            cmd = New MySqlCommand(query, connection)
                            reader = cmd.ExecuteReader
                            reader.Read()
                            manufacturer = reader("manufacturer_id")
                            reader.Close()
                        End If

                        query = "SELECT * FROM types WHERE name = '" & txtType.Text & "'"
                        cmd = New MySqlCommand(query, connection)
                        reader = cmd.ExecuteReader
                        If reader.Read Then
                            type = reader("type_id")
                            reader.Close()
                        Else
                            reader.Close()
                            sql = "INSERT INTO types(name) VALUES('" & txtType.Text & "')"
                            cmd = New MySqlCommand(sql, connection)
                            cmd.ExecuteNonQuery()
                            query = "SELECT type_id FROM types WHERE type_id = (SELECT MAX(type_id) FROM types)"
                            cmd = New MySqlCommand(query, connection)
                            reader = cmd.ExecuteReader
                            reader.Read()
                            type = reader("type_id")
                            reader.Close()
                        End If
                        sql = "INSERT INTO models(name, manufacturer_id, type_id) VALUES('" & txtModel.Text & "'," & manufacturer & "," & type & ")"
                        cmd = New MySqlCommand(sql, connection)
                        cmd.ExecuteNonQuery()
                        query = "SELECT model_id FROM models WHERE model_id = (SELECT MAX(model_id) FROM models)"
                        cmd = New MySqlCommand(query, connection)
                        reader = cmd.ExecuteReader
                        reader.Read()
                        mod_id = reader("model_id")
                        reader.Close()
                    End If

                    Try
                        sql = "INSERT INTO cars(mileage, platenumber, customer_id, model_id) 
                           VALUES ('" & txtMileage.Text & "','" & txtPlateNumber.Text & "'," & customer_id & "," & mod_id & ")"
                        cmd = New MySqlCommand(sql, connection)
                        cmd.ExecuteNonQuery()
                        MsgBox("Car Inserted")
                    Catch ex As MySqlException
                        MsgBox("Error in collectig data from database. Error is :" & ex.Message)
                    End Try
                End If
            End If
        End If
        connection.Close()
        Me.Hide()
        MakeService.Show()
    End Sub

    Private Sub txtNameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtNameSearch.TextChanged
        'Searching name and platenumber of car
        Try
            connection.Open()
            query = "SELECT DISTINCT customer_id, name, phone, email, address, postalcode
                    FROM customers WHERE name LIKE '%" & txtNameSearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "customers_cars_models_manufacturers_types")
            DataGridView1.DataSource = dataset.Tables("customers_cars_models_manufacturers_types")




            query = "SELECT car_id, platenumber, mileage, mo.name AS car_model, t.name AS type_name, m.name AS manufacturer
                    FROM customers cu INNER JOIN cars ca ON (cu.customer_id = ca.customer_id) 
                    INNER JOIN models mo ON (mo.model_id = ca.model_id) INNER JOIN manufacturers m ON
                    (m.manufacturer_id = mo.manufacturer_id) INNER JOIN types t ON (t.type_id = mo.type_id) 
                    WHERE cu.name LIKE '%" & txtNameSearch.Text & "%' OR platenumber LIKE '%" & txtNameSearch.Text & "%'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "customers_cars_models_manufacturers_types")
            DataGridView2.DataSource = dataset.Tables("customers_cars_models_manufacturers_types")
        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is :" & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        'Transfer customer info to textboxes
        Dim row As Integer = e.RowIndex
        customer_id = DataGridView1(0, row).Value.ToString
        txtname.Text = DataGridView1(1, row).Value.ToString
        txtPhone.Text = DataGridView1(2, row).Value.ToString
        txtEmail.Text = DataGridView1(3, row).Value.ToString
        txtAddress.Text = DataGridView1(4, row).Value.ToString
        txtPostalCode.Text = DataGridView1(5, row).Value.ToString
    End Sub
    Private Sub DataGridView2_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseDoubleClick
        Dim row As Integer = e.RowIndex
        car_id = DataGridView2(0, row).Value.ToString
        txtPlateNumber.Text = DataGridView2(1, row).Value.ToString
        txtMileage.Text = DataGridView2(2, row).Value.ToString
        txtModel.Text = DataGridView2(3, row).Value.ToString
        txtManufacturer.Text = DataGridView2(5, row).Value.ToString
        txtType.Text = DataGridView2(4, row).Value.ToString
    End Sub

    'Private Sub cmdModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdModel.SelectedIndexChanged
    '    Try
    '        connection.Open()
    '        query = "SELECT ma.name AS manu, t.name AS type 
    '                FROM models mo INNER JOIN manufacturers ma ON
    '                (ma.manufacturer_id = mo.manufacturer_id) 
    '                INNER JOIN types t ON (t.type_id = mo.type_id)
    '                WHERE mo.name = '" & cmdModel.SelectedItem & "'"
    '        cmd = New MySqlCommand(query, connection)
    '        reader = cmd.ExecuteReader
    '        reader.Read()
    '        txtManufacturer.Text = reader("manu")
    '        txtType.Text = reader("type")
    '    Catch ex As MySqlException
    '        MsgBox("Error in collectig data from database. Error is :" & ex.Message)
    '    End Try
    '    connection.Close()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BtnAddModel_Click(sender As Object, e As EventArgs)
        ManageCars.Show()
        ManageCars.TabControl1.SelectedTab = ManageCars.TabPage2
    End Sub

    Private Sub BtnAddCar_Click(sender As Object, e As EventArgs) Handles BtnAddCar.Click
        txtMileage.Enabled = True
        txtPlateNumber.Enabled = True
        txtModel.Enabled = True
        cmbModels.Enabled = True
        txtManufacturer.Enabled = True
        txtType.Enabled = True
    End Sub

    Private Sub BtnClearCustomer_Click(sender As Object, e As EventArgs) Handles BtnClearCustomer.Click
        txtname.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtPostalCode.Clear()
        customer_id = 0
    End Sub

    Private Sub BtnClearCar_Click(sender As Object, e As EventArgs) Handles BtnClearCar.Click
        txtMileage.Clear()
        txtPlateNumber.Clear()
        txtModel.Clear()
        txtManufacturer.Clear()
        txtType.Clear()
        cmbModels.Text = ""
        car_id = 0
    End Sub

    Private Sub txtModel_TextChanged(sender As Object, e As EventArgs) Handles txtModel.TextChanged
        txtManufacturer.Text = ""
        txtType.Text = ""
        cmbModels.Text = ""
        cmbModels.DroppedDown = False
        cmbModels.Items.Clear()
        Try
            connection.Open()
            query = "SELECT ma.name AS manu, t.name AS type, mo.name AS model 
                        FROM models mo INNER JOIN manufacturers ma ON
                        (ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON (t.type_id = mo.type_id)
                        WHERE mo.name LIKE '%" & txtModel.Text & "%'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read()
                If reader("manu") = Nothing Then
                    txtManufacturer.Text = ""
                ElseIf reader("type") = Nothing Then
                    txtType.Text = ""
                ElseIf txtModel.Text = "" Then
                    txtManufacturer.Text = ""
                    txtType.Text = ""
                    cmbModels.Text = ""
                    cmbModels.Items.Clear()
                    cmbModels.DroppedDown = False
                Else
                    txtManufacturer.Text = reader("manu")
                    txtType.Text = reader("type")
                    cmbModels.Items.Add(reader("model"))
                    cmbModels.Text = reader("model")
                    cmbModels.DroppedDown = True
                End If
            End While
        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        End Try
        reader.Close()
        connection.Close()
    End Sub

    'Private Sub cmbModels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModels.SelectedIndexChanged
    '    txtModel.Text = cmbModels.SelectedItem
    'End Sub


    'Private Sub cmdModel_TextChanged(sender As Object, e As EventArgs) Handles cmdModel.TextChanged
    '    cmdModel.Items.Clear()
    '    Try
    '        connection.Open()
    '        query = "SELECT name FROM models WHERE name LIKE '%" & cmdModel.Text & "%'"
    '        cmd = New MySqlCommand(query, connection)
    '        reader = cmd.ExecuteReader
    '        While reader.Read()
    '            cmdModel.Items.Add(reader("name"))
    '        End While
    '    Catch ex As MySqlException
    '        MsgBox("Error in collectig data from database. Error is :" & ex.Message)
    '    End Try
    '    reader.Close()
    '    connection.Close()
    'End Sub

    'Private Sub cmbManufacturer_TextChanged(sender As Object, e As EventArgs) Handles cmbManufacturer.TextChanged
    '    cmbManufacturer.Items.Clear()
    '    Try
    '        connection.Open()
    '        query = "SELECT name FROM manufacturers WHERE name LIKE '%" & cmbManufacturer.Text & "%'"
    '        cmd = New MySqlCommand(query, connection)
    '        reader = cmd.ExecuteReader
    '        While reader.Read()
    '            cmbManufacturer.Items.Add(reader("name"))
    '        End While
    '    Catch ex As MySqlException
    '        MsgBox("Error in collectig data from database. Error is :" & ex.Message)
    '    End Try
    '    reader.Close()
    '    connection.Close()
    'End Sub

    'Private Sub cmbType_TextChanged(sender As Object, e As EventArgs) Handles cmbType.TextChanged
    '    cmbType.Items.Clear()
    '    Try
    '        connection.Open()
    '        query = "SELECT name FROM types WHERE name LIKE '%" & cmbType.Text & "%'"
    '        cmd = New MySqlCommand(query, connection)
    '        reader = cmd.ExecuteReader
    '        While reader.Read()
    '            cmbType.Items.Add(reader("name"))
    '        End While
    '    Catch ex As MySqlException
    '        MsgBox("Error in collectig data from database. Error is :" & ex.Message)
    '    End Try
    '    reader.Close()
    '    connection.Close()
    'End Sub
End Class