Public Class frmManualFind
    Private Sub frmManualFind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCheck.Items.Add("1: Find out which orderiD you are looking for.")
        lstCheck.Items.Add("2: Using the naviagtion bar at the top of the form")
        lstCheck.Items.Add("   click the 'Next' button to move between each order.")
        lstCheck.Items.Add("3: You can make edit orders by selecting the 'Add New' button.")
        lstCheck.Items.Add("4: You can remove orders by slecting the 'Delete' button")
        lstCheck.Items.Add("5: Click the Back to homepage to go back to homepage.")
    End Sub
End Class