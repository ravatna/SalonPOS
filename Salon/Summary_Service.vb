Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading

Public Class Summary_Service

    Dim dtpayment As DataTable
    Dim dtSale As DataTable
    Dim dtSaleDetail As DataTable
    Dim dtSalePayment As DataTable

    Dim dtProductCAT As DataTable
    Private Sub service_memo_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        dtpStart.Value = Date.Now
        dtpStart.Format = DateTimePickerFormat.Custom
        dtpStart.CustomFormat = "dd/MM/yyyy"

        dtpStop.Value = Date.Now
        dtpStop.Format = DateTimePickerFormat.Custom
        dtpStop.CustomFormat = "dd/MM/yyyy"

        lvtSale.Columns.Add("Code", 150, HorizontalAlignment.Left)
        lvtSale.Columns.Add("Date Time", 150, HorizontalAlignment.Left)
        lvtSale.Columns.Add("CustomerVisitType", 150, HorizontalAlignment.Left)
        lvtSale.Columns.Add("CustomerID", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("Customer name", 150, HorizontalAlignment.Left)
        lvtSale.Columns.Add("Stylist", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("Firstname", 150, HorizontalAlignment.Left)
        lvtSale.Columns.Add("Lastname", 150, HorizontalAlignment.Left)
        lvtSale.Columns.Add("Total", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("Discount", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("GrandTotal", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("CASH", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("COUPON", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("CREDITCARD", 100, HorizontalAlignment.Left)
        lvtSale.Columns.Add("VOUCHER", 100, HorizontalAlignment.Left)



        lvtSaleDetail.Columns.Add("Code", 150, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Date Time", 150, HorizontalAlignment.Left)

        lvtSaleDetail.Columns.Add("CustomerID", 150, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Customer name", 150, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Nickname", 150, HorizontalAlignment.Left)

        lvtSaleDetail.Columns.Add("Stylist", 200, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Product", 150, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Product Title", 150, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Product Cate", 150, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("UnitPrice", 100, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Quantity", 100, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Discount", 100, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Bill Discount", 100, HorizontalAlignment.Left)
        lvtSaleDetail.Columns.Add("Total", 100, HorizontalAlignment.Left)






        lvtSalePayment.Columns.Add("Code", 150, HorizontalAlignment.Left)
        lvtSalePayment.Columns.Add("Date Time", 150, HorizontalAlignment.Left)
        lvtSalePayment.Columns.Add("CustomerID", 150, HorizontalAlignment.Left)
        lvtSalePayment.Columns.Add("Customer name", 150, HorizontalAlignment.Left)
        lvtSalePayment.Columns.Add("Nickname", 150, HorizontalAlignment.Left)
        lvtSalePayment.Columns.Add("PaymentMethod", 150, HorizontalAlignment.Left)
        lvtSalePayment.Columns.Add("PaidAmt", 150, HorizontalAlignment.Left)

        ' loadLvtData()


        ListView1.Columns.Add("Payment type", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Amount", 150, HorizontalAlignment.Left)

        lvtProductCAT.Columns.Add("Product Category", 150, HorizontalAlignment.Left)
        lvtProductCAT.Columns.Add("Amount", 150, HorizontalAlignment.Left)

        ' loadSumpaymentData()
    End Sub


    'Sub LoadColorCombobox()
    '    Dim dt As DataTable = Common.GetColorDatatable
    '    Dim dr As DataRow = dt.NewRow()
    '    dr("CODE") = ""

    '    dt.Rows.InsertAt(dr, 0)

    '    cboColor.DataSource = dt
    '    cboColor.DisplayMember = "Title"
    '    cboColor.ValueMember = "Code"
    '    cboColor.SelectedIndex = 0
    'End Sub

    Private Sub ExportToExcel(datatablePayment As DataTable, dtsale As DataTable, dtsaledetail As DataTable, dtsalepayment As DataTable)
        'Dim dataAdapter As New SqlClient.SqlDataAdapter()
        'Dim dataSet As New DataSet
        'Dim command As New SqlClient.SqlCommand
        'Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        ''Assign your connection string to connection object
        'connection.ConnectionString = "Data Source=.;Initial Catalog=pubs;Integrated Security=True"
        'command.Connection = connection
        'command.CommandType = CommandType.Text
        ''You can use any command select
        'command.CommandText = "Select * from Authors"
        'dataAdapter.SelectCommand = command


        ' Dim f As SaveFileDialog = New SaveFileDialog
        f.FileName = "summarysale" & Date.Now.ToString("yyyyMMddhhmm")
        f.Filter = "Excel File|*.xls"
        f.Title = "Save an Excel File"
        Try
            If f.ShowDialog() = DialogResult.OK Then
                'This section help you if your language is not English.
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
                Dim oExcel As Microsoft.Office.Interop.Excel.Application
                Dim oBook As Microsoft.Office.Interop.Excel.Workbook
                Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add(Type.Missing)
                oSheet = oBook.Worksheets(1)

                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0

                'Fill data to datatable
                'connection.Open()
                'dataAdapter.Fill(datatableMain)
                'connection.Close()


                'Export the Columns to excel file
                For Each dc In datatablePayment.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(1, colIndex) = dc.ColumnName
                Next

                'Export the rows to excel file
                For Each dr In datatablePayment.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In datatablePayment.Columns
                        colIndex = colIndex + 1
                        oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next

                'Set final path
                'Dim fileName As String = "\ExportedData" + ".xls"
                'Dim finalPath = f.SelectedPath + fileName
                Dim finalpath = f.FileName
                ' txtPath.Text = finalPath
                oSheet.Columns.AutoFit()
                'Save file in final path
                'oBook.SaveAs(finalpath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, _
                'Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, _
                'Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                'Release the objects
                ReleaseObject(oSheet)
                'oBook.Close(False, Type.Missing, Type.Missing)
                'ReleaseObject(oBook)
                'oExcel.Quit()
                'ReleaseObject(oExcel)
                'Some time Office application does not quit after automation: 
                'so i am calling GC.Collect method.



                Dim oSheet1 As Microsoft.Office.Interop.Excel.Worksheet
                oSheet1 = oBook.Worksheets.Add
                colIndex = 0
                rowIndex = 0
                For Each dc In dtsale.Columns
                    colIndex = colIndex + 1
                    oSheet1.Cells(1, colIndex) = dc.ColumnName
                Next

                'Export the rows to excel file
                For Each dr In dtsale.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In dtsale.Columns
                        colIndex = colIndex + 1
                        oSheet1.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next


                oSheet1.Columns.AutoFit()


                Dim oSheet2 As Microsoft.Office.Interop.Excel.Worksheet
                oSheet2 = oBook.Worksheets.Add
                colIndex = 0
                rowIndex = 0
                For Each dc In dtsaledetail.Columns
                    colIndex = colIndex + 1
                    oSheet2.Cells(1, colIndex) = dc.ColumnName
                Next

                'Export the rows to excel file
                For Each dr In dtsaledetail.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In dtsaledetail.Columns
                        colIndex = colIndex + 1
                        oSheet2.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next


                oSheet2.Columns.AutoFit()

                Dim oSheet3 As Microsoft.Office.Interop.Excel.Worksheet
                oSheet3 = oBook.Worksheets.Add
                colIndex = 0
                rowIndex = 0
                For Each dc In dtsalepayment.Columns
                    colIndex = colIndex + 1
                    oSheet3.Cells(1, colIndex) = dc.ColumnName
                Next

                'Export the rows to excel file
                For Each dr In dtsalepayment.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In dtsalepayment.Columns
                        colIndex = colIndex + 1
                        oSheet3.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next


                oSheet3.Columns.AutoFit()


                'Save file in final path
                oBook.SaveAs(finalpath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, _
                Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, _
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                'Release the objects
                ReleaseObject(oSheet1)
                oBook.Close(False, Type.Missing, Type.Missing)
                ReleaseObject(oBook)
                oExcel.Quit()
                ReleaseObject(oExcel)
                GC.Collect()

                MessageBox.Show("Export completed")
            End If
        Catch ex As Exception
            MessageBox.Show("Export failed " & ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub LoadSalePayment()
        Dim sql As String = "SELECT     Sale.Code, Sale.SaleDateTime, Sale.Customer, Customer.Name, Customer.NickName, SalePayment.PaymentMethod, SalePayment.PaidAmt"
        sql &= "  FROM         Sale INNER JOIN"
        sql &= "                Customer ON Sale.Customer = Customer.ID INNER JOIN"
        sql &= "               SalePayment ON Sale.Code = SalePayment.Sale INNER JOIN"
        sql &= "               PaymentMethod ON SalePayment.PaymentMethod = PaymentMethod.Code where  CONVERT(date, sale.saledatetime)>=@SaleStartDate  and CONVERT(date, sale.saledatetime)<=@SaleFinishDate order by saledatetime "

        Dim param(1) As SqlParameter
        param(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        param(0).Value = CDate(dtpStart.Value).Date

        param(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        param(1).Value = CDate(dtpStop.Value).Date
        dtSalePayment = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, param)








        lvtSalePayment.Items.Clear()
        Dim i As Integer
        For i = 0 To dtSalePayment.Rows.Count - 1
            Dim item(6) As String
            item(0) = dtSalePayment.Rows(i).Item("Code")
            item(1) = dtSalePayment.Rows(i).Item("SaleDatetime")

            item(2) = ConvertNullToString(dtSalePayment.Rows(i).Item("Customer"))
            item(3) = ConvertNullToString(dtSalePayment.Rows(i).Item("Name"))
            item(4) = ConvertNullToString(dtSalePayment.Rows(i).Item("NickName"))

            item(5) = ConvertNullToString(dtSalePayment.Rows(i).Item("PaymentMethod"))
            item(6) = ConvertNullToZero(dtSalePayment.Rows(i).Item("PaidAmt"))
            Dim lr As New ListViewItem(item)

            lvtSalePayment.Items.Add(lr)




        Next
    End Sub

    Private Sub LoadSale()
        'Dim sql As String = "SELECT   Sale.Code, Sale.SaleDateTime, CustomerVisitType.Title as CustomerVisitTypeTitle, Sale.Customer, Customer.Name, Sale.Stylist, Employee.Firstname, Employee.Lastname, Sale.Total, Sale.Discount, "
        'sql &= "   Sale.GrandTotal "
        'sql &= "  FROM         Sale INNER JOIN"
        'sql &= "                      CustomerVisitType ON Sale.CustomerVisitType = CustomerVisitType.Code INNER JOIN"
        'sql &= "                      Customer ON Sale.Customer = Customer.ID INNER JOIN"
        'sql &= "                     Employee ON Sale.Stylist = Employee.ID where  CONVERT(date, sale.saledatetime)>=@SaleStartDate  and CONVERT(date, sale.saledatetime)<=@SaleFinishDate  order by saledatetime"


        Dim sql As String = "select  *"
        sql &= "     from "
        sql &= "  ("
        sql &= "  select Sale.Code, Sale.SaleDateTime, CustomerVisitType.Title AS CustomerVisitTypeTitle, Sale.Customer, Customer.Name, Sale.Stylist, Employee.Firstname, Employee.Lastname, Sale.Total, "
        sql &= " Sale.Discount, Sale.GrandTotal, SalePayment.PaymentMethod, SalePayment.PaidAmt"
        sql &= "   FROM         Sale INNER JOIN"
        sql &= "                       CustomerVisitType ON Sale.CustomerVisitType = CustomerVisitType.Code INNER JOIN"
        sql &= "                       Customer ON Sale.Customer = Customer.ID INNER JOIN"
        sql &= "                      Employee ON Sale.Stylist = Employee.ID INNER JOIN"
        sql &= "                      SalePayment ON Sale.Code = SalePayment.Sale where  CONVERT(date, sale.saledatetime)>=@SaleStartDate  and CONVERT(date, sale.saledatetime)<=@SaleFinishDate"
        sql &= " ) d"
        sql &= "         pivot"
        sql &= " ("
        sql &= "        SUM(PaidAmt)"
        sql &= "  for PaymentMethod in ([CASH],   [COUPON], [CREDITCARD],   [VOUCHER])"
        sql &= "  ) piv"
        Dim param(1) As SqlParameter
        param(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        param(0).Value = CDate(dtpStart.Value).Date

        param(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        param(1).Value = CDate(dtpStop.Value).Date
        dtSale = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, param)








        lvtSale.Items.Clear()
        Dim i As Integer
        For i = 0 To dtSale.Rows.Count - 1
            Dim item(15) As String
            item(0) = dtSale.Rows(i).Item("Code")
            item(1) = dtSale.Rows(i).Item("SaleDatetime")
            item(2) = ConvertNullToString(dtSale.Rows(i).Item("CustomerVisitTypeTitle"))
            item(3) = ConvertNullToString(dtSale.Rows(i).Item("Customer"))
            item(4) = ConvertNullToString(dtSale.Rows(i).Item("Name"))
            item(5) = ConvertNullToString(dtSale.Rows(i).Item("Stylist"))
            item(6) = ConvertNullToString(dtSale.Rows(i).Item("Firstname"))
            item(7) = ConvertNullToString(dtSale.Rows(i).Item("Lastname"))
            item(8) = ConvertNullToZero(dtSale.Rows(i).Item("Total"))
            item(9) = ConvertNullToZero(dtSale.Rows(i).Item("Discount"))
            item(10) = ConvertNullToZero(dtSale.Rows(i).Item("GrandTotal"))
            If dtSale.Rows(i).Item("CASH") Is DBNull.Value Then
                item(11) = "0"
            Else
                item(11) = dtSale.Rows(i).Item("CASH")
            End If

            If dtSale.Rows(i).Item("COUPON") Is DBNull.Value Then
                item(12) = "0"
            Else
                item(12) = dtSale.Rows(i).Item("COUPON")
            End If

            If dtSale.Rows(i).Item("CREDITCARD") Is DBNull.Value Then
                item(13) = "0"
            Else
                item(13) = dtSale.Rows(i).Item("CREDITCARD")
            End If

            If dtSale.Rows(i).Item("VOUCHER") Is DBNull.Value Then
                item(14) = "0"
            Else
                item(14) = dtSale.Rows(i).Item("VOUCHER")
            End If

            Dim lr As New ListViewItem(item)
            ' lr.Tag = dt.Rows(i).Item("Code")
            lvtSale.Items.Add(lr)


            'lvtSale.Columns.Add("Code", 150, HorizontalAlignment.Left)
            'lvtSale.Columns.Add("SaleDatetime", 150, HorizontalAlignment.Left)
            'lvtSale.Columns.Add("CustomerVisitType", 150, HorizontalAlignment.Left)
            'lvtSaleDetail.Columns.Add("CustomerID", 150, HorizontalAlignment.Left)
            'lvtSaleDetail.Columns.Add("Customer name", 150, HorizontalAlignment.Left)
            'lvtSaleDetail.Columns.Add("Stylist", 150, HorizontalAlignment.Left)
            'lvtSaleDetail.Columns.Add("Firstname", 150, HorizontalAlignment.Left)
            'lvtSaleDetail.Columns.Add("Lastname", 150, HorizontalAlignment.Left)
            'lvtSale.Columns.Add("Total", 150, HorizontalAlignment.Left)
            'lvtSale.Columns.Add("Discount", 150, HorizontalAlignment.Left)
            'lvtSale.Columns.Add("GrandTotal", 150, HorizontalAlignment.Left)
        Next

    End Sub
    Private Sub LoadProductCAT()
        Dim sql As String
        sql = "SELECT      ProductCAT.Code,ProductCAT.Title AS ProductCATTitle,ISNULL( SUM(SaleDetail.Total),0) as sumamt"
        sql &= " FROM         Sale INNER JOIN"
        sql &= "                SaleDetail ON Sale.Code = SaleDetail.Sale INNER JOIN"
        sql &= "               Product ON SaleDetail.Product = Product.Code RIGHT OUTER JOIN"
        sql &= "              ProductCAT ON Product.ProductCAT = ProductCAT.Code"
        sql &= "                      AND   CONVERT(date, sale.saledatetime)>=@SaleStartDate  and CONVERT(date, sale.saledatetime)<=@SaleFinishDate"
        sql &= "    group by ProductCAT.Code,ProductCAT.Title"
        sql &= "  ORDER BY code"

        Dim param(1) As SqlParameter
        param(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        param(0).Value = CDate(dtpStart.Value).Date

        param(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        param(1).Value = CDate(dtpStop.Value).Date
        dtProductCAT = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, param)








        lvtProductCAT.Items.Clear()
        Dim i As Integer
        For i = 0 To dtProductCAT.Rows.Count - 1
            Dim item(11) As String
            item(0) = ConvertNullToString(dtProductCAT.Rows(i).Item("ProductCATTitle"))
            item(1) = ConvertNullToZero(dtProductCAT.Rows(i).Item("sumamt"))

            Dim lr As New ListViewItem(item)

            lvtProductCAT.Items.Add(lr)
        Next
    End Sub

    Private Sub loadSaleDetail()
        Dim sql As String

   
        'sql = "SELECT     (s.discount/(select count(saledetail.sale) from  saledetail  where sale=s.Code)) as billdiscount,"

        'sql &= " SaleDetail.Total-(s.discount/(select count(saledetail.sale) from  saledetail  where sale=s.Code)) as DetailTotal,"
        'sql &= "  S.SaleDateTime, S.Code, S.Customer AS customerID, TitlePrefix_1.Title, Customer.Name, Customer.NickName, S.Stylist AS stylistID, TitlePrefix.Title AS EmployeeTitle, "
        'sql &= "              Employee.Firstname, Employee.Lastname, S.GrandTotal, SaleDetail.Product, Product.Title AS ProductTitle, Product.ProductCAT, ProductCAT.Title AS ProductCATTitle, SaleDetail.UnitPrice, SaleDetail.Quantity, "
        'sql &= " SaleDetail.Discount, SaleDetail.Total"
        'sql &= "  FROM         Sale s INNER JOIN"
        'sql &= "                    Customer ON S.Customer = Customer.ID INNER JOIN"
        'sql &= "                  Employee ON S.Stylist = Employee.ID INNER JOIN"
        'sql &= "                  TitlePrefix ON Employee.Title = TitlePrefix.Code INNER JOIN"
        'sql &= "                 SaleDetail ON S.Code = SaleDetail.Sale INNER JOIN"
        'sql &= "                 Product ON SaleDetail.Product = Product.Code INNER JOIN"
        'sql &= "                  ProductCAT ON Product.ProductCAT = ProductCAT.Code LEFT OUTER JOIN"
        'sql &= "                 TitlePrefix AS TitlePrefix_1 ON Customer.Title = TitlePrefix_1.Code where  CONVERT(date, S.saledatetime)>=@SaleStartDate  and CONVERT(date, S.saledatetime)<=@SaleFinishDate order by saledatetime"
        sql = "select  * from (SELECT     s.Discount /"
        sql &= "                   (SELECT     COUNT(Sale) AS Expr1"
        sql &= "  FROM SaleDetail"
        sql &= "                      WHERE      (Sale = s.Code)) AS billdiscount, SaleDetail_1.Total - s.Discount /"
        sql &= "                    (SELECT     COUNT(Sale) AS Expr1"
        sql &= "                     FROM          SaleDetail AS SaleDetail_2"
        sql &= "                     WHERE      (Sale = s.Code)) AS DetailTotal, s.SaleDateTime, s.Code, s.Customer AS customerID, TitlePrefix_1.Title, Customer.Name, Customer.NickName, s.Stylist AS stylistID, "
        sql &= "               TitlePrefix.Title AS EmployeeTitle, Employee.Firstname, Employee.Lastname, s.GrandTotal, SaleDetail_1.Product, Product.Title AS ProductTitle, Product.ProductCAT, "
        sql &= "               ProductCAT.Title AS ProductCATTitle, SaleDetail_1.UnitPrice, SaleDetail_1.Quantity, SaleDetail_1.Discount, SaleDetail_1.Total, SaleDetail_1.Stylist"
        sql &= "  , SalePayment.PaymentMethod,"
        sql &= "        SalePayment.PaidAmt "
        sql &= "  FROM         SaleDetail AS SaleDetail_1 INNER JOIN"
        sql &= "                     Sale AS s INNER JOIN"
        sql &= "                  Customer ON s.Customer = Customer.ID ON SaleDetail_1.Sale = s.Code INNER JOIN"
        sql &= "                Product ON SaleDetail_1.Product = Product.Code INNER JOIN"
        sql &= "               ProductCAT ON Product.ProductCAT = ProductCAT.Code INNER JOIN"
        sql &= "              TitlePrefix INNER JOIN"
        sql &= "              Employee ON TitlePrefix.Code = Employee.Title ON SaleDetail_1.Stylist = Employee.ID INNER JOIN"
        sql &= "              SalePayment ON s.Code = SalePayment.Sale LEFT OUTER JOIN"
        sql &= "                TitlePrefix AS TitlePrefix_1 ON Customer.Title = TitlePrefix_1.Code where  CONVERT(date, S.saledatetime)>=@SaleStartDate  and CONVERT(date, S.saledatetime)<=@SaleFinishDate ) d   "
        sql &= "   pivot (        SUM(PaidAmt)  for PaymentMethod in ([CASH],   [COUPON], [CREDITCARD],   [VOUCHER])  ) piv order by code "

        Dim param(1) As SqlParameter
        param(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        param(0).Value = CDate(dtpStart.Value).Date

        param(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        param(1).Value = CDate(dtpStop.Value).Date
        dtSaleDetail = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, param)








        lvtSaleDetail.Items.Clear()
        Dim i As Integer
        For i = 0 To dtSaleDetail.Rows.Count - 1
            Dim item(13) As String
            item(0) = dtSaleDetail.Rows(i).Item("Code")
            item(1) = dtSaleDetail.Rows(i).Item("SaleDatetime")

            item(2) = ConvertNullToString(dtSaleDetail.Rows(i).Item("CustomerID"))
            item(3) = ConvertNullToString(dtSaleDetail.Rows(i).Item("Name"))
            item(4) = ConvertNullToString(dtSaleDetail.Rows(i).Item("NickName"))

            item(5) = ConvertNullToString(dtSaleDetail.Rows(i).Item("EmployeeTitle")) & " " & ConvertNullToString(dtSaleDetail.Rows(i).Item("Firstname")) & " " & ConvertNullToString(dtSaleDetail.Rows(i).Item("LastName"))

            item(6) = ConvertNullToString(dtSaleDetail.Rows(i).Item("Product"))
            item(7) = ConvertNullToString(dtSaleDetail.Rows(i).Item("ProductTitle"))
            item(8) = ConvertNullToString(dtSaleDetail.Rows(i).Item("ProductCatTitle"))
            item(9) = ConvertNullToZero(dtSaleDetail.Rows(i).Item("UnitPrice"))
            item(10) = ConvertNullToZero(dtSaleDetail.Rows(i).Item("Quantity"))
            item(11) = ConvertNullToZero(dtSaleDetail.Rows(i).Item("Discount"))
            item(12) = FormatNumber(dtSaleDetail.Rows(i).Item("billdiscount"), 2)
            ' item(3) = dtSaleDetail.Rows(i).Item("firstname") + " " + dtSaleDetail.Rows(i).Item("lastname")
            item(13) = ConvertNullToZero(dtSaleDetail.Rows(i).Item("DetailTotal"))
            Dim lr As New ListViewItem(item)
            ' lr.Tag = dtSaleDetail.Rows(i).Item("Code")
            lvtSaleDetail.Items.Add(lr)
        Next
    End Sub

    Private Sub loadSumpaymentData()
        Dim sql As String

        'sql = "SELECT     Sale.Code, sale.saledatetime, Sale.Branch, Sale.Shift, Sale.ShiftDate, Sale.Stylist, TitlePrefix_1.Title, Employee.Firstname, Employee.Lastname, TitlePrefix.Title AS Expr1, Customer.Name, Customer.NickName, "
        'sql &= "  Sale.GrandTotal FROM         Sale INNER JOIN"
        'sql &= "                Employee ON Sale.Stylist = Employee.ID INNER JOIN"
        'sql &= "               Customer ON Sale.Customer = Customer.ID LEFT OUTER JOIN"
        'sql &= "                TitlePrefix ON Customer.Title = TitlePrefix.Code LEFT OUTER JOIN"
        'sql &= "                TitlePrefix AS TitlePrefix_1 ON Employee.Title = TitlePrefix_1.Code where  CONVERT(date, sale.saledatetime)=@SaleDate"

        sql = "SELECT     SalePayment.PaymentMethod, sum(SalePayment.PaidAmt) as Amount"
        sql &= "  FROM         Sale INNER JOIN"
        sql &= "                       SalePayment ON Sale.Code = SalePayment.Sale"
        sql &= "                         where  CONVERT(date, sale.saledatetime)>=@SaleStartDate  and CONVERT(date, sale.saledatetime)<=@SaleFinishDate"
        sql &= "                      group by  SalePayment.PaymentMethod"

        Dim param(1) As SqlParameter
        param(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        param(0).Value = CDate(dtpStart.Value).Date

        param(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        param(1).Value = CDate(dtpStop.Value).Date
        dtpayment = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, param)








        ListView1.Items.Clear()
        Dim i As Integer
        For i = 0 To dtpayment.Rows.Count - 1
            Dim item(5) As String
            item(0) = ConvertNullToString(dtpayment.Rows(i).Item("PaymentMethod"))
            item(1) = ConvertNullToZero(dtpayment.Rows(i).Item("Amount"))

            Dim lr As New ListViewItem(item)
            ' lr.Tag = dt.Rows(i).Item("Code")
            ListView1.Items.Add(lr)
        Next
    End Sub

    Private Sub button_edit_Click_1(sender As Object, e As EventArgs) Handles button_edit.Click
        ExportToExcel(dtpayment, dtSale, dtSaleDetail, dtSalePayment)
    End Sub
    Private Sub button_edit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        LoadProductCAT()
        loadSumpaymentData()
        LoadSale()
        loadSaleDetail()
        LoadSalePayment()
    End Sub

    Private Sub lvtItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvtSaleDetail.SelectedIndexChanged

    End Sub

    Function ConvertNullToZero(para As Object)
        Dim reValue As Decimal
        If para Is DBNull.Value Then
            reValue = 0
        Else
            reValue = para
        End If
        Return reValue
    End Function

    Function ConvertNullToString(para As Object) As String
        Dim reValue As String
        If para Is DBNull.Value Then
            reValue = ""
        Else
            reValue = para
        End If
        Return reValue
    End Function
End Class