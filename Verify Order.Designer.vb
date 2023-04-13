<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verify_Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verify_Order))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbOrderID = New System.Windows.Forms.TextBox()
        Me.lvVerifyOrder = New System.Windows.Forms.ListView()
        Me.OrderNo = New System.Windows.Forms.ColumnHeader()
        Me.ProdName = New System.Windows.Forms.ColumnHeader()
        Me.Quantity = New System.Windows.Forms.ColumnHeader()
        Me.Total = New System.Windows.Forms.ColumnHeader()
        Me.MOP = New System.Windows.Forms.ColumnHeader()
        Me.TRXid = New System.Windows.Forms.ColumnHeader()
        Me.AmtReceived = New System.Windows.Forms.ColumnHeader()
        Me.Change = New System.Windows.Forms.ColumnHeader()
        Me.VerifyOrder = New System.Windows.Forms.ColumnHeader()
        Me.Remarks = New System.Windows.Forms.ColumnHeader()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.picWarranty = New System.Windows.Forms.PictureBox()
        Me.picVerify = New System.Windows.Forms.PictureBox()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.picInventory = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAmtReceived = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbOrderNo = New System.Windows.Forms.TextBox()
        Me.tbProdName = New System.Windows.Forms.TextBox()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbMOP = New System.Windows.Forms.TextBox()
        Me.tbTRXid = New System.Windows.Forms.TextBox()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.tbVerifyOrder = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbChange = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarranty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(495, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Verification of Orders"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(115, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Order ID:"
        '
        'tbOrderID
        '
        Me.tbOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOrderID.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbOrderID.Location = New System.Drawing.Point(233, 31)
        Me.tbOrderID.Name = "tbOrderID"
        Me.tbOrderID.Size = New System.Drawing.Size(208, 26)
        Me.tbOrderID.TabIndex = 3
        '
        'lvVerifyOrder
        '
        Me.lvVerifyOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OrderNo, Me.ProdName, Me.Quantity, Me.Total, Me.MOP, Me.TRXid, Me.AmtReceived, Me.Change, Me.VerifyOrder, Me.Remarks})
        Me.lvVerifyOrder.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvVerifyOrder.Location = New System.Drawing.Point(97, 61)
        Me.lvVerifyOrder.Name = "lvVerifyOrder"
        Me.lvVerifyOrder.Size = New System.Drawing.Size(1160, 297)
        Me.lvVerifyOrder.TabIndex = 4
        Me.lvVerifyOrder.UseCompatibleStateImageBehavior = False
        Me.lvVerifyOrder.View = System.Windows.Forms.View.Details
        '
        'OrderNo
        '
        Me.OrderNo.Text = "Order #"
        Me.OrderNo.Width = 70
        '
        'ProdName
        '
        Me.ProdName.Text = "Product Name"
        Me.ProdName.Width = 200
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 70
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.Width = 70
        '
        'MOP
        '
        Me.MOP.Text = "Mode of Payment"
        Me.MOP.Width = 130
        '
        'TRXid
        '
        Me.TRXid.Text = "Transaction ID"
        Me.TRXid.Width = 120
        '
        'AmtReceived
        '
        Me.AmtReceived.Text = "Amount Received"
        Me.AmtReceived.Width = 130
        '
        'Change
        '
        Me.Change.Text = "Change"
        Me.Change.Width = 70
        '
        'VerifyOrder
        '
        Me.VerifyOrder.Text = "Verify"
        Me.VerifyOrder.Width = 100
        '
        'Remarks
        '
        Me.Remarks.Text = "Remarks"
        Me.Remarks.Width = 180
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.picLogout)
        Me.Panel1.Controls.Add(Me.picWarranty)
        Me.Panel1.Controls.Add(Me.picVerify)
        Me.Panel1.Controls.Add(Me.picSales)
        Me.Panel1.Controls.Add(Me.picInventory)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(70, 551)
        Me.Panel1.TabIndex = 1
        '
        'picLogout
        '
        Me.picLogout.Image = CType(resources.GetObject("picLogout.Image"), System.Drawing.Image)
        Me.picLogout.Location = New System.Drawing.Point(13, 476)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(46, 44)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogout.TabIndex = 8
        Me.picLogout.TabStop = False
        '
        'picWarranty
        '
        Me.picWarranty.Image = Global.Group5System.My.Resources.Resources.replacement
        Me.picWarranty.Location = New System.Drawing.Point(13, 162)
        Me.picWarranty.Name = "picWarranty"
        Me.picWarranty.Size = New System.Drawing.Size(46, 44)
        Me.picWarranty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWarranty.TabIndex = 7
        Me.picWarranty.TabStop = False
        '
        'picVerify
        '
        Me.picVerify.Image = CType(resources.GetObject("picVerify.Image"), System.Drawing.Image)
        Me.picVerify.Location = New System.Drawing.Point(13, 112)
        Me.picVerify.Name = "picVerify"
        Me.picVerify.Size = New System.Drawing.Size(46, 44)
        Me.picVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVerify.TabIndex = 6
        Me.picVerify.TabStop = False
        '
        'picSales
        '
        Me.picSales.Image = CType(resources.GetObject("picSales.Image"), System.Drawing.Image)
        Me.picSales.Location = New System.Drawing.Point(13, 62)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(46, 44)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSales.TabIndex = 5
        Me.picSales.TabStop = False
        '
        'picInventory
        '
        Me.picInventory.Image = CType(resources.GetObject("picInventory.Image"), System.Drawing.Image)
        Me.picInventory.Location = New System.Drawing.Point(13, 12)
        Me.picInventory.Name = "picInventory"
        Me.picInventory.Size = New System.Drawing.Size(46, 44)
        Me.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInventory.TabIndex = 4
        Me.picInventory.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(97, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Amount Received"
        '
        'tbAmtReceived
        '
        Me.tbAmtReceived.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbAmtReceived.Location = New System.Drawing.Point(233, 396)
        Me.tbAmtReceived.Name = "tbAmtReceived"
        Me.tbAmtReceived.Size = New System.Drawing.Size(208, 26)
        Me.tbAmtReceived.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(340, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 26)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Reject Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbOrderNo
        '
        Me.tbOrderNo.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbOrderNo.Location = New System.Drawing.Point(234, 364)
        Me.tbOrderNo.Name = "tbOrderNo"
        Me.tbOrderNo.Size = New System.Drawing.Size(207, 26)
        Me.tbOrderNo.TabIndex = 21
        '
        'tbProdName
        '
        Me.tbProdName.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbProdName.Location = New System.Drawing.Point(505, 409)
        Me.tbProdName.Name = "tbProdName"
        Me.tbProdName.Size = New System.Drawing.Size(21, 26)
        Me.tbProdName.TabIndex = 22
        '
        'tbQuantity
        '
        Me.tbQuantity.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbQuantity.Location = New System.Drawing.Point(505, 441)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(21, 26)
        Me.tbQuantity.TabIndex = 23
        '
        'tbTotal
        '
        Me.tbTotal.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbTotal.Location = New System.Drawing.Point(532, 409)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(21, 26)
        Me.tbTotal.TabIndex = 24
        '
        'tbMOP
        '
        Me.tbMOP.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbMOP.Location = New System.Drawing.Point(532, 441)
        Me.tbMOP.Name = "tbMOP"
        Me.tbMOP.Size = New System.Drawing.Size(21, 26)
        Me.tbMOP.TabIndex = 25
        '
        'tbTRXid
        '
        Me.tbTRXid.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbTRXid.Location = New System.Drawing.Point(559, 409)
        Me.tbTRXid.Name = "tbTRXid"
        Me.tbTRXid.Size = New System.Drawing.Size(21, 26)
        Me.tbTRXid.TabIndex = 26
        '
        'tbRemarks
        '
        Me.tbRemarks.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbRemarks.Location = New System.Drawing.Point(233, 493)
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(208, 26)
        Me.tbRemarks.TabIndex = 28
        '
        'tbVerifyOrder
        '
        Me.tbVerifyOrder.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbVerifyOrder.Location = New System.Drawing.Point(559, 441)
        Me.tbVerifyOrder.Name = "tbVerifyOrder"
        Me.tbVerifyOrder.Size = New System.Drawing.Size(21, 26)
        Me.tbVerifyOrder.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(233, 461)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 26)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Accept Order"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lato Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(158, 501)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lato Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(178, 469)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Verify"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(167, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Change"
        '
        'tbChange
        '
        Me.tbChange.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbChange.Location = New System.Drawing.Point(233, 429)
        Me.tbChange.Name = "tbChange"
        Me.tbChange.Size = New System.Drawing.Size(208, 26)
        Me.tbChange.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lato Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(167, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Order #"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(495, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 76)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Print Receipt"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Verify_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 547)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbChange)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.tbVerifyOrder)
        Me.Controls.Add(Me.tbTRXid)
        Me.Controls.Add(Me.tbMOP)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.tbProdName)
        Me.Controls.Add(Me.tbOrderNo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbAmtReceived)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvVerifyOrder)
        Me.Controls.Add(Me.tbOrderID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Verify_Order"
        Me.Text = "Verify_Order"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarranty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbOrderID As TextBox
    Friend WithEvents lvVerifyOrder As ListView
    Friend WithEvents OrderNo As ColumnHeader
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents picWarranty As PictureBox
    Friend WithEvents picVerify As PictureBox
    Friend WithEvents picSales As PictureBox
    Friend WithEvents picInventory As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAmtReceived As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents MOP As ColumnHeader
    Friend WithEvents TRXid As ColumnHeader
    Friend WithEvents VerifyOrder As ColumnHeader
    Friend WithEvents Remarks As ColumnHeader
    Friend WithEvents tbOrderNo As TextBox
    Friend WithEvents tbProdName As TextBox
    Friend WithEvents tbQuantity As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbMOP As TextBox
    Friend WithEvents tbTRXid As TextBox
    Friend WithEvents tbRemarks As TextBox
    Friend WithEvents tbVerifyOrder As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AmtReceived As ColumnHeader
    Friend WithEvents Change As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents tbChange As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
