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
    public class AddRating
    {
        public int userRatingID { get; set; }
        public string UserID { get; set; }
        public string CompetencyID { get; set; }
        public string  RatingID{ get; set; }
    }

}