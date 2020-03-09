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
    public class AdminDao : IAdminDao
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(AdminDao));
        private string _connectionString = @"Data Source=EVILLITTLEPONY\SQLEXPRESS;Initial Catalog=HealthMonitoring;Integrated Security=True";

        public Admin AddAdmin(Admin admin)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddUser";

                command.Parameters.AddWithValue("@UserName", admin.AdminName);
                command.Parameters.AddWithValue("@UserSurname", admin.AdminSurname);
                command.Parameters.AddWithValue("@DateOfBirth", admin.AdminDateOfBirth);
                command.Parameters.AddWithValue("@Login", admin.AdminLogin);
                command.Parameters.AddWithValue("@Password", admin.AdminPassword);
                command.Parameters.AddWithValue("@Role", "Admin"); //какой метод вызывается AddUser или AddAdmin, такая роль и присваивается

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
            return admin;
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            var admins = new List<Admin>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "dbo.GetAllAdmins";
                try
                {
                    connection.Open();

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        admins.Add(new Admin
                        {
                            AdminName = reader["UserName"] as string,
                            AdminSurname = reader["UserSurname"] as string,

                        });
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw ex;
                }
                log.Info("Success");
            }
            return admins;
        }

        public void DeleteAdmin(int id)
        {

        }

        public void DeleteUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "dbo.DeleteUser";

                command.Parameters.AddWithValue("Id", id);

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

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [IdUser], [UserName], [UserSurname], [DateOfBirth] FROM[HealthMonitoring].[dbo].[Users]";
                try
                {
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
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    throw ex;
                }
                log.Info("Success");
                }
            return users;
        }
    }
}
