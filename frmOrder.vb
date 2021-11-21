Imports System.Data.OleDb
Public Class frmOrder
    Dim iTax = 0.2
    Dim isSave = False
    'LOAD TABLES FUNCTION
    Private Sub LoadTables(Optional ByVal q As String = "")
        Try
            If con.State = ConnectionState.Closed Then
                OpenCon()
            End If
            query.Connection = con
            query.CommandText = "SELECT Order_Ref_No,Customer_ID,Customer_Name,Customer_Phone,Order_Date,Order_Time,Qty_Spaghetti,Qty_Burger,Qty_Fries, Qty_Cola,Qty_Rice,Price_Spaghetti,Price_Burger,Price_Fries,Price_Cola,Price_Rice,Order_Sub_Total,Tax,Total FROM tblOrders"
            adapter.SelectCommand = query
            dt.Clear()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub

    'CASHIER ID FUNCTION
    Private Sub cashierID(Optional ByVal q As String = "")
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        Try
            Dim strsql As String
            strsql = "SELECT * FROM tblUsers WHERE Username = '" & frmLogin.txtUsername.Text & "'"
            Dim cmd As New OleDbCommand(strsql, con)
            Dim myReader As OleDbDataReader
            myReader = cmd.ExecuteReader
            myReader.Read()
            txtCashierID.Text = myReader("ID")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub

    'RECEIPT DATA FUNCTION
    Private Sub receiptData(Optional ByVal q As String = "")
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        Dim strsql As String
        strsql = "SELECT * FROM tblOrders WHERE Customer_ID = " & txtCustomerID.Text & ""
        Dim cmd As New OleDbCommand(strsql, con)
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader
        myReader.Read()
        txtCustname.Text = myReader("Customer_Name")
        txtCustphone.Text = myReader("Customer_Phone")
        txtRef.Text = myReader("Order_Ref_No")
        txtOrderdate.Text = myReader("Order_Date")
        txtOrdertime.Text = myReader("Order_Time")
        txtQ1.Text = myReader("Qty_Spaghetti")
        txtQ2.Text = myReader("Qty_Burger")
        txtQ3.Text = myReader("Qty_Fries")
        txtQ4.Text = myReader("Qty_Cola")
        txtQ5.Text = myReader("Qty_Rice")
        txtP1.Text = myReader("Price_Spaghetti")
        txtP2.Text = myReader("Price_Burger")
        txtP3.Text = myReader("Price_Fries")
        txtP4.Text = myReader("Price_Cola")
        txtP5.Text = myReader("Price_Rice")
        txtST1.Text = myReader("Sub_Total_Spag")
        txtST2.Text = myReader("Sub_Total_Burg")
        txtST3.Text = myReader("Sub_Total_Fries")
        txtST4.Text = myReader("Sub_Total_Cola")
        txtST5.Text = myReader("Sub_Total_Rice")
        txtOST.Text = myReader("Order_Sub_Total")
        txtTx.Text = myReader("Tax")
        txtTtl.Text = myReader("Total")
        con.Close()
    End Sub

    'LOADER
    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage3.Enabled = False
        Call LoadTables()
        Call cashierID()
        'ITEM TEXTBOX PRICES
        txtPrice1.Text = "$50.00"
        txtPrice2.Text = "$30.00"
        txtPrice3.Text = "$20.00"
        txtPrice4.Text = "$15.00"
        txtPrice5.Text = "$10.00"
        'REMAINING TEXTBOX
        txtRefno.Text = "0"
        txtQty1.Text = "0"
        txtSubTotal1.Text = "0"
        txtQty2.Text = "0"
        txtSubTotal2.Text = "0"
        txtQty3.Text = "0"
        txtSubTotal3.Text = "0"
        txtQty4.Text = "0"
        txtSubTotal4.Text = "0"
        txtQty5.Text = "0"
        txtSubTotal5.Text = "0"
        txtOrderSubTotal.Text = "0"
        txtTax.Text = "0"
        txtTotal.Text = "0"
    End Sub

    'LOAD BUTTON
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Call LoadTables()
    End Sub

    'BACK BUTTON
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    'RESET BUTTON
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TabControl1.SelectedTab = TabPage1
        txtCustomerID.Text = ""
        txtQty1.Text = "0"
        txtQty2.Text = "0"
        txtQty3.Text = "0"
        txtQty4.Text = "0"
        txtQty5.Text = "0"

        txtSubTotal1.Text = "0"
        txtSubTotal2.Text = "0"
        txtSubTotal3.Text = "0"
        txtSubTotal4.Text = "0"
        txtSubTotal5.Text = "0"

        txtOrderSubTotal.Text = "0"
        txtTax.Text = "0"
        txtTotal.Text = "0"
        txtRefno.Text = "0"

        'PRINT TAB
        txtCustname.Text = ""
        txtCustphone.Text = ""
        txtRef.Text = ""
        txtOrderdate.Text = ""
        txtOrdertime.Text = ""
        txtQ1.Text = ""
        txtQ2.Text = ""
        txtQ3.Text = ""
        txtQ4.Text = ""
        txtQ5.Text = ""
        txtP1.Text = ""
        txtP2.Text = ""
        txtP3.Text = ""
        txtP4.Text = ""
        txtP5.Text = ""
        txtST1.Text = ""
        txtST2.Text = ""
        txtST3.Text = ""
        txtST4.Text = ""
        txtST5.Text = ""
        txtOST.Text = ""
        txtTx.Text = ""
        txtTtl.Text = ""
        'RECEIPT
        txtReceipt.Text = ""
    End Sub

    'TOTAL BUTTON
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        If txtQty1.Text = "0" And txtQty2.Text = "0" And txtQty3.Text = "0" And txtQty4.Text = "0" And txtQty5.Text = "0" Then
            MessageBox.Show("Please Add Order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim isEqual = False
                txtRefno.Text = (Rnd() * Rnd() * 32676)
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM tblOrders WHERE [Order_Ref_No] = @Order_Ref_No", con)
                    cmd.Parameters.AddWithValue("@Order_Ref_No", OleDbType.VarChar).Value = txtRefno.Text
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        isEqual = True
                        txtRefno.Text = Rnd() * Rnd() * 32676
                        Exit Sub
                    Else
                        isEqual = False
                        'FORMULA TO MULTIPLY VALUE OF PRICE TO THE QUANTITY
                        txtSubTotal1.Text = txtPrice1.Text * txtQty1.Text
                        txtSubTotal2.Text = txtPrice2.Text * txtQty2.Text
                        txtSubTotal3.Text = txtPrice3.Text * txtQty3.Text
                        txtSubTotal4.Text = txtPrice4.Text * txtQty4.Text
                        txtSubTotal5.Text = txtPrice5.Text * txtQty5.Text

                        'GROUPBOX 3 - Order_Sub_Total, Tax, & Total TEXTBOXES
                        txtOrderSubTotal.Text = Val(txtSubTotal1.Text) + Val(txtSubTotal2.Text) + Val(txtSubTotal3.Text) + Val(txtSubTotal4.Text) + Val(txtSubTotal5.Text)
                        txtTax.Text = (txtOrderSubTotal.Text * iTax) / 100
                        txtTotal.Text = Val(txtTax.Text) + Val(txtOrderSubTotal.Text)

                        'FORMAT CURRENCY
                        txtPrice1.Text = FormatCurrency(txtPrice1.Text)
                        txtPrice2.Text = FormatCurrency(txtPrice2.Text)
                        txtPrice3.Text = FormatCurrency(txtPrice3.Text)
                        txtPrice4.Text = FormatCurrency(txtPrice4.Text)
                        txtPrice5.Text = FormatCurrency(txtPrice5.Text)

                        txtSubTotal1.Text = FormatCurrency(txtSubTotal1.Text)
                        txtSubTotal2.Text = FormatCurrency(txtSubTotal2.Text)
                        txtSubTotal3.Text = FormatCurrency(txtSubTotal3.Text)
                        txtSubTotal4.Text = FormatCurrency(txtSubTotal4.Text)
                        txtSubTotal5.Text = FormatCurrency(txtSubTotal5.Text)

                        txtOrderSubTotal.Text = FormatCurrency(txtOrderSubTotal.Text)
                        txtTax.Text = FormatCurrency(txtTax.Text)
                        txtTotal.Text = FormatCurrency(txtTotal.Text)
                        con.Close()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub

    'SAVE BUTTON
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please input a Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtRefno.Text = "0" Then
            MessageBox.Show("Please Click Total First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtQty1.Text = "0" And txtQty2.Text = "0" And txtQty3.Text = "0" And txtQty4.Text = "0" And txtQty5.Text = "0" Then
            MessageBox.Show("Please Add Order First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                TabControl1.SelectedTab = TabPage1
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM tblOrders WHERE [Customer_ID] = @Customer_ID", con)
                    cmd.Parameters.AddWithValue("@Customer_ID", OleDbType.VarChar).Value = txtCustomerID.Text.Trim
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        query.Connection = con
                        query.CommandText = "UPDATE tblOrders SET Order_Ref_No = '" & txtRefno.Text & "', Order_Date = '" & Today & "', Order_Time = '" & TimeOfDay & "', Qty_Spaghetti = '" & txtQty1.Text & "', Qty_Burger = '" & txtQty2.Text & "', Qty_Fries = '" & txtQty3.Text & "', Qty_Cola = '" & txtQty4.Text & "', Qty_Rice = '" & txtQty5.Text & "', Price_Spaghetti = '" & txtPrice1.Text & "', Price_Burger = '" & txtPrice2.Text & "', Price_Fries = '" & txtPrice3.Text & "', Price_Cola = '" & txtPrice4.Text & "', Price_Rice = '" & txtPrice5.Text & "', Sub_Total_Spag = '" & txtSubTotal1.Text & "', Sub_Total_Burg = '" & txtSubTotal2.Text & "', Sub_Total_Fries = '" & txtSubTotal3.Text & "', Sub_Total_Cola = '" & txtSubTotal4.Text & "', Sub_Total_Rice = '" & txtSubTotal5.Text & "', Order_Sub_Total = '" & txtOrderSubTotal.Text & "', Tax = '" & txtTax.Text & "', Total = '" & txtTotal.Text & "'  WHERE Customer_ID = " & txtCustomerID.Text & ""
                        query.ExecuteNonQuery()
                        MessageBox.Show("Successfully Registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        isSave = True
                        con.Close()
                        Call LoadTables()
                        Exit Sub
                    Else
                        MessageBox.Show("Customer ID is not Registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
            Call LoadTables()
        End If
    End Sub

    'DELIVERED BUTTON
    Private Sub btnDelivered_Click(sender As Object, e As EventArgs) Handles btnDelivered.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please input a Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using cmd As New OleDbCommand("Select COUNT(*) FROM tblOrders WHERE [Customer_ID] = @Customer_ID", con)
                    cmd.Parameters.AddWithValue("@Customer_ID", OleDbType.VarChar).Value = txtCustomerID.Text.Trim
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        TabControl1.SelectedTab = TabPage1
                        query.Connection = con
                        query.CommandText = "UPDATE tblOrders SET Order_Ref_No = '" & Nothing & "', Qty_Spaghetti = '" & Nothing & "', Qty_Burger = '" & Nothing & "', Qty_Fries = '" & Nothing & "', Qty_Cola = '" & Nothing & "', Qty_Rice = '" & Nothing & "', Price_Spaghetti = '" & Nothing & "', Price_Burger = '" & Nothing & "', Price_Fries = '" & Nothing & "', Price_Cola = '" & Nothing & "', Price_Rice = '" & Nothing & "', Sub_Total_Spag = '" & Nothing & "', Sub_Total_Burg = '" & Nothing & "', Sub_Total_Fries = '" & Nothing & "', Sub_Total_Cola = '" & Nothing & "', Sub_Total_Rice = '" & Nothing & "', Order_Sub_Total = '" & Nothing & "', Tax = '" & Nothing & "', Total = '" & Nothing & "'  WHERE Customer_ID = " & txtCustomerID.Text & ""
                        query.ExecuteNonQuery()
                        MessageBox.Show("Successfully Delivered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        con.Close()
                        Call LoadTables()
                        Exit Sub
                    Else
                        MessageBox.Show("Customer ID is not Registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
            Call LoadTables()
        End If
    End Sub

    'CHECK BUTTON
    Private Sub btnPrint2_Click(sender As Object, e As EventArgs) Handles btnPrint2.Click
        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please input a Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf isSave = False Then
            MessageBox.Show("Save Order First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                TabControl1.SelectedTab = TabPage3
                Call receiptData()
                TabPage3.Enabled = True
                isSave = False
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    'PRINT BUTTON
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please input a Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '  ElseIf txt Then
        Else
            Try
                txtReceipt.Clear()
                Using cmd As New OleDbCommand("Select COUNT(*) FROM tblOrders WHERE [Customer_ID] = @Customer_ID", con)
                    cmd.Parameters.AddWithValue("@Customer_ID", OleDbType.VarChar).Value = txtCustomerID.Text.Trim
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        TabControl1.SelectedTab = TabPage2
                        txtOrdertime.Text = TimeOfDay

                        txtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab & "ITERY ORDERING SYSTEM" + vbNewLine)
                        txtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab & "Cashier Name: " & frmMain.lblUsername.Text)

                        txtReceipt.AppendText(vbTab + vbTab + vbTab & "=============================================================================" + vbNewLine)
                        txtReceipt.AppendText("" + vbNewLine)
                        txtReceipt.AppendText("Name: " & txtCustname.Text + vbTab + vbTab + "Phone No: " & txtCustphone.Text + vbTab +
                                   "Ref No: " & txtRef.Text + vbNewLine)

                        txtReceipt.AppendText(vbNewLine + "Order Date:" + vbTab & txtOrderdate.Text + vbTab + vbTab + "Order Time: " +
                                  vbTab & txtOrdertime.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + "Item " + vbTab & "           Quantity: " + vbTab + vbTab & "Price: " + vbTab + vbTab & "Sub Total: " + vbNewLine)

                        txtReceipt.AppendText(vbNewLine + "Spaghetti: " + vbTab & txtQ1.Text + vbTab + vbTab & txtP1.Text + vbTab +
                                  vbTab & txtST1.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + "Burger: " + vbTab + vbTab & txtQ2.Text + vbTab + vbTab & txtP2.Text + vbTab +
                                  vbTab & txtST2.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + "Fries: " + vbTab + vbTab & txtQ3.Text + vbTab + vbTab & txtP3.Text + vbTab +
                                  vbTab & txtST3.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + "Cola: " + vbTab + vbTab & txtQ4.Text + vbTab + vbTab & txtP4.Text + vbTab +
                                  vbTab & txtST4.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + "Rice: " + vbTab + vbTab & txtQ5.Text + vbTab + vbTab & txtP5.Text + vbTab +
                                  vbTab & txtST5.Text + vbNewLine)

                        txtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab & "Order Sub Total: " + vbTab & txtOST.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab & "Tax On Order: " + vbTab & txtTx.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + vbTab + vbTab + vbTab & "Net Total: " + vbTab & txtTtl.Text + vbNewLine)
                        txtReceipt.AppendText(vbNewLine + "=============================================================================" + vbNewLine)
                        txtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab & "ITERY ORDERS RECEIPT" + vbNewLine)
                        TabPage3.Enabled = False
                        con.Close()
                        Exit Sub
                    Else
                        MessageBox.Show("Customer ID is not Registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
        End If
        con.Close()
    End Sub
End Class