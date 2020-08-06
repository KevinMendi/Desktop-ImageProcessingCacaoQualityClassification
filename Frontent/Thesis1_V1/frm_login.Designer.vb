<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.ImageSlider1 = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_SignIn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_password = New Thesis1_V1.Watermark()
        Me.txt_username = New Thesis1_V1.Watermark()
        CType(Me.ImageSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageSlider1
        '
        Me.ImageSlider1.CurrentImageIndex = 0
        Me.ImageSlider1.Images.Add(CType(resources.GetObject("ImageSlider1.Images"), System.Drawing.Image))
        Me.ImageSlider1.Images.Add(CType(resources.GetObject("ImageSlider1.Images1"), System.Drawing.Image))
        Me.ImageSlider1.Images.Add(CType(resources.GetObject("ImageSlider1.Images2"), System.Drawing.Image))
        Me.ImageSlider1.Images.Add(CType(resources.GetObject("ImageSlider1.Images3"), System.Drawing.Image))
        Me.ImageSlider1.Images.Add(CType(resources.GetObject("ImageSlider1.Images4"), System.Drawing.Image))
        Me.ImageSlider1.Images.Add(CType(resources.GetObject("ImageSlider1.Images5"), System.Drawing.Image))
        Me.ImageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
        Me.ImageSlider1.Location = New System.Drawing.Point(-2, 95)
        Me.ImageSlider1.Name = "ImageSlider1"
        Me.ImageSlider1.Size = New System.Drawing.Size(1028, 331)
        Me.ImageSlider1.TabIndex = 0
        Me.ImageSlider1.Text = "ImageSlider1"
        Me.ImageSlider1.UseDisabledStatePainter = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1174, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 26)
        Me.Panel1.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(971, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 27)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "_"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1002, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 27)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Thesis_V1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(161, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ABOUT THIS PROJECT"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Gray
        Me.RichTextBox1.Location = New System.Drawing.Point(44, 484)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(435, 194)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(569, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Developers"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(557, 484)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kevin A. Mendi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(536, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Angel Vonn Capuyan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(547, 524)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Ma. Paula Estrada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(840, 455)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "CONTACT US"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(832, 481)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "+639770592864"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(832, 537)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "CONNECT WITH US"
        '
        'btn_SignIn
        '
        Me.btn_SignIn.ActiveBorderThickness = 1
        Me.btn_SignIn.ActiveCornerRadius = 20
        Me.btn_SignIn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_SignIn.ActiveForecolor = System.Drawing.Color.White
        Me.btn_SignIn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_SignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_SignIn.BackgroundImage = CType(resources.GetObject("btn_SignIn.BackgroundImage"), System.Drawing.Image)
        Me.btn_SignIn.ButtonText = "Get Started"
        Me.btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SignIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignIn.ForeColor = System.Drawing.Color.White
        Me.btn_SignIn.IdleBorderThickness = 1
        Me.btn_SignIn.IdleCornerRadius = 20
        Me.btn_SignIn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_SignIn.IdleForecolor = System.Drawing.Color.White
        Me.btn_SignIn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_SignIn.Location = New System.Drawing.Point(839, 36)
        Me.btn_SignIn.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_SignIn.Name = "btn_SignIn"
        Me.btn_SignIn.Size = New System.Drawing.Size(140, 55)
        Me.btn_SignIn.TabIndex = 14
        Me.btn_SignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(836, 569)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 37)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(885, 569)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 37)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.ErrorImage = Nothing
        Me.PictureBox4.Location = New System.Drawing.Point(936, 569)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(43, 37)
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(399, 26)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Quality Classification of Cross-Cut"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(467, 26)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Cacao Beans through Image Processing"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.txt_username)
        Me.Panel2.Controls.Add(Me.BunifuThinButton23)
        Me.Panel2.Controls.Add(Me.BunifuThinButton22)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lbl_Name)
        Me.Panel2.Location = New System.Drawing.Point(774, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 331)
        Me.Panel2.TabIndex = 19
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Cancel"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.Silver
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(52, 257)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(189, 43)
        Me.BunifuThinButton23.TabIndex = 21
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Sign In"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Gray
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.Silver
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(50, 211)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(189, 43)
        Me.BunifuThinButton22.TabIndex = 20
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.ErrorImage = Nothing
        Me.PictureBox7.Location = New System.Drawing.Point(13, 166)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.ErrorImage = Nothing
        Me.PictureBox6.Location = New System.Drawing.Point(13, 115)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.ErrorImage = Nothing
        Me.PictureBox5.Location = New System.Drawing.Point(90, 35)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(82, 66)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 318)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(252, 13)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 15)
        Me.Panel3.TabIndex = 0
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.White
        Me.lbl_Name.Location = New System.Drawing.Point(2, 318)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Name.TabIndex = 22
        Me.lbl_Name.Text = "Name"
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(813, 35)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 58)
        Me.Panel5.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(578, 569)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 19)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Adviser"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(536, 598)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Engr. Randy Angelia"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.White
        Me.txt_password.Location = New System.Drawing.Point(59, 170)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(170, 33)
        Me.txt_password.TabIndex = 2
        Me.txt_password.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_password.WatermarkText = "Password"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.White
        Me.txt_username.Location = New System.Drawing.Point(59, 120)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(170, 33)
        Me.txt_username.TabIndex = 1
        Me.txt_username.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_username.WatermarkText = "Username"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 648)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_SignIn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ImageSlider1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ImageSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageSlider1 As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_SignIn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_password As Thesis1_V1.Watermark
    Friend WithEvents txt_username As Thesis1_V1.Watermark
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lbl_Name As System.Windows.Forms.Label

End Class
