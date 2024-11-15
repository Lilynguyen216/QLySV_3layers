USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[selectAllMonHoc]    Script Date: 10/1/2024 2:34:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[selectAllMonHoc]
	@tukhoa nvarchar(30)
as
begin
	select
		mamonhoc,
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc like '%'+ lower(trim(@tukhoa)) + '%'
	or lower(tenmonhoc) like '%'+lower(trim(@tukhoa)) + '%'
	order by tenmonhoc;
end