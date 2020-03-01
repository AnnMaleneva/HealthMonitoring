using Epam.HealthMonitoring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.DAL
{
    public class UserDao
    {
        public User AddUser(User user)
        {
            return user;
        }

        public void AddPulse(int pulse)
        {

        }

        public void AddBloodPressure (int topNumber, int lowerNumber)
        {

        }

        public void AddMedicineToList(string nameMedicine, int daysOfTaking)
        {

        }

        public void RemoveMedicineFromList (string nameMedicine)
        {

        }

        public void AddComplaintToList (string text)
        {

        }

        public void DeleteComplaintFromList () //пока не знаю как правильно удалить по ID или по самой записи 
        {

        }

    }
}
