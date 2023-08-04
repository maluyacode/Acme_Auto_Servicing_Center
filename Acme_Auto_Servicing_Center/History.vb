Imports MySql.Data.MySqlClient
Public Class History
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim IncomeService As Decimal
        Dim prodparts As Decimal
        Dim IncomeParts As Decimal
        Try
            connection.Open()
            query = "SELECT name AS Name_of_Customers FROM customers"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "name")
            dtgList.DataSource = dataset
            dtgList.DataMember = "name"
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT fee, servicetype.type_id 
                    FROM servicetype, servetype
                    WHERE servicetype.type_id = servetype.type_id"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                IncomeService = IncomeService + reader("fee")
            End While
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT service.service_id, sellprice, serveparts.quantity 
                    FROM parts, serveparts, service
                    WHERE parts.part_id = serveparts.part_id
                    AND service.service_id = serveparts.service_id ORDER BY service.service_id ASC"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                prodparts = CDec(reader("sellprice")) * CDec(reader("quantity"))
                IncomeParts = IncomeParts + prodparts
            End While
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        txtTotalIncome.Text = (IncomeParts + IncomeService).ToString("C2")
    End Sub

    Private Sub txtTypeSearch_TextChanged(sender As Object, e As EventArgs) Handles txtTypeSearch.TextChanged
        Try
            connection.Open()
            query = "SELECT name FROM customers WHERE name LIKE '%" & txtTypeSearch.Text & "%'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                txtNameSearch.Text = reader("name")
            End While
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        If txtTypeSearch.Text = "" Then
            txtNameSearch.Text = ""
        End If
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim cars As Integer = 0
        Dim petsa As Integer
        cmbCar.Items.Clear()
        cmbCar.Text = ""
        Try
            connection.Open()
            query = "SELECT platenumber FROM cars, customers 
                     WHERE customers.customer_id = cars.customer_id
                     AND customers.name = '" & txtNameSearch.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbCar.Items.Add(reader("platenumber"))
                cars += 1
            End While
            Label3.Text = "Has " & cars & " Car(s)"
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "Select service_date FROM cars, customers, service 
                     WHERE 
                     customers.customer_id = cars.customer_id
                     AND
                     cars.car_id = service.car_id
                     AND
                     customers.name = '" & txtNameSearch.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbDate.Items.Add(reader("service_date"))
                petsa += 1
            End While
            Label4.Text = "Has been serviced " & petsa & " time(s)"
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        'Try
        '    connection.Open()
        '    query = "SELECT DISTINCT servi.name
        '            FROM customers cu 
        '            INNER JOIN cars ca ON(cu.customer_id = ca.customer_id)
        '            INNER JOIN models mo ON(mo.model_id = ca.model_id) 
        '            INNER JOIN manufacturers ma ON(ma.manufacturer_id = mo.manufacturer_id)
        '            INNER JOIN types t ON(t.type_id = mo.type_id)
        '            INNER JOIN service s ON(s.car_id = ca.car_id)
        '            INNER JOIN servetype ser ON(ser.service_id = s.service_id)
        '            INNER JOIN servicetype servi ON(servi.type_id = ser.type_id)
        '            INNER JOIN serveparts servp ON(servp.service_id = s.service_id)
        '            INNER JOIN parts pa ON(servp.part_id = pa.part_id) WHERE cu.name = '" & txtNameSearch.Text & "'"
        '    dataAdapter = New MySqlDataAdapter(query, connection)
        '    dataset = New DataSet
        '    dataAdapter.Fill(dataset, "name")
        '    dtgServiceAvail.DataSource = dataset
        '    dtgServiceAvail.DataMember = "name"

        '    query = "SELECT DISTINCT pa.name
        '            FROM customers cu 
        '            INNER JOIN cars ca ON(cu.customer_id = ca.customer_id)
        '            INNER JOIN models mo ON(mo.model_id = ca.model_id) 
        '            INNER JOIN manufacturers ma ON(ma.manufacturer_id = mo.manufacturer_id)
        '            INNER JOIN types t ON(t.type_id = mo.type_id)
        '            INNER JOIN service s ON(s.car_id = ca.car_id)
        '            INNER JOIN servetype ser ON(ser.service_id = s.service_id)
        '            INNER JOIN servicetype servi ON(servi.type_id = ser.type_id)
        '            INNER JOIN serveparts servp ON(servp.service_id = s.service_id)
        '            INNER JOIN parts pa ON(servp.part_id = pa.part_id) WHERE cu.name = '" & txtNameSearch.Text & "'"
        '    dataAdapter = New MySqlDataAdapter(query, connection)
        '    dataset = New DataSet
        '    dataAdapter.Fill(dataset, "name")
        '    dtgPartsPurchase.DataSource = dataset
        '    dtgPartsPurchase.DataMember = "name"

        '    query = "SELECT DISTINCT .name
        '            FROM customers cu 
        '            INNER JOIN cars ca ON(cu.customer_id = ca.customer_id)
        '            INNER JOIN models mo ON(mo.model_id = ca.model_id) 
        '            INNER JOIN manufacturers ma ON(ma.manufacturer_id = mo.manufacturer_id)
        '            INNER JOIN types t ON(t.type_id = mo.type_id)
        '            INNER JOIN service s ON(s.car_id = ca.car_id)
        '            INNER JOIN servetype ser ON(ser.service_id = s.service_id)
        '            INNER JOIN servicetype servi ON(servi.type_id = ser.type_id)
        '            INNER JOIN serveparts servp ON(servp.service_id = s.service_id)
        '            INNER JOIN servemehcanics serme ON(serme.service_id = s.service_id)
        '            INNER JOIN mechanics meca ON(meca.mechanic_id = serme.mechanic_id)
        '            INNER JOIN parts pa ON(servp.part_id = pa.part_id) WHERE cu.name = '" & txtNameSearch.Text & "'"
        '    dataAdapter = New MySqlDataAdapter(query, connection)
        '    dataset = New DataSet
        '    dataAdapter.Fill(dataset, "name")
        '    dtgPartsPurchase.DataSource = dataset
        '    dtgPartsPurchase.DataMember = "name"
        'Catch ex As MySqlException
        '    MsgBox("Error : " & ex.Message)
        'Catch exs As Exception
        '    MsgBox(exs.Message)
        'End Try
        'connection.Close()
    End Sub

    Private Sub cmbCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCar.SelectedIndexChanged
        Dim petsa As Integer = 0
        cmbDate.Items.Clear()
        cmbDate.Text = ""
        Try
            connection.Open()
            query = "Select service_date FROM cars, customers, service 
                     WHERE 
                     customers.customer_id = cars.customer_id
                     AND
                     cars.car_id = service.car_id
                     AND
                     customers.name = '" & txtNameSearch.Text & "'
                     AND 
                     platenumber = '" & cmbCar.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbDate.Items.Add(reader("service_date"))
                petsa += 1
            End While
            Label4.Text = "Has been serviced " & petsa & " time(s)"
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT DISTINCT CONCAT(mo.name, ' - ' ,ma.name, ' - ' ,t.name) AS ModelName
                    FROM customers cu 
                    INNER JOIN cars ca ON(cu.customer_id = ca.customer_id)
                    INNER JOIN models mo ON(mo.model_id = ca.model_id) 
                    INNER JOIN manufacturers ma ON(ma.manufacturer_id = mo.manufacturer_id)
                    INNER JOIN types t ON(t.type_id = mo.type_id) WHERE platenumber = '" & cmbCar.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                txtCarDesc.Text = reader("ModelName")
            End While
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub BtnFinalSearch_Click(sender As Object, e As EventArgs) Handles BtnFinalSearch.Click
        Try
            connection.Open()
            query = "SELECT DISTINCT servi.name AS Services
                    FROM customers cu 
                    INNER JOIN cars ca ON(cu.customer_id = ca.customer_id)
                    INNER JOIN models mo ON(mo.model_id = ca.model_id) 
                    INNER JOIN manufacturers ma ON(ma.manufacturer_id = mo.manufacturer_id)
                    INNER JOIN types t ON(t.type_id = mo.type_id)
                    INNER JOIN service s ON(s.car_id = ca.car_id)
                    INNER JOIN servetype ser ON(ser.service_id = s.service_id)
                    INNER JOIN servicetype servi ON(servi.type_id = ser.type_id)
                    INNER JOIN serveparts servp ON(servp.service_id = s.service_id)
                    INNER JOIN parts pa ON(servp.part_id = pa.part_id)
                    WHERE platenumber = '" & cmbCar.Text & "' 
                    AND service_date = '" & CDate(cmbDate.Text).ToString("yyyy-MM-dd") & "'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "Services")
            dtgServiceAvail.DataSource = dataset
            dtgServiceAvail.DataMember = "Services"
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT DISTINCT pa.name AS Parts_Used
                    FROM customers cu 
                    INNER JOIN cars ca ON(cu.customer_id = ca.customer_id)
                    INNER JOIN models mo ON(mo.model_id = ca.model_id) 
                    INNER JOIN manufacturers ma ON(ma.manufacturer_id = mo.manufacturer_id)
                    INNER JOIN types t ON(t.type_id = mo.type_id)
                    INNER JOIN service s ON(s.car_id = ca.car_id)
                    INNER JOIN servetype ser ON(ser.service_id = s.service_id)
                    INNER JOIN servicetype servi ON(servi.type_id = ser.type_id)
                    INNER JOIN serveparts servp ON(servp.service_id = s.service_id)
                    INNER JOIN parts pa ON(servp.part_id = pa.part_id)
                    WHERE platenumber = '" & cmbCar.Text & "' 
                    AND service_date = '" & CDate(cmbDate.Text).ToString("yyyy-MM-dd") & "'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "Parts")
            dtgPartsPurchase.DataSource = dataset
            dtgPartsPurchase.DataMember = "Parts"
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT DISTINCT meca.fname AS Mechanics
                    FROM customers cu INNER JOIN cars ca ON(cu.customer_id = ca.customer_id)
                    INNER JOIN models mo ON(mo.model_id = ca.model_id) 
                    INNER JOIN manufacturers ma ON(ma.manufacturer_id = mo.manufacturer_id)
                    INNER JOIN types t ON(t.type_id = mo.type_id)
                    INNER JOIN service s ON(s.car_id = ca.car_id)
                    INNER JOIN servetype ser ON(ser.service_id = s.service_id)
                    INNER JOIN servicetype servi ON(servi.type_id = ser.type_id)
                    INNER JOIN servemehcanics serme ON(serme.service_id = s.service_id)
                    INNER JOIN mechanics meca ON(meca.mechanic_id = serme.mechanic_id)
                    INNER JOIN serveparts servp ON(servp.service_id = s.service_id)
                    INNER JOIN parts pa ON(servp.part_id = pa.part_id)     
                    WHERE platenumber = '" & cmbCar.Text & "' 
                    AND service_date = '" & CDate(cmbDate.Text).ToString("yyyy-MM-dd") & "'"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "Mechanics")
            dtgMechanics.DataSource = dataset
            dtgMechanics.DataMember = "Mechanics"
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        Dim IncomeService As Decimal
        Dim prodparts As Decimal
        Dim IncomeParts As Decimal

        Try
            connection.Open()
            query = "SELECT fee, servicetype.type_id 
                    FROM servicetype, servetype, service
                    WHERE servicetype.type_id = servetype.type_id
                    AND service.service_id = servetype.service_id
                    AND service_date BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                IncomeService = IncomeService + reader("fee")
            End While
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()

        Try
            connection.Open()
            query = "SELECT service.service_id, sellprice, serveparts.quantity 
                    FROM parts, serveparts, service
                    WHERE parts.part_id = serveparts.part_id
                    AND service.service_id = serveparts.service_id 
                    AND service_date BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                prodparts = CDec(reader("sellprice")) * CDec(reader("quantity"))
                IncomeParts = IncomeParts + prodparts
            End While
        Catch ex As MySqlException
            MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            MsgBox(exs.Message)
        End Try
        connection.Close()
        txtDateRangeIncome.Text = (IncomeParts + IncomeService).ToString("C2")
    End Sub
End Class