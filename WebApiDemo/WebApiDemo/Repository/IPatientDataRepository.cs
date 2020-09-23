using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Utility;

namespace WebApiDemo.Repository
{
   public  interface IPatientDataRepository
    {
        IEnumerable<Models.PatientDataModel> GetAllPatients(ITransactionManager manager);
        void AddNewPatient(Models.PatientDataModel newState,ITransactionManager manager);
        void UpdatePatientInfo(string mrn ,Models.PatientDataModel state,ITransactionManager manager);
        void Remove(string mrn,ITransactionManager manager);
    }
}
