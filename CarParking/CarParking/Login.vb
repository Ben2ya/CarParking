Public Class Login

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try


            Sign_Up.Show()

            Me.Hide()

        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim query As String = "SELECT * FROM Login WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'"
            ' DatabaseOperations.Connect()
            If DatabaseOperations.Login(query) Then
                Me.Hide()

                ControlMenu.ShowDialog()

            Else
                MessageBox.Show("Unable To Login", "Login")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

       


    End Sub
End Class