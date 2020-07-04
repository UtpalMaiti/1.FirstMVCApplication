using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Welcome to ASP.NET MVC";
        //}

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginInfo loginInfo)
        {
            if (ModelState.IsValid)
            {
                SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS;database=EmployeeDB;integrated security=true");
                string query = "select count(*) from LoginInfo where UserName=@uName and Password=@pwd";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@uName", loginInfo.UserName));
                cmd.Parameters.Add(new SqlParameter("@pwd", loginInfo.PassWord));
                conn.Open();
                int noOfUsers = (int)cmd.ExecuteScalar();
                conn.Close();
                if (noOfUsers > 0)
                {
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.AddModelError("InvalidLogIn", "Invalid UserName or Password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult Index2(LoginInfo loginInfo)
        {
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection(@"server=.\SQLEXPRESS;database=EmployeeDB;integrated security=true");
                string query = "SELECT COUNT(*) FROM LOGININFIO WHERE UserName=@uname and Password=@pwd";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@uName", loginInfo.UserName));
                cmd.Parameters.Add(new SqlParameter("@pwd", loginInfo.PassWord));
                con.Open();
                int noOfUsers = (int)cmd.ExecuteScalar();
                con.Close();
                if (noOfUsers>0)
                {
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.AddModelError("InvalidLogIn", "Invalid UserName and Password");
                    return View();
                }



            }


            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public string Register()
        {
            return "Welcome to Register Method";
        }

        public int Test()
        {
            return 100;
        }
    }
}