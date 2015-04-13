Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'Button exit đóng ứng dụng
        Application.Exit()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click 'Mở form quản lí sản phẩm
        frmProduct.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductType_Click(sender As Object, e As EventArgs) Handles btnProductType.Click 'Mở form quản lí chủng loại sản phẩm
        frmType.Show()
        Me.Hide()
    End Sub
End Class