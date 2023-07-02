<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BT_Bo = New System.Windows.Forms.Button()
        Me.BT_Gop = New System.Windows.Forms.Button()
        Me.BT_Thoat = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dlgFolderSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbdanhsach = New System.Windows.Forms.Label()
        Me.BT_Len = New System.Windows.Forms.Button()
        Me.BT_Xuong = New System.Windows.Forms.Button()
        Me.txtLuu = New System.Windows.Forms.TextBox()
        Me.BT_Luu = New System.Windows.Forms.Button()
        Me.BT_Them = New System.Windows.Forms.Button()
        Me.lbvn = New System.Windows.Forms.Label()
        Me.lbanh = New System.Windows.Forms.Label()
        Me.BT_Xoa = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_Bo
        '
        Me.BT_Bo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Bo.BackColor = System.Drawing.Color.LimeGreen
        Me.BT_Bo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Bo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Bo.ForeColor = System.Drawing.Color.White
        Me.BT_Bo.Location = New System.Drawing.Point(123, 401)
        Me.BT_Bo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Bo.Name = "BT_Bo"
        Me.BT_Bo.Size = New System.Drawing.Size(111, 53)
        Me.BT_Bo.TabIndex = 2
        Me.BT_Bo.Text = "Bỏ bớt"
        Me.BT_Bo.UseVisualStyleBackColor = False
        '
        'BT_Gop
        '
        Me.BT_Gop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Gop.BackColor = System.Drawing.Color.LimeGreen
        Me.BT_Gop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Gop.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Gop.ForeColor = System.Drawing.Color.White
        Me.BT_Gop.Location = New System.Drawing.Point(563, 401)
        Me.BT_Gop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Gop.Name = "BT_Gop"
        Me.BT_Gop.Size = New System.Drawing.Size(111, 53)
        Me.BT_Gop.TabIndex = 6
        Me.BT_Gop.Text = "Gộp"
        Me.BT_Gop.UseVisualStyleBackColor = False
        '
        'BT_Thoat
        '
        Me.BT_Thoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Thoat.BackColor = System.Drawing.Color.LimeGreen
        Me.BT_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Thoat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Thoat.ForeColor = System.Drawing.Color.White
        Me.BT_Thoat.Location = New System.Drawing.Point(672, 401)
        Me.BT_Thoat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Thoat.Name = "BT_Thoat"
        Me.BT_Thoat.Size = New System.Drawing.Size(111, 53)
        Me.BT_Thoat.TabIndex = 7
        Me.BT_Thoat.Text = "Thoát"
        Me.BT_Thoat.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 38)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 10
        Me.DataGridView1.Size = New System.Drawing.Size(769, 322)
        Me.DataGridView1.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbdanhsach
        '
        Me.lbdanhsach.AutoSize = True
        Me.lbdanhsach.BackColor = System.Drawing.Color.Transparent
        Me.lbdanhsach.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdanhsach.ForeColor = System.Drawing.Color.Black
        Me.lbdanhsach.Location = New System.Drawing.Point(11, 22)
        Me.lbdanhsach.Name = "lbdanhsach"
        Me.lbdanhsach.Size = New System.Drawing.Size(579, 13)
        Me.lbdanhsach.TabIndex = 10
        Me.lbdanhsach.Text = "Danh sách các tệp cần nối như Word, Excel, Powerpoint, Image, Pdf (gộp riêng từng" & _
    " loại hoặc hỗn hợp)"
        '
        'BT_Len
        '
        Me.BT_Len.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Len.BackColor = System.Drawing.Color.LimeGreen
        Me.BT_Len.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Len.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Len.ForeColor = System.Drawing.Color.White
        Me.BT_Len.Location = New System.Drawing.Point(234, 401)
        Me.BT_Len.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Len.Name = "BT_Len"
        Me.BT_Len.Size = New System.Drawing.Size(111, 53)
        Me.BT_Len.TabIndex = 3
        Me.BT_Len.Text = "Di chuyển lên"
        Me.BT_Len.UseVisualStyleBackColor = False
        '
        'BT_Xuong
        '
        Me.BT_Xuong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Xuong.BackColor = System.Drawing.Color.LimeGreen
        Me.BT_Xuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Xuong.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Xuong.ForeColor = System.Drawing.Color.White
        Me.BT_Xuong.Location = New System.Drawing.Point(343, 401)
        Me.BT_Xuong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Xuong.Name = "BT_Xuong"
        Me.BT_Xuong.Size = New System.Drawing.Size(111, 53)
        Me.BT_Xuong.TabIndex = 4
        Me.BT_Xuong.Text = "Di chuyển xuống"
        Me.BT_Xuong.UseVisualStyleBackColor = False
        '
        'txtLuu
        '
        Me.txtLuu.BackColor = System.Drawing.Color.Orange
        Me.txtLuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLuu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuu.ForeColor = System.Drawing.Color.Black
        Me.txtLuu.Location = New System.Drawing.Point(234, 360)
        Me.txtLuu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLuu.Name = "txtLuu"
        Me.txtLuu.ReadOnly = True
        Me.txtLuu.Size = New System.Drawing.Size(330, 21)
        Me.txtLuu.TabIndex = 12
        '
        'BT_Luu
        '
        Me.BT_Luu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Luu.BackColor = System.Drawing.Color.Black
        Me.BT_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Luu.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Luu.ForeColor = System.Drawing.Color.White
        Me.BT_Luu.Location = New System.Drawing.Point(563, 360)
        Me.BT_Luu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Luu.Name = "BT_Luu"
        Me.BT_Luu.Size = New System.Drawing.Size(220, 23)
        Me.BT_Luu.TabIndex = 0
        Me.BT_Luu.Text = "Chọn đường dẫn để lưu"
        Me.BT_Luu.UseVisualStyleBackColor = False
        '
        'BT_Them
        '
        Me.BT_Them.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Them.BackColor = System.Drawing.Color.LimeGreen
        Me.BT_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Them.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Them.ForeColor = System.Drawing.Color.White
        Me.BT_Them.Location = New System.Drawing.Point(14, 401)
        Me.BT_Them.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Them.Name = "BT_Them"
        Me.BT_Them.Size = New System.Drawing.Size(111, 53)
        Me.BT_Them.TabIndex = 1
        Me.BT_Them.Text = "Thêm..."
        Me.BT_Them.UseVisualStyleBackColor = False
        '
        'lbvn
        '
        Me.lbvn.AutoSize = True
        Me.lbvn.BackColor = System.Drawing.Color.Transparent
        Me.lbvn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbvn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbvn.Location = New System.Drawing.Point(652, 8)
        Me.lbvn.Name = "lbvn"
        Me.lbvn.Size = New System.Drawing.Size(77, 14)
        Me.lbvn.TabIndex = 8
        Me.lbvn.Text = "Vietnamese"
        '
        'lbanh
        '
        Me.lbanh.AutoSize = True
        Me.lbanh.BackColor = System.Drawing.Color.Transparent
        Me.lbanh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbanh.ForeColor = System.Drawing.Color.Black
        Me.lbanh.Location = New System.Drawing.Point(736, 8)
        Me.lbanh.Name = "lbanh"
        Me.lbanh.Size = New System.Drawing.Size(50, 14)
        Me.lbanh.TabIndex = 9
        Me.lbanh.Text = "English"
        '
        'BT_Xoa
        '
        Me.BT_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Xoa.BackColor = System.Drawing.Color.LimeGreen
        Me.BT_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Xoa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Xoa.ForeColor = System.Drawing.Color.White
        Me.BT_Xoa.Location = New System.Drawing.Point(452, 401)
        Me.BT_Xoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Xoa.Name = "BT_Xoa"
        Me.BT_Xoa.Size = New System.Drawing.Size(111, 53)
        Me.BT_Xoa.TabIndex = 5
        Me.BT_Xoa.Text = "Xoá danh sách"
        Me.BT_Xoa.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar1.Location = New System.Drawing.Point(-3, 462)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(809, 14)
        Me.ProgressBar1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 22)
        Me.Label1.TabIndex = 25
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Black
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(31, 363)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 15)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "Sửa kích thước trang"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(798, 472)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BT_Xoa)
        Me.Controls.Add(Me.lbanh)
        Me.Controls.Add(Me.lbvn)
        Me.Controls.Add(Me.BT_Luu)
        Me.Controls.Add(Me.txtLuu)
        Me.Controls.Add(Me.BT_Xuong)
        Me.Controls.Add(Me.BT_Len)
        Me.Controls.Add(Me.lbdanhsach)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BT_Thoat)
        Me.Controls.Add(Me.BT_Gop)
        Me.Controls.Add(Me.BT_Bo)
        Me.Controls.Add(Me.BT_Them)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Merge to PDF Pro v2.0                             Code by: Trần Quốc Minh_GV Trườ" & _
    "ng THPT Văn Hiến, TP Long Khánh, Tỉnh Đồng Nai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_Them As System.Windows.Forms.Button
    Friend WithEvents BT_Bo As System.Windows.Forms.Button
    Friend WithEvents BT_Gop As System.Windows.Forms.Button
    Friend WithEvents BT_Thoat As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgFolderSelect As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbdanhsach As System.Windows.Forms.Label
    Friend WithEvents BT_Len As System.Windows.Forms.Button
    Friend WithEvents BT_Xuong As System.Windows.Forms.Button
    Friend WithEvents txtLuu As System.Windows.Forms.TextBox
    Friend WithEvents BT_Luu As System.Windows.Forms.Button
    Friend WithEvents lbvn As System.Windows.Forms.Label
    Friend WithEvents lbanh As System.Windows.Forms.Label
    Friend WithEvents BT_Xoa As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
