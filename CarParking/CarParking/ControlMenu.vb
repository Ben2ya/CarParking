Public Class ControlMenu

    Private Sub ControlMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CarDetails.ShowDialog()


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ParkingSlots.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Services.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        MainSystem.ShowDialog()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ViewVehicels.ShowDialog()

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        ViewOperations.ShowDialog()


    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        MessageBox.Show("Vision Car Parking is Shuting Down", "EXIT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Environment.Exit(0)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Report.ShowDialog()

    End Sub

    Private Sub ControlMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        help.ShowDialog()

    End Sub
End Class