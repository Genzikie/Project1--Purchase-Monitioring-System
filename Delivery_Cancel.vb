Imports System.Data.OleDb
Public Class Delivery_Cancel
    Dim OleDbCon As New OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("DELETE FROM [orders] WHERE [ID] = idnum", OleDbCon)
        COMMAND.Parameters.Add("idnum", OleDbType.Integer).Value = TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Delivery Cancelled")
            Else
                MessageBox.Show("Delivery Cancel Failed")
            End If
        Catch ex As Exception
            MessageBox.Show("Error. Please try again correctly")
        End Try

        OleDbCon.Close()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Delivery.Show()
        Me.Close()
    End Sub
End Class