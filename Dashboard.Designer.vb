<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnWarranty = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.pbInventory = New System.Windows.Forms.PictureBox()
        Me.pbSales = New System.Windows.Forms.PictureBox()
        Me.pbVerify = New System.Windows.Forms.PictureBox()
        Me.pbWarranty = New System.Windows.Forms.PictureBox()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWarranty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Lato Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(186, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome, Admin!"
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.IndianRed
        Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Roboto Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInventory.Location = New System.Drawing.Point(158, 112)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(197, 161)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Roboto Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSales.Location = New System.Drawing.Point(399, 112)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(197, 161)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "Sales Report"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnWarranty
        '
        Me.btnWarranty.BackColor = System.Drawing.Color.Khaki
        Me.btnWarranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWarranty.Font = New System.Drawing.Font("Roboto Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnWarranty.Location = New System.Drawing.Point(158, 310)
        Me.btnWarranty.Name = "btnWarranty"
        Me.btnWarranty.Size = New System.Drawing.Size(197, 161)
        Me.btnWarranty.TabIndex = 3
        Me.btnWarranty.Text = "Warranty"
        Me.btnWarranty.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWarranty.UseVisualStyleBackColor = False
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.PowderBlue
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Roboto Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVerify.Location = New System.Drawing.Point(399, 310)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(197, 161)
        Me.btnVerify.TabIndex = 4
        Me.btnVerify.Text = "Verify Order"
        Me.btnVerify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'picLogout
        '
        Me.picLogout.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogout.BackgroundImage = Global.Group5System.My.Resources.Resources.power_off
        Me.picLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogout.Location = New System.Drawing.Point(729, 502)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(46, 44)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogout.TabIndex = 5
        Me.picLogout.TabStop = False
        '
        'pbInventory
        '
        Me.pbInventory.BackColor = System.Drawing.Color.IndianRed
        Me.pbInventory.Image = Global.Group5System.My.Resources.Resources.inventory
        Me.pbInventory.Location = New System.Drawing.Point(197, 138)
        Me.pbInventory.Name = "pbInventory"
        Me.pbInventory.Size = New System.Drawing.Size(122, 96)
        Me.pbInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbInventory.TabIndex = 6
        Me.pbInventory.TabStop = False
        '
        'pbSales
        '
        Me.pbSales.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pbSales.Image = Global.Group5System.My.Resources.Resources.inventory
        Me.pbSales.Location = New System.Drawing.Point(440, 138)
        Me.pbSales.Name = "pbSales"
        Me.pbSales.Size = New System.Drawing.Size(122, 96)
        Me.pbSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSales.TabIndex = 7
        Me.pbSales.TabStop = False
        '
        'pbVerify
        '
        Me.pbVerify.BackColor = System.Drawing.Color.PowderBlue
        Me.pbVerify.Image = Global.Group5System.My.Resources.Resources.inventory
        Me.pbVerify.Location = New System.Drawing.Point(440, 335)
        Me.pbVerify.Name = "pbVerify"
        Me.pbVerify.Size = New System.Drawing.Size(122, 96)
        Me.pbVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbVerify.TabIndex = 8
        Me.pbVerify.TabStop = False
        '
        'pbWarranty
        '
        Me.pbWarranty.BackColor = System.Drawing.Color.Khaki
        Me.pbWarranty.Image = Global.Group5System.My.Resources.Resources.inventory
        Me.pbWarranty.Location = New System.Drawing.Point(197, 335)
        Me.pbWarranty.Name = "pbWarranty"
        Me.pbWarranty.Size = New System.Drawing.Size(122, 96)
        Me.pbWarranty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWarranty.TabIndex = 9
        Me.pbWarranty.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(787, 558)
        Me.Controls.Add(Me.pbWarranty)
        Me.Controls.Add(Me.pbVerify)
        Me.Controls.Add(Me.pbSales)
        Me.Controls.Add(Me.pbInventory)
        Me.Controls.Add(Me.picLogout)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnWarranty)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWarranty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnWarranty As Button
    Friend WithEvents btnVerify As Button
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents pbInventory As PictureBox
    Friend WithEvents pbSales As PictureBox
    Friend WithEvents pbVerify As PictureBox
    Friend WithEvents pbWarranty As PictureBox
End Class
