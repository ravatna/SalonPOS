<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos_add_discount
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
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textbox_amount = New Salon.IDN_NumericTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoBath = New System.Windows.Forms.RadioButton()
        Me.rdoPercentage = New System.Windows.Forms.RadioButton()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.panel_control = New System.Windows.Forms.Panel()
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
        Me.panel_header.Size = New System.Drawing.Size(484, 60)
        Me.panel_header.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Discount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(75, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Amount:"
        '
        'textbox_amount
        '
        Me.textbox_amount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_amount.Location = New System.Drawing.Point(166, 94)
        Me.textbox_amount.Name = "textbox_amount"
        Me.textbox_amount.Size = New System.Drawing.Size(208, 35)
        Me.textbox_amount.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(77, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Method:"
        '
        'rdoBath
        '
        Me.rdoBath.AutoSize = True
        Me.rdoBath.Checked = True
        Me.rdoBath.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rdoBath.ForeColor = System.Drawing.Color.Black
        Me.rdoBath.Location = New System.Drawing.Point(166, 135)
        Me.rdoBath.Name = "rdoBath"
        Me.rdoBath.Size = New System.Drawing.Size(68, 29)
        Me.rdoBath.TabIndex = 16
        Me.rdoBath.TabStop = True
        Me.rdoBath.Text = "Baht"
        Me.rdoBath.UseVisualStyleBackColor = True
        '
        'rdoPercentage
        '
        Me.rdoPercentage.AutoSize = True
        Me.rdoPercentage.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.rdoPercentage.ForeColor = System.Drawing.Color.Black
        Me.rdoPercentage.Location = New System.Drawing.Point(249, 135)
        Me.rdoPercentage.Name = "rdoPercentage"
        Me.rdoPercentage.Size = New System.Drawing.Size(125, 29)
        Me.rdoPercentage.TabIndex = 16
        Me.rdoPercentage.TabStop = True
        Me.rdoPercentage.Text = "Percentage"
        Me.rdoPercentage.UseVisualStyleBackColor = True
        '
        'button_ok
        '
        Me.button_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_ok.FlatAppearance.BorderSize = 0
        Me.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_ok.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ok.ForeColor = System.Drawing.Color.White
        Me.button_ok.Location = New System.Drawing.Point(119, 9)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(119, 42)
        Me.button_ok.TabIndex = 9
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = False
        '
        'button_cancel
        '
        Me.button_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_cancel.FlatAppearance.BorderSize = 0
        Me.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.ForeColor = System.Drawing.Color.White
        Me.button_cancel.Location = New System.Drawing.Point(244, 9)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(120, 42)
        Me.button_cancel.TabIndex = 8
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = False
        '
        'panel_control
        '
        Me.panel_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_control.Controls.Add(Me.button_cancel)
        Me.panel_control.Controls.Add(Me.button_ok)
        Me.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_control.Location = New System.Drawing.Point(0, 201)
        Me.panel_control.Name = "panel_control"
        Me.panel_control.Size = New System.Drawing.Size(484, 60)
        Me.panel_control.TabIndex = 15
        '
        'pos_add_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.rdoPercentage)
        Me.Controls.Add(Me.rdoBath)
        Me.Controls.Add(Me.panel_control)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textbox_amount)
        Me.Controls.Add(Me.panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pos_add_discount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount"
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
    Friend WithEvents rdoBath As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPercentage As System.Windows.Forms.RadioButton
    Friend WithEvents button_ok As System.Windows.Forms.Button
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents panel_control As System.Windows.Forms.Panel
    Friend WithEvents textbox_amount As Salon.IDN_NumericTextbox
End Class
