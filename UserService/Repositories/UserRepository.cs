using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        public ProductDbContext productDbContext;
        public UserRepository(ProductDbContext productDbContext)
        {
            this.productDbContext = productDbContext;
        }
        public void AddUser(UserDetails userDetails)
        {
            productDbContext.UserDetails.Add(userDetails);
            productDbContext.SaveChanges();
        }

        public UserDetails ViewUser(int userId)
        {
            return productDbContext.UserDetails.Find(userId);
        }

        public UserDetails Login(string username, string password)
        {
            return productDbContext.UserDetails.SingleOrDefault(e => e.Username == username && e.Pwd == password);
        }
        public void UpdateUser(UserDetails userDetails)
        {
            productDbContext.UserDetails.Update(userDetails);
            productDbContext.SaveChanges();
        }
    }
}
