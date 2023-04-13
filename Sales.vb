Public Class Sales
    Private Sub picInventory_Click(sender As Object, e As EventArgs) Handles picInventory.Click
        Dim inventoryRefresh As New Form2
        inventoryRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picVerify_Click(sender As Object, e As EventArgs) Handles picVerify.Click
        Dim VerifyRefresh As New Verify_Order
        VerifyRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picWarranty_Click(sender As Object, e As EventArgs) Handles picWarranty.Click
        Dim WarrantyRefresh As New Warranty
        WarrantyRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picSales_Click(sender As Object, e As EventArgs) Handles picSales.Click

    End Sub
End Class