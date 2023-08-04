Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRecordService_Click(sender As Object, e As EventArgs) Handles BtnRecordService.Click
        Me.Hide()
        Customer.Show()
    End Sub

    Private Sub BtnManage_Click(sender As Object, e As EventArgs) Handles BtnManage.Click
        Me.Hide()
        MachineProblem.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Reciept.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnQueries_Click(sender As Object, e As EventArgs) Handles BtnQueries.Click
        Queries.Show()
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        History.Show()
    End Sub
End Class
