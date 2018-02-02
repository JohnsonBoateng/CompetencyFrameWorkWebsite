using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompetencyFrameworkWebsite.Models
{
    public class ResultsModel
    {

        public List<Competency> Results;
        public List<string> TopicsName;
        public List<string> Rating;
        public List<UserRatingData> RatingID;
        public List<AddRating> AddUserRating;
        public List<GetUserRating> UserSelection;
    }

}
