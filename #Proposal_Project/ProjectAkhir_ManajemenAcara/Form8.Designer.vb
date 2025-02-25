<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        lblDaftar = New Label()
        MenuStrip1 = New MenuStrip()
        PelaksanaanToolStripMenuItem = New ToolStripMenuItem()
        KeperluanToolStripMenuItem = New ToolStripMenuItem()
        AnggaranToolStripMenuItem = New ToolStripMenuItem()
        TamuToolStripMenuItem = New ToolStripMenuItem()
        DokumentasiToolStripMenuItem = New ToolStripMenuItem()
        EvaluasiToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        Kategori = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        TextBox1 = New TextBox()
        lblTotalTamu = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Cooper Black", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDaftar.ForeColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        lblDaftar.Location = New Point(454, 54)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(268, 46)
        lblDaftar.TabIndex = 7
        lblDaftar.Text = "Tamu Acara"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PelaksanaanToolStripMenuItem, KeperluanToolStripMenuItem, AnggaranToolStripMenuItem, TamuToolStripMenuItem, DokumentasiToolStripMenuItem, EvaluasiToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1348, 28)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PelaksanaanToolStripMenuItem
        ' 
        PelaksanaanToolStripMenuItem.Name = "PelaksanaanToolStripMenuItem"
        PelaksanaanToolStripMenuItem.Size = New Size(103, 24)
        PelaksanaanToolStripMenuItem.Text = "Pelaksanaan"
        ' 
        ' KeperluanToolStripMenuItem
        ' 
        KeperluanToolStripMenuItem.Name = "KeperluanToolStripMenuItem"
        KeperluanToolStripMenuItem.Size = New Size(90, 24)
        KeperluanToolStripMenuItem.Text = "Keperluan"
        ' 
        ' AnggaranToolStripMenuItem
        ' 
        AnggaranToolStripMenuItem.Name = "AnggaranToolStripMenuItem"
        AnggaranToolStripMenuItem.Size = New Size(88, 24)
        AnggaranToolStripMenuItem.Text = "Anggaran"
        ' 
        ' TamuToolStripMenuItem
        ' 
        TamuToolStripMenuItem.Name = "TamuToolStripMenuItem"
        TamuToolStripMenuItem.Size = New Size(58, 24)
        TamuToolStripMenuItem.Text = "Tamu"
        ' 
        ' DokumentasiToolStripMenuItem
        ' 
        DokumentasiToolStripMenuItem.Name = "DokumentasiToolStripMenuItem"
        DokumentasiToolStripMenuItem.Size = New Size(110, 24)
        DokumentasiToolStripMenuItem.Text = "Dokumentasi"
        ' 
        ' EvaluasiToolStripMenuItem
        ' 
        EvaluasiToolStripMenuItem.Name = "EvaluasiToolStripMenuItem"
        EvaluasiToolStripMenuItem.Size = New Size(76, 24)
        EvaluasiToolStripMenuItem.Text = "Evaluasi"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(lblTotalTamu)
        Panel1.Location = New Point(276, 121)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(605, 562)
        Panel1.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(386, 509)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(257, 509)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(128, 509)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 10
        Button5.Text = "Simpan"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Kategori, Column1, Column2, Column3})
        DataGridView1.Location = New Point(24, 97)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(554, 188)
        DataGridView1.TabIndex = 5
        ' 
        ' Kategori
        ' 
        Kategori.HeaderText = "Kategori"
        Kategori.MinimumWidth = 6
        Kategori.Name = "Kategori"
        Kategori.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Jam Kedatangan"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Undangan"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Realisasi"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(242, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Masukan Username Anda"
        TextBox1.Size = New Size(231, 27)
        TextBox1.TabIndex = 1
        ' 
        ' lblTotalTamu
        ' 
        lblTotalTamu.AccessibleRole = AccessibleRole.TitleBar
        lblTotalTamu.AutoSize = True
        lblTotalTamu.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTotalTamu.ForeColor = SystemColors.ButtonHighlight
        lblTotalTamu.Location = New Point(47, 25)
        lblTotalTamu.Name = "lblTotalTamu"
        lblTotalTamu.Size = New Size(189, 41)
        lblTotalTamu.TabIndex = 0
        lblTotalTamu.Text = "Total Tamu :"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Controls.Add(lblDaftar)
        Name = "Form8"
        Text = "Form8"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDaftar As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PelaksanaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeperluanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokumentasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvaluasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTotalTamu As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
