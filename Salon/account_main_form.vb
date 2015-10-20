Imports System.Data.SqlClient

Public Class account_main_form

    Public accountMode As Action
    Public levelMode As Action


    Dim lastLevelSelectedIndex As Integer
    Dim lastAccountSelectedIndex As Integer


    Enum Action
        Add
        Edit
        View
        Cancel
    End Enum
    Enum Section
        Account
        Level

    End Enum
    Enum ControlState
        Lock
        Unlock
    End Enum
    Sub LoadTitleCombobox()
        Dim dt As DataTable = Common.GetTitlePrefixDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)

        combobox_account_title.DataSource = dt
        combobox_account_title.DisplayMember = "Title"
        combobox_account_title.ValueMember = "Code"
        combobox_account_title.SelectedIndex = 0
    End Sub

   

    Sub LoadProvinceCombobox()
        Dim dt As DataTable = Common.GetProvinceDatatable

        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)
        combobox_account_province.DataSource = dt
        combobox_account_province.DisplayMember = "EnglishTitle"
        combobox_account_province.ValueMember = "Code"

    End Sub

    Sub LoadBranchCombobox()
        Dim dt As DataTable = Common.GetBranchDatatable

        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)
        combobox_account_province.DataSource = dt
        combobox_account_province.DisplayMember = "Name"
        combobox_account_province.ValueMember = "Code"

    End Sub

    Private Sub account_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControl1.Appearance = TabAppearance.FlatButtons
        Me.TabControl1.ItemSize = New Size(0, 1)
        Me.TabControl1.SizeMode = TabSizeMode.Fixed


        loadLvtLevelData(False, textbox_level_keyword.Text)
        ' loadLvtLevelData(False, txt_brand_keyword.Text)


        ' load combo box
        LoadLevelCombobox()
        LoadProvinceCombobox()

        LoadTitleCombobox()
        LoadBranchCombobox()
    End Sub
    Private Sub change_component_state(section As Section, state As ControlState)
        Select Case section

            Case section.Level
                If (state = ControlState.Lock) Then
                    textbox_level_code.ReadOnly = True
                    textbox_level_name.ReadOnly = True

                    button_level_proceed.Enabled = False
                    button_level_cancel.Enabled = True
                Else

                    textbox_level_code.ReadOnly = False
                    textbox_level_name.ReadOnly = False
                    button_level_proceed.Enabled = True
                    button_level_cancel.Enabled = True
                End If
                'Case section.Product
                '    If (state = ControlState.Lock) Then
                '        textbox_product_code.ReadOnly = True
                '        textbox_product_name.ReadOnly = True
                '        textbox_product_re_order_point.ReadOnly = True
                '        textbox_product_price.ReadOnly = True
                '        textbox_product_shortcode.ReadOnly = True
                '        combobox_product_unit.Enabled = False
                '        combobox_product_level.Enabled = False
                '        combobox_product_category.Enabled = False
                '        combobox_product_brand.Enabled = False

                '        button_product_proceed.Enabled = False
                '        button_product_cancel.Enabled = True

                '    Else

                '        textbox_product_code.ReadOnly = False
                '        textbox_product_name.ReadOnly = False

                '        textbox_product_re_order_point.ReadOnly = False
                '        textbox_product_price.ReadOnly = False
                '        textbox_product_shortcode.ReadOnly = False
                '        combobox_product_unit.Enabled = True
                '        combobox_product_level.Enabled = True
                '        combobox_product_category.Enabled = True
                '        combobox_product_brand.Enabled = True

                '        button_product_proceed.Enabled = True
                '        button_product_cancel.Enabled = True
                '    End If
        End Select
    End Sub
    Private Sub reset_clear_control(section As Section)
        Select Case section



            Case section.Level
                textbox_level_code.Clear()
                textbox_level_name.Clear()
                textbox_level_name.ReadOnly = False


            Case section.Account
                'textbox_product_code.Clear()
                'textbox_product_name.Clear()
                'textbox_product_shortcode.Clear()
                'textbox_product_price.Clear()
                'textbox_product_name.ReadOnly = False

                'combobox_product_brand.SelectedIndex = 0
                'combobox_product_level.SelectedIndex = 0
                'combobox_product_unit.SelectedIndex = 0
                'combobox_product_category.SelectedIndex = 0
                'textbox_product_shortcode.Clear()

                'chk_product_favorite.Checked = False
                'textbox_product_re_order_point.Clear()
        End Select
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

    Sub assignTypeDataToControl()
        textbox_level_code.Text = listview_level.SelectedItems(0).SubItems(1).Text
        lastLevelSelectedIndex = listview_level.SelectedItems(0).Index
        Dim sql As String
        sql = "select * from Level where Code='" & textbox_level_code.Text & "' "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        textbox_level_code.Text = dt.Rows(0).Item("Code")
        textbox_level_name.Text = dt.Rows(0).Item("Title")


        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub
    Private Sub account_main_form_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(221, Byte), Integer)), 1)
        e.Graphics.DrawLine(pen, 0, 74, Me.Width, 74) '(margin_left, top_from_left, wide, top_from_right)
    End Sub

    Protected button_navigate_foreground_color As Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(111, Byte), Integer))
    Protected button_navigate_background_color As Color = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
    Protected button_navigate_foreground_hover_color As Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
    Protected button_navigate_background_hover_color As Color = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(251, Byte), Integer))

    Private Sub button_product_Click(sender As Object, e As EventArgs) Handles button_account.Click
        TabControl1.SelectedTab = TabPage1

        Me.button_account.ForeColor = button_navigate_foreground_hover_color
        Me.button_account.BackColor = button_navigate_background_hover_color
        Me.button_level.ForeColor = button_navigate_foreground_color
        Me.button_level.BackColor = button_navigate_background_color
        Me.button_employee.ForeColor = button_navigate_foreground_color
        Me.button_employee.BackColor = button_navigate_background_color

    End Sub

    Private Sub button_category_Click(sender As Object, e As EventArgs) Handles button_level.Click
        TabControl1.SelectedTab = TabPage2
        Me.button_account.ForeColor = button_navigate_foreground_color
        Me.button_account.BackColor = button_navigate_background_color
        Me.button_level.ForeColor = button_navigate_foreground_hover_color
        Me.button_level.BackColor = button_navigate_background_hover_color

        Me.button_employee.ForeColor = button_navigate_foreground_color
        Me.button_employee.BackColor = button_navigate_background_color
    End Sub

    Private Sub button_new_customer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_show_all_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub button_level_new_Click(sender As Object, e As EventArgs) Handles button_level_new.Click
        textbox_level_name.ReadOnly = False
        reset_clear_control(Section.Level)
        levelMode = Action.Add
        textbox_level_code.Text = "AUTO"

        button_level_proceed.Enabled = True
        button_level_proceed.Visible = True
        button_level_cancel.Visible = True
    End Sub

    Private Sub button_level_edit_Click(sender As Object, e As EventArgs) Handles button_level_edit.Click
        levelMode = Action.Edit
        listview_level.Enabled = False
        button_level_edit.Enabled = False
        change_component_state(Section.Level, ControlState.Unlock)
        button_level_proceed.Text = "Save Change"
        button_level_cancel.Text = "Cancel"
        assignTypeDataToControl()
        button_level_proceed.Visible = True
        button_level_cancel.Visible = True
    End Sub

    Private Sub button_level_show_all_Click(sender As Object, e As EventArgs) Handles button_level_show_all.Click
        button_level_proceed.Visible = False
        button_level_cancel.Visible = False
        loadLvtLevelData(True, textbox_level_keyword.Text)
        change_component_state(Section.Level, ControlState.Lock)
        reset_clear_control(Section.Level)
    End Sub

    Private Sub button_level_delete_Click(sender As Object, e As EventArgs) Handles button_level_delete.Click
        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("Level", "Code", textbox_level_code.Text)
            loadLvtLevelData(False, textbox_level_keyword.Text)
            reset_clear_control(Section.Level)

            Select Case levelMode
                Case Action.Add
                    button_level_edit.Enabled = False
                    button_level_delete.Enabled = False

                Case Action.Edit
                    button_level_edit.Enabled = True
                    button_level_delete.Enabled = True

            End Select
            listview_level.Enabled = True
            button_level_proceed.Visible = False
            button_level_cancel.Visible = False

            LoadLevelCombobox()

        End If
    End Sub

    Private Sub button_level_proceed_Click(sender As Object, e As EventArgs) Handles button_level_proceed.Click
        If textbox_level_name.Text = "" Then
            MessageBox.Show("Please enter level title", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_level_name.Focus()
            Exit Sub
        End If


        If textbox_level_code.Text = "AUTO" Then


            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("Level", "Code")
                    Dim sql As String

                    sql = "INSERT INTO [Level]"
                    sql &= "    ([Code]"
                    sql &= "    ,[Title]"
                    sql &= "    ,[Status]"
                    sql &= "    ,[InsertDate]"
                    sql &= "    ,[InsertUser]"
                    sql &= "    ,[InsertIP]"
                    sql &= "    ,[LastUpdateDate]"
                    sql &= "    ,[LastUpdateUser]"
                    sql &= "    ,[LastUpdateIP])"
                    sql &= "     VALUES"
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(textbox_level_code.Text) Or textbox_level_code.Text.ToLower.Equals("auto"), lastestCode, textbox_level_code.Text) & "'"
                    sql &= "    ,'" & textbox_level_name.Text & "'"
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

                    loadLvtLevelData(False, textbox_level_keyword.Text)
                    'EditableControl(False)
                    'ControlButtonStatus(True)
                    'ConfirmButtonStatus(False)

                    'Dim lr As ListViewItem = listview_level.FindItemWithText( _
                    '    IIf(String.IsNullOrEmpty(textbox_level_code.Text) Or textbox_level_code.Text.ToLower.Equals("auto"), lastestCode, textbox_level_code.Text))
                    'lr.Selected = True

                    'lvtItem.Items(lvtItem.Items.Count - 1).Selected = True
                    'lvtItem.Select()

                    'assignTypeDataToControl()
                    reset_clear_control(Section.Level)
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
                    sql = "Update  [Level] set "

                    sql &= "    [Title]='" & textbox_level_name.Text & "'"


                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & textbox_level_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtLevelData(False, textbox_level_keyword.Text)

                    'listview_level.Items(lastTypeSelectedIndex).Selected = True
                    'listview_level.Select()
                    '  assignDataToControl()
                    reset_clear_control(Section.Level)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_level.Enabled = True

        change_component_state(Section.Level, ControlState.Lock)

        Select Case levelMode
            Case Action.Add

            Case Action.Edit
                button_level_edit.Enabled = True

        End Select

        button_level_proceed.Visible = False
        button_level_cancel.Visible = False

        LoadLevelCombobox()

    End Sub

    Sub LoadLevelCombobox()
        Dim dt As DataTable = Common.GetTypeDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("Code") = ""

        dt.Rows.InsertAt(dr, 0)

        combobox_account_level.DataSource = dt
        combobox_account_level.DisplayMember = "Title"
        combobox_account_level.ValueMember = "Code"
        combobox_account_level.SelectedIndex = 0
    End Sub

    Private Sub loadLvtLevelData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "select Code,Title,Status from [Level] where status = 'Active' and (Title like '%" & textbox_level_keyword.Text & "'   or Code like '%" & textbox_level_keyword.Text & "%')"
        If allstatus = False Then
            sql = "select Code,Title,Status from [Level]  where status = 'Active'"
        Else
            textbox_level_keyword.Text = ""
        End If

        sql &= " order by Code "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_level.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(5) As String
            item(0) = i + 1
            item(1) = dt.Rows(i).Item("Code")
            item(2) = Common.IsNullToString(dt.Rows(i).Item("Title"))

            Dim lr As New ListViewItem(item)
            listview_level.Items.Add(lr)
        Next
    End Sub
    Private Sub button_level_cancel_Click(sender As Object, e As EventArgs) Handles button_level_cancel.Click
        listview_level.Enabled = True
        reset_clear_control(Section.Level)
        change_component_state(Section.Level, ControlState.Lock)

        Select Case levelMode
            Case Action.Add
                button_level_edit.Enabled = False
                button_level_delete.Enabled = False

            Case Action.Edit
                button_level_edit.Enabled = True
                button_level_delete.Enabled = True

        End Select

        button_level_proceed.Visible = False
        button_level_cancel.Visible = False
    End Sub

    Private Sub button_level_search_Click(sender As Object, e As EventArgs) Handles button_level_search.Click
        loadLvtLevelData(True, textbox_level_keyword.Text)
        change_component_state(Section.Level, ControlState.Lock)
        reset_clear_control(Section.Level)
    End Sub

    Private Sub listview_level_Click(sender As Object, e As EventArgs) Handles listview_level.Click

    End Sub

    Private Sub textbox_account_cancel_Click(sender As Object, e As EventArgs) Handles textbox_account_cancel.Click

    End Sub

    Private Sub textbox_account_proceed_Click(sender As Object, e As EventArgs) Handles textbox_account_proceed.Click

    End Sub

    Private Sub textbox_account_show_all_Click(sender As Object, e As EventArgs) Handles textbox_account_show_all.Click

    End Sub

    Private Sub textbox_account_search_Click(sender As Object, e As EventArgs) Handles textbox_account_search.Click

    End Sub

    Private Sub button_account_new_Click(sender As Object, e As EventArgs) Handles button_account_new.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button_employee_search_all.Click

    End Sub

    Private Sub button_employee_Click(sender As Object, e As EventArgs) Handles button_employee.Click
        TabControl1.SelectedTab = TabPage3
        Me.button_account.ForeColor = button_navigate_foreground_color
        Me.button_account.BackColor = button_navigate_background_color
        Me.button_level.ForeColor = button_navigate_foreground_color
        Me.button_level.BackColor = button_navigate_background_color
        Me.button_employee.ForeColor = button_navigate_foreground_hover_color
        Me.button_employee.BackColor = button_navigate_background_hover_color
    End Sub
End Class