Imports System.Data.OleDb
Public Class Delivery
    Dim OleDbCon As New OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim ADAPTER As New OleDbDataAdapter("SELECT * FROM [orders]", OleDbCon)
        Dim TABLE As New DataTable()

        ADAPTER.Fill(TABLE)

        DataGridView1.DataSource = TABLE
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Delivery_Cancel.Show()
        Me.Close()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Purchase_System.Show()
        Me.Close()
    End Sub
End Class