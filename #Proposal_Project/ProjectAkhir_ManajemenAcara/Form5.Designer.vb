<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Panel1 = New Panel()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label1 = New Label()
        MonthCalendar1 = New MonthCalendar()
        Button5 = New Button()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        PelaksanaanToolStripMenuItem = New ToolStripMenuItem()
        KeperluanToolStripMenuItem = New ToolStripMenuItem()
        VendorToolStripMenuItem = New ToolStripMenuItem()
        TamuToolStripMenuItem = New ToolStripMenuItem()
        DokumentasiToolStripMenuItem = New ToolStripMenuItem()
        EvaluasiToolStripMenuItem = New ToolStripMenuItem()
        Button2 = New Button()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Cooper Black", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDaftar.ForeColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        lblDaftar.Location = New Point(454, 54)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(408, 46)
        lblDaftar.TabIndex = 4
        lblDaftar.Text = "Pelaksanaan Acara"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(MonthCalendar1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(292, 150)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(764, 539)
        Panel1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(467, 472)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(338, 386)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Masukan Username Anda"
        TextBox2.Size = New Size(352, 27)
        TextBox2.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(74, 372)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 41)
        Label1.TabIndex = 6
        Label1.Text = "Lokasi           :"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(338, 136)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 5
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(338, 472)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 4
        Button5.Text = "Simpan"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(74, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 41)
        Label3.TabIndex = 2
        Label3.Text = "Pelaksanaan :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(338, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Masukan Username Anda"
        TextBox1.Size = New Size(352, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(74, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 41)
        Label2.TabIndex = 0
        Label2.Text = "Kegiatan        :"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PelaksanaanToolStripMenuItem, KeperluanToolStripMenuItem, VendorToolStripMenuItem, TamuToolStripMenuItem, DokumentasiToolStripMenuItem, EvaluasiToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1348, 28)
        MenuStrip1.TabIndex = 6
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
        ' VendorToolStripMenuItem
        ' 
        VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        VendorToolStripMenuItem.Size = New Size(88, 24)
        VendorToolStripMenuItem.Text = "Anggaran"
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
        ' Button2
        ' 
        Button2.Location = New Point(596, 472)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 9
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel1)
        Controls.Add(lblDaftar)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDaftar As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PelaksanaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeperluanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokumentasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvaluasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
