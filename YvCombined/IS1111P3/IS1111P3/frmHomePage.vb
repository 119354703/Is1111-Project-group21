Public Class frmHomePage
    Private Sub frmHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(strUser)
        If strUser = "Customer" Then
            btnFindOrder.Visible = False
            btnCustomer.Visible = False
            btnEmployee.Visible = False
        ElseIf strUser = "Employee" Then
            btnCustomer.Visible = False
            btnEmployee.Visible = False
        End If
    End Sub
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btnFindOrder_Click(sender As Object, e As EventArgs) Handles btnFindOrder.Click
        frmFindOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        frmNewOrder1.Show()
        Me.Hide()
    End Sub

    Private Sub btnTrackOrder_Click(sender As Object, e As EventArgs) Handles btnTrackOrder.Click
        frmTrackOrder.Show()
        Me.Close()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frmEmployee.Show()
        Me.Hide()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Visible = False
    End Sub
End Class