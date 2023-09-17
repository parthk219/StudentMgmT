CREATE   PROCEDURE DeleteStudent  
    @Mobile NVARCHAR(15)  
AS  
BEGIN  
    DELETE FROM StudentTable  
    WHERE mob = @Mobile;  
END;