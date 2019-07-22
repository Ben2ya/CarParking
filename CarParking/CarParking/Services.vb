Public Class Services

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Services_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatabaseOperations.LoadTable(DataGridView1, "SELECT Name,Amount FROM services")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("Please Provide Service Details ", "Invalid Entry")
        Else

            Dim SQL As String = "INSERT INTO `services`(`Name`, `Amount`) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "')"
            DatabaseOperations.RunSQL(SQL)
            MessageBox.Show("Successfully Saved Service Information", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DatabaseOperations.LoadTable(DataGridView1, "SELECT Name,Amount FROM services")
        End If

    End Sub
End Class