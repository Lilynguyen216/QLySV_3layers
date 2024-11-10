USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[insertLopHoc]    Script Date: 10/1/2024 2:29:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[insertLopHoc]
	@nguoitao varchar(30),
	@mamonhoc int,
	@magiaovien int
as
begin
	insert into tblLopHoc(nguoitao,mamonhoc,magiaovien)
	values (@nguoitao,@mamonhoc,@magiaovien);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end