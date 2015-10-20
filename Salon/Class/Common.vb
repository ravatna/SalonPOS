Imports System.Data.SqlClient

Public Class Common

    Public Shared Function GetColorDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Color where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function
    

    Public Shared Function GetBrandDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Brand where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetCategoryDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from ProductCAT where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetTypeDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from ProductType where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetUnitDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from ProductUnit where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetPositionDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Position where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetProvinceDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Province  order by EnglishTitle"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetBranchDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Branch where status='active'  order by Title"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    'Public Shared Function GetPaymentMethodDatatable() As DataTable
    '    Dim cnn As SqlConnection = ConnectionManagement.GetConnection
    '    Dim sql As String = "select * from PaymentMethod where status='active'"

    '    Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
    '    Return dt
    'End Function

    Public Shared Function GetPRStatusDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from PRStatus where status='active' order by sort"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetWarehouseDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Location where status='active'  and locationtype='Warehouse'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function


    Public Shared Function GetPaymentMethodDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from PaymentMethod where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetLocationDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Location where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetCustomerVisitTypeDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from CustomerVisitType where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetPOStatusDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from POStatus where status='active' order by sort"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

   
    Public Shared Function GetCountryDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Country"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function


    Public Shared Function GetTitlePrefixDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from TitlePrefix where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetVATDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from VATType where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetIPAddress() As String
        Dim myHost As String = System.Net.Dns.GetHostName

        Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(myHost)

        Dim ipaddress As String = ""

        For Each myIP As System.Net.IPAddress In myIPs.AddressList

            ipaddress = myIP.ToString

        Next
        Return ipaddress
    End Function

    Public Shared Function CheckSaleTotalByCustomer(Customer, PayementType) As Decimal
        Dim value As Decimal = 0
        Dim sql As String = "select SUM(grandtotal) as sumTotalwelfare FROM         Sale INNER JOIN"
        sql &= "           SalePayment ON Sale.Branch = SalePayment.Branch AND Sale.Code = SalePayment.Sale where SalePayment.PaymentMethod='" & PayementType & "' and Customer='" & Customer & "' and YEAR(SaleDateTime)=YEAR(getdate()) and month(SaleDateTime)=month(getdate())"


        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            If dt.Rows.Count = 0 Then
                value = 0
            ElseIf dt.Rows(0).Item("sumTotalwelfare") Is DBNull.Value Then
                value = 0

            Else
                value = dt.Rows(0).Item("sumTotalwelfare")

            End If
        End Using
        Return value
    End Function

    Public Shared Function CheckWelfareAMT(Customer) As Decimal
        Dim sumTotalwelfare As Decimal
        Dim sql As String = "select SUM(grandtotal) as sumTotalwelfare FROM         Sale INNER JOIN"
        sql &= "           SalePayment ON Sale.Branch = SalePayment.Branch AND Sale.Code = SalePayment.Sale where SalePayment.PaymentMethod='welfare' and Customer='" & Customer & "' and YEAR(SaleDateTime)=YEAR(getdate()) and month(SaleDateTime)=month(getdate())"
        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            If dt.Rows(0).Item("sumTotalwelfare") Is DBNull.Value Then
                sumTotalwelfare = 0
            Else
                sumTotalwelfare = dt.Rows(0).Item("sumTotalwelfare")
            End If
        End Using
        Return sumTotalwelfare
    End Function

    Public Shared Function CheckWelfare(Customer) As Boolean
        'ตรวจสอบสิทธิ พนักงานสามารถเติมแก๊สได้ฟรี เกินจำนวนวงเงินได้ 1 ครั้ง หลังจากนั้นระบบจะ block ในรอบเดือน ////////////////////////////////////////

        Dim sumTotalwelfare As Decimal
        Dim Credit As Decimal
        ' Dim sql As String = "select SUM(grandtotal) as sumTotalwelfare from Sale where PaymentMethod='welfare' and Customer='" & Customer & "' and YEAR(SaleDateTime)=YEAR(getdate()) and month(SaleDateTime)=month(getdate())"
        Dim sql As String = "select SUM(grandtotal) as sumTotalwelfare FROM         Sale INNER JOIN"
        sql &= "           SalePayment ON Sale.Branch = SalePayment.Branch AND Sale.Code = SalePayment.Sale where SalePayment.PaymentMethod='welfare' and Customer='" & Customer & "' and YEAR(SaleDateTime)=YEAR(getdate()) and month(SaleDateTime)=month(getdate())"


        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, Sql)

            If dt.Rows(0).Item("sumTotalwelfare") Is DBNull.Value Then
                sumTotalwelfare = 0
            Else
                sumTotalwelfare = dt.Rows(0).Item("sumTotalwelfare")
            End If
        End Using
        sql = "select * from employee where id='" & Customer & "'"
        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            If dt.Rows(0).Item("Credit") Is DBNull.Value Then
                Credit = 0
            Else
                Credit = dt.Rows(0).Item("Credit")
            End If

            'เกินจำนวนวงเงินได้ 1 ครั้ง
            If sumTotalwelfare > Credit Then

                Return False
            Else
                Return True
            End If

        End Using

        '////////////////////////////////////////
    End Function


    Public Function CheckCredit(Customer) As Decimal
        'ตรวจสอบสิทธิ พนักงานสามารถเติมแก๊สได้ฟรี เกินจำนวนวงเงินได้ 1 ครั้ง หลังจากนั้นระบบจะ block ในรอบเดือน ////////////////////////////////////////

        Dim sumTotalCredit As Decimal
        Dim Credit As Decimal
        '  Dim sql As String = "select SUM(grandtotal) as sumTotalCredit from Sale where PaymentMethod='CREDIT' and Customer='" & Customer & "' and YEAR(SaleDateTime)=YEAR(getdate()) and month(SaleDateTime)=month(getdate())"
        Dim sql As String = "SELECT     SUM(SalePayment.PaidAmt) AS sumTotalCredit"
        sql &= " FROM         SalePayment INNER JOIN"
        sql &= "                Sale ON SalePayment.Branch = Sale.Branch AND SalePayment.Sale = Sale.Code"
        sql &= " where PaymentMethod='CREDIT' and Customer='" & Customer & "' and YEAR(SaleDateTime)=YEAR(getdate()) and month(SaleDateTime)=month(getdate())"
        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            If dt.Rows.Count = 0 Then
                sumTotalCredit = 0
            Else
                If dt.Rows(0).Item("sumTotalCredit") Is DBNull.Value Then
                    sumTotalCredit = 0
                Else
                    sumTotalCredit = dt.Rows(0).Item("sumTotalCredit")
                End If
            End If
           
        End Using
        sql = "select * from customer where id='" & GlobalVar.POSCustomer & "'"
        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            If dt.Rows(0).Item("Credit") Is DBNull.Value Then
                Credit = 0
            Else
                Credit = dt.Rows(0).Item("Credit")
            End If

            Return Credit - sumTotalCredit

            ''เกินจำนวนวงเงินได้ 1 ครั้ง
            'If sumTotalCredit > Credit Then

            '    Return False
            'Else
            '    Return True
            'End If

        End Using

        '////////////////////////////////////////
    End Function

    Public Shared Function GetCustomerDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String
        sql = "SELECT     Customer.* ,TitlePrefix.Title as PrefixTitle  FROM         Customer LEFT OUTER JOIN TitlePrefix ON Customer.Title = TitlePrefix.Code  where Customer.status='Active' "

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetEmployeeDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select *, isnull(TitlePrefix.Title,'')+' '+firstname + ' ' + lastname  AS fullname FROM         Employee INNER JOIN      TitlePrefix ON Employee.Title = TitlePrefix.Code WHERE     (Employee.Status = 'active') "

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetProductTypeDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from ProductType where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetProductUnitDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from ProductUnit where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function


    Public Shared Function GetVATValue(VATType As String) As Decimal
        'Dim vat As String
        'If VATType = "" Then
        '    vat = 0
        'Else
        '    Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        '    Dim sql As String = "select * from VATType where code='" & VATType & "'"

        '    Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        '    vat = CDec((dt.Rows(0).Item("VAT").ToString) / 100)
        'End If
        'Return vat
    End Function

    Public Shared Function GetProvinceNameByCode(code As String) As String
        Dim dataSource As DataTable
        Dim ProvinceName As String
        dataSource = Common.GetProvinceDatatable
        ProvinceName = (dataSource.Select("Code = '" & code & "'")(0).Item("Title"))
        Return ProvinceName
    End Function

    Public Shared Function GetFullname(Code As String) As String
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Employee where ID='" & Code & "'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Dim fullname As String
        If dt.Rows.Count = 0 Then
            fullname = ""
        Else
            fullname = dt.Rows(0).Item("Title") + " " + dt.Rows(0).Item("Firstname") + " " + dt.Rows(0).Item("Lastname")
        End If

        Return fullname
    End Function

    Public Shared Function GetConvertData(Code As String) As Decimal
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select  top 1 * from unitConvert  order by InsertDate desc"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Dim ConvertValue As Decimal
        If dt.Rows.Count = 0 Then
            ConvertValue = "1"
        Else
            ConvertValue = dt.Rows(0).Item("Value")
        End If

        Return ConvertValue
    End Function

    Public Shared Function GetUseUnitRate(product As String, useunit As String) As Decimal
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select  *  from ProductUseUnit  where product='" & product & "' and ProductUnit='" & useunit & "'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Dim ConvertValue As Decimal
        If dt.Rows.Count = 0 Then
            ConvertValue = "1"
        Else
            ConvertValue = dt.Rows(0).Item("ConvertRate")
        End If

        Return ConvertValue
    End Function


    'Public Shared Function GetFullname(Code As String) As String
    '    Dim cnn As SqlConnection = ConnectionManagement.GetConnection
    '    Dim sql As String = "select * from Employee where ID='" & Code & "'"

    '    Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
    '    Dim fullname As String
    '    fullname = dt.Rows(0).Item("Title") + " " + dt.Rows(0).Item("Firstname") + " " + dt.Rows(0).Item("Lastname")
    '    Return fullname
    'End Function

    Public Shared Function GetLatestCode(TableName As String, Optional Column As String = "Code") As String
        Dim lastestCode As Integer = 0
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select top 1  * from " & TableName & " order by code desc"



        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)

        If dt.Rows.Count = 0 Then
            lastestCode += 1
        Else
            Dim currentCode As String
            currentCode = dt.Rows(0).Item(Column)
            lastestCode = CInt(currentCode.Substring(1)) + 1
        End If

        'For Each row As DataRow In dt.Rows
        '    Dim code As Integer
        '    If Integer.TryParse(row.Item(Column), code) Then
        '        lastestCode = IIf(code > lastestCode, code, lastestCode)
        '    End If
        'Next
        'lastestCode += 1
        Return lastestCode.ToString("0000")
    End Function

    Public Shared Function IsNullToString(Value As Object) As String
        Dim v As String
        If Value Is DBNull.Value Then
            v = ""

        ElseIf Value Is Nothing Then
            v = ""
        Else
            v = Value.ToString


        End If
        Return v
    End Function

    Public Shared Function IsNullToFalse(Value As Object) As Boolean
        Dim v As Boolean
        If Value Is DBNull.Value Then
            v = False

        ElseIf Value Is Nothing Then
            v = False
        Else
            v = Value


        End If
        Return v
    End Function

    Public Shared Function GetLocationTypeDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from LocationType where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetAreaDatatable() As DataTable
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select * from Area where status='active'"

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Return dt
    End Function

    Public Shared Function GetLatestIDMember() As String
        Dim lastestCode As String = String.Empty
        Dim cnn As SqlConnection = ConnectionManagement.GetConnection
        Dim sql As String = "select top 1 * from Member order by ID desc "

        Dim dt As DataTable = SQLHelper.ExecuteTable(cnn, CommandType.Text, sql)
        Dim code As Integer
        If dt.Rows.Count > 0 Then
            If Integer.TryParse(dt.Rows(0).Item("ID").ToString.Substring(1), code) Then
                code += 1
            End If
        Else
            code = 1
        End If

        lastestCode = "M" + code.ToString.PadLeft(4, "0")
        Return lastestCode
    End Function

End Class
