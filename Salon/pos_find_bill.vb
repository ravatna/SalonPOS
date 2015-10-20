Public Class pos_find_bill


    Dim _SaleCode As String
    Public Property SaleCode() As String
        Get
            Return _SaleCode
        End Get
        Set(ByVal value As String)
            _SaleCode = value
        End Set
    End Property


    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        loadLvtData()
    End Sub



    Sub loadLvtData()
        Dim sql As String
        sql = "select Sale.Code,Product.Title as ProductTitle, Employee.Firstname + ' ' + Employee.Lastname as Fullname,Customer.Name,Sale.Total,Sale.Discount,Sale.GrandTotal from ((((Sale left join SaleDetail ON Sale.Code = SaleDetail.Sale ) left join Customer on SaleDetail.Customer = Customer.ID ) left join Employee on SaleDetail.Stylish = Employee.ID) left join Product on SaleDetail.Product = Product.Code)   where Sale.Status ='Active' and (   Customer.Name like '%" & txtSearch.Text & "%' or  Customer.Nickname like '%" & txtSearch.Text & "%' or Customer.Phone like '%" & txtSearch.Text & "%' or Sale.CODE like '%" & txtSearch.Text & "%') order by Sale.Code desc"

        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

        lvtItem.Items.Clear()
        Dim i As Integer

        For i = 0 To dt.Rows.Count - 1

            If Not dt.Rows(i).Item("Code") Is DBNull.Value Then

                Dim item(6) As String
                item(0) = Common.IsNullToString(dt.Rows(i).Item("Code"))
                item(1) = Common.IsNullToString(dt.Rows(i).Item("ProductTitle"))
                item(2) = Common.IsNullToString(dt.Rows(i).Item("Fullname"))
                item(3) = Common.IsNullToString(dt.Rows(i).Item("Name"))
                item(4) = Common.IsNullToString(dt.Rows(i).Item("Total"))
                item(5) = Common.IsNullToString(dt.Rows(i).Item("Discount"))
                item(6) = Common.IsNullToString(dt.Rows(i).Item("GrandTotal"))


                Dim lr As New ListViewItem(item)
                lr.Tag = dt.Rows(i).Item("Code")
                lvtItem.Items.Add(lr)

            End If
        Next
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click

        If lvtItem.SelectedItems.Count <> 0 Then
            SaleCode = lvtItem.SelectedItems(0).Tag
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub pos_find_bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            loadLvtData()
        End If
    End Sub

    Private Sub pos_find_bill_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub lvtItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lvtItem.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If lvtItem.SelectedItems.Count <> 0 Then
                SaleCode = lvtItem.SelectedItems(0).Tag
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub
End Class