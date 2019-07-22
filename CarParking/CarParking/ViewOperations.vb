Public Class ViewOperations
    Sub Sum(ByVal DS As DataGridView, ByVal col As String)
        ' Try


        Dim sum As Integer = 0
        For i As Integer = 0 To DS.Rows.Count - 1
            sum = Integer.Parse(DS.Rows(i).Cells(col).Value.ToString()) + sum
            '  MessageBox.Show(DataGridView2.Rows(i).Cells(5).Value.ToString())
        Next
        total.Text = sum.ToString

    End Sub
    Private Sub ViewOperations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DatabaseOperations.LoadTable(DataGridView1, "SELECT * FROM carparkingservices WHERE 1")
        Sum(DataGridView1, "Charges")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DatabaseOperations.LoadTable(DataGridView1, "SELECT * FROM carparkingservices WHERE DateTime = '" + DateTimePicker1.Text + "'")
        Sum(DataGridView1, "Charges")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class