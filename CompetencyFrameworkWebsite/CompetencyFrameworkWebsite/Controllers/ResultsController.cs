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
        public ActionResult ResultsIndex(string technology, string jobTitles)
        {
           
            ApiAccess apiAccess = new ApiAccess();
            var model = new ResultsModel();
           
            model.Results = new List<Competency>();
            model.TopicsName = new List<string>();
            model.Results = apiAccess.GetAllResults(technology, jobTitles);
            model.TopicsName = apiAccess.GetAllTopics();


            return View(model);

        }
    }
}