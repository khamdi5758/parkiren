﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laporan_pmasuk
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
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.viewharian = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.viewbulanan = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.viewjenken = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.viewperiode = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crv.Location = New System.Drawing.Point(0, 123)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(841, 395)
        Me.crv.TabIndex = 0
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.viewharian)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 114)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "harian"
        '
        'viewharian
        '
        Me.viewharian.Location = New System.Drawing.Point(28, 75)
        Me.viewharian.Name = "viewharian"
        Me.viewharian.Size = New System.Drawing.Size(118, 33)
        Me.viewharian.TabIndex = 1
        Me.viewharian.Text = "view"
        Me.viewharian.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.viewbulanan)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 114)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "bulanan"
        '
        'viewbulanan
        '
        Me.viewbulanan.Location = New System.Drawing.Point(28, 75)
        Me.viewbulanan.Name = "viewbulanan"
        Me.viewbulanan.Size = New System.Drawing.Size(118, 33)
        Me.viewbulanan.TabIndex = 1
        Me.viewbulanan.Text = "view"
        Me.viewbulanan.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMMM yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker2.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.viewjenken)
        Me.GroupBox3.Location = New System.Drawing.Point(586, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 114)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "jenis kendaraan"
        '
        'viewjenken
        '
        Me.viewjenken.Location = New System.Drawing.Point(18, 75)
        Me.viewjenken.Name = "viewjenken"
        Me.viewjenken.Size = New System.Drawing.Size(104, 33)
        Me.viewjenken.TabIndex = 1
        Me.viewjenken.Text = "view"
        Me.viewjenken.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox4.Controls.Add(Me.viewperiode)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox4.Location = New System.Drawing.Point(394, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(178, 114)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "periode"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(6, 46)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker4.TabIndex = 2
        '
        'viewperiode
        '
        Me.viewperiode.Location = New System.Drawing.Point(29, 75)
        Me.viewperiode.Name = "viewperiode"
        Me.viewperiode.Size = New System.Drawing.Size(118, 33)
        Me.viewperiode.TabIndex = 1
        Me.viewperiode.Text = "view"
        Me.viewperiode.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker3.TabIndex = 0
        '
        'laporan_pmasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 518)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.crv)
        Me.Name = "laporan_pmasuk"
        Me.Text = "laporan_pmasuk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents viewharian As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents viewbulanan As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents viewjenken As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents viewperiode As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
End Class
