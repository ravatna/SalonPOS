<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos_select_service
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos_select_service))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panel_control = New System.Windows.Forms.Panel()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.txtDisPercent = New Salon.IDN_NumericTextbox()
        Me.txtdisBath = New Salon.IDN_NumericTextbox()
        Me.txtPrice = New Salon.IDN_NumericTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboStylist = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.lblCustomerData = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCustomerType = New System.Windows.Forms.ComboBox()
        Me.panel_header.SuspendLayout()
        Me.panel_control.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_header.Controls.Add(Me.Label1)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(574, 60)
        Me.panel_header.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter the price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Full Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(53, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Discount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(67, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Service:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(408, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "THB"
        '
        'lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblServiceName.Location = New System.Drawing.Point(152, 183)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(95, 25)
        Me.lblServiceName.TabIndex = 23
        Me.lblServiceName.Text = "Hair wash"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(408, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 25)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "THB"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(253, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "%"
        '
        'panel_control
        '
        Me.panel_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_control.Controls.Add(Me.button_cancel)
        Me.panel_control.Controls.Add(Me.button_ok)
        Me.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_control.Location = New System.Drawing.Point(0, 339)
        Me.panel_control.Name = "panel_control"
        Me.panel_control.Size = New System.Drawing.Size(574, 60)
        Me.panel_control.TabIndex = 36
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(87, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 25)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Price:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Black
        Me.lblNet.Location = New System.Drawing.Point(147, 300)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(46, 25)
        Me.lblNet.TabIndex = 23
        Me.lblNet.Text = "0.00"
        '
        'txtDisPercent
        '
        Me.txtDisPercent.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisPercent.Location = New System.Drawing.Point(152, 256)
        Me.txtDisPercent.Name = "txtDisPercent"
        Me.txtDisPercent.Size = New System.Drawing.Size(95, 35)
        Me.txtDisPercent.TabIndex = 1
        '
        'txtdisBath
        '
        Me.txtdisBath.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisBath.Location = New System.Drawing.Point(287, 256)
        Me.txtdisBath.Name = "txtdisBath"
        Me.txtdisBath.Size = New System.Drawing.Size(115, 35)
        Me.txtdisBath.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(152, 217)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(250, 35)
        Me.txtPrice.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(71, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 25)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Stylist*:"
        '
        'cboStylist
        '
        Me.cboStylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStylist.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboStylist.ForeColor = System.Drawing.Color.Black
        Me.cboStylist.FormattingEnabled = True
        Me.cboStylist.Location = New System.Drawing.Point(150, 70)
        Me.cboStylist.Name = "cboStylist"
        Me.cboStylist.Size = New System.Drawing.Size(336, 29)
        Me.cboStylist.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(39, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 25)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Customer*:"
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Location = New System.Drawing.Point(148, 107)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(37, 37)
        Me.btnCustomer.TabIndex = 59
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'lblCustomerData
        '
        Me.lblCustomerData.AutoSize = True
        Me.lblCustomerData.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerData.ForeColor = System.Drawing.Color.Blue
        Me.lblCustomerData.Location = New System.Drawing.Point(199, 112)
        Me.lblCustomerData.Name = "lblCustomerData"
        Me.lblCustomerData.Size = New System.Drawing.Size(0, 21)
        Me.lblCustomerData.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 21)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Customer Type*:"
        '
        'cboCustomerType
        '
        Me.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboCustomerType.ForeColor = System.Drawing.Color.Black
        Me.cboCustomerType.FormattingEnabled = True
        Me.cboCustomerType.Items.AddRange(New Object() {"Appoint", "New", "New free", "Free"})
        Me.cboCustomerType.Location = New System.Drawing.Point(151, 151)
        Me.cboCustomerType.Name = "cboCustomerType"
        Me.cboCustomerType.Size = New System.Drawing.Size(180, 29)
        Me.cboCustomerType.TabIndex = 61
        '
        'pos_select_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 399)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboCustomerType)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.lblCustomerData)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboStylist)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.panel_control)
        Me.Controls.Add(Me.lblServiceName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDisPercent)
        Me.Controls.Add(Me.txtdisBath)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pos_select_service"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Service"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_control.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_header As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As Salon.IDN_NumericTextbox
    Friend WithEvents txtdisBath As Salon.IDN_NumericTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblServiceName As System.Windows.Forms.Label
    Friend WithEvents txtDisPercent As Salon.IDN_NumericTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents panel_control As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_ok As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboStylist As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents lblCustomerData As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCustomerType As System.Windows.Forms.ComboBox
End Class
