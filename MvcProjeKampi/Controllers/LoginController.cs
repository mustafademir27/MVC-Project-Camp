using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //ContentManager cm = new ContentManager(new EfContentDal());
        WriterLoginManager wm = new WriterLoginManager(new EfWriterDal());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserinfo = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            //if (adminuserinfo.AdminUserName != p.AdminUserName || adminuserinfo.AdminPassword != p.AdminPassword)
            //{ // pop up ile hata mesajı göstermeye çalışıyorum.
            //    //MessageBox.Show("Şifre veya kullanıcı adını hatalı girdiniz.");
            //    Console.WriteLine("Şifre veya kullanıcı adını hatalı girdiniz.");
            //    return error
            //}
            if (adminuserinfo != null)
            {
                // Aşağıdaki 2 satır kod ile kullanıcıya yetkilendirme veriyoruz.
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName, false);
                Session["AdminUserName"] = adminuserinfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            // Bu yapmak solidi ezdiği için yapıyı mimariye taşıyorum.
            //Context c = new Context();
            //var writeruserinfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword== p.WriterPassword);
            var writeruserinfo = wm.GetWriter(p.WriterMail, p.WriterPassword); // bu kodu yazarak solide taşıyorum.
            if (writeruserinfo != null)
            {
                // Aşağıdaki 2 satır kod ile kullanıcıya yetkilendirme veriyoruz.
                FormsAuthentication.SetAuthCookie(writeruserinfo.WriterMail, false);
                Session["WriterMail"] = writeruserinfo.WriterMail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Headings", "Default");
        }


    }
}