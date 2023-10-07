using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    //viết thêm phần quản lý đăng nhập
  /*  [Authorize]*/
    public class StudentController : Controller
    {
        

        public static List<Models.StudentInfo> lst=new List<Models.StudentInfo>();
        // GET: Student
      /*  [AllowAnonymous]*/
        public ActionResult Index()
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item.Name);
            }
            return View(lst);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.StudentInfo obj)
        {
            obj.Id="1";
            var fAvatar = Request.Files["fAvatar"];
            if(fAvatar != null)
            {
                // nếu có file được chọn => upload len server
                string fileName = fAvatar.FileName;// tự sinh tên file
                /* string fileName = DateTime.Now.ToString("yyyy/MM/dd");*/
                string folderPath=Server.MapPath("~/Asset/upload/"+fileName);
                fAvatar.SaveAs(folderPath);
                obj.Avatar="/Asset/upload/" + fileName;
            }
            lst.Add(obj);
           
             return RedirectToAction("Index");
          /*  return View();*/
        }
    }
}