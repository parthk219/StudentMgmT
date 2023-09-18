using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentMGMT.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentMGMT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void InsertRecord(Student ss)
        {
            string msg = "";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("InsertData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", ss.name);
                cmd.Parameters.AddWithValue("@mob", ss.mob);
                cmd.Parameters.AddWithValue("@email", ss.email);
                cmd.Parameters.AddWithValue("@dob", ss.dob);
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                int n = cmd.ExecuteNonQuery();// used to execute a SQL command that modifies the database and returns the number of rows affected by the command.
                con.Close();
                if (n > 0)
                {
                    msg = "Record saved";
                }
                else
                {
                    msg = "record notsaved";
                }
            }
            catch (Exception e)
            {
                msg = "record notsaved";


            }
        }

        public List<Student> GetAllData() // GENERIC COLLECTION
        {
            List<Student> lst = new List<Student>();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SelectData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            if(ConnectionState.Closed==con.State)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lst.Add(new Student
                {
                    rid = dr["Id"].ToString(),
                    name = dr["name"].ToString(),
                    mob = dr["mob"].ToString(),
                    email = dr["email"].ToString(),
                    dob = dr["dob"].ToString(),
                });
            }
            con.Close();
            return lst;
        }



        public ActionResult display()
        {
            return View();
        }

        public JsonResult getStudList()
        {
            //return Json(GetAllData(),JsonRequestBehavior.AllowGet);

                List<Student> students = GetAllData();
                return Json(students);
            

        }

        public void delete(string mobileno)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("DeleteStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@Mobile", SqlDbType.NVarChar, 15));
            cmd.Parameters["@Mobile"].Value = mobileno;
            SqlDataReader dr = cmd.ExecuteReader();



        }

        //public void EditStudent(string mob, string name, string email, string dob)
        //{
        [HttpPost]
        public void EditStudent(string rid,string name, string mob, string email, string dob)
        { 
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateData", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Mob", mob);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@rid", rid);

                    command.ExecuteNonQuery();
                }
            }
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

