USE [QLySV]
GO
/****** Object:  StoredProcedure [dbo].[ThemMoiSV]    Script Date: 10/1/2024 2:36:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ThemMoiSV]
	@Ho nvarchar(10),
	@Tendem nvarchar(20),
	@Ten nvarchar(10),
	@Ngaysinh date,
	@Gioitinh tinyint,
	@Quequan nvarchar(150),
	@Diachi nvarchar(150),
	@Dienthoai varchar(30),
	@Email varchar(150)
AS
BEGIN
	INSERT INTO tblSinhVien
	(
		masinhvien,
		ho, tendem, ten,
		ngaysinh, gioitinh,
		quequan, diachi,
		dienthoai, email
	) VALUES (
		'19SV' + CAST(NEXT VALUE FOR sinhvienSeq as varchar(30)),
		@Ho, @Tendem, @Ten, 
		@Ngaysinh, 
		@Gioitinh,
		@Quequan, @Diachi,
		@Dienthoai, @Email
	);

	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;

END