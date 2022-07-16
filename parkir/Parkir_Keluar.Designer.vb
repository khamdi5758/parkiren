<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parkir_Keluar
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.karcishilang = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblwaktukeluar2 = New System.Windows.Forms.Label()
        Me.lblwaktumasuk2 = New System.Windows.Forms.Label()
        Me.txtjenker = New System.Windows.Forms.ComboBox()
        Me.txtnoplat = New System.Windows.Forms.TextBox()
        Me.txtantrikelua = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblwaktukeluar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltanggalkeluar = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.txtantrikeluar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.carikendar = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.karcishilang)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.lbltotal)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.lblwaktukeluar2)
        Me.TabPage3.Controls.Add(Me.lblwaktumasuk2)
        Me.TabPage3.Controls.Add(Me.txtjenker)
        Me.TabPage3.Controls.Add(Me.txtnoplat)
        Me.TabPage3.Controls.Add(Me.txtantrikelua)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(824, 454)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'karcishilang
        '
        Me.karcishilang.AutoSize = True
        Me.karcishilang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.karcishilang.Location = New System.Drawing.Point(601, 361)
        Me.karcishilang.Name = "karcishilang"
        Me.karcishilang.Size = New System.Drawing.Size(139, 28)
        Me.karcishilang.TabIndex = 123
        Me.karcishilang.Text = "Karcis Hilang"
        Me.karcishilang.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(504, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Denda : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(225, 16)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(154, 73)
        Me.lbltotal.TabIndex = 119
        Me.lbltotal.Text = "total"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(-1, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(210, 73)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "Total :"
        '
        'lblwaktukeluar2
        '
        Me.lblwaktukeluar2.AutoSize = True
        Me.lblwaktukeluar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktukeluar2.Location = New System.Drawing.Point(598, 313)
        Me.lblwaktukeluar2.Name = "lblwaktukeluar2"
        Me.lblwaktukeluar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblwaktukeluar2.Size = New System.Drawing.Size(133, 25)
        Me.lblwaktukeluar2.TabIndex = 114
        Me.lblwaktukeluar2.Text = "waktu keluar"
        '
        'lblwaktumasuk2
        '
        Me.lblwaktumasuk2.AutoSize = True
        Me.lblwaktumasuk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktumasuk2.Location = New System.Drawing.Point(596, 269)
        Me.lblwaktumasuk2.Name = "lblwaktumasuk2"
        Me.lblwaktumasuk2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblwaktumasuk2.Size = New System.Drawing.Size(137, 25)
        Me.lblwaktumasuk2.TabIndex = 112
        Me.lblwaktumasuk2.Text = "waktu masuk"
        '
        'txtjenker
        '
        Me.txtjenker.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjenker.FormattingEnabled = True
        Me.txtjenker.Location = New System.Drawing.Point(200, 363)
        Me.txtjenker.Name = "txtjenker"
        Me.txtjenker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtjenker.Size = New System.Drawing.Size(223, 33)
        Me.txtjenker.TabIndex = 3
        '
        'txtnoplat
        '
        Me.txtnoplat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoplat.Location = New System.Drawing.Point(200, 313)
        Me.txtnoplat.Multiline = True
        Me.txtnoplat.Name = "txtnoplat"
        Me.txtnoplat.Size = New System.Drawing.Size(221, 34)
        Me.txtnoplat.TabIndex = 2
        '
        'txtantrikelua
        '
        Me.txtantrikelua.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtantrikelua.Location = New System.Drawing.Point(200, 266)
        Me.txtantrikelua.Multiline = True
        Me.txtantrikelua.Name = "txtantrikelua"
        Me.txtantrikelua.Size = New System.Drawing.Size(221, 34)
        Me.txtantrikelua.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 25)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Jenis Kendaraan :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(497, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Sampai : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Terhitung pada : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "No plat :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Id Antrian :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(824, 454)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblwaktukeluar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbltanggalkeluar)
        Me.GroupBox2.Controls.Add(Me.btnback)
        Me.GroupBox2.Controls.Add(Me.Btnreset)
        Me.GroupBox2.Controls.Add(Me.btninput)
        Me.GroupBox2.Controls.Add(Me.txtantrikeluar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(818, 448)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'lblwaktukeluar
        '
        Me.lblwaktukeluar.AutoSize = True
        Me.lblwaktukeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktukeluar.Location = New System.Drawing.Point(522, 198)
        Me.lblwaktukeluar.Name = "lblwaktukeluar"
        Me.lblwaktukeluar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblwaktukeluar.Size = New System.Drawing.Size(129, 25)
        Me.lblwaktukeluar.TabIndex = 116
        Me.lblwaktukeluar.Text = "/ Jam keluar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(156, 25)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Waktu keluar : "
        '
        'lbltanggalkeluar
        '
        Me.lbltanggalkeluar.AutoSize = True
        Me.lbltanggalkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggalkeluar.Location = New System.Drawing.Point(370, 198)
        Me.lbltanggalkeluar.Name = "lbltanggalkeluar"
        Me.lbltanggalkeluar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltanggalkeluar.Size = New System.Drawing.Size(155, 25)
        Me.lbltanggalkeluar.TabIndex = 114
        Me.lbltanggalkeluar.Text = "Tanggal keluar"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(413, 380)
        Me.btnback.Name = "btnback"
        Me.btnback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnback.Size = New System.Drawing.Size(89, 38)
        Me.btnback.TabIndex = 112
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Btnreset
        '
        Me.Btnreset.Location = New System.Drawing.Point(553, 380)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btnreset.Size = New System.Drawing.Size(88, 38)
        Me.Btnreset.TabIndex = 111
        Me.Btnreset.Text = "RESET"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(689, 380)
        Me.btninput.Name = "btninput"
        Me.btninput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btninput.Size = New System.Drawing.Size(78, 38)
        Me.btninput.TabIndex = 110
        Me.btninput.Text = "INPUT"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'txtantrikeluar
        '
        Me.txtantrikeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtantrikeluar.Location = New System.Drawing.Point(375, 124)
        Me.txtantrikeluar.Multiline = True
        Me.txtantrikeluar.Name = "txtantrikeluar"
        Me.txtantrikeluar.Size = New System.Drawing.Size(221, 34)
        Me.txtantrikeluar.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "No antrian : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 72
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(824, 454)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(818, 393)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnnext)
        Me.GroupBox1.Controls.Add(Me.carikendar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(3, 396)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(651, 15)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(141, 33)
        Me.btnnext.TabIndex = 2
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'carikendar
        '
        Me.carikendar.Location = New System.Drawing.Point(97, 14)
        Me.carikendar.Multiline = True
        Me.carikendar.Name = "carikendar"
        Me.carikendar.Size = New System.Drawing.Size(336, 33)
        Me.carikendar.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(832, 480)
        Me.TabControl1.TabIndex = 3
        '
        'Parkir_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 480)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Parkir_Keluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parkir Keluar"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents carikendar As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnnext As Button
    Friend WithEvents txtantrikeluar As TextBox
    Friend WithEvents btnback As Button
    Friend WithEvents Btnreset As Button
    Friend WithEvents btninput As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnoplat As TextBox
    Friend WithEvents txtantrikelua As TextBox
    Friend WithEvents txtjenker As ComboBox
    Friend WithEvents lblwaktumasuk2 As Label
    Friend WithEvents lblwaktukeluar2 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbltanggalkeluar As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents karcishilang As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblwaktukeluar As Label
    Friend WithEvents Label5 As Label
End Class
