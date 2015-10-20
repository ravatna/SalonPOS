Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports System.Configuration
Imports System.Xml.Serialization
Imports System.IO
Imports System.Text

Public Class ExportData




    Private Sub service_memo_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
       
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


    Sub DataTable2CSV(ByVal table As DataTable, ByVal filename As String, _
    ByVal sepChar As String)
        Dim writer As System.IO.StreamWriter
        Try
            writer = New System.IO.StreamWriter(filename)

            ' first write a line with the columns name
            Dim sep As String = ""
            Dim builder As New System.Text.StringBuilder
            For Each col As DataColumn In table.Columns
                builder.Append(sep).Append(col.ColumnName)
                sep = sepChar
            Next
            writer.WriteLine(builder.ToString())

            ' then write all the rows
            For Each row As DataRow In table.Rows
                sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In table.Columns
                    builder.Append(sep).Append(row(col.ColumnName))
                    sep = sepChar
                Next
                writer.WriteLine(builder.ToString())
            Next
        Finally
            If Not writer Is Nothing Then writer.Close()
        End Try
    End Sub

    Private Sub ExportToCSV(dt As DataTable, DesPAth As String)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Dim str As New StringBuilder

        For Each dr As DataRow In dt.Rows

            For Each field As Object In dr.ItemArray

                str.Append(field.ToString & ",")

            Next

            str.Replace(",", vbNewLine, str.Length - 1, 1)

        Next



        Try

            My.Computer.FileSystem.WriteAllText(DesPAth, str.ToString, False)

        Catch ex As Exception

            MessageBox.Show("Write Error")

        End Try
    End Sub

    Private Sub ExportToExcel(datatablePayment As DataTable)
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
        f.FileName = "ExportData" & Date.Now.ToString("yyyyMMddhhmm")
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






                'Save file in final path
                oBook.SaveAs(finalpath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, _
                Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, _
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)


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





    Function ConvertNullToZero(para As Object)
        Dim reValue As Decimal
        If para Is DBNull.Value Then
            reValue = 0
        Else
            reValue = para
        End If
        Return reValue
    End Function





    Private Sub button_edit_Click_1(sender As Object, e As EventArgs) Handles button_edit.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

        Dim dtCustomer As DataTable
        Dim dtSale As DataTable
        Dim dtSaleDetail As DataTable
        Dim dtSalePayment As DataTable


        Dim sql As String = "select * from customer   where  CONVERT(date, lastupdatedate)>=@SaleStartDate  and CONVERT(date, lastupdatedate)<=@SaleFinishDate order by InsertDate "
        Dim paramCustomer(1) As SqlParameter
        paramCustomer(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        paramCustomer(0).Value = CDate(dtpStart.Value).Date

        paramCustomer(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        paramCustomer(1).Value = CDate(dtpEnd.Value).Date
        dtCustomer = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, paramCustomer)
        DataTable2CSV(dtCustomer, ConfigurationManager.AppSettings("DirCSVExport") & "Customer_" & Date.Now.ToString("yyyyMMddHHmmss") & ".csv", "|")






        sql = "select * from sale   where  CONVERT(date, InsertDate)>=@SaleStartDate  and CONVERT(date, InsertDate)<=@SaleFinishDate order by InsertDate "
        Dim paramSale(1) As SqlParameter
        paramSale(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        paramSale(0).Value = CDate(dtpStart.Value).Date

        paramSale(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        paramSale(1).Value = CDate(dtpEnd.Value).Date
        dtSale = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, paramSale)
        ' ExportToExcel(dtSale)
        DataTable2CSV(dtSale, ConfigurationManager.AppSettings("DirCSVExport") & "Sale_" & Date.Now.ToString("yyyyMMddHHmmss") & ".csv", "|")


        sql = "select * from saleDetail   where  CONVERT(date, InsertDate)>=@SaleStartDate  and CONVERT(date,InsertDate)<=@SaleFinishDate order by InsertDate "
        Dim paramSaleDetail(1) As SqlParameter
        paramSaleDetail(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        paramSaleDetail(0).Value = CDate(dtpStart.Value).Date

        paramSaleDetail(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        paramSaleDetail(1).Value = CDate(dtpEnd.Value).Date
        dtSaleDetail = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, paramSaleDetail)
        'ExportToExcel(dtSaleDetail)
        DataTable2CSV(dtSaleDetail, ConfigurationManager.AppSettings("DirCSVExport") & "SaleDetail_" & Date.Now.ToString("yyyyMMddHHmmss") & ".csv", "|")


        sql = "select * from salePayment   where  CONVERT(date, InsertDate)>=@SaleStartDate  and CONVERT(date, InsertDate)<=@SaleFinishDate order by InsertDate "
        Dim paramSalePayment(1) As SqlParameter
        paramSalePayment(0) = New SqlClient.SqlParameter("@SaleStartDate", SqlDbType.DateTime)
        paramSalePayment(0).Value = CDate(dtpStart.Value).Date

        paramSalePayment(1) = New SqlClient.SqlParameter("@SaleFinishDate", SqlDbType.DateTime)
        paramSalePayment(1).Value = CDate(dtpEnd.Value).Date
        dtSalePayment = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql, paramSalePayment)
        'ExportToExcel(dtSalePayment)
        DataTable2CSV(dtSalePayment, ConfigurationManager.AppSettings("DirCSVExport") & "SalePayment_" & Date.Now.ToString("yyyyMMddHHmmss") & ".csv", "|")

        MessageBox.Show("complete")
    End Sub
    Private Sub button_edit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click

    End Sub

    Private Sub lvtItem_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImportCustomer()

    End Sub

    Sub ImportData(tableName As String)

        Dim sql As String
        sql = "select *  from " & tableName
        Dim dtCustomer As DataTable
        dtCustomer = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection2, CommandType.Text, sql)



        Dim dv As New DataView(dtCustomer)

        Dim di As New IO.DirectoryInfo(ConfigurationManager.AppSettings("DirCSVExport"))
        Dim diar1 As IO.FileInfo() = di.GetFiles(tableName & "_*.csv", SearchOption.AllDirectories)
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        For Each dra In diar1





            Dim sr As StreamReader = New StreamReader(ConfigurationManager.AppSettings("DirCSVExport") & dra.Name, Encoding.GetEncoding("TIS-620"))
            sr.ReadLine()
            Dim line As String = ""

            Dim Conn1 As SqlConnection = ConnectionManagement.GetConnection2
            Dim transaction As SqlTransaction

            If Conn1.State = ConnectionState.Closed Then
                Conn1.Open()
            End If
            transaction = Conn1.BeginTransaction()
            Try

                Dim csvarry() As String
                Dim words() As String
                While (sr.Peek <> -1)
                    words = sr.ReadLine.Split("|")
                    ReDim csvarry(words.Count)

                    For i = 0 To words.Count - 1
                        csvarry(i) = words(i).Trim
                    Next






                    dv.RowFilter = "Code='" & csvarry(0) & "'"
                    Dim strSQL As String
                    If dv.Count > 0 Then
                        Dim ds() As String = csvarry(words.Count - 4).ToString.Split("/")
                        Dim oldData As DateTime
                        If ds(0).ToString.Length = 1 And ds(1).ToString.Length = 1 Then
                            oldData = Date.ParseExact(csvarry(words.Count - 4), "M/d/yyyy HH:mm:ss tt",
                  System.Globalization.DateTimeFormatInfo.InvariantInfo)

                        ElseIf ds(0).ToString.Length = 1 And ds(1).ToString.Length = 2 Then
                            oldData = Date.ParseExact(csvarry(words.Count - 4), "M/dd/yyyy HH:mm:ss tt",
                  System.Globalization.DateTimeFormatInfo.InvariantInfo)
                        ElseIf ds(0).ToString.Length = 2 And ds(1).ToString.Length = 1 Then
                            oldData = Date.ParseExact(csvarry(words.Count - 4), "MM/d/yyyy HH:mm:ss tt",
                  System.Globalization.DateTimeFormatInfo.InvariantInfo)

                        Else
                            oldData = Date.ParseExact(csvarry(words.Count - 4), "MM/dd/yyyy HH:mm:ss tt",
                System.Globalization.DateTimeFormatInfo.InvariantInfo)

                        End If

                      

                        'If CDate(dv(0).Row("LastUpdateDate")).ToString("M/d/yyyy HH:mm:ss") = LastUpdateDate Then
                        If dv(0).Row("LastUpdateDate") < oldData Then
                            strSQL = "UPDATE " & tableName & " set "
                            Dim j As Integer
                            For j = 0 To dtCustomer.Columns.Count - 1
                                Dim value As String
                                If words(j).Trim = "" Then
                                    value = ConvertStringtoNull(words(j).Trim)
                                Else
                                    value = "'" & words(j).Trim & "'"
                                End If


                                If j = 0 Then
                                ElseIf j = 1 Then
                                    strSQL &= " " & dtCustomer.Columns(j).Caption & " = " & value

                                Else
                                    strSQL &= "," & dtCustomer.Columns(j).Caption & " = " & value
                                End If
                            Next
                            strSQL &= " WHERE  CODE ='" & csvarry(0) & "'"
                            Dim SqlCom As SqlCommand = New SqlCommand(strSQL, Conn1, transaction)
                            'Dim SqlDa As SqlDataReader = SqlCom.ExecuteReader
                            SqlCom.ExecuteNonQuery()
                        End If




                    Else

                        strSQL = " INSERT INTO " & tableName

                        strSQL &= "   VALUES "
                        Dim j As Integer
                        'For j = 0 To dtCustomer.Columns.Count - 1
                        '    If j = 0 Then
                        '        strSQL &= " ('" & dtCustomer.Columns(j).Caption & "'"
                        '    ElseIf j = dtCustomer.Columns.Count - 1 Then
                        '        strSQL &= " ,'" & dtCustomer.Columns(j).Caption & "')"
                        '    Else
                        '        strSQL &= " ,'" & dtCustomer.Columns(j).Caption & "'"
                        '    End If
                        'Next

                        For j = 0 To dtCustomer.Columns.Count - 1
                            Dim value As String
                            If words(j).Trim = "" Then
                                value = ConvertStringtoNull(words(j).Trim)
                            Else
                                value = "'" & words(j).Trim & "'"
                            End If
                            If j = 0 Then
                                strSQL &= " (" & value
                            ElseIf j = dtCustomer.Columns.Count - 1 Then
                                strSQL &= " ," & value & ")"
                            Else
                                strSQL &= " ," & value
                            End If
                        Next




                        Dim SqlCom As SqlCommand = New SqlCommand(strSQL, Conn1, transaction)
                        'Dim SqlDa As SqlDataReader = SqlCom.ExecuteReader
                        SqlCom.ExecuteNonQuery()
                    End If


                End While
                sr.Close()
                transaction.Commit()
                'txt_folderactivity.Text &= "Tranfer " & FileName & " Completed" & vbCrLf
                My.Computer.FileSystem.MoveFile(ConfigurationManager.AppSettings("DirCSVExport") & dra.Name, ConfigurationManager.AppSettings("DirCSVComplete") & dra.Name, True)
                MessageBox.Show("completed")
            Catch ex As Exception
                sr.Close()
                MessageBox.Show(ex.Message)
                '  transaction.Rollback()
                '  txt_folderactivity.Text &= "Tranfer " & FileName & _
                ' " Failed" & vbCrLf
            End Try

        Next
    End Sub

    Sub ImportCustomer()

        Dim sql As String
        sql = "select *  from Customer"
        Dim dtCustomer
        dtCustomer = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection2, CommandType.Text, sql)
        Dim dv As New DataView(dtCustomer)

        Dim di As New IO.DirectoryInfo(ConfigurationManager.AppSettings("DirCSVExport"))
        Dim diar1 As IO.FileInfo() = di.GetFiles("Customer_*.csv", SearchOption.AllDirectories)
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        For Each dra In diar1





            Dim sr As StreamReader = New StreamReader(ConfigurationManager.AppSettings("DirCSVExport") & dra.Name, Encoding.GetEncoding("TIS-620"))
            sr.ReadLine()
            Dim line As String = ""

            Dim Conn1 As SqlConnection = ConnectionManagement.GetConnection2
            Dim transaction As SqlTransaction

            If Conn1.State = ConnectionState.Closed Then
                Conn1.Open()
            End If
            transaction = Conn1.BeginTransaction()
            Try

                



                While (sr.Peek <> -1)
                    'While (Not (sr.ReadLine) Is DBNull.Value)

                    Dim words() As String = sr.ReadLine.Split("|")

                    Dim ID As String = words(0).Trim
                    Dim Branch As String = words(1).Trim
                    Dim Title As String = words(2).Trim
                    Dim Name As String = words(3).Trim
                    Dim Firstname As String = words(4).Trim
                    Dim Lastname As String = words(5).Trim
                    Dim NickName As String = words(6).Trim
                    Dim Address As String = words(7).Trim
                    Dim SubDistrict As String = words(8).Trim
                    Dim District As String = words(9).Trim
                    Dim Province As String = words(10).Trim
                    Dim ZipCode As String = words(11).Trim
                    Dim Country As String = words(12).Trim
                    Dim Email As String = words(13).Trim
                    Dim Phone As String = words(14).Trim
                    Dim TAXID As String = words(15).Trim
                    Dim Credit As String = words(16).Trim
                    Dim NameImage As String = words(17).Trim
                    Dim AddressImage As String = words(18).Trim
                    Dim BirthDay As String = words(19).Trim
                    Dim BirthMonth As String = words(20).Trim
                    Dim Customertype As String = words(21).Trim
                    Dim Stylist As String = words(22).Trim
                    Dim Family As String = words(23).Trim
                    Dim [Friend] As String = words(24).Trim
                    Dim website As String = words(25).Trim
                    Dim OtherWebsite As String = words(26).Trim
                    Dim Facebook As String = words(27).Trim
                    Dim Instagram As String = words(28).Trim
                    Dim Magazine As String = words(29).Trim
                    Dim WalkIn As String = words(30).Trim
                    Dim OtherReason As String = words(31).Trim
                    Dim Remark As String = words(32).Trim
                    Dim Status As String = words(33).Trim
                    Dim InsertDate As String = words(34).Trim
                    Dim InsertUser As String = words(35).Trim
                    Dim InsertIP As String = words(36).Trim
                    Dim LastUpdateDate As String = words(37).Trim
                    Dim LastUpdateUser As String = words(38).Trim
                    Dim LastUpdateIP As String = words(39).Trim
                    dv.RowFilter = "ID='" & ID & "'"
                    Dim strSQL As String
                    If dv.Count > 0 Then


                        Dim oldData As DateTime = Date.ParseExact(LastUpdateDate, "MM/dd/yyyy HH:mm:ss tt",
                System.Globalization.DateTimeFormatInfo.InvariantInfo)

                        'If CDate(dv(0).Row("LastUpdateDate")).ToString("M/d/yyyy HH:mm:ss") = LastUpdateDate Then
                        If dv(0).Row("LastUpdateDate") < oldData Then
                            MessageBox.Show("xx")

                            strSQL = "UPDATE [dbo].[Customer]"
                            strSQL &= " set [Branch] =  '" & Branch & "'"
                            strSQL &= ",[Title] =  '" & Title & "'"
                            strSQL &= ",[Name] =  '" & Name & "'"
                            strSQL &= ",[Firstname] =  '" & Firstname & "'"
                            strSQL &= ",[Lastname] =  '" & Lastname & "'"
                            strSQL &= ",[NickName] =  '" & NickName & "'"
                            strSQL &= ",[Address] =  '" & Address & "'"
                            strSQL &= ",[SubDistrict] =  '" & SubDistrict & "'"
                            strSQL &= ",[District] =  '" & District & "'"
                            strSQL &= ",[Province] =  '" & Province & "'"
                            strSQL &= ",[ZipCode] =  '" & ZipCode & "'"
                            strSQL &= ",[Country] =  '" & Country & "'"
                            strSQL &= ",[Email] =  '" & Email & "'"
                            strSQL &= ",[Phone] =  '" & Phone & "'"
                            strSQL &= ",[TAXID] =  '" & TAXID & "'"
                            strSQL &= ",[Credit] =  " & ConvertStringtoNull(Credit)

                            strSQL &= ",[BirthDay] =  " & ConvertStringtoNull(BirthDay)
                            strSQL &= ",[BirthMonth] =  " & ConvertStringtoNull(BirthMonth)
                            strSQL &= ",[Customertype] =  '" & Customertype & "'"
                            strSQL &= ",[Stylist] =  '" & Stylist & "'"
                            strSQL &= ",[Family] =  '" & Family & "'"
                            strSQL &= ",[Friend] =  '" & [Friend] & "'"
                            strSQL &= ",[website] =  '" & website & "'"
                            strSQL &= ",[OtherWebsite] =  '" & OtherWebsite & "'"
                            strSQL &= ",[Facebook] =  '" & Facebook & "'"
                            strSQL &= ",[Instagram] =  '" & Instagram & "'"
                            strSQL &= ",[Magazine] =  '" & Magazine & "'"
                            strSQL &= ",[WalkIn] =  '" & WalkIn & "'"
                            strSQL &= ",[OtherReason] =  '" & OtherReason & "'"
                            strSQL &= ",[Remark] =  '" & Remark & "'"
                            strSQL &= ",[Status] =  '" & Status & "'"
                            strSQL &= ",[InsertDate] =  '" & InsertDate & "'"
                            strSQL &= ",[InsertUser] =  '" & InsertUser & "'"
                            strSQL &= ",[InsertIP] =  '" & InsertIP & "'"
                            strSQL &= ",[LastUpdateDate] =  '" & LastUpdateDate & "'"
                            strSQL &= ",[LastUpdateUser] =  '" & LastUpdateUser & "'"
                            strSQL &= ",[LastUpdateIP] =  '" & LastUpdateIP & "'"
                            strSQL &= " WHERE  ID ='" & ID & "'"
                            Dim SqlCom As SqlCommand = New SqlCommand(strSQL, Conn1, transaction)
                            'Dim SqlDa As SqlDataReader = SqlCom.ExecuteReader
                            SqlCom.ExecuteNonQuery()
                        End If




                    Else

                        strSQL = " INSERT INTO [dbo].[Customer]"
                        strSQL &= "  ([ID]"
                        strSQL &= ",[Branch]"
                        strSQL &= "  ,[Title]"
                        strSQL &= "  ,[Name]"
                        strSQL &= "  ,[Firstname]"
                        strSQL &= "  ,[Lastname]"
                        strSQL &= "  ,[NickName]"
                        strSQL &= "  ,[Address]"
                        strSQL &= "  ,[SubDistrict]"
                        strSQL &= "  ,[District]"
                        strSQL &= "  ,[Province]"
                        strSQL &= "  ,[ZipCode]"
                        strSQL &= "  ,[Country]"
                        strSQL &= "  ,[Email]"
                        strSQL &= "  ,[Phone]"
                        strSQL &= "  ,[TAXID]"
                        strSQL &= "  ,[Credit]"
                        'StrSql &= "  ,[NameImage]"
                        'StrSql &= "  ,[AddressImage]"
                        strSQL &= "  ,[BirthDay]"
                        strSQL &= "  ,[BirthMonth]"
                        strSQL &= "  ,[Customertype]"
                        strSQL &= "  ,[Stylist]"
                        strSQL &= "  ,[Family]"
                        strSQL &= "  ,[Friend]"
                        strSQL &= "  ,[website]"
                        strSQL &= "  ,[OtherWebsite]"
                        strSQL &= "  ,[Facebook]"
                        strSQL &= "  ,[Instagram]"
                        strSQL &= "  ,[Magazine]"
                        strSQL &= "  ,[WalkIn]"
                        strSQL &= "  ,[OtherReason]"
                        strSQL &= "  ,[Remark]"
                        strSQL &= "  ,[Status]"
                        strSQL &= "  ,[InsertDate]"
                        strSQL &= "  ,[InsertUser]"
                        strSQL &= "  ,[InsertIP]"
                        strSQL &= "  ,[LastUpdateDate]"
                        strSQL &= "  ,[LastUpdateUser]"
                        strSQL &= "  ,[LastUpdateIP])"
                        strSQL &= "     VALUES "
                        strSQL &= "('" & ID & "'"
                        strSQL &= ",'" & Branch & "'"
                        strSQL &= ",'" & Title & "'"
                        strSQL &= ",'" & Name & "'"
                        strSQL &= ",'" & Firstname & "'"
                        strSQL &= ",'" & Lastname & "'"
                        strSQL &= ",'" & NickName & "'"
                        strSQL &= ",'" & Address & "'"
                        strSQL &= ",'" & SubDistrict & "'"
                        strSQL &= ",'" & District & "'"
                        strSQL &= ",'" & Province & "'"
                        strSQL &= ",'" & ZipCode & "'"
                        strSQL &= ",'" & Country & "'"
                        strSQL &= ",'" & Email & "'"
                        strSQL &= ",'" & Phone & "'"
                        strSQL &= ",'" & TAXID & "'"
                        strSQL &= "," & ConvertStringtoNull(Credit)
                        strSQL &= "," & ConvertStringtoNull(BirthDay)
                        strSQL &= "," & ConvertStringtoNull(BirthMonth)

                        strSQL &= ",'" & Customertype & "'"
                        strSQL &= ",'" & Stylist & "'"
                        strSQL &= ",'" & Family & "'"
                        strSQL &= ",'" & [Friend] & "'"
                        strSQL &= ",'" & website & "'"
                        strSQL &= ",'" & OtherWebsite & "'"
                        strSQL &= ",'" & Facebook & "'"
                        strSQL &= ",'" & Instagram & "'"
                        strSQL &= ",'" & Magazine & "'"
                        strSQL &= ",'" & WalkIn & "'"
                        strSQL &= ",'" & OtherReason & "'"
                        strSQL &= ",'" & Remark & "'"
                        strSQL &= ",'" & Status & "'"
                        strSQL &= ",'" & InsertDate & "'"
                        strSQL &= ",'" & InsertUser & "'"
                        strSQL &= ",'" & InsertIP & "'"
                        strSQL &= ",'" & LastUpdateDate & "'"
                        strSQL &= ",'" & LastUpdateUser & "'"
                        strSQL &= ",'" & LastUpdateIP & "')"
                        Dim SqlCom As SqlCommand = New SqlCommand(strSQL, Conn1, transaction)
                        'Dim SqlDa As SqlDataReader = SqlCom.ExecuteReader
                        SqlCom.ExecuteNonQuery()
                    End If


                End While
                sr.Close()
                transaction.Commit()
                'txt_folderactivity.Text &= "Tranfer " & FileName & " Completed" & vbCrLf
                My.Computer.FileSystem.MoveFile(ConfigurationManager.AppSettings("DirCSVExport") & dra.Name, ConfigurationManager.AppSettings("DirCSVComplete") & dra.Name, True)
                MessageBox.Show("completed")
            Catch ex As Exception
                sr.Close()
                MessageBox.Show(ex.Message)
                '  transaction.Rollback()
                '  txt_folderactivity.Text &= "Tranfer " & FileName & _
                ' " Failed" & vbCrLf
            End Try

        Next
    End Sub

    Function ConvertStringtoNull(para As String)
        Dim reValue As String
        If para = "" Then
            reValue = "null"
        Else
            reValue = para
        End If
        Return reValue
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ImportData("Sale")
    End Sub
End Class