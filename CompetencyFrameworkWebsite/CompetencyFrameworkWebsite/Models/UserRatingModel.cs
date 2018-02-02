using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CompetencyFrameworkWebsite.Models
{
    public class UserRatingModel
    {
        public List<string> Rating;
        public List<int> RatingID;
    }
}