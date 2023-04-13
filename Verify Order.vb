Public Class Verify_Order
    Private Sub picWarranty_Click(sender As Object, e As EventArgs) Handles picWarranty.Click
        Me.Hide()
        Warranty.Show()
    End Sub

    Private Sub Verify_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Fill_Products()
    End Sub
    Public Sub Fill_Products()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM VerifyOrder WHERE OrderNo = '" & tbOrderID.Text & "'")
        Try
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("OrderNo")
                    item.SubItems.Add(dt.Rows(ctr)("Total"))
                    item.SubItems.Add(dt.Rows(ctr)("MOP"))
                    item.SubItems.Add(dt.Rows(ctr)("TRXid"))
                    item.SubItems.Add(dt.Rows(ctr)("AmtReceived"))
                    item.SubItems.Add(dt.Rows(ctr)("Change"))
                    item.SubItems.Add(dt.Rows(ctr)("Verify"))
                    item.SubItems.Add(dt.Rows(ctr)("Remarks"))
                    lvVerifyOrder.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub ViewSelectedlvVerifyOrder(ByVal OrderNo As String)
        Dim dt As New DataTable
        Dim ctr As Integer
        dt = ExecuteQuery("SELECT * FROM VerifyOrder WHERE OrderNo = '" & OrderNo & "'")

        If dt.Rows.Count > 0 Then
            tbOrderNo.Text = (dt.Rows(ctr)("OrderNo"))
            tbProdName.Text = (dt.Rows(ctr)("ProdName"))
            tbQuantity.Text = (dt.Rows(ctr)("Quantity"))
            tbTotal.Text = (dt.Rows(ctr)("Total"))
            tbMOP.Text = (dt.Rows(ctr)("MOP"))
            tbTRXid.Text = (dt.Rows(ctr)("TRXid"))
            tbAmtReceived.Text = (dt.Rows(ctr)("AmtReceived"))
            tbChange.Text = (dt.Rows(ctr)("Change"))
            tbVerifyOrder.Text = (dt.Rows(ctr)("VerifyOrder"))
            tbRemarks.Text = (dt.Rows(ctr)("Remarks"))
        End If
    End Sub
    Private Sub lvVerifyOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvVerifyOrder.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            For Each item As ListViewItem In lvVerifyOrder.SelectedItems
                Dim first, last As Integer
                Dim str As String = item.SubItems(0).ToString
                first = str.IndexOf("{")
                last = str.LastIndexOf("}")
                str = item.SubItems(0).ToString.Substring(first + 1, last - first - 1)
                Call ViewSelectedlvVerifyOrder(str)
                tbOrderNo.Text = str
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub tbOrderID_TextChanged(sender As Object, e As EventArgs) Handles tbOrderID.TextChanged
        lvVerifyOrder.Items.Clear()
        Call Fill_Products()
    End Sub

    Private Sub picSales_Click(sender As Object, e As EventArgs) Handles picSales.Click
        Dim salesRefresh As New Sales
        salesRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picInventory_Click(sender As Object, e As EventArgs) Handles picInventory.Click
        Dim inventoryRefresh As New Form2
        inventoryRefresh.Show()
        Me.Hide()
    End Sub
End Class