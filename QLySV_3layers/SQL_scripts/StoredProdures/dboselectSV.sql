USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[selectSV]    Script Date: 10/1/2024 2:35:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[selectSV]
	@masinhvien varchar(50)
AS
BEGIN
	SELECT
		ho, tendem, ten, convert(varchar(10), ngaysinh, 103) as ngsinh,
		gioitinh,
		quequan, diachi, dienthoai, email
	FROM tblSinhVien
	WHERE masinhvien = @masinhvien;
END