Imports System.Data.SqlClient
Imports System.Threading
Imports System.Globalization

Public Class customer_main_form
    Dim is_member As Boolean = True
    Public mode As Action

    Dim lastSelectedIndex As Integer
    Enum Action
        Add
        Edit
        View
        Upgrade
        Cancel
    End Enum
    Enum Section
        Customer
        Member
    End Enum
    Enum ControlState
        Lock
        Unlock
    End Enum
    Private Sub change_component_state(section As Section, state As ControlState)
        Select Case section
            Case section.Customer
                If (state = ControlState.Lock) Then
                    cboTitle.Enabled = False
                    txtName.ReadOnly = True
                    txtNickName.ReadOnly = True
                Else
                    cboTitle.Enabled = True
                    txtName.ReadOnly = False
                    txtNickName.ReadOnly = False
                End If
            Case section.Member
                If (state = ControlState.Lock) Then
                    txt_tax_id.ReadOnly = True
                    txtAddress.ReadOnly = True
                    txtSubDistinct.ReadOnly = True
                    txtDistinct.ReadOnly = True
                    cboProvince.Enabled = False
                    cboCountry.Enabled = False
                    txtZipCode.ReadOnly = True
                    txtPhone.ReadOnly = True
                    txtEmail.ReadOnly = True
                    cboDay.Enabled = False
                    cboMonth.Enabled = False
                    pnlWay.Enabled = False
                    ' textbox_occupation.ReadOnly = True
                Else
                    txt_tax_id.ReadOnly = False
                    txtAddress.ReadOnly = False
                    txtSubDistinct.ReadOnly = False
                    txtDistinct.ReadOnly = False
                    cboProvince.Enabled = True
                    cboCountry.Enabled = True
                    txtZipCode.ReadOnly = False
                    txtPhone.ReadOnly = False
                    txtEmail.ReadOnly = False
                    cboDay.Enabled = True
                    cboMonth.Enabled = True
                    pnlWay.Enabled = True
                    ' textbox_occupation.ReadOnly = False
                End If
        End Select
    End Sub
    Private Sub reset_clear_control(section As Section)
        Select Case section
            Case section.Customer
                cboTitle.SelectedIndex = 0
                txtName.Clear()
                txtNickName.Clear()
            Case section.Member
                txtAddress.Clear()
                txtSubDistinct.Clear()
                txtDistinct.Clear()
                txtZipCode.Clear()
                txtPhone.Clear()
                txtEmail.Clear()
                txtOther.Clear()
                txt_tax_id.Clear()
                ' textbox_occupation.Clear()
                cboDay.SelectedIndex = 0
                cboMonth.SelectedIndex = 0
                cboProvince.SelectedIndex = 0
                cboTitle.SelectedIndex = 0
                cboCountry.SelectedIndex = 0

                chkFamily.Checked = False
                chkFriend.Checked = False
                chkWebsite.Checked = False
                chkOtherWebsite.Checked = False
                chkFacebook.Checked = False
                chkInstagram.Checked = False
                chkMagazine.Checked = False
                chkWalkin.Checked = False
        End Select
    End Sub

    Private Sub button_home_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub button_edit_Click(sender As Object, e As EventArgs) Handles button_edit.Click
        mode = Action.Edit

        lvtItem.Enabled = False

        button_edit.Enabled = False
        ' button_upgrade.Enabled = False

        change_component_state(Section.Customer, ControlState.Unlock)
        change_component_state(Section.Member, ControlState.Unlock)
        panel_customer.Enabled = True
        pnlWay.Enabled = True
        'If (is_member) Then
        '    panel_member.Enabled = True
        '    change_component_state(Section.Member, ControlState.Unlock)
        'End If

        button_proceed.Text = "Save Change"
        button_cancel.Text = "Cancel"

        button_proceed.Visible = True
        button_cancel.Visible = True
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click

        lvtItem.Enabled = True

        change_component_state(Section.Customer, ControlState.Lock)
        change_component_state(Section.Member, ControlState.Lock)

        Select Case mode
            Case Action.Add
                panel_customer.Enabled = False
            Case Action.Edit
                button_edit.Enabled = True
                ' button_upgrade.Enabled = True
            Case Action.Upgrade
                panel_customer.Enabled = False
                button_edit.Enabled = True
                ' button_upgrade.Enabled = True
        End Select

        button_proceed.Visible = False
        button_cancel.Visible = False
    End Sub

    Private Sub button_new_customer_Click(sender As Object, e As EventArgs) Handles button_new_customer.Click
        mode = Action.Add

        txtCode.Text = "AUTO"

        lvtItem.Enabled = False

        reset_clear_control(Section.Customer)
        reset_clear_control(Section.Member)

        cboProvince.SelectedValue = "02"

        button_edit.Visible = False
        ' button_upgrade.Visible = False

        change_component_state(Section.Customer, ControlState.Unlock)
        change_component_state(Section.Member, ControlState.Unlock)
        panel_customer.Enabled = True
        pnlWay.Enabled = True
        button_proceed.Text = "Add Customer"
        button_cancel.Text = "Cancel"

        button_proceed.Visible = True
        button_cancel.Visible = True
    End Sub

    Private Sub button_upgrade_Click(sender As Object, e As EventArgs)
        mode = Action.Upgrade

        lvtItem.Enabled = False

        reset_clear_control(Section.Member)

        change_component_state(Section.Customer, ControlState.Lock)
        change_component_state(Section.Member, ControlState.Unlock)
        ' button_upgrade.Enabled = False
        button_edit.Enabled = False

        button_proceed.Text = "Upgrade Member"
        button_cancel.Text = "Cancel"

        button_proceed.Visible = True
        button_cancel.Visible = True
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles lvtItem.Click
        mode = Action.View

        Dim rand As New Random
        is_member = Convert.ToBoolean(rand.Next(0, 2))

        button_edit.Visible = True
        change_component_state(Section.Customer, ControlState.Lock)
        change_component_state(Section.Member, ControlState.Lock)

        'If (is_member) Then
        '    button_upgrade.Visible = False
        '    panel_member.Enabled = True
        'Else
        '    button_upgrade.Visible = True
        '    panel_member.Enabled = False
        'End If
        assignDataToControl()
    End Sub
    Sub assignDataToControl()
        txtCode.Text = lvtItem.SelectedItems(0).SubItems(0).Text
        lastSelectedIndex = lvtItem.SelectedItems(0).Index
        Dim sql As String
        sql = "select * from customer where ID='" & txtCode.Text & "' "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        txtCode.Text = dt.Rows(0).Item("ID")
        cboTitle.SelectedValue = Common.IsNullToString(dt.Rows(0).Item("Title"))
        'txtBranch.Text = dt.Rows(0).Item("Branch")
        txtName.Text = Common.IsNullToString(dt.Rows(0).Item("Name"))
        txt_tax_id.Text = Common.IsNullToString(dt.Rows(0).Item("TAXID"))
        txtNickName.Text = Common.IsNullToString(dt.Rows(0).Item("NickName"))
        txtAddress.Text = Common.IsNullToString(dt.Rows(0).Item("Address"))
        txtSubDistinct.Text = Common.IsNullToString(dt.Rows(0).Item("SubDistrict"))
        txtDistinct.Text = Common.IsNullToString(dt.Rows(0).Item("District"))
        If dt.Rows(0).Item("Province") Is DBNull.Value Then
            cboProvince.SelectedIndex = 0
        Else
            cboProvince.SelectedValue = dt.Rows(0).Item("Province")
        End If

        If dt.Rows(0).Item("Country") Is DBNull.Value Or dt.Rows(0).Item("Country").ToString().Equals("") Then
            cboCountry.SelectedIndex = 0
        Else


            cboCountry.SelectedIndex = dt.Rows(0).Item("Country")
        End If

        txtZipCode.Text = Common.IsNullToString(dt.Rows(0).Item("ZipCode"))
        txtEmail.Text = Common.IsNullToString(dt.Rows(0).Item("Email"))
        txtPhone.Text = Common.IsNullToString(dt.Rows(0).Item("Phone"))

        If dt.Rows(0).Item("BirthDay") Is DBNull.Value Then
            cboDay.SelectedIndex = 0
        Else
            cboDay.SelectedIndex = dt.Rows(0).Item("BirthDay")
        End If

        If dt.Rows(0).Item("BirthMonth") Is DBNull.Value Then
            cboMonth.SelectedIndex = 0
        Else
            cboMonth.SelectedIndex = dt.Rows(0).Item("BirthMonth")
        End If



        chkFamily.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Family"))
        chkFriend.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Friend"))
        chkWebsite.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Website"))
        chkOtherWebsite.Checked = Common.IsNullToFalse(dt.Rows(0).Item("OtherWebsite"))
        chkFacebook.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Facebook"))
        chkInstagram.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Instagram"))
        chkMagazine.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Magazine"))
        chkWalkin.Checked = Common.IsNullToFalse(dt.Rows(0).Item("Walkin"))
        txtOther.Text = Common.IsNullToString(dt.Rows(0).Item("OtherReason"))

        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub

    Function getCode() As String
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

        Dim sql As String = "select top 1 * from Customer  order by id desc"
        Dim nvdt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        Dim newCode As String
        If nvdt.Rows.Count = 0 Then
            newCode = "C"
            newCode &= "0001"
        Else
            Dim Prefix As String = nvdt.Rows(0).Item("id").ToString.Substring(0, 1)
            Dim runningno As String = nvdt.Rows(0).Item("id").ToString.Substring(1)
            runningno = (CInt(runningno) + 1).ToString.PadLeft(4, "0")
            newCode = Prefix & runningno
        End If


        Return newCode


    End Function
    Private Sub button_proceed_Click(sender As Object, e As EventArgs) Handles button_proceed.Click

        If txtName.Text = "" Then
            MessageBox.Show("Please enter your name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'lblError.Text = "กรุณากรอกชื่อ"
            txtName.Focus()
            Exit Sub
        End If

        If txtCode.Text = "AUTO" Then
        
            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = getCode()
                    'Common.GetLatestCode("Customer", "ID")
                    Dim sql As String

                    sql = "INSERT INTO [Customer]"
                    sql &= "    ([ID]"
                    sql &= "    ,[Branch]"
                    sql &= "    ,[Title]"
                    sql &= "    ,[Name]"
                    sql &= "    ,[NickName]"
                    sql &= "    ,[Address]"
                    sql &= "    ,[SubDistrict]"
                    sql &= "    ,[District]"
                    sql &= "    ,[Province]"
                    sql &= "    ,[Country]"
                    sql &= "   ,[ZipCode]"
                    sql &= "   ,[Email]"
                    sql &= "    ,[Phone]"
                    sql &= "     ,[BirthDay]"
                    sql &= "     ,[BirthMonth]"
                    'sql &= "     ,[Customertype]"
                    'sql &= "    ,[Stylist]"
                    sql &= "    ,[Family]"
                    sql &= "     ,[Friend]"
                    sql &= "     ,[website]"
                    sql &= "     ,[OtherWebsite]"
                    sql &= "     ,[Facebook]"
                    sql &= "     ,[Instagram]"
                    sql &= "      ,[Magazine]"
                    sql &= "     ,[WalkIn]"
                    sql &= "     ,[OtherReason]"
                    sql &= "     ,[TAXID]"
                    sql &= "    ,[Status]"
                    sql &= "    ,[InsertDate]"
                    sql &= "    ,[InsertUser]"
                    sql &= "   ,[InsertIP]"
                    sql &= "   ,[LastUpdateDate]"
                    sql &= "  ,[LastUpdateUser]"
                    sql &= "   ,[LastUpdateIP])"
                    sql &= "     VALUES"
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(txtCode.Text) Or txtCode.Text.ToLower.Equals("auto"), lastestCode, txtCode.Text) & "'"
                    sql &= "    ,'" & GlobalVar.Branch & "'"
                    sql &= "    ,'" & cboTitle.SelectedValue & "'"
                    sql &= "    ,'" & txtName.Text & "'"
                    sql &= "    ,'" & txtNickName.Text & "'"
                    sql &= "    ,'" & txtAddress.Text & "'"
                    sql &= "    ,'" & txtSubDistinct.Text & "'"
                    sql &= "    ,'" & txtDistinct.Text & "'"
                    sql &= "    ,'" & cboProvince.SelectedValue & "'"
                    sql &= "    ,'" & cboCountry.SelectedValue & "'"
                    sql &= "    ,'" & txtZipCode.Text & "'"
                    sql &= "    ,'" & txtEmail.Text & "'"
                    sql &= "    ,'" & txtPhone.Text & "'"
                    sql &= "     ,@BirthDay"
                    sql &= "     ,@BirthMonth"

                    sql &= "    ,'" & chkFamily.Checked & "'"
                    sql &= "    ,'" & chkFriend.Checked & "'"
                    sql &= "    ,'" & chkWebsite.Checked & "'"
                    sql &= "    ,'" & chkOtherWebsite.Checked & "'"
                    sql &= "    ,'" & chkFacebook.Checked & "'"
                    sql &= "    ,'" & chkInstagram.Checked & "'"
                    sql &= "    ,'" & chkMagazine.Checked & "'"
                    sql &= "    ,'" & chkWalkin.Checked & "'"
                    sql &= "    ,'" & txtOther.Text & "'"
                    sql &= "    ,'" & txt_tax_id.Text & "'"
                    sql &= "    ,'Active'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"
                    sql &= "    ,getdate()"
                    sql &= "   ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "')"

                    Dim command = New SqlCommand(sql, cnn, transaction)
                    If cboDay.SelectedIndex = 0 Then
                        command.Parameters.AddWithValue("@BirthDay", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@BirthDay", cboDay.SelectedIndex)
                    End If

                    If cboMonth.SelectedIndex = 0 Then
                        command.Parameters.AddWithValue("@BirthMonth", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@BirthMonth", cboMonth.SelectedIndex)
                    End If

                    command.CommandText = sql
                    command.ExecuteNonQuery()



                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    loadLvtData(False, txtSearch.Text)
                    'EditableControl(False)
                    'ControlButtonStatus(True)
                    'ConfirmButtonStatus(False)

                    Dim lr As ListViewItem = lvtItem.FindItemWithText( _
                        IIf(String.IsNullOrEmpty(txtCode.Text) Or txtCode.Text.ToLower.Equals("auto"), lastestCode, txtCode.Text))
                    lr.Selected = True

                    'lvtItem.Items(lvtItem.Items.Count - 1).Selected = True
                    'lvtItem.Select()
                    assignDataToControl()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error" & ex.Message)
                End Try
            End Using
        Else
            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()
                Try
                    Dim sql As String
                    sql = "Update  [Customer] set "
                    sql &= "    [Branch]='" & txtCode.Text & "'"
                    sql &= "    ,[Title]='" & cboTitle.SelectedValue & "'"
                    sql &= "    ,[Name]='" & txtName.Text & "'"
                    sql &= "    ,[nickname]='" & txtNickName.Text & "'"
                    sql &= "    ,[Address]='" & txtAddress.Text & "'"
                    sql &= "    ,[SubDistrict]='" & txtSubDistinct.Text & "'"
                    sql &= "    ,[District]='" & txtDistinct.Text & "'"
                    sql &= "    ,[Province]='" & cboProvince.SelectedValue & "'"
                    sql &= "    ,[Country]='" & cboCountry.SelectedValue & "'"
                    sql &= "   ,[ZipCode]='" & txtZipCode.Text & "'"
                    sql &= "   ,[Email]='" & txtEmail.Text & "'"
                    sql &= "    ,[Phone]='" & txtPhone.Text & "'"
                    sql &= "     ,[BirthDay]=@BirthDay"
                    sql &= "     ,[BirthMonth]=@BirthMonth"
                    sql &= "    ,[Family]='" & chkFamily.Checked & "'"
                    sql &= "     ,[Friend]='" & chkFriend.Checked & "'"
                    sql &= "     ,[website]='" & chkWebsite.Checked & "'"
                    sql &= "     ,[OtherWebsite]='" & chkOtherWebsite.Checked & "'"
                    sql &= "     ,[Facebook]='" & chkFacebook.Checked & "'"
                    sql &= "     ,[Instagram]='" & chkInstagram.Checked & "'"
                    sql &= "      ,[Magazine]='" & chkMagazine.Checked & "'"
                    sql &= "     ,[WalkIn]='" & chkWalkin.Checked & "'"
                    sql &= "     ,[OtherReason]='" & txtOther.Text & "'"
                    sql &= "     ,[TAXID]='" & txt_tax_id.Text & "'"
                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where ID='" & txtCode.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)


                    If cboDay.SelectedIndex = 0 Then
                        command.Parameters.AddWithValue("@BirthDay", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@BirthDay", cboDay.SelectedIndex)
                    End If

                    If cboMonth.SelectedIndex = 0 Then
                        command.Parameters.AddWithValue("@BirthMonth", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@BirthMonth", cboMonth.SelectedIndex)
                    End If

                    command.CommandText = sql
                    command.ExecuteNonQuery()




                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtData(False, txtSearch.Text)
           
                    'lvtItem.Items(lastSelectedIndex).Selected = True
                    'lvtItem.Select()
                    '  assignDataToControl()
                 
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If

        'lvtItem.Enabled = True
        lvtItem.Enabled = True

        change_component_state(Section.Customer, ControlState.Lock)
        change_component_state(Section.Member, ControlState.Lock)
        Select Case mode
            Case Action.Add
                panel_customer.Enabled = False
                pnlWay.Enabled = False
            Case Action.Edit
                button_edit.Enabled = True
                '  pnlWay.Enabled = True
                ' button_upgrade.Enabled = True
            Case Action.Upgrade
                panel_customer.Enabled = False
                pnlWay.Enabled = False
                'button_upgrade.Enabled = True
        End Select

        button_proceed.Visible = False
        button_cancel.Visible = False
    End Sub

    Private Sub button_show_all_Click(sender As Object, e As EventArgs) Handles button_show_all.Click
        loadLvtData(True, txtSearch.Text)
        button_proceed.Visible = False
        button_cancel.Visible = False

        change_component_state(Section.Customer, ControlState.Lock)
        change_component_state(Section.Member, ControlState.Lock)

        reset_clear_control(Section.Customer)
        reset_clear_control(Section.Member)
    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        loadLvtData(False, txtSearch.Text)
        change_component_state(Section.Customer, ControlState.Lock)
        change_component_state(Section.Member, ControlState.Lock)

        reset_clear_control(Section.Customer)
        reset_clear_control(Section.Member)
    End Sub

    Private Sub button_home_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub customer_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLvtData(True, txtSearch.Text)
        LoadProvinceCombobox()
        LoadTitleCombobox()
        LoadCountryCombobox()

    End Sub

    Sub LoadTitleCombobox()
        Dim dt As DataTable = Common.GetTitlePrefixDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)

        cboTitle.DataSource = dt
        cboTitle.DisplayMember = "Title"
        cboTitle.ValueMember = "Code"
        cboTitle.SelectedIndex = 0
    End Sub

    Sub LoadCountryCombobox()
        Dim dt As DataTable = Common.GetCountryDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)

        cboCountry.DataSource = dt
        cboCountry.DisplayMember = "NAME"
        cboCountry.ValueMember = "CODE"
        cboCountry.SelectedIndex = 0
    End Sub

    Sub LoadProvinceCombobox()
        Dim dt As DataTable = Common.GetProvinceDatatable

        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)
        cboProvince.DataSource = dt
        cboProvince.DisplayMember = "EnglishTitle"
        cboProvince.ValueMember = "Code"

    End Sub
    Private Sub loadLvtData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "select TitlePrefix.Title as Nameprefix,customer.*,convert(varchar(25), customer.InsertDate, 103)  as CustomerInsertDate from Customer LEFT OUTER JOIN    TitlePrefix ON Customer.Title = TitlePrefix.Code where Customer.status='Active' "
        If allstatus = False Then
            sql &= " and  ( Customer.ID like '%" & criteria & "%' or Customer.title like '%" & criteria & "%' or Customer.Name like '%" & criteria & "%'  or Customer.nickname like '%" & criteria & "%' or Customer.email like '%" & criteria & "%' or Customer.phone like '%" & criteria & "%'  or convert(varchar(25), customer.InsertDate, 103) like '%" & txtSearch.Text & "%') "
        Else
            txtSearch.Text = ""
        End If

        sql &= " order by ID "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        lvtItem.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(5) As String
            item(0) = dt.Rows(i).Item("ID")

            Dim fullname As String


            If dt.Rows(i).Item("Title") = "" Then
                fullname = dt.Rows(i).Item("Name")
            Else
                fullname = dt.Rows(i).Item("Nameprefix") & " " & dt.Rows(i).Item("Name")
            End If

            item(1) = fullname
            item(2) = Common.IsNullToString(dt.Rows(i).Item("NickName"))
            item(3) = Common.IsNullToString(dt.Rows(i).Item("Phone"))
            item(4) = Common.IsNullToString(dt.Rows(i).Item("Email"))

            item(5) = Common.IsNullToString(dt.Rows(i).Item("CustomerInsertDate"))
            Dim lr As New ListViewItem(item)
            lvtItem.Items.Add(lr)
        Next
    End Sub


 

    Private Sub lvtItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvtItem.SelectedIndexChanged

    End Sub
End Class