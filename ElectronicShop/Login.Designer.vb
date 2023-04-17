<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Log_in = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.errorMsg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Admin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Log_in
        '
        Me.Log_in.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Log_in.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Log_in.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Log_in.FlatAppearance.BorderSize = 0
        Me.Log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Log_in.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Log_in.Location = New System.Drawing.Point(318, 283)
        Me.Log_in.Margin = New System.Windows.Forms.Padding(4)
        Me.Log_in.Name = "Log_in"
        Me.Log_in.Size = New System.Drawing.Size(101, 38)
        Me.Log_in.TabIndex = 1
        Me.Log_in.Text = "Log In"
        Me.Log_in.UseVisualStyleBackColor = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.PasswordTextBox.Location = New System.Drawing.Point(151, 241)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(268, 26)
        Me.PasswordTextBox.TabIndex = 2
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.UsernameTextBox.Location = New System.Drawing.Point(151, 170)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(20)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(268, 26)
        Me.UsernameTextBox.TabIndex = 3
        '
        'errorMsg
        '
        Me.errorMsg.AutoSize = True
        Me.errorMsg.Font = New System.Drawing.Font("Courier New", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorMsg.ForeColor = System.Drawing.Color.Red
        Me.errorMsg.Location = New System.Drawing.Point(197, 120)
        Me.errorMsg.Name = "errorMsg"
        Me.errorMsg.Size = New System.Drawing.Size(182, 16)
        Me.errorMsg.TabIndex = 4
        Me.errorMsg.Text = "Invalid username/password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(573, 343)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.errorMsg)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Log_in)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(589, 382)
        Me.MinimumSize = New System.Drawing.Size(589, 382)
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(50)
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Log_in As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents errorMsg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
