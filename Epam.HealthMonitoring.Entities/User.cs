using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.Entities
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public string UserLogin { get; set; }

        public string UserPassword { get; set; }

        public DateTime UserDateOfBirth { get; set; }

        public int Age => DateTime.Now.Year - UserDateOfBirth.Year;
    }
}
