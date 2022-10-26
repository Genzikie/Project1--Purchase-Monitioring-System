Imports System.Data.OleDb
Public Class Material
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Size] = '',Furniture = '',Design = '' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                New_Item_Module.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Narra_Click(sender As Object, e As EventArgs) Handles Narra.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Material] = 'Narra' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Varnish_Color.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Mahogany_Click(sender As Object, e As EventArgs) Handles Mahogany.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Material] = 'Mahogany' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Varnish_Color.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Yakal_Click(sender As Object, e As EventArgs) Handles Yakal.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Material] = 'Yakal' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Varnish_Color.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Acacia_Click(sender As Object, e As EventArgs) Handles Acacia.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Material] = 'Acacia' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Varnish_Color.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Kamagong_Click(sender As Object, e As EventArgs) Handles Kamagong.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Material] = 'Kamagong' WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Varnish_Color.Show()
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