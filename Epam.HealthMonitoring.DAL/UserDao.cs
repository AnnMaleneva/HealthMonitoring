using Epam.HealthMonitoring.DAL.Interfaces;
using Epam.HealthMonitoring.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using Epam.HealthMonitoring.Logger;

namespace Epam.HealthMonitoring.DAL
{
    public class UserDao : IUserDao
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserDao));
        private string _connectionString = @"Data Source=EVILLITTLEPONY\SQLEXPRESS;Initial Catalog=HealthMonitoring;Integrated Security=True";
        public User AddUser(User user)
        {
               using (SqlConnection connection = new SqlConnection(_connectionString))
               { 
                    var command = connection.CreateCommand();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "dbo.AddUser";

                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@UserSurname", user.UserSurname);
                    command.Parameters.AddWithValue("@DateOfBirth", user.UserDateOfBirth);
                    command.Parameters.AddWithValue("@Login", user.UserLogin);
                    command.Parameters.AddWithValue("@Password", user.UserPassword);
                    command.Parameters.AddWithValue("@Role", "User");

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                                               
                    }
                    catch (Exception ex)
                    {
                         log.Error(ex.Message);
                         throw ex;
                    }
                    log.Info("Success");
               }
            return user;
                                                             
        }

        public User GetUser(string login)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "dbo.GetUser";

                try
                {
                    connection.Open();

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user = new User
                        {
                            UserID = (int)reader["IdUser"],
                            UserName = reader["UserName"] as string,
                            UserSurname = reader["UserSurname"] as string,
                            Role = reader["Role"] as string

                        };
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw ex;
                }
                log.Info("Success");
            }
            return user;
        }

        public void AddPulse(int pulse, DateTime Date, int userId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddPulse";

                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Pulse", pulse);
                command.Parameters.AddWithValue("@Date", Date);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw ex;
                }
                log.Info("Success");
            }


        }

        public void AddBloodPressure (int TopNumber, int LowerNumber, DateTime Date, int UserId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddPressure";

                command.Parameters.AddWithValue("@UserId", UserId);
                command.Parameters.AddWithValue("@TopNumber", TopNumber);
                command.Parameters.AddWithValue("@LowerNumber", LowerNumber);
                command.Parameters.AddWithValue("@Date", Date);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw ex;
                }
                log.Info("Success");
            }
        }

        public void AddMedicineToList(string nameMedicine, DateTime medicationStartDate, DateTime medicationFinishDate, string methodForTheUse)
        {

        }

        public void RemoveMedicineFromList (string nameMedicine)
        {

        }

        public void AddComplaintToList (string textOfComplaint, DateTime date)
        {

        }

        public void DeleteComplaintFromList (int id) 
        {

        }

    }
}
