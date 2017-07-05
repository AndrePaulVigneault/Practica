using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
        private ExamContext db_context = new ExamContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAuthors() {
            return Json(db_context.Authors.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}