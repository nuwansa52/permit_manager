Imports System.Data.OleDb

Public Class login
    Dim con As New OleDb.OleDbConnection

    Private Sub letMeIn_Click(sender As Object, e As EventArgs) Handles letMeIn.Click
        Dim dbConn = New AccessDataBase()
        con = dbConn.dbConnect()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT [password], [user_name] FROM [system_user] WHERE user_name = @userName", con)
        cmd.Parameters.Add("@userName", userName.Text)

        Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Dim comboSource As New Dictionary(Of String, String)()

        If sdr.Read() Then

            If sdr("password").ToString = password.Text Then
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Incorrect Passwort!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Incorrect User Name!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        userName.Text = ""
        password.Text = ""
        systemUser.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class