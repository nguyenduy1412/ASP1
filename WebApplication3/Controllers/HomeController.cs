using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        static List<Models.StudentInfo> lst = new List<Models.StudentInfo>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(int id)
        {
            ViewBag.Message = "Your application description page."+id;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {

            return View();
        }
        public ActionResult Login()
        {
            var listRole =new List<dynamic>();
            listRole.Add(new { id = 1, name = "Quản trị" });
            listRole.Add(new { id = 2, name = "người dùng" });
            ViewBag.Roles=new SelectList(listRole, "id", "name"); // danh sách value member - display member
            return View();
        }
        public ActionResult TetsModel()
        {
            var obj=new Models.StudentInfo
                {
                Id="123",
                Name="Nguyen Ngoc Duy",
                Mark="7"
            };
            
            return View(obj);
        }
        public ActionResult TestListModel()
        {
            
            return View(lst);
        }
        public ActionResult Create() 
            {
                return View();
            }
        public ActionResult Edit(string Id)
        {
            var obj=lst.FirstOrDefault(x => x.Id==Id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Login(string Taikhoan)
        {
            Session["User"] =Taikhoan;
            return RedirectToAction("TestListModel");
        }
    }
}