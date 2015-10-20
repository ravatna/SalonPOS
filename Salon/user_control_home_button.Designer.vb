<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_control_home_button
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_control_home_button))
        Me.button_home = New System.Windows.Forms.Button()
        Me.lblBranchName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label_time = New System.Windows.Forms.Label()
        Me.button_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_home
        '
        Me.button_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_home.FlatAppearance.BorderSize = 0
        Me.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_home.Image = CType(resources.GetObject("button_home.Image"), System.Drawing.Image)
        Me.button_home.Location = New System.Drawing.Point(3, 10)
        Me.button_home.Name = "button_home"
        Me.button_home.Size = New System.Drawing.Size(54, 54)
        Me.button_home.TabIndex = 12
        Me.button_home.UseVisualStyleBackColor = True
        '
        'lblBranchName
        '
        Me.lblBranchName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblBranchName.ForeColor = System.Drawing.Color.Black
        Me.lblBranchName.Location = New System.Drawing.Point(60, 40)
        Me.lblBranchName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBranchName.Name = "lblBranchName"
        Me.lblBranchName.Size = New System.Drawing.Size(248, 23)
        Me.lblBranchName.TabIndex = 13
        Me.lblBranchName.Text = "Rikyu"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'label_time
        '
        Me.label_time.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.label_time.ForeColor = System.Drawing.Color.Black
        Me.label_time.Location = New System.Drawing.Point(59, 17)
        Me.label_time.Margin = New System.Windows.Forms.Padding(0)
        Me.label_time.Name = "label_time"
        Me.label_time.Size = New System.Drawing.Size(286, 23)
        Me.label_time.TabIndex = 14
        Me.label_time.Text = "DateTime"
        '
        'button_logout
        '
        Me.button_logout.BackColor = System.Drawing.Color.Transparent
        Me.button_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button_logout.FlatAppearance.BorderSize = 0
        Me.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_logout.Image = CType(resources.GetObject("button_logout.Image"), System.Drawing.Image)
        Me.button_logout.Location = New System.Drawing.Point(320, 33)
        Me.button_logout.Name = "button_logout"
        Me.button_logout.Size = New System.Drawing.Size(30, 30)
        Me.button_logout.TabIndex = 15
        Me.button_logout.UseVisualStyleBackColor = False
        '
        'user_control_home_button
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.button_logout)
        Me.Controls.Add(Me.label_time)
        Me.Controls.Add(Me.lblBranchName)
        Me.Controls.Add(Me.button_home)
        Me.Location = New System.Drawing.Point(1300, 12)
        Me.Name = "user_control_home_button"
        Me.Size = New System.Drawing.Size(353, 70)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_home As System.Windows.Forms.Button
    Friend WithEvents lblBranchName As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents label_time As System.Windows.Forms.Label
    Friend WithEvents button_logout As System.Windows.Forms.Button

End Class
