Imports System.Data.SqlClient
Public Class ketnoisomee
    Public Function Loadkhachhang() As DataSet
        Dim chuoiketnoi As String = "workstation id=QuanLy-Sach.mssql.somee.com;packet size=4096;user id=ngahuynh0812_SQLLogin_1;pwd=mpsa76lc41;data source=QuanLy-Sach.mssql.somee.com;persist security info=False;initial catalog=QuanLy-Sach"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã Khách Hàng', TENKH as 'Tên Khách Hàng', SDT as 'Số Điện Thoại', Email as 'Email'", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Function Loadtheloai() As DataSet
    Dim chuoiketnoi As String = "workstation id=QL-SACH.mssql.somee.com;packet size=4096;user id=vantoan1996_SQLLogin_1;pwd=m2zj7kx1to;data source=QL-SACH.mssql.somee.com;persist security info=False;initial catalog=QL-SACH"
    Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadTL As New SqlDataAdapter("select MATHELOAI as 'Mã Thể Loại', TENTHELOAI as 'Tên Thể Loại'", theloai)
        Dim db As New DataSet
    theloai.Open()
    LoadTL.Fill(db)
    theloai.Close()
    Return db
End Function
End Class
