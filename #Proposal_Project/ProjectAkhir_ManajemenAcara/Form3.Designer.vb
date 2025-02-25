<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button3 = New Button()
        Panel1 = New Panel()
        Button6 = New Button()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        lblDaftar = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 49)
        Button3.TabIndex = 5
        Button3.Text = "Kembali"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(395, 229)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(575, 309)
        Panel1.TabIndex = 4
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(249, 226)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 4
        Button6.Text = "Daftar"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(249, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Masukan Password Anda"
        TextBox2.Size = New Size(231, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(74, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 41)
        Label3.TabIndex = 2
        Label3.Text = "Password :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(249, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Masukan Username Anda"
        TextBox1.Size = New Size(231, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(74, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 41)
        Label2.TabIndex = 0
        Label2.Text = "Username :"
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Cooper Black", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDaftar.ForeColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        lblDaftar.Location = New Point(277, 110)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(847, 54)
        lblDaftar.TabIndex = 3
        lblDaftar.Text = "Silahkan Daftarkan Akun Anda !!!"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1348, 721)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(lblDaftar)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDaftar As Label
End Class
