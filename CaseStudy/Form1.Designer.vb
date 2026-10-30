<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        btnAdd = New Button()
        btnSearch = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Panel2 = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        lblViewPreferences = New Label()
        lblViewPhone = New Label()
        lblViewEmail = New Label()
        lblViewLastName = New Label()
        lblViewFirstName = New Label()
        lblViewID = New Label()
        btnClear = New Button()
        txtEmail = New RichTextBox()
        txtLastName = New RichTextBox()
        txtGuestID = New RichTextBox()
        txtPhone = New RichTextBox()
        txtFirstName = New RichTextBox()
        txtPreferences = New RichTextBox()
        Panel3 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel4 = New Panel()
        Label13 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(Label13)
        Panel1.Location = New Point(-5, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(760, 49)
        Panel1.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Green
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ButtonHighlight
        btnAdd.Location = New Point(4, 8)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(116, 36)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add Guest"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.HotTrack
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ButtonHighlight
        btnSearch.Location = New Point(159, 8)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(116, 36)
        btnSearch.TabIndex = 2
        btnSearch.Text = "View / Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.DarkOrange
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = SystemColors.ButtonHighlight
        btnUpdate.Location = New Point(309, 8)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(116, 36)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update Guest"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.IndianRed
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(461, 8)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(116, 36)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete Guest"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(lblViewPreferences)
        Panel2.Controls.Add(lblViewPhone)
        Panel2.Controls.Add(lblViewEmail)
        Panel2.Controls.Add(lblViewLastName)
        Panel2.Controls.Add(lblViewFirstName)
        Panel2.Controls.Add(lblViewID)
        Panel2.Location = New Point(488, 63)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(254, 274)
        Panel2.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 239)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 15)
        Label7.TabIndex = 11
        Label7.Text = "Preferences:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(13, 196)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 10
        Label8.Text = "Phone:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 154)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 9
        Label9.Text = "Email:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(13, 110)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 15)
        Label10.TabIndex = 8
        Label10.Text = "LastName:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(13, 68)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 15)
        Label11.TabIndex = 7
        Label11.Text = "FirstName:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(13, 26)
        Label12.Name = "Label12"
        Label12.Size = New Size(56, 15)
        Label12.TabIndex = 6
        Label12.Text = "GuestID:"
        ' 
        ' lblViewPreferences
        ' 
        lblViewPreferences.AutoSize = True
        lblViewPreferences.Location = New Point(101, 239)
        lblViewPreferences.Name = "lblViewPreferences"
        lblViewPreferences.Size = New Size(0, 15)
        lblViewPreferences.TabIndex = 5
        ' 
        ' lblViewPhone
        ' 
        lblViewPhone.AutoSize = True
        lblViewPhone.Location = New Point(101, 196)
        lblViewPhone.Name = "lblViewPhone"
        lblViewPhone.Size = New Size(0, 15)
        lblViewPhone.TabIndex = 4
        ' 
        ' lblViewEmail
        ' 
        lblViewEmail.AutoSize = True
        lblViewEmail.Location = New Point(101, 154)
        lblViewEmail.Name = "lblViewEmail"
        lblViewEmail.Size = New Size(0, 15)
        lblViewEmail.TabIndex = 3
        ' 
        ' lblViewLastName
        ' 
        lblViewLastName.AutoSize = True
        lblViewLastName.Location = New Point(101, 110)
        lblViewLastName.Name = "lblViewLastName"
        lblViewLastName.Size = New Size(0, 15)
        lblViewLastName.TabIndex = 2
        ' 
        ' lblViewFirstName
        ' 
        lblViewFirstName.AutoSize = True
        lblViewFirstName.Location = New Point(101, 68)
        lblViewFirstName.Name = "lblViewFirstName"
        lblViewFirstName.Size = New Size(0, 15)
        lblViewFirstName.TabIndex = 1
        ' 
        ' lblViewID
        ' 
        lblViewID.AutoSize = True
        lblViewID.Location = New Point(101, 26)
        lblViewID.Name = "lblViewID"
        lblViewID.Size = New Size(0, 15)
        lblViewID.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ControlDark
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.ButtonHighlight
        btnClear.Location = New Point(611, 8)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(116, 36)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear Form"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Cursor = Cursors.IBeam
        txtEmail.Location = New Point(133, 145)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(320, 28)
        txtEmail.TabIndex = 7
        txtEmail.Text = ""
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Cursor = Cursors.IBeam
        txtLastName.Location = New Point(133, 101)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(320, 28)
        txtLastName.TabIndex = 8
        txtLastName.Text = ""
        ' 
        ' txtGuestID
        ' 
        txtGuestID.BackColor = SystemColors.Menu
        txtGuestID.BorderStyle = BorderStyle.FixedSingle
        txtGuestID.Cursor = Cursors.IBeam
        txtGuestID.Location = New Point(133, 17)
        txtGuestID.Name = "txtGuestID"
        txtGuestID.Size = New Size(181, 28)
        txtGuestID.TabIndex = 9
        txtGuestID.Text = ""
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Cursor = Cursors.IBeam
        txtPhone.Location = New Point(133, 187)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(320, 28)
        txtPhone.TabIndex = 10
        txtPhone.Text = ""
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Cursor = Cursors.IBeam
        txtFirstName.Location = New Point(133, 59)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(320, 28)
        txtFirstName.TabIndex = 11
        txtFirstName.Text = ""
        ' 
        ' txtPreferences
        ' 
        txtPreferences.Location = New Point(133, 230)
        txtPreferences.Name = "txtPreferences"
        txtPreferences.Size = New Size(320, 28)
        txtPreferences.TabIndex = 12
        txtPreferences.Text = ""
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(label2)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(txtFirstName)
        Panel3.Controls.Add(txtPreferences)
        Panel3.Controls.Add(txtEmail)
        Panel3.Controls.Add(txtLastName)
        Panel3.Controls.Add(txtPhone)
        Panel3.Controls.Add(txtGuestID)
        Panel3.Location = New Point(12, 63)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(465, 274)
        Panel3.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(21, 234)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 21)
        Label6.TabIndex = 18
        Label6.Text = "Preferences:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(22, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 21)
        Label5.TabIndex = 17
        Label5.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(22, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 21)
        Label4.TabIndex = 16
        Label4.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(22, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 21)
        Label3.TabIndex = 15
        Label3.Text = "LastName:"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        label2.Location = New Point(22, 66)
        label2.Name = "label2"
        label2.Size = New Size(88, 21)
        label2.TabIndex = 14
        label2.Text = "FirstName:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(22, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 21)
        Label1.TabIndex = 13
        Label1.Text = "GuestID:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 403)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(730, 219)
        DataGridView1.TabIndex = 14
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ControlDarkDark
        Panel4.Controls.Add(btnClear)
        Panel4.Controls.Add(btnAdd)
        Panel4.Controls.Add(btnSearch)
        Panel4.Controls.Add(btnDelete)
        Panel4.Controls.Add(btnUpdate)
        Panel4.Location = New Point(12, 343)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(730, 54)
        Panel4.TabIndex = 15
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.PaleTurquoise
        Label13.Font = New Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(56, 5)
        Label13.Name = "Label13"
        Label13.Size = New Size(333, 38)
        Label13.TabIndex = 0
        Label13.Text = "Bayview Suites Hotel"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(754, 634)
        Controls.Add(Panel4)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Bayview Suites Hotel"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents txtEmail As RichTextBox
    Friend WithEvents txtLastName As RichTextBox
    Friend WithEvents txtGuestID As RichTextBox
    Friend WithEvents txtPhone As RichTextBox
    Friend WithEvents txtFirstName As RichTextBox
    Friend WithEvents txtPreferences As RichTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblViewPreferences As Label
    Friend WithEvents lblViewPhone As Label
    Friend WithEvents lblViewEmail As Label
    Friend WithEvents lblViewLastName As Label
    Friend WithEvents lblViewFirstName As Label
    Friend WithEvents lblViewID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label

End Class
