using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientDataController : ControllerBase
    {
        Repository.IPatientDataRepository _patientDataRepository;

        public PatientDataController(Repository.IPatientDataRepository repo)
        {
            this._patientDataRepository = repo;
        }
        // GET: api/<PatientDataController>
        [HttpGet]
        public IEnumerable<Models.PatientDataModel> Get()
        {
            return _patientDataRepository.GetAllPatients();
        }

        // GET api/<PatientDataController>/5
        [HttpGet("{mrn}")]
        public Models.PatientDataModel Get(string  mrn)
        {
            var patients = _patientDataRepository.GetAllPatients();
            foreach(var patient in patients)
            {
                if (patient.MRN == mrn)
                {
                    return patient;
                }
            }
            return null;
        }

        // POST api/<PatientDataController>
        [HttpPost]
        public void Post([FromBody] Models.PatientDataModel value)
        {
            _patientDataRepository.AddNewPatient(value);
        }

        // PUT api/<PatientDataController>/5
        [HttpPut("{mrn}")]
        public void Put(string mrn, [FromBody] Models.PatientDataModel value)
        {
            _patientDataRepository.UpdatePatientInfo(mrn, value);
        }

        // DELETE api/<PatientDataController>/5
        [HttpDelete("{mrn}")]
        public void Delete(string mrn)
        {
            _patientDataRepository.Remove(mrn);
        }
    }
}
