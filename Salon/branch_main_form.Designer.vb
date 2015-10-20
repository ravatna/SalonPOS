<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class branch_main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(branch_main_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_branch = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.textbox_branch_taxid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textbox_branch_fax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textbox_branch_tel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combobox_branch_province = New System.Windows.Forms.ComboBox()
        Me.textbox_branch_district = New System.Windows.Forms.TextBox()
        Me.textbox_branch_postcode = New System.Windows.Forms.TextBox()
        Me.textbox_branch_subdistrict = New System.Windows.Forms.TextBox()
        Me.textbox_branch_address = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.button_branch_cancel = New System.Windows.Forms.Button()
        Me.button_branch_proceed = New System.Windows.Forms.Button()
        Me.textbox_branch_name = New System.Windows.Forms.TextBox()
        Me.textbox_branch_code = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.listview_branch = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.button_branch_edit = New System.Windows.Forms.Button()
        Me.button_branch_delete = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.button_branch_show_all = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.button_branch_search = New System.Windows.Forms.Button()
        Me.textbox_branch_keyword = New System.Windows.Forms.TextBox()
        Me.panel_title_branch = New System.Windows.Forms.Panel()
        Me.button_branch_new = New System.Windows.Forms.Button()
        Me.label_title_level = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.user_control_menu_left = New Salon.user_control_panel_left()
        Me.header_information = New Salon.user_control_home_button()
        Me.TabPage2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.panel_title_branch.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(220, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "       Branch"
        '
        'button_branch
        '
        Me.button_branch.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.button_branch.BackgroundImage = CType(resources.GetObject("button_branch.BackgroundImage"), System.Drawing.Image)
        Me.button_branch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_branch.FlatAppearance.BorderSize = 0
        Me.button_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_branch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.button_branch.Location = New System.Drawing.Point(0, 75)
        Me.button_branch.Name = "button_branch"
        Me.button_branch.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_branch.Size = New System.Drawing.Size(220, 42)
        Me.button_branch.TabIndex = 22
        Me.button_branch.Text = "Branch"
        Me.button_branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.textbox_branch_taxid)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.textbox_branch_fax)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.textbox_branch_tel)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.combobox_branch_province)
        Me.TabPage2.Controls.Add(Me.textbox_branch_district)
        Me.TabPage2.Controls.Add(Me.textbox_branch_postcode)
        Me.TabPage2.Controls.Add(Me.textbox_branch_subdistrict)
        Me.TabPage2.Controls.Add(Me.textbox_branch_address)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.button_branch_cancel)
        Me.TabPage2.Controls.Add(Me.button_branch_proceed)
        Me.TabPage2.Controls.Add(Me.textbox_branch_name)
        Me.TabPage2.Controls.Add(Me.textbox_branch_code)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Panel9)
        Me.TabPage2.Controls.Add(Me.Panel12)
        Me.TabPage2.Controls.Add(Me.panel_title_branch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1138, 667)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "TabPage1"
        '
        'textbox_branch_taxid
        '
        Me.textbox_branch_taxid.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_taxid.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_taxid.Location = New System.Drawing.Point(599, 370)
        Me.textbox_branch_taxid.Name = "textbox_branch_taxid"
        Me.textbox_branch_taxid.ReadOnly = True
        Me.textbox_branch_taxid.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_taxid.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(534, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 21)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Tax ID:"
        '
        'textbox_branch_fax
        '
        Me.textbox_branch_fax.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_fax.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_fax.Location = New System.Drawing.Point(811, 445)
        Me.textbox_branch_fax.Name = "textbox_branch_fax"
        Me.textbox_branch_fax.ReadOnly = True
        Me.textbox_branch_fax.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_fax.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(767, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 21)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Fax:"
        '
        'textbox_branch_tel
        '
        Me.textbox_branch_tel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_tel.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_tel.Location = New System.Drawing.Point(599, 445)
        Me.textbox_branch_tel.Name = "textbox_branch_tel"
        Me.textbox_branch_tel.ReadOnly = True
        Me.textbox_branch_tel.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_tel.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(555, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Tel:"
        '
        'combobox_branch_province
        '
        Me.combobox_branch_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_branch_province.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.combobox_branch_province.ForeColor = System.Drawing.Color.Black
        Me.combobox_branch_province.FormattingEnabled = True
        Me.combobox_branch_province.Location = New System.Drawing.Point(87, 440)
        Me.combobox_branch_province.Name = "combobox_branch_province"
        Me.combobox_branch_province.Size = New System.Drawing.Size(148, 29)
        Me.combobox_branch_province.TabIndex = 31
        '
        'textbox_branch_district
        '
        Me.textbox_branch_district.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_district.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_district.Location = New System.Drawing.Point(599, 405)
        Me.textbox_branch_district.Name = "textbox_branch_district"
        Me.textbox_branch_district.ReadOnly = True
        Me.textbox_branch_district.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_district.TabIndex = 32
        '
        'textbox_branch_postcode
        '
        Me.textbox_branch_postcode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_postcode.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_postcode.Location = New System.Drawing.Point(368, 441)
        Me.textbox_branch_postcode.Name = "textbox_branch_postcode"
        Me.textbox_branch_postcode.ReadOnly = True
        Me.textbox_branch_postcode.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_postcode.TabIndex = 33
        '
        'textbox_branch_subdistrict
        '
        Me.textbox_branch_subdistrict.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_subdistrict.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_subdistrict.Location = New System.Drawing.Point(368, 405)
        Me.textbox_branch_subdistrict.Name = "textbox_branch_subdistrict"
        Me.textbox_branch_subdistrict.ReadOnly = True
        Me.textbox_branch_subdistrict.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_subdistrict.TabIndex = 34
        '
        'textbox_branch_address
        '
        Me.textbox_branch_address.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_address.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_address.Location = New System.Drawing.Point(87, 405)
        Me.textbox_branch_address.Name = "textbox_branch_address"
        Me.textbox_branch_address.ReadOnly = True
        Me.textbox_branch_address.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_address.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(269, 409)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 21)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Sub District:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(283, 445)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 21)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Post Code:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 444)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 21)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Province:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(526, 409)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 21)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "District:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 21)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Address:"
        '
        'button_branch_cancel
        '
        Me.button_branch_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_branch_cancel.BackgroundImage = CType(resources.GetObject("button_branch_cancel.BackgroundImage"), System.Drawing.Image)
        Me.button_branch_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_branch_cancel.FlatAppearance.BorderSize = 0
        Me.button_branch_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button_branch_cancel.ForeColor = System.Drawing.Color.White
        Me.button_branch_cancel.Location = New System.Drawing.Point(241, 485)
        Me.button_branch_cancel.Name = "button_branch_cancel"
        Me.button_branch_cancel.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_branch_cancel.Size = New System.Drawing.Size(106, 36)
        Me.button_branch_cancel.TabIndex = 27
        Me.button_branch_cancel.Text = "Cancel"
        Me.button_branch_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch_cancel.UseVisualStyleBackColor = False
        Me.button_branch_cancel.Visible = False
        '
        'button_branch_proceed
        '
        Me.button_branch_proceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_branch_proceed.BackgroundImage = CType(resources.GetObject("button_branch_proceed.BackgroundImage"), System.Drawing.Image)
        Me.button_branch_proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_branch_proceed.FlatAppearance.BorderSize = 0
        Me.button_branch_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch_proceed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button_branch_proceed.ForeColor = System.Drawing.Color.White
        Me.button_branch_proceed.Location = New System.Drawing.Point(87, 485)
        Me.button_branch_proceed.Name = "button_branch_proceed"
        Me.button_branch_proceed.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_branch_proceed.Size = New System.Drawing.Size(148, 36)
        Me.button_branch_proceed.TabIndex = 28
        Me.button_branch_proceed.Text = "Proceed"
        Me.button_branch_proceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch_proceed.UseVisualStyleBackColor = False
        Me.button_branch_proceed.Visible = False
        '
        'textbox_branch_name
        '
        Me.textbox_branch_name.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_name.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_name.Location = New System.Drawing.Point(87, 370)
        Me.textbox_branch_name.Name = "textbox_branch_name"
        Me.textbox_branch_name.ReadOnly = True
        Me.textbox_branch_name.Size = New System.Drawing.Size(394, 29)
        Me.textbox_branch_name.TabIndex = 23
        '
        'textbox_branch_code
        '
        Me.textbox_branch_code.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textbox_branch_code.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_code.Location = New System.Drawing.Point(87, 334)
        Me.textbox_branch_code.Name = "textbox_branch_code"
        Me.textbox_branch_code.ReadOnly = True
        Me.textbox_branch_code.Size = New System.Drawing.Size(148, 29)
        Me.textbox_branch_code.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(26, 374)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 21)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(32, 338)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 21)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Code:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.listview_branch)
        Me.Panel9.Controls.Add(Me.button_branch_edit)
        Me.Panel9.Controls.Add(Me.button_branch_delete)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 100)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1138, 204)
        Me.Panel9.TabIndex = 22
        '
        'listview_branch
        '
        Me.listview_branch.BackColor = System.Drawing.Color.White
        Me.listview_branch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listview_branch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader1})
        Me.listview_branch.Dock = System.Windows.Forms.DockStyle.Top
        Me.listview_branch.FullRowSelect = True
        Me.listview_branch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listview_branch.Location = New System.Drawing.Point(0, 0)
        Me.listview_branch.Name = "listview_branch"
        Me.listview_branch.Size = New System.Drawing.Size(1138, 155)
        Me.listview_branch.TabIndex = 13
        Me.listview_branch.UseCompatibleStateImageBehavior = False
        Me.listview_branch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "No"
        Me.ColumnHeader7.Width = 75
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Code"
        Me.ColumnHeader10.Width = 147
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Branch Name"
        Me.ColumnHeader11.Width = 421
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Address"
        '
        'button_branch_edit
        '
        Me.button_branch_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.button_branch_edit.BackgroundImage = CType(resources.GetObject("button_branch_edit.BackgroundImage"), System.Drawing.Image)
        Me.button_branch_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_branch_edit.FlatAppearance.BorderSize = 0
        Me.button_branch_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch_edit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button_branch_edit.ForeColor = System.Drawing.Color.White
        Me.button_branch_edit.Location = New System.Drawing.Point(10, 162)
        Me.button_branch_edit.Name = "button_branch_edit"
        Me.button_branch_edit.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_branch_edit.Size = New System.Drawing.Size(90, 32)
        Me.button_branch_edit.TabIndex = 24
        Me.button_branch_edit.Text = "Edit"
        Me.button_branch_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch_edit.UseVisualStyleBackColor = False
        '
        'button_branch_delete
        '
        Me.button_branch_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.button_branch_delete.BackgroundImage = CType(resources.GetObject("button_branch_delete.BackgroundImage"), System.Drawing.Image)
        Me.button_branch_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_branch_delete.FlatAppearance.BorderSize = 0
        Me.button_branch_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch_delete.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button_branch_delete.ForeColor = System.Drawing.Color.White
        Me.button_branch_delete.Location = New System.Drawing.Point(106, 162)
        Me.button_branch_delete.Name = "button_branch_delete"
        Me.button_branch_delete.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.button_branch_delete.Size = New System.Drawing.Size(96, 32)
        Me.button_branch_delete.TabIndex = 21
        Me.button_branch_delete.Text = "Delete"
        Me.button_branch_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch_delete.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel12.Controls.Add(Me.button_branch_show_all)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 50)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1138, 50)
        Me.Panel12.TabIndex = 21
        '
        'button_branch_show_all
        '
        Me.button_branch_show_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_branch_show_all.BackgroundImage = CType(resources.GetObject("button_branch_show_all.BackgroundImage"), System.Drawing.Image)
        Me.button_branch_show_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_branch_show_all.FlatAppearance.BorderSize = 0
        Me.button_branch_show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch_show_all.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button_branch_show_all.ForeColor = System.Drawing.Color.White
        Me.button_branch_show_all.Location = New System.Drawing.Point(326, 7)
        Me.button_branch_show_all.Name = "button_branch_show_all"
        Me.button_branch_show_all.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_branch_show_all.Size = New System.Drawing.Size(131, 36)
        Me.button_branch_show_all.TabIndex = 17
        Me.button_branch_show_all.Text = "Show All"
        Me.button_branch_show_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch_show_all.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Controls.Add(Me.button_branch_search)
        Me.Panel13.Controls.Add(Me.textbox_branch_keyword)
        Me.Panel13.Location = New System.Drawing.Point(10, 7)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(310, 36)
        Me.Panel13.TabIndex = 18
        '
        'button_branch_search
        '
        Me.button_branch_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_branch_search.BackgroundImage = CType(resources.GetObject("button_branch_search.BackgroundImage"), System.Drawing.Image)
        Me.button_branch_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_branch_search.FlatAppearance.BorderSize = 0
        Me.button_branch_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch_search.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_branch_search.ForeColor = System.Drawing.Color.White
        Me.button_branch_search.Location = New System.Drawing.Point(278, 4)
        Me.button_branch_search.Name = "button_branch_search"
        Me.button_branch_search.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_branch_search.Size = New System.Drawing.Size(28, 28)
        Me.button_branch_search.TabIndex = 12
        Me.button_branch_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch_search.UseVisualStyleBackColor = False
        '
        'textbox_branch_keyword
        '
        Me.textbox_branch_keyword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textbox_branch_keyword.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_branch_keyword.ForeColor = System.Drawing.Color.Black
        Me.textbox_branch_keyword.Location = New System.Drawing.Point(7, 4)
        Me.textbox_branch_keyword.Name = "textbox_branch_keyword"
        Me.textbox_branch_keyword.Size = New System.Drawing.Size(265, 28)
        Me.textbox_branch_keyword.TabIndex = 0
        '
        'panel_title_branch
        '
        Me.panel_title_branch.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.panel_title_branch.Controls.Add(Me.button_branch_new)
        Me.panel_title_branch.Controls.Add(Me.label_title_level)
        Me.panel_title_branch.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title_branch.Location = New System.Drawing.Point(0, 0)
        Me.panel_title_branch.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_title_branch.Name = "panel_title_branch"
        Me.panel_title_branch.Size = New System.Drawing.Size(1138, 50)
        Me.panel_title_branch.TabIndex = 16
        '
        'button_branch_new
        '
        Me.button_branch_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button_branch_new.BackgroundImage = CType(resources.GetObject("button_branch_new.BackgroundImage"), System.Drawing.Image)
        Me.button_branch_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_branch_new.FlatAppearance.BorderSize = 0
        Me.button_branch_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_branch_new.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_branch_new.ForeColor = System.Drawing.Color.White
        Me.button_branch_new.Location = New System.Drawing.Point(969, 7)
        Me.button_branch_new.Name = "button_branch_new"
        Me.button_branch_new.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_branch_new.Size = New System.Drawing.Size(161, 36)
        Me.button_branch_new.TabIndex = 20
        Me.button_branch_new.Text = "New Branch"
        Me.button_branch_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_branch_new.UseVisualStyleBackColor = False
        '
        'label_title_level
        '
        Me.label_title_level.AutoSize = True
        Me.label_title_level.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title_level.ForeColor = System.Drawing.Color.Black
        Me.label_title_level.Location = New System.Drawing.Point(3, 9)
        Me.label_title_level.Name = "label_title_level"
        Me.label_title_level.Size = New System.Drawing.Size(130, 32)
        Me.label_title_level.TabIndex = 1
        Me.label_title_level.Text = "Branch List"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(220, 75)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1146, 693)
        Me.TabControl1.TabIndex = 21
        '
        'user_control_menu_left
        '
        Me.user_control_menu_left.BackColor = System.Drawing.Color.WhiteSmoke
        Me.user_control_menu_left.Location = New System.Drawing.Point(0, 0)
        Me.user_control_menu_left.Name = "user_control_menu_left"
        Me.user_control_menu_left.Size = New System.Drawing.Size(220, 768)
        Me.user_control_menu_left.TabIndex = 20
        '
        'header_information
        '
        Me.header_information.AutoSize = True
        Me.header_information.Location = New System.Drawing.Point(1000, 0)
        Me.header_information.Name = "header_information"
        Me.header_information.Size = New System.Drawing.Size(353, 70)
        Me.header_information.TabIndex = 19
        '
        'branch_main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.button_branch)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.user_control_menu_left)
        Me.Controls.Add(Me.header_information)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "branch_main_form"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Management"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.panel_title_branch.ResumeLayout(False)
        Me.panel_title_branch.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents header_information As Salon.user_control_home_button
    Friend WithEvents user_control_menu_left As Salon.user_control_panel_left
    Friend WithEvents button_branch As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents button_branch_cancel As System.Windows.Forms.Button
    Friend WithEvents button_branch_proceed As System.Windows.Forms.Button
    Friend WithEvents textbox_branch_name As System.Windows.Forms.TextBox
    Friend WithEvents textbox_branch_code As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents listview_branch As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents button_branch_edit As System.Windows.Forms.Button
    Friend WithEvents button_branch_delete As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents button_branch_show_all As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents button_branch_search As System.Windows.Forms.Button
    Friend WithEvents textbox_branch_keyword As System.Windows.Forms.TextBox
    Friend WithEvents panel_title_branch As System.Windows.Forms.Panel
    Friend WithEvents label_title_level As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents button_branch_new As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents combobox_branch_province As System.Windows.Forms.ComboBox
    Friend WithEvents textbox_branch_district As System.Windows.Forms.TextBox
    Friend WithEvents textbox_branch_postcode As System.Windows.Forms.TextBox
    Friend WithEvents textbox_branch_subdistrict As System.Windows.Forms.TextBox
    Friend WithEvents textbox_branch_address As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents textbox_branch_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textbox_branch_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textbox_branch_taxid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
