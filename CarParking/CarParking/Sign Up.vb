Public Class Sign_Up

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Sign_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            MessageBox.Show("Please Provide your Details ", "Invalid Entry")
        Else
            Dim SQL As String = "INSERT INTO `login`(`Username`, `Password`, `Confirm_Password`) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
            DatabaseOperations.RunSQL(SQL)
            MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class