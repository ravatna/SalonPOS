Public Class login_form

    Private Sub button_login_Click(sender As Object, e As EventArgs) Handles button_login.Click
        Dim username As String = textbox_username.Text
        Dim password As String = textbox_password.Text

        If String.IsNullOrEmpty(username.Trim()) Or String.IsNullOrEmpty(password.Trim()) Then
            label_result.ResetText()
            Me.label_result.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(139, Byte), Integer))
            label_result.Text = "Please enter the user id and password"
        Else

            If username.IndexOf("apple", 0, StringComparison.CurrentCultureIgnoreCase) > -1 And password = "orange" Then
                welcome_form.Show()
                Me.Close()
            Else
                Me.label_result.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(20, Byte), Integer))
                label_result.Text = "Incorrect username or password"
            End If
        End If
    End Sub

    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Application.Exit()
    End Sub
End Class