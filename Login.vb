Imports System.Data.OleDb
Public Class Login
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim READER As OleDbDataReader

        Try
            OleDbCon.Open()
            Dim Query As String
            Query = "SELECT * FROM admin where Username = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "' "
            COMMAND = New OleDbCommand(Query, OleDbCon)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count += 1

            End While

            If count = 1 Then
                MessageBox.Show("Login Successful")
                Purchase_System.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicated")
            Else
                MessageBox.Show("Username and Password are incorrect")
            End If

            OleDbCon.Close()

        Catch ex As OleDbException
            MessageBox.Show(ex.Message)

        Finally
            OleDbCon.Dispose()
            TextBox2.Clear()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
