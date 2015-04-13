Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmType
    Dim YO As New DataTable
    Dim ConnectionString As String = "workstation id=AwesomeDatabase.mssql.somee.com;packet size=4096;user id=theluanvuong1;pwd=Linkinpark123@;data source=AwesomeDatabase.mssql.somee.com;persist security info=False;initial catalog=AwesomeDatabase"

    Private Sub frmType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connect As New SqlConnection(ConnectionString)
        Dim sqlAdapter As New SqlDataAdapter("SELECT * FROM Loai_SP", Connect)
        Try
            Connect.Open()
            sqlAdapter.Fill(YO)
        Catch ex As Exception
        End Try
        dgrView2.DataSource = YO
        Connect.Close()

        Dim andex As Integer = dgrView2.CurrentCell.RowIndex
        txtTypecode.Text = dgrView2.Item(0, andex).Value
        txtTypeName.Text = dgrView2.Item(1, andex).Value
    End Sub

    Private Sub frmType_Load()
        Dim Connect As New SqlConnection(ConnectionString)
        Dim sqlAdapter As New SqlDataAdapter("SELECT * FROM Loai_SP", Connect)
        Try
            Connect.Open()
            sqlAdapter.Fill(YO)
        Catch ex As Exception
        End Try
        dgrView2.DataSource = YO
        Connect.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim Query As String = String.Empty
        Query &= "INSERT INTO Loai_SP (Ma_loai, Ten_loai)"
        Query &= "VALUES (@Ma_loai,@Ten_loai)"
        Using Connt As New SqlConnection("workstation id=AwesomeDatabase.mssql.somee.com;packet size=4096;user id=theluanvuong1;pwd=Linkinpark123@;data source=AwesomeDatabase.mssql.somee.com;persist security info=False;initial catalog=AwesomeDatabase")
            Using Cont As New SqlCommand()
                With Cont
                    .Connection = Connt
                    .CommandType = CommandType.Text
                    .CommandText = Query
                    .Parameters.AddWithValue("@Ma_loai", txtTypecode.Text)
                    .Parameters.AddWithValue("@Ten_loai", txtTypeName.Text)
                End With
                Try
                    Connt.Open()
                    Cont.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error! Can not connect!")
                End Try
                TB.Clear()
                dgrView2.DataSource = TB
                dgrView2.DataSource = Nothing
                frmType_Load()
            End Using
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim Connect As New SqlConnection(ConnectionString)
        Connect.Open()
        Dim Stradd As String = "UPDATE Loai_SP SET Ma_Loai = @Ma_loai, Ten_loai = @Ten_loai WHERE Ma_loai = @Ma_loai"
        Dim Com As New SqlCommand(Stradd, Connect)
        Try
            Com.Parameters.AddWithValue("@Ma_loai", txtTypecode.Text)
            Com.Parameters.AddWithValue("@Ten_loai", txtTypeName.Text)
            Com.ExecuteNonQuery()
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Error! Can not Edit!")
        End Try
        TB.Clear()
        dgrView2.DataSource = TB
        dgrView2.DataSource = Nothing
        frmType_Load()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim Connect As New SqlConnection(ConnectionString)
        Connect.Open()
        Dim Stradd As String = "DELETE FROM Loai_SP WHERE Ma_loai = @Ma_loai"
        Dim Com As New SqlCommand(Stradd, Connect)
        Try
            Com.Parameters.AddWithValue("@Ma_loai", txtTypecode.Text)
            Com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error! Can not delete!")
        End Try
        TB.Clear()
        dgrView2.DataSource = TB
        dgrView2.DataSource = Nothing
        frmType_Load()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
   
End Class