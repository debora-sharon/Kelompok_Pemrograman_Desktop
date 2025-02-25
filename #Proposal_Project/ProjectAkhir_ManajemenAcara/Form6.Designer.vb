<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        MenuStrip1 = New MenuStrip()
        PelaksanaanToolStripMenuItem = New ToolStripMenuItem()
        KeperluanToolStripMenuItem = New ToolStripMenuItem()
        AnggaranToolStripMenuItem = New ToolStripMenuItem()
        TamuToolStripMenuItem = New ToolStripMenuItem()
        DokumentasiToolStripMenuItem = New ToolStripMenuItem()
        EvaluasiToolStripMenuItem = New ToolStripMenuItem()
        lblDaftar = New Label()
        Panel1 = New Panel()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        DataGridView2 = New DataGridView()
        Kategori = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewCheckBoxColumn()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PelaksanaanToolStripMenuItem, KeperluanToolStripMenuItem, AnggaranToolStripMenuItem, TamuToolStripMenuItem, DokumentasiToolStripMenuItem, EvaluasiToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1348, 28)
        MenuStrip1.TabIndex = 0
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
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Cooper Black", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDaftar.ForeColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        lblDaftar.Location = New Point(454, 54)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(366, 46)
        lblDaftar.TabIndex = 5
        lblDaftar.Text = "Keperluan Acara"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(DataGridView2)
        Panel1.Location = New Point(266, 132)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(746, 529)
        Panel1.TabIndex = 10
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(460, 454)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 12
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(331, 454)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 11
        Button4.Text = "Edit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(202, 454)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 10
        Button5.Text = "Simpan"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Kategori, Column1, Column2, Column3})
        DataGridView2.Location = New Point(96, 24)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(552, 358)
        DataGridView2.TabIndex = 5
        ' 
        ' Kategori
        ' 
        Kategori.HeaderText = "Keperluan"
        Kategori.MinimumWidth = 6
        Kategori.Name = "Kategori"
        Kategori.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nama Vendor"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Kontak"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Keterangan"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Resizable = DataGridViewTriState.True
        Column3.SortMode = DataGridViewColumnSortMode.Automatic
        Column3.Width = 125
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel1)
        Controls.Add(lblDaftar)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form6"
        Text = "Form6"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PelaksanaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeperluanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokumentasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvaluasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDaftar As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewCheckBoxColumn
End Class
