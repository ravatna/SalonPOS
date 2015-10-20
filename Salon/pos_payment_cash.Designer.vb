<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos_payment_cash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos_payment_cash))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_control = New System.Windows.Forms.Panel()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_reset = New System.Windows.Forms.Button()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.txtCash = New Salon.IDN_NumericTextbox()
        Me.button_cash_100 = New System.Windows.Forms.Button()
        Me.button_cash_20 = New System.Windows.Forms.Button()
        Me.button_cash_500 = New System.Windows.Forms.Button()
        Me.button_cash_1000 = New System.Windows.Forms.Button()
        Me.button_cash_50 = New System.Windows.Forms.Button()
        Me.txtSplitPaid = New Salon.IDN_NumericTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label1.Size = New System.Drawing.Size(265, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter cash recieve amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(247, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Recieved:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(476, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "THB"
        '
        'panel_control
        '
        Me.panel_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_control.Controls.Add(Me.button_cancel)
        Me.panel_control.Controls.Add(Me.button_reset)
        Me.panel_control.Controls.Add(Me.button_ok)
        Me.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_control.Location = New System.Drawing.Point(0, 201)
        Me.panel_control.Name = "panel_control"
        Me.panel_control.Size = New System.Drawing.Size(574, 60)
        Me.panel_control.TabIndex = 24
        '
        'button_cancel
        '
        Me.button_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_cancel.FlatAppearance.BorderSize = 0
        Me.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.ForeColor = System.Drawing.Color.White
        Me.button_cancel.Location = New System.Drawing.Point(346, 9)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(120, 42)
        Me.button_cancel.TabIndex = 8
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = False
        '
        'button_reset
        '
        Me.button_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_reset.FlatAppearance.BorderSize = 0
        Me.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_reset.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_reset.ForeColor = System.Drawing.Color.White
        Me.button_reset.Location = New System.Drawing.Point(221, 9)
        Me.button_reset.Name = "button_reset"
        Me.button_reset.Size = New System.Drawing.Size(119, 42)
        Me.button_reset.TabIndex = 9
        Me.button_reset.Text = "Reset"
        Me.button_reset.UseVisualStyleBackColor = False
        '
        'button_ok
        '
        Me.button_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_ok.FlatAppearance.BorderSize = 0
        Me.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_ok.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ok.ForeColor = System.Drawing.Color.White
        Me.button_ok.Location = New System.Drawing.Point(96, 9)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(119, 42)
        Me.button_ok.TabIndex = 9
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = False
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(346, 87)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(120, 35)
        Me.txtCash.TabIndex = 25
        '
        'button_cash_100
        '
        Me.button_cash_100.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cash_100.BackgroundImage = CType(resources.GetObject("button_cash_100.BackgroundImage"), System.Drawing.Image)
        Me.button_cash_100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_cash_100.FlatAppearance.BorderSize = 0
        Me.button_cash_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cash_100.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cash_100.ForeColor = System.Drawing.Color.White
        Me.button_cash_100.Location = New System.Drawing.Point(221, 148)
        Me.button_cash_100.Name = "button_cash_100"
        Me.button_cash_100.Size = New System.Drawing.Size(100, 48)
        Me.button_cash_100.TabIndex = 27
        Me.button_cash_100.UseVisualStyleBackColor = False
        '
        'button_cash_20
        '
        Me.button_cash_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cash_20.BackgroundImage = CType(resources.GetObject("button_cash_20.BackgroundImage"), System.Drawing.Image)
        Me.button_cash_20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_cash_20.FlatAppearance.BorderSize = 0
        Me.button_cash_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cash_20.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cash_20.ForeColor = System.Drawing.Color.White
        Me.button_cash_20.Location = New System.Drawing.Point(12, 148)
        Me.button_cash_20.Name = "button_cash_20"
        Me.button_cash_20.Size = New System.Drawing.Size(92, 48)
        Me.button_cash_20.TabIndex = 27
        Me.button_cash_20.UseVisualStyleBackColor = False
        '
        'button_cash_500
        '
        Me.button_cash_500.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cash_500.BackgroundImage = CType(resources.GetObject("button_cash_500.BackgroundImage"), System.Drawing.Image)
        Me.button_cash_500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_cash_500.FlatAppearance.BorderSize = 0
        Me.button_cash_500.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cash_500.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cash_500.ForeColor = System.Drawing.Color.White
        Me.button_cash_500.Location = New System.Drawing.Point(333, 148)
        Me.button_cash_500.Name = "button_cash_500"
        Me.button_cash_500.Size = New System.Drawing.Size(106, 48)
        Me.button_cash_500.TabIndex = 27
        Me.button_cash_500.UseVisualStyleBackColor = False
        '
        'button_cash_1000
        '
        Me.button_cash_1000.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cash_1000.BackgroundImage = CType(resources.GetObject("button_cash_1000.BackgroundImage"), System.Drawing.Image)
        Me.button_cash_1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_cash_1000.FlatAppearance.BorderSize = 0
        Me.button_cash_1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cash_1000.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cash_1000.ForeColor = System.Drawing.Color.White
        Me.button_cash_1000.Location = New System.Drawing.Point(451, 148)
        Me.button_cash_1000.Name = "button_cash_1000"
        Me.button_cash_1000.Size = New System.Drawing.Size(110, 48)
        Me.button_cash_1000.TabIndex = 27
        Me.button_cash_1000.UseVisualStyleBackColor = False
        '
        'button_cash_50
        '
        Me.button_cash_50.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cash_50.BackgroundImage = CType(resources.GetObject("button_cash_50.BackgroundImage"), System.Drawing.Image)
        Me.button_cash_50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_cash_50.FlatAppearance.BorderSize = 0
        Me.button_cash_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cash_50.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cash_50.ForeColor = System.Drawing.Color.White
        Me.button_cash_50.Location = New System.Drawing.Point(116, 148)
        Me.button_cash_50.Name = "button_cash_50"
        Me.button_cash_50.Size = New System.Drawing.Size(93, 48)
        Me.button_cash_50.TabIndex = 27
        Me.button_cash_50.UseVisualStyleBackColor = False
        '
        'txtSplitPaid
        '
        Me.txtSplitPaid.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSplitPaid.Location = New System.Drawing.Point(96, 87)
        Me.txtSplitPaid.Name = "txtSplitPaid"
        Me.txtSplitPaid.Size = New System.Drawing.Size(119, 35)
        Me.txtSplitPaid.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(43, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Pay:"
        '
        'pos_payment_cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 261)
        Me.Controls.Add(Me.txtSplitPaid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.button_cash_1000)
        Me.Controls.Add(Me.button_cash_500)
        Me.Controls.Add(Me.button_cash_50)
        Me.Controls.Add(Me.button_cash_20)
        Me.Controls.Add(Me.button_cash_100)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.panel_control)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pos_payment_cash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_control.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_header As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panel_control As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_ok As System.Windows.Forms.Button
    Friend WithEvents txtCash As Salon.IDN_NumericTextbox
    Friend WithEvents button_cash_100 As System.Windows.Forms.Button
    Friend WithEvents button_cash_20 As System.Windows.Forms.Button
    Friend WithEvents button_cash_500 As System.Windows.Forms.Button
    Friend WithEvents button_cash_1000 As System.Windows.Forms.Button
    Friend WithEvents button_reset As System.Windows.Forms.Button
    Friend WithEvents button_cash_50 As System.Windows.Forms.Button
    Friend WithEvents txtSplitPaid As Salon.IDN_NumericTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
