<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStFs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStFs))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddFee = New System.Windows.Forms.Button()
        Me.btnFeeMd = New System.Windows.Forms.Button()
        Me.btnFeeDel = New System.Windows.Forms.Button()
        Me.btnFeeCncl = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Fee Record"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGreen
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(34, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 83)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "idfees"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Issued Date"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Student ID no."
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tuition Fee"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Other Fees"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total Fees"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Semester"
        Me.Column7.Name = "Column7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'btnAddFee
        '
        Me.btnAddFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFee.Location = New System.Drawing.Point(45, 223)
        Me.btnAddFee.Name = "btnAddFee"
        Me.btnAddFee.Size = New System.Drawing.Size(129, 37)
        Me.btnAddFee.TabIndex = 3
        Me.btnAddFee.Text = "Add Record"
        Me.btnAddFee.UseVisualStyleBackColor = True
        '
        'btnFeeMd
        '
        Me.btnFeeMd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeeMd.Location = New System.Drawing.Point(235, 223)
        Me.btnFeeMd.Name = "btnFeeMd"
        Me.btnFeeMd.Size = New System.Drawing.Size(119, 37)
        Me.btnFeeMd.TabIndex = 4
        Me.btnFeeMd.Text = "Modify Record"
        Me.btnFeeMd.UseVisualStyleBackColor = True
        '
        'btnFeeDel
        '
        Me.btnFeeDel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeeDel.Location = New System.Drawing.Point(507, 223)
        Me.btnFeeDel.Name = "btnFeeDel"
        Me.btnFeeDel.Size = New System.Drawing.Size(122, 37)
        Me.btnFeeDel.TabIndex = 5
        Me.btnFeeDel.Text = "Delete Record"
        Me.btnFeeDel.UseVisualStyleBackColor = True
        '
        'btnFeeCncl
        '
        Me.btnFeeCncl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeeCncl.Location = New System.Drawing.Point(690, 223)
        Me.btnFeeCncl.Name = "btnFeeCncl"
        Me.btnFeeCncl.Size = New System.Drawing.Size(87, 37)
        Me.btnFeeCncl.TabIndex = 6
        Me.btnFeeCncl.Text = "Cancel"
        Me.btnFeeCncl.UseVisualStyleBackColor = True
        '
        'FrmStFs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(828, 316)
        Me.Controls.Add(Me.btnFeeCncl)
        Me.Controls.Add(Me.btnFeeDel)
        Me.Controls.Add(Me.btnFeeMd)
        Me.Controls.Add(Me.btnAddFee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStFs"
        Me.Text = "Student Fees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddFee As Button
    Friend WithEvents btnFeeMd As Button
    Friend WithEvents btnFeeDel As Button
    Friend WithEvents btnFeeCncl As Button
End Class
