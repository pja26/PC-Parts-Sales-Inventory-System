Public Class Warranty
    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picInventory_Click(sender As Object, e As EventArgs) Handles picInventory.Click
        Dim InventoryRefresh As New Form2
        InventoryRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picVerify_Click(sender As Object, e As EventArgs) Handles picVerify.Click
        Dim VerifyRefresh As New Verify_Order
        VerifyRefresh.Show()
        Me.Hide()
    End Sub
    Private Sub picSales_Click(sender As Object, e As EventArgs) Handles picSales.Click
        Dim salesRefresh As New Sales
        salesRefresh.Show()
        Me.Hide()
    End Sub
End Class