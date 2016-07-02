Imports System.Data.SqlClient

Public Class Quanlykhachhang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLy-Sach.mssql.somee.com;packet size=4096;user id=ngahuynh0812_SQLLogin_1;pwd=mpsa76lc41;data source=QuanLy-Sach.mssql.somee.com;persist security info=False;initial catalog=QuanLy-Sach"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private dgvkhachhang As Object

    Private Sub bttimkiem_Click(sender As Object, e As EventArgs) Handles bttimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã Khách Hàng', TENKH as 'Tên Khách Hàng', SĐT as 'Số Điện Thoại', Email as 'Email'FROM KHACHHANG where MAKH= '" & txtmakhachhang.Text & "'", connect)
        Try
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã the loai", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvkhachhang.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvkhachhang.DataSource = db.DefaultView
                    txtmakhachhang.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtmakhachhang.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@SĐT,@EMAIL)"
        Dim save As SqlCommand = New SqlCommand(query, theloai)
        theloai.Open()
        Try
            txtmakhachhang.Focus()
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmakhachhang.Focus()
                If txttnkhachhang.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txttnkhachhang.Focus()
                    If txtsodienthoai.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Số Điện Thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtsodienthoai.Focus()
                        If txtemail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập Email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MATL", txtmakhachhang.Text)
                            save.Parameters.AddWithValue("@TEN", txttnkhachhang.Text)
                            save.Parameters.AddWithValue("@TEN", txtsodienthoai.Text)
                            save.Parameters.AddWithValue("@TEN", txtemail.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtmakhachhang.Text = Nothing
                            txttnkhachhang.Text = Nothing
                            txtsodienthoai.Text = Nothing
                            txtemail.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã thể loại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MATL as 'Mã TL', TEN as 'Tên TL' from THELOAI", theloai)
        db.Clear()
        refesh.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
    End Sub

    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TEN KH,  SĐT=@SĐT, Email=@Email where MAKH=@MAKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmakhachhang.Focus()
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmakhachhang.Focus()
                If txttnkhachhang.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txttnkhachhang.Focus()
                    If txtsodienthoai.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtsodienthoai.Focus()
                        If txtemail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập Mail", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MA_KH", txtmakhachhang.Text)
                            addupdate.Parameters.AddWithValue("@HO_TEN", txttnkhachhang.Text)
                            addupdate.Parameters.AddWithValue("@SDT", txtsodienthoai.Text)
                            addupdate.Parameters.AddWithValue("@Mail", txtemail.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtmakhachhang.Text = Nothing
                            txttnkhachhang.Text = Nothing
                            txtsodienthoai.Text = Nothing
                            txtemail.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvkhachhang.DataSource = db
        dgvkhachhang.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Throw New NotImplementedException()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmakhachhang.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_KH", txtmakhachhang.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmakhachhang.Text = Nothing
                    txttnkhachhang.Text = Nothing
                    txtsodienthoai.Text = Nothing
                    txtemail.Text = Nothing
                    txtmakhachhang.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvkhachhang.DataSource = db
        dgvkhachhang.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btluu_Click(sender As Object, e As EventArgs) Handles btluu.Click
        If txtmakhachhang.Text = "" Then
            MessageBox.Show("Chua nhap mã khách hàng")
            txtmakhachhang.Focus()
        ElseIf txttnkhachhang.Text = "" Then
            MessageBox.Show("Chua nhap Tên khách hàng")
            txttnkhachhang.Focus()
        ElseIf txtsodienthoai.Text = "" Then
            MessageBox.Show("Chua nhap Số Điện Thoại")
            txtsodienthoai.Focus()
        ElseIf txtemail.Text = "" Then
            MessageBox.Show("Chua nhap Email")
            txtemail.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into SANPHAM1 values(@MASP,@TENSP,@SOLUONG,@DONGIA)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtmakhachhang.Text)
            save.Parameters.AddWithValue("@TENKH", txttnkhachhang.Text)
            save.Parameters.AddWithValue("@SĐT", txtsodienthoai.Text)
            save.Parameters.AddWithValue("@EMAIL", txtemail.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub dvgkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgkhachhang.CellContentClick
        Dim click As Integer = dgvkhachhang.CurrentCell.RowIndex
        txtmakhachhang.Text = dgvkhachhang.Item(0, click).Value
        txttnkhachhang.Text = dgvkhachhang.Item(1, click).Value
        txtsodienthoai.Text = dgvkhachhang.Item(3, click).Value
        txtemail.Text = dgvkhachhang.Item(4, click).Value
    End Sub
End Class