<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class karcis_pmasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(karcis_pmasuk))
        Me.printkarcismasuk = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.waktumasuk = New System.Windows.Forms.Label()
        Me.lblgolker = New System.Windows.Forms.Label()
        Me.lblplat = New System.Windows.Forms.Label()
        Me.lblantrian = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barcode = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'printkarcismasuk
        '
        Me.printkarcismasuk.DocumentName = "kmasuk"
        Me.printkarcismasuk.Form = Me
        Me.printkarcismasuk.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.printkarcismasuk.PrinterSettings = CType(resources.GetObject("printkarcismasuk.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.printkarcismasuk.PrintFileName = Nothing
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.barcode)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.waktumasuk)
        Me.GroupBox1.Controls.Add(Me.lblgolker)
        Me.GroupBox1.Controls.Add(Me.lblplat)
        Me.GroupBox1.Controls.Add(Me.lblantrian)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 323)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(133, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 19)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 19)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 19)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(133, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 19)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = ":"
        '
        'waktumasuk
        '
        Me.waktumasuk.AutoSize = True
        Me.waktumasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktumasuk.Location = New System.Drawing.Point(146, 291)
        Me.waktumasuk.Name = "waktumasuk"
        Me.waktumasuk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.waktumasuk.Size = New System.Drawing.Size(138, 16)
        Me.waktumasuk.TabIndex = 139
        Me.waktumasuk.Text = "Tanggal / Jam masuk"
        '
        'lblgolker
        '
        Me.lblgolker.AutoSize = True
        Me.lblgolker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgolker.Location = New System.Drawing.Point(146, 253)
        Me.lblgolker.Name = "lblgolker"
        Me.lblgolker.Size = New System.Drawing.Size(108, 16)
        Me.lblgolker.TabIndex = 138
        Me.lblgolker.Text = "Jenis kendaraan"
        '
        'lblplat
        '
        Me.lblplat.AutoSize = True
        Me.lblplat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplat.Location = New System.Drawing.Point(150, 212)
        Me.lblplat.Name = "lblplat"
        Me.lblplat.Size = New System.Drawing.Size(45, 16)
        Me.lblplat.TabIndex = 137
        Me.lblplat.Text = "noplat"
        '
        'lblantrian
        '
        Me.lblantrian.AutoSize = True
        Me.lblantrian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblantrian.Location = New System.Drawing.Point(148, 174)
        Me.lblantrian.Name = "lblantrian"
        Me.lblantrian.Size = New System.Drawing.Size(63, 16)
        Me.lblantrian.TabIndex = 136
        Me.lblantrian.Text = "noantrian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "No antrian"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Waktu masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Jenis Kendaraan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "No Plat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 37)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Parkir Masuk"
        '
        'barcode
        '
        Me.barcode.Location = New System.Drawing.Point(15, 84)
        Me.barcode.Name = "barcode"
        Me.barcode.Size = New System.Drawing.Size(264, 65)
        Me.barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.barcode.TabIndex = 147
        Me.barcode.TabStop = False
        '
        'karcis_pmasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(293, 323)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "karcis_pmasuk"
        Me.Text = "karcis_pmasuk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents printkarcismasuk As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents waktumasuk As Label
    Friend WithEvents lblgolker As Label
    Friend WithEvents lblplat As Label
    Friend WithEvents lblantrian As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents barcode As PictureBox
End Class
