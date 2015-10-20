Imports System.Data.SqlClient

Public Class product_main_form

    Public brandMode As Action
    Public productMode As Action
    Public typeMode As Action
    Public categoryMode As Action
    Public unitMode As Action

    Dim lastBrandSelectedIndex As Integer
    Dim lastProductSelectedIndex As Integer
    Dim lastUnitSelectedIndex As Integer
    Dim lastTypeSelectedIndex As Integer
    Dim lastCategorySelectedIndex As Integer

    Enum Action
        Add
        Edit
        View
        Cancel
    End Enum
    Enum Section
        Category
        Unit
        Type
        Brand
        Product
    End Enum
    Enum ControlState
        Lock
        Unlock
    End Enum

    Private Sub product_main_form_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(221, Byte), Integer)), 1)
        e.Graphics.DrawLine(pen, 0, 74, Me.Width, 74) '(margin_left, top_from_left, wide, top_from_right)
    End Sub

    Private Sub product_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControl1.Appearance = TabAppearance.FlatButtons
        Me.TabControl1.ItemSize = New Size(0, 1)
        Me.TabControl1.SizeMode = TabSizeMode.Fixed

        loadLvtProductData(False, txt_product_keyword.Text)
        loadLvtBrandData(False, txt_brand_keyword.Text)
        loadLvtTypeData(False, textbox_type_keyword.Text)
        loadLvtCategoryData(False, textbox_category_keyword.Text)
        loadLvtUnitData(False, textbox_unit_keyword.Text)

        ' load combo box
        LoadTypeCombobox()
        LoadBrandCombobox()
        LoadUnitCombobox()
        LoadCategoryCombobox()


    End Sub

    Sub LoadTypeCombobox()
        Dim dt As DataTable = Common.GetTypeDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("Code") = ""

        dt.Rows.InsertAt(dr, 0)

        combobox_product_type.DataSource = dt
        combobox_product_type.DisplayMember = "Title"
        combobox_product_type.ValueMember = "Code"
        combobox_product_type.SelectedIndex = 0
    End Sub

    Sub LoadBrandCombobox()
        Dim dt As DataTable = Common.GetBrandDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("Code") = ""

        dt.Rows.InsertAt(dr, 0)

        combobox_product_brand.DataSource = dt
        combobox_product_brand.DisplayMember = "Title"
        combobox_product_brand.ValueMember = "Code"
        combobox_product_brand.SelectedIndex = 0
    End Sub

    Sub LoadUnitCombobox()
        Dim dt As DataTable = Common.GetUnitDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("Code") = ""

        dt.Rows.InsertAt(dr, 0)

        combobox_product_unit.DataSource = dt
        combobox_product_unit.DisplayMember = "Title"
        combobox_product_unit.ValueMember = "Code"
        combobox_product_unit.SelectedIndex = 0
    End Sub

    Sub LoadCategoryCombobox()
        Dim dt As DataTable = Common.GetCategoryDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("Code") = ""

        dt.Rows.InsertAt(dr, 0)

        combobox_product_category.DataSource = dt
        combobox_product_category.DisplayMember = "Title"
        combobox_product_category.ValueMember = "Code"
        combobox_product_category.SelectedIndex = 0
    End Sub


    Private Sub loadLvtBrandData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "select Code,Title,Status from Brand where status = 'Active' and (Title like '%" & txt_brand_keyword.Text & "%' or Code like '%" & txt_brand_keyword.Text & "%')"
        If allstatus = False Then
            sql = "select Code,Title,Status from  Brand  where status = 'Active' "
        Else
            txt_brand_keyword.Text = ""
        End If

        sql &= " order by Code "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_brand.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(5) As String
            item(0) = i + 1
            item(1) = dt.Rows(i).Item("Code")
            item(2) = Common.IsNullToString(dt.Rows(i).Item("Title"))

            Dim lr As New ListViewItem(item)
            listview_brand.Items.Add(lr)
        Next
    End Sub

    Private Sub loadLvtProductData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "SELECT Product.[Code]"
        sql &= ",Product.[CODENO]"
        sql &= ",Product.[Title] as ProductName"
        sql &= ",Product.[ProductUnit]"
        sql &= ",ProductUnit.Title as UnitName"
        sql &= ",Product.[ProductType]"
        sql &= ",ProductType.Title as TypeName"
        sql &= ",[ReOrderPoint]"
        sql &= ",[Brand].Title as Brand"
        sql &= ",[Price]"
        sql &= ",[ProductCAT]"
        sql &= ",ProductCAT.Title as CATName"
        sql &= ",[Favorite]"
        sql &= ",Product.[Status]"
        sql &= ",Product.[InsertDate]"
        sql &= ",Product.[InsertUser]"
        sql &= ",Product.[InsertIP]"
        sql &= ",Product.[LastUpdateDate]"
        sql &= ",Product.[LastUpdateUser]"
        sql &= ",Product.[LastUpdateIP]"
        sql &= " FROM (((([Product]"
        sql &= " inner join ProductUnit on Product.ProductUnit = ProductUnit.Code)"
        sql &= " inner join ProductType on Product.ProductType = ProductType.Code)"
        sql &= " inner join ProductCAT on Product.ProductCAT = ProductCAT.Code)"
        sql &= " left join Brand on Product.Brand = Brand.Code) where Product.Status = 'Active' and (Brand.Title like '%" & txt_product_keyword.Text & "%'   or ProductType.Title like '%" & txt_product_keyword.Text & "%'   or ProductUnit.Title like '%" & txt_product_keyword.Text & "%'   or ProductCAT.Title like '%" & txt_product_keyword.Text & "%'   or Product.Title like '%" & txt_product_keyword.Text & "%'   or Product.Code like '%" & txt_product_keyword.Text & "%'   or Product.CODENO like '%" & txt_product_keyword.Text & "%')"


        If allstatus = False Then
            sql = "SELECT Product.[Code]"
            sql &= ",Product.[CODENO]"
            sql &= ",Product.[Title] as ProductName"
            sql &= ",Product.[ProductUnit]"
            sql &= ",ProductUnit.Title as UnitName"
            sql &= ",Product.[ProductType]"
            sql &= ",ProductType.Title as TypeName"
            sql &= ",[ReOrderPoint]"
            sql &= ",[Brand].Title as Brand"
            sql &= ",[Price]"
            sql &= ",[ProductCAT]"
            sql &= ",ProductCAT.Title as CATName"
            sql &= ",[Favorite]"
            sql &= ",Product.[Status]"
            sql &= ",Product.[InsertDate]"
            sql &= ",Product.[InsertUser]"
            sql &= ",Product.[InsertIP]"
            sql &= ",Product.[LastUpdateDate]"
            sql &= ",Product.[LastUpdateUser]"
            sql &= ",Product.[LastUpdateIP]"
            sql &= " FROM (((([Product]"
            sql &= " inner join ProductUnit on Product.ProductUnit = ProductUnit.Code)"
            sql &= " inner join ProductType on Product.ProductType = ProductType.Code)"
            sql &= " inner join ProductCAT on Product.ProductCAT = ProductCAT.Code)"
            sql &= " left join Brand on Product.Brand = Brand.Code)"
            sql &= " WHERE Product.Status = 'Active'"
        Else
            txt_product_keyword.Text = ""
        End If

        sql &= " order by Product.Code "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_product.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(11) As String
            item(0) = i + 1
            item(1) = Common.IsNullToString(dt.Rows(i).Item("Code"))
            item(2) = Common.IsNullToString(dt.Rows(i).Item("ProductName"))
            item(3) = Common.IsNullToString(dt.Rows(i).Item("UnitName"))
            item(4) = Common.IsNullToString(dt.Rows(i).Item("TypeName"))
            item(5) = Common.IsNullToString(dt.Rows(i).Item("ReOrderPoint"))
            item(6) = Common.IsNullToString(dt.Rows(i).Item("Brand"))
            item(7) = Common.IsNullToString(dt.Rows(i).Item("Price"))
            item(8) = Common.IsNullToString(dt.Rows(i).Item("CATName"))
            item(9) = Common.IsNullToString(dt.Rows(i).Item("Favorite"))
            item(10) = Common.IsNullToString(dt.Rows(i).Item("Status"))
            item(11) = Common.IsNullToString(dt.Rows(i).Item("CODENO"))

            Dim lr As New ListViewItem(item)
            listview_product.Items.Add(lr)
        Next
    End Sub

    Private Sub loadLvtCategoryData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "select Code,Title,Status from ProductCAT where status = 'Active' and (Title like '%" & textbox_category_keyword.Text & "%'  or Code like '%" & textbox_category_keyword.Text & "%')"
        If allstatus = False Then
            sql = "select Code,Title,Status from ProductCAT where status = 'Active' "
        Else
            textbox_category_keyword.Text = ""
        End If

        sql &= " order by Code "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_category.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(5) As String
            item(0) = i + 1
            item(1) = dt.Rows(i).Item("Code")
            item(2) = Common.IsNullToString(dt.Rows(i).Item("Title"))

            Dim lr As New ListViewItem(item)
            listview_category.Items.Add(lr)
        Next
    End Sub

    Private Sub loadLvtUnitData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "select Code,Title,Status from ProductUnit  where status = 'Active' and (Title like '%" & textbox_unit_keyword.Text & "'   or Code like '%" & textbox_unit_keyword.Text & "%')"

        If allstatus = False Then
            sql = "select Code,Title,Status from ProductUnit  where status = 'Active' "
        Else
            textbox_unit_keyword.Text = ""
        End If

        sql &= " order by Code "

        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_unit.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(5) As String
            item(0) = i + 1
            item(1) = dt.Rows(i).Item("Code")
            item(2) = Common.IsNullToString(dt.Rows(i).Item("Title"))

            Dim lr As New ListViewItem(item)
            listview_unit.Items.Add(lr)
        Next
    End Sub


    Private Sub loadLvtTypeData(allstatus As Boolean, criteria As String)
        Dim sql As String
        sql = "select Code,Title,Status from ProductType where status = 'Active' and (Title like '%" & textbox_type_keyword.Text & "'   or Code like '%" & textbox_type_keyword.Text & "%')"
        If allstatus = False Then
            sql = "select Code,Title,Status from ProductType  where status = 'Active'"
        Else
            textbox_type_keyword.Text = ""
        End If

        sql &= " order by Code "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        listview_type.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim item(5) As String
            item(0) = i + 1
            item(1) = dt.Rows(i).Item("Code")
            item(2) = Common.IsNullToString(dt.Rows(i).Item("Title"))

            Dim lr As New ListViewItem(item)
            listview_type.Items.Add(lr)
        Next
    End Sub


    Protected button_navigate_foreground_color As Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(111, Byte), Integer))
    Protected button_navigate_background_color As Color = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
    Protected button_navigate_foreground_hover_color As Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
    Protected button_navigate_background_hover_color As Color = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(251, Byte), Integer))

    Private Sub button_product_Click(sender As Object, e As EventArgs) Handles button_product.Click
        TabControl1.SelectedTab = TabPage1

        Me.button_product.ForeColor = button_navigate_foreground_hover_color
        Me.button_product.BackColor = button_navigate_background_hover_color
        Me.button_category.ForeColor = button_navigate_foreground_color
        Me.button_category.BackColor = button_navigate_background_color
        Me.button_type.ForeColor = button_navigate_foreground_color
        Me.button_type.BackColor = button_navigate_background_color
        Me.button_unit.ForeColor = button_navigate_foreground_color
        Me.button_unit.BackColor = button_navigate_background_color
        Me.button_brand.ForeColor = button_navigate_foreground_color
        Me.button_brand.BackColor = button_navigate_background_color

        button_product_proceed.Visible = False
        button_product_cancel.Visible = False

        loadLvtProductData(False, txt_product_keyword.Text)
        change_component_state(Section.Product, ControlState.Lock)
        reset_clear_control(Section.Product)
    End Sub

    Private Sub button_category_Click(sender As Object, e As EventArgs) Handles button_category.Click
        TabControl1.SelectedTab = TabPage2
        Me.button_product.ForeColor = button_navigate_foreground_color
        Me.button_product.BackColor = button_navigate_background_color
        Me.button_category.ForeColor = button_navigate_foreground_hover_color
        Me.button_category.BackColor = button_navigate_background_hover_color
        Me.button_type.ForeColor = button_navigate_foreground_color
        Me.button_type.BackColor = button_navigate_background_color
        Me.button_unit.ForeColor = button_navigate_foreground_color
        Me.button_unit.BackColor = button_navigate_background_color
        Me.button_brand.ForeColor = button_navigate_foreground_color
        Me.button_brand.BackColor = button_navigate_background_color

        button_category_proceed.Visible = False
        button_category_cancel.Visible = False
        loadLvtCategoryData(False, textbox_category_keyword.Text)
        change_component_state(Section.Category, ControlState.Lock)
        reset_clear_control(Section.Category)


    End Sub
    Private Sub button_type_Click(sender As Object, e As EventArgs) Handles button_type.Click
        TabControl1.SelectedTab = TabPage5
        Me.button_product.ForeColor = button_navigate_foreground_color
        Me.button_product.BackColor = button_navigate_background_color
        Me.button_category.ForeColor = button_navigate_foreground_color
        Me.button_category.BackColor = button_navigate_background_color
        Me.button_unit.ForeColor = button_navigate_foreground_color
        Me.button_unit.BackColor = button_navigate_background_color
        Me.button_type.ForeColor = button_navigate_foreground_hover_color
        Me.button_type.BackColor = button_navigate_background_hover_color
        Me.button_brand.ForeColor = button_navigate_foreground_color
        Me.button_brand.BackColor = button_navigate_background_color
        button_type_proceed.Visible = False
        button_type_cancel.Visible = False
        loadLvtTypeData(True, txt_product_keyword.Text)
        change_component_state(Section.Type, ControlState.Lock)
        reset_clear_control(Section.Type)
    End Sub
    Private Sub button_unit_Click(sender As Object, e As EventArgs) Handles button_unit.Click
        TabControl1.SelectedTab = TabPage3
        Me.button_product.ForeColor = button_navigate_foreground_color
        Me.button_product.BackColor = button_navigate_background_color
        Me.button_category.ForeColor = button_navigate_foreground_color
        Me.button_category.BackColor = button_navigate_background_color
        Me.button_unit.ForeColor = button_navigate_foreground_hover_color
        Me.button_unit.BackColor = button_navigate_background_hover_color
        Me.button_type.ForeColor = button_navigate_foreground_color
        Me.button_type.BackColor = button_navigate_background_color
        Me.button_brand.ForeColor = button_navigate_foreground_color
        Me.button_brand.BackColor = button_navigate_background_color

        button_unit_proceed.Visible = False
        button_unit_cancel.Visible = False
        loadLvtUnitData(False, txt_product_keyword.Text)
        change_component_state(Section.Unit, ControlState.Lock)
        reset_clear_control(Section.Unit)
    End Sub
    Private Sub button_brand_Click(sender As Object, e As EventArgs) Handles button_brand.Click
        TabControl1.SelectedTab = TabPage4
        Me.button_product.ForeColor = button_navigate_foreground_color
        Me.button_product.BackColor = button_navigate_background_color
        Me.button_category.ForeColor = button_navigate_foreground_color
        Me.button_category.BackColor = button_navigate_background_color
        Me.button_unit.ForeColor = button_navigate_foreground_color
        Me.button_unit.BackColor = button_navigate_background_color
        Me.button_type.ForeColor = button_navigate_foreground_color
        Me.button_type.BackColor = button_navigate_background_color
        Me.button_brand.ForeColor = button_navigate_foreground_hover_color
        Me.button_brand.BackColor = button_navigate_background_hover_color

        button_brand_proceed.Visible = False
        button_brand_cancel.Visible = False
        loadLvtBrandData(False, txt_brand_keyword.Text)
        change_component_state(Section.Brand, ControlState.Lock)
        reset_clear_control(Section.Brand)
    End Sub

    Private Sub button_new_customer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_show_all_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub button_brand_edit_Click(sender As Object, e As EventArgs) Handles button_brand_edit.Click
        brandMode = Action.Edit

        listview_brand.Enabled = False

        button_brand_edit.Enabled = False

        change_component_state(Section.Brand, ControlState.Unlock)

        button_brand_proceed.Text = "Save Change"
        button_brand_cancel.Text = "Cancel"

        assignBrandDataToControl()

        button_brand_proceed.Visible = True
        button_brand_cancel.Visible = True
    End Sub


    Private Sub change_component_state(section As Section, state As ControlState)
        Select Case section
            Case section.Brand
                If (state = ControlState.Lock) Then

                    txt_brand_code.ReadOnly = True
                    txt_brand_name.ReadOnly = True
                    button_brand_proceed.Enabled = False
                    button_brand_cancel.Enabled = True
                Else

                    txt_brand_code.ReadOnly = False
                    txt_brand_name.ReadOnly = False

                    button_brand_proceed.Enabled = True
                    button_brand_cancel.Enabled = True
                End If

            Case section.Unit
                If (state = ControlState.Lock) Then

                    textbox_unit_code.ReadOnly = True
                    textbox_unit_name.ReadOnly = True
                    button_unit_proceed.Enabled = False
                    button_unit_cancel.Enabled = True
                Else

                    textbox_unit_code.ReadOnly = False
                    textbox_unit_name.ReadOnly = False
                    button_unit_proceed.Enabled = True
                    button_unit_cancel.Enabled = True
                End If
            Case section.Category
                If (state = ControlState.Lock) Then

                    textbox_category_code.ReadOnly = True
                    textbox_category_name.ReadOnly = True
                    button_category_proceed.Enabled = False
                    button_category_cancel.Enabled = True
                Else

                    textbox_category_code.ReadOnly = False
                    textbox_category_name.ReadOnly = False
                    button_category_proceed.Enabled = True
                    button_category_cancel.Enabled = True
                End If
            Case section.Type
                If (state = ControlState.Lock) Then
                    textbox_type_code.ReadOnly = True
                    textbox_type_name.ReadOnly = True

                    button_type_proceed.Enabled = False
                    button_type_cancel.Enabled = True
                Else

                    textbox_type_code.ReadOnly = False
                    textbox_type_name.ReadOnly = False
                    button_type_proceed.Enabled = True
                    button_type_cancel.Enabled = True
                End If
            Case section.Product
                If (state = ControlState.Lock) Then
                    textbox_product_code.ReadOnly = True
                    textbox_product_name.ReadOnly = True
                    textbox_product_re_order_point.ReadOnly = True
                    textbox_product_price.ReadOnly = True
                    textbox_product_shortcode.ReadOnly = True
                    combobox_product_unit.Enabled = False
                    combobox_product_type.Enabled = False
                    combobox_product_category.Enabled = False
                    combobox_product_brand.Enabled = False

                    button_product_proceed.Enabled = False
                    button_product_cancel.Enabled = True

                Else

                    textbox_product_code.ReadOnly = False
                    textbox_product_name.ReadOnly = False

                    textbox_product_re_order_point.ReadOnly = False
                    textbox_product_price.ReadOnly = False
                    textbox_product_shortcode.ReadOnly = False
                    combobox_product_unit.Enabled = True
                    combobox_product_type.Enabled = True
                    combobox_product_category.Enabled = True
                    combobox_product_brand.Enabled = True

                    button_product_proceed.Enabled = True
                    button_product_cancel.Enabled = True
                End If
        End Select
    End Sub
    Private Sub reset_clear_control(section As Section)
        Select Case section
            Case section.Brand
                txt_brand_code.Clear()
                txt_brand_name.Clear()
               
                txt_brand_name.ReadOnly = False

            Case section.Unit
                textbox_unit_code.Clear()
                textbox_unit_name.Clear()
                textbox_unit_name.ReadOnly = False
                

            Case section.Category
                textbox_category_code.Clear()
                textbox_category_name.Clear()
                textbox_category_name.ReadOnly = False



            Case section.Type
                textbox_type_code.Clear()
                textbox_type_name.Clear()
                textbox_type_name.ReadOnly = False


            Case section.Product
                textbox_product_code.Clear()
                textbox_product_name.Clear()
                textbox_product_shortcode.Clear()
                textbox_product_price.Clear()
                textbox_product_name.ReadOnly = False

                combobox_product_brand.SelectedIndex = 0
                combobox_product_type.SelectedIndex = 0
                combobox_product_unit.SelectedIndex = 0
                combobox_product_category.SelectedIndex = 0
                textbox_product_shortcode.Clear()

                chk_product_favorite.Checked = False
                textbox_product_re_order_point.Clear()
        End Select
    End Sub

    Private Sub button_brand_new_Click(sender As Object, e As EventArgs) Handles button_brand_new.Click
        reset_clear_control(Section.Brand)

        brandMode = Action.Add

        txt_brand_code.Text = "AUTO"
        txt_brand_name.ReadOnly = False

        button_brand_proceed.Enabled = True
        button_brand_proceed.Visible = True
        button_brand_cancel.Visible = True
    End Sub

    Private Sub button_brand_show_all_Click(sender As Object, e As EventArgs) Handles button_brand_show_all.Click
        button_brand_proceed.Visible = False
        button_brand_cancel.Visible = False
        loadLvtBrandData(False, txt_brand_keyword.Text)
        change_component_state(Section.Brand, ControlState.Lock)
        reset_clear_control(Section.Brand)
    End Sub

    Private Sub button_brand_cancel_Click(sender As Object, e As EventArgs) Handles button_brand_cancel.Click
        listview_brand.Enabled = True
        reset_clear_control(Section.Brand)
        change_component_state(Section.Brand, ControlState.Lock)

        Select Case brandMode
            Case Action.Add
                button_brand_edit.Enabled = False
                button_brand_delete.Enabled = False

            Case Action.Edit
                button_brand_edit.Enabled = True
                button_brand_delete.Enabled = True

        End Select

        button_brand_proceed.Visible = False
        button_brand_cancel.Visible = False

    End Sub

    Private Sub button_brand_proceed_Click(sender As Object, e As EventArgs) Handles button_brand_proceed.Click

        If txt_brand_name.Text = "" Then
            MessageBox.Show("Please enter brand title", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txt_brand_name.Focus()
            Exit Sub
        End If


        If txt_brand_code.Text = "AUTO" Then


            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("Brand", "Code")
                    Dim sql As String

                    sql = "INSERT INTO [Brand]"
                    sql &= "    ([Code]"
                    sql &= "    ,[Title]"
                    sql &= "    ,[Status]"
                    sql &= "    ,[InsertDate]"
                    sql &= "    ,[InsertUser]"
                    sql &= "   ,[InsertIP]"
                    sql &= "   ,[LastUpdateDate]"
                    sql &= "  ,[LastUpdateUser]"
                    sql &= "   ,[LastUpdateIP])"
                    sql &= "     VALUES"
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(txt_brand_code.Text) Or txt_brand_code.Text.ToLower.Equals("auto"), lastestCode, txt_brand_code.Text) & "'"
                    sql &= "    ,'" & txt_brand_name.Text & "'"



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

                    loadLvtBrandData(False, txt_brand_keyword.Text)
                    'EditableControl(False)
                    'ControlButtonStatus(True)
                    'ConfirmButtonStatus(False)

                    'Dim lr As ListViewItem = listview_brand.FindItemWithText( _
                    '    IIf(String.IsNullOrEmpty(txt_brand_code.Text) Or txt_brand_code.Text.ToLower.Equals("auto"), lastestCode, txt_brand_code.Text))
                    'lr.Selected = True

                    'lvtItem.Items(lvtItem.Items.Count - 1).Selected = True
                    'lvtItem.Select()
                    'assignBrandDataToControl()
                    reset_clear_control(Section.Brand)
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
                    sql = "Update  [Brand] set "

                    sql &= " [Title]='" & txt_brand_name.Text & "'"
                    sql &= " ,[LastUpdateDate]=getdate()"
                    sql &= " ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= " ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & txt_brand_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtBrandData(False, txt_brand_keyword.Text)

                    'listview_brand.Items(lastBrandSelectedIndex).Selected = True
                    'listview_brand.Select()
                    '  assignDataToControl()
                    reset_clear_control(Section.Brand)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_brand.Enabled = True

        change_component_state(Section.Brand, ControlState.Lock)

        Select Case brandMode
            Case Action.Add

            Case Action.Edit
                button_brand_edit.Enabled = True

        End Select

        button_brand_proceed.Visible = False
        button_brand_cancel.Visible = False

        LoadBrandCombobox()
        

    End Sub

    Sub assignBrandDataToControl()
        txt_brand_code.Text = listview_brand.SelectedItems(0).SubItems(1).Text
        lastBrandSelectedIndex = listview_brand.SelectedItems(0).Index
        Dim sql As String
        sql = "select * from Brand where Code='" & txt_brand_code.Text & "' "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        txt_brand_code.Text = dt.Rows(0).Item("Code")
        txt_brand_name.Text = dt.Rows(0).Item("Title")

        

        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub

    Sub assignCategoryDataToControl()
        textbox_category_code.Text = listview_category.SelectedItems(0).SubItems(1).Text
        lastCategorySelectedIndex = listview_category.SelectedItems(0).Index
        Dim sql As String
        sql = "select * from ProductCAT where Code='" & textbox_category_code.Text & "' "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        textbox_category_code.Text = dt.Rows(0).Item("Code")
        textbox_category_name.Text = dt.Rows(0).Item("Title")

        




        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub

    Sub assignUnitDataToControl()
        textbox_unit_code.Text = listview_unit.SelectedItems(0).SubItems(1).Text
        lastUnitSelectedIndex = listview_unit.SelectedItems(0).Index
        Dim sql As String
        sql = "select * from ProductUnit where Code='" & textbox_unit_code.Text & "' "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        textbox_unit_code.Text = dt.Rows(0).Item("Code")
        textbox_unit_name.Text = dt.Rows(0).Item("Title")

        




        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub

    Sub assignTypeDataToControl()
        textbox_type_code.Text = listview_type.SelectedItems(0).SubItems(1).Text
        lastTypeSelectedIndex = listview_type.SelectedItems(0).Index
        Dim sql As String
        sql = "select * from ProductType where Code='" & textbox_type_code.Text & "' "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        textbox_type_code.Text = dt.Rows(0).Item("Code")
        textbox_type_name.Text = dt.Rows(0).Item("Title")


        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub



    Sub assignProductDataToControl()
        textbox_product_code.Text = listview_product.SelectedItems(0).SubItems(0).Text
        lastProductSelectedIndex = listview_product.SelectedItems(0).Index
        Dim sql As String
        sql = "select * from Product where Code='" & textbox_product_code.Text & "' "
        Dim dt As DataTable
        dt = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        textbox_product_code.Text = dt.Rows(0).Item("Code")
        textbox_product_shortcode.Text = dt.Rows(0).Item("CODENO")
        textbox_product_name.Text = dt.Rows(0).Item("Title")

        

        'EditableControl(False)
        'ControlButtonStatus(True)
        'ConfirmButtonStatus(False)
    End Sub

    Private Sub button_brand_search_Click(sender As Object, e As EventArgs) Handles button_brand_search.Click
        loadLvtBrandData(True, txt_brand_keyword.Text)
        change_component_state(Section.Brand, ControlState.Lock)
        reset_clear_control(Section.Brand)
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub button_product_search_Click(sender As Object, e As EventArgs) Handles button_product_search.Click
        loadLvtProductData(True, txt_product_keyword.Text)
        change_component_state(Section.Product, ControlState.Lock)
        reset_clear_control(Section.Product)
    End Sub

    Private Sub button_product_show_all_Click(sender As Object, e As EventArgs) Handles button_product_show_all.Click
        'button_product_proceed.Visible = False
        'button_product_cancel.Visible = False
        loadLvtProductData(False, txt_product_keyword.Text)
        change_component_state(Section.Product, ControlState.Lock)
        reset_clear_control(Section.Product)
    End Sub

    Private Sub button_product_edit_Click(sender As Object, e As EventArgs) Handles button_product_edit.Click
        productMode = Action.Edit
        listview_product.Enabled = False
        button_product_edit.Enabled = False
        change_component_state(Section.Product, ControlState.Unlock)
        button_product_proceed.Text = "Save Change"
        button_product_cancel.Text = "Cancel"
        button_product_proceed.Visible = True
        button_product_cancel.Visible = True
        assignHeaderData()
    End Sub

    Private Sub assignHeaderData()
        textbox_product_code.Text = listview_product.SelectedItems(0).SubItems(1).Text
        textbox_product_shortcode.Text = listview_product.SelectedItems(0).SubItems(11).Text
        textbox_product_name.Text = listview_product.SelectedItems(0).SubItems(2).Text

        matchingCombobox(combobox_product_unit, listview_product.SelectedItems(0).SubItems(3).Text)
        matchingCombobox(combobox_product_type, listview_product.SelectedItems(0).SubItems(4).Text)
        matchingCombobox(combobox_product_brand, listview_product.SelectedItems(0).SubItems(6).Text)

        textbox_product_re_order_point.Text = listview_product.SelectedItems(0).SubItems(5).Text
        textbox_product_price.Text = listview_product.SelectedItems(0).SubItems(7).Text
        matchingCombobox(combobox_product_category, listview_product.SelectedItems(0).SubItems(8).Text)


        matchingCheckBox(chk_product_favorite, listview_product.SelectedItems(0).SubItems(9).Text, "True")


    End Sub

    Private Sub matchingCheckBox(chk As CheckBox, v As String, matchWith As String)
        If v.Equals(matchWith) Then
            chk.Checked = True
        Else
            chk.Checked = False
        End If
    End Sub

    Private Sub matchingCombobox(cbo As ComboBox, v As String)

        For i As Integer = 0 To cbo.Items.Count - 1
            If cbo.GetItemText(cbo.Items(i)).Equals(v) Then
                cbo.SelectedIndex = i
            End If
        Next

    End Sub

    Private Sub button_product_delete_Click(sender As Object, e As EventArgs) Handles button_product_delete.Click

        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("Product", "Code", textbox_product_code.Text)
            loadLvtProductData(False, txt_product_keyword.Text)
            reset_clear_control(Section.Product)

            Select Case productMode
                Case Action.Add
                    button_product_edit.Enabled = False
                    button_product_delete.Enabled = False

                Case Action.Edit
                    button_product_edit.Enabled = True
                    button_product_delete.Enabled = True

            End Select
            listview_product.Enabled = True
            button_product_proceed.Visible = False
            button_product_cancel.Visible = False
        End If
    End Sub

    Private Sub button_product_new_Click(sender As Object, e As EventArgs) Handles button_product_new.Click
        reset_clear_control(Section.Product)

        productMode = Action.Add

        textbox_product_code.Text = "AUTO"
        textbox_product_name.ReadOnly = False



        listview_product.Enabled = False
        button_product_edit.Enabled = False
        change_component_state(Section.Product, ControlState.Unlock)
        button_product_proceed.Text = "Save Change"
        button_product_cancel.Text = "Cancel"

        button_product_proceed.Enabled = True

        button_product_proceed.Visible = True
        button_product_cancel.Visible = True

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

    Sub saveData()
        'คำนวณตอนกดเสร็จ
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Dim Sql As String = ""
            Try


                If textbox_product_code.Text = "" Then
                    Sql = "INSERT INTO [Product]"
                    Sql &= "   ([Code]"
                    Sql &= "    ,[CODENO]"
                    Sql &= "    ,[Title]"
                    Sql &= "    ,[ProductUnit]"
                    Sql &= "    ,[ProductType]"
                    Sql &= "    ,[ReOrderPoint]"

                    Sql &= "    ,[Brand]"
                    Sql &= "    ,[Price]"
                    Sql &= "    ,[ProductCAT]"
                    Sql &= "    ,[Favorite]"
                    Sql &= "     ,[Status]"
                    Sql &= "     ,[InsertDate]"
                    Sql &= "     ,[InsertUser]"
                    Sql &= "     ,[InsertIP]"
                    Sql &= "    ,[LastUpdateDate]"
                    Sql &= "     ,[LastUpdateUser]"
                    Sql &= "     ,[LastUpdateIP])"
                    Sql &= "                VALUES "
                    Sql &= "   ('" & textbox_product_code.Text & "'"
                    Sql &= "    ,'" & textbox_product_shortcode.Text & "'"
                    Sql &= "    ,'" & textbox_product_name.Text & "'"
                    Sql &= "    ,'" & combobox_product_unit.SelectedValue & "'"
                    Sql &= "    ,'" & combobox_product_type.SelectedValue & "'"
                    Sql &= "    ," & textbox_product_re_order_point.Text

                    Sql &= "    ,'" & combobox_product_brand.SelectedValue & "'"
                    Sql &= "    ," & textbox_product_price.Text
                    Sql &= "    ,'" & combobox_product_category.SelectedValue & "'"

                    Dim status As String = "Unactive"
                    Dim favorite As String = "False"

                    If chk_product_favorite.Checked = True Then
                        favorite = "True"
                    End If


                    Sql &= "    ," & favorite
                    Sql &= "    ,'Active'"
                    Sql &= "    ,getdate()"
                    Sql &= "    ,'" & GlobalVar.UserID & "'"
                    Sql &= "    ,'" & Common.GetIPAddress & "'"
                    Sql &= "    ,getdate()"
                    Sql &= "   ,'" & GlobalVar.UserID & "'"
                    Sql &= "    ,'" & Common.GetIPAddress & "')"
                Else
                    Sql = "UPDATE [Product]"
                    Sql &= "   SET "
                    Sql &= "    [CODENO] = '" & textbox_product_shortcode.Text & "'"
                    Sql &= "    ,[Title] = '" & textbox_product_name.Text & "'"
                    Sql &= "    ,[ProductUnit] = '" & combobox_product_unit.SelectedValue & "'"
                    Sql &= "    ,[ProductType] = '" & combobox_product_type.SelectedValue & "'"
                    Sql &= "    ,[ReOrderPoint] = " & textbox_product_re_order_point.Text

                    Sql &= "    ,[Brand] = '" & combobox_product_brand.SelectedValue & "'"
                    Sql &= "    ,[Price] = " & textbox_product_price.Text
                    Sql &= "    ,[ProductCAT] = '" & combobox_product_category.SelectedValue & "'"
                    
                    Dim status As String = "Unactive"
                    Dim favorite As String = "False"

                    If chk_product_favorite.Checked = True Then
                        favorite = "True"
                    End If


                    Sql &= " ,[Favorite] = " & favorite

                    
                    Sql &= " ,[LastUpdateDate] = getdate()"
                    Sql &= " ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    Sql &= " ,[LastUpdateIP]='" & Common.GetIPAddress & "'"

                    Sql &= "    where Code = '" & textbox_product_code.Text & "'"
                End If

                Dim commanditem = New SqlCommand(Sql, cnn)
                commanditem.CommandText = Sql
                commanditem.ExecuteNonQuery()


                MessageBox.Show("Update data success.")

            Catch ex As Exception

                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจากเกิดปัญหา" & ex.Message)

            End Try



        End Using
    End Sub

    Private Sub button_product_proceed_Click(sender As Object, e As EventArgs) Handles button_product_proceed.Click

        If textbox_product_name.Text = "" Then
            MessageBox.Show("Please enter product title", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_product_name.Focus()
            Exit Sub
        End If


        If textbox_product_re_order_point.Text = "" Then
            MessageBox.Show("Please enter product Re-Order point", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_product_re_order_point.Focus()
            Exit Sub
        End If

        If textbox_product_price.Text = "" Then
            MessageBox.Show("Please enter product price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_product_price.Focus()
            Exit Sub
        End If

        If textbox_product_code.Text = "AUTO" Then


            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("Product", "Code")
                    Dim sql As String

                    sql = "INSERT INTO [Product]"
                    sql &= "    ([Code]"
                    sql &= "    ,[CODENO]"
                    sql &= "    ,[Title]"

                    sql &= "    ,[ProductUnit]"
                    sql &= "    ,[ProductType]"
                    sql &= "    ,[ReOrderPoint]"
                    sql &= "    ,[Brand]"
                    sql &= "    ,[Price]"
                    sql &= "    ,[ProductCAT]"
                    sql &= "    ,[Favorite]"


                    sql &= "    ,[Status]"
                    sql &= "    ,[InsertDate]"
                    sql &= "    ,[InsertUser]"
                    sql &= "    ,[InsertIP]"
                    sql &= "    ,[LastUpdateDate]"
                    sql &= "    ,[LastUpdateUser]"
                    sql &= "    ,[LastUpdateIP])"
                    sql &= "     VALUES"
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(textbox_product_code.Text) Or textbox_product_code.Text.ToLower.Equals("auto"), lastestCode, textbox_product_code.Text) & "'"
                    sql &= "    ,'" & textbox_product_shortcode.Text & "'"
                    sql &= "    ,'" & textbox_product_name.Text & "'"

                    sql &= "    ,'" & combobox_product_unit.SelectedValue & "'"
                    sql &= "    ,'" & combobox_product_type.SelectedValue & "'"
                    sql &= "    ,'" & textbox_product_re_order_point.Text & "'"
                    sql &= "    ,'" & combobox_product_brand.SelectedValue & "'"
                    sql &= "    ,'" & textbox_product_price.Text & "'"
                    sql &= "    ,'" & combobox_product_category.SelectedValue & "'"

                    sql &= "    ," & IIf(chk_product_favorite.Checked = False, 0, 1)

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

                    loadLvtProductData(False, txt_product_keyword.Text)
                    'EditableControl(False)
                    'ControlButtonStatus(True)
                    'ConfirmButtonStatus(False)

                    'Dim lr As ListViewItem = listview_category.FindItemWithText( _
                    '    IIf(String.IsNullOrEmpty(textbox_product_code.Text) Or textbox_product_code.Text.ToLower.Equals("auto"), lastestCode, textbox_product_code.Text))
                    'lr.Selected = True

                    'lvtItem.Items(lvtItem.Items.Count - 1).Selected = True
                    'lvtItem.Select()
                    'assignProductDataToControl()
                    reset_clear_control(Section.Product)
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
                    sql = "Update  [Product] set "

                    sql &= "    [Title]='" & textbox_product_name.Text & "'"
                    sql &= "    ,[CODENO]='" & textbox_product_shortcode.Text & "'"
                    sql &= "    ,[ProductUnit] = '" & combobox_product_unit.SelectedValue & "'"
                    sql &= "    ,[ProductType] ='" & combobox_product_type.SelectedValue & "'"
                    sql &= "    ,[ReOrderPoint] =" & textbox_product_re_order_point.Text & ""
                    sql &= "    ,[Brand] ='" & combobox_product_brand.SelectedValue & "'"
                    sql &= "    ,[Price] = " & textbox_product_price.Text & ""
                    sql &= "    ,[ProductCAT] = '" & combobox_product_type.SelectedValue & "'"
                    sql &= "    ,[Favorite] =" & IIf(chk_product_favorite.Checked = False, 0, 1)





                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & textbox_product_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtProductData(False, txt_product_keyword.Text)

                    'listview_category.Items(lastCategorySelectedIndex).Selected = True
                    'listview_category.Select()
                    '  assignDataToControl()
                    reset_clear_control(Section.Product)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_product.Enabled = True

        change_component_state(Section.Product, ControlState.Lock)

        Select Case productMode
            Case Action.Add

            Case Action.Edit
                button_product_edit.Enabled = True

        End Select

        button_product_proceed.Visible = False
        button_product_cancel.Visible = False
    End Sub

    Private Sub button_product_cancel_Click(sender As Object, e As EventArgs) Handles button_product_cancel.Click
        listview_product.Enabled = True
        reset_clear_control(Section.Product)
        change_component_state(Section.Product, ControlState.Lock)

        Select Case productMode
            Case Action.Add
                button_product_edit.Enabled = False
                button_product_delete.Enabled = False

            Case Action.Edit
                button_product_edit.Enabled = True
                button_product_delete.Enabled = True

        End Select

        button_product_proceed.Visible = False
        button_product_cancel.Visible = False
    End Sub

    Private Sub button_category_edit_Click(sender As Object, e As EventArgs) Handles button_category_edit.Click
        categoryMode = Action.Edit

        listview_category.Enabled = False

        button_category_edit.Enabled = False

        change_component_state(Section.Category, ControlState.Unlock)

        button_category_proceed.Text = "Save Change"
        button_category_cancel.Text = "Cancel"

        assignCategoryDataToControl()


        button_category_proceed.Visible = True
        button_category_cancel.Visible = True
    End Sub

    Private Sub button_category_delete_Click(sender As Object, e As EventArgs) Handles button_category_delete.Click
        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("ProductCAT", "Code", textbox_category_code.Text)
            loadLvtCategoryData(False, textbox_category_keyword.Text)
            reset_clear_control(Section.Category)


            Select Case categoryMode
                Case Action.Add
                    button_category_edit.Enabled = False
                    button_category_delete.Enabled = False

                Case Action.Edit
                    button_category_edit.Enabled = True
                    button_category_delete.Enabled = True

            End Select

            listview_category.Enabled = True

            button_category_proceed.Visible = False
            button_category_cancel.Visible = False

            LoadCategoryCombobox()
        End If
    End Sub

    Private Sub button_category_new_Click(sender As Object, e As EventArgs) Handles button_category_new.Click
        reset_clear_control(Section.Category)

        categoryMode = Action.Add

        textbox_category_code.Text = "AUTO"
        textbox_category_name.ReadOnly = False

        button_category_proceed.Enabled = True
        button_category_proceed.Visible = True
        button_category_cancel.Visible = True

    End Sub

    Private Sub textbox_category_search_Click(sender As Object, e As EventArgs) Handles textbox_category_search.Click
        loadLvtCategoryData(True, textbox_category_keyword.Text)
        change_component_state(Section.Category, ControlState.Lock)
        reset_clear_control(Section.Category)
    End Sub

    Private Sub textbox_category_cancel_Click(sender As Object, e As EventArgs) Handles button_category_cancel.Click
        listview_category.Enabled = True
        reset_clear_control(Section.Category)
        change_component_state(Section.Category, ControlState.Lock)

        Select Case categoryMode
            Case Action.Add
                button_category_edit.Enabled = False
                button_category_delete.Enabled = False

            Case Action.Edit
                button_category_edit.Enabled = True
                button_category_delete.Enabled = True

        End Select

        button_category_proceed.Visible = False
        button_category_cancel.Visible = False
    End Sub

    Private Sub textbox_category_proceed_Click(sender As Object, e As EventArgs) Handles button_category_proceed.Click

        If textbox_category_name.Text = "" Then
            MessageBox.Show("Please enter category title", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_category_name.Focus()
            Exit Sub
        End If


        If textbox_category_code.Text = "AUTO" Then

            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("ProductCAT", "Code")
                    Dim sql As String

                    sql = "INSERT INTO [ProductCAT]"
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
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(textbox_category_code.Text) Or textbox_category_code.Text.ToLower.Equals("auto"), lastestCode, textbox_category_code.Text) & "'"
                    sql &= "    ,'" & textbox_category_name.Text & "'"

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

                    loadLvtCategoryData(False, textbox_category_keyword.Text)
                    'EditableControl(False)
                    'ControlButtonStatus(True)
                    'ConfirmButtonStatus(False)

                    'Dim lr As ListViewItem = listview_category.FindItemWithText( _
                    '    IIf(String.IsNullOrEmpty(textbox_category_code.Text) Or textbox_category_code.Text.ToLower.Equals("auto"), lastestCode, textbox_category_code.Text))
                    'lr.Selected = True

                    'lvtItem.Items(lvtItem.Items.Count - 1).Selected = True
                    'lvtItem.Select()
                    ' assignCategoryDataToControl()

                    reset_clear_control(Section.Category)
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
                    sql = "Update  [ProductCAT] set "

                    sql &= "    [Title]='" & textbox_category_name.Text & "'"



                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & textbox_category_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtCategoryData(False, textbox_category_keyword.Text)

                    'listview_category.Items(lastCategorySelectedIndex).Selected = True
                    'listview_category.Select()
                    'assignCategoryToControl()
                    reset_clear_control(Section.Category)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_category.Enabled = True

        change_component_state(Section.Category, ControlState.Lock)

        Select Case categoryMode
            Case Action.Add

            Case Action.Edit
                button_category_edit.Enabled = True

        End Select

        button_category_proceed.Visible = False
        button_category_cancel.Visible = False


        
        LoadCategoryCombobox()

    End Sub

    Private Sub textbox_category_show_all_Click(sender As Object, e As EventArgs) Handles textbox_category_show_all.Click
        loadLvtCategoryData(False, textbox_category_keyword.Text)
        change_component_state(Section.Category, ControlState.Lock)
        reset_clear_control(Section.Category)
    End Sub

    Private Sub button_brand_delete_Click(sender As Object, e As EventArgs) Handles button_brand_delete.Click
        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("Brand", "Code", txt_brand_code.Text)
            loadLvtBrandData(False, txt_brand_keyword.Text)
            reset_clear_control(Section.Brand)

            Select Case brandMode
                Case Action.Add
                    button_brand_edit.Enabled = False
                    button_brand_delete.Enabled = False

                Case Action.Edit
                    button_brand_edit.Enabled = True
                    button_brand_delete.Enabled = True

            End Select
            listview_brand.Enabled = True
            button_brand_proceed.Visible = False
            button_brand_cancel.Visible = False

            LoadBrandCombobox()
            
        End If
    End Sub

    Private Sub button_unit_new_Click(sender As Object, e As EventArgs) Handles button_unit_new.Click
        reset_clear_control(Section.Category)
        unitMode = Action.Add
        textbox_unit_code.Text = "AUTO"
        textbox_unit_name.ReadOnly = False
        button_unit_proceed.Enabled = True
        button_unit_proceed.Visible = True
        button_unit_cancel.Visible = True
    End Sub

    Private Sub button_unit_proceed_Click(sender As Object, e As EventArgs) Handles button_unit_proceed.Click
        If textbox_unit_name.Text = "" Then
            MessageBox.Show("Please enter unit title", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_unit_name.Focus()
            Exit Sub
        End If


        If textbox_unit_code.Text = "AUTO" Then


            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("ProductUnit", "Code")
                    Dim sql As String

                    sql = "INSERT INTO [ProductUnit]"
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
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(textbox_unit_code.Text) Or textbox_unit_code.Text.ToLower.Equals("auto"), lastestCode, textbox_unit_code.Text) & "'"
                    sql &= "    ,'" & textbox_unit_name.Text & "'"

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

                    loadLvtUnitData(False, textbox_unit_keyword.Text)
                    'EditableControl(False)
                    'ControlButtonStatus(True)
                    'ConfirmButtonStatus(False)

                    'Dim lr As ListViewItem = listview_unit.FindItemWithText( _
                    '    IIf(String.IsNullOrEmpty(textbox_unit_code.Text) Or textbox_unit_code.Text.ToLower.Equals("auto"), lastestCode, textbox_unit_code.Text))
                    'lr.Selected = True

                    'lvtItem.Items(lvtItem.Items.Count - 1).Selected = True
                    'lvtItem.Select()
                    'assignUnitDataToControl()
                    reset_clear_control(Section.Unit)
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
                    sql = "Update  [ProductUnit] set "

                    sql &= "    [Title]='" & textbox_unit_name.Text & "'"

                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & textbox_unit_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtUnitData(False, textbox_unit_keyword.Text)

                    'listview_unit.Items(lastUnitSelectedIndex).Selected = True
                    'listview_unit.Select()
                    '  assignDataToControl()
                    reset_clear_control(Section.Unit)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_unit.Enabled = True

        change_component_state(Section.Unit, ControlState.Lock)

        Select Case unitMode
            Case Action.Add

            Case Action.Edit
                button_unit_edit.Enabled = True

        End Select

        button_unit_proceed.Visible = False
        button_unit_cancel.Visible = False

        LoadUnitCombobox()


    End Sub

    Private Sub button_type_show_all_Click(sender As Object, e As EventArgs) Handles button_type_show_all.Click
        button_type_proceed.Visible = False
        button_type_cancel.Visible = False
        loadLvtTypeData(True, txt_product_keyword.Text)
        change_component_state(Section.Type, ControlState.Lock)
        reset_clear_control(Section.Type)
    End Sub

    Private Sub button_unit_show_all_Click(sender As Object, e As EventArgs) Handles button_unit_show_all.Click
        button_unit_proceed.Visible = False
        button_unit_cancel.Visible = False
        loadLvtUnitData(False, txt_product_keyword.Text)
        change_component_state(Section.Unit, ControlState.Lock)
        reset_clear_control(Section.Unit)
    End Sub

    Private Sub button_unit_search_Click(sender As Object, e As EventArgs) Handles button_unit_search.Click
        loadLvtUnitData(True, txt_brand_keyword.Text)
        change_component_state(Section.Unit, ControlState.Lock)
        reset_clear_control(Section.Unit)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles button_type_search.Click
        loadLvtTypeData(True, textbox_type_keyword.Text)
        change_component_state(Section.Type, ControlState.Lock)
        reset_clear_control(Section.Type)
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_type_proceed_Click(sender As Object, e As EventArgs) Handles button_type_proceed.Click
        If textbox_type_name.Text = "" Then
            MessageBox.Show("Please enter service type title", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            textbox_type_name.Focus()
            Exit Sub
        End If


        If textbox_type_code.Text = "AUTO" Then


            Using connection As SqlConnection = ConnectionManagement.GetConnection
                Dim cnn As SqlConnection = ConnectionManagement.GetConnection
                Dim transaction As SqlTransaction
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If
                transaction = cnn.BeginTransaction()

                Try
                    Dim lastestCode As String = Common.GetLatestCode("ProductType", "Code")
                    Dim sql As String

                    sql = "INSERT INTO [ProductType]"
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
                    sql &= "    ('" & IIf(String.IsNullOrEmpty(textbox_type_code.Text) Or textbox_type_code.Text.ToLower.Equals("auto"), lastestCode, textbox_type_code.Text) & "'"
                    sql &= "    ,'" & textbox_type_name.Text & "'"
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

                    loadLvtTypeData(False, textbox_type_keyword.Text)
                    'EditableControl(False)
                    'ControlButtonStatus(True)
                    'ConfirmButtonStatus(False)

                    'Dim lr As ListViewItem = listview_type.FindItemWithText( _
                    '    IIf(String.IsNullOrEmpty(textbox_type_code.Text) Or textbox_type_code.Text.ToLower.Equals("auto"), lastestCode, textbox_type_code.Text))
                    'lr.Selected = True

                    'lvtItem.Items(lvtItem.Items.Count - 1).Selected = True
                    'lvtItem.Select()

                    'assignTypeDataToControl()
                    reset_clear_control(Section.Type)
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
                    sql = "Update  [ProductType] set "

                    sql &= "    [Title]='" & textbox_type_name.Text & "'"


                    sql &= "   ,[LastUpdateDate]=getdate()"
                    sql &= "  ,[LastUpdateUser]='" & GlobalVar.UserID & "'"
                    sql &= "   ,[LastUpdateIP]='" & Common.GetIPAddress & "'"
                    sql &= " where Code='" & textbox_type_code.Text & "'"
                    Dim command = New SqlCommand(sql, cnn, transaction)

                    command.CommandText = sql
                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    transaction.Commit()
                    MessageBox.Show("Update completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadLvtTypeData(False, textbox_type_keyword.Text)

                    'listview_type.Items(lastTypeSelectedIndex).Selected = True
                    'listview_type.Select()
                    '  assignDataToControl()
                    reset_clear_control(Section.Type)
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Can't update data  because " & ex.Message)
                End Try
            End Using
        End If


        listview_type.Enabled = True

        change_component_state(Section.Type, ControlState.Lock)

        Select Case typeMode
            Case Action.Add

            Case Action.Edit
                button_type_edit.Enabled = True

        End Select

        button_type_proceed.Visible = False
        button_type_cancel.Visible = False

        LoadTypeCombobox()
        
    End Sub

    Private Sub button_type_cancel_Click(sender As Object, e As EventArgs) Handles button_type_cancel.Click
        listview_type.Enabled = True
        reset_clear_control(Section.Type)
        change_component_state(Section.Type, ControlState.Lock)

        Select Case typeMode
            Case Action.Add
                button_type_edit.Enabled = False
                button_type_delete.Enabled = False

            Case Action.Edit
                button_type_edit.Enabled = True
                button_type_delete.Enabled = True

        End Select

        button_type_proceed.Visible = False
        button_type_cancel.Visible = False
    End Sub

    Private Sub button_unit_cancel_Click(sender As Object, e As EventArgs) Handles button_unit_cancel.Click
        listview_unit.Enabled = True
        reset_clear_control(Section.Unit)
        change_component_state(Section.Unit, ControlState.Lock)

        Select Case unitMode
            Case Action.Add
                button_unit_edit.Enabled = False
                button_unit_delete.Enabled = False

            Case Action.Edit
                button_unit_edit.Enabled = True
                button_unit_delete.Enabled = True

        End Select

        button_unit_proceed.Visible = False
        button_unit_cancel.Visible = False
    End Sub

    Private Sub button_type_new_Click(sender As Object, e As EventArgs) Handles button_type_new.Click
        textbox_type_name.ReadOnly = False
        reset_clear_control(Section.Type)
        typeMode = Action.Add
        textbox_type_code.Text = "AUTO"

        button_type_proceed.Enabled = True
        button_type_proceed.Visible = True
        button_type_cancel.Visible = True
    End Sub

    Private Sub button_type_edit_Click(sender As Object, e As EventArgs) Handles button_type_edit.Click
        typeMode = Action.Edit
        listview_type.Enabled = False
        button_type_edit.Enabled = False
        change_component_state(Section.Type, ControlState.Unlock)
        button_type_proceed.Text = "Save Change"
        button_type_cancel.Text = "Cancel"
        assignTypeDataToControl()
        button_type_proceed.Visible = True
        button_type_cancel.Visible = True
    End Sub

    Private Sub button_unit_edit_Click(sender As Object, e As EventArgs) Handles button_unit_edit.Click
        unitMode = Action.Edit

        listview_unit.Enabled = False

        button_unit_edit.Enabled = False

        change_component_state(Section.Unit, ControlState.Unlock)

        button_unit_proceed.Text = "Save Change"
        button_unit_cancel.Text = "Cancel"

        assignUnitDataToControl()

        button_unit_proceed.Visible = True
        button_unit_cancel.Visible = True
    End Sub

    Private Sub button_unit_delete_Click(sender As Object, e As EventArgs) Handles button_unit_delete.Click
        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("ProductUnit", "Code", textbox_unit_code.Text)
            loadLvtUnitData(False, textbox_unit_keyword.Text)
            reset_clear_control(Section.Unit)

            Select Case unitMode
                Case Action.Add
                    button_unit_edit.Enabled = False
                    button_unit_delete.Enabled = False

                Case Action.Edit
                    button_unit_edit.Enabled = True
                    button_unit_delete.Enabled = True

            End Select
            listview_unit.Enabled = True
            button_unit_proceed.Visible = False
            button_unit_cancel.Visible = False

            LoadUnitCombobox()

        End If
    End Sub

    Private Sub button_type_delete_Click(sender As Object, e As EventArgs) Handles button_type_delete.Click
        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            deleteDataFrom("ProductType", "Code", textbox_type_code.Text)
            loadLvtTypeData(False, textbox_type_keyword.Text)
            reset_clear_control(Section.Type)

            Select Case typeMode
                Case Action.Add
                    button_type_edit.Enabled = False
                    button_type_delete.Enabled = False

                Case Action.Edit
                    button_type_edit.Enabled = True
                    button_type_delete.Enabled = True

            End Select
            listview_type.Enabled = True
            button_type_proceed.Visible = False
            button_type_cancel.Visible = False

            LoadTypeCombobox()
            
        End If
    End Sub

    Private Sub listview_product_Click(sender As Object, e As EventArgs) Handles listview_product.Click
        assignHeaderData()
        button_product_edit.Enabled = True
        button_product_delete.Enabled = True
    End Sub

    Private Sub listview_category_Click(sender As Object, e As EventArgs) Handles listview_category.Click

        assignCategoryDataToControl()
        button_category_edit.Enabled = True
        button_category_delete.Enabled = True
    End Sub

    Private Sub listview_unit_Click(sender As Object, e As EventArgs) Handles listview_unit.Click
        assignUnitDataToControl()
        button_unit_edit.Enabled = True
        button_unit_delete.Enabled = True
    End Sub

    Private Sub listview_brand_Click(sender As Object, e As EventArgs) Handles listview_brand.Click
        assignBrandDataToControl()
        button_brand_edit.Enabled = True
        button_brand_delete.Enabled = True
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub listview_type_Click(sender As Object, e As EventArgs) Handles listview_type.Click
        assignTypeDataToControl()
        button_type_edit.Enabled = True
        button_type_delete.Enabled = True
    End Sub
End Class