USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[updateLopHoc]    Script Date: 10/1/2024 2:36:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[updateLopHoc]
	@nguoicapnhat varchar(30),
	@malophoc bigint,
	@mamonhoc int,
	@magiaovien int
as
begin
	update tblLopHoc
	set nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		magiaovien = @magiaovien,
		mamonhoc = @mamonhoc
	where malophoc = @malophoc;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end