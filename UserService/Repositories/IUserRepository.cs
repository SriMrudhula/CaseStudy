using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;
namespace UserService.Repositories
{
    public interface IUserRepository
    {
        void AddUser(UserDetails userDetails);
        void UpdateUser(UserDetails userDetails);
        UserDetails Login(string username, string password);
        UserDetails ViewUser(int userId);
    }
}
