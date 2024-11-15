USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[monDaDKy]    Script Date: 10/1/2024 2:33:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[monDaDKy]
	@masinhvien varchar(30)
as
begin
	select
		l.malophoc,
		m.tenmonhoc,
		case when len(trim(g.tendem)) > 0 then concat (g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as gvien,
		m.sotinchi,
		d.diemthilan1,
		d.diemthilan2
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	where l.daketthuc = 0
	and d.masinhvien = @masinhvien;
end