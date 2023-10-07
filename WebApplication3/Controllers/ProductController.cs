using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        public static List<Models.Product> lst = new List<Models.Product>();
        // GET: Product
        public ActionResult Index()
        {
            return View(lst);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Product obj)
        {
            
            if (obj.Sale == 0)
            {
                obj.PriceSale=obj.Price;
            }
            else
            {
                obj.PriceSale=obj.Price - obj.Price * obj.Sale /100;
            }
            
            var fAvatar = Request.Files["fImage"];
            if (fAvatar != null)
            {
                // nếu có file được chọn => upload len server
                string fileName = fAvatar.FileName;// tự sinh tên file
                /* string fileName = DateTime.Now.ToString("yyyy/MM/dd");*/
                string folderPath = Server.MapPath("~/Asset/upload/"+fileName);
                fAvatar.SaveAs(folderPath);
                obj.Image="/Asset/upload/" + fileName;
            }
            lst.Add(obj);

            return RedirectToAction("Index");
            /*  return View();*/
        }
    }
}