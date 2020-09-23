using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using WebApiDemo.Utility;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //State Less
    public class PatientDataController : ControllerBase
    {
        Repository.IPatientDataRepository _patientDataRepository;
        IServiceProvider _provider;
        public PatientDataController(Repository.IPatientDataRepository repo,IServiceProvider provider)
        {
            this._patientDataRepository = repo;
            this._provider = provider;
            
        }
        // GET: api/<PatientDataController>
        [HttpGet("all")]
        public IEnumerable<Models.PatientDataModel> Get()
        {
           
            return _patientDataRepository.GetAllPatients(GetTrsanctionObjectFromContainer());
        }

        // GET api/<PatientDataController>/5
        [HttpGet("get/{mrn}")]
        public Models.PatientDataModel Get(string  mrn)
        {
            var patients = _patientDataRepository.GetAllPatients(GetTrsanctionObjectFromContainer());
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
        [HttpPost("new")]
        public void Post([FromBody] Models.PatientDataModel value)
        {
            _patientDataRepository.AddNewPatient(value, GetTrsanctionObjectFromContainer());
        }

        // PUT api/<PatientDataController>/5
        [HttpPut("update/{mrn}")]
        public void Put(string mrn, [FromBody] Models.PatientDataModel value)
        {
            _patientDataRepository.UpdatePatientInfo(mrn, value, GetTrsanctionObjectFromContainer());
        }

        // DELETE api/<PatientDataController>/5
        [HttpDelete("remove/{mrn}")]
        public void Delete(string mrn)
        {
            _patientDataRepository.Remove(mrn, GetTrsanctionObjectFromContainer());
        }

        ITransactionManager GetTrsanctionObjectFromContainer()
        {
            return this._provider.GetService<ITransactionManager>();
        }
    }
}
