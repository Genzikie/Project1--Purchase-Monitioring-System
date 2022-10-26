Imports System.Data.OleDb
Public Class Quantity_Customer_ID
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Color] = '' WHERE ID = id", OleDbCon)
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

    Private Sub Deliver_Click(sender As Object, e As EventArgs) Handles Deliver.Click
        If TextBox1.Text And TextBox2.Text = "" Then
            MessageBox.Show("Quantity and Customer ID empty")

        Else
            OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
            Dim COMMAND As New OleDbCommand("UPDATE orders SET [Quantity] = quan, [CustomerID] = cus WHERE [ID] = id", OleDbCon)
            COMMAND.Parameters.Add("quan", OleDbType.VarChar).Value = TextBox1.Text
            COMMAND.Parameters.Add("cus", OleDbType.VarChar).Value = TextBox2.Text
            COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
            OleDbCon.Open()
            Try
                If COMMAND.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Order Successful! Check Delivery")
                    Purchase_System.Show()
                    Me.Close()
                    Varnish_Color.Close()
                    Material.Close()
                    Bed_Sizes.Close()
                    New_Item_Module.Close()
                    New_Item_Module2.Close()
                    Item_Module.Close()
                Else
                    MessageBox.Show("Delivery Failed")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            OleDbCon.Close()

        End If
    End Sub
End Class