Imports System.Data.OleDb
Public Class Item_Module
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Purchase_System.Show()
        Me.Close()
    End Sub

    Private Sub Order_Click(sender As Object, e As EventArgs) Handles Order.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Order ID cannot be empty")
        Else
            New_Item_Module.Show()
            Me.Hide()
        End If
    End Sub
End Class