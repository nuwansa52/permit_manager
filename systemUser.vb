Imports System.Data.OleDb

Public Class systemUser
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub systemUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'City Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [ag_office_id], [description] FROM [ag_office]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("ag_office_id").ToString, sdr("description").ToString)
                End While

                agOfficeInput.DataSource = New BindingSource(comboSource, Nothing)
                agOfficeInput.DisplayMember = "Value"
                agOfficeInput.ValueMember = "Key"

                'Department
                Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT [department_id], [description] FROM [departments]", con)
                Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource1 As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("department_id").ToString, sdr("description").ToString)
                End While

                departmentInput.DataSource = New BindingSource(comboSource, Nothing)
                departmentInput.DisplayMember = "Value"
                departmentInput.ValueMember = "Key"

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs)

        con = dbConn.dbConnect()

        Dim value As String = DirectCast(roleInput.SelectedItem, KeyValuePair(Of String, String)).Value

        Dim sql As String = "INSERT INTO [system_user] VALUES(@userName, @userfName, @userlName, @userRole, @agOfficeId, @departmentId, @password)"

        If con.State = ConnectionState.Open Then
            Using sqlCom = New OleDbCommand(sql, con)
                sqlCom.Parameters.Add("@userName", OleDbType.VarWChar).Value = firstName.Text
                sqlCom.Parameters.Add("@userfName", OleDbType.VarWChar).Value = firstName.Text
                sqlCom.Parameters.Add("@userlName", OleDbType.VarWChar).Value = lastName.Text
                sqlCom.Parameters.Add("@userRole", OleDbType.VarWChar).Value = DirectCast(roleInput.SelectedItem, KeyValuePair(Of String, String)).Key
                sqlCom.Parameters.Add("@agOfficeId", OleDbType.VarNumeric).Value = DirectCast(agOfficeInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                sqlCom.Parameters.Add("@departmentId", OleDbType.VarNumeric).Value = DirectCast(departmentInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                sqlCom.Parameters.Add("@password", OleDbType.VarWChar).Value = password.Text
                Dim icount As Integer = sqlCom.ExecuteNonQuery
            End Using
        End If
    End Sub
    Private Sub DistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistrictToolStripMenuItem.Click
        district.Show()
    End Sub

    Private Sub CityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CityToolStripMenuItem.Click
        city.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        customer.Show()
    End Sub

    Private Sub DivisionalSectretariatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisionalSectretariatToolStripMenuItem.Click
        divisionalSecretariat.Show()
    End Sub

    Private Sub GramasewaWasamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GramasewaWasamToolStripMenuItem.Click
        gramaSewaWasama.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        department.Show()
    End Sub

    Private Sub PermitTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermitTypeToolStripMenuItem.Click
        permitType.Show()
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'City Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [system_user] WHERE [user_name]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                If sdr.Read() Then

                    userName.Text = sdr("user_name").ToString()
                    firstName.Text = sdr("user_fname").ToString()
                    lastName.Text = sdr("user_lname").ToString()
                    roleInput.SelectedIndex = roleInput.FindString(sdr.Item("user_role").ToString()).ToString()
                    agOfficeInput.SelectedIndex = roleInput.FindString(sdr.Item("ag_office_id").ToString()).ToString()
                    departmentInput.SelectedIndex = roleInput.FindString(sdr.Item("department_id").ToString()).ToString()
                    password.Text = sdr("password").ToString()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class