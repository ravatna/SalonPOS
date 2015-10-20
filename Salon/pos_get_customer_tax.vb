Public Class pos_get_customer_tax

    Dim _CustomerCode As String
    Dim _CustomerName As String
    Dim _CustomerAddr1 As String
    Dim _CustomerAddr2 As String
    Dim _CustomerAddr3 As String
    Dim _CustomerTax As String
    Dim _CustomerMobile As String


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

    Public Property CustomerAddr1() As String
        Get
            Return _CustomerAddr1

        End Get
        Set(value As String)
            _CustomerAddr1 = value

        End Set
    End Property

    Public Property CustomerAddr2() As String
        Get
            Return _CustomerAddr2
        End Get

        Set(value As String)
            _CustomerAddr2 = value

        End Set
    End Property

    Public Property CustomerAddr3() As String
        Get
            Return _CustomerAddr3
        End Get

        Set(value As String)
            _CustomerAddr3 = value

        End Set
    End Property

    Public Property CustomerTax() As String
        Get
            Return _CustomerTax
        End Get

        Set(value As String)
            _CustomerTax = value

        End Set
    End Property

    Public Property CustomerMobile() As String
        Get
            Return _CustomerMobile
        End Get

        Set(value As String)
            _CustomerMobile = value

        End Set
    End Property

    Private Sub pos_get_customer_tax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvtItem.Columns.Clear()
        lvtItem.Columns.Add("Tel", 100, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Name", 200, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Nickname", 100, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Mobile", 100, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Addr 1", 100, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Addr 2", 100, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Addr 3", 100, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Tax No.", 100, HorizontalAlignment.Left)
    End Sub
    Sub loadLvtData()
        Dim sql As String
        sql = "SELECT     Customer.* ,TitlePrefix.Title as PrefixTitle"
        sql &= "  FROM         Customer LEFT OUTER JOIN"
        sql &= "           TitlePrefix ON Customer.Title = TitlePrefix.Code  where Customer.status='Active' and ( TAXID like '%" & txtSearch.Text & "%' or  Customer.Name like '%" & txtSearch.Text & "%' or  Customer.Nickname like '%" & txtSearch.Text & "%' or Phone like '%" & txtSearch.Text & "%' or ID like '%" & txtSearch.Text & "%') "



        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)



        lvtItem.Items.Clear()
        Dim i As Integer

        For i = 0 To dt.Rows.Count - 1

            If Not dt.Rows(i).Item("Name") Is DBNull.Value Then

                Dim item(6) As String
                item(0) = Common.IsNullToString(dt.Rows(i).Item("Phone"))
                item(1) = Common.IsNullToString(dt.Rows(i).Item("PrefixTitle")) & " " & dt.Rows(i).Item("NAME")
                item(2) = Common.IsNullToString(dt.Rows(i).Item("Nickname"))
                item(3) = Common.IsNullToString(dt.Rows(i).Item("Phone"))
                item(4) = Common.IsNullToString(dt.Rows(i).Item("Address"))
                item(5) = Common.IsNullToString(dt.Rows(i).Item("SubDistrict")) & " " & Common.IsNullToString(dt.Rows(i).Item("ZipCode"))
                item(6) = Common.IsNullToString(dt.Rows(i).Item("TAXID"))

                Dim lr As New ListViewItem(item)
                lr.Tag = dt.Rows(i).Item("ID")
                lvtItem.Items.Add(lr)

            End If



        Next
    End Sub
    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        loadLvtData()
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        If lvtItem.SelectedItems.Count <> 0 Then

            CustomerCode = lvtItem.SelectedItems(0).Tag


            CustomerName = lvtItem.SelectedItems.Item(0).SubItems(1).Text
            CustomerMobile = lvtItem.SelectedItems.Item(0).SubItems(3).Text
            CustomerAddr1 = lvtItem.SelectedItems.Item(0).SubItems(4).Text
            CustomerAddr2 = lvtItem.SelectedItems.Item(0).SubItems(5).Text
            CustomerTax = lvtItem.SelectedItems.Item(0).SubItems(6).Text


            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            loadLvtData()
        End If
    End Sub
End Class