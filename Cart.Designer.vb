<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        Me.lvCart = New System.Windows.Forms.ListView()
        Me.ProdName = New System.Windows.Forms.ColumnHeader()
        Me.OrderNo = New System.Windows.Forms.ColumnHeader()
        Me.Price = New System.Windows.Forms.ColumnHeader()
        Me.Quantity = New System.Windows.Forms.ColumnHeader()
        Me.Total = New System.Windows.Forms.ColumnHeader()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.tbOrderNo = New System.Windows.Forms.TextBox()
        Me.tbProdName = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvCart
        '
        Me.lvCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProdName, Me.OrderNo, Me.Price, Me.Quantity, Me.Total})
        Me.lvCart.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvCart.Location = New System.Drawing.Point(12, 52)
        Me.lvCart.Name = "lvCart"
        Me.lvCart.Size = New System.Drawing.Size(647, 365)
        Me.lvCart.TabIndex = 0
        Me.lvCart.UseCompatibleStateImageBehavior = False
        Me.lvCart.View = System.Windows.Forms.View.Details
        '
        'ProdName
        '
        Me.ProdName.Text = "Product Name"
        Me.ProdName.Width = 300
        '
        'OrderNo
        '
        Me.OrderNo.Text = "Order #"
        Me.OrderNo.Width = 70
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 100
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 70
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.Width = 100
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCheckout.Font = New System.Drawing.Font("Lato", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCheckout.Location = New System.Drawing.Point(-2, 637)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(692, 62)
        Me.btnCheckout.TabIndex = 6
        Me.btnCheckout.Text = "Proceed Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Firebrick
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDel.Location = New System.Drawing.Point(382, 486)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(211, 37)
        Me.btnDel.TabIndex = 19
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'tbQuantity
        '
        Me.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQuantity.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbQuantity.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbQuantity.Location = New System.Drawing.Point(134, 530)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(92, 26)
        Me.tbQuantity.TabIndex = 20
        '
        'tbOrderNo
        '
        Me.tbOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOrderNo.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbOrderNo.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbOrderNo.Location = New System.Drawing.Point(134, 470)
        Me.tbOrderNo.Name = "tbOrderNo"
        Me.tbOrderNo.Size = New System.Drawing.Size(222, 26)
        Me.tbOrderNo.TabIndex = 21
        '
        'tbProdName
        '
        Me.tbProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProdName.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbProdName.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbProdName.Location = New System.Drawing.Point(134, 440)
        Me.tbProdName.Name = "tbProdName"
        Me.tbProdName.Size = New System.Drawing.Size(222, 26)
        Me.tbProdName.TabIndex = 22
        '
        'tbPrice
        '
        Me.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPrice.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbPrice.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbPrice.Location = New System.Drawing.Point(134, 500)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(222, 26)
        Me.tbPrice.TabIndex = 23
        '
        'tbTotal
        '
        Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotal.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbTotal.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbTotal.Location = New System.Drawing.Point(134, 559)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(222, 26)
        Me.tbTotal.TabIndex = 24
        '
        'tbGrandTotal
        '
        Me.tbGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbGrandTotal.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbGrandTotal.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbGrandTotal.Location = New System.Drawing.Point(134, 589)
        Me.tbGrandTotal.Name = "tbGrandTotal"
        Me.tbGrandTotal.Size = New System.Drawing.Size(222, 26)
        Me.tbGrandTotal.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(22, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(67, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Order #"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(86, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(58, 536)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(86, 565)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 18)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(40, 597)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 18)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Grand Total"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Roboto Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(232, 530)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 26)
        Me.btnAdd.TabIndex = 68
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.White
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Font = New System.Drawing.Font("Roboto Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMinus.ForeColor = System.Drawing.Color.Black
        Me.btnMinus.Location = New System.Drawing.Point(297, 530)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(59, 26)
        Me.btnMinus.TabIndex = 69
        Me.btnMinus.Text = "−"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'pbBack
        '
        Me.pbBack.Image = Global.Group5System.My.Resources.Resources.previous
        Me.pbBack.Location = New System.Drawing.Point(12, 12)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(36, 22)
        Me.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBack.TabIndex = 70
        Me.pbBack.TabStop = False
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 694)
        Me.Controls.Add(Me.pbBack)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbGrandTotal)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbProdName)
        Me.Controls.Add(Me.tbOrderNo)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lvCart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Cart"
        Me.Text = "Cart"
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvCart As ListView
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents tbQuantity As TextBox
    Friend WithEvents OrderNo As ColumnHeader
    Friend WithEvents tbOrderNo As TextBox
    Friend WithEvents tbProdName As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbGrandTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents pbBack As PictureBox
End Class
