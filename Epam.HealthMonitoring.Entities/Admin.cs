using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.Entities
{
    public class Admin
    {
        public int AdminID { get; set; }

        public string AdminName { get; set; }

        public string AdminSurname { get; set; }

        public string AdminLogin { get; set; }

        public DateTime AdminDateOfBirth { get; set; }

        public string AdminPassword { get; set; }

        public string Role { get; set; }
    }
}
