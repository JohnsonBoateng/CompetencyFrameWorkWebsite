using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CompetencyFrameworkWebsite
{
    public class AddUser
    {

        public void addUsers(string userFirstName, string userLastName, string userEmail, string userJobTitles)
        {
            //var addUserData = new List<CreateUser>();

            //string connectionString = ConfigurationManager.ConnectionStrings["apiDatabase"].ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["apiDatabase"].ToString();
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CreateNewUser";
                    command.Connection = connection;

                    SqlParameter firstName = new SqlParameter();
                    firstName.ParameterName = "FirstName";
                    firstName.Value = userFirstName;
                    command.Parameters.Add(firstName);

                    SqlParameter lastName = new SqlParameter();
                    lastName.ParameterName = "LastName";
                    lastName.Value = userLastName;
                    command.Parameters.Add(lastName);

                    SqlParameter email = new SqlParameter();
                    email.ParameterName = "EmailAddress";
                    email.Value = userEmail;
                    command.Parameters.Add(email);

                    SqlParameter jobTitle = new SqlParameter();
                    jobTitle.ParameterName = "JobTitleID";
                    jobTitle.Value = userJobTitles;
                    int iDConvert = int.Parse(userJobTitles);
                    command.Parameters.AddWithValue("JobTitleID",iDConvert);




                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
