<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        BindingSource1 = New BindingSource(components)
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(65, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 38)
        Label1.TabIndex = 1
        Label1.Text = "Debora Patricia"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(463, 21)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Cari Acara Anda"
        TextBox1.Size = New Size(702, 34)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1171, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(165, 35)
        Button1.TabIndex = 4
        Button1.Text = "Tambah Acara"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 104)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1324, 573)
        Panel1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(502, 258)
        Label2.Name = "Label2"
        Label2.Size = New Size(355, 38)
        Label2.TabIndex = 0
        Label2.Text = "Anda Belum Memiliki Acara"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
