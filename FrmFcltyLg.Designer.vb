<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFcltyLg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFcltyLg))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFcltyLG = New System.Windows.Forms.Button()
        Me.btnFcltyCncl = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFcltySwtch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddFclty = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Faculty Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'btnFcltyLG
        '
        Me.btnFcltyLG.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFcltyLG.Location = New System.Drawing.Point(302, 194)
        Me.btnFcltyLG.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFcltyLG.Name = "btnFcltyLG"
        Me.btnFcltyLG.Size = New System.Drawing.Size(100, 31)
        Me.btnFcltyLG.TabIndex = 3
        Me.btnFcltyLG.Text = "Log In"
        Me.btnFcltyLG.UseVisualStyleBackColor = True
        '
        'btnFcltyCncl
        '
        Me.btnFcltyCncl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFcltyCncl.Location = New System.Drawing.Point(462, 194)
        Me.btnFcltyCncl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFcltyCncl.Name = "btnFcltyCncl"
        Me.btnFcltyCncl.Size = New System.Drawing.Size(100, 31)
        Me.btnFcltyCncl.TabIndex = 4
        Me.btnFcltyCncl.Text = "Cancel"
        Me.btnFcltyCncl.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(302, 67)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(260, 23)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(302, 119)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(260, 23)
        Me.TextBox3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Student User? Switch here."
        '
        'btnFcltySwtch
        '
        Me.btnFcltySwtch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFcltySwtch.Location = New System.Drawing.Point(435, 286)
        Me.btnFcltySwtch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFcltySwtch.Name = "btnFcltySwtch"
        Me.btnFcltySwtch.Size = New System.Drawing.Size(151, 29)
        Me.btnFcltySwtch.TabIndex = 10
        Me.btnFcltySwtch.Text = "Switch Account"
        Me.btnFcltySwtch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnAddFclty
        '
        Me.btnAddFclty.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFclty.Location = New System.Drawing.Point(111, 194)
        Me.btnAddFclty.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddFclty.Name = "btnAddFclty"
        Me.btnAddFclty.Size = New System.Drawing.Size(143, 31)
        Me.btnAddFclty.TabIndex = 8
        Me.btnAddFclty.Text = "Add Account"
        Me.btnAddFclty.UseVisualStyleBackColor = True
        '
        'FrmFcltyLg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(634, 358)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFcltySwtch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddFclty)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnFcltyCncl)
        Me.Controls.Add(Me.btnFcltyLG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmFcltyLg"
        Me.Text = "Faculty"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFcltyLG As Button
    Friend WithEvents btnFcltyCncl As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFcltySwtch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddFclty As Button
End Class
