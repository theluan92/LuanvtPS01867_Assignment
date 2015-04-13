<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmType))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTypecode = New System.Windows.Forms.TextBox()
        Me.txtTypeName = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.dgrView2 = New System.Windows.Forms.DataGridView()
        CType(Me.dgrView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã loại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên loại:"
        '
        'txtTypecode
        '
        Me.txtTypecode.Location = New System.Drawing.Point(65, 28)
        Me.txtTypecode.Name = "txtTypecode"
        Me.txtTypecode.Size = New System.Drawing.Size(361, 20)
        Me.txtTypecode.TabIndex = 2
        '
        'txtTypeName
        '
        Me.txtTypeName.Location = New System.Drawing.Point(65, 68)
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Size = New System.Drawing.Size(361, 20)
        Me.txtTypeName.TabIndex = 3
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadd.Location = New System.Drawing.Point(65, 114)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 53)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "Thêm"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.Location = New System.Drawing.Point(159, 114)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 53)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "Sửa"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.SteelBlue
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.Location = New System.Drawing.Point(256, 114)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 53)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "Xóa"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Image = CType(resources.GetObject("btnexit.Image"), System.Drawing.Image)
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexit.Location = New System.Drawing.Point(351, 114)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 53)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Đóng"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'dgrView2
        '
        Me.dgrView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrView2.Location = New System.Drawing.Point(19, 191)
        Me.dgrView2.Name = "dgrView2"
        Me.dgrView2.Size = New System.Drawing.Size(407, 150)
        Me.dgrView2.TabIndex = 5
        '
        'frmType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(446, 385)
        Me.Controls.Add(Me.dgrView2)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.txtTypecode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmType"
        Me.Text = "Type"
        CType(Me.dgrView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTypecode As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeName As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents dgrView2 As System.Windows.Forms.DataGridView
End Class
