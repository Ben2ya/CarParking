Imports MySql.Data.MySqlClient

Public Class MainSystem

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Con As New MySqlConnection("Server=localhost;uid=root;password=;database=carparking;")
        Dim cmd As MySqlCommand
        Dim read As MySqlDataReader
        Con.Open()
        cmd = New MySqlCommand("SELECT * FROM details WHERE CarPlate = '" + TextBox7.Text + "'", Con)
        read = cmd.ExecuteReader
        If read.Read Then
            TextBox1.Text = read.GetString(0)
            TextBox2.Text = read.GetString(1)
            TextBox3.Text = read.GetString(2)
            TextBox4.Text = read.GetString(3)
            TextBox5.Text = read.GetString(4)
            TextBox6.Text = read.GetString(4)
            slots.Enabled = True
            DataGridView1.Enabled = True


        Else
            MessageBox.Show("Cannot Find Vehicle", "Search Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            slots.Enabled = False
            DataGridView1.Enabled = False
        End If


    End Sub
    Sub Sum(ByVal DS As DataGridView, ByVal col As String)
        ' Try


        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            sum = Integer.Parse(DataGridView2.Rows(i).Cells(5).Value.ToString()) + sum
            '  MessageBox.Show(DataGridView2.Rows(i).Cells(5).Value.ToString())
        Next
        total.Text = sum.ToString

    End Sub

    Private Sub MainSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatabaseOperations.LoadTable(slots, "SELECT ParkingSlot,Amount,Status FROM parkingslots")
        DatabaseOperations.LoadTable(DataGridView1, "SELECT Name,Amount FROM services")
        DatabaseOperations.LoadTable(DataGridView2, "SELECT * FROM carparkingservices")
        Sum(DataGridView2, "")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        DatabaseOperations.LoadTable(slots, "SELECT ParkingSlot,Amount,Status FROM parkingslots WHERE Status = '" + ComboBox1.Text + "'")

    End Sub

    Private Sub slots_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles slots.RowHeaderMouseClick
        ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        ContextMenuStrip2.Show(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub AddParkingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddParkingToolStripMenuItem.Click
        Dim row As DataGridViewRow
        row = slots.SelectedRows(0)
        Dim name As String = row.Cells(0).Value.ToString()
        Dim amount As String = row.Cells(1).Value.ToString()

        Dim SQL As String = "INSERT INTO `carparkingservices`(`Carplate`, `CarModel`, `Color`, `DateTime`, `Service`, `Charges`) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + name + "','" + amount + "')"
        DatabaseOperations.RunSQL(SQL)
        DatabaseOperations.LoadTable(DataGridView2, "SELECT * FROM carparkingservices")
        Sum(DataGridView2, "")



    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AddServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddServiceToolStripMenuItem.Click
        Dim row As DataGridViewRow
        row = DataGridView1.SelectedRows(0)
        Dim name As String = row.Cells(0).Value.ToString()
        Dim amount As String = row.Cells(1).Value.ToString()

        Dim SQL As String = "INSERT INTO `carparkingservices`(`Carplate`, `CarModel`, `Color`, `DateTime`, `Service`, `Charges`) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + name + "','" + amount + "')"
        DatabaseOperations.RunSQL(SQL)
        DatabaseOperations.LoadTable(DataGridView2, "SELECT * FROM carparkingservices")
        Sum(DataGridView2, "")

    End Sub
End Class