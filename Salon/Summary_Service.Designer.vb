<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary_Service
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Summary_Service))
        Me.lvtSaleDetail = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvtSale = New System.Windows.Forms.ListView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvtSalePayment = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCustomerData = New System.Windows.Forms.Label()
        Me.button_search = New System.Windows.Forms.Button()
        Me.f = New System.Windows.Forms.SaveFileDialog()
        Me.button_edit = New System.Windows.Forms.Button()
        Me.lvtProductCAT = New System.Windows.Forms.ListView()
        Me.header_information = New Salon.user_control_home_button()
        Me.dtpStop = New Salon.MyDateTimePicker()
        Me.dtpStart = New Salon.MyDateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvtSaleDetail
        '
        Me.lvtSaleDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lvtSaleDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvtSaleDetail.FullRowSelect = True
        Me.lvtSaleDetail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvtSaleDetail.Location = New System.Drawing.Point(3, 3)
        Me.lvtSaleDetail.Name = "lvtSaleDetail"
        Me.lvtSaleDetail.Size = New System.Drawing.Size(1294, 291)
        Me.lvtSaleDetail.TabIndex = 13
        Me.lvtSaleDetail.UseCompatibleStateImageBehavior = False
        Me.lvtSaleDetail.View = System.Windows.Forms.View.Details
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
        Me.Label1.Size = New System.Drawing.Size(325, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "       Summary Service"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lvtProductCAT)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 539)
        Me.Panel1.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 176)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1333, 320)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvtSale)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1325, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sale"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvtSale
        '
        Me.lvtSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lvtSale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvtSale.FullRowSelect = True
        Me.lvtSale.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvtSale.Location = New System.Drawing.Point(3, 3)
        Me.lvtSale.Name = "lvtSale"
        Me.lvtSale.Size = New System.Drawing.Size(1294, 291)
        Me.lvtSale.TabIndex = 14
        Me.lvtSale.UseCompatibleStateImageBehavior = False
        Me.lvtSale.View = System.Windows.Forms.View.Details
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvtSaleDetail)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1325, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sale Detail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvtSalePayment)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1325, 294)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sale Payment"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvtSalePayment
        '
        Me.lvtSalePayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lvtSalePayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvtSalePayment.FullRowSelect = True
        Me.lvtSalePayment.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvtSalePayment.Location = New System.Drawing.Point(3, 3)
        Me.lvtSalePayment.Name = "lvtSalePayment"
        Me.lvtSalePayment.Size = New System.Drawing.Size(1294, 288)
        Me.lvtSalePayment.TabIndex = 14
        Me.lvtSalePayment.UseCompatibleStateImageBehavior = False
        Me.lvtSalePayment.View = System.Windows.Forms.View.Details
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(365, 142)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(0, 75)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1366, 50)
        Me.Panel3.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.dtpStop)
        Me.Panel4.Controls.Add(Me.lblCustomerData)
        Me.Panel4.Controls.Add(Me.dtpStart)
        Me.Panel4.Controls.Add(Me.button_search)
        Me.Panel4.Location = New System.Drawing.Point(20, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(448, 36)
        Me.Panel4.TabIndex = 18
        '
        'lblCustomerData
        '
        Me.lblCustomerData.AutoSize = True
        Me.lblCustomerData.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerData.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerData.Location = New System.Drawing.Point(187, 7)
        Me.lblCustomerData.Name = "lblCustomerData"
        Me.lblCustomerData.Size = New System.Drawing.Size(33, 25)
        Me.lblCustomerData.TabIndex = 16
        Me.lblCustomerData.Text = "To"
        Me.lblCustomerData.Visible = False
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
        Me.button_search.Location = New System.Drawing.Point(410, 3)
        Me.button_search.Name = "button_search"
        Me.button_search.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_search.Size = New System.Drawing.Size(28, 28)
        Me.button_search.TabIndex = 12
        Me.button_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_search.UseVisualStyleBackColor = False
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
        Me.button_edit.Location = New System.Drawing.Point(8, 686)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.button_edit.Size = New System.Drawing.Size(172, 36)
        Me.button_edit.TabIndex = 25
        Me.button_edit.Text = "Export to excel"
        Me.button_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_edit.UseVisualStyleBackColor = False
        '
        'lvtProductCAT
        '
        Me.lvtProductCAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lvtProductCAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvtProductCAT.FullRowSelect = True
        Me.lvtProductCAT.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvtProductCAT.Location = New System.Drawing.Point(453, -1)
        Me.lvtProductCAT.Name = "lvtProductCAT"
        Me.lvtProductCAT.Size = New System.Drawing.Size(365, 142)
        Me.lvtProductCAT.TabIndex = 16
        Me.lvtProductCAT.UseCompatibleStateImageBehavior = False
        Me.lvtProductCAT.View = System.Windows.Forms.View.Details
        '
        'header_information
        '
        Me.header_information.AutoSize = True
        Me.header_information.Location = New System.Drawing.Point(1000, 0)
        Me.header_information.Name = "header_information"
        Me.header_information.Size = New System.Drawing.Size(353, 70)
        Me.header_information.TabIndex = 19
        '
        'dtpStop
        '
        Me.dtpStop.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpStop.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpStop.Location = New System.Drawing.Point(226, 4)
        Me.dtpStop.Name = "dtpStop"
        Me.dtpStop.Size = New System.Drawing.Size(178, 29)
        Me.dtpStop.TabIndex = 23
        Me.dtpStop.Value = New Date(2015, 3, 26, 12, 18, 32, 680)
        '
        'dtpStart
        '
        Me.dtpStart.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpStart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpStart.Location = New System.Drawing.Point(3, 4)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(178, 29)
        Me.dtpStart.TabIndex = 22
        Me.dtpStart.Value = New Date(2015, 3, 26, 12, 18, 32, 680)
        '
        'Summary_Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.button_edit)
        Me.Controls.Add(Me.header_information)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "Summary_Service"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Service"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvtSaleDetail As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents header_information As Salon.user_control_home_button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents button_search As System.Windows.Forms.Button
    Friend WithEvents dtpStart As Salon.MyDateTimePicker
    Friend WithEvents f As System.Windows.Forms.SaveFileDialog
    Friend WithEvents button_edit As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dtpStop As Salon.MyDateTimePicker
    Friend WithEvents lblCustomerData As System.Windows.Forms.Label
    Friend WithEvents lvtSale As System.Windows.Forms.ListView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lvtSalePayment As System.Windows.Forms.ListView
    Friend WithEvents lvtProductCAT As System.Windows.Forms.ListView
End Class
