Public Class welcome_form


    Private Sub button_pos_Click(sender As Object, e As EventArgs) Handles button_pos.Click
        pos_main_form.Show()
    End Sub

    Private Sub button_customer_Click(sender As Object, e As EventArgs) Handles button_customer.Click
        customer_main_form.Show()
    End Sub

    Private Sub button_purchasing_Click(sender As Object, e As EventArgs) Handles button_purchasing.Click
        storehouse_main_form.Show()
    End Sub

    Private Sub button_product_Click(sender As Object, e As EventArgs) Handles button_product.Click
        product_main_form.Show()
    End Sub

    Private Sub button_supplier_Click(sender As Object, e As EventArgs) Handles button_supplier.Click
        supplier_main_form.Show()
    End Sub

    Private Sub button_branch_Click(sender As Object, e As EventArgs) Handles button_branch.Click
        branch_main_form.Show()
    End Sub

    Private Sub button_account_Click(sender As Object, e As EventArgs) Handles button_account.Click
        account_main_form.Show()
    End Sub

    Private Sub button_memo_Click(sender As Object, e As EventArgs) Handles button_memo.Click
        service_memo_main_form.Show()
    End Sub

    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Application.Exit()
    End Sub

    Private Sub button_report_Click(sender As Object, e As EventArgs) Handles button_report.Click
        Summary_Service.Show()
    End Sub
End Class
