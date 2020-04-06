Public Class frmManualEmployee
    Private Sub frmManualEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOutput.Items.Add("1: To Add a new employee's information, click the add new button,")
        lstOutput.Items.Add("   fill in the employee information and then click the save button.")
        lstOutput.Items.Add("2: To delete employee's information, click the delete button")
        lstOutput.Items.Add("3: To edit employees info, fin the customers information by using the arrows")
        lstOutput.Items.Add("   then change the information that they want chnaged and click the save button.")
        lstOutput.Items.Add("4: To return to the employee details click the return button down in the corner.")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmEmployee.Show()
        Me.Hide()
    End Sub
End Class