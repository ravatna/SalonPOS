<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblCustomerData = New System.Windows.Forms.Label()
        Me.button_search = New System.Windows.Forms.Button()
        Me.f = New System.Windows.Forms.SaveFileDialog()
        Me.button_edit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.header_information = New Salon.user_control_home_button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(248, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "       Export Data"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 539)
        Me.Panel1.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(624, 287)
        Me.DataGridView1.TabIndex = 0
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
        Me.Panel4.Controls.Add(Me.dtpEnd)
        Me.Panel4.Controls.Add(Me.dtpStart)
        Me.Panel4.Controls.Add(Me.lblCustomerData)
        Me.Panel4.Controls.Add(Me.button_search)
        Me.Panel4.Location = New System.Drawing.Point(20, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(872, 36)
        Me.Panel4.TabIndex = 18
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(336, 8)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 18
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(104, 8)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 17
        '
        'lblCustomerData
        '
        Me.lblCustomerData.AutoSize = True
        Me.lblCustomerData.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerData.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerData.Location = New System.Drawing.Point(12, 4)
        Me.lblCustomerData.Name = "lblCustomerData"
        Me.lblCustomerData.Size = New System.Drawing.Size(68, 25)
        Me.lblCustomerData.TabIndex = 16
        Me.lblCustomerData.Text = "Month"
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
        Me.button_search.Location = New System.Drawing.Point(841, 3)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(244, 686)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(172, 36)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Get Data"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'header_information
        '
        Me.header_information.AutoSize = True
        Me.header_information.Location = New System.Drawing.Point(1000, 0)
        Me.header_information.Name = "header_information"
        Me.header_information.Size = New System.Drawing.Size(353, 70)
        Me.header_information.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(507, 686)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(172, 36)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Get By Function"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ExportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.button_edit)
        Me.Controls.Add(Me.header_information)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "ExportData"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Service"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents header_information As Salon.user_control_home_button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents button_search As System.Windows.Forms.Button
    Friend WithEvents f As System.Windows.Forms.SaveFileDialog
    Friend WithEvents button_edit As System.Windows.Forms.Button
    Friend WithEvents lblCustomerData As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
