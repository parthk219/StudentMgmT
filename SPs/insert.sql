USE [Student]
GO

/****** Object:  StoredProcedure [dbo].[SelectData]    Script Date: 16-07-2023 23:26:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE or alter  PROCEDURE [dbo].[SelectData]
as begin
select * from [StudentTable];
	-- Add the parameters for the stored procedure here
--	@id int,
--	@name varchar(50),
--	@mob varchar(50),
--	@email varchar(50),
--	@dob varchar(50)
--AS
--BEGIN
--	update Student set name=@name,mob=@mob where id=@id;
	
	END
GO


