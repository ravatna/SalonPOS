Public Class MyDateTimePicker : Inherits Windows.Forms.DateTimePicker

    Private oldFormat As DateTimePickerFormat
    Private oldCustomFormat As String
    Private _value As Object

    Public Sub New()
        _value = MyBase.Value
    End Sub

    Public Overloads Property Value()
        Get
            Return _value
        End Get
        Set(ByVal value)
            If value = DateTime.MinValue Then
                If _value IsNot Nothing Then
                    oldFormat = Me.Format
                    oldCustomFormat = Me.CustomFormat
                End If

                Me.Format = DateTimePickerFormat.Custom
                Me.CustomFormat = " "
                _value = Nothing
            Else
                If _value Is Nothing Then
                    Me.Format = oldFormat
                    Me.CustomFormat = oldCustomFormat
                End If

                MyBase.Value = value
                _value = value
            End If
        End Set
    End Property

    Private Sub MyDateTimePicker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                Me.Value = DateTime.MinValue
        End Select
    End Sub

    Protected Overrides Sub OnValueChanged(ByVal eventargs As System.EventArgs)
        If _value Is Nothing Then
            Me.Format = oldFormat
            Me.CustomFormat = oldCustomFormat
        End If

        _value = MyBase.Value
    End Sub

End Class
