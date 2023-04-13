Public Class Dashboard
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim InventoryRefresh As New Form2
        InventoryRefresh.Show()
        Me.Close()
    End Sub

    Private Sub pbInventory_Click(sender As Object, e As EventArgs) Handles pbInventory.Click
        Dim InventoryRefresh As New Form2
        InventoryRefresh.Show()
        Me.Close()
    End Sub

    Private Sub pbSales_Click(sender As Object, e As EventArgs) Handles pbSales.Click
        Dim SalesRefresh As New Sales
        SalesRefresh.Show()
        Me.Close()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim SalesRefresh As New Sales
        SalesRefresh.Show()
        Me.Close()
    End Sub

    Private Sub pbWarranty_Click(sender As Object, e As EventArgs) Handles pbWarranty.Click
        Dim WarrantyRefresh As New Warranty
        WarrantyRefresh.Show()
        Me.Close()
    End Sub

    Private Sub btnWarranty_Click(sender As Object, e As EventArgs) Handles btnWarranty.Click
        Dim WarrantyRefresh As New Warranty
        WarrantyRefresh.Show()
        Me.Close()
    End Sub

    Private Sub pbVerify_Click(sender As Object, e As EventArgs) Handles pbVerify.Click
        Dim VerifyRefresh As New Verify_Order
        VerifyRefresh.Show()
        Me.Close()
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim VerifyRefresh As New Verify_Order
        VerifyRefresh.Show()
        Me.Close()
    End Sub

    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Close()
    End Sub
End Class