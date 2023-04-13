Public Class VerifyOrderCashier
    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Hide()
    End Sub

End Class