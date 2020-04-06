Public Class frmManNewOrder
    Private Sub frmManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPlace.Items.Add("1: Select New Order button at the top of the Homepage.")
        lstPlace.Items.Add("2: Fill in which items you would like to have on your new shoes.")
        lstPlace.Items.Add("3: Click the Calculate button to check the price of your order.")
        lstPlace.Items.Add("4: Click Order to place the order for your shoes.")
        lstPlace.Items.Add("5: You can click View Order to check the price breakdown of each item.")
        lstPlace.Items.Add("5: Click Back to Homepage to return to the Homepage.")
        lstPlace.Items.Add("6: Click logout and the application shall close")

        lstLogout.Items.Add("1: Click the return button down on the bottom left of the form.")
        lstLogout.Items.Add("2: This will bring you to the Homepage.")
        lstLogout.Items.Add("3: Click logout and the application shall close.")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmNewOrder1.Show()
        Me.Hide()
    End Sub
End Class