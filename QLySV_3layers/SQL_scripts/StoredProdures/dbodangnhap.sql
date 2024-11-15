USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 10/1/2024 2:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[dangnhap]
	@loaitaikhoan varchar(10),
	@taikhoan varchar(50),
	@matkhau varchar(50)
as
begin
	if @loaitaikhoan = 'admin'
			select *
			from tblTaiKhoan
			where tentaikhoan = @taikhoan
			and  matkhau = @matkhau
	else if @loaitaikhoan = 'gv'
			select *
			from tblGiaoVien
			where CONVERT(varchar(50),magiaovien) = @taikhoan
			and matkhau = @matkhau
	else
			select * 
			from tblSinhVien
			where masinhvien = @taikhoan
			and matkhau = @matkhau;
end