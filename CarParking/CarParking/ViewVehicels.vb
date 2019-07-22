Public Class ViewVehicels

    Private Sub ViewVehicels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatabaseOperations.LoadTable(DataGridView1, "SELECT * FROM details")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DatabaseOperations.LoadTable(DataGridView1, "SELECT * FROM details WHERE CarPlare = '" + TextBox1.Text + "%'")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class