Imports MySql.Data.MySqlClient
Public Class Queries
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter

    Private Sub Queries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSearchQueries_TextChanged(sender As Object, e As EventArgs) Handles txtSearchQueries.TextChanged
        txtDisplay.Clear()
        If dtgQueries.Rows.Count > 0 Or txtSearchQueries.Text = "" Then
            dtgQueries.DataSource = Nothing
            txtDisplay.Clear()
        End If
        connection.Open()
        If RbtQuiz1.Checked Then
            Try
                query = "SELECT DISTINCT p.name as Parts_Used, se.quantity, service_date 
                        FROM manufacturers ma INNER JOIN models mo ON(ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON(t.type_id = mo.type_id) 
                        INNER JOIN cars ca ON(mo.model_id = ca.model_id) 
                        INNER JOIN service s ON(s.car_id = ca.car_id) 
                        INNER JOIN serveparts se ON(s.service_id = se.service_id) 
                        INNER JOIN parts p ON(p.part_id = se.part_id) WHERE mo.name LIKE '%" & txtSearchQueries.Text & "%'"
                dataAdapter = New MySqlDataAdapter(query, connection)
                dataset = New DataSet
                dataAdapter.Fill(dataset, "Quiz1")
                dtgQueries.DataSource = dataset
                dtgQueries.DataMember = "Quiz1"

                query = "SELECT CONCAT(mo.name, ' - ' ,ma.name, ' - ' ,t.name) AS ModelName, p.name as Parts_Used, s.service_date
                        FROM manufacturers ma INNER JOIN models mo ON(ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON(t.type_id = mo.type_id) 
                        INNER JOIN cars ca ON(mo.model_id = ca.model_id) 
                        INNER JOIN service s ON(s.car_id = ca.car_id) 
                        INNER JOIN serveparts se ON(s.service_id = se.service_id) 
                        INNER JOIN parts p ON(p.part_id = se.part_id) WHERE mo.name LIKE '%" & txtSearchQueries.Text & "%'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    txtDisplay.Text = reader("ModelName")
                End While
            Catch ex As MySqlException
                MsgBox("Error in collectig data from database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
        ElseIf RbtQuiz2.Checked Then
            Try
                query = "SELECT p.name, so.quantity, o.orderdate, o.daterecieved, p.costprice, s.email
                        FROM suppliers s INNER JOIN orders o ON(s.supplier_id = o.supplier_id)
                        INNER JOIN stockorder so ON (o.order_id = so.order_id) INNER JOIN 
                        stock st ON (st.part_id = so.part_id) INNER JOIN parts p ON (p.part_id = st.part_id) WHERE s.name LIKE '%" & txtSearchQueries.Text & "%'"
                dataAdapter = New MySqlDataAdapter(query, connection)
                dataset = New DataSet
                dataAdapter.Fill(dataset, "Quiz2")
                dtgQueries.DataSource = dataset
                dtgQueries.DataMember = "Quiz2"

                query = "SELECT s.name AS SupplierName, s.email, o.orderdate, o.daterecieved, so.quantity, p.name, p.costprice
                        FROM suppliers s INNER JOIN orders o ON(s.supplier_id = o.supplier_id)
                        INNER JOIN stockorder so ON (o.order_id = so.order_id) INNER JOIN 
                        stock st ON (st.part_id = so.part_id) INNER JOIN parts p ON (p.part_id = st.part_id) WHERE s.name LIKE '%" & txtSearchQueries.Text & "%'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    txtDisplay.Text = reader("SupplierName")
                End While
            Catch ex As MySqlException
                MsgBox("Error in collectig data from database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
        ElseIf RbtQuiz3.Checked Then
            Try
                query = "SELECT platenumber, mileage, CONCAT(mo.name, ' - ' ,ma.name, ' - ' ,t.name) AS ModelName,  service_date
                        FROM manufacturers ma INNER JOIN models mo ON(ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON(t.type_id = mo.type_id) 
                        INNER JOIN cars ca ON(mo.model_id = ca.model_id) 
                        INNER JOIN service s ON(s.car_id = ca.car_id) 
                        INNER JOIN servemehcanics sm ON(sm.service_id = s.service_id)
                        INNER JOIN mechanics mec ON(sm.mechanic_id = mec.mechanic_id) WHERE fname LIKE '%" & txtSearchQueries.Text & "%'"
                dataAdapter = New MySqlDataAdapter(query, connection)
                dataset = New DataSet
                dataAdapter.Fill(dataset, "Quiz3")
                dtgQueries.DataSource = dataset
                dtgQueries.DataMember = "Quiz3"

                query = "SELECT mec.fname, platenumber, mileage, CONCAT(mo.name, ' - ' ,ma.name, ' - ' ,t.name) AS ModelName,  service_date
                        FROM manufacturers ma INNER JOIN models mo ON(ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON(t.type_id = mo.type_id) 
                        INNER JOIN cars ca ON(mo.model_id = ca.model_id) 
                        INNER JOIN service s ON(s.car_id = ca.car_id) 
                        INNER JOIN servemehcanics sm ON(sm.service_id = s.service_id)
                        INNER JOIN mechanics mec ON(sm.mechanic_id = mec.mechanic_id) WHERE fname LIKE '%" & txtSearchQueries.Text & "%'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    txtDisplay.Text = reader("fname")
                End While
            Catch ex As MySqlException
                MsgBox("Error in collectig data from database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
        ElseIf RbtQuiz4.Checked Then
            Try
                query = "SELECT platenumber, mileage, CONCAT(mo.name, ' - ' ,ma.name, ' - ' ,t.name) AS ModelName, service_date
                        FROM manufacturers ma INNER JOIN models mo ON(ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON(t.type_id = mo.type_id) 
                        INNER JOIN cars ca ON(mo.model_id = ca.model_id) 
                        INNER JOIN service s ON(s.car_id = ca.car_id)
                        INNER JOIN servetype ser ON(s.service_id = ser.service_id)
                        INNER JOIN servicetype sert ON(sert.type_id = ser.type_id) WHERE sert.name LIKE '%" & txtSearchQueries.Text & "%'"
                dataAdapter = New MySqlDataAdapter(query, connection)
                dataset = New DataSet
                dataAdapter.Fill(dataset, "Quiz4")
                dtgQueries.DataSource = dataset
                dtgQueries.DataMember = "Quiz4"

                query = "SELECT sert.name AS ServiceName, platenumber, mileage, CONCAT(mo.name, ' - ' ,ma.name, ' - ' ,t.name) AS ModelName, service_date
                        FROM manufacturers ma INNER JOIN models mo ON(ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON(t.type_id = mo.type_id) 
                        INNER JOIN cars ca ON(mo.model_id = ca.model_id) 
                        INNER JOIN service s ON(s.car_id = ca.car_id)
                        INNER JOIN servetype ser ON(s.service_id = ser.service_id)
                        INNER JOIN servicetype sert ON(sert.type_id = ser.type_id) WHERE sert.name LIKE '%" & txtSearchQueries.Text & "%'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    txtDisplay.Text = reader("ServiceName")
                End While
            Catch ex As MySqlException
                MsgBox("Error in collectig data from database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
        ElseIf RbtQuiz5.Checked Then
            Try
                query = "SELECT service_date, platenumber, mileage, CONCAT(mo.name, ' - ' ,ma.name, ' - ' ,t.name) AS ModelName
                        FROM manufacturers ma INNER JOIN models mo ON(ma.manufacturer_id = mo.manufacturer_id) 
                        INNER JOIN types t ON(t.type_id = mo.type_id) 
                        INNER JOIN cars ca ON(mo.model_id = ca.model_id) 
                        INNER JOIN service s ON(s.car_id = ca.car_id) WHERE service_date BETWEEN '" &
                        DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"
                dataAdapter = New MySqlDataAdapter(query, connection)
                dataset = New DataSet
                dataAdapter.Fill(dataset, "Quiz5")
                dtgQueries.DataSource = dataset
                dtgQueries.DataMember = "Quiz5"
                txtDisplay.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd") & " To " & DateTimePicker2.Value.ToString("yyyy-MM-dd")
            Catch ex As MySqlException
                MsgBox("Error in collectig data from database. Error is :" & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is :" & exs.Message)
            End Try
            connection.Close()
            txtSearchQueries.Text = "Kahit wag na lagyan"
        End If
        connection.Close()
        If txtSearchQueries.Text = "" Then
            txtDisplay.Text = ""
            dtgQueries.DataSource = Nothing
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtSearchQueries_TextChanged(sender, e)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        txtSearchQueries_TextChanged(sender, e)
    End Sub
End Class