CREATE   PROCEDURE UpdateData    
    @Mob NVARCHAR(15),    
    @Name NVARCHAR(100),    
    @Email NVARCHAR(100),    
    @DOB NVARCHAR(10)  ,  
 @rid INT  
AS    
BEGIN    
    UPDATE StudentTable    
    SET    
        name = @Name,    
        email = @Email,    
        dob = @DOB,  
   mob = @Mob    
    WHERE    
        Id = @rid;    
END;