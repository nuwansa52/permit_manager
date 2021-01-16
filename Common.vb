Imports Org.BouncyCastle.Asn1.Crmf

Public Class Common

    Public Function clearData(form As Form) As Boolean

        Dim element As Control
        For Each element In form.Controls

            If TypeOf element Is TextBox Then
                element.Text = ""
            ElseIf TypeOf element Is ComboBox Then
                element.ResetText()
            End If

        Next

        Return True
    End Function

End Class
