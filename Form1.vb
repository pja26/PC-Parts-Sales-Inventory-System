Public Class Form1

    Private Sub loginBtn_Click_1(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try
            login(txtUsername.Text.Trim, txtPassword.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub login(ByVal Username As String, ByVal Password As String)

        Try
            If Username = "" Then
                MessageBox.Show("Please enter username")
                Exit Sub

            ElseIf Password = "" Then
                MessageBox.Show("Please enter password")
                Exit Sub

            End If

            If Username = "admin" And Password = "test" Then
                'Dim dashboardRefresh As New Dashboard
                'dashboardRefresh.Show()
                Dashboard.Show()
                'Me.Close()

            ElseIf Username = "cashier" And Password = "test" Then
                'Dim verifyRefresh As New VerifyOrderCashier
                'verifyRefresh.Show()
                VerifyOrderCashier.Show()
                'Me.Close()
            Else
                MessageBox.Show("Incorrect Login")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
