Imports MySql.Data.MySqlClient
Public Class MakeService
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter

    Public arrServiceType(20) As String
    Public arrServiceTypeFee(20) As Decimal
    Public arrMechanics(20) As String
    Dim servicefee As Decimal = 0
    Public i As Integer = 0

    Public arrParts(100) As String
    Public arrPartsFee(100) As Decimal
    Public arrPartsQuantity(100) As Decimal
    Public priceparts(100) As Decimal
    Dim totalpriceparts As Decimal
    Public j As Integer = 0

    Dim mechanics(100) As String
    Public k As Integer = 0

    Public id As Integer = 0
    Public type_id As Integer = 0
    Public mech_id As Integer = 0
    Public part_id As Integer = 0

    Public temp As String
    Private Sub MakeService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtType.Enabled = False
        txtPostaCode.Enabled = False
        txtPlateNumber.Enabled = False
        txtPhone.Enabled = False
        txtName.Enabled = False
        txtModel.Enabled = False
        txtMileage.Enabled = False
        txtManufacturer.Enabled = False
        txtEmail.Enabled = False
        txtCustomerID.Enabled = False
        txtAddress.Enabled = False
        txtType.Text = Customer.txtType.Text
        txtPostaCode.Text = Customer.txtPostalCode.Text
        txtPlateNumber.Text = Customer.txtPlateNumber.Text
        txtPhone.Text = Customer.txtPhone.Text
        txtName.Text = Customer.txtname.Text
        txtModel.Text = Customer.txtModel.Text
        txtMileage.Text = Customer.txtMileage.Text
        txtManufacturer.Text = Customer.txtMileage.Text
        txtEmail.Text = Customer.txtEmail.Text
        txtAddress.Text = Customer.txtAddress.Text

        connection.Open()
        If Customer.customer_id = 0 Then
            txtCustomerID.Text = Customer.newcus.ToString
        Else
            txtCustomerID.Text = Customer.customer_id.ToString
        End If

        If Customer.car_id = 0 Then
            Try

                query = "select car_id from cars where car_id = (select max(car_id) from cars);"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader()
                reader.Read()
                txtCarID.Text = reader("car_id")
                reader.Close()
            Catch ex As MySqlException
                MsgBox("Error in collectig data from database. Error is :" & ex.Message)
            End Try

        Else
            txtCarID.Text = Customer.car_id.ToString
        End If

        Try
            query = "select name from servicetype"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbServicsType.Items.Add(reader("name"))
            End While
            reader.Close()
        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        End Try

        Try
            query = "select name from parts"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbParts.Items.Add(reader("name"))
            End While
            reader.Close()
        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        End Try

        Try
            query = "select fname from mechanics"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbMechanics.Items.Add(reader("fname"))
            End While
            reader.Close()
        Catch ex As MySqlException
            MsgBox("Error in collectig data from database. Error is :" & ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub cmbServicsType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServicsType.SelectedIndexChanged
        For t = 0 To arrServiceType.Length - 1
            If arrServiceType(t) = cmbServicsType.SelectedItem Then
                Exit Sub
            End If
        Next
        arrServiceType(i) = cmbServicsType.SelectedItem

        connection.Open()
        query = " select fee from servicetype Where name = '" & arrServiceType(i) & "'"
        cmd = New MySqlCommand(query, connection)
        reader = cmd.ExecuteReader
        reader.Read()
        arrServiceTypeFee(i) = reader("fee")
        lbServiceType.Items.Add(arrServiceType(i) & "     " & arrServiceTypeFee(i))
        connection.Close()
        servicefee += arrServiceTypeFee(i)
        txtTotalService.Text = servicefee.ToString("C2")
        i += 1
    End Sub

    Private Sub cmbMechanics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMechanics.SelectedIndexChanged
        For t = 0 To arrMechanics.Length - 1
            If arrMechanics(t) = cmbMechanics.SelectedItem Then
                Exit Sub
            End If
        Next
        arrMechanics(k) = cmbMechanics.SelectedItem
        lbMechanics.Items.Add(arrMechanics(k))
        k += 1
    End Sub

    Private Sub cmbParts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbParts.SelectedIndexChanged
        For t = 0 To arrParts.Length - 1
            If arrParts(t) = cmbParts.SelectedItem Then
                Exit Sub
            End If
        Next
        arrParts(j) = cmbParts.SelectedItem
        arrPartsQuantity(j) = Val(InputBox("Quantity", "Parts"))
        connection.Open()
        query = " select sellprice from parts Where name = '" & arrParts(j) & "'"
        cmd = New MySqlCommand(query, connection)
        reader = cmd.ExecuteReader
        reader.Read()
        arrPartsFee(j) = reader("sellprice")
        priceparts(j) = arrPartsFee(j) * arrPartsQuantity(j)

        lbParts.Items.Add(arrParts(j) & "   " & arrPartsFee(j) & "   Quantity: " & CInt(arrPartsQuantity(j)) & "     Total: " & priceparts(j))
        connection.Close()
        totalpriceparts = totalpriceparts + priceparts(j)
        txtTotalPartsPrice.Text = totalpriceparts.ToString("C2")
        j += 1
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try
            connection.Open()
            sql = "INSERT INTO service(service_date, car_id) VALUES('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "'," & txtCarID.Text & ")"
            cmd = New MySqlCommand(sql, connection)
            Dim row As Integer = cmd.ExecuteNonQuery
            If row > 0 Then
                'MsgBox("Inserted")
            End If
        Catch ex As MySqlException
            'MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            'MsgBox(exs.Message)
        End Try
        connection.Close()

        Try
            connection.Open()
            sql = "SELECT service_id from service where service_id = (SELECT MAX(service_id) FROM service)"
            cmd = New MySqlCommand(sql, connection)
            reader = cmd.ExecuteReader
            reader.Read()
            id = reader("service_id")
        Catch ex As MySqlException
            'MsgBox("Error : " & ex.Message)
        Catch exs As Exception
            'MsgBox(exs.Message)
        End Try
        connection.Close()

        For g = 0 To i - 1
            Try
                connection.Open()
                query = "SELECT type_id FROM servicetype WHERE name = '" & arrServiceType(g) & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader()
                While reader.Read()
                    type_id = reader("type_id")
                End While
            Catch ex As MySqlException
                'MsgBox("Error : " & ex.Message)
            Catch exs As Exception
                'MsgBox(exs.Message)
            End Try
            connection.Close()

            Try
                connection.Open()
                sql = "INSERT INTO servetype(service_id, type_id) VALUES(" & id & "," & type_id & ")"
                cmd = New MySqlCommand(sql, connection)
                Dim row As Integer = cmd.ExecuteNonQuery
                If row > 0 Then
                    'MsgBox("ServeType Inserted")
                Else
                    'MsgBox("BOBO")
                End If
            Catch ex As MySqlException
                'MsgBox("Error : " & ex.Message)
            Catch exs As Exception
                'MsgBox(exs.Message)
            End Try
            connection.Close()
        Next

        For yey = 0 To j - 1
            Try
                connection.Open()
                query = "SELECT part_id FROM parts WHERE name = '" & arrParts(yey) & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    part_id = reader("part_id")
                End While
            Catch ex As MySqlException
                'MsgBox("Error : " & ex.Message)
            Catch exs As Exception
                'MsgBox(exs.Message)
            End Try
            connection.Close()
            Try
                connection.Open()
                sql = "INSERT INTO serveparts(service_id, part_id, quantity) VALUES(" & id & "," & part_id & "," & arrPartsQuantity(yey) & ")"
                cmd = New MySqlCommand(sql, connection)
                Dim row As Integer = cmd.ExecuteNonQuery
                If row > 0 Then
                    'MsgBox("ServeParts Inserted")
                Else
                    'MsgBox("BOBO")
                End If
            Catch ex As MySqlException
                'MsgBox("Error : " & ex.Message)
            Catch exs As Exception
                'MsgBox(exs.Message)
            End Try
            connection.Close()
            Try
                connection.Open()
                sql = "UPDATE stock SET quantity = quantity -" & arrPartsQuantity(yey) & " WHERE part_id = " & part_id
                cmd = New MySqlCommand(sql, connection)
                Dim row As Integer = cmd.ExecuteNonQuery
            Catch ex As MySqlException
                'MsgBox("Error : " & ex.Message)
            Catch exs As Exception
                'MsgBox(exs.Message)
            End Try
            connection.Close()
        Next

        For uwo = 0 To k - 1
            Try
                connection.Open()
                query = "SELECT mechanic_id FROM mechanics WHERE fname = '" & arrMechanics(uwo) & "'"
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    mech_id = reader("mechanic_id")
                End While
            Catch ex As MySqlException
                'MsgBox("Error : " & ex.Message)
            Catch exs As Exception
                'MsgBox(exs.Message)
            End Try
            connection.Close()
            'MsgBox(mech_id)
            Try
                connection.Open()
                sql = "INSERT INTO servemehcanics(service_id, mechanic_id) VALUES(" & id & "," & mech_id & ")"
                cmd = New MySqlCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    'MsgBox("ServeMechanics Inserted")
                Else
                    'MsgBox("BOBO")
                End If
            Catch ex As MySqlException
                'MsgBox("Error : " & ex.Message)
            Catch exs As Exception
                'MsgBox(exs.Message)
            End Try
            connection.Close()
        Next
        MessageBox.Show("All of the records like customer info, car info and the service info are successfully inserted to database. Press OK to print the reciept",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Reciept.Show()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Customer.Show()
    End Sub

    Private Sub BtnResetServeType_Click(sender As Object, e As EventArgs) Handles BtnResetServeType.Click
        Array.Clear(arrServiceType, 0, arrServiceType.Length)
        lbServiceType.Items.Clear()
        cmbServicsType.Text = ""
        txtTotalService.Clear()
        servicefee = 0
    End Sub

    Private Sub BtnResetServeParts_Click(sender As Object, e As EventArgs) Handles BtnResetServeParts.Click
        Array.Clear(arrParts, 0, arrParts.Length)
        Array.Clear(arrPartsQuantity, 0, arrPartsQuantity.Length)
        lbParts.Items.Clear()
        cmbParts.Text = ""
        txtTotalPartsPrice.Clear()
        totalpriceparts = 0
    End Sub

    Private Sub BtnResetServeMechanics_Click(sender As Object, e As EventArgs) Handles BtnResetServeMechanics.Click
        Array.Clear(arrMechanics, 0, arrMechanics.Length)
        lbMechanics.Items.Clear()
        cmbMechanics.Text = ""
    End Sub
End Class