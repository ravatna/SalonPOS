Public Class IDN_NumericTextbox
    Inherits TextBox

 


    Private Sub IDN_NumericTextbox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True

        Else
            If e.KeyChar = "." Then
                If Me.Text.IndexOf(".") = -1 Then

                Else
                    e.Handled = True

                End If
            End If

        End If
    End Sub
End Class

