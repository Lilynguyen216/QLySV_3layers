USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[selectAllGV]    Script Date: 10/1/2024 2:33:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[selectAllGV]
	@tukhoa nvarchar(50)
as
begin
	select
		magiaovien,
		case
			when len(tendem)>0 then concat (ho,' ',tendem,' ', ten)
		else concat(ho,' ',ten)
		end as hoten,
		case when gioitinh = 1 then 'Nam'
		else N'Nữ' end as gt,
		dienthoai,
		email,
		diachi
	from tblGiaoVien
	where lower(concat(ho,' ',tendem,' ',ten)) like '%'+lower(trim(@tukhoa))+'%'
	or lower(ho) like '%'+lower(trim(@tukhoa))+'%'
	or lower(tendem) like '%'+lower(trim(@tukhoa))+'%'
	or lower(ten) like '%'+lower(trim(@tukhoa))+'%'
	or dienthoai like '%'+lower(trim(@tukhoa))+'%'
	or cast(magiaovien as varchar(30)) like '%'+lower(trim(@tukhoa))+'%'
	or lower(email) like '%' + lower(trim(@tukhoa))+'%'
	order by ten;
end