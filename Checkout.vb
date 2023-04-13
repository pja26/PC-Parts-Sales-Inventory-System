Public Class Checkout
    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AutoNumOrder()
        Call Grand()
    End Sub
    Public Sub Grand()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT GrandTotal FROM CartZero WHERE OrderNo = '" & lblOrderNo.Text & "'")
        Try
            Dim sum As Integer = 0
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1

                    Dim item As New ListViewItem
                    item.SubItems.Add(dt.Rows(ctr)("GrandTotal"))
                    sum += dt.Rows(ctr)("GrandTotal")
                Next
            End If

            lblTotal.Text = sum
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Add()
        Dim dt As New DataTable
        Dim mode As String = Nothing
        If rbCard.Checked Then
            mode = "Card"
        ElseIf rbCash.Checked Then
            mode = "Cash"
        ElseIf rbGcash.Checked Then
            mode = "GCash"
        ElseIf rbPayM.Checked Then
            mode = "PayMaya"
        End If


        If tbTRXid.Text = Nothing Then
            MessageBox.Show("Please fill out all the fields.")

        Else

        dt = ExecuteQuery("INSERT INTO Sales VALUES
            ('" & lblOrderNo.Text.Trim & "',
             '" & lblTotal.Text.Trim & "',
             '" & mode & "',
             '" & tbTRXid.Text.Trim & "')")
        End If
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If tbTRXid.Text = Nothing Then
            MessageBox.Show("Enter Transaction ID to verify order.")
        Else
            Call Add()
            Dim orderRefresh As New Order
            orderRefresh.Show()
            Me.Close()
        End If

    End Sub
    Public Sub AutoNumOrder()
        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM Sales")
        lblOrderNo.Text = dt.Rows.Count + 1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim orderRefresh As New Order
        orderRefresh.Show()
        Me.Close()
    End Sub
End Class