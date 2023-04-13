<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSales = New System.Windows.Forms.TextBox()
        Me.tbItems = New System.Windows.Forms.TextBox()
        Me.tbReplaced = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ProdName = New System.Windows.Forms.ColumnHeader()
        Me.Qty = New System.Windows.Forms.ColumnHeader()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.picWarranty = New System.Windows.Forms.PictureBox()
        Me.picVerify = New System.Windows.Forms.PictureBox()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.picInventory = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(266, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monthly Sales Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(95, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Month:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(95, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Number of Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(95, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Items Sold:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(95, 457)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No. Products Replaced:"
        '
        'tbSales
        '
        Me.tbSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbSales.Location = New System.Drawing.Point(266, 385)
        Me.tbSales.Name = "tbSales"
        Me.tbSales.Size = New System.Drawing.Size(323, 21)
        Me.tbSales.TabIndex = 6
        '
        'tbItems
        '
        Me.tbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbItems.Location = New System.Drawing.Point(266, 420)
        Me.tbItems.Name = "tbItems"
        Me.tbItems.Size = New System.Drawing.Size(323, 21)
        Me.tbItems.TabIndex = 7
        '
        'tbReplaced
        '
        Me.tbReplaced.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbReplaced.Location = New System.Drawing.Point(266, 452)
        Me.tbReplaced.Name = "tbReplaced"
        Me.tbReplaced.Size = New System.Drawing.Size(323, 21)
        Me.tbReplaced.TabIndex = 8
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProdName, Me.Qty})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView1.Location = New System.Drawing.Point(95, 94)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(724, 270)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ProdName
        '
        Me.ProdName.Text = "Product Name"
        Me.ProdName.Width = 500
        '
        'Qty
        '
        Me.Qty.Text = "Qty."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.picLogout)
        Me.Panel1.Controls.Add(Me.picWarranty)
        Me.Panel1.Controls.Add(Me.picVerify)
        Me.Panel1.Controls.Add(Me.picSales)
        Me.Panel1.Controls.Add(Me.picInventory)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 504)
        Me.Panel1.TabIndex = 11
        '
        'picLogout
        '
        Me.picLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLogout.Image = CType(resources.GetObject("picLogout.Image"), System.Drawing.Image)
        Me.picLogout.Location = New System.Drawing.Point(17, 449)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(46, 44)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogout.TabIndex = 4
        Me.picLogout.TabStop = False
        '
        'picWarranty
        '
        Me.picWarranty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picWarranty.Image = CType(resources.GetObject("picWarranty.Image"), System.Drawing.Image)
        Me.picWarranty.Location = New System.Drawing.Point(17, 162)
        Me.picWarranty.Name = "picWarranty"
        Me.picWarranty.Size = New System.Drawing.Size(46, 44)
        Me.picWarranty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWarranty.TabIndex = 3
        Me.picWarranty.TabStop = False
        '
        'picVerify
        '
        Me.picVerify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVerify.Image = CType(resources.GetObject("picVerify.Image"), System.Drawing.Image)
        Me.picVerify.Location = New System.Drawing.Point(17, 112)
        Me.picVerify.Name = "picVerify"
        Me.picVerify.Size = New System.Drawing.Size(46, 44)
        Me.picVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVerify.TabIndex = 2
        Me.picVerify.TabStop = False
        '
        'picSales
        '
        Me.picSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSales.Image = CType(resources.GetObject("picSales.Image"), System.Drawing.Image)
        Me.picSales.Location = New System.Drawing.Point(17, 62)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(46, 44)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSales.TabIndex = 1
        Me.picSales.TabStop = False
        '
        'picInventory
        '
        Me.picInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picInventory.Image = CType(resources.GetObject("picInventory.Image"), System.Drawing.Image)
        Me.picInventory.Location = New System.Drawing.Point(17, 12)
        Me.picInventory.Name = "picInventory"
        Me.picInventory.Size = New System.Drawing.Size(46, 44)
        Me.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInventory.TabIndex = 0
        Me.picInventory.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox1.Location = New System.Drawing.Point(146, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 12
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 502)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.tbReplaced)
        Me.Controls.Add(Me.tbItems)
        Me.Controls.Add(Me.tbSales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sales"
        Me.Text = "Sales"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbSales As TextBox
    Friend WithEvents tbItems As TextBox
    Friend WithEvents tbReplaced As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents Qty As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picInventory As PictureBox
    Friend WithEvents picVerify As PictureBox
    Friend WithEvents picSales As PictureBox
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents picWarranty As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
