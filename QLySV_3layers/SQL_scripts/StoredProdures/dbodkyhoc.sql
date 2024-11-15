USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[dkyhoc]    Script Date: 10/1/2024 2:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[dkyhoc]
	@masinhvien varchar(50),
	@malophoc bigint
as
begin
	declare @v_lanhoc int,
			@v_mamonhoc int,
			@v_dadangky int;

	select @v_mamonhoc = mamonhoc
	from tblLopHoc
	where malophoc = @malophoc;

	select @v_lanhoc = count(*)
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	where l.daketthuc = 1
	and d.masinhvien = @masinhvien
	and l.mamonhoc = @v_mamonhoc

	select @v_dadangky = count(*)
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	where l.daketthuc = 0
	and l.mamonhoc = @v_mamonhoc
	and d.masinhvien = @masinhvien;

	if @v_dadangky>0 return -1;

	set @v_lanhoc = @v_lanhoc + 1;

	insert into tblDiem(nguoitao, masinhvien, malophoc,lanhoc)
	values (@masinhvien,@masinhvien,@malophoc,@v_lanhoc);
	if @@ROWCOUNT > 0 return 1 else return 0;
end
