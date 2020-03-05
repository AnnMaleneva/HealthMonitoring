using Epam.HealthMonitoring.BLL;
using Epam.HealthMonitoring.BLL.Interfaces;
using Epam.HealthMonitoring.DAL;
using Epam.HealthMonitoring.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.Ioc
{
    public static class HealthMonitoringIoc
    {
        public static IUserDao UserDao { get; set; } = new UserDao();

        public static IUserLogic UserLogic { get; set; } = new UserLogic(UserDao);


        public static IAdminDao AdminDao { get; set; } = new AdminDao();

        public static IAdminLogic AdminLogic { get; set; } = new AdminLogic(AdminDao);
    }
}
