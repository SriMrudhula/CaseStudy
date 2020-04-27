using System;
using System.Collections.Generic;

namespace UserService.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string ProductDesc { get; set; }
        public string Img { get; set; }
        public int? UserId { get; set; }

        public virtual UserDetails User { get; set; }
    }
}
