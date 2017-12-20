using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompetencyFrameworkWebsite.Models;

namespace CompetencyFrameworkWebsite.Controllers
{
    public class ResultsController : Controller
    {
        // GET: Results
        public ActionResult ResultsIndex(string technologyName, string jobTitleName)
        {

            ApiAccess apiAccess = new ApiAccess();
            ViewBag.results = apiAccess.GetAllResults(technologyName, jobTitleName);

            return View();

        }
    }
}