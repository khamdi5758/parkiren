<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKendaraanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifParkirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkirMasukToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkirKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.userToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilAndaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilInstansiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkirMasukToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkirKeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.userToolStripMenuItem, Me.ParkirMasukToolStripMenuItem2, Me.ParkirKeluarToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperatorToolStripMenuItem, Me.DaftarKendaraanToolStripMenuItem, Me.TarifParkirToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'OperatorToolStripMenuItem
        '
        Me.OperatorToolStripMenuItem.Name = "OperatorToolStripMenuItem"
        Me.OperatorToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OperatorToolStripMenuItem.Text = "Daftar Pegawai"
        '
        'DaftarKendaraanToolStripMenuItem
        '
        Me.DaftarKendaraanToolStripMenuItem.Name = "DaftarKendaraanToolStripMenuItem"
        Me.DaftarKendaraanToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DaftarKendaraanToolStripMenuItem.Text = "Daftar Kendaraan"
        '
        'TarifParkirToolStripMenuItem
        '
        Me.TarifParkirToolStripMenuItem.Name = "TarifParkirToolStripMenuItem"
        Me.TarifParkirToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TarifParkirToolStripMenuItem.Text = "Tarif Parkir"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParkirMasukToolStripMenuItem1, Me.ParkirKeluarToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'ParkirMasukToolStripMenuItem1
        '
        Me.ParkirMasukToolStripMenuItem1.Name = "ParkirMasukToolStripMenuItem1"
        Me.ParkirMasukToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ParkirMasukToolStripMenuItem1.Text = "Parkir Masuk"
        '
        'ParkirKeluarToolStripMenuItem
        '
        Me.ParkirKeluarToolStripMenuItem.Name = "ParkirKeluarToolStripMenuItem"
        Me.ParkirKeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ParkirKeluarToolStripMenuItem.Text = "Parkir Keluar"
        '
        'userToolStripMenuItem
        '
        Me.userToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilAndaToolStripMenuItem, Me.ProfilInstansiToolStripMenuItem, Me.KeluarToolStripMenuItem1})
        Me.userToolStripMenuItem.Name = "userToolStripMenuItem"
        Me.userToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.userToolStripMenuItem.Text = "User"
        '
        'ProfilAndaToolStripMenuItem
        '
        Me.ProfilAndaToolStripMenuItem.Name = "ProfilAndaToolStripMenuItem"
        Me.ProfilAndaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ProfilAndaToolStripMenuItem.Text = "Profil Anda"
        '
        'ProfilInstansiToolStripMenuItem
        '
        Me.ProfilInstansiToolStripMenuItem.Name = "ProfilInstansiToolStripMenuItem"
        Me.ProfilInstansiToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ProfilInstansiToolStripMenuItem.Text = "Profil Instansi"
        '
        'KeluarToolStripMenuItem1
        '
        Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.KeluarToolStripMenuItem1.Text = "Keluar"
        '
        'ParkirMasukToolStripMenuItem2
        '
        Me.ParkirMasukToolStripMenuItem2.Name = "ParkirMasukToolStripMenuItem2"
        Me.ParkirMasukToolStripMenuItem2.Size = New System.Drawing.Size(87, 20)
        Me.ParkirMasukToolStripMenuItem2.Text = "Parkir Masuk"
        '
        'ParkirKeluarToolStripMenuItem1
        '
        Me.ParkirKeluarToolStripMenuItem1.Name = "ParkirKeluarToolStripMenuItem1"
        Me.ParkirKeluarToolStripMenuItem1.Size = New System.Drawing.Size(85, 20)
        Me.ParkirKeluarToolStripMenuItem1.Text = "Parkir Keluar"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 451)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Parkirin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents userToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarKendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParkirMasukToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ParkirKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifParkirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilAndaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilInstansiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ParkirMasukToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ParkirKeluarToolStripMenuItem1 As ToolStripMenuItem
End Class
