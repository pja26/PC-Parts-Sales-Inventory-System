<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Warranty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Warranty))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.picVerify = New System.Windows.Forms.PictureBox()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.picWarranty = New System.Windows.Forms.PictureBox()
        Me.picInventory = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.DateOfPurchase = New System.Windows.Forms.ColumnHeader()
        Me.ProdName = New System.Windows.Forms.ColumnHeader()
        Me.WarrantyPeriod = New System.Windows.Forms.ColumnHeader()
        Me.tbOrderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnWarranty = New System.Windows.Forms.Button()
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(256, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Warranty "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.picSales)
        Me.Panel1.Controls.Add(Me.picVerify)
        Me.Panel1.Controls.Add(Me.picLogout)
        Me.Panel1.Controls.Add(Me.picWarranty)
        Me.Panel1.Controls.Add(Me.picInventory)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 454)
        Me.Panel1.TabIndex = 1
        '
        'picSales
        '
        Me.picSales.Image = CType(resources.GetObject("picSales.Image"), System.Drawing.Image)
        Me.picSales.Location = New System.Drawing.Point(12, 69)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(47, 50)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSales.TabIndex = 5
        Me.picSales.TabStop = False
        '
        'picVerify
        '
        Me.picVerify.Image = CType(resources.GetObject("picVerify.Image"), System.Drawing.Image)
        Me.picVerify.Location = New System.Drawing.Point(12, 125)
        Me.picVerify.Name = "picVerify"
        Me.picVerify.Size = New System.Drawing.Size(47, 50)
        Me.picVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVerify.TabIndex = 4
        Me.picVerify.TabStop = False
        '
        'picLogout
        '
        Me.picLogout.Image = CType(resources.GetObject("picLogout.Image"), System.Drawing.Image)
        Me.picLogout.Location = New System.Drawing.Point(12, 388)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(47, 50)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogout.TabIndex = 3
        Me.picLogout.TabStop = False
        '
        'picWarranty
        '
        Me.picWarranty.Image = CType(resources.GetObject("picWarranty.Image"), System.Drawing.Image)
        Me.picWarranty.Location = New System.Drawing.Point(12, 181)
        Me.picWarranty.Name = "picWarranty"
        Me.picWarranty.Size = New System.Drawing.Size(47, 50)
        Me.picWarranty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWarranty.TabIndex = 1
        Me.picWarranty.TabStop = False
        '
        'picInventory
        '
        Me.picInventory.Image = Global.Group5System.My.Resources.Resources.inventory
        Me.picInventory.Location = New System.Drawing.Point(11, 13)
        Me.picInventory.Name = "picInventory"
        Me.picInventory.Size = New System.Drawing.Size(47, 50)
        Me.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInventory.TabIndex = 0
        Me.picInventory.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DateOfPurchase, Me.ProdName, Me.WarrantyPeriod})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView1.Location = New System.Drawing.Point(113, 95)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(656, 186)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'DateOfPurchase
        '
        Me.DateOfPurchase.Text = "Date"
        Me.DateOfPurchase.Width = 150
        '
        'ProdName
        '
        Me.ProdName.Text = "Product Name"
        Me.ProdName.Width = 350
        '
        'WarrantyPeriod
        '
        Me.WarrantyPeriod.Text = "Warranty Period"
        Me.WarrantyPeriod.Width = 150
        '
        'tbOrderID
        '
        Me.tbOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOrderID.Location = New System.Drawing.Point(217, 66)
        Me.tbOrderID.Name = "tbOrderID"
        Me.tbOrderID.Size = New System.Drawing.Size(329, 23)
        Me.tbOrderID.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(113, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Order ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(113, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Returned Product:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(250, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(379, 23)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(250, 332)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(379, 23)
        Me.TextBox2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(113, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Replaced Product:"
        '
        'btnWarranty
        '
        Me.btnWarranty.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnWarranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnWarranty.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnWarranty.Location = New System.Drawing.Point(674, 397)
        Me.btnWarranty.Name = "btnWarranty"
        Me.btnWarranty.Size = New System.Drawing.Size(95, 41)
        Me.btnWarranty.TabIndex = 12
        Me.btnWarranty.Text = "Confirm"
        Me.btnWarranty.UseVisualStyleBackColor = False
        '
        'Warranty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 450)
        Me.Controls.Add(Me.btnWarranty)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.tbOrderID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Warranty"
        Me.Text = "Warranty"
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picSales As PictureBox
    Friend WithEvents picVerify As PictureBox
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents picWarranty As PictureBox
    Friend WithEvents picInventory As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents tbOrderID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateOfPurchase As ColumnHeader
    Friend WithEvents WarrantyPeriod As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnWarranty As Button
End Class
