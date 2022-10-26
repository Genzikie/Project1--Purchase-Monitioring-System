Imports System.Data.OleDb
Public Class Bed_Sizes
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        New_Item_Module.Show()
        Me.Close()
    End Sub

    Private Sub CK_Click(sender As Object, e As EventArgs) Handles CK.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Size] = 'California King' WHERE Furniture = 'Bed'", OleDbCon)
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

    Private Sub K_Click(sender As Object, e As EventArgs) Handles K.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Size] = 'King' WHERE Furniture = 'Bed'", OleDbCon)
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

    Private Sub Q_Click(sender As Object, e As EventArgs) Handles Q.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Size] = 'Queen' WHERE Furniture = 'Bed'", OleDbCon)
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

    Private Sub S_Click(sender As Object, e As EventArgs) Handles S.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("UPDATE orders SET [Size] = 'Single' WHERE Furniture = 'Bed'", OleDbCon)
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
End Class