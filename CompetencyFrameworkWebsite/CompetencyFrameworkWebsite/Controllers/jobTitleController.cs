using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetencyFrameworkWebsite.Controllers
{
    public class JobTitleController : Controller
    {
        // GET: jobTitle
        public ActionResult JobTitleIndex(string technologyName)
        {

            ApiAccess apiAccess = new ApiAccess();
            ViewBag.job = apiAccess.GetAllJobTitle(technologyName);

            return View();
           
        }
    }
}