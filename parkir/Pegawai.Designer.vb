<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pegawai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.viewpegawai = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btninput = New System.Windows.Forms.Button()
        Me.pilih = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.jenkelam = New System.Windows.Forms.ComboBox()
        Me.txtttlpeg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtpaspeg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jabatan = New System.Windows.Forms.ComboBox()
        Me.txtnampeg = New System.Windows.Forms.TextBox()
        Me.txtuserpeg = New System.Windows.Forms.TextBox()
        Me.txtidpeg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcaripeg = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.viewpegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'viewpegawai
        '
        Me.viewpegawai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewpegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewpegawai.Location = New System.Drawing.Point(0, 182)
        Me.viewpegawai.Name = "viewpegawai"
        Me.viewpegawai.Size = New System.Drawing.Size(795, 278)
        Me.viewpegawai.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btninput)
        Me.GroupBox1.Controls.Add(Me.pilih)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.jenkelam)
        Me.GroupBox1.Controls.Add(Me.txtttlpeg)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtpaspeg)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.jabatan)
        Me.GroupBox1.Controls.Add(Me.txtnampeg)
        Me.GroupBox1.Controls.Add(Me.txtuserpeg)
        Me.GroupBox1.Controls.Add(Me.txtidpeg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcaripeg)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 176)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(707, 17)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(75, 44)
        Me.btninput.TabIndex = 73
        Me.btninput.Text = "INPUT"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'pilih
        '
        Me.pilih.Location = New System.Drawing.Point(487, 102)
        Me.pilih.Name = "pilih"
        Me.pilih.Size = New System.Drawing.Size(152, 28)
        Me.pilih.TabIndex = 71
        Me.pilih.Text = "....."
        Me.pilih.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(418, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Pilih Gambar"
        '
        'jenkelam
        '
        Me.jenkelam.FormattingEnabled = True
        Me.jenkelam.Location = New System.Drawing.Point(125, 73)
        Me.jenkelam.Name = "jenkelam"
        Me.jenkelam.Size = New System.Drawing.Size(95, 21)
        Me.jenkelam.TabIndex = 69
        '
        'txtttlpeg
        '
        Me.txtttlpeg.Location = New System.Drawing.Point(125, 99)
        Me.txtttlpeg.Name = "txtttlpeg"
        Me.txtttlpeg.Size = New System.Drawing.Size(274, 20)
        Me.txtttlpeg.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Tempat/Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(604, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 23)
        Me.Button5.TabIndex = 64
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtpaspeg
        '
        Me.txtpaspeg.Location = New System.Drawing.Point(476, 47)
        Me.txtpaspeg.Name = "txtpaspeg"
        Me.txtpaspeg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpaspeg.Size = New System.Drawing.Size(209, 20)
        Me.txtpaspeg.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Password"
        '
        'jabatan
        '
        Me.jabatan.FormattingEnabled = True
        Me.jabatan.Location = New System.Drawing.Point(475, 73)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(97, 21)
        Me.jabatan.TabIndex = 61
        '
        'txtnampeg
        '
        Me.txtnampeg.Location = New System.Drawing.Point(125, 45)
        Me.txtnampeg.Name = "txtnampeg"
        Me.txtnampeg.Size = New System.Drawing.Size(274, 20)
        Me.txtnampeg.TabIndex = 59
        '
        'txtuserpeg
        '
        Me.txtuserpeg.Location = New System.Drawing.Point(475, 21)
        Me.txtuserpeg.Name = "txtuserpeg"
        Me.txtuserpeg.Size = New System.Drawing.Size(210, 20)
        Me.txtuserpeg.TabIndex = 60
        '
        'txtidpeg
        '
        Me.txtidpeg.Location = New System.Drawing.Point(125, 21)
        Me.txtidpeg.MaxLength = 5
        Me.txtidpeg.Name = "txtidpeg"
        Me.txtidpeg.Size = New System.Drawing.Size(274, 20)
        Me.txtidpeg.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Jabatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nama Pegawai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Id_pegawai"
        '
        'txtcaripeg
        '
        Me.txtcaripeg.Location = New System.Drawing.Point(286, 142)
        Me.txtcaripeg.Multiline = True
        Me.txtcaripeg.Name = "txtcaripeg"
        Me.txtcaripeg.Size = New System.Drawing.Size(209, 25)
        Me.txtcaripeg.TabIndex = 53
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(707, 122)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 45)
        Me.btndelete.TabIndex = 52
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(707, 71)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 45)
        Me.btnupdate.TabIndex = 51
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(492, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Pegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.viewpegawai)
        Me.Name = "Pegawai"
        Me.Text = "Form1"
        CType(Me.viewpegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents viewpegawai As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtpaspeg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents jabatan As ComboBox
    Friend WithEvents txtnampeg As TextBox
    Friend WithEvents txtuserpeg As TextBox
    Friend WithEvents txtidpeg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcaripeg As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents jenkelam As ComboBox
    Friend WithEvents txtttlpeg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pilih As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btninput As Button
End Class
