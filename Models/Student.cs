using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMGMT.Models
{
    public class Student
    {

        public int rid { get; set; }
        public string name { get; set; }
        public string mob { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
    }
}


//CREATE TABLE[dbo].[StudentTable] (

//   [Id]    INT IDENTITY(1,1) PRIMARY KEY,

//   [name]  VARCHAR (50) NOT NULL,

//   [mob]   VARCHAR (50) NULL,
//    [email] VARCHAR (50) NULL,
//    [dob]   VARCHAR (50) NULL
//);

