using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        public ProductDbContext _context;
        public UserRepository(ProductDbContext context)
        {
            _context = context;
        }
        public void AddUser(UserDetails user)
        {
            _context.UserDetails.Add(user);
            _context.SaveChanges();
        }

        public UserDetails ViewUser(int userId)
        {
            return _context.UserDetails.Find(userId);
        }

        public UserDetails Login(string uname, string pwd)
        {
            return _context.UserDetails.SingleOrDefault(e => e.Username == uname && e.Pwd == pwd);
        }
        public void UpdateUser(UserDetails user)
        {
            _context.UserDetails.Update(user);
            _context.SaveChanges();
        }
    }
}
