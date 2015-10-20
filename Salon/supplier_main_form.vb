Imports System.Data.SqlClient

Public Class supplier_main_form
    Public supplierMode As Action
    Enum Action
        Add
        Edit
        View
        Cancel
    End Enum
    Enum Section
        Supplier
    End Enum

    Enum ControlState
        Lock
        Unlock
    End Enum

    Private Sub reset_clear_control(section As Section)


        textbox_supplier_code.Clear()
        textbox_supplier_name.Clear()
        textbox_supplier_taxid.Clear()
        textbox_supplier_regno.Clear()
        textbox_supplier_address.Clear()
        textbox_supplier_subdistrict.Clear()
        textbox_supplier_district.Clear()
        textbox_supplier_postcode.Clear()
        textbox_supplier_email.Clear()
        textbox_supplier_tel1.Clear()
        textbox_supplier_tel2.Clear()

        combobox_supplier_province.SelectedIndex = 0

    End Sub
    Private Sub supplier_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControl1.Appearance = TabAppearance.FlatButtons
        Me.TabControl1.ItemSize = New Size(0, 1)
        Me.TabControl1.SizeMode = TabSizeMode.Fixed


        ' set up gridw

        LoadProvinceCombobox()
        loadLvtSupplierData(False, textbox_supplier_keyword.Text)

    End Sub


    Private Sub matchingCombobox(cbo As ComboBox, v As String)

        For i As Integer = 0 To cbo.Items.Count - 1
            cbo.SelectedIndex = i

            If cbo.SelectedValue.Equals(v) Then

                Exit For
                'cbo.SelectedIndex = i
            End If
        Next

    End Sub

    Sub LoadProvinceCombobox()
        Dim dt As DataTable = Common.GetProvinceDatatable

        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)
        combobox_supplier_province.DataSource = dt
        combobox_supplier_province.DisplayMember = "EnglishTitle"
        combobox_supplier_province.ValueMember = "Code"

    End Sub

    Private Sub supplier_main_form_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(221, Byte), Integer)), 1)
        e.Graphics.DrawLine(pen, 0, 74, Me.Width, 74) '(margin_left, top_from_left, wide, top_from_right)
    End Sub

    Private Sub button_supplyer_search_Click(sender As Object, e As EventArgs) Handles button_supplyer_search.Click
        loadLvtSupplierData(True, textbox_supplier_keyword.Text)
        change_component_state(Section.Supplier, ControlState.Lock)
        reset_clear_control(Section.Supplier)
    End Sub

    Private Sub button_supplier_show_all_Click(sender As Object, e As EventArgs) Handles button_supplier_show_all.Click
        loadLvtSupplierData(False, textbox_supplier_keyword.Text)
        change_component_state(Section.Supplier, ControlState.Lock)
        reset_clear_control(Section.Supplier)
    End Sub

    Private Sub button_supplier_new_Click(sender As Object, e As EventArgs) Handles button_supplier_new.Click
        reset_clear_control(Section.Supplier)

        supplierMode = Action.Add

        textbox_supplier_code.Text = "AUTO"
        textbox_supplier_name.ReadOnly = False


        supplierMode = Action.Edit
        listview_supplier.Enabled = False
        button_supplier_edit.Enabled = False
        change_component_state(Section.Supplier, ControlState.Unlock)
        button_supplier_proceed.Text = "Save Change"
        button_supplier_cancel.Text = "Cancel"
        button_supplier_cancel.Enabled = False
        button_supplier_proceed.Enabled = True

        button_supplier_proceed.Visible = True
        button_supplier_cancel.Visible = True
    End Sub

    Private Sub button_supplier_edit_Click(sender As Object, e As EventArgs) Handles button_supplier_edit.Click
        supplierMode = Action.Edit
        listview_supplier.Enabled = False
        button_supplier_edit.Enabled = False
        button_supplier_cancel.Enabled = False
        change_component_state(Section.Supplier, ControlState.Unlock)
        button_supplier_proceed.Text = "Save Change"
        button_supplier_cancel.Text = "Cancel"
        button_supplier_proceed.Visible = True
        button_supplier_cancel.Visible = True
        assignHeaderData()
    End Sub


    Sub deleteDataFrom(table As String, onField As String, val As String)

        Using connection As SqlConnection = ConnectionManagement.GetConnection

            Dim cnn As SqlConnection = ConnectionManagement.GetConnection
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Dim Sql As String

            ' delete sale detail
            Sql = "UPDATE " & table & " SET [Status]='Inactive' WHERE " & onField & " =  '" & val & "'"

            Dim commandDeleteitem = New SqlCommand(Sql, cnn)
            commandDeleteitem.CommandText = Sql

            Try
                commandDeleteitem.ExecuteNonQuery()
                MessageBox.Show("Delete success")
            Catch ex As Exception
                MessageBox.Show("Can not delete")
            End Try

        End Using

    End Sub

    Private Sub button_supplier_delete_Click(sender As Object, e As EventArgs) Handles button_supplier_delete.Click

        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("Supplier", "Code", textbox_supplier_code.Text)
            loadLvtSupplierData(False, textbox_supplier_keyword.Text)
            reset_clear_control(Section.Supplier)

            Select Case supplierMode
                Case Action.Add
                    button_supplier_edit.Enabled = False
                    button_supplier_delete.Enabled = False

                Case Action.Edit
                    button_supplier_edit.Enabled = True
                    button_supplier_delete.Enabled = True

            End Select
            listview_supplier.Enabled = True
            button_supplier_proceed.Visible = False
            button_supplier_cancel.Visible = False
        End If
    End Sub

    Private Sub listview_supplier_Click(sender As Object, e As EventArgs) Handles listview_supplier.Click
        assignHeaderData()
        button_supplier_edit.Enabled = True
        button_supplier_delete.Enabled = True
    End Sub


    Private Sub assignHeaderData()

        
        textbox_supplier_code.Text = listview_supplier.SelectedItems(0).SubItems(1).Text
        textbox_supplier_name.Text = listview_supplier.SelectedItems(0).SubItems(2).Text
        textbox_supplier_address.Text = listview_supplier.SelectedItems(0).SubItems(3).Text
        textbox_supplier_subdistrict.Text = listview_supplier.SelectedItems(0).SubItems(4).Text
        textbox_supplier_district.Text = listview_supplier.SelectedItems(0).SubItems(5).Text
        matchingCombobox(combobox_supplier_province, listview_supplier.SelectedItems(0).SubItems(6).Text)
        textbox_supplier_postcode.Text = listview_supplier.SelectedItems(0).SubItems(7).Text
        textbox_supplier_tel1.Text = listview_supplier.SelectedItems(0).SubItems(8).Text
        textbox_supplier_tel2.Text = listview_supplier.SelectedItems(0).SubItems(9).Text
        textbox_supplier_email.Text = listview_supplier.SelectedItems(0).SubItems(10).Text
        textbox_supplier_taxid.Text = listview_supplier.SelectedItems(0).SubItems(11).Text
        textbox_supplier_regno.Text = listview_supplier.SelectedItems(0).SubItems(12).Text





    End Sub


    Private Sub loadLvtSupplierData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "SELECT [Code]"
        sql &= " ,[Title] "
        sql &= " ,[Name]"
        sql &= " ,[Address]"
        sql &= " ,[SubDistrict]"
        sql &= " ,[District]"
        sql &= " ,[Province]"
        sql &= " ,[ZipCode]"
        sql &= " ,[Tel1]"
        sql &= " ,[Tel2]"
        sql &= " ,[Email]"
        sql &= " ,[TAXID]"
        sql &= " ,[RegistrationNo]"
        sql &= " ,[Status]"
        sql &= " ,[InsertDate]"
        sql &= " ,[InsertUser]"
        sql &= " ,[InsertIP]"
        sql &= " ,[LastUpdateDate]"
        sql &= " ,[LastUpdateUser]"
        sql &= " ,[LastUpdateIP]"
        sql &= " FROM [POS_DB_Salon].[dbo].[Supplier] where Supplier.Status = 'Active' and (Supplier.CODE like '%" & textbox_supplier_keyword.Text & "%' or Supplier.Name like '%" & textbox_supplier_keyword.Text & "%' or Supplier.Address like '%" & textbox_supplier_keyword.Text & "%' or Supplier.tel1 like '%" & textbox_supplier_keyword.Text & "%' or Supplier.tel2 like '%" & textbox_supplier_keyword.Text & "%' or Supplier.email like '%" & textbox_supplier_keyword.Text & "%')"


        If allstatus = False Then
            sql = "SELECT [Code]"
            sql &= " ,[Title] "
            sql &= " ,[Name]"
            sql &= " ,[Address]"
            sql &= " ,[SubDistrict]"
            sql &= " ,[District]"
            sql &= " ,[Province]"
            sql &= " ,[ZipCode]"
            sql &= " ,[Tel1]"
            sql &= " ,[Tel2]"
            sql &= " ,[Email]"
            sql &= " ,[TAXID]"
            sql &= " ,[RegistrationNo]"
            sql &= " ,[Status]"
            sql &= " ,[InsertDate]"
            sql &= " ,[InsertUser]"
            sql &= " ,[InsertIP]"
            sql &= " ,[LastUpdateDate]"
            sql &= " ,[LastUpdateUser]"
            sql &= " ,[LastUpdateIP]"
            sql &= " FROM [POS_DB_Salon].[dbo].[Supplier] where Supplier.Status = 'Active' "
        Else
            textbox_supplier_keyword.Text = ""
        End If

        sql &= " order by Supplier.Code "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_supplier.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(13) As String
            item(0) = i + 1
            item(1) = Common.IsNullToString(dt.Rows(i).Item("Code"))
            item(2) = Common.IsNullToString(dt.Rows(i).Item("Name"))
            item(3) = Common.IsNullToString(dt.Rows(i).Item("Address"))
            item(4) = Common.IsNullToString(dt.Rows(i).Item("SubDistrict"))
            item(5) = Common.IsNullToString(dt.Rows(i).Item("District"))
            item(6) = Common.IsNullToString(dt.Rows(i).Item("Province"))
            item(7) = Common.IsNullToString(dt.Rows(i).Item("Zipcode"))
            item(8) = Common.IsNullToString(dt.Rows(i).Item("Tel1"))
            item(9) = Common.IsNullToString(dt.Rows(i).Item("Tel2"))
            item(10) = Common.IsNullToString(dt.Rows(i).Item("Email"))
            item(11) = Common.IsNullToString(dt.Rows(i).Item("TAXID"))
            item(12) = Common.IsNullToString(dt.Rows(i).Item("RegistrationNo"))
            item(13) = Common.IsNullToString(dt.Rows(i).Item("Status"))


            Dim lr As New ListViewItem(item)
            listview_supplier.Items.Add(lr)
        Next
    End Sub

    Private Sub change_component_state(section As Section, state As ControlState)
        If (state = ControlState.Lock) Then
            textbox_supplier_code.ReadOnly = True
            textbox_supplier_name.ReadOnly = True
            textbox_supplier_address.ReadOnly = True
            textbox_supplier_email.ReadOnly = True
            textbox_supplier_tel1.ReadOnly = True
            textbox_supplier_tel2.ReadOnly = True
            textbox_supplier_taxid.ReadOnly = True
            textbox_supplier_regno.ReadOnly = True
            textbox_supplier_subdistrict.ReadOnly = True
            textbox_supplier_district.ReadOnly = True
            textbox_supplier_postcode.ReadOnly = True
            combobox_supplier_province.Enabled = False
            button_supplier_proceed.Enabled = False
            button_supplier_cancel.Enabled = True
        Else
            textbox_supplier_code.ReadOnly = False
            textbox_supplier_name.ReadOnly = False
            textbox_supplier_address.ReadOnly = False
            textbox_supplier_email.ReadOnly = False
            textbox_supplier_tel1.ReadOnly = False
            textbox_supplier_tel2.ReadOnly = False
            textbox_supplier_taxid.ReadOnly = False
            textbox_supplier_regno.ReadOnly = False
            textbox_supplier_subdistrict.ReadOnly = False
            textbox_supplier_district.ReadOnly = False
            textbox_supplier_postcode.ReadOnly = False
            combobox_supplier_province.Enabled = True
            button_supplier_proceed.Enabled = False
            button_supplier_cancel.Enabled = False
        End If

    End Sub

    Private Sub button_supplier_cancel_Click(sender As Object, e As EventArgs) Handles button_supplier_cancel.Click
        listview_supplier.Enabled = True
        reset_clear_control(Section.Supplier)
        change_component_state(Section.Supplier, ControlState.Lock)

        Select Case supplierMode
            Case Action.Add
                button_supplier_edit.Enabled = False
                button_supplier_delete.Enabled = False

            Case Action.Edit
                button_supplier_edit.Enabled = True
                button_supplier_delete.Enabled = True

        End Select

        button_supplier_proceed.Visible = False
        button_supplier_cancel.Visible = False
    End Sub

    Private Sub button_supplier_proceed_Click(sender As Object, e As EventArgs) Handles button_supplier_proceed.Click

        If textbox_supplier_name.Text = "" Then
            MessageBox.Show("Please enter supplier name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_supplier_name.Focus()
            Exit Sub
        End If




        If textbox_supplier_code.Text = "AUTO" Then


            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("Supplier", "Code")
                    lastestCode = "S" & lastestCode.Substring(1, 3)
                    Dim sql As String

                    sql = "INSERT INTO [Supplier]"
                    sql &= "    ([Code]"
                    sql &= " ,[Name]"
                    sql &= " ,[Address]"
                    sql &= " ,[SubDistrict]"
                    sql &= " ,[District]"
                    sql &= " ,[Province]"
                    sql &= " ,[ZipCode]"
                    sql &= " ,[Tel1]"
                    sql &= " ,[Tel2]"
                    sql &= " ,[Email]"
                    sql &= " ,[TAXID]"
                    sql &= " ,[RegistrationNo]"
                    sql &= " ,[Status]"
                    sql &= " ,[InsertDate]"
                    sql &= " ,[InsertUser]"
                    sql &= " ,[InsertIP]"
                    sql &= " ,[LastUpdateDate]"
                    sql &= " ,[LastUpdateUser]"
                    sql &= "    ,[LastUpdateIP])"
                    sql &= "     VALUES"
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(textbox_supplier_code.Text) Or textbox_supplier_code.Text.ToLower.Equals("auto"), lastestCode, textbox_supplier_code.Text) & "'"

                    sql &= "    ,'" & textbox_supplier_name.Text & "'"

                    sql &= "    ,'" & textbox_supplier_address.Text & "'"
                    sql &= "    ,'" & textbox_supplier_subdistrict.Text & "'"
                    sql &= "    ,'" & textbox_supplier_district.Text & "'"
                    sql &= "    ,'" & combobox_supplier_province.SelectedValue & "'"
                    sql &= "    ,'" & textbox_supplier_postcode.Text & "'"
                    sql &= "    ,'" & textbox_supplier_tel1.Text & "'"
                    sql &= "    ,'" & textbox_supplier_tel2.Text & "'"
                    sql &= "    ,'" & textbox_supplier_email.Text & "'"
                    sql &= "    ,'" & textbox_supplier_taxid.Text & "'"
                    sql &= "    ,'" & textbox_supplier_regno.Text & "'"
                    sql &= "    ,'Active'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"
                    sql &= "    ,getdate()"
                    sql &= "   ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "')"

                    Dim command = New SqlCommand(sql, cnn, transaction)


                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    loadLvtSupplierData(False, textbox_supplier_keyword.Text)
                    
                    reset_clear_control(Section.Supplier)
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
                    sql = "Update  [Supplier] set "


                    sql &= " [Name]='" & textbox_supplier_name.Text & "'"
                    sql &= " ,[Address]='" & textbox_supplier_address.Text & "'"
                    sql &= " ,[SubDistrict]='" & textbox_supplier_subdistrict.Text & "'"
                    sql &= " ,[District]='" & textbox_supplier_district.Text & "'"
                    sql &= " ,[Province]='" & combobox_supplier_province.SelectedValue & "'"
                    sql &= " ,[ZipCode]='" & textbox_supplier_postcode.Text & "'"
                    sql &= " ,[Tel1]='" & textbox_supplier_tel1.Text & "'"
                    sql &= " ,[Tel2]='" & textbox_supplier_tel2.Text & "'"
                    sql &= " ,[Email]='" & textbox_supplier_email.Text & "'"
                    sql &= " ,[TAXID]='" & textbox_supplier_taxid.Text & "'"
                    sql &= " ,[RegistrationNo]='" & textbox_supplier_regno.Text & "'"



                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & textbox_supplier_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtSupplierData(False, textbox_supplier_keyword.Text)

                    reset_clear_control(Section.Supplier)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_supplier.Enabled = True

        change_component_state(Section.Supplier, ControlState.Lock)

        Select Case supplierMode
            Case Action.Add

            Case Action.Edit
                button_supplier_edit.Enabled = True

        End Select

        button_supplier_proceed.Visible = False
        button_supplier_cancel.Visible = False
    End Sub

    Private Sub panel_title_supplier_Paint(sender As Object, e As PaintEventArgs) Handles panel_title_supplier.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub
End Class

