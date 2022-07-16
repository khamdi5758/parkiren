<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parkir_Masuk
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltanggalmasuk = New System.Windows.Forms.Label()
        Me.txtjenken = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtplat = New System.Windows.Forms.TextBox()
        Me.txtantrimasuk = New System.Windows.Forms.TextBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnreset = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblwaktumasuk = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(323, 462)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblwaktumasuk)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbltanggalmasuk)
        Me.GroupBox1.Controls.Add(Me.txtjenken)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtplat)
        Me.GroupBox1.Controls.Add(Me.txtantrimasuk)
        Me.GroupBox1.Controls.Add(Me.btnrefresh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btnreset)
        Me.GroupBox1.Controls.Add(Me.btninput)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(327, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 462)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbltanggalmasuk
        '
        Me.lbltanggalmasuk.AutoSize = True
        Me.lbltanggalmasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggalmasuk.Location = New System.Drawing.Point(231, 238)
        Me.lbltanggalmasuk.Name = "lbltanggalmasuk"
        Me.lbltanggalmasuk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltanggalmasuk.Size = New System.Drawing.Size(159, 25)
        Me.lbltanggalmasuk.TabIndex = 111
        Me.lbltanggalmasuk.Text = "Tanggal masuk"
        '
        'txtjenken
        '
        Me.txtjenken.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjenken.FormattingEnabled = True
        Me.txtjenken.Location = New System.Drawing.Point(232, 126)
        Me.txtjenken.Name = "txtjenken"
        Me.txtjenken.Size = New System.Drawing.Size(237, 37)
        Me.txtjenken.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(505, 135)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 100
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtplat
        '
        Me.txtplat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplat.Location = New System.Drawing.Point(235, 179)
        Me.txtplat.Multiline = True
        Me.txtplat.Name = "txtplat"
        Me.txtplat.Size = New System.Drawing.Size(240, 34)
        Me.txtplat.TabIndex = 3
        '
        'txtantrimasuk
        '
        Me.txtantrimasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtantrimasuk.Location = New System.Drawing.Point(232, 70)
        Me.txtantrimasuk.Multiline = True
        Me.txtantrimasuk.Name = "txtantrimasuk"
        Me.txtantrimasuk.Size = New System.Drawing.Size(240, 34)
        Me.txtantrimasuk.TabIndex = 1
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(392, 369)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnrefresh.Size = New System.Drawing.Size(89, 38)
        Me.btnrefresh.TabIndex = 92
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(192, 25)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Jenis Kendaraan : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "No Plat : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "No antrian : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnreset
        '
        Me.Btnreset.Location = New System.Drawing.Point(134, 369)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btnreset.Size = New System.Drawing.Size(88, 38)
        Me.Btnreset.TabIndex = 85
        Me.Btnreset.Text = "RESET"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(272, 369)
        Me.btninput.Name = "btninput"
        Me.btninput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btninput.Size = New System.Drawing.Size(78, 38)
        Me.btninput.TabIndex = 4
        Me.btninput.Text = "INPUT"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(160, 25)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Waktu masuk : "
        '
        'lblwaktumasuk
        '
        Me.lblwaktumasuk.AutoSize = True
        Me.lblwaktumasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktumasuk.Location = New System.Drawing.Point(385, 238)
        Me.lblwaktumasuk.Name = "lblwaktumasuk"
        Me.lblwaktumasuk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblwaktumasuk.Size = New System.Drawing.Size(133, 25)
        Me.lblwaktumasuk.TabIndex = 113
        Me.lblwaktumasuk.Text = "/ Jam masuk"
        '
        'Parkir_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(870, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Parkir_Masuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parkir Masukvb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnrefresh As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnreset As Button
    Friend WithEvents btninput As Button
    Friend WithEvents txtplat As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtjenken As ComboBox
    Friend WithEvents lbltanggalmasuk As Label
    Friend WithEvents txtantrimasuk As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblwaktumasuk As Label
End Class
