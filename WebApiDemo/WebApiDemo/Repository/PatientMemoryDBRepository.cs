using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Repository
{
    public class PatientMemoryDBRepository : IPatientDataRepository
    {
         List<Models.PatientDataModel> _db = new List<PatientDataModel>();

        public PatientMemoryDBRepository()
        {
            _db.Add(new PatientDataModel {  
                MRN="MRN001", 
                Name="Tom",
                Age=36, 
                ContactNumber="1234567890",
                Address=new AddressDataModel {
                    City="BLR", 
                    State="KA",
                    Pincode="560077",
                    Street="abc"
                }
            }
            );
            _db.Add(new PatientDataModel
            {
                MRN = "MRN002",
                Name = "Hary",
                Age = 37,
                ContactNumber = "134567890",
                Address = new AddressDataModel
                {
                    City = "CHN",
                    State = "TN",
                    Pincode = "56007",
                    Street = "xyz"
                }
            }
            );
        } 
        public void AddNewPatient(PatientDataModel newState)
        {
            _db.Add(newState);
        }

        public IEnumerable<PatientDataModel> GetAllPatients()
        {
            return _db;
        }

        public void Remove(string mrn)
        {
           for(int i = 0; i < _db.Count; i++)
            {
                if (_db[i].MRN == mrn)
                {
                    _db.Remove(_db[i]);
                    return;
                }
            }
        }

        public void UpdatePatientInfo(string mrn, PatientDataModel state)
        {

            for (int i = 0; i < _db.Count; i++)
            {
                if (_db[i].MRN == mrn)
                {
                    _db.Insert(i, state);
                    return;
                }
            }
        }
    }
}
