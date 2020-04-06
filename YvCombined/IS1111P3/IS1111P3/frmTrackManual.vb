Public Class frmTrackManual
    Private Sub frmTrackManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSearch.Items.Add("1: Ask the Customer for their OrderID.")
        lstSearch.Items.Add("2: Look down the list and check for the OrderID.")
        lstSearch.Items.Add("3: Tell Customer what stage fo the process their order is at.")
        lstSearch.Items.Add("4: Click Back to homepage and ask the customer do they have any other queries.")
    End Sub
End Class