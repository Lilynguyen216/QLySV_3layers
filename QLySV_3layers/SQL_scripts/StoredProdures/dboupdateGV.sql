USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[updateGV]    Script Date: 10/1/2024 2:36:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[updateGV]
	@nguoicapnhat varchar(30),
	@magiaovien int,
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@dienthoai varchar(30),
	@email varchar(150),
	@diachi nvarchar(150)
as
begin
	update tblGiaoVien
	set
		nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		ho = @ho, tendem = @tendem, ten = @ten,
		gioitinh = @gioitinh, ngaysinh = @ngaysinh,
		dienthoai = @dienthoai, email = @email, diachi = @diachi
	where magiaovien = @magiaovien
end