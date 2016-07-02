<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quanlykhachhang
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
        Me.dvgkhachhang = New System.Windows.Forms.DataGridView()
        Me.btsua = New System.Windows.Forms.Button()
        Me.bttimkiem = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.txttnkhachhang = New System.Windows.Forms.TextBox()
        Me.txtsodienthoai = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.lbltenkhachhang = New System.Windows.Forms.Label()
        Me.lblsodienthoai = New System.Windows.Forms.Label()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.lblmakhachhang = New System.Windows.Forms.Label()
        Me.btluu = New System.Windows.Forms.Button()
        CType(Me.dvgkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgkhachhang
        '
        Me.dvgkhachhang.BackgroundColor = System.Drawing.Color.Tan
        Me.dvgkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgkhachhang.Location = New System.Drawing.Point(-1, 156)
        Me.dvgkhachhang.Name = "dvgkhachhang"
        Me.dvgkhachhang.Size = New System.Drawing.Size(735, 243)
        Me.dvgkhachhang.TabIndex = 17
        '
        'btsua
        '
        Me.btsua.Location = New System.Drawing.Point(643, 16)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(75, 35)
        Me.btsua.TabIndex = 12
        Me.btsua.Text = "Sửa"
        Me.btsua.UseVisualStyleBackColor = True
        '
        'bttimkiem
        '
        Me.bttimkiem.Location = New System.Drawing.Point(244, 106)
        Me.bttimkiem.Name = "bttimkiem"
        Me.bttimkiem.Size = New System.Drawing.Size(156, 35)
        Me.bttimkiem.TabIndex = 13
        Me.bttimkiem.Text = "Tìm Kiếm"
        Me.bttimkiem.UseVisualStyleBackColor = True
        '
        'btxoa
        '
        Me.btxoa.Location = New System.Drawing.Point(545, 71)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 35)
        Me.btxoa.TabIndex = 15
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Location = New System.Drawing.Point(545, 16)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(75, 35)
        Me.btthem.TabIndex = 16
        Me.btthem.Text = "Thêm"
        Me.btthem.UseVisualStyleBackColor = True
        '
        'txttnkhachhang
        '
        Me.txttnkhachhang.Location = New System.Drawing.Point(116, 68)
        Me.txttnkhachhang.Name = "txttnkhachhang"
        Me.txttnkhachhang.Size = New System.Drawing.Size(166, 20)
        Me.txttnkhachhang.TabIndex = 8
        '
        'txtsodienthoai
        '
        Me.txtsodienthoai.Location = New System.Drawing.Point(371, 19)
        Me.txtsodienthoai.Name = "txtsodienthoai"
        Me.txtsodienthoai.Size = New System.Drawing.Size(156, 20)
        Me.txtsodienthoai.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(371, 64)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(156, 20)
        Me.txtemail.TabIndex = 10
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Location = New System.Drawing.Point(116, 16)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.Size = New System.Drawing.Size(145, 20)
        Me.txtmakhachhang.TabIndex = 11
        '
        'lbltenkhachhang
        '
        Me.lbltenkhachhang.AutoSize = True
        Me.lbltenkhachhang.Location = New System.Drawing.Point(26, 71)
        Me.lbltenkhachhang.Name = "lbltenkhachhang"
        Me.lbltenkhachhang.Size = New System.Drawing.Size(89, 13)
        Me.lbltenkhachhang.TabIndex = 4
        Me.lbltenkhachhang.Text = "Tên Khách Hàng"
        '
        'lblsodienthoai
        '
        Me.lblsodienthoai.AutoSize = True
        Me.lblsodienthoai.Location = New System.Drawing.Point(290, 23)
        Me.lblsodienthoai.Name = "lblsodienthoai"
        Me.lblsodienthoai.Size = New System.Drawing.Size(75, 13)
        Me.lblsodienthoai.TabIndex = 5
        Me.lblsodienthoai.Text = "Số Điện Thoại"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Location = New System.Drawing.Point(311, 71)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(32, 13)
        Me.lblmail.TabIndex = 6
        Me.lblmail.Text = "Email"
        '
        'lblmakhachhang
        '
        Me.lblmakhachhang.AutoSize = True
        Me.lblmakhachhang.Location = New System.Drawing.Point(26, 19)
        Me.lblmakhachhang.Name = "lblmakhachhang"
        Me.lblmakhachhang.Size = New System.Drawing.Size(84, 13)
        Me.lblmakhachhang.TabIndex = 7
        Me.lblmakhachhang.Text = "Mã khách Hàng"
        '
        'btluu
        '
        Me.btluu.Location = New System.Drawing.Point(647, 73)
        Me.btluu.Name = "btluu"
        Me.btluu.Size = New System.Drawing.Size(70, 32)
        Me.btluu.TabIndex = 18
        Me.btluu.Text = "Lưu"
        Me.btluu.UseVisualStyleBackColor = True
        '
        'Quanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(734, 401)
        Me.Controls.Add(Me.btluu)
        Me.Controls.Add(Me.dvgkhachhang)
        Me.Controls.Add(Me.btsua)
        Me.Controls.Add(Me.bttimkiem)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.txttnkhachhang)
        Me.Controls.Add(Me.txtsodienthoai)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtmakhachhang)
        Me.Controls.Add(Me.lbltenkhachhang)
        Me.Controls.Add(Me.lblsodienthoai)
        Me.Controls.Add(Me.lblmail)
        Me.Controls.Add(Me.lblmakhachhang)
        Me.Name = "Quanlykhachhang"
        Me.Text = "Quanlykhachhang"
        CType(Me.dvgkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgkhachhang As DataGridView
    Friend WithEvents btsua As Button
    Friend WithEvents bttimkiem As Button
    Friend WithEvents btxoa As Button
    Friend WithEvents btthem As Button
    Friend WithEvents txttnkhachhang As TextBox
    Friend WithEvents txtsodienthoai As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtmakhachhang As TextBox
    Friend WithEvents lbltenkhachhang As Label
    Friend WithEvents lblsodienthoai As Label
    Friend WithEvents lblmail As Label
    Friend WithEvents lblmakhachhang As Label
    Friend WithEvents btluu As Button
End Class
