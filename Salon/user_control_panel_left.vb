Imports System.Drawing
Public Class user_control_panel_left


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim line1 As New System.Drawing.Pen(System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(221, Byte), Integer)), 1)
        e.Graphics.DrawLine(line1, 0, 74, Panel1.Width, 74) '(margin_left, top_from_left, wide, top_from_right)

        Dim line2 As New System.Drawing.Pen(System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer)), 1)
        e.Graphics.DrawLine(line2, 0, 700, Panel1.Width, 700) '(margin_left, top_from_left, wide, top_from_right)
    End Sub
End Class
