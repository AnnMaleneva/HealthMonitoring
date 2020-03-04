using Epam.HealthMonitoring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.DAL.Interfaces
{
    public interface IAdminDao
    {
        Admin AddAdmin(Admin admin);

        IEnumerable<Admin> GetAllAdmins();

        void DeleteAdmin(int id);

        void DeleteUser(int id);

        IEnumerable<User> GetAllUsers();


    }
}
