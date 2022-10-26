Imports System.Data.OleDb
Public Class New_Item_Module2
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Table1_Click(sender As Object, e As EventArgs) Handles Table1.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Table"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Modern Dining"
        COMMAND.Parameters.Add("siz", OleDbType.VarChar).Value = "N/A"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Material.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Table2_Click(sender As Object, e As EventArgs) Handles Table2.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Table"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Single-Stand"
        COMMAND.Parameters.Add("siz", OleDbType.VarChar).Value = "N/A"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Material.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Table3_Click(sender As Object, e As EventArgs) Handles Table3.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Table"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Modern Coffee"
        COMMAND.Parameters.Add("siz", OleDbType.VarChar).Value = "N/A"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Material.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Table4_Click(sender As Object, e As EventArgs) Handles Table4.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Table"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Traditional Coffee"
        COMMAND.Parameters.Add("siz", OleDbType.VarChar).Value = "N/A"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Material.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Table5_Click(sender As Object, e As EventArgs) Handles Table5.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Table"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Innovative"
        COMMAND.Parameters.Add("siz", OleDbType.VarChar).Value = "N/A"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Material.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        New_Item_Module.Show()
        Me.Close()
    End Sub
End Class