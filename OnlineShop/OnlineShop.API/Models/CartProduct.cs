using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Models
{
    public class CartProduct
    {
        public int Id { get; set; }
        [ForeignKey("Product")] 
        public int ProductId { get; set; }

        public Product Product { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
