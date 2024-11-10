USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[selectLopHoc]    Script Date: 10/1/2024 2:35:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[selectLopHoc]
	@malophoc bigint
as
begin
	select magiaovien, mamonhoc from tblLopHoc
	where malophoc = @malophoc;
end