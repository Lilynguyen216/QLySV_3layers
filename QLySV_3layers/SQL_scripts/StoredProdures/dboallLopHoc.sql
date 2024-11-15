USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[allLopHoc]    Script Date: 10/1/2024 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[allLopHoc]
	@tukhoa nvarchar(50)
as
begin
	select
		l.malophoc,
		case when len(trim(g.tendem)) > 0 then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as gv,
		m.tenmonhoc
	from tblLopHoc l
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	where lower(m.tenmonhoc) like '%'+lower(@tukhoa)+'%'
	or lower(g.ten) like '%'+lower(@tukhoa)+'%'
	or lower(g.tendem) like '%'+lower(@tukhoa)+'%'
	or lower(g.ho) like '%'+lower(@tukhoa)+'%'
	or lower(concat(g.ho,' ',g.tendem,' ',g.ten)) like '%'+lower(@tukhoa)+'%';
end