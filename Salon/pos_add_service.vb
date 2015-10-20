Public Class pos_add_service

    Dim _ProductType As String

    Dim _ProductCode As String
    Dim _ProductName As String

    Dim _CustomerCode As String
    Dim _CustomerName As String

    Dim _StylishCode As String
    Dim _StylishName As String

    Dim _CustomerTypeCode As String
    Dim _CustomerTypeName As String

    Dim _QTY As Integer
    Dim _Price As Decimal
    Dim _Discount As Decimal


    Public Property ProductCode() As String
        Get
            Return _ProductCode
        End Get
        Set(ByVal value As String)
            _ProductCode = value
        End Set
    End Property

    Public Property ProductName() As String
        Get
            Return _ProductName
        End Get
        Set(ByVal value As String)
            _ProductName = value
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

    Public Property StylishCode() As String
        Get
            Return _StylishCode
        End Get
        Set(ByVal value As String)
            _StylishCode = value
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


    Public Property ProductType() As String
        Get
            Return _ProductType
        End Get
        Set(ByVal value As String)
            _ProductType = value
        End Set
    End Property

    
    Public Property QTY() As Integer
        Get
            Return _QTY
        End Get
        Set(ByVal value As Integer)
            _QTY = value
        End Set
    End Property


    Public Property Price() As Decimal
        Get
            Return _Price
        End Get
        Set(ByVal value As Decimal)
            _Price = value
        End Set
    End Property



    Public Property Discount() As Decimal
        Get
            Return _Discount
        End Get
        Set(ByVal value As Decimal)
            _Discount = value
        End Set
    End Property


    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        loadData()
    End Sub


    Private Sub pos_add_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        LoadEmployeeCombobox()
        LoadCustomerVisitTypeCombobox()


        If Not String.IsNullOrEmpty(GlobalVar.POSCustomerType) Then
            cboCustomerType.SelectedValue = GlobalVar.POSCustomerType
            CustomerTypeCode = GlobalVar.POSCustomerType

            cboStylist.SelectedValue = GlobalVar.POSStylish
            StylishCode = GlobalVar.POSStylish

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
    Sub loadData(Optional Brand As String = "")
        lvtItem.Clear()
        Dim sql As String = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
        sql &= " FROM         Product INNER JOIN"
        sql &= "               ProductUnit ON Product.ProductUnit = ProductUnit.Code join producttype on Product.producttype=producttype.code where (Product.Code Like '%" & txtSearch.Text & "%' or Product.CodeNO Like '%" & txtSearch.Text & "%' or  product.title like '%" & txtSearch.Text & "%' or producttype.title like '%" & txtSearch.Text & "%')"
        If Brand <> "" Then
            sql &= "   and (Product.Brand='" & Brand & "')"
        End If


        sql &= "   and (Product.ProductType='" & ProductType & "')"


        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            Dim i As Integer
            lvtItem.Columns.Add("Name", -2, HorizontalAlignment.Center)
            For i = 0 To dt.Rows.Count - 1


                Dim item1 As New ListViewItem(dt.Rows(i).Item("title").ToString)
                If dt.Rows(i).Item("Producttype").ToString = "0001" Then
                    item1.ImageIndex = 0
                ElseIf dt.Rows(i).Item("Producttype").ToString = "0003" Then
                    item1.ImageIndex = 0
                ElseIf dt.Rows(i).Item("Producttype").ToString = "0002" Then
                    item1.ImageIndex = 0
                Else
                    item1.ImageIndex = 0
                End If

                item1.Tag = dt.Rows(i).Item("Code").ToString


                lvtItem.Items.Add(item1)
            Next

        End Using

    End Sub

    Private Sub lvtItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvtItem.SelectedIndexChanged
        If lvtItem.SelectedItems.Count > 0 Then
            lblServiceName.Text = lvtItem.SelectedItems(0).Text
            lblServiceName.Tag = lvtItem.SelectedItems(0).Tag
            panel_discount.Enabled = True
        End If


    End Sub
    Private Sub txtDisPercent_GotFocus(sender As Object, e As System.EventArgs) Handles txtDisPercent.GotFocus
        txtdisBath.Text = ""

    End Sub

    Private Sub txtDiscount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDisPercent.TextChanged
        Dim grandTotal, discount As Decimal
        grandTotal = txtPrice.Text
        If txtDisPercent.Text <> "" And txtDisPercent.Text <> "0" Then
            discount = grandTotal * (CDec(txtDisPercent.Text) / 100)
            txtdisBath.Text = discount
            grandTotal = CDec(grandTotal) - discount

        End If
        lblNet.Text = CDec(grandTotal).ToString("F2")
    End Sub


    Private Sub txtdisBath_GotFocus(sender As Object, e As System.EventArgs) Handles txtdisBath.GotFocus
        txtDisPercent.Text = ""
        txtdisBath.Text = ""

    End Sub

    Private Sub txtdisBath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdisBath.TextChanged
        Dim grandTotal, discount As Decimal
        grandTotal = txtPrice.Text
        If txtdisBath.Text <> "" And txtdisBath.Text <> "0" Then

            discount = txtdisBath.Text
            grandTotal = CDec(grandTotal) - discount

        End If
        lblNet.Text = CDec(grandTotal).ToString("F2")
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        If lblNet.Text = "0" Or lblNet.Text = "" Then
            MessageBox.Show("Please enter price", "Message", MessageBoxButtons.OK)
        Else

            
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

            ' CustomerCode = cboCustomer.SelectedValue
            'CustomerName = CustomerName


            ProductCode = lvtItem.SelectedItems(0).Tag ' assign value product code
            ProductName = lvtItem.SelectedItems(0).SubItems(0).Text ' assign value product name
            Price = txtPrice.Text

            If String.IsNullOrEmpty(txtdisBath.Text) Then
                Discount = 0
            Else
                Discount = txtdisBath.Text
            End If

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If
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


    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs)


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

    Private Sub lblCustomerData_Click(sender As Object, e As EventArgs) Handles lblCustomerData.Click

    End Sub

    Private Sub panel_discount_Paint(sender As Object, e As PaintEventArgs) Handles panel_discount.Paint

    End Sub
End Class