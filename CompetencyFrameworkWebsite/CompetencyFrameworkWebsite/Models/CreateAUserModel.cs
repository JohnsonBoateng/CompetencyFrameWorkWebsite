﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompetencyFrameworkWebsite.Controllers;

namespace CompetencyFrameworkWebsite.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int JobTitleId { get; set; }
    }
}
