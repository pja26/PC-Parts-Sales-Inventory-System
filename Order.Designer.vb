<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbProdName = New System.Windows.Forms.TextBox()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.lvProdOrder = New System.Windows.Forms.ListView()
        Me.ProdName = New System.Windows.Forms.ColumnHeader()
        Me.Category = New System.Windows.Forms.ColumnHeader()
        Me.WarrantyPeriod = New System.Windows.Forms.ColumnHeader()
        Me.Price = New System.Windows.Forms.ColumnHeader()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.pbCart = New System.Windows.Forms.PictureBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbWarrantyPeriod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbOrderNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(54, 546)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(83, 610)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(57, 674)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(19, 578)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Product Name"
        '
        'tbProdName
        '
        Me.tbProdName.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbProdName.Location = New System.Drawing.Point(133, 570)
        Me.tbProdName.Name = "tbProdName"
        Me.tbProdName.Size = New System.Drawing.Size(533, 26)
        Me.tbProdName.TabIndex = 62
        '
        'tbCategory
        '
        Me.tbCategory.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbCategory.Location = New System.Drawing.Point(133, 538)
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(533, 26)
        Me.tbCategory.TabIndex = 64
        '
        'lvProdOrder
        '
        Me.lvProdOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProdName, Me.Category, Me.WarrantyPeriod, Me.Price})
        Me.lvProdOrder.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvProdOrder.Location = New System.Drawing.Point(12, 58)
        Me.lvProdOrder.Name = "lvProdOrder"
        Me.lvProdOrder.Size = New System.Drawing.Size(654, 442)
        Me.lvProdOrder.TabIndex = 65
        Me.lvProdOrder.UseCompatibleStateImageBehavior = False
        Me.lvProdOrder.View = System.Windows.Forms.View.Details
        '
        'ProdName
        '
        Me.ProdName.Text = "Product Name"
        Me.ProdName.Width = 200
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.Width = 100
        '
        'WarrantyPeriod
        '
        Me.WarrantyPeriod.Text = "Warranty Period"
        Me.WarrantyPeriod.Width = 280
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(12, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Search"
        '
        'cmbSearch
        '
        Me.cmbSearch.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Category", "Product Name"})
        Me.cmbSearch.Location = New System.Drawing.Point(79, 26)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(158, 26)
        Me.cmbSearch.TabIndex = 69
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbSearch.Location = New System.Drawing.Point(243, 26)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(236, 26)
        Me.tbSearch.TabIndex = 70
        '
        'pbLogin
        '
        Me.pbLogin.Image = Global.Group5System.My.Resources.Resources._1081856_2001
        Me.pbLogin.Location = New System.Drawing.Point(608, 6)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(58, 50)
        Me.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogin.TabIndex = 71
        Me.pbLogin.TabStop = False
        '
        'tbPrice
        '
        Me.tbPrice.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbPrice.Location = New System.Drawing.Point(133, 602)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(533, 26)
        Me.tbPrice.TabIndex = 73
        Me.tbPrice.Text = "0"
        '
        'tbQuantity
        '
        Me.tbQuantity.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbQuantity.Location = New System.Drawing.Point(133, 666)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(70, 26)
        Me.tbQuantity.TabIndex = 74
        '
        'pbCart
        '
        Me.pbCart.Image = Global.Group5System.My.Resources.Resources.buy
        Me.pbCart.Location = New System.Drawing.Point(550, 12)
        Me.pbCart.Name = "pbCart"
        Me.pbCart.Size = New System.Drawing.Size(52, 34)
        Me.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCart.TabIndex = 78
        Me.pbCart.TabStop = False
        '
        'tbTotal
        '
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbTotal.Location = New System.Drawing.Point(608, 671)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(27, 21)
        Me.tbTotal.TabIndex = 83
        '
        'tbWarrantyPeriod
        '
        Me.tbWarrantyPeriod.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbWarrantyPeriod.Location = New System.Drawing.Point(133, 634)
        Me.tbWarrantyPeriod.Name = "tbWarrantyPeriod"
        Me.tbWarrantyPeriod.Size = New System.Drawing.Size(533, 26)
        Me.tbWarrantyPeriod.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 642)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Warranty Period"
        '
        'tbOrderNo
        '
        Me.tbOrderNo.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbOrderNo.Location = New System.Drawing.Point(133, 506)
        Me.tbOrderNo.Name = "tbOrderNo"
        Me.tbOrderNo.Size = New System.Drawing.Size(533, 26)
        Me.tbOrderNo.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(19, 514)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Order Number"
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.White
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Font = New System.Drawing.Font("Roboto Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMinus.ForeColor = System.Drawing.Color.Black
        Me.btnMinus.Location = New System.Drawing.Point(171, 698)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(32, 26)
        Me.btnMinus.TabIndex = 94
        Me.btnMinus.Text = "−"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Roboto Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(133, 698)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 26)
        Me.btnAdd.TabIndex = 93
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.Navy
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Location = New System.Drawing.Point(596, 666)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(70, 58)
        Me.btnAddToCart.TabIndex = 95
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 734)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbOrderNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbWarrantyPeriod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.pbCart)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.pbLogin)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lvProdOrder)
        Me.Controls.Add(Me.tbCategory)
        Me.Controls.Add(Me.tbProdName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Order"
        Me.Text = "Order"
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbProdName As TextBox
    Friend WithEvents tbCategory As TextBox
    Friend WithEvents lvProdOrder As ListView
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents pbLogin As PictureBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbQuantity As TextBox
    Friend WithEvents pbCart As PictureBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents WarrantyPeriod As ColumnHeader
    Friend WithEvents tbWarrantyPeriod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbOrderNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddToCart As Button
End Class
