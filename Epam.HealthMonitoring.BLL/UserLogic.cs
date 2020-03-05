using Epam.HealthMonitoring.BLL.Interfaces;
using Epam.HealthMonitoring.DAL.Interfaces;
using Epam.HealthMonitoring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao __userDao;
        public UserLogic(IUserDao userDao)
        {
            __userDao = userDao;
        }

        public User AddUser(User user)
        {
            return __userDao.AddUser(user);
        }
        public void AddBloodPressure(int topNumber, int lowerNumber, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void AddComplaintToList(string textOfComplaint, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void AddMedicineToList(string nameMedicine, DateTime medicationStartDate, DateTime medicationFinishDate, string methodForTheUse)
        {
            throw new NotImplementedException();
        }

        public void AddPulse(int pulse, DateTime date)
        {
            throw new NotImplementedException();
        }



        public void DeleteComplaintFromList(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveMedicineFromList(string nameMedicine)
        {
            throw new NotImplementedException();
        }
    }
}
