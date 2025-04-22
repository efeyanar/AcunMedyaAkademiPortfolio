using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult StatisticList()
        {
            ViewBag.categorysayisi = db.TblCategory.Count();
            ViewBag.projesayisi = db.TblProject.Count();
            ViewBag.mesajsayisi = db.TblContact.Count();
            ViewBag.hizmetsayisi = db.TblService.Count();
            ViewBag.testimonialsayisi = db.TblTestimonial.Count();
            ViewBag.aboutsayisi = db.TblAbout.Count();
            return View();
        }
    }
}