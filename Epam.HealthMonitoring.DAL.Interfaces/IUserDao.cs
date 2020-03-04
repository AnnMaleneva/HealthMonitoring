using Epam.HealthMonitoring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.DAL.Interfaces
{
    public interface IUserDao
    {
        User AddUser(User user);

        void AddPulse(int pulse, DateTime date);

        void AddBloodPressure(int topNumber, int lowerNumber, DateTime date);

        void AddMedicineToList(string nameMedicine, DateTime medicationStartDate, DateTime medicationFinishDate, string methodForTheUse);

        void RemoveMedicineFromList(string nameMedicine);

        void AddComplaintToList(string textOfComplaint, DateTime date);

        void DeleteComplaintFromList(int id);
    }
}
