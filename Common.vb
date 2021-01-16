Imports Org.BouncyCastle.Asn1.Crmf

Public Class Common
    Public Shared userId As Integer
    Public Shared userName As String
    Public Shared userRole As String
    Public Shared agOfficeId As Integer

    Public Function clearData(form As Form) As Boolean

        Dim element As Control
        For Each element In form.Controls

            If TypeOf element Is TextBox Then
                element.Text = ""
            ElseIf TypeOf element Is ComboBox Then
                element.ResetText()
            ElseIf TypeOf element Is GroupBox Then
                For Each gbElement In element.Controls
                    If TypeOf gbElement Is TextBox Then
                        gbElement.Text = ""
                    ElseIf TypeOf gbElement Is ComboBox Then
                        gbElement.ResetText()
                    ElseIf TypeOf gbElement Is MaskedTextBox Then
                        gbElement.Text = ""
                    End If
                Next
                element.ResetText()
            End If

        Next

        Return True
    End Function

End Class
