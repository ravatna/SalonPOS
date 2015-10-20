Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading

Public Class service_memo_main_form

    Dim SaleCode As String
    Dim MemoId As Integer
    Dim SaleBranch As String
    Dim _product As String
    Dim _customer As String
    Dim _code As String


    Private Sub service_memo_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        NullableDateTimePicker1.Value = Date.Now
        NullableDateTimePicker1.Format = DateTimePickerFormat.Custom
        NullableDateTimePicker1.CustomFormat = "dd/MM/yyyy"
        lvtItem.Columns.Add("Bill No", 90, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Product", 150, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Staff name", 150, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Customer name", 200, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Nickname", 150, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Date", 150, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Amount", 150, HorizontalAlignment.Left)
        
        lvtItem.Columns.Add("Void", 100, HorizontalAlignment.Left)

        lvtItem.Columns.Add("Stylish", 1, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Customer", 1, HorizontalAlignment.Left)
        lvtItem.Columns.Add("Product", 1, HorizontalAlignment.Left)

        listview_saleMemo.Columns.Add("No", 50, HorizontalAlignment.Left)
        

        loadLvtData(False, txtSearch.Text)
    End Sub


    'Sub LoadColorCombobox()
    '    Dim dt As DataTable = Common.GetColorDatatable
    '    Dim dr As DataRow = dt.NewRow()
    '    dr("CODE") = ""

    '    dt.Rows.InsertAt(dr, 0)

    '    cboColor.DataSource = dt
    '    cboColor.DisplayMember = "Title"
    '    cboColor.ValueMember = "Code"
    '    cboColor.SelectedIndex = 0
    'End Sub



    Private Sub loadLvtData(allstatus As Boolean, criteria As String)
        Dim sql As String
        Dim dt As DataTable
        sql = "SELECT     Sale.Code, sale.saledatetime, Sale.Branch, Sale.Shift, Sale.ShiftDate, Sale.Stylist, TitlePrefix_1.Title, Employee.Firstname, Employee.Lastname, TitlePrefix.Title AS Expr1,Customer.ID as Cust_ID, Customer.Name, Customer.NickName, "
        sql &= "  Sale.GrandTotal, Sale.Status, Product.Title as ProductName,saleDetail.Product, saleDetail.Stylish,saleDetail.Customer FROM         "
       

        sql &= " (((((Sale  inner join saleDetail on Sale.Code = SaleDetail.Sale )"
        sql &= " Left JOIN  Employee ON SaleDetail.Stylish = Employee.ID "
        sql &= " Left JOIN Customer ON SaleDetail.Customer = Customer.ID )"
        sql &= " Left join Product on SaleDetail.Product = Product.Code)"
        sql &= " Left JOIN  TitlePrefix ON Customer.Title = TitlePrefix.Code )"
        sql &= " Left JOIN  TitlePrefix AS TitlePrefix_1 ON Employee.Title = TitlePrefix_1.Code)"


        If allstatus = False Then
            sql &= " where  (Employee.ID like '%" & criteria & "%' or Employee.firstname like '%" & criteria & "%'  or Employee.lastname like '%" & criteria & "%' or Customer.name like '%" & criteria & "%' or Customer.nickname like '%" & criteria & "%' or sale.grandtotal like '%" & criteria & "%')"

            If NullableDateTimePicker1.Value <> Nothing Then
                sql &= " and CONVERT(date, sale.saledatetime)='" & CDate(NullableDateTimePicker1.Value).Date.Year & "-" & CDate(NullableDateTimePicker1.Value).Date.Month & "-" & CDate(NullableDateTimePicker1.Value).Date.Day & "'"

                sql &= " ORDER BY Code desc"

                Dim param(0) As SqlParameter
                'param(0) = New SqlClient.SqlParameter("@SaleDate", SqlDbType.DateTime)
                'param(0).Value = CDate(NullableDateTimePicker1.Value).Date
                dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            Else

                sql &= " ORDER BY Code desc"


                dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            End If


        Else

            sql &= " ORDER BY Code desc"

            dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        End If



        lvtItem.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(12) As String

            item(0) = dt.Rows(i).Item("Code")
            item(1) = IIf(IsDBNull(dt.Rows(i).Item("ProductName")), "", dt.Rows(i).Item("ProductName"))
            item(2) = "(" & dt.Rows(i).Item("Cust_ID") & ") " & dt.Rows(i).Item("firstname") + " " + dt.Rows(i).Item("lastname")
            item(3) = IIf(IsDBNull(dt.Rows(i).Item("Name")), "", dt.Rows(i).Item("Name"))
            item(4) = IIf(IsDBNull(dt.Rows(i).Item("NickName")), "", dt.Rows(i).Item("NickName"))
            item(5) = dt.Rows(i).Item("SaleDatetime")
            item(6) = dt.Rows(i).Item("GrandTotal")
            item(8) = dt.Rows(i).Item("Branch")


            item(7) = dt.Rows(i).Item("Status")


            item(9) = IIf(IsDBNull(dt.Rows(i).Item("Customer")), "", dt.Rows(i).Item("Customer"))
            item(10) = IIf(IsDBNull(dt.Rows(i).Item("Stylish")), "", dt.Rows(i).Item("Stylish"))
            item(11) = IIf(IsDBNull(dt.Rows(i).Item("Product")), "", dt.Rows(i).Item("Product"))

            Dim lr As New ListViewItem(item)
            lr.Tag = dt.Rows(i).Item("Code")
            lvtItem.Items.Add(lr)
        Next
    End Sub

    Private Sub loadLvtSaleMemoData(allstatus As Boolean, criteria As String)
        Dim sql As String
        Dim dt As DataTable
        sql = "SELECT [Stylish],[Customer],[Product],[Code],[Branch],[Status],[Cut_L],[Cut_M],[Cut_S],[HairType_Coarse],[HairType_Medium],[HairType_Fine] ,[HairType_Dry] ,[HairType_Normal],[HairType_Oily],[HairType_ALot],[HairType_Medium2],[HairType_Thin],[Color],[Color_Other],[Color_Brand],[Color_Amount] ,[Color_Unit]"
        sql &= ",[Perm_M],[Perm_H],[Perm_EX],[Perm_V],[Perm_Time],[Straight_M],[Straight_H],[Straight_EX],[Straight_V],[Straight_180],[Straight_200],[Straight_Time],[Treatment_SHERPA],[Treatment_PRIVA],[Treatment_caretico],[ShampooBlow],[MakeUp_Party],[MakeUp_Wedding],[MakeUp_Graduation],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP],[RefCode]"
        sql &= " FROM [dbo].[SaleMemo] "

        sql &= " where  (Code = '" & criteria & "')"

        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)


        listview_saleMemo.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(40) As String
            item(0) = dt.Rows(i).Item("MemoID")
            item(1) = dt.Rows(i).Item("Code")
            item(2) = dt.Rows(i).Item("Branch")
            item(3) = dt.Rows(i).Item("Status")
            item(4) = dt.Rows(i).Item("Cut_L")

            item(5) = dt.Rows(i).Item("Cut_M")
            item(6) = dt.Rows(i).Item("Cut_S")
            item(7) = dt.Rows(i).Item("HairType_Coarse")
            item(8) = dt.Rows(i).Item("HairType_Medium")
            item(9) = dt.Rows(i).Item("HairType_Fine")

            item(10) = dt.Rows(i).Item("HairType_Dry")
            item(11) = dt.Rows(i).Item("HairType_Normal")
            item(12) = dt.Rows(i).Item("HairType_Oily")
            item(13) = dt.Rows(i).Item("HairType_ALot")
            item(14) = dt.Rows(i).Item("HairType_Medium2")

            item(15) = dt.Rows(i).Item("HairType_Thin")
            item(16) = dt.Rows(i).Item("Color")

            item(17) = Common.IsNullToString(dt.Rows(i).Item("Color_Other"))
            item(18) = Common.IsNullToString(dt.Rows(i).Item("Color_Brand"))
            item(19) = Common.IsNullToString(dt.Rows(i).Item("Color_Amount"))
            item(20) = Common.IsNullToString(dt.Rows(i).Item("Color_Unit"))


            item(21) = dt.Rows(i).Item("Perm_M")
            item(22) = dt.Rows(i).Item("Perm_H")
            item(23) = dt.Rows(i).Item("Perm_EX")
            item(24) = dt.Rows(i).Item("Perm_V")
            item(25) = Common.IsNullToString(dt.Rows(i).Item("Perm_Time"))
            item(26) = dt.Rows(i).Item("Straight_M")
            item(27) = dt.Rows(i).Item("Straight_H")
            item(28) = dt.Rows(i).Item("Straight_EX")
            item(29) = dt.Rows(i).Item("Straight_V")

            item(30) = dt.Rows(i).Item("Straight_180")
            item(31) = dt.Rows(i).Item("Straight_200")
            item(32) = Common.IsNullToString(dt.Rows(i).Item("Straight_Time"))
            item(33) = dt.Rows(i).Item("Treatment_SHERPA")
            item(34) = dt.Rows(i).Item("Treatment_PRIVA")
            item(35) = dt.Rows(i).Item("Treatment_caretico")
            item(36) = dt.Rows(i).Item("ShampooBlow")
            item(37) = dt.Rows(i).Item("MakeUp_Party")
            item(38) = dt.Rows(i).Item("MakeUp_Wedding")
            item(39) = dt.Rows(i).Item("MakeUp_Graduation")

            Dim lr As New ListViewItem(item)
            lr.Tag = dt.Rows(i).Item("MemoID")

            listview_saleMemo.Items.Add(lr)
        Next
    End Sub


    Private Sub button_edit_Click(sender As Object, e As EventArgs) Handles button_edit.Click
        PnlDetail.Enabled = True
        button_proceed.Visible = True
        button_cancel.Visible = True

        assignDataToControl()
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        txtCode.Text = ""
        PnlDetail.Enabled = False
        button_proceed.Visible = False
        button_cancel.Visible = False
        lvtItem.Items(lastSelectedIndex).Selected = True
        lvtItem.Select()
        'assignDataToControl()
    End Sub

    Sub SaveData()
        'คำนวณตอนกดเสร็จ
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection

            Dim transaction As SqlTransaction
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            transaction = cnn.BeginTransaction()

            Try
                Dim rewardPont As Integer = 0
                Dim sql As String

                sql = "INSERT INTO [SaleMemo] ("
                sql &= "   [Code]"
                sql &= "  ,[Branch] "
                sql &= "  ,[Cut_L] "
                sql &= "  ,[Cut_M] "
                sql &= "  ,[Cut_S] "
                sql &= "  ,[Color] "

                sql &= "  ,[HairType_Coarse] "
                sql &= "  ,[HairType_Medium] "
                sql &= "  ,[HairType_Fine]  "

                sql &= "  ,[HairType_Dry] "
                sql &= "  ,[HairType_Normal] "
                sql &= "  ,[HairType_Oily] "

                sql &= "  ,[HairType_ALot] "
                sql &= "  ,[HairType_Medium2] "
                sql &= "  ,[HairType_Thin] "

                sql &= "   ,[Perm_M] "
                sql &= "  ,[Perm_H] "
                sql &= "  ,[Perm_EX] "
                sql &= "  ,[Perm_V] "

                If txtPerm_Time.Text = "" Then
                Else
                    sql &= "   ,[Perm_Time]"
                End If

                sql &= "   ,[Straight_M] "
                sql &= "   ,[Straight_H] "
                sql &= "  ,[Straight_EX] "
                sql &= "  ,[Straight_V] "
                sql &= "  ,[Straight_180] "
                sql &= "   ,[Straight_200] "
                If txtStraight_Time.Text = "" Then
                Else
                    sql &= "   ,[Straight_Time] "
                End If

                sql &= "   ,[Treatment_SHERPA] "
                sql &= "   ,[Treatment_PRIVA] "
                sql &= "   ,[Treatment_caretico] "
                sql &= "  ,[ShampooBlow] "
                sql &= "   ,[MakeUp_Party] "
                sql &= "   ,[MakeUp_Wedding] "
                sql &= "  ,[MakeUp_Graduation] "
                sql &= "    ,[LastUpdateDate] "
                sql &= "    ,[LastUpdateUser] "
                sql &= "    ,[LastUpdateIP],[Status],[Stylish],[Customer],[Product])"


                ''''''''''''''''''''''
                sql &= "  values ('" & SaleCode & "','" & SaleBranch & "', '" & chk_L.Checked & "'"
                sql &= "  ,'" & chk_M.Checked & "'"
                sql &= "  ,'" & chk_S.Checked & "'"
                sql &= "  , '" & cboColor.Text & "'"

                sql &= "  , '" & chkHairType_Coarse.Checked & "'"
                sql &= "  , '" & chkHairType_Medium.Checked & "'"
                sql &= "  , '" & chkHairType_Fine.Checked & "'"

                sql &= "  , '" & chkHairType_Dry.Checked & "'"
                sql &= "  , '" & chkHairType_Normal.Checked & "'"
                sql &= "  , '" & chkHairType_Oily.Checked & "'"

                sql &= "  , '" & chkHairType_ALot.Checked & "'"
                sql &= "  , '" & chkHairType_Medium2.Checked & "'"
                sql &= "  , '" & chkHairType_Thin.Checked & "'"

                sql &= "   ,  '" & chkPerm_M.Checked & "'"
                sql &= "  ,'" & chkPerm_H.Checked & "'"
                sql &= "  , '" & chkPerm_EX.Checked & "'"
                sql &= "  , '" & chkPerm_V.Checked & "'"

                If txtPerm_Time.Text = "" Then
                Else
                    sql &= "   , " & txtPerm_Time.Text
                End If


                sql &= "   , '" & chkStraight_M.Checked & "'"
                sql &= "   , '" & chkStraight_H.Checked & "'"
                sql &= "  , '" & chkStraight_EX.Checked & "'"
                sql &= "  , '" & chkStraight_V.Checked & "'"
                sql &= "  , '" & chkStraight_180.Checked & "'"
                sql &= "   , '" & chkStraight_200.Checked & "'"
                If txtStraight_Time.Text = "" Then
                Else
                    sql &= "   , " & txtStraight_Time.Text
                End If

                sql &= "   , '" & chkTreatment_SHERPA.Checked & "'"
                sql &= "   , '" & chkTreatment_PRIVA.Checked & "'"
                sql &= "   , '" & chkTreatment_caretico.Checked & "'"
                sql &= "  , '" & txtShampooBlow.Text & "'"
                sql &= "   , '" & chkMakeUp_Party.Checked & "'"
                sql &= "   , '" & chkMakeUp_Wedding.Checked & "'"
                sql &= "  , '" & chkMakeUp_Graduation.Checked & "'"
                sql &= "    ,getdate()"
                sql &= "    , '" & GlobalVar.UserID & "'"
                sql &= "    , '" & Common.GetIPAddress & "','Active', '" & txtStylish.Text & "', '" & txtCustomer.Text & "', '" & txtProduct.Text & "')"

                ''''''''''''''''''''''

                Dim command = New SqlCommand(sql, cnn, transaction)

                command.CommandText = sql
                command.ExecuteNonQuery()



                transaction.Commit()


            Catch ex As Exception

                transaction.Rollback()
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจากเกิดปัญหา" & ex.Message)

            End Try



        End Using
    End Sub

    Sub UpdatessData()
        'คำนวณตอนกดเสร็จ
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection

            Dim transaction As SqlTransaction
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            transaction = cnn.BeginTransaction()

            Try
                Dim rewardPont As Integer = 0
                Dim sql As String

                sql = "UPDATE [SaleMemo] set "

                sql &= "  [Cut_L] = '" & chk_L.Checked & "'"
                sql &= "  ,[Cut_M] = '" & chk_M.Checked & "'"
                sql &= "  ,[Cut_S] = '" & chk_S.Checked & "'"
                sql &= "  ,[Color] = '" & cboColor.Text & "'"

                sql &= "  ,[HairType_Coarse] = '" & chkHairType_Coarse.Checked & "'"
                sql &= "  ,[HairType_Medium] = '" & chkHairType_Medium.Checked & "'"
                sql &= "  ,[HairType_Fine]  = '" & chkHairType_Fine.Checked & "'"

                sql &= "  ,[HairType_Dry] =  '" & chkHairType_Dry.Checked & "'"
                sql &= "  ,[HairType_Normal] = '" & chkHairType_Normal.Checked & "'"
                sql &= "  ,[HairType_Oily] = '" & chkHairType_Oily.Checked & "'"

                sql &= "  ,[HairType_ALot] ='" & chkHairType_ALot.Checked & "'"
                sql &= "  ,[HairType_Medium2] ='" & chkHairType_Medium2.Checked & "'"
                sql &= "  ,[HairType_Thin] ='" & chkHairType_Thin.Checked & "'"

                sql &= "   ,[Perm_M] ='" & chkPerm_M.Checked & "'"
                sql &= "  ,[Perm_H] ='" & chkPerm_H.Checked & "'"
                sql &= "  ,[Perm_EX] ='" & chkPerm_EX.Checked & "'"
                sql &= "  ,[Perm_V] ='" & chkPerm_V.Checked & "'"

                If txtPerm_Time.Text <> "" Then

                    sql &= "   ,[Perm_Time] = " & txtPerm_Time.Text
                End If

                sql &= "   ,[Straight_M] = '" & chkStraight_M.Checked & "'"
                sql &= "   ,[Straight_H] = '" & chkStraight_H.Checked & "'"
                sql &= "  ,[Straight_EX] = '" & chkStraight_EX.Checked & "'"
                sql &= "  ,[Straight_V] = '" & chkStraight_V.Checked & "'"
                sql &= "  ,[Straight_180] = '" & chkStraight_180.Checked & "'"
                sql &= "   ,[Straight_200] = '" & chkStraight_200.Checked & "'"
                If txtStraight_Time.Text <> "" Then

                    sql &= "   ,[Straight_Time] = " & txtStraight_Time.Text
                End If

                sql &= "   ,[Treatment_SHERPA] = '" & chkTreatment_SHERPA.Checked & "'"
                sql &= "   ,[Treatment_PRIVA] = '" & chkTreatment_PRIVA.Checked & "'"
                sql &= "   ,[Treatment_caretico] = '" & chkTreatment_caretico.Checked & "'"
                sql &= "  ,[ShampooBlow] = '" & txtShampooBlow.Text & "'"
                sql &= "   ,[MakeUp_Party] = '" & chkMakeUp_Party.Checked & "'"
                sql &= "   ,[MakeUp_Wedding] = '" & chkMakeUp_Wedding.Checked & "'"
                sql &= "  ,[MakeUp_Graduation] = '" & chkMakeUp_Graduation.Checked & "'"
                sql &= "    ,[LastUpdateDate] = getdate()"
                sql &= "    ,[LastUpdateUser] = '" & GlobalVar.UserID & "'"
                sql &= "    ,[LastUpdateIP] = '" & Common.GetIPAddress & "'"
                sql &= ",[Status]  = 'Active'"

                sql &= " WHERE Code = '" & txtCode.Text & "' and  Stylish = '" & txtStylish.Text & "' and  Customer = '" & txtCustomer.Text & "' and  Product = '" & txtProduct.Text & "'"


                ''''''''''''''''''''''

                Dim command = New SqlCommand(sql, cnn, transaction)

                command.CommandText = sql
                command.ExecuteNonQuery()



                transaction.Commit()


            Catch ex As Exception

                transaction.Rollback()
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจากเกิดปัญหา" & ex.Message)

            End Try



        End Using
    End Sub

    Private Sub button_proceed_Click(sender As Object, e As EventArgs) Handles button_proceed.Click
        Dim hasRecord As Boolean = False
        Dim sql As String
        Dim dt As DataTable
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            sql = "select * from SaleMemo where Code='" & txtCode.Text & "' and Stylish='" & txtStylish.Text & "' and Customer='" & txtCustomer.Text & "' and Product='" & txtProduct.Text & "'"

            dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            If dt.Rows.Count > 0 Then
                hasRecord = True
            End If

        End Using


        If hasRecord = True Then
            UpdateData()
        Else
            SaveData()
        End If

        ' loadLvtSaleMemoData(False, SaleCode)

    End Sub

    Private Sub UpdateData()
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection
            Dim transaction As SqlTransaction
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            transaction = cnn.BeginTransaction()
            Try
                Dim sql As String

                sql = "UPDATE [SaleMemo]"
                sql &= "   SET "
                sql &= "  [Cut_L] = '" & chk_L.Checked & "'"
                sql &= "  ,[Cut_M] = '" & chk_M.Checked & "'"
                sql &= "  ,[Cut_S] = '" & chk_S.Checked & "'"
                sql &= "  ,[Color] = '" & cboColor.Text & "'"

                sql &= "  ,[HairType_Coarse] = '" & chkHairType_Coarse.Checked & "'"
                sql &= "  ,[HairType_Medium] = '" & chkHairType_Medium.Checked & "'"
                sql &= "  ,[HairType_Fine] = '" & chkHairType_Fine.Checked & "'"

                sql &= "  ,[HairType_Dry] = '" & chkHairType_Dry.Checked & "'"
                sql &= "  ,[HairType_Normal] = '" & chkHairType_Normal.Checked & "'"
                sql &= "  ,[HairType_Oily] = '" & chkHairType_Oily.Checked & "'"

                sql &= "  ,[HairType_ALot] = '" & chkHairType_ALot.Checked & "'"
                sql &= "  ,[HairType_Medium2] = '" & chkHairType_Medium2.Checked & "'"
                sql &= "  ,[HairType_Thin] = '" & chkHairType_Thin.Checked & "'"

                sql &= "   ,[Perm_M] =  '" & chkPerm_M.Checked & "'"
                sql &= "  ,[Perm_H] =  '" & chkPerm_H.Checked & "'"
                sql &= "  ,[Perm_EX] =  '" & chkPerm_EX.Checked & "'"
                sql &= "  ,[Perm_V] =  '" & chkPerm_V.Checked & "'"

                If txtPerm_Time.Text = "" Then
                Else
                    sql &= "   ,[Perm_Time] =  " & txtPerm_Time.Text
                End If


                sql &= "   ,[Straight_M] = '" & chkStraight_M.Checked & "'"
                sql &= "   ,[Straight_H] = '" & chkStraight_H.Checked & "'"
                sql &= "  ,[Straight_EX] ='" & chkStraight_EX.Checked & "'"
                sql &= "  ,[Straight_V] = '" & chkStraight_V.Checked & "'"
                sql &= "  ,[Straight_180] = '" & chkStraight_180.Checked & "'"
                sql &= "   ,[Straight_200] = '" & chkStraight_200.Checked & "'"
                If txtStraight_Time.Text = "" Then
                Else
                    sql &= "   ,[Straight_Time] = " & txtStraight_Time.Text
                End If

                sql &= "   ,[Treatment_SHERPA] = '" & chkTreatment_SHERPA.Checked & "'"
                sql &= "   ,[Treatment_PRIVA] = '" & chkTreatment_PRIVA.Checked & "'"
                sql &= "   ,[Treatment_caretico] = '" & chkTreatment_caretico.Checked & "'"
                sql &= "  ,[ShampooBlow] = '" & txtShampooBlow.Text & "'"
                sql &= "   ,[MakeUp_Party] = '" & chkMakeUp_Party.Checked & "'"
                sql &= "   ,[MakeUp_Wedding] = '" & chkMakeUp_Wedding.Checked & "'"
                sql &= "  ,[MakeUp_Graduation] = '" & chkMakeUp_Graduation.Checked & "'"
                sql &= "    ,[LastUpdateDate]=getdate()"
                sql &= "    ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                sql &= "    ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                sql &= " WHERE Code = '" & txtCode.Text & "' and  Stylish = '" & txtStylish.Text & "' and  Customer = '" & txtCustomer.Text & "' and  Product = '" & txtProduct.Text & "'"
                Dim command = New SqlCommand(sql, cnn, transaction)
                command.CommandText = sql
                command.ExecuteNonQuery()

                ' Attempt to commit the transaction.
                transaction.Commit()
                ' MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                loadLvtData(False, txtSearch.Text)
                ' EditableControl(False)
                ' ControlButtonStatus(True)
                ' ConfirmButtonStatus(False)

                'lvtItem.Items(lastSelectedIndex).Selected = True
                'lvtItem.Select()

                'assignDataToControl()

                PnlDetail.Enabled = False
                button_proceed.Visible = False
                button_cancel.Visible = False
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจากเกิดปัญหา" & ex.Message)
            End Try
        End Using
    End Sub


    Dim lastSelectedIndex As Integer
    Private Sub assignDataToControl()


        'txtStaff.Tag = lvtItem.SelectedItems(0).Tag

        'txtStaff.Text = lvtItem.SelectedItems(0).SubItems(0).Text
        'lastSelectedIndex = lvtItem.SelectedItems(0).Index
        'txtSaleDateTime.Text = lvtItem.SelectedItems(0).SubItems(3).Text
        'txtCusName.Text = lvtItem.SelectedItems(0).SubItems(1).Text
        'lastSelectedIndex = lvtItem.SelectedItems(0).Index
        'txtSaleDateTime.Text = lvtItem.SelectedItems(0).SubItems(3).Text
        'txtCusName.Text = lvtItem.SelectedItems(0).SubItems(1).Text & "(" & lvtItem.SelectedItems(0).SubItems(2).Text & ")"

        'txtAmount.Text = lvtItem.SelectedItems(0).SubItems(4).Text


        txtStaff.Text = lvtItem.SelectedItems(0).SubItems(2).Text
        'lastSelectedIndex = lvtItem.SelectedItems(0).Index
        'txtSaleDateTime.Text = lvtItem.SelectedItems(0).SubItems(3).Text
        'txtCusName.Text = lvtItem.SelectedItems(0).SubItems(1).Text
        lastSelectedIndex = lvtItem.SelectedItems(0).Index
        txtSaleDateTime.Text = lvtItem.SelectedItems(0).SubItems(5).Text
        txtCusName.Text = lvtItem.SelectedItems(0).SubItems(3).Text & "(" & lvtItem.SelectedItems(0).SubItems(4).Text & ")"

        txtAmount.Text = lvtItem.SelectedItems(0).SubItems(6).Text

        SaleBranch = lvtItem.SelectedItems(0).SubItems(8).Text
        SaleCode = lvtItem.SelectedItems(0).Tag

        txtProduct.Text = lvtItem.SelectedItems(0).SubItems(11).Text
        txtStylish.Text = lvtItem.SelectedItems(0).SubItems(9).Text
        txtCustomer.Text = lvtItem.SelectedItems(0).SubItems(10).Text
        txtCode.Text = lvtItem.SelectedItems(0).Tag


        Dim sql As String
        sql = "select * from saleMemo  WHERE Code = '" & txtCode.Text & "' and  Stylish = '" & txtStylish.Text & "' and  Customer = '" & txtCustomer.Text & "' and  Product = '" & txtProduct.Text & "'"
        'Uc_UpdatedDetail1.sqlstring = sql
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        If dt.Rows.Count < 1 Then
            Exit Sub
        End If

        chk_L.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Cut_L"))
        chk_M.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Cut_M"))
        chk_S.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Cut_S"))



        chkHairType_Coarse.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Coarse"))
        chkHairType_Medium.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Medium"))
        chkHairType_Fine.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Fine"))

        chkHairType_Dry.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Dry"))
        chkHairType_Normal.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Normal"))
        chkHairType_Oily.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Oily"))

        chkHairType_ALot.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_ALot"))
        chkHairType_Medium2.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Medium2"))
        chkHairType_Thin.Checked = Common.IsNullToFalse(dt.Rows(0).Item("HairType_Thin"))


        cboColor.Text = Common.IsNullToString(dt.Rows(0).Item("Color"))
        ' txtColor_Other.Text = Common.IsNullToString(dt.Rows(0).Item("Color_Other"))

        chkPerm_M.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Perm_M"))
        chkPerm_H.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Perm_H"))
        chkPerm_EX.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Perm_EX"))
        chkPerm_V.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Perm_V"))
        txtPerm_Time.Text = Common.IsNullToString(dt.Rows(0).Item("Perm_Time"))

        chkStraight_M.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Straight_M"))
        chkStraight_H.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Straight_H"))
        chkStraight_EX.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Straight_EX"))
        chkStraight_V.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Straight_V"))
        chkStraight_180.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Straight_180"))
        chkStraight_200.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Straight_200"))
        txtStraight_Time.Text = Common.IsNullToString(dt.Rows(0).Item("Straight_Time"))

        chkTreatment_SHERPA.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Treatment_SHERPA"))
        chkTreatment_PRIVA.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Treatment_PRIVA"))
        chkTreatment_caretico.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Treatment_caretico"))
        txtShampooBlow.Text = Common.IsNullToString(dt.Rows(0).Item("ShampooBlow"))

        chkMakeUp_Party.Checked = Common.IsNullToFalse(dt.Rows(0).Item("MakeUp_Party"))
        chkMakeUp_Wedding.Checked = Common.IsNullToFalse(dt.Rows(0).Item("MakeUp_Wedding"))
        chkMakeUp_Graduation.Checked = Common.IsNullToFalse(dt.Rows(0).Item("MakeUp_Graduation"))
        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub
    Private Sub clearForm()
        chk_L.Checked = False
        chk_M.Checked = False
        chk_S.Checked = False



        chkHairType_Coarse.Checked = False
        chkHairType_Medium.Checked = False
        chkHairType_Fine.Checked = False

        chkHairType_Dry.Checked = False
        chkHairType_Normal.Checked = False
        chkHairType_Oily.Checked = False

        chkHairType_ALot.Checked = False
        chkHairType_Medium2.Checked = False
        chkHairType_Thin.Checked = False


        cboColor.Text = ""
        ' txtColor_Other.Text = Common.IsNullToString(dt.Rows(0).Item("Color_Other"))

        chkPerm_M.Checked = False
        chkPerm_H.Checked = False
        chkPerm_EX.Checked = False
        chkPerm_V.Checked = False
        txtPerm_Time.Text = ""

        chkStraight_M.Checked = False
        chkStraight_H.Checked = False
        chkStraight_EX.Checked = False
        chkStraight_V.Checked = False
        chkStraight_180.Checked = False
        chkStraight_200.Checked = False
        txtStraight_Time.Text = ""

        chkTreatment_SHERPA.Checked = False
        chkTreatment_PRIVA.Checked = False
        chkTreatment_caretico.Checked = False
        txtShampooBlow.Text = ""

        chkMakeUp_Party.Checked = False
        chkMakeUp_Wedding.Checked = False
        chkMakeUp_Graduation.Checked = False
    End Sub
    Private Sub assignHeaderData()

        txtStaff.Text = lvtItem.SelectedItems(0).SubItems(2).Text
        'lastSelectedIndex = lvtItem.SelectedItems(0).Index
        'txtSaleDateTime.Text = lvtItem.SelectedItems(0).SubItems(3).Text
        'txtCusName.Text = lvtItem.SelectedItems(0).SubItems(1).Text
        lastSelectedIndex = lvtItem.SelectedItems(0).Index
        txtSaleDateTime.Text = lvtItem.SelectedItems(0).SubItems(5).Text
        txtCusName.Text = lvtItem.SelectedItems(0).SubItems(3).Text & "(" & lvtItem.SelectedItems(0).SubItems(4).Text & ")"

        txtAmount.Text = lvtItem.SelectedItems(0).SubItems(6).Text

        SaleBranch = lvtItem.SelectedItems(0).SubItems(5).Text
        SaleCode = lvtItem.SelectedItems(0).Tag

        txtProduct.Text = lvtItem.SelectedItems(0).SubItems(11).Text
        txtStylish.Text = lvtItem.SelectedItems(0).SubItems(9).Text
        txtCustomer.Text = lvtItem.SelectedItems(0).SubItems(10).Text
        txtCode.Text = lvtItem.SelectedItems(0).Tag

    End Sub


    Private Sub lvtItem_Click(sender As Object, e As EventArgs) Handles lvtItem.Click
        'If PnlDetail.Enabled = False Then
        ' assignDataToControl()
        clearForm()
        assignHeaderData()
        'End If

        ' load sale memo
        ' loadLvtSaleMemoData(False, SaleCode)

        PnlDetail.Enabled = False
        button_proceed.Visible = False
        button_cancel.Visible = False
        assignDataToControl()

    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        loadLvtData(False, txtSearch.Text)
    End Sub

    Private Sub NullableDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles NullableDateTimePicker1.ValueChanged

    End Sub

    Private Sub chkDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate.CheckedChanged
        If chkDate.Checked = True Then
            NullableDateTimePicker1.Value = Date.Now
        Else
            NullableDateTimePicker1.Value = Nothing
        End If
    End Sub

    Private Sub listview_saleMemo_Click(sender As Object, e As EventArgs) Handles listview_saleMemo.Click

    End Sub

    Private Sub listview_saleMemo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_saleMemo.SelectedIndexChanged
        'If PnlDetail.Enabled = False Then
        
        'End If
    End Sub

    Private Sub listview_saleMemo_MouseClick(sender As Object, e As MouseEventArgs) Handles listview_saleMemo.MouseClick
        txtCode.Text = listview_saleMemo.SelectedItems(0).SubItems(0).Text
        txtProduct.Text = listview_saleMemo.SelectedItems(0).SubItems(2).Text
        txtCustomer.Text = listview_saleMemo.SelectedItems(0).SubItems(7).Text
        txtStylish.Text = listview_saleMemo.SelectedItems(0).SubItems(6).Text
        assignDataToControl()
    End Sub

    Private Sub txtAmount_Click(sender As Object, e As EventArgs) Handles txtAmount.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn2 As SqlConnection = ConnectionManagement.GetConnection
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            If cnn2.State = ConnectionState.Closed Then
                cnn2.Open()
            End If

            Dim sql As String
            sql = "select Code,Stylist, Customer, Branch,CustomerVisitType from sale where sale.Stylist <> '' and sale.Customer <> '' and sale.CustomerVisitType <> ''"

            Dim selectCommand = New SqlCommand(sql, cnn)
            selectCommand.CommandText = sql
            Dim dr As SqlDataReader = selectCommand.ExecuteReader()
            While (dr.Read())
                Try
                    sql = "UPDATE [SaleDetail] SET   Stylish = '" & dr.GetString(1) & "', Customer = '" & dr.GetString(2) & "',branch ='" & dr.GetString(3) & "', customerType='" & dr.GetString(4) & "' where Sale = '" & dr.GetString(0) & "'"

                    'sql &= "    ,[LastUpdateDate]=getdate()"
                    'sql &= "    ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    'sql &= "    ,[LastUpdateIP]='" & Common.GetIPAddress & "'"

                    Dim command = New SqlCommand(sql, cnn2)
                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                Catch ex As Exception

                    Debug.Print(ex.Message)
                End Try

            End While
            dr.Close()

        End Using

        MessageBox.Show("OK")

    End Sub
End Class