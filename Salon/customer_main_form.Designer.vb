<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_main_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_main_form))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lvtItem = New System.Windows.Forms.ListView()
        Me.column_customer_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_NickName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_mobile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_mail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_CreateDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button_edit = New System.Windows.Forms.Button()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.panel_customer = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.pnlWay = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkFriend = New System.Windows.Forms.CheckBox()
        Me.chkWalkin = New System.Windows.Forms.CheckBox()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.chkMagazine = New System.Windows.Forms.CheckBox()
        Me.chkFamily = New System.Windows.Forms.CheckBox()
        Me.chkInstagram = New System.Windows.Forms.CheckBox()
        Me.chkWebsite = New System.Windows.Forms.CheckBox()
        Me.chkFacebook = New System.Windows.Forms.CheckBox()
        Me.chkOtherWebsite = New System.Windows.Forms.CheckBox()
        Me.txtSubDistinct = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.txtDistinct = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNickName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.button_proceed = New System.Windows.Forms.Button()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.button_show_all = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.button_search = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.button_new_customer = New System.Windows.Forms.Button()
        Me.header_information = New Salon.user_control_home_button()
        Me.txt_tax_id = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panel_customer.SuspendLayout()
        Me.pnlWay.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(504, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(49, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Title:"
        '
        'lvtItem
        '
        Me.lvtItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lvtItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvtItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_customer_id, Me.column_name, Me.Column_NickName, Me.column_mobile, Me.column_mail, Me.Column_CreateDateTime})
        Me.lvtItem.FullRowSelect = True
        Me.lvtItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvtItem.Location = New System.Drawing.Point(20, 1)
        Me.lvtItem.Name = "lvtItem"
        Me.lvtItem.Size = New System.Drawing.Size(1334, 155)
        Me.lvtItem.TabIndex = 13
        Me.lvtItem.UseCompatibleStateImageBehavior = False
        Me.lvtItem.View = System.Windows.Forms.View.Details
        '
        'column_customer_id
        '
        Me.column_customer_id.Text = "Customer ID"
        Me.column_customer_id.Width = 90
        '
        'column_name
        '
        Me.column_name.Text = "Name & LastName"
        Me.column_name.Width = 199
        '
        'Column_NickName
        '
        Me.Column_NickName.Text = "NickName"
        Me.Column_NickName.Width = 150
        '
        'column_mobile
        '
        Me.column_mobile.Text = "Mobile"
        Me.column_mobile.Width = 121
        '
        'column_mail
        '
        Me.column_mail.Text = "E-Mail"
        Me.column_mail.Width = 120
        '
        'Column_CreateDateTime
        '
        Me.Column_CreateDateTime.Text = "Created DateTime"
        Me.Column_CreateDateTime.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "       Customer and Member"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lvtItem)
        Me.Panel1.Controls.Add(Me.button_edit)
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 210)
        Me.Panel1.TabIndex = 15
        '
        'button_edit
        '
        Me.button_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_edit.BackgroundImage = CType(resources.GetObject("button_edit.BackgroundImage"), System.Drawing.Image)
        Me.button_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_edit.FlatAppearance.BorderSize = 0
        Me.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_edit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button_edit.ForeColor = System.Drawing.Color.White
        Me.button_edit.Location = New System.Drawing.Point(20, 162)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_edit.Size = New System.Drawing.Size(90, 36)
        Me.button_edit.TabIndex = 24
        Me.button_edit.Text = "Edit"
        Me.button_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_edit.UseVisualStyleBackColor = False
        Me.button_edit.Visible = False
        '
        'cboTitle
        '
        Me.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboTitle.ForeColor = System.Drawing.Color.Black
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"<-Select->", "คุณ", "นาง", "นางสาว", "นาย"})
        Me.cboTitle.Location = New System.Drawing.Point(97, 57)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(82, 29)
        Me.cboTitle.TabIndex = 16
        '
        'panel_customer
        '
        Me.panel_customer.BackColor = System.Drawing.Color.Transparent
        Me.panel_customer.Controls.Add(Me.txt_tax_id)
        Me.panel_customer.Controls.Add(Me.Label18)
        Me.panel_customer.Controls.Add(Me.Label17)
        Me.panel_customer.Controls.Add(Me.cboCountry)
        Me.panel_customer.Controls.Add(Me.cboMonth)
        Me.panel_customer.Controls.Add(Me.Label3)
        Me.panel_customer.Controls.Add(Me.cboDay)
        Me.panel_customer.Controls.Add(Me.pnlWay)
        Me.panel_customer.Controls.Add(Me.txtSubDistinct)
        Me.panel_customer.Controls.Add(Me.txtAddress)
        Me.panel_customer.Controls.Add(Me.cboProvince)
        Me.panel_customer.Controls.Add(Me.txtDistinct)
        Me.panel_customer.Controls.Add(Me.txtZipCode)
        Me.panel_customer.Controls.Add(Me.Label15)
        Me.panel_customer.Controls.Add(Me.Label14)
        Me.panel_customer.Controls.Add(Me.Label11)
        Me.panel_customer.Controls.Add(Me.txtEmail)
        Me.panel_customer.Controls.Add(Me.Label2)
        Me.panel_customer.Controls.Add(Me.Label10)
        Me.panel_customer.Controls.Add(Me.txtPhone)
        Me.panel_customer.Controls.Add(Me.Label13)
        Me.panel_customer.Controls.Add(Me.Label9)
        Me.panel_customer.Controls.Add(Me.Label8)
        Me.panel_customer.Controls.Add(Me.Label7)
        Me.panel_customer.Controls.Add(Me.Button6)
        Me.panel_customer.Controls.Add(Me.txtName)
        Me.panel_customer.Controls.Add(Me.txtCode)
        Me.panel_customer.Controls.Add(Me.Label12)
        Me.panel_customer.Controls.Add(Me.Label5)
        Me.panel_customer.Controls.Add(Me.Label4)
        Me.panel_customer.Controls.Add(Me.txtNickName)
        Me.panel_customer.Controls.Add(Me.Label6)
        Me.panel_customer.Controls.Add(Me.cboTitle)
        Me.panel_customer.Location = New System.Drawing.Point(20, 356)
        Me.panel_customer.Name = "panel_customer"
        Me.panel_customer.Size = New System.Drawing.Size(1326, 297)
        Me.panel_customer.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(474, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 21)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Country:"
        '
        'cboCountry
        '
        Me.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCountry.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboCountry.ForeColor = System.Drawing.Color.Black
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(553, 134)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(165, 29)
        Me.cboCountry.TabIndex = 42
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Enabled = False
        Me.cboMonth.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboMonth.ForeColor = System.Drawing.Color.Black
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(1202, 58)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(105, 29)
        Me.cboMonth.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1127, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "/ Month:"
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.Enabled = False
        Me.cboDay.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboDay.ForeColor = System.Drawing.Color.Black
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboDay.Location = New System.Drawing.Point(1059, 58)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(50, 29)
        Me.cboDay.TabIndex = 39
        '
        'pnlWay
        '
        Me.pnlWay.Controls.Add(Me.Label16)
        Me.pnlWay.Controls.Add(Me.chkFriend)
        Me.pnlWay.Controls.Add(Me.chkWalkin)
        Me.pnlWay.Controls.Add(Me.txtOther)
        Me.pnlWay.Controls.Add(Me.chkMagazine)
        Me.pnlWay.Controls.Add(Me.chkFamily)
        Me.pnlWay.Controls.Add(Me.chkInstagram)
        Me.pnlWay.Controls.Add(Me.chkWebsite)
        Me.pnlWay.Controls.Add(Me.chkFacebook)
        Me.pnlWay.Controls.Add(Me.chkOtherWebsite)
        Me.pnlWay.Enabled = False
        Me.pnlWay.Location = New System.Drawing.Point(97, 215)
        Me.pnlWay.Name = "pnlWay"
        Me.pnlWay.Size = New System.Drawing.Size(900, 73)
        Me.pnlWay.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(554, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 21)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Other:"
        '
        'chkFriend
        '
        Me.chkFriend.AutoSize = True
        Me.chkFriend.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkFriend.Location = New System.Drawing.Point(127, 3)
        Me.chkFriend.Name = "chkFriend"
        Me.chkFriend.Size = New System.Drawing.Size(73, 25)
        Me.chkFriend.TabIndex = 41
        Me.chkFriend.Text = "Friend"
        Me.chkFriend.UseVisualStyleBackColor = True
        '
        'chkWalkin
        '
        Me.chkWalkin.AutoSize = True
        Me.chkWalkin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkWalkin.Location = New System.Drawing.Point(405, 29)
        Me.chkWalkin.Name = "chkWalkin"
        Me.chkWalkin.Size = New System.Drawing.Size(81, 25)
        Me.chkWalkin.TabIndex = 47
        Me.chkWalkin.Text = "Walk in"
        Me.chkWalkin.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        Me.txtOther.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtOther.ForeColor = System.Drawing.Color.Black
        Me.txtOther.Location = New System.Drawing.Point(613, 27)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(256, 29)
        Me.txtOther.TabIndex = 28
        '
        'chkMagazine
        '
        Me.chkMagazine.AutoSize = True
        Me.chkMagazine.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkMagazine.Location = New System.Drawing.Point(250, 29)
        Me.chkMagazine.Name = "chkMagazine"
        Me.chkMagazine.Size = New System.Drawing.Size(96, 25)
        Me.chkMagazine.TabIndex = 46
        Me.chkMagazine.Text = "Magazine"
        Me.chkMagazine.UseVisualStyleBackColor = True
        '
        'chkFamily
        '
        Me.chkFamily.AutoSize = True
        Me.chkFamily.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkFamily.Location = New System.Drawing.Point(0, 3)
        Me.chkFamily.Name = "chkFamily"
        Me.chkFamily.Size = New System.Drawing.Size(75, 25)
        Me.chkFamily.TabIndex = 40
        Me.chkFamily.Text = "Family"
        Me.chkFamily.UseVisualStyleBackColor = True
        '
        'chkInstagram
        '
        Me.chkInstagram.AutoSize = True
        Me.chkInstagram.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkInstagram.Location = New System.Drawing.Point(127, 29)
        Me.chkInstagram.Name = "chkInstagram"
        Me.chkInstagram.Size = New System.Drawing.Size(99, 25)
        Me.chkInstagram.TabIndex = 45
        Me.chkInstagram.Text = "Instagram"
        Me.chkInstagram.UseVisualStyleBackColor = True
        '
        'chkWebsite
        '
        Me.chkWebsite.AutoSize = True
        Me.chkWebsite.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkWebsite.Location = New System.Drawing.Point(250, 3)
        Me.chkWebsite.Name = "chkWebsite"
        Me.chkWebsite.Size = New System.Drawing.Size(136, 25)
        Me.chkWebsite.TabIndex = 42
        Me.chkWebsite.Text = "Rikyu's website"
        Me.chkWebsite.UseVisualStyleBackColor = True
        '
        'chkFacebook
        '
        Me.chkFacebook.AutoSize = True
        Me.chkFacebook.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkFacebook.Location = New System.Drawing.Point(0, 29)
        Me.chkFacebook.Name = "chkFacebook"
        Me.chkFacebook.Size = New System.Drawing.Size(95, 25)
        Me.chkFacebook.TabIndex = 44
        Me.chkFacebook.Text = "Facebook"
        Me.chkFacebook.UseVisualStyleBackColor = True
        '
        'chkOtherWebsite
        '
        Me.chkOtherWebsite.AutoSize = True
        Me.chkOtherWebsite.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkOtherWebsite.Location = New System.Drawing.Point(405, 3)
        Me.chkOtherWebsite.Name = "chkOtherWebsite"
        Me.chkOtherWebsite.Size = New System.Drawing.Size(126, 25)
        Me.chkOtherWebsite.TabIndex = 43
        Me.chkOtherWebsite.Text = "Other website"
        Me.chkOtherWebsite.UseVisualStyleBackColor = True
        '
        'txtSubDistinct
        '
        Me.txtSubDistinct.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSubDistinct.ForeColor = System.Drawing.Color.Black
        Me.txtSubDistinct.Location = New System.Drawing.Point(565, 96)
        Me.txtSubDistinct.Name = "txtSubDistinct"
        Me.txtSubDistinct.ReadOnly = True
        Me.txtSubDistinct.Size = New System.Drawing.Size(153, 29)
        Me.txtSubDistinct.TabIndex = 38
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(97, 96)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(356, 29)
        Me.txtAddress.TabIndex = 24
        '
        'cboProvince
        '
        Me.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvince.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboProvince.ForeColor = System.Drawing.Color.Black
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(97, 135)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(165, 29)
        Me.cboProvince.TabIndex = 37
        '
        'txtDistinct
        '
        Me.txtDistinct.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDistinct.ForeColor = System.Drawing.Color.Black
        Me.txtDistinct.Location = New System.Drawing.Point(813, 96)
        Me.txtDistinct.Name = "txtDistinct"
        Me.txtDistinct.ReadOnly = True
        Me.txtDistinct.Size = New System.Drawing.Size(153, 29)
        Me.txtDistinct.TabIndex = 25
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtZipCode.ForeColor = System.Drawing.Color.Black
        Me.txtZipCode.Location = New System.Drawing.Point(354, 135)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.ReadOnly = True
        Me.txtZipCode.Size = New System.Drawing.Size(99, 29)
        Me.txtZipCode.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(747, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 21)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Mobile:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(22, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 21)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Province:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1005, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 21)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(1062, 134)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(155, 29)
        Me.txtEmail.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "How do you know about us?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(976, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 21)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Birth Day:"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.Location = New System.Drawing.Point(814, 134)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(155, 29)
        Me.txtPhone.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(268, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Post Code:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(735, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 21)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Amphoe:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(466, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Sub District:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Address:"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(224, 304)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(104, 36)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Save"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(565, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(401, 29)
        Me.txtName.TabIndex = 23
        '
        'txtCode
        '
        Me.txtCode.AutoEllipsis = True
        Me.txtCode.AutoSize = True
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(127, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(112, 25)
        Me.txtCode.TabIndex = 22
        Me.txtCode.Text = "1000059832"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 25)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Customer id:"
        '
        'txtNickName
        '
        Me.txtNickName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNickName.ForeColor = System.Drawing.Color.Black
        Me.txtNickName.Location = New System.Drawing.Point(280, 57)
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.ReadOnly = True
        Me.txtNickName.Size = New System.Drawing.Size(173, 29)
        Me.txtNickName.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(188, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "NickName:"
        '
        'button_proceed
        '
        Me.button_proceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_proceed.BackgroundImage = CType(resources.GetObject("button_proceed.BackgroundImage"), System.Drawing.Image)
        Me.button_proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_proceed.FlatAppearance.BorderSize = 0
        Me.button_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_proceed.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_proceed.ForeColor = System.Drawing.Color.White
        Me.button_proceed.Location = New System.Drawing.Point(20, 699)
        Me.button_proceed.Name = "button_proceed"
        Me.button_proceed.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_proceed.Size = New System.Drawing.Size(200, 42)
        Me.button_proceed.TabIndex = 17
        Me.button_proceed.Text = "Save Change"
        Me.button_proceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_proceed.UseVisualStyleBackColor = False
        Me.button_proceed.Visible = False
        '
        'button_cancel
        '
        Me.button_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_cancel.BackgroundImage = CType(resources.GetObject("button_cancel.BackgroundImage"), System.Drawing.Image)
        Me.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_cancel.FlatAppearance.BorderSize = 0
        Me.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.ForeColor = System.Drawing.Color.White
        Me.button_cancel.Location = New System.Drawing.Point(226, 699)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_cancel.Size = New System.Drawing.Size(145, 42)
        Me.button_cancel.TabIndex = 17
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_cancel.UseVisualStyleBackColor = False
        Me.button_cancel.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(15, 666)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(386, 25)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Member ID 542301 has been updated/create"
        Me.Label19.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblError.Location = New System.Drawing.Point(407, 666)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(212, 25)
        Me.lblError.TabIndex = 12
        Me.lblError.Text = "Error Color/Invarid data"
        Me.lblError.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel3.Controls.Add(Me.button_show_all)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.button_new_customer)
        Me.Panel3.Location = New System.Drawing.Point(0, 75)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1366, 50)
        Me.Panel3.TabIndex = 14
        '
        'button_show_all
        '
        Me.button_show_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_show_all.BackgroundImage = CType(resources.GetObject("button_show_all.BackgroundImage"), System.Drawing.Image)
        Me.button_show_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_show_all.FlatAppearance.BorderSize = 0
        Me.button_show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_show_all.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button_show_all.ForeColor = System.Drawing.Color.White
        Me.button_show_all.Location = New System.Drawing.Point(345, 7)
        Me.button_show_all.Name = "button_show_all"
        Me.button_show_all.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_show_all.Size = New System.Drawing.Size(131, 36)
        Me.button_show_all.TabIndex = 17
        Me.button_show_all.Text = "Show All"
        Me.button_show_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_show_all.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.button_search)
        Me.Panel4.Controls.Add(Me.txtSearch)
        Me.Panel4.Location = New System.Drawing.Point(20, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 36)
        Me.Panel4.TabIndex = 18
        '
        'button_search
        '
        Me.button_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_search.BackgroundImage = CType(resources.GetObject("button_search.BackgroundImage"), System.Drawing.Image)
        Me.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_search.FlatAppearance.BorderSize = 0
        Me.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_search.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_search.ForeColor = System.Drawing.Color.White
        Me.button_search.Location = New System.Drawing.Point(278, 4)
        Me.button_search.Name = "button_search"
        Me.button_search.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_search.Size = New System.Drawing.Size(28, 28)
        Me.button_search.TabIndex = 12
        Me.button_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_search.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(7, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 28)
        Me.txtSearch.TabIndex = 0
        '
        'button_new_customer
        '
        Me.button_new_customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_new_customer.BackgroundImage = CType(resources.GetObject("button_new_customer.BackgroundImage"), System.Drawing.Image)
        Me.button_new_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_new_customer.FlatAppearance.BorderSize = 0
        Me.button_new_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_new_customer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_new_customer.ForeColor = System.Drawing.Color.White
        Me.button_new_customer.Location = New System.Drawing.Point(1197, 7)
        Me.button_new_customer.Name = "button_new_customer"
        Me.button_new_customer.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_new_customer.Size = New System.Drawing.Size(161, 36)
        Me.button_new_customer.TabIndex = 17
        Me.button_new_customer.Text = "New Customer"
        Me.button_new_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_new_customer.UseVisualStyleBackColor = False
        '
        'header_information
        '
        Me.header_information.AutoSize = True
        Me.header_information.Location = New System.Drawing.Point(1000, 0)
        Me.header_information.Name = "header_information"
        Me.header_information.Size = New System.Drawing.Size(353, 70)
        Me.header_information.TabIndex = 19
        '
        'txt_tax_id
        '
        Me.txt_tax_id.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_tax_id.ForeColor = System.Drawing.Color.Black
        Me.txt_tax_id.Location = New System.Drawing.Point(1062, 9)
        Me.txt_tax_id.Name = "txt_tax_id"
        Me.txt_tax_id.ReadOnly = True
        Me.txt_tax_id.Size = New System.Drawing.Size(250, 29)
        Me.txt_tax_id.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(997, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 21)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "TAX ID:"
        '
        'customer_main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.header_information)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.button_proceed)
        Me.Controls.Add(Me.panel_customer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "customer_main_form"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Management"
        Me.Panel1.ResumeLayout(False)
        Me.panel_customer.ResumeLayout(False)
        Me.panel_customer.PerformLayout()
        Me.pnlWay.ResumeLayout(False)
        Me.pnlWay.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents column_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents column_mobile As System.Windows.Forms.ColumnHeader
    Friend WithEvents column_mail As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvtItem As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents panel_customer As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents column_customer_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents button_proceed As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents button_edit As System.Windows.Forms.Button
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents header_information As Salon.user_control_home_button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents button_show_all As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents button_search As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents button_new_customer As System.Windows.Forms.Button
    Friend WithEvents Column_NickName As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNickName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSubDistinct As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents txtDistinct As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkWalkin As System.Windows.Forms.CheckBox
    Friend WithEvents chkMagazine As System.Windows.Forms.CheckBox
    Friend WithEvents chkInstagram As System.Windows.Forms.CheckBox
    Friend WithEvents chkFacebook As System.Windows.Forms.CheckBox
    Friend WithEvents chkOtherWebsite As System.Windows.Forms.CheckBox
    Friend WithEvents chkWebsite As System.Windows.Forms.CheckBox
    Friend WithEvents chkFriend As System.Windows.Forms.CheckBox
    Friend WithEvents chkFamily As System.Windows.Forms.CheckBox
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlWay As System.Windows.Forms.Panel
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents Column_CreateDateTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tax_id As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
