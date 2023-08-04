Imports MySql.Data.MySqlClient
Public Class OrdersParts
    Public connection As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=carservice_database;User=root;Password=;")
    Public sql As String
    Public query As String
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dataset As DataSet
    Public dataAdapter As New MySqlDataAdapter

    Public limit As Integer = 0
    Public i As Integer = 0
    Public arrParts(20) As String
    Public arrQuantity(20) As Integer
    Private Sub OrdersParts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpartID.Enabled = False
        txtTotal.Enabled = False
        lbParts.Enabled = False
        txtPrice.Enabled = False
        cmbSupplier.Items.Clear()
        cmbname.Items.Clear()
        Try
            connection.Open()
            sql = "SELECT o.order_id, p.name, s.name, so.quantity, p.costprice, o.orderdate, o.daterecieved, (p.costprice * so.quantity) AS total, s.email 
                    FROM suppliers s INNER JOIN orders o ON(s.supplier_id = o.supplier_id)
                    INNER JOIN stockorder so ON (o.order_id = so.order_id) INNER JOIN 
                    stock st ON (st.part_id = so.part_id) INNER JOIN parts p ON (p.part_id = st.part_id)"
            dataAdapter = New MySqlDataAdapter(sql, connection)
            dataset = New DataSet
            dataAdapter.Fill(dataset, "parts_stock")
            dtgOrderParts.DataSource = dataset
            dtgOrderParts.DataMember = "parts_stock"
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT name FROM parts"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbname.Items.Add(reader("name"))
            End While
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        Try
            connection.Open()
            query = "SELECT name FROM suppliers"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbSupplier.Items.Add(reader("name"))
            End While
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub cmbname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbname.SelectedIndexChanged
        Try
            connection.Open()
            query = "SELECT costprice, part_id FROM parts WHERE name = '" & cmbname.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                txtPrice.Text = reader("costprice")
                txtpartID.Text = reader("part_id")
            End While
        Catch ex As MySqlException
            MsgBox("Error collection data from database. Error is :" & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim price As Decimal
        Try
            connection.Open()
            query = "SELECT part_id, costprice FROM parts WHERE name = '" & cmbname.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            While reader.Read
                arrParts(i) = reader("part_id")
                price = reader("costprice")
            End While
        Catch ex As MySqlException
            MsgBox("Error is: " & ex.Message)
        Catch exs As Exception
            MsgBox("Error in code. Error is : " & exs.Message)
        End Try
        connection.Close()
        arrQuantity(i) = CInt(txtQuantity.Text)
        txtTotal.Text = Val(txtTotal.Text) + (price * arrQuantity(i))
        lbParts.Items.Add(cmbname.Text)
        i += 1
        limit += 1
    End Sub

    Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
        Dim ans = MessageBox.Show("Do you want to purchase those parts?", "Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            Try
                connection.Open()
                sql = "INSERT INTO orders(supplier_id, orderdate, daterecieved) VALUES((SELECT supplier_id FROM suppliers WHERE name ='" & cmbSupplier.Text & "'), now(), DATE(now() + INTERVAL + 5 DAY))"
                cmd = New MySqlCommand(sql, connection)
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MsgBox("Error is: " & ex.Message)
            Catch exs As Exception
                MsgBox("Error in code. Error is : " & exs.Message)
            End Try
            connection.Close()
            For i = 0 To limit - 1
                Try
                    connection.Open()
                    sql = "INSERT INTO stockorder(part_id, order_id, quantity) VALUES(" & arrParts(i) & "," & "(SELECT order_id from orders where order_id = (SELECT MAX(order_id) FROM orders)), " & arrQuantity(i) & ")"
                    cmd = New MySqlCommand(sql, connection)
                    cmd.ExecuteNonQuery()
                    sql = "UPDATE stock SET quantity = quantity + " & arrQuantity(i) & " WHERE part_id = " & arrParts(i)
                    cmd = New MySqlCommand(sql, connection)
                    cmd.ExecuteNonQuery()
                Catch ex As MySqlException
                    MsgBox("Error is: " & ex.Message)
                Catch exs As Exception
                    MsgBox("Error in code. Error is : " & exs.Message)
                End Try
                connection.Close()
            Next
            MsgBox("Parts Purchased, Check your stock on specific parts you purchase :)")
        End If
        Array.Clear(arrParts, 0, arrParts.Length)
        Array.Clear(arrQuantity, 0, arrQuantity.Length)
    End Sub
    Private Sub BtnCancelAll_Click(sender As Object, e As EventArgs) Handles BtnCancelAll.Click
        txtpartID.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtTotal.Clear()
        cmbname.Text = ""
        cmbSupplier.Text = ""
        lbParts.Items.Clear()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        OrdersParts_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Parts.Show()
    End Sub
End Class