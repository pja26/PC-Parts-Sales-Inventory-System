<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbCard = New System.Windows.Forms.RadioButton()
        Me.rbPayM = New System.Windows.Forms.RadioButton()
        Me.rbGcash = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTRXid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Roboto Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(185, 76)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 33)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(58, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Total Price"
        '
        'rbCard
        '
        Me.rbCard.AutoSize = True
        Me.rbCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbCard.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbCard.Location = New System.Drawing.Point(295, 171)
        Me.rbCard.Name = "rbCard"
        Me.rbCard.Size = New System.Drawing.Size(136, 23)
        Me.rbCard.TabIndex = 20
        Me.rbCard.TabStop = True
        Me.rbCard.Text = "Mobile Banking"
        Me.rbCard.UseVisualStyleBackColor = True
        '
        'rbPayM
        '
        Me.rbPayM.AutoSize = True
        Me.rbPayM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbPayM.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbPayM.Location = New System.Drawing.Point(123, 171)
        Me.rbPayM.Name = "rbPayM"
        Me.rbPayM.Size = New System.Drawing.Size(93, 23)
        Me.rbPayM.TabIndex = 19
        Me.rbPayM.TabStop = True
        Me.rbPayM.Text = "PayMaya"
        Me.rbPayM.UseVisualStyleBackColor = True
        '
        'rbGcash
        '
        Me.rbGcash.AutoSize = True
        Me.rbGcash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbGcash.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbGcash.Location = New System.Drawing.Point(222, 171)
        Me.rbGcash.Name = "rbGcash"
        Me.rbGcash.Size = New System.Drawing.Size(71, 23)
        Me.rbGcash.TabIndex = 18
        Me.rbGcash.TabStop = True
        Me.rbGcash.Text = "Gcash"
        Me.rbGcash.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbCash.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbCash.Location = New System.Drawing.Point(58, 171)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(62, 23)
        Me.rbCash.TabIndex = 17
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(58, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Mode of Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(197, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Input ""Cash"" for Cash Payment"
        '
        'tbTRXid
        '
        Me.tbTRXid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTRXid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbTRXid.Location = New System.Drawing.Point(110, 240)
        Me.tbTRXid.Name = "tbTRXid"
        Me.tbTRXid.Size = New System.Drawing.Size(233, 29)
        Me.tbTRXid.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato Light", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(131, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 33)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Order #"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(58, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 23)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Transaction ID"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPlaceOrder.ForeColor = System.Drawing.Color.White
        Me.btnPlaceOrder.Location = New System.Drawing.Point(166, 275)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(115, 30)
        Me.btnPlaceOrder.TabIndex = 37
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Lato Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOrderNo.Location = New System.Drawing.Point(225, 5)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(31, 33)
        Me.lblOrderNo.TabIndex = 38
        Me.lblOrderNo.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Group5System.My.Resources.Resources.previous
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(149, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 33)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "₱"
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 318)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblOrderNo)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTRXid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbCard)
        Me.Controls.Add(Me.rbPayM)
        Me.Controls.Add(Me.rbGcash)
        Me.Controls.Add(Me.rbCash)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Checkout"
        Me.Text = "Checkout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbCard As RadioButton
    Friend WithEvents rbPayM As RadioButton
    Friend WithEvents rbGcash As RadioButton
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTRXid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
