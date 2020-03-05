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
    public class AdminLogic : IAdminLogic
    {
        private IAdminDao _adminDao;

        public AdminLogic(IAdminDao adminDao)
        {
            _adminDao = adminDao;
        }
        public Admin AddAdmin(Admin admin)
        {
            return _adminDao.AddAdmin(admin);
        }

        public void DeleteAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
