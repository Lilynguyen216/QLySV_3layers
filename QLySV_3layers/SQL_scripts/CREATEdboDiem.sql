USE [QLySV]
GO

/****** Object:  Table [dbo].[tblDiem]    Script Date: 10/1/2024 1:59:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDiem](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](30) NULL,
	[malophoc] [bigint] NOT NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[lanhoc] [int] NULL,
	[diemthilan1] [float] NULL,
	[diemthilan2] [float] NULL,
 CONSTRAINT [PK_tblDiem] PRIMARY KEY CLUSTERED 
(
	[malophoc] ASC,
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO

ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO

ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO

ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO

ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_lanhoc]  DEFAULT ((1)) FOR [lanhoc]
GO

ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemthilan1]  DEFAULT ((0)) FOR [diemthilan1]
GO

ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemthilan2]  DEFAULT ((0)) FOR [diemthilan2]
GO

ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblLopHoc] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblLopHoc] ([malophoc])
GO

ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblLopHoc]
GO

ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblSinhVien1] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[tblSinhVien] ([masinhvien])
GO

ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblSinhVien1]
GO


