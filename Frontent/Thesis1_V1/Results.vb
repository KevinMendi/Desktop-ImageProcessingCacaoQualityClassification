Imports MySql.Data.MySqlClient
Imports System.IO



Public Class Results
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand



    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT * FROM `tbl_filename` ORDER BY uid DESC LIMIT 3"


            MysqlConn.Close()

        Catch ex As Exception

        End Try





    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
      

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim id As String = ""
        If System.IO.File.Exists("C:\Users\User\Desktop\Python try\name0.txt") = True Then
            Dim objreader As New System.IO.StreamReader("C:\Users\User\Desktop\Python try\name0.txt")
            id = objreader.ReadLine
            Dim filename As String = System.IO.Path.Combine("C:\Users\User\Desktop\Python try\", "result-" & id)
            PictureBox1.Image = Image.FromFile(filename)

            objreader.Close()

        Else
            MessageBox.Show("File does not exist !")

        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim id As String = ""
        If System.IO.File.Exists("C:\Users\User\Desktop\Python try\name1.txt") = True Then
            Dim objreader As New System.IO.StreamReader("C:\Users\User\Desktop\Python try\name1.txt")
            id = objreader.ReadLine
            Dim filename As String = System.IO.Path.Combine("C:\Users\User\Desktop\Python try\", "result-" & id)
            PictureBox1.Image = Image.FromFile(filename)

            objreader.Close()

        Else
            MessageBox.Show("File does not exist !")

        End If
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim id As String = ""
        If System.IO.File.Exists("C:\Users\User\Desktop\Python try\name2.txt") = True Then
            Dim objreader As New System.IO.StreamReader("C:\Users\User\Desktop\Python try\name2.txt")
            id = objreader.ReadLine
            Dim filename As String = System.IO.Path.Combine("C:\Users\User\Desktop\Python try\", "result-" & id)
            PictureBox1.Image = Image.FromFile(filename)

            objreader.Close()

        Else
            MessageBox.Show("File does not exist !")

        End If
    End Sub
End Class