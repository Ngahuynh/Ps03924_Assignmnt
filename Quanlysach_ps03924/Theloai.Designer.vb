<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Theloai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Theloai))
        Me.lbmatheloai = New System.Windows.Forms.Label()
        Me.lbtentheloai = New System.Windows.Forms.Label()
        Me.txtmatheloai = New System.Windows.Forms.TextBox()
        Me.txttentheloai = New System.Windows.Forms.TextBox()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.bttimKiếm = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.dvgloai = New System.Windows.Forms.DataGridView()
        CType(Me.dvgloai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbmatheloai
        '
        Me.lbmatheloai.AutoSize = True
        Me.lbmatheloai.Location = New System.Drawing.Point(26, 14)
        Me.lbmatheloai.Name = "lbmatheloai"
        Me.lbmatheloai.Size = New System.Drawing.Size(63, 13)
        Me.lbmatheloai.TabIndex = 0
        Me.lbmatheloai.Text = "Mã Thể loại"
        '
        'lbtentheloai
        '
        Me.lbtentheloai.AutoSize = True
        Me.lbtentheloai.Location = New System.Drawing.Point(26, 63)
        Me.lbtentheloai.Name = "lbtentheloai"
        Me.lbtentheloai.Size = New System.Drawing.Size(67, 13)
        Me.lbtentheloai.TabIndex = 0
        Me.lbtentheloai.Text = "Tên Thể loại"
        '
        'txtmatheloai
        '
        Me.txtmatheloai.Location = New System.Drawing.Point(105, 14)
        Me.txtmatheloai.Name = "txtmatheloai"
        Me.txtmatheloai.Size = New System.Drawing.Size(162, 20)
        Me.txtmatheloai.TabIndex = 1
        '
        'txttentheloai
        '
        Me.txttentheloai.Location = New System.Drawing.Point(105, 56)
        Me.txttentheloai.Name = "txttentheloai"
        Me.txttentheloai.Size = New System.Drawing.Size(162, 20)
        Me.txttentheloai.TabIndex = 1
        '
        'btthem
        '
        Me.btthem.Location = New System.Drawing.Point(290, 14)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(74, 32)
        Me.btthem.TabIndex = 2
        Me.btthem.Text = "Thêm"
        Me.btthem.UseVisualStyleBackColor = True
        '
        'btxoa
        '
        Me.btxoa.Location = New System.Drawing.Point(290, 56)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(74, 32)
        Me.btxoa.TabIndex = 2
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'bttimKiếm
        '
        Me.bttimKiếm.Location = New System.Drawing.Point(370, 56)
        Me.bttimKiếm.Name = "bttimKiếm"
        Me.bttimKiếm.Size = New System.Drawing.Size(127, 32)
        Me.bttimKiếm.TabIndex = 2
        Me.bttimKiếm.Text = "Tìm Kiếm"
        Me.bttimKiếm.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(370, 12)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(74, 32)
        Me.btSua.TabIndex = 2
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'dvgloai
        '
        Me.dvgloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgloai.Location = New System.Drawing.Point(29, 94)
        Me.dvgloai.Name = "dvgloai"
        Me.dvgloai.Size = New System.Drawing.Size(484, 193)
        Me.dvgloai.TabIndex = 3
        '
        'Theloai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(551, 299)
        Me.Controls.Add(Me.dvgloai)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.bttimKiếm)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.txttentheloai)
        Me.Controls.Add(Me.txtmatheloai)
        Me.Controls.Add(Me.lbtentheloai)
        Me.Controls.Add(Me.lbmatheloai)
        Me.Name = "Theloai"
        Me.Text = "Theloai"
        CType(Me.dvgloai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbmatheloai As Label
    Friend WithEvents lbtentheloai As Label
    Friend WithEvents txtmatheloai As TextBox
    Friend WithEvents txttentheloai As TextBox
    Friend WithEvents btthem As Button
    Friend WithEvents btxoa As Button
    Friend WithEvents bttimKiếm As Button
    Friend WithEvents btSua As Button
    Friend WithEvents dvgloai As DataGridView
End Class
