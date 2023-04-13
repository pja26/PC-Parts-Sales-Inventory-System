Public Class Cart
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Call Add()
        Me.Hide()
        Checkout.Show()
    End Sub

    Public Sub Add()

        Dim dt As New DataTable
        dt = ExecuteQuery("INSERT INTO CartZero VALUES
            ('" & tbProdName.Text.Trim & "',
             '" & tbOrderNo.Text.Trim & "',
             '" & tbPrice.Text.Trim & "',
             '" & tbQuantity.Text.Trim & "',
             '" & tbTotal.Text.Trim & "',
             '" & tbGrandTotal.Text.Trim & "')")

    End Sub
    Public Sub Edit()
        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("UPDATE Cart SET OrderNo = '" & tbOrderNo.Text.Trim & "' , 
                                               Price = '" & tbPrice.Text.Trim & "' , 
                                               Quantity = '" & tbQuantity.Text.Trim & "', 
                                               Total = '" & tbTotal.Text.Trim & "' 
                                               WHERE ProdName = '" & tbProdName.Text & "'")

            lvCart.Items.Clear()
            Call Fill_Products()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Delete()
        Dim dt As New DataTable
        dt = ExecuteQuery("DELETE FROM Cart WHERE ProdName = '" & tbProdName.Text & "'")
    End Sub
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AutoNumOrder()
        Call Fill_Products()
        Call Grand()
        tbProdName.Enabled = False
        tbOrderNo.Enabled = False
        tbPrice.Enabled = False
        tbQuantity.Enabled = False
        tbTotal.Enabled = False
        tbGrandTotal.Enabled = False
    End Sub
    Public Sub AutoNumOrder()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM Sales")
        tbOrderNo.Text = dt.Rows.Count + 1
    End Sub
    Public Sub Clear()
        tbProdName.Clear()
        tbProdName.Refresh()
        tbOrderNo.Clear()
        tbPrice.Clear()
        tbTotal.Clear()
        tbGrandTotal.Clear()
    End Sub
    Public Sub Grand()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT Total FROM Cart WHERE OrderNo = '" & tbOrderNo.Text & "'")
        Try
            Dim sum As Integer = 0
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1

                    Dim item As New ListViewItem
                    item.SubItems.Add(dt.Rows(ctr)("Total"))
                    sum += dt.Rows(ctr)("Total")
                Next
            End If

            tbGrandTotal.Text = sum
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Fill_OrderNo()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM Cart WHERE OrderNo = '" & tbOrderNo.Text & "'")
        Try
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("OrderNo")
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Fill_Products()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM Cart WHERE OrderNo = '" & tbOrderNo.Text & "'")
        Try
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ProdName")
                    item.SubItems.Add(dt.Rows(ctr)("OrderNo"))
                    item.SubItems.Add(dt.Rows(ctr)("Price"))
                    item.SubItems.Add(dt.Rows(ctr)("Quantity"))
                    item.SubItems.Add(dt.Rows(ctr)("Total"))
                    lvCart.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ViewSelectedlvCart(ByVal ProdName As String)
        Dim dt As New DataTable
        Dim ctr As Integer
        dt = ExecuteQuery("SELECT ProdName, Price, Quantity, Total FROM Cart WHERE ProdName = '" & ProdName & "'")
        If dt.Rows.Count > 0 Then
            tbProdName.Text = (dt.Rows(ctr)("ProdName"))
            tbPrice.Text = (dt.Rows(ctr)("Price"))
            tbQuantity.Text = (dt.Rows(ctr)("Quantity"))
            tbTotal.Text = (dt.Rows(ctr)("Total"))
        End If
    End Sub

    Private Sub lvCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCart.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            For Each item As ListViewItem In lvCart.SelectedItems
                Dim first, last As Integer
                Dim str As String = item.SubItems(0).ToString
                first = str.IndexOf("{")
                last = str.LastIndexOf("}")
                str = item.SubItems(0).ToString.Substring(first + 1, last - first - 1)
                Call ViewSelectedlvCart(str)
                tbProdName.Text = str
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Restore()
        Try
            Dim dt As New DataTable
            Dim qty As Integer = tbQuantity.Text
            dt = ExecuteQuery("UPDATE ProductTable SET Stock = Stock + '" & qty & "' WHERE ProdName = '" & tbProdName.Text & "'")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        'Call Restore()
        'Call Delete()
        'lvCart.Items.Clear()
        'Call Fill_Products()
        'Call Clear()

        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to delete this item in your cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Call Restore()
            Call Delete()
            lvCart.Items.Clear()
            Call Fill_Products()
            Call Clear()
        End If
    End Sub
    Private Sub tbQuantity_TextChanged(sender As Object, e As EventArgs) Handles tbQuantity.TextChanged
        Call Addition()
    End Sub

    Public Sub Addition()
        tbTotal.Text = tbQuantity.Text * tbPrice.Text
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim sum As Integer = 1
        sum = tbQuantity.Text + 1
        tbQuantity.Text = sum

        Call Edit()
        Call Grand()
        tbGrandTotal.Refresh()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim diff As Integer = 1
        diff = tbQuantity.Text - 1
        tbQuantity.Text = diff

        If diff = 0 Then
            tbQuantity.Text = 1
            MessageBox.Show("Error! Number must be greater than 0")
        End If

        Call Edit()
        Call Grand()
        tbGrandTotal.Refresh()
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Close()
    End Sub

    Private Sub tbGrandTotal_TextChanged(sender As Object, e As EventArgs) Handles tbGrandTotal.TextChanged

    End Sub

    Private Sub tbOrderNo_TextChanged(sender As Object, e As EventArgs) Handles tbOrderNo.TextChanged
        Call Fill_OrderNo()
    End Sub
End Class