using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;
namespace UserService.Repositories
{
    public interface IUserRepository
    {
        void AddUser(UserDetails user);
        void UpdateUser(UserDetails user);
        UserDetails Login(string uname, string pwd);
        UserDetails ViewUser(int userId);
    }
}
