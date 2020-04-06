Public Class frmManualCustomer
    Private Sub frmManualCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCustomer.Items.Add("1: To Add a new customers information, click the add new button,")
        lstCustomer.Items.Add("   fill in the customers information and then click the save button.")
        lstCustomer.Items.Add("2: To delete customers information, click the delete button")
        lstCustomer.Items.Add("3: To edit customers info, fin the customers information by using the arrows")
        lstCustomer.Items.Add("   then change the information that they want chnaged and click the save button.")
        lstCustomer.Items.Add("4: to return to the customer details click the return button down in the corner.")
    End Sub

    Private Sub btnBackToCustomer_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        frmCustomer.Show()
    End Sub
End Class