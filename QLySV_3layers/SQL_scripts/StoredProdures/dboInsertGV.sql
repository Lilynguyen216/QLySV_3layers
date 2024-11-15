USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[InsertGV]    Script Date: 10/1/2024 2:28:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[InsertGV]
	@nguoitao varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@dienthoai varchar(30),
	@email varchar(150),
	@diachi nvarchar(150)
as
begin
	insert into tblGiaoVien
	(
		nguoitao,
		ho,tendem,ten,
		gioitinh,ngaysinh,
		dienthoai,email,diachi
	) VALUES (
		@nguoitao,
		@ho,@tendem,@ten,
		@gioitinh,@ngaysinh,
		@dienthoai,@email,@diachi
	);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end