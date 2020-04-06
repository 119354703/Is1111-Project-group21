Public Class frmEmployee
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.IS1111_Project1DataSet.tblEmployee)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmHomePage.Show()
    End Sub

    Private Sub tsbUserManual_Click(sender As Object, e As EventArgs) Handles tsbUserManual.Click
        frmManualEmployee.Show()
        Me.Hide()
    End Sub
End Class