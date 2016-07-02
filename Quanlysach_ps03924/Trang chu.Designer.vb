<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trang_chu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trang_chu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThưViệnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThanhToánHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThưViệnToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.HóaĐơnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThưViệnToolStripMenuItem
        '
        Me.ThưViệnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoạiSáchToolStripMenuItem, Me.SáchToolStripMenuItem})
        Me.ThưViệnToolStripMenuItem.Name = "ThưViệnToolStripMenuItem"
        Me.ThưViệnToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ThưViệnToolStripMenuItem.Text = "Thư viện"
        '
        'LoạiSáchToolStripMenuItem
        '
        Me.LoạiSáchToolStripMenuItem.Name = "LoạiSáchToolStripMenuItem"
        Me.LoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoạiSáchToolStripMenuItem.Text = "Loại sách"
        '
        'SáchToolStripMenuItem
        '
        Me.SáchToolStripMenuItem.Name = "SáchToolStripMenuItem"
        Me.SáchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SáchToolStripMenuItem.Text = "Sách"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýKháchHàngToolStripMenuItem})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'QuảnLýKháchHàngToolStripMenuItem
        '
        Me.QuảnLýKháchHàngToolStripMenuItem.Name = "QuảnLýKháchHàngToolStripMenuItem"
        Me.QuảnLýKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.QuảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThanhToánHóaĐơnToolStripMenuItem})
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'ThanhToánHóaĐơnToolStripMenuItem
        '
        Me.ThanhToánHóaĐơnToolStripMenuItem.Name = "ThanhToánHóaĐơnToolStripMenuItem"
        Me.ThanhToánHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ThanhToánHóaĐơnToolStripMenuItem.Text = "Thanh toán hóa đơn"
        '
        'Trang_chu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 366)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Trang_chu"
        Me.Text = "Trang_chu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThưViệnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoạiSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýKháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThanhToánHóaĐơnToolStripMenuItem As ToolStripMenuItem
End Class
