<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        lblDaftar = New Label()
        ProgressBar1 = New ProgressBar()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PelaksanaanToolStripMenuItem, KeperluanToolStripMenuItem, AnggaranToolStripMenuItem, TamuToolStripMenuItem, DokumentasiToolStripMenuItem, EvaluasiToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1348, 28)
        MenuStrip1.TabIndex = 9
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
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(387, 252)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(575, 309)
        Panel1.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(377, 236)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 15
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(248, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 14
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(119, 236)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 13
        Button5.Text = "Simpan"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(24, 21)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Tuliskan Evaluasi Acara"
        TextBox1.Size = New Size(535, 142)
        TextBox1.TabIndex = 1
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDaftar.ForeColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        lblDaftar.Location = New Point(465, 159)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(325, 46)
        lblDaftar.TabIndex = 10
        lblDaftar.Text = "Evaluasi Acara"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(179, 169)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(224, 29)
        ProgressBar1.TabIndex = 16
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel1)
        Controls.Add(lblDaftar)
        Controls.Add(MenuStrip1)
        Name = "Form10"
        Text = "Form10"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDaftar As Label
End Class
