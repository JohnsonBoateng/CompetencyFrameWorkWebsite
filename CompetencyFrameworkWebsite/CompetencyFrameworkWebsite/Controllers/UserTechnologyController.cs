using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompetencyFrameworkWebsite.Models;

namespace CompetencyFrameworkWebsite.Controllers
{
    public class UserTechnologyController : Controller
    {

        //[HttpGet]
        //public ActionResult UserTechnologyIndex()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult UserTechnologyIndex(string technologies)
        {
            ApiAccess apiAccess = new ApiAccess();
            var model = new JobModel();
            model.Jobs = new List<Job>();
            model.Technologies = technologies;
            model.Jobs = apiAccess.GetAllJobDetails(technologies);
            return View("CreateAUserIndex", model);
        }

        [HttpGet]
        public ActionResult UserTechnologyIndex()
        {
            ApiAccess apiAccess = new ApiAccess();
            var model = new TechnologyModel();
            model.Technologies = new List<string>();
            model.Technologies = apiAccess.GetAllTechnologies();

            return View(model);
        }

        //[HttpPost]
        //public ActionResult SaveRecord(FormCollection formCollection)
        //{
        //    var model = new UserModel();
        //    model.CreateUsers = new List<CreateUser>();


        //    var firstName = Request.Form.GetValues("FirstName");
        //    var lastName = Request.Form.GetValues("LastName");
        //    var firstName = Request.Form.GetValues("Email");
        //    //foreach (string key in formCollection.AllKeys)
        //    //{
        //    //    Response.Write("Key = " + key + "    ");
        //    //    Response.Write(formCollection[key]);
        //    //    Response.Write("<br/>");
        //    //}


          //  return View();
       // }

        //[HttpPost]
        //public ActionResult CreateAUserIndex(string technologies)
        //{
        //    ApiAccess apiAccess = new ApiAccess();
        //    var model = new JobModel();
        //    model.Jobs = new List<Job>();
        //    model.Technologies = technologies;
        //    model.Jobs = apiAccess.GetAllJobs(technologies);
        //    return View("CreateAUserIndex", model);
        //}




    }
}