<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtCashierID = New System.Windows.Forms.TextBox()
        Me.btnLogs = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(145, 10)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(22, 23)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "..."
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnCustomer.Location = New System.Drawing.Point(448, 41)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(179, 68)
        Me.btnCustomer.TabIndex = 2
        Me.btnCustomer.Text = "&Customers"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnOrder.Location = New System.Drawing.Point(448, 115)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(179, 68)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "&Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnLogout.Location = New System.Drawing.Point(448, 293)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(179, 68)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(681, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'txtCashierID
        '
        Me.txtCashierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashierID.Location = New System.Drawing.Point(12, 9)
        Me.txtCashierID.Name = "txtCashierID"
        Me.txtCashierID.ReadOnly = True
        Me.txtCashierID.Size = New System.Drawing.Size(32, 24)
        Me.txtCashierID.TabIndex = 38
        Me.txtCashierID.TabStop = False
        Me.txtCashierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogs
        '
        Me.btnLogs.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnLogs.Location = New System.Drawing.Point(448, 189)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(179, 68)
        Me.btnLogs.TabIndex = 39
        Me.btnLogs.Text = "&Logs"
        Me.btnLogs.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 377)
        Me.Controls.Add(Me.btnLogs)
        Me.Controls.Add(Me.txtCashierID)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCashierID As TextBox
    Friend WithEvents btnLogs As Button
End Class
