USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[selectGV]    Script Date: 10/1/2024 2:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[selectGV]
	@magiaovien int
	--@ho nvarchar(10),
	--@tendem nvarchar(20),
	--@ten nvarchar(10
as 
begin
	select
		ho,
		tendem,
		ten,
		gioitinh,
		convert(varchar(10), ngaysinh, 103) ngsinh,
		dienthoai,
		email, diachi
	from tblGiaoVien
	where magiaovien = @magiaovien;
end