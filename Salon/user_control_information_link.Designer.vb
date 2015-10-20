<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_control_information_link
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
        Me.link_information = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'link_information
        '
        Me.link_information.AutoSize = True
        Me.link_information.Location = New System.Drawing.Point(3, 0)
        Me.link_information.Name = "link_information"
        Me.link_information.Size = New System.Drawing.Size(108, 13)
        Me.link_information.TabIndex = 56
        Me.link_information.TabStop = True
        Me.link_information.Text = "The information detail"
        '
        'user_control_information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.link_information)
        Me.Name = "user_control_information"
        Me.Size = New System.Drawing.Size(113, 18)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents link_information As System.Windows.Forms.LinkLabel

End Class
