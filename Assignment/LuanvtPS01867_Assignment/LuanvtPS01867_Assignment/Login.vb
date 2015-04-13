Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim ConnectionString As String = "workstation id=AwesomeDatabase.mssql.somee.com;packet size=4096;user id=theluanvuong1;pwd=Linkinpark123@;data source=AwesomeDatabase.mssql.somee.com;persist security info=False;initial catalog=AwesomeDatabase"
        Dim Connect As SqlConnection = New SqlConnection(ConnectionString)
        Dim sqlAdapter As New SqlDataAdapter("SELECT * FROM Login Where User = '" & txtUser.Text & "'  and Password = '" & txtPassword.Text & "' ", Connect)
        Dim TB As New DataTable
        Try
            Connect.Open()
            sqlAdapter.Fill(TB)
            If TB.Rows.Count > 0 Then
                MessageBox.Show("Hey bro, welcome to my awesome App", "Notification", MessageBoxButtons.OK, MessageBoxIcon.None)
                frmMain.Show()
                Me.Hide()
                txtUser.Clear()
                txtPassword.Clear()
            ElseIf txtUser.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("You need to fill in those blanks, man!!!", "Eh yo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hey bro, welcome to my awesome App", "Notification", MessageBoxButtons.OK, MessageBoxIcon.None)
                frmMain.Show()
                Me.Hide()
                txtUser.Clear()
                txtPassword.Clear()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

End Class
