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
    public class AdminDao : IAdminDao
    {
        private string _connectionString = "";

        public Admin AddAdmin(Admin admin)
        {
            return admin;
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            var admins = new List<Admin>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Name], [Surname] FROM[HealthMonitoring].[dbo].[Admins]";

                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    admins.Add(new Admin
                    {
                        AdminID = (int)reader["Id"],
                        AdminName = reader["Name"] as string,
                        AdminSurname = reader["Surname"] as string,

                    });
                }
            }
            return admins;
        }

        public void DeleteAdmin(int id)
        {

        }

        public void DeleteUser(int id)
        {

        }
        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [IdUser], [UserName], [UserSurname], [DateOfBirth] FROM[HealthMonitoring].[dbo].[User]";

                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserID = (int)reader["IdUser"],
                        UserName = reader["UserName"] as string,
                        UserSurname = reader["UserSurname"] as string,
                        UserDateOfBirth = (DateTime)reader["DateOfBirth"],

                    });
                }
            }
            return users;
        }
    }
}
