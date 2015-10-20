﻿Imports System.Data.SqlClient

Public Class branch_main_form
    Public branchMode As Action
    Enum Action
        Add
        Edit
        View
        Cancel
    End Enum
    Enum Section
        branch
    End Enum

    Enum ControlState
        Lock
        Unlock
    End Enum

    Private Sub reset_clear_control(section As Section)


        textbox_branch_code.Clear()
        textbox_branch_name.Clear()
        textbox_branch_taxid.Clear()
        textbox_branch_address.Clear()
        textbox_branch_subdistrict.Clear()
        textbox_branch_district.Clear()
        textbox_branch_postcode.Clear()

        textbox_branch_tel.Clear()
        textbox_branch_fax.Clear()

        combobox_branch_province.SelectedIndex = 0

    End Sub
    Private Sub assignHeaderData()


        textbox_branch_code.Text = listview_branch.SelectedItems(0).SubItems(1).Text
        textbox_branch_name.Text = listview_branch.SelectedItems(0).SubItems(2).Text
        textbox_branch_address.Text = listview_branch.SelectedItems(0).SubItems(3).Text
        textbox_branch_subdistrict.Text = listview_branch.SelectedItems(0).SubItems(4).Text
        textbox_branch_district.Text = listview_branch.SelectedItems(0).SubItems(5).Text
        matchingCombobox(combobox_branch_province, listview_branch.SelectedItems(0).SubItems(6).Text)
        textbox_branch_postcode.Text = listview_branch.SelectedItems(0).SubItems(7).Text
        textbox_branch_tel.Text = listview_branch.SelectedItems(0).SubItems(8).Text
        textbox_branch_fax.Text = listview_branch.SelectedItems(0).SubItems(9).Text
        textbox_branch_taxid.Text = listview_branch.SelectedItems(0).SubItems(11).Text






    End Sub


    Private Sub loadLvtbranchData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "SELECT [Code]"

        sql &= " ,[Name]"
        sql &= " ,[Address]"
        sql &= " ,[SubDistrict]"
        sql &= " ,[District]"
        sql &= " ,[Province]"
        sql &= " ,[ZipCode]"
        sql &= " ,[Tel]"
        sql &= " ,[fax]"

        sql &= " ,[TAXID]"

        sql &= " ,[Status]"
        sql &= " ,[InsertDate]"
        sql &= " ,[InsertUser]"
        sql &= " ,[InsertIP]"
        sql &= " ,[LastUpdateDate]"
        sql &= " ,[LastUpdateUser]"
        sql &= " ,[LastUpdateIP]"
        sql &= " FROM [POS_DB_Salon].[dbo].[branch] where branch.Status = 'Active' and (branch.CODE like '%" & textbox_branch_keyword.Text & "%' or branch.Name like '%" & textbox_branch_keyword.Text & "%' or branch.Address like '%" & textbox_branch_keyword.Text & "%' or branch.tel like '%" & textbox_branch_keyword.Text & "%' or branch.fax like '%" & textbox_branch_keyword.Text & "%')"


        If allstatus = False Then
            sql = "SELECT [Code]"

            sql &= " ,[Name]"
            sql &= " ,[Address]"
            sql &= " ,[SubDistrict]"
            sql &= " ,[District]"
            sql &= " ,[Province]"
            sql &= " ,[ZipCode]"
            sql &= " ,[Tel]"
            sql &= " ,[Fax]"

            sql &= " ,[TAXID]"
            sql &= " ,[Status]"
            sql &= " ,[InsertDate]"
            sql &= " ,[InsertUser]"
            sql &= " ,[InsertIP]"
            sql &= " ,[LastUpdateDate]"
            sql &= " ,[LastUpdateUser]"
            sql &= " ,[LastUpdateIP]"
            sql &= " FROM [POS_DB_Salon].[dbo].[branch] where branch.Status = 'Active' "
        Else
            textbox_branch_keyword.Text = ""
        End If

        sql &= " order by branch.Code "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_branch.Items.Clear()
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
            item(8) = Common.IsNullToString(dt.Rows(i).Item("Tel"))
            item(9) = Common.IsNullToString(dt.Rows(i).Item("Fax"))
            item(11) = Common.IsNullToString(dt.Rows(i).Item("TAXID"))
            item(13) = Common.IsNullToString(dt.Rows(i).Item("Status"))


            Dim lr As New ListViewItem(item)
            listview_branch.Items.Add(lr)
        Next
    End Sub

    Private Sub change_component_state(section As Section, state As ControlState)
        If (state = ControlState.Lock) Then
            textbox_branch_code.ReadOnly = True
            textbox_branch_name.ReadOnly = True
            textbox_branch_address.ReadOnly = True

            textbox_branch_tel.ReadOnly = True
            textbox_branch_fax.ReadOnly = True
            textbox_branch_taxid.ReadOnly = True

            textbox_branch_subdistrict.ReadOnly = True
            textbox_branch_district.ReadOnly = True
            textbox_branch_postcode.ReadOnly = True
            combobox_branch_province.Enabled = False
            button_branch_proceed.Enabled = False
            button_branch_cancel.Enabled = True
        Else
            textbox_branch_code.ReadOnly = False
            textbox_branch_name.ReadOnly = False
            textbox_branch_address.ReadOnly = False

            textbox_branch_tel.ReadOnly = False
            textbox_branch_fax.ReadOnly = False
            textbox_branch_taxid.ReadOnly = False

            textbox_branch_subdistrict.ReadOnly = False
            textbox_branch_district.ReadOnly = False
            textbox_branch_postcode.ReadOnly = False
            combobox_branch_province.Enabled = True
            button_branch_proceed.Enabled = False
            button_branch_cancel.Enabled = False
        End If

    End Sub
    Sub deleteDataFrom(table As String, onField As String, val As String)

        Using connection As SqlClient.SqlConnection = ConnectionManagement.GetConnection

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

    Sub LoadProvinceCombobox()
        Dim dt As DataTable = Common.GetProvinceDatatable

        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)
        combobox_branch_province.DataSource = dt
        combobox_branch_province.DisplayMember = "EnglishTitle"
        combobox_branch_province.ValueMember = "Code"

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


    Private Sub branch_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControl1.Appearance = TabAppearance.FlatButtons
        Me.TabControl1.ItemSize = New Size(0, 1)
        Me.TabControl1.SizeMode = TabSizeMode.Fixed



        LoadProvinceCombobox()
        loadLvtbranchData(False, textbox_branch_keyword.Text)
    End Sub

    Private Sub branch_main_form_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(221, Byte), Integer)), 1)
        e.Graphics.DrawLine(pen, 0, 74, Me.Width, 74) '(margin_left, top_from_left, wide, top_from_right)
    End Sub

    Private Sub button_branch_search_Click(sender As Object, e As EventArgs) Handles button_branch_search.Click
        loadLvtbranchData(True, textbox_branch_keyword.Text)
        change_component_state(Section.branch, ControlState.Lock)
        reset_clear_control(Section.branch)
    End Sub

    Private Sub button_branch_show_all_Click(sender As Object, e As EventArgs) Handles button_branch_show_all.Click
        loadLvtbranchData(False, textbox_branch_keyword.Text)
        change_component_state(Section.branch, ControlState.Lock)
        reset_clear_control(Section.branch)
    End Sub

    Private Sub button_branch_edit_Click(sender As Object, e As EventArgs) Handles button_branch_edit.Click
        branchMode = Action.Edit
        listview_branch.Enabled = False
        button_branch_edit.Enabled = False
        button_branch_cancel.Enabled = False
        change_component_state(Section.branch, ControlState.Unlock)
        button_branch_proceed.Text = "Save Change"
        button_branch_cancel.Text = "Cancel"
        button_branch_proceed.Visible = True
        button_branch_cancel.Visible = True
        assignHeaderData()
    End Sub

    Private Sub button_branch_delete_Click(sender As Object, e As EventArgs) Handles button_branch_delete.Click

        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("branch", "Code", textbox_branch_code.Text)
            loadLvtbranchData(False, textbox_branch_keyword.Text)
            reset_clear_control(Section.branch)

            Select Case branchMode
                Case Action.Add
                    button_branch_edit.Enabled = False
                    button_branch_delete.Enabled = False

                Case Action.Edit
                    button_branch_edit.Enabled = True
                    button_branch_delete.Enabled = True

            End Select
            listview_branch.Enabled = True
            button_branch_proceed.Visible = False
            button_branch_cancel.Visible = False
        End If
    End Sub

    Private Sub button_branch_proceed_Click(sender As Object, e As EventArgs) Handles button_branch_proceed.Click

        If textbox_branch_name.Text = "" Then
            MessageBox.Show("Please enter branch name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_branch_name.Focus()
            Exit Sub
        End If




        If textbox_branch_code.Text = "AUTO" Then


            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("branch", "Code")
                    lastestCode = "B" & lastestCode.Substring(1, 3)
                    Dim sql As String

                    sql = "INSERT INTO [branch]"
                    sql &= "    ([Code]"
                    sql &= " ,[Name]"
                    sql &= " ,[Address]"
                    sql &= " ,[SubDistrict]"
                    sql &= " ,[District]"
                    sql &= " ,[Province]"
                    sql &= " ,[ZipCode]"
                    sql &= " ,[Tel]"
                    sql &= " ,[Fax]"

                    sql &= " ,[TAXID]"

                    sql &= " ,[Status]"
                    sql &= " ,[InsertDate]"
                    sql &= " ,[InsertUser]"
                    sql &= " ,[InsertIP]"
                    sql &= " ,[LastUpdateDate]"
                    sql &= " ,[LastUpdateUser]"
                    sql &= "    ,[LastUpdateIP])"
                    sql &= "     VALUES"
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(textbox_branch_code.Text) Or textbox_branch_code.Text.ToLower.Equals("auto"), lastestCode, textbox_branch_code.Text) & "'"

                    sql &= "    ,'" & textbox_branch_name.Text & "'"

                    sql &= "    ,'" & textbox_branch_address.Text & "'"
                    sql &= "    ,'" & textbox_branch_subdistrict.Text & "'"
                    sql &= "    ,'" & textbox_branch_district.Text & "'"
                    sql &= "    ,'" & combobox_branch_province.SelectedValue & "'"
                    sql &= "    ,'" & textbox_branch_postcode.Text & "'"
                    sql &= "    ,'" & textbox_branch_tel.Text & "'"
                    sql &= "    ,'" & textbox_branch_fax.Text & "'"

                    sql &= "    ,'" & textbox_branch_taxid.Text & "'"

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

                    loadLvtbranchData(False, textbox_branch_keyword.Text)

                    reset_clear_control(Section.branch)
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
                    sql = "Update  [branch] set "


                    sql &= " [Name]='" & textbox_branch_name.Text & "'"
                    sql &= " ,[Address]='" & textbox_branch_address.Text & "'"
                    sql &= " ,[SubDistrict]='" & textbox_branch_subdistrict.Text & "'"
                    sql &= " ,[District]='" & textbox_branch_district.Text & "'"
                    sql &= " ,[Province]='" & combobox_branch_province.SelectedValue & "'"
                    sql &= " ,[ZipCode]='" & textbox_branch_postcode.Text & "'"
                    sql &= " ,[Tel1]='" & textbox_branch_tel.Text & "'"
                    sql &= " ,[Tel2]='" & textbox_branch_fax.Text & "'"

                    sql &= " ,[TAXID]='" & textbox_branch_taxid.Text & "'" 



                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & textbox_branch_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtbranchData(False, textbox_branch_keyword.Text)

                    reset_clear_control(Section.branch)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_branch.Enabled = True

        change_component_state(Section.branch, ControlState.Lock)

        Select Case branchMode
            Case Action.Add

            Case Action.Edit
                button_branch_edit.Enabled = True

        End Select

        button_branch_proceed.Visible = False
        button_branch_cancel.Visible = False
    End Sub

    Private Sub button_branch_cancel_Click(sender As Object, e As EventArgs) Handles button_branch_cancel.Click
        listview_branch.Enabled = True
        reset_clear_control(Section.branch)
        change_component_state(Section.branch, ControlState.Lock)

        Select Case branchMode
            Case Action.Add
                button_branch_edit.Enabled = False
                button_branch_delete.Enabled = False

            Case Action.Edit
                button_branch_edit.Enabled = True
                button_branch_delete.Enabled = True

        End Select

        button_branch_proceed.Visible = False
        button_branch_cancel.Visible = False
    End Sub

    Private Sub button_branch_new_Click(sender As Object, e As EventArgs) Handles button_branch_new.Click
        reset_clear_control(Section.branch)

        branchMode = Action.Add

        textbox_branch_code.Text = "AUTO"
        textbox_branch_name.ReadOnly = False


        branchMode = Action.Edit
        listview_branch.Enabled = False
        button_branch_edit.Enabled = False
        change_component_state(Section.branch, ControlState.Unlock)
        button_branch_proceed.Text = "Save Change"
        button_branch_cancel.Text = "Cancel"
        button_branch_cancel.Enabled = False
        button_branch_proceed.Enabled = True

        button_branch_proceed.Visible = True
        button_branch_cancel.Visible = True
    End Sub

    Private Sub listview_branch_Click(sender As Object, e As EventArgs) Handles listview_branch.Click
        assignHeaderData()
        button_branch_edit.Enabled = True
        button_branch_delete.Enabled = True
    End Sub
End Class