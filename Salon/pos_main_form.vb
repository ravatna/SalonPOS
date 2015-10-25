Imports System.Data.SqlClient
Imports System.Threading
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing

Imports System.Runtime.InteropServices

Public Class pos_main_form
    Dim prDoc As PrintDocument = New Printing.PrintDocument
    Dim DiscountAmt As Decimal
    Dim DiscountType As String

    Dim _CustomerCode As String
    Dim _BillNo As String
    Dim _RefBillNo As String

    Dim Change As Decimal
    Dim result_paid As Decimal
    Dim UnPaid As Decimal

    Public Property BillNo() As String
        Get
            Return _BillNo
        End Get
        Set(value As String)
            _BillNo = value
        End Set
    End Property

    Public Property RefBillNo() As String
        Get
            Return _RefBillNo
        End Get
        Set(value As String)
            _RefBillNo = value
        End Set
    End Property

    Public Property CustomerCode() As String
        Get
            Return _CustomerCode
        End Get
        Set(ByVal value As String)
            _CustomerCode = value
        End Set
    End Property

    Dim _PaymentList As DataTable
    Public Property PaymentList() As DataTable
        Get
            Return _PaymentList
        End Get
        Set(ByVal value As DataTable)
            _PaymentList = value
        End Set
    End Property

    Private Sub AnyString_Lucida(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        Dim UseFont As New Font("Lucida Sans Typewriter", 9, FontStyle.Bold)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub AnyString_Lucida1(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        Dim UseFont As New Font("Lucida Sans Typewriter", 18, FontStyle.Bold)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub AnyString_Lucida2(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        Dim UseFont As New Font("Lucida Sans Typewriter", 8, FontStyle.Bold)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub AnyString_Tahoma2(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        Dim UseFont As New Font("Tahoma", 8, FontStyle.Bold)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub AnyString_Tahoma(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        Dim UseFont As New Font("Tahoma", 9, FontStyle.Bold)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub AnyString_barcode(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        Dim UseFont As New Font("WASP 39 LC TTF", 17, FontStyle.Bold)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub


    Private Sub BmpDraw(ByVal g As Graphics, ByVal img As Bitmap, ByVal xPos As Integer, ByVal yPos As Integer)
        g.DrawImage(img, xPos, yPos)
        g.Dispose()
    End Sub



    Sub CalChangeForCash()
        lblChange.Text = "0.00"
        ' result_paid = 0
        ' Change = 0
        Dim i As Integer
        Dim result_paid As Decimal
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text.ToUpper = "CASH" Then
                ' Change = (CDec(ListView1.Items(i).SubItems(2).Text) - CDec(ListView1.Items(i).SubItems(1).Text)).ToString("F2")
                lblChange.Text = (CDec(ListView1.Items(i).SubItems(2).Text) - CDec(ListView1.Items(i).SubItems(1).Text)).ToString("F2")
            End If
            result_paid = result_paid + CDec(ListView1.Items(i).SubItems(1).Text)
        Next
        ' lblChange.Text = Change.ToString("F2")
        label_result_paid.Text = result_paid.ToString("F2")
    End Sub
    Private Sub button_payment_cash_Click(sender As Object, e As EventArgs) Handles btnCash.Click


        Dim frm As New pos_payment_cash
        frm.grandTotal = lblGrandTotal.Text
        frm.UnPaid = lblUnPaid.Text
        frm.PaymentType = "CASH"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddPaymentMethod("CASH", frm.SplitPay.ToString("F2"), frm.Pay.ToString("F2"))
            SettingPaymentButton()

            CalChangeForCash()
        End If
    End Sub

    Sub AddPaymentMethod(paymenttype As String, splite As Decimal, amt As Decimal, Optional CardNo As String = "")
        Dim b As Boolean = False
        For j = 0 To ListView1.Items.Count - 1
            If ListView1.Items(j).SubItems(0).Text = paymenttype Then
                b = True
                Exit For
            End If

        Next

        If b = True Then
        Else
            Dim item(3) As String
            item(0) = paymenttype
            item(1) = splite
            item(2) = amt
            item(3) = CardNo
            Dim lr As New ListViewItem(item)
            lr.Tag = ""
            ListView1.Items.Add(lr)


            CalUnPaid()

        End If
    End Sub
    Sub CalUnPaid()
        Dim netPOice As Decimal
        Dim TotalPOice As Decimal = 0
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(1).Text <> "" Then
                TotalPOice += ListView1.Items(i).SubItems(1).Text
            End If

        Next


        'End If
        If CDec(lblGrandTotal.Text) - TotalPOice <= 0 Then
            lblUnPaid.Text = 0
        Else
            lblUnPaid.Text = CDec(lblGrandTotal.Text) - TotalPOice
        End If



        SettingPaymentButton()

    End Sub

    Sub SettingPaymentButton(Optional CalChange As Boolean = True)
        btnCash.Enabled = True
        btnCreditCard.Enabled = True
        btnCoupon.Enabled = True
        btnVoucher.Enabled = True
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text = "CASH" Then
                btnCash.Enabled = False
                Exit For
            Else
                btnCash.Enabled = True
            End If

        Next
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text = "CREDITCARD" Then
                btnCreditCard.Enabled = False
                Exit For
            Else
                btnCreditCard.Enabled = True
            End If

        Next
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text = "VOUCHER" Then
                btnVoucher.Enabled = False
                Exit For
            Else
                btnVoucher.Enabled = True
            End If

        Next
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text.ToUpper = "COUPON" Then
                btnCoupon.Enabled = False
                Exit For
            Else
                btnCoupon.Enabled = True
            End If

        Next

        If CalChange = True Then
            CalChangeForCash()
        End If

    End Sub
    Private Sub button_payment_credit_card_Click(sender As Object, e As EventArgs) Handles btnCreditCard.Click
        Dim frm As New pos_payment_credit_card
        frm.grandTotal = lblGrandTotal.Text
        frm.UnPaid = lblUnPaid.Text
        frm.PaymentType = "CREDITCARD"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddPaymentMethod("CREDITCARD", frm.SplitPay.ToString("F2"), frm.Pay.ToString("F2"), frm.CardNo)
            SettingPaymentButton()
        End If
    End Sub

    Private Sub button_payment_coupon_Click(sender As Object, e As EventArgs) Handles btnCoupon.Click
        Dim frm As New pos_payment_coupon
        frm.grandTotal = lblGrandTotal.Text
        frm.UnPaid = lblUnPaid.Text
        frm.PaymentType = "COUPON"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddPaymentMethod("COUPON", frm.SplitPay.ToString("F2"), frm.Pay.ToString("F2"), frm.CardNo)
            SettingPaymentButton()
        End If




    End Sub

    Private Sub button_payment_voucher_Click(sender As Object, e As EventArgs) Handles btnVoucher.Click
        Dim frm As New pos_payment_voucher
        frm.grandTotal = lblGrandTotal.Text
        frm.UnPaid = lblUnPaid.Text
        frm.PaymentType = "VOUCHER"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddPaymentMethod("VOUCHER", frm.SplitPay.ToString("F2"), frm.Pay.ToString("F2"), frm.CardNo)
            SettingPaymentButton()
        End If
    End Sub

    Private Sub button_product_Click(sender As Object, e As EventArgs) Handles button_product.Click

        Dim frm As New pos_add_product
        frm.ProductType = "0001"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim sql As String = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
            sql &= " FROM  Product INNER JOIN ProductUnit ON Product.ProductUnit = ProductUnit.Code"
            sql &= " WHERE     (Product.code = '" & frm.ProductCode & "')"

            Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
                Dim existStatus As Boolean = False
                Dim i As Integer
                For i = 0 To lvtItem.Items.Count - 1
                    If dt.Rows(0).Item("Code") = lvtItem.Items(i).SubItems(0).Text And frm.StylishName & "/" & frm.StylishCode = lvtItem.Items(i).SubItems(7).Text And frm.CustomerName & "/" & frm.CustomerCode = lvtItem.Items(i).SubItems(8).Text And frm.CustomerTypeName & "/" & frm.CustomerTypeCode = lvtItem.Items(i).SubItems(9).Text Then
                        lvtItem.Items(i).SubItems(3).Text = lvtItem.Items(i).SubItems(2).Text + 1
                        lvtItem.Items(i).SubItems(6).Text = (lvtItem.Items(i).SubItems(3).Text * lvtItem.Items(i).SubItems(4).Text) / lvtItem.Items(i).SubItems(5).Text
                        existStatus = True
                        Exit For
                    End If
                Next


                If existStatus = False Then
                    Dim item(10) As String
                    item(0) = i + 1
                    item(1) = dt.Rows(0).Item("Code")
                    item(2) = dt.Rows(0).Item("Title")
                    item(3) = frm.QTY
                    item(4) = frm.Price.ToString("F2")
                    item(5) = frm.Discount.ToString("F2")

                    item(6) = CDec((item(3) * item(4)) - item(5)).ToString("F2")

                    item(7) = frm.StylishName & "/" & frm.StylishCode
                    item(8) = frm.CustomerName & "/" & frm.CustomerCode
                    item(9) = frm.CustomerTypeName & "/" & frm.CustomerTypeCode

                    Dim lr As New ListViewItem(item)
                    lvtItem.Items.Add(lr)
                End If



                LoadSumData()
            End Using
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim frm As New pos_add_discount
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If frm.DiscountType = "BATH" Then
                txtDiscount.Text = frm.DiscountAmt
                DiscountAmt = frm.DiscountAmt
                DiscountType = "BATH"
            Else
                Dim discountBath As Decimal
                txtDiscount.Text = (CDec(lblTotal.Text) * frm.DiscountAmt) / 100
                DiscountAmt = frm.DiscountAmt
                DiscountType = "PERCENT"
            End If
            LoadSumData()
        End If
    End Sub

    Function loadProductOrService(ProductCode As String) As DataTable

        Dim sql As String = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
        sql &= " FROM         Product INNER JOIN"
        sql &= " ProductUnit ON Product.ProductUnit = ProductUnit.Code join producttype on Product.producttype=producttype.code where  (Product.Code='" & ProductCode & "')"

        Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

        Return dt

    End Function

    Function loadProductBrand(BrandCode As String) As DataTable
        Dim sql As String = "select * from brand where brand.Code = '" & BrandCode & "'"
        Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        Return dt
    End Function

    Function loadEmployee(EmpCode As String) As String
        Dim sql As String = "select *, isnull(TitlePrefix.Title,'')+' '+firstname + ' ' + lastname  AS fullname FROM         Employee INNER JOIN      TitlePrefix ON Employee.Title = TitlePrefix.Code WHERE     (Employee.ID = '" & EmpCode & "') "
        Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

        'item(7) = frm.StylishName & "/" & frm.StylishCode
        'item(8) = frm.CustomerName & "/" & frm.CustomerCode
        'item(9) = frm.CustomerTypeName & "/" & frm.CustomerTypeCode

        If (dt.Rows.Count < 1) Then Return ""

        Return dt.Rows(0).Item("fullname").ToString() & "/" & dt.Rows(0).Item("ID").ToString()

    End Function

    Function loadCustomer(CustomerCode As String) As String
        Dim sql As String = "select TitlePrefix.title as PrefixTitle, *,province.title as provinceTitle from Customer left outer join province on Customer.province=province.code left outer join TitlePrefix on Customer.title =TitlePrefix.code  where ID='" & CustomerCode & "'"
        Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

        If (dt.Rows.Count < 1) Then Return ""

        Return dt.Rows(0).Item("Name") & "/" & dt.Rows(0).Item("ID").ToString()

        'lblCustomerData.Text = Common.IsNullToString(dt.Rows(0).Item("PrefixTitle")) & " " & dt.Rows(0).Item("Name")
        'lblCustomerData.Text &= "/" & Common.IsNullToString(dt.Rows(0).Item("Nickname"))

        'lblCustomerData.Text &= " (Tel:" & Common.IsNullToString(dt.Rows(0).Item("Phone")) & ")"

    End Function

    Function loadCustomerType(CustomerTypeCode As String) As String
        Dim sql As String = "select * from CustomerVisitType where   Code='" & CustomerTypeCode & "'"
        Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

        If (dt.Rows.Count < 1) Then Return ""

        Return dt.Rows(0).Item("Title").ToString() & "/" & dt.Rows(0).Item("Code").ToString()
    End Function

    Public Sub setCustomerData(CustomerCode As String, customertablename As String)
        Dim sql As String = "select TitlePrefix.title as PrefixTitle, *,province.title as provinceTitle from " & customertablename & " left outer join province on " & customertablename & ".province=province.code left outer join TitlePrefix on " & customertablename & ".title =TitlePrefix.code  where ID='" & CustomerCode & "'"
        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            GlobalVar.POSCustomer = dt.Rows(0).Item("ID")

            lblCustomerData.Text = Common.IsNullToString(dt.Rows(0).Item("PrefixTitle")) & " " & dt.Rows(0).Item("Name")
            lblCustomerData.Text &= "/" & Common.IsNullToString(dt.Rows(0).Item("Nickname"))

            lblCustomerData.Text &= " (Tel:" & Common.IsNullToString(dt.Rows(0).Item("Phone")) & ")"
            If dt.Rows(0).Item("BirthDay") Is DBNull.Value Then
                lblBirthDate.Visible = False
                PictureBoxlblBirthDate.Visible = False
            ElseIf dt.Rows(0).Item("BirthMonth") Is DBNull.Value Then
                lblBirthDate.Visible = False
                PictureBoxlblBirthDate.Visible = False

            Else

                Dim birthDay As Integer = dt.Rows(0).Item("birthDay")
                Dim birthMonth As Integer = dt.Rows(0).Item("birthMonth")
                If birthMonth = Date.Now.Month And birthDay = Date.Now.Day Then
                    lblBirthDate.Visible = True
                    PictureBoxlblBirthDate.Visible = True
                Else
                    lblBirthDate.Visible = False
                    PictureBoxlblBirthDate.Visible = False
                End If

            End If
        End Using
    End Sub

    Sub LoadButtonService(ProductCode As String)
        Dim frm As New pos_select_service
        frm.ProductCode = ProductCode
        Dim sql As String = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
        sql &= " FROM         Product INNER JOIN"
        sql &= "               ProductUnit ON Product.ProductUnit = ProductUnit.Code"
        sql &= " WHERE     (Product.code = '" & frm.ProductCode & "')"

        Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
            frm.ServiceName = dt.Rows(0).Item("Title")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim existStatus As Boolean = False
                Dim i As Integer

                If dt.Rows(0).Item("Code").ToString().Equals("0063") Then
                    If lvtItem.Items.Count > 0 Then
                        MessageBox.Show("Can not add Service or Product with any Coupon.")
                        Exit Sub
                    End If
                End If

                If lvtItem.Items.Count > 0 Then

                    ' วนรอบตรวจสอบการซ้ำกันของรายการ
                    For i = 0 To lvtItem.Items.Count - 1

                        If lvtItem.Items(i).SubItems(1).Text.ToString().Equals("0063") Then
                            MessageBox.Show("Can not add Service or Product with any Coupon.")
                            Exit Sub
                        End If

                        ' todo : ต้องแก้ไขให้รองรับการเลือกบริการเดียวกัน แต่ช่างคนละคนด้วย
                        If dt.Rows(0).Item("Code") = lvtItem.Items(i).SubItems(0).Text And frm.StylishName & "/" & frm.StylishCode = lvtItem.Items(i).SubItems(7).Text And frm.CustomerName & "/" & frm.CustomerCode = lvtItem.Items(i).SubItems(8).Text And frm.CustomerTypeName & "/" & frm.CustomerTypeCode = lvtItem.Items(i).SubItems(9).Text Then
                            lvtItem.Items(i).SubItems(3).Text = lvtItem.Items(i).SubItems(2).Text + 1
                            lvtItem.Items(i).SubItems(6).Text = (lvtItem.Items(i).SubItems(3).Text * lvtItem.Items(i).SubItems(4).Text) / lvtItem.Items(i).SubItems(5).Text
                            existStatus = True
                            Exit For
                        End If
                    Next

                End If

            ' ถ้ารายการที่เลือกเข้ามาไม่มีอยู่ในกริด
            If existStatus = False Then
                Dim item(10) As String
                item(0) = i + 1
                item(1) = dt.Rows(0).Item("Code")
                item(2) = dt.Rows(0).Item("Title")
                item(3) = 1
                item(4) = frm.Price
                item(5) = frm.Discount

                item(6) = (item(3) * item(4)) - item(5)

                item(7) = frm.StylishName & "/" & frm.StylishCode
                item(8) = frm.CustomerName & "/" & frm.CustomerCode
                item(9) = frm.CustomerTypeName & "/" & frm.CustomerTypeCode
                Dim lr As New ListViewItem(item)
                lvtItem.Items.Add(lr)
            End If

            LoadSumData()

            End If
        End Using

    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim frm As New pos_select_member

        frm.CustomerType = "CUSTOMER"


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CustomerCode = frm.CustomerCode

            setCustomerData(CustomerCode, "CUSTOMER")


        End If



    End Sub


    Private Sub button_cancel_bill_Click(sender As Object, e As EventArgs) Handles button_cancel_bill.Click
        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to cancel this bill ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then

            modeSave = "void"

            dialogResult = MessageBox.Show("Are you want to copy this bill ?", "Confirm", MessageBoxButtons.YesNo)

            cancelBill(BillNo)

            If (dialogResult = MsgBoxResult.Yes) Then
                ' เปิดการใช้งานฟอร์ม
                enabledForm(True)

                ' assign new bill 
                RefBillNo = BillNo

                ' get new bill no when need to open new bill
                getNewBillNo()
            Else
                processNewBill()
            End If


        Else


        End If


    End Sub

    Private Function cancelBill(ByVal code As String)
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection

            Dim transaction As SqlTransaction
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            transaction = cnn.BeginTransaction()

            Try
                Dim employee As String
                Dim member As String
                Dim rewardPont As Integer = 0
                Dim sql As String

                Dim i As Integer
                Dim Salecode As String

                ' If GlobalVar.SaleCode = "" Then
                GlobalVar.SaleCode = getCode()



                sql = "update [Sale] set "
                sql &= "     [Status] = 'Cancel'"
                sql &= "     ,[LastUpdateDate] = getdate()"
                sql &= "     ,[LastUpdateUser] = '" & GlobalVar.UserID & "'"
                sql &= "     ,[LastUpdateIP] = '" & Common.GetIPAddress & "'"

                sql &= "WHERE     [Code] = '" & Me.BillNo & "'"

                Dim commanditem = New SqlCommand(sql, cnn, transaction)
                commanditem.CommandText = sql
                commanditem.ExecuteNonQuery()


                sql = "update [SaleDetail] set "
                sql &= "     [Status] = 'Cancel'"
                sql &= "    ,[LastUpdateDate] = getdate()"
                sql &= "     ,[LastUpdateUser] = '" & GlobalVar.UserID & "'"
                sql &= "     ,[LastUpdateIP] = '" & Common.GetIPAddress & "'"

                sql &= "WHERE     [Sale] = '" & Me.BillNo & "'"

                Dim commanditem2 = New SqlCommand(sql, cnn, transaction)
                commanditem2.CommandText = sql
                commanditem2.ExecuteNonQuery()

                    sql = "update [SalePayment] set "
                sql &= "     [Status] = 'Cancel'"
                    sql &= "    ,[LastUpdateDate] = getdate()"
                    sql &= "     ,[LastUpdateUser] = '" & GlobalVar.UserID & "'"
                    sql &= "     ,[LastUpdateIP] = '" & Common.GetIPAddress & "'"

                    sql &= "WHERE     [Sale] = '" & Me.BillNo & "'"

                Dim commanditem3 = New SqlCommand(sql, cnn, transaction)
                commanditem3.CommandText = sql
                commanditem3.ExecuteNonQuery()



                    transaction.Commit()


                    'EnableStatus(False)
                    'btnpay.Enabled = True
                    'btnShiftOpen.Enabled = False
                    'btnFullTAX.Enabled = True
                    'btnShortTAX.Enabled = True
                    'btnSubmit.Enabled = True
                    'btnSearchCustomer.Enabled = True
            Catch ex As Exception

                transaction.Rollback()
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจากเกิดปัญหา" & ex.Message)

            End Try



        End Using
    End Function


    Private Function clearBill()
        btnEditBill.Enabled = False
        button_cancel_bill.Enabled = False
        Button1.Enabled = False
        lblCustomerData.Text = ""
        PictureBoxlblBirthDate.Visible = False
        lblBirthDate.Visible = False

        'lblTotal.Text = "0"
        'txtDiscount.Text = "0"
        'lblGrandTotal.Text = "0"
        'label_result_paid.Text = "0"
        'lblChange.Text = "0"
        'lblUnPaid.Text = "0"
        'ListView1.Items.Clear()
        'lvtItem.Items.Clear()
        'SettingPaymentButton()


        'cboCustomerType.SelectedIndex = 0
        'cboStylist.SelectedIndex = 0

        DiscountAmt = 0
        DiscountType = ""

        BillNo = ""
        GlobalVar.POSCustomer = ""
        GlobalVar.POSCustomerLastname = ""
        GlobalVar.POSCustomerName = ""
        GlobalVar.POSCustomerType = ""
        GlobalVar.POSStylish = ""
    End Function

    Private Sub button_home_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles lvtItem.Click
        ' button_service_information_edit.Enabled = True
        button_service_information_remove.Enabled = True
    End Sub

    Private Sub button_service_Click(sender As Object, e As EventArgs) Handles button_service.Click

        Dim frm As New pos_add_service
        frm.ProductType = "0002" ' กำหนดประเภท ว่าเป็นประเภทของ บริการโดยตรงเลย

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim sql As String = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
            sql &= " FROM         Product INNER JOIN"
            sql &= "               ProductUnit ON Product.ProductUnit = ProductUnit.Code"
            sql &= " WHERE     (Product.code = '" & frm.ProductCode & "')"

            Using dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
                Dim existStatus As Boolean = False
                Dim i As Integer
                For i = 0 To lvtItem.Items.Count - 1
                    If dt.Rows(0).Item("Code") = lvtItem.Items(i).SubItems(0).Text And frm.StylishName & "/" & frm.StylishCode = lvtItem.Items(i).SubItems(7).Text And frm.CustomerName & "/" & frm.CustomerCode = lvtItem.Items(i).SubItems(8).Text And frm.CustomerTypeName & "/" & frm.CustomerTypeCode = lvtItem.Items(i).SubItems(9).Text Then

                        lvtItem.Items(i).SubItems(3).Text = lvtItem.Items(i).SubItems(2).Text + 1
                        lvtItem.Items(i).SubItems(6).Text = (lvtItem.Items(i).SubItems(3).Text * lvtItem.Items(i).SubItems(4).Text) / lvtItem.Items(i).SubItems(5).Text
                        existStatus = True
                        Exit For
                    End If
                Next


                If existStatus = False Then
                    Dim item(10) As String
                    item(0) = i + 1
                    item(1) = dt.Rows(0).Item("Code")
                    item(2) = dt.Rows(0).Item("Title")
                    item(3) = 1
                    item(4) = frm.Price.ToString("F2")
                    item(5) = frm.Discount.ToString("F2")

                    item(6) = CDec((item(3) * item(4)) - item(5)).ToString("F2")
                    item(7) = frm.StylishName & "/" & frm.StylishCode
                    item(8) = frm.CustomerName & "/" & frm.CustomerCode
                    item(9) = frm.CustomerTypeName & "/" & frm.CustomerTypeCode

                    Dim lr As New ListViewItem(item)
                    lvtItem.Items.Add(lr)
                End If



                LoadSumData()
            End Using
        End If
    End Sub
    Sub LoadEmployeeCombobox()
        Dim dt As DataTable = Common.GetEmployeeDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)

        cboStylist.DataSource = dt
        cboStylist.DisplayMember = "fullname"
        cboStylist.ValueMember = "ID"
        cboStylist.SelectedIndex = 0
    End Sub

    Sub LoadCustomerVisitTypeCombobox()
        Dim dt As DataTable = Common.GetCustomerVisitTypeDatatable
        Dim dr As DataRow = dt.NewRow()
        dr("CODE") = ""

        dt.Rows.InsertAt(dr, 0)

        cboCustomerType.DataSource = dt
        cboCustomerType.DisplayMember = "Title"
        cboCustomerType.ValueMember = "Code"
        cboCustomerType.SelectedIndex = 0
    End Sub

    Sub SetFavoriteService()
        Dim sql As String = "select  * from product where Favorite='true'"
        Dim fvdt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        Dim i As Integer
        For i = 0 To fvdt.Rows.Count - 1
            If i = 0 Then
                btnservice1.Text = fvdt.Rows(i).Item("Title")
                btnservice1.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 1 Then
                btnservice2.Text = fvdt.Rows(i).Item("Title")
                btnservice2.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 2 Then
                btnservice3.Text = fvdt.Rows(i).Item("Title")
                btnservice3.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 3 Then
                btnservice4.Text = fvdt.Rows(i).Item("Title")
                btnservice4.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 4 Then
                btnservice5.Text = fvdt.Rows(i).Item("Title")
                btnservice5.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 5 Then
                btnservice6.Text = fvdt.Rows(i).Item("Title")
                btnservice6.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 6 Then
                btnservice7.Text = fvdt.Rows(i).Item("Title")
                btnservice7.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 7 Then
                btnservice8.Text = fvdt.Rows(i).Item("Title")
                btnservice8.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 8 Then
                btnservice9.Text = fvdt.Rows(i).Item("Title")
                btnservice9.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 9 Then
                btnservice10.Text = fvdt.Rows(i).Item("Title")
                btnservice10.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 10 Then
                btnservice11.Text = fvdt.Rows(i).Item("Title")
                btnservice11.Tag = fvdt.Rows(i).Item("Code")
            ElseIf i = 11 Then
                btnservice12.Text = fvdt.Rows(i).Item("Title")
                btnservice12.Tag = fvdt.Rows(i).Item("Code")
            End If
        Next
    End Sub
    Private Sub pos_main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        GlobalVar.POSCustomer = ""
        GlobalVar.POSStylish = ""

        lblCustomerData.Text = ""
        PictureBoxlblBirthDate.Visible = False
        lblBirthDate.Visible = False

        lblTotal.Text = "0"
        txtDiscount.Text = "0"
        lblGrandTotal.Text = "0"
        label_result_paid.Text = "0"
        lblChange.Text = "0"
        lblUnPaid.Text = "0"


        'LoadCustomerVisitTypeCombobox()
        SetFavoriteService()
        'LoadEmployeeCombobox()

        getNewBillNo()



    End Sub

    Private Function getNewBillNo()
        GlobalVar.SaleCode = getCode()
        BillNo = GlobalVar.SaleCode

        lblBillNo.Text = BillNo ' show on bill lable
    End Function

    Private Sub button_service_information_remove_Click(sender As Object, e As EventArgs) Handles button_service_information_remove.Click
        If lvtItem.SelectedItems.Count <> 0 Then
            Dim rowindex As ListViewItem
            rowindex = lvtItem.SelectedItems(0)
            lvtItem.Items.Remove(rowindex)
            LoadSumData()
        End If
    End Sub

    Sub LoadSumData()
        Dim netPOice As Decimal
        Dim TotalPrice As Decimal = 0

        If lvtItem.Items.Count = 0 Then
            txtDiscount.Text = "0.00"
        End If

        For i = 0 To lvtItem.Items.Count - 1
            If lvtItem.Items(i).SubItems(6).Text <> "" Then
                TotalPrice += lvtItem.Items(i).SubItems(6).Text
            End If

        Next
        lblTotal.Text = CDec(TotalPrice).ToString("F2")
        Dim grandTotal = CDec(TotalPrice)
        Dim discount As Decimal
        'If txtDiscount.Text <> "" And txtDiscount.Text <> "0" Then
        If DiscountAmt <> 0 Then
            If DiscountType = "PERCENT" Then
                discount = (CDec(lblTotal.Text) * DiscountAmt) / 100
            Else
                discount = CDec(txtDiscount.Text)

            End If
            txtDiscount.Text = discount
            grandTotal = CDec(TotalPrice) - CDec(discount)

        Else
            txtDiscount.Text = discount.ToString("F2")

        End If
        lblGrandTotal.Text = CDec(grandTotal).ToString("F2")



        ' lblGrandTotal.Text = grandTotal

        If PaymentList Is Nothing Then
            CalUnPaid()
        Else
            Dim dt As New DataTable
            dt = PaymentList

            Dim i As Integer
            For i = 0 To dt.Rows.Count - 1
                Dim item(3) As String
                item(0) = dt.Rows(i).Item("PaymentMethod")
                item(1) = dt.Rows(i).Item("PaidAmt")
                item(2) = dt.Rows(i).Item("Cash")

                Dim lr As New ListViewItem(item)
                lr.Tag = dt.Rows(i).Item("CardNumber")
                ListView1.Items.Add(lr)

            Next
            CalUnPaid()

        End If
        SettingPaymentButton()



    End Sub

    Private Sub button_payment_remove_Click(sender As Object, e As EventArgs) Handles button_payment_remove.Click
        If ListView1.SelectedItems.Count <> 0 Then
            ListView1.Items.RemoveAt(ListView1.SelectedItems(0).Index)
            CalUnPaid()
            CalChangeForCash()
        End If

    End Sub



    Function getCode() As String

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

        Dim sql As String = "select top 1 * from sale  order by code desc"
        Dim nvdt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)
        Dim newCode As String
        If nvdt.Rows.Count = 0 Then
            newCode = Date.Now.ToString("yyyyMMdd")
            newCode &= "00001"
        Else

            Dim Prefix As String = Date.Now.ToString("yyyyMMdd")
            Dim runningno As String = nvdt.Rows(0).Item("code").ToString.Substring(8)
            runningno = (CInt(runningno) + 1).ToString.PadLeft(5, "0")
            newCode = Prefix & runningno
        End If


        Return newCode


    End Function

    Sub SaveData()
        'คำนวณตอนกดเสร็จ
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection

            Dim transaction As SqlTransaction
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            transaction = cnn.BeginTransaction()

            Try
                Dim employee As String
                Dim member As String
                Dim rewardPont As Integer = 0
                Dim sql As String

                Dim i As Integer
                Dim Salecode As String
                
                sql = "INSERT INTO [Sale]"
                sql &= "   ([Code]"
                sql &= "    ,[Branch]"
                sql &= "    ,[Shift]"
                sql &= "    ,[ShiftDate]"
                sql &= "    ,[CustomerVisitType]"
                sql &= "    ,[Stylist]"
                sql &= "    ,[Sale_Employee]"
                sql &= "    ,[SaleDateTime]"
                sql &= "    ,[TimeStart]"
                sql &= "    ,[TimeFinish]"
                sql &= "    ,[HoseNo]"
                sql &= "    ,[UnitPrice]"
                sql &= "    ,[Liter]"
                sql &= "    ,[Amount]"
                sql &= "    ,[Totalizer]"
                sql &= "     ,[IsMember]"
                sql &= "     ,[CustomerType]"
                sql &= "    ,[Customer]"
                sql &= "    ,[member]"
                sql &= "    ,[Employee]"
                sql &= "    ,[LicensePlate]"
                sql &= "    ,[Total]"
                sql &= "    ,[Discount]"
                sql &= "    ,[GrandTotal]"
                sql &= "    ,[RewardProduct]"
                sql &= "    ,[RewardQTY]"
                sql &= "    ,[Point]"
                sql &= "    ,[Status]"
                sql &= "   ,[InsertDate]"
                sql &= "   ,[InsertUser]"
                sql &= "   ,[InsertIP]"
                sql &= "   ,[LastUpdateDate]"
                sql &= "    ,[LastUpdateUser]"
                sql &= "     ,[LastUpdateIP],[RefCode])"
                sql &= "     VALUES"
                sql &= "   ('" & GlobalVar.SaleCode & "'"
                sql &= "    ,'" & GlobalVar.Branch & "'"
                sql &= "    ,'" & GlobalVar.POSShiftCode & "'"
                sql &= "    ,@ShiftDate"
                sql &= "    ,'" & cboCustomerType.SelectedValue & "'"
                sql &= "    ,'" & cboStylist.SelectedValue & "'"

                sql &= "    ,'" & GlobalVar.UserID & "'"
                sql &= "    ,getdate()"

                Dim TimeStart As String = ""
                Dim TimeFinish As String = ""
                Dim ActiveHoseNO As Integer
                Dim UnitPrice As Decimal
                Dim Liter As Decimal
                Dim Amount As Decimal
                Dim Totalizer As Decimal

                For i = 0 To lvtItem.Items.Count - 1
                    If lvtItem.Items(0).Tag <> "" Then
                        Dim strData() As String
                        strData = lvtItem.Items(0).Tag.ToString.Split("/")
                        TimeStart = strData(0)
                        TimeFinish = strData(1)
                        ActiveHoseNO = strData(2)
                        UnitPrice = strData(3)
                        Liter = strData(4)
                        Amount = strData(5)
                        Totalizer = strData(6)
                        Exit For
                    End If
                Next

                sql &= "    ,'" & TimeStart & "'"
                sql &= "    ,'" & TimeFinish & "'"
                sql &= "    ,'" & ActiveHoseNO & "'"
                sql &= "    ," & UnitPrice
                sql &= "    ," & Liter
                sql &= "    ," & Amount
                sql &= "    ," & Totalizer
                If member <> "" Then
                    sql &= "     ,'true'"
                Else
                    sql &= "     ,'false'"
                End If

                sql &= "     ,''"
                sql &= "    ,'" & GlobalVar.POSCustomer & "'"
                sql &= "    ,'" & member & "'"


                sql &= "    ,''"


                sql &= "    ,''"
                sql &= "    ," & lblTotal.Text
                sql &= "    ," & txtDiscount.Text
                sql &= "    ," & lblGrandTotal.Text
                sql &= "    ,'" & GlobalVar.RewardProductCode & "'"
                sql &= "    ," & GlobalVar.RewardProductQTY
                sql &= "    ," & rewardPont
                sql &= "    ,'Active'"
                sql &= "    ,getdate()"
                sql &= "    ,'" & GlobalVar.UserID & "'"
                sql &= "    ,'" & Common.GetIPAddress & "'"
                sql &= "    ,getdate()"
                sql &= "   ,'" & GlobalVar.UserID & "'"
                sql &= "    ,'" & Common.GetIPAddress & "'"
                sql &= "    ,'" & RefBillNo & "')"

                Dim command = New SqlCommand(sql, cnn, transaction)
                command.Parameters.Add("@ShiftDate", SqlDbType.Date).Value = GlobalVar.POSShiftDate

                command.CommandText = sql
                command.ExecuteNonQuery()



                'If GlobalVar.SaleCode = "" Then

                'Else
                '    sql = "delete SaleDetail where sale='" & GlobalVar.SaleCode & "'"
                '    Dim commandDeleteSale = New SqlCommand(sql, cnn, transaction)

                '    commandDeleteSale.CommandText = sql
                '    commandDeleteSale.ExecuteNonQuery()
                'End If



                For i = 0 To lvtItem.Items.Count - 1

                    sql = "INSERT INTO [SaleDetail]"
                    sql &= "    ([Sale]"
                    sql &= "    ,[Branch]"
                    sql &= "    ,[Product]"
                    sql &= "    ,[UnitPrice]"
                    sql &= "    ,[Quantity]"
                    sql &= "    ,[Discount]"
                    sql &= "    ,[total]"
                    sql &= "    ,[Status]"
                    sql &= "    ,[InsertDate]"
                    sql &= "    ,[InsertUser]"
                    sql &= "    ,[InsertIP]"
                    sql &= "    ,[LastUpdateDate]"
                    sql &= "    ,[LastUpdateUser]"
                    sql &= "    ,[LastUpdateIP]"
                    sql &= "    ,[Stylish]" ' add field
                    sql &= "    ,[Customer]" ' add field
                    sql &= "    ,[CustomerType])" ' add field
                    sql &= "                VALUES "
                    sql &= "    ('" & GlobalVar.SaleCode & "'"
                    sql &= "    ,'" & GlobalVar.Branch & "'"
                    sql &= "    ,'" & lvtItem.Items(i).SubItems(1).Text & "'"
                    sql &= "    ," & lvtItem.Items(i).SubItems(4).Text
                    sql &= "    ," & lvtItem.Items(i).SubItems(3).Text
                    sql &= "    ," & lvtItem.Items(i).SubItems(5).Text
                    sql &= "    ," & lvtItem.Items(i).SubItems(6).Text
                    sql &= "    ,'Active'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"



                    sql &= "    ,'" & lvtItem.Items(i).SubItems(7).Text.Split("/")(1) & "'"
                    sql &= "    ,'" & lvtItem.Items(i).SubItems(8).Text.Split("/")(1) & "'"
                    sql &= "    ,'" & lvtItem.Items(i).SubItems(9).Text.Split("/")(1) & "')"

                    Dim commanditem = New SqlCommand(sql, cnn, transaction)
                    commanditem.CommandText = sql
                    commanditem.ExecuteNonQuery()

                Next


                'If GlobalVar.SaleCode = "" Then

                'Else

                '    sql = "delete SalePayment where sale='" & GlobalVar.SaleCode & "'"
                '    Dim commandDeleteSale = New SqlCommand(sql, cnn, transaction)

                '    commandDeleteSale.CommandText = sql
                '    commandDeleteSale.ExecuteNonQuery()
                'End If








                For i = 0 To ListView1.Items.Count - 1



                    sql = "INSERT INTO [SalePayment]"
                    sql &= "   ([Sale]"
                    sql &= "    ,[Branch]"
                    sql &= "    ,[PaymentMethod]"
                    sql &= "    ,[PaidAmt]"
                    sql &= "    ,[CardNumber]"
                    sql &= "    ,[Cash]"
                    'sql &= "    ,[change]"
                    sql &= "    ,[PayeeEmployee]"
                    sql &= "     ,[Status]"
                    sql &= "     ,[InsertDate]"
                    sql &= "     ,[InsertUser]"
                    sql &= "     ,[InsertIP]"
                    sql &= "    ,[LastUpdateDate]"
                    sql &= "     ,[LastUpdateUser]"
                    sql &= "     ,[LastUpdateIP])"
                    sql &= "                VALUES "
                    sql &= "   ('" & GlobalVar.SaleCode & "'"
                    sql &= "    ,'" & GlobalVar.Branch & "'"
                    sql &= "    ,'" & ListView1.Items(i).SubItems(0).Text & "'"
                    sql &= "    ," & ListView1.Items(i).SubItems(1).Text
                    sql &= "    ,''"
                    sql &= "    ," & ListView1.Items(i).SubItems(2).Text
                    'sql &= "    ," & PaymentList.Rows(i).Item("change")
                    sql &= "    ,''"
                    sql &= "    ,'Active'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"
                    sql &= "    ,getdate()"
                    sql &= "   ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "')"
                    Dim commanditem = New SqlCommand(sql, cnn, transaction)
                    commanditem.CommandText = sql
                    commanditem.ExecuteNonQuery()

                Next

                transaction.Commit()


                'EnableStatus(False)
                'btnpay.Enabled = True
                'btnShiftOpen.Enabled = False
                'btnFullTAX.Enabled = True
                'btnShortTAX.Enabled = True
                'btnSubmit.Enabled = True
                'btnSearchCustomer.Enabled = True
                Button1.Enabled = True

            Catch ex As Exception
                Button1.Enabled = False
                transaction.Rollback()
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจากเกิดปัญหา" & ex.Message)

            End Try
            modeSave = "new"
        End Using
    End Sub

    Sub EditData()
        'คำนวณตอนกดเสร็จ
        Using connection As SqlConnection = ConnectionManagement.GetConnection
            Dim cnn As SqlConnection = ConnectionManagement.GetConnection

            Dim transaction As SqlTransaction
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            transaction = cnn.BeginTransaction()

            Try

                Dim member As String
                Dim rewardPont As Integer = 0
                Dim sql As String

                Dim i As Integer

                sql = "UPDATE [Sale]"
                sql &= "   SET "

                Dim TimeStart As String
                Dim TimeFinish As String
                Dim ActiveHoseNO As Integer
                Dim UnitPrice As Decimal
                Dim Liter As Decimal
                Dim Amount As Decimal
                Dim Totalizer As Decimal

                For i = 0 To lvtItem.Items.Count - 1
                    If lvtItem.Items(0).Tag <> "" Then
                        Dim strData() As String
                        strData = lvtItem.Items(0).Tag.ToString.Split("/")
                        TimeStart = strData(0)
                        TimeFinish = strData(1)
                        ActiveHoseNO = strData(2)
                        UnitPrice = strData(3)
                        Liter = strData(4)
                        Amount = strData(5)
                        Totalizer = strData(6)
                        Exit For
                    End If
                Next


                sql &= "    [TimeStart] = '" & TimeStart & "'"
                sql &= "    ,[TimeFinish] = '" & TimeFinish & "'"
                sql &= "    ,[HoseNo] = '" & ActiveHoseNO & "'"
                sql &= "    ,[UnitPrice] = " & UnitPrice
                sql &= "    ,[Liter] = " & Liter
                sql &= "    ,[Amount] = " & Amount
                sql &= "    ,[Totalizer]= " & Totalizer
                sql &= "    ,[Customer] = '" & GlobalVar.POSCustomer & "'"
                sql &= "    ,[Employee] = ''"
                sql &= "    ,[LicensePlate] = ''"
                sql &= "    ,[Total] = " & lblTotal.Text
                sql &= "    ,[Discount] = " & txtDiscount.Text
                sql &= "    ,[GrandTotal] = " & lblGrandTotal.Text
                sql &= "    ,[RewardProduct] = '" & GlobalVar.RewardProductCode & "'"
                sql &= "    ,[RewardQTY] = " & GlobalVar.RewardProductQTY
                sql &= "    ,[Point] = " & rewardPont
                sql &= "   ,[LastUpdateDate] = getdate()"
                sql &= "    ,[LastUpdateUser] = '" & GlobalVar.UserID & "'"
                sql &= "     ,[LastUpdateIP] = '" & Common.GetIPAddress & "'"

                sql &= "     WHERE [Code] =  '" & GlobalVar.SaleCode & "'"

                Dim command = New SqlCommand(sql, cnn, transaction)

                command.CommandText = sql
                command.ExecuteNonQuery()


                ' delete sale detail
                sql = "DELETE FROM [SaleDetail]    WHERE [Sale] =  '" & GlobalVar.SaleCode & "'"
                Dim commandDeleteitem = New SqlCommand(sql, cnn, transaction)
                commandDeleteitem.CommandText = sql
                commandDeleteitem.ExecuteNonQuery()

                ' insert new item
                For i = 0 To lvtItem.Items.Count - 1

                    'sql = "UPDATE [SaleDetail]"
                    'sql &= "    SET  [Product] = '" & lvtItem.Items(i).SubItems(1).Text & "'"
                    'sql &= "    ,[UnitPrice] = " & lvtItem.Items(i).SubItems(4).Text
                    'sql &= "    ,[Quantity] = " & lvtItem.Items(i).SubItems(3).Text
                    'sql &= "    ,[Discount] = " & lvtItem.Items(i).SubItems(5).Text
                    'sql &= "    ,[total] = " & lvtItem.Items(i).SubItems(6).Text
                    'sql &= "    ,[Status] = 'Active'"
                    'sql &= "    ,[LastUpdateDate] = getdate()"
                    'sql &= "    ,[LastUpdateUser] = '" & GlobalVar.UserID & "'"
                    'sql &= "    ,[LastUpdateIP] = '" & Common.GetIPAddress & "'"
                    'sql &= "    ,[Stylish] = '" & lvtItem.Items(i).SubItems(7).Text.Split("/")(1) & "'" ' add field
                    'sql &= "    ,[Customer] = '" & lvtItem.Items(i).SubItems(8).Text.Split("/")(1) & "'" ' add field
                    'sql &= "    ,[CustomerType] = '" & lvtItem.Items(i).SubItems(9).Text.Split("/")(1) & "'" ' add field
                    'sql &= "     WHERE [Sale] =  '" & GlobalVar.SaleCode & "'"

                    sql = "INSERT INTO [SaleDetail]"
                    sql &= "    ([Sale]"
                    sql &= "    ,[Branch]"
                    sql &= "    ,[Product]"
                    sql &= "    ,[UnitPrice]"
                    sql &= "    ,[Quantity]"
                    sql &= "    ,[Discount]"
                    sql &= "    ,[total]"
                    sql &= "    ,[Status]"
                    sql &= "    ,[InsertDate]"
                    sql &= "    ,[InsertUser]"
                    sql &= "    ,[InsertIP]"
                    sql &= "    ,[LastUpdateDate]"
                    sql &= "    ,[LastUpdateUser]"
                    sql &= "    ,[LastUpdateIP]"
                    sql &= "    ,[Stylish]" ' add field
                    sql &= "    ,[Customer]" ' add field
                    sql &= "    ,[CustomerType])" ' add field
                    sql &= "                VALUES "
                    sql &= "    ('" & GlobalVar.SaleCode & "'"
                    sql &= "    ,'" & GlobalVar.Branch & "'"
                    sql &= "    ,'" & lvtItem.Items(i).SubItems(1).Text & "'"
                    sql &= "    ," & lvtItem.Items(i).SubItems(4).Text
                    sql &= "    ," & lvtItem.Items(i).SubItems(3).Text
                    sql &= "    ," & lvtItem.Items(i).SubItems(5).Text
                    sql &= "    ," & lvtItem.Items(i).SubItems(6).Text
                    sql &= "    ,'Active'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"



                    sql &= "    ,'" & lvtItem.Items(i).SubItems(7).Text.Split("/")(1) & "'"
                    sql &= "    ,'" & lvtItem.Items(i).SubItems(8).Text.Split("/")(1) & "'"
                    sql &= "    ,'" & lvtItem.Items(i).SubItems(9).Text.Split("/")(1) & "')"

                    Dim commanditem = New SqlCommand(sql, cnn, transaction)
                    commanditem.CommandText = sql
                    commanditem.ExecuteNonQuery()

                Next



                ' delete sale payment
                sql = "DELETE FROM [SalePayment]    WHERE [Sale] =  '" & GlobalVar.SaleCode & "'"
                Dim commandDeletePaymentitem = New SqlCommand(sql, cnn, transaction)
                commandDeletePaymentitem.CommandText = sql
                commandDeletePaymentitem.ExecuteNonQuery()

                For i = 0 To ListView1.Items.Count - 1
                    'sql = "UPDATE [SalePayment]"
                    'sql &= "   SET [PaymentMethod] = '" & ListView1.Items(i).SubItems(0).Text & "'"
                    'sql &= "    ,[PaidAmt] = " & ListView1.Items(i).SubItems(1).Text
                    'sql &= "    ,[CardNumber] = ''"
                    'sql &= "    ,[Cash] = " & ListView1.Items(i).SubItems(2).Text
                    ''sql &= "    ,[change]"
                    'sql &= "    ,[PayeeEmployee] = ''"
                    'sql &= "     ,[Status] = 'Active'"

                    'sql &= "    ,[LastUpdateDate] = getdate()"
                    'sql &= "     ,[LastUpdateUser] = '" & GlobalVar.UserID & "'"
                    'sql &= "     ,[LastUpdateIP] = '" & Common.GetIPAddress & "'"

                    'sql &= "     WHERE [Sale] =  '" & GlobalVar.SaleCode & "'"

                    sql = "INSERT INTO [SalePayment]"
                    sql &= "   ([Sale]"
                    sql &= "    ,[Branch]"
                    sql &= "    ,[PaymentMethod]"
                    sql &= "    ,[PaidAmt]"
                    sql &= "    ,[CardNumber]"
                    sql &= "    ,[Cash]"
                    'sql &= "    ,[change]"
                    sql &= "    ,[PayeeEmployee]"
                    sql &= "     ,[Status]"
                    sql &= "     ,[InsertDate]"
                    sql &= "     ,[InsertUser]"
                    sql &= "     ,[InsertIP]"
                    sql &= "    ,[LastUpdateDate]"
                    sql &= "     ,[LastUpdateUser]"
                    sql &= "     ,[LastUpdateIP])"
                    sql &= "                VALUES "
                    sql &= "   ('" & GlobalVar.SaleCode & "'"
                    sql &= "    ,'" & GlobalVar.Branch & "'"
                    sql &= "    ,'" & ListView1.Items(i).SubItems(0).Text & "'"
                    sql &= "    ," & ListView1.Items(i).SubItems(1).Text
                    sql &= "    ,''"
                    sql &= "    ," & ListView1.Items(i).SubItems(2).Text
                    'sql &= "    ," & PaymentList.Rows(i).Item("change")
                    sql &= "    ,''"
                    sql &= "    ,'Active'"
                    sql &= "    ,getdate()"
                    sql &= "    ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "'"
                    sql &= "    ,getdate()"
                    sql &= "   ,'" & GlobalVar.UserID & "'"
                    sql &= "    ,'" & Common.GetIPAddress & "')"

                    Dim commanditem = New SqlCommand(sql, cnn, transaction)
                    commanditem.CommandText = sql
                    commanditem.ExecuteNonQuery()

                Next

                transaction.Commit()


                'EnableStatus(False)
                'btnpay.Enabled = True
                'btnShiftOpen.Enabled = False
                'btnFullTAX.Enabled = True
                'btnShortTAX.Enabled = True
                'btnSubmit.Enabled = True
                'btnSearchCustomer.Enabled = True
                Button1.Enabled = True
                'getNewBillNo()
            Catch ex As Exception
                Button1.Enabled = False
                transaction.Rollback()
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจากเกิดปัญหา" & ex.Message)

            End Try


            modeSave = "new"
        End Using
    End Sub

    Dim modeSave As String = ""

    Private Function validMoneys()

    End Function

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

        Dim dialogResult As MsgBoxResult

        dialogResult = MessageBox.Show("Are you want to Save bill ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            
        'If GlobalVar.POSCustomer = "" Then
        '    MessageBox.Show("Pleaes select customer", "Message", MessageBoxButtons.OK)
        '    Exit Sub
            'Else


            If lvtItem.Items.Count < 1 Then
                MessageBox.Show("Pleaes select service or product", "Message", MessageBoxButtons.OK)
                Exit Sub
            End If

            If ListView1.Items.Count < 1 Then
                MessageBox.Show("Pleaes select payment method", "Message", MessageBoxButtons.OK)
                Exit Sub
            End If



        If lblGrandTotal.Text = "" Or lblGrandTotal.Text = "0" Then
                MessageBox.Show("Pleaes select payment method", "Message", MessageBoxButtons.OK)

            Exit Sub
        ElseIf lblUnPaid.Text <> "0" Then
                MessageBox.Show("A payment is incorrect !", "Message", MessageBoxButtons.OK)

                Exit Sub
            Else



                If modeSave = "edit" Then
                    EditData()
                Else
                    SaveData()

                End If

                ' Dim i As Integer
                ' For i = 0 To ListView1.Items.Count - 1
                'If ListView1.Items(i).SubItems(0).Text.ToUpper = "CASH" Then
                OpenCashdrawer()





                If Button15.Text.Equals("Auto Receipt") Then
                    prDoc.Dispose()
                    AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.printSlip)
                    prDoc.Print()
                End If

                If Button16.Text.Equals("Auto Tax Invoice") Then
                    prDoc.Dispose()
                    AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.printSlipTax)
                    prDoc.Print()
                End If



                ' clear ref code bill
                RefBillNo = ""
                BillNo = ""
                GlobalVar.SaleCode = ""
                GlobalVar.POSCustomer = ""
                GlobalVar.POSCustomerLastname = ""
                GlobalVar.POSCustomerName = ""
                GlobalVar.POSCustomerType = ""
                GlobalVar.POSStylish = ""



                


                'End If
                ' Next

                lblCustomerData.Text = ""
                PictureBoxlblBirthDate.Visible = False
                lblBirthDate.Visible = False

                ListView1.Items.Clear()
                lvtItem.Items.Clear()


                ' cboCustomerType.SelectedIndex = 0
                'cboStylist.SelectedIndex = 0

                DiscountAmt = 0
                DiscountType = ""

                ' get new bill no

                ' getNewBillNo()
                processNewBill() 'user will press new bill

            End If
            
        End If

    End Sub


    Private Sub btnservice1_Click(sender As Object, e As EventArgs) Handles btnservice1.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice2_Click(sender As Object, e As EventArgs) Handles btnservice2.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice3_Click(sender As Object, e As EventArgs) Handles btnservice3.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice4_Click(sender As Object, e As EventArgs) Handles btnservice4.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice5_Click(sender As Object, e As EventArgs) Handles btnservice5.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice6_Click(sender As Object, e As EventArgs) Handles btnservice6.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice7_Click(sender As Object, e As EventArgs) Handles btnservice7.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice8_Click(sender As Object, e As EventArgs) Handles btnservice8.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice9_Click(sender As Object, e As EventArgs) Handles btnservice9.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice10_Click(sender As Object, e As EventArgs) Handles btnservice10.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub btnservice11_Click(sender As Object, e As EventArgs) Handles btnservice11.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        'Button15.Enabled = Not Button15.Enabled

        'Dim dialogResult As MsgBoxResult

        'dialogResult = MessageBox.Show("Are you want to print Receipt this bill ?", "Confirm", MessageBoxButtons.YesNo)
        'If (dialogResult = MsgBoxResult.Yes) Then
        '    prDoc.Dispose()

        '    'OpenCashdrawer()
        '    AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.printSlip)
        '    prDoc.Print()
        'End If

        

        If Button15.Text.Equals("Auto Receipt") Then
            Button15.Text = "Not Receipt"
        Else
            Button15.Text = "Auto Receipt"
        End If

    End Sub

    Public Sub OpenCashdrawer()
        'Modify DrawerCode to your receipt printer open drawer code
        Dim DrawerCode As String = Chr(27) & Chr(112) & Chr(0) & Chr(50) & Chr(250)
        ' 27,112,0,50,250
        'Modify PrinterName to your receipt printer name
        Dim PrinterName As String = "BIXOLON SRP-330"

        RawPrinter.PrintRaw(PrinterName, DrawerCode)
    End Sub

    Public Sub printSlip(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim Uied As New System.Globalization.CultureInfo("th-TH")
        Dim Line As Integer

        Dim _conn As SqlConnection = ConnectionManagement.GetConnection
        Dim _rd As SqlDataReader

        If _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If

        Dim sqlSale As String = "Select [Code],[Branch],[Shift],[ShiftDate],[CustomerVisitType],[Stylist],[Sale_Employee],[SaleDateTime],[TimeStart],[TimeFinish],[HoseNo],[UnitPrice],[Liter],[Amount],[Totalizer],[IsMember],[CustomerType],[Customer],[Member],[Employee],[LicensePlate],[Total],[Discount],[VAT],[GrandTotal],[RewardProduct],[RewardQTY],[Point],[ReqTAXInvoice],[Status],[Cut_L],[Cut_M],[Cut_S],[HairType_Coarse],[HairType_Medium],[HairType_Fine],[HairType_Dry],[HairType_Normal],[HairType_Oily],[HairType_ALot],[HairType_Medium2],[HairType_Thin],[Color],[Color_Other],[Color_Brand],[Color_Amount],[Color_Unit],[Perm_M],[Perm_H],[Perm_EX],[Perm_V],[Perm_Time],[Straight_M],[Straight_H],[Straight_EX],[Straight_V],[Straight_180],[Straight_200],[Straight_Time],[Treatment_SHERPA],[Treatment_PRIVA],[Treatment_caretico],[ShampooBlow],[MakeUp_Party],[MakeUp_Wedding],[MakeUp_Graduation],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP] FROM [Sale] WHERE  Code='" & lblBillNo.Text & "'"
        Dim dtSale As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sqlSale)


        Dim sqlx As String = "SELECT [Sale],[Branch],[Product] ,[UnitPrice],[Quantity],[Discount],[Total],[Stylish],[Customer],[CustomerType] ,[Status],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP] FROM [SaleDetail] sd WHERE  Sale='" & lblBillNo.Text & "' order by Sale desc"
        Dim _cmd As SqlCommand = New SqlCommand(sqlx, _conn)
        _rd = _cmd.ExecuteReader


        ' get data by bill code from sele detail

        'Dim dtSaleDetail As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sqlx)

        Dim _billNo As String = dtSale.Rows(0).Item("Code").ToString()

        Line += 16
        AnyString_Lucida(e.Graphics, "                   " & _billNo, 0, Line)
        Line += 16
        AnyString_Lucida(e.Graphics, "                      " & CDate(dtSale.Rows(0).Item("InsertDate")).ToString("dd/MM/yyyy"), 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "    ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "        บริษัท บอยริคิว จำกัด ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, " ห้อง 10 ชั้น 3 เลขที่ 49 อาคารเดอะเทอเรซ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, " ซอยสุขุมวิท 49 ถนนสุขุมวิท  แขวงคลองตันเหนือ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "      เขตวัฒนา  กรุงเทพมหานคร 10110", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "  เลขประจำตัวผู้เสียภาษี 0105553073455", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "         POS No. 0001", 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "==================================", 0, Line)
        Line += 20

        Dim i As Integer = 0
        While _rd.Read()

        
            Dim sql = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
            sql &= " FROM         Product INNER JOIN ProductUnit ON Product.ProductUnit = ProductUnit.Code"
            sql &= " WHERE     (Product.code = '" & _rd.GetValue(2).ToString() & "')"

            Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            Dim ii As Integer
            Dim item As String

            item = dt.Rows(0).Item("Code") & "  " & dt.Rows(0).Item("Title")

            AnyString_Lucida(e.Graphics, item, 0, Line)
            Line += 16

            item = "      " & _rd.GetValue(3).ToString() & "  " & " (-" & _rd.GetValue(5).ToString() & ")    " & CDec((_rd.GetValue(3) * 1) - CDec(_rd.GetValue(5)))

            AnyString_Lucida(e.Graphics, item, 0, Line)
            Line += 20

            i = i + 1
        End While

        AnyString_Lucida(e.Graphics, "==================================", 0, Line)
        Line += 20


        
        Line += 10
        AnyString_Lucida(e.Graphics, "Total           " & dtSale.Rows(0).Item("GrandTotal").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "Discount        " & dtSale.Rows(0).Item("Discount").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "VAT 7%        " & dtSale.Rows(0).Item("VAT").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "Net Total       " & dtSale.Rows(0).Item("GrandTotal").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "----------------------------------", 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "        ==VAT INCLUDED=", 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "     THANK YOU And WELCOME", 0, Line)
        Line += 20

        _rd.Close()

        _conn.Close()

        Dim str As String = "logo.bmp"
        Dim objBmp As New Bitmap(str)
        BmpDraw(e.Graphics, objBmp, 10, Line)

        '-------------------------------------------------------------



    End Sub


    Public Sub printSlipTax(ByVal sender As Object, ByVal e As PrintPageEventArgs)


        Dim frm As New pos_get_customer_tax


        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

        Else
            Exit Sub
        End If

        Dim Uied As New System.Globalization.CultureInfo("th-TH")
        Dim Line As Integer

        Dim _conn As SqlConnection = ConnectionManagement.GetConnection
        Dim _rd As SqlDataReader

        If _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If

        Dim sqlSale As String = "Select [Code],[Branch],[Shift],[ShiftDate],[CustomerVisitType],[Stylist],[Sale_Employee],[SaleDateTime],[TimeStart],[TimeFinish],[HoseNo],[UnitPrice],[Liter],[Amount],[Totalizer],[IsMember],[CustomerType],[Customer],[Member],[Employee],[LicensePlate],[Total],[Discount],[VAT],[GrandTotal],[RewardProduct],[RewardQTY],[Point],[ReqTAXInvoice],[Status],[Cut_L],[Cut_M],[Cut_S],[HairType_Coarse],[HairType_Medium],[HairType_Fine],[HairType_Dry],[HairType_Normal],[HairType_Oily],[HairType_ALot],[HairType_Medium2],[HairType_Thin],[Color],[Color_Other],[Color_Brand],[Color_Amount],[Color_Unit],[Perm_M],[Perm_H],[Perm_EX],[Perm_V],[Perm_Time],[Straight_M],[Straight_H],[Straight_EX],[Straight_V],[Straight_180],[Straight_200],[Straight_Time],[Treatment_SHERPA],[Treatment_PRIVA],[Treatment_caretico],[ShampooBlow],[MakeUp_Party],[MakeUp_Wedding],[MakeUp_Graduation],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP] FROM [Sale] WHERE  Code='" & lblBillNo.Text & "'"
        Dim dtSale As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sqlSale)


        Dim sqlx As String = "SELECT [Sale],[Branch],[Product] ,[UnitPrice],[Quantity],[Discount],[Total],[Stylish],[Customer],[CustomerType] ,[Status],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP] FROM [SaleDetail] sd WHERE  Sale='" & lblBillNo.Text & "' order by Sale desc"
        Dim _cmd As SqlCommand = New SqlCommand(sqlx, _conn)
        _rd = _cmd.ExecuteReader


        ' get data by bill code from sele detail

        'Dim dtSaleDetail As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sqlx)

        Dim _billNo As String = dtSale.Rows(0).Item("Code").ToString()


        Line += 16 ' 
        AnyString_Lucida(e.Graphics, "                   " & _billNo, 0, Line)
        Line += 16
        AnyString_Lucida(e.Graphics, "                      " & CDate(dtSale.Rows(0).Item("InsertDate")).ToString("dd/MM/yyyy"), 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "            ใบกำกับภาษี ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "        บริษัท บอยริคิว จำกัด ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, " ห้อง 10 ชั้น 3 เลขที่ 49 อาคารเดอะเทอเรซ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, " ซอยสุขุมวิท 49 ถนนสุขุมวิท  แขวงคลองตันเหนือ", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "      เขตวัฒนา  กรุงเทพมหานคร 10110", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "  เลขประจำตัวผู้เสียภาษี 0105553073455", 0, Line)
        Line += 16

        AnyString_Lucida(e.Graphics, "         POS No. 0001", 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "==================================", 0, Line)
        Line += 20
        AnyString_Lucida(e.Graphics, frm.CustomerName, 0, Line)
        Line += 16
        AnyString_Lucida(e.Graphics, frm.CustomerAddr1, 0, Line)
        Line += 16
        AnyString_Lucida(e.Graphics, frm.CustomerAddr2 & " " & frm.CustomerAddr3, 0, Line)

        'Line += 16
        'AnyString_Lucida(e.Graphics, frm.CustomerAddr3, 0, Line)

        Line += 16
        AnyString_Lucida(e.Graphics, "Tax No. " & frm.CustomerTax, 0, Line)
        Line += 20



        AnyString_Lucida(e.Graphics, "==================================", 0, Line)
        Line += 20

        Dim i As Integer = 0
        While _rd.Read()


            Dim sql = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
            sql &= " FROM         Product INNER JOIN ProductUnit ON Product.ProductUnit = ProductUnit.Code"
            sql &= " WHERE     (Product.code = '" & _rd.GetValue(2).ToString() & "')"

            Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            Dim ii As Integer
            Dim item As String

            item = dt.Rows(0).Item("Code") & "  " & dt.Rows(0).Item("Title")

            AnyString_Lucida(e.Graphics, item, 0, Line)
            Line += 16

            item = "      " & _rd.GetValue(3).ToString() & "  " & " (-" & _rd.GetValue(5).ToString() & ")    " & CDec((_rd.GetValue(3) * 1) - CDec(_rd.GetValue(5)))

            AnyString_Lucida(e.Graphics, item, 0, Line)
            Line += 20

            i = i + 1
        End While

        AnyString_Lucida(e.Graphics, "==================================", 0, Line)
        Line += 20

        Line += 10
        AnyString_Lucida(e.Graphics, "Total           " & dtSale.Rows(0).Item("GrandTotal").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "Discount        " & dtSale.Rows(0).Item("Discount").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "VAT 7%        " & dtSale.Rows(0).Item("VAT").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "Net Total       " & dtSale.Rows(0).Item("GrandTotal").ToString(), 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "----------------------------------", 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "        ==VAT INCLUDED=", 0, Line)
        Line += 20

        AnyString_Lucida(e.Graphics, "     THANK YOU And WELCOME", 0, Line)
        Line += 20

        _rd.Close()

        _conn.Close()

        Dim str As String = "logo.bmp"
        Dim objBmp As New Bitmap(str)
        BmpDraw(e.Graphics, objBmp, 10, Line)

        '-------------------------------------------------------------



    End Sub

    Private Sub btnservice12_Click(sender As Object, e As EventArgs) Handles btnservice12.Click
        LoadButtonService(sender.Tag)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       

        lblTotal.Text = "0"
        txtDiscount.Text = "0"
        lblGrandTotal.Text = "0"
        label_result_paid.Text = "0"
        lblChange.Text = "0"
        lblUnPaid.Text = "0"
        SettingPaymentButton()

      
    End Sub

    Private Sub cboStylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStylist.SelectedIndexChanged

    End Sub

    Private Sub button_findBill_Click(sender As Object, e As EventArgs) Handles button_findBill.Click
        Dim frm As pos_find_bill = New pos_find_bill()
        frm.ShowDialog(Me)
        lvtItem.Items.Clear()
        ListView1.Items.Clear()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then

            clearBill()
            GlobalVar.SaleCode = frm.SaleCode ' assign sale code from get old bill
            lblBillNo.Text = frm.SaleCode
            BillNo = frm.SaleCode ' keep bill no 
            loadBill(frm.SaleCode)
            loadPayment(frm.SaleCode)
            lblBillNo.Text = frm.SaleCode
            loadBillDetail(frm.SaleCode)
            LoadSumData() 'cal moneys
            enabledForm(False)

            btnEditBill.Enabled = True
            button_cancel_bill.Enabled = True
        End If
    End Sub

    ' load bill from db to screen
    Private Function loadBill(ByVal code As String)

        Dim sql As String = "Select [Code],[Branch],[Shift],[ShiftDate],[CustomerVisitType],[Stylist],[Sale_Employee],[SaleDateTime],[TimeStart],[TimeFinish],[HoseNo],[UnitPrice],[Liter],[Amount],[Totalizer],[IsMember],[CustomerType],[Customer],[Member],[Employee],[LicensePlate],[Total],[Discount],[VAT],[GrandTotal],[RewardProduct],[RewardQTY],[Point],[ReqTAXInvoice],[Status],[Cut_L],[Cut_M],[Cut_S],[HairType_Coarse],[HairType_Medium],[HairType_Fine],[HairType_Dry],[HairType_Normal],[HairType_Oily],[HairType_ALot],[HairType_Medium2],[HairType_Thin],[Color],[Color_Other],[Color_Brand],[Color_Amount],[Color_Unit],[Perm_M],[Perm_H],[Perm_EX],[Perm_V],[Perm_Time],[Straight_M],[Straight_H],[Straight_EX],[Straight_V],[Straight_180],[Straight_200],[Straight_Time],[Treatment_SHERPA],[Treatment_PRIVA],[Treatment_caretico],[ShampooBlow],[MakeUp_Party],[MakeUp_Wedding],[MakeUp_Graduation],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP] FROM [Sale] WHERE  Code='" & code & "'"
        Dim dtSale As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

        Dim i As Integer = 0
        If i < dtSale.Rows.Count Then
            ' lblBillNo.Text = dtSale.Rows(i).Item("Code").ToString()
            DiscountAmt = CDec(dtSale.Rows(i).Item("Discount").ToString())
            txtDiscount.Text = dtSale.Rows(i).Item("Discount").ToString()
            cboCustomerType.SelectedValue = dtSale.Rows(i).Item(4).ToString()
        End If

    End Function

    Private Function loadBillDetail(ByVal code As String)

        Dim _conn As SqlConnection = ConnectionManagement.GetConnection

        Dim _rd As SqlDataReader

        If _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If

        Dim sqlx As String = "SELECT [Sale],[Branch],[Product] ,[UnitPrice],[Quantity],[Discount],[Total],[Stylish],[Customer],[CustomerType] ,[Status],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP] FROM [SaleDetail] sd WHERE  Sale='" & code & "' order by Sale desc"
        Dim _cmd As SqlCommand = New SqlCommand(sqlx, _conn)
        _rd = _cmd.ExecuteReader


        ' get data by bill code from sele detail

        'Dim dtSaleDetail As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sqlx)

        Dim i As Integer = 0
        While _rd.Read()

            Dim _Customer As String = loadCustomer(_rd.GetValue(8).ToString())
            Dim _CustomerType As String = loadCustomerType(_rd.GetValue(9).ToString())
            Dim _Stylish As String = loadEmployee(_rd.GetValue(7).ToString())

            Dim sql = "SELECT    Product.producttype, Product.Title, Product.Code,  Product.ProductUnit, ProductUnit.Title AS ProductUnitTitle "
            sql &= " FROM         Product INNER JOIN ProductUnit ON Product.ProductUnit = ProductUnit.Code"
            sql &= " WHERE     (Product.code = '" & _rd.GetValue(2).ToString() & "')"

            Dim dt As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

            Dim ii As Integer

            Dim item(10) As String
            item(0) = ii + 1 ' no
            item(1) = dt.Rows(0).Item("Code") ' code
            item(2) = dt.Rows(0).Item("Title") ' title
            item(3) = _rd.GetValue(4).ToString() '1 ' amout
            item(4) = _rd.GetValue(3).ToString() ' unit price
            item(5) = CDec(_rd.GetValue(5).ToString()).ToString("F2") ' discount

            item(6) = CDec((item(3) * item(4)) - item(5)).ToString("F2") 'summary
            item(7) = _Stylish
            item(8) = _Customer
            item(9) = _CustomerType

            Dim lr As New ListViewItem(item)
            lvtItem.Items.Add(lr)

            i = i + 1
        End While
        _rd.Close()

        _conn.Close()
    End Function

    ' load payment from database to screen
    Private Function loadPayment(ByVal code As String)

        Dim sql As String = "select [Sale],[Branch],[PaymentMethod],[PayeeEmployee],[PaidAmt],[CardNumber],[Bank],[Cash],[change],[Status],[InsertDate],[InsertUser],[InsertIP],[LastUpdateDate],[LastUpdateUser],[LastUpdateIP] from salePayment WHERE  Sale='" & code & "'"
        Dim dtSaleDetail As DataTable = SQLHelper.ExecuteTable(ConnectionManagement.GetConnection, CommandType.Text, sql)

        Dim i As Integer = 0
        While i < dtSaleDetail.Rows.Count

            Dim item(3) As String
            item(0) = dtSaleDetail.Rows(i).Item(2).ToString()
            item(1) = dtSaleDetail.Rows(i).Item(4).ToString()
            item(2) = dtSaleDetail.Rows(i).Item(7).ToString()
            item(3) = dtSaleDetail.Rows(i).Item(5).ToString()
            Dim lr As New ListViewItem(item)
            lr.Tag = ""
            ListView1.Items.Add(lr)



            i = i + 1
        End While
    End Function

    Private Sub cboCustomerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomerType.SelectedIndexChanged

    End Sub



    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        If Button16.Text.Equals("Auto Tax Invoice") Then
            Button16.Text = "Not Tax Invoice"
        Else
            Button16.Text = "Auto Tax Invoice"
        End If
      
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dialogResult As MsgBoxResult

        modeSave = "new"

        dialogResult = MessageBox.Show("Are you want to open new bill ?", "Confirm", MessageBoxButtons.YesNo)

        If (dialogResult = MsgBoxResult.Yes) Then
            processNewBill()
            lvtItem.Items.Clear()
            ListView1.Items.Clear()
            LoadSumData() 'cal moneys
        End If

       
    End Sub

    Sub processNewBill()



        ' clear all data on form
        clearBill()

        'clear reference bill no 
        RefBillNo = ""

        ' get new bill no when need to open new bill
        getNewBillNo()

        enabledForm(True)
    End Sub

    Private Sub btnEditBill_Click(sender As Object, e As EventArgs) Handles btnEditBill.Click
        enabledForm(True)
        modeSave = "edit"
        'SaveData()
    End Sub

    Private Sub enabledForm(ByVal b As Boolean)
        panel_service_information.Enabled = b
        panel_service.Enabled = b
        panel_payment.Enabled = b
        Button26.Enabled = b
        Button1.Enabled = b
        Button16.Enabled = b
        Button15.Enabled = b

        btnCash.Enabled = b
        btnCreditCard.Enabled = b
        btnCoupon.Enabled = b
        btnVoucher.Enabled = b
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button15_MouseClick(sender As Object, e As MouseEventArgs)
        Button15.Enabled = Not Button15.Enabled
    End Sub

    Private Sub Button16_MouseClick(sender As Object, e As MouseEventArgs) Handles Button16.MouseClick
        ' Button16.Enabled = Not Button16.Enabled

    End Sub
End Class




Module mdlprint
    Public Class RawPrinter
        ' ----- Define the data type that supplies basic print job information to the spooler.
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure DOCINFO
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public pDataType As String
        End Structure

        ' ----- Define interfaces to the functions supplied in the DLL.
        <DllImport("winspool.drv", EntryPoint:="OpenPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter(ByVal printerName As String, ByRef hPrinter As IntPtr, ByVal printerDefaults As Integer) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="ClosePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartDocPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Integer, ByRef documentInfo As DOCINFO) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndDocPrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="WritePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal buffer As IntPtr, ByVal bufferLength As Integer, ByRef bytesWritten As Integer) As Boolean
        End Function

        Public Shared Function PrintRaw(ByVal printerName As String, ByVal origString As String) As Boolean
            ' ----- Send a string of  raw data to  the printer.
            Dim hPrinter As IntPtr
            Dim spoolData As New DOCINFO
            Dim dataToSend As IntPtr
            Dim dataSize As Integer
            Dim bytesWritten As Integer

            ' ----- The internal format of a .NET String is just
            '       different enough from what the printer expects
            '       that there will be a problem if we send it
            '       directly. Convert it to ANSI format before
            '       sending.
            dataSize = origString.Length()
            dataToSend = Marshal.StringToCoTaskMemAnsi(origString)

            ' ----- Prepare information for the spooler.
            spoolData.pDocName = "OpenDrawer" ' class='highlight'
            spoolData.pDataType = "RAW"

            Try
                ' ----- Open a channel to  the printer or spooler.
                Call OpenPrinter(printerName, hPrinter, 0)

                ' ----- Start a new document and Section 1.1.
                Call StartDocPrinter(hPrinter, 1, spoolData)
                Call StartPagePrinter(hPrinter)
                Call StartPagePrinter(hPrinter)

                ' ----- Send the data to the printer.
                Call WritePrinter(hPrinter, dataToSend, _
                   dataSize, bytesWritten)

                ' ----- Close everything that we opened.
                EndPagePrinter(hPrinter)
                EndDocPrinter(hPrinter)
                ClosePrinter(hPrinter)
                PrintRaw = True
            Catch ex As Exception
                MsgBox("Error occurred: " & ex.ToString)
                PrintRaw = False
            Finally
                ' ----- Get rid of the special ANSI version.
                Marshal.FreeCoTaskMem(dataToSend)
            End Try
        End Function


        


    End Class
End Module