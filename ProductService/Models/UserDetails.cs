using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string Addr { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
