using Epam.HealthMonitoring.BLL;
using Epam.HealthMonitoring.BLL.Interfaces;
using Epam.HealthMonitoring.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace HealthMonitoring.Models
{
    public class AppRoleProvider : RoleProvider
    {
        private static IUserLogic _userLogic;

        public AppRoleProvider()
        {
            _userLogic = HealthMonitoringIoc.UserLogic;
        }

        
        public override bool IsUserInRole(string username, string roleName) //проверка только на админа
        {
            var user = _userLogic.GetUser(username); 
            return user.Role == "Admin" || roleName == "Admin";
        }

        public override string[] GetRolesForUser(string username) //заглушка, сам метод не использую
        {
            if (username == "Admin")
                return new string[] { "Admin" };
            else
                return new string[] { };
        }

        #region Notimplemented
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }



        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }



        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}