<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnProductType = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.Black
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.White
        Me.btnProduct.Image = CType(resources.GetObject("btnProduct.Image"), System.Drawing.Image)
        Me.btnProduct.Location = New System.Drawing.Point(16, 421)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(140, 138)
        Me.btnProduct.TabIndex = 1
        Me.btnProduct.Text = "Product Manager"
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnProductType
        '
        Me.btnProductType.BackColor = System.Drawing.Color.Black
        Me.btnProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductType.ForeColor = System.Drawing.Color.White
        Me.btnProductType.Image = CType(resources.GetObject("btnProductType.Image"), System.Drawing.Image)
        Me.btnProductType.Location = New System.Drawing.Point(183, 421)
        Me.btnProductType.Name = "btnProductType"
        Me.btnProductType.Size = New System.Drawing.Size(140, 138)
        Me.btnProductType.TabIndex = 1
        Me.btnProductType.Text = "Product Type"
        Me.btnProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProductType.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(79, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database Management Application"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(856, 523)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(158, 39)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit Application"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1024, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnProductType)
        Me.Controls.Add(Me.btnProduct)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnProductType As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
