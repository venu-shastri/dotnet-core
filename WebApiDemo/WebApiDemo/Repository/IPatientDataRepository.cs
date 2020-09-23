using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Repository
{
   public  interface IPatientDataRepository
    {
        IEnumerable<Models.PatientDataModel> GetAllPatients();
        void AddNewPatient(Models.PatientDataModel newState);
        void UpdatePatientInfo(string mrn ,Models.PatientDataModel state);
        void Remove(string mrn);
    }
}
