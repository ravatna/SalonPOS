Imports System.Data.SqlClient
Public Class storehouse_main_form


    Dim invCode As String = ""


    Private Sub storehouse_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControl1.Appearance = TabAppearance.FlatButtons
        Me.TabControl1.ItemSize = New Size(0, 1)
        Me.TabControl1.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub storehouse_main_form_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(221, Byte), Integer)), 1)
        e.Graphics.DrawLine(pen, 0, 74, Me.Width, 74) '(margin_left, top_from_left, wide, top_from_right)
    End Sub

    Protected button_navigate_foreground_color As Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(111, Byte), Integer))
    Protected button_navigate_background_color As Color = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
    Protected button_navigate_foreground_hover_color As Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
    Protected button_navigate_background_hover_color As Color = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(251, Byte), Integer))

    Private Sub button_request_order_history_Click(sender As Object, e As EventArgs) Handles button_request_history.Click
        storehouse_pr_choose_history_dialog.Show()
    End Sub


    Private Sub button_burchase_Click(sender As Object, e As EventArgs) Handles button_burchase.Click
        TabControl1.SelectedTab = TabPage2
        Me.button_request.ForeColor = button_navigate_foreground_color
        Me.button_request.BackColor = button_navigate_background_color
        Me.button_burchase.ForeColor = button_navigate_foreground_hover_color
        Me.button_burchase.BackColor = button_navigate_background_hover_color
        Me.button_delivery.ForeColor = button_navigate_foreground_color
        Me.button_delivery.BackColor = button_navigate_background_color
    End Sub

    Private Sub button_delivery_Click(sender As Object, e As EventArgs) Handles button_delivery.Click
        TabControl1.SelectedTab = TabPage3
        Me.button_request.ForeColor = button_navigate_foreground_color
        Me.button_request.BackColor = button_navigate_background_color
        Me.button_burchase.ForeColor = button_navigate_foreground_color
        Me.button_burchase.BackColor = button_navigate_background_color
        Me.button_delivery.ForeColor = button_navigate_foreground_hover_color
        Me.button_delivery.BackColor = button_navigate_background_hover_color
    End Sub

    Private Sub button_request_Click(sender As Object, e As EventArgs) Handles button_request.Click
        TabControl1.SelectedTab = TabPage1

        Me.button_request.ForeColor = button_navigate_foreground_hover_color
        Me.button_request.BackColor = button_navigate_background_hover_color
        Me.button_burchase.ForeColor = button_navigate_foreground_color
        Me.button_burchase.BackColor = button_navigate_background_color
        Me.button_delivery.ForeColor = button_navigate_foreground_color
        Me.button_delivery.BackColor = button_navigate_background_color
    End Sub

    Private Sub button_purchase_browse_Click(sender As Object, e As EventArgs) Handles button_purchase_browse_request.Click
        storehouse_pr_choose_request_no.Show()
    End Sub

    Private Sub button_delivery_history_Click(sender As Object, e As EventArgs) Handles button_delivery_history.Click
        storehouse_pd_choose_history_dialog.Show()
    End Sub

    Private Sub button_purchase_history_Click(sender As Object, e As EventArgs) Handles button_purchase_history.Click
        storehouse_po_choose_history_dialog.Show()
    End Sub

    Private Sub button_delivery_browse_request_no_Click(sender As Object, e As EventArgs) Handles button_delivery_browse_request_no.Click
        storehouse_pd_choose_request_no.Show()
    End Sub

    Private Sub button_request_browse_item_Click(sender As Object, e As EventArgs) Handles button_request_browse_item.Click

    End Sub

    Private Sub button_delivery_browse_item_Click(sender As Object, e As EventArgs) Handles button_delivery_browse_item.Click

    End Sub

    Private Sub button_purchase_browse_item_Click(sender As Object, e As EventArgs) Handles button_purchase_browse_item.Click

    End Sub

    Private Sub button_request_new_Click(sender As Object, e As EventArgs) Handles button_request_new.Click

    End Sub

    Private Sub clearRequestForm()
        textbox_request_note.Clear()
        textbox_request_amount.Clear()
        textbox_request_product.Clear()
        combobox_request_unit.SelectedIndex = 0

        datetimepicker_requestdate.Refresh()
        label_request_no.Text = getNewRequestNo() ' get new request no

    End Sub

    Private Function getNewRequestNo()
        Dim _code = "INV";


        Return ""
    End Function

    Sub deleteDataFrom(table As String, onField As String, val As String)

        Using connection As SqlConnection = ConnectionManagement.GetConnection

            Dim cnn As SqlConnection = ConnectionManagement.GetConnection
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Dim Sql As String

            ' delete sale detail
            Sql = "UPDATE " & table & " SET [Status]='Inactive' WHERE " & onField & " =  '" & val & "'"

            Dim commandDeleteitem = New SqlCommand(Sql, cnn)
            commandDeleteitem.CommandText = Sql

            Try
                commandDeleteitem.ExecuteNonQuery()
                MessageBox.Show("Delete success")
            Catch ex As Exception
                MessageBox.Show("Can not delete")
            End Try

        End Using

    End Sub

End Class