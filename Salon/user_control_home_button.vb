Public Class user_control_home_button

    Private Sub button_home_Click(sender As Object, e As EventArgs) Handles button_home.Click
        Dim Form As Form = Me.Parent
        Form.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label_time.Text = Format(Now, "dd MMM yyyy h:mm:ss tt")
    End Sub

    Private Sub button_logout_Click(sender As Object, e As EventArgs) Handles button_logout.Click
        Dim Form As Form = Me.Parent
        Form.Close()
    End Sub

    Private Sub user_control_home_button_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
