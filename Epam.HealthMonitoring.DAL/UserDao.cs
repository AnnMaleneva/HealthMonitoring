using Epam.HealthMonitoring.DAL.Interfaces;
using Epam.HealthMonitoring.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.DAL
{
    public class UserDao : IUserDao
    {
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

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
               }
               return user;
                                                   
        }

        //public User GetByIdUserLoginAndPassword(int id) юзер получает собственные логин и пароль
        //{

        //}

        
        public void AddPulse(int pulse, DateTime date)
        {
            //using (SqlConnection connection = new SqlConnection(_connectionString))
            //{

            //    var command = connection.CreateCommand();
            //    command.CommandType = System.Data.CommandType.StoredProcedure;
            //    command.CommandText = "dbo.AddUser";

            //    var nameParameter = new SqlParameter()
            //    {
            //        DbType = System.Data.DbType.String,
            //        ParameterName = "@UserName",
            //        Value = user.UserName,
            //        Direction = System.Data.ParameterDirection.Input,
            //    };

            //    command.Parameters.Add(nameParameter);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}

            
        }

        public void AddBloodPressure (int topNumber, int lowerNumber, DateTime date)
        {

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

        public void DeleteComplaintFromList (int id) //пока не знаю как правильно удалить по ID или по самой записи 
        {

        }

    }
}
