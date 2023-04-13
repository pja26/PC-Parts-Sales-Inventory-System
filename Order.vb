Public Class Order
    Private Sub pbLogin_Click(sender As Object, e As EventArgs) Handles pbLogin.Click
        Form1.Show()
        Dim loginRefresh As New Form1
        loginRefresh.Show()
        Me.Hide()

    End Sub

    Private Sub pbCart_Click(sender As Object, e As EventArgs) Handles pbCart.Click
        Dim cartRefresh As New Cart
        cartRefresh.Show()
        Me.Hide()

    End Sub
    Public Sub Fill_Products()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM ProductTable")
        Try
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem

                    item.Text = dt.Rows(ctr)("ProdName")
                    item.SubItems.Add(dt.Rows(ctr)("Category"))
                    item.SubItems.Add(dt.Rows(ctr)("WarrantyPeriod"))
                    item.SubItems.Add(dt.Rows(ctr)("Price"))
                    lvProdOrder.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub AutoNumOrder()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM Sales")
        tbOrderNo.Text = dt.Rows.Count + 1
    End Sub
    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Fill_Products()
        Call AutoNumOrder()
        

        Dim QuantityStr As String
        QuantityStr = tbQuantity.Text
        tbQuantity.Text = 1

        tbCategory.Enabled = False
        tbProdName.Enabled = False
        tbWarrantyPeriod.Enabled = False
        tbPrice.Enabled = False
        tbQuantity.Enabled = False
        tbOrderNo.Enabled = False
        tbTotal.Enabled = False
    End Sub
    Public Sub Sum()
        tbTotal.Text = tbQuantity.Text * tbPrice.Text
    End Sub

    Private Sub lvProdOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProdOrder.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            For Each item As ListViewItem In lvProdOrder.SelectedItems
                Dim first, last As Integer
                Dim str As String = item.SubItems(0).ToString
                first = str.IndexOf("{")
                last = str.LastIndexOf("}")
                str = item.SubItems(0).ToString.Substring(first + 1, last - first - 1)
                Call ViewSelectedlvProdOrder(str)
                tbProdName.Text = str
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub ViewSelectedlvProdOrder(ByVal ProdName As String)
        Dim dt As New DataTable
        Dim ctr As Integer

        dt = ExecuteQuery("SELECT * FROM ProductTable WHERE ProdName = '" & ProdName & "'")
        If dt.Rows.Count > 0 Then
            tbProdName.Text = (dt.Rows(ctr)("ProdName"))
            tbCategory.Text = (dt.Rows(ctr)("Category"))
            tbWarrantyPeriod.Text = (dt.Rows(ctr)("WarrantyPeriod"))
            tbPrice.Text = (dt.Rows(ctr)("Price"))

        End If
        Call Sum()

    End Sub
    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim search As String = Nothing

        If cmbSearch.Text = "Product Name" Then
            search = "ProdName"
        ElseIf cmbSearch.Text = "Category" Then
            search = "Category"
        End If

        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("SELECT * FROM ProductTable WHERE " & search & " LIKE '" & tbSearch.Text & "%'")
            lvProdOrder.Items.Clear()
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ProdName")
                    item.SubItems.Add(dt.Rows(ctr)("Category"))
                    item.SubItems.Add(dt.Rows(ctr)("WarrantyPeriod"))
                    item.SubItems.Add(dt.Rows(ctr)("Price"))
                    lvProdOrder.Items.Add(item)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Add()
        Dim tempt As Integer = 0
        Dim dt As New DataTable
        If tbQuantity.Text = Nothing Then
            MessageBox.Show("Please fill out all the fields.")

        Else
            Dim temp As Integer = 0
            dt = ExecuteQuery("INSERT INTO Cart VALUES
            ('" & tbProdName.Text.Trim & "',
             '" & tbOrderNo.Text.Trim & "',
             '" & tbPrice.Text.Trim & "',
             '" & tbQuantity.Text.Trim & "',
             '" & tbTotal.Text & "')")

        End If

    End Sub
    Public Sub Clear()
        tbProdName.Clear()
        tbProdName.Refresh()
        tbCategory.Clear()
        tbCategory.Refresh()
        tbWarrantyPeriod.Clear()
        tbPrice.Clear()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sum As Integer = tbQuantity.Text
        sum = tbQuantity.Text + 1
        tbQuantity.Text = sum
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim diff As Integer = tbQuantity.Text
        diff = tbQuantity.Text - 1
        tbQuantity.Text = diff

        If diff = 0 Then
            MessageBox.Show("Error! Number must be greater than 0")
            tbQuantity.Text = 1
        End If
    End Sub
    Public Sub Deduct()
        Try
            Dim dt As New DataTable
            Dim qty As Integer = tbQuantity.Text
            dt = ExecuteQuery("UPDATE ProductTable SET Stock = Stock - '" & qty & "' WHERE ProdName = '" & tbProdName.Text & "'")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Call Deduct()
        Call Add()
        MessageBox.Show("Product added to cart.")

    End Sub

    Private Sub tbQuantity_TextChanged(sender As Object, e As EventArgs) Handles tbQuantity.TextChanged
        Call Sum()
    End Sub

    Private Sub tbGrandTotal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbProdName_TextChanged(sender As Object, e As EventArgs) Handles tbProdName.TextChanged
        Call Sum()
    End Sub
End Class