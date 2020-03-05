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
        private string _connectionString = "Data Source=.;Initial Catalog=HealthMonitoring;Integrated Security=True";
        public User AddUser(User user)
        {
            return user;
        }

        //public User GetByIdUserLoginAndPassword(int id) юзер получает собственные логин и пароль
        //{

        //}

        
        public void AddPulse(int pulse, DateTime date)
        {

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
