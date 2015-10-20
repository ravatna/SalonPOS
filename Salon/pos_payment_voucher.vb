Public Class pos_payment_voucher
    Dim _grandTotal As Decimal
    Public Property grandTotal() As Decimal
        Get
            Return _grandTotal
        End Get
        Set(ByVal value As Decimal)
            _grandTotal = value
        End Set
    End Property

    Dim _UnPaid As Decimal
    Public Property UnPaid() As Decimal
        Get
            Return _UnPaid
        End Get
        Set(ByVal value As Decimal)
            _UnPaid = value
        End Set
    End Property

    Dim _PaymentType As String
    Public Property PaymentType() As String
        Get
            Return _PaymentType
        End Get
        Set(ByVal value As String)
            _PaymentType = value
        End Set
    End Property

    Dim _Pay As Decimal
    Public Property Pay() As Decimal
        Get
            Return _Pay
        End Get
        Set(ByVal value As Decimal)
            _Pay = value
        End Set
    End Property

    Dim _SplitPay As Decimal
    Public Property SplitPay() As Decimal
        Get
            Return _SplitPay
        End Get
        Set(ByVal value As Decimal)
            _SplitPay = value
        End Set
    End Property

    Dim _PayeeEmployee As String
    Public Property PayeeEmployee() As String
        Get
            Return _PayeeEmployee
        End Get
        Set(ByVal value As String)
            _PayeeEmployee = value
        End Set
    End Property

    Dim _CardNo As String
    Public Property CardNo() As String
        Get
            Return _CardNo
        End Get
        Set(ByVal value As String)
            _CardNo = value
        End Set
    End Property
    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub pos_payment_coupon_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If Pay = 0 Then

            txtSplitPaid.Text = UnPaid
            If PaymentType.ToUpper = "CREDITC txtCash.Text = UnPaid

            End If
        Else
            txtSplitPaid.Text = SplitPay

        End If
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        If txtSplitPaid.Text = "" Then
            MessageBox.Show("กรุณากรอกจำนวนที่ต้องการชำระ", "ข้อความ", MessageBoxButtons.OK)


        Else
            Pay = txtSplitPaid.Text

            SplitPay = txtSplitPaid.Text
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class