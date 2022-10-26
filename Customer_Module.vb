Imports System.Data.OleDb
Public Class Customer_Module
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("SELECT * FROM customer WHERE ID = idnum", OleDbCon)
        COMMAND.Parameters.Add("idnum", OleDbType.Integer).Value = TextBox1.Text
        Dim ADAPTER As New OleDbDataAdapter(COMMAND)
        Dim TABLE As New DataTable()

        Try
            ADAPTER.Fill(TABLE)

            If TABLE.Rows.Count > 0 Then
                TextBox2.Text = TABLE(0)(0)
                TextBox3.Text = TABLE(0)(1)
                TextBox4.Text = TABLE(0)(2)
            Else
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                MessageBox.Show("No Data Found")
            End If
        Catch ex As Exception
            MessageBox.Show("No Input")
        End Try



    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Empty ID")

        Else
            OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
            Dim COMMAND As New OleDbCommand("UPDATE customer SET CustomerName = name, Address = add, PhoneNumber = num WHERE ID = idnum", OleDbCon)
            COMMAND.Parameters.Add("name", OleDbType.VarChar).Value = TextBox2.Text
            COMMAND.Parameters.Add("add", OleDbType.VarChar).Value = TextBox3.Text
            COMMAND.Parameters.Add("num", OleDbType.VarChar).Value = TextBox4.Text
            COMMAND.Parameters.Add("idnum", OleDbType.Integer).Value = TextBox1.Text
            OleDbCon.Open()
            If COMMAND.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Customer Updated")
            Else
                MessageBox.Show("Customer Update Failed")
            End If

            OleDbCon.Close()

        End If


    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO customer (ID,CustomerName, Address, PhoneNumber) VALUES (idnum,name,add,num)", OleDbCon)
        COMMAND.Parameters.Add("idnum", OleDbType.Integer).Value = TextBox1.Text
        COMMAND.Parameters.Add("name", OleDbType.VarChar).Value = TextBox2.Text
        COMMAND.Parameters.Add("add", OleDbType.VarChar).Value = TextBox3.Text
        COMMAND.Parameters.Add("num", OleDbType.VarChar).Value = TextBox4.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Customer Added")
            Else
                MessageBox.Show("Customer Not Added")
            End If
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        End Try

        OleDbCon.Close()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Purchase_System.Show()
        Me.Close()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("DELETE FROM customer WHERE ID = idnum", OleDbCon)
        COMMAND.Parameters.Add("idnum", OleDbType.Integer).Value = TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Customer Deleted")
            Else
                MessageBox.Show("Customer Deletion Failed")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        OleDbCon.Close()
    End Sub
End Class
