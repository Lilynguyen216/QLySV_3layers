USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllSinhVien]    Script Date: 10/1/2024 2:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectAllSinhVien]
	@tukhoa nvarchar(50)
AS
	select 
		masinhvien,
		case
			when LEN(tendem) > 0 then	
				CONCAT(ho, ' ', tendem, ' ', ten)
			else CONCAT (ho, ' ',ten)
		end as hoten,
		CONVERT(varchar(10),ngaysinh,103) as nsinh,
		case
			when gioitinh = 1 then N'Nam'
			else N'Nữ'
		end as gt,
		quequan,
		diachi,
		dienthoai,
		email
	from tblSinhVien
	where 
		lower(ho) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(tendem) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(ten) like '%' + lower(trim(@tukhoa)) + '%'
		or dienthoai like '%' + lower(trim(@tukhoa)) + '%'
	order by ten;