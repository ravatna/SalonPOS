Public Class pos_select_service

    Dim _ProductType As String

    Dim _ProductCode As String
    Dim _ProductName As String

    Dim _CustomerCode As String
    Dim _CustomerName As String

    Dim _StylishCode As String
    Dim _StylishName As String

    Dim _CustomerTypeCode As String
    Dim _CustomerTypeName As String


    Dim _grandTotal As Decimal
    

    Public Property StylishCode() As String
        Get
            Return _StylishCode
        End Get
        Set(ByVal value As String)
            _StylishCode = value
        End Set
    End Property

    Public Property StylishName() As String
        Get
            Return _StylishName
        End Get
        Set(ByVal value As String)
            _StylishName = value
        End Set
    End Property


    Public Property CustomerCode() As String
        Get
            Return _CustomerCode
        End Get
        Set(ByVal value As String)
            _CustomerCode = value
        End Set
    End Property

    Public Property CustomerName() As String
        Get
            Return _CustomerName
        End Get
        Set(ByVal value As String)
            _CustomerName = value
        End Set
    End Property

    Public Property CustomerTypeCode() As String
        Get
            Return _CustomerTypeCode
        End Get
        Set(ByVal value As String)
            _CustomerTypeCode = value
        End Set
    End Property

    Public Property CustomerTypeName() As String
        Get
            Return _CustomerTypeName
        End Get
        Set(ByVal value As String)
            _CustomerTypeName = value
        End Set
    End Property

    Dim _CustomerType As String
   

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

    Dim _ServiceName As String
    Public Property ServiceName() As String
        Get
            Return _ServiceName
        End Get
        Set(ByVal value As String)
            _ServiceName = value
        End Set
    End Property

    Public Property ProductCode() As String
        Get
            Return _ProductCode
        End Get
        Set(ByVal value As String)
            _ProductCode = value
        End Set
    End Property

    Dim _Price As Decimal
    Public Property Price() As Decimal
        Get
            Return _Price
        End Get
        Set(ByVal value As Decimal)
            _Price = value
        End Set
    End Property

    Dim _Discount As Decimal
    Public Property Discount() As Decimal
        Get
            Return _Discount
        End Get
        Set(ByVal value As Decimal)
            _Discount = value
        End Set
    End Property



    Dim txtForcus As String
    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub txtPrice_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrice.TextChanged
        If txtPrice.Text <> "" Then
            Dim grandTotal, discount As Decimal
            grandTotal = txtPrice.Text
            If txtDisPercent.Text <> "" And txtDisPercent.Text <> "0" Then
                discount = grandTotal * (CDec(txtDisPercent.Text) / 100)
                txtdisBath.Text = discount
                grandTotal = CDec(grandTotal) - discount

            End If
            lblNet.Text = CDec(grandTotal).ToString("F2")
        Else
            lblNet.Text = ""
        End If

    End Sub

    Private Sub txtDisPercent_GotFocus(sender As Object, e As System.EventArgs) Handles txtDisPercent.GotFocus
        txtdisBath.Text = ""

    End Sub

    Private Sub txtDiscount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDisPercent.TextChanged
        Dim grandTotal, discount As Decimal
        If txtPrice.Text = "" Then
            txtDisPercent.Text = ""
            'MessageBox.Show("Please enter Price", "Message", MessageBoxButtons.OK)
            Exit Sub
        Else
            grandTotal = txtPrice.Text
            If txtDisPercent.Text <> "" And txtDisPercent.Text <> "0" Then
                discount = grandTotal * (CDec(txtDisPercent.Text) / 100)
                txtdisBath.Text = discount
                grandTotal = CDec(grandTotal) - discount

            End If
            lblNet.Text = CDec(grandTotal).ToString("F2")
        End If

    End Sub

    Private Sub dlgServicePrice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblServiceName.Text = ServiceName
        LoadEmployeeCombobox()
        LoadCustomerVisitTypeCombobox()

        If Not String.IsNullOrEmpty(GlobalVar.POSCustomerType) Then



            cboCustomerType.SelectedValue = GlobalVar.POSCustomerType
            CustomerTypeName = GlobalVar.POSCustomerTypeName
            CustomerTypeCode = GlobalVar.POSCustomerType

            cboStylist.SelectedValue = GlobalVar.POSStylish
            StylishCode = GlobalVar.POSStylish
            StylishName = GlobalVar.POSStylishName

            setCustomerData(GlobalVar.POSCustomer, "CUSTOMER")
            CustomerCode = GlobalVar.POSCustomer
            CustomerName = GlobalVar.POSCustomerName
        End If






    End Sub

    Sub LoadCustomerVisitTypeCombobox()
        Dim dt As DataTable = Common.GetCustomerVisitTypeDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)

        cboCustomerType.DataSource = dt
        cboCustomerType.DisplayMember = "Title"
        cboCustomerType.ValueMember = "Code"
        cboCustomerType.SelectedIndex = 0
    End Sub

    Private Sub txtdisBath_GotFocus(sender As Object, e As System.EventArgs) Handles txtdisBath.GotFocus
        txtDisPercent.Text = ""
        txtdisBath.Text = ""

    End Sub

    Private Sub txtdisBath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdisBath.TextChanged
        Dim grandTotal, discount As Decimal
        If txtPrice.Text = "" Then
            ' MessageBox.Show("Please enter Price", "Message", MessageBoxButtons.OK)
            txtdisBath.Text = ""
            Exit Sub
        Else
            grandTotal = txtPrice.Text
            If txtdisBath.Text <> "" And txtdisBath.Text <> "0" Then
                discount = txtdisBath.Text
                grandTotal = CDec(grandTotal) - discount
                'grandTotal = CDec(grandTotal) - discount

            End If
            lblNet.Text = CDec(grandTotal).ToString("F2")
        End If

        'Dim grandTotal, discount As Decimal

        'grandTotal = txtPrice.Text
        'If txtdisBath.Text <> "" And txtdisBath.Text <> "0" Then

        '    discount = txtdisBath.Text
        '    grandTotal = CDec(grandTotal) - discount

        'End If
        'lblNet.Text = CDec(grandTotal).ToString("F2")
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        If String.IsNullOrEmpty(lblNet.Text) Or String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please enter the price")
            Exit Sub
        End If
        Price = txtPrice.Text
        

        If cboStylist.SelectedIndex = 0 Then
            MessageBox.Show("Please select the stylish")
            Exit Sub
        End If

        If String.IsNullOrEmpty(CustomerCode) Then
            MessageBox.Show("Please select the customer")
            Exit Sub
        End If

        If cboCustomerType.SelectedIndex = 0 Then
            MessageBox.Show("Please select type customer")
            Exit Sub
        End If


        StylishCode = cboStylist.SelectedValue
        StylishName = cboStylist.Text

        CustomerTypeCode = cboCustomerType.SelectedValue
        CustomerTypeName = cboCustomerType.Text

        GlobalVar.POSStylish = StylishCode
        GlobalVar.POSCustomerType = CustomerTypeCode
        GlobalVar.POSCustomerTypeName = CustomerTypeName


        '   CustomerCode = cboCustomer.SelectedValue
        '  CustomerName = cboCustomer.Text


        If txtdisBath.Text <> "" Then
            Discount = txtdisBath.Text
        Else
            Discount = 0
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Sub LoadEmployeeCombobox()
        Dim dt As DataTable = Common.GetEmployeeDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)

        cboStylist.DataSource = dt
        cboStylist.DisplayMember = "fullname"
        cboStylist.ValueMember = "ID"
        cboStylist.SelectedIndex = 0
    End Sub

    

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim frm As New pos_select_member

        frm.CustomerType = "CUSTOMER"

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CustomerCode = frm.CustomerCode
            CustomerName = frm.CustomerName
            GlobalVar.POSCustomerName = frm.CustomerName

            setCustomerData(CustomerCode, "CUSTOMER")

        End If
    End Sub

    Public Sub setCustomerData(CustomerCode As String, customertablename As String)
        Dim sql As String = "select TitlePrefix.title as PrefixTitle, *,province.title as provinceTitle from " & customertablename & " left outer join province on " & customertablename & ".province=province.code left outer join TitlePrefix on " & customertablename & ".title =TitlePrefix.code  where ID='" & CustomerCode & "'"
        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            GlobalVar.POSCustomer = dt.Rows(0).Item("ID") ' กำหนดค่าสำหรับ ตัวแปร global
            GlobalVar.POSCustomerName = Common.IsNullToString(dt.Rows(0).Item("PrefixTitle")) & " " & dt.Rows(0).Item("Name") ' กำหนดค่าสำหรับ ตัวแปร global

            lblCustomerData.Text = Common.IsNullToString(dt.Rows(0).Item("PrefixTitle")) & " " & dt.Rows(0).Item("Name")
            lblCustomerData.Text &= "/" & Common.IsNullToString(dt.Rows(0).Item("Nickname"))

            lblCustomerData.Text &= " (Tel:" & Common.IsNullToString(dt.Rows(0).Item("Phone")) & ")"

        End Using
    End Sub
End Class