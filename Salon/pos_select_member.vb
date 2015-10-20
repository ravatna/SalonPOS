Public Class pos_select_member
    Dim _CustomerCode As String
    Dim _CustomerName As String
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

    Dim _CustomerType As String
    Public Property CustomerType() As String
        Get
            Return _CustomerType
        End Get
        Set(ByVal value As String)
            _CustomerType = value
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

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click

        loadLvtData(CustomerType)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        If lvtItem.SelectedItems.Count <> 0 Then

            CustomerCode = lvtItem.SelectedItems(0).Tag


            CustomerName = lvtItem.SelectedItems.Item(0).SubItems(1).Text

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub pos_select_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvtItem.Columns.Clear()
        lvtItem.Columns.Add("Tel", 100, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Name", 200, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Nickname", 100, HorizontalAlignment.Left)

        ' loadLvtData(CustomerType)
    End Sub

    Sub loadLvtData(customertablename As String)
        Dim sql As String
        sql = "SELECT     Customer.* ,TitlePrefix.Title as PrefixTitle"
            sql &= "  FROM         Customer LEFT OUTER JOIN"
            sql &= "           TitlePrefix ON Customer.Title = TitlePrefix.Code  where Customer.status='Active' and ( TAXID like '%" & txtSearch.Text & "%' or  Customer.Name like '%" & txtSearch.Text & "%' or  Customer.Nickname like '%" & txtSearch.Text & "%' or Phone like '%" & txtSearch.Text & "%' or ID like '%" & txtSearch.Text & "%') "



        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)



        lvtItem.Items.Clear()
        Dim i As Integer
        Dim address As String
        For i = 0 To dt.Rows.Count - 1
          
                If Not dt.Rows(i).Item("Name") Is DBNull.Value Then
                    address = ""
                    Dim item(3) As String
                    item(0) = Common.IsNullToString(dt.Rows(i).Item("Phone"))
                    item(1) = Common.IsNullToString(dt.Rows(i).Item("PrefixTitle")) & " " & dt.Rows(i).Item("NAME")
                    item(2) = Common.IsNullToString(dt.Rows(i).Item("Nickname"))


                    Dim lr As New ListViewItem(item)
                    lr.Tag = dt.Rows(i).Item("ID")
                    lvtItem.Items.Add(lr)

                End If



        Next
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            loadLvtData(CustomerType)
        End If
    End Sub

    Private Sub panel_control_Paint(sender As Object, e As PaintEventArgs) Handles panel_control.Paint

    End Sub

    Private Sub lvtItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvtItem.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub panel_header_Paint(sender As Object, e As PaintEventArgs) Handles panel_header.Paint

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class