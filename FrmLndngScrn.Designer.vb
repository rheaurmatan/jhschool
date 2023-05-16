<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLndngScrn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLndngScrn))
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.btnFees = New System.Windows.Forms.Button()
        Me.btnSwitch0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignO = New System.Windows.Forms.Button()
        Me.btnBackupdb = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(49, 241)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(87, 41)
        Me.btnProfile.TabIndex = 0
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnGrade
        '
        Me.btnGrade.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrade.Location = New System.Drawing.Point(222, 241)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(92, 41)
        Me.btnGrade.TabIndex = 1
        Me.btnGrade.Text = "Grades"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'btnFees
        '
        Me.btnFees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFees.Location = New System.Drawing.Point(426, 241)
        Me.btnFees.Name = "btnFees"
        Me.btnFees.Size = New System.Drawing.Size(110, 41)
        Me.btnFees.TabIndex = 2
        Me.btnFees.Text = "Fees"
        Me.btnFees.UseVisualStyleBackColor = True
        '
        'btnSwitch0
        '
        Me.btnSwitch0.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwitch0.Location = New System.Drawing.Point(660, 335)
        Me.btnSwitch0.Name = "btnSwitch0"
        Me.btnSwitch0.Size = New System.Drawing.Size(110, 30)
        Me.btnSwitch0.TabIndex = 5
        Me.btnSwitch0.Text = "Switch"
        Me.btnSwitch0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 35)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome to JHSchool"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.btnSignO)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 211)
        Me.Panel1.TabIndex = 8
        '
        'btnSignO
        '
        Me.btnSignO.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignO.Location = New System.Drawing.Point(686, 24)
        Me.btnSignO.Name = "btnSignO"
        Me.btnSignO.Size = New System.Drawing.Size(84, 32)
        Me.btnSignO.TabIndex = 9
        Me.btnSignO.Text = "Sign Out"
        Me.btnSignO.UseVisualStyleBackColor = True
        '
        'btnBackupdb
        '
        Me.btnBackupdb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupdb.Location = New System.Drawing.Point(608, 241)
        Me.btnBackupdb.Name = "btnBackupdb"
        Me.btnBackupdb.Size = New System.Drawing.Size(110, 41)
        Me.btnBackupdb.TabIndex = 9
        Me.btnBackupdb.Text = "Back Up"
        Me.btnBackupdb.UseVisualStyleBackColor = True
        '
        'FrmLndngScrn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(782, 390)
        Me.Controls.Add(Me.btnBackupdb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSwitch0)
        Me.Controls.Add(Me.btnFees)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.btnProfile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLndngScrn"
        Me.Text = "JHSchool Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProfile As Button
    Friend WithEvents btnGrade As Button
    Friend WithEvents btnFees As Button
    Friend WithEvents btnSwitch0 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignO As Button
    Friend WithEvents btnBackupdb As Button
End Class
