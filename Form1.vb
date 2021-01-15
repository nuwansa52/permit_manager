Imports System.Data.OleDb

Public Class Form1
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Nilu\DCBA - Project.accdb")

    Function dbConnect() As Boolean

        Try
            con.Open()

            If con.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If dbConnect() Then

                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [user_id], [user_name] FROM [system_user]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of String, String)()

                While sdr.Read()
                    comboSource.Add(sdr("user_id").ToString, sdr("user_name").ToString)
                End While

                ComboBox1.DataSource = New BindingSource(comboSource, Nothing)
                ComboBox1.DisplayMember = "Value"
                ComboBox1.ValueMember = "Key"


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim key As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value
        MessageBox.Show(key & " - " & value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value

        Dim sql As String = "INSERT INTO [system_user] VALUES(@id, @userName, @fName, @lName, @userRole, @userDept)"

        If dbConnect() Then
            Using sqlCom = New OleDbCommand(sql, con)
                sqlCom.Parameters.Add("@id", OleDbType.VarWChar).Value = 3
                sqlCom.Parameters.Add("@userName", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@fName", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@lName", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@userRole", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@userDept", OleDbType.VarWChar).Value = value
                Dim icount As Integer = sqlCom.ExecuteNonQuery
            End Using
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value

        Dim sql As String = "UPDATE [system_user] SET user_name = @userName WHERE [user_id] = 1"

        If dbConnect() Then
            Using sqlCom = New OleDbCommand(sql, con)
                sqlCom.Parameters.Add("@userName", OleDbType.VarWChar).Value = value
                Dim icount As Integer = sqlCom.ExecuteNonQuery
            End Using
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        login.Show()
    End Sub
End Class
