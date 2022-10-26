Imports System.Data.OleDb
Public Class Varnish_Color
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Material] = '' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
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

    Private Sub Walnut_Click(sender As Object, e As EventArgs) Handles Walnut.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Color] = 'Walnut' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Quantity_Customer_ID.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Red_Mahogany_Click(sender As Object, e As EventArgs) Handles Red_Mahogany.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Color] = 'Red Mahogany' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Quantity_Customer_ID.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Light_Oak_Click(sender As Object, e As EventArgs) Handles Light_Oak.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Color] = 'Light Oak' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Quantity_Customer_ID.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Pine_Click(sender As Object, e As EventArgs) Handles Pine.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Color] = 'Pine' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Quantity_Customer_ID.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Dark_Oak_Click(sender As Object, e As EventArgs) Handles Dark_Oak.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Color] = 'Dark Oak' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Quantity_Customer_ID.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub
End Class