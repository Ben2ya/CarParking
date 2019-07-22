Imports MySql.Data.MySqlClient

Module DatabaseOperations
    Dim Con As New MySqlConnection("Server=localhost;uid=root;password=;database=carparking;")
    Dim cmd As MySqlCommand
    Dim adp As MySqlDataAdapter
    Public read As MySqlDataReader
    Sub Connect()
        Con.Open()
    End Sub
    Sub RunSQL(ByVal SQL As String)
        Con.Open()
        cmd = New MySqlCommand(SQL, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
    End Sub
    Function Login(ByVal sql As String)
        Con.Open()

        cmd = New MySqlCommand(sql, Con)
        read = cmd.ExecuteReader()
        If read.Read Then
            Return True
        Else
            Return False
        End If
        Con.Close()
    End Function
    Sub LoadTable(ByVal grid As DataGridView, ByVal sql As String)
        'Con.Open()
        adp = New MySqlDataAdapter(sql, Con)
        Dim table As New DataTable

        grid.DataSource = table
        Con.Close()
    End Sub

End Module
