Public Class pos_add_discount
    Dim _DiscountAmt As Decimal
    Public Property DiscountAmt() As Decimal
        Get
            Return _DiscountAmt
        End Get
        Set(ByVal value As Decimal)
            _DiscountAmt = value
        End Set
    End Property

    Dim _DiscountType As String
    Public Property DiscountType() As String
        Get
            Return _DiscountType
        End Get
        Set(ByVal value As String)
            _DiscountType = value
        End Set
    End Property
    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        If textbox_amount.Text = "" Then
            MessageBox.Show("กรุณากรอกจำนวน", "ข้อความ", MessageBoxButtons.OK)
        Else
            DiscountAmt = textbox_amount.Text
            If rdoBath.Checked = True Then
                DiscountType = "BATH"
            Else
                DiscountType = "PERCENTAGE"
            End If

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If


    End Sub
End Class