Imports System.Data.OleDb

Public Class login
    Dim con As New OleDb.OleDbConnection

    Private Sub letMeIn_Click(sender As Object, e As EventArgs) Handles letMeIn.Click
        Dim dbConn = New AccessDataBase()
        con = dbConn.dbConnect()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [system_user] WHERE user_name = @userName", con)
        cmd.Parameters.Add("@userName", userName.Text)

        Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        If sdr.Read() Then

            If sdr("password").ToString = password.Text Then
                Common.userId = sdr("user_id")
                Common.userName = sdr("user_fname") & " " & sdr("user_lname")
                Common.userRole = sdr("user_role")
                Common.agOfficeId = sdr("ag_office_id")

                Me.Hide()
                permitHeader.Show()
            Else
                MessageBox.Show("Incorrect Passwort!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Incorrect User Name!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Dim common As New Common()
        common.clearData(Me)
        fileUpload.Show()
    End Sub

End Class