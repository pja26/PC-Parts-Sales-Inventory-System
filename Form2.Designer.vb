<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpdID = New System.Windows.Forms.TextBox()
        Me.tbpdName = New System.Windows.Forms.TextBox()
        Me.tbStocks = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProdID = New System.Windows.Forms.ColumnHeader()
        Me.ProdName = New System.Windows.Forms.ColumnHeader()
        Me.Category = New System.Windows.Forms.ColumnHeader()
        Me.Stocks = New System.Windows.Forms.ColumnHeader()
        Me.Price = New System.Windows.Forms.ColumnHeader()
        Me.lvPL = New System.Windows.Forms.ListView()
        Me.WarrantyPeriod = New System.Windows.Forms.ColumnHeader()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.picVerify = New System.Windows.Forms.PictureBox()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.picWarranty = New System.Windows.Forms.PictureBox()
        Me.picInventory = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbWarrantyPeriod = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarranty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(114, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search:"
        '
        'cmbSearch
        '
        Me.cmbSearch.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Product ID", "Product Name", "Category"})
        Me.cmbSearch.Location = New System.Drawing.Point(186, 57)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 26)
        Me.cmbSearch.TabIndex = 1
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbSearch.Location = New System.Drawing.Point(313, 57)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(250, 26)
        Me.tbSearch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(158, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(132, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(187, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stocks:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(199, 479)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Price:"
        '
        'tbpdID
        '
        Me.tbpdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbpdID.Location = New System.Drawing.Point(257, 340)
        Me.tbpdID.Name = "tbpdID"
        Me.tbpdID.Size = New System.Drawing.Size(572, 21)
        Me.tbpdID.TabIndex = 8
        '
        'tbpdName
        '
        Me.tbpdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbpdName.Location = New System.Drawing.Point(257, 367)
        Me.tbpdName.Name = "tbpdName"
        Me.tbpdName.Size = New System.Drawing.Size(572, 21)
        Me.tbpdName.TabIndex = 9
        '
        'tbStocks
        '
        Me.tbStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbStocks.Location = New System.Drawing.Point(257, 448)
        Me.tbStocks.Name = "tbStocks"
        Me.tbStocks.Size = New System.Drawing.Size(572, 21)
        Me.tbStocks.TabIndex = 10
        '
        'tbPrice
        '
        Me.tbPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbPrice.Location = New System.Drawing.Point(257, 476)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(572, 21)
        Me.tbPrice.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(835, 340)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 48)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEdit.Location = New System.Drawing.Point(835, 394)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(113, 48)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Firebrick
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(835, 448)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(113, 49)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'tbCategory
        '
        Me.tbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbCategory.Location = New System.Drawing.Point(257, 394)
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(572, 21)
        Me.tbCategory.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(172, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Category:"
        '
        'ProdID
        '
        Me.ProdID.Text = "ProductID"
        Me.ProdID.Width = 80
        '
        'ProdName
        '
        Me.ProdName.Text = "ProductName"
        Me.ProdName.Width = 200
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.Width = 100
        '
        'Stocks
        '
        Me.Stocks.DisplayIndex = 3
        Me.Stocks.Text = "Stocks"
        '
        'Price
        '
        Me.Price.DisplayIndex = 4
        Me.Price.Text = "Price"
        Me.Price.Width = 100
        '
        'lvPL
        '
        Me.lvPL.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProdID, Me.ProdName, Me.Category, Me.WarrantyPeriod, Me.Stocks, Me.Price})
        Me.lvPL.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvPL.Location = New System.Drawing.Point(114, 89)
        Me.lvPL.Name = "lvPL"
        Me.lvPL.Size = New System.Drawing.Size(834, 229)
        Me.lvPL.TabIndex = 3
        Me.lvPL.UseCompatibleStateImageBehavior = False
        Me.lvPL.View = System.Windows.Forms.View.Details
        '
        'WarrantyPeriod
        '
        Me.WarrantyPeriod.DisplayIndex = 5
        Me.WarrantyPeriod.Text = "WarrantyPeriod"
        Me.WarrantyPeriod.Width = 270
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(368, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 37)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Product Inventory"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.picSales)
        Me.Panel1.Controls.Add(Me.picVerify)
        Me.Panel1.Controls.Add(Me.picLogout)
        Me.Panel1.Controls.Add(Me.picWarranty)
        Me.Panel1.Controls.Add(Me.picInventory)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(81, 510)
        Me.Panel1.TabIndex = 19
        '
        'picSales
        '
        Me.picSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSales.Image = Global.Group5System.My.Resources.Resources.sales
        Me.picSales.Location = New System.Drawing.Point(16, 69)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(60, 50)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSales.TabIndex = 4
        Me.picSales.TabStop = False
        '
        'picVerify
        '
        Me.picVerify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVerify.Image = Global.Group5System.My.Resources.Resources.check
        Me.picVerify.Location = New System.Drawing.Point(16, 125)
        Me.picVerify.Name = "picVerify"
        Me.picVerify.Size = New System.Drawing.Size(60, 50)
        Me.picVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVerify.TabIndex = 3
        Me.picVerify.TabStop = False
        '
        'picLogout
        '
        Me.picLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLogout.Image = Global.Group5System.My.Resources.Resources.log_out1
        Me.picLogout.Location = New System.Drawing.Point(16, 452)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(60, 50)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogout.TabIndex = 2
        Me.picLogout.TabStop = False
        '
        'picWarranty
        '
        Me.picWarranty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picWarranty.Image = Global.Group5System.My.Resources.Resources.replacement
        Me.picWarranty.Location = New System.Drawing.Point(16, 181)
        Me.picWarranty.Name = "picWarranty"
        Me.picWarranty.Size = New System.Drawing.Size(60, 50)
        Me.picWarranty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWarranty.TabIndex = 1
        Me.picWarranty.TabStop = False
        '
        'picInventory
        '
        Me.picInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picInventory.Image = Global.Group5System.My.Resources.Resources.inventory1
        Me.picInventory.Location = New System.Drawing.Point(16, 13)
        Me.picInventory.Name = "picInventory"
        Me.picInventory.Size = New System.Drawing.Size(60, 50)
        Me.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInventory.TabIndex = 0
        Me.picInventory.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(118, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Warranty Period:"
        '
        'tbWarrantyPeriod
        '
        Me.tbWarrantyPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbWarrantyPeriod.Location = New System.Drawing.Point(257, 421)
        Me.tbWarrantyPeriod.Name = "tbWarrantyPeriod"
        Me.tbWarrantyPeriod.Size = New System.Drawing.Size(572, 21)
        Me.tbWarrantyPeriod.TabIndex = 21
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 509)
        Me.Controls.Add(Me.tbWarrantyPeriod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbStocks)
        Me.Controls.Add(Me.tbpdName)
        Me.Controls.Add(Me.tbpdID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvPL)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarranty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbpdID As TextBox
    Friend WithEvents tbpdName As TextBox
    Friend WithEvents tbStocks As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents tbCategory As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProdID As ColumnHeader
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents Stocks As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents lvPL As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picSales As PictureBox
    Friend WithEvents picVerify As PictureBox
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents picWarranty As PictureBox
    Friend WithEvents picInventory As PictureBox
    Friend WithEvents WarrantyPeriod As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents tbWarrantyPeriod As TextBox
End Class
