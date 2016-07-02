Imports System.Data.SqlClient
Public Class Theloai
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLy-Sach.mssql.somee.com;packet size=4096;user id=ngahuynh0812_SQLLogin_1;pwd=mpsa76lc41;data source=QuanLy-Sach.mssql.somee.com;persist security info=False;initial catalog=QuanLy-Sach"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim loaisach As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into LOAISACH values(@MATHELOAI,@TENTHELOAI)"
        Dim save As SqlCommand = New SqlCommand(query, loaisach)
        loaisach.Open()
        Try
            txtmatheloai.Focus()
            If txtmatheloai.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmatheloai.Focus()
                If txttentheloai.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    save.Parameters.AddWithValue("@MATL", txtmatheloai.Text)
                    save.Parameters.AddWithValue("@TEN", txttentheloai.Text)
                    save.ExecuteNonQuery()
                    MessageBox.Show("Lưu thành công")
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                    txtmatheloai.Text = Nothing
                    txttentheloai.Text = Nothing

                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã thể loại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MATHELOAI as 'Mã Thể Loại', TENTHELOAI as 'Tên Thể Loại' from LOAISACH", loaisach)
        db.Clear()
        refesh.Fill(db)
        dvgloai.DataSource = db.DefaultView
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update LOAISACH set MATL= @MATHELOAI,TENTL=@TENTHELOAI"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmatheloai.Focus()
            If txtmatheloai.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmatheloai.Focus()
                If txttentheloai.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Tên Thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txttentheloai.Focus()
                    addupdate.Parameters.AddWithValue("@MA_KH", txtmatheloai.Text)
                    addupdate.Parameters.AddWithValue("@HO_TEN", txttentheloai.Text)
                    addupdate.ExecuteNonQuery()
                    conn.Close() 'đóng kết nối
                    MessageBox.Show("Cập nhật thành công")
                    txtmatheloai.Text = Nothing
                    txttentheloai.Text = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dvgloai.DataSource = db
        dvgloai.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Throw New NotImplementedException()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        If txtmatheloai.Text = "" Then
            MessageBox.Show("Nhap MaTL cần xóa")
            txtmatheloai.Focus()
        Else
            Dim delquery As String = "delete from THELOAI where MaTL=@MATL"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult
            resulft = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MATL", txtmatheloai.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub bttimKiếm_Click(sender As Object, e As EventArgs) Handles bttimKiếm.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MATHELOAI as 'Mã Thể loại',TENTHELOAI as 'Tên Thể loại'FROM LOAISACH where MATHELOAI= '" & txtmatheloai.Text & "'", connect)
        Try
            If txtmatheloai.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã the loai", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dvgloai.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dvgloai.DataSource = db.DefaultView
                    txtmatheloai.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtmatheloai.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dvgloai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgloai.CellContentClick
        Dim click As Integer = dvgloai.CurrentCell.RowIndex
        txtmatheloai.Text = dvgloai.Item(0, click).Value
        txttentheloai.Text = dvgloai.Item(1, click).Value
    End Sub
End Class