Public Class pos_add_product
    Dim _ProductCode As String


    Dim _ProductName As String

    Dim _CustomerCode As String
    Dim _CustomerName As String

    Dim _StylishCode As String
    Dim _StylishName As String

    Dim _CustomerTypeCode As String
    Dim _CustomerTypeName As String
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

    Dim _ProductType As String
    Public Property ProductType() As String
        Get
            Return _ProductType
        End Get
        Set(ByVal value As String)
            _ProductType = value
        End Set
    End Property




    Dim _QTY As Integer
    Dim _Discount As Decimal

    Public Property QTY() As Integer
        Get
            Return _QTY
        End Get
        Set(ByVal value As Integer)
            _QTY = value
        End Set
    End Property

    Public Property Discount() As Integer
        Get
            Return _Discount
        End Get
        Set(ByVal value As Integer)
            _Discount = value
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

    Sub loadProductTypeData()
        LvtProductType.Clear()
        Dim sql As String = "select * from brand"
        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            Dim i As Integer
            LvtProductType.Columns.Add("Name", -2, HorizontalAlignment.Center)
            For i = 0 To dt.Rows.Count - 1


                Dim item1 As New ListViewItem(dt.Rows(i).Item("title").ToString)
                If dt.Rows(i).Item("code").ToString = "0001" Then
                    item1.ImageIndex = 1
                ElseIf dt.Rows(i).Item("code").ToString = "0003" Then
                    item1.ImageIndex = 1
                ElseIf dt.Rows(i).Item("code").ToString = "0004" Then
                    item1.ImageIndex = 1
                Else
                    item1.ImageIndex = 1
                End If

                item1.Tag = dt.Rows(i).Item("Code").ToString


                LvtProductType.Items.Add(item1)
            Next

        End Using

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
                    item1.ImageIndex = 1
                ElseIf dt.Rows(i).Item("Producttype").ToString = "0003" Then
                    item1.ImageIndex = 5
                ElseIf dt.Rows(i).Item("Producttype").ToString = "0002" Then
                    item1.ImageIndex = 4
                Else
                    item1.ImageIndex = 0
                End If

                item1.Tag = dt.Rows(i).Item("Code").ToString


                lvtItem.Items.Add(item1)
            Next

        End Using

    End Sub
    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        'DataGridView1.Rows.Add("1", "1020531", "caretrico type H", "SHAMPOO", "Arimino", "750", "100")
        'DataGridView1.Rows.Add("2", "1020532", "caretrico type H", "TREATMENT", "Arimino", "750", "100")
        'DataGridView1.Rows.Add("3", "1020533", "caretrico type S", "SHAMPOO", "Arimino", "750", "100")
        'DataGridView1.Rows.Add("4", "1020534", "caretrico type S", "TREATMENT", "Arimino", "750", "100")
        'DataGridView1.Rows.Add("5", "1020535", "caretrico after treatment", "lotion", "Arimino", "860", "100")
        'DataGridView1.Rows.Add("6", "1020536", "caretrico after treatment", "conc.oil", "Arimino", "1020", "100")
        'DataGridView1.Rows.Add("7", "1020537", "caretrico after treatment", "oil", "Arimino", "1020", "100")
        'DataGridView1.Rows.Add("12", "10205312", "SPICE", "tube series jelly", "Arimino", "460", "100")
        'DataGridView1.Rows.Add("13", "10205313", "SPICE", "sisters freeze wax", "Arimino", "460", "100")
        'DataGridView1.Rows.Add("8", "1020538", "Senscience volume boost", "mousse stylisante", "SHISEIDO", "420", "100")
        'DataGridView1.Rows.Add("9", "1020539", "UEVO", "hold wax (green)", "DEMI", "650", "100")
        'DataGridView1.Rows.Add("10", "10205310", "UEVO", "round wax (orange)", "DEMI", "650", "100")
        'DataGridView1.Rows.Add("11", "10205311", "UEVO", "dry wax (grey)", "DEMI", "650", "100")
        'DataGridView1.Rows.Add("", "102053", "UEVO", "Airloose wax (yellow)", "DEMI", "650", "100")
        'DataGridView1.Rows.Add("14", "10205314", "PREJUME DROP", "NO.1", "MILBON", "600", "100")
        'DataGridView1.Rows.Add("15", "10205315", "PREJUME DROP", "NO.2", "MILBON", "600", "100")
        'DataGridView1.Rows.Add("22", "10205322", "Pomade", "", "Admiral", "950", "100")
        loadData()
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

    Private Sub pos_add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProductTypeData()
        loadData("0001")


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

    Private Sub LvtProductType_Click(sender As Object, e As EventArgs) Handles LvtProductType.Click
        If LvtProductType.SelectedItems.Count <> 0 Then

            Dim sql As String = "select * from Brand where code = '" & LvtProductType.SelectedItems(0).Tag & "'"

            Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
                loadData(dt.Rows(0).Item("Code"))
            End Using
        End If
    End Sub

    Private Sub lvtItem_Click(sender As Object, e As EventArgs) Handles lvtItem.Click
        If lvtItem.SelectedItems.Count <> 0 Then

            Dim sql As String = "SELECT  Product.price,  Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
            sql &= " FROM         Product INNER JOIN"
            sql &= "               ProductUnit ON Product.ProductUnit = ProductUnit.Code"
            sql &= "     WHERE     (Product.code = '" & lvtItem.SelectedItems(0).Tag & "')"

            Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
                'txtPrice.Text = dt.Rows(0).Item("SalePrice")
                txtUnitTitle.Text = dt.Rows(0).Item("ProductUnitTitle")
                txtQTY.Text = 1
                If ProductType = "0001" Then
                    txtPrice.Text = dt.Rows(0).Item("price")
                End If
            End Using
        End If
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        If lvtItem.SelectedItems.Count <> 0 Then
            If lblNet.Text = "" Then
                MessageBox.Show("Please enter price", "Message", MessageBoxButtons.OK)
                Exit Sub
            End If


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

            If txtQTY.Text = "" Then
                QTY = 1
            Else
                QTY = txtQTY.Text
            End If

            If txtdisBath.Text = "" Then
                Discount = 0
            Else
                Discount = txtdisBath.Text
            End If

            ProductCode = lvtItem.SelectedItems(0).Tag
            Price = txtPrice.Text


            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please select product", "Message", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub listView_Click(sender As Object, e As System.EventArgs) Handles lvtItem.Click
        If lvtItem.SelectedItems.Count <> 0 Then

            Dim sql As String = "SELECT  Product.price,  Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
            sql &= " FROM         Product INNER JOIN"
            sql &= "               ProductUnit ON Product.ProductUnit = ProductUnit.Code"
            sql &= "     WHERE     (Product.code = '" & lvtItem.SelectedItems(0).Tag & "')"

            Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, Sql)
                'txtPrice.Text = dt.Rows(0).Item("SalePrice")
                txtUnitTitle.Text = dt.Rows(0).Item("ProductUnitTitle")
                txtQTY.Text = 1
                If ProductType = "0001" Then
                    txtPrice.Text = Common.IsNullToString(dt.Rows(0).Item("price"))
                End If
            End Using
        End If

    End Sub


    Private Sub lblPrice_Click(sender As Object, e As EventArgs)

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

    Private Sub txtDisPercent_TextChanged(sender As Object, e As EventArgs) Handles txtDisPercent.TextChanged
        Dim grandTotal, discount As Decimal

        If txtPrice.Text = "" Then txtPrice.Text = 0

        grandTotal = Decimal.Parse(txtPrice.Text) * Integer.Parse(txtQTY.Text)
        If txtDisPercent.Text <> "" And txtDisPercent.Text <> "0" Then
            discount = grandTotal * (CDec(txtDisPercent.Text) / 100)
            txtdisBath.Text = discount
            grandTotal = CDec(grandTotal) - discount

        End If
        lblNet.Text = CDec(grandTotal).ToString("F2")
    End Sub

    Private Sub txtdisBath_TextChanged(sender As Object, e As EventArgs) Handles txtdisBath.TextChanged
        Dim grandTotal, discount As Decimal

        If txtPrice.Text = "" Then txtPrice.Text = 0

        grandTotal = Decimal.Parse(txtPrice.Text) * Integer.Parse(txtQTY.Text)
        If txtdisBath.Text <> "" And txtdisBath.Text <> "0" Then

            discount = txtdisBath.Text
            grandTotal = CDec(grandTotal) - discount

        End If
        lblNet.Text = CDec(grandTotal).ToString("F2")
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Dim grandTotal, discount As Decimal

        If txtPrice.Text = "" Then txtPrice.Text = 0
        If txtQTY.Text = "" Then txtQTY.Text = 1

        grandTotal = Decimal.Parse(txtPrice.Text) * Integer.Parse(txtQTY.Text)

        If txtDisPercent.Text <> "" And txtDisPercent.Text <> "0" Then
            discount = grandTotal * (CDec(txtDisPercent.Text) / 100)
            txtdisBath.Text = discount
            grandTotal = CDec(grandTotal) - discount

        End If
        lblNet.Text = CDec(grandTotal).ToString("F2")
    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged
        Dim grandTotal, discount As Decimal

        If txtPrice.Text = "" Then txtPrice.Text = 0
        If txtQTY.Text = "" Then txtQTY.Text = 1

        grandTotal = Decimal.Parse(txtPrice.Text) * Integer.Parse(txtQTY.Text)

        If txtDisPercent.Text <> "" And txtDisPercent.Text <> "0" Then
            discount = grandTotal * (CDec(txtDisPercent.Text) / 100)
            txtdisBath.Text = discount
            grandTotal = CDec(grandTotal) - discount

        End If
        lblNet.Text = CDec(grandTotal).ToString("F2")
    End Sub

    Private Sub cboStylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStylist.SelectedIndexChanged

    End Sub
End Class