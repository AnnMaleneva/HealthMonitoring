using Epam.HealthMonitoring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.HealthMonitoring.BLL.Interfaces
{
    public interface IUserLogic
    {
        User AddUser(User user);

        User GetUser(string login);

        void AddPulse(int pulse, DateTime date, int userId);

        void AddBloodPressure(int topNumber, int lowerNumber, DateTime date, int userId);

        void AddMedicineToList(string nameMedicine, DateTime medicationStartDate, DateTime medicationFinishDate, string methodForTheUse);

        void RemoveMedicineFromList(string nameMedicine);

        void AddComplaintToList(string textOfComplaint, DateTime date);

        void DeleteComplaintFromList(int id);
    }
}
