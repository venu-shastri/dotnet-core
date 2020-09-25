using CoreWebApi.Models;
using System.Collections.Generic;

namespace CoreWebApi.Repository
{
    public interface IUserDataRepository
    {
        void AddNewUser(UserModel newUser);
        IEnumerable<UserModel> GetAllUsers();
    }
}