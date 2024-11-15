USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[insertMH]    Script Date: 10/1/2024 2:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[insertMH]
	@nguoitao varchar(30),
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	insert into tblMonHoc
	(
		mamonhoc,
		tenmonhoc,
		sotinchi
	) values (
		@nguoitao,
		@tenmonhoc,
		@sotinchi
	);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end