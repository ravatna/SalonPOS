<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.textbox_username = New System.Windows.Forms.TextBox()
        Me.textbox_password = New System.Windows.Forms.TextBox()
        Me.button_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_result = New System.Windows.Forms.Label()
        Me.button_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textbox_username
        '
        Me.textbox_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.textbox_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textbox_username.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.textbox_username.Location = New System.Drawing.Point(270, 288)
        Me.textbox_username.Name = "textbox_username"
        Me.textbox_username.Size = New System.Drawing.Size(308, 50)
        Me.textbox_username.TabIndex = 0
        Me.textbox_username.Text = "Apple"
        '
        'textbox_password
        '
        Me.textbox_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.textbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textbox_password.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.textbox_password.Location = New System.Drawing.Point(270, 372)
        Me.textbox_password.Name = "textbox_password"
        Me.textbox_password.Size = New System.Drawing.Size(252, 50)
        Me.textbox_password.TabIndex = 1
        Me.textbox_password.Text = "orange"
        Me.textbox_password.UseSystemPasswordChar = True
        '
        'button_login
        '
        Me.button_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_login.BackgroundImage = CType(resources.GetObject("button_login.BackgroundImage"), System.Drawing.Image)
        Me.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_login.FlatAppearance.BorderSize = 0
        Me.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_login.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_login.ForeColor = System.Drawing.Color.White
        Me.button_login.Location = New System.Drawing.Point(528, 372)
        Me.button_login.Name = "button_login"
        Me.button_login.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.button_login.Size = New System.Drawing.Size(50, 50)
        Me.button_login.TabIndex = 4
        Me.button_login.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(303, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Get started."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(230, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the User ID and Password"
        '
        'label_result
        '
        Me.label_result.AutoSize = True
        Me.label_result.BackColor = System.Drawing.Color.Transparent
        Me.label_result.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_result.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.label_result.Location = New System.Drawing.Point(198, 451)
        Me.label_result.Name = "label_result"
        Me.label_result.Size = New System.Drawing.Size(140, 32)
        Me.label_result.TabIndex = 5
        Me.label_result.Text = "Login result"
        '
        'button_close
        '
        Me.button_close.BackColor = System.Drawing.Color.Transparent
        Me.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_close.FlatAppearance.BorderSize = 0
        Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_close.Image = CType(resources.GetObject("button_close.Image"), System.Drawing.Image)
        Me.button_close.Location = New System.Drawing.Point(758, 12)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(30, 30)
        Me.button_close.TabIndex = 16
        Me.button_close.UseVisualStyleBackColor = False
        '
        'login_form
        '
        Me.AcceptButton = Me.button_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.button_close)
        Me.Controls.Add(Me.label_result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.button_login)
        Me.Controls.Add(Me.textbox_password)
        Me.Controls.Add(Me.textbox_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "login_form"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textbox_username As System.Windows.Forms.TextBox
    Friend WithEvents textbox_password As System.Windows.Forms.TextBox
    Friend WithEvents button_login As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label_result As System.Windows.Forms.Label
    Friend WithEvents button_close As System.Windows.Forms.Button
End Class
