using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            return View();
        }

        public ActionResult Default()
        {
            ViewBag.Title = "Default";
            return View("Index");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            ViewBag.Title = "Admin";
            return View("Index");
        }

        [Authorize(Roles = "Editor")]
        public ActionResult Editor()
        {
            ViewBag.Title = "Editor";
            return View("Index");
        }
        
        [Authorize(Roles = "Editor, Admin")]
        public ActionResult EditorOrAdmin()
        {
            ViewBag.Title = "Editor or Admin";
            return View("Index");
        }

        [Authorize(Roles = "Editor")]
        [Authorize(Roles = "Admin")]
        public ActionResult EditorAndAdmin()
        {
            ViewBag.Title = "Editor and Admin";
            return View("Index");
        }

        [Authorize(Users = "user@lexicon.se")]
        public ActionResult UserIdentity()
        {
            ViewBag.Title = "Editor and Admin";
            return View("Index");
        }

    }
}