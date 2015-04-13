Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmProduct

    Dim TB As New DataTable
    Dim ConnectionString As String = "workstation id=AwesomeDatabase.mssql.somee.com;packet size=4096;user id=theluanvuong1;pwd=Linkinpark123@;data source=AwesomeDatabase.mssql.somee.com;persist security info=False;initial catalog=AwesomeDatabase"

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connect As New SqlConnection(ConnectionString)
        Dim sqlAdapter As New SqlDataAdapter("SELECT * FROM San_pham", Connect)
        Try
            Connect.Open()
            sqlAdapter.Fill(TB)
        Catch ex As Exception
        End Try
        dgrGrid.DataSource = TB
        Connect.Close()

        Dim index As Integer = dgrGrid.CurrentCell.RowIndex
        txtProduct.Text = dgrGrid.Item(0, index).Value
        txtName.Text = dgrGrid.Item(1, index).Value
        txtPrice.Text = dgrGrid.Item(2, index).Value
        txtQuantity.Text = dgrGrid.Item(3, index).Value
        txtDescript.Text = dgrGrid.Item(4, index).Value
        txtType.Text = dgrGrid.Item(5, index).Value
    End Sub

    Private Sub frmProduct_Load()

        Dim Connect As New SqlConnection(ConnectionString)
        Dim sqlAdapter As New SqlDataAdapter("SELECT * FROM San_pham", Connect)
        Try
            Connect.Open()
            sqlAdapter.Fill(TB)
        Catch ex As Exception
        End Try
        dgrGrid.DataSource = TB
        Connect.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO San_pham ( Ma_SP, Ten_SP, Don_gia, So_luong, Dac_tinh, Ma_loai)"
        query &= "Values(@Ma_SP, @Ten_SP, @Don_gia, @So_luong, @Dac_tinh, @Ma_loai)"
        Using Connt As New SqlConnection("workstation id=AwesomeDatabase.mssql.somee.com;packet size=4096;user id=theluanvuong1;pwd=Linkinpark123@;data source=AwesomeDatabase.mssql.somee.com;persist security info=False;initial catalog=AwesomeDatabase")
            Using Cont As New SqlCommand()
                With Cont
                    .Connection = Connt
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Ma_SP", txtProduct.Text)
                    .Parameters.AddWithValue("@Ten_SP", txtName.Text)
                    .Parameters.AddWithValue("@Don_gia", txtPrice.Text)
                    .Parameters.AddWithValue("@So_luong", txtQuantity.Text)
                    .Parameters.AddWithValue("@Dac_tinh", txtDescript.Text)
                    .Parameters.AddWithValue("@Ma_loai", txtType.Text)
                End With
                Try
                    Connt.Open()
                    Cont.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error! Cannot Add!")
                End Try
                TB.Clear()
                dgrGrid.DataSource = TB
                dgrGrid.DataSource = Nothing
                frmProduct_Load()
            End Using
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim Connect As New SqlConnection(ConnectionString)
        Connect.Open()
        Dim Stradd As String = "UPDATE San_pham SET Ma_SP = @Ma_SP, Ten_SP = @Ten_SP, Don_gia = @Don_gia, So_luong = @So_luong, Dac_tinh = @Dac_tinh, Ma_loai = @Ma_loai WHERE Ma_SP = @Ma_SP "
        Dim Com As New SqlCommand(Stradd, Connect)
        Try
            Com.Parameters.AddWithValue("@Ma_SP", txtProduct.Text)
            Com.Parameters.AddWithValue("@Ten_SP", txtName.Text)
            Com.Parameters.AddWithValue("@Don_gia", txtPrice.Text)
            Com.Parameters.AddWithValue("@So_luong", txtQuantity.Text)
            Com.Parameters.AddWithValue("@Dac_tinh", txtDescript.Text)
            Com.Parameters.AddWithValue("@Ma_loai", txtType.Text)
            Com.ExecuteNonQuery()
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Error! Cannot Edit!")
        End Try
        TB.Clear()
        dgrGrid.DataSource = TB
        dgrGrid.DataSource = Nothing
        frmProduct_Load()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Connect As New SqlConnection(ConnectionString)
        Connect.Open()
        Dim stradd As String = "DELETE FROM  San_pham WHERE Ma_SP = @Ma_SP"
        Dim com As New SqlCommand(stradd, Connect)
        Try
            com.Parameters.AddWithValue("@MaSP", txtProduct.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error! Cannot Delete!")
        End Try
        TB.Clear()
        dgrGrid.DataSource = TB
        dgrGrid.DataSource = Nothing
        frmProduct_Load()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class

