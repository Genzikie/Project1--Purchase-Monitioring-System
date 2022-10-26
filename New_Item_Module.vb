Imports System.Data.OleDb
Public Class New_Item_Module
    Dim OleDbCon As OleDbConnection
    Dim COMMAND As OleDbCommand
    Private Sub Bed1_Click(sender As Object, e As EventArgs) Handles Bed1.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design) VALUES (id,fur,des)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Bed"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Modern"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Bed_Sizes.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Bed2_Click(sender As Object, e As EventArgs) Handles Bed2.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design) VALUES (id,fur,des)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Bed"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Mission"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Bed_Sizes.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Bed3_Click(sender As Object, e As EventArgs) Handles Bed3.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design) VALUES (id,fur,des)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Bed"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Country"
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Bed_Sizes.Show()
                Me.Hide()
            Else
                MessageBox.Show("There is a problem")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        OleDbCon.Close()
    End Sub

    Private Sub Bed4_Click(sender As Object, e As EventArgs) Handles Bed4.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Bed"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Twin Over Full Bunk"
        COMMAND.Parameters.Add("siz", OleDbType.VarChar).Value = "Double Decker"
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

    Private Sub Bed5_Click(sender As Object, e As EventArgs) Handles Bed5.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Bed"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Traditional"
        COMMAND.Parameters.Add("siz", OleDbType.VarChar).Value = "Double Decker"
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

    Private Sub Chair1_Click(sender As Object, e As EventArgs) Handles Chair1.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design , [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Chair"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Transitional"
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

    Private Sub Chair2_Click(sender As Object, e As EventArgs) Handles Chair2.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Chair"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Outdoor"
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

    Private Sub Chair3_Click(sender As Object, e As EventArgs) Handles Chair3.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design , [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Chair"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Ladderback"
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

    Private Sub Chair4_Click(sender As Object, e As EventArgs) Handles Chair4.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Chair"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Kitchen"
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

    Private Sub Chair5_Click(sender As Object, e As EventArgs) Handles Chair5.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Chair"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Traditional"
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

    Private Sub Cabinet1_Click(sender As Object, e As EventArgs) Handles Cabinet1.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Cabinet"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Large Traditional"
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

    Private Sub Cabinet2_Click(sender As Object, e As EventArgs) Handles Cabinet2.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Cabinet"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Transitional"
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

    Private Sub Cabinet3_Click(sender As Object, e As EventArgs) Handles Cabinet3.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Cabinet"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Contemporary"
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

    Private Sub Cabinet4_Click(sender As Object, e As EventArgs) Handles Cabinet4.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Cabinet"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Traditional"
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

    Private Sub Cabinet5_Click(sender As Object, e As EventArgs) Handles Cabinet5.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("INSERT INTO orders (ID, Furniture, Design, [Size]) VALUES (id,fur,des,siz)", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Integer).Value = Item_Module.TextBox1.Text
        COMMAND.Parameters.Add("fur", OleDbType.VarChar).Value = "Cabinet"
        COMMAND.Parameters.Add("des", OleDbType.VarChar).Value = "Modern"
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

    Private Sub Next_Page_Click(sender As Object, e As EventArgs) Handles Next_Page.Click
        New_Item_Module2.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        OleDbCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project1.mdb")
        Dim COMMAND As New OleDbCommand("DELETE FROM orders WHERE ID = id", OleDbCon)
        COMMAND.Parameters.Add("id", OleDbType.Variant).Value = Item_Module.TextBox1.Text
        OleDbCon.Open()
        Try
            If COMMAND.ExecuteNonQuery() = 1 Then
                Item_Module.Show()
                Me.Close()
            Else
                Item_Module.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        OleDbCon.Close()
    End Sub
End Class