<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.greetings = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logout = New System.Windows.Forms.Button()
        Me.newOrders = New System.Windows.Forms.Label()
        Me.newOrdersNum = New System.Windows.Forms.Label()
        Me.totalOrders = New System.Windows.Forms.Label()
        Me.totalOrdersNum = New System.Windows.Forms.Label()
        Me.manageOrders = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.manageProducts = New System.Windows.Forms.Button()
        Me.manageClients = New System.Windows.Forms.Button()
        Me.manageEmployees = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'greetings
        '
        Me.greetings.AutoSize = True
        Me.greetings.Font = New System.Drawing.Font("Cascadia Mono", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greetings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.greetings.Location = New System.Drawing.Point(21, 38)
        Me.greetings.Name = "greetings"
        Me.greetings.Size = New System.Drawing.Size(280, 45)
        Me.greetings.TabIndex = 0
        Me.greetings.Text = "Welcome,User!"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.greetings)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 126)
        Me.Panel1.TabIndex = 1
        '
        'Logout
        '
        Me.Logout.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Logout.FlatAppearance.BorderSize = 0
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.Location = New System.Drawing.Point(1151, 15)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(83, 32)
        Me.Logout.TabIndex = 2
        Me.Logout.Text = "Log Out"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'newOrders
        '
        Me.newOrders.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.newOrders.AutoSize = True
        Me.newOrders.Font = New System.Drawing.Font("Cascadia Mono", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.newOrders.Location = New System.Drawing.Point(8, 10)
        Me.newOrders.Name = "newOrders"
        Me.newOrders.Size = New System.Drawing.Size(122, 25)
        Me.newOrders.TabIndex = 2
        Me.newOrders.Text = "New Orders"
        '
        'newOrdersNum
        '
        Me.newOrdersNum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.newOrdersNum.AutoSize = True
        Me.newOrdersNum.Font = New System.Drawing.Font("Cascadia Mono", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newOrdersNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.newOrdersNum.Location = New System.Drawing.Point(99, 67)
        Me.newOrdersNum.Name = "newOrdersNum"
        Me.newOrdersNum.Size = New System.Drawing.Size(31, 35)
        Me.newOrdersNum.TabIndex = 3
        Me.newOrdersNum.Text = "5"
        '
        'totalOrders
        '
        Me.totalOrders.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.totalOrders.AutoSize = True
        Me.totalOrders.Font = New System.Drawing.Font("Cascadia Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.totalOrders.Location = New System.Drawing.Point(3, 10)
        Me.totalOrders.Name = "totalOrders"
        Me.totalOrders.Size = New System.Drawing.Size(144, 25)
        Me.totalOrders.TabIndex = 4
        Me.totalOrders.Text = "Total Orders"
        '
        'totalOrdersNum
        '
        Me.totalOrdersNum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.totalOrdersNum.AutoSize = True
        Me.totalOrdersNum.Font = New System.Drawing.Font("Cascadia Mono", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalOrdersNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.totalOrdersNum.Location = New System.Drawing.Point(84, 67)
        Me.totalOrdersNum.Name = "totalOrdersNum"
        Me.totalOrdersNum.Size = New System.Drawing.Size(63, 35)
        Me.totalOrdersNum.TabIndex = 5
        Me.totalOrdersNum.Text = "200"
        '
        'manageOrders
        '
        Me.manageOrders.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.manageOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.manageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageOrders.Font = New System.Drawing.Font("Cascadia Mono", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.manageOrders.Location = New System.Drawing.Point(20, 38)
        Me.manageOrders.Name = "manageOrders"
        Me.manageOrders.Size = New System.Drawing.Size(179, 56)
        Me.manageOrders.TabIndex = 6
        Me.manageOrders.Text = "Manage Orders"
        Me.manageOrders.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel2.Controls.Add(Me.manageProducts)
        Me.Panel2.Controls.Add(Me.manageEmployees)
        Me.Panel2.Controls.Add(Me.manageClients)
        Me.Panel2.Controls.Add(Me.manageOrders)
        Me.Panel2.Location = New System.Drawing.Point(8, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 484)
        Me.Panel2.TabIndex = 7
        '
        'manageProducts
        '
        Me.manageProducts.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.manageProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.manageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageProducts.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.manageProducts.Location = New System.Drawing.Point(20, 155)
        Me.manageProducts.Name = "manageProducts"
        Me.manageProducts.Size = New System.Drawing.Size(179, 56)
        Me.manageProducts.TabIndex = 6
        Me.manageProducts.Text = "Manage Products"
        Me.manageProducts.UseVisualStyleBackColor = False
        '
        'manageClients
        '
        Me.manageClients.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.manageClients.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.manageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageClients.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageClients.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.manageClients.Location = New System.Drawing.Point(20, 267)
        Me.manageClients.Name = "manageClients"
        Me.manageClients.Size = New System.Drawing.Size(179, 56)
        Me.manageClients.TabIndex = 6
        Me.manageClients.Text = "Manage Clients"
        Me.manageClients.UseVisualStyleBackColor = False
        '
        'manageEmployees
        '
        Me.manageEmployees.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.manageEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.manageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageEmployees.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.manageEmployees.Location = New System.Drawing.Point(20, 382)
        Me.manageEmployees.Name = "manageEmployees"
        Me.manageEmployees.Size = New System.Drawing.Size(179, 56)
        Me.manageEmployees.TabIndex = 6
        Me.manageEmployees.Text = "Manage Employees"
        Me.manageEmployees.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel3.Controls.Add(Me.newOrdersNum)
        Me.Panel3.Controls.Add(Me.newOrders)
        Me.Panel3.Location = New System.Drawing.Point(444, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 144)
        Me.Panel3.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel4.Controls.Add(Me.totalOrders)
        Me.Panel4.Controls.Add(Me.totalOrdersNum)
        Me.Panel4.Location = New System.Drawing.Point(755, 174)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 144)
        Me.Panel4.TabIndex = 8
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Dashboard"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents greetings As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Logout As Button
    Friend WithEvents newOrders As Label
    Friend WithEvents newOrdersNum As Label
    Friend WithEvents totalOrders As Label
    Friend WithEvents totalOrdersNum As Label
    Friend WithEvents manageOrders As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents manageProducts As Button
    Friend WithEvents manageEmployees As Button
    Friend WithEvents manageClients As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
