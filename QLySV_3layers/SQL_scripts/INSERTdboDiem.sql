USE [QLySV]
GO

INSERT INTO [dbo].[tblDiem]
           ([nguoitao]
           ,[nguoicapnhat]
           ,[malophoc]
           ,[masinhvien]
           ,[lanhoc]
           ,[diemthilan1]
           ,[diemthilan2])
     VALUES
           ('admin'           -- ngaycapnhat, datetime
           ,'admin'            -- nguoicapnhat, varchar(30)
           ,1               -- malophoc, bigint
           ,'19SV1101'            -- masinhvien, varchar(50)
           ,1                  -- lanhoc, int
           ,8.5                -- diemthilan1, float
           ,7.0)    
GO


