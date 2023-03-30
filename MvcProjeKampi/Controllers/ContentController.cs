using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        // Yazılar kısmına arama kutucuğu ekledim
        public ActionResult GetAllContent(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var values = cm.GetList(p);
                return View(values);
            }
            return View(cm.GetAllValue()); // p boş gelirse tüm yazıları dönsün
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }

    }
}