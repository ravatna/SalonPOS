Public Class pos_payment_cash
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

    Private Sub pos_payment_cash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
      

     


        'lblGrandTotal.Text = grandTotal
        'lblUnPaid.Text = UnPaid


        'If Pay = 0 Then
        '    txtCash.Text = ""
        '    txtCash.Text = UnPaid
        '    If PaymentType.ToUpper = "CREDITCARD" Or PaymentType.ToUpper = "CREDIT" Or PaymentType.ToUpper = "WELFARE" Then
        '        txtCash.Text = UnPaid

        '    End If
        'Else
        txtSplitPaid.Text = UnPaid
        ' txtCash.Text = Pay
        'End If

    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click



        If txtSplitPaid.Text = "" Then
            MessageBox.Show("Please enter pay amount", "Message", MessageBoxButtons.OK)

        ElseIf txtCash.Text = "" Then
            MessageBox.Show("Please enter cash receive amount", "Message", MessageBoxButtons.OK)
        Else
            If CDec(txtCash.Text) < CDec(txtSplitPaid.Text) Then
                MessageBox.Show("Receive amount is less than receive amount", "Message", MessageBoxButtons.OK)
            Else
                Pay = txtCash.Text
                SplitPay = txtSplitPaid.Text
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If


        End If



    End Sub

    Private Sub button_cash_20_Click(sender As Object, e As EventArgs) Handles button_cash_20.Click
        If txtCash.Text = "" Then
            txtCash.Text = 20
        Else
            txtCash.Text = CType(txtCash.Text, Decimal) + 20
        End If

    End Sub
    Private Sub button_cash_50_Click(sender As Object, e As EventArgs) Handles button_cash_50.Click
        If txtCash.Text = "" Then
            txtCash.Text = 50
        Else
            txtCash.Text = CType(txtCash.Text, Decimal) + 50
        End If
    End Sub
    Private Sub button_cash_100_Click(sender As Object, e As EventArgs) Handles button_cash_100.Click
        If txtCash.Text = "" Then
            txtCash.Text = 100
        Else
            txtCash.Text = CType(txtCash.Text, Decimal) + 100
        End If
    End Sub
    Private Sub button_cash_500_Click(sender As Object, e As EventArgs) Handles button_cash_500.Click
        If txtCash.Text = "" Then
            txtCash.Text = 500
        Else
            txtCash.Text = CType(txtCash.Text, Decimal) + 500
        End If
    End Sub
    Private Sub button_cash_1000_Click(sender As Object, e As EventArgs) Handles button_cash_1000.Click
        If txtCash.Text = "" Then
            txtCash.Text = 1000
        Else
            txtCash.Text = CType(txtCash.Text, Decimal) + 1000
        End If
    End Sub

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        txtCash.Clear()
    End Sub
End Class