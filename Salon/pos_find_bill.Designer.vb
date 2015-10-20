<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos_find_bill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos_find_bill))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_search = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvtItem = New System.Windows.Forms.ListView()
        Me.listview_code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_product_desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_emp_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_discount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_grandtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panel_control = New System.Windows.Forms.Panel()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.panel_header.SuspendLayout()
        Me.panel_control.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_header.Controls.Add(Me.Label1)
        Me.panel_header.Controls.Add(Me.button_search)
        Me.panel_header.Controls.Add(Me.txtSearch)
        Me.panel_header.Location = New System.Drawing.Point(0, -2)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(865, 60)
        Me.panel_header.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select Bill"
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
        Me.button_search.Location = New System.Drawing.Point(436, 14)
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
        Me.txtSearch.Location = New System.Drawing.Point(192, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(243, 32)
        Me.txtSearch.TabIndex = 0
        '
        'lvtItem
        '
        Me.lvtItem.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lvtItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvtItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.listview_code, Me.listview_product_desc, Me.listview_emp_name, Me.listview_customer, Me.listview_total, Me.listview_discount, Me.listview_grandtotal})
        Me.lvtItem.FullRowSelect = True
        Me.lvtItem.Location = New System.Drawing.Point(0, 64)
        Me.lvtItem.MultiSelect = False
        Me.lvtItem.Name = "lvtItem"
        Me.lvtItem.Size = New System.Drawing.Size(853, 272)
        Me.lvtItem.TabIndex = 20
        Me.lvtItem.UseCompatibleStateImageBehavior = False
        Me.lvtItem.View = System.Windows.Forms.View.Details
        '
        'listview_code
        '
        Me.listview_code.Text = "Bill No"
        Me.listview_code.Width = 100
        '
        'listview_product_desc
        '
        Me.listview_product_desc.Text = "Product"
        Me.listview_product_desc.Width = 120
        '
        'listview_emp_name
        '
        Me.listview_emp_name.Text = "Stylish"
        Me.listview_emp_name.Width = 160
        '
        'listview_customer
        '
        Me.listview_customer.Text = "Customer"
        Me.listview_customer.Width = 160
        '
        'listview_total
        '
        Me.listview_total.Text = "Total"
        Me.listview_total.Width = 90
        '
        'listview_discount
        '
        Me.listview_discount.Text = "Discount"
        Me.listview_discount.Width = 90
        '
        'listview_grandtotal
        '
        Me.listview_grandtotal.Text = "Grand Total"
        Me.listview_grandtotal.Width = 90
        '
        'panel_control
        '
        Me.panel_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_control.Controls.Add(Me.button_cancel)
        Me.panel_control.Controls.Add(Me.button_ok)
        Me.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_control.Location = New System.Drawing.Point(0, 333)
        Me.panel_control.Name = "panel_control"
        Me.panel_control.Size = New System.Drawing.Size(865, 60)
        Me.panel_control.TabIndex = 21
        '
        'button_cancel
        '
        Me.button_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_cancel.FlatAppearance.BorderSize = 0
        Me.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.ForeColor = System.Drawing.Color.White
        Me.button_cancel.Location = New System.Drawing.Point(416, 11)
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
        Me.button_ok.Location = New System.Drawing.Point(291, 11)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(119, 42)
        Me.button_ok.TabIndex = 9
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = False
        '
        'pos_find_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 393)
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.lvtItem)
        Me.Controls.Add(Me.panel_control)
        Me.Name = "pos_find_bill"
        Me.Text = "pos_find_bill"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_header As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents button_search As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lvtItem As System.Windows.Forms.ListView
    Public WithEvents listview_code As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_emp_name As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_customer As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_total As System.Windows.Forms.ColumnHeader
    Friend WithEvents panel_control As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_ok As System.Windows.Forms.Button
    Friend WithEvents listview_discount As System.Windows.Forms.ColumnHeader
    Friend WithEvents listview_grandtotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents listview_product_desc As System.Windows.Forms.ColumnHeader
End Class
