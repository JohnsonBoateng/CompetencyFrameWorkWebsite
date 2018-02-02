using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompetencyFrameworkWebsite.Models;
using System.Configuration;
using System.Data.SqlClient;

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
            model.RatingID = new List<UserRatingData>();
            model.TopicsName = new List<string>();
            model.Rating = new List<string>();
         

            model.Results = apiAccess.GetAllResults(technology, jobTitles);
            model.TopicsName = apiAccess.GetAllTopics();
            model.RatingID = apiAccess.GetAllUserRating();


            return View(model);

        }



        [HttpPost]
        public ActionResult SaveUserData(FormCollection formCollection)
        {

            var model = new ResultsModel();
            model.AddUserRating = new List<AddRating>();
            dataAcess dataAcess = new dataAcess();

            var competencyID = Request.Form.GetValues("CompetencyID");
            var userRating = Request.Form.GetValues("userRating");
            int upper = competencyID.GetUpperBound(0);

            for (int i = 0; i <= upper; i++)
            {
                dataAcess.AddUserRating(competencyID[i], userRating[i]);
            }


            if (ValidateRequest == true)
            {
                RedirectToAction("SaveUserData");
            }

            return View();

        }


        [HttpPost]
        public ActionResult ViewSelection()
        {
            ApiAccess apiAccess = new ApiAccess();
            var model = new ResultsModel();
            
            model.UserSelection = new List<GetUserRating>();
            model.UserSelection = apiAccess.GetAllUserInput(3);

            return View(model);

        }
    }

}