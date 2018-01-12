using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompetencyFrameworkWebsite.Models;

namespace CompetencyFrameworkWebsite.Controllers
{
    public class CreateAUserController : Controller
    {
     
        [HttpGet]
        public ActionResult CreateAUserIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAUserIndex(UserModel model)
        {
            ApiAccess apiAccess = new ApiAccess();
            return View();
        }



    }
}