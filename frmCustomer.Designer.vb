<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
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
        Dim Customer_NameLabel1 As System.Windows.Forms.Label
        Dim Customer_PhoneLabel1 As System.Windows.Forms.Label
        Dim Order_DateLabel1 As System.Windows.Forms.Label
        Dim Order_TimeLabel1 As System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtCustomername = New System.Windows.Forms.TextBox()
        Me.txtCustomerphone = New System.Windows.Forms.TextBox()
        Me.txtOrderdate = New System.Windows.Forms.TextBox()
        Me.txtOrdertime = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Customer_NameLabel1 = New System.Windows.Forms.Label()
        Customer_PhoneLabel1 = New System.Windows.Forms.Label()
        Order_DateLabel1 = New System.Windows.Forms.Label()
        Order_TimeLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_NameLabel1
        '
        Customer_NameLabel1.AutoSize = True
        Customer_NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel1.Location = New System.Drawing.Point(139, 124)
        Customer_NameLabel1.Name = "Customer_NameLabel1"
        Customer_NameLabel1.Size = New System.Drawing.Size(122, 18)
        Customer_NameLabel1.TabIndex = 24
        Customer_NameLabel1.Text = "Customer Name:"
        '
        'Customer_PhoneLabel1
        '
        Customer_PhoneLabel1.AutoSize = True
        Customer_PhoneLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_PhoneLabel1.Location = New System.Drawing.Point(136, 184)
        Customer_PhoneLabel1.Name = "Customer_PhoneLabel1"
        Customer_PhoneLabel1.Size = New System.Drawing.Size(125, 18)
        Customer_PhoneLabel1.TabIndex = 25
        Customer_PhoneLabel1.Text = "Customer Phone:"
        '
        'Order_DateLabel1
        '
        Order_DateLabel1.AutoSize = True
        Order_DateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_DateLabel1.Location = New System.Drawing.Point(469, 124)
        Order_DateLabel1.Name = "Order_DateLabel1"
        Order_DateLabel1.Size = New System.Drawing.Size(85, 18)
        Order_DateLabel1.TabIndex = 26
        Order_DateLabel1.Text = "Order Date:"
        '
        'Order_TimeLabel1
        '
        Order_TimeLabel1.AutoSize = True
        Order_TimeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_TimeLabel1.Location = New System.Drawing.Point(469, 183)
        Order_TimeLabel1.Name = "Order_TimeLabel1"
        Order_TimeLabel1.Size = New System.Drawing.Size(87, 18)
        Order_TimeLabel1.TabIndex = 27
        Order_TimeLabel1.Text = "Order Time:"
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(25, 104)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 78)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITery Customers Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnInsert
        '
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(426, 285)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(92, 35)
        Me.btnInsert.TabIndex = 13
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(553, 285)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 35)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(676, 285)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 35)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(222, 290)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(171, 24)
        Me.txtSearch.TabIndex = 24
        '
        'txtCustomername
        '
        Me.txtCustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomername.Location = New System.Drawing.Point(257, 125)
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.Size = New System.Drawing.Size(171, 24)
        Me.txtCustomername.TabIndex = 25
        '
        'txtCustomerphone
        '
        Me.txtCustomerphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerphone.Location = New System.Drawing.Point(257, 183)
        Me.txtCustomerphone.Name = "txtCustomerphone"
        Me.txtCustomerphone.Size = New System.Drawing.Size(171, 24)
        Me.txtCustomerphone.TabIndex = 26
        '
        'txtOrderdate
        '
        Me.txtOrderdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderdate.Location = New System.Drawing.Point(553, 125)
        Me.txtOrderdate.Name = "txtOrderdate"
        Me.txtOrderdate.ReadOnly = True
        Me.txtOrderdate.Size = New System.Drawing.Size(171, 24)
        Me.txtOrderdate.TabIndex = 27
        Me.txtOrderdate.TabStop = False
        '
        'txtOrdertime
        '
        Me.txtOrdertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdertime.Location = New System.Drawing.Point(553, 183)
        Me.txtOrdertime.Name = "txtOrdertime"
        Me.txtOrdertime.ReadOnly = True
        Me.txtOrdertime.Size = New System.Drawing.Size(171, 24)
        Me.txtOrdertime.TabIndex = 28
        Me.txtOrdertime.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(222, 326)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 186)
        Me.DataGridView1.TabIndex = 2
        '
        'btnLoad
        '
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(124, 368)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(92, 35)
        Me.btnLoad.TabIndex = 29
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(125, 283)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(92, 35)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 524)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtOrdertime)
        Me.Controls.Add(Me.txtOrderdate)
        Me.Controls.Add(Me.txtCustomerphone)
        Me.Controls.Add(Me.txtCustomername)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Order_TimeLabel1)
        Me.Controls.Add(Order_DateLabel1)
        Me.Controls.Add(Customer_PhoneLabel1)
        Me.Controls.Add(Customer_NameLabel1)
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtCustomername As TextBox
    Friend WithEvents txtCustomerphone As TextBox
    Friend WithEvents txtOrderdate As TextBox
    Friend WithEvents txtOrdertime As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSearch As Button
End Class
