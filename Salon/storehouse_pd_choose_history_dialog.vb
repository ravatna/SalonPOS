Public Class storehouse_pd_choose_history_dialog

    Private Sub button_cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub button_cancel_Click_1(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        'DataGridView1.Rows.Clear()
        'DataGridView1.Rows.Add("1", "102052", "นายแดง มีสุข", "0921048732")
        'DataGridView1.Rows.Add("2", "102053", "นายดำ สุขดี", "0972739862")
        'DataGridView1.Rows.Add("3", "102054", "นายเขียว หอมขจี", "0947621934")
        'DataGridView1.Rows.Add("4", "102055", "นายจัน อิ่มบุญ", "0932817634")
        'DataGridView1.Rows.Add("5", "102056", "นายหนวด ภักดี", "0984328754")
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class