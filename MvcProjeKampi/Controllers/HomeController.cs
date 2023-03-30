using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        ImagesProjectFileManager ifm = new ImagesProjectFileManager(new EfImagesProjectFileDal());
        public ActionResult Index() // listeleme işlemleri için kullanılır.
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

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

        [AllowAnonymous]
        public ActionResult HomePage()
        {
            var files = ifm.GetList();
            return View(files);
        }

    }
}