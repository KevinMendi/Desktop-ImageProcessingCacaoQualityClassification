Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports MySql.Data.MySqlClient


Public Class frm_Main
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim data1 As String
    Dim data2 As String
    Dim data3 As String
    Dim data4 As String
    Dim data5 As String
    Dim priceMatrix As Double = 0
    Dim count As Integer = 0
    Dim remain As Integer = 0
    Dim state As String = 0

#Region "clear"
    Public Sub clear()
        tb_Name.Text = ""
        tb_Age.Text = ""
        cb_Gender.Text = Nothing
        tb_CN.Text = ""
        tb_Address.Text = ""
        tb_Email.Text = ""
        tb_Username.Text = ""
        tb_Pass.Text = ""
        tb_CPass.Text = ""
        photo.Image = Nothing


    End Sub
#End Region
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        Me.Close()

    End Sub


   

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_analyzeBeans.Click
        pnl_AB.Visible = True
        pnl_UP.Visible = False
        pnl_MPM.Visible = False
        pnl_Reports.Visible = False
        pnl_About.Visible = False
        pnl_step2.Visible = False
        pnl_step3.Visible = False



    End Sub

#Region "Get Data"
    Public Sub Getdata()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query2 As String = "SELECT uid, Name, Gender, Address, Username FROM tbl_users ORDER BY Name"
            Command = New MySqlCommand(Query2, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (Reader.Read() = True)
                DataGridView1.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

#End Region




#Region "update pm"
    Public Sub updatePm()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query3 As String = "SELECT * FROM tbl_pricematrix2 WHERE uid =  1 "
            Command = New MySqlCommand(Query3, MysqlConn)

            Reader = Command.ExecuteReader
            If Reader.Read Then
                tb_pm1.Text = Reader("r1").ToString
                tb_pm2.Text = Reader("r2").ToString
                tb_pm3.Text = Reader("r3").ToString
                tb_pm4.Text = Reader("r4").ToString
                tb_pm5.Text = Reader("r5").ToString
                tb_pm6.Text = Reader("r6").ToString
                tb_pm7.Text = Reader("r7").ToString
                tb_pm8.Text = Reader("r8").ToString
                tb_pm9.Text = Reader("r9").ToString
                tb_pm10.Text = Reader("r10").ToString
                tb_pm11.Text = Reader("r11").ToString
                tb_pm12.Text = Reader("r12").ToString
                tb_pm13.Text = Reader("r13").ToString
                tb_pm14.Text = Reader("r14").ToString
                tb_pm15.Text = Reader("r15").ToString
                tb_pm16.Text = Reader("r16").ToString
                tb_pm17.Text = Reader("r17").ToString
                tb_pm18.Text = Reader("r18").ToString
                tb_pm19.Text = Reader("r19").ToString
                tb_pm20.Text = Reader("r20").ToString
                tb_pm21.Text = Reader("r21").ToString
                tb_pm22.Text = Reader("r22").ToString
                tb_pm23.Text = Reader("r23").ToString
                tb_pm24.Text = Reader("r24").ToString
                tb_pm25.Text = Reader("r25").ToString
                tb_pm26.Text = Reader("r26").ToString

            End If

            MysqlConn.Close()
            If Reader Is Nothing Then
                Reader.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnl_AB.Visible = False
        pnl_UP.Visible = False
        pnl_MPM.Visible = False
        pnl_Reports.Visible = False
        pnl_About.Visible = False
        btn_step1.IdleFillColor = Color.SeaGreen
        btn_step1.IdleForecolor = Color.White
        PictureBox9.Visible = False
        'PictureBox9.Visible = True
       

        updatePm()
        Getdata()

      

    End Sub

  
    Private Sub btn_UP_Click(sender As Object, e As EventArgs) Handles btn_UP.Click
        pnl_AB.Visible = False
        pnl_UP.Visible = True
        pnl_MPM.Visible = False
        pnl_Reports.Visible = False
        pnl_About.Visible = False
    End Sub

    Private Sub btn_MPM_Click(sender As Object, e As EventArgs) Handles btn_MPM.Click
        pnl_AB.Visible = False
        pnl_UP.Visible = False
        pnl_MPM.Visible = True
        pnl_Reports.Visible = False
        pnl_About.Visible = False
    End Sub

    Private Sub btn_Reports_Click(sender As Object, e As EventArgs) Handles btn_Reports.Click
        'pnl_AB.Visible = False
        'pnl_UP.Visible = False
        'pnl_MPM.Visible = False
        'pnl_Reports.Visible = True
        'pnl_About.Visible = False

        frm_login.lbl_Name.Text = "Name"




        frm_login.Refresh()



        frm_login.Show()
        Me.Hide()

        frm_login.ErrorProvider1.Clear()
        frm_login.txt_username.Clear()
        frm_login.txt_password.Clear()
        'Me.Close()

        ' Me.Hide()




        



        

    End Sub

    Private Sub btn_About_Click(sender As Object, e As EventArgs) Handles btn_About.Click
        pnl_AB.Visible = False
        pnl_UP.Visible = False
        pnl_MPM.Visible = False
        pnl_Reports.Visible = False
        pnl_About.Visible = True
    End Sub

    Private Sub btn_step1_Click(sender As Object, e As EventArgs) Handles btn_step1.Click
        pnl_step1.Visible = True
        pnl_step2.Visible = False
        pnl_step3.Visible = False
    End Sub
    Dim a As Integer = 0
    Private Sub btn_step2_Click(sender As Object, e As EventArgs) Handles btn_step2.Click

        pnl_step1.Visible = False
        pnl_step2.Visible = True
        pnl_step3.Visible = False
        btn_step1.IdleFillColor = Color.SeaGreen
        btn_step1.IdleForecolor = Color.White
        btn_step2.IdleFillColor = Color.SeaGreen
        btn_step2.IdleForecolor = Color.White


    End Sub
#Region "Calculation"
    Public Sub multiplier()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader
        Dim pm1 As Decimal = 0.0
        Dim pm2 As Decimal = 0.0
        Dim pm3 As Decimal = 0.0
        Dim pm4 As Decimal = 0.0
        Dim pm5 As Decimal = 0.0
        Dim pm6 As Decimal = 0.0
        Dim pm7 As Decimal = 0.0
        Dim pm8 As Decimal = 0.0
        Dim pm9 As Decimal = 0.0
        Dim pm10 As Decimal = 0.0
        Dim pm11 As Decimal = 0.0
        Dim pm12 As Decimal = 0.0
        Dim pm13 As Decimal = 0.0
        Dim pm14 As Decimal = 0.0
        Dim pm15 As Decimal = 0.0
        Dim pm16 As Decimal = 0.0
        Dim pm17 As Decimal = 0.0
        Dim pm18 As Decimal = 0.0
        Dim pm19 As Decimal = 0.0
        Dim pm20 As Decimal = 0.0
        Dim pm21 As Decimal = 0.0
        Dim pm22 As Decimal = 0.0
        Dim pm23 As Decimal = 0.0
        Dim pm24 As Decimal = 0.0
        Dim pm25 As Decimal = 0.0
        Dim pm26 As Decimal = 0.0

        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT * FROM tbl_pricematrix2"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                pm1 = Reader("r1").ToString
                pm2 = Reader("r2").ToString
                pm3 = Reader("r3").ToString
                pm4 = Reader("r4").ToString
                pm5 = Reader("r5").ToString
                pm6 = Reader("r6").ToString
                pm7 = Reader("r7").ToString
                pm8 = Reader("r8").ToString
                pm9 = Reader("r9").ToString
                pm10 = Reader("r10").ToString
                pm11 = Reader("r11").ToString
                pm12 = Reader("r12").ToString
                pm13 = Reader("r13").ToString
                pm14 = Reader("r14").ToString
                pm15 = Reader("r15").ToString
                pm16 = Reader("r16").ToString
                pm17 = Reader("r17").ToString
                pm18 = Reader("r18").ToString
                pm19 = Reader("r19").ToString
                pm20 = Reader("r20").ToString
                pm21 = Reader("r21").ToString
                pm22 = Reader("r22").ToString
                pm23 = Reader("r23").ToString
                pm24 = Reader("r24").ToString
                pm25 = Reader("r25").ToString
                pm26 = Reader("r26").ToString

                If (lbl_Ototal.Text <= 80) Then

                    If (gauge_Over.Value >= 0 And gauge_Over.Value <= 2) Then

                        If (gauge_Under.Value <= 15) Then

                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.54
                                lbl_pm.Text = pm1
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.38
                                lbl_pm.Text = pm2

                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        ElseIf (gauge_Under.Value > 15 And gauge_Under.Value <= 32) Then


                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.47
                                lbl_pm.Text = pm3
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.31
                                lbl_pm.Text = pm4

                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix

                            End If

                        Else
                            MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                            priceMatrix = 0
                            lbl_pm.Text = priceMatrix
                        End If

                    ElseIf (gauge_Over.Value > 2 And gauge_Over.Value <= 5) Then

                        If (gauge_Under.Value < 15) Then

                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.35
                                lbl_pm.Text = pm5
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.21
                                lbl_pm.Text = pm6

                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        ElseIf (gauge_Under.Value > 15 And gauge_Under.Value <= 32) Then
                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.29
                                lbl_pm.Text = pm7
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.15
                                lbl_pm.Text = pm8
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        Else
                            MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                            priceMatrix = 0
                            lbl_pm.Text = priceMatrix
                        End If

                    Else
                        MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                        priceMatrix = 0
                        lbl_pm.Text = priceMatrix


                    End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf (lbl_Ototal.Text > 80 And lbl_Ototal.Text <= 90) Then

                    If (gauge_Over.Value <= 2) Then

                        If (gauge_Under.Value <= 15) Then

                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.47
                                lbl_pm.Text = pm9
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.32
                                lbl_pm.Text = pm10
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        ElseIf (gauge_Under.Value > 15 And gauge_Under.Value <= 32) Then
                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.4
                                lbl_pm.Text = pm11
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.25
                                lbl_pm.Text = pm12
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        Else
                            MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                            priceMatrix = 0
                            lbl_pm.Text = priceMatrix
                        End If

                    ElseIf (gauge_Over.Value > 2 And gauge_Over.Value <= 5) Then
                        If (gauge_Under.Value <= 15) Then
                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.29
                                lbl_pm.Text = pm13
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.16
                                lbl_pm.Text = pm14
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        ElseIf (gauge_Under.Value > 15 And gauge_Under.Value <= 32) Then
                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.23
                                lbl_pm.Text = pm15
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.1
                                lbl_pm.Text = pm16
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix

                            End If
                        Else
                            MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                            priceMatrix = 0
                            lbl_pm.Text = priceMatrix
                        End If

                    Else
                        MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                        priceMatrix = 0
                        lbl_pm.Text = priceMatrix

                    End If
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf (lbl_Ototal.Text > 90 And lbl_Ototal.Text <= 100) Then
                    If (gauge_Over.Value <= 2) Then

                        If (gauge_Under.Value <= 15) Then
                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.44
                                lbl_pm.Text = pm17

                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.28
                                lbl_pm.Text = pm18
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        ElseIf (gauge_Under.Value > 15 And gauge_Under.Value <= 32) Then
                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.37
                                lbl_pm.Text = pm19
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.22
                                lbl_pm.Text = pm20
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        Else
                            MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                            priceMatrix = 0
                            lbl_pm.Text = priceMatrix
                        End If

                    ElseIf (gauge_Over.Value > 2 And gauge_Over.Value <= 5) Then
                        If (gauge_Under.Value < 15) Then
                            If (gauge_Reject.Value < 5) Then
                                'priceMatrix = 1.26
                                lbl_pm.Text = pm21
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.12
                                lbl_pm.Text = pm22
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix

                            End If
                        ElseIf (gauge_Under.Value > 15 And gauge_Under.Value <= 32) Then
                            If (gauge_Reject.Value <= 5) Then
                                'priceMatrix = 1.2
                                lbl_pm.Text = pm23
                            ElseIf (gauge_Reject.Value > 5 And gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.07
                                lbl_pm.Text = pm24
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix
                            End If

                        Else
                            MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                            priceMatrix = 0
                            lbl_pm.Text = priceMatrix
                        End If

                    Else
                        MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                        priceMatrix = 0
                        lbl_pm.Text = priceMatrix
                    End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf (lbl_Ototal.Text > 100 And lbl_Ototal.Text <= 110) Then
                    If (gauge_Over.Value <= 5) Then

                        If (gauge_Under.Value <= 32) Then
                            If (gauge_Reject.Value <= 12) Then
                                'priceMatrix = 1.0
                                lbl_pm.Text = pm25
                            Else
                                MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                                priceMatrix = 0
                                lbl_pm.Text = priceMatrix

                            End If

                        Else
                            MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                            priceMatrix = 0
                            lbl_pm.Text = priceMatrix
                        End If

                    Else
                        MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                        priceMatrix = 0
                        lbl_pm.Text = priceMatrix
                    End If


                ElseIf (lbl_Ototal.Text > 110 And lbl_Ototal.Text <= 120) Then
                    MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                    priceMatrix = 0
                    lbl_pm.Text = priceMatrix


                Else
                    MessageBox.Show("Beans NOT Accepted -- LOW Quality")
                    priceMatrix = 0
                    lbl_pm.Text = priceMatrix



                End If
            End If
            MysqlConn.Close()
            If Reader Is Nothing Then
                Reader.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

       
    End Sub
#End Region
    Private Sub btn_step3_Click(sender As Object, e As EventArgs) Handles btn_step3.Click
        pnl_step1.Visible = False
        pnl_step2.Visible = False
        pnl_step3.Visible = True

        btn_step1.IdleFillColor = Color.SeaGreen
        btn_step1.IdleForecolor = Color.White
        btn_step2.IdleFillColor = Color.SeaGreen
        btn_step2.IdleForecolor = Color.White
        btn_step3.IdleFillColor = Color.SeaGreen
        btn_step3.IdleForecolor = Color.White
        

        If System.IO.File.Exists("C:\Users\User\Desktop\Python try\result.txt") = True Then
            Dim objreader As New System.IO.StreamReader("C:\Users\User\Desktop\Python try\result.txt")

            gauge_Well.Value = objreader.ReadLine
            gauge_Under.Value = objreader.ReadLine
            gauge_Over.Value = objreader.ReadLine
            gauge_Reject.Value = objreader.ReadLine
            'gauge_Total.Value = objreader.ReadLine
            lbl_Ototal.Text = objreader.ReadLine
            objreader.Close()

            









        Else
            MessageBox.Show("File does not exist !")

        End If


        multiplier()


        
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice


            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            'CAMERA.SetCameraProperty(CameraControlProperty.Focus, 5, CameraControlFlags.Manual)



            CAMERA.Start()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox8.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub


    Private Sub btn_capture_Click(sender As Object, e As EventArgs) Handles btn_capture.Click
        If count > 2 Then
            PictureBox10.Image = Nothing
            MessageBox.Show("You have captured three image already !")
        Else
            PictureBox10.Image = PictureBox8.Image

        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'lbl_indicator.Text = 1
        Dim picName As String = ""
        Dim picNo As Integer = 0
        Dim pName As String = ""

        'Dim pPath As String = ""

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()

            Dim Query As String = "SELECT MAX(uid) FROM tbl_filename"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            If Reader.HasRows Then
                Reader.Read()
                picName = Reader(0)
                picNo = (CInt(picName)) + 1
                pName = ("cacao" & picNo & ".jpg")

                'MessageBox.Show("" & picName)
                Reader.Close()
                Try
                    Dim Query2 As String = "INSERT INTO thesis1_v1.tbl_filename ( Name, pic ) VALUES ( @Name, @pic)"

                    Command = New MySqlCommand(Query2, MysqlConn)
                    PictureBox10.Image.Save("C:\Users\User\Desktop\Python try\" & pName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    File.WriteAllText("C:\Users\User\Desktop\Python try\name" & state & ".txt", Nothing)
                    File.AppendAllText("C:\Users\User\Desktop\Python try\name" & state & ".txt", "" & pName)

                    'Dim file As System.IO.StreamWriter("C:\Users\User\Desktop\Python try\name0.txt", True)

                    Dim mstream As New System.IO.MemoryStream
                    PictureBox10.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()
                    mstream.Close()
                    Command.Parameters.AddWithValue("@pic", arrImage)

                    Command.Parameters.AddWithValue("@Name", pName)
                    
                    Reader = Command.ExecuteReader()
                    MessageBox.Show("Saved Successfully ! ")
                    If (count = 0) Then
                        'Label16.Text = pName
                        pb0.Image = PictureBox10.Image

                    ElseIf (count = 1) Then
                        pb1.Image = PictureBox10.Image
                    ElseIf (count = 2) Then
                        pb2.Image = PictureBox10.Image
                    End If

                    If Reader Is Nothing Then
                        Reader.Close()

                    End If

                    count = count + 1
                    remain = 3 - count


                    'SaveFileDialog1.DefaultExt = ".jpg"

                    'If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'PictureBox10.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
                    If (count < 3 And count > 0) Then
                        MessageBox.Show("Picture Saved ! " & remain & " more to go !")
                        PictureBox10.Image = Nothing





                    Else
                        MessageBox.Show("You may now proceed to the next step !")
                        PictureBox10.Image = Nothing
                        btn_capture.Visible = False
                        btn_cancel.Visible = False
                        btn_new.Visible = False
                        btn_save.Visible = False
                        btn_start.Visible = False
                        btn_step1.IdleFillColor = Color.White
                        btn_step1.IdleForecolor = Color.SeaGreen
                        btn_step1.ForeColor = Color.SeaGreen
                        PictureBox9.Visible = True



                    End If


                    state = state + 1

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            End If



            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        pnl_step1.Visible = False
        pnl_step2.Visible = True
        pnl_step3.Visible = False
        btn_step1.IdleFillColor = Color.SeaGreen
        btn_step1.IdleForecolor = Color.White
        btn_step2.IdleFillColor = Color.SeaGreen
        btn_step2.IdleForecolor = Color.White
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox9.Visible = True Then
            PictureBox9.Visible = False
        ElseIf PictureBox9.Visible = False Then
            PictureBox9.Visible = True
        End If
    End Sub

    Private Sub pnl_AB_Paint(sender As Object, e As PaintEventArgs) Handles pnl_AB.Paint

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub pnl_MPM_Paint(sender As Object, e As PaintEventArgs) Handles pnl_MPM.Paint

    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click

    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label141_Click(sender As Object, e As EventArgs) Handles Label141.Click

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim sign As Integer = 0
        Dim retVal As Process
        retVal = Process.Start("C:\Users\User\Desktop\Python try\Thesis2_V3.py - Shortcut")
        If System.IO.File.Exists("C:\Users\User\Desktop\Python try\sign.txt") = True Then
            Dim objreader1 As New System.IO.StreamReader("C:\Users\User\Desktop\Python try\sign.txt")

            sign = objreader1.ReadLine
            If (sign = 1) Then
                Timer2.Start()

                ' retVal = Process.Start("C:\Users\User\Desktop\Thesis1 - Shortcut")

                If System.IO.File.Exists("C:\Users\User\Desktop\Python try\result.txt") = True Then
                    Dim objreader As New System.IO.StreamReader("C:\Users\User\Desktop\Python try\result.txt")

                    gauge_Well.Value = objreader.ReadLine
                    gauge_Under.Value = objreader.ReadLine
                    gauge_Over.Value = objreader.ReadLine
                    gauge_Reject.Value = objreader.ReadLine
                    'gauge_Total.Value = objreader.ReadLine
                    lbl_Ototal.Text = objreader.ReadLine

                    objreader.Close()


                Else
                    MessageBox.Show("File does not exist !")

                End If


            End If

            objreader1.Close()
        End If

      

        
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim sign As String = ""

        BunifuProgressBar1.Value += 1
        Label20.Text = BunifuProgressBar1.Value & " %"
        If (BunifuProgressBar1.Value = 100) Then
            Timer2.Stop()
            MessageBox.Show("Done")


        End If



    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Results.ShowDialog()

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader

        If Len(Trim(tb_Name.Text)) = 0 Then
            ErrorProvider1.SetError(tb_Name, "Please Enter User Full Name")
            MessageBox.Show("Please Enter User Full Name", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_Name.Focus()
            Exit Sub
        End If

        If Len(Trim(tb_Age.Text)) = 0 Then
            ErrorProvider1.SetError(tb_Age, "Please Enter User Age")
            MessageBox.Show("Please Enter User Age", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_Age.Focus()
            Exit Sub
        End If

        If Len(Trim(cb_Gender.Text)) = 0 Then
            ErrorProvider1.SetError(cb_Gender, "Please Select User Gender")
            MessageBox.Show("Please Select User Gender", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cb_Gender.Focus()
            Exit Sub
        End If

        If Len(Trim(tb_CN.Text)) = 0 Then
            ErrorProvider1.SetError(tb_CN, "Please Enter User Contact No")
            MessageBox.Show("Please Enter User Contact No", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_CN.Focus()
            Exit Sub
        End If


        If Len(Trim(tb_Address.Text)) = 0 Then
            ErrorProvider1.SetError(tb_Address, "Please Enter User Address")
            MessageBox.Show("Please Enter User Address", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_Address.Focus()
            Exit Sub
        End If

        If Len(Trim(tb_Email.Text)) = 0 Then
            ErrorProvider1.SetError(tb_Email, "Please Enter User Gmail")
            MessageBox.Show("Please Enter User Gmail", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_Email.Focus()
            Exit Sub
        End If


        If Len(Trim(tb_Username.Text)) = 0 Then
            ErrorProvider1.SetError(tb_Username, "Please Enter User Username")
            MessageBox.Show("Please Enter User Username", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_Username.Focus()
            Exit Sub
        End If

        If Len(Trim(tb_Pass.Text)) = 0 Then
            ErrorProvider1.SetError(tb_Pass, "Please Enter User Password")
            MessageBox.Show("Please Enter User Password", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_Pass.Focus()
            Exit Sub
        End If

        If Len(Trim(tb_CPass.Text)) = 0 Then
            ErrorProvider1.SetError(tb_CPass, "Please Enter User Confirm Password")
            MessageBox.Show("Please Enter User Confirm Password", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_CPass.Focus()
            Exit Sub
        End If

        ' If Len(Trim(photo.Text)) = 0 Then
        'ErrorProvider1.SetError(photo, "Please Select User Photo")
        'MessageBox.Show("Please Select User Photo", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ' photo.Focus()
        'Exit Sub
        'End If


        If tb_Pass.Text <> tb_CPass.Text Then
            ErrorProvider1.SetError(tb_CPass, "Password Not Match !")
            MessageBox.Show("Password Not Match", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_Pass.Text = ""
            tb_CPass.Text = ""
            tb_Pass.Focus()
            Exit Sub
        End If




        Try
            MysqlConn.Open()
            Dim Query As String = "INSERT INTO tbl_users (Name, Age, Gender, Contact_No, Address, Email, Username, Password, Picture ) VALUES (@name, @age, @gender, @cn, @address, @email, @un, md5(@pass), @pic)"
            Command = New MySqlCommand(Query, MysqlConn)
            Dim mstream As New System.IO.MemoryStream
            photo.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()
            Command.Parameters.AddWithValue("@name", tb_Name.Text.ToUpper)
            Command.Parameters.AddWithValue("@age", tb_Age.Text)
            Command.Parameters.AddWithValue("@gender", cb_Gender.Text)
            Command.Parameters.AddWithValue("@cn", tb_CN.Text)
            Command.Parameters.AddWithValue("@address", tb_Address.Text)
            Command.Parameters.AddWithValue("@email", tb_Email.Text)
            Command.Parameters.AddWithValue("@un", tb_Username.Text)
            Command.Parameters.AddWithValue("@pass", tb_Pass.Text)
            Command.Parameters.AddWithValue("@pic", arrImage)
            Reader = Command.ExecuteReader
            MessageBox.Show("Saved !")
            clear()


            MysqlConn.Close()
            If Reader Is Nothing Then
                Reader.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Getdata()
        clear()


    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                'PictureBox1.Visible = False
                'photo.Visible = True
                photo.Image = Image.FromFile(OpenFileDialog1.FileName)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String = "UPDATE tbl_pricematrix2 SET r1=@r1, r2=@r2, r3=@r3, r4=@r4, r5=@r5, r6=@r6, r7=@r7, r8=@r8, r9=@r9, r10=@r10, r11=@r11, r12=@r12, r13=@r13, r14=@r14, r15=@r15, r16=@r16, r17=@r17, r18=@r18, r19=@r19, r20=@r20, r21=@r21, r22=@r22, r23=@r23, r24=@r24, r25=@r25, r26=@r26 WHERE uid= 1"
            Command = New MySqlCommand(Query, MysqlConn)
            Command.Parameters.AddWithValue("@r1", tb_pm1.Text)
            Command.Parameters.AddWithValue("@r2", tb_pm2.Text)
            Command.Parameters.AddWithValue("@r3", tb_pm3.Text)
            Command.Parameters.AddWithValue("@r4", tb_pm4.Text)
            Command.Parameters.AddWithValue("@r5", tb_pm5.Text)
            Command.Parameters.AddWithValue("@r6", tb_pm6.Text)
            Command.Parameters.AddWithValue("@r7", tb_pm7.Text)
            Command.Parameters.AddWithValue("@r8", tb_pm8.Text)
            Command.Parameters.AddWithValue("@r9", tb_pm9.Text)
            Command.Parameters.AddWithValue("@r10", tb_pm10.Text)
            Command.Parameters.AddWithValue("@r11", tb_pm11.Text)
            Command.Parameters.AddWithValue("@r12", tb_pm12.Text)
            Command.Parameters.AddWithValue("@r13", tb_pm13.Text)
            Command.Parameters.AddWithValue("@r14", tb_pm14.Text)
            Command.Parameters.AddWithValue("@r15", tb_pm15.Text)
            Command.Parameters.AddWithValue("@r16", tb_pm16.Text)
            Command.Parameters.AddWithValue("@r17", tb_pm17.Text)
            Command.Parameters.AddWithValue("@r18", tb_pm18.Text)
            Command.Parameters.AddWithValue("@r19", tb_pm19.Text)
            Command.Parameters.AddWithValue("@r20", tb_pm20.Text)
            Command.Parameters.AddWithValue("@r21", tb_pm21.Text)
            Command.Parameters.AddWithValue("@r22", tb_pm22.Text)
            Command.Parameters.AddWithValue("@r23", tb_pm23.Text)
            Command.Parameters.AddWithValue("@r24", tb_pm24.Text)
            Command.Parameters.AddWithValue("@r25", tb_pm25.Text)
            Command.Parameters.AddWithValue("@r26", tb_pm26.Text)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
            MessageBox.Show("Price Multiplier Updated !")
            If Reader Is Nothing Then
                Reader.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        updatePm()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BunifuThinButton29_Click(sender As Object, e As EventArgs)

    End Sub








    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader
        'Dim a As Integer = 0
        Try
            If DataGridView1.Rows.Count Then
                Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                lbl_ID.Text = dgvRow.Cells(0).Value.ToString
                Try
                    MysqlConn.Open()
                    Dim Query As String = "SELECT * FROM tbl_users WHERE uid =  '" & lbl_ID.Text & "' "
                    Command = New MySqlCommand(Query, MysqlConn)
                    Reader = Command.ExecuteReader
                    If Reader.Read Then
                        tb_Name.Text = Reader("Name").ToString
                        tb_Age.Text = Reader("Age").ToString
                        cb_Gender.Text = Reader("Gender").ToString
                        tb_CN.Text = Reader("Contact_No").ToString
                        tb_Address.Text = Reader("Address").ToString
                        tb_Email.Text = Reader("Email").ToString
                        tb_Username.Text = Reader("Username").ToString
                        tb_Pass.Text = Reader("Password").ToString
                        Dim data As Byte() = DirectCast(Reader("Picture"), Byte())
                        Dim ms As New MemoryStream(data)
                        photo.Image = Image.FromStream(ms)

                    End If
                        MysqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String = "UPDATE tbl_users SET Name=@name, Age=@age, Gender=@gender, Contact_No=@cn, Address=@address, Email=@email, Username=@un, Password=md5(@pass) WHERE uid = '" & lbl_ID.Text & "' "
            Command = New MySqlCommand(Query, MysqlConn)
            Command.Parameters.AddWithValue("@name", tb_Name.Text)
            Command.Parameters.AddWithValue("@age", tb_Age.Text)
            Command.Parameters.AddWithValue("@gender", cb_Gender.Text)
            Command.Parameters.AddWithValue("@cn", tb_CN.Text)
            Command.Parameters.AddWithValue("@address", tb_Address.Text)
            Command.Parameters.AddWithValue("@email", tb_Email.Text)
            Command.Parameters.AddWithValue("@un", tb_Username.Text)
            Command.Parameters.AddWithValue("@pass", tb_Pass.Text)
            Reader = Command.ExecuteReader


            MysqlConn.Close()
            MessageBox.Show("Data Updated! ")
            If Reader Is Nothing Then
                Reader.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Getdata()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=Thesis1_V1"
        Dim Reader As MySqlDataReader

        Try

            If MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                MysqlConn.Open()
                Dim AffectedRow As Integer = 0
                Dim Query As String = "DELETE FROM tbl_users WHERE uid = @ID1"
                Command = New MySqlCommand(Query, MysqlConn)
                Command.Parameters.AddWithValue("@ID1", lbl_ID.Text)
                AffectedRow = Command.ExecuteNonQuery


                If AffectedRow > 0 Then
                    MessageBox.Show("Successfully Deleted !", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()


                Else
                    MessageBox.Show("No found Record !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()



                End If
                MysqlConn.Close()
            End If
            
            

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Getdata()
    End Sub

    Private Sub tb_Address_TextChanged(sender As Object, e As EventArgs) Handles tb_Address.TextChanged

    End Sub

    Private Sub tb_CN_TextChanged(sender As Object, e As EventArgs) Handles tb_CN.TextChanged

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        clear()

    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label64.Click

    End Sub

    Private Sub Label89_Click(sender As Object, e As EventArgs) Handles Label89.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            If MessageBox.Show("Are you sure you want to try again ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                count = 0
                remain = 0
                state = 0

                btn_capture.Visible = True
                btn_cancel.Visible = True
                btn_new.Visible = True
                btn_save.Visible = True
                btn_start.Visible = True
                PictureBox10.Refresh()

              
                pnl_step1.Visible = True
                pnl_step2.Visible = False
                pnl_step3.Visible = False

                btn_step1.IdleFillColor = Color.SeaGreen
                btn_step1.IdleForecolor = Color.White
                btn_step2.IdleFillColor = Color.White
                btn_step2.IdleForecolor = Color.SeaGreen
                btn_step3.IdleFillColor = Color.White
                btn_step3.IdleForecolor = Color.SeaGreen
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub pnl_step3_Paint(sender As Object, e As PaintEventArgs) Handles pnl_step3.Paint

    End Sub
End Class