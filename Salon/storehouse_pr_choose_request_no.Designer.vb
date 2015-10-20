<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class storehouse_pr_choose_request_no
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(storehouse_pr_choose_request_no))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.button_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.panel_control = New System.Windows.Forms.Panel()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_select = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.listview_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_request_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview_note = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panel_header.SuspendLayout()
        Me.panel_control.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(192, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(243, 32)
        Me.TextBox1.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Request No."
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_header.Controls.Add(Me.Label1)
        Me.panel_header.Controls.Add(Me.button_search)
        Me.panel_header.Controls.Add(Me.TextBox1)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(484, 60)
        Me.panel_header.TabIndex = 6
        '
        'panel_control
        '
        Me.panel_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panel_control.Controls.Add(Me.button_cancel)
        Me.panel_control.Controls.Add(Me.button_select)
        Me.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_control.Location = New System.Drawing.Point(0, 204)
        Me.panel_control.Name = "panel_control"
        Me.panel_control.Size = New System.Drawing.Size(484, 57)
        Me.panel_control.TabIndex = 16
        '
        'button_cancel
        '
        Me.button_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_cancel.FlatAppearance.BorderSize = 0
        Me.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.ForeColor = System.Drawing.Color.White
        Me.button_cancel.Location = New System.Drawing.Point(244, 7)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(120, 42)
        Me.button_cancel.TabIndex = 8
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = False
        '
        'button_select
        '
        Me.button_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button_select.FlatAppearance.BorderSize = 0
        Me.button_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_select.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_select.ForeColor = System.Drawing.Color.White
        Me.button_select.Location = New System.Drawing.Point(119, 7)
        Me.button_select.Name = "button_select"
        Me.button_select.Size = New System.Drawing.Size(119, 42)
        Me.button_select.TabIndex = 9
        Me.button_select.Text = "Select"
        Me.button_select.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.listview_no, Me.listview_request_no, Me.listview_note})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListView1.Location = New System.Drawing.Point(0, 60)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(484, 145)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'listview_no
        '
        Me.listview_no.Text = "No"
        Me.listview_no.Width = 45
        '
        'listview_request_no
        '
        Me.listview_request_no.Text = "Request No"
        Me.listview_request_no.Width = 100
        '
        'listview_note
        '
        Me.listview_note.Text = "Note"
        Me.listview_note.Width = 340
        '
        'storehouse_pr_choose_request_no
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.panel_control)
        Me.Controls.Add(Me.panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "storehouse_pr_choose_request_no"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a request form number"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents button_search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panel_header As System.Windows.Forms.Panel
    Friend WithEvents panel_control As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_select As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Public WithEvents listview_no As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_request_no As System.Windows.Forms.ColumnHeader
    Public WithEvents listview_note As System.Windows.Forms.ColumnHeader
End Class
