Public Class frmTrackOrder
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblOrders' table. You can move, or remove it, as needed.
        Me.TblOrdersTableAdapter.Fill(Me.IS1111_Project1DataSet.tblOrders)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        frmHomePage.Show()
    End Sub

    Private Sub tsbManualTrack_Click(sender As Object, e As EventArgs) Handles tsbManualTrack.Click
        frmTrackManual.Show()
        Me.Close()
    End Sub
End Class