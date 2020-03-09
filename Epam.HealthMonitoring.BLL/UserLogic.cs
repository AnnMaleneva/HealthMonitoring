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
        private IUserDao _userDao;
        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public User AddUser(User user)
        {
            return _userDao.AddUser(user);
        }

        public User GetUser(string login)
        {
            return _userDao.GetUser(login);
        }
        public void AddBloodPressure(int topNumber, int lowerNumber, DateTime date, int userId)
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

        public void AddPulse(int pulse, DateTime date, int userId)
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
