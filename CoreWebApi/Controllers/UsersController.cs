using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        Repository.IUserDataRepository _repository;
        public UsersController(Repository.IUserDataRepository repository)
        {
            this._repository = repository;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Models.UserModel> Get()
        {
            return this._repository.GetAllUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{userId}")]
        public Models.UserModel Get(string  userId)
        {
            Models.UserModel user = default(Models.UserModel);
            foreach(Models.UserModel usertemp in _repository.GetAllUsers())
            {
                if (usertemp.Uid == userId)
                {
                    user = usertemp;
                    break;
                }

            }
            return user;
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] Models.UserModel newuser)
        {
            this._repository.AddNewUser(newuser);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{userId}")]
        public void Put(string  userId, [FromBody] Models.UserModel userInfo)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{userId}")]
        public void Delete(string  userId)
        {
        }
    }
}
