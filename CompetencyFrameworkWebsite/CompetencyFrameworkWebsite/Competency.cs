using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompetencyFrameworkWebsite
{
    public class Competency
    {
        public string TopicName { get; set; }
        public string AreaName { get; set; }
        public string CompetencyName { get; set; }
        public int CompetencyID { get; set; }
        public string RatingName { get; set; }
        public string RatingTypeName { get; set; }
        public int RatingTypeID { get; set; }
        public int RatingID { get; set; }
    }
}