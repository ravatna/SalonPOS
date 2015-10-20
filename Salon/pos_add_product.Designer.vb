<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos_add_product
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos_add_product))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button_search = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.panel_control = New System.Windows.Forms.Panel()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.txtQTY = New Salon.IDN_NumericTextbox()
        Me.panel_discount = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDisPercent = New Salon.IDN_NumericTextbox()
        Me.txtdisBath = New Salon.IDN_NumericTextbox()
        Me.txtPrice = New Salon.IDN_NumericTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCustomerType = New System.Windows.Forms.ComboBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.lblCustomerData = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboStylist = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnitTitle = New System.Windows.Forms.Label()
        Me.LvtProductType = New System.Windows.Forms.ListView()
        Me.listview_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_instock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lvtItem = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3.SuspendLayout()
        Me.panel_control.SuspendLayout()
        Me.panel_discount.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.button_search)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(559, 60)
        Me.Panel3.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select a Product"
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
        Me.button_search.Location = New System.Drawing.Point(514, 14)
        Me.button_search.Name = "button_search"
        Me.button_search.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_search.Size = New System.Drawing.Size(32, 32)
        Me.button_search.TabIndex = 4
        Me.button_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_search.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(210, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(303, 32)
        Me.txtSearch.TabIndex = 0
        '
        'panel_control
        '
        Me.panel_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_control.Controls.Add(Me.button_cancel)
        Me.panel_control.Controls.Add(Me.button_ok)
        Me.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_control.Location = New System.Drawing.Point(0, 571)
        Me.panel_control.Name = "panel_control"
        Me.panel_control.Size = New System.Drawing.Size(559, 60)
        Me.panel_control.TabIndex = 13
        '
        'button_cancel
        '
        Me.button_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_cancel.FlatAppearance.BorderSize = 0
        Me.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.ForeColor = System.Drawing.Color.White
        Me.button_cancel.Location = New System.Drawing.Point(282, 9)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(120, 42)
        Me.button_cancel.TabIndex = 8
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = False
        '
        'button_ok
        '
        Me.button_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_ok.FlatAppearance.BorderSize = 0
        Me.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_ok.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ok.ForeColor = System.Drawing.Color.White
        Me.button_ok.Location = New System.Drawing.Point(157, 9)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(119, 42)
        Me.button_ok.TabIndex = 9
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = False
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(418, 130)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(72, 35)
        Me.txtQTY.TabIndex = 29
        '
        'panel_discount
        '
        Me.panel_discount.Controls.Add(Me.Label9)
        Me.panel_discount.Controls.Add(Me.Label8)
        Me.panel_discount.Controls.Add(Me.lblNet)
        Me.panel_discount.Controls.Add(Me.Label6)
        Me.panel_discount.Controls.Add(Me.Label4)
        Me.panel_discount.Controls.Add(Me.Label11)
        Me.panel_discount.Controls.Add(Me.txtDisPercent)
        Me.panel_discount.Controls.Add(Me.txtdisBath)
        Me.panel_discount.Controls.Add(Me.txtPrice)
        Me.panel_discount.Controls.Add(Me.Label10)
        Me.panel_discount.Controls.Add(Me.cboCustomerType)
        Me.panel_discount.Controls.Add(Me.btnCustomer)
        Me.panel_discount.Controls.Add(Me.lblCustomerData)
        Me.panel_discount.Controls.Add(Me.Label7)
        Me.panel_discount.Controls.Add(Me.Label5)
        Me.panel_discount.Controls.Add(Me.cboStylist)
        Me.panel_discount.Controls.Add(Me.Label3)
        Me.panel_discount.Controls.Add(Me.txtUnitTitle)
        Me.panel_discount.Controls.Add(Me.txtQTY)
        Me.panel_discount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_discount.Location = New System.Drawing.Point(0, 309)
        Me.panel_discount.Name = "panel_discount"
        Me.panel_discount.Size = New System.Drawing.Size(559, 262)
        Me.panel_discount.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(93, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 25)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(304, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 25)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "%"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Black
        Me.lblNet.Location = New System.Drawing.Point(157, 218)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(22, 25)
        Me.lblNet.TabIndex = 73
        Me.lblNet.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(496, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 25)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "THB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(58, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Discount:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(56, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 25)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Full Price:"
        '
        'txtDisPercent
        '
        Me.txtDisPercent.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisPercent.Location = New System.Drawing.Point(157, 171)
        Me.txtDisPercent.Name = "txtDisPercent"
        Me.txtDisPercent.Size = New System.Drawing.Size(141, 35)
        Me.txtDisPercent.TabIndex = 68
        '
        'txtdisBath
        '
        Me.txtdisBath.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisBath.Location = New System.Drawing.Point(349, 171)
        Me.txtdisBath.Name = "txtdisBath"
        Me.txtdisBath.Size = New System.Drawing.Size(141, 35)
        Me.txtdisBath.TabIndex = 69
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(157, 130)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(141, 35)
        Me.txtPrice.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 21)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Customer Type*:"
        '
        'cboCustomerType
        '
        Me.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboCustomerType.ForeColor = System.Drawing.Color.Black
        Me.cboCustomerType.FormattingEnabled = True
        Me.cboCustomerType.Items.AddRange(New Object() {"Appoint", "New", "New free", "Free"})
        Me.cboCustomerType.Location = New System.Drawing.Point(157, 95)
        Me.cboCustomerType.Name = "cboCustomerType"
        Me.cboCustomerType.Size = New System.Drawing.Size(180, 29)
        Me.cboCustomerType.TabIndex = 66
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Location = New System.Drawing.Point(155, 53)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(37, 37)
        Me.btnCustomer.TabIndex = 64
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'lblCustomerData
        '
        Me.lblCustomerData.AutoSize = True
        Me.lblCustomerData.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerData.ForeColor = System.Drawing.Color.Blue
        Me.lblCustomerData.Location = New System.Drawing.Point(206, 58)
        Me.lblCustomerData.Name = "lblCustomerData"
        Me.lblCustomerData.Size = New System.Drawing.Size(0, 21)
        Me.lblCustomerData.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(44, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 25)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Customer*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(76, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 25)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Stylist*:"
        '
        'cboStylist
        '
        Me.cboStylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStylist.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboStylist.ForeColor = System.Drawing.Color.Black
        Me.cboStylist.FormattingEnabled = True
        Me.cboStylist.Location = New System.Drawing.Point(155, 9)
        Me.cboStylist.Name = "cboStylist"
        Me.cboStylist.Size = New System.Drawing.Size(336, 29)
        Me.cboStylist.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(320, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Quantity:"
        '
        'txtUnitTitle
        '
        Me.txtUnitTitle.AutoSize = True
        Me.txtUnitTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitTitle.ForeColor = System.Drawing.Color.Black
        Me.txtUnitTitle.Location = New System.Drawing.Point(496, 135)
        Me.txtUnitTitle.Name = "txtUnitTitle"
        Me.txtUnitTitle.Size = New System.Drawing.Size(47, 25)
        Me.txtUnitTitle.TabIndex = 32
        Me.txtUnitTitle.Text = "Unit"
        '
        'LvtProductType
        '
        Me.LvtProductType.BackColor = System.Drawing.Color.White
        Me.LvtProductType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvtProductType.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.listview_no, Me.listview_code, Me.listview_type, Me.listview_title, Me.listview_brand, Me.listview_price, Me.listview_instock})
        Me.LvtProductType.LargeImageList = Me.ImageList1
        Me.LvtProductType.Location = New System.Drawing.Point(0, 66)
        Me.LvtProductType.MultiSelect = False
        Me.LvtProductType.Name = "LvtProductType"
        Me.LvtProductType.Size = New System.Drawing.Size(559, 90)
        Me.LvtProductType.TabIndex = 35
        Me.LvtProductType.UseCompatibleStateImageBehavior = False
        '
        'listview_no
        '
        Me.listview_no.Text = "No"
        '
        'listview_code
        '
        Me.listview_code.Text = "Code"
        '
        'listview_type
        '
        Me.listview_type.Text = "Type"
        '
        'listview_title
        '
        Me.listview_title.Text = "Title"
        '
        'listview_brand
        '
        Me.listview_brand.Text = "Brand"
        '
        'listview_price
        '
        Me.listview_price.Text = "Price"
        '
        'listview_instock
        '
        Me.listview_instock.Text = "In Stock"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "edit_cut.png")
        Me.ImageList1.Images.SetKeyName(1, "water_bottle.png")
        '
        'lvtItem
        '
        Me.lvtItem.BackColor = System.Drawing.Color.White
        Me.lvtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvtItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvtItem.LargeImageList = Me.ImageList1
        Me.lvtItem.Location = New System.Drawing.Point(0, 162)
        Me.lvtItem.MultiSelect = False
        Me.lvtItem.Name = "lvtItem"
        Me.lvtItem.Size = New System.Drawing.Size(559, 141)
        Me.lvtItem.TabIndex = 36
        Me.lvtItem.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Code"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Title"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Brand"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Price"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "In Stock"
        '
        'pos_add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(559, 631)
        Me.Controls.Add(Me.lvtItem)
        Me.Controls.Add(Me.LvtProductType)
        Me.Controls.Add(Me.panel_discount)
        Me.Controls.Add(Me.panel_control)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pos_add_product"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Product"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panel_control.ResumeLayout(False)
        Me.panel_discount.ResumeLayout(False)
        Me.panel_discount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents button_search As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents panel_control As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_ok As System.Windows.Forms.Button
    Friend WithEvents txtQTY As Salon.IDN_NumericTextbox
    Friend WithEvents panel_discount As System.Windows.Forms.Panel
    Friend WithEvents LvtProductType As System.Windows.Forms.ListView
    Public WithEvents listview_no As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_code As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_type As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_title As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_brand As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_price As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_instock As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvtItem As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtUnitTitle As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCustomerType As System.Windows.Forms.ComboBox
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents lblCustomerData As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboStylist As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDisPercent As Salon.IDN_NumericTextbox
    Friend WithEvents txtdisBath As Salon.IDN_NumericTextbox
    Friend WithEvents txtPrice As Salon.IDN_NumericTextbox
End Class
