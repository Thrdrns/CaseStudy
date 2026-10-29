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
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        RichTextBox3 = New RichTextBox()
        RichTextBox4 = New RichTextBox()
        RichTextBox5 = New RichTextBox()
        RichTextBox6 = New RichTextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 18)
        Label1.TabIndex = 0
        Label1.Text = "GuestID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(270, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 18)
        Label3.TabIndex = 1
        Label3.Text = "LastName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 18)
        Label2.TabIndex = 2
        Label2.Text = "FirstName"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 18)
        Label4.TabIndex = 3
        Label4.Text = "Preferences"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(30, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 18)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(270, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 18)
        Label6.TabIndex = 5
        Label6.Text = "Phone"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Controls.Add(RichTextBox6)
        Panel1.Controls.Add(RichTextBox5)
        Panel1.Controls.Add(RichTextBox4)
        Panel1.Controls.Add(RichTextBox3)
        Panel1.Controls.Add(RichTextBox2)
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(516, 287)
        Panel1.TabIndex = 6
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(30, 45)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(68, 27)
        RichTextBox1.TabIndex = 6
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(30, 109)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.Size = New Size(208, 27)
        RichTextBox2.TabIndex = 7
        RichTextBox2.Text = ""
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(270, 109)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.ReadOnly = True
        RichTextBox3.Size = New Size(208, 27)
        RichTextBox3.TabIndex = 8
        RichTextBox3.Text = ""
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.Location = New Point(30, 174)
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.ReadOnly = True
        RichTextBox4.Size = New Size(208, 28)
        RichTextBox4.TabIndex = 9
        RichTextBox4.Text = ""
        ' 
        ' RichTextBox5
        ' 
        RichTextBox5.Location = New Point(270, 174)
        RichTextBox5.Name = "RichTextBox5"
        RichTextBox5.ReadOnly = True
        RichTextBox5.Size = New Size(208, 28)
        RichTextBox5.TabIndex = 10
        RichTextBox5.Text = ""
        ' 
        ' RichTextBox6
        ' 
        RichTextBox6.Location = New Point(30, 237)
        RichTextBox6.Name = "RichTextBox6"
        RichTextBox6.ReadOnly = True
        RichTextBox6.Size = New Size(448, 28)
        RichTextBox6.TabIndex = 11
        RichTextBox6.Text = ""
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(540, 314)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox6 As RichTextBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
