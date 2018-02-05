using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security.AntiXss;
using CompetencyFrameworkWebsite.Models;

namespace CompetencyFrameworkWebsite.Controllers
{
    public class JobController : Controller
    {
        public ActionResult CreateAUserIndex(string technologyName)
        {
            ApiAccess apiAccess = new ApiAccess();
            ViewBag.job = apiAccess.GetAllJobDetails(technologyName);
            return View();
        }


        [HttpPost]
        public ActionResult SaveRecord(FormCollection formCollection)
        {
            var model = new JobModel();
            model.CreateUsers = new List<CreateUser>();
            AddUser addUser= new AddUser();

           
            var userFirstName = Request.Form.Get("FirstName");
            var userLastName = Request.Form.Get("LastName");
            var userEmail = Request.Form.Get("EmailAddress");
            var userJobTitles = Request.Form.Get("JobTitles");
            
              addUser.addUsers(userFirstName,userLastName, userEmail, userJobTitles); 

            
            return View();

        }


    }
}