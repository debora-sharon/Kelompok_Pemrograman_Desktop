<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Panel1 = New Panel()
        Button5 = New Button()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Button4 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        Label1.Location = New Point(277, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(811, 54)
        Label1.TabIndex = 0
        Label1.Text = "Silahkan Masukan Akun Anda !!!"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(201), CByte(101), CByte(93))
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(395, 229)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(575, 309)
        Panel1.TabIndex = 1
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(249, 226)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 4
        Button5.Text = "Masuk"
        Button5.UseVisualStyleBackColor = True
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
        ' Button4
        ' 
        Button4.BackColor = Color.Firebrick
        Button4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(12, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(113, 49)
        Button4.TabIndex = 2
        Button4.Text = "Kembali"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1348, 721)
        Controls.Add(Button4)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
End Class
