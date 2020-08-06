Imports MySql.Data.MySqlClient
Public Class frm_login
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panel2.BackColor = Color.FromArgb(100, 255, 255, 255)

        Timer1.Start()
        Panel2.Visible = False
        Panel5.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ImageSlider1.CurrentImageIndex = 5 Then
            ImageSlider1.SlideFirst()
        Else
            ImageSlider1.SlideNext()
        End If


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()


    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btn_SignIn.Click
        Panel2.Visible = True
        Panel5.Visible = True


    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        btn_SignIn.Visible = True
        Panel2.Visible = False
        Panel5.Visible = False
        txt_username.ResetText()
        txt_password.ResetText()



    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click






    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader
        Dim Reader2 As MySqlDataReader

        If Len(Trim(txt_username.Text)) = 0 Then
            ErrorProvider1.SetError(txt_username, "Please Enter Your Username")
            MessageBox.Show("Please Enter Your Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_username.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_password.Text)) = 0 Then
            ErrorProvider1.SetError(txt_password, "Please Enter Your Password")
            MessageBox.Show("Please Enter Your Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_password.Focus()
            Exit Sub

        End If






        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT Name FROM thesis1_v1.tbl_users WHERE Username = @find"
            Command = New MySqlCommand(Query, MysqlConn)
            Command.Parameters.Add(New MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30, "Username"))
            Command.Parameters("@find").Value = txt_username.Text
            Reader = Command.ExecuteReader

            If Reader.Read Then

                lbl_Name.Text = Reader("Name").ToString
            Else
                MessageBox.Show("Invalid Username", "Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_username.Text = ""
                txt_username.Focus()
                Return

                If Reader Is Nothing Then
                    Reader.Close()

                End If
            End If

            If Reader Is Nothing Then
                Reader.Close()

            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try




        Try
            MysqlConn.Open()

            Dim Query As String = "SELECT * FROM thesis1_v1.tbl_users WHERE Username = '" & txt_username.Text & "' and Password = md5('" & txt_password.Text & "')"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader2 = Command.ExecuteReader

            Reader2.Read()

           

            If Reader2.HasRows Then
                frm_Main.Label3.Text = lbl_Name.Text
                Dim imagebytes As Byte() = CType(Reader2("Picture"), Byte())
                Using ms As New IO.MemoryStream(imagebytes)
                    frm_Main.PictureBox2.Image = Image.FromStream(ms)
                    frm_Main.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                End Using





                Me.Hide()
                frm_Main.Refresh()

                frm_Main.Show()


                If Reader2 Is Nothing Then
                    Reader2.Close()
                End If

            Else
                MessageBox.Show("Invalid Password", "Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_password.Text = ""
                txt_password.Focus()

                If Reader2 Is Nothing Then
                    Reader2.Close()
                End If
            End If

            
            If Reader2 Is Nothing Then
                Reader2.Close()
            End If
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try







        

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
