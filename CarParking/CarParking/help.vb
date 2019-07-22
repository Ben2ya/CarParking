Public Class help

    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Node0" Then
            RichTextBox1.Text = "Now-a-day's more parking spaces are required as the population of vehicles worldwide continues to increase, so the efficient parking management is becoming an important issue. This paper proposes a smart approach to find the parking lot in commercial car parking areas. The advantage of the approach is that it takes less time to find the parking lot in the parking areas. Sensors such as IR (Infra Red) are used in order to identify the entrance or exit of the car at the parking slot. The existing system gives information about the empty slots availability but does not give information about the exact location of parking slot available in such a big area. This is time taking process for the person to search for the empty slot and if the parking area is very big to search for the slot will consume a lot of time which is a major drawback for the pre-existing methods. The proposed car parking system takes the help of IR sensors to find the car at the entrance and at the exit area and thus allocates as well as de-allocates the available parking slots to the vehicles. This system clearly displays the total parking slots available and indicates the occupied slots and unoccupied slots in display board so that user can check the slots before entering the parking area and can park his car in that slot with in no time without wasting his/her time. The parking slots are continuously monitored and the data is continuously updated in the display board. The demonstration has shown the ability of the approach to reserve the parking lot, increase the entry to the parking area as well as eliminates the difficulties of searching empty parking lots. "
        End If
        If e.Node.Name = "Node1" Then
            RichTextBox1.Text = "Open Hours Monday 	9:00 am – 6:00 pm Tuesday 	9:00 am – 6:00 pm Wednesday 	9:00 am – 6:00 pm Thursday 	9:00 am – 6:00 pm Friday 	9:00 am – 6:00 pm Saturday 	10:00 am – 5:00 pm Sunday 	10:00 am – 5:00 pm  Holiday Hours Public Holidays 	10:00 am – 5:00 pm Christmas Day 	Closed"

        End If

        If e.Node.Name = "Node2" Then
            RichTextBox1.Text = "Our parking services in particular now support over 50,000 vehicle transactions daily. Nevertheless, the key to effective parking solutions is management expertise.we have built a reservoir of management capabilities including a portfolio of targeted software tools. This places the company in the best position to be your partner in every parking situation.With basic equipment, parking management can be enhanced reducing operating costs drastically.We offer parking management services under a Parking Management Agreement (PMA). Our clients have realized improved parking orderliness and reduced costs of parking area management. Indeed most of our clients have turned the parking  service from a drain of resources into a revenue centre."


        End If

        If e.Node.Name = "Node3" Then
            RichTextBox1.Text = "We wish to inform our esteemed Customers that the parking fees 1     -     2     Hours Kshs.     50.002     -     3     Hours      Kshs.     100.003     -     4     Hours    Kshs.     150.004     -     5     Hours     Kshs.     200.00 After 7pm free parking Thereafter an additional Kshs. 50 per eve"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class