Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        MessageBox.Show(txtFirstName.Text)
        txtFirstName.BackColor = Color.Red()
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChange
    End Sub
End Class
