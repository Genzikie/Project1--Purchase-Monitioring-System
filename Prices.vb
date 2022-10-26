Imports System.Data.OleDb
Public Class Prices
    Dim OleDbCon As New OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Prices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filter_Data("")
    End Sub

    Public Sub Filter_Data(ValueToSearch As String)
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim QUERY As String = "SELECT * FROM [prices] WHERE [Furniture] & [Design] & [Material] & [Size] & [Price] like '%" & ValueToSearch & "%'"
        Dim COMMAND As New OleDbCommand(QUERY, OleDbCon)
        Dim ADAPTER As New OleDbDataAdapter(COMMAND)
        Dim TABLE As New DataTable()
        Try
            ADAPTER.Fill(TABLE)
            DataGridView1.DataSource = TABLE
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Purchase_System.Show()
        Me.Close()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Filter_Data(TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Filter_Data(TextBox1.Text)
    End Sub
End Class