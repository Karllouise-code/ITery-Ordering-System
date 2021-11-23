<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCashierID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQty1 = New System.Windows.Forms.TextBox()
        Me.txtQty2 = New System.Windows.Forms.TextBox()
        Me.txtQty3 = New System.Windows.Forms.TextBox()
        Me.txtQty4 = New System.Windows.Forms.TextBox()
        Me.txtQty5 = New System.Windows.Forms.TextBox()
        Me.txtPrice1 = New System.Windows.Forms.TextBox()
        Me.txtPrice2 = New System.Windows.Forms.TextBox()
        Me.txtPrice3 = New System.Windows.Forms.TextBox()
        Me.txtPrice4 = New System.Windows.Forms.TextBox()
        Me.txtPrice5 = New System.Windows.Forms.TextBox()
        Me.txtSubTotal5 = New System.Windows.Forms.TextBox()
        Me.txtSubTotal4 = New System.Windows.Forms.TextBox()
        Me.txtSubTotal3 = New System.Windows.Forms.TextBox()
        Me.txtSubTotal2 = New System.Windows.Forms.TextBox()
        Me.txtSubTotal1 = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelivered = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTx = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtTtl = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtOST = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtST5 = New System.Windows.Forms.TextBox()
        Me.txtST4 = New System.Windows.Forms.TextBox()
        Me.txtST3 = New System.Windows.Forms.TextBox()
        Me.txtST2 = New System.Windows.Forms.TextBox()
        Me.txtST1 = New System.Windows.Forms.TextBox()
        Me.txtP5 = New System.Windows.Forms.TextBox()
        Me.txtP4 = New System.Windows.Forms.TextBox()
        Me.txtP3 = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.txtP1 = New System.Windows.Forms.TextBox()
        Me.txtQ5 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtQ3 = New System.Windows.Forms.TextBox()
        Me.txtQ2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtQ1 = New System.Windows.Forms.TextBox()
        Me.txtOrdertime = New System.Windows.Forms.TextBox()
        Me.txtOrderdate = New System.Windows.Forms.TextBox()
        Me.txtCustphone = New System.Windows.Forms.TextBox()
        Me.txtCustname = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRefno = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtOrderSubTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.btnAddcart = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnCustomerIns = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITery Ordering System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.txtCashierID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 78)
        Me.Panel1.TabIndex = 2
        '
        'txtCashierID
        '
        Me.txtCashierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashierID.Location = New System.Drawing.Point(15, 19)
        Me.txtCashierID.Name = "txtCashierID"
        Me.txtCashierID.ReadOnly = True
        Me.txtCashierID.Size = New System.Drawing.Size(33, 24)
        Me.txtCashierID.TabIndex = 37
        Me.txtCashierID.TabStop = False
        Me.txtCashierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ITEMS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "QUANTITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PRICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SUB-TOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Spaghetti"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Burger"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fries"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Rice"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Cola"
        '
        'txtQty1
        '
        Me.txtQty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty1.Location = New System.Drawing.Point(158, 176)
        Me.txtQty1.Name = "txtQty1"
        Me.txtQty1.Size = New System.Drawing.Size(57, 24)
        Me.txtQty1.TabIndex = 12
        '
        'txtQty2
        '
        Me.txtQty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty2.Location = New System.Drawing.Point(158, 219)
        Me.txtQty2.Name = "txtQty2"
        Me.txtQty2.Size = New System.Drawing.Size(57, 24)
        Me.txtQty2.TabIndex = 13
        '
        'txtQty3
        '
        Me.txtQty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty3.Location = New System.Drawing.Point(158, 259)
        Me.txtQty3.Name = "txtQty3"
        Me.txtQty3.Size = New System.Drawing.Size(57, 24)
        Me.txtQty3.TabIndex = 14
        '
        'txtQty4
        '
        Me.txtQty4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty4.Location = New System.Drawing.Point(158, 301)
        Me.txtQty4.Name = "txtQty4"
        Me.txtQty4.Size = New System.Drawing.Size(57, 24)
        Me.txtQty4.TabIndex = 15
        '
        'txtQty5
        '
        Me.txtQty5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty5.Location = New System.Drawing.Point(158, 344)
        Me.txtQty5.Name = "txtQty5"
        Me.txtQty5.Size = New System.Drawing.Size(57, 24)
        Me.txtQty5.TabIndex = 16
        '
        'txtPrice1
        '
        Me.txtPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice1.Location = New System.Drawing.Point(285, 174)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.ReadOnly = True
        Me.txtPrice1.Size = New System.Drawing.Size(58, 24)
        Me.txtPrice1.TabIndex = 17
        Me.txtPrice1.TabStop = False
        Me.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice2
        '
        Me.txtPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice2.Location = New System.Drawing.Point(285, 216)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.ReadOnly = True
        Me.txtPrice2.Size = New System.Drawing.Size(58, 24)
        Me.txtPrice2.TabIndex = 18
        Me.txtPrice2.TabStop = False
        Me.txtPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice3
        '
        Me.txtPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice3.Location = New System.Drawing.Point(285, 260)
        Me.txtPrice3.Name = "txtPrice3"
        Me.txtPrice3.ReadOnly = True
        Me.txtPrice3.Size = New System.Drawing.Size(58, 24)
        Me.txtPrice3.TabIndex = 19
        Me.txtPrice3.TabStop = False
        Me.txtPrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice4
        '
        Me.txtPrice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice4.Location = New System.Drawing.Point(285, 300)
        Me.txtPrice4.Name = "txtPrice4"
        Me.txtPrice4.ReadOnly = True
        Me.txtPrice4.Size = New System.Drawing.Size(58, 24)
        Me.txtPrice4.TabIndex = 20
        Me.txtPrice4.TabStop = False
        Me.txtPrice4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice5
        '
        Me.txtPrice5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice5.Location = New System.Drawing.Point(285, 343)
        Me.txtPrice5.Name = "txtPrice5"
        Me.txtPrice5.ReadOnly = True
        Me.txtPrice5.Size = New System.Drawing.Size(58, 24)
        Me.txtPrice5.TabIndex = 21
        Me.txtPrice5.TabStop = False
        Me.txtPrice5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubTotal5
        '
        Me.txtSubTotal5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal5.Location = New System.Drawing.Point(395, 343)
        Me.txtSubTotal5.Name = "txtSubTotal5"
        Me.txtSubTotal5.ReadOnly = True
        Me.txtSubTotal5.Size = New System.Drawing.Size(70, 24)
        Me.txtSubTotal5.TabIndex = 26
        Me.txtSubTotal5.TabStop = False
        Me.txtSubTotal5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal4
        '
        Me.txtSubTotal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal4.Location = New System.Drawing.Point(395, 300)
        Me.txtSubTotal4.Name = "txtSubTotal4"
        Me.txtSubTotal4.ReadOnly = True
        Me.txtSubTotal4.Size = New System.Drawing.Size(70, 24)
        Me.txtSubTotal4.TabIndex = 25
        Me.txtSubTotal4.TabStop = False
        Me.txtSubTotal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal3
        '
        Me.txtSubTotal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal3.Location = New System.Drawing.Point(395, 260)
        Me.txtSubTotal3.Name = "txtSubTotal3"
        Me.txtSubTotal3.ReadOnly = True
        Me.txtSubTotal3.Size = New System.Drawing.Size(70, 24)
        Me.txtSubTotal3.TabIndex = 24
        Me.txtSubTotal3.TabStop = False
        Me.txtSubTotal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal2
        '
        Me.txtSubTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal2.Location = New System.Drawing.Point(395, 216)
        Me.txtSubTotal2.Name = "txtSubTotal2"
        Me.txtSubTotal2.ReadOnly = True
        Me.txtSubTotal2.Size = New System.Drawing.Size(70, 24)
        Me.txtSubTotal2.TabIndex = 23
        Me.txtSubTotal2.TabStop = False
        Me.txtSubTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal1
        '
        Me.txtSubTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal1.Location = New System.Drawing.Point(395, 174)
        Me.txtSubTotal1.Name = "txtSubTotal1"
        Me.txtSubTotal1.ReadOnly = True
        Me.txtSubTotal1.Size = New System.Drawing.Size(70, 24)
        Me.txtSubTotal1.TabIndex = 22
        Me.txtSubTotal1.TabStop = False
        Me.txtSubTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnTotal
        '
        Me.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(137, 408)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(103, 42)
        Me.btnTotal.TabIndex = 27
        Me.btnTotal.Text = "&Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(246, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 42)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(8, 17)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(85, 30)
        Me.btnCheck.TabIndex = 31
        Me.btnCheck.Text = "&Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(27, 383)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(79, 38)
        Me.btnReset.TabIndex = 34
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelivered
        '
        Me.btnDelivered.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivered.Location = New System.Drawing.Point(298, 461)
        Me.btnDelivered.Name = "btnDelivered"
        Me.btnDelivered.Size = New System.Drawing.Size(103, 42)
        Me.btnDelivered.TabIndex = 33
        Me.btnDelivered.Text = "&Delivered"
        Me.btnDelivered.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(533, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 317)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 292)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnLoad)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(601, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Order"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.Location = New System.Drawing.Point(396, 7)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(77, 26)
        Me.btnLoad.TabIndex = 37
        Me.btnLoad.Text = "&Refresh"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 225)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtRef)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.txtTx)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.txtTtl)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.txtOST)
        Me.TabPage3.Controls.Add(Me.btnCheck)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.txtST5)
        Me.TabPage3.Controls.Add(Me.txtST4)
        Me.TabPage3.Controls.Add(Me.txtST3)
        Me.TabPage3.Controls.Add(Me.txtST2)
        Me.TabPage3.Controls.Add(Me.txtST1)
        Me.TabPage3.Controls.Add(Me.txtP5)
        Me.TabPage3.Controls.Add(Me.txtP4)
        Me.TabPage3.Controls.Add(Me.txtP3)
        Me.TabPage3.Controls.Add(Me.txtP2)
        Me.TabPage3.Controls.Add(Me.txtP1)
        Me.TabPage3.Controls.Add(Me.txtQ5)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.txtQ4)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.txtQ3)
        Me.TabPage3.Controls.Add(Me.txtQ2)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.txtQ1)
        Me.TabPage3.Controls.Add(Me.txtOrdertime)
        Me.TabPage3.Controls.Add(Me.txtOrderdate)
        Me.TabPage3.Controls.Add(Me.txtCustphone)
        Me.TabPage3.Controls.Add(Me.txtCustname)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(601, 266)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cart"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtRef
        '
        Me.txtRef.BackColor = System.Drawing.SystemColors.Window
        Me.txtRef.Location = New System.Drawing.Point(200, 81)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.ReadOnly = True
        Me.txtRef.Size = New System.Drawing.Size(100, 20)
        Me.txtRef.TabIndex = 40
        Me.txtRef.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(157, 84)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 13)
        Me.Label33.TabIndex = 41
        Me.Label33.Text = "Ref No:"
        '
        'txtTx
        '
        Me.txtTx.BackColor = System.Drawing.SystemColors.Window
        Me.txtTx.Location = New System.Drawing.Point(502, 195)
        Me.txtTx.Name = "txtTx"
        Me.txtTx.ReadOnly = True
        Me.txtTx.Size = New System.Drawing.Size(78, 20)
        Me.txtTx.TabIndex = 39
        Me.txtTx.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(477, 198)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(28, 13)
        Me.Label32.TabIndex = 38
        Me.Label32.Text = "Tax:"
        '
        'txtTtl
        '
        Me.txtTtl.BackColor = System.Drawing.SystemColors.Window
        Me.txtTtl.Location = New System.Drawing.Point(502, 236)
        Me.txtTtl.Name = "txtTtl"
        Me.txtTtl.ReadOnly = True
        Me.txtTtl.Size = New System.Drawing.Size(78, 20)
        Me.txtTtl.TabIndex = 37
        Me.txtTtl.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(471, 239)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 36
        Me.Label31.Text = "Total:"
        '
        'txtOST
        '
        Me.txtOST.BackColor = System.Drawing.SystemColors.Window
        Me.txtOST.Location = New System.Drawing.Point(502, 166)
        Me.txtOST.Name = "txtOST"
        Me.txtOST.ReadOnly = True
        Me.txtOST.Size = New System.Drawing.Size(78, 20)
        Me.txtOST.TabIndex = 35
        Me.txtOST.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(420, 169)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(85, 13)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "Order Sub Total:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(236, 6)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(147, 13)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "ITERY ORDERING SYSTEM"
        '
        'txtST5
        '
        Me.txtST5.BackColor = System.Drawing.SystemColors.Window
        Me.txtST5.Location = New System.Drawing.Point(341, 236)
        Me.txtST5.Name = "txtST5"
        Me.txtST5.ReadOnly = True
        Me.txtST5.Size = New System.Drawing.Size(64, 20)
        Me.txtST5.TabIndex = 32
        Me.txtST5.TabStop = False
        '
        'txtST4
        '
        Me.txtST4.BackColor = System.Drawing.SystemColors.Window
        Me.txtST4.Location = New System.Drawing.Point(341, 210)
        Me.txtST4.Name = "txtST4"
        Me.txtST4.ReadOnly = True
        Me.txtST4.Size = New System.Drawing.Size(64, 20)
        Me.txtST4.TabIndex = 31
        Me.txtST4.TabStop = False
        '
        'txtST3
        '
        Me.txtST3.BackColor = System.Drawing.SystemColors.Window
        Me.txtST3.Location = New System.Drawing.Point(341, 184)
        Me.txtST3.Name = "txtST3"
        Me.txtST3.ReadOnly = True
        Me.txtST3.Size = New System.Drawing.Size(64, 20)
        Me.txtST3.TabIndex = 30
        Me.txtST3.TabStop = False
        '
        'txtST2
        '
        Me.txtST2.BackColor = System.Drawing.SystemColors.Window
        Me.txtST2.Location = New System.Drawing.Point(341, 156)
        Me.txtST2.Name = "txtST2"
        Me.txtST2.ReadOnly = True
        Me.txtST2.Size = New System.Drawing.Size(64, 20)
        Me.txtST2.TabIndex = 29
        Me.txtST2.TabStop = False
        '
        'txtST1
        '
        Me.txtST1.BackColor = System.Drawing.SystemColors.Window
        Me.txtST1.Location = New System.Drawing.Point(341, 129)
        Me.txtST1.Name = "txtST1"
        Me.txtST1.ReadOnly = True
        Me.txtST1.Size = New System.Drawing.Size(64, 20)
        Me.txtST1.TabIndex = 28
        Me.txtST1.TabStop = False
        '
        'txtP5
        '
        Me.txtP5.BackColor = System.Drawing.SystemColors.Window
        Me.txtP5.Location = New System.Drawing.Point(271, 236)
        Me.txtP5.Name = "txtP5"
        Me.txtP5.ReadOnly = True
        Me.txtP5.Size = New System.Drawing.Size(44, 20)
        Me.txtP5.TabIndex = 27
        Me.txtP5.TabStop = False
        '
        'txtP4
        '
        Me.txtP4.BackColor = System.Drawing.SystemColors.Window
        Me.txtP4.Location = New System.Drawing.Point(271, 210)
        Me.txtP4.Name = "txtP4"
        Me.txtP4.ReadOnly = True
        Me.txtP4.Size = New System.Drawing.Size(44, 20)
        Me.txtP4.TabIndex = 26
        Me.txtP4.TabStop = False
        '
        'txtP3
        '
        Me.txtP3.BackColor = System.Drawing.SystemColors.Window
        Me.txtP3.Location = New System.Drawing.Point(271, 184)
        Me.txtP3.Name = "txtP3"
        Me.txtP3.ReadOnly = True
        Me.txtP3.Size = New System.Drawing.Size(44, 20)
        Me.txtP3.TabIndex = 25
        Me.txtP3.TabStop = False
        '
        'txtP2
        '
        Me.txtP2.BackColor = System.Drawing.SystemColors.Window
        Me.txtP2.Location = New System.Drawing.Point(271, 156)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.ReadOnly = True
        Me.txtP2.Size = New System.Drawing.Size(44, 20)
        Me.txtP2.TabIndex = 24
        Me.txtP2.TabStop = False
        '
        'txtP1
        '
        Me.txtP1.BackColor = System.Drawing.SystemColors.Window
        Me.txtP1.Location = New System.Drawing.Point(271, 130)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.ReadOnly = True
        Me.txtP1.Size = New System.Drawing.Size(44, 20)
        Me.txtP1.TabIndex = 23
        Me.txtP1.TabStop = False
        '
        'txtQ5
        '
        Me.txtQ5.BackColor = System.Drawing.SystemColors.Window
        Me.txtQ5.Location = New System.Drawing.Point(193, 235)
        Me.txtQ5.Name = "txtQ5"
        Me.txtQ5.ReadOnly = True
        Me.txtQ5.Size = New System.Drawing.Size(28, 20)
        Me.txtQ5.TabIndex = 22
        Me.txtQ5.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(110, 238)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 13)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Rice"
        '
        'txtQ4
        '
        Me.txtQ4.BackColor = System.Drawing.SystemColors.Window
        Me.txtQ4.Location = New System.Drawing.Point(193, 209)
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.ReadOnly = True
        Me.txtQ4.Size = New System.Drawing.Size(28, 20)
        Me.txtQ4.TabIndex = 20
        Me.txtQ4.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(110, 212)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 13)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Cola"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(109, 183)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Fries"
        '
        'txtQ3
        '
        Me.txtQ3.BackColor = System.Drawing.SystemColors.Window
        Me.txtQ3.Location = New System.Drawing.Point(193, 183)
        Me.txtQ3.Name = "txtQ3"
        Me.txtQ3.ReadOnly = True
        Me.txtQ3.Size = New System.Drawing.Size(28, 20)
        Me.txtQ3.TabIndex = 17
        Me.txtQ3.TabStop = False
        '
        'txtQ2
        '
        Me.txtQ2.BackColor = System.Drawing.SystemColors.Window
        Me.txtQ2.Location = New System.Drawing.Point(193, 155)
        Me.txtQ2.Name = "txtQ2"
        Me.txtQ2.ReadOnly = True
        Me.txtQ2.Size = New System.Drawing.Size(28, 20)
        Me.txtQ2.TabIndex = 16
        Me.txtQ2.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(344, 110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 13)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Sub Total"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(275, 110)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Price"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(184, 110)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Quantity"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(109, 109)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Item"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(107, 157)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Burger"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(98, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Spaghetti"
        '
        'txtQ1
        '
        Me.txtQ1.BackColor = System.Drawing.SystemColors.Window
        Me.txtQ1.Location = New System.Drawing.Point(193, 129)
        Me.txtQ1.Name = "txtQ1"
        Me.txtQ1.ReadOnly = True
        Me.txtQ1.Size = New System.Drawing.Size(28, 20)
        Me.txtQ1.TabIndex = 8
        Me.txtQ1.TabStop = False
        '
        'txtOrdertime
        '
        Me.txtOrdertime.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdertime.Location = New System.Drawing.Point(384, 57)
        Me.txtOrdertime.Name = "txtOrdertime"
        Me.txtOrdertime.ReadOnly = True
        Me.txtOrdertime.Size = New System.Drawing.Size(100, 20)
        Me.txtOrdertime.TabIndex = 6
        Me.txtOrdertime.TabStop = False
        '
        'txtOrderdate
        '
        Me.txtOrderdate.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrderdate.Location = New System.Drawing.Point(384, 31)
        Me.txtOrderdate.Name = "txtOrderdate"
        Me.txtOrderdate.ReadOnly = True
        Me.txtOrderdate.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderdate.TabIndex = 2
        Me.txtOrderdate.TabStop = False
        '
        'txtCustphone
        '
        Me.txtCustphone.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustphone.Location = New System.Drawing.Point(200, 57)
        Me.txtCustphone.Name = "txtCustphone"
        Me.txtCustphone.ReadOnly = True
        Me.txtCustphone.Size = New System.Drawing.Size(100, 20)
        Me.txtCustphone.TabIndex = 1
        Me.txtCustphone.TabStop = False
        '
        'txtCustname
        '
        Me.txtCustname.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustname.Location = New System.Drawing.Point(200, 31)
        Me.txtCustname.Name = "txtCustname"
        Me.txtCustname.ReadOnly = True
        Me.txtCustname.Size = New System.Drawing.Size(100, 20)
        Me.txtCustname.TabIndex = 0
        Me.txtCustname.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(116, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Customer Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(113, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Customer Phone:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(325, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Order Date:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(325, 61)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Order Time:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtReceipt)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(601, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receipt Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtReceipt
        '
        Me.txtReceipt.Location = New System.Drawing.Point(3, 4)
        Me.txtReceipt.Multiline = True
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReceipt.Size = New System.Drawing.Size(595, 259)
        Me.txtReceipt.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRefno)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtTax)
        Me.GroupBox2.Controls.Add(Me.txtOrderSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(545, 407)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(489, 189)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txtRefno
        '
        Me.txtRefno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.Location = New System.Drawing.Point(67, 19)
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.ReadOnly = True
        Me.txtRefno.Size = New System.Drawing.Size(74, 24)
        Me.txtRefno.TabIndex = 38
        Me.txtRefno.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 19)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Ref No:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(237, 144)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(200, 24)
        Me.txtTotal.TabIndex = 39
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(237, 97)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(200, 24)
        Me.txtTax.TabIndex = 38
        Me.txtTax.TabStop = False
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOrderSubTotal
        '
        Me.txtOrderSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderSubTotal.Location = New System.Drawing.Point(237, 59)
        Me.txtOrderSubTotal.Name = "txtOrderSubTotal"
        Me.txtOrderSubTotal.ReadOnly = True
        Me.txtOrderSubTotal.Size = New System.Drawing.Size(200, 24)
        Me.txtOrderSubTotal.TabIndex = 35
        Me.txtOrderSubTotal.TabStop = False
        Me.txtOrderSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(174, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 22)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(188, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 22)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Tax:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(84, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 22)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Order Sub-Total:"
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Location = New System.Drawing.Point(15, 545)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(77, 26)
        Me.btnBack.TabIndex = 35
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(133, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(233, 95)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(110, 24)
        Me.txtCustomerID.TabIndex = 1
        '
        'btnAddcart
        '
        Me.btnAddcart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddcart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddcart.Location = New System.Drawing.Point(355, 408)
        Me.btnAddcart.Name = "btnAddcart"
        Me.btnAddcart.Size = New System.Drawing.Size(103, 42)
        Me.btnAddcart.TabIndex = 29
        Me.btnAddcart.Text = "&Add Cart"
        Me.btnAddcart.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'btnCustomerIns
        '
        Me.btnCustomerIns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomerIns.Location = New System.Drawing.Point(98, 545)
        Me.btnCustomerIns.Name = "btnCustomerIns"
        Me.btnCustomerIns.Size = New System.Drawing.Size(117, 26)
        Me.btnCustomerIns.TabIndex = 38
        Me.btnCustomerIns.Text = "&Add Customer Intead"
        Me.btnCustomerIns.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(189, 461)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(103, 42)
        Me.btnPrint.TabIndex = 32
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 599)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCustomerIns)
        Me.Controls.Add(Me.btnAddcart)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelivered)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtSubTotal5)
        Me.Controls.Add(Me.txtSubTotal4)
        Me.Controls.Add(Me.txtSubTotal3)
        Me.Controls.Add(Me.txtSubTotal2)
        Me.Controls.Add(Me.txtSubTotal1)
        Me.Controls.Add(Me.txtPrice5)
        Me.Controls.Add(Me.txtPrice4)
        Me.Controls.Add(Me.txtPrice3)
        Me.Controls.Add(Me.txtPrice2)
        Me.Controls.Add(Me.txtPrice1)
        Me.Controls.Add(Me.txtQty5)
        Me.Controls.Add(Me.txtQty4)
        Me.Controls.Add(Me.txtQty3)
        Me.Controls.Add(Me.txtQty2)
        Me.Controls.Add(Me.txtQty1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmOrder"
        Me.Text = "frmOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtQty1 As TextBox
    Friend WithEvents txtQty2 As TextBox
    Friend WithEvents txtQty3 As TextBox
    Friend WithEvents txtQty4 As TextBox
    Friend WithEvents txtQty5 As TextBox
    Friend WithEvents txtPrice1 As TextBox
    Friend WithEvents txtPrice2 As TextBox
    Friend WithEvents txtPrice3 As TextBox
    Friend WithEvents txtPrice4 As TextBox
    Friend WithEvents txtPrice5 As TextBox
    Friend WithEvents txtSubTotal5 As TextBox
    Friend WithEvents txtSubTotal4 As TextBox
    Friend WithEvents txtSubTotal3 As TextBox
    Friend WithEvents txtSubTotal2 As TextBox
    Friend WithEvents txtSubTotal1 As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelivered As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtOrderSubTotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtRefno As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label19 As Label
    Friend WithEvents txtOrdertime As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtOrderdate As TextBox
    Friend WithEvents txtCustphone As TextBox
    Friend WithEvents txtCustname As TextBox
    Friend WithEvents txtQ5 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtQ4 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtQ3 As TextBox
    Friend WithEvents txtQ2 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtQ1 As TextBox
    Friend WithEvents txtST5 As TextBox
    Friend WithEvents txtST4 As TextBox
    Friend WithEvents txtST3 As TextBox
    Friend WithEvents txtST2 As TextBox
    Friend WithEvents txtST1 As TextBox
    Friend WithEvents txtP5 As TextBox
    Friend WithEvents txtP4 As TextBox
    Friend WithEvents txtP3 As TextBox
    Friend WithEvents txtP2 As TextBox
    Friend WithEvents txtP1 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtTx As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtTtl As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtOST As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtRef As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtCashierID As TextBox
    Friend WithEvents btnAddcart As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnCustomerIns As Button
    Friend WithEvents btnPrint As Button
End Class
