using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
//using Students.Models;
using System.Web.Services;
using Students.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Students.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()

        {

            return View();

        }

        public JsonResult getrecord()
        {
            DisplayTable ta = new DisplayTable();
            DataTable dtG = new DataTable();
            List<DisplayTable> lst = new List<DisplayTable>();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT * FROM [Students].[dbo].[StudentsDetails]";
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtG);

                    foreach (DataRow row in dtG.Rows)
                    {
                        var details = new DisplayTable();
                        details.Photo = Convert.ToString(row["Photo"]);
                        details.StudentId = Convert.ToInt32(row["StudentID"]);
                        details.FirstName = Convert.ToString(row["FirstName"]);
                        details.LastName = Convert.ToString(row["LastName"]);
                        details.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
                        details.CountryOfBirth = Convert.ToString(row["CountryOfBirth"]);
                        details.Gender = Convert.ToString(row["Gender"]);
                        details.Grade = Convert.ToString(row["Grade"]);
                        details.QuestionnaireStatus = Convert.ToString(row["QuestionnaireStatus"]);
                        details.PersonalPlanStatus = Convert.ToString(row["PersonalPlanStatus"]);
                        details.StudentStatus = Convert.ToString(row["StudentStatus"]);
                        details.StudentType = Convert.ToString(row["StudentType"]);
                        details.OldStudentId = Convert.ToInt32(row["OldStudentId"]);

                        lst.Add(details);

                    }
                    con.Close();
                }
            }
            return Json(lst, JsonRequestBehavior.AllowGet);


        }              

    }
}



