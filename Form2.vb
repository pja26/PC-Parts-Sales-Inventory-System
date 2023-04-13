Public Class Form2
    Public Sub Fill_Products()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM ProductTable")
        Try
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ProdID")
                    item.SubItems.Add(dt.Rows(ctr)("ProdName"))
                    item.SubItems.Add(dt.Rows(ctr)("Category"))
                    item.SubItems.Add(dt.Rows(ctr)("WarrantyPeriod"))
                    item.SubItems.Add(dt.Rows(ctr)("Stock"))
                    item.SubItems.Add((dt.Rows(ctr)("Price")))
                    lvPL.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub ViewSelectedlvProducts(ByVal ProdID As String)
        Dim dt As New DataTable
        Dim ctr As Integer
        dt = ExecuteQuery("SELECT * FROM ProductTable WHERE ProdID = '" & ProdID & "'")

        If dt.Rows.Count > 0 Then
            tbpdID.Text = (dt.Rows(ctr)("ProdID"))
            tbpdName.Text = (dt.Rows(ctr)("ProdName"))
            tbCategory.Text = (dt.Rows(ctr)("Category"))
            tbWarrantyPeriod.Text = (dt.Rows(ctr)("WarrantyPeriod"))
            tbStocks.Text = (dt.Rows(ctr)("Stock"))
            tbPrice.Text = (dt.Rows(ctr)("Price"))
        End If
    End Sub
    Public Sub Add()
        Dim dt As New DataTable
        If tbpdID.Text = Nothing Or tbpdName.Text = Nothing Or tbStocks.Text = Nothing Then
            MessageBox.Show("Please fill out all the fields.")
        Else
            dt = ExecuteQuery("INSERT INTO ProductTable VALUES
            ('" & tbpdID.Text.Trim & "','" &
            tbpdName.Text.Trim & "','" &
            tbCategory.Text.Trim & "','" &
            tbWarrantyPeriod.Text.Trim & "','" &
            tbStocks.Text.Trim & "','" &
            tbPrice.Text.Trim & "')")
            lvPL.Items.Clear()
            Call Fill_Products()
        End If
    End Sub
    Public Sub Edit()
        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("UPDATE ProductTable SET ProdName = '" & tbpdName.Text.Trim & "' , 
                                                       Category = '" & tbCategory.Text.Trim & "' , 
                                                       WarrantyPeriod = '" & tbWarrantyPeriod.Text.Trim & "', 
                                                       Stock = '" & tbStocks.Text.Trim & "' , 
                                                       Price = '" & tbPrice.Text.Trim & "' 
                                                       WHERE ProdID = '" & tbpdID.Text & "'")

            lvPL.Items.Clear()
            Call Fill_Products()
            MessageBox.Show("Product Updated")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Delete()
        Dim dt As New DataTable
        dt = ExecuteQuery("DELETE FROM ProductTable WHERE ProdID = '" & tbpdID.Text & "'")
    End Sub
    Public Sub Clear()
        tbpdID.Clear()
        tbpdID.Refresh()
        tbpdName.Clear()
        tbCategory.Clear()
        tbWarrantyPeriod.Clear()
        tbStocks.Clear()
        tbPrice.Clear()
    End Sub
    Public Sub Code()
        If tbpdName.Text.Count > 3 Then
            Dim dt As New DataTable
            dt = ExecuteQuery("SELECT * FROM ProductTable")
            tbpdID.Text = dt.Rows.Count + 1
        End If
    End Sub
    Private Sub lvPL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPL.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            For Each item As ListViewItem In lvPL.SelectedItems
                Dim first, last As Integer
                Dim str As String = item.SubItems(0).ToString
                first = str.IndexOf("{")
                last = str.LastIndexOf("}")
                str = item.SubItems(0).ToString.Substring(first + 1, last - first - 1)
                Call ViewSelectedlvProducts(str)
                tbpdID.Text = str
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub tbpdName_TextChanged(sender As Object, e As EventArgs) Handles tbpdName.TextChanged
        Call Code()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbStocks.Text > 1 Then
            Call Add()
            Call Clear()
        ElseIf tbStocks.Text <= 0 Then
            MessageBox.Show("Please input stocks greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question)
            'MessageBox.Show("", MessageBoxIcon.Information)
        ElseIf tbPrice.Text > 1 Then
            Call Add()
            Call Clear()
        ElseIf tbStocks.Text <= 0 Then
            MessageBox.Show("Please input price greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question)
            'MessageBox.Show("", MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If tbStocks.Text > 1 Then
            Call Edit()
            Call Clear()
        ElseIf tbStocks.Text <= 0 Then
            MessageBox.Show("Please input stocks greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question)
            'MessageBox.Show("", MessageBoxIcon.Information)
        ElseIf tbPrice.Text > 1 Then
            Call Edit()
            Call Clear()
        ElseIf tbStocks.Text <= 0 Then
            MessageBox.Show("Please input price greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question)
            'MessageBox.Show("", MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to delete this item in Inventory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Call Delete()
            lvPL.Items.Clear()
            Call Fill_Products()
            Call Clear()
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Fill_Products()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim search As String = Nothing

        If cmbSearch.Text = "Product ID" Then
            search = "ProdID"
        ElseIf cmbSearch.Text = "Product Name" Then
            search = "ProdName"
        ElseIf cmbSearch.Text = "Category" Then
            search = "Category"
        End If

        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("SELECT * FROM ProductTable WHERE " & search & " LIKE '" & tbSearch.Text & "%'")
            lvPL.Items.Clear()
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ProdID")
                    item.SubItems.Add(dt.Rows(ctr)("ProdName"))
                    item.SubItems.Add(dt.Rows(ctr)("Category"))
                    item.SubItems.Add(dt.Rows(ctr)("WarrantyPeriod"))
                    item.SubItems.Add(dt.Rows(ctr)("Stock"))
                    item.SubItems.Add(dt.Rows(ctr)("Price"))
                    lvPL.Items.Add(item)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub picVerify_Click(sender As Object, e As EventArgs) Handles picVerify.Click
        Dim VerifyRefresh As New Verify_Order
        VerifyRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub tbpdID_TextChanged(sender As Object, e As EventArgs) Handles tbpdID.TextChanged

    End Sub
    Private Sub picSales_Click(sender As Object, e As EventArgs) Handles picSales.Click
        Dim salesRefresh As New Sales
        salesRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picWarranty_Click(sender As Object, e As EventArgs) Handles picWarranty.Click
        Dim WarrantyRefresh As New Warranty
        WarrantyRefresh.Show()
        Me.Hide()
    End Sub

    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Hide()
    End Sub
End Class