Public Class MachineProblem
    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles BtnCustomer.Click
        Me.Hide()
        ManageCus.Show()
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BtnCars_Click(sender As Object, e As EventArgs) Handles BtnCars.Click
        Me.Hide()
        ManageCars.Show()
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        Me.Hide()
        Suppliers.Show()
    End Sub

    Private Sub BtnParts_Click(sender As Object, e As EventArgs) Handles BtnParts.Click
        Me.Hide()
        Parts.Show()
    End Sub
    Private Sub BtnMechanics_Click(sender As Object, e As EventArgs) Handles BtnMechanics.Click
        Me.Hide()
        Mechanics.Show()
    End Sub

    Private Sub BtnServices_Click(sender As Object, e As EventArgs) Handles BtnServices.Click
        Me.Hide()
        ServiceOffer.Show()
    End Sub
End Class