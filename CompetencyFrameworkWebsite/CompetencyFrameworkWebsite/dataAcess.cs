using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CompetencyFrameworkWebsite.Models;

namespace CompetencyFrameworkWebsite
{
    public class dataAcess
    {
        public void AddUserRating(string competencyID, string userRating)

        {

            //Avar userInputList = new List<GetUserRating>();


            //var addUserRating = new List<AddRating>();

            string connectionString = ConfigurationManager.ConnectionStrings["apiDatabase"].ToString();
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

               using (var command = new SqlCommand())
                {
                    //command.CommandType = CommandType.StoredProcedure;
                    //command.CommandText = "CollectData";
                    //command.Connection = connection;

                    //SqlParameter getUserID = new SqlParameter();
                    //getUserID.ParameterName = "UserID";
                    //getUserID.Value = "1";
                    //int getID = int.Parse("1");
                    //command.Parameters.AddWithValue("UserID", getID);


                    //SqlParameter getUserRatingID = new SqlParameter();
                    //getUserRatingID.ParameterName = "RateID";
                    //getUserRatingID.Value = userRating;
                    //int getRatingInput = int.Parse(userRating);
                    //command.Parameters.AddWithValue("RateID", getRatingInput);

                    ///////////////////////////////////////////////////////////
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CollectData";
                    command.Connection = connection;


                    SqlParameter userID = new SqlParameter();
                    userID.ParameterName = "UserID";
                    userID.Value = "1";
                    int UserIDInput = int.Parse("3");
                    command.Parameters.AddWithValue("UserID", UserIDInput);

                    SqlParameter competency = new SqlParameter();
                    competency.ParameterName = "CompetencyID";
                    competency.Value = competencyID;
                    int competencyInput = int.Parse(competencyID);
                    command.Parameters.AddWithValue("CompetencyID", competencyInput);

                    SqlParameter UserRatingID = new SqlParameter();
                    UserRatingID.ParameterName = "RateID";
                    UserRatingID.Value = userRating;
                    int ratingInput = int.Parse(userRating);
                    command.Parameters.AddWithValue("RateID", ratingInput);


                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
