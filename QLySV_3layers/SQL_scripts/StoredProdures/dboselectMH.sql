USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[selectMH]    Script Date: 10/1/2024 2:35:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[selectMH]
	@mamonhoc int
as
begin
	select
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc = @mamonhoc;
end