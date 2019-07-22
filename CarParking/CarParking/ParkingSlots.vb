Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class ParkingSlots

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("Please Provide Service Details ", "Invalid Entry")
        Else

            Dim SQL As String = "INSERT INTO `parkingslots`(`ParkingSlot`, `Amount`,`Status`) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','Available')"
            DatabaseOperations.RunSQL(SQL)
            MessageBox.Show("Successfully Saved Service Information", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DatabaseOperations.LoadTable(slots, "SELECT ParkingSlot,Amount,Status FROM parkingslots")
        End If

    End Sub

    Private Sub ParkingSlots_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatabaseOperations.LoadTable(slots, "SELECT ParkingSlot,Amount,Status FROM parkingslots")

    End Sub

    Private Sub slots_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles slots.CellContentClick

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBoxD1.TextChanged

    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
        ' GroupBox3.Visible = False



    End Sub

    Private Sub details_Enter(sender As Object, e As EventArgs) Handles details.Enter
        Dim Connnection As New MySqlConnection("Server=localhost;uid=root;password=;database=carparking;")
        Dim adapter As New MySqlDataAdapter("SELECT `ID` , `Name` FROM services", Connnection)
        Dim table As New DataTable()

        adapter.Fill(table)
        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "ID"



    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim Con As New MySqlConnection("Server=localhost;uid=root;password=;database=carparking;")
        Dim cmd As MySqlCommand
        Dim read As MySqlDataReader
        Con.Open()
        cmd = New MySqlCommand("SELECT * FROM carparkingservices WHERE slot = '" + Slot.Text + "'", Con)
        read = cmd.ExecuteReader
        If read.Read Then
            TextBoxC1.Text = read.GetString(0)
            TextBoxC2.Text = read.GetString(1)
            TextBoxC4.Text = read.GetString(2)
            TextBoxC3.Text = read.GetString(3)
            TextBoxC5.Text = read.GetString(5)
            TextBoxC6.Text = read.GetString(6)
            TextBoxC7.Text = read.GetString(4)
            slots.Enabled = True
           
        Else
            MessageBox.Show("Cannot Find Vehicle", "Search Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            slots.Enabled = False


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Con As New MySqlConnection("Server=localhost;uid=root;password=;database=carparking;")
        Dim cmd As MySqlCommand
        Dim read As MySqlDataReader
        Con.Open()
        cmd = New MySqlCommand("SELECT slot FROM carparkingservices ", Con)
        read = cmd.ExecuteReader

        Select Case Slot.Text = read.Read
            Case Slot.Text = read.Read
                Label1A.Visible = False
                Label1N.Visible = True
                MessageBox.Show("slot taken")
            Case Slot.Text = read.Read
                Label2A.Visible = False
                Label2N.Visible = True
                MessageBox.Show("slot taken")
            Case Slot.Text = read.Read
                Label3A.Visible = False
                Label3N.Visible = True
                MessageBox.Show("slot taken")
            Case Slot.Text = read.Read
                Label4A.Visible = False
                Label4N.Visible = True
                MessageBox.Show("slot taken")

            Case Slot.Text = read.Read
                Label5A.Visible = False
                Label5N.Visible = True
                MessageBox.Show("slot taken")
            Case Slot.Text = read.Read
                Label6A.Visible = False
                Label6N.Visible = True
                MessageBox.Show("slot taken")

            Case Slot.Text = read.Read
                Label7A.Visible = False
                Label7N.Visible = True
                MessageBox.Show("slot taken")
            Case Slot.Text = read.Read
                Label8A.Visible = False
                Label8N.Visible = True
                MessageBox.Show("slot taken")
            Case Slot.Text = read.Read
                Label9A.Visible = False
                Label9N.Visible = True
                MessageBox.Show("slot taken")
            Case Else
                MessageBox.Show("slot available")
        End Select

       








        '  If LabelS1.TabIndex = "1" Then
        'Label1A.Visible = True
        'Else
        'Label1N.Visible = False
        'If Label1A.Visible = True Then
        'LabelS1.TabIndex = Slot.Text
        'MessageBox.Show("slot available")
        'Else

        'Label1N.Visible = True
        'Label1A.Visible = False
        'MessageBox.Show("slot occupied")

        'End If
        'End If
        TextBoxD3.Text = Slot.Text
        TextBoxC4.Text = Slot.Text

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBoxD1.Text = "" And TextBoxD2.Text = "" And TextBoxD3.Text = "" And TextBoxD5.Text = "" And TextBoxD4.Text = "" And ComboBox1.Text = "" And TextBoxD6.Text = "" Then
            MessageBox.Show("Please Provide Car Details ", "Invalid Entry")
        Else

            Dim SQL As String = "INSERT INTO `carparkingservices`(`Carplate`, `CarModel`, `slot`, `Color`, `DateTime`, `Service`, `Charges`) VALUES ('" + TextBoxD1.Text + "','" + TextBoxD2.Text + "', '" + TextBoxD3.Text + "','" + TextBoxD5.Text + "','" + TextBoxD4.Text + "' ,'" + ComboBox1.Text + "', '" + TextBoxD6.Text + "')"
            DatabaseOperations.RunSQL(SQL)
            MessageBox.Show("Slot Successfully Assigned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DatabaseOperations.LoadTable(slots, "SELECT Carplate,CarModel,slot,Color,DateTime,Service,Charges FROM carparkingservices")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBoxD4.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxD4.Text = Date.Now

    End Sub

    Private Sub TextBoxD2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxD3.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
      


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub
End Class