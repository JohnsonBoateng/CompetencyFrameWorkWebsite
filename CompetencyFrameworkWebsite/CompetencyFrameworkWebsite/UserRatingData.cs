using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CompetencyFrameworkWebsite
{
    public class UserRatingData
    {
        public int RatingID { get; set; }
        public string RatingName { get; set; }
        public int RatingTypeID { get; set; }
        public string RatingTypeName { get; set; }

    }
}