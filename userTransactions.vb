Imports System.Data.OleDb

Public Class userTransactions
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = dbConn.dbConnect()

        Dim sql As String

        sql = "SELECT per_appication_no AS [Application No], per_transport_from AS [Transport From], per_transport_to AS [Transport To], per_transport_date_from AS [Transport Date From],
                    per_transport_date_to As [Transport Date To], per_vehicle_no As [Vehicle No], per_created_on As [Created Date]
               FROM [permit_header]
               WHERE [per_created_by] = " & DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key & " AND [per_created_on] BETWEEN '" & DateTimePicker2.Value.ToString("yyyy/MM/dd HH:mm:ss") & "' AND '" & DateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm:ss") & "'"


        Dim adapter As New OleDbDataAdapter(sql, con)

        Dim dt As New DataTable("system_user")

        adapter.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub

    Private Sub userTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'User Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [user_id], [user_name] FROM [system_user]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("user_id").ToString, sdr("user_name").ToString)
                End While

                ComboBox1.DataSource = New BindingSource(comboSource, Nothing)
                ComboBox1.DisplayMember = "Value"
                ComboBox1.ValueMember = "Key"

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class