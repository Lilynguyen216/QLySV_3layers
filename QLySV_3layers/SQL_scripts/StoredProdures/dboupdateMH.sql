USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[updateMH]    Script Date: 10/1/2024 2:37:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[updateMH]
	@nguoicapnhat varchar(30),
	@mamonhoc int,
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	update tblMonHoc
	set
		nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		tenmonhoc = @tenmonhoc,
		sotinchi = @sotinchi
	where mamonhoc = @mamonhoc;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end