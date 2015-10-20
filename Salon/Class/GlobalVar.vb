Public Class GlobalVar

    Public Const POS_NEW_BILL_MODE As Byte = 0
    Public Const POS_EDIT_BILL_MODE As Byte = 1

    Public Shared UserID As String = "0001"
    Public Shared UserName As String = "0000"
    Public Shared Branch As String = "b0002"
    Public Shared SaleCode As String
    Public Shared ClosHour As Integer
    Public Shared CloseMinute As Integer
    Public Shared CloseSecond As Integer

    Public Shared RewardProductCode As String = ""
    Public Shared RewardProductQTY As Integer = 0

    Public Shared POSWorkingMode As Byte

    ' ตัวแปรสำหรับ เก็บรหัสอ้างอิงลูกค้าที่กำลังใช้ ลงบิลอยู่
    Public Shared POSCustomer As String ' เก็บรหัสลูกค้าที่เลือกมาล่าสุด
    Public Shared POSCustomerName As String ' เก็บชื่อลูกค้าที่เลือกมาล่าสุด
    Public Shared POSCustomerLastname As String 'เก็บสกุลลูกค้าที่เลือกมาล่าสุด

    Public Shared POSCustomerType As String ' เก็บประเภทลูกที่มาใช้บริการ
    Public Shared POSCustomerTypeName As String ' เก็บคำเีรยกประเภทลูกค้าที่มาใช้บริการ

    Public Shared POSStylish As String
    Public Shared POSStylishName As String

    

    Public Shared POSShiftCode As String
    Public Shared POSShiftDate As Date
End Class
