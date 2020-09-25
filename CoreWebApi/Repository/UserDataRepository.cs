using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Repository
{
    public class UserDataRepository : IUserDataRepository
    {
        List<Models.UserModel> _userModelDb = new List<Models.UserModel>();

        public UserDataRepository()
        {
            _userModelDb.Add(new Models.UserModel { Uid = "u0001", Name = "tom", Email = "tom@tom.com", Password = "tom@123" });
            _userModelDb.Add(new Models.UserModel { Uid = "u0002", Name = "hary", Email = "hary@tom.com", Password = "tom@123" });
            _userModelDb.Add(new Models.UserModel { Uid = "u0003", Name = "jack", Email = "jack@tom.com", Password = "tom@123" });
            _userModelDb.Add(new Models.UserModel { Uid = "u0004", Name = "james", Email = "james@tom.com", Password = "tom@123" });
        }
        public IEnumerable<Models.UserModel> GetAllUsers() { return _userModelDb; }
        public void AddNewUser(Models.UserModel newUser) { _userModelDb.Add(newUser); }
    }
}
