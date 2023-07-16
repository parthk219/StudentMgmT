USE [Student]
GO

/****** Object:  StoredProcedure [dbo].[UpdateData]    Script Date: 17-07-2023 01:40:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE   PROCEDURE [dbo].[UpdateData]
	-- Add the parameters for the stored procedure here
	@id int,
	@name varchar(50),
	@mob varchar(50),
	@email varchar(50),
	@dob varchar(50)
AS
BEGIN
	update Student set name=@name,mob=@mob where id=@id;
	
	END
GO


