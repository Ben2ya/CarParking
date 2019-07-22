Public Class CarDetails
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" Then
            MessageBox.Show("Please Provide Customer Car Details ", "Invalid Entry")
        Else
            Dim SQL As String = "INSERT INTO `details`(`Carplate`, `Carmodel`, `Color`, `OwnerName`, `Telephone`, `DatTime`) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DateTimePicker1.Text + "')"
            DatabaseOperations.RunSQL(SQL)
            MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DatabaseOperations.LoadTable(slots, "SELECT Carplate,Carmodel,Color,OwnerName,Telephone,DatTime FROM details")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatabaseOperations.LoadTable(slots, "SELECT Carplate,Carmodel,Color,OwnerName,Telephone,DatTime FROM details")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Function slots() As DataGridView
        Throw New NotImplementedException
    End Function

End Class